using System;
using LZManager.BLL.Common;
using LZManager.DAL;
using LZManager.BLL;
using LZWebApp.BLL.Roulette;
using System.Configuration;

namespace LZManager.Users
{
    public partial class UsersPasswordEdit : BasePage
    {
        UserManage userManage = new UserManage();
        //wndou.common.Encrypt MD5 = new wndou.common.Encrypt();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (GetUserID() == "")
            {
                Jswork.AlertAndRedirect("亲，请先登录！", ConfigurationManager.AppSettings["WebLoginURL"].ToString(), this.Page);
                return;
            }

            if (!IsPostBack)
            {
                this.LoadUser();
            }
        }

        /// <summary>
        /// 加载用户信息
        /// </summary>
        private void LoadUser()
        {
            UsersEO usersEO = new UsersEO();

            usersEO = userManage.GetUserByPK(GetUserID());
            if (!string.IsNullOrEmpty(usersEO.UrId))
            {
                this.lblUserName.Text = usersEO.UrName;
            }

        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOK_Click(object sender, EventArgs e)
        {
            UsersEO usersEO = new UsersEO();

            usersEO = userManage.GetUserByPK(GetUserID());

            if (usersEO.UrPass != MdUtil.ToMd5Hash(this.txtPass.Text.Trim()))
            {
                this.divAlert.Visible = true;
                this.lblAlert.Text = "当前密码不正确";
                CloseDivImplementation();
                return;
            }

            if (this.txtNewPass.Text.Trim() != this.txtRePass.Text.Trim())
            {
                this.divAlert.Visible = true;
                this.lblAlert.Text = "两次输入密码不一致";
                CloseDivImplementation();
                return;
            }

            usersEO.UrPass = MdUtil.ToMd5Hash(this.txtNewPass.Text.Trim());//密码MD5加密

            if (userManage.EditUser(usersEO) > 0)
            {
                //插入操作日志
                InsertLog("修改用户", string.Format("username:{0},id:{1}", usersEO.UrName, usersEO.UrId), 2, GetPlatformIdByValue(1));

                Jswork.Alert("用户密码修改成功", "UsersList.aspx");
            }
            else
            {
                //Jswork.Alert("用户信息修改失败", this.Page);
                this.divAlert.Visible = true;
                this.lblAlert.Text = "用户密码修改失败";
            }
            CloseDivImplementation();
        }
    }
}