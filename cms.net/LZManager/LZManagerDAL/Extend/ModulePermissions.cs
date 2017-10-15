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
    /// 【表 modulepermissions 的操作类】
    /// </summary>
    public partial class ModulepermissionsMO : DataManagerBase
    {
        #region  自定义方法集合
        /// <summary>
        /// 按 PK（主键） 查询
        /// </summary>
        /// <param name="tm">事务管理对象</param>
        /// <param name = "mdId">模块ID</param>
        /// <param name = "pmId">功能id</param>
        /// <return></return>
        public virtual ModulepermissionsEO GetByPK(string mdId, TransactionManager tm = null)
        {
            const string sql = @"SELECT Md_id, Pm_id, Mp_user, Mp_addTime, Mp_text1, Mp_text2 FROM modulepermissions WHERE Md_id=@Md_id";
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@Md_id", mdId, DbType.String, 50)
                            .ExecSingle<ModulepermissionsEO>(ModulepermissionsEO.GetItem, tm);
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
        public virtual DataTable GetTable(string where, int top, string sort,IEnumerable<DbParameter> paras)
        {
            const string format = @"SELECT  Md_id, Pm_id, Mp_user, Mp_addTime, Mp_text1, Mp_text2 FROM modulepermissions  {0}";
            string sql = format;

            if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
            if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
            sql = string.Format(sql, (top > 0) ? "LIMIT 0, " + top : string.Empty);
            return Database.CreateSqlDao(sql)
                .AddParameters(paras)
                             .ExecTable();
        }

        /// <summary>
        /// 按主键删除
        /// </summary>
        /// <param name = "mdId">模块ID</param>
        /// <param name = "pmId">功能id</param>
        /// <param name="tm">事务管理对象</param>
        /// <summary>
        public virtual int RemoveByPK(string mdId, TransactionManager tm = null)
        {
            const string sql = @"DELETE FROM modulepermissions WHERE Md_id=@Md_id";
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@Md_id", mdId, DbType.String, 50)
                            .ExecNonQuery(tm);
        }
        #endregion
    }
}
