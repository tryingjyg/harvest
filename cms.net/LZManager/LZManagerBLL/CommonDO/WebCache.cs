using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

/// <summary>
/// Summary description for WebCache
/// </summary>
public class WebCache
{

    /// <summary>
    /// 清除指定的cachKey
    /// </summary>
    /// <param name="cacheKey"></param>
    public static void RemoveCache(string cacheKey)
    {
        System.Web.Caching.Cache objCache = HttpRuntime.Cache;
        objCache.Remove(cacheKey);
    }
    /// <summary>
    /// 获取当前应用程序指定CacheKey的Cache值
    /// </summary>
    /// <param name="CacheKey"></param>
    /// <returns></returns>
    public static object GetCache(string CacheKey)
    {
        System.Web.Caching.Cache objCache = HttpRuntime.Cache;
        return objCache[CacheKey];
    }

    /// <summary>
    /// 设置当前应用程序指定CacheKey的Cache值,过期时间为300秒
    /// </summary>
    /// <param name="CacheKey"></param>
    /// <param name="objObject"></param>
    public static void SetCache(string CacheKey, object cacheValue)
    {
        System.Web.Caching.Cache objCache = HttpRuntime.Cache;
        objCache.Insert(CacheKey, cacheValue, null, DateTime.Now.AddSeconds(1), System.Web.Caching.Cache.NoSlidingExpiration);
    }
    /// <summary>
    /// 设置当前应用程序指定CacheKey的Cache值
    /// </summary>
    /// <param name="cacheKey"></param>
    /// <param name="cacheValue"></param>
    /// <param name="expireTime">过期时间(秒)</param>
    public static void SetCache(string cacheKey, object cacheValue, int expireTime)
    {
        System.Web.Caching.Cache objCache = HttpRuntime.Cache;
        objCache.Insert(cacheKey, cacheValue, null, DateTime.Now.AddSeconds(expireTime), System.Web.Caching.Cache.NoSlidingExpiration);
    }
}

