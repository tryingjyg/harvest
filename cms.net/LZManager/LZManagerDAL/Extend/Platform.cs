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
    /// 【表 platform 的操作类】
    /// </summary>
    public partial class NxPlatformMO : DataManagerBase
    {
        #region  自定义方法集合
        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name = "item">要更新的实体对象</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>受影响的行数</return>
        public virtual int UpdatePlatform(NxPlatformEO item, TransactionManager tm = null)
        {
            const string sql = @"UPDATE platform SET Pf_name=@Pf_name, Pf_imgWaterUrl = @Pf_imgWaterUrl, Pf_imgUrl=@Pf_imgUrl, Pf_addUser=@Pf_addUser, Pf_addTime=@Pf_addTime, Pf_state=@Pf_state, Pf_del=@Pf_del, Pf_sort=@Pf_sort, Pf_text1=@Pf_text1, Pf_text2=@Pf_text2,Pf_isRepair=@Pf_isRepair,Pf_newFunction=@Pf_newFunction,Pf_newEndTime=@Pf_newEndTime,Pf_isNewShow=@Pf_isNewShow WHERE Pf_id=@Pf_id";
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@Pf_id", item.PfId, DbType.String, 50)
                            .AddInParameter("@Pf_name", item.PfName != null ? (object)item.PfName : DBNull.Value, DbType.String, 50)
                            .AddInParameter("@Pf_imgWaterUrl", item.PfImgWaterUrl != null ? (object)item.PfImgWaterUrl : DBNull.Value, DbType.String, 200)
                            .AddInParameter("@Pf_imgUrl", item.PfImgUrl != null ? (object)item.PfImgUrl : DBNull.Value, DbType.String, 200)
                            .AddInParameter("@Pf_addUser", item.PfAddUser != null ? (object)item.PfAddUser : DBNull.Value, DbType.String, 50)
                            .AddInParameter("@Pf_addTime", item.PfAddTime, DbType.DateTime, 8)
                            .AddInParameter("@Pf_state", item.PfState, DbType.AnsiStringFixedLength, 1)
                            .AddInParameter("@Pf_del", item.PfDel, DbType.AnsiStringFixedLength, 1)
                            .AddInParameter("@Pf_sort", item.PfSort.HasValue ? (object)item.PfSort.Value : DBNull.Value, DbType.Int32, 4)
                            .AddInParameter("@Pf_text1", item.PfText1 != null ? (object)item.PfText1 : DBNull.Value, DbType.String, 100)
                            .AddInParameter("@Pf_text2", item.PfText2 != null ? (object)item.PfText2 : DBNull.Value, DbType.String, 100)
                            .AddInParameter("@Pf_isRepair", item.PfIsRepair, DbType.AnsiStringFixedLength, 1)
                            .AddInParameter("@Pf_newFunction", item.PfNewFunction != null ? (object)item.PfNewFunction : DBNull.Value, DbType.String, -1)
                            .AddInParameter("@Pf_newEndTime", item.PfNewEndTime, DbType.DateTime, 8)
                            .AddInParameter("@Pf_isNewShow", item.PfIsNewShow, DbType.AnsiStringFixedLength, 1)
                            .ExecNonQuery(tm);
        }

        /// <summary>
        /// 按自定义条件查询
        /// </summary>
        /// <param name = "where">自定义条件,where子句</param>
        /// <param name = "top">获取行数</param>
        /// <param name = "sort">排序表达式</param>
        /// <param name="tm">事务管理对象</param>
        /// <param name = "values">where子句中定义的参数值集合</param>
        /// <return>实体对象集合</return>
        public virtual DataTable GetTable(string where, int top, string sort, IEnumerable<DbParameter> paras)
        {
            const string format = @"SELECT  Pf_imgWaterUrl,Pf_id, Pf_name, Pf_imgUrl, Pf_addUser, Pf_addTime, Pf_state, Pf_del, Pf_sort, Pf_text1, Pf_text2,Pf_isRepair,Pf_newFunction,Pf_newEndTime,Pf_isNewShow FROM platform  {0}";
            string sql = format;

            if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
            if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
            sql = string.Format(sql, (top > 0) ? "LIMIT 0, " + top : string.Empty);
            return Database.CreateSqlDao(sql)
                    .AddParameters(paras)
                           .ExecTable();
        }

        public virtual DataTable GetList(string where, int top, string sort, IEnumerable<DbParameter> paras)
        {
            const string format = @"select g.*,u.Ur_name from platform g,users u";
            string sql = format;

            if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
            if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
            sql = string.Format(sql, (top > 0) ? "LIMIT 0, " + top : string.Empty);
            return Database.CreateSqlDao(sql)
                 .AddParameters(paras)
                           .ExecTable();
        }
        #endregion
    }
}
