using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LZManager.BLL.Common;
using LZManager.DAL;

namespace LZManager.Framework
{
    public partial class Header : BasePage
    {
        public string strUrid = string.Empty;
        private string plantname
        {
            get
            {
                try
                {
                    return Request.QueryString["Platform"].ToString();
                }
                catch
                {
                    return "未知";
                }
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
           try
            {
               UsersEO usersEO = GetUser();
               strUrid = usersEO.UrId;
               lblUserName.Text = usersEO.UrName; // 姓名
               lblDepartment.Text = usersEO.UrDepartment; // 部门
               lblPlant.Text = "【" + plantname + "】";
               // 获取用户角色
               foreach (string[] a in GetUserLeaveByString())
               {
                   if (a[1].ToString() == usersEO.UrText1)
                   {
                       lblLeave.Text = a[0].ToString();
                       break;
                   }
               }
           }
            catch
            { }
        }        
    }
}