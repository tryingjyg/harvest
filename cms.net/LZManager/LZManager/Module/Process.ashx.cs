using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using LZManager.BLL;
using LZManager.DAL;
using MySql.Data.MySqlClient;
using System.Text;

namespace LZManager.Module
{
    /// <summary>
    /// Process 的摘要说明
    /// </summary>
    public class Process : IHttpHandler, IReadOnlySessionState
    {
        ModuleManage mbll = new ModuleManage();
        ModulePermissionsManage mpbll = new ModulePermissionsManage();
        RoleModuleManage rmpbll = new RoleModuleManage();

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string ModuleID = context.Request.QueryString["ModuleID"].Trim();

            //if (mbll.GetTable("Md_parentid='" + ModuleID.Trim() + "' AND Md_deleteFlag =0").Rows.Count == 0)

            IList<MySqlParameter> parm = new List<MySqlParameter>();
            StringBuilder strWhere = new StringBuilder();
            strWhere.Append("  Md_parentid=@Md_parentid AND Md_deleteFlag =0");
            parm.Add(new MySqlParameter("@Md_parentid", ModuleID.Trim()));
            if (mbll.GetTable(strWhere.ToString(), parm).Rows.Count == 0)
            {
                //删除模块
                //mbll.DelModules(" Md_deleteFlag=1", " Md_id='" + ModuleID + "'");
                IList<MySqlParameter> parmD = new List<MySqlParameter>();
                StringBuilder strWhereD = new StringBuilder();
                strWhereD.Append(" Md_id=@ModuleID");
                parmD.Add(new MySqlParameter("@ModuleID", ModuleID));
                mbll.DelModules(" Md_deleteFlag=1", strWhereD.ToString(), parmD);
                //删除模块权限
                mpbll.RemoveByPK(ModuleID);
                //删除角色、模块、权限
                rmpbll.RemoveByPK(ModuleID);
                //返回删除完成
                context.Response.Write("0|" + ModuleID);
            }
            else
            {
                //返回请先删除下级模块！
                context.Response.Write("1|" + ModuleID);
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}