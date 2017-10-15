using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LZManager.Utility
{
    /// <summary>
    /// 配置类文件
    /// </summary>
    public static class H5Config
    {

        public static readonly Dictionary<string, string> dicconst = new Dictionary<string, string> {
                 // {"QueryUrl", "https://pay.ipaynow.cn/"},正式环境使用此地址
             {"QueryUrl", "https://p.ipaynow.cn/"},//测试环境地址
            {"appId", "148999970238152"},
            {"appKey", "ey12lW6mWurQAL73JMiSjZWj3T8p6rxK"},
            {"mhtOrderAmt", "1"},
            {"mhtOrderName", "测试支付"},
            {"mhtOrderDetail", "订单详情"},
            {"mhtOrderTimeOut", "2000"},
            {"mhtCurrencyType", "156"},
            {"funcode", "WP001"},
            {"mhtOrderType", "01"},
            {"mhtCharset", "UTF-8"},
            {"deviceType", "0601"},
            {"payChannelType", "13"},
            {"outputType", "0"},
            {"notifyUrl", "http://posp.ipaynow.cn:10808/mobilewapH/notify"},
            {"frontNotifyUrl", "http://posp.ipaynow.cn:10808/mobilewapH/frontnotify"},
            {"mhtSignType", "MD5"},
            {"mhtOrderNo", DateTime.Now.ToString("yyyyMMddHHmmss")},
            {"mhtOrderStartTime", DateTime.Now.ToString("yyyyMMddHHmmss")},
           // {"mhtLimitPay", "no_credit"},
            {"version", "1.0.0"},
            //发起H5支付的外网地址
            {"consumerCreateIp", "60.253.242.122"}

        };
    }
}