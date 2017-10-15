using System;
using System.Security.Cryptography;
using System.Text;

namespace LZManager.BLL.Common
{
    public class MdUtil
    {
        public static string ToMd5Hash(string str)
        {
            var md5Hasher = new MD5CryptoServiceProvider();
            var btData = md5Hasher.ComputeHash(Encoding.UTF8.GetBytes(str));
            var sBuilder = new StringBuilder();
            for (var i = 0; i < btData.Length; i++)
            {
                sBuilder.Append(btData[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
    }
}
