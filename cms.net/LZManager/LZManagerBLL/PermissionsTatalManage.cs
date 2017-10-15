using System.Collections.Generic;
using LZManager.DAL;
using System.Data;
using System.Data.Common;

namespace LZManager.BLL
{
    public class PermissionsTatalManage
    {
        PermissionstatalMO ptMO = new PermissionstatalMO("LZBgAuthorityConn");

        /// <summary>
        /// 获取总功能信息
        /// </summary>
        /// <param name="ptId"></param>
        /// <returns></returns>
        public PermissionstatalEO GetPermissionsTatalByPK(string ptId)
        {
            return ptMO.GetByPK(ptId);
        }

        /// <summary>
        /// 创建总功能信息
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public int AddPermissionsTatal(PermissionstatalEO item)
        {
            return ptMO.Add(item);
        }

        /// <summary>
        /// 修改总功能信息
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public int EditPermissionsTatal(PermissionstatalEO item)
        {
            return ptMO.UpdatePermissionsTatal(item);
        }

        /// <summary>
        /// 查询总功能信息
        /// </summary>
        /// <returns></returns>
        public IEnumerable<PermissionstatalEO> GetAllPermissionsTatal()
        {
            return ptMO.GetAll();
        }

        /// <summary>
        /// 删除总功能信息
        /// </summary>
        /// <param name="set"></param>
        /// <param name="where"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        //public int DelPermissionsTatals(string set, string where, params object[] values)
        //{
        //    return ptMO.Put(set, where, null, values);
        //}

        public int DelPermissionsTatals(string set, string where, IEnumerable<DbParameter> values)
        {
            return ptMO.Put(set, where,  values,null);
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
            return ptMO.GetTable(where, -1, string.Empty,paras);
        }

        /// <summary>
        /// 根据条件查询数据
        /// </summary>
        /// <param name="where"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        //public IEnumerable<PermissionstatalEO> Get(string where, params object[] values)
        //{
        //    return ptMO.GetTopSort(where, -1, string.Empty, null, values);
        //}
        public IEnumerable<PermissionstatalEO> Get(string where,  IEnumerable<DbParameter> paras)
        {
            return ptMO.GetTopSort(where, paras,-1, string.Empty, null);
        }

        //public IEnumerable<PermissionstatalEO> Gets(string where, params object[] values)
        //{
        //    return ptMO.Gets(where, -1, string.Empty, null, values);
        //}
        public IEnumerable<PermissionstatalEO> Gets(string where, IEnumerable<DbParameter> values)
        {
            return ptMO.Gets(where, -1, string.Empty, null, values);
        }

        public virtual DataTable GetList(string where, IEnumerable<DbParameter> paras)
        {
            return ptMO.GetList(where, -1, string.Empty,paras);
        }
    }
}
