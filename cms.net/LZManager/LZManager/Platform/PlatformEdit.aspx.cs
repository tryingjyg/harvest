using System;
using LZManager.BLL.Common;
using LZManager.DAL;
using LZWebApp.BLL.Roulette;
using LZManager.BLL;
using System.Web.UI.WebControls;
using System.Xml;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Text;

namespace LZManager.Platform
{
    public partial class PlatformEdit : BasePage
    {
        PlatformManage PfManage = new PlatformManage();
        UpFile upFile = new UpFile();

        protected void Page_Load(object sender, EventArgs e)
        {
            GetAuthorityUrl(this.Page, "Platform/PlatformList.aspx", 1);

            if (!IsPostBack)
            {
                if (Request.QueryString["State"] != null)
                {
                    //创建平台信息
                    if (Request.QueryString["State"] == "A")
                    {
                        this.imgUrl.Visible = false;
                        this.FileUpload1.Visible = true;
                        this.btnUpload.Visible = false;
                        //this.btnCancelUpload.Visible = true;
                    }

                    //更新平台信息
                    if (Request.QueryString["State"] == "U")
                    {
                        this.LoadPlatform();
                    }
                }
            }
        }

        /// <summary>
        /// 加载平台信息
        /// </summary>
        private void LoadPlatform()
        {
            NxPlatformEO NxPlatformEO = new NxPlatformEO();

            NxPlatformEO = PfManage.GetPlatformByPK(Request.QueryString["Pfid"]);
            if (!string.IsNullOrEmpty(NxPlatformEO.PfName))
            {
                this.txtPfname.Text = NxPlatformEO.PfName;
                txtPfname_en.Text = NxPlatformEO.PfText1;//显示英文名称
                this.hfPfName.Value = NxPlatformEO.PfName;
                this.hfPfImg.Value = NxPlatformEO.PfImgUrl;
                this.imgUrl.ImageUrl = NxPlatformEO.PfImgUrl;
                if (!string.IsNullOrEmpty(NxPlatformEO.PfImgUrl))
                {
                    this.imgUrl.ImageUrl = NxPlatformEO.PfImgUrl;
                    this.imgUrl.Visible = true;
                    this.FileUpload1.Visible = false;
                    this.btnUpload.Visible = true;
                    this.btnCancelUpload.Visible = false;
                }
                else
                {
                    this.imgUrl.Visible = false;
                    this.FileUpload1.Visible = true;
                    this.btnUpload.Visible = false;
                    this.btnCancelUpload.Visible = true;
                }
                this.rblState.SelectedValue = NxPlatformEO.PfState;
                this.txtPfsort.Text = NxPlatformEO.PfSort.ToString();
            }
        }

