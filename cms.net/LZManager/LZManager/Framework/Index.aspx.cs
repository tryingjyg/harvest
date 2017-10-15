using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LZManager.BLL;
using LZManager.DAL;
using LZManager.BLL.Common;
using System.Text;
using System.Data;

namespace LZManager.Frameworks
{
    public partial class Index : BasePage
    {
        public string strUrid = string.Empty;

        private string Platformid
        {
            get
            {
                try
                {
                    return Request.QueryString["Platform"].ToString();
                }
                catch
                {
                    return "";
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (GetUserID() == "" || Platformid == "") // 判断是否登录
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
                    catch
                    {
                        Response.Write("<script>top.location.href = '../Login.aspx' </script>");
                    }
                }

                SetUserLogin(); //  设置用户登录欢迎
                leftMenu.InnerHtml = GetTreeView(); //  获取TreeView
            }
        }

        /// <summary>
        /// 显示登录欢迎信息
        /// </summary>
        private void SetUserLogin()
        {
            try
            {
                UsersEO usersEO = GetUser();
                strUrid = usersEO.UrId;
                lblUserName.Text = usersEO.UrName; // 姓名
                lblDepartment.Text = usersEO.UrDepartment; // 部门
                // 获取用户角色
                foreach (string[] a in GetUserLeaveByString())
                {
                    if (a[1].ToString() == usersEO.UrText1)
                    {
                        lblLeave.Text = a[0].ToString();
                        break;
                    }
                }
            }
            catch
            { }
        }


        /// <summary>
        /// 获取树形结构列表
        /// </summary>
        /// <returns></returns>
        private string GetTreeView()
        {
            StringBuilder str = new StringBuilder();
            DataTable dt = GetNewModuleTableByUserid(Platformid); // 获取所有模块信息
            foreach (DataRow dr in dt.Select(" Md_parentid = '0' ", " Md_filedOrder ")) // 获取所有父模块
            {
                DataRow[] drsChild = dt.Select(" Md_parentid = '" + dr["Md_id"] + "' ", " Md_filedOrder ");

                if (IsLanguageEng())
                {
                    str.Append("<div title=\"" + dr["Md_text1"].ToString() + "\" style=\"overflow: auto;\">");
                }
                else
                {
                    str.Append("<div title=\"" + dr["Md_name"].ToString() + "\" style=\"overflow: auto;\">");
                    
                }
               

                str.Append("<table style=' width:100%;' align='left'>");
                foreach (DataRow drs in drsChild) // 循环子节点数据
                {
                    str.Append("<tr>");
                    str.Append("<td style='width:30px;'>");
                    str.Append("<img width=\"20px\" height=\"20px\" src=\"" + dr["Md_imgUrl"].ToString() + "\" />");
                    str.Append("</td>");
                    str.Append("<td>");
                    str.Append("<a onclick=\" AddPanel('" + drs["Md_address"].ToString());
                    if (drs["Md_address"].ToString().Split('?').Length > 1)
                    {
                        str.Append("&");
                    }
                    else
                    {
                        str.Append("?");
                    }
                    if (IsLanguageEng())
                    {
                        str.Append("Platformid=" + Platformid + "','" + drs["Md_text1"].ToString() + "') \" href='javascript:void()' >" + drs["Md_text1"].ToString() + "</a> "); 
                    }
                    else
                    {
                        str.Append("Platformid=" + Platformid + "','" + drs["Md_name"].ToString() + "') \" href='javascript:void()' >" + drs["Md_name"].ToString() + "</a> ");
                    }
                 
                    str.Append("</td>");
                    str.Append("</tr>");
                }

                str.Append("</table>");
                str.Append(" </div>");

            }
            return str.ToString();
        }
    }
}