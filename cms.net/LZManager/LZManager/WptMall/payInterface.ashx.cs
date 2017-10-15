using LZManager.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Web;
using TinyFx.Net.Json;
using TinyFx.Net.Json.Linq;

namespace LZManager.WptMall
{
    /// <summary>
    /// payInterface 的摘要说明
    /// </summary>
    public class payInterface : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            //context.Request.ContentEncoding = Encoding.GetEncoding("gb2312");

            #region 牛状元

            /*
             appId = 148999970238152
             appkey = ey12lW6mWurQAL73JMiSjZWj3T8p6rxK


            应用ID：
            appId=147245449905115
            应用密钥：
            appKey=nxY3Gysbt3cCo9k6xdLSpch4MFg3S2bI

             */

            /*
            Dictionary<string, string> paratStr = new Dictionary<string, string>();
            StringBuilder sb = new StringBuilder();
            paratStr.Add("funcode", "funcode=WP001");
            paratStr.Add("version", "version=1.0.0");
            paratStr.Add("appId", "appId=147245449905115");
            paratStr.Add("mhtOrderNo", "mhtOrderNo=1506827619125");
            paratStr.Add("mhtOrderName", "mhtOrderName=merchantTest");
            paratStr.Add("mhtCurrencyType", "mhtCurrencyType=156");
            paratStr.Add("mhtOrderAmt", "mhtOrderAmt=10");
            paratStr.Add("mhtOrderDetail", "mhtOrderDetail=mhtOrderDetail");
            paratStr.Add("mhtOrderType", "mhtOrderType=01");
            paratStr.Add("mhtOrderStartTime", "mhtOrderStartTime=" + DateTime.Now.ToString("yyyyMMddHHmmss"));
            paratStr.Add("notifyUrl", "notifyUrl=http://posp.ipaynow.cn:10808/mobilewaptest/notify");
            paratStr.Add("frontNotifyUrl", "frontNotifyUrl=http://posp.ipaynow.cn:10808/mobilewaptest/frontnotify");
            paratStr.Add("mhtCharset", "mhtCharset=UTF-8");
            paratStr.Add("deviceType", "deviceType=08");
            paratStr.Add("payChannelType", "payChannelType=13");
            paratStr.Add("outputType", "outputType=1");
            paratStr.Add("mhtSignType", "mhtSignType=MD5");

            paratStr = (from entry in paratStr
                        orderby entry.Key ascending
                        select entry).ToDictionary(pair => pair.Key, pair => pair.Value);

            List<string> optList = new List<string>();
            foreach (var key2 in paratStr)
            {
                optList.Add(key2.Value);
            }

            for (var i = 0; i < optList.Count; i++)
            {
                if (i == optList.Count - 1)
                {
                    sb.Append(optList[i]);
                }
                else
                {
                    sb.Append(optList[i] + "&");
                }
            }

            string queryUrl = "https://pay.ipaynow.cn?";
            string MD5Key = "nxY3Gysbt3cCo9k6xdLSpch4MFg3S2bI"; //ey12lW6mWurQAL73JMiSjZWj3T8p6rxK

            //string mhtSignatureStr = "appId=148999970238152&frontNotifyUrl=http://posp.ipaynow.cn:10808/mobilewaptest/frontnotify" +
            //    "&mhtCharset=UTF-8&mhtCurrencyType=156&mhtOrderAmt=10&mhtOrderDetail=mhtOrderDetail&mhtOrderName=merchantTest&mhtOrderNo=1506827619120" +
            //    "&mhtOrderStartTime=" + DateTime.Now.ToString("yyyyMMddHHmmss") + "&mhtOrderType=01&notifyUrl=http://posp.ipaynow.cn:10808/mobilewaptest/notify&payChannelType=13&5770c97131bd3aa136fdd46afdeec9f4";


            string mhtSignatureStrResullt = Security.MD5(MD5Key);
            string MD5Result1 = Security.MD5(sb.ToString() + "&" + mhtSignatureStrResullt);

            string outUrl = queryUrl + sb.ToString() + "&mhtSignature=" + MD5Result1;
            context.Response.Write(outUrl);
            */
            #endregion


            #region 掌宜付


            //APP_ID =  3947(应用ID)
            //PARTNER_ID = 1000100020001688(商户ID)
            //KEY = 86FE35EFBDD846A0868A43CD13BFD4AE(秘钥)
            //QN = //请在子渠道管理模块下选择该应用的一个渠道代码(qn)


            //string basePath = "http://pay.csl2016.cn:8000/";

            /**
                商户ID
            **/
            //string partnerId = "1000100020001688";//request.getParameter("partnerId");
            /**
                应用ID
            **/
            //string appId = "3947";//request.getParameter("appId");
            /**
                    支付金额(正整数，以分为单位)
            
            **/
            //string money = "10";//request.getParameter("money");
            /**
            支付方式(1 微信H5,2 支付宝H5,3 银联H5,4 微信扫码,5 微信公众号,6 QQ钱包)
            **/
            //string wapType = "4";//request.getParameter("wapType");
            /**
            商户订单号(需保证同⼀app_id下唯一，交易结果回
                    调通知将传递此参数，支付结果查询也
                    使用此参数。)
            **/
            //string outTradeNo = "261215095524963127";//request.getParameter("outTradeNo");
            /***


            **/
            /***
                设备识别码

            **/
            //string imei = "imei";//request.getParameter("imei");

