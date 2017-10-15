using System;
using LZManager.BLL.Common;
using LZManager.DAL;
using LZWebApp.BLL.Roulette;
using LZManager.BLL;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Text;

namespace LZManager.Permissions
{
    public partial class PermissionsEdit : BasePage
    {
        PermissionsManage pmManage = new PermissionsManage();

        protected void Page_Load(object sender, EventArgs e)
        {
            GetAuthorityUrl(this.Page, "Permissions/PermissionsList.aspx",1);

            if (!IsPostBack)
            {
                if (Request.QueryString["State"] != null)
                {
                    //更新功能信息
                    if (Request.QueryString["State"] == "U")
                    {
                        this.LoadPermissions();
                    }
                }
            }
        }

        /// <summary>
        /// 加载功能信息
        /// </summary>
        private void LoadPermissions()
        {
            PermissionsEO pmEO = new PermissionsEO();

            pmEO = pmManage.GetPermissionsByPK(Request.QueryString["Pmid"]);
            if (!string.IsNullOrEmpty(pmEO.PmName))
            {
                this.txtPmname.Text = pmEO.PmName;
                this.hfPermissionsName.Value = pmEO.PmName;
                this.rblState.SelectedValue = pmEO.PmState;
            }
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            if (this.CheckForm() == false)
            {
                CloseDivImplementation();
                return;
            }

            PermissionsEO pmEO = new PermissionsEO();

            if (Request.QueryString["State"] == "U")
            {
                pmEO = pmManage.GetPermissionsByPK(Request.QueryString["Pmid"]);
            }

            pmEO.PmName = this.txtPmname.Text.Trim();
            pmEO.PmState = this.rblState.SelectedValue;

            //创建功能信息
            if (Request.QueryString["State"] == "A")
            {
                //判断功能名称是否存在
                if (this.ChecPermissionsName() == false)
                {
                    //Jswork.Alert("功能名称 " + this.txtPmname.Text.Trim() + " 已存在", this.Page);

                    this.divAlert.Visible = true;
                    this.lblAlert.Text = Resources.Resource.Functio_nname + this.txtPmname.Text.Trim() + Resources.Resource.Already_exist;
                    CloseDivImplementation();
                    return;
                }

                pmEO.PmId = GetBigGuid();
                pmEO.PmDel = "0";
                pmEO.PmAddUser = GetUserID();
                pmEO.PmAddTime = DateTime.Now;

                if (pmManage.AddPermissions(pmEO) > 0)
                {
                    //插入操作日志
                    InsertLog(Resources.Resource.Create_functional_information, string.Format("permissionsname:{0},id:{1}", pmEO.PmName, pmEO.PmId), 10, GetPlatformIdByValue(1));
                    CloseDivImplementation();
                    Jswork.Alert(Resources.Resource.Function_information_to_create_success, "PermissionsList.aspx");
                }
                else
                {
                    //Jswork.Alert("功能信息创建失败", this.Page);
                    this.divAlert.Visible = true;
                    this.lblAlert.Text = Resources.Resource.Functional_information_creation_failed;// "功能信息创建失败";
                }
            }

            //修改功能信息
            if (Request.QueryString["State"] == "U")
            {
                //修改时判断功能名称是否存在
                if (this.hfPermissionsName.Value != this.txtPmname.Text.Trim())
                {
                    //判断平台名称是否存在
                    if (this.ChecPermissionsName() == false)
                    {
                        //Jswork.Alert("功能名称 " + this.txtPmname.Text.Trim() + " 已存在", this.Page);

                        this.divAlert.Visible = true;
                        this.lblAlert.Text = Resources.Resource.Functio_nname + this.txtPmname.Text.Trim() + Resources.Resource.Already_exist;
                        CloseDivImplementation();
                        return;
                    }
                }

                if (pmManage.EditPermissions(pmEO) > 0)
                {
                    //插入操作日志
                    InsertLog(Resources.Resource.Modify_function_information, string.Format("permissionsname:{0},id:{1}", pmEO.PmName, pmEO.PmId), 11, GetPlatformIdByValue(1));
                    CloseDivImplementation();
                    Jswork.Alert(Resources.Resource.Success_of_functional_information_modification, "PermissionsList.aspx");
                }
                else
                {
                    //Jswork.Alert("功能信息修改失败", this.Page);
                    this.divAlert.Visible = true;
                    this.lblAlert.Text = Resources.Resource.Failure_of_functional_information_modification; //"功能信息修改失败";
                }
            }
            CloseDivImplementation();
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("PermissionsList.aspx");
        }

        /// <summary>
        /// 判断功能名称是否存在
        /// </summary>
        /// <returns></returns>
        private bool ChecPermissionsName()
        {
            //if (pmManage.GetTable(string.Format(" Pm_name = '{0}' AND Pm_del = 0", this.txtPmname.Text.Trim())).Rows.Count > 0)
            IList<MySqlParameter> parm = new List<MySqlParameter>();
            StringBuilder strWhere = new StringBuilder();
            strWhere.Append(" Pm_name =@Pm_name AND Pm_del = 0");
            parm.Add(new MySqlParameter("@Pm_name", this.txtPmname.Text.Trim()));
            if (pmManage.GetTable(strWhere.ToString(), parm).Rows.Count > 0)
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
                            this.lblAlert.Text = Resources.Resource.Please_enter_a_function_name;//"请输入功能名称";
                            control.Focus();
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
    }
}