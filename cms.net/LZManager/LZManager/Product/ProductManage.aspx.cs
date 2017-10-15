using LZManager.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;
using TinyFx.Net.Json;
using TinyFx.Net.Json.Linq;

namespace LZManager.Product
{
    public partial class ProductManage : System.Web.UI.Page
    {

        private string serverUrl = "http://192.168.1.101:8888";

        protected void Page_Load(object sender, EventArgs e)
        {
            this.txtNotice.Text = "";
        }

        protected void btnPublish_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic["action"] = "IDIP_DO_SEND_NOTICE_REQ";
            dic["content"] = this.txtNotice.Text.Trim();
            string json = new JavaScriptSerializer().Serialize(dic);
            string responseStr = HttpClientUlity.PostJsonData(serverUrl, json);

            JObject jo = (JObject)JsonConvert.DeserializeObject(responseStr);
            this.divAlert.Visible = true;
            this.lblAlert.Text = jo["msg"].ToString();
        }
    }
}