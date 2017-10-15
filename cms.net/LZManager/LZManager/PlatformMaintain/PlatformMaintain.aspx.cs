using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LZManager.BLL;
using LZManager.BLL.Common;
using System.Text;
using System.Data;
using LZManager.DAL;
using LZWebApp.BLL.Roulette;
using MySql.Data.MySqlClient;

namespace LZManager.PlatformMaintain
{
    public partial class PlatformMaintain : BasePage
    {
        PlatformManage PfManage = new PlatformManage();
        NxPlatformMO NxPlatformMO = new NxPlatformMO();

        protected void Page_Load(object sender, EventArgs e)
        {
            GetAuthorityUrl(this.Page, "PlatformMaintain/PlatformMaintain.aspx", 0);

            if (!IsPostBack)
            {
                this.BindPlatform();
                this.BindPlatformList();
            }
        }

        private void BindPlatform()
        {
            PlatformManage PlatformManage = new PlatformManage();
            StringBuilder strWhere = new StringBuilder();
            strWhere.Append(" 1=1");
            IList<MySqlParameter> parm = new List<MySqlParameter>();    
            if (!string.IsNullOrEmpty(this.txtPfname.Text.Trim()))
            {
                //strWhere.Append(" And Pf_name LIKE '%" + txtPfname.Text.Trim() + "%' ");
                strWhere.Append("  And Pf_name LIKE @Cnname");
                parm.Add(new MySqlParameter("@Cnname", "%" + this.txtPfname.Text.Trim() + "%"));
            }
            strWhere.Append(" And Pf_del = 0 ORDER BY Pf_sort asc");
            this.ddlPf.DataSource = PlatformManage.GetTable(strWhere.ToString(),parm);
            this.ddlPf.DataTextField = "Pf_name";
            this.ddlPf.DataValueField = "Pf_id";
            this.ddlPf.DataBind();
        }

        private void BindPlatformList()
        {
            DataTable dt = PfManage.GetTable(" Pf_del = 0 ORDER BY Pf_sort asc",null);
            gvPlatform.DataSource = dt;
            gvPlatform.DataBind();
        }

        protected void rblStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.rblStatus.SelectedValue == "0")
            {
                this.trNotice.Visible = false;
                this.trEndTime.Visible = false;
            }
            else
            {
                this.trNotice.Visible = true;
                this.trEndTime.Visible = true;
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            this.BindPlatform();
            CloseDivImplementation();
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            this.txtPfname.Text = string.Empty;
            this.BindPlatform();
        }

        protected void gvPlatform_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)//查出表头
            {
                LinkButton lnkEdit = e.Row.FindControl("lnkEdit") as LinkButton;// 修改      
                LinkButton lnkClostWh = e.Row.FindControl("lnkClostWh") as LinkButton;// 关闭维护   
                LinkButton lnkCloseGg = e.Row.FindControl("lnkCloseGg") as LinkButton;// 关闭公告
                if (e.Row.RowIndex > -1)
                {
                    lnkClostWh.CssClass = "Enable";
                    lnkCloseGg.CssClass = "Enable";

                    if (e.Row.Cells[1].Text == "1")
                    {
                        e.Row.Cells[1].Text = "<font color=red>维护</font>";
                    }
                    else
                    {
                        e.Row.Cells[1].Text = "<font color=green>正常运行</font>";
                        lnkClostWh.Enabled = false;
                        lnkClostWh.CssClass = "IsEnable";
                    }

                    if (e.Row.Cells[2].Text == "1")
                    {
                        e.Row.Cells[2].Text = "<b>显示</b>";
                    }
                    else
                    {
                        e.Row.Cells[2].Text = "不显示";
                        lnkCloseGg.Enabled = false;
                        lnkCloseGg.CssClass = "IsEnable";
                    }
                }
            }
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            NxPlatformEO NxPlatformEO = new NxPlatformEO();
            NxPlatformEO = PfManage.GetPlatformByPK(this.ddlPf.SelectedValue);
            if (this.rblStatus.SelectedValue == "0")
            {
                NxPlatformEO.PfIsRepair = "1";//开启维护
                NxPlatformEO.PfIsNewShow = "0";//不显示新功能说明
            }
            else
            {
                NxPlatformEO.PfIsNewShow = "1";//显示新功能
                NxPlatformEO.PfIsRepair = "0";//关闭维护

                if (string.IsNullOrEmpty(this.txtPfnewFunction.Text.Trim()))
                {
                    this.divAlert.Visible = true;
                    this.lblAlert.Text = "请输入新功能说明";
                    this.txtPfnewFunction.Focus();
                    CloseDivImplementation();
                    return;
                }
                else
                {
                    NxPlatformEO.PfNewFunction = this.txtPfnewFunction.Text.Trim();
                }

                if (string.IsNullOrEmpty(this.txtEndTime.Text.Trim()))
                {
                    this.divAlert.Visible = true;
                    this.lblAlert.Text = "请选择维护结束时间";
                    CloseDivImplementation();
                    return;
                }
                else
                {
                    NxPlatformEO.PfNewEndTime = Convert.ToDateTime(txtEndTime.Text.Trim());
                }
            }            

            if (PfManage.EditPlatform(NxPlatformEO) > 0)
            {
                //插入操作日志
                InsertLog("修改平台维护信息", string.Format("Platformname:{0},id:{1}", this.ddlPf.SelectedItem.Text, this.ddlPf.SelectedValue), 14, GetPlatformIdByValue(1));
                CloseDivImplementation();
                Jswork.Alert("平台维护信息修改成功", "PlatformMaintain.aspx");
            }
            else
            {
                this.divAlert.Visible = true;
                this.lblAlert.Text = "平台维护信息修改失败";
            }
            CloseDivImplementation();
        }

        /// <summary>
        /// 行事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvPlatform_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            string Platformid = e.CommandName; //  平台ID

            if (e.CommandArgument.ToString() == "CloseWh") // 关闭维护
            {
                if (NxPlatformMO.PutPfIsRepairByPK(Platformid, "0") > 0)
                {
                    InsertLog("关闭维护", string.Format("Platformname:{0},id:{1}", this.ddlPf.SelectedItem.Text, this.ddlPf.SelectedValue), 14, GetPlatformIdByValue(1));
                    CloseDivImplementation();
                    Jswork.Alert("关闭维护成功", "PlatformMaintain.aspx");
                }
                else
                {
                    Jswork.Alert("关闭维护失败！");
                }
            }
            else if (e.CommandArgument.ToString() == "CloseGg") // 关闭公告
            {
                if (NxPlatformMO.PutPfIsNewShowByPK(Platformid, "0") > 0)
                {
                    InsertLog("修改平台维护信息", string.Format("Platformname:{0},id:{1}", this.ddlPf.SelectedItem.Text, this.ddlPf.SelectedValue), 14, GetPlatformIdByValue(1));
                    CloseDivImplementation();
                    Jswork.Alert("关闭公告", "PlatformMaintain.aspx");
                }
                else
                {
                    Jswork.Alert("关闭公告失败！");
                }
            }
        }

        /// <summary>
        /// 翻页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvPlatform_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.gvPlatform.PageIndex = e.NewPageIndex;
            BindPlatformList();
        }
    }
}