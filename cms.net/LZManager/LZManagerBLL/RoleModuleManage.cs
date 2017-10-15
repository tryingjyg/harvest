using System.Collections.Generic;
using LZManager.DAL;
using System.Data;
using System.Data.Common;

namespace LZManager.BLL
{
    public class RoleModuleManage
    {
        RolemoduleMO rlmdMO = new RolemoduleMO("LZBgAuthorityConn");

        /// <summary>
        /// 根据条件查询数据
        /// </summary>
        /// <param name="where"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public IEnumerable<RolemoduleEO> Get(string where, params object[] values)
        {
            return rlmdMO.GetTopSort(where, -1, string.Empty, null, values);
        }
        public IEnumerable<RolemoduleEO> Get(string where, IEnumerable<DbParameter> values)
        {
            return rlmdMO.GetTopSort(where, values, - 1, string.Empty, null);
        }

        /// <summary>
        /// 按主键删除
        /// </summary>
        /// <param name = "ptId">总功能id</param>
        /// <param name = "pmId">功能id</param>
        /// <param name="tm">事务管理对象</param>
        public virtual int RemoveByPK(string ptId)
        {
            return rlmdMO.RemoveByPK(ptId);
        }

        /// <summary>
        /// 创建信息
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public int AddRoleModule(RolemoduleEO item)
        {
            return rlmdMO.Add(item);
        }

        /// <summary>
		/// 删除指定条件的数据
		/// </summary>
		/// <param name = "where">自定义删除条件，where子句。如：id=1 and name='aaa'</param>
		/// <param name="tm">事务管理对象</param>
		/// <param name = "values">where子句中定义的参数值集合</param>
		/// <return>受影响的行数</return>
        public virtual int Remove(string where)
        {
            return rlmdMO.Remove(where);
        }

        /// <summary>
        /// 按自定义条件查询
        /// </summary>
        /// <param name = "where">自定义条件,where子句</param>
        /// <param name = "top">获取行数</param>
        /// <param name = "sort">排序表达式</param>
        /// <return>Table</return>
        public virtual DataTable GetTable(string where, IEnumerable<DbParameter> values)
        {
            return rlmdMO.GetTable(where, -1, string.Empty,values);
        }
    }
}
