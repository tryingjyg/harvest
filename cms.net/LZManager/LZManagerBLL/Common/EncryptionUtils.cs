using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using TinyFx;
using TinyFx.Security;
using System.Security.Cryptography;
using TinyFx.Logging;

namespace LZManager.BLL.Common
{
    /// <summary>
    /// DES加密、解密、自定义加密、自定义解密
    /// </summary>
    public class EncryptionUtils
    {
        #region  DES加密，解密
        public static string CreateToken(IEnumerable<string> values, byte[] desKey, byte[] desIV, string md5Key)
        {
            const string seperaor = "@";
            var md5ValidateValue = MD5Crypto.Hash(string.Concat(values) + md5Key, Encoding.UTF8);
            var desString = string.Format("{0}@{1}", string.Join(seperaor, values), md5ValidateValue);
            var result = EncryptionUtils.Encrypt(desKey, desIV, desString);

            return result;
        }

        public static bool TryParseToken(string token, byte[] desKey, byte[] desIV, string md5Key, out string[] values)
        {
            const char seperator = '@';
            values = null;

            try
            {
                if (string.IsNullOrEmpty(token)) return false;
                var dESencryptResult = Decrypt(desKey, desIV, token);
                if (string.IsNullOrEmpty(dESencryptResult)) return false;
                string[] result = dESencryptResult.Split(seperator);

                string source = string.Empty;
                for (int i = 0; i < result.Length - 1; i++)
                    source += result[i];

                if (result[result.Length - 1] == MD5Crypto.Hash(source + md5Key, Encoding.UTF8))
                {
                    values = result;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                LoggerFactory.Create("Info").Write("解析token失败,Token =" + token);
                return false;
            }
        }

        /// <summary>
        /// 标准的DES加密
        /// </summary>
        /// <param name="value">预加密值</param>
        /// <returns>返回已加密值</returns>
        public static string Encrypt(byte[] desKey, byte[] desIV, string value)
        {
            if (desKey.Length == 24) //3des
            {
                var crypto = new SymmetricCrypto(SymmetricMode.TripleDES, desKey, Encoding.ASCII);
                crypto.Mode = CipherMode.ECB;
                crypto.Padding = PaddingMode.PKCS7;
                return crypto.Encrypt(value);
            }
            else
            {
                using (DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider())
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        CryptoStream cs = new CryptoStream(ms, cryptoProvider.CreateEncryptor(desKey, desIV),
                                                           CryptoStreamMode.Write);
                        StreamWriter sw = new StreamWriter(cs);
                        sw.Write(value);
                        sw.Flush();
                        cs.FlushFinalBlock();
                        ms.Flush();

                        return Convert.ToBase64String(ms.GetBuffer(), 0, (int)ms.Length);
                    }
                }
            }
        }

        /// <summary>
        /// 标准的DES解密
        /// </summary>
        /// <param name="value">预解密值</param>
        /// <returns>已解密值</returns>
        public static string Decrypt(byte[] desKey, byte[] desIV, string value)
        {
            if (desKey.Length == 24) //3des
            {
                var crypto = new SymmetricCrypto(SymmetricMode.TripleDES, desKey, Encoding.ASCII);
                crypto.Mode = CipherMode.ECB;
                crypto.Padding = PaddingMode.PKCS7;
                return crypto.Decrypt(value);
            }
            else
            {
                using (DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider())
                {
                    //从字符串转换为字节组
                    byte[] buffer = Convert.FromBase64String(value);
                    MemoryStream ms = new MemoryStream(buffer);
                    CryptoStream cs = new CryptoStream(ms, cryptoProvider.CreateDecryptor(desKey, desIV),
                                                       CryptoStreamMode.Read);
                    StreamReader sr = new StreamReader(cs);
                    return sr.ReadToEnd();
                }
            }
        }

        #endregion

        #region 自定义加密

