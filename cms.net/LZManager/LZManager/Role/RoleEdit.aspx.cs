using System;
using LZManager.BLL.Common;
using LZManager.DAL;
using LZWebApp.BLL.Roulette;
using LZManager.BLL;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Text;
using System.Collections.Generic;

namespace LZManager.Role
{
    public partial class RoleEdit : BasePage
    {
        RoleManage roleManage = new RoleManage();
        GameMO _mo = new GameMO();
        RolegameMO _rgmo = new RolegameMO();

        protected void Page_Load(object sender, EventArgs e)
        {
            GetAuthorityUrl(this.Page, "Role/RoleList.aspx",1);

            if (!IsPostBack)
            {
                this.LoadPlatform();
                BindcbkGame();
                if (Request.QueryString["State"] != null)
                {
                    //更新角色
                    if (Request.QueryString["State"] == "U")
                    {
                        this.LoadRole();
                        LoadGameChannel();
                    }
                }
            }
        }

        /// <summary>
        /// 绑定所属游戏列表
        /// </summary>
        private void BindcbkGame()
        {
            foreach (GameEO _eo in _mo.GetTopSortByChannel(" a.Gm_del = 0 and a.Gm_state = 0 ", null, -1, " Gm_name desc ", null))
            {
                ListItem item = new ListItem();
                item.Text = _eo.GmName + "(" + _eo.CnChannelId + ")";
                item.Value = _eo.GmId;
                cblGame.Items.Add(item);
            }
        }

        /// <summary>
        /// 加载角色信息
        /// </summary>
        private void LoadRole()
        {
            RoleEO roleEO = new RoleEO();

            roleEO = roleManage.GetRoleByPK(Request.QueryString["Rlid"]);
            if (!string.IsNullOrEmpty(roleEO.RlName))
            {
                this.txtRlName.Text = roleEO.RlName;
                this.hfRoleName.Value = roleEO.RlName;
                this.ddlPf.SelectedValue = roleEO.PfId;
                this.rblState.SelectedValue = roleEO.RlState;
            }
        }
        /// <summary>
        /// 加载游戏渠道
        /// </summary>
        private void LoadGameChannel()
        {
            foreach (RolegameEO _rgeo in _rgmo.Get(" Rl_id = @Rl_id ", Request.QueryString["Rlid"]))
            {
                for (int i = 0; i < cblGame.Items.Count; i++) //  循环选中渠道的值
                {
                    if (_rgeo.GmId == cblGame.Items[i].Value) // 选中
                    {
                        cblGame.Items[i].Selected =true;
                    }
                }
            }
        }
        /// <summary>
        /// 加载平台列表
        /// </summary>
        private void LoadPlatform()
        {
            PlatformManage PfManage = new PlatformManage();
            //this.ddlPf.DataSource = PfManage.Get(" Pf_del = 0 AND Pf_text1 > 0  ORDER BY Pf_text1");
            this.ddlPf.DataSource = PfManage.Get(" Pf_del = 0 ORDER BY Pf_sort asc");

          
            this.ddlPf.DataTextField = "Pfname";
            this.ddlPf.DataValueField = "Pfid";
            if (IsLanguageEng())
            {
                this.ddlPf.DataTextField = "PfText1";
            }
            this.ddlPf.DataBind();

            if (this.ddlPf.Items.Count == 0)
            {
                this.ddlPf.Visible = false;
                this.lkPlatformEdit.Visible = true;
            }
        }

