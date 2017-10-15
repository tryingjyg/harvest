using System.Collections.Generic;
using LZManager.DAL;
using System.Data;
using System.Data.Common;

namespace LZManager.BLL
{
    public class MallGoodManage
    {
        MalltgoodsMO goodMO = new MalltgoodsMO("LZBgAuthorityConn");

        /// <summary>
        /// 添加商品
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public int AddGood(MalltgoodsEO item)
        {
            return goodMO.Add(item);            
        }

        /// <summary>
        /// 修改商品
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public int EditGood(MalltgoodsEO item)
        {
            return goodMO.UpdateGoods(item);
        }

        /// <summary>
        /// 查询所有商品
        /// </summary>
        /// <returns></returns>
        public IEnumerable<MalltgoodsEO> GetAll()
        {
            return goodMO.GetAll();
        }

        /// <summary>
        /// 获取商品信息
        /// </summary>
        /// <param name="urId"></param>
        /// <returns></returns>
        public MalltgoodsEO GetGoodsByPK(string gdId)
        {
            return goodMO.GetByPK(gdId);
        }

        /// <summary>
        /// 删除商品
        /// </summary>
        /// <param name="set"></param>
        /// <param name="where"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public int DelGood(string set, string where, params object[] values)
        {
            return goodMO.Put(set, where, null, values);
        }


        public int DelGood(string mgid)
        {
            return goodMO.RemoveByPK(mgid,null);
        }
        //public int DelRoles(string set, string where, IEnumerable<DbParameter> values)
        //{
        //    return roleMO.Put(set, where, values,null);
        //}

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
        public IEnumerable<MalltgoodsEO> Get(string where, IEnumerable<DbParameter> values)
        {
            return goodMO.GetTopSort(where, values ,-1, "Mg_id",null);
        }

        /// <summary>
        /// 按自定义条件查询
        /// </summary>
        /// <param name = "where">自定义条件,where子句</param>
        /// <param name = "top">获取行数</param>
        /// <param name = "sort">排序表达式</param>
        /// <return>Table</return>
        //public virtual DataTable GetTable(string where, IEnumerable<DbParameter> paras)
        //{
        //    return goodMO.GetTable(where, -1, "Rl_name",paras);
        //}

        public virtual DataTable GetList(string where, IEnumerable<DbParameter> paras)
        {
            return goodMO.GetList(where);
        }
    }
}
