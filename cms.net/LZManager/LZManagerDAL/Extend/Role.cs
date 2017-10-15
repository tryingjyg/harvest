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
    /// 【表 role 的操作类】
    /// </summary>
    public partial class RoleMO : DataManagerBase
    {
        #region  自定义方法集合
        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name = "item">要更新的实体对象</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>受影响的行数</return>
        public virtual int UpdateRole(RoleEO item, TransactionManager tm = null)
        {
            const string sql = @"UPDATE role SET Rl_name=@Rl_name, Rl_addUser=@Rl_addUser, Rl_addTime=@Rl_addTime, Rl_state=@Rl_state, Rl_del=@Rl_del, Rl_text1=@Rl_text1, Rl_text2=@Rl_text2,Pf_id=@Pf_id WHERE Rl_id=@Rl_id";
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@Rl_id", item.RlId, DbType.String, 50)
                            .AddInParameter("@Rl_name", item.RlName, DbType.String, 50)
                            .AddInParameter("@Rl_addUser", item.RlAddUser != null ? (object)item.RlAddUser : DBNull.Value, DbType.String, 50)
                            .AddInParameter("@Rl_addTime", item.RlAddTime, DbType.DateTime, 8)
                            .AddInParameter("@Rl_state", item.RlState != null ? (object)item.RlState : DBNull.Value, DbType.AnsiStringFixedLength, 1)
                            .AddInParameter("@Rl_del", item.RlDel != null ? (object)item.RlDel : DBNull.Value, DbType.AnsiStringFixedLength, 1)
                            .AddInParameter("@Rl_text1", item.RlText1 != null ? (object)item.RlText1 : DBNull.Value, DbType.String, 200)
                            .AddInParameter("@Rl_text2", item.RlText2 != null ? (object)item.RlText2 : DBNull.Value, DbType.String, 200).AddInParameter("@Pf_id", item.PfId != null ? (object)item.PfId : DBNull.Value, DbType.String, 50)
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
        public virtual DataTable GetTable(string where, int top, string sort, IEnumerable<DbParameter> para)
        {
            const string format = @"SELECT  Rl_id, Rl_name, Rl_addUser, Rl_addTime, Rl_state, Rl_del, Rl_text1, Rl_text2 FROM role  {0}";
            string sql = format;

            if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
            if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
            sql = string.Format(sql, (top > 0) ? "LIMIT 0, " + top : string.Empty);
            return Database.CreateSqlDao(sql)
                 .AddParameters(para)
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
        public virtual DataTable GetList(string where, int top, string sort,IEnumerable<DbParameter>para)
        {
            const string format = @"select g.Pf_name,g.Pf_text1,r.Rl_id,r.Rl_name,r.Rl_state,u.Ur_name,r.Rl_addTime,r.Pf_id from platform g,role r,users u ";
            string sql = format;

            if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
            if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
            sql = string.Format(sql, (top > 0) ? "LIMIT 0, " + top : string.Empty);
            return Database.CreateSqlDao(sql).AddParameters(para)
                            .ExecTable();
        }
        #endregion
    }
}
