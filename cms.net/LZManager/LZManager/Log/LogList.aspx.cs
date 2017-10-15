using System;
using System.Web.UI.WebControls;
using LZManager.BLL.Common;
using LZManager.BLL;
using LZManager.Common;
using LZWebApp.BLL.Roulette;
using LZManager.DAL;
using System.Text;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;
using System.Web;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Web.Script.Serialization;
using TinyFx.Net.Json;
using LZManager.Utility;
using TinyFx.Net.Json.Linq;


namespace LZManager.Log
{
    public partial class LogList : BasePage
    {
        LoPfanage loPfanage = new LoPfanage();
        NxPlatformMO _mo = new NxPlatformMO("LZBgAuthorityConn");

        private string serverUrl = "http://192.168.1.101:8888";

        protected void Page_Load(object sender, EventArgs e)
        {
            GetAuthorityUrl(this.Page, "Log/LogList.aspx", 0);

            if (!IsPostBack)
            {
                InitTime();
                this.LoadPlatform();
                ViewState["SortOrder"] = "Lg_addtime";
                ViewState["OrderDire"] = "DESC";
            }


        }

        /// <summary>
        /// 初始化时间,只能查询当前的30天之内的时间
        /// </summary>
        public void InitTime()
        {
            if (string.IsNullOrEmpty(this.txtStartTime.Text))
            {
                this.txtStartTime.Text = DateTime.Now.AddMonths(-1).ToString("yyyy-MM-dd 07:00:00");
            }
            if (string.IsNullOrEmpty(this.txtEndTime.Text))
            {
                this.txtEndTime.Text = DateTime.Now.ToString("yyyy-MM-dd 07:00:00");
            }



        }


        /// <summary>
        /// 加载平台
        /// </summary>
        private void LoadPlatform()
        {
            DataTable dt = GetPlatformTableByUserid();

            foreach (DataRow dr in dt.Rows)
            {
                ListItem item = new ListItem();
                item.Text = dr["Pf_name"].ToString();
                item.Value = dr["Pf_id"].ToString();

                if (dr["Pf_sort"].ToString() != "2")
                {
                    //this.ddlPf.Items.Add(item);
                }
            }
            //this.ddlPf.Items.Insert(0, new ListItem("请选择平台", string.Empty));
        }

