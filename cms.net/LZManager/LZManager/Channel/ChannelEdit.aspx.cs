using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LZManager.BLL.Common;
using LZManager.BLL;
using LZManager.DAL;
using LZWebApp.BLL.Roulette;

namespace LZManager.Game
{
    public partial class ChannelEdit : BasePage
    {
        ChannelMO _mo = new ChannelMO();

        protected void Page_Load(object sender, EventArgs e)
        {
            GetAuthorityUrl(this.Page, "Channel/ChannelList.aspx", 1);

            if (!IsPostBack)
            {
                if (Request.QueryString["State"] != null)
                {
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
            ChannelMO _mo = new ChannelMO();

            ChannelEO _eo = _mo.GetByPK(Request.QueryString["Chid"].ToString());
            if (!string.IsNullOrEmpty(_eo.CnName))
            {
                this.txtChannelName.Text = _eo.CnName;
                this.txtChannelId.Text = _eo.CnChannelId;
                this.txtDescription.Text = _eo.CnDescription;
                this.rblState.SelectedValue = _eo.CnState;
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


            ChannelEO _eo = new ChannelEO();
            _eo.CnName = txtChannelName.Text;
            _eo.CnChannelId = txtChannelId.Text;
            _eo.CnDel = "0";
            _eo.CnDescription = txtDescription.Text;
            _eo.CnState = rblState.Text;
            _eo.UrId = GetUserID();
            _eo.CnAddTime = DateTime.Now;


            //创建平台信息
            if (Request.QueryString["State"] == "A")
            {

                //判断平台名称是否存在
                if (this.CheckChannelID() == false)
                {
                    this.divAlert.Visible = true;
                    this.lblAlert.Text = Resources.Resource.Channe_lID + this.txtChannelId.Text.Trim() + Resources.Resource.Already_exist;
                    CloseDivImplementation();
                    return;
                }
                _eo.CnId = GetBigGuid();

                if (_mo.Add(_eo) > 0)
                {
                    //插入操作日志
                    InsertLog(Resources.Resource.Create_channel_information, string.Format("Cn_name:{0},Cn_channelId:{1}", _eo.CnName, _eo.CnId), -6, GetPlatformIdByValue(1));
                    CloseDivImplementation();
                    Jswork.Alert(Resources.Resource.Channel_information_to_create_success, "ChannelList.aspx");
                }
                else
                {
                    this.divAlert.Visible = true;
                    this.lblAlert.Text = Resources.Resource.Create_channel_information_creation_failed;//"创建渠信息创建失败";
                }
            }

            //修改平台信息
            if (Request.QueryString["State"] == "U")
            {

                //判断平台名称是否存在
                if (this.CheckChannelID() == false)
                {
                    //Jswork.Alert("平台名称 " + this.txtPfname.Text.Trim() + " 已存在", this.Page);

                    this.divAlert.Visible = true;
                    this.lblAlert.Text = Resources.Resource.Channe_lID + this.txtChannelId.Text.Trim() + Resources.Resource.Already_exist;
                    CloseDivImplementation();
                    return;
                }

                _eo.CnId = Request.QueryString["Chid"].ToString();
                if (_mo.PutById(_eo) > 0)
                {
                    //插入操作日志
                    InsertLog(Resources.Resource.Modify_channel_information, string.Format("CnId:{0},CnChannelId:{1}", _eo.CnId, _eo.CnChannelId), 5008, GetPlatformIdByValue(1));
                    CloseDivImplementation();
                    Jswork.Alert(Resources.Resource.Channel_information_to_modify_the_success_of, "ChannelList.aspx");

                }
                else
                {
                    this.divAlert.Visible = true;
                    this.lblAlert.Text = Resources.Resource.Channel_information_modification_failed; //"渠道信息修改失败";
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
            Response.Redirect("ChannelList.aspx");
        }


        /// <summary>
        /// 判断平台名称是否存在
        /// </summary>
        /// <returns></returns>
        private bool CheckChannelID()
        {
            if (_mo.Get(" Cn_channelId = @Cn_channelId  AND Cn_Del = 0", this.txtChannelId.Text.Trim()).Count() > 0)
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