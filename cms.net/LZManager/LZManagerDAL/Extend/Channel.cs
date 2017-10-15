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
    public partial class ChannelMO : DataManagerBase
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
        public virtual DataTable GetAll(string where, IEnumerable<DbParameter> paras, int top, string sort, TransactionManager tm)
        {
            const string format = @"SELECT  ac.Cn_id, ac.Cn_channelId, ac.Cn_name, ac.Cn_description, ac.Ur_id, ac.Cn_addTime, ac.Cn_state, ac.Cn_Del, ac.Cn_text1, ac.Cn_text2, au.Ur_name FROM channel ac left join users au on ac.Ur_id = au.Ur_id  {0} ";
            string sql = format;

            if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
            if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
            sql = string.Format(sql, (top > 0) ? "LIMIT 0, " + top : string.Empty);
            return Database.CreateSqlDao(sql)
                            .AddParameters(paras)
                            .ExecTable();
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name = "item">要更新的实体对象</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>受影响的行数</return>
        public virtual int PutById(ChannelEO item, TransactionManager tm = null)
        {
            const string sql = @"UPDATE channel SET Cn_channelId=@Cn_channelId, Cn_name=@Cn_name, Cn_description=@Cn_description, Ur_id=@Ur_id, Cn_addTime=@Cn_addTime, Cn_state=@Cn_state, Cn_Del=@Cn_Del, Cn_text1=@Cn_text1, Cn_text2=@Cn_text2 WHERE Cn_id=@Cn_id";
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@Cn_channelId", item.CnChannelId != null ? (object)item.CnChannelId : DBNull.Value, DbType.String, 50)
                            .AddInParameter("@Cn_name", item.CnName != null ? (object)item.CnName : DBNull.Value, DbType.String, 50)
                            .AddInParameter("@Cn_description", item.CnDescription != null ? (object)item.CnDescription : DBNull.Value, DbType.String, -1)
                            .AddInParameter("@Ur_id", item.UrId != null ? (object)item.UrId : DBNull.Value, DbType.String, 50)
                            .AddInParameter("@Cn_addTime", item.CnAddTime.HasValue ? (object)item.CnAddTime.Value : DBNull.Value, DbType.Date, 3)
                            .AddInParameter("@Cn_state", item.CnState != null ? (object)item.CnState : DBNull.Value, DbType.AnsiStringFixedLength, 1)
                            .AddInParameter("@Cn_Del", item.CnDel != null ? (object)item.CnDel : DBNull.Value, DbType.AnsiStringFixedLength, 1)
                            .AddInParameter("@Cn_text1", item.CnText1 != null ? (object)item.CnText1 : DBNull.Value, DbType.String, 200)
                            .AddInParameter("@Cn_text2", item.CnText2 != null ? (object)item.CnText2 : DBNull.Value, DbType.String, 200)
                            .AddInParameter("@Cn_id", item.CnId, DbType.String, 50)
                            .ExecNonQuery(tm);
        }
        #endregion
    }
}
