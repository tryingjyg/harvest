using LZManager.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace LZManager.WptMall
{
    /// <summary>
    /// charge 的摘要说明
    /// </summary>
    public class charge : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            //var recharData = { "mhtOrderAmt": "1", "mhtOrderDetail": SelfUid(), "mhtOrderName": "good1"};

            string url = H5Config.dicconst["QueryUrl"];
            string mD5Sign = H5Config.dicconst["mhtSignType"];

            string appId = (H5Config.dicconst["appId"]);
            string appKey = (H5Config.dicconst["appKey"]);
            string mhtOrderAmt = (H5Config.dicconst["mhtOrderAmt"]);
            string mhtOrderName = (H5Config.dicconst["mhtOrderName"]);
            string mhtOrderDetail = (H5Config.dicconst["mhtOrderDetail"]);

            string mhtOrderTimeOut = (H5Config.dicconst["mhtOrderTimeOut"]);
            string mhtCurrencyType = (H5Config.dicconst["mhtCurrencyType"]);
            string mhtOrderType = (H5Config.dicconst["mhtOrderType"]);
            string mhtCharset = (H5Config.dicconst["mhtCharset"]);
            string deviceType = (H5Config.dicconst["deviceType"]);
            string payChannelType = (H5Config.dicconst["payChannelType"]);
            string funcode = (H5Config.dicconst["funcode"]);
            string outputType = (H5Config.dicconst["outputType"]);
            string notifyUrl = (H5Config.dicconst["notifyUrl"]);
            string frontNotifyUrl = (H5Config.dicconst["frontNotifyUrl"]);
            string mhtSignType = (H5Config.dicconst["mhtSignType"]);
            string mhtOrderNo = (H5Config.dicconst["mhtOrderNo"]);
            string mhtOrderStartTime = (H5Config.dicconst["mhtOrderStartTime"]);
            string version = (H5Config.dicconst["version"]);
            string consumerCreateIp = (H5Config.dicconst["consumerCreateIp"]);

            //"&mhtSignType=" + mhtSignType +


            string mdSectrStr = "appId=" + appId + "&appKey=" + appKey + "&consumerCreateIp=" + consumerCreateIp + "&deviceType=" + deviceType + "&frontNotifyUrl="
                + frontNotifyUrl + "&funcode = " + funcode + "&mhtCharset=" + mhtCharset + "&mhtCurrencyType=" + mhtCurrencyType + "&mhtOrderAmt=" + mhtOrderAmt + "&mhtOrderDetail=" + mhtOrderDetail +
                "&mhtOrderName=" + mhtOrderName + "&mhtOrderNo=" + mhtOrderNo + "&mhtOrderTimeOut=" + mhtOrderTimeOut + "&mhtOrderType=" + mhtOrderType + "&mhtOrderStartTime="
                + mhtOrderStartTime + "&mhtSignType=" + mhtSignType + "&notifyUrl =" + notifyUrl + "&outputType=" + outputType + "&payChannelType=" + payChannelType + "&version=" + version;

            string MD5Result = Security.MD5(mdSectrStr + Security.MD5(appKey));

            string mdSectrStr11 = "appId=" + HttpUtility.UrlEncode(appId) + "&appKey=" + HttpUtility.UrlEncode(appKey) + "&consumerCreateIp=" + HttpUtility.UrlEncode(consumerCreateIp) + "&deviceType=" + HttpUtility.UrlEncode(deviceType) + "&frontNotifyUrl="
                + HttpUtility.UrlEncode(frontNotifyUrl) + "&funcode = " + HttpUtility.UrlEncode(funcode) + "&mhtCharset=" + HttpUtility.UrlEncode(mhtCharset) + "&mhtCurrencyType=" + HttpUtility.UrlEncode(mhtCurrencyType) + "&mhtOrderAmt=" + HttpUtility.UrlEncode(mhtOrderAmt) + "&mhtOrderDetail=" + HttpUtility.UrlEncode(mhtOrderDetail) +
                "&mhtOrderName=" + HttpUtility.UrlEncode(mhtOrderName) + "&mhtOrderNo=" + HttpUtility.UrlEncode(mhtOrderNo) + "&mhtOrderTimeOut=" + HttpUtility.UrlEncode(mhtOrderTimeOut) + "&mhtOrderType=" + HttpUtility.UrlEncode(mhtOrderType) + "&mhtOrderStartTime="
                + HttpUtility.UrlEncode(mhtOrderStartTime) + "&mhtSignType=" + HttpUtility.UrlEncode(mhtSignType) + "&notifyUrl =" + HttpUtility.UrlEncode(notifyUrl) + "&outputType=" + HttpUtility.UrlEncode(outputType) + "&payChannelType=" + HttpUtility.UrlEncode(payChannelType) + "&version=" + HttpUtility.UrlEncode(version);
            string report = mdSectrStr11;

            string endUrlStr = url + "?" + report + "&mhtSignature = " + MD5Result;
            //string resPonstr = HttpClient.Post(url, report + "mhtSignature=" + MD5Result);

            context.Response.Write(endUrlStr);
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