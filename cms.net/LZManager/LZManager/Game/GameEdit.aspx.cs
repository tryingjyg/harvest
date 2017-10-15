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
using System.Data;

namespace LZManager.Game
{
    public partial class GameEdit : BasePage
    {
        GameMO _mo = new GameMO();
        GameMessage _message = new GameMessage();
        ChannelMO channelMO = new ChannelMO();

        protected void Page_Load(object sender, EventArgs e)
        {
            GetAuthorityUrl(this.Page, "Game/GameList.aspx", 1);

            if (!IsPostBack)
            {
                if (Request.QueryString["State"] != null)
                {
                    BindChannel(); //  绑定渠道
                    //更新平台信息
                    if (Request.QueryString["State"] == "U")
                    {
                        this.LoadGame();
                    }
                }
            }
        }

        /// <summary>
        /// 绑定渠道
        /// </summary>
        private void BindChannel()
        {
            cblChannel.DataSource = channelMO.Get("Cn_Del = 0 and Cn_state =0");
            cblChannel.DataTextField = "CnName";
            cblChannel.DataValueField = "CnId";
            cblChannel.DataBind();
        }

        /// <summary>
        /// 加载平台信息
        /// </summary>
        private void LoadGame()
        {
            GameMO _mo = new GameMO();

            GameEO _eo = _mo.Get(" Gm_gameId = @Gm_gameId ", Request.QueryString["Gm_gameId"].ToString()).Last();
            if (!string.IsNullOrEmpty(_eo.GmId))
            {
                this.txtGameName.Text = _eo.GmName;
                this.txtGaameId.Text = _eo.GmGameId;
                this.txtDescription.Text = _eo.GmDescription;
                this.rblState.SelectedValue = _eo.GmState;

                foreach (DataRow dr in _message.GetCannelListByGameId(Request.QueryString["Gm_gameId"].ToString()).Rows)
                {
                    for (int i = 0; i < cblChannel.Items.Count; i++) //  循环选中渠道的值
                    {
                        if (cblChannel.Items[i].Value == dr["Cn_id"].ToString())
                            cblChannel.Items[i].Selected = true;

                    }
                }
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


            GameEO _eo = new GameEO();
            _eo.GmName = txtGameName.Text;
            _eo.GmGameId = txtGaameId.Text;
            _eo.GmDel = "0";
            _eo.GmDescription = txtDescription.Text;
            _eo.GmState = rblState.Text;
            _eo.UrId = GetUserID();
            _eo.GmAdddTime = DateTime.Now;

            if (Request.QueryString["State"] == "A")
            {
                Add(_eo);
            }
            if (Request.QueryString["State"] == "U")
            {
                Edit(_eo);
            }


            CloseDivImplementation();
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="_eo"></param>
        private void Add(GameEO _eo)
        {
            string messagetrue = "";
            string messagefalse = "";

            //创建平台信息


            //判断平台名称是否存在
            if (this.CheckGameID() == false)
            {
                this.divAlert.Visible = true;
                this.lblAlert.Text = Resources.Resource.Gam_eID + this.txtGaameId.Text.Trim() + Resources.Resource.Already_exist;
                CloseDivImplementation();
                return;
            }

            for (int i = 0; i < cblChannel.Items.Count; i++) //  循环选中渠道的值
            {
                if (cblChannel.Items[i].Selected)
                {
                    _eo.CnChannelId = cblChannel.Items[i].Value;
                    _eo.GmId = GetBigGuid();

                    bool result = true;
                    foreach (GameEO eoss in _mo.Get(" Gm_gameId=@Gm_gameId and Cn_channelId=@Cn_channelId ", _eo.GmGameId, _eo.CnChannelId))
                    {
                        _eo.GmId = eoss.GmId;
                        if (_mo.PutById(_eo) > 0)
                        {
                            messagetrue += cblChannel.Items[i].Value + ";";
                            //插入操作日志
                        }
                        else
                        {
                            messagefalse += cblChannel.Items[i].Value + ";";
                        }
                        result = false;
                    }
                    if (result) // 如果不存在
                    {
                        if (_mo.Add(_eo) > 0)
                        {
                            messagetrue += cblChannel.Items[i].Value + ";";
                        }
                        else
                        {
                            messagefalse += cblChannel.Items[i].Value + ";";
                        }
                    }
                }
            }

            InsertLog(Resources.Resource.Create_game_information, string.Format("GmGameId:{0},创建{1}成功,创建{2}失败", _eo.GmGameId, messagetrue, messagefalse), 5009, GetPlatformIdByValue(1));
            CloseDivImplementation();
            if (messagefalse == "")
            {
                Jswork.Alert(Resources.Resource.Create_game_information_success, "GameList.aspx");
            }
            else
            {
                Jswork.Alert(Resources.Resource.Create_a_game_channel + messagetrue + Resources.Resource.Success_create + messagefalse + Resources.Resource.fail, "GameList.aspx");
            }


        }

        /// <summary>
        /// 修改
        /// </summary>
        private void Edit(GameEO _eo)
        {
            string messagetrue = "";
            string messagefalse = "";
            //修改平台信息


            //判断平台名称是否存在
            if (this.CheckGameID() == false)
            {
                this.divAlert.Visible = true;
                this.lblAlert.Text = Resources.Resource.Gam_eID + this.txtGaameId.Text.Trim() + Resources.Resource.Already_exist;
                CloseDivImplementation();
                return;
            }


            if (Request.QueryString["Gm_gameId"].ToString() != txtGaameId.Text)
            {
                foreach (GameEO eos in _mo.GetByGmGameId(Request.QueryString["Gm_gameId"].ToString()))
                {
                    string id = eos.GmId;
                    _mo.PutGmGameIdByPK(id, txtGaameId.Text);
                }
            }

            for (int i = 0; i < cblChannel.Items.Count; i++) //  循环选中渠道的值
            {
                if (cblChannel.Items[i].Selected)
                {
                    _eo.CnChannelId = cblChannel.Items[i].Value;
                    bool result = true;
                    foreach (GameEO eoss in _mo.Get(" Gm_gameId=@Gm_gameId and Cn_channelId=@Cn_channelId ", _eo.GmGameId, _eo.CnChannelId))
                    {
                        _eo.GmId = eoss.GmId;
                        if (_mo.PutById(_eo) > 0)
                        {
                            messagetrue += cblChannel.Items[i].Value + ";";
                            //插入操作日志
                        }
                        else
                        {
                            messagefalse += cblChannel.Items[i].Value + ";";
                        }
                        result = false;
                    }
                    if (result) // 如果不存在
                    {
                        _eo.GmId = GetBigGuid();
                        if (_mo.Add(_eo) > 0)
                        {
                            messagetrue += cblChannel.Items[i].Value + ";";
                        }
                        else
                        {
                            messagefalse += cblChannel.Items[i].Value + ";";
                        }
                    }

                }
                else // 没有选中
                {
                    _eo.CnChannelId = cblChannel.Items[i].Value;
                    foreach (GameEO eoss in _mo.Get(" Gm_gameId=@Gm_gameId and Cn_channelId=@Cn_channelId ", _eo.GmGameId, _eo.CnChannelId))
                    {
                        _mo.PutGmDelByPK(eoss.GmId, "1");
                    }
                }
            }
            InsertLog(Resources.Resource.Modify_game_info, string.Format("GmGameId:{0},创建{1}成功,创建{2}失败", _eo.GmGameId, messagetrue, messagefalse), 5010, GetPlatformIdByValue(1));
            CloseDivImplementation();
            if (messagefalse == "")
            {
                Jswork.Alert(Resources.Resource.Modify_game_information_successfully, "GameList.aspx");
            }
            else
            {
                Jswork.Alert(Resources.Resource.Modify_game_creation + messagetrue + Resources.Resource.Success_create + messagefalse + Resources.Resource.fail, "GameList.aspx");
            }
        }

        /// <summary>
        /// 返回
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("GameList.aspx");
        }

        /// <summary>
        /// 判断平台名称是否存在
        /// </summary>
        /// <returns></returns>
        private bool CheckGameID()
        {
            string gameid = "";
            try
            {
                gameid = Request.QueryString["Gm_gameId"].ToString();
            }
            catch
            {
                gameid = txtGaameId.Text;
            }

            if (txtGaameId.Text.Trim() == gameid)
            {
                return true;
            }
            //if (_mo.Get(string.Format(" Gm_gameId = '{0}' and Gm_del =0 ", txtGaameId.Text.Trim())).Count() > 0)
            if (_mo.Get(" Gm_gameId =@Gm_gameId and Gm_del =0 ", txtGaameId.Text.Trim()).Count() > 0)
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
                            this.lblAlert.Text = Resources.Resource.Please_enter_the_required;// "请输入必填项";
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