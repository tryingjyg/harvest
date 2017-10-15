using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Security;

namespace LZManager.Wx
{
    /// <summary>
    /// wx_sample 的摘要说明
    /// </summary>
    public class wx_sample : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string postString = string.Empty;
            Auth(); //微信接入的测试   
            //context.Response.Write("Hello World");
        }

        /// <summary>  
        /// 获取参数进行认证  
        /// </summary>  
        private void Auth()
        {
            //string token = "*****";//你申请的时候填写的Token  
            string token = "wxToShow";
            string echoString = HttpContext.Current.Request.QueryString["echoStr"];
            string signature = HttpContext.Current.Request.QueryString["signature"];
            string timestamp = HttpContext.Current.Request.QueryString["timestamp"];
            string nonce = HttpContext.Current.Request.QueryString["nonce"];

            if (CheckSignature(token, signature, timestamp, nonce))
            {
                if (!string.IsNullOrEmpty(echoString))
                {
                    HttpContext.Current.Response.Write(echoString);
                    HttpContext.Current.Response.End();
                }
            }
        }

        /// <summary>  
        /// 对微信传入参数进行封装到数组，拼接字符串，进行加密操作  
        /// </summary>  
        /// <param name="token"></param>  
        /// <param name="signature"></param>  
        /// <param name="timestamp"></param>  
        /// <param name="nonce"></param>  
        /// <returns></returns>  
        private bool CheckSignature(string token, string signature, string timestamp, string nonce)
        {
            string[] ArrTmp = { token, timestamp, nonce };//将参数放进数组  

            Array.Sort(ArrTmp);//对数组进行排序  
            string tmpStr = string.Join("", ArrTmp);//将数组进行拼接  
            ///对拼接后的字符串进行加密操作  
            tmpStr = FormsAuthentication.HashPasswordForStoringInConfigFile(tmpStr, "SHA1");
            //转换成小写形式  
            tmpStr = tmpStr.ToLower();
            //比对成功返回  
            if (tmpStr == signature)
            {
                return true;
            }
            else
            {
                return false;
            }
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