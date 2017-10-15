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
{/// <summary>
    /// 【表 log 的操作类】
    /// </summary>
    public partial class NxLogMO : DataManagerBase
    {
        #region  自定义方法集合

        /// <summary>
        /// 根据用户名判断次数(num:0登陆)
        /// </summary>
        /// <param name="userid">用户ID</param>
        /// <param name="num">0：登录</param>
        /// <returns></returns>
        public int GetNumByUserId(string userid, int num)
        {
            const string sql = @" SELECT Count(Lg_id) as nums FROM log WHERE Ur_id=@Ur_id and Lg_text1=@Lg_text1 ";
            return Convert.ToInt32(Database.CreateSqlDao(sql)
                            .AddInParameter("@Ur_id", userid)
                            .AddInParameter("@Lg_text1", num).ExecTable().Rows[0]["nums"].ToString());
        }

        /// <summary>
        /// 根据用户ID类型获取log信息
        /// </summary>
        /// <param name="userid">用户ID</param>
        /// <param name="num">0：登录</param>
        /// <param name="topnum">获取数据条数</param>
        /// <returns></returns>
        public DataTable GetTableByUserid(string userid, int num, int topnum = -1)
        {
            const string format = @"SELECT Lg_id, Ur_id, Lg_userip, Lg_addtime, Lg_name, Lg_content, Lg_text1, Lg_text2 FROM `log` Where Ur_id = @Ur_id and Lg_text1 = @Lg_text1 Order by Lg_addtime desc  {0}   ";
            string sql = format;

            sql = string.Format(sql, (topnum > 0) ? "LIMIT 0, " + topnum : string.Empty);
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@Ur_id", userid)
                            .AddInParameter("@Lg_text1", num).ExecTable();
        }


        public virtual DataTable GetList(string where, int top, string sort)
        {
            string sql = @"SELECT ";
            sql += " users.Ur_name, ";
            sql += " users.Ur_department,";
            sql += " log.Lg_userip, ";
            sql += " log.Lg_addtime, ";
            sql += " log.Lg_name, ";
            sql += " log.Lg_content, ";
            sql += " log.Lg_text2, ";
            sql += " log.Lg_text1 ";
            sql += " FROM";
            sql += " log LEFT JOIN users";
            sql += " ON log.Ur_id = users.Ur_id";

            if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
            if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
            sql = string.Format(sql, (top > 0) ? "top " + top : string.Empty);
            return Database.CreateSqlDao(sql)
                            .ExecTable();
        }


        public virtual DataTable GetTableBySql(string sql)
        {
            return Database.CreateSqlDao(sql)
                            .ExecTable();
        }


        public virtual DataTable GetTableBySql(string wheresql ,IEnumerable<DbParameter> paras)
        {
            string sql = @"SELECT ";
            sql += " users.Ur_name, ";
            sql += " users.Ur_department,";
            sql += " log.Lg_userip, ";
            sql += " log.Lg_addtime, ";
            sql += " log.Lg_name, ";
            sql += " log.Lg_content, ";
            sql += " log.Lg_text2, ";
            sql += " log.Lg_text1 ";
            sql += " FROM";
            sql += " log LEFT JOIN users";
            sql += " ON log.Ur_id = users.Ur_id";
            if (!string.IsNullOrEmpty(wheresql)) sql += " WHERE " + wheresql;
            return Database.CreateSqlDao(sql)
                   .AddParameters(paras)
                            .ExecTable();
        }

        #endregion
    }
}
