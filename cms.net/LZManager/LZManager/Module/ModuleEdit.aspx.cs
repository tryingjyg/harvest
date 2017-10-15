using System;
using LZManager.BLL.Common;
using LZManager.DAL;
using LZWebApp.BLL.Roulette;
using LZManager.BLL;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;
using System.Text;
using System.Collections.Generic;

namespace LZManager.Module
{
    public partial class ModuleEdit : BasePage
    {
        ModuleManage mdManage = new ModuleManage();
        ModulePermissionsManage mdpManage = new ModulePermissionsManage();

        protected int iUpdateState = 0; //更新状态0更新父模块 1更新子模块

        protected void Page_Load(object sender, EventArgs e)
        {
            GetAuthorityUrl(this.Page, "Module/ModuleList.aspx", 1);

            //this.btnOK.Attributes.Add("onclick", "javascript:if(confirm('是否继续录入？')){}else{return false;}");

            if (!IsPostBack)
            {
                this.LoadPlatform();
                this.LoadPermissionsTatal(this.ddlPf.SelectedValue);

                if (Request.QueryString["State"] != null)
                {
                    //新建父模块
                    if (Request.QueryString["State"] == "AF") //AddFather
                    {
                        this.trMdParent.Visible = false;
                        this.trMdParent_en.Visible = false;
                        this.lblMdTitle.Text = Resources.Resource.parent_module_name;// "父模块名称:";
                        this.lblMdTitle_en.Text = "parent module name:";

                        //"父模块名称:";
                    }

                    //新建子模块
                    if (Request.QueryString["State"] == "AC") //AddChild
                    {
                        this.trMdParent.Visible = true;
                        trMdParent_en.Visible = true;
                       
                        this.lblMdPartentName.Text = Request.QueryString["ParentName"];
                        this.lblMdPartentName_en.Text = Request.QueryString["MdText1"];//传递过来英文的名称
                        this.hfMdId.Value = Request.QueryString["ParentID"];
                        this.lblMdTitle.Text = Resources.Resource.submodule_name;// "子模块名称:";

                        this.lblMdTitle_en.Text = "submodule:";
                            
                            //"子模块名称:";




                        ModuleEO mdEO = new ModuleEO();

                        mdEO = mdManage.GetModuleByPK(this.hfMdId.Value);
                        if (!string.IsNullOrEmpty(mdEO.MdName))
                        {
                            this.ddlPf.SelectedValue = mdEO.PfId;
                            this.ddlPf.Enabled = false;
                            this.LoadPermissionsTatal(this.ddlPf.SelectedValue);
                        }
                    }

                    //更新模块
                    if (Request.QueryString["State"] == "U")
                    {
                        this.trMdParent.Visible = false;
                        this.trMdParent_en.Visible = false;
                        this.lblMdTitle.Text = Resources.Resource.parentmodulename; //"模块名称";  

                        this.lblMdTitle_en.Text = "module name:"; 
                        this.hfMdId.Value = Request.QueryString["ModuleID"];
                        this.LoadModule();
                        this.LoadModulePermissions();

                    }
                }
            }
        }

        /// <summary>
        /// 加载平台
        /// </summary>
        private void LoadPlatform()
        {
            PlatformManage PfManage = new PlatformManage();
            this.ddlPf.DataSource = PfManage.Get(" Pf_del = 0 ORDER BY Pf_sort asc");
            this.ddlPf.DataTextField = "Pfname";

            if (IsLanguageEng())
            {
                this.ddlPf.DataTextField = "PfText1";

                //new NxPlatformEO().PfText1
            }
            this.ddlPf.DataValueField = "Pfid";
            this.ddlPf.DataBind();

            if (this.ddlPf.Items.Count == 0)
            {
                this.ddlPf.Visible = false;
                this.lkPlatformEdit.Visible = true;
            }
        }

