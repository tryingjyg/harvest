using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LZManager.BLL.Common;
using LZManager.DAL;
using LZWebApp.BLL.Roulette;
using LZManager.BLL;
using System.Data;

namespace LZManager.Framework
{
    public partial class Main : BasePage
    {
        LoPfanage loPfanage = new LoPfanage();
        PlatformMO platformMO = new PlatformMO();

        private string Platformid
        {
            get
            {
                try
                {
                    return Request.QueryString["Platform"].ToString();
                }
                catch
                {
                    return "";
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            string imgurl = "../images/farmework/admin_p.gif"; // 图片默认地址

            if (Platformid != "") // 修改图片显示
            {
                try
                {
                    PlatformEO platformEO = platformMO.GetByPK(Platformid);
                    if (platformEO != null)
                    {
                        imgurl = platformEO.PfImgUrl;
                        imglogo.Height = 100;
                        imglogo.Width = 160;
                    }
                    lbl_Pname.Text = platformEO.PfName;
                }
                catch { }
            }

            imglogo.ImageUrl = imgurl;

            if (!IsPostBack)
            {
                UsersEO usersEO = GetUser(); // 获取用户基本信息
                if (usersEO.UrId.ToString() != "")
                {
                    lblUser.Text = usersEO.UrName; // 用户名
                    lblUserName.Text = usersEO.UrLoginName; // 登录名
                    lblAddTime.Text = Convert.ToDateTime(usersEO.UrAddTime).ToString("yyyy-MM-dd hh:ss:mm"); // 添加时间
                    lblNum.Text = loPfanage.GetNumByUserId(usersEO.UrId, 0).ToString(); // 登录次数
                    DataTable dt = loPfanage.GetTableByUserid(usersEO.UrId, 0, 2);

                    if (dt != null)
                    {
                        if (dt.Rows.Count >= 2)
                        {
                            lblNowLoginTime.Text = dt.Rows[0]["Lg_addtime"].ToString(); //  本次登陆时间
                            lblLastLoginTime.Text = dt.Rows[1]["Lg_addtime"].ToString(); //  上次登陆时间
                            lblNowLoginIp.Text = dt.Rows[0]["Lg_userip"].ToString();    //  本次登陆IP
                            lblLastLoginIp.Text = dt.Rows[1]["Lg_userip"].ToString();    //  上次登陆IP
                        }
                        else
                        {
                            lblNowLoginTime.Text = dt.Rows[0]["Lg_addtime"].ToString(); //  本次登陆时间
                            lblLastLoginTime.Text =  "首次登陆";
                            lblNowLoginIp.Text = dt.Rows[0]["Lg_userip"].ToString();    //  本次登陆IP
                            lblLastLoginIp.Text = "首次登陆";
                        }
                    }
                }
                else
                {
                    Response.Write("<script>top.location.href = '../Login.aspx' </script>");
                }
            }     
        }
    }
}