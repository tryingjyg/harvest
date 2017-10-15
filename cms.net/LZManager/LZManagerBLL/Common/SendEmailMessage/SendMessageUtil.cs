using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Net.Mail;
using System.Net;

namespace LZManager.BLL.Common.SendEmailMessage
{
    public class SendMessageUtil
    {

        /// <summary>
        /// 访问URL地址,获得页面内容
        /// add by guoxu 2012-05-29
        /// </summary>
        /// <param name="url"></param>
        /// <param name="postDataStr"></param>
        /// <param name="Encod"></param>
        /// <returns></returns>
        public static string getUrlbody(string url, string postDataStr, Encoding Encod)
        {
            string rStr = "";
            System.Net.WebRequest req = null;
            System.Net.WebResponse resp = null;
            System.IO.Stream os = null;
            System.IO.StreamReader sr = null;
            try
            {
                //创建连接
                req = System.Net.WebRequest.Create(url);
                //设置访问方式和发送的请求数据的内容类型
                if (string.IsNullOrEmpty(postDataStr))
                {
                    req.ContentType = "application/x-www-form-urlencoded";
                    req.Method = "GET";
                }
                else
                {
                    req.ContentType = "application/x-www-form-urlencoded";
                    req.Method = "POST";
                    if (Encod == null)
                    {
                        Encod = System.Text.Encoding.Default;
                    }
                    byte[] bytes = Encod.GetBytes(postDataStr);
                    req.ContentLength = bytes.Length;
                    os = req.GetRequestStream();
                    os.Write(bytes, 0, bytes.Length);
                    os.Close();
                }

                //读取返回结果
                resp = req.GetResponse();
                sr = new System.IO.StreamReader(resp.GetResponseStream(), Encod);
                rStr = sr.ReadToEnd();
            }
            catch (Exception ex1)
            {

            }
            finally
            {
                try
                {
                    //关闭资源
                    if (os != null)
                    {
                        os.Dispose();
                        os.Close();
                    }
                    if (sr != null)
                    {
                        sr.Dispose();
                        sr.Close();
                    }
                    if (resp != null)
                    {
                        resp.Close();

                    }
                    if (req != null) req = null;
                }
                catch (Exception ex2)
                {
                    
                }
            }
            return rStr;
        }


        #region EMAIL

        [Serializable]
        public class EmailMessageAdapter
        {

            public void SendEmail(string emailSubject, string emailBody, IEnumerable<string> toEmail)
            {
                EmailParamter emailPara = new EmailParamter();

                SendEmail(emailPara, emailSubject, emailBody, toEmail);
            }

            public void SendEmail(EmailParamter emailPara, string emailSubject, string emailBody, IEnumerable<string> toEmail)
            {
                if (string.IsNullOrEmpty(ConfigurationManager.AppSettings["EmailFromAddress"]))
                    throw new ArgumentException("web.config配置文件中没有配置EmailFromAddress项,请检查配置文件");
                if (string.IsNullOrEmpty(emailSubject))
                    throw new ArgumentException("参数emailSubject不能为空，请检查参数");
                if (string.IsNullOrEmpty(emailBody))
                    throw new ArgumentException("参数emailBody不能为空，请检查参数");
                if (toEmail == null || toEmail.Count() == 0)
                    throw new ArgumentException("参数toEmail不能为空，请检查参数");

                string emailFrom = ConfigurationManager.AppSettings["EmailFromAddress"];

                MailMessage result = new MailMessage();

                result.Body = emailBody;
                result.IsBodyHtml = true;
                result.From = new MailAddress(emailFrom, "联众游戏");
                result.Priority = MailPriority.High;

                result.Subject = emailSubject;

                foreach (var item in toEmail)
                {
                    result.To.Add(new MailAddress(item));
                }

                using (SmtpClient client = emailPara.ToSmtpClient())
                {
                    try
                    {
                        client.Send(result);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
        }
        [Serializable]
        public class EmailParamter
        {
            private int _Port;
            public int Port
            {
                get
                {
                    if (_Port == default(int))
                    {
                        string strPort = ConfigurationManager.AppSettings["emailPort"];
                        if (string.IsNullOrEmpty(strPort))
                            _Port = 25;
                        else if (!int.TryParse(strPort, out _Port))
                            throw new ArgumentException("web.config配置文件中配置项emailPort项必须是int型，请检查配置文件");

                    }
                    return _Port;
                }
            }

            public string Server { get; private set; }

            public string LoginName { get; private set; }

            public string LoginPwd { get; private set; }

            public bool UseDefaultCredentials { get; private set; }

            public string Domain { get; private set; }

            public EmailParamter()
            {
                Server = ConfigurationManager.AppSettings["emailServer"];
                LoginName = ConfigurationManager.AppSettings["emailLoginName"];
                LoginPwd = ConfigurationManager.AppSettings["emailLoginPwd"];

                Domain = ConfigurationManager.AppSettings["emailDomain"];

                if (string.IsNullOrEmpty(ConfigurationManager.AppSettings["UseDefaultCredentials"]))
                    UseDefaultCredentials = false;
                else
                {
                    UseDefaultCredentials = bool.Parse(ConfigurationManager.AppSettings["UseDefaultCredentials"]);
                }
            }

            public SmtpClient ToSmtpClient()
            {
                int port = this.Port;

                if (port == 0)
                    port = 25;

                SmtpClient client = new SmtpClient(Server, port);

                client.UseDefaultCredentials = this.UseDefaultCredentials;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.EnableSsl = true;

                if (this.UseDefaultCredentials)
                {
                    client.Credentials = CredentialCache.DefaultNetworkCredentials;
                }
                else
                {
                    client.Credentials = new NetworkCredential(this.LoginName, this.LoginPwd, this.Domain);
                }

                return client;
            }
        }

        #endregion
    }
}