        /// <summary>
        /// 加载模块
        /// </summary>
        private void LoadModule()
        {
            ModuleEO mdEO = new ModuleEO();

            mdEO = mdManage.GetModuleByPK(Request.QueryString["ModuleID"]);
            if (!string.IsNullOrEmpty(mdEO.MdName))
            {
                this.lblMdPartentName.Text = mdEO.MdParentid;
                this.txtMdName.Text = mdEO.MdName;
                this.hfMdName.Value = mdEO.MdName;
                this.txtAddress.Text = mdEO.MdAddress;
                this.ddlPf.SelectedValue = mdEO.PfId;
                this.txtNotes.Text = mdEO.MdNotes;
                this.txtSort.Text = mdEO.MdFiledOrder.ToString();
                this.rblMdExist.SelectedValue = mdEO.MdExistsTreeView;
                this.rblState.SelectedValue = mdEO.MdUseFlag;


                this.txtMdName_en.Text = mdEO.MdText1;//英文

                if (mdEO.MdParentid == "0") //加载父模块信息
                {
                    this.ddlPf.Enabled = true;
                    iUpdateState = 0;
                }
                else //加载子模块信息
                {
                    this.ddlPf.Enabled = false;
                    iUpdateState = 1;
                }
            }
        }

        /// <summary>
        /// 加载功能列表
        /// </summary>
        private void LoadPermissionsTatal(string strPfid)
        {
            PermissionsTatalManage pslManage = new PermissionsTatalManage();
            //this.cblPermissionsTatal.DataSource = pslManage.Get(" Pf_id='" + strPfid + "' AND Pt_del = 0");
            StringBuilder strWhere = new StringBuilder();
            strWhere.Append(" 1=1");
            IList<MySqlParameter> parm = new List<MySqlParameter>();
            strWhere.Append(" and Pf_id=@strPfid AND Pt_del = 0 ");
            parm.Add(new MySqlParameter("@strPfid", strPfid));
            this.cblPermissionsTatal.DataSource = pslManage.Get(strWhere.ToString(), parm);
            this.cblPermissionsTatal.DataTextField = "Ptname";
            this.cblPermissionsTatal.DataValueField = "PtId";
            this.cblPermissionsTatal.DataBind();

            if (this.cblPermissionsTatal.Items.Count == 0)
            {
                this.lkPermissionsTatalEdit.Visible = true;
            }
        }

