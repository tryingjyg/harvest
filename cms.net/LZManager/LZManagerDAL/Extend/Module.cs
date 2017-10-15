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
    /// 【表 module 的操作类】
    /// </summary>
    public partial class ModuleMO : DataManagerBase
    {
        #region  自定义方法集合
        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name = "item">要更新的实体对象</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>受影响的行数</return>
        public virtual int UpdateModule(ModuleEO item, TransactionManager tm = null)
        {
            const string sql = @"UPDATE module SET Md_name=@Md_name, Md_parentid=@Md_parentid, Md_address=@Md_address, Pf_id=@Pf_id, 
Md_useFlag=@Md_useFlag, Md_notes=@Md_notes, Md_deleteFlag=@Md_deleteFlag, Md_addTime=@Md_addTime, Md_existsTreeView=@Md_existsTreeView, 
Md_filedOrder=@Md_filedOrder, Md_imgUrl=@Md_imgUrl, Md_text1=@Md_text1, Md_text2=@Md_text2 WHERE Md_id=@Md_id";
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@Md_id", item.MdId, DbType.String, 50)
                            .AddInParameter("@Md_name", item.MdName, DbType.String, 100)
                            .AddInParameter("@Md_parentid", item.MdParentid, DbType.String, 50)
                            .AddInParameter("@Md_address", item.MdAddress != null ? (object)item.MdAddress : DBNull.Value, DbType.String, 200)
                            .AddInParameter("@Pf_id", item.PfId, DbType.String, 50)
                            .AddInParameter("@Md_useFlag", item.MdUseFlag, DbType.AnsiStringFixedLength, 1)
                            .AddInParameter("@Md_notes", item.MdNotes != null ? (object)item.MdNotes : DBNull.Value, DbType.String, 500)
                            .AddInParameter("@Md_deleteFlag", item.MdDeleteFlag, DbType.AnsiStringFixedLength, 1)
                            .AddInParameter("@Md_addTime", item.MdAddTime, DbType.DateTime, 8)
                            .AddInParameter("@Md_existsTreeView", item.MdExistsTreeView, DbType.AnsiStringFixedLength, 1)
                            .AddInParameter("@Md_filedOrder", item.MdFiledOrder != null ? (object)item.MdFiledOrder : DBNull.Value, DbType.Int32, 4)
                            .AddInParameter("@Md_imgUrl", item.MdImgUrl != null ? (object)item.MdImgUrl : DBNull.Value, DbType.String, 200)
                            .AddInParameter("@Md_text1", item.MdText1 != null ? (object)item.MdText1 : DBNull.Value, DbType.String, 200)
                            .AddInParameter("@Md_text2", item.MdText2 != null ? (object)item.MdText2 : DBNull.Value, DbType.String, 200)
                            .ExecNonQuery(tm);
        }

        /// <summary>
        /// 按自定义条件查询
        /// </summary>
        /// <param name = "where">自定义条件,where子句</param>
        /// <param name = "top">获取行数</param>
        /// <param name = "sort">排序表达式</param>
        /// <return>Table</return>
        public virtual DataTable GetTable(string where, int top, string sort, IEnumerable<DbParameter> paras)
        {
            const string format = @"SELECT  Md_id, Md_name, Md_parentid, Md_address, Pf_id, Md_useFlag, Md_notes, Md_deleteFlag, 

Md_addTime, Md_existsTreeView, Md_filedOrder, Md_imgUrl, Md_text1, Md_text2 FROM module {0}";
            string sql = format;

            if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
            if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
            sql = string.Format(sql, (top > 0) ? "LIMIT 0, " + top : string.Empty);
            return Database.CreateSqlDao(sql)
                .AddParameters(paras)
                           .ExecTable();
        }

        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// <param name = "mdId">模块ID</param>
        /// <param name = "PfId">外键 平台ID</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>受影响的行数</return>
        public virtual int PutPfIdByPtId(string mdId, string PfId, TransactionManager tm = null)
        {
            const string sql = @"UPDATE module SET Pf_id = @Pf_id  WHERE Md_parentid = @Md_parentid";
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@Md_parentid", mdId, DbType.String, 50)
                            .AddInParameter("@Pf_id", PfId, DbType.String, 50)
                            .ExecNonQuery(tm);
        }
        #endregion
    }
}
