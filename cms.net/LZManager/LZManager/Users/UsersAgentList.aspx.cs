using System;
using System.Web.UI.WebControls;
using LZManager.BLL.Common;
using LZManager.BLL;
using LZWebApp.BLL.Roulette;
using LZManager.DAL;
using System.Text;
using System.Data;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using ThoughtWorks.QRCode.Codec;
using System.Configuration;

namespace LZManager.Users
{
    public partial class UsersAgentList : BasePage
    {
        UserManage userManage = new UserManage();
        RoleManage roleManage = new RoleManage();

        protected void Page_Load(object sender, EventArgs e)
        {
            //GetAuthorityUrl(this.Page, "Users/UsersList.aspx", 0);

            //if (GetUserLeave() >= 90)
            //{
            //    btnAuthorityCopy.Visible = true;
            //}
            //else
            //{
            //    btnAuthorityCopy.Visible = false;
            //}
            if (!IsPostBack)
            {
                ViewState["SortOrder"] = "Ur_addTime";
                ViewState["OrderDire"] = "DESC";
                //this.BindDepartment(); // 绑定部门
                //BindRoleList(); // 绑定角色
                this.BindUsers();
            }
        }

        /// <summary>
        /// 绑定用户数据
        /// </summary>
        private void BindUsers()
        {
            UsersEO usersEO = GetUser(); // 获取登录用户的信息
            string loginName = "";
            StringBuilder sb = new StringBuilder();

            UsersEO um = userManage.GetUser(GetUserID());
            if (GetUserDepartment() > 1)
            {
                if (usersEO != null)
                {
                    loginName = usersEO.UrLoginName;
                    sb.Append(string.Format(" Ur_parent = '{0}'", loginName));
                }

                if (!string.IsNullOrEmpty(this.txtLoginName.Text))
                {
                    sb.Append(string.Format(" and Ur_loginName = '{0}'", this.txtLoginName.Text.Trim()));
                }
            }
            IList<MySqlParameter> parm = new List<MySqlParameter>();
            //public virtual DataTable GetTable(string where, int top, string sort, IEnumerable<DbParameter> paras)
            DataView view = userManage.GetTable(sb.ToString(), null).DefaultView;

            string sort = (string)ViewState["SortOrder"] + " " + (string)ViewState["OrderDire"];

            view.Sort = sort;

            this.gvUsers.DataSource = view;
            this.gvUsers.DataBind();
        }

        /// <summary>
        /// 全选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void chbSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i <= gvUsers.Rows.Count - 1; i++)
            {
                CheckBox CheckBox = (CheckBox)gvUsers.Rows[i].FindControl("chbSelect");
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
            for (int i = 0; i <= gvUsers.Rows.Count - 1; i++)
            {
                CheckBox CheckBox = (CheckBox)gvUsers.Rows[i].FindControl("chbSelect");
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
            Response.Redirect("UsersEdit.aspx?State=A&Action=0");
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
                foreach (GridViewRow gvrow in gvUsers.Rows)
                {
                    CheckBox CheckBox = gvrow.FindControl("chbSelect") as CheckBox;
                    if (CheckBox.Checked)
                    {
                        strId = this.gvUsers.DataKeys[gvrow.RowIndex]["Ur_id"].ToString();
                    }
                }
                Response.Redirect(string.Format("UsersEdit.aspx?State=U&Urid={0}&Action=1", strId));
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
                this.lblAlert.Text = Resources.Resource.tip_only_modify; //"一次只能修改一条记录";
            }
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnDel_Click(object sender, EventArgs e)
        {
            String strUrids = string.Empty;
            String strNames = string.Empty;

            foreach (GridViewRow gvrow in gvUsers.Rows)
            {
                CheckBox CheckBox = gvrow.FindControl("chbSelect") as CheckBox;
                if (CheckBox.Checked)
                {
                    strUrids += this.gvUsers.DataKeys[gvrow.RowIndex]["Ur_id"].ToString() + "|";
                    strNames += this.gvUsers.DataKeys[gvrow.RowIndex]["Ur_name"].ToString() + ",";
                }
            }
            if (strUrids == "" && strUrids.Length == 0)
            {
                //Jswork.Alert("请至少选择一条记录进行删除", this.Page);

                this.divAlert.Visible = true;
                this.lblAlert.Text = Resources.Resource.tip_only_delete; //"请至少选择一条记录进行删除";

                return;
            }

            strUrids = strUrids.TrimEnd('|');

            UsersMO usersMO = new UsersMO();

            int iSuccess = 0;
            for (int i = 0; i < strUrids.Split('|').Length; i++)
            {
                StringBuilder strWhere = new StringBuilder();
                strWhere.Append(" 1=1");
                IList<MySqlParameter> parm = new List<MySqlParameter>();

                strWhere.Append(" and Ur_id =@Rl_id");
                parm.Add(new MySqlParameter("@Rl_id", strUrids.Split('|')[i]));
                if (userManage.DelUsers("Ur_del = 1", strWhere.ToString(), parm) > 0)
                //if (userManage.DelUsers("Ur_del = 1", string.Format(" Ur_id = '{0}'", strUrids.Split('|')[i])) > 0)
                {
                    //插入操作日志表
                    InsertLog("删除用户", string.Format("username:{0},id:{1}", strNames.Split(',')[i], strUrids.Split('|')[i]), 3, GetPlatformIdByValue(1));

                    iSuccess += 1;
                }
            }

            if (iSuccess > 0)
            {
                //Jswork.Alert("删除成功", this.Page);
                Jswork.Alert(Resources.Resource.tip_delete_success, this.Page);

                this.BindUsers();
            }
        }

        /// <summary>
        /// 按条件搜索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            BindUsers();
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
            this.txtLoginName.Text = string.Empty;
            this.BindUsers();
            this.divAlert.Visible = false;
        }

