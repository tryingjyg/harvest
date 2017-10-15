using System.Collections.Generic;
using LZManager.DAL;
using System.Data;
using System;
using System.Data.Common;

namespace LZManager.BLL
{
    public class LogChargeManage
    {
        LogChargeMO lgChargeMO = new LogChargeMO("LZBgAuthorityConn");

        public int addLg(LogChargeEO lpEo) 
        { 
            return lgChargeMO.Add(lpEo);
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
            return lgChargeMO.GetTopSortTable(where, -1, string.Empty, null);
        }

    }
}
