using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Web.SessionState;
using LZManager.BLL;
using LZManager.Common;
using LZManager.DAL;
using MySql.Data.MySqlClient;

namespace LZManager.Role
{
    /// <summary>
    /// PermissionsTatalTree 的摘要说明
    /// </summary>
    public class PermissionsTatalTree : IHttpHandler, IReadOnlySessionState
    {
        ModuleManage mdManage = new ModuleManage();
        RoleModuleManage rlmdManage = new RoleModuleManage();
        PermissionsTatalManage ptManage = new PermissionsTatalManage();

        private string _roleID = null;
        /// <summary>
        /// 角色ID
        /// </summary>
        public string RoleID
        {
            get
            {
                if (_roleID == null)
                    _roleID = HttpContext.Current.Request.QueryString["RoleID"].Trim();
                return _roleID;
            }
        }
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

        private string _PlatformID = null;

        public string PlatformID
        {
            get
            {
                if (_PlatformID == null)
                    _PlatformID = HttpContext.Current.Request.QueryString["PlatformID"].Trim();
                return _PlatformID;
            }

        }

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write(BindTreeView().ToString());
        }

        protected StringBuilder BindTreeView()
        {
            string a = PlatformID;
            StringBuilder str = new StringBuilder();
            str.Append(ParentID + "_Child|||");
            List<ModuleEO> modellist = new List<ModuleEO>();
            //得到模块权限和角色的列表
            List<RolemoduleEO> rmplist = new List<RolemoduleEO>();
            rmplist = (List<RolemoduleEO>)System.Web.HttpContext.Current.Session["RmpList"];

            //modellist = (List<ModuleEO>)mdManage.Get("Md_parentid='" + ParentID + "' AND Md_deleteFlag<>1 ORDER BY Md_filedOrder");
            IList<MySqlParameter> parm = new List<MySqlParameter>();
            StringBuilder strWhere = new StringBuilder();
            strWhere.Append("  Md_parentid=@Md_parentid  AND Md_deleteFlag<>1 ORDER BY Md_filedOrder");
            parm.Add(new MySqlParameter("@Md_parentid", ParentID));
            modellist = (List<ModuleEO>)mdManage.Get(strWhere.ToString(), parm);

            foreach (ModuleEO model in modellist)
            {
                //是否有下级内容
                bool IsChild = true;
                IList<MySqlParameter> parmC = new List<MySqlParameter>();
                StringBuilder strWhereC = new StringBuilder();
                strWhereC.Append("  Md_parentid=@Md_parentid and Md_existsTreeView='1' AND Md_deleteFlag<>1 ORDER BY Md_filedOrder");
                parmC.Add(new MySqlParameter("@Md_parentid", model.MdId));
                if (mdManage.Get(strWhereC.ToString(), parmC) != null)
                //if (mdManage.Get("Md_parentid='" + model.MdId + "'and Md_existsTreeView='1' AND Md_deleteFlag<>1 ORDER BY Md_filedOrder") != null)
                {
                    IsChild = true;
                }
                else
                {
                    IsChild = false;
                }

                //最外层div格式
                if (IsChild)
                {
                    str.Append("<div id=" + model.MdId + " class=\"moduleChildYes\">");
                }
                else
                {
                    str.Append("<div id=" + model.MdId + " class=\"moduleChildNo\">");
                }
                //最外层div中，顶级模块表格式
                str.Append("<table class=\"ModuleTeble\">");
                str.Append("<tr>");
                str.Append("<td><div class=\"MapShow\" id=\"" + model.MdId + "_Map\"></div></td>");
                if (IsChild)
                {

                    if (model.MdImgUrl == "")
                    {
                        str.Append("<td></td>");
                    }
                    else
                    {
                        str.Append("<td><img src=\"" + model.MdImgUrl + "\" onclick=\"javascrpt:TreeViewSpread('" + model.MdId + "','0','" + RoleID + "')\"/ ></td>");
                    }
                    if (PubFuncs.IsLanguageEng())
                    {
                        str.Append("<td><div class=\"ChildTitleYes\"><a href=\"#\"  onclick=\"javascrpt:TreeViewSpread('" + model.MdId + "','0','" + RoleID + "')\" >" + model.MdText1.Trim() + "</a></td>");
                    }
                    else
                    {
                        str.Append("<td><div class=\"ChildTitleYes\"><a href=\"#\"  onclick=\"javascrpt:TreeViewSpread('" + model.MdId + "','0','" + RoleID + "')\" >" + model.MdName.Trim() + "</a></td>");
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
                        str.Append("<td><img src=\"" + model.MdImgUrl + "\" onclick=\"javascrpt:TreeViewSpread('" + model.MdId + "','" + model.MdId.Trim() + "_Child','1','" + RoleID + "')\"/ ></td>");
                    }
                    str.Append("<td><div class=\"ChildTitleNo\"><a href=\"#\"  onclick=\"javascrpt:TreeViewSpread('" + model.MdId + "','1','" + RoleID + "')\" >" + model.MdName.Trim() + "</a></div></td>");
                }
                str.Append("</div>");

                //加载权限列表
                List<PermissionstatalEO> plist = new List<PermissionstatalEO>();


                StringBuilder strWhereX = new StringBuilder();
                strWhereX.Append(" 1=1");
                IList<MySqlParameter> parmX = new List<MySqlParameter>();
                strWhereX.Append(" and APerTat.Pt_del<>1 and APerTat.Pf_id=@Pf_id and AMoudlePer.Md_id = @Md_id");
                parmX.Add(new MySqlParameter("@Pf_id", PlatformID));
                parmX.Add(new MySqlParameter("@Md_id", model.MdId));
                plist = (List<PermissionstatalEO>)ptManage.Gets(strWhereX.ToString(),parmX);
                //plist = (List<PermissionstatalEO>)ptManage.Gets(" APerTat.Pt_del<>1 and APerTat.Pf_id='" + PlatformID + "' and AMoudlePer.Md_id = '" + model.MdId + "'");
                //List<RolemoduleEO> mplist = new List<RolemoduleEO>();
                string permissionsIdList = "";
                int int_ls = 0;
                StringBuilder strls = new StringBuilder();
                foreach (PermissionstatalEO mpmodel in plist)
                {
                    int_ls++;

                    StringBuilder strWhereL = new StringBuilder();
                    strWhereL.Append(" 1=1");
                    IList<MySqlParameter> parmL = new List<MySqlParameter>();
                    strWhereL.Append(" and Rl_id=@Rl_id and  Md_id=@Md_id and Pt_id=@Pt_id");
                    parmL.Add(new MySqlParameter("@Rl_id", RoleID));
                    parmL.Add(new MySqlParameter("@Md_id", model.MdId));
                    parmL.Add(new MySqlParameter("@Pt_id", mpmodel.PtId));

                    if (rlmdManage.GetTable(strWhereL.ToString(),parmL).Rows.Count > 0)
                    //if (rlmdManage.GetTable("Rl_id='" + RoleID + "' and  Md_id='" + model.MdId + "' and Pt_id='" + mpmodel.PtId + "'").Rows.Count > 0)
                    {
                        strls.Append("<input type=\"checkbox\" id=\"" + model.MdId + "_" + mpmodel.PtId + "\" checked=\"checked\" value=\"" + ISPermName(mpmodel.PtId, plist) + "\" onclick=\"Permsave('0','" + model.MdId + "','" + RoleID + "','" + mpmodel.PtId + "','" + PlatformID + "')\" />");
                        strls.Append("<span onclick=\"Permsave('0','" + model.MdId + "','" + RoleID + "','" + mpmodel.PtId + "','" + PlatformID + "')\">" + ISPermName(mpmodel.PtId, plist) + "</span>");
                    }
                    else
                    {
                        strls.Append("<input type=\"checkbox\" id=\"" + model.MdId + "_" + mpmodel.PtId + "\" value=\"" + ISPermName(mpmodel.PtId, plist) + "\" onclick=\"Permsave('0','" + model.MdId + "','" + RoleID + "','" + mpmodel.PtId + "','" + PlatformID + "')\" />");
                        strls.Append("<span onclick=\"Permsave('0','" + model.MdId + "','" + RoleID + "','" + mpmodel.PtId + "','" + PlatformID + "')\">" + ISPermName(mpmodel.PtId, plist) + "</span>");
                    }
                    if (int_ls == 1)
                        permissionsIdList += mpmodel.PtId;
                    else
                        permissionsIdList += "|" + mpmodel.PtId;

                }
                if (int_ls != 0)
                {
                    str.Append("<td><div class=\"chackall\"><input type=\"checkbox\" id=\"" + model.MdId + "_all\" value=\"\" style=display:none onclick=\"Permsave('1','" + model.MdId + "','" + RoleID + "','','" + PlatformID + "')\"/><span>&nbsp;</span></div></td>");
                    str.Append("<td><div class=\"check\">");
                    str.Append(strls.ToString());
                    str.Append("</div><input type=\"hidden\" id=\"" + model.MdId + "_hidden\" value=\"" + permissionsIdList + "\">");
                    str.Append("</td>");
                }
                int_ls = 0;
                str.Append("</tr>");
                str.Append("</table>");

                //下级最外层Div格式
                if (IsChild)
                {
                    str.Append("<div id=\"" + model.MdId.Trim() + "_Child\"  class=\"moduleChild\" style=\"display:none;\"></div>");
                }
                str.Append("</div>");
            }
            return str;
        }

        private string ISPermName(string Permassions, List<PermissionstatalEO> plist)
        {
            foreach (PermissionstatalEO p in plist)
            {
                if (p.PtId == Permassions.Trim())
                {
                    return p.PtName;
                }
            }
            return "";
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}