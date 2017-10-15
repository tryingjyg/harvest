using System.Collections.Generic;
using LZManager.DAL;
using System.Data;
using System.Data.Common;

namespace LZManager.BLL
{
    public class PlatformManage
    {
        NxPlatformMO NxPlatformMO = new NxPlatformMO("LZBgAuthorityConn");

        /// <summary>
        /// 获取平台信息
        /// </summary>
        /// <param name="ptId"></param>
        /// <returns></returns>
        public NxPlatformEO GetPlatformByPK(string ptId)
        {
            return NxPlatformMO.GetByPK(ptId);
        }

        /// <summary>
        /// 创建平台信息
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public int AddPlatform(NxPlatformEO item)
        {
            return NxPlatformMO.Add(item);
        }

        /// <summary>
        /// 修改平台信息
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public int EditPlatform(NxPlatformEO item)
        {
            return NxPlatformMO.UpdatePlatform(item);
        }

        /// <summary>
        /// 查询平台信息
        /// </summary>
        /// <returns></returns>
        public IEnumerable<NxPlatformEO> GetAllPlatform()
        {
            return NxPlatformMO.GetAll();
        }

        /// <summary>
        /// 删除平台信息
        /// </summary>
        /// <param name="set"></param>
        /// <param name="where"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        //public int DelPlatforms(string set, string where, params object[] values)
        //{
        //    return NxPlatformMO.Put(set, where, null, values);
        //}
        public int DelPlatforms(string set, string where, IEnumerable<DbParameter> values)
        {
            return NxPlatformMO.Put(set, where, values, null);
        }

        /// <summary>
        /// 根据条件查询平台信息
        /// </summary>
        /// <returns></returns>
        public IEnumerable<NxPlatformEO> Get(string where, params object[] values)
        {
            return NxPlatformMO.GetTopSort(where, -1, string.Empty, null, values);
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
            return NxPlatformMO.GetTable(where, -1, string.Empty,paras);
        }

        public virtual DataTable GetList(string where, IEnumerable<DbParameter> paras)
        {
            return NxPlatformMO.GetList(where, -1, string.Empty,paras);
        }
    }
}
