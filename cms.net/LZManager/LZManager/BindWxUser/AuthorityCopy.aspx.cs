using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LZManager.BLL.Common;
using LZManager.DAL;
using LZManager.BLL;
using System.Web.Script.Serialization;
using LZManager.Utility;
using TinyFx.Net.Json.Linq;
using TinyFx.Net.Json;
using System.Text;
using System.Configuration;

namespace LZManager.BindWxUser
{
    public partial class AuthorityCopy : BasePage
    {
        WxUserManage wxUserManage = new WxUserManage();
        private string serverUrl = ConfigurationManager.AppSettings["ServerUrl"].ToString();
        private string tarnsferids = "";
        private string openids = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            //GetAuthorityUrl(this.Page, "Users/UsersList.aspx", 1);
            if (!IsPostBack)
            {
                tarnsferids = Request.QueryString["tranferids"];
                Loads();
            }
        }

        /// <summary>
        /// 加载
        /// </summary>
        private void Loads()
        {
            string names = Request.QueryString["traname"];
            if (string.IsNullOrEmpty(tarnsferids))
            {
                this.lblUser.Text = "ids error";//显示用户账号
            }
            else
            {
                this.lblUser.Text = names;//显示用户账号
            }
            //UsersEO usersEO = new UsersEO();
            //usersEO = userManage.GetUserByPK(Request.QueryString["Urid"]);
            //if (!string.IsNullOrEmpty(usersEO.UrId))
            //{
            //    this.lblUser.Text = usersEO.UrLoginName;//显示用户账号
            //}
        }