        /// <summary>
        /// 绑定日志数据
        /// </summary>
        private DataTable BindLogs()
        {
            
            string STime = txtStartTime.Text.Trim();
            string ETime = txtEndTime.Text.Trim();
            if (string.IsNullOrEmpty(STime)||string.IsNullOrEmpty(ETime))
            {
                PubFuncs.ResponseRandomAlert("查询开始时间或者结束时间不能为空", this);

                return null;
            }
             TimeSpan timespan = (TimeSpan)(DateTime.Parse(ETime) - DateTime.Parse(STime));
            if (timespan.Days > 32)
            {
               PubFuncs.ResponseRandomAlert("查询天数不能大于30天", this);
               return null;
            }

            else
            {
                StringBuilder strWhere = new StringBuilder();
                strWhere.Append(" 1=1");
                IList<MySqlParameter> parm = new List<MySqlParameter>();
                //if (!string.IsNullOrEmpty(this.ddlPf.SelectedValue))
                //{
                //    //strWhere.Append(string.Format(" And log.Lg_text2 = '{0}' ", ddlPf.SelectedValue));
                //    strWhere.Append(" And log.Lg_text2 = @SelectedValue ");
                //    parm.Add(new MySqlParameter("@SelectedValue", this.ddlPf.SelectedValue));
                //}
                //else
                //{
                //    if (GetUserLeave() < 90)
                //    {
                //        CloseDivImplementation();
                //        Jswork.Alert("请选择要查询的平台");
                //        return null;
                //    }
                //}

                //if (!string.IsNullOrEmpty(this.txtName.Text.Trim()))
                //{
                //    //strWhere.Append(string.Format(" And log.Lg_name like '%{0}%'",this.txtName.Text.Trim()));
                //    strWhere.Append(" And log.Lg_name like @Cnname");
                //    parm.Add(new MySqlParameter("@Cnname", "%" + this.txtName.Text.Trim() + "%"));
                //}
                if (!string.IsNullOrEmpty(this.txtUrName.Text.Trim()))
                {
                    //strWhere.Append(string.Format(" And users.Ur_name like '%{0}%'",this.txtUrName.Text.Trim()));
                    strWhere.Append(" And users.Ur_name like @Unname");
                    parm.Add(new MySqlParameter("@Unname", "%" + this.txtUrName.Text.Trim() + "%"));
                }
                if (!string.IsNullOrEmpty(this.txtStartTime.Text.Trim()))
                {
                    //strWhere.Append(string.Format(" And log.Lg_addtime >= '{0}'", Convert.ToDateTime(this.txtStartTime.Text.Trim())));
                    strWhere.Append(" And log.Lg_addtime >=  @Lgaddtime");
                    parm.Add(new MySqlParameter("@Lgaddtime", Convert.ToDateTime(this.txtStartTime.Text.Trim())));
                }
                if (!string.IsNullOrEmpty(this.txtEndTime.Text.Trim()))
                {
                    //strWhere.Append(string.Format(" And log.Lg_addtime < '{0}'", Convert.ToDateTime(this.txtEndTime.Text.Trim())));
                    strWhere.Append(" And log.Lg_addtime <  @LgEddtime");
                    parm.Add(new MySqlParameter("@LgEddtime", Convert.ToDateTime(this.txtEndTime.Text.Trim())));
                }

                //DataTable dt = loPfanage.GetList(strWhere.ToString());
                DataTable dt = new NxLogMO().GetTableBySql(strWhere.ToString(), parm);


                DataView view = dt.DefaultView;
                string sort = (string)ViewState["SortOrder"] + " " + (string)ViewState["OrderDire"];

                view.Sort = sort;

                this.gvLogs.DataSource = view;
                this.gvLogs.DataBind();

                if (dt != null && dt.Rows.Count > 0)
                {
                    this.divAlert.Visible = true;
                    this.lblAlert.Text = "一共：" + view.Count.ToString() + "数据";

                    this.btnExport.Enabled = true;
                }
                else
                {
                    this.divAlert.Visible = false;
                    this.btnExport.Enabled = false;
                }

                return dt;
                
            }

            
        }