        /// <summary>
        /// 加载总功能关系信息
        /// </summary>
        private void LoadModulePermissions()
        {
            this.LoadPermissionsTatal(this.ddlPf.SelectedValue);

            StringBuilder strWhere = new StringBuilder();
            strWhere.Append(" 1=1 ");
            IList<MySqlParameter> parm = new List<MySqlParameter>();
            strWhere.Append(" and Md_id = @ModuleID");
            parm.Add(new MySqlParameter("@ModuleID", Request.QueryString["ModuleID"]));
            DataTable dt = mdpManage.GetTable(strWhere.ToString(), parm);

            if (dt != null && dt.Rows.Count > 0)
            {
                for (int i = 0; i < this.cblPermissionsTatal.Items.Count; i++)
                {
                    for (int j = 0; j < dt.Rows.Count; j++)
                    {
                        if (this.cblPermissionsTatal.Items[i].Value == dt.Rows[j]["Pm_id"].ToString())
                        {
                            this.cblPermissionsTatal.Items[i].Selected = true;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 添加、修改数据
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
            if (this.CheckIsNum(this.txtSort.Text.Trim()) == false)
            {
                this.divAlert.Visible = true;
                this.lblAlert.Text = Resources.Resource.Please_enter_a_sort_number;//"请输入排序数字";
                CloseDivImplementation();
                return;
            }

            ModuleEO mdEO = new ModuleEO(); //模块信息
            ModulepermissionsEO mdpEO = new ModulepermissionsEO(); //模块功能关系

            if (Request.QueryString["State"] == "U")
            {
                mdEO = mdManage.GetModuleByPK(Request.QueryString["ModuleID"]);
            }

            mdEO.MdName = this.txtMdName.Text;
            mdEO.MdAddress = this.txtAddress.Text;
            mdEO.PfId = this.ddlPf.SelectedValue;
            mdEO.MdUseFlag = this.rblState.SelectedValue;
            mdEO.MdNotes = this.txtNotes.Text;
            mdEO.MdFiledOrder = Convert.ToInt32(this.txtSort.Text.Trim()); //备用字段：模块排序
            mdEO.MdExistsTreeView = this.rblMdExist.SelectedValue;
            mdEO.MdImgUrl = @"../Images/farmework/ico11.gif";
            mdEO.MdText1 = this.txtMdName_en.Text;//英文


            

            //创建父模块
            if (Request.QueryString["State"] == "AF")
            {
                //判断模块名称是否存在
                if (this.CheckModuleName() == false)
                {
                    //Jswork.Alert("父模块名称 " + this.txtMdName.Text.Trim() + " 已存在", this.Page);

                    this.divAlert.Visible = true;
                    this.lblAlert.Text = this.ddlPf.SelectedItem.Text + Resources.Resource.Name_of_the_parent_module + this.txtMdName.Text.Trim() + Resources.Resource.Already_exist;
                    CloseDivImplementation();
                    return;
                }

                //模块信息数据
                mdEO.MdId = GetBigGuid();
                mdEO.MdParentid = "0";
                mdEO.MdDeleteFlag = "0";
                mdEO.MdAddTime = DateTime.Now;

                //模块功能关系数据            
                for (int i = 0; i < this.cblPermissionsTatal.Items.Count; i++)
                {
                    if (this.cblPermissionsTatal.Items[i].Selected)
                    {
                        mdpEO.MdId = mdEO.MdId;
                        mdpEO.PmId = this.cblPermissionsTatal.Items[i].Value;
                        mdpEO.MpUser = GetUserID();
                        mdpEO.MpAddTime = DateTime.Now.ToString();

                        mdpManage.AddModulePermissions(mdpEO);
                    }
                }

                if (mdManage.AddModule(mdEO) > 0)
                {
                    //插入操作日志
                    InsertLog(Resources.Resource.Create_parent_module, string.Format("modulename:{0},id:{1}", mdEO.MdName, mdEO.PfId), 16, GetPlatformIdByValue(1));
                    CloseDivImplementation();
                    Jswork.Alert(Resources.Resource.Parent_module_creates_success, "ModuleList.aspx");
                }
                else
                {
                    //Jswork.Alert("父模块创建失败", this.Page);
                    this.divAlert.Visible = true;
                    this.lblAlert.Text = Resources.Resource.Parent_module_creates_success;
                }
            }

            //创建子模块
            if (Request.QueryString["State"] == "AC")
            {
                //判断模块名称是否存在
                if (this.CheckChildModuleName() == false)
                {
                    //Jswork.Alert("子模块名称 " + this.txtMdName.Text.Trim() + " 已存在", this.Page);

                    this.divAlert.Visible = true;
                    this.lblAlert.Text = this.lblMdPartentName.Text + Resources.Resource.Neutron_module_name + this.txtMdName.Text.Trim() + Resources.Resource.Already_exist;
                    CloseDivImplementation();
                    return;
                }

                mdEO.MdId = GetBigGuid();
                mdEO.MdParentid = hfMdId.Value;
                mdEO.MdDeleteFlag = "0";
                mdEO.MdAddress = this.txtAddress.Text.Trim();
                mdEO.MdAddTime = DateTime.Now;

                //模块功能关系数据            
                for (int i = 0; i < this.cblPermissionsTatal.Items.Count; i++)
                {
                    if (this.cblPermissionsTatal.Items[i].Selected)
                    {
                        mdpEO.MdId = mdEO.MdId;
                        mdpEO.PmId = this.cblPermissionsTatal.Items[i].Value;
                        mdpEO.MpUser = GetUserID();
                        mdpEO.MpAddTime = DateTime.Now.ToString("yyyy-MM-dd");

                        mdpManage.AddModulePermissions(mdpEO);
                    }
                }

                if (mdManage.AddModule(mdEO) > 0)
                {
                    //插入操作日志
                    InsertLog(Resources.Resource.Create_sub_module, string.Format("modulename:{0},id:{1}", mdEO.MdName, mdEO.PfId), 16, GetPlatformIdByValue(1));
                    CloseDivImplementation();
                    Jswork.Alert(Resources.Resource.Sub_module_to_create_success, "ModuleList.aspx");
                }
                else
                {
                    //Jswork.Alert("子模块创建失败", this.Page);
                    this.divAlert.Visible = true;
                    this.lblAlert.Text = Resources.Resource.Module_creation_failed;//"子模块创建失败";
                }
            }

            //修改模块
            if (Request.QueryString["State"] == "U")
            {
                //修改时判断模块名称是否存在
                if (this.hfMdName.Value != this.txtMdName.Text.Trim())
                {
                    if (iUpdateState == 0)
                    {
                        //判断模块名称是否存在
                        if (this.CheckModuleName() == false)
                        {
                            //Jswork.Alert("父模块名称 " + this.txtMdName.Text.Trim() + " 已存在", this.Page);

                            this.divAlert.Visible = true;
                            this.lblAlert.Text = this.ddlPf.SelectedItem.Text + Resources.Resource.Name_of_the_parent_module+ this.txtMdName.Text.Trim() + Resources.Resource.Already_exist;
                            CloseDivImplementation();
                            return;
                        }
                    }
                    else
                    {
                        //判断模块名称是否存在
                        if (this.CheckChildModuleName() == false)
                        {
                            //Jswork.Alert("子模块名称 " + this.txtMdName.Text.Trim() + " 已存在", this.Page);

                            this.divAlert.Visible = true;
                            this.lblAlert.Text = this.lblMdPartentName.Text + Resources.Resource.Neutron_module_name + this.txtMdName.Text.Trim() +  Resources.Resource.Already_exist;
                            CloseDivImplementation();
                            return;
                        }
                    }
                }

                //更改父模块平台ID时，所有子模块的平台ID一起更新
                if (iUpdateState == 0)
                {
                    mdManage.PutPfIdByPtId(this.hfMdId.Value, this.ddlPf.SelectedValue);
                }

                //模块功能关系数据     
                mdpManage.RemoveByPK(Request.QueryString["ModuleID"]); //插入关系表数据前先删除数据
                for (int i = 0; i < this.cblPermissionsTatal.Items.Count; i++)
                {
                    if (this.cblPermissionsTatal.Items[i].Selected)
                    {
                        mdpEO.MdId = mdEO.MdId;
                        mdpEO.PmId = this.cblPermissionsTatal.Items[i].Value;
                        mdpEO.MpUser = GetUserID();
                        mdpEO.MpAddTime = DateTime.Now.ToString("yyyy-MM-dd");

                        mdpManage.AddModulePermissions(mdpEO);
                    }
                }

                if (mdManage.EditModule(mdEO) > 0)
                {
                    //插入操作日志
                    InsertLog(Resources.Resource.Modify_module, string.Format("modulename:{0},id:{1}", mdEO.MdName, mdEO.PfId), 17, GetPlatformIdByValue(1));
                    CloseDivImplementation();
                    Jswork.Alert(Resources.Resource.Module_modification_success, "ModuleList.aspx");
                }
                else
                {
                    Jswork.Alert(Resources.Resource.Module_modification_failed, this.Page);
                }
            }
            CloseDivImplementation();
        }

        /// <summary>
        /// 绑定总功能信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ddlPf_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadPermissionsTatal(this.ddlPf.SelectedValue);
        }

        /// <summary>
        /// 跳转到录入平台信息页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lkPlatformEdit_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Platform/PlatformEdit.aspx?State=A&Action=0");
        }

        /// <summary>
        /// 跳转到录入总功能信息页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lkPermissionsTatalEdit_Click(object sender, EventArgs e)
        {
            Response.Redirect("../PermissionsTatal/PermissionsTatalEdit.aspx?State=A&Action=0");
        }

        /// <summary>
        /// 判断某一平台下父模块名称是否存在
        /// </summary>
        /// <returns></returns>
        private bool CheckModuleName()
        {
            //if (mdManage.GetTable(string.Format(" Pf_id = '{0}' AND Md_name = '{1}' AND Md_deleteFlag = 0 ", this.ddlPf.SelectedValue, this.txtMdName.Text.Trim())).Rows.Count > 0)
            IList<MySqlParameter> parm = new List<MySqlParameter>();
            StringBuilder strWhere = new StringBuilder();
            strWhere.Append(" Pf_id = @Pf_id AND Md_name = @Md_name AND Md_deleteFlag = 0 ");
            parm.Add(new MySqlParameter("@Pf_id", this.ddlPf.SelectedValue));
            parm.Add(new MySqlParameter("@Md_name", this.txtMdName.Text.Trim()));
            //if (mdManage.GetTable(string.Format(" Pf_id = '{0}' AND Md_name = '{1}' AND Md_deleteFlag = 0 ", this.ddlPf.SelectedValue, this.txtMdName.Text.Trim())).Rows.Count > 0)
            if (mdManage.GetTable(strWhere.ToString(), parm).Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// 判断某一父模块下子模块名称是否存在
        /// </summary>
        /// <returns></returns>
        private bool CheckChildModuleName()
        {
            //if (mdManage.GetTable(string.Format(" Md_parentid = '{0}' AND Md_name = '{1}' AND Md_deleteFlag = 0", this.hfMdId.Value, this.txtMdName.Text.Trim())).Rows.Count > 0)
            IList<MySqlParameter> parm = new List<MySqlParameter>();
            StringBuilder strWhere = new StringBuilder();
            strWhere.Append("  Md_parentid = @Md_parentid AND Md_name = @Md_name AND Md_deleteFlag = 0");
            parm.Add(new MySqlParameter("@Md_parentid", this.hfMdId.Value));
            parm.Add(new MySqlParameter("@Md_name", this.txtMdName.Text.Trim()));
            //if (mdManage.GetTable(string.Format(" Md_parentid = '{0}' AND Md_name = '{1}' AND Md_deleteFlag = 0", this.hfMdId.Value, this.txtMdName.Text.Trim())).Rows.Count > 0)
            if (mdManage.GetTable(strWhere.ToString(), parm).Rows.Count > 0)
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
                            this.lblAlert.Text = Resources.Resource.Please_input_the_required;// "请录入必填项";
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

        /// <summary>
        /// 验证页面表单合理性
        /// </summary>
        /// <returns></returns>
        private bool CheckForms()
        {
            bool flg = true;
            string strAlert = string.Empty;

            if (string.IsNullOrEmpty(this.txtMdName.Text.Trim()))
            {
                flg = false;
                strAlert = Resources.Resource.Please_enter_the_name_of_the_module;//"请输入模块名称";
                this.txtMdName.Focus();
            }
            else if (string.IsNullOrEmpty(this.txtAddress.Text.Trim()))
            {
                flg = false;
                strAlert = Resources.Resource.Please_enter_a_module_address;//"请输入模块地址";
                this.txtAddress.Focus();
            }
            else if (string.IsNullOrEmpty(this.ddlPf.SelectedValue))
            {
                flg = false;
                strAlert = Resources.Resource.Please_select_the_platform_name; //"请选择平台名称";
                this.ddlPf.Focus();
            }
            else if (string.IsNullOrEmpty(this.cblPermissionsTatal.SelectedValue))
            {
                flg = false;
                strAlert = Resources.Resource.Please_select_the_total_function_name;//"请选择总功能名称";
            }
            else if (string.IsNullOrEmpty(this.txtSort.Text.Trim()))
            {
                flg = false;
                strAlert = Resources.Resource.Please_enter_a_sort_number; //"请输入排序数字";
                this.txtSort.Focus();
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
        /// 验证是否数字
        /// </summary>
        /// <param name="oText"></param>
        /// <returns></returns>
        public bool CheckIsNum(string oText)
        {
            try
            {
                Decimal Number = Convert.ToDecimal(oText);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}