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
    /// 【表 rolemodule 的操作类】
    /// </summary>
    public partial class RolemoduleMO : DataManagerBase
    {
        #region  自定义方法集合
        /// <summary>
        /// 按主键删除
        /// </summary>
        /// <param name = "rlId">角色ID</param>
        /// <param name = "mdId">模块ID（模块表）</param>
        /// <param name="tm">事务管理对象</param>
        public virtual int RemoveByPK(string rlId, TransactionManager tm = null)
        {
            const string sql = @"DELETE FROM rolemodule WHERE Rl_id=@Rl_id";
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@Rl_id", rlId, DbType.String, 50)
                            .ExecNonQuery(tm);
        }

        /// <summary>
        /// 按自定义条件查询
        /// </summary>
        /// <param name="where"></param>
        /// <param name="top"></param>
        /// <param name="sort"></param>
        /// <returns></returns>
        public virtual DataTable GetTable(string where, int top, string sort, IEnumerable<DbParameter> values)
        {
            const string format = @"SELECT {0} Rl_id, Md_id, Pt_id, Rm_addTime, Rm_text1, Rm_text2 FROM rolemodule";
            string sql = format;

            if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
            if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
            sql = string.Format(sql, (top > 0) ? "LIMIT 0, " + top : string.Empty);
            return Database.CreateSqlDao(sql)
                   .AddParameters(values)
                            .ExecTable();
        }
        #endregion
    }
}
