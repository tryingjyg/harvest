using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace LZManager.Framework
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Application["online"] = 0;

        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Application.Lock();//锁定后，只有这个Session能够会话
            Application["online"] = (int)Application["online"] + 1;
            Application.UnLock();//会话完毕后解锁
        }

        void Application_BeginRequest(Object sender, EventArgs e)
        {
            try
            {
                if (Request.Cookies["langCook"] != null)
                {
                    System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture(Request.Cookies["langCook"]["lang"].ToString());
                    System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Request.Cookies["langCook"]["lang"].ToString());
                }
                else
                {
                    HttpCookie cookielang = new HttpCookie("langCook");   //初使化并设置Cookie的名称
                    cookielang.Values.Add("lang", "");//英语  en-US
                    Response.Cookies.Add(cookielang); //添加新建的cookie





                }
            }
            catch (Exception)
            { }
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {
            Application.Lock();
            Application["online"] = (int)Application["online"] - 1;
            Application.UnLock();
        }

        protected void Application_End(object sender, EventArgs e)
        {

        }

    }
}