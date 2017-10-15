using System;
using LZManager.BLL.Common;
using LZManager.DAL;
using LZWebApp.BLL.Roulette;
using LZManager.BLL;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Text;

namespace LZManager.PermissionsTatal
{
    public partial class PermissionsTatalEdit : BasePage
    {
        PermissionsTatalManage ptManage = new PermissionsTatalManage();
        PermissionsTatalPManage ptpManage = new PermissionsTatalPManage();

        protected void Page_Load(object sender, EventArgs e)
        {
            GetAuthorityUrl(this.Page, "PermissionsTatal/PermissionsTatalList.aspx",1);

            if (!IsPostBack)
            {
                this.LoadPermissions();
                this.LoadPlatform();

                if (Request.QueryString["State"] != null)
                {
                    //更新总功能信息
                    if (Request.QueryString["State"] == "U")
                    {
                        this.LoadPermissionsTatal();
                        this.LoadPermissionsTatalP();
                    }
                }
            }
        }

        /// <summary>
        /// 加载功能列表
        /// </summary>
        private void LoadPermissions()
        {
            PermissionsManage psManage = new PermissionsManage();
            this.cblPermissions.DataSource = psManage.Get(" Pm_del = 0");
            this.cblPermissions.DataTextField = "Pmname";
            this.cblPermissions.DataValueField = "PmId";
            this.cblPermissions.DataBind();

            if (this.cblPermissions.Items.Count == 0)
            {
                this.lkPremissionsEdit.Visible = true;
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
            this.ddlPf.DataBind();

            if (this.ddlPf.Items.Count == 0)
            {
                this.ddlPf.Visible = false;
                this.lkPlatformEdit.Visible = true;
            }
        }

        /// <summary>
        /// 加载总功能信息
        /// </summary>
        private void LoadPermissionsTatal()
        {
            PermissionstatalEO ptEO = new PermissionstatalEO();

            ptEO = ptManage.GetPermissionsTatalByPK(Request.QueryString["Ptid"]);
            if (!string.IsNullOrEmpty(ptEO.PtName))
            {
                this.txtPtName.Text = ptEO.PtName;
                this.hfPtName.Value = ptEO.PtName;
                this.ddlPf.SelectedValue = ptEO.PfId;
                this.rblState.SelectedValue = ptEO.PtState;
            }
        }

        /// <summary>
        /// 加载总功能关系信息
        /// </summary>
        private void LoadPermissionsTatalP()
        {
            //DataTable dt = ptpManage.GetTable(string.Format(" Pt_id = '{0}'", Request.QueryString["Ptid"]));
            IList<MySqlParameter> parm = new List<MySqlParameter>();
            StringBuilder strWhere = new StringBuilder();
            strWhere.Append(" Pt_id=@Pt_id");
            parm.Add(new MySqlParameter("@Pt_id", Request.QueryString["Ptid"]));

            DataTable dt = ptpManage.GetTable(strWhere.ToString(), parm);

            if (dt != null && dt.Rows.Count > 0)
            {
                for (int i = 0; i < this.cblPermissions.Items.Count; i++)
                {
                    for (int j = 0; j < dt.Rows.Count; j++)
                    {
                        if (this.cblPermissions.Items[i].Value == dt.Rows[j]["Pm_id"].ToString())
                        {
                            this.cblPermissions.Items[i].Selected = true;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 维护信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOK_Click(object sender, EventArgs e)
        {
            if (this.CheckForms() == false)
            {
                CloseDivImplementation();
                return;
            }

            PermissionstatalEO ptEO = new PermissionstatalEO(); //总功能
            PermissionstatalpEO ptpEO = new PermissionstatalpEO(); //总功能关系

            if (Request.QueryString["State"] == "U")
            {
                ptEO = ptManage.GetPermissionsTatalByPK(Request.QueryString["Ptid"]);
            }

            //总功能数据
            ptEO.PtName = this.txtPtName.Text.Trim();
            ptEO.PfId = this.ddlPf.SelectedValue;
            ptEO.PtState = this.rblState.SelectedValue;

            //创建总功能信息
            if (Request.QueryString["State"] == "A")
            {
                //判断总功能名称是否存在
                if (this.ChecPtName() == false)
                {
                    //Jswork.Alert("总功能名称 " + this.txtPtName.Text.Trim() + " 已存在", this.Page);

                    this.divAlert.Visible = true;
                    this.lblAlert.Text = this.ddlPf.SelectedItem.Text + Resources.Resource.Name_of_total_function_in + this.txtPtName.Text.Trim() + Resources.Resource.Already_exist;
                    CloseDivImplementation();
                    return;
                }

                //总功能数据
                ptEO.PtId = GetBigGuid();
                ptEO.PtDel = "0";
                ptEO.PtAddUser = GetUserID();
                ptEO.PtAddTime = DateTime.Now;

                //总功能关系数据            
                for (int i = 0; i < this.cblPermissions.Items.Count; i++)
                {
                    if (this.cblPermissions.Items[i].Selected)
                    {
                        ptpEO.PtId = ptEO.PtId;
                        ptpEO.PmId = this.cblPermissions.Items[i].Value;
                        ptpEO.PpUser = GetUserID();
                        ptpEO.PpAddTime = DateTime.Now;

                        ptpManage.AddPermissionsTatalP(ptpEO);
                    }
                }

                if (ptManage.AddPermissionsTatal(ptEO) > 0)
                {
                    //插入操作日志
                    InsertLog(Resources.Resource.Create_general_function_information, string.Format("permissionstatalname:{0},id:{1}", ptEO.PtName, ptEO.PtId), 7, GetPlatformIdByValue(1));
                    CloseDivImplementation();
                    Jswork.Alert(Resources.Resource.Total_function_information_creation_success, "PermissionsTatalList.aspx");
                }
                else
                {
                    //Jswork.Alert("总功能信息创建失败", this.Page);
                    this.divAlert.Visible = true;
                    this.lblAlert.Text = Resources.Resource.Total_function_information_creation_failed;//"总功能信息创建失败";
                }
            }

            //修改总功能信息
            if (Request.QueryString["State"] == "U")
            {
                //修改时判断总功能名称是否存在
                if (this.hfPtName.Value != this.txtPtName.Text.Trim())
                {
                    //判断平台名称是否存在
                    if (this.ChecPtName() == false)
                    {
                        //Jswork.Alert("总功能名称 " + this.txtPtName.Text.Trim() + " 已存在", this.Page);

                        this.divAlert.Visible = true;
                        this.lblAlert.Text = this.ddlPf.SelectedItem.Text + Resources.Resource.Name_of_total_function_in + this.txtPtName.Text.Trim() + Resources.Resource.Already_exist;
                        CloseDivImplementation();
                        return;
                    }
                }

                //总功能关系数据     
                ptpManage.RemoveByPK(Request.QueryString["Ptid"]); //插入关系表数据前先删除数据
                for (int i = 0; i < this.cblPermissions.Items.Count; i++)
                {
                    if (this.cblPermissions.Items[i].Selected)
                    {
                        ptpEO.PtId = Request.QueryString["Ptid"];
                        ptpEO.PmId = this.cblPermissions.Items[i].Value;
                        ptpEO.PpUser = GetUserID();
                        ptpEO.PpAddTime = DateTime.Now;

                        ptpManage.AddPermissionsTatalP(ptpEO);
                    }
                }

                if (ptManage.EditPermissionsTatal(ptEO) > 0)
                {
                    //插入操作日志
                    InsertLog(Resources.Resource.Modify_general_function_information, string.Format("permissionstatalname:{0},id:{1}", ptEO.PtName, ptEO.PtId), 8, GetPlatformIdByValue(1));
                    CloseDivImplementation();
                    Jswork.Alert(Resources.Resource.The_success_of_total_functional_information_modification, "PermissionsTatalList.aspx");
                }
                else
                {
                    //Jswork.Alert("总功能信息修改失败", this.Page);
                    this.divAlert.Visible = true;
                    this.lblAlert.Text = Resources.Resource.Failure_of_total_functional_information_modification;
                }
            }
            CloseDivImplementation();
        }

        /// <summary>
        /// 返回列表页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("PermissionsTatalList.aspx");
        }

        /// <summary>
        /// 判断总功能名称是否存在
        /// </summary>
        /// <returns></returns>
        private bool ChecPtName()
        {
            //if (ptManage.GetTable(string.Format(" Pt_name = '{0}' AND Pf_id = '{1}' AND Pt_del = 0 ", this.txtPtName.Text.Trim(), this.ddlPf.SelectedValue)).Rows.Count > 0)
            IList<MySqlParameter> parm = new List<MySqlParameter>();
            StringBuilder strWhere = new StringBuilder();
            strWhere.Append(" Pt_name = @Pt_name AND Pf_id = @Pf_id AND Pt_del = 0 ");
            parm.Add(new MySqlParameter("@Pt_name", this.txtPtName.Text.Trim()));
            parm.Add(new MySqlParameter("@Pf_id", this.ddlPf.SelectedValue));
            if (ptManage.GetTable(strWhere.ToString(), parm).Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
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

            if (string.IsNullOrEmpty(this.txtPtName.Text.Trim()))
            {
                flg = false;
                strAlert = Resources.Resource.Please_enter_the_name_of_the_total_function;//"请输入总功能名称";
                this.txtPtName.Focus();
            }            
            else if (string.IsNullOrEmpty(this.ddlPf.SelectedValue))
            {
                flg = false;
                strAlert = Resources.Resource.Please_select_the_platform_name;//"请选择平台名称";
                this.ddlPf.Focus();
            }
            else if (string.IsNullOrEmpty(this.cblPermissions.SelectedValue))
            {
                flg = false;
                strAlert = Resources.Resource.Please_select_the_function_name;//"请选择功能名";
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

        protected void lkPlatformEdit_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Platform/PlatformEdit.aspx?State=A");
        }

        protected void lkPremissionsEdit_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Permissions/PermissionsEdit.aspx?State=A");
        }
    }
}