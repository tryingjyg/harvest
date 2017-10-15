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
    /// 【表 permissions 的操作类】
    /// </summary>
    public partial class PermissionsMO : DataManagerBase
    {
        #region  自定义方法集合
        public virtual int UpdatePermissions(PermissionsEO item, TransactionManager tm = null)
        {
            const string sql = @"UPDATE permissions SET Pm_name=@Pm_name, Pm_addUser=@Pm_addUser, Pm_addTime=@Pm_addTime, Pm_state=@Pm_state, Pm_del=@Pm_del, Pm_text1=@Pm_text1, Pm_text2=@Pm_text2 WHERE Pm_Id=@Pm_Id";
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@Pm_Id", item.PmId, DbType.String, 50)
                            .AddInParameter("@Pm_name", item.PmName, DbType.String, 50)
                            .AddInParameter("@Pm_addUser", item.PmAddUser, DbType.String, 50)
                            .AddInParameter("@Pm_addTime", item.PmAddTime , DbType.DateTime, 8)
                            .AddInParameter("@Pm_state", item.PmState, DbType.AnsiStringFixedLength, 1)
                            .AddInParameter("@Pm_del", item.PmDel, DbType.AnsiStringFixedLength, 1)
                            .AddInParameter("@Pm_text1", item.PmText1 != null ? (object)item.PmText1 : DBNull.Value, DbType.String, 200)
                            .AddInParameter("@Pm_text2", item.PmText2 != null ? (object)item.PmText2 : DBNull.Value, DbType.String, 200)
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
            const string format = @"SELECT  Pm_Id, Pm_name, Pm_addUser, Pm_addTime, Pm_state, Pm_del, Pm_text1, Pm_text2 FROM permissions  {0}";
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
            const string format = @"select p.*,u.Ur_name from permissions p,users u";
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
