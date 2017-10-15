using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LZManager.Wx
{
    /// <summary>
    /// wxBaby 的摘要说明
    /// </summary>
    public class wxBaby : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string appId = "wx7d6684f9dcb1fc7c";
            string requestStr = context.Request["duid"];
            string reDirectoryUrl = "http://wyx.aizhidiaosu.com/Wx/wxToBaby.ashx?duid=" + requestStr;

            context.Response.ContentType = "text/plain";
            context.Response.Redirect("https://open.weixin.qq.com/connect/oauth2/authorize?appid=" + appId + "&redirect_uri=" + reDirectoryUrl + "&response_type=code&scope=snsapi_userinfo&state=1#wechat_redirect");
            //context.Response.Write("Hello World");
        }


        /// <summary>
        /// 得到获取code的Url
        /// </summary>
        /// <param name="appid">公众号的唯一标识</param>
        /// <param name="redirect">授权后重定向的回调链接地址，请使用urlencode对链接进行处理</param>
        /// <param name="scope">应用授权作用域，snsapi_base （不弹出授权页面，直接跳转，只能获取用户openid），snsapi_userinfo （弹出授权页面，可通过openid拿到昵称、性别、所在地。并且，即使在未关注的情况下，只要用户授权，也能获取其信息）</param>
        /// <param name="state">重定向后会带上state参数，开发者可以填写a-zA-Z0-9的参数值</param>
        /// <returns></returns>
        public static string BuildWebCodeUrl(string appid, string redirect, string scope, string state = "")
        {

            return string.Format("https://open.weixin.qq.com/connect/oauth2/authorize?appid={0}&redirect_uri={1}&response_type=code&scope={2}&state={3}#wechat_redirect", appid, redirect, scope, state);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}