            /**
                商户渠道代码
            **/
            //string qn = "q156";//request.getParameter("qn");
            /**
                商户密钥
            **/
            //string key = "86FE35EFBDD846A0868A43CD13BFD4AE";//request.getParameter("key");
            /***
                支付后返回地址(需进行URL encode)

            **/
            //string returnUrl = "http://wyx.aizhidiaosu.com/WptMall/payResponse.ashx";//request.getParameter("returnUrl");
            /**
                商品名称
            **/
            //string subject = "good01";//request.getParameter("subject");

            //string action = "create";//request.getParameter("action");
            //string reqParams = "partner_id=" + partnerId + "&app_id=" + appId + "&out_trade_no=" + outTradeNo;
            //string reqAction = "/queryOrder.e";

            //if ("create".Equals(action))
            //{
            //    reqAction = "/createOrder.e";
            //    reqParams +=
            //    "&money=" + money +
            //    "&wap_type=" + wapType +
            //    "&qn=" + qn +       //                "&imei=" + imei +
            //    "&return_url=" + HttpUtility.UrlEncode(returnUrl, System.Text.Encoding.UTF8) +
            //    "&subject=" + HttpUtility.UrlEncode(subject, System.Text.Encoding.UTF8);
            //    if ("3".Equals(wapType))
            //    {
            //        reqParams += "&bank_code=" + "";//request.getParameter("bankCode");

            //    }

            //}

            //Dictionary<string, string> zyfparatStr = new Dictionary<string, string>();
            //StringBuilder zyfsb = new StringBuilder();
            //zyfparatStr.Add("partner_id", "partner_id=1000100020001688");
            //zyfparatStr.Add("app_id", "app_id=3947");
            //zyfparatStr.Add("out_trade_no", "out_trade_no=" + outTradeNo);
            //zyfparatStr.Add("money", "money=10");
            //zyfparatStr.Add("wap_type", "wap_type=4");
            //zyfparatStr.Add("qn", "qn=q156");
            ////zyfparatStr.Add("imei", "imei=imeiqqq");
            //zyfparatStr.Add("return_url", "return_url=" + HttpUtility.UrlEncode("http://wyx.aizhidiaosu.com/WptMall/payResponse.ashx"));
            //zyfparatStr.Add("subject", "subject=good01");

            //zyfparatStr = (from entry in zyfparatStr
            //               orderby entry.Key ascending
            //               select entry).ToDictionary(pair => pair.Key, pair => pair.Value);

            //List<string> zyfList = new List<string>();
            //foreach (var key1 in zyfparatStr)
            //{
            //    zyfList.Add(key1.Value);
            //}

            //for (var i = 0; i < zyfList.Count; i++)
            //{
            //    if (i == zyfList.Count - 1)
            //    {
            //        zyfsb.Append(zyfList[i]);
            //    }
            //    else
            //    {
            //        zyfsb.Append(zyfList[i] + "&");
            //    }
            //}
            //zyfsb.Append("&key=86FE35EFBDD846A0868A43CD13BFD4AE");

            //string sign = Security.MD5(zyfsb.ToString());

            //string visitUrl = basePath + reqAction + "?" + reqParams + "&sign=" + HttpUtility.UrlEncode(sign, System.Text.Encoding.UTF8).ToUpper();

            #endregion
            //context.Response.Write(outUrl);

            //http://wyx.aizhidiaosu.com/WptMall/getGoodsList.ashx?goodId=1006&goodName=good6&goodMoney=500&userDetail={"userUid":10260,"unionid":"o4_X2vk3c1ZbJdqrleN8ul0OF3ks"}

            //"userUid":10260,"unionid":"o4_X2vk3c1ZbJdqrleN8ul0OF3ks","duid":10012

            if (string.IsNullOrEmpty(context.Request["goodId"]) || string.IsNullOrEmpty(context.Request["goodName"]) || string.IsNullOrEmpty(context.Request["goodMoney"])
                || string.IsNullOrEmpty(context.Request["goodDetail"]) || string.IsNullOrEmpty(context.Request["userDetail"]))
            {
                context.Response.Write("param error");
            }
            else
            {
                string goodNo = context.Request["goodId"].ToString();
                string goodName = context.Request["goodName"].ToString();
                string goodMoney = (Convert.ToInt32(context.Request["goodMoney"].ToString()) * 100).ToString();
                string goodDetail = HttpUtility.UrlDecode(context.Request["goodDetail"].ToString(), Encoding.GetEncoding("utf-8")); ;
                string useDetails = context.Request["userDetail"].ToString();
                string uid = "";

                if (!string.IsNullOrEmpty(useDetails))
                {
                    JObject jo = (JObject)JsonConvert.DeserializeObject(useDetails);
                    uid = jo["userUid"].ToString();
                }
                string trandeNo = DateTime.Now.ToString("yyyyMMddHHmmss");
                string payUrl = PayUlity.ZYFPay(goodMoney, "1", trandeNo, goodName, uid);
                context.Response.Write(payUrl);
            }

            //this.lblTotal.Text = jo["amount"].ToString();
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