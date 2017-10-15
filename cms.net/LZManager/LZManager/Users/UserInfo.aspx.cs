using LZManager.BLL;
using LZManager.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LZManager.Users
{
    public partial class UserInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string curUserId = Session["username"].ToString();
                if (!string.IsNullOrEmpty(curUserId))
                {
                    initUserInfo(curUserId);
                }
            }
            
        }

        private void initUserInfo(string userId)
        {
            UserManage userManage = new UserManage();
            UsersEO usersEO = userManage.GetUser(userId);
            if(usersEO != null)
            {
                this.txtLoginName.Text = usersEO.UrLoginName;
                this.txtName.Text = usersEO.UrName;
                this.txtParent.Text = usersEO.UrParent;
                this.txtPhone.Text = usersEO.UrPhone;
                this.txtArea.Text = usersEO.UrZone;
                this.txtContactPeople.Text = usersEO.UrPeople;
                this.txtContact.Text = usersEO.UrContact;
                this.txtGameId.Text = usersEO.UrGameId;
                this.lblDiamond.Text = usersEO.UrDiamondNum;
                this.lblMoney.Text = usersEO.UrMoney;
                this.txtBankName.Text = usersEO.UrBankName;
                this.txtBank.Text = usersEO.UrBank;
                this.txtBankNo.Text = usersEO.UrBankNo;
                this.txtPercent.Text = string.Format("{0}%", usersEO.UrPercent);
                this.txtIntrdouce.Text = usersEO.UrIntroducer;
            }
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            //Response.Redirect("RoleEdit.aspx?State=A&Action=0");
        }

        protected void btnChangePwd_Click(object sender, EventArgs e)
        {
            Response.Redirect("UsersPasswordEdit.aspx");
        }
    }
}