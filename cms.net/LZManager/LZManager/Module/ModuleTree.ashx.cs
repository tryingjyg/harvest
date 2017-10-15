using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using System.Text;
using LZManager.BLL;
using LZManager.DAL;
using MySql.Data.MySqlClient;

namespace LZManager.Module
{
    /// <summary>
    /// ModuleTree 的摘要说明
    /// </summary>
    public class ModuleTree : IHttpHandler, IReadOnlySessionState
    {
        private string _parentID = null;

        public string ParentID
        {
            get
            {
                if (_parentID == null)
                    _parentID = HttpContext.Current.Request.QueryString["ParentID"].Trim();
                return _parentID;
            }
        }

        ModuleManage mdManage = new ModuleManage();

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            StringBuilder str = new StringBuilder();

            str.Append(ParentID + "_Child|||");

            //得到模块列表
            List<ModuleEO> mdEoList = new List<ModuleEO>();
            //mdEoList = (List<ModuleEO>)mdManage.Get("Md_parentid='" + ParentID + "' AND Md_deleteFlag<>1 ORDER BY Md_filedOrder");


            IList<MySqlParameter> parm = new List<MySqlParameter>();
            StringBuilder strWhere = new StringBuilder();
            strWhere.Append("  Md_parentid=@Md_parentid AND Md_deleteFlag<>1 ORDER BY Md_filedOrder");
            parm.Add(new MySqlParameter("@Md_parentid", ParentID));
            mdEoList = (List<ModuleEO>)mdManage.Get(strWhere.ToString(), parm);
            foreach (ModuleEO model in mdEoList)
            {
                //是否有下级内容
                bool IsChild = true;
                //if (mdManage.Get("Md_parentid='" + model.MdId + "' AND Md_deleteFlag<>1 ORDER BY Md_filedOrder") != null)

                IList<MySqlParameter> parmC = new List<MySqlParameter>();
                StringBuilder strWhereC = new StringBuilder();
                strWhereC.Append("  Md_parentid=@Md_parentid AND Md_deleteFlag<>1 ORDER BY Md_filedOrder");
                parmC.Add(new MySqlParameter("@Md_parentid", model.MdId));
                //mdEoList = (List<ModuleEO>)mdManage.Get(strWhereC.ToString(), parmC);
                if (mdManage.Get(strWhereC.ToString(), parmC) != null)
                {
                    IsChild = true;
                }
                else
                {
                    IsChild = false;
                }

                if (IsChild)
                {
                    str.Append("<div id=" + model.MdId + " class=\"moduleChildYes\">");
                }
                else
                {
                    str.Append("<div id=" + model.MdId + " class=\"moduleChildNo\">");
                }
                //表格式
                str.Append("<table class=\"ModuleTeble\">");
                str.Append("<tr>");
                str.Append("<td><div class=\"MapShow\" id=\"" + model.MdId + "_Map\"></div></td>");
                //是否有下级目录
                if (IsChild)
                {
                    if (model.MdImgUrl == "")
                    {
                        str.Append("<td></td>");
                    }
                    else
                    {
                        str.Append("<td><img src=\"" + model.MdImgUrl + "\" onclick=\"javascrpt:TreeViewSpread('" + model.MdId + "','0')\" /></td>");
                    }

                    if (IsLanguageEng())
                    {
                        str.Append("<td ><div class=\"ChildTitleYes\"><a href=\"#\"  onclick=\"javascrpt:TreeViewSpread('" + model.MdId + "','0')\" >" + model.MdText1 + "</a></div></td>");
                    }
                    else
                    {
                        str.Append("<td ><div class=\"ChildTitleYes\"><a href=\"#\"  onclick=\"javascrpt:TreeViewSpread('" + model.MdId + "','0')\" >" + model.MdName.Trim() + "</a></div></td>");
                        
                    }
                 
                }
                else
                {
                    if (model.MdImgUrl == "")
                    {
                        str.Append("<td></td>");
                    }
                    else
                    {
                        str.Append("<td><img src=\"" + model.MdImgUrl + "\" onclick=\"javascrpt:TreeViewSpread('" + model.MdId + "','1')\"/ ></td>");
                    }

                    if (IsLanguageEng())
                    {
                        str.Append("<td><div class=\"ChildTitleNo\"><a href=\"#\"  onclick=\"javascrpt:TreeViewSpread('" + model.MdId + "','1')\" >" + model.MdText1 + "</div></a></td>");
                    }
                    else
                    {
                        str.Append("<td><div class=\"ChildTitleNo\"><a href=\"#\"  onclick=\"javascrpt:TreeViewSpread('" + model.MdId + "','1')\" >" + model.MdName.Trim() + "</div></a></td>");
                    }
                  
                }


                string useflag = model.MdUseFlag.Trim() == "0" ? Resources.Resource.On : Resources.Resource.Off;
                str.Append("<td><div class=\"useFlag\">" + useflag + "</div></td>");
                string ExitsTree = model.MdExistsTreeView.Trim() == "0" ? Resources.Resource.Display_in_the_tree_directory : Resources.Resource.Hide_in_the_tree_directory;
                str.Append("<td><div class=\"exitsTree\">" + ExitsTree + "</div></td>");
                str.Append("<td <div class=\"features\"><a href=\"ModuleEdit.aspx?State=AC&Action=0&ParentID=" + model.MdId + "&ParentName=" + model.MdName + "\">" + Resources.Resource.Add_sub_module + "</a>｜<a href=\"ModuleEdit.aspx?State=U&&Action=1&ModuleID=" + model.MdId + "\">" + Resources.Resource.edit + "</a>｜<a href=\"#\" onclick=\"Process('" + model.MdId + "')\">" + Resources.Resource.delete + "</a></div></td>");
                str.Append("</tr>");
                str.Append("</table>");
                if (IsChild)
                {
                    str.Append("<div id=\"" + model.MdId.Trim() + "_Child\" class=\"moduleChild\" style=\"display:none;\"></div>");
                }
                str.Append("</div>");
            }
            context.Response.Write(str.ToString());
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

        #region 获取cookie返回中文还是英文

        /// <summary>
        /// 判断当前的cookie值来确定是不是使用英语
        /// </summary>
        /// <returns></returns>
        public bool IsLanguageEng()
        {
            bool flag = false;

            HttpCookie cookie1 = HttpContext.Current.Request.Cookies["langCook"];

            if (cookie1 != null && cookie1.Values["lang"] == "en-us")
            {

                flag = true;
            }

            return flag;
        }

        #endregion
    }
}