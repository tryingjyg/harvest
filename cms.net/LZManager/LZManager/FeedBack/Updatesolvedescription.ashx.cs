using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LZManager.DAL;
using LZManager.BLL.Common;
using LZWebApp.BLL.Roulette;
using System.Configuration;

namespace LZManager.FeedBack
{
    /// <summary>
    /// Handler1 的摘要说明
    /// </summary>
    public class Handler1 : IHttpHandler
    {
        FeedbackMO feedBackMO = new FeedbackMO();
        BasePage basePage = new BasePage();
        public void ProcessRequest(HttpContext context)
        {
            if (basePage.GetUserID() == "")
            {
                Jswork.Alert("亲，请先登录！", "top", ConfigurationManager.AppSettings["WebLoginURL"].ToString());
            }
            int result = 0;
            try
            {
                string id = context.Request["id"].ToString();
                string state = context.Request["state"].ToString();
                string message = context.Request["message"].ToString();


                if (id != "" && state != "")
                {
                    if (feedBackMO.PutFbStateByPK(Convert.ToInt32(id), state) > 0)  // 修改state
                    {
                        feedBackMO.PutFbSolveUserByPK(Convert.ToInt32(id), basePage.GetUserID()); // 修改人
                        feedBackMO.PutFbSolveTimeByPK(Convert.ToInt32(id), DateTime.Now);  //修改时间
                        feedBackMO.PutFbSolvedescriptionByPK(Convert.ToInt32(id), message);  //修改管理员回复
                        basePage.InsertLog("问题反馈管理员回复", "Fb_state:" + state + ",Fb_addTime:" + DateTime.Now + ",Fb_solvedescription:" + message + ",id:" + id, -3, basePage.GetPlatformIdByValue(1)); //  添加日志
                        result = 1;
                    }
                    else
                    {
                        result = 0;
                    }
                }
            }
            catch
            {
                result = 0;
            }

            context.Response.ContentType = "text/plain";
            context.Response.Write(result);
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