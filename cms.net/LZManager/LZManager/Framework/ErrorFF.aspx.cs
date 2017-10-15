using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LZManager.Framework
{
    public partial class ErrorFF : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string type = "0";
                try
                {
                    type = Request.QueryString["type"];
                }
                catch
                {
                    type = "0";
                }


                if (type == "1")
                {
                    Label1.Text = "您没有权限啊~";
                }
                else if (type == "2")
                {
                    Label1.Text = "您不能非法访问啊~";
                }
                else
                {
                    Label1.Text = "谁把我的页面删了~";
                }
            }
        }
    }
}