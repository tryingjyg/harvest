using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LZManager.BLL.Common.SendEmailMessage;
using System.Configuration;
using System.Web;

namespace LZManager.BLL.Common
{
    public static class Send
    {
        /// <summary>
        /// 发送Email
        /// </summary>
        /// <param name="emailname"></param>
        /// <param name="title"></param>
        /// <param name="message"></param>
        /// <param name="email"></param>
        /// <param name="ServerEmail"></param>
        /// <returns></returns>
        public  static bool sendEmail(string mailtitle, string mailmessage, string email)
        {
            bool result = false;
            try
            {
                StringBuilder mailBody = new StringBuilder(mailmessage);

                String subject = mailtitle;
                String body = mailBody.ToString();

                SendMessageUtil.EmailMessageAdapter adapter = new SendMessageUtil.EmailMessageAdapter();
                adapter.SendEmail(subject, body, new List<String>() { email });

                result = true;
            }
            catch (Exception ex)
            {
               
            }
            return result;
        }



        /// <summary>
        /// 发送短信
        /// </summary>
        /// <param name="emailname"></param>
        /// <param name="title"></param>
        /// <param name="message"></param>
        /// <param name="email"></param>
        /// <param name="ServerEmail"></param>
        /// <returns></returns>
        public static bool sendPhone(string phone, string msgContent)
        {
            string tmpurl = ConfigurationManager.AppSettings["Constants"].ToString() + string.Format("?phone={0}&msgContent={1}&sourceId={2}", phone, HttpUtility.UrlEncode(msgContent, Encoding.GetEncoding("gb2312")), "pw");
            var request = new TinyFx.Web.WebGetRequest(tmpurl, Encoding.UTF8);
            var result = HttpUtility.UrlDecode(request.GetResponse(), Encoding.UTF8);

            return result.ToString().ToUpper() == "OK";
        }

    }
}
