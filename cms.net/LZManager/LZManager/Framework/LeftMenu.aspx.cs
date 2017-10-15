using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;
using LZManager.BLL;
using LZManager.BLL.Common;

namespace LZManager.Framework
{
    public partial class LeftMenu : BasePage
    {
        private string Platformid // 获取平台ID
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
                if (Platformid != "")
                {
                    left.InnerHtml = GetTreeView(); //  获取TreeView
                }
            }
        }
        /// <summary>
        /// 获取树形结构列表
        /// </summary>
        /// <returns></returns>
        private string GetTreeView()
        {
            StringBuilder str = new StringBuilder();
            DataTable dt = GetModuleTableByUserid(Platformid); // 获取所有模块信息
            int id = 0;
            foreach (DataRow dr in dt.Select(" Md_parentid = '0' ", " Md_filedOrder ")) // 获取所有父模块
            {
                DataRow[] drsChild = dt.Select(" Md_parentid = '" + dr["Md_id"] + "' ", " Md_filedOrder ");
                str.Append("<div class=\"box\">");
                str.Append("<div class=\"title\" id=\"div_" + id + "\">");
                str.Append("<img width=\"20px\" height=\"20px\" src=\"" + dr["Md_imgUrl"].ToString() + "\" />");
               
                if (dr["Md_address"].ToString() == "" || dr["Md_address"].ToString() == "#")
                {
                    str.Append("<font color =white>" + dr["Md_name"].ToString() + "</font> ");
                }
                else
                {
                    str.Append("<a onclick=\" top.ChangeTitleName('" + dr["Md_name"].ToString() + "')\"  href=\"" + dr["Md_address"].ToString());
                    if (dr["Md_address"].ToString().Split('?').Length > 1)
                    {
                        str.Append("&");
                    }
                    else
                    {
                        str.Append("?");
                    }
                    str.Append("Platformid=" + Platformid + "\" target=right_body><font color =white>" + dr["Md_name"].ToString() + "</font></a> ");
                }

                str.Append("</div><div class=\"text\">");
                str.Append("<table>");


                id++;
                foreach (DataRow drs in drsChild ) // 循环子节点数据
                {
                    str.Append("<tr>");
                    str.Append("<td>");
                    str.Append("<img width=\"20px\" height=\"20px\" src=\"" + dr["Md_imgUrl"].ToString() + "\" />");
                    str.Append("</td>");
                    str.Append("<td>");
                    str.Append("<a onclick=\" top.ChangeTitleName('" + drs["Md_name"].ToString() + "'); top.CloseDiv_load()\" href=\"" + drs["Md_address"].ToString());
                    if (drs["Md_address"].ToString().Split('?').Length > 1)
                    {
                        str.Append("&");
                    }
                    else
                    {
                        str.Append("?");
                    }
                    str.Append("Platformid=" + Platformid + "\" target=\"right_body\">" + drs["Md_name"].ToString() + "</a> ");
                    str.Append("</td>");
                    str.Append("</tr>");
                }

                str.Append("</table>");
                str.Append(" </div>");
                str.Append("</div>");

            }
            return str.ToString();
        }
    }
}