        /// <summary>
        /// 数据绑定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvUsers_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowIndex > -1)
            {
                //if (e.Row.Cells[12].Text == "1")
                //{
                //    e.Row.Cells[12].Text = "管理员";
                //}
                //else if (e.Row.Cells[12].Text == "2")
                //{
                //    e.Row.Cells[12].Text = "机构代理";
                //}
                //else if (e.Row.Cells[12].Text == "3")
                //{
                //    e.Row.Cells[12].Text = "普通代理";
                //}
                //else
                //{
                //    e.Row.Cells[12].Text = "未知";
                //}
            }
        }

        /// <summary>
        /// 字段排序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvUsers_Sorting(object sender, GridViewSortEventArgs e)
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

            this.BindUsers();
        }

        /// <summary>
        /// 返回GridView中CheckBox选择了几个
        /// </summary>
        /// <returns></returns>
        private int SelectCount()
        {
            int iSelectCount = 0;
            for (int i = 0; i <= gvUsers.Rows.Count - 1; i++)
            {
                CheckBox CheckBox = (CheckBox)gvUsers.Rows[i].FindControl("chbSelect");
                if (CheckBox.Checked == true)
                {
                    iSelectCount += 1;
                }
            }

            return iSelectCount;
        }

        protected void gvUsers_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.gvUsers.PageIndex = e.NewPageIndex;
            this.BindUsers();
        }

        /// <summary>
        /// 根据ID查询所属级别名称
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetUserLeaveNameById(object id)
        {
            string leavename = "未知";
            List<string[]> list = GetUserLeaveByString();
            try
            {
                foreach (string[] nums in list)
                {
                    if (nums[1].Trim().ToString() == id.ToString().Trim())
                    {
                        leavename = nums[0].Trim().ToString();
                    }
                }
            }
            catch { leavename = "异常"; }
            return leavename;
        }


        /// <summary>
        /// 根据用户ID 获取角色字符串
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public string GetRoleList(object userid)
        {
            string Platformid = "";
            string result = "";
            DataTable dt = userManage.GetRoleByUserId(userid.ToString());
            int a = 0;
            foreach (DataRow dr in dt.Rows)
            {
                if (a == 2)
                {
                    result += "<br />";
                    a = 0;
                }
                else if (dr["Pf_id"].ToString() != Platformid && Platformid != "")
                {
                    result += "<br />";
                    a = 0;
                }

                result += dr["Rl_name"].ToString() + ",";
                a++;

                Platformid = dr["Pf_id"].ToString();

            }
            return result;
        }

    }
}