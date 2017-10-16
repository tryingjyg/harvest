using LZManager.BLL.Common;
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
    public partial class QueryUnForbiden : BasePage
    {

        private string serverUrl = ConfigurationManager.AppSettings["ServerUrl"].ToString();

        protected void Page_Load(object sender, EventArgs e)
        {
            //this.lblOnLineNum.Text = "0";
            //this.lblTotalNum.Text = "0";

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
                ShowCommonDlg(jo["msg"].ToString());
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