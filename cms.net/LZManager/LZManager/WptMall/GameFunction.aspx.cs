using LZManager.BLL;
using LZManager.DAL;
using LZManager.Utility;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;
using TinyFx.Net.Json;
using TinyFx.Net.Json.Linq;

namespace LZManager.WptMall
{
    public partial class GameFunction : System.Web.UI.Page
    {

        private string serverUrl = ConfigurationManager.AppSettings["ServerUrl"].ToString();

        private LogPaymentManage lpMange = new LogPaymentManage();

        protected void Page_Load(object sender, EventArgs e)
        {
            this.lblDiamondNum.Text = "0";
            this.lblIsDone.Text = "0";
            this.lblTotal.Text = "0";
        }

        protected void btnCharge_Click(object sender, EventArgs e)
        {

            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic["action"] = "IDIP_DO_PAY_CASH_REQ";
            dic["remark"] = this.txtOrderNo.Text.Trim();
            dic["dis_uin"] = this.txtPlayerId.Text.Trim();
            dic["src_uin"] = "10372";
            dic["role_name"] = "niuniu";
            dic["us_source"] = "2";
            dic["amount"] = this.txtDiamondNum.Text.Trim();
            dic["ui_ip"] = Common.PubFuncs.GetIpAddress();
            dic["gameId"] = "hlynzy";
            dic["sz_desc"] = this.txtDesc.Text.Trim();
            string json = new JavaScriptSerializer().Serialize(dic);

            string responseStr = HttpClientUlity.PostJsonData(serverUrl, json);

            JObject jo = (JObject)JsonConvert.DeserializeObject(responseStr);

            LogPaymentEO lp = new LogPaymentEO();
            int res = (Int32)jo["paystatus"];
            lp.Remarkid = this.txtOrderNo.Text.Trim();
            lp.Areaid = "1";
            lp.Worldid = "1";
            lp.Dstuin = this.txtPlayerId.Text.Trim();
            lp.Roleid = "1";
            lp.Rolename = "niuniu";
            lp.Srcuin = "1011";
            lp.Source = "1";
            lp.Amount = this.txtDiamondNum.Text.Trim();
            lp.Uiip = Common.PubFuncs.GetIpAddress();
            lp.Description = this.txtDesc.Text.Trim(); ;

            if (res == 0)
            {
                lp.Paystatus = "0";
            }
            else
            {
                lp.Paystatus = "1";
            }
            lp.Paymsg = "Paymsg";
            lp.CreateTime = DateTime.Now.ToString("yyyy-MM-dd");
            lp.FinishTime = DateTime.Now.ToString("yyyy-MM-dd");
            this.divAlert.Visible = true;
            if (lpMange.addLg(lp) > 0)
            {
                this.lblAlert.Text = "充值成功";
            }
            else
            {
                this.lblAlert.Text = "充值失败";
            }

            
            
        }


        protected void queryTotal_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic["action"] = "IDIP_QUERY_CASH_NUM_REQ";
            dic["uin"] = this.txtChargePlayerId.Text.Trim();
            dic["begin_time"] = this.txtStartTime.Text.Trim();
            dic["end_time"] = this.txtEndTime.Text.Trim();
            string json = new JavaScriptSerializer().Serialize(dic);
            string responseStr = HttpClientUlity.PostJsonData(serverUrl, json);

            JObject jo = (JObject)JsonConvert.DeserializeObject(responseStr);
            this.lblTotal.Text = jo["amount"].ToString();
            //this.divAlert.Visible = true;
            //this.lblAlert.Text = jo["msg"].ToString(); 
        }

        protected void btnOrderNo_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic["action"] = "IDIP_DO_CHECK_PAY_CASH_REQ";
            dic["remark"] = this.txtOrder.Text.Trim();
            string json = new JavaScriptSerializer().Serialize(dic);
            string responseStr = HttpClientUlity.PostJsonData(serverUrl, json);

            this.txtOrder.Text = responseStr;
            JObject jo = (JObject)JsonConvert.DeserializeObject(responseStr);
            this.lblIsDone.Text = jo["msg"].ToString();
            //this.divAlert.Visible = true;
            //this.lblAlert.Text = jo["msg"].ToString(); 
        }

        protected void btn_queryPlayer_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic["action"] = "IDIP_QUERY_CASH_REQ";
            dic["uin"] = this.txtPlayer.Text.Trim();
            string json = new JavaScriptSerializer().Serialize(dic);
            string responseStr = HttpClientUlity.PostJsonData(serverUrl, json);

            //this.txtPlayer.Text = responseStr;
            JObject jo = (JObject)JsonConvert.DeserializeObject(responseStr);
            this.lblDiamondNum.Text = jo["amount"].ToString();
            //this.divAlert.Visible = true;
            //this.lblAlert.Text = jo["msg"].ToString();
        }


        protected void btnModify_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic["action"] = "IDIP_DO_UPDATE_CASH_REQ";
            dic["uin"] = this.txtModifyPlayerId.Text.Trim();
            dic["source"] = "0";
            dic["amount"] = this.txtModifyNum.Text.Trim();
            string json = new JavaScriptSerializer().Serialize(dic);
            string responseStr = HttpClientUlity.PostJsonData(serverUrl, json);

            JObject jo = (JObject)JsonConvert.DeserializeObject(responseStr);
            this.divAlert.Visible = true;
            this.lblAlert.Text = jo["msg"].ToString();
        }


        protected void btnRecord_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic["action"] = "IDIP_DO_CHECK_PAY_LIST_REQ";
            dic["uin"] = this.txtPlayerIdRecored.Text.Trim();
            dic["begin_time"] = this.txtStartTime1.Text.Trim();
            dic["end_time"] = this.txtEndTime1.Text.Trim();
            string json = new JavaScriptSerializer().Serialize(dic);
            string responseStr = HttpClientUlity.PostJsonData(serverUrl, json);

            //JObject jo = (JObject)JsonConvert.DeserializeObject(responseStr);
            //this.divAlert.Visible = true;
            //this.lblAlert.Text = jo["msg"].ToString();

            Response.Redirect("MallTChargeList.aspx");

        }

    }
}