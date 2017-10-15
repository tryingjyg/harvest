using System;
using System.Collections.Generic;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Web.UI;
using System.Text;
using System.Text.RegularExpressions;

namespace LZWebApp.BLL.Roulette
{
    public class Jswork
    {
        #region 新版本
        /// <summary>
        /// 弹出JavaScript小窗口
        /// </summary>
        /// <param name="message">窗口信息</param>
        /// <param name="page">Page类的实例</param>
        public static void Alert(string message, Page page)
        {
            #region
            string js = @"<Script language='JavaScript'>
                    alert('" + message + "');</Script>";
            if (!page.ClientScript.IsStartupScriptRegistered(page.GetType(), "alert"))
            {
                page.ClientScript.RegisterStartupScript(page.GetType(), "alert", js);
            }
            #endregion
        }

        /// <summary>
        /// 弹出消息框并且转向到新的URL
        /// </summary>
        /// <param name="message">消息内容</param>
        /// <param name="toURL">连接地址</param>
        /// <param name="page">Page类的实例</param> 
        public static void AlertAndRedirect(string message, string toURL, Page page)
        {
            #region
            string js = "<script language=javascript>alert('" + message + "');window.location='" + toURL + "';</script>";
            if (!page.ClientScript.IsStartupScriptRegistered(page.GetType(), "AlertAndRedirect"))
            {
                page.ClientScript.RegisterStartupScript(page.GetType(), "AlertAndRedirect", js);
            }
            #endregion
        }
        /// <summary>
        /// 回到历史页面
        /// </summary>
        /// <param name="value">-1/1</param>
        /// <param name="page">Page类的实例</param> 
        public static void GoHistory(int value, Page page)
        {
            #region
            string js = @"<Script language='JavaScript'>
                    history.go('" + value + "');</Script>";
            if (!page.ClientScript.IsStartupScriptRegistered(page.GetType(), "GoHistory"))
            {
                page.ClientScript.RegisterStartupScript(page.GetType(), "GoHistory", js);
            }
            #endregion
        }
        /// <summary>
        /// 回到历史页面弹出提示
        /// </summary>
        /// <param name="value">-1/1</param>
        /// <param name="page">Page类的实例</param> 
        public static void GoHistoryAlert(string message, int value, Page page)
        {
            #region
            string js = @"<Script language='JavaScript'>
                    alert('" + message + "');history.go('" + value + "');</Script>";
            if (!page.ClientScript.IsStartupScriptRegistered(page.GetType(), "GoHistory"))
            {
                page.ClientScript.RegisterStartupScript(page.GetType(), "GoHistory", js);
            }
            #endregion
        }
        /// <summary>
        /// 刷新父窗口
        /// </summary>
        /// <param name="url">要刷新的url</param>
        /// <param name="page">Page类的实例</param>
        public static void RefreshParent(string url, Page page)
        {
            #region
            string js = @"<Script language='JavaScript'>
                    window.opener.location.href='" + url + "';window.close();</Script>";
            //HttpContext.Current.Response.Write(js);
            if (!page.ClientScript.IsStartupScriptRegistered(page.GetType(), "RefreshParent"))
            {
                page.ClientScript.RegisterStartupScript(page.GetType(), "RefreshParent", js);
            }
            #endregion
        }


        /// <summary>
        /// 刷新打开窗口
        /// </summary>
        /// <param name="page">Page类的实例</param>
        public static void RefreshOpener(Page page)
        {
            #region
            string js = @"<Script language='JavaScript'>
                    opener.location.reload();
                  </Script>";
            //HttpContext.Current.Response.Write(js);
            if (!page.ClientScript.IsStartupScriptRegistered(page.GetType(), "RefreshOpener"))
            {
                page.ClientScript.RegisterStartupScript(page.GetType(), "RefreshOpener", js);
            }
            #endregion
        }


        /// <summary>
        /// 打开指定大小的新窗体
        /// </summary>
        /// <param name="url">地址</param>
        /// <param name="width">宽</param>
        /// <param name="heigth">高</param>
        /// <param name="top">头位置</param>
        /// <param name="left">左位置</param>
        /// <param name="page">Page类的实例</param>
        public static void OpenWebFormSize(string url, int width, int heigth, int top, int left, Page page)
        {
            #region
            string js = @"<Script language='JavaScript'>window.open('" + url + @"','','height=" + heigth + ",width=" + width + ",top=" + top + ",left=" + left + ",location=no,menubar=no,resizable=yes,scrollbars=yes,status=yes,titlebar=no,toolbar=no,directories=no');</Script>";
            //HttpContext.Current.Response.Write(js);
            if (!page.ClientScript.IsStartupScriptRegistered(page.GetType(), "OpenWebFormSize"))
            {
                page.ClientScript.RegisterStartupScript(page.GetType(), "OpenWebFormSize", js);
            }
            #endregion
        }


