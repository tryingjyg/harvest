using System;
using System.Web.UI.WebControls;
using LZManager.BLL.Common;
using LZManager.BLL;
using LZWebApp.BLL.Roulette;
using LZManager.DAL;
using System.Text;
using System.Data;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using ThoughtWorks.QRCode.Codec;
using System.Configuration;

namespace LZManager.Users
{
    public partial class UsersList : BasePage
    {
        UserManage userManage = new UserManage();
        RoleManage roleManage = new RoleManage();

        protected void Page_Load(object sender, EventArgs e)
        {
            GetAuthorityUrl(this.Page, "Users/UsersList.aspx", 0);

            if (GetUserLeave() >= 90)
            {
                btnAuthorityCopy.Visible = true;
            }
            else
            {
                btnAuthorityCopy.Visible = false;
            }
            if (!IsPostBack)
            {
                ViewState["SortOrder"] = "Ur_addTime";
                ViewState["OrderDire"] = "DESC";
                this.BindDepartment(); // 绑定部门
                BindRoleList(); // 绑定角色
                this.BindUsers();
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
            items.Text = Resources.Resource.alldepartment; //"所有部门";
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
        /// 绑定角色
        /// </summary>
        private void BindRoleList()
        {
            ddlRoleName.Items.Clear();
            ListItem items = new ListItem();
            items.Value = "";
            items.Text = Resources.Resource.All_roles; //"所有角色";
            ddlRoleName.Items.Add(items);
            DataTable dt = new DataTable();
            if (GetUserLeave() >= 90)
            {
                //dt = roleManage.GetTable("",null);
                dt = roleManage.GetTable(" Rl_del=0", null);
            }
            else
            {
                dt = userManage.GetRoleByUserId(GetUserID());
            }

            foreach (DataRow drRoleName in dt.Rows)
            {
                ListItem item = new ListItem();
                item.Value = drRoleName["Rl_id"].ToString();
                item.Text = drRoleName["Rl_name"].ToString();
                ddlRoleName.Items.Add(item);
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
            IList<MySqlParameter> parm = new List<MySqlParameter>();
            if (!string.IsNullOrEmpty(this.ddlRoleName.SelectedValue)) // 角色
            {
                strWhere.Append("( ");
            }

            strWhere.Append(" ( 1=1 ");
            if (!string.IsNullOrEmpty(this.txtLoginName.Text.Trim()))
            {
                strWhere.Append(string.Format(" And AUser.Ur_loginName like '%{0}%'", this.txtLoginName.Text.Trim()));
                //strWhere.Append("  And AUser.Ur_loginName like @Cnname");
                //parm.Add(new MySqlParameter("@Cnname", "%" + this.txtLoginName.Text.Trim() + "%"));
            }
            if (!string.IsNullOrEmpty(this.txtName.Text.Trim()))
            {
                strWhere.Append(string.Format(" And AUser.Ur_name like '%{0}%'", this.txtName.Text.Trim()));
                //strWhere.Append("  And AUser.Ur_name like @Nnname");
                //parm.Add(new MySqlParameter("@Nnname", "%" + this.txtName.Text.Trim() + "%"));
            }
            if (!string.IsNullOrEmpty(this.ddlDepartment.SelectedValue))
            {
                strWhere.Append(string.Format(" And AUser.Ur_department = '{0}' ", ddlDepartment.SelectedValue));
                //strWhere.Append("  And AUser.Ur_department= @Snname");
                //parm.Add(new MySqlParameter("@Snname", ddlDepartment.SelectedValue));
            }

            strWhere.Append(string.Format(" And AUser.Ur_state = '{0}'", this.rblState.SelectedValue));//0启用1停用2冻结 默认0
            //strWhere.Append("  And AUser.Ur_state = @RBnname");
            //parm.Add(new MySqlParameter("@RBnname", this.rblState.SelectedValue));

            if (leave < 200)
            {
                //strWhere.Append("  And cast(AUser.Ur_text1 as int ) <= @Bnname");
                //parm.Add(new MySqlParameter("@Bnname", Convert.ToInt32(usersEO.UrText1)));
                strWhere.Append(string.Format(" And cast(AUser.Ur_text1 as signed ) <= {0} ", Convert.ToInt32(usersEO.UrText1)));
            }

            if (leave < 90) // 根据用户账号管理权限显示归属内的账号
            {
                strWhere.Append(" And AUser.Ur_text2 like '%" + usersEO.UrId + ";%' ");
                //strWhere.Append("  And AUser.Ur_text2 like @URnname");
                //parm.Add(new MySqlParameter("@URnname", usersEO.UrId));
            }

            strWhere.Append(" And AUser.Ur_del = 0 ) ");

            //if (leave >= 80) // 显示自己的账号
            //{
            //    strWhere.Append(" or AUser.Ur_id = '" + usersEO.UrId + "' ");
            //    //strWhere.Append("   or AUser.Ur_id =  @URID");
            //    //parm.Add(new MySqlParameter("@URID", usersEO.UrId));
            //}

            if (!string.IsNullOrEmpty(this.ddlRoleName.SelectedValue)) // 角色
            {
                string levelStr = usersEO.UrText1;
                int levelAccount = 0;
                int.TryParse(levelStr, out levelAccount);
                if (levelAccount >= 100)
                {
                    strWhere.Append("  ) " + " and Arole.Rl_id = '" + this.ddlRoleName.SelectedValue + "' and  cast(AUser.Ur_text1 as signed ) <= 100 ");
                }
                else
                {
                    strWhere.Append("  ) " + " and Arole.Rl_id = '" + this.ddlRoleName.SelectedValue + "' and  cast(AUser.Ur_text1 as signed ) <= 90 ");
                }


                //strWhere.Append("   )  and ARole.Rl_id =  @RONAME and  cast(AUser.Ur_text1 as int ) <= 90");
                //parm.Add(new MySqlParameter("@RONAME", this.ddlRoleName.SelectedValue));
            }

            if (leave >= 80) // 显示自己的账号
            {
                strWhere.Append(" or AUser.Ur_id = '" + usersEO.UrId + "' ");
                //strWhere.Append("   or AUser.Ur_id =  @URID");
                //parm.Add(new MySqlParameter("@URID", usersEO.UrId));
            }
            DataView view = userManage.GetList(strWhere.ToString(), parm).DefaultView;
            string sort = (string)ViewState["SortOrder"] + " " + (string)ViewState["OrderDire"];

            view.Sort = sort;

            this.gvUsers.DataSource = view;
            this.gvUsers.DataBind();
        }

        private void BindUsers1()
        {
            UsersEO usersEO = GetUser(); // 获取登录用户的信息
            int leave = GetUserLeave(); //  获取用户级别

            StringBuilder strWhere = new StringBuilder();
            IList<MySqlParameter> parm = new List<MySqlParameter>();
            if (!string.IsNullOrEmpty(this.ddlRoleName.SelectedValue)) // 角色
            {
                strWhere.Append("( ");
            }

            strWhere.Append(" ( 1=1 ");
            if (!string.IsNullOrEmpty(this.txtLoginName.Text.Trim()))
            {
                //strWhere.Append(string.Format(" And AUser.Ur_loginName like '%{0}%'",this.txtLoginName.Text.Trim()));
                strWhere.Append("  And AUser.Ur_loginName like @Cnname");
                parm.Add(new MySqlParameter("@Cnname", "%" + this.txtLoginName.Text.Trim() + "%"));
            }
            if (!string.IsNullOrEmpty(this.txtName.Text.Trim()))
            {
                //strWhere.Append(string.Format(" And AUser.Ur_name like '%{0}%'", this.txtName.Text.Trim()));
                strWhere.Append("  And AUser.Ur_name like @Nnname");
                parm.Add(new MySqlParameter("@Nnname", "%" + this.txtName.Text.Trim() + "%"));
            }
            if (!string.IsNullOrEmpty(this.ddlDepartment.SelectedValue))
            {
                //strWhere.Append(string.Format(" And AUser.Ur_department = '{0}' ", ddlDepartment.SelectedValue));
                strWhere.Append("  And AUser.Ur_department= @Snname");
                parm.Add(new MySqlParameter("@Snname", ddlDepartment.SelectedValue));
            }

            //strWhere.Append(string.Format(" And AUser.Ur_state = '{0}'", this.rblState.SelectedValue));//0启用1停用2冻结 默认0
            strWhere.Append("  And AUser.Ur_state = @RBnname");
            parm.Add(new MySqlParameter("@RBnname", this.rblState.SelectedValue));

            if (leave < 200)
            {
                strWhere.Append("  And cast(AUser.Ur_text1 as signed ) <= @Bnname");
                parm.Add(new MySqlParameter("@Bnname", Convert.ToInt32(usersEO.UrText1)));
                //strWhere.Append(string.Format(" And cast(AUser.Ur_text1 as int ) <= {0} ", Convert.ToInt32(usersEO.UrText1)));
            }

            if (leave < 90) // 根据用户账号管理权限显示归属内的账号
            {
                //strWhere.Append(" And AUser.Ur_text2 like '%" + usersEO.UrId + ";%' ");
                strWhere.Append("  And AUser.Ur_text2 like @URnname");
                parm.Add(new MySqlParameter("@URnname", usersEO.UrId));
            }

            strWhere.Append(" And AUser.Ur_del = 0 ) ");

            if (leave >= 80) // 显示自己的账号
            {
                //strWhere.Append(" or AUser.Ur_id = '" + usersEO.UrId + "' ");
                strWhere.Append("   or AUser.Ur_id =  @URID");
                parm.Add(new MySqlParameter("@URID", usersEO.UrId));
            }

            if (!string.IsNullOrEmpty(this.ddlRoleName.SelectedValue)) // 角色
            {
                //strWhere.Append("  ) " + " and ARole.Rl_id = '" + this.ddlRoleName.SelectedValue + "' and  cast(AUser.Ur_text1 as int ) <= 90 ");
                strWhere.Append("   )  and 'ARole.Rl_id' =  @RONAME and  cast(AUser.Ur_text1 as signed ) <= 90");
                parm.Add(new MySqlParameter("@RONAME", this.ddlRoleName.SelectedValue));
            }


            DataView view = userManage.GetList(strWhere.ToString(), parm).DefaultView;
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

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("UsersEdit.aspx?State=A&Action=0");
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
                foreach (GridViewRow gvrow in gvUsers.Rows)
                {
                    CheckBox CheckBox = gvrow.FindControl("chbSelect") as CheckBox;
                    if (CheckBox.Checked)
                    {
                        strId = this.gvUsers.DataKeys[gvrow.RowIndex]["Ur_id"].ToString();
                    }
                }
                Response.Redirect(string.Format("UsersEdit.aspx?State=U&Urid={0}&Action=1", strId));
            }

            else if (this.SelectCount() == 0)
            {
                //Jswork.Alert("请选择一条记录进行修改", this.Page);

                this.divAlert.Visible = true;
                this.lblAlert.Text = Resources.Resource.tip_one_modify; //"请选择一条记录进行修改";
            }
            else
            {
                //Jswork.Alert("一次只能修改一条记录", this.Page);

                this.divAlert.Visible = true;
                this.lblAlert.Text = Resources.Resource.tip_only_modify; //"一次只能修改一条记录";
            }
        }

        /// <summary>
        /// 生成二维码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnQrCode_Click(object sender, EventArgs e)
        {
            //一次只能修改一条记录
            if (this.SelectCount() == 1)
            {
                string strId = string.Empty;
                foreach (GridViewRow gvrow in gvUsers.Rows)
                {
                    CheckBox CheckBox = gvrow.FindControl("chbSelect") as CheckBox;
                    if (CheckBox.Checked)
                    {
                        strId = this.gvUsers.DataKeys[gvrow.RowIndex]["Ur_gameId"].ToString();
                    }
                }
                string qrUrl = ConfigurationManager.AppSettings["QrCodeUrl"].ToString() + strId;
                string imgPath = CreateCode_Simple(qrUrl);

                //this.divAlert.Visible = true;
                //this.lblAlert.Text = imgPath; //"请选择一条记录进行修改";
                Response.Redirect(string.Format("QrCode.aspx?imgSrc=" + imgPath));
                //Response.Redirect(string.Format("UsersEdit.aspx?State=U&Urid={0}&Action=1", strId));
            }

            else if (this.SelectCount() == 0)
            {
                //Jswork.Alert("请选择一条记录进行修改", this.Page);

                this.divAlert.Visible = true;
                this.lblAlert.Text = Resources.Resource.tip_one_modify; //"请选择一条记录进行修改";
            }
            else
            {
                //Jswork.Alert("一次只能修改一条记录", this.Page);

                this.divAlert.Visible = true;
                this.lblAlert.Text = Resources.Resource.tip_only_modify; //"一次只能修改一条记录";
            }
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnDel_Click(object sender, EventArgs e)
        {
            String strUrids = string.Empty;
            String strNames = string.Empty;

            foreach (GridViewRow gvrow in gvUsers.Rows)
            {
                CheckBox CheckBox = gvrow.FindControl("chbSelect") as CheckBox;
                if (CheckBox.Checked)
                {
                    strUrids += this.gvUsers.DataKeys[gvrow.RowIndex]["Ur_id"].ToString() + "|";
                    strNames += this.gvUsers.DataKeys[gvrow.RowIndex]["Ur_name"].ToString() + ",";
                }
            }
            if (strUrids == "" && strUrids.Length == 0)
            {
                //Jswork.Alert("请至少选择一条记录进行删除", this.Page);

                this.divAlert.Visible = true;
                this.lblAlert.Text = Resources.Resource.tip_only_delete; //"请至少选择一条记录进行删除";

                return;
            }

            strUrids = strUrids.TrimEnd('|');

            UsersMO usersMO = new UsersMO();

            int iSuccess = 0;
            for (int i = 0; i < strUrids.Split('|').Length; i++)
            {
                StringBuilder strWhere = new StringBuilder();
                strWhere.Append(" 1=1");
                IList<MySqlParameter> parm = new List<MySqlParameter>();

                strWhere.Append(" and Ur_id =@Rl_id");
                parm.Add(new MySqlParameter("@Rl_id", strUrids.Split('|')[i]));
                if (userManage.DelUsers("Ur_del = 1", strWhere.ToString(), parm) > 0)
                //if (userManage.DelUsers("Ur_del = 1", string.Format(" Ur_id = '{0}'", strUrids.Split('|')[i])) > 0)
                {
                    //插入操作日志表
                    InsertLog("删除用户", string.Format("username:{0},id:{1}", strNames.Split(',')[i], strUrids.Split('|')[i]), 3, GetPlatformIdByValue(1));

                    iSuccess += 1;
                }
            }

            if (iSuccess > 0)
            {
                //Jswork.Alert("删除成功", this.Page);
                Jswork.Alert(Resources.Resource.tip_delete_success, this.Page);

                this.BindUsers();
            }
        }

        /// <summary>
        /// 按条件搜索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            BindUsers();

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
            this.txtLoginName.Text = string.Empty;
            this.txtName.Text = string.Empty;
            this.ddlDepartment.SelectedValue = string.Empty;
            this.rblState.SelectedValue = "0";
            this.ddlRoleName.SelectedValue = string.Empty;
            this.BindUsers();

            this.divAlert.Visible = false;
        }

        /// <summary>
        /// 数据绑定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvUsers_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowIndex > -1)
            {
                //if (e.Row.Cells[6].Text == "0")
                //{
                //    e.Row.Cells[6].Text = Resources.Resource.On;//"启用";
                //}
                //else if (e.Row.Cells[6].Text == "1")
                //{
                //    e.Row.Cells[6].Text = Resources.Resource.Off; //"停用";
                //}
                //else if (e.Row.Cells[6].Text == "2")
                //{
                //    e.Row.Cells[6].Text = "冻结";
                //}
                //else
                //{
                //    e.Row.Cells[6].Text = "未知";
                //}

                if (e.Row.Cells[16].Text == "0")
                {
                    e.Row.Cells[16].Text = "管理员";
                }
                //else if (e.Row.Cells[16].Text == "1")
                //{
                //    e.Row.Cells[16].Text = "机构代理";
                //}
                //else if (e.Row.Cells[16].Text == "2")
                //{
                //    e.Row.Cells[16].Text = "代理";
                //}
                //else
                //{
                //    e.Row.Cells[16].Text = "错误";
                //}

            }
        }

        /// <summary>
        /// 字段排序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// 返回GridView中CheckBox选择了几个
        /// </summary>
        /// <returns></returns>
        private int SelectCount()
        {
            int iSelectCount = 0;
            for (int i = 0; i <= gvUsers.Rows.Count - 1; i++)
            {
                CheckBox CheckBox = (CheckBox)gvUsers.Rows[i].FindControl("chbSelect");
                if (CheckBox.Checked == true)
                {
                    iSelectCount += 1;
                }
            }

            return iSelectCount;
        }

        protected void gvUsers_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.gvUsers.PageIndex = e.NewPageIndex;
            this.BindUsers();
        }

