using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LZManager.WptMall
{
    /// <summary>
    /// NZYPayResponse 的摘要说明
    /// </summary>
    public class NZYPayResponse : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            context.Response.Write("NZYPayResponse");
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