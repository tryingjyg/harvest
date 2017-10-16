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
    public partial class QueryChargeIsSuc : BasePage
    {

        private string serverUrl = ConfigurationManager.AppSettings["ServerUrl"].ToString();

        protected void Page_Load(object sender, EventArgs e)
        {
            //this.lblOnLineNum.Text = "0";
            //this.lblTotalNum.Text = "0";

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