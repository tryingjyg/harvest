using System.Collections.Generic;
using LZManager.DAL;
using System.Data;
using System.Data.Common;

namespace LZManager.BLL
{
    public class PermissionsManage
    {
        PermissionsMO pmMO = new PermissionsMO("LZBgAuthorityConn");

        /// <summary>
        /// 获取总功能信息
        /// </summary>
        /// <param name="ptId"></param>
        /// <returns></returns>
        public PermissionsEO GetPermissionsByPK(string ptId)
        {
            return pmMO.GetByPK(ptId);
        }

        /// <summary>
        /// 创建总功能信息
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public int AddPermissions(PermissionsEO item)
        {
            return pmMO.Add(item);
        }

        /// <summary>
        /// 修改总功能信息
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public int EditPermissions(PermissionsEO item)
        {
            return pmMO.UpdatePermissions(item);
        }

        /// <summary>
        /// 查询总功能信息
        /// </summary>
        /// <returns></returns>
        public IEnumerable<PermissionsEO> GetAllPermissions()
        {
            return pmMO.GetAll();
        }

        /// <summary>
        /// 删除总功能信息
        /// </summary>
        /// <param name="set"></param>
        /// <param name="where"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        //public int DelPermissionss(string set, string where, params object[] values)
        //{
        //    return pmMO.Put(set, where, null, values);
        //}
        public int DelPermissionss(string set, string where, IEnumerable<DbParameter> values)
        {
            return pmMO.Put(set, where, values,null);
        }

        /// <summary>
        /// 根据条件查询数据
        /// </summary>
        /// <param name="where"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public IEnumerable<PermissionsEO> Get(string where, params object[] values)
        {
            return pmMO.GetTopSort(where, -1, string.Empty, null, values);
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
            return pmMO.GetTable(where, -1, string.Empty,paras);
        }

        public virtual DataTable GetList(string where, IEnumerable<DbParameter> paras)
        {
            return pmMO.GetList(where, -1, string.Empty,paras);
        }
    }
}