        /// <summary>
        /// 根据ID查询所属级别名称
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetUserLeaveNameById(object id)
        {
            string leavename = "未知";
            List<string[]> list = GetUserLeaveByString();
            try
            {
                foreach (string[] nums in list)
                {
                    if (nums[1].Trim().ToString() == id.ToString().Trim())
                    {
                        leavename = nums[0].Trim().ToString();
                    }
                }
            }
            catch { leavename = "异常"; }
            return leavename;
        }


        /// <summary>
        /// 根据用户ID 获取角色字符串
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public string GetRoleList(object userid)
        {
            string Platformid = "";
            string result = "";
            DataTable dt = userManage.GetRoleByUserId(userid.ToString());
            int a = 0;
            foreach (DataRow dr in dt.Rows)
            {
                if (a == 2)
                {
                    result += "<br />";
                    a = 0;
                }
                else if (dr["Pf_id"].ToString() != Platformid && Platformid != "")
                {
                    result += "<br />";
                    a = 0;
                }

                result += dr["Rl_name"].ToString() + ",";
                a++;

                Platformid = dr["Pf_id"].ToString();

            }
            return result;
        }

        /// <summary>
        /// 权限复制或转移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnAuthorityCopy_Click(object sender, EventArgs e)
        {
            //一次只能修改一条记录
            if (this.SelectCount() == 1)
            {
                string strId = string.Empty;
                foreach (GridViewRow gvrow in gvUsers.Rows)
                {
                    CheckBox CheckBox = gvrow.FindControl("chbSelect") as CheckBox;
                    if (CheckBox.Checked)
                    {
                        strId = this.gvUsers.DataKeys[gvrow.RowIndex]["Ur_id"].ToString();
                    }
                }
                Response.Redirect(string.Format("AuthorityCopy.aspx?State=U&Urid={0}&Action=1", strId));
            }

            else if (this.SelectCount() == 0)
            {
                //Jswork.Alert("请选择一条记录进行修改", this.Page);

                this.divAlert.Visible = true;
                this.lblAlert.Text = Resources.Resource.tip_one_modify; //"请选择一条记录进行修改";
            }
            else
            {
                //Jswork.Alert("一次只能修改一条记录", this.Page);

                this.divAlert.Visible = true;
                this.lblAlert.Text = Resources.Resource.tip_only_modify; //"一次只能修改一条记录";
            }
        }

        private string CreateCode_Simple(string nr)
        {
            QRCodeEncoder qrCodeEncoder = new QRCodeEncoder();
            qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
            qrCodeEncoder.QRCodeScale = 4;
            qrCodeEncoder.QRCodeVersion = 8;
            qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M;
            //System.Drawing.Image image = qrCodeEncoder.Encode("4408810820 深圳－广州 小江");
            System.Drawing.Image image = qrCodeEncoder.Encode(nr);
            string filename = DateTime.Now.ToString("yyyymmddhhmmssfff").ToString() + ".jpg";
            string filepath = Server.MapPath(@"~\Images\img") + "\\" + filename;
            System.IO.FileStream fs = new System.IO.FileStream(filepath, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Write);
            image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);

            fs.Close();
            image.Dispose();
            return filepath;
            //二维码解码
            //var codeDecoder = CodeDecoder(filepath);
        }
    }
}