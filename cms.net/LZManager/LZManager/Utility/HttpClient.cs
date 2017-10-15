using System.IO;
using System.Net;
using System.Text;


namespace LZManager.Utility
{
    public class HttpClientUlity
    {
        public static string Post(string url, string body)
        {
            string contentType = "application/octet-stream;charset=UTF-8";
            return HttpClientUlity.Post(url, body, contentType);
        }
        public static string Post(string url, string body, string contentType)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ContentType = contentType;
            httpWebRequest.Method = "POST";
            httpWebRequest.Timeout = 20000;

            byte[] btBodys = Encoding.UTF8.GetBytes(body);
            httpWebRequest.ContentLength = btBodys.Length;
            httpWebRequest.GetRequestStream().Write(btBodys, 0, btBodys.Length);

            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
            string responseContent = streamReader.ReadToEnd();

            httpWebResponse.Close();
            streamReader.Close();
            httpWebRequest.Abort();
            httpWebResponse.Close();

            return responseContent;
        }
        //异步通知接受
        public static string Post(string url)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);

            httpWebRequest.Method = "POST";
            Stream stream;
            stream = httpWebRequest.GetRequestStream();
            StreamReader reader = new StreamReader(stream);
            string responseContent = reader.ReadToEnd();
            stream.Close();
            return responseContent;
        }
        public static string getResponseUrl(string url, string body)
        {
            string contentType = "application/octet-stream;charset=UTF-8";
            return HttpClientUlity.getResponseUrl(url, body, contentType);
        }

        public static string getResponseUrl(string url, string body, string contentType)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ContentType = contentType;
            httpWebRequest.Method = "POST";
            httpWebRequest.Timeout = 20000;

            byte[] btBodys = Encoding.UTF8.GetBytes(body);
            httpWebRequest.ContentLength = btBodys.Length;
            httpWebRequest.GetRequestStream().Write(btBodys, 0, btBodys.Length);

            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            string ResponseUrl = httpWebResponse.ResponseUri.ToString();


            httpWebResponse.Close();

            httpWebRequest.Abort();
            httpWebResponse.Close();

            return ResponseUrl;
        }
        
        /// <summary>
        /// post json 数据
        /// </summary>
        /// <param name="url"></param>
        /// <param name="jsonData"></param>
        /// <returns></returns>
        public static string PostJsonData(string url, string jsonData)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = jsonData.Length;
            StreamWriter writer = new StreamWriter(request.GetRequestStream(), Encoding.ASCII);
            writer.Write(jsonData);
            writer.Flush();

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string encoding = response.ContentEncoding;
            if (encoding == null || encoding.Length < 1)
            {
                encoding = "UTF-8"; //默认编码  
            }
            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(encoding));
            string retString = reader.ReadToEnd();
            return retString;
        }
    }
}