        /// <summary>
        /// 转向Url制定的页面
        /// </summary>
        /// <param name="url">连接地址</param>
        /// <param name="page">Page类的实例</param>
        public static void JavaScriptLocationHref(string url, Page page)
        {
            #region
            string js = @"<Script language='JavaScript'>
                    window.location.replace('{0}');
                  </Script>";
            js = string.Format(js, url);
            if (!page.ClientScript.IsStartupScriptRegistered(page.GetType(), "JavaScriptLocationHref"))
            {
                page.ClientScript.RegisterStartupScript(page.GetType(), "JavaScriptLocationHref", js);
            }
            #endregion
        }
        ///  <summary>
        ///  向当前页面动态输出客户端脚本代码
        /// </summary>
        ///  <param name="javascript">javascript脚本段</param>
        /// <param name="page">Page类的实例</param>
        ///  <param name="afterForm">是否紧跟在&lt;form&gt;标记之后输出javascript脚本，如果不是则在&lt;/form&gt;标记之前输出脚本代码</param>
        public static void AppendScript(string javascript, Page page, bool afterForm)
        {
            if (afterForm)
            {
                page.ClientScript.RegisterClientScriptBlock(page.GetType(), page.ToString(), javascript);
            }
            else
            {
                page.ClientScript.RegisterStartupScript(page.GetType(), page.ToString(), javascript);
            }
        }
        #endregion
        /// <summary>
        /// 弹出JavaScript小窗口
        /// </summary>
        public static void Alert(string message)
        {
            string js = "<script language='JavaScript'>alert('{0}');history.go(-1);</script>";
            HttpContext.Current.Response.Write(string.Format(js, message));
        }
        /// <summary>
        /// 弹出消息框并且转向到新的URL
        /// </summary>
        public static void Alert(string message, string toURL)
        {
            string js = "<script language='JavaScript'>alert('{0}');window.location.replace('{1}')</script>";
            HttpContext.Current.Response.Write(string.Format(js, message, toURL));
        }
        /// <summary>
        /// 弹出消息框并且转向到指定FRAME的新URL
        /// </summary>
        public static void Alert(string message, string frame, string toURL)
        {
            string js = "<script language='JavaScript'>alert('{0}');{1}.location.replace('{2}')</script>";
            HttpContext.Current.Response.Write(string.Format(js, message, frame, toURL));
        }
        /// <summary>
        /// 回到历史页面
        /// </summary>
        public static void GoHistory(int value)
        {
            string js = "<script language='JavaScript'>history.go({0});</script>";
            HttpContext.Current.Response.Write(string.Format(js, value));
        }
        /// <summary>
        /// 关闭当前窗口
        /// <summary>
        public static void CloseWindow()
        {
            string js = "<script language='JavaScript'>parent.opener=null;window.close();</script>";
            HttpContext.Current.Response.Write(js);
            HttpContext.Current.Response.End();
        }
        /// <summary>
        /// 父窗口打开指定页面
        /// </summary>
        public static void RefreshParent(string url)
        {
            string js = "<script language='JavaScript'>window.opener.location.href='{0}';window.close();</script>";
            HttpContext.Current.Response.Write(string.Format(js, url));
        }
        /// <summary>
        /// 刷新窗口
        /// </summary>
        public static void RefreshWindow()
        {
            string js = "<script language='JavaScript'>opener.location.reload();</script>";
            HttpContext.Current.Response.Write(js);
        }
        /// <summary>
        /// 时间截取
        /// </summary>
        public static string subDate(object Time)
        {
            //判断数据是否为空,否则不执行转换
            if (!(string.IsNullOrEmpty(Time.ToString())))
            {
                DateTime ttime = Convert.ToDateTime(Time);
                return ttime.ToString("yyyy-MM-dd");
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 年份截取
        /// </summary>
        public static string subYear(object Time)
        {
            //判断数据是否为空,否则不执行转换
            if (!(string.IsNullOrEmpty(Time.ToString())))
            {
                DateTime ttime = Convert.ToDateTime(Time);
                return ttime.ToString("yyyy");
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 月份截取
        /// </summary>
        public static string subMonth(object Time)
        {
            //判断数据是否为空,否则不执行转换
            if (!(string.IsNullOrEmpty(Time.ToString())))
            {
                DateTime ttime = Convert.ToDateTime(Time);
                return ttime.ToString("MM");
            }
            else
            {
                return null;
            }
        }
        /// 打开指定大小的新窗体
        /// </summary>
        public static void OpenWindow(string url, int width, int heigth, int top, int left)
        {
            string js = "<script language='JavaScript'>window.open('{0}', '', 'width={1}, height={2}, top={3}, left={4}, location=no, menubar=no, resizable=yes, scrollbars=yes, status=yes, titlebar=no, toolbar=no, directories=no');</script>";
            HttpContext.Current.Response.Write(string.Format(js, url, width, heigth, top, left));

        }
    }
}