        /// <summary>
        /// 新增、修改信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOK_Click(object sender, EventArgs e)
        {
            if (this.CheckForm() == false)
            {
                CloseDivImplementation();
                return;
            }
            if (this.hfPfImg.Value == "" && this.FileUpload1.HasFile == false)
            {
                this.divAlert.Visible = true;
                this.lblAlert.Text = Resources.Resource.Please_upload_platform;//"请上传平台图片";
            }

            NxPlatformEO NxPlatformEO = new NxPlatformEO();

            if (Request.QueryString["State"] == "U")
            {
                NxPlatformEO = PfManage.GetPlatformByPK(Request.QueryString["Pfid"]);
            }

            NxPlatformEO.PfName = this.txtPfname.Text.Trim();
            NxPlatformEO.PfText1 = this.txtPfname_en.Text.Trim();//平台的英文名称
            NxPlatformEO.PfState = this.rblState.SelectedValue;
            if (Regex.IsMatch(this.txtPfsort.Text.Trim(), "^[0-9]*$"))
            {
                NxPlatformEO.PfSort = Convert.ToInt32(this.txtPfsort.Text.Trim());
            }
            else
            {
                this.divAlert.Visible = true;
                this.lblAlert.Text = Resources.Resource.Platform_ordering_must_be_numeric;//"平台排序必须为数字";
                CloseDivImplementation();
                return;
            }

            //创建平台信息
            if (Request.QueryString["State"] == "A")
            {
                //判断平台名称是否存在
                if (this.CheckPlatformName() == false)
                {
                    //Jswork.Alert("平台名称 " + this.txtPfname.Text.Trim() + " 已存在", this.Page);

                    this.divAlert.Visible = true;
                    this.lblAlert.Text = Resources.Resource.Platfor_mname + this.txtPfname.Text.Trim() + Resources.Resource.Already_exist;
                    CloseDivImplementation();
                    return;
                }

                NxPlatformEO.PfId = GetBigGuid();
                string ImgName = GetBigGuid();
                string waterImgName = "";
                if (this.FileUpload1.HasFile)
                {
                    ImgName = upFile.UpLoadImage(FileUpload1, ImgName, this.Page, out waterImgName, "../Images/Platform/");
                }
                else
                {
                    waterImgName = "noimg.jpg";
                    ImgName = "noimg.jpg";
                }
                NxPlatformEO.PfImgUrl = "../Images/Platform/" + ImgName;
                NxPlatformEO.PfDel = "0";
                NxPlatformEO.PfAddUser = GetUserID();
                NxPlatformEO.PfAddTime = DateTime.Now;
                NxPlatformEO.PfNewEndTime = DateTime.Now;
                NxPlatformEO.PfImgWaterUrl = "../Images/Platform/" + ImgName;

                if (PfManage.AddPlatform(NxPlatformEO) > 0)
                {
                    //插入操作日志
                    InsertLog(Resources.Resource.Create_platform_information, string.Format("Platformname:{0},id:{1}", NxPlatformEO.PfName, NxPlatformEO.PfId), 13, GetPlatformIdByValue(1));
                    CloseDivImplementation();
                    Jswork.Alert(Resources.Resource.Platform_information_to_create_success, "PlatformList.aspx");
                }
                else
                {
                    //Jswork.Alert("平台信息创建失败", this.Page);
                    this.divAlert.Visible = true;
                    this.lblAlert.Text = Resources.Resource.Platform_information_creation_failed; //"平台信息创建失败";
                }
            }

            //修改平台信息
            if (Request.QueryString["State"] == "U")
            {
                //修改时判断平台名称是否存在
                if (this.hfPfName.Value != this.txtPfname.Text.Trim())
                {
                    //判断平台名称是否存在
                    if (this.CheckPlatformName() == false)
                    {
                        //Jswork.Alert("平台名称 " + this.txtPfname.Text.Trim() + " 已存在", this.Page);

                        this.divAlert.Visible = true;
                        this.lblAlert.Text = Resources.Resource.Platfor_mname + this.txtPfname.Text.Trim() + Resources.Resource.Already_exist;
                        CloseDivImplementation();
                        return;
                    }
                }

                if (this.FileUpload1.Visible == true && this.FileUpload1.HasFile)
                {
                    string waterImgName = "";
                    string ImgName = GetBigGuid();
                    ImgName = upFile.UpLoadImage(FileUpload1, ImgName, this.Page, out waterImgName, "../Images/Platform/");
                    NxPlatformEO.PfImgWaterUrl = "../Images/Platform/" + waterImgName;
                    NxPlatformEO.PfImgUrl = "../Images/Platform/" + ImgName;
                }

                if (PfManage.EditPlatform(NxPlatformEO) > 0)
                {
                    //插入操作日志
                    InsertLog(Resources.Resource.Modify_platform_information, string.Format("Platformname:{0},id:{1}", NxPlatformEO.PfName, NxPlatformEO.PfId), 14, GetPlatformIdByValue(1));
                    CloseDivImplementation();
                    Jswork.Alert(Resources.Resource.Successful_platform_information_modification, "PlatformList.aspx");

                }
                else
                {
                    this.divAlert.Visible = true;
                    this.lblAlert.Text = Resources.Resource.Platform_information_modification_failed;//"平台信息修改失败";
                }
            }
            CloseDivImplementation();
        }

        /// <summary>
        /// 返回
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("PlatformList.aspx");
        }

        /// <summary>
        /// 上传图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnUpload_Click(object sender, EventArgs e)
        {
            this.FileUpload1.Visible = true;
            this.btnUpload.Visible = false;
            this.btnCancelUpload.Visible = true;
            this.imgUrl.Visible = false;
        }

        /// <summary>
        /// 取消上传
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnCancelUpload_Click(object sender, EventArgs e)
        {
            this.FileUpload1.Visible = false;
            this.btnUpload.Visible = true;
            this.btnCancelUpload.Visible = false;
            if (Request.QueryString["State"] == "U")
            {
                this.imgUrl.Visible = true;
            }
        }

        /// <summary>
        /// 判断平台名称是否存在
        /// </summary>
        /// <returns></returns>
        private bool CheckPlatformName()
        {
            //if (PfManage.GetTable(string.Format(" Pf_name = '{0}' AND Pf_name = 0", this.txtPfname.Text.Trim())).Rows.Count > 0)
            IList<MySqlParameter> parm = new List<MySqlParameter>();
            StringBuilder strWhere = new StringBuilder();
            strWhere.Append("  Pf_name =@Pf_name AND Pf_name = 0 ");
            parm.Add(new MySqlParameter("@Pf_name", this.txtPfname.Text.Trim()));
            if (PfManage.GetTable(strWhere.ToString(), parm).Rows.Count > 0)
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
                            this.divAlert.Visible = true;
                            this.lblAlert.Text = Resources.Resource.Please_enter_the_required;//"请输入必填项";
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