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

namespace LZManager.Permissions
{
    public partial class PermissionsList : BasePage
    {
        PermissionsManage pmManage = new PermissionsManage();

        protected void Page_Load(object sender, EventArgs e)
        {
            GetAuthorityUrl(this.Page, "Permissions/PermissionsList.aspx",0);

            if (!IsPostBack)
            {
                ViewState["SortOrder"] = "Pm_addTime";
                ViewState["OrderDire"] = "DESC";

                this.BindPermissions();
            }
        }

        private void BindPermissions()
        {
            StringBuilder strWhere = new StringBuilder();
            strWhere.Append(" p.Pm_addUser=u.Ur_id");
            IList<MySqlParameter> parm = new List<MySqlParameter>();    
            if (!string.IsNullOrEmpty(this.txtPmname.Text.Trim()))
            {
                strWhere.Append(" And p.Pm_name like @Cnname");
                parm.Add(new MySqlParameter("@Cnname", "%" + this.txtPmname.Text.Trim() + "%"));
                //strWhere.Append(" And p.Pm_name like '%" + this.txtPmname.Text.Trim() + "%'");
            }
            if (this.rblState.SelectedValue == "0") //0启用1停用 默认0
            {
                strWhere.Append(" And p.Pm_state = 0");
            }
            else
            {
                strWhere.Append(" And p.Pm_state = 1");
            }
            strWhere.Append(" And p.Pm_del = 0 ");

            DataView view = pmManage.GetList(strWhere.ToString(), parm).DefaultView;
            string sort = (string)ViewState["SortOrder"] + " " + (string)ViewState["OrderDire"];

            view.Sort = sort;

            this.gvPermissions.DataSource = view;
            this.gvPermissions.DataBind();
        }

        protected void chbSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i <= gvPermissions.Rows.Count - 1; i++)
            {
                CheckBox CheckBox = (CheckBox)gvPermissions.Rows[i].FindControl("chbSelect");
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
            for (int i = 0; i <= gvPermissions.Rows.Count - 1; i++)
            {
                CheckBox CheckBox = (CheckBox)gvPermissions.Rows[i].FindControl("chbSelect");
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
            Response.Redirect("PermissionsEdit.aspx?State=A&Action=0");
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            //一次只能修改一条记录
            if (this.SelectCount() == 1)
            {
                string strId = string.Empty;
                foreach (GridViewRow gvrow in gvPermissions.Rows)
                {
                    CheckBox CheckBox = gvrow.FindControl("chbSelect") as CheckBox;
                    if (CheckBox.Checked)
                    {
                        strId = this.gvPermissions.DataKeys[gvrow.RowIndex]["Pm_id"].ToString();
                    }
                }
                Response.Redirect(string.Format("PermissionsEdit.aspx?State=U&Pmid={0}&Action=1", strId));
            }

            else if (this.SelectCount() == 0)
            {
                //Jswork.Alert("请选择一条记录进行修改", this.Page);

                this.divAlert.Visible = true;
                this.lblAlert.Text = Resources.Resource.tip_one_modify; //"请选择一条记录进行修改";
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
            String strPmids = string.Empty;
            string strPmnames = string.Empty;

            foreach (GridViewRow gvrow in gvPermissions.Rows)
            {
                CheckBox CheckBox = gvrow.FindControl("chbSelect") as CheckBox;
                if (CheckBox.Checked)
                {
                    strPmids += this.gvPermissions.DataKeys[gvrow.RowIndex]["Pm_id"].ToString() + "|";
                    strPmnames += this.gvPermissions.DataKeys[gvrow.RowIndex]["Pm_name"].ToString() + ",";
                }
            }
            if (strPmids == "" && strPmids.Length == 0)
            {
                //Jswork.Alert("请至少选择一条记录进行删除", this.Page);

                this.divAlert.Visible = true;
                this.lblAlert.Text = Resources.Resource.tip_only_delete;//"请至少选择一条记录进行删除";

                return;
            }

            strPmids = strPmids.TrimEnd('|');

            PermissionsMO pmMO = new PermissionsMO();

            int iSuccess = 0;
            for (int i = 0; i < strPmids.Split('|').Length; i++)
            {
                StringBuilder strWhere = new StringBuilder();
                strWhere.Append(" 1=1");
                IList<MySqlParameter> parm = new List<MySqlParameter>();

                strWhere.Append(" and Pm_id =@Cnname");
                parm.Add(new MySqlParameter("@Cnname", strPmids.Split('|')[i]));
                if (pmManage.DelPermissionss("Pm_del = 1", strWhere.ToString(),parm) > 0)

                //if (pmManage.DelPermissionss("Pm_del = 1", string.Format(" Pm_id = '{0}'", strPmids.Split('|')[i])) > 0)
                {
                    InsertLog(Resources.Resource.Delete_function, string.Format("permissionsname:{0},id:{1}", strPmnames.Split(',')[i], strPmids.Split('|')[i]), 12, GetPlatformIdByValue(1));

                    iSuccess += 1;
                }
            }

            if (iSuccess > 0)
            {
                Jswork.Alert(Resources.Resource.tip_delete_success, this.Page);

                this.BindPermissions();
            }
        }

        protected void gvPermissions_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowIndex > -1)
            {
                if (e.Row.Cells[2].Text == "0")
                {
                    e.Row.Cells[2].Text = Resources.Resource.On;//"启用";
                }
                if (e.Row.Cells[2].Text == "1")
                {
                    e.Row.Cells[2].Text = Resources.Resource.Off;//"停用";
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
            for (int i = 0; i <= gvPermissions.Rows.Count - 1; i++)
            {
                CheckBox CheckBox = (CheckBox)gvPermissions.Rows[i].FindControl("chbSelect");
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
            this.BindPermissions();

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
            this.txtPmname.Text = string.Empty;
            this.rblState.SelectedValue = "0";

            this.BindPermissions();

            this.divAlert.Visible = false;
        }

        protected void gvPermissions_Sorting(object sender, GridViewSortEventArgs e)
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

            this.BindPermissions();
        }       
    }
}