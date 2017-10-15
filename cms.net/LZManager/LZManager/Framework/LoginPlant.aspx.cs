using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using LZManager.BLL.Common;
using System.Configuration;
using LZWebApp.BLL.Roulette;
using System.IO;

namespace LZManager.Frameworks
{
    public partial class LoginPlant : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InsertLog("获取登录用户GetUserID", string.Format("GetUserID:{0}, GetUserLoginName:{1}", GetUserID(), GetUserLoginName()), 0, GetPlatformIdByValue(1));

                if (GetUserID() == "")
                {
                    Response.Write("<script>top.location.href = '../Login.aspx' </script>");
                }
                else
                {
                    try
                    {
                        if (GetUser().UrId == "")
                        {
                            Response.Write("<script>top.location.href = '../Login.aspx' </script>");
                        }
                    }
                    catch(Exception ex)
                    {
                        Response.Write("<script>top.location.href = '../Login.aspx' </script>");
                    }
                }
                BindddlPlatformList(0);
            }
        }

        /// <summary>
        /// 判断是否有访问该游戏的权限
        /// </summary>
        /// <param name="Pf_id"></param>
        /// <param name="Pf_name"></param>
        ///  /// <param name="Pf_text1">英文的备用字段</param>
        /// <param name="Pf_imgUrl"></param>
        /// <param name="id"></param>
        /// <param name="Pf_isRepair"></param>
        /// <param name="Pf_imgWaterUrl"></param>
        /// <returns></returns>
        public string GetMessage(object Pf_id, object Pf_name,object Pf_text1,object Pf_imgUrl, object id, object Pf_isRepair, object Pf_imgWaterUrl)
        {

            try
            {
                //  判断图片地址是否存在
                string filename = Server.MapPath(Pf_imgUrl.ToString());
                if (!File.Exists(filename)) // 不存在
                {
                    Pf_imgWaterUrl = "Themes/Images/lianzhong.jpg";
                }

                DataRow[] dr = GetRoleTable().Select("Rl_name = '" + ConfigurationManager.AppSettings["WeiHuRoleName"].ToString() + "'");
                if (dr.Length > 0) // 证明有工程师权限
                {
                    Pf_isRepair = "0";
                }

                if (Pf_isRepair.ToString() == "0" || Pf_isRepair.ToString() == "") // 正常
                {
                    if (id.ToString() == "0") // 图片
                    {
                        if (IsLanguageEng())
                        {
                            return "<a href=\"javascript:void()\" onclick=\"onLinkPlatform('" + Pf_text1 + "','" + Pf_id + "')\"><div style=\" background:url('" + Pf_imgWaterUrl + "'); width: 120px; height: 120px; border: #33aa33; background-size: cover; \" id='" + Pf_id + "'/></div></a> <script>yj(\"" + Pf_id + "\");</script>";
                            
                        }
                        else
                        {
                            return "<a href=\"javascript:void()\" onclick=\"onLinkPlatform('" + Pf_name + "','" + Pf_id + "')\"><div style=\" background:url('" + Pf_imgWaterUrl + "'); width: 120px; height: 120px; border: #33aa33; background-size: cover; \" id='" + Pf_id + "'/></div></a> <script>yj(\"" + Pf_id + "\");</script>";
                        }
                      
                    }
                    else if (id.ToString() == "1") // 汉字 '" + Pf_imgUrl + "'
                    {
                        if (IsLanguageEng())
                        {
                            return "<a style=\" color:White; text-size:8px; text-decoration:none; \" href=\"javascript:void()\" onclick=\"onLinkPlatform('" + Pf_text1 + "','" + Pf_id + "')  \"> " + Pf_text1 + "</a>";
                        }
                        else
                        {
                            return "<a style=\" color:White; text-size:8px; text-decoration:none; \" href=\"javascript:void()\" onclick=\"onLinkPlatform('" + Pf_name + "','" + Pf_id + "')  \"> " + Pf_name + "</a>";
                        }

                     
                    }
                }
                else // 维护
                {
                    if (id.ToString() == "0") // 图片
                    {
                        return "<a href=\"javascript:void()\" onclick=\"alert('系统维护中,请稍后再试！\"><div style=\" background:url('Themes/Images/lianzhong.jpg'); width: 120px; height: 120px; border: #33aa33; background-size: cover; \" id='" + Pf_id + "'/></div></a> <script>yj(\"" + Pf_id + "\");</script>";
                    }
                    else if (id.ToString() == "1") // 汉字 '" + Pf_imgUrl + "'
                    {

                        if (IsLanguageEng())
                        {
                            return "<span style='color:write'>" + Pf_text1 + "(维护中)" + "</span>";
                            
                        }
                        else
                        {
                            return "<span style='color:write'>" + Pf_name + "(维护中)" + "</span>";
                        }
                       
                    }
                }
                return "";
            }
            catch
            {
                CloseDivImplementation();
                Jswork.Alert("系统异常，请与管理员联系!", "top", ConfigurationManager.AppSettings["WebLoginURL"].ToString());
                return "";
            }
        }

        /// <summary>
        /// 绑定平台列表
        /// </summary>
        private void BindddlPlatformList(int curPage)
        {
            if (curPage < 0)
            {
                curPage = 0; // 设置初始值
            }
            int pagesize = 15;

            DataTable dt = GetPlatformTableByUserid();
            System.Web.UI.WebControls.PagedDataSource ps = new PagedDataSource();//实例化分页数据源
            ps.DataSource = dt.DefaultView;//将要绑定在datalist上的datatable给分页数据源
            ps.AllowPaging = true;
            ps.PageSize = pagesize;//每页显示几条记录
            ps.CurrentPageIndex = curPage;//设置当前页的索引(当前页码减1就是)

            AspNetPager1.RecordCount = dt.Rows.Count;
            AspNetPager1.PageSize = pagesize;

            ddlPlatformList.DataSource = ps;
            ddlPlatformList.DataBind();
        }

        /// <summary>
        /// 翻页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            BindddlPlatformList(AspNetPager1.CurrentPageIndex-1);
        }
    }
}