//==========================================================
// 此代码由代码生成器工具自动生成，请不要修改
// 代码生成器核心库版本号：2.0
// 创建时间：2015/12/21 15:09:29
//==========================================================

using System;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Xml;
using TinyFx.Common;
using TinyFx.Data;

namespace LZManager.DAL
{
    /// <summary>
    /// 【表 game 的操作类】
    /// </summary>
    public partial class GameMO : DataManagerBase
    {
        #region  自定义方法集合

        /// <summary>
        /// 按自定义条件查询
        /// </summary>
        /// <param name = "where">自定义条件,where子句</param>
        /// <param name = "paras">where子句中定义的参数集合</param>
        /// <param name = "top">获取行数</param>
        /// <param name = "sort">排序表达式</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>实体对象集合</return>
        public virtual DataTable GetALL(string where, IEnumerable<DbParameter> paras, int top, string sort, TransactionManager tm)
        {
            const string format = @"SELECT DISTINCT   gm.Gm_name, gm.Gm_gameId,  gm.Gm_description, gm.Ur_id, gm.Gm_adddTime, gm.Gm_state, gm.Gm_del, gm.Gm_text1, gm.Gm_text2,au.Ur_name   FROM game as gm left join users as au on gm.Ur_id = au.Ur_id {0} ";
            string sql = format;

            if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
            if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
            sql = string.Format(sql, (top > 0) ? "LIMIT 0, " + top : string.Empty);
            return Database.CreateSqlDao(sql)
                            .AddParameters(paras)
                            .ExecTable();
        }

        /// <summary>
        /// 根据gameid查询游戏渠道列表
        /// </summary>
        public virtual DataTable GetCannelListByGameId(string gameid)
        {
            string sql = string.Format(" select a.Gm_id,a.Gm_name,a.Gm_gameId,b.Cn_id,b.Cn_channelId,b.Cn_name from  game a left join  channel b on a.Cn_channelId = b.Cn_id  where a.Gm_gameId='{0}' and a.Gm_del =0 ", gameid);
            return Database.CreateSqlDao(sql)
                            .ExecTable();
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name = "item">要更新的实体对象</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>受影响的行数</return>
        public virtual int PutById(GameEO item, TransactionManager tm = null)
        {
            const string sql = @"UPDATE game SET Gm_name=@Gm_name, Gm_gameId=@Gm_gameId, Cn_channelId=@Cn_channelId, Gm_description=@Gm_description, Ur_id=@Ur_id, Gm_adddTime=@Gm_adddTime, Gm_state=@Gm_state, Gm_del=@Gm_del, Gm_text1=@Gm_text1, Gm_text2=@Gm_text2 WHERE Gm_id=@Gm_id";
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@Gm_name", item.GmName != null ? (object)item.GmName : DBNull.Value, DbType.String, 50)
                            .AddInParameter("@Gm_gameId", item.GmGameId != null ? (object)item.GmGameId : DBNull.Value, DbType.String, 10)
                            .AddInParameter("@Cn_channelId", item.CnChannelId != null ? (object)item.CnChannelId : DBNull.Value, DbType.String, 50)
                            .AddInParameter("@Gm_description", item.GmDescription != null ? (object)item.GmDescription : DBNull.Value, DbType.String, -1)
                            .AddInParameter("@Ur_id", item.UrId != null ? (object)item.UrId : DBNull.Value, DbType.String, 50)
                            .AddInParameter("@Gm_adddTime", item.GmAdddTime.HasValue ? (object)item.GmAdddTime.Value : DBNull.Value, DbType.Date, 3)
                            .AddInParameter("@Gm_state", item.GmState != null ? (object)item.GmState : DBNull.Value, DbType.AnsiStringFixedLength, 1)
                            .AddInParameter("@Gm_del", item.GmDel != null ? (object)item.GmDel : DBNull.Value, DbType.AnsiStringFixedLength, 1)
                            .AddInParameter("@Gm_text1", item.GmText1 != null ? (object)item.GmText1 : DBNull.Value, DbType.String, 200)
                            .AddInParameter("@Gm_text2", item.GmText2 != null ? (object)item.GmText2 : DBNull.Value, DbType.String, 200)
                            .AddInParameter("@Gm_id", item.GmId, DbType.String, 50)
                            .ExecNonQuery(tm);
        }

        /// <summary>
        /// 按自定义条件查询
        /// </summary>
        /// <param name = "where">自定义条件,where子句</param>
        /// <param name = "paras">where子句中定义的参数集合</param>
        /// <param name = "top">获取行数</param>
        /// <param name = "sort">排序表达式</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<GameEO> GetTopSortByChannel(string where, IEnumerable<DbParameter> paras, int top, string sort, TransactionManager tm)
        {
            const string format = @"SELECT  a.Gm_id, a.Gm_name, a.Gm_gameId, b.Cn_name as Cn_channelId, a.Gm_description, a.Ur_id, a.Gm_adddTime, a.Gm_state, a.Gm_del, a.Gm_text1, a.Gm_text2 FROM game as a left join channel b on a.Cn_channelId = b.Cn_id  {0} ";
            string sql = format;

            if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
            if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
            sql = string.Format(sql, (top > 0) ? "LIMIT 0," + top : string.Empty);
            return Database.CreateSqlDao(sql)
                            .AddParameters(paras)
                            .ExecList<GameEO>(GameEO.GetItem, tm);
        }

        #endregion
    }
}
