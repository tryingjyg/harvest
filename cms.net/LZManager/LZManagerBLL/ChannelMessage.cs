using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using LZManager.DAL;
using System.Data.Common;

namespace LZManager.BLL
{
    public class ChannelMessage
    {
        ChannelMO _mo = new ChannelMO("LZBgAuthorityConn");

        /// <summary>
        /// 获取信息
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataTable GetTable(string strWhere)
        {
            return _mo.GetAll(strWhere, null, -1, "", null);
        }

        public DataTable GetTable(string strWhere, IEnumerable<DbParameter> paras)
        {
            return _mo.GetAll(strWhere, paras, -1, "", null);
        }

        /// <summary>
        /// 根据id删除信息
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public int Del(string id)
        {
            return _mo.PutCnDelByPK(id, "1", null);
        }
    }
}
