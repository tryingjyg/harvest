using System.Collections.Generic;
using LZManager.DAL;
using System.Data;
using System.Data.Common;
namespace LZManager.BLL
{
    public class ModuleManage
    {
        ModuleMO mdMO = new ModuleMO("LZBgAuthorityConn");

        /// <summary>
        /// 获取模块信息
        /// </summary>
        /// <param name="ptId"></param>
        /// <returns></returns>
        public ModuleEO GetModuleByPK(string ptId)
        {
            return mdMO.GetByPK(ptId);
        }

        /// <summary>
        /// 创建模块信息
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public int AddModule(ModuleEO item)
        {
            return mdMO.Add(item);
        }

        /// <summary>
        /// 修改模块信息
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public int EditModule(ModuleEO item)
        {
            return mdMO.UpdateModule(item);
        }

        /// <summary>
        /// 查询模块信息
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ModuleEO> GetAllModule()
        {
            return mdMO.GetAll();
        }

        /// <summary>
        /// 删除模块信息
        /// </summary>
        /// <param name="set"></param>
        /// <param name="where"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        //public int DelModules(string set, string where, params object[] values)
        //{
        //    return mdMO.Put(set, where, null, values);
        //}
        public int DelModules(string set, string where, IEnumerable<DbParameter> paras)
        {
            return mdMO.Put(set, where, paras, null);
        }

        /// <summary>
        /// 根据条件查询模块信息
        /// </summary>
        /// <returns></returns>
        //public IEnumerable<ModuleEO> Get(string where, params object[] values)
        //{
        //    return mdMO.GetTopSort(where, -1, string.Empty, null, values);
        //}
        public IEnumerable<ModuleEO> Get(string where, IEnumerable<DbParameter> paras)
        {
            return mdMO.GetTopSort(where, paras, - 1, string.Empty);
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
            return mdMO.GetTable(where, -1, string.Empty, paras);
        }

        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// <param name = "mdId">模块ID</param>
        /// <param name = "PfId">外键 平台ID</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>受影响的行数</return>
        public virtual int PutPfIdByPtId(string mdId, string PfId)
        {
            return mdMO.PutPfIdByPtId(mdId, PfId);
        }
    }
}
