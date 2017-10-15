using System;
using System.Collections.Generic;
using System.Text;
using LZManager.BLL.Common;
using LZManager.BLL;
using LZManager.DAL;
using MySql.Data.MySqlClient;

namespace LZManager.Module
{
    public partial class ModuleList : BasePage
    {
        ModuleManage mdManage = new ModuleManage();

        protected void Page_Load(object sender, EventArgs e)
        {
            GetAuthorityUrl(this.Page, "Module/ModuleList.aspx",0);

            if (!IsPostBack)
            {
                this.LoadPlatform();
                BindTreeView();
            }
        }

        /// <summary>
        /// 加载平台列表
        /// </summary>
        private void LoadPlatform()
        {
            PlatformManage PfManage = new PlatformManage();
            this.ddlPf.DataSource = PfManage.Get(" Pf_del = 0 ORDER BY Pf_sort asc");

           
            this.ddlPf.DataTextField = "Pfname";
            if (IsLanguageEng())
            {
                this.ddlPf.DataTextField = "PfText1";

                
            }
            this.ddlPf.DataValueField = "Pfid";
            this.ddlPf.DataBind();
        }

        protected void BindTreeView()
        {
            StringBuilder str = new StringBuilder();
            //得到模块权限和角色的列表

            List<ModuleEO> mdEoList = new List<ModuleEO>();
            //mdEoList = (List<ModuleEO>)mdManage.Get(" Pf_id = '" + this.ddlPf.SelectedValue + "' AND Md_parentid = '0' AND Md_deleteFlag<>1 ORDER BY Md_filedOrder");
            //MySqlParameter[] arrparm = new MySqlParameter { };
            
            IList<MySqlParameter> parm = new List<MySqlParameter>();
            StringBuilder strWhere = new StringBuilder();
            strWhere.Append("    Pf_id = @ddlPf AND Md_parentid = '0' AND Md_deleteFlag<>1 ORDER BY Md_filedOrder");
            parm.Add(new MySqlParameter("@ddlPf", this.ddlPf.SelectedValue));
            mdEoList = (List<ModuleEO>)mdManage.Get(strWhere.ToString(),parm);

            foreach (ModuleEO model in mdEoList)
            {
                //是否有下级内容
                bool IsChild = true;
                //if (mdManage.Get("Md_parentid=@MdId AND Md_deleteFlag<>1 ORDER BY Md_filedOrder", model.MdId) != null)
                IList<MySqlParameter> parmC = new List<MySqlParameter>();
                StringBuilder strWhereC = new StringBuilder();
                strWhereC.Append("   Md_parentid=@MdId AND Md_deleteFlag<>1 ORDER BY Md_filedOrder");
                parmC.Add(new MySqlParameter("@MdId", model.MdId));
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
                    str.Append("<div id=" + model.MdId + " class=\"TopParentDivYes\">");
                }
                //最外层div中，顶级模块表格式
                str.Append("<table class=\"TopModuleTeble\">");
                str.Append("<tr>");
                str.Append("<td><div class=\"MapShow\" id=\"" + model.MdId + "_Map\"></div></td>");
                //是否有下级模块
                if (IsChild)
                {
                    if (model.MdImgUrl == "")
                    {
                        str.Append("<td></td>");
                    }
                    else
                    {
                        str.Append("<td><img src=\"" + model.MdImgUrl + "\" onclick=\"javascrpt:TreeViewSpread('" + model.MdId + "','0')\"/ ></td>");
                    }
                    if (IsLanguageEng())
                    {
                        str.Append("<td><div class=\"TopParentTitleYes\"><a href=\"#\"  onclick=\"javascrpt:TreeViewSpread('" + model.MdId + "','0')\" >" + model.MdText1 + "</a></div></td>");
                    }

                    else
                    {
                        str.Append("<td><div class=\"TopParentTitleYes\"><a href=\"#\"  onclick=\"javascrpt:TreeViewSpread('" + model.MdId + "','0')\" >" + model.MdName.Trim() + "</a></div></td>");
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
                        str.Append("<td><div class=\"TopParentTitleNo\"><a href=\"#\"  onclick=\"javascrpt:TreeViewSpread('" + model.MdId + "','1')\" >" + model.MdText1 + "</a></div></td>");
                    }
                    str.Append("<td><div class=\"TopParentTitleNo\"><a href=\"#\"  onclick=\"javascrpt:TreeViewSpread('" + model.MdId + "','1')\" >" + model.MdName.Trim() + "</a></div></td>");
                }
                string useflag = model.MdUseFlag.Trim() == "0" ? Resources.Resource.On : Resources.Resource.Off;
                str.Append("<td><div class=\"useFlag\">" + useflag + "</div></td>");
                string ExitsTree = model.MdExistsTreeView.Trim() == "0" ? Resources.Resource.Display_in_the_tree_directory : Resources.Resource.Hide_in_the_tree_directory;
                str.Append("<td><div class=\"exitsTree\">" + ExitsTree + "</div></td>");
                str.Append("<td <div class=\"features\"><a href=\"ModuleEdit.aspx?State=AC&Action=0&ParentID=" + model.MdId + "&ParentName=" + model.MdName + "&MdText1=" + model.MdText1 + "\">" + Resources.Resource.Add_sub_module + "</a>｜<a href=\"ModuleEdit.aspx?State=U&Action=1&ModuleID=" + model.MdId + "\">" + Resources.Resource.edit + "</a>｜<a href=\"#\" onclick=\"Process('" + model.MdId + "')\">" + Resources.Resource.delete + "</a></div></td>");
                str.Append("</tr>");
                str.Append("</table>");
                if (IsChild)
                {
                    str.Append("<div id=\"" + model.MdId.Trim() + "_Child\" class=\"TopModuleChild\" style=\"display:none;\"></div>");
                }
                str.Append("</div>");

            }
            if (!string.IsNullOrEmpty(str.ToString()))
            {
                TreelistView.InnerHtml = str.ToString();
            }
            else
            {
                TreelistView.InnerHtml =  Resources.Resource.No_data;//"暂无数据";
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("ModuleEdit.aspx?State=AF&ParentID=0&ParentName=顶级模块&Action=0");
        }

        protected void ddlPf_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BindTreeView();
        }
    }
}