        private static string Key = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static byte[] Keys = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };

        /// <summary> 
        /// 使用DES加密指定字符串 
        /// </summary> 
        /// <param name="encryptStr">待加密的字符串 </param> 
        /// <param name="key">密钥(最大长度8) </param> 
        /// <param name="IV">初始化向量(最大长度8) </param> 
        /// <returns>加密后的字符串 </returns> 
        public static string DESEncrypt(string encryptStr, string key, string IV)
        {
            //将key和IV处理成8个字符 
            key += "12345678";
            IV += "12345678";
            key = key.Substring(0, 8);
            IV = IV.Substring(0, 8);

            SymmetricAlgorithm sa;
            ICryptoTransform ict;
            MemoryStream ms;
            CryptoStream cs;
            byte[] byt;

            sa = new DESCryptoServiceProvider();
            sa.Key = Encoding.UTF8.GetBytes(key);
            sa.IV = Encoding.UTF8.GetBytes(IV);
            ict = sa.CreateEncryptor();

            byt = Encoding.UTF8.GetBytes(encryptStr);

            ms = new MemoryStream();
            cs = new CryptoStream(ms, ict, CryptoStreamMode.Write);
            cs.Write(byt, 0, byt.Length);
            cs.FlushFinalBlock();

            cs.Close();

            //加上一些干扰字符 
            string retVal = Convert.ToBase64String(ms.ToArray());
            System.Random ra = new Random();

            for (int i = 0; i < 8; i++)
            {
                int radNum = ra.Next(36);
                char radChr = Convert.ToChar(radNum + 65);//生成一个随机字符 

                retVal = retVal.Substring(0, 2 * i + 1) + radChr.ToString() + retVal.Substring(2 * i + 1);
            }
            return retVal.Replace("+", "%2B");
        }

        /// <summary> 
        /// 使用DES解密指定字符串 
        /// </summary> 
        /// <param name="encryptedValue">待解密的字符串 </param> 
        /// <param name="key">密钥(最大长度8) </param> 
        /// <param name="IV">初始化向量(最大长度8) </param> 
        /// <returns>解密后的字符串 </returns> 
        public static string DESDecrypt(string encryptedValue, string key, string IV)
        {
            //去掉干扰字符 
            string tmp = encryptedValue.Replace("%2B", "+");
            if (tmp.Length < 16)
            {
                return "";
            }

            for (int i = 0; i < 8; i++)
            {
                tmp = tmp.Substring(0, i + 1) + tmp.Substring(i + 2);
            }
            encryptedValue = tmp;

            //将key和IV处理成8个字符 
            key += "12345678";
            IV += "12345678";
            key = key.Substring(0, 8);
            IV = IV.Substring(0, 8);

            SymmetricAlgorithm sa;
            ICryptoTransform ict;
            MemoryStream ms;
            CryptoStream cs;
            byte[] byt;

            try
            {
                sa = new DESCryptoServiceProvider();
                sa.Key = Encoding.UTF8.GetBytes(key);
                sa.IV = Encoding.UTF8.GetBytes(IV);
                ict = sa.CreateDecryptor();

                byt = Convert.FromBase64String(encryptedValue);

                ms = new MemoryStream();
                cs = new CryptoStream(ms, ict, CryptoStreamMode.Write);
                cs.Write(byt, 0, byt.Length);
                cs.FlushFinalBlock();

                cs.Close();

                return Encoding.UTF8.GetString(ms.ToArray());
            }
            catch (System.Exception e)
            {

                return null;
            }
        }

        #endregion

        #region MD5 加密 解密
              
        /// <summary>   
        /// MD5加密   
        /// </summary>   
        /// <param name="strSource">需要加密的字符串</param>   
        /// <returns>MD5加密后的字符串</returns>   
        public string MD5Encrypt(string pToEncrypt, string sKey)
        {
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            byte[] inputByteArray = Encoding.Default.GetBytes(pToEncrypt);
            des.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
            des.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            StringBuilder ret = new StringBuilder();
            foreach (byte b in ms.ToArray())
            {
                ret.AppendFormat("{0:X2}", b);
            }
            ret.ToString();
            return ret.ToString();
        }


        /// <summary>   
        /// MD5解密   
        /// </summary>   
        /// <param name="Source">需要解密的字符串</param>   
        /// <returns>MD5解密后的字符串</returns>   
        public string MD5Decrypt(string pToDecrypt, string sKey)
        {
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();

            byte[] inputByteArray = new byte[pToDecrypt.Length / 2];
            for (int x = 0; x < pToDecrypt.Length / 2; x++)
            {
                int i = (Convert.ToInt32(pToDecrypt.Substring(x * 2, 2), 16));
                inputByteArray[x] = (byte)i;
            }

            des.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
            des.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();

            StringBuilder ret = new StringBuilder();

            return System.Text.Encoding.Default.GetString(ms.ToArray());
        }
        #endregion   

    }
}
