using System;
using LZManager.BLL.Common;
using LZManager.Common;
using LZManager.DAL;
using LZWebApp.BLL.Roulette;
using LZManager.BLL;
using System.Data;
using System.Web.UI.WebControls;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace LZManager.Users
{
    public partial class UserAdd : BasePage
    {
        UserManage userManage = new UserManage();
        RoleUserManage rluManage = new RoleUserManage();
        RoleManage rlManage = new RoleManage();

        protected void Page_Load(object sender, EventArgs e)
        {
            //GetAuthorityUrl(this.Page, "Users/UserAdd.aspx", 1);

            if (!IsPostBack)
            {
                this.LoadParentInfo();
                //this.BindcbAccountManagement();
                //this.BindDepartment();

                //if (Request.QueryString["State"] != null)
                //{
                //    //更新用户
                //    if (Request.QueryString["State"] == "U")
                //    {
                //        this.LoadUsers();
                //        this.LoadRoleUser();
                //    }
                //}
            }
        }

        /// <summary>
        /// 加载上级机构信息
        /// </summary>
        private void LoadParentInfo()
        {
            UsersEO usersEO = userManage.GetUser(GetUserID());
            if (usersEO != null)
            {
                this.txtParent.Text = usersEO.UrLoginName;
                this.txtZone.Text = usersEO.UrZone;
            }
        }

        /// <summary>
        /// 添加、修改数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOK_Click(object sender, EventArgs e)
        {

            if (Page.IsValid)
            {

                #region 验证表单合法性
                if (this.CheckForms() == false)
                {
                    CloseDivImplementation();
                    return;
                }

                #endregion

                //判断用户账号是否存在
                if (this.CheckUserLoginName()== false)
                {
                    ShowCommonDlg("账户名已存在！");
                    CloseDivImplementation();
                    return;
                }

                #region 初始化数据
                UsersEO usersEO = new UsersEO();
                RoleuserEO rluEO = new RoleuserEO();

                //if (Request.QueryString["State"] == "U")
                //{
                //    usersEO = userManage.GetUserByPK(Request.QueryString["Urid"]);
                //    if (cbk_password.Checked)
                //    {

                //    }
                //}

                usersEO.UrPass = MdUtil.ToMd5Hash(this.txtPass.Text.Trim());//密码MD5加密

                usersEO.UrLoginName = this.txtLoginName.Text.Trim();
                usersEO.UrName = this.txtName.Text.Trim();

                usersEO.UrParent = this.txtParent.Text.Trim();
                usersEO.UrPhone = "";//this.txtPhone.Text.Trim();
                usersEO.UrZone = this.txtZone.Text.Trim();
                usersEO.UrPeople = this.txtContactPeople.Text.Trim();
                usersEO.UrContact = this.txtContact.Text.Trim();
                usersEO.UrGameId = this.txtGameId.Text.Trim();
                usersEO.UrDiamondNum = "0";
                usersEO.UrBankName = "";//this.txtBankName.Text.Trim();
                usersEO.UrBank = "";//this.txtBank.Text.Trim();
                usersEO.UrPercent = "0";
                usersEO.UrBankNo = "";//this.txtBankNo.Text.Trim();
                usersEO.UrIntroducer = "";//this.txtIntrdouce.Text.Trim();
                usersEO.UrRolestate = "3";
                usersEO.UrDepartment = "3";
                usersEO.UrState = "0";
                usersEO.UrLockBindIp = "";
                usersEO.UrText1 = "0"; //  用户级别

                #endregion

                #region 创建用户
                //if (Request.QueryString["State"] == "A")
                {
                    //用户信息
                    usersEO.UrId = GetBigGuid();
                    usersEO.UrPass = MdUtil.ToMd5Hash(this.txtPass.Text.Trim());//密码MD5加密
                    usersEO.UrDel = "0";
                    usersEO.UrAddUser = GetUserID();
                    usersEO.UrAddTime = DateTime.Now;
                    usersEO.UrLockTime = DateTime.Now;
                    //用户角色信息            
                    //for (int i = 0; i < this.cblRoles.Items.Count; i++)
                    {
                        //if (this.cblRoles.Items[i].Selected)
                        {
                            rluEO.UrId = usersEO.UrId;
                            rluEO.RlId = "0468a29f20160413170700";//this.cblRoles.Items[i].Value;
                            rluEO.RuAddUser = GetUserID();
                            rluEO.RuAddTime = DateTime.Now;

                            rluManage.AddRoleUser(rluEO);
                        }
                    }

                    if (userManage.AddUser(usersEO) > 0)
                    {
                        //插入操作日志
                        InsertLog(Resources.Resource.Create_user, string.Format("username:{0},id:{1}", usersEO.UrName, usersEO.UrId), 4, GetPlatformIdByValue(1));
                        CloseDivImplementation();
                        Jswork.Alert("代理信息创建成功!","UsersAgentList.aspx"); //ShowCommonDlg("代理信息创建成功！");
                    }
                    else
                    {
                        //Jswork.Alert("用户信息创建失败", this.Page);
                        //this.divAlert.Visible = true;
                        //this.lblAlert.Text = Resources.Resource.User_information_creation_failed;//"用户信息创建失败";
                        ShowCommonDlg("代理信息创建失败！");
                    }
                }
                #endregion

                CloseDivImplementation();

            }


        }


        /// <summary>
        /// 验证用户账号是否存在
        /// </summary>
        /// <returns></returns>
        private bool CheckUserLoginName()
        {
            IList<MySqlParameter> parmC = new List<MySqlParameter>();
            StringBuilder strWhereC = new StringBuilder();
            strWhereC.Append("  Ur_loginName =@Ur_loginName AND Ur_del = 0 ");
            parmC.Add(new MySqlParameter("@Ur_loginName", this.txtLoginName.Text.Trim()));
            //if (userManage.GetTable(strWhereC.ToString(), parmC).Rows.Count > 0)
            if (userManage.GetTable(string.Format(" Ur_loginName = '{0}' AND Ur_del = 0", this.txtLoginName.Text.Trim()),null).Rows.Count > 0)
            {
                return false;//已存在
            }
            else
            {
                return true;//不存在
            }
        }

        /// <summary>
        /// 验证页面表单合理性
        /// </summary>
        /// <returns></returns>
        private bool CheckForms()
        {
            bool flg = true;
            string strAlert = string.Empty;

            if (string.IsNullOrEmpty(this.txtLoginName.Text.Trim()))
            {
                flg = false;
                //strAlert = Resources.Resource.Please_enter_a_user_account;// "";
                ShowCommonDlg("请输入用户账号！");
                this.txtLoginName.Focus();
            }
            else if (string.IsNullOrEmpty(this.txtPass.Text.Trim()) && this.trPass.Visible == true)
            {
                flg = false;
                //strAlert = Resources.Resource.Please_enter_a_user_password;// "请输入用户密码";
                ShowCommonDlg("请输入用户密码！");
                this.txtPass.Focus();
            }
            else if (string.IsNullOrEmpty(this.txtName.Text.Trim()))
            {
                flg = false;
                //strAlert = Resources.Resource.Please_enter_user_name;// "请输入用户姓名";
                ShowCommonDlg("请输入用户姓名！");
                this.txtName.Focus();
            }
            else if (string.IsNullOrEmpty(this.txtContactPeople.Text.Trim()))
            {
                flg = false;
                //strAlert = Resources.Resource.Please_enter_user_name;// "联系人";
                ShowCommonDlg("请输入联系人！");
                this.txtContactPeople.Focus();
            }
            else if (string.IsNullOrEmpty(this.txtContact.Text.Trim()))
            {
                flg = false;
                //strAlert = Resources.Resource.Please_enter_user_name;// "联系方式";
                ShowCommonDlg("请输入联系方式！");
                this.txtContact.Focus();
            }
            else if (string.IsNullOrEmpty(this.txtGameId.Text.Trim()))
            {
                flg = false;
                //strAlert = Resources.Resource.Please_enter_user_name;// "游戏ID";
                ShowCommonDlg("请输入游戏ID！");
                this.txtGameId.Focus();
            }
            //((?:(?:25[0-5]|2[0-4]\d|((1\d{2})|([1-9]?\d)))\.){3}(?:25[0-5]|2[0-4]\d|((1\d{2})|([1-9]?\d))));
            if (flg == true)
            {
                this.divAlert.Visible = false;
            }
            else
            {
                this.divAlert.Visible = true;
                this.lblAlert.Text = strAlert;
            }

            return flg;
        }

        /// <summary>
        /// 是否进行密码重置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void cbk_password_CheckedChanged(object sender, EventArgs e)
        {
            if (cbk_password.Checked)
            {
                trPass.Visible = true;
            }
            else
            {
                trPass.Visible = false;
            }
        }
    }
}