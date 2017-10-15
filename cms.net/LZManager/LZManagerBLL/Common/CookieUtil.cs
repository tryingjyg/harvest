using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace LZManager.BLL.Common
{
    public class CookieUtil
    {
        /// <summary>
        /// 创建Cookie
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public static void CreateCookie(string name, string value)
        {
            var cookie = new HttpCookie(name, value);

            //cookie.Domain = "wpt.com";//ourgame.com
            cookie.Expires = DateTime.Now.AddDays(1);
            cookie.Path = "/";
            HttpContext.Current.Response.AppendCookie(cookie);
        }

        /// <summary>
        /// 更新Cookie(缓存时间1小时)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public static void UpdateCookie(string name, string value)
        {
            var cookie = new HttpCookie(name, value);
            cookie.Expires = DateTime.Now.AddDays(1);
            //cookie.Domain = "wpt.com";//配置文件
            HttpContext.Current.Response.SetCookie(cookie);
        }


        /// <summary>
        /// 获取Cookie
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string GetCookie(string name)
        {
            HttpCookie cookie = HttpContext.Current.Request.Cookies[name];
            if (cookie == null || string.IsNullOrEmpty(cookie.Value))
                return string.Empty;
            else
            {
                UpdateCookie(name, cookie.Value);
                return cookie.Value;
            }
        }

        /// <summary>
        /// 清除Cookie
        /// </summary>
        /// <param name="name"></param>
        public static void RemoveCookie(string name)
        {
            var cookie = new HttpCookie(name, string.Empty);
            //cookie.Domain = "wpt.com";
            cookie.Expires = DateTime.Today.AddYears(-100);
            HttpContext.Current.Response.AppendCookie(cookie);
        }
    }
}
