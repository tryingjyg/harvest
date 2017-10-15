using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LZManager.BLL;
using LZManager.DAL;
using System.Text;
using LZManager.BLL.Common;
using System.Data;
using System.Configuration;
using LZWebApp.BLL.Roulette;
using MySql.Data.MySqlClient;

namespace LZManager.FeedBack
{
    public partial class FeedBackList : BasePage
    {
        int pagesize = 15; // 显示数量
        FeedBackMessage feedBackMessage = new FeedBackMessage();
        bool IsRepare = false; //  是否有维护权限

        protected void Page_Load(object sender, EventArgs e)
        {
            if (GetUserID() == "")
            {
                Jswork.Alert("亲，请先登录！", "top", ConfigurationManager.AppSettings["WebLoginURL"].ToString());
            }
            //IList<MySqlParameter> parm = new List<MySqlParameter>();
            //parm.Add(new MySqlParameter("@Cnname", "%" + this.txtCnname.Text.Trim() + "%"));
            DataRow[] dr = GetRoleTable().Select("Rl_name = '" + ConfigurationManager.AppSettings["WeiHuRoleName"].ToString() + "'");
            if (dr.Length > 0) // 证明有工程师权限
            {
                IsRepare = true;
            }

            if (!IsPostBack)
            {
                BindList(1);
            }
        }

