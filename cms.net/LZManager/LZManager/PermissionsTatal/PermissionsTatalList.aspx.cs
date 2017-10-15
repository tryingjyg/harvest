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

namespace LZManager.PermissionsTatal
{
    public partial class PermissionsTatalList : BasePage
    {
        PermissionsTatalManage ptManage = new PermissionsTatalManage();

        protected void Page_Load(object sender, EventArgs e)
        {
            GetAuthorityUrl(this.Page, "PermissionsTatal/PermissionsTatalList.aspx", 0);

            if (!IsPostBack)
            {
                ViewState["SortOrder"] = "Pt_addTime";
                ViewState["OrderDire"] = "DESC";

                this.LoadPlatform();
                this.BindPermissionsTatal();
            }
        }

        private void BindPermissionsTatal()
        {
            StringBuilder strWhere = new StringBuilder();
            strWhere.Append(" pt.Pf_id=g.Pf_id and pt.Pt_addUser=u.Ur_id");
            IList<MySqlParameter> parm = new List<MySqlParameter>();    
            if (!string.IsNullOrEmpty(this.txtPtName.Text.Trim()))
            {
                strWhere.Append(" And pt.Pt_name like @Cnname");
                parm.Add(new MySqlParameter("@Cnname", "%" + this.txtPtName.Text.Trim() + "%"));
                //strWhere.Append(" And pt.Pt_name like '%" + this.txtPtName.Text.Trim() + "%'");
            }
            if (!string.IsNullOrEmpty(this.ddlPf.SelectedValue))
            {
                strWhere.Append(" And pt.Pf_id = @ddlPf");
                parm.Add(new MySqlParameter("@ddlPf", ddlPf.SelectedValue));
                //strWhere.Append(" And pt.Pf_id = '" + ddlPf.SelectedValue + "' ");
            }
            if (this.rblState.SelectedValue == "0") //0启用1停用 默认0
            {
                strWhere.Append(" And pt.Pt_state = 0");
            }
            else
            {
                strWhere.Append(" And pt.Pt_state = 1");
            }
            strWhere.Append(" And pt.Pt_del = 0 ORDER BY pt.Pt_addTime DESC");

            DataView view = ptManage.GetList(strWhere.ToString(),parm).DefaultView;
            string sort = (string)ViewState["SortOrder"] + " " + (string)ViewState["OrderDire"];

            view.Sort = sort;

            this.gvPermissionsTatal.DataSource = view;
            this.gvPermissionsTatal.DataBind();
        }

        /// <summary>
        /// 加载平台列表
        /// </summary>
        private void LoadPlatform()
        {
            PlatformManage PfManage = new PlatformManage();
            //this.ddlPf.DataSource = PfManage.Get(" Pf_del = 0 AND Pf_text1 > 0  ORDER BY Pf_text1");
            this.ddlPf.DataSource = PfManage.Get(" Pf_del = 0 ORDER BY Pf_sort");
            this.ddlPf.DataTextField = "Pfname";
            this.ddlPf.DataValueField = "Pfid";
            this.ddlPf.DataBind();
            this.ddlPf.Items.Insert(0, new ListItem(Resources.Resource.allplatform, ""));
            //this.ddlPf.Items.Insert(0, new ListItem("所有平台", ""));
        }

