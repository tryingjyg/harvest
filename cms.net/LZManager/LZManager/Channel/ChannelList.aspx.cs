using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LZManager.BLL.Common;
using System.Text;
using LZManager.DAL;
using LZWebApp.BLL.Roulette;
using System.Data;
using LZManager.BLL;
using System.Data.Common;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace LZManager.Game
{
    public partial class ChannelList : BasePage
    {
        ChannelMessage channelMessage = new ChannelMessage();

        protected void Page_Load(object sender, EventArgs e)
        {
            GetAuthorityUrl(this.Page, "Channel/ChannelList.aspx", 0);

            if (!IsPostBack)
            {
                ViewState["SortOrder"] = "Cn_channelId";
                ViewState["OrderDire"] = "DESC";

                this.BindChannel();
            }
        }

        /// <summary>
        /// 绑定数据
        /// </summary>
        private void BindChannel()
        {
            StringBuilder strWhere = new StringBuilder();

            strWhere.Append(" 1=1 ");
            IList<MySqlParameter> parm = new List<MySqlParameter>();           
            if (!string.IsNullOrEmpty(this.txtCnname.Text.Trim()))
            {
                strWhere.Append(" And ac.Cn_name like @Cnname");
                parm.Add(new MySqlParameter("@Cnname", "%"+this.txtCnname.Text.Trim()+"%"));
            }
            if (this.rblState.SelectedValue == "0") //0启用1停用 默认0
            {
                strWhere.Append(" And ac.Cn_state = 0");
            }
            else
            {
                strWhere.Append(" And ac.Cn_state = 1");
            }
            strWhere.Append(" And ac.Cn_Del = 0 ");

            DataView view = channelMessage.GetTable(strWhere.ToString(),parm).DefaultView;
            string sort = (string)ViewState["SortOrder"] + " " + (string)ViewState["OrderDire"];

            view.Sort = sort;

            this.gvChannel.DataSource = view;
            this.gvChannel.DataBind();
        }

        protected void chbSelectAll_CheckedChanged(object sender, EventArgs e)
        {

            for (int i = 0; i <= gvChannel.Rows.Count - 1; i++)
            {
                CheckBox CheckBox = (CheckBox)gvChannel.Rows[i].FindControl("chbSelect");
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
            for (int i = 0; i <= gvChannel.Rows.Count - 1; i++)
            {
                CheckBox CheckBox = (CheckBox)gvChannel.Rows[i].FindControl("chbSelect");
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
            Response.Redirect("ChannelEdit.aspx?State=A&Action=0");
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
                foreach (GridViewRow gvrow in gvChannel.Rows)
                {
                    CheckBox CheckBox = gvrow.FindControl("chbSelect") as CheckBox;
                    if (CheckBox.Checked)
                    {
                        strId = this.gvChannel.DataKeys[gvrow.RowIndex]["Cn_id"].ToString();
                    }
                }
                Response.Redirect(string.Format("ChannelEdit.aspx?State=U&Chid={0}&Action=1", strId));
            }

            else if (this.SelectCount() == 0)
            {
                this.divAlert.Visible = true;
                this.lblAlert.Text = Resources.Resource.tip_one_modify;//"请选择一条记录进行修改";
            }
            else
            {
                this.divAlert.Visible = true;
                this.lblAlert.Text = Resources.Resource.tip_only_modify;//"一次只能修改一条记录";
            }
        }

        protected void btnDel_Click(object sender, EventArgs e)
        {
            String strPfids = string.Empty;
            string strPfnames = string.Empty;

            foreach (GridViewRow gvrow in gvChannel.Rows)
            {
                CheckBox CheckBox = gvrow.FindControl("chbSelect") as CheckBox;
                if (CheckBox.Checked)
                {
                    strPfids += this.gvChannel.DataKeys[gvrow.RowIndex]["Cn_id"].ToString() + "|";
                    strPfnames += this.gvChannel.DataKeys[gvrow.RowIndex]["Cn_channelId"].ToString() + ",";
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
                if (channelMessage.Del(strPfids.Split('|')[i]) > 0)
                {
                    InsertLog(Resources.Resource.Delete_channel, string.Format("Cn_name:{0},Cn_id:{1}", strPfnames.Split(',')[i], strPfids.Split('|')[i]), -5, GetPlatformIdByValue(1));
                    iSuccess += 1;
                }
            }

            if (iSuccess > 0)
            {
                Jswork.Alert(Resources.Resource.tip_delete_success, this.Page);

                this.BindChannel();
            }
        }

        protected void gvChannel_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowIndex > -1)
            {
                if (e.Row.Cells[4].Text == "0")
                {
                    e.Row.Cells[4].Text = Resources.Resource.On;//"启用";
                }
                if (e.Row.Cells[4].Text == "1")
                {
                    e.Row.Cells[4].Text = Resources.Resource.Off; //"停用";
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
            for (int i = 0; i <= gvChannel.Rows.Count - 1; i++)
            {
                CheckBox CheckBox = (CheckBox)gvChannel.Rows[i].FindControl("chbSelect");
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
            this.BindChannel();
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
            this.txtCnname.Text = string.Empty;
            this.rblState.SelectedValue = "0";

            this.BindChannel();

            this.divAlert.Visible = false;
        }
        /// <summary>
        /// 排序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvChannel_Sorting(object sender, GridViewSortEventArgs e)
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

            this.BindChannel();
        }


        /// <summary>
        /// 翻页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvChannel_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.gvChannel.PageIndex = e.NewPageIndex;
            this.BindChannel();
        }
    }
}