        /// <summary>
        /// 绑定列表
        /// </summary>
        /// <param name="page"></param>
        private void BindList(int page)
        {
            int a = 1 + ((page - 1) * pagesize); // 排序
            StringBuilder str = new StringBuilder();
            DataTable dts = new DataTable();
            IList<MySqlParameter> parm = new List<MySqlParameter>();  
            if (IsRepare)
            {
                //dts = feedBackMessage.GetAllByWhere(" (fb.Fb_solveUser='" + GetUserID() + "' or fb.Fb_solveUser is null or fb.Fb_solveUser = '')", GetUserID(), "  Pf_id, Fb_state, Fb_addTime desc");
                dts = feedBackMessage.GetAllByWhere(" (fb.Fb_solveUser=@GetUserID or fb.Fb_solveUser is null or fb.Fb_solveUser = '')", GetUserID(), "  Pf_id, Fb_state, Fb_addTime desc", GetUserID());
                parm.Add(new MySqlParameter("@GetUserID", GetUserID()));
            }
            else
            {
                dts = feedBackMessage.GetAllByWhere(" fb.Fb_addUser=@GetUserID ", GetUserID(), "  Pf_id, Fb_state, Fb_addTime desc", GetUserID());
                parm.Add(new MySqlParameter("@GetUserID", GetUserID()));
            }
            DataTable dt = CommonPage.GetPagedTable(dts, page, pagesize);

            AspNetPager1.PageSize = pagesize;//每页显示的数据条数
            AspNetPager1.RecordCount = dts.Rows.Count;////获取数据总数
            foreach (DataRow dr in dt.Rows) // 循环所有数据
            {
                str.Append(" <div class=\"box\"> ");
                str.Append(" <div class=\"title\"> ");
                str.Append("    <table> ");
                str.Append("        <tr> ");
                str.Append("            <td width=\"45%\" style=\"background-color: #E9F2F7\"> ");
                str.Append("               " + a + "、" + dr["Fb_title"] + " ");
                str.Append("           </td> ");
                str.Append("            <td width=\"220px\" style=\"background-color: #E9F2F7\"> ");
                str.Append(dr["Pf_name"].ToString());
                str.Append("           </td> ");
                str.Append("           <td width=\"100px\" style=\"background-color: #E9F2F7\"> ");
                str.Append("              " + dr["Ur_names"].ToString() + " ");
                str.Append("          </td> ");
                str.Append("          <td width=\"200px\" style=\"background-color: #CADEE8\"> ");
                str.Append("            " + dr["Fb_addTime"].ToString() + " ");
                str.Append("         </td> ");
                if (dr["Fb_state"].ToString() == "0")
                {
                    str.Append("           <td width=\"55px\" style=\"background-color: #6494B6; color: White;\"> ");
                    str.Append("未解决");
                }
                else if (dr["Fb_state"].ToString() == "1")
                {
                    str.Append("           <td width=\"55px\" style=\"background-color: #6494B6; color: White;\"> ");
                    str.Append("解决");
                }
                else if (dr["Fb_state"].ToString() == "2")
                {
                    str.Append("           <td width=\"55px\" style=\"background-color: #6494B6; color: White;\"> ");
                    str.Append("保留");
                }
                else if (dr["Fb_state"].ToString() == "3")
                {
                    str.Append("           <td width=\"55px\" style=\"background-color: #6494B6; color: Red;\"> ");
                    str.Append("处理中");
                }
                str.Append("</td> ");
                str.Append("           <td width=\"100px\" style=\"background-color: #E9F2F7\"> ");
                str.Append("              " + dr["Ur_name"].ToString() + " ");
                str.Append("          </td> ");
                str.Append("          <td width=\"200px\" style=\"background-color: #CADEE8\"> ");
                str.Append("            " + dr["Fb_solveTime"].ToString() + " ");
                str.Append("         </td> ");
                str.Append("      </tr> ");
                str.Append("  </table> ");
                str.Append("  </div> ");
                str.Append("  <div class=\"text\"> ");
                str.Append("      <table width=\"100%\" border=\"0\" cellspacing=\"1\" cellpadding=\"3\" align=\"center\"> ");
                str.Append("         <tr> ");
                str.Append("             <td bgcolor=\"#cadee8\" width=\"10%\"> ");
                str.Append("                 所属平台: ");
                str.Append("             </td> ");
                str.Append("            <td bgcolor=\"#e9f2f7\" width=\"40%\"> ");
                str.Append("                  " + dr["Pf_name"].ToString() + " ");
                if (IsRepare)
                {
                    str.Append(" <div style=\"width:15%; float:right;\"><a href=\"javascript:void()\" onclick=\"UpDateState('" + dr["Fb_id"].ToString() + "',3)\"><span style=\"color:Blue\">接受修改该问题</span></a></div>");
                }
                str.Append("              </td> ");
                str.Append("          </tr> ");
                str.Append("          <tr> ");
                str.Append("              <td bgcolor=\"#cadee8\"> ");
                str.Append("                 提交人: ");
                str.Append("             </td> ");
                str.Append("             <td bgcolor=\"#e9f2f7\"> ");
                str.Append("                 " + dr["Ur_names"].ToString() + " ");
                str.Append("             </td> ");
                str.Append("        </tr> ");
                str.Append("          <tr> ");
                str.Append("              <td bgcolor=\"#cadee8\"> ");
                str.Append("                 提交时间: ");
                str.Append("             </td> ");
                str.Append("             <td bgcolor=\"#e9f2f7\"> ");
                str.Append("                 " + dr["Fb_addTime"].ToString() + " ");
                str.Append("             </td> ");
                str.Append("        </tr> ");
                str.Append("         <tr> ");
                str.Append("            <td bgcolor=\"#cadee8\"> ");
                str.Append("                反馈标题： ");
                str.Append("            </td> ");
                str.Append("           <td bgcolor=\"#e9f2f7\"> ");
                str.Append("               " + dr["Fb_title"].ToString() + " ");
                str.Append("           </td> ");
                str.Append("       </tr> ");
                str.Append("       <tr> ");
                str.Append("           <td bgcolor=\"#cadee8\"> ");
                str.Append("              是否上传图片： ");
                str.Append("           </td> ");
                str.Append("          <td bgcolor=\"#e9f2f7\"> ");
                    if (dr["Fb_url"].ToString() != "")
                    {
                        if (IsRepare)
                        {
                            str.Append(" <span style=\"padding-left:50px;\"></span><a href=\"../File/FeedBackFile/" + dr["Fb_url"].ToString() + "\">" + dr["Fb_url"].ToString() + "</a><span style=\"color:Red;\"> (点击文件可直接下载)</span>");
                        }
                        else
                        {
                            str.Append("             是");
                        }
                    }
                    else
                    {
                        str.Append("             否 ");
                    }
                str.Append("          </td> ");
                str.Append("      </tr> ");
                str.Append("       <tr> ");
                str.Append("           <td bgcolor=\"#cadee8\"> ");
                str.Append("              反馈内容： ");
                str.Append("          </td> ");
                str.Append("           <td bgcolor=\"#e9f2f7\"> ");
                str.Append("              " + dr["Fb_description"].ToString() + " ");
                str.Append("          </td> ");
                str.Append("       </tr> ");
                str.Append("       <tr> ");
                str.Append("           <td bgcolor=\"#cadee8\"> ");
                str.Append("               管理员回复内容： ");
                str.Append("           </td> ");
                str.Append("          <td bgcolor=\"#e9f2f7\" style=\"color: Red;\"> ");
                if (IsRepare)
                {
                    str.Append(" <textarea id=\"txt_solvedescription_" + dr["Fb_id"].ToString() + "\" style=\"width:574px; height:108px\">" + dr["Fb_solvedescription"].ToString() + "</textarea> ");
                    str.Append(" <div align=\"right\"><a href=\"javascript:void()\" onclick=\"Updatesolvedescription('您确定要提交信息么？状态将被改成解决！','" + dr["Fb_id"].ToString() + "',1)\"><span style=\"color:Blue\">提交回复信息</span></a><div>");
                    str.Append(" <div align=\"right\"><a href=\"javascript:void()\" onclick=\"Updatesolvedescription('您确定要提交信息么？状态将被改成保留！','" + dr["Fb_id"].ToString() + "',2)\"><span style=\"color:Blue\">状态为保留并回复信息</span></a><div>");
                }
                else
                {
                    str.Append("              " + dr["Fb_solvedescription"].ToString() + " ");
                }
                str.Append("           </td> ");
                str.Append("        </tr> ");
                str.Append("     </table> ");
                str.Append(" </div> ");
                str.Append(" </div> ");
                a++;
            }

            div_show.InnerHtml = str.ToString();
        }

        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            BindList(AspNetPager1.CurrentPageIndex);
        }
    }
}