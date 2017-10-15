using System;
using System.Web.UI.WebControls;
using LZManager.BLL.Common;
using LZManager.BLL;
using LZWebApp.BLL.Roulette;
using LZManager.DAL;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace LZManager.Platform
{
    public partial class PlatformList : BasePage
    {
        PlatformManage pmManage = new PlatformManage();

        protected void Page_Load(object sender, EventArgs e)
        {
            GetAuthorityUrl(this.Page, "Platform/PlatformList.aspx",0);

            if (!IsPostBack)
            {
                ViewState["SortOrder"] = "Pf_sort";
                ViewState["OrderDire"] = "ASC";

                this.BindPlatform();
            }
        }

        private void BindPlatform()
        {
            StringBuilder strWhere = new StringBuilder();
            strWhere.Append(" g.Pf_addUser=u.Ur_id");
            IList<MySqlParameter> parm = new List<MySqlParameter>();    
            if (!string.IsNullOrEmpty(this.txtPfname.Text.Trim()))
            {
                //strWhere.Append(" And g.Pf_name like '%" + this.txtPfname.Text.Trim() + "%'");
                strWhere.Append(" And g.Pf_name like @Cnname");
                parm.Add(new MySqlParameter("@Cnname", "%" + this.txtPfname.Text.Trim() + "%"));
            }
            if (this.rblState.SelectedValue == "0") //0启用1停用 默认0
            {
                strWhere.Append(" And g.Pf_state = 0");
            }
            else
            {
                strWhere.Append(" And g.Pf_state = 1");
            }
            strWhere.Append(" And g.Pf_del = 0 ");

            DataView view = pmManage.GetList(strWhere.ToString(),parm).DefaultView;
            string sort = (string)ViewState["SortOrder"] + " " + (string)ViewState["OrderDire"];

            view.Sort = sort;

            this.gvPlatform.DataSource = view;
            this.gvPlatform.DataBind();
        }

        protected void chbSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i <= gvPlatform.Rows.Count - 1; i++)
            {
                CheckBox CheckBox = (CheckBox)gvPlatform.Rows[i].FindControl("chbSelect");
                if (chbSelectAll.Checked == true)
                {
                    CheckBox.Checked = true;
                }
                else
                {
                    CheckBox.Checked = false;
                }
            }
            chbUnSelectAll.Checked = false;
        }

        protected void chbUnSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i <= gvPlatform.Rows.Count - 1; i++)
            {
                CheckBox CheckBox = (CheckBox)gvPlatform.Rows[i].FindControl("chbSelect");
                if (CheckBox.Checked == false)
                {
                    CheckBox.Checked = true;
                }
                else
                {
                    CheckBox.Checked = false;
                }
            }
            chbSelectAll.Checked = false;
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("PlatformEdit.aspx?State=A&Action=0");
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            //一次只能修改一条记录
            if (this.SelectCount() == 1)
            {
                string strId = string.Empty;
                foreach (GridViewRow gvrow in gvPlatform.Rows)
                {
                    CheckBox CheckBox = gvrow.FindControl("chbSelect") as CheckBox;
                    if (CheckBox.Checked)
                    {
                        strId = this.gvPlatform.DataKeys[gvrow.RowIndex]["Pf_id"].ToString();
                    }
                }
                Response.Redirect(string.Format("PlatformEdit.aspx?State=U&Pfid={0}&Action=1", strId));
            }

            else if (this.SelectCount() == 0)
            {
                //Jswork.Alert("请选择一条记录进行修改", this.Page);

                this.divAlert.Visible = true;
                this.lblAlert.Text = Resources.Resource.tip_one_modify;//"请选择一条记录进行修改";
            }
            else
            {
                //Jswork.Alert("一次只能修改一条记录", this.Page);

                this.divAlert.Visible = true;
                this.lblAlert.Text = Resources.Resource.tip_only_modify;//"一次只能修改一条记录";
            }
        }

        protected void btnDel_Click(object sender, EventArgs e)
        {
            String strPfids = string.Empty;
            string strPfnames = string.Empty;

            foreach (GridViewRow gvrow in gvPlatform.Rows)
            {
                CheckBox CheckBox = gvrow.FindControl("chbSelect") as CheckBox;
                if (CheckBox.Checked)
                {
                    strPfids += this.gvPlatform.DataKeys[gvrow.RowIndex]["Pf_id"].ToString() + "|";
                    strPfnames += this.gvPlatform.DataKeys[gvrow.RowIndex]["Pf_name"].ToString() + ",";
                }
            }
            if (strPfids == "" && strPfids.Length == 0)
            {
                //Jswork.Alert("请至少选择一条记录进行删除", this.Page);

                this.divAlert.Visible = true;
                this.lblAlert.Text = Resources.Resource.tip_only_delete;//"请至少选择一条记录进行删除";

                return;
            }

            strPfids = strPfids.TrimEnd('|');

            NxPlatformMO pmMO = new NxPlatformMO();

            int iSuccess = 0;
            for (int i = 0; i < strPfids.Split('|').Length; i++)
            {
                //if (pmManage.DelPlatforms("Pf_del = 1", string.Format(" Pf_id = '{0}'", strPfids.Split('|')[i])) > 0)
                StringBuilder strWhere = new StringBuilder();
                strWhere.Append(" 1=1");
                IList<MySqlParameter> parm = new List<MySqlParameter>();

                strWhere.Append(" and Pf_id =@Pt_id");
                parm.Add(new MySqlParameter("@Pt_id", strPfids.Split('|')[i]));
                if (pmManage.DelPlatforms("Pf_del = 1", strWhere.ToString(), parm) > 0)
                {
                    InsertLog(Resources.Resource.Delete_platform, string.Format("Platformname:{0},id:{1}", strPfnames.Split(',')[i], strPfids.Split('|')[i]), 12, GetPlatformIdByValue(1));

                    iSuccess += 1;
                }
            }

            if (iSuccess > 0)
            {
                Jswork.Alert(Resources.Resource.tip_delete_success, this.Page);

                this.BindPlatform();
            }
        }

        protected void gvPlatform_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowIndex > -1)
            {
                if (e.Row.Cells[5].Text == "0")
                {
                    e.Row.Cells[5].Text = Resources.Resource.On;//"启用";
                }
                if (e.Row.Cells[5].Text == "1")
                {
                    e.Row.Cells[5].Text = Resources.Resource.Off;// "停用";
                }
            }
        }

        /// <summary>
        /// 返回GridView中CheckBox选择了几个
        /// </summary>
        /// <returns></returns>
        private int SelectCount()
        {
            int iSelectCount = 0;
            for (int i = 0; i <= gvPlatform.Rows.Count - 1; i++)
            {
                CheckBox CheckBox = (CheckBox)gvPlatform.Rows[i].FindControl("chbSelect");
                if (CheckBox.Checked == true)
                {
                    iSelectCount += 1;
                }
            }

            return iSelectCount;
        }

        /// <summary>
        /// 搜索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            this.BindPlatform();
            this.divAlert.Visible = false;
            CloseDivImplementation();
        }

        /// <summary>
        /// 重置搜索条件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnReset_Click(object sender, EventArgs e)
        {
            this.txtPfname.Text = string.Empty;
            this.rblState.SelectedValue = "0";

            this.BindPlatform();

            this.divAlert.Visible = false;
        }

        protected void gvPlatform_Sorting(object sender, GridViewSortEventArgs e)
        {
            string sPage = e.SortExpression;
            if (ViewState["SortOrder"].ToString() == sPage)
            {
                if (ViewState["OrderDire"].ToString() == "Desc")
                    ViewState["OrderDire"] = "ASC";
                else
                    ViewState["OrderDire"] = "Desc";
            }
            else
            {
                ViewState["SortOrder"] = e.SortExpression;
            }

            this.BindPlatform();
        }

        /// <summary>
        /// 翻页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvPlatform_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.gvPlatform.PageIndex = e.NewPageIndex;
            BindPlatform();
        }       
    }
}