using LZManager.BLL;
using LZManager.BLL.Common;
using LZManager.Common;
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

namespace LZManager.Query
{
    public partial class QueryCharge : BasePage
    {

        private string serverUrl = ConfigurationManager.AppSettings["ServerUrl"].ToString();
        private LogPaymentManage lpMange = new LogPaymentManage();
        private UserManage umMange = new UserManage();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCharge_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(this.txtPlayerId.Text.Trim()))
            {
                ShowCommonDlg("请输入玩家ID！");
                return;
            }
            if (string.IsNullOrEmpty(this.txtDiamondNum.Text.Trim()))
            {
                ShowCommonDlg("请输入钻石数量！");
                return;
            }
            UsersEO um = umMange.GetUser(GetUserID());
            string srcuid = string.Empty;
            if (um != null)
            {
                srcuid = um.UrGameId;
            }
            string orderNo = PubFuncs.GenerateOrderNumber();
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic["action"] = "IDIP_DO_PAY_CASH_REQ";
            dic["remark"] = orderNo;//this.txtOrderNo.Text.Trim();
            dic["dis_uin"] = this.txtPlayerId.Text.Trim();
            dic["src_uin"] = srcuid;
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
            if (string.IsNullOrEmpty(this.txtDiamondNum.Text.Trim()))
            {
                return;
            }
            if ((Convert.ToInt32(this.txtDiamondNum.Text.Trim()) < 0))
            {
                ShowCommonDlg("请输入正确钻石数量！");
                return;
            }
            int res = (Int32)jo["paystatus"];
            lp.Remarkid = orderNo;
            lp.Areaid = "1";
            lp.Worldid = "1";
            lp.Dstuin = this.txtPlayerId.Text.Trim();
            lp.Roleid = "1";
            lp.Rolename = "niuniu";
            lp.Srcuin = srcuid;
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
                //UsersEO um = umMange.GetUser(GetUserID());
                int subDiamondNum = Convert.ToInt32(this.txtDiamondNum.Text.Trim());
                int resNum = Convert.ToInt32(um.UrDiamondNum) - subDiamondNum;
                int resUpdate = umMange.PutUrDiamondNumByPK(GetUserID(), resNum.ToString());
                if (resUpdate > 0)
                {
                    //this.lblAlert.Text = "充值成功";
                    ShowCommonDlg("充值成功");
                }
                else
                {
                    //this.lblAlert.Text = "充值失败";
                    ShowCommonDlg("充值失败");
                }
            }
            else
            {
                //this.lblAlert.Text = "充值失败";
                ShowCommonDlg("充值失败");
            }

        }

        private bool checkFrom(string msg)
        {
            if (string.IsNullOrEmpty(msg))
            {
                this.lblAlert.Visible = true;
                ShowCommonDlg("请输入相应的查询信息");
                return false;
            }
            else
            {
                this.lblAlert.Visible = false;
                return true;
            }
        }

    }
}