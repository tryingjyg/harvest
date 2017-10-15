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
    public partial class QueryFunction : System.Web.UI.Page
    {

        private string serverUrl = ConfigurationManager.AppSettings["ServerUrl"].ToString();

        protected void Page_Load(object sender, EventArgs e)
        {
            this.lblOnLineNum.Text = "0";
            this.lblTotalNum.Text = "0";

        }

        protected void btnOnLine_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic["action"] = "IDIP_QUERY_CURRENT_ONLINE_NUMBER_REQ";
            string json = new JavaScriptSerializer().Serialize(dic);
            string responseStr = HttpClientUlity.PostJsonData(serverUrl, json);

            JObject jo = (JObject)JsonConvert.DeserializeObject(responseStr);
            //this.txtOnline.Text = responseStr;
            this.lblTotalNum.Text = jo["currentUser"].ToString();
        }

        protected void btnRequestRoomNum_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic["action"] = "IDIP_DO_ROOM_NUM_REQ";
            string json = new JavaScriptSerializer().Serialize(dic);
            string responseStr = HttpClientUlity.PostJsonData(serverUrl, json);

            JObject jo = (JObject)JsonConvert.DeserializeObject(responseStr);
            this.lblTotalNum.Text = jo["roomNum"].ToString();
        }


        protected void btnDel_Click(object sender, EventArgs e)
        {
            if (this.checkFrom(this.txtRoom.Text.Trim()))
            {
                Dictionary<string, string> dic = new Dictionary<string, string>();
                dic["action"] = "IDIP_DO_DEL_ROOM_REQ";
                dic["roomId"] = this.txtRoom.Text.Trim();
                string json = new JavaScriptSerializer().Serialize(dic);
                string responseStr = HttpClientUlity.PostJsonData(serverUrl, json);

                JObject jo = (JObject)JsonConvert.DeserializeObject(responseStr);
                this.divAlert.Visible = true;
                this.lblAlert.Text = jo["msg"].ToString();
            }
        }

        protected void btnQueryPlayerInfo_Click(object sender, EventArgs e)
        {
            if (this.checkFrom(this.txtPlayerInfoId.Text.Trim()))
            {
                Dictionary<string, string> dic = new Dictionary<string, string>();
                dic["action"] = "IDIP_DO_PLAYER_INFO_REQ";
                dic["uid"] = this.txtPlayerInfoId.Text.Trim();
                string json = new JavaScriptSerializer().Serialize(dic);
                string responseStr = HttpClientUlity.PostJsonData(serverUrl, json);

                JObject jo = (JObject)JsonConvert.DeserializeObject(responseStr);
                this.divAlert.Visible = true;
                this.lblAlert.Text = jo["msg"].ToString();
            }
        }

        /// <summary>
        /// 封号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnForbiden_Click(object sender, EventArgs e)
        {
            if (this.checkFrom(this.txfFrobidenPlayerId.Text.Trim()))
            {
                Dictionary<string, string> dic = new Dictionary<string, string>();
                dic["action"] = "IDIP_DO_BAN_USR_REQ";
                dic["uid"] = this.txfFrobidenPlayerId.Text.Trim();
                dic["banstatus"] = "1";
                string json = new JavaScriptSerializer().Serialize(dic);
                string responseStr = HttpClientUlity.PostJsonData(serverUrl, json);

                JObject jo = (JObject)JsonConvert.DeserializeObject(responseStr);
                this.divAlert.Visible = true;
                this.lblAlert.Text = jo["msg"].ToString();
            }
        }

        /// <summary>
        /// 解封
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnDeArchive_Click(object sender, EventArgs e)
        {
            if (this.checkFrom(this.txtdeArchive.Text.Trim()))
            {
                Dictionary<string, string> dic = new Dictionary<string, string>();
                dic["action"] = "IDIP_DO_UNBAN_USR_REQ";
                dic["uid"] = this.txtdeArchive.Text.Trim();
                string json = new JavaScriptSerializer().Serialize(dic);
                string responseStr = HttpClientUlity.PostJsonData(serverUrl, json);

                JObject jo = (JObject)JsonConvert.DeserializeObject(responseStr);
                this.divAlert.Visible = true;
                this.lblAlert.Text = jo["msg"].ToString();
            }

        }

        private bool checkFrom(string msg)
        {
            if (string.IsNullOrEmpty(msg))
            {
                this.lblAlert.Visible = true;
                this.lblAlert.Text = "请输入相应的查询信息";
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