        protected void chbSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i <= gvPermissionsTatal.Rows.Count - 1; i++)
            {
                CheckBox CheckBox = (CheckBox)gvPermissionsTatal.Rows[i].FindControl("chbSelect");
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
            for (int i = 0; i <= gvPermissionsTatal.Rows.Count - 1; i++)
            {
                CheckBox CheckBox = (CheckBox)gvPermissionsTatal.Rows[i].FindControl("chbSelect");
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
            Response.Redirect("PermissionsTatalEdit.aspx?State=A&Action=0");
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            //一次只能修改一条记录
            if (this.SelectCount() == 1)
            {
                string strId = string.Empty;
                foreach (GridViewRow gvrow in gvPermissionsTatal.Rows)
                {
                    CheckBox CheckBox = gvrow.FindControl("chbSelect") as CheckBox;
                    if (CheckBox.Checked)
                    {
                        strId = this.gvPermissionsTatal.DataKeys[gvrow.RowIndex]["Pt_id"].ToString();
                    }
                }
                Response.Redirect(string.Format("PermissionsTatalEdit.aspx?State=U&Ptid={0}&Action=1", strId));
            }

            else if (this.SelectCount() == 0)
            {
                //Jswork.Alert("请选择一条记录进行修改", this.Page);

                this.divAlert.Visible = true;
                this.lblAlert.Text = Resources.Resource.tip_one_modify; // "请选择一条记录进行修改";
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
            String strPtids = string.Empty;
            string strPtnames = string.Empty;

            foreach (GridViewRow gvrow in gvPermissionsTatal.Rows)
            {
                CheckBox CheckBox = gvrow.FindControl("chbSelect") as CheckBox;
                if (CheckBox.Checked)
                {
                    strPtids += this.gvPermissionsTatal.DataKeys[gvrow.RowIndex]["Pt_id"].ToString() + "|";
                    strPtnames += this.gvPermissionsTatal.DataKeys[gvrow.RowIndex]["Pt_name"].ToString() + ",";
                }
            }
            if (strPtids == "" && strPtids.Length == 0)
            {
                //Jswork.Alert("请至少选择一条记录进行删除", this.Page);

                this.divAlert.Visible = true;
                this.lblAlert.Text = Resources.Resource.tip_only_delete;//"请至少选择一条记录进行删除";

                return;
            }

            strPtids = strPtids.TrimEnd('|');

            PermissionstatalMO roleMO = new PermissionstatalMO();

            int iSuccess = 0;
            for (int i = 0; i < strPtids.Split('|').Length; i++)
            {
                //if (ptManage.DelPermissionsTatals("Pt_del = 1", string.Format(" Pt_id = '{0}'", strPtids.Split('|')[i])) > 0)
                StringBuilder strWhere = new StringBuilder();
                strWhere.Append(" 1=1");
                IList<MySqlParameter> parm = new List<MySqlParameter>();

                strWhere.Append(" and Pt_id =@Pt_id");
                parm.Add(new MySqlParameter("@Pt_id", strPtids.Split('|')[i]));
                if (ptManage.DelPermissionsTatals("Pt_del = 1", strWhere.ToString(), parm) > 0)
                {
                    InsertLog(Resources.Resource.Delete_general_function, string.Format("permissionstatalname:{0},id:{1}", strPtnames.Split(',')[i], strPtids.Split('|')[i]), 9, GetPlatformIdByValue(1));

                    iSuccess += 1;
                }
            }

            if (iSuccess > 0)
            {
                Jswork.Alert(Resources.Resource.tip_delete_success, this.Page);

                this.BindPermissionsTatal();
            }
        }

        protected void gvPermissionsTatal_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowIndex > -1)
            {
                if (e.Row.Cells[3].Text == "0")
                {
                    e.Row.Cells[3].Text = Resources.Resource.On;//"启用";
                }
                if (e.Row.Cells[3].Text == "1")
                {
                    e.Row.Cells[3].Text = Resources.Resource.Off; //"停用";
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
            for (int i = 0; i <= gvPermissionsTatal.Rows.Count - 1; i++)
            {
                CheckBox CheckBox = (CheckBox)gvPermissionsTatal.Rows[i].FindControl("chbSelect");
                if (CheckBox.Checked == true)
                {
                    iSelectCount += 1;
                }
            }

            return iSelectCount;
        }

        /// <summary>
        /// 按条件搜索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            BindPermissionsTatal();

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
            this.txtPtName.Text = string.Empty;
            this.ddlPf.SelectedValue = string.Empty;
            this.rblState.SelectedValue = "0";

            this.BindPermissionsTatal();

            this.divAlert.Visible = false;
        }

        protected void gvPermissionsTatal_Sorting(object sender, GridViewSortEventArgs e)
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

            this.BindPermissionsTatal();
        }

        /// <summary>
        /// 翻页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvPermissionsTatal_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.gvPermissionsTatal.PageIndex = e.NewPageIndex;
            this.BindPermissionsTatal();
        }
    }
}