using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using LZManager.BLL;
using LZManager.DAL;
using MySql.Data.MySqlClient;
using System.Text;

namespace LZManager.Role
{
    /// <summary>
    /// RoleModuleParm 的摘要说明
    /// </summary>
    public class RoleModuleParm : IHttpHandler, IReadOnlySessionState
    {
        private string _parentID = null;

        /// <summary>
        /// 权限ID
        /// </summary>
        public string ParmID
        {
            get
            {
                if (_parentID == null)
                    _parentID = HttpContext.Current.Request.QueryString["ParmID"].Trim();
                return _parentID;
            }
        }

        private string _roleID = null;

        /// <summary>
        /// 角色ID
        /// </summary>
        public string RoleID
        {
            get
            {
                if (_roleID == null)
                    _roleID = HttpContext.Current.Request.QueryString["RoleID"].Trim();
                return _roleID;
            }
        }

        private string _parmType;

        /// <summary>
        /// 是否是全选(1)为全选
        /// </summary>
        public string ParmType
        {
            get
            {
                if (_parmType == null)
                    _parmType = HttpContext.Current.Request.QueryString["ParmType"].Trim();
                return _parmType;
            }
        }

        private string _moduleID;

        /// <summary>
        /// 模块ID
        /// </summary>
        public string ModuleID
        {
            get
            {
                if (_moduleID == null)
                    _moduleID = HttpContext.Current.Request.QueryString["ModuleID"].Trim();
                return _moduleID;
            }
        }

        RoleModuleManage rmpbll = new RoleModuleManage();

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            //所有权限
            if (ParmType == "1")
            {
                string[] strParm = ParmID.Split('|');
                rmpbll.RemoveByPK("Rl_id='" + RoleID + "' and  Md_id='" + ModuleID + "'");
                foreach (string s in strParm)
                {
                    RolemoduleEO rmpmodel = new RolemoduleEO();
                    rmpmodel.RlId = RoleID;
                    rmpmodel.MdId = ModuleID;
                    rmpmodel.PtId = s;
                    rmpmodel.RmAddTime = DateTime.Now;
                    rmpbll.AddRoleModule(rmpmodel);
                }
            }
            else if (ParmType == "2") //添加一个权限
            {
                //if (rmpbll.Get("Rl_id='" + RoleID + "' and  Md_id='" + ModuleID + "' and Pt_id='" + ParmID + "'") != null)
                StringBuilder strWhereQ = new StringBuilder();
                strWhereQ.Append(" 1=1");
                IList<MySqlParameter> parmQ = new List<MySqlParameter>();
                strWhereQ.Append(" and Rl_id=@Rl_id and  Md_id=@Md_id and Pt_id=@Pt_id");
                parmQ.Add(new MySqlParameter("@Rl_id", RoleID));
                parmQ.Add(new MySqlParameter("@Md_id", ModuleID));
                parmQ.Add(new MySqlParameter("@Pt_id", ParmID));
                if (rmpbll.Get(strWhereQ.ToString(),parmQ) != null)
                {
                    RolemoduleEO rmpmodel = new RolemoduleEO();
                    rmpmodel.RlId = RoleID;
                    rmpmodel.MdId = ModuleID;
                    rmpmodel.PtId = ParmID;
                    rmpmodel.RmAddTime = DateTime.Now;
                    rmpbll.AddRoleModule(rmpmodel);
                }
            }
            else if (ParmType == "3")//删除一个权限
            {
                rmpbll.Remove("Rl_id='" + RoleID + "' and  Md_id='" + ModuleID + "' and Pt_id='" + ParmID + "'");
            }
            context.Response.Write("完成！");
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