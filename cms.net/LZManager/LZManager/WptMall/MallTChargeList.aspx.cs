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
using System.Net;
using System.Collections.Specialized;
using System.Web.Script.Serialization;
using System.IO;
using LZManager.Utility;

namespace LZManager.MallCharge
{
    public partial class MallTChargeList : BasePage
    {

        LogChargeManage manager = new LogChargeManage();

        protected void Page_Load(object sender, EventArgs e)
        {
            //GetAuthorityUrl(this.Page, "WptMall/MallTChargeList.aspx", 0);

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
                ViewState["SortOrder"] = "createTime";
                ViewState["OrderDire"] = "DESC";
                //this.BindDepartment(); // 绑定部门
                //BindRoleList(); // 绑定角色
                this.BindLgRecord();
            }
        }


        /// <summary>
        /// 绑定充值数量
        /// </summary>
        private void BindLgRecord()
        {

            StringBuilder strWhere = new StringBuilder();
            DataView view = manager.GetTable(strWhere.ToString(), null).DefaultView;
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
        /// 按条件搜索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            BindLgRecord();

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
            this.BindLgRecord();
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
                if (e.Row.Cells[6].Text == "1")
                {
                    e.Row.Cells[6].Text = "微信";//"启用";
                }
                else if (e.Row.Cells[6].Text == "2")
                {
                    e.Row.Cells[6].Text = "支付宝";//"启用";
                }
                else if (e.Row.Cells[6].Text == "3")
                {
                    e.Row.Cells[6].Text = "QQ钱包";//"启用";
                }
                else if (e.Row.Cells[6].Text == "9")
                {
                    e.Row.Cells[6].Text = "银联";//"启用";
                }
                else
                {
                    e.Row.Cells[6].Text = "未知";//"启用";
                }

                e.Row.Cells[4].Text = string.Format("{0}{1}",(Convert.ToInt32(e.Row.Cells[4].Text)/100).ToString(),"元");

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

            this.BindLgRecord();
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
            this.BindLgRecord();
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
        /// 权限复制或转移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnAuthorityCopy_Click(object sender, EventArgs e)
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
        }

    }
}