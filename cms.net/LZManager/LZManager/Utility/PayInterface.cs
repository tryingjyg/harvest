using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace LZManager.Utility
{
    /// <summary>
    /// 配置类文件
    /// </summary>
    public static class PayUlity
    {

        //public static readonly Dictionary<string, string> dicconst = new Dictionary<string, string> {
        //         // {"QueryUrl", "https://pay.ipaynow.cn/"},正式环境使用此地址
        //     {"QueryUrl", "https://p.ipaynow.cn/"},//测试环境地址
        //    {"appId", "147868777472129"},
        //    {"appKey", "1FZMAlAplOTamX6OARDVV8hrswhbGEVg"},
        //    {"mhtOrderAmt", "1"},
        //    {"mhtOrderName", "测试支付"},
        //    {"mhtOrderDetail", "订单详情"},
        //    {"mhtOrderTimeOut", "2000"},
        //    {"mhtCurrencyType", "156"},
        //    {"funcode", "WP001"},
        //    {"mhtOrderType", "01"},
        //    {"mhtCharset", "UTF-8"},
        //    {"deviceType", "0601"},
        //    {"payChannelType", "12"},           
        //    {"notifyUrl", "http://posp.ipaynow.cn:10808/mobilewapH/notify"},
        //    {"frontNotifyUrl", "http://posp.ipaynow.cn:10808/mobilewapH/frontnotify"},
        //    {"mhtSignType", "MD5"},
        //    {"mhtOrderNo", DateTime.Now.ToString("yyyyMMddHHmmss")},
        //    {"mhtOrderStartTime", DateTime.Now.ToString("yyyyMMddHHmmss")},
        //   // {"mhtLimitPay", "no_credit"}
        //    {"outputType", "1"},
        //    {"version", "1.0.0"},
        //};
        /// <summary>
        /// 牛状元支付方式
        /// </summary>
        /// <param name="payMhtOrderNo"></param>
        /// <param name="payMhtOrderName"></param>
        /// <param name="payMhtOrderDetail"></param>
        /// <param name="payMoney"></param>
        /// <returns></returns>
        public static string NZYPay(string payMhtOrderNo, string payMhtOrderName, string payMhtOrderDetail, string payMoney)
        {
            /*
            appId = 148999970238152
            appkey = ey12lW6mWurQAL73JMiSjZWj3T8p6rxK
            功能码				funcode	String(5)	Y	定值：WP001
            接口版本号			version	String(5)	Y	定值：1.0.0
            商户应用唯一标识	appId	String(1,40)	Y	
            商户订单号			mhtOrderNo	String(1,40)	Y	
	            商户子商户号		mhtSubMchId	String(64)	N	现在支付子商户号，机构商模式使用
            商户商品名称		mhtOrderName	String(1,40)	Y	
            商户交易类型		mhtOrderType	String(1,40)	Y	定值01（普通消费）
            商户订单币种类型	mhtCurrencyType	String(3)	Y	定值156（人民币）
            商户订单交易金额	mhtOrderAmt	Number(22)	Y	单位(人民币)：分整数，无小数点
            商户订单详情		mhtOrderDetail	String(0,200)	Y	
	            商户订单超时时间	mhtOrderTimeOut	Number(4)	N	60~3600秒，默认3600
            商户订单开始时间	mhtOrderStartTime	String(14)	Y	yyyyMMddHHmmss
            商户后台通知URL		notifyUrl	String(1,200)	Y	HTTP协议或者HTTPS协议，POST方式提交报文。
            商户前台通知URL		frontNotifyUrl	String(1,200)	Y	HTTP协议或者HTTPS协议，POST方式提交报文。
            商户字符编码		mhtCharset	String(1,16)	Y	UTF-8
            设备类型			deviceType	String(4)	Y	定值：0601（手机网页）
            用户所选渠道类型	payChannelType	String(2)	Y	银联：11支付宝：12微信：13手Q：25见附录6.5的渠道类型表
	            商户保留域			mhtReserved	String(100)	N	给商户使用的字段，商户可以对交易进行标记，必须严格遵循以下格式：mchBankId=123&商户自定义参数
            输出格式			outputType	String(2)	Y	outputType=0(默认取值)outputType=1outputType=2(注：微信deeplink)，outputType=3
	            是否支持信用卡支付	mhtLimitPay	String(2)	N	0：禁用信用卡1：允许使用信用卡
	            支付账号			payAccNo	String(40)	N	outputType为0且payChannelType=11时，卡号必传
	            商品标记			mhtGoodsTag	String(0,32)	N	用于营销活动
	            用户支付ip			consumerCreateIp	String(20)	N	outputType=0或1，且payChannelType=13时必填,
            商户签名方法		mhtSignType	String(3)	Y	定值：MD5
            商户数据签名		mhtSignature	String(32)	Y	除mhtSignature字段外，所有参数都参与MD5签名。签名逻辑见接口附录说明6.1 
            */


            string mhtOrderNo = payMhtOrderNo;
            string mhtOrderName = payMhtOrderName;
            string money = payMoney;
            string returnUrl = "http://wyx.aizhidiaosu.com/WptMall/NZYPayResponse.ashx";//request.getParameter("returnUrl");
            string mhtOrderDetail = payMhtOrderDetail;


            Dictionary<string, string> paratStr = new Dictionary<string, string>();
            StringBuilder sb = new StringBuilder();
            paratStr.Add("funcode", "funcode=WP001");
            paratStr.Add("version", "version=1.0.0");
            paratStr.Add("appId", "appId=148999970238152");
            paratStr.Add("mhtOrderNo", "mhtOrderNo=" + mhtOrderNo);
            paratStr.Add("mhtOrderName", "mhtOrderName=" + mhtOrderName);
            paratStr.Add("mhtCurrencyType", "mhtCurrencyType=156");
            paratStr.Add("mhtOrderAmt", "mhtOrderAmt=" + money);
            paratStr.Add("mhtOrderDetail", "mhtOrderDetail=" + mhtOrderDetail);
            paratStr.Add("mhtOrderType", "mhtOrderType=01");
            paratStr.Add("mhtOrderStartTime", "mhtOrderStartTime=" + DateTime.Now.ToString("yyyyMMddHHmmss"));
            paratStr.Add("notifyUrl", "notifyUrl=" + returnUrl);
            paratStr.Add("frontNotifyUrl", "frontNotifyUrl=http://posp.ipaynow.cn:10808/mobilewaptest/frontnotify");
            paratStr.Add("mhtCharset", "mhtCharset=UTF-8");
            paratStr.Add("deviceType", "deviceType=0601");
            paratStr.Add("payChannelType", "payChannelType=13");
            paratStr.Add("outputType", "outputType=2");
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

            //context.Response.Write(sb.ToString());

            string queryUrl = "https://pay.ipaynow.cn?";
            string MD5Key = "ey12lW6mWurQAL73JMiSjZWj3T8p6rxK";

            //string mhtSignatureStr = "appId=148999970238152&frontNotifyUrl=http://posp.ipaynow.cn:10808/mobilewaptest/frontnotify" +
            //    "&mhtCharset=UTF-8&mhtCurrencyType=156&mhtOrderAmt=10&mhtOrderDetail=mhtOrderDetail&mhtOrderName=merchantTest&mhtOrderNo=1506827619120" +
            //    "&mhtOrderStartTime=" + DateTime.Now.ToString("yyyyMMddHHmmss") + "&mhtOrderType=01&notifyUrl=http://posp.ipaynow.cn:10808/mobilewaptest/notify&payChannelType=13&5770c97131bd3aa136fdd46afdeec9f4";


            string mhtSignatureStrResullt = Security.MD5(MD5Key);


            string MD5Result1 = Security.MD5(sb.ToString() + "&" + mhtSignatureStrResullt);

            string outUrl = queryUrl + sb.ToString() + "&mhtSignature=" + MD5Result1;

            return outUrl;
        }

        /// <summary>
        /// 掌宜付支付方式
        /// </summary>
        /// <param name="payMoney"></param>
        /// <param name="payWapType"></param>
        /// <param name="payOutTradeNo"></param>
        /// <param name="paySubject"></param>
        /// <returns></returns>
        public static string ZYFPay(string payMoney, string payWapType, string payOutTradeNo, string paySubject, string uid)
        {

            //APP_ID =  3947(应用ID)
            //PARTNER_ID = 1000100020001688(商户ID)
            //KEY = 86FE35EFBDD846A0868A43CD13BFD4AE(秘钥)
            //QN = //请在子渠道管理模块下选择该应用的一个渠道代码(qn)

            string basePath = "http://pay.csl2016.cn:8000/";

            /**
                商户ID
            **/
            string partnerId = "1000100020001688";//request.getParameter("partnerId");
            /**
                应用ID
            **/
            string appId = "3947";//request.getParameter("appId");
            /**
                    支付金额(正整数，以分为单位)
            
            **/
            string money = payMoney;//request.getParameter("money");
            /**
            支付方式(1 微信H5,2 支付宝H5,3 银联H5,4 微信扫码,5 微信公众号,6 QQ钱包)
        **/
            string wapType = payWapType;//request.getParameter("wapType");
            /**
            商户订单号(需保证同⼀app_id下唯一，交易结果回
                    调通知将传递此参数，支付结果查询也
                    使用此参数。)
            **/
            string outTradeNo = payOutTradeNo;//request.getParameter("outTradeNo");"261215095524963127"

            /***
                设备识别码
            **/
            //string imei = uid;//request.getParameter("imei");

            /**
                商户渠道代码
            **/
            string qn = uid;//request.getParameter("qn");
            /**
                商户密钥
            **/
            string key = "86FE35EFBDD846A0868A43CD13BFD4AE";//request.getParameter("key");
            /***
                支付后返回地址(需进行URL encode)

            **/
            string returnUrl = "http://wyx.aizhidiaosu.com/WptMall/payResponse.ashx";//request.getParameter("returnUrl");
            /**
                商品名称
            **/
            string subject = paySubject;//request.getParameter("subject");

            string action = "create";//request.getParameter("action");
            string reqParams = "partner_id=" + partnerId + "&app_id=" + appId + "&out_trade_no=" + outTradeNo;
            string reqAction = "/queryOrder.e";

            if ("create".Equals(action))
            {
                reqAction = "/createOrder.e";
                reqParams +=
                "&money=" + money +
                "&wap_type=" + wapType +
                "&qn=" + qn +       //"&imei=" + imei +
                "&return_url=" + HttpUtility.UrlEncode(returnUrl, System.Text.Encoding.UTF8) +
                "&subject=" + HttpUtility.UrlEncode(subject, System.Text.Encoding.UTF8);
                if ("3".Equals(wapType))
                {
                    reqParams += "&bank_code=" + "";//request.getParameter("bankCode");
                }

            }

            Dictionary<string, string> zyfparatStr = new Dictionary<string, string>();
            StringBuilder zyfsb = new StringBuilder();
            zyfparatStr.Add("partner_id", "partner_id=1000100020001688");
            zyfparatStr.Add("app_id", "app_id=3947");
            zyfparatStr.Add("out_trade_no", "out_trade_no=" + outTradeNo);
            zyfparatStr.Add("money", "money=" + money);
            zyfparatStr.Add("wap_type", "wap_type=" + wapType);
            zyfparatStr.Add("qn", "qn=" + qn);
            //zyfparatStr.Add("imei", "imei=" + imei);
            zyfparatStr.Add("return_url", "return_url=" + HttpUtility.UrlEncode(returnUrl));
            zyfparatStr.Add("subject", "subject=" + subject);

            zyfparatStr = (from entry in zyfparatStr
                           orderby entry.Key ascending
                           select entry).ToDictionary(pair => pair.Key, pair => pair.Value);

            List<string> zyfList = new List<string>();
            foreach (var key1 in zyfparatStr)
            {
                zyfList.Add(key1.Value);
            }

            for (var i = 0; i < zyfList.Count; i++)
            {
                if (i == zyfList.Count - 1)
                {
                    zyfsb.Append(zyfList[i]);
                }
                else
                {
                    zyfsb.Append(zyfList[i] + "&");
                }
            }
            zyfsb.Append("&key=86FE35EFBDD846A0868A43CD13BFD4AE");
            string sign = Security.MD5(zyfsb.ToString());
            string visitUrl = basePath + reqAction + "?" + reqParams + "&sign=" + HttpUtility.UrlEncode(sign, System.Text.Encoding.UTF8).ToUpper();
            return visitUrl;
        }

    }
}