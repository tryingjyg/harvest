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

namespace LZManager.MallGoods
{
    public partial class MallGoodsEdit : BasePage
    {
        UserManage userManage = new UserManage();
        MallGoodManage goodManage = new MallGoodManage();

        protected void Page_Load(object sender, EventArgs e)
        {
            //GetAuthorityUrl(this.Page, "WptMall/MallTGoodsEdit.aspx", 1);

            if (!IsPostBack)
            {
                if (Request.QueryString["State"] != null)
                {
                    //更新用户
                    if (Request.QueryString["State"] == "U")
                    {
                        this.LoadGoods();
                    }
                }
            }
        }

        /// <summary>
        /// 加载用户信息
        /// </summary>
        private void LoadGoods()
        {
            MalltgoodsEO goodEO = new MalltgoodsEO();
            int leave = GetUserLeave(); // 获取用户级别
            goodEO = goodManage.GetGoodsByPK(Request.QueryString["Urid"]);
            if (!string.IsNullOrEmpty(goodEO.MgId))
            {
                this.txtGoodNo.Text = goodEO.MgNo;
                this.txtGoodName.Text = goodEO.MgName;
                this.txtGoodPrice.Text = goodEO.MgPrice;
                this.txtGoodDiamondNum.Text = goodEO.MgDiamondsnum;
                this.txtPresentNum.Text = goodEO.MgPresentnum;
                this.txtRate.Text = goodEO.MgRate;
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

                #region 初始化数据
                MalltgoodsEO goodsEO = new MalltgoodsEO();

                //if (Request.QueryString["State"] == "U")
                //{
                //    usersEO = userManage.GetUserByPK(Request.QueryString["Urid"]);
                //    if (cbk_password.Checked)
                //    {
                //        usersEO.UrPassWord = MdUtil.ToMd5Hash(this.txtPass.Text.Trim());//密码MD5加密
                //    }
                //}

                goodsEO.MgNo = this.txtGoodNo.Text.Trim();
                goodsEO.MgName = this.txtGoodName.Text.Trim();
                goodsEO.MgPrice = this.txtGoodPrice.Text.Trim();
                goodsEO.MgDiamondsnum = this.txtGoodDiamondNum.Text.Trim();
                goodsEO.MgPresentnum = this.txtPresentNum.Text.Trim();
                goodsEO.MgRate = this.txtRate.Text.Trim();

                string jsonStr = "{ \"MgNo\":" + "\"" + goodsEO.MgNo + "\","
                                    + "\"MgName\":" + "\"" + goodsEO.MgName + "\","
                                    + "\"MgPrice\":" + "\"" + goodsEO.MgPrice + "\","
                                    + "\"MgDiamondsnum\":" + "\"" + goodsEO.MgDiamondsnum + "\","
                                    + "\"MgPresentnum\":" + "\"" + goodsEO.MgPresentnum + "\","
                                    + "\"MgRate\":" + "\"" + goodsEO.MgRate + "\"}";

                goodsEO.MgJsondata = jsonStr;
                #endregion

                #region 创建商品
                if (Request.QueryString["State"] == "A")
                {
                    //用户信息
                    goodsEO.MgId = GetBigGuid();
                    goodsEO.MgAdddTime = DateTime.Now;

                    if (goodManage.AddGood(goodsEO) > 0)
                    {
                        //插入操作日志
                        //InsertLog(Resources.Resource.Create_user, string.Format("username:{0},id:{1}", usersEO.UrName, usersEO.UrId), 4, GetPlatformIdByValue(1));
                        CloseDivImplementation();
                        Jswork.Alert(Resources.Resource.goods_add_suc, "MallTGoodsList.aspx");
                    }
                    else
                    {
                        //Jswork.Alert("用户信息创建失败", this.Page);
                        this.divAlert.Visible = true;
                        this.lblAlert.Text = Resources.Resource.goods_add_fail;//"信息创建失败";
                    }
                }
                #endregion

                #region 修改用户
                if (Request.QueryString["State"] == "U")
                {
                    goodsEO.MgId = Request.QueryString["Urid"];
                    goodsEO.MgAdddTime = DateTime.Now;
                    if (goodManage.EditGood(goodsEO) > 0)
                    {
                        //插入操作日志
                        //InsertLog(Resources.Resource.Modify_user, string.Format("username:{0},id:{1}", usersEO.UrName, usersEO.UrId), 2, GetPlatformIdByValue(1));
                        CloseDivImplementation();
                        Jswork.Alert(Resources.Resource.goods_edit_suc, "MallTGoodsList.aspx");
                    }
                    else
                    {
                        //Jswork.Alert("用户信息修改失败", this.Page);
                        this.divAlert.Visible = true;
                        this.lblAlert.Text = Resources.Resource.goods_edit_fail;//"信息修改失败";
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
            Response.Redirect("MallTGoodsList.aspx");
        }


        /// <summary>
        /// 验证页面表单合理性
        /// </summary>
        /// <returns></returns>
        private bool CheckForms()
        {
            bool flg = true;
            string strAlert = string.Empty;

            if (string.IsNullOrEmpty(this.txtGoodNo.Text.Trim()))
            {
                flg = false;
                strAlert = Resources.Resource.Please_enter_a_user_account;// "请输入用户账号";
                this.txtGoodNo.Focus();
            }
            else if (string.IsNullOrEmpty(this.txtGoodName.Text.Trim()))
            {
                flg = false;
                strAlert = Resources.Resource.Please_enter_a_user_password;// "请输入用户密码";
                this.txtGoodName.Focus();
            }
            else if (string.IsNullOrEmpty(this.txtGoodPrice.Text.Trim()))
            {
                flg = false;
                strAlert = Resources.Resource.Please_enter_user_name;// "请输入用户姓名";
                this.txtGoodPrice.Focus();
            }
            else if (string.IsNullOrEmpty(this.txtGoodDiamondNum.Text.Trim()))
            {
                flg = false;
                strAlert = Resources.Resource.Please_select_user_department;//"请选择用户部门";
                this.txtGoodDiamondNum.Focus();
            }
            else if (string.IsNullOrEmpty(this.txtPresentNum.Text.Trim()))
            {
                flg = false;
                strAlert = Resources.Resource.Please_select_a_character_name;// "请选择角色名";
                this.txtPresentNum.Focus();
            }
            else if (string.IsNullOrEmpty(this.txtRate.Text.Trim()))
            {
                flg = false;
                strAlert = Resources.Resource.Please_select_a_character_name;// "请选择角色名";
                this.txtRate.Focus();
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
    }
}