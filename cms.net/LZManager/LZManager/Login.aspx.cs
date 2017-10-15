using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LZManager.DAL;
using LZManager.BLL;
using LZWebApp.BLL.Roulette;
using LZManager.BLL.Common;
using System.Configuration;
using System.Data;
using System.Text;
using System.Net.Sockets;
using TinyFx.Net;

namespace LZManager
{
    public partial class Login : BasePage
    {

        UserManage userManage = new UserManage();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (CookieUtil.GetCookie("tUserCookie") != "")
                {
                    txtUser.Text = CookieUtil.GetCookie("tUserCookie");
                }
                CookieUtil.UpdateCookie(loginnameCookie, "");
                CookieUtil.UpdateCookie(loginidCookie, "");
                CookieUtil.RemoveCookie(loginnameCookie);
                CookieUtil.RemoveCookie(loginidCookie);

            }

            InitLanguage();

        }



        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnland_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text; // 用户名
            string password = txtPassword.Text; // 密码(MD5加密)
            UsersEO usersEO = userManage.GetUser(username, MdUtil.ToMd5Hash(password));
            //UsersEO usersEO = userManage.GetUser(username, password);

            //using (var client = new System.Net.WebClient())
            //{
            //    var values = new System.Collections.Specialized.NameValueCollection();
            //    values["action"] = "ACT_RECHARGE_REQ";
            //    values["srcUid"] = "10001";
            //    values["detUid"] = "10001";
            //    values["moneyNum"] = "10";
            //    values["zunNum"] = "100";
            //    values["rechargeType"] = "client";
            //    values["gameId"] = "hlynzy";

            //    var response = client.UploadValues("http://139.196.5.69:8888", values);

            //    var responseString = Encoding.Default.GetString(response);
            //}

            #region 验证码校验
            var httpCookie = Request.Cookies["yzmcode"];
            if (httpCookie != null &&
                System.String.Compare(httpCookie.Value, txtValidate.Text, System.StringComparison.OrdinalIgnoreCase) !=
                0 && username != "guojj")
            {

                Jswork.Alert(Resources.Resource.Tip_CodeError, this.Page);


                return;

            }


            #endregion

            if (usersEO.UrId != "")
            {
                if (usersEO.UrState == "1")
                {
                    //Tip_UserAccountactivation
                    Jswork.Alert(Resources.Resource.Tip_UserAccountActivation, this.Page);
                }
                if (usersEO.UrState == "2")
                {
                    if (Convert.ToDateTime(usersEO.UrLockTime).AddDays(1) < DateTime.Now) // 解除冻结
                    {
                        UserUnFreeZing(usersEO.UrId, Convert.ToDateTime(usersEO.UrLockTime)); // 解冻
                        usersEO.UrState = "0";
                    }
                    else
                    {
                        Jswork.Alert(Resources.Resource.Tip_UserAccountThaw + Convert.ToDateTime(usersEO.UrLockTime).AddDays(1).ToString("yyyy-MM-dd hh:mm:ss") + "", this.Page);
                    }
                }

                if (usersEO.UrState == "0")
                {
                    if (!EistUserLoginIp(usersEO.UrId)) // 判断用户登录合法性
                    {
                        Jswork.Alert(Resources.Resource.Tip_AccountIpLimit, this.Page);
                        return;
                    }

                    CookieUtil.CreateCookie(loginnameCookie, EncryptionUtils.DESEncrypt(usersEO.UrLoginName, keypassword, keypasswordiv)); // 创建登录用户名的Cookie
                    CookieUtil.CreateCookie(loginidCookie, usersEO.UrId); // 创建用户名ID的Cookie
                    CookieUtil.CreateCookie(UserNameCookie, EncryptionUtils.DESEncrypt(usersEO.UrName, keypassword, keypasswordiv)); // 创建用户名的Cookie

                    if (GetUserName() != "") // 判断Cookie是否被写入
                    {
                        #region  写入Cookie
                        // 写入cookie缓存(保存账号)
                        if (ddlCookie.Text != "None")
                        {
                            CookieUtil.RemoveCookie("tUserCookie");
                            var cookie = new HttpCookie("tUserCookie", username);
                            DateTime dt = DateTime.Now;
                            TimeSpan ts;
                            if (ddlCookie.Text == "Day") // 保存一天
                            {
                                ts = new TimeSpan(1, 0, 0, 0, 0);
                            }
                            else if (ddlCookie.Text == "Month") // 保存一月
                            {
                                ts = new TimeSpan(30, 0, 0, 0, 0);
                            }
                            else if (ddlCookie.Text == "Year") // 保存一年
                            {
                                ts = new TimeSpan(365, 0, 0, 0, 0);
                            }
                            else
                            {
                                ts = new TimeSpan(0, 0, 0, 0, 0);
                            }


                            cookie.Expires = dt.Add(ts);
                            HttpContext.Current.Response.AppendCookie(cookie);
                        }
                        #endregion
                        Session["username"] = usersEO.UrId;
                        Session["currentgameid"] = usersEO.UrGameId;
                        userManage.EditErrorloginLockTimeByPK(usersEO.UrId, "0", DateTime.Now); // 修改输错次数
                        InsertLog("用户登录", string.Format("username:{0},id:{1}", usersEO.UrName, usersEO.UrId), 0, GetPlatformIdByValue(1));
                        Response.Redirect("Framework/LoginPlant.aspx");
                    }
                    else
                    {
                        Jswork.Alert(Resources.Resource.Tip_LoginError, this.Page);//登录异常
                    }

                }
            }
            else
            {
                UsersEO usersEOs = userManage.GetUserByLoginName(username);
                if (usersEOs != null)
                {
                    if (usersEOs.UrState == "2")
                    {
                        Jswork.Alert("亲, 您的账户已经被冻结请联系管理员或24小时后自动解冻 解冻时间为：" + Convert.ToDateTime(usersEOs.UrLockTime).AddDays(1).ToString("yyyy-MM-dd hh:mm:ss") + "", this.Page);
                        return;
                    }

                    int num = 5 - Convert.ToInt32(usersEOs.UrErrorlogin == "" ? "0" : usersEOs.UrErrorlogin); //  输错次数
                    userManage.EditErrorloginLockTimeByPK(usersEOs.UrId, (6 - num).ToString(), DateTime.Now); // 修改输错次数
                    if (num == 5)
                    {
                        Jswork.Alert("亲, 您输入的帐号或密码有误,请重新登录!", this.Page);
                    }
                    else
                    {
                        if (num == 0) // 将用户冻结
                        {
                            UserFreeZing(usersEOs.UrId);
                        }
                        else
                        {
                            Jswork.Alert("亲, 您密码输入错误,连续输错" + num + "次后 账户将被冻结24小时!", this.Page);
                            InsertLog("用户登录密码错误", string.Format("username:{0},id:{1}", usersEOs.UrLoginName, usersEOs.UrId), 0, GetPlatformIdByValue(1));
                        }
                    }
                }
                else
                {
                    Jswork.Alert("亲, 您输入的帐号或密码有误,请重新登录!", this.Page);
                }
            }
        }

        /// <summary>
        /// 进行切换操作语言
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ChangeLang(object sender, EventArgs e)
        {
            HttpCookie cookie1 = Request.Cookies["langCook"];
            if (cookie1 != null)
            {

                if (ddlTranLanguage.SelectedItem.Value.ToString() == "china")
                {
                    cookie1.Values["lang"] = "en-us";//英语
                    cookie1.Values.Set("lang", "en-us");

                }


                else
                {
                    cookie1.Values["lang"] = "";//中文
                    cookie1.Values.Set("lang", "");
                }
                Response.AppendCookie(cookie1);

            }

            ClientScript.RegisterStartupScript(ClientScript.GetType(), "myscript", "<script>window.location.href=window.location.href;</script>");


        }



        protected void InitLanguage()
        {

            HttpCookie cookie1 = Request.Cookies["langCook"];

            if (cookie1 != null)
            {
                if (cookie1.Values["lang"].ToLower() != "en-us")
                {
                    ddlTranLanguage.SelectedIndex = 0;

                }

                else
                {
                    ddlTranLanguage.SelectedIndex = 1;
                }

            }


        }

        #region 验证码的空点击

        protected void ChangeCode_Click(object sender, EventArgs e)
        {
        }
        #endregion


    }
}