        /// <summary>
        /// 确定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOK_Click(object sender, EventArgs e)
        {
            #region 验证表单合法性
            if (this.CheckForms() == false)
            {
                CloseDivImplementation();
                return;
            }
            tarnsferids = Request.QueryString["tranferids"];
            openids = Request.QueryString["openids"];

            string[] oids = openids.Split(',');
            string[] ids = tarnsferids.Split(',');

            string toUserId = this.txtToUser.Text.Trim();
            int ret = 0;
            for (int i = 0; i < ids.Length; i++)
            {
                string curId = ids[i];
                if (!string.IsNullOrEmpty(curId))
                {
                    ret = wxUserManage.PutWxDuidByPK(curId, toUserId);
                }

            }
            this.div1.Visible = true;
            if (ret > 0)
            {
                //var recharData = { "action": "IDIP_DO_BAND_MORE_DAILI_REQ", "unionIdArray": ["jjjjsdsd:11102", "jjsdsddsd:2222", "jjsdfasdsd:33333", "asdfasdfw:44444", ] };
                StringBuilder to_json = new StringBuilder();
                to_json.Append("[");
                for (int i = 0; i < ids.Length; i++)
                {
                    string curId = ids[i];
                    if (!string.IsNullOrEmpty(curId)) 
                    {
                        to_json.Append("\"");
                        to_json.Append(oids[i]);
                        to_json.Append(":");
                        to_json.Append(curId);
                        to_json.Append("\"");
                        to_json.Append(",");
                    }
                }
                to_json.Append("]");
                Dictionary<string, string> dic = new Dictionary<string, string>();
                dic["action"] = "IDIP_DO_BAND_MORE_DAILI_REQ";
                dic["unionIdArray"] = to_json.ToString();//"["jjjjsdsd:11102", "jjsdsddsd:2222", "jjsdfasdsd:33333", "asdfasdfw:44444", ]";
                string json = new JavaScriptSerializer().Serialize(dic);
                string responseStr = HttpClientUlity.PostJsonData(serverUrl, json);

                JObject jo = (JObject)JsonConvert.DeserializeObject(responseStr);
                this.Label2.Text = "转移成功";
            }
            else
            {
                this.Label2.Text = "转移失败";
            }
            // new UsersMO().GetByUrLoginName()

            //if (new UsersMO().GetByUrLoginName(txtToUser.Text.Trim()).Count() > 0)
            //{
            //    Label1.Text = Resources.Resource.verification_successful;
            //    //"验证成功！";
            //}
            //else
            //{
            //    Label1.Text = Resources.Resource.usernotexist;
            //    //"用户不存在！";
            //    return;
            //}
            #endregion

            /*
            string _eoid = "";
            string _eomid = "";

            foreach (UsersEO _eos in new UsersMO().GetByUrLoginName(lblUser.Text.Trim())) // 被复制ID
            {
                _eoid = _eos.UrId;
            }
            foreach (UsersEO _eoss in new UsersMO().GetByUrLoginName(txtToUser.Text.Trim())) // 目标ID
            {
                _eomid = _eoss.UrId;
            }


            string result = "";
            int winnum = 0; // 成功个数 
            int losenum = 0; // 失败个数

            foreach (RoleuserEO _ruEO in new RoleuserMO().GetByUrId(_eoid)) // 循环 目标ID 拥有角色
            {
                RoleuserEO _fzeo = new RoleuserEO();
                _fzeo.UrId = _eomid;
                _fzeo.RlId = _ruEO.RlId;
                _fzeo.RuAddUser = GetUserID();
                _fzeo.RuAddTime = DateTime.Now;

                if (new RoleuserMO().GetByPK(_fzeo.UrId, _fzeo.RlId) == null) // 不存在添加 存在不变
                {
                    if (new RoleuserMO().Add(_fzeo) > 0) // 添加目标Id成功
                    {
                        result += GetDisPlayName(_fzeo) + Resources.Resource.Tip_SuscessCopy;//（成功）：复制权限：
                        if (rdoType.Text == "1") // 转移
                        {
                            new RoleuserMO().RemoveByPK(_eoid, _fzeo.RlId); // 删除原有角色
                            result += "id:" + _eoid + ",roleid:" + _fzeo.RlId + Resources.Resource.tip_delete_success;//删除成功
                        }
                        winnum++;
                    }
                    else //  失败
                    {
                        result += GetDisPlayName(_fzeo) + Resources.Resource.Tip_FaileCopy;//（失败）：复制权限：
                        losenum++;
                    }
                }
                else
                {
                    if (rdoType.Text == "1") // 转移
                    {
                        new RoleuserMO().RemoveByPK(_eoid, _fzeo.RlId); // 删除原有角色
                        result += "id:" + _eoid + ",roleid:" + _fzeo.RlId + Resources.Resource.tip_delete_success;
                            //"删除成功";
                    }
                }
            }

            if (rdoType.Text == "1") // 转移
            {
                userManage.EditStateByPk(_eoid, "1"); // 将用户改为停用
            }

            this.div1.Visible = true;
            //this.Label2.Text = result;
            this.Label2.Text = "复制或转移成功";
            CloseDivImplementation();
            InsertLog(rdoType.Text == "1" ? Resources.Resource.transfer_authority : Resources.Resource.copy_authority, Resources.Resource.tip_content + result, -7, GetPlatformIdByValue(1));
             */
        }

        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("WxUsersList.aspx");
            CloseDivImplementation();
        }

        /// <summary>
        /// 验证
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btn_Click(object sender, EventArgs e)
        {
            /*
            #region 验证表单合法性
            if (this.CheckForms() == false)
            {
                CloseDivImplementation();
                return;
            }
            #endregion

            if (new UsersMO().GetByUrLoginName(txtToUser.Text.Trim()).Count() > 0)
            {
                Label1.Text = Resources.Resource.verification_successful;
                    
                    //"验证成功！";
            }
            else
            {
                Label1.Text = Resources.Resource.usernotexist;
                    //"用户不存在！";
            }
             * */
            CloseDivImplementation();

        }

        /// <summary>
        /// 验证页面表单合理性
        /// </summary>
        /// <returns></returns>
        private bool CheckForms()
        {
            bool flg = true;
            string strAlert = string.Empty;

            if (string.IsNullOrEmpty(this.txtToUser.Text.Trim()))
            {
                //Please_enter_a_user_account
                flg = false;
                strAlert = Resources.Resource.Please_enter_a_user_account;
                //"请输入用户账号";
                this.txtToUser.Focus();
            }
            if (this.txtToUser.Text.Trim() == this.lblUser.Text.Trim())
            {
                flg = false;
                strAlert = Resources.Resource.Tip_not_OptMyself;
                //"不能给自己账号中复制或转移";
                this.txtToUser.Focus();
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
            CloseDivImplementation();
            return flg;
        }
    }
}