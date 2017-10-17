using LZManager.BLL;
using LZManager.BLL.Common;
using LZManager.DAL;
using LZManager.Utility;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;
using TinyFx.Net.Json;
using TinyFx.Net.Json.Linq;

namespace LZManager.WptMall
{
    public partial class GiveDiamond : BasePage
    {

        private string serverUrl = ConfigurationManager.AppSettings["ServerUrl"].ToString();

        private LogPaymentManage lpMange = new LogPaymentManage();
        private UserManage userManage = new UserManage();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["SortOrder"] = "Ur_addTime";
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
            DataView view = userManage.GetTable(" Ur_department > 1 ", null).DefaultView;
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

        protected void gvUsers_RowDataBound(object sender, GridViewRowEventArgs e)
        {

        }

        protected void gvUsers_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.gvUsers.PageIndex = e.NewPageIndex;
            this.BindUsers();
        }

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

        protected void btnGive_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtDiamond.Text.Trim()))
            {
                ShowCommonDlg("请输入钻石数量!");
                return;
            }
            if (Convert.ToInt32(this.txtDiamond.Text.Trim()) < 0)
            {
                ShowCommonDlg("请输入合理的钻石数量!");
                return;
            }
            List<string> uids = new List<string>();
            string strId = "";
            foreach (GridViewRow gvrow in gvUsers.Rows)
            {
                CheckBox CheckBox = gvrow.FindControl("chbSelect") as CheckBox;
                if (CheckBox.Checked)
                {
                    strId = this.gvUsers.DataKeys[gvrow.RowIndex]["Ur_id"].ToString();
                    uids.Add(strId);
                }
            }

            if (uids.Count <= 0)
            {
                ShowCommonDlg("请选择要送钻的代理!");
                return;
            }

            int res = 0;
            string diamondNum = this.txtDiamond.Text.Trim();
            foreach (var uid in uids)
            {
                UsersEO eo = userManage.GetUserByPK(uid);
                if (eo != null)
                {
                    int curDiamond = Convert.ToInt32(eo.UrDiamondNum);
                    int resNum = curDiamond + Convert.ToInt32(diamondNum);
                    res = userManage.PutUrDiamondNumByPK(uid, resNum.ToString());
                }
            }
            if(res>0)
            {
                ShowCommonDlg("赠送钻石成功!");
            }
            else
            {
                ShowCommonDlg("赠送钻石失败!");
            }
            BindUsers();
        }

    }
}