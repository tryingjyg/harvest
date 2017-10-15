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
    /// 【表 permissionstatal 的操作类】
    /// </summary>
    public partial class PermissionstatalMO : DataManagerBase
    {
        #region  自定义方法集合
        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name = "item">要更新的实体对象</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>受影响的行数</return>
        
        public virtual int UpdatePermissionsTatal(PermissionstatalEO item, TransactionManager tm = null)
        {
            const string sql = @"UPDATE permissionstatal SET Pt_name=@Pt_name, Pf_id=@Pf_id, Pt_addUser=@Pt_addUser, Pt_addTime=@Pt_addTime, Pt_state=@Pt_state, Pt_del=@Pt_del, Pt_text1=@Pt_text1, Pt_text2=@Pt_text2 WHERE Pt_id=@Pt_id";
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@Pt_id", item.PtId, DbType.String, 50)
                            .AddInParameter("@Pt_name", item.PtName, DbType.String, 50)
                            .AddInParameter("@Pf_id", item.PfId, DbType.String, 50)
                            .AddInParameter("@Pt_addUser", item.PtAddUser, DbType.String, 50)
                            .AddInParameter("@Pt_addTime", item.PtAddTime, DbType.DateTime, 8)
                            .AddInParameter("@Pt_state", item.PtState, DbType.AnsiStringFixedLength, 1)
                            .AddInParameter("@Pt_del", item.PtDel, DbType.AnsiStringFixedLength, 1)
                            .AddInParameter("@Pt_text1", item.PtText1 != null ? (object)item.PtText1 : DBNull.Value, DbType.String, 200)
                            .AddInParameter("@Pt_text2", item.PtText2 != null ? (object)item.PtText2 : DBNull.Value, DbType.String, 200)
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
        public virtual DataTable GetTable(string where, int top, string sort, IEnumerable<DbParameter> paras)
        {
            const string format = @"SELECT {0} Pt_id, Pt_name, Pf_id, Pt_addUser, Pt_addTime, Pt_state, Pt_del, Pt_text1, Pt_text2 FROM permissionstatal";
            string sql = format;

            if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
            if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
            sql = string.Format(sql, (top > 0) ? "top " + top : string.Empty);
            return Database.CreateSqlDao(sql)
                       .AddParameters(paras)
                             .ExecTable();
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
        public virtual DataTable GetList(string where, int top, string sort, IEnumerable<DbParameter> paras)
        {
            const string format = @"select pt.*,g.Pf_name,u.Ur_name from permissionstatal pt,platform g,users u ";
            string sql = format;

            if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
            if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
            sql = string.Format(sql, (top > 0) ? "LIMIT 0, " + top : string.Empty);
            return Database.CreateSqlDao(sql)
                .AddParameters(paras)
                            .ExecTable();
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
        public virtual IEnumerable<PermissionstatalEO> Gets(string where, int top, string sort, TransactionManager tm, params object[] values)
        {
            string sql = @"select APerTat.* from modulepermissions AMoudlePer";
            sql += " left join permissionstatal APerTat on";
            sql += " APerTat.Pt_id = AMoudlePer.Pm_id";

            if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
            if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
            sql = string.Format(sql, (top > 0) ? "LIMIT 0, " + top : string.Empty);
            return Database.CreateSqlDao(sql)
                            .AddInParameters(values)
                            .ExecList<PermissionstatalEO>(PermissionstatalEO.GetItem, tm);
        }

        public virtual IEnumerable<PermissionstatalEO> Gets(string where, int top, string sort, TransactionManager tm, IEnumerable<DbParameter> values)
        {
            string sql = @"select APerTat.* from modulepermissions AMoudlePer";
            sql += " left join permissionstatal APerTat on";
            sql += " APerTat.Pt_id = AMoudlePer.Pm_id";

            if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
            if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
            sql = string.Format(sql, (top > 0) ? "LIMIT 0, " + top : string.Empty);
            return Database.CreateSqlDao(sql)
                            .AddParameters(values)
                            .ExecList<PermissionstatalEO>(PermissionstatalEO.GetItem, tm);
            //AddInParameters(values)
        }
        #endregion
    }
}
