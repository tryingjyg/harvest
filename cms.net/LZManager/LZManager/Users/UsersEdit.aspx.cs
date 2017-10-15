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
    public partial class UsersEdit : BasePage
    {
        UserManage userManage = new UserManage();
        RoleUserManage rluManage = new RoleUserManage();
        RoleManage rlManage = new RoleManage();       

        protected void Page_Load(object sender, EventArgs e)
        {
            GetAuthorityUrl(this.Page, "Users/UsersList.aspx", 1);

            if (!IsPostBack)
            {
                this.LoadRoles();
                this.BindcbAccountManagement();
                this.BindDepartment();

                if (Request.QueryString["State"] != null)
                {
                    //更新用户
                    if (Request.QueryString["State"] == "U")
                    {
                        this.LoadUsers();
                        this.LoadRoleUser();
                    }
                }
            }
        }

        /// <summary>
        /// 绑定部门
        /// </summary>
        private void BindDepartment()
        {
            ddlDepartment.Items.Clear();
            ListItem items = new ListItem();
            items.Value = "";
            items.Text = "请选择部门";//
            items.Text = Resources.Resource.Please_select_Department;

            ddlDepartment.Items.Add(items);

            foreach (string departmentName in GetDepartment())
            {
                ListItem item = new ListItem();
                item.Value = departmentName;
                item.Text = departmentName;
                ddlDepartment.Items.Add(item);
            }
        }

        /// <summary>
        /// 绑定用户级别
        /// </summary>
        private void BindddlUserLeave(int userleave)
        {
            //ddlUserLeave.Items.Clear();
            //foreach (string[] sleave in GetUserLeaveByString())
            //{
            //    ListItem item = new ListItem();
            //    item.Text = sleave[0].ToString();
            //    item.Value = sleave[1].ToString();
            //    if (userleave >= 200) //  超超级管理员权限
            //    {
            //        ddlUserLeave.Items.Add(item);
            //    }
            //    else if (userleave >= 90 && userleave < 200)
            //    {
            //        if (userleave >= Convert.ToInt32(sleave[1].ToString()))
            //        {
            //            ddlUserLeave.Items.Add(item);
            //        }
            //    }
            //    else
            //    {
            //        if (userleave > Convert.ToInt32(sleave[1].ToString()))
            //        {
            //            ddlUserLeave.Items.Add(item);
            //        }
            //    }
            //}
        }

        /// <summary>
        /// 绑定账号管理归属
        /// </summary>
        private void BindcbAccountManagement()
        {
            try
            {
                cbAccountManagement.DataSource = userManage.Get(" cast(Ur_text1 as signed) = 80 and Ur_state = 0 and  Ur_del = 0 ");
                cbAccountManagement.DataTextField = "Urname";
                cbAccountManagement.DataValueField = "Urid";
                cbAccountManagement.DataBind();
            }
            catch
            { }
        }

        /// <summary>
        /// 加载角色信息
        /// </summary>
        private void LoadRoles()
        {
            UsersEO userEO = GetUser();
            int leave = GetUserLeave(); // 获取用户等级
            // 根据级别绑定用户可选的级别信息
            BindddlUserLeave(leave); 
            
            // 判断开发管理员以上的用户可以对任何用户进行编辑
            if (leave >= 90)
            {
                this.cblRoles.DataSource = rlManage.Get(" Rl_del = 0",null);
            }
            else
            {
                IList<MySqlParameter> parm = new List<MySqlParameter>();
                StringBuilder strWhere = new StringBuilder();
                strWhere.Append("   Rl_id in ( select Rl_id from  roleuser where Ur_id =@Ur_id )  and Rl_del = 0 and Rl_name <> @UserEditName ");
                parm.Add(new MySqlParameter("@Ur_id", GetUserID()));
                parm.Add(new MySqlParameter("@UserEditName", ConfigurationManager.AppSettings["UserEditName"].ToString()));
                this.cblRoles.DataSource = rlManage.Get(strWhere.ToString(),parm);
                //this.cblRoles.DataSource = rlManage.Get(" Rl_id in ( select Rl_id from  roleuser where Ur_id = '" + GetUserID() + "')  and Rl_del = 0 and Rl_name <> '" + ConfigurationManager.AppSettings["UserEditName"].ToString() + "' ");
                // 根据用户级别判断该用户是否有用户账号管理的权限
                cbAccountManagement.Enabled = false;
                cbAccountManagement.SelectedValue = userEO.UrId;
            }
            this.cblRoles.DataTextField = "Rlname";
            this.cblRoles.DataValueField = "RlId";
            this.cblRoles.DataBind();

            if (this.cblRoles.Items.Count == 0)
            {
                this.lkRoleEdit.Visible = true;
            }
        }

        /// <summary>
        /// 加载用户信息
        /// </summary>
        private void LoadUsers()
        {
            UsersEO usersEO = new UsersEO();
            int leave = GetUserLeave(); // 获取用户级别
            usersEO = userManage.GetUserByPK(Request.QueryString["Urid"]);
            if (!string.IsNullOrEmpty(usersEO.UrId))
            {
                this.txtLoginName.Text = usersEO.UrLoginName;
                this.hfLoginName.Value = usersEO.UrLoginName;
                this.txtName.Text = usersEO.UrName;
                this.txtParent.Text = usersEO.UrParent;
                this.txtPhone.Text = usersEO.UrPhone;
                this.txtZone.Text = usersEO.UrZone;
                this.txtContactPeople.Text = usersEO.UrPeople;
                this.txtContact.Text = usersEO.UrContact;
                this.txtGameId.Text = usersEO.UrGameId;
                this.txtDiamondNum.Text = usersEO.UrDiamondNum;
                this.txtBankName.Text = usersEO.UrBankName;
                this.txtBank.Text = usersEO.UrBank;
                this.txtPercent.Text = usersEO.UrPercent;
                this.txtBankNo.Text = usersEO.UrBankNo;
                this.txtIntrdouce.Text = usersEO.UrIntroducer;
                this.ddlDepartment.SelectedValue = usersEO.UrDepartment;
                this.rblState.SelectedValue = usersEO.UrState;
                this.txtUserIps.Text = usersEO.UrLockBindIp;
            }

            this.trPass.Visible = false;

            if (leave >= 90)
            {
                this.cbk_password.Visible = true;
            }

            // 加载用户账号归属
            if (usersEO.UrText2 != null)
            {
                foreach (string AccountManagementmessage in usersEO.UrText2.Split(';'))
                {
                    if (AccountManagementmessage != "")
                    {
                        for (int i = 0; i < this.cbAccountManagement.Items.Count; i++)
                        {
                            if (this.cbAccountManagement.Items[i].Value == AccountManagementmessage)
                            {
                                this.cbAccountManagement.Items[i].Selected = true;
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 加载用户角色信息
        /// </summary>
        private void LoadRoleUser()
        {
            IList<MySqlParameter> parm = new List<MySqlParameter>();
            StringBuilder strWhere = new StringBuilder();
            strWhere.Append("  Ur_id= @Rl_name ");
            parm.Add(new MySqlParameter("@Rl_name", Request.QueryString["Urid"]));
            DataTable dt = rluManage.GetTable(strWhere.ToString(),parm);

            UsersEO userEO = userManage.GetUser(Request.QueryString["Urid"]);
            try
            {
                ddlUserLeave.SelectedValue = userEO.UrText1;
            }
            catch { }

            if (dt != null && dt.Rows.Count > 0)
            {
                for (int i = 0; i < this.cblRoles.Items.Count; i++)
                {
                    for (int j = 0; j < dt.Rows.Count; j++)
                    {
                        if (this.cblRoles.Items[i].Value == dt.Rows[j]["Rl_id"].ToString())
                        {
                            this.cblRoles.Items[i].Selected = true;
                        }
                    }
                }
            }

            SetRoleListColor();
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

                #region 初始化数据
                UsersEO usersEO = new UsersEO();
                RoleuserEO rluEO = new RoleuserEO();

                if (Request.QueryString["State"] == "U")
                {
                    usersEO = userManage.GetUserByPK(Request.QueryString["Urid"]);
                    if (cbk_password.Checked)
                    {
                        usersEO.UrPass = MdUtil.ToMd5Hash(this.txtPass.Text.Trim());//密码MD5加密
                    }
                }


                usersEO.UrLoginName = this.txtLoginName.Text.Trim();
                usersEO.UrName = this.txtName.Text.Trim();

                usersEO.UrParent = this.txtParent.Text.Trim();
                usersEO.UrPhone = this.txtPhone.Text.Trim();
                usersEO.UrZone = this.txtZone.Text.Trim();
                usersEO.UrPeople = this.txtContactPeople.Text.Trim();
                usersEO.UrContact = this.txtContact.Text.Trim();
                usersEO.UrGameId = this.txtGameId.Text.Trim();
                usersEO.UrDiamondNum = this.txtDiamondNum.Text.Trim();
                usersEO.UrBankName = this.txtBankName.Text.Trim();
                usersEO.UrBank = this.txtBank.Text.Trim();
                usersEO.UrPercent = this.txtPercent.Text.Trim();
                usersEO.UrBankNo = this.txtBankNo.Text.Trim();
                usersEO.UrIntroducer = this.txtIntrdouce.Text.Trim();
                usersEO.UrName = this.txtName.Text.Trim();
                usersEO.UrName = this.txtName.Text.Trim();
                usersEO.UrRolestate = this.ddlDepartment.SelectedValue;
                usersEO.UrDepartment = this.ddlDepartment.SelectedValue;
                usersEO.UrState = this.rblState.SelectedValue;
                usersEO.UrLockBindIp = this.txtUserIps.Text.ToString().Trim();
                usersEO.UrText1 = this.ddlUserLeave.Text.ToString().Trim(); //  用户级别


                #endregion

                #region 设置用户账号归属管理

                //用户角色信息  
                int itemCount = 0; // 选择的数量
                string strAccountManagement = "";
                for (int i = 0; i < this.cbAccountManagement.Items.Count; i++)
                {
                    if (this.cbAccountManagement.Items[i].Selected)
                    {
                        strAccountManagement += this.cbAccountManagement.Items[i].Value;
                        strAccountManagement += ";";
                        itemCount++;
                    }
                }
                usersEO.UrText2 = strAccountManagement;

                if (itemCount > 5)
                {
                    this.divAlert.Visible = true;
                    this.lblAlert.Text = "账号管理归属最多选择4个人";
                    CloseDivImplementation();
                    return;
                }
                #endregion

                #region 创建用户
                if (Request.QueryString["State"] == "A")
                {
                    //判断用户账号是否存在
                    if (this.CheckUserLoginName() == false)
                    {
                        //Jswork.Alert("用户账号【" + this.txtLoginName.Text.Trim() + "】已存在", this.Page);

                        this.divAlert.Visible = true;
                        this.lblAlert.Text = Resources.Resource.User_account1 + this.txtLoginName.Text.Trim() + Resources.Resource.Already_exist;
                        CloseDivImplementation();
                        return;
                    }

                    //用户信息
                    usersEO.UrId = GetBigGuid();
                    usersEO.UrPass = MdUtil.ToMd5Hash(this.txtPass.Text.Trim());//密码MD5加密
                    usersEO.UrDel = "0";
                    usersEO.UrAddUser = GetUserID();
                    usersEO.UrAddTime = DateTime.Now;
                    usersEO.UrLockTime = DateTime.Now;
                    //用户角色信息            
                    for (int i = 0; i < this.cblRoles.Items.Count; i++)
                    {
                        if (this.cblRoles.Items[i].Selected)
                        {
                            rluEO.UrId = usersEO.UrId;
                            rluEO.RlId = this.cblRoles.Items[i].Value;
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
                        Jswork.Alert(Resources.Resource.User_information_creation_success, "UsersList.aspx");
                    }
                    else
                    {
                        //Jswork.Alert("用户信息创建失败", this.Page);
                        this.divAlert.Visible = true;
                        this.lblAlert.Text = Resources.Resource.User_information_creation_failed;//"用户信息创建失败";
                    }
                }
                #endregion

                #region 修改用户
                if (Request.QueryString["State"] == "U")
                {
                    //修改时判断账号是否存在
                    if (hfLoginName.Value != this.txtLoginName.Text.Trim())
                    {
                        //判断用户账号是否存在
                        if (this.CheckUserLoginName() == false)
                        {
                            //Jswork.Alert("用户账号【" + this.txtLoginName.Text.Trim() + "】已存在", this.Page);

                            this.divAlert.Visible = true;
                            //this.lblAlert.Text = "用户账号【" + this.txtLoginName.Text.Trim() + "】已存在";
                            this.lblAlert.Text = Resources.Resource.User_account1 + this.txtLoginName.Text.Trim() + Resources.Resource.Already_exist;
                            CloseDivImplementation();
                            return;
                        }
                    }

                    //用户角色信息     
                    rluManage.RemoveByPK(Request.QueryString["Urid"]); //插入用户角色关系表数据前先删除数据
                    for (int i = 0; i < this.cblRoles.Items.Count; i++)
                    {
                        if (this.cblRoles.Items[i].Selected)
                        {
                            rluEO.UrId = usersEO.UrId;
                            rluEO.RlId = this.cblRoles.Items[i].Value;
                            rluEO.RuAddUser = GetUserID();
                            rluEO.RuAddTime = DateTime.Now;

                            rluManage.AddRoleUser(rluEO);
                        }
                    }

                    if (userManage.EditUser(usersEO) > 0)
                    {
                        if (usersEO.UrState == "0") // 启用状态
                        {
                            UserUnFreeZing(usersEO.UrId, DateTime.Now.AddMonths(-1));
                        }
                        //插入操作日志
                        InsertLog(Resources.Resource.Modify_user, string.Format("username:{0},id:{1}", usersEO.UrName, usersEO.UrId), 2, GetPlatformIdByValue(1));
                        CloseDivImplementation();
                        Jswork.Alert(Resources.Resource.Success_of_user_information_modification, "UsersList.aspx");
                    }
                    else
                    {
                        //Jswork.Alert("用户信息修改失败", this.Page);
                        this.divAlert.Visible = true;
                        this.lblAlert.Text = Resources.Resource.User_information_modification_failed;//"用户信息修改失败";
                    }
                }
                #endregion

                CloseDivImplementation();
                
            }

          
        }

        /// <summary>
        /// 返回
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("UsersList.aspx");
        }

        /// <summary>
        /// 跳转到创建角色信息页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lbRoleEdit_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Role/RoleEdit.aspx?State=A");
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
            if (userManage.GetTable(strWhereC.ToString(),parmC).Rows.Count > 0)
            //if (userManage.GetTable(string.Format(" Ur_loginName = '{0}' AND Ur_del = 0", this.txtLoginName.Text.Trim())).Rows.Count > 0)
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
                strAlert = Resources.Resource.Please_enter_a_user_account;// "请输入用户账号";
                this.txtLoginName.Focus();
            }
            else if (string.IsNullOrEmpty(this.txtPass.Text.Trim()) && this.trPass.Visible == true)
            {
                flg = false;
                strAlert = Resources.Resource.Please_enter_a_user_password;// "请输入用户密码";
                this.txtPass.Focus();
            }
            else if (string.IsNullOrEmpty(this.txtName.Text.Trim()))
            {
                flg = false;
                strAlert = Resources.Resource.Please_enter_user_name;// "请输入用户姓名";
                this.txtName.Focus();
            }
            else if (string.IsNullOrEmpty(this.ddlDepartment.SelectedValue))
            {
                flg = false;
                strAlert = Resources.Resource.Please_select_user_department;//"请选择用户部门";
                this.ddlDepartment.Focus();
            }
            else if (string.IsNullOrEmpty(this.cblRoles.SelectedValue))
            {
                flg = false;
                strAlert = Resources.Resource.Please_select_a_character_name;// "请选择角色名";
            }
            //((?:(?:25[0-5]|2[0-4]\d|((1\d{2})|([1-9]?\d)))\.){3}(?:25[0-5]|2[0-4]\d|((1\d{2})|([1-9]?\d))));

            if (!string.IsNullOrEmpty(txtUserIps.Text.Trim()))
            {
                #region 进行校验
                string[] sArray = this.txtUserIps.Text.Split(',');
                foreach (string s in sArray)
                {

                    int resultIp = PubFuncs.ValidateIp(s);

                    if (resultIp != 0)
                    {
                        flg = false;
                        strAlert = string.Format("Error IP{0} value", s);// "ip格式";
                    }
                }
                #endregion
               
            }
          
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

        /// <summary>
        /// 设置选择的颜色
        /// </summary>
        private void SetRoleListColor()
        {
            for (int i = 0; i < this.cblRoles.Items.Count; i++)
            {
                if (this.cblRoles.Items[i].Selected == true)
                {
                    this.cblRoles.Items[i].Text = this.cblRoles.Items[i].Text.IndexOf("font") == -1 ? "<font color='Blue'>" + this.cblRoles.Items[i].Text + "</font>" : this.cblRoles.Items[i].Text.Replace("Black", "Blue");
                }
                else
                {
                    this.cblRoles.Items[i].Text = this.cblRoles.Items[i].Text.IndexOf("font") == -1 ? "<font color='Black'>" + this.cblRoles.Items[i].Text + "</font>" : this.cblRoles.Items[i].Text.Replace("Blue", "Black");
                }
            }
        }
    }
}