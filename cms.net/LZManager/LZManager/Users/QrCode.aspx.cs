using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LZManager.BLL.Common;
using LZManager.DAL;
using LZManager.BLL;

namespace LZManager.Users
{
    public partial class QrCode : BasePage
    {
        // userManage = new UserManage();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Loads();
                string imgScr = Request["imgSrc"];
                this.img.ImageUrl = imgScr;
                this.img.Visible = true;
            }
        }


        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("UsersList.aspx");
            CloseDivImplementation();
        }
    }
}