        protected void gvLogs_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                if (e.Row.RowState == DataControlRowState.Normal || e.Row.RowState == DataControlRowState.Alternate)
                {
                    string s = e.Row.Cells[4].Text.Trim();
                    if (s.Length > 100)
                    {
                        e.Row.Cells[4].Text = s.Remove(100, s.Length - 100) + "...";
                    }
                    //当鼠标停留时更改背景色
                    e.Row.Attributes.Add("onmouseover", "c=this.style.backgroundColor;this.style.backgroundColor='#00A9FF'");
                    //当鼠标移开时还原背景色
                    e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=c");
                }
            }
        }

        /// <summary>
        /// 按条件搜索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            BindLogs();
            CloseDivImplementation();
        }

        /// <summary>
        /// 重置搜索条件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnReset_Click(object sender, EventArgs e)
        {
            //this.ddlPf.SelectedValue = string.Empty;
            //this.txtName.Text = string.Empty;

            this.BindLogs();
        }

        /// <summary>
        /// 导出Excel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnExport_Click(object sender, EventArgs e)
        {
            DataTable dt = BindLogs();

            StringWriter sw = new StringWriter();
            sw.WriteLine(" <table> ");
            sw.WriteLine(" <tr> ");
            sw.WriteLine("<td>姓名</td><td>部门</td><td>ip地址</td><td>操作内容</td><td>详情</td><td>时间</td><td>Id</td>");
            sw.WriteLine(" </tr> ");
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    //sw.WriteLine("<tr><td>" + dt.Rows[i]["Ur_name"].ToString() + "</td><td>" + dt.Rows[i]["Ur_department"].ToString() + "</td><td>" + dt.Rows[i]["Lg_userip"].ToString() + "</td><td>" + dt.Rows[i]["Lg_name"].ToString() + "</td><td>" + CommonUtil.NoHTML(dt.Rows[i]["Lg_content"].ToString()) + "</td><td>" + dt.Rows[i]["Lg_addtime"].ToString() + "</td><td>" + dt.Rows[i]["Lg_text2"].ToString() + "</td></tr>");
                    
                    if (!string.IsNullOrEmpty(dt.Rows[i]["Ur_name"].ToString()))
                    {
                        sw.WriteLine("<tr><td>" + dt.Rows[i]["Ur_name"].ToString() + "</td><td>" + dt.Rows[i]["Ur_department"].ToString() + "</td><td>" + dt.Rows[i]["Lg_userip"].ToString() + "</td><td>" + dt.Rows[i]["Lg_name"].ToString() + "</td><td>" + CommonUtil.NoHTML(dt.Rows[i]["Lg_content"].ToString()) + "</td><td>" + dt.Rows[i]["Lg_addtime"].ToString() + "</td><td>" + dt.Rows[i]["Lg_text2"].ToString() + "</td></tr>");
                    }
                    else
                    {
                        sw.WriteLine("<tr><td>NULL</td><td>tNULL</td><td>" + dt.Rows[i]["Lg_userip"].ToString() + "</td><td>" + dt.Rows[i]["Lg_name"].ToString() + "</td><td>" + CommonUtil.NoHTML(dt.Rows[i]["Lg_content"].ToString()) + "</td><td>" + dt.Rows[i]["Lg_addtime"].ToString() + "</td></tr>");
                    }
                }
            }
            sw.Close();

            //HttpContext.Current.Response.AppendHeader("Content-Disposition", "attachment;filename=Excel.xls");
            //HttpContext.Current.Response.Charset = "gb2312";
            //HttpContext.Current.Response.ContentEncoding = System.Text.Encoding.GetEncoding("gb2312");
            //HttpContext.Current.Response.ContentType = "application/ms-excel";
            //ctl.Page.EnableViewState = false;
            //System.IO.StringWriter tw = new System.IO.StringWriter();
            //System.Web.UI.HtmlTextWriter hw = new System.Web.UI.HtmlTextWriter(tw);
            //ctl.RenderControl(hw);
            //HttpContext.Current.Response.Write(tw.ToString());
            //HttpContext.Current.Response.End(); 

            CloseDivImplementation();
            //Response.ContentEncoding = System.Text.Encoding.GetEncoding("GB2312");
            Response.AddHeader("Content-Disposition", "attachment; filename=" + System.Web.HttpUtility.UrlEncode("操作日志详情" + DateTime.Now.ToString("yyyyMMddmmss"), System.Text.Encoding.UTF8) + ".xls");
            Response.ContentType = "application/ms-excel";

            Response.Write(sw);
            Response.End();

            CloseDivImplementation();
        }

        /// <summary>
        /// 字段排序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvLogs_Sorting(object sender, GridViewSortEventArgs e)
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

            this.BindLogs();
        }

        /// <summary>
        /// 翻页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvLogs_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.gvLogs.PageIndex = e.NewPageIndex;

            BindLogs();
        }

        protected void btnDay_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic["action"] = "IDIP_DO_DAY_LOG_REQ";
            dic["limit"] = "10";
            string json = new JavaScriptSerializer().Serialize(dic);
            string responseStr = HttpClientUlity.PostJsonData(serverUrl, json);

            JObject jo = (JObject)JsonConvert.DeserializeObject(responseStr);
            //this.lblTotalNum.Text = jo["roomNum"].ToString();
        }

        protected void btnReplay_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic["action"] = "IDIP_DO_REPLAY_LOG_REQ";
            dic["uin"] = this.txtPlayerId.Text.Trim();
            string json = new JavaScriptSerializer().Serialize(dic);
            string responseStr = HttpClientUlity.PostJsonData(serverUrl, json);

            JObject jo = (JObject)JsonConvert.DeserializeObject(responseStr);
            //this.lblTotalNum.Text = jo["roomNum"].ToString();
        }

        protected void btnWinInfo_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic["action"] = "IDIP_DO_TABLEINFO_LOG_REQ";
            dic["date"] = this.txtDate.Text.Trim();
            dic["roomId"] = this.txtRoomNo.Text.Trim();
            string json = new JavaScriptSerializer().Serialize(dic);
            string responseStr = HttpClientUlity.PostJsonData(serverUrl, json);

            JObject jo = (JObject)JsonConvert.DeserializeObject(responseStr);
            //this.lblTotalNum.Text = jo["roomNum"].ToString();
        }
    }
}