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
using MySql.Data.MySqlClient;

namespace LZManager.Game
{
    public partial class GameList : BasePage
    {
        GameMessage gameMessage = new GameMessage();

        protected void Page_Load(object sender, EventArgs e)
        {
            GetAuthorityUrl(this.Page, "Game/GameList.aspx", 0);

            if (!IsPostBack)
            {
                ViewState["SortOrder"] = "Gm_gameId";
                ViewState["OrderDire"] = "DESC";

                this.BindGame();
            }
        }

        /// <summary>
        /// 绑定数据
        /// </summary>
        private void BindGame()
        {
            StringBuilder strWhere = new StringBuilder();

            strWhere.Append(" 1=1 ");
            IList<MySqlParameter> parm = new List<MySqlParameter>();
            if (!string.IsNullOrEmpty(this.txtCnname.Text.Trim()))
            {
                //strWhere.Append(" And gm.Gm_name like '%" + this.txtCnname.Text.Trim() + "%'");
                strWhere.Append(" And gm.Gm_name like @Cnname");
                parm.Add(new MySqlParameter("@Cnname", "%" + this.txtCnname.Text.Trim() + "%"));
            }
            if (this.rblState.SelectedValue == "0") //0启用1停用 默认0
            {
                strWhere.Append(" And gm.Gm_state = 0");
            }
            else
            {
                strWhere.Append(" And gm.Gm_state = 1");
            }
            strWhere.Append(" And gm.Gm_del = 0 ");

            //DataView view = gameMessage.GetTable(strWhere.ToString()).DefaultView;
           
            string sort = (string)ViewState["SortOrder"] + " " + (string)ViewState["OrderDire"];
            // view = gameMessage.GetTable(strWhere.ToString(),parm,sort);
            //view.Sort = sort;

             this.gvGame.DataSource = gameMessage.GetTable(strWhere.ToString(), parm); ;
            this.gvGame.DataBind();
        }

        /// <summary>
        /// 绑定渠道号
        /// </summary>
        /// <returns></returns>
        public string BindChannelID(object gameId)
        {
            string message = "";
            DataTable dt = gameMessage.GetCannelListByGameId(gameId.ToString());

            if (dt.Rows.Count != 0)
            {
                foreach (DataRow dr in dt.Rows) // 循环数据
                {
                    message += dr["Cn_name"] + "(" + dr["Cn_channelId"] + ");";
                }
            }
            return message;
        }


        protected void chbSelectAll_CheckedChanged(object sender, EventArgs e)
        {

            for (int i = 0; i <= gvGame.Rows.Count - 1; i++)
            {
                CheckBox CheckBox = (CheckBox)gvGame.Rows[i].FindControl("chbSelect");
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
            for (int i = 0; i <= gvGame.Rows.Count - 1; i++)
            {
                CheckBox CheckBox = (CheckBox)gvGame.Rows[i].FindControl("chbSelect");
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
            Response.Redirect("GameEdit.aspx?State=A&Action=0");
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
                foreach (GridViewRow gvrow in gvGame.Rows)
                {
                    CheckBox CheckBox = gvrow.FindControl("chbSelect") as CheckBox;
                    if (CheckBox.Checked)
                    {
                        strId = this.gvGame.DataKeys[gvrow.RowIndex]["Gm_gameId"].ToString();
                    }
                }
                Response.Redirect(string.Format("GameEdit.aspx?State=U&Gm_gameId={0}&Action=1", strId));
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

            foreach (GridViewRow gvrow in gvGame.Rows)
            {
                CheckBox CheckBox = gvrow.FindControl("chbSelect") as CheckBox;
                if (CheckBox.Checked)
                {
                    strPfids += this.gvGame.DataKeys[gvrow.RowIndex]["Gm_gameId"].ToString() + "|";
                    strPfnames += this.gvGame.DataKeys[gvrow.RowIndex]["Gm_name"].ToString() + ",";
                }
            }
            if (strPfids == "" && strPfids.Length == 0)
            {
                this.divAlert.Visible = true;
                this.lblAlert.Text = Resources.Resource.tip_only_delete; //"请至少选择一条记录进行删除";

                return;
            }

            strPfids = strPfids.TrimEnd('|');

            NxPlatformMO pmMO = new NxPlatformMO();

            int iSuccess = 0;
            for (int i = 0; i < strPfids.Split('|').Length; i++)
            {
                if (gameMessage.Del(strPfids.Split('|')[i]) > 0)
                {
                    InsertLog(Resources.Resource.Delete_game, string.Format("Gm_gameId:{0},Gm_name:{1}", strPfnames.Split(',')[i], strPfids.Split('|')[i]), 5011, GetPlatformIdByValue(1));
                    iSuccess += 1;
                }
            }

            if (iSuccess > 0)
            {
                Jswork.Alert(Resources.Resource.tip_delete_success, this.Page);

                this.BindGame();
            }
        }

        protected void gvGame_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowIndex > -1)
            {
                if (e.Row.Cells[4].Text == "0")
                {
                    e.Row.Cells[4].Text = Resources.Resource.On;//"启用";
                }
                if (e.Row.Cells[4].Text == "1")
                {
                    e.Row.Cells[4].Text = Resources.Resource.Off;//"停用";
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
            for (int i = 0; i <= gvGame.Rows.Count - 1; i++)
            {
                CheckBox CheckBox = (CheckBox)gvGame.Rows[i].FindControl("chbSelect");
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
            this.BindGame();
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

            this.BindGame();

            this.divAlert.Visible = false;
        }
        /// <summary>
        /// 排序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvGame_Sorting(object sender, GridViewSortEventArgs e)
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

            this.BindGame();
        }

        /// <summary>
        /// 翻页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvGame_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.gvGame.PageIndex = e.NewPageIndex;
            this.BindGame();
        }
    }
}