        /// <summary>
        /// 添加、修改数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOK_Click(object sender, EventArgs e)
        {
            //验证表单数据：页面中文本框
            if (this.CheckForm() == false)
            {
                CloseDivImplementation();
                return;
            }

            RoleEO roleEO = new RoleEO();

            if (Request.QueryString["State"] == "U")
            {
                roleEO = roleManage.GetRoleByPK(Request.QueryString["Rlid"]);
            }

            roleEO.RlName = this.txtRlName.Text.Trim();
            roleEO.PfId = this.ddlPf.SelectedValue;
            roleEO.RlState = this.rblState.SelectedValue;

            //创建角色信息
            if (Request.QueryString["State"] == "A")
            {
                //判断角色名称是否存在
                if (this.CheckRoleName() == false)
                {
                    this.divAlert.Visible = true;
                    this.lblAlert.Text = this.ddlPf.SelectedItem.Text + Resources.Resource.Middle_role_name + this.txtRlName.Text.Trim() + Resources.Resource.Already_exist;
                    CloseDivImplementation();
                    return;
                }
                string id = GetBigGuid();
                roleEO.RlId = id;
                roleEO.RlDel = "0";
                roleEO.RlAddUser = GetUserID();
                roleEO.RlAddTime = DateTime.Now;

                if (roleManage.AddRole(roleEO) > 0)
                {
                    SetGameChannel(id);
                    //插入操作日志
                    InsertLog(Resources.Resource.Create_role, string.Format("rolename:{0},id:{1}", roleEO.RlName, roleEO.RlId), 4, GetPlatformIdByValue(1));
                    CloseDivImplementation();
                    Jswork.Alert(Resources.Resource.Role_information_creation_success, "RoleList.aspx");
                }
                else
                {
                    this.divAlert.Visible = true;
                    this.lblAlert.Text = Resources.Resource.Role_information_creation_failed;//"角色信息创建失败";
                }
            }

            //修改角色
            if (Request.QueryString["State"] == "U")
            {
                //修改时判断角色名称是否存在
                if (hfRoleName.Value != this.txtRlName.Text.Trim())
                {
                    //判断角色名称是否存在
                    if (this.CheckRoleName() == false)
                    {
                        this.divAlert.Visible = true;
                        this.lblAlert.Text = this.ddlPf.SelectedItem.Text +Resources.Resource.Middle_role_name+ this.txtRlName.Text.Trim() + Resources.Resource.Already_exist;
                        CloseDivImplementation();
                        return;
                    }
                }

                if (roleManage.EditRole(roleEO) > 0)
                {
                    SetGameChannel(roleEO.RlId);
                    //插入操作日志
                    InsertLog(Resources.Resource.Modify_role, string.Format("rolename:{0},id:{1}", roleEO.RlName, roleEO.RlId), 5, GetPlatformIdByValue(1));
                    CloseDivImplementation();
                    Jswork.Alert(Resources.Resource.Role_information_change_success, "RoleList.aspx");
                }
                else
                {
                    this.divAlert.Visible = true;
                    this.lblAlert.Text = Resources.Resource.Role_information_modification_failed;//"角色信息修改失败";
                }
            }
            CloseDivImplementation();
        }

        /// <summary>
        /// 设置游戏渠道
        /// </summary>
        private void SetGameChannel(string roleid)
        {
            RolegameEO _rgeo = new RolegameEO();
            _rgeo.RlId = roleid;
            _rgeo.UrId = GetUserID();
            _rgeo.RgAddTime = DateTime.Now;
            for (int i = 0; i < cblGame.Items.Count; i++) //  循环选中渠道的值
            {
                if (cblGame.Items[i].Selected) // 选中
                {
                    _rgmo.RemoveByPK(roleid, cblGame.Items[i].Value);
                    _rgeo.GmId = cblGame.Items[i].Value;
                    _rgmo.Add(_rgeo);
                }
                else //非选中
                {
                    _rgmo.RemoveByPK(roleid, cblGame.Items[i].Value);
                }
            }
        }

        /// <summary>
        /// 返回
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("RoleList.aspx");
        }

        /// <summary>
        /// 判断角色名称是否存在
        /// </summary>
        /// <returns></returns>
        private bool CheckRoleName()
        {
            IList<MySqlParameter> parm = new List<MySqlParameter>();
            StringBuilder strWhere = new StringBuilder();
            strWhere.Append("  Rl_name = @Rl_name AND Pf_id =@Pf_id AND Rl_del = 0 ");
            parm.Add(new MySqlParameter("@Rl_name", this.txtRlName.Text.Trim()));
            parm.Add(new MySqlParameter("@Pf_id", this.ddlPf.SelectedValue));
            if (roleManage.GetTable(strWhere.ToString(), parm).Rows.Count > 0)
            //if (roleManage.GetTable(string.Format(" Rl_name = '{0}' AND Pf_id = '{1}' AND Rl_del = 0", this.txtRlName.Text.Trim(), this.ddlPf.SelectedValue)).Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// 验证表单
        /// </summary>
        /// <returns></returns>
        private bool CheckForm()
        {
            //txtRlName 角色名称

            bool flg = false;

            for (int i = 0; i < Page.Controls.Count; i++)
            {
                foreach (System.Web.UI.Control control in Page.Controls[i].Controls)
                {
                    if (control is TextBox)
                    {
                        if (String.IsNullOrEmpty((control as TextBox).Text.Trim()))
                        {
                            //Jswork.Alert("请录入必填项", this.Page);
                            this.divAlert.Visible = true;
                            this.lblAlert.Text = Resources.Resource.Please_enter_a_character_name;//"请输入角色名";
                            flg = false;
                        }
                        else
                        {
                            flg = true;
                        }
                    }
                }
            }

            return flg;
        }

        protected void lkPlatformEdit_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Platform/PlatformEdit.aspx?State=A&Action=1");
        }
    }
}