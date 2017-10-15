using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;
using LZManager.BLL.Common;
using LZManager.DAL;
using LZManager.BLL;
using MySql.Data.MySqlClient;

namespace LZManager.Role
{
    public partial class RoleModuleEdit : BasePage
    {
        ModuleManage mdManage = new ModuleManage();
        RoleModuleManage rlmdManage = new RoleModuleManage();
        PermissionsTatalManage ptManage = new PermissionsTatalManage();

        private string _roleID = "0";

        private string _PlatformID = "0";

        public string RoleID
        {
            get
            {
                if (_roleID == "0")
                    _roleID = Request.QueryString["Rlid"].Trim();
                return _roleID;
            }
        }

        public string PlatformID
        {
            get
            {
                if (_PlatformID == "0")
                    _PlatformID = Request.QueryString["Pfid"].Trim();
                return _PlatformID;
            }
        }


        private List<RolemoduleEO> rmpermList;

        public List<RolemoduleEO> RmpermList
        {
            get
            {
                if (rmpermList == null)
                    rmpermList = (List<RolemoduleEO>)rlmdManage.Get("Rl_id='" + RoleID + "'");                   

                return rmpermList;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            GetAuthorityUrl(this.Page, "Role/RoleList.aspx", 1);

            if (!IsPostBack)
            {
                BindTreeView();
            }
        }

        protected void BindTreeView()
        {
            StringBuilder str = new StringBuilder();
            List<ModuleEO> modellist = new List<ModuleEO>();
            //得到模块权限和角色的列表
            List<RolemoduleEO> rmplist = new List<RolemoduleEO>();
            rmplist = (List<RolemoduleEO>)Session["RmpList"];
            IList<MySqlParameter> parm = new List<MySqlParameter>();
            StringBuilder strWhere = new StringBuilder();
            strWhere.Append("  Pf_id = @Pf_id AND Md_parentid='0' AND Md_deleteFlag <>1 ORDER BY Md_filedOrder");
            parm.Add(new MySqlParameter("@Pf_id", PlatformID));

            //modellist = (List<ModuleEO>)mdManage.Get(" Pf_id = '" + PlatformID + "' AND Md_parentid='0' AND Md_deleteFlag <>1 ORDER BY Md_filedOrder");
            modellist = (List<ModuleEO>)mdManage.Get(strWhere.ToString(), parm);
            foreach (ModuleEO model in modellist)
            {
                //是否有下级内容
                bool IsChild = true;
                //if (mdManage.Get("Md_parentid='" + model.MdId + "' AND Md_deleteFlag <>1 ORDER BY Md_filedOrder") != null)
                IList<MySqlParameter> parmC = new List<MySqlParameter>();
                StringBuilder strWhereC = new StringBuilder();
                strWhereC.Append("  Md_parentid=@Md_parentid AND Md_deleteFlag <>1 ORDER BY Md_filedOrder");
                parmC.Add(new MySqlParameter("@Md_parentid", model.MdId));
                if (mdManage.Get(strWhereC.ToString(), parmC) != null)
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
                    str.Append("<div id=" + model.MdId + " class=\"TopParentDivYes\">");
                }
                else
                {
                    str.Append("<div id=" + model.MdId + " class=\"TopParentDivNo\">");
                }

                //最外层div中，顶级模块表格式
                str.Append("<table class=\"TopModuleTeble\">");
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
                        str.Append("<td><img src=\"" + model.MdImgUrl + "\" onclick=\"javascrpt:TreeViewSpread('" + model.MdId + "','0','" + RoleID + "','" + PlatformID + "')\" /></td>");
                    }
                    if (IsLanguageEng())
                    {
                        str.Append("<td><div class=\"TopParentTitleYes\"><a href=\"#\"  onclick=\"javascrpt:TreeViewSpread('" + model.MdId + "','0','" + RoleID + "','" + PlatformID + "')\" >" + model.MdText1.Trim() + "</a></div></td>");
                    }
                    else
                    {
                        str.Append("<td><div class=\"TopParentTitleYes\"><a href=\"#\"  onclick=\"javascrpt:TreeViewSpread('" + model.MdId + "','0','" + RoleID + "','" + PlatformID + "')\" >" + model.MdName.Trim() + "</a></div></td>");
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
                        str.Append("<td><img src=\"" + model.MdImgUrl + "\" onclick=\"javascrpt:TreeViewSpread('" + model.MdId + "','1','" + RoleID + "','" + PlatformID + "')\" ></td>");
                    }
                    if (IsLanguageEng())
                    {
                        str.Append("<td ><div class=\"TopParentTitleNo\"><a href=\"#\"  onclick=\"javascrpt:TreeViewSpread('" + model.MdId + "','1','" + RoleID + "','" + PlatformID + "')\" >" + model.MdText1.Trim() + "</a></div></td>");
                        
                    }
                    else
                    {
                        str.Append("<td ><div class=\"TopParentTitleNo\"><a href=\"#\"  onclick=\"javascrpt:TreeViewSpread('" + model.MdId + "','1','" + RoleID + "','" + PlatformID + "')\" >" + model.MdName.Trim() + "</a></div></td>");
                    }
                 
                }

                //加载权限列表
                List<PermissionstatalEO> plist = new List<PermissionstatalEO>();
                StringBuilder strWhereQ = new StringBuilder();
                strWhereQ.Append(" 1=1");
                IList<MySqlParameter> parmQ = new List<MySqlParameter>();
                strWhereQ.Append(" and APerTat.Pt_del<>1 and APerTat.Pf_id=@Pf_id and AMoudlePer.Md_id = @Md_id");
                parmQ.Add(new MySqlParameter("@Pf_id", PlatformID));
                parmQ.Add(new MySqlParameter("@Md_id", model.MdId));
                plist = (List<PermissionstatalEO>)ptManage.Gets(strWhereQ.ToString(),parmQ);
                //plist = (List<PermissionstatalEO>)ptManage.Gets(" APerTat.Pt_del<>1 and APerTat.Pf_id='" + PlatformID + "' and AMoudlePer.Md_id = '" + model.MdId + "'");
                string permissionsIdList = "";
                int int_ls = 0;
                StringBuilder strls = new StringBuilder();
                foreach (PermissionstatalEO mpmodel in plist)
                {
                    int_ls++;
                    //是否已选择了权限
                    if (ISPerm(model.MdId, mpmodel.PtId))
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
                    str.Append("<td><div class=\"checkall\"><input type=\"checkbox\" id=\"" + model.MdId + "_all\" value=\"\" style=display:none onclick=\"Permsave('1','" + model.MdId + "','" + RoleID + "','','" + PlatformID + "')\"/><span onclick=\"Permsave('1','" + model.MdId + "','" + RoleID + "','','" + PlatformID + "')\">&nbsp;</span></div></td>");
                    str.Append("<td><div class=\"chack\">");
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
                    str.Append("<div id=\"" + model.MdId.Trim() + "_Child\"  class=\"TopModuleChild\" style=\"display:none;\"></div>");
                }
                str.Append("</div>");
            }

            if (!string.IsNullOrEmpty(str.ToString()))
            {
                PermissionsTree.InnerHtml = str.ToString();
            }
            else
            {
                PermissionsTree.InnerHtml = "暂无数据";
            }
        }

        private bool ISPerm(string ModuleID, string Permissions)
        {
            foreach (RolemoduleEO rmp in RmpermList)
            {
                if (rmp.MdId.Trim() == ModuleID.Trim() && rmp.PtId.Trim() == Permissions.Trim())
                {
                    return true;
                }
            }

            return false; ;
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

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("RoleList.aspx");
        }
    }
}