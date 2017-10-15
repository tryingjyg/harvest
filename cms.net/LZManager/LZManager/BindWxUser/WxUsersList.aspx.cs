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

namespace LZManager.BindWxUser
{
    public partial class WxUsersList : BasePage
    {
        //UserManage userManage = new UserManage();
        //RoleManage roleManage = new RoleManage();
        WxUserManage wxUserManage = new WxUserManage();

        protected void Page_Load(object sender, EventArgs e)
        {
            //GetAuthorityUrl(this.Page, "BindWxUser/WxUsersList.aspx", 0);

            if (GetUserLeave() >= 90)
            {
                btnAuthorityCopy.Visible = true;
            }
            else
            {
                btnAuthorityCopy.Visible = false;
            }
            if (!IsPostBack)
            {
                ViewState["SortOrder"] = "Wx_bindtime";
                ViewState["OrderDire"] = "DESC";
                this.BindUsers();
            }
        }

        /// <summary>
        /// 绑定用户数据
        /// </summary>
        private void BindUsers()
        {
            UsersEO usersEO = GetUser(); // 获取登录用户的信息
            int leave = GetUserLeave(); //  获取用户级别

            StringBuilder strWhere = new StringBuilder();
            IList<MySqlParameter> parm = new List<MySqlParameter>();

            string beginTime = this.txtBeginTime.Text.Trim();
            string endTime = this.txtEndTime.Text.Trim();
            string queryId = this.txtdId.Text.Trim();

            int curGameId = 0;
            if (!string.IsNullOrEmpty(Session["currentgameid"].ToString()))
            {
                curGameId = Convert.ToInt32(Session["currentgameid"].ToString());
            }
            if (curGameId != 0)
            {
                this.txtdId.Visible = false;
                bool isFirst = true;
                strWhere.Append(string.Format(" Wx_duid = '{0}'", curGameId));
                if (!string.IsNullOrEmpty(beginTime))
                {
                    strWhere.Append(string.Format(" And Wx_bindtime > '{0}'", beginTime));
                    isFirst = false;
                }
                if (!string.IsNullOrEmpty(endTime))
                {
                    if (isFirst)
                    {
                        strWhere.Append(string.Format(" And Wx_bindtime < '{0}'", endTime));
                    }
                    else
                    {
                        strWhere.Append(string.Format(" And Wx_bindtime < '{0}'", endTime));
                    }
                }
            }
            else
            {
                //管理员
                this.txtdId.Visible = true;
                bool isQuereIdNull = true;
                if (!string.IsNullOrEmpty(queryId))
                {
                    strWhere.Append(string.Format(" Wx_duid = '{0}'", queryId));
                    isQuereIdNull = false;
                }
                if (!string.IsNullOrEmpty(beginTime))
                {
                    if (isQuereIdNull)
                    {
                        strWhere.Append(string.Format(" Wx_bindtime > '{0}'", beginTime));
                    }
                    else
                    {
                        strWhere.Append(string.Format(" And Wx_bindtime > '{0}'", beginTime));
                    }

                }
                if (!string.IsNullOrEmpty(endTime))
                {
                    strWhere.Append(string.Format(" And Wx_bindtime < '{0}'", endTime));
                }
            }


            DataView view = wxUserManage.GetTable(strWhere.ToString(), parm).DefaultView;
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
            /*
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
            */
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
            this.txtBeginTime.Text = string.Empty;
            this.txtEndTime.Text = string.Empty;
            this.rblState.SelectedValue = "0";
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
                string text = e.Row.Cells[5].Text;
                if (e.Row.Cells[5].Text == "0")
                {
                    e.Row.Cells[5].Text = "女";
                }
                else if (e.Row.Cells[5].Text == "1")
                {
                    e.Row.Cells[5].Text = "男";
                }
                else
                {
                    e.Row.Cells[5].Text = "未知";
                }

                e.Row.Cells[4].Text = e.Row.Cells[4].Text.Substring(0, 50).Trim();
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
        /// 权限复制或转移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnAuthorityCopy_Click(object sender, EventArgs e)
        {
            StringBuilder unionIds = new StringBuilder();
            StringBuilder openids = new StringBuilder();
            StringBuilder names = new StringBuilder();
            for (int i = 0; i <= gvUsers.Rows.Count - 1; i++)
            {
                CheckBox CheckBox = (CheckBox)gvUsers.Rows[i].FindControl("chbSelect");
                if (CheckBox.Checked == true)
                {
                    string strId = this.gvUsers.DataKeys[gvUsers.Rows[i].RowIndex]["Wx_id"].ToString();
                    unionIds.Append(strId);
                    unionIds.Append(",");

                    string openId = this.gvUsers.DataKeys[gvUsers.Rows[i].RowIndex]["Wx_openid"].ToString();
                    openids.Append(openId);
                    openids.Append(",");

                    string strName = this.gvUsers.DataKeys[gvUsers.Rows[i].RowIndex]["Wx_nickname"].ToString();
                    names.Append(strName);
                    names.Append(",");
                }
            }
            if (!string.IsNullOrEmpty(unionIds.ToString()))
            {
                Response.Redirect(string.Format("AuthorityCopy.aspx?State=U&tranferids={0}&openids={1}&traname={2}", unionIds.ToString(), openids.ToString(), names.ToString()));
            }
            else
            {
                this.divAlert.Visible = true;
                this.lblAlert.Text = "请选择要转移的账号"; //"请选择一条记录进行修改";
            }
            //一次只能修改一条记录
            /*
            if (this.SelectCount() == 1)
            {
                string strId = string.Empty;
                foreach (GridViewRow gvrow in gvUsers.Rows)
                {
                    CheckBox CheckBox = gvrow.FindControl("chbSelect") as CheckBox;
                    if (CheckBox.Checked)
                    {
                        strId = this.gvUsers.DataKeys[gvrow.RowIndex]["Wx_id"].ToString();
                    }
                }
                Response.Redirect(string.Format("AuthorityCopy.aspx?State=U&Urid={0}&Action=1", strId));
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
            */
        }
    }
}