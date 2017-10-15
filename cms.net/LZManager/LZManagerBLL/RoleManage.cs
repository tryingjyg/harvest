using System.Collections.Generic;
using LZManager.DAL;
using System.Data;
using System.Data.Common;

namespace LZManager.BLL
{
    public class RoleManage
    {
        RoleMO roleMO = new RoleMO("LZBgAuthorityConn");

        /// <summary>
        /// 获取权限信息
        /// </summary>
        /// <param name="rlId"></param>
        /// <returns></returns>
        public RoleEO GetRoleByPK(string rlId)
        {
            return roleMO.GetByPK(rlId);
        }

        /// <summary>
        /// 创建权限
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public int AddRole(RoleEO item)
        {
            return roleMO.Add(item);            
        }

        /// <summary>
        /// 修改用户
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public int EditRole(RoleEO item)
        {
            return roleMO.UpdateRole(item);
        }

        /// <summary>
        /// 查询所有权限信息
        /// </summary>
        /// <returns></returns>
        public IEnumerable<RoleEO> GetAllRole()
        {
            return roleMO.GetAll();
        }

        /// <summary>
        /// 删除权限
        /// </summary>
        /// <param name="set"></param>
        /// <param name="where"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public int DelRoles(string set, string where, params object[] values)
        {
            return roleMO.Put(set, where, null, values);
        }
        public int DelRoles(string set, string where, IEnumerable<DbParameter> values)
        {
            return roleMO.Put(set, where, values,null);
        }

        /// <summary>
        /// 根据条件查询数据
        /// </summary>
        /// <param name="where"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        //public IEnumerable<RoleEO> Get(string where, params object[] values)
        //{
        //    return roleMO.GetTopSort(where, -1, "Rl_name", null, values);
        //}
        public IEnumerable<RoleEO> Get(string where, IEnumerable<DbParameter> values)
        {
            return roleMO.GetTopSort(where, values ,-1, "Rl_name",null);
        }

        /// <summary>
        /// 按自定义条件查询
        /// </summary>
        /// <param name = "where">自定义条件,where子句</param>
        /// <param name = "top">获取行数</param>
        /// <param name = "sort">排序表达式</param>
        /// <return>Table</return>
        public virtual DataTable GetTable(string where, IEnumerable<DbParameter> paras)
        {
            return roleMO.GetTable(where, -1, "Rl_name",paras);
        }

        public virtual DataTable GetList(string where, IEnumerable<DbParameter> paras)
        {
            return roleMO.GetList(where, -1, string.Empty, paras);
        }
    }
}
