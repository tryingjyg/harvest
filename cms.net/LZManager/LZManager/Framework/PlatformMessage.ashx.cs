using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LZManager.DAL;

namespace LZManager.Framework
{
    /// <summary>
    /// PlatformMessage 的摘要说明
    /// </summary>
    public class PlatformMessage : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            NxPlatformMO NxPlatformMO = new NxPlatformMO("LZBgAuthorityConn");
            string id = context.Request["id"].ToString();
            string message = "";

            if (id != "")
            {
                NxPlatformEO NxPlatformEO = NxPlatformMO.GetByPK(id);
                if (NxPlatformEO.PfNewEndTime == null)
                {
                    NxPlatformEO.PfNewEndTime = new DateTime(1970, 1, 1);
                }

                if (NxPlatformEO.PfNewEndTime < DateTime.Now)
                {
                    NxPlatformMO.PutPfIsNewShowByPK(id, "0"); // 将信息修改为不显示
                    message = "0";
                }
                else
                {
                    message = NxPlatformEO.PfIsNewShow + NxPlatformEO.PfNewFunction;
                }
            }

            context.Response.ContentType = "text/plain";
            context.Response.Write(message);
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