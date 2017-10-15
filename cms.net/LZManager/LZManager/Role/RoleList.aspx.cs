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

namespace LZManager.Role
{
    public partial class RoleList : BasePage
    {
        RoleManage roleManage = new RoleManage();

        protected void Page_Load(object sender, EventArgs e)
        {
            GetAuthorityUrl(this.Page, "Role/RoleList.aspx",0);

            if (!IsPostBack)
            {
                ViewState["SortOrder"] = "Rl_addTime";
                ViewState["OrderDire"] = "DESC";

                this.LoadPlatform();
                this.BindRole();
            }
        }

        /// <summary>
        /// 绑定角色信息列表
        /// </summary>
        private void BindRole()
        {
            StringBuilder strWhere = new StringBuilder();
            //strWhere.Append(" r.Pf_id=g.Pf_id and r.Rl_addUser = u.Ur_id");
            strWhere.Append(" 1 = 1 ");

            IList<MySqlParameter> parm = new List<MySqlParameter>();    
            if (!string.IsNullOrEmpty(this.txtRlName.Text.Trim()))
            {
                strWhere.Append(" And r.Rl_name like @Cnname");
                parm.Add(new MySqlParameter("@Cnname", "%" + this.txtRlName.Text.Trim() + "%"));
                //strWhere.Append(" And r.Rl_name like '%" + this.txtRlName.Text.Trim() + "%'");
            }
            if (!string.IsNullOrEmpty(this.ddlPf.SelectedValue))
            {
                strWhere.Append(" And r.Pf_id=@Snname");
                parm.Add(new MySqlParameter("@Snname", ddlPf.SelectedValue));
                //strWhere.Append(" And r.Pf_id = '" + ddlPf.SelectedValue + "' ");
            }
            if (this.rblState.SelectedValue == "0") //0启用1停用 默认0
            {
                strWhere.Append(" And r.Rl_state = 0");
            }
            else
            {
                strWhere.Append(" And r.Rl_state = 1");
            }
            strWhere.Append(" And r.Rl_del = 0 ORDER BY r.Rl_addTime DESC");

            DataView view = roleManage.GetList(strWhere.ToString(),parm).DefaultView;
            string sort = (string)ViewState["SortOrder"] + " " + (string)ViewState["OrderDire"];

            view.Sort = sort;

            this.gvRole.DataSource = view;
            this.gvRole.DataBind();
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
            if (IsLanguageEng())
            {
                this.ddlPf.DataTextField = "PfText1";
            }
            this.ddlPf.DataBind();

            this.ddlPf.Items.Insert(0, new ListItem(Resources.Resource.allplatform, ""));
        }

        /// <summary>
        /// 全选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void chbSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i <= gvRole.Rows.Count - 1; i++)
            {
                CheckBox CheckBox = (CheckBox)gvRole.Rows[i].FindControl("chbSelect");
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

        /// <summary>
        /// 反选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void chbUnSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i <= gvRole.Rows.Count - 1; i++)
            {
                CheckBox CheckBox = (CheckBox)gvRole.Rows[i].FindControl("chbSelect");
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

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("RoleEdit.aspx?State=A&Action=0");
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnEdit_Click(object sender, EventArgs e)
        {
            //一次只能修改一条记录
            if (this.SelectCount() == 1)
            {
                string strId = string.Empty;
                foreach (GridViewRow gvrow in gvRole.Rows)
                {
                    CheckBox CheckBox = gvrow.FindControl("chbSelect") as CheckBox;
                    if (CheckBox.Checked)
                    {
                        strId = this.gvRole.DataKeys[gvrow.RowIndex]["Rl_id"].ToString();
                    }
                }
                Response.Redirect(string.Format("RoleEdit.aspx?State=U&Rlid={0}&Action=1", strId));
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
                this.lblAlert.Text = Resources.Resource.tip_only_modify;// "一次只能修改一条记录";
            }
        }

        /// <summary>
        /// 为角色添加功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnAddPermissions_Click(object sender, EventArgs e)
        {
            //一次只能选择一条记录
            if (this.SelectCount() == 1)
            {
                string strRlid = string.Empty;
                string strPfid = string.Empty;
                foreach (GridViewRow gvrow in gvRole.Rows)
                {
                    CheckBox CheckBox = gvrow.FindControl("chbSelect") as CheckBox;
                    if (CheckBox.Checked)
                    {
                        strRlid = this.gvRole.DataKeys[gvrow.RowIndex]["Rl_id"].ToString();
                        strPfid = this.gvRole.DataKeys[gvrow.RowIndex]["Pf_id"].ToString();
                    }
                }
                Response.Redirect(string.Format("RoleModuleEdit.aspx?Rlid={0}&Pfid={1}&Action=1", strRlid, strPfid));
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

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnDel_Click(object sender, EventArgs e)
        {
            String strRlids = string.Empty;
            string strRlnames = string.Empty;

            foreach (GridViewRow gvrow in gvRole.Rows)
            {
                CheckBox CheckBox = gvrow.FindControl("chbSelect") as CheckBox;
                if (CheckBox.Checked)
                {
                    strRlids += this.gvRole.DataKeys[gvrow.RowIndex]["Rl_id"].ToString() + "|";
                    strRlnames += this.gvRole.DataKeys[gvrow.RowIndex]["Rl_name"].ToString() + ",";
                }
            }
            if (strRlids == "" && strRlids.Length == 0)
            {
                //Jswork.Alert("请至少选择一条记录进行删除", this.Page);

                this.divAlert.Visible = true;
                this.lblAlert.Text = Resources.Resource.tip_only_delete;//"请至少选择一条记录进行删除";

                return;
            }

            strRlids = strRlids.TrimEnd('|');

            RoleMO roleMO = new RoleMO();

            int iSuccess = 0;
            for (int i = 0; i < strRlids.Split('|').Length; i++)
            {
                //if (roleManage.DelRoles("Rl_del = 1", string.Format(" Rl_id = '{0}'", strRlids.Split('|')[i])) > 0)
                StringBuilder strWhere = new StringBuilder();
                strWhere.Append(" 1=1");
                IList<MySqlParameter> parm = new List<MySqlParameter>();

                strWhere.Append(" and Rl_id =@Rl_id");
                parm.Add(new MySqlParameter("@Rl_id", strRlids.Split('|')[i]));
                if (roleManage.DelRoles("Rl_del = 1", strWhere.ToString(),parm) > 0)
                {
                    //插入操作日志
                    InsertLog(Resources.Resource.Delete_role, string.Format("rolename:{0},id:{1}", strRlnames.Split(',')[i], strRlids.Split('|')[i]), 3, GetPlatformIdByValue(1));

                    iSuccess += 1;
                }
            }

            if (iSuccess > 0)
            {
                Jswork.Alert(Resources.Resource.tip_delete_success, this.Page);

                this.BindRole();
            }
        }

        protected void gvRole_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowIndex > -1)
            {
                if (e.Row.Cells[4].Text == "0")
                {
                    e.Row.Cells[4].Text = "On";
                }
                if (e.Row.Cells[4].Text == "1")
                {
                    e.Row.Cells[4].Text = "Off";
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
            for (int i = 0; i <= gvRole.Rows.Count - 1; i++)
            {
                CheckBox CheckBox = (CheckBox)gvRole.Rows[i].FindControl("chbSelect");
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
            this.BindRole();

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
            this.txtRlName.Text = string.Empty;
            this.ddlPf.SelectedValue = string.Empty;
            this.rblState.SelectedValue = "0";

            this.BindRole();

            this.divAlert.Visible = false;
        }

        protected void gvRole_Sorting(object sender, GridViewSortEventArgs e)
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

            this.BindRole();
        }

        /// <summary>
        /// 翻页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvRole_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.gvRole.PageIndex = e.NewPageIndex;
            this.BindRole();
        }
    }
}