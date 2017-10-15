using LZManager.BLL;
using LZManager.DAL;
using LZManager.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.SessionState;

namespace LZManager.WptMall
{
    /// <summary>
    /// payResponse 的摘要说明
    /// </summary>
    public class payResponse : IHttpHandler, IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            //http://wyx.aizhidiaosu.com/WptMall/payResponse.ashx?
            //app_id =3947&code=0&
            //invoice_no=8a758f7d2d5e4f2fa96f6a61bb3e3e70&money=10&out_trade_no=261215095524963124&pay_way=1
            //&qn=q156&up_invoice_no=4200000007201710127617788650&sign=EC8BB69BE9A38005B9D6990DD32B9160

            //code          交易易结果   是      Int 0 交易易成功 1 交易易失败(保留留值，交易易失败暂不不发回调通知)
            //app_id        应⽤用编号   是      Int 可在商户后台创建和查询
            //pay_way       ⽀支付⽅方式  是     Int 1 微信2 ⽀支付宝3 QQ钱包9 银联
            //out_trade_no  商户订单编号  是     String(32) ⽀支付请求同名参数透传
            //invoice_no    平台订单编号  是     String(32) 平台⾃自动⽣生成，全局唯⼀一
            //up_invoice_no 通道订单编号  否     String(32) 银⾏行行或微信⽀支付流⽔水号，不不是所有通道或⽀支付⽅方式都提供
            //money         交易易⾦金金额 是    Int 正整数，以分为单位
            //qn            商户渠道代码  是     String(20) ⽀支付请求同名参数透传
            //sign          参数签名        是         String(32) 按以上参数签名说明计算得到

            string resCode = context.Request["code"];
            int codei = Convert.ToInt32(resCode);
            //context.Response.Redirect("MallTGoodsList.aspx?codei = " + codei);
            if (codei == 0)
            {
                string sign = context.Request["sign"].ToString();
                if (true)
                {
                    string invoice_no = context.Request["invoice_no"];
                    string money = context.Request["money"];
                    string out_trade_no = context.Request["out_trade_no"];
                    string appid = context.Request["app_id"];
                    string qn = context.Request["qn"];
                    string up_invoice_no = context.Request["up_invoice_no"];
                    string pay_way = context.Request["pay_way"];
                    //string imei = context.Request["imei"];


                    //app_id = 3947 & 
                    //code = 0 & 
                    //    invoice_no = 8373acfd070e429aa324714c93c24c43 
                    //    & money = 10 
                    //    & out_trade_no = 20171013160155 
                    //    & pay_way = 1 
                    //    & qn = q156 
                    //    & up_invoice_no = 4200000014201710137811686478 

                    //    & sign = 620B20195B9AC738FCCF3B3EA5402602

                    //string key = "86FE35EFBDD846A0868A43CD13BFD4AE";//request.getParameter("key");

                    Dictionary<string, string> zyfparatStr = new Dictionary<string, string>();
                    StringBuilder zyfsb = new StringBuilder();
                    zyfparatStr.Add("app_id", "app_id=" + appid);
                    zyfparatStr.Add("code", "code=" + resCode);
                    zyfparatStr.Add("out_trade_no", "out_trade_no=" + out_trade_no);
                    zyfparatStr.Add("money", "money=" + money);
                    zyfparatStr.Add("pay_way", "pay_way=" + pay_way);
                    zyfparatStr.Add("invoice_no", "invoice_no=" + invoice_no);
                    zyfparatStr.Add("up_invoice_no", "up_invoice_no=" + up_invoice_no);
                    zyfparatStr.Add("qn", "qn=" + qn);
                    //zyfparatStr.Add("imei", "imei=" + imei);

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
                    string mySign = Security.MD5(zyfsb.ToString()).ToUpper();
                    if (mySign.Equals(sign))
                    {
                        LogChargeManage lcMange = new LogChargeManage();

                        LogChargeEO chargeEo = new LogChargeEO();
                        chargeEo.InvoiceNo = invoice_no;
                        chargeEo.UpInvoiceNo = up_invoice_no;
                        chargeEo.OutTradeNo = out_trade_no;
                        chargeEo.AppId = appid;
                        chargeEo.Money = money;
                        chargeEo.Duid = qn;
                        chargeEo.PayWay = pay_way;
                        chargeEo.Qn = qn;
                        chargeEo.CreateTime = DateTime.Now.ToString();
                        int res = lcMange.addLg(chargeEo);
                        if (res > 0)
                        {
                            //更新代理的钻石
                            UserManage umMange = new UserManage();
                            umMange.PutUrDiamondByGameId(qn, "105");
                            context.Response.Write("0");
                        }
                        else
                        {
                            context.Response.Write("1");
                        }
                    }
                    else
                    {
                        context.Response.Write("2");    //签名失败
                    }
                }
                else
                {
                    context.Response.Write("3");    //gameid 为0
                }
            }
            else
            {
                context.Response.Write("4");        //返会code不是0
            }

            //context.Response.Write("Hello World");
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