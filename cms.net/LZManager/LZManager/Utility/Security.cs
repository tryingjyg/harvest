using System;

namespace LZManager.Utility
{
    public class Security
    {
        public static string MD5(string Text)
        {
            return Security.MD5(Text, false);
        }

        public static string MD5(string Text, Boolean ToUpper)
        {
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(Text);
            try
            {
                System.Security.Cryptography.MD5CryptoServiceProvider check;
                check = new System.Security.Cryptography.MD5CryptoServiceProvider();
                byte[] somme = check.ComputeHash(buffer);
                string ret = "";
                foreach (byte a in somme)
                {
                    if (a < 16)
                        ret += "0" + a.ToString("X");
                    else
                        ret += a.ToString("X");
                }
                if (true == ToUpper)
                {
                    return ret.ToUpper();
                }
                return ret.ToLower();
            }
            catch
            {
                throw;
            }
        }
    }
}