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
    /// 【表 roleuser 的操作类】
    /// </summary>
    public partial class RoleuserMO : DataManagerBase
    {
        #region  自定义方法集合
        /// <summary>
        /// 按 PK（主键） 查询
        /// </summary>
        /// <param name="tm">事务管理对象</param>
        /// <param name = "urId">用户id</param>
        /// <param name = "rlId">角色id</param>
        /// <return></return>
        public virtual RoleuserEO GetByPK(string urId, TransactionManager tm = null)
        {
            const string sql = @"SELECT Ur_id, Rl_id, Ru_AddUser, Ru_AddTime, Ru_text1, Ru_text2 FROM roleuser WHERE Ur_id=@Ur_id";
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@Ur_id", urId, DbType.String, 50)
                            .ExecSingle<RoleuserEO>(RoleuserEO.GetItem, tm);
        }

        /// <summary>
        /// 按主键删除
        /// </summary>
        /// <param name = "urId">用户id</param>
        /// <param name = "rlId">角色id</param>
        /// <param name="tm">事务管理对象</param>
        public virtual int RemoveByPK(string urId, TransactionManager tm = null)
        {
            const string sql = @"DELETE FROM roleuser WHERE Ur_id=@Ur_id";
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@Ur_id", urId, DbType.String, 50)
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
        public virtual DataTable GetTable(string where, int top, string sort, IEnumerable<DbParameter> para)
        {
            const string format = @"SELECT  Ur_id, Rl_id, Ru_AddUser, Ru_AddTime, Ru_text1, Ru_text2 FROM roleuser {0}";
            string sql = format;

            if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
            if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
            sql = string.Format(sql, (top > 0) ? "LIMIT 0, " + top : string.Empty);
            return Database.CreateSqlDao(sql)
                  .AddParameters(para)
                            .ExecTable();
        }
        #endregion
    }
}
