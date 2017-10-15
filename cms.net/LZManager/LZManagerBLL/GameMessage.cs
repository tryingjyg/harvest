using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LZManager.DAL;
using System.Data;
using System.Data.Common;

namespace LZManager.BLL
{
    public class GameMessage
    {
        GameMO _mo = new GameMO();

        /// <summary>
        /// 获取信息
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataTable GetTable(string strWhere, IEnumerable<DbParameter> paras)
        {
            return _mo.GetALL(strWhere, paras, -1, "", null);
        }

        public IEnumerable<GameEO> GetTable(string strWhere, IEnumerable<DbParameter> paras,string strsort)
        {
            return _mo.GetTopSort(strWhere, paras, -1, strsort, null);
        }

         /// <summary>
        /// 根据Gameid查询游戏渠道列表
        /// </summary>
        public virtual DataTable GetCannelListByGameId(string gameid)
        {
            return _mo.GetCannelListByGameId(gameid);
        }

        /// <summary>
        /// 根据id删除信息
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public int Del(string id)
        {
            return _mo.Put(" Gm_del = 1 ", " Gm_gameId = @Gm_gameId ", id);
        }
    }
}
