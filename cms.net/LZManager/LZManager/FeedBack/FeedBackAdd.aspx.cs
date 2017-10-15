using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using LZManager.BLL.Common;
using LZManager.DAL;
using LZWebApp.BLL.Roulette;
using System.Configuration;

namespace LZManager.FeedBack
{
    public partial class FeedBackAdd : BasePage
    {
        FeedbackMO feedBackMO = new FeedbackMO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (GetUserID() == "")
            {
                Jswork.Alert("亲，请先登录！", "top", ConfigurationManager.AppSettings["WebLoginURL"].ToString());
            }
            if (!IsPostBack)
            {
                BindPlatform();
            }
        }
        /// <summary>
        /// 帮顶平台信息
        /// </summary>
        private void BindPlatform()
        {
            DataTable dt = GetPlatformTableByUserid();
            ddlPf.DataSource = dt;
            ddlPf.DataTextField = "Pf_name";
            ddlPf.DataValueField = "Pf_id";
            ddlPf.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string lasttime = "";
            if (txtTitle.Text == "")
            {
                this.divAlert.Visible = true;
                lblAlert.Text = "请输入反馈标题!";
                CloseDivImplementation(); // 关闭等待框
                return;
            }
            else if (txtMessage.Text == "")
            {
                this.divAlert.Visible = true;
                lblAlert.Text = "请输入反馈内容!";
                CloseDivImplementation(); // 关闭等待框
                return;
            }
            //foreach (FeedbackEO feedBackEOLast in feedBackMO.GetTopSort("Fb_state =0 and Fb_del = 0 and Fb_addUser='" + GetUserID() + "'", 1, "Fb_addTime desc"))
            foreach (FeedbackEO feedBackEOLast in feedBackMO.GetTopSort("Fb_state =0 and Fb_del = 0 and Fb_addUser=@GetUserID", 1, "Fb_addTime desc",GetUserID()))
            {
                lasttime = feedBackEOLast.FbAddTime.ToString();
            }

            if (lasttime != "")
            {
                TimeSpan timespan = new TimeSpan(0,1,0);
                if (DateTime.Now - Convert.ToDateTime(lasttime) < timespan)
                {
                    this.divAlert.Visible = true;
                    lblAlert.Text = "亲，您操作过于频繁，请1分钟后尝试！";
                    CloseDivImplementation(); // 关闭等待框
                    return;
                }
            }
            this.divAlert.Visible = false;
            FeedbackEO feedBackEO = new FeedbackEO();
            feedBackEO.FbTitle = txtTitle.Text;
            feedBackEO.FbDescription = txtMessage.Text;
            UpFile upfile = new UpFile();
            string a = "";
            string ImgName = upfile.UpLoadImage(FileUpload1, GetBigGuid(), this.Page, out a, "../File/FeedBackFile/");
            feedBackEO.FbUrl = ImgName;
            feedBackEO.FbDel = "0";
            feedBackEO.FbState = "0";
            feedBackEO.PfId = ddlPf.Text;
            feedBackEO.FbAddUser = GetUserID();
            feedBackEO.FbAddTime = DateTime.Now;

            if (feedBackMO.Add(feedBackEO) > 0)
            {
                InsertLog("问题反馈", GetDisPlayName(feedBackEO), -2, GetPlatformIdByValue(1)); //  添加日志
                Jswork.AlertAndRedirect("问题提交成功,我们会尽快处理!", "FeedBackList.aspx", this.Page);
            }
            else
            {
                Jswork.AlertAndRedirect("问题提交声失败,请与管理员联系!", "FeedBackList.aspx", this.Page);
            }
            CloseDivImplementation();
        }
    }
}