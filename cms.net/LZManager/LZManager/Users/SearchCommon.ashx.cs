using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LZManager.Users
{
    /// <summary>
    /// SearchCommon 的摘要说明
    /// </summary>
    public class SearchCommon : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string id = context.Request["key"].ToString();

            context.Response.ContentType = "text/plain";
            context.Response.Write("Hello World");
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