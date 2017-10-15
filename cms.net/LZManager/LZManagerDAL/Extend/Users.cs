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
    /// 【表 users 的操作类】
    /// </summary>
    public partial class UsersMO : DataManagerBase
    {
        #region  自定义方法集合
        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name = "item">要更新的实体对象</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>受影响的行数</return>
        public virtual int UpdateUser(UsersEO item, TransactionManager tm = null)
        {
            const string sql = @"UPDATE users SET  Ur_loginName=@Ur_loginName, Ur_pass=@Ur_pass, Ur_name=@Ur_name, Ur_parent=@Ur_parent,Ur_department=@Ur_department, Ur_phone=@Ur_phone,Ur_zone=@Ur_zone,Ur_people=@Ur_people,Ur_Contact=@Ur_Contact,Ur_gameId=@Ur_gameId,Ur_diamondNum=@Ur_diamondNum,Ur_percent=@Ur_percent,Ur_bankName=@Ur_bankName,Ur_bank=@Ur_bank,Ur_bankNo=@Ur_bankNo,Ur_introducer=@Ur_introducer,Ur_addUser=@Ur_addUser, Ur_rolestate=@Ur_rolestate,Ur_addTime=@Ur_addTime, Ur_state=@Ur_state, Ur_del=@Ur_del, Ur_errorlogin=@Ur_errorlogin, Ur_lockTime=@Ur_lockTime, Ur_lockBindIp=@Ur_lockBindIp, Ur_text1=@Ur_text1, Ur_text2=@Ur_text2 WHERE Ur_id=@Ur_id";
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@Ur_loginName", item.UrLoginName != null ? (object)item.UrLoginName : DBNull.Value, DbType.String, 50)
                            .AddInParameter("@Ur_pass", item.UrPass != null ? (object)item.UrPass : DBNull.Value, DbType.String, 100)
                            .AddInParameter("@Ur_name", item.UrName != null ? (object)item.UrName : DBNull.Value, DbType.String, 50)
                            .AddInParameter("@Ur_parent", item.UrParent != null ? (object)item.UrParent : DBNull.Value, DbType.String, 50)
                            .AddInParameter("@Ur_department", item.UrDepartment != null ? (object)item.UrDepartment : DBNull.Value, DbType.String, 50)
                            .AddInParameter("@Ur_phone", item.UrPhone != null ? (object)item.UrPhone : DBNull.Value, DbType.String, 50)
                            .AddInParameter("@Ur_zone", item.UrZone != null ? (object)item.UrZone : DBNull.Value, DbType.String, 50)
                            .AddInParameter("@Ur_people", item.UrPeople != null ? (object)item.UrPeople : DBNull.Value, DbType.String, 50)
                            .AddInParameter("@Ur_Contact", item.UrContact != null ? (object)item.UrContact : DBNull.Value, DbType.String, 50)
                            .AddInParameter("@Ur_gameId", item.UrGameId != null ? (object)item.UrGameId : DBNull.Value, DbType.String, 100)
                            .AddInParameter("@Ur_diamondNum", item.UrDiamondNum != null ? (object)item.UrDiamondNum : DBNull.Value, DbType.String, 100)
                            .AddInParameter("@Ur_percent", item.UrPercent != null ? (object)item.UrPercent : DBNull.Value, DbType.String, 50)
                            .AddInParameter("@Ur_bankName", item.UrBankName != null ? (object)item.UrBankName : DBNull.Value, DbType.String, 50)
                            .AddInParameter("@Ur_bank", item.UrBank != null ? (object)item.UrBank : DBNull.Value, DbType.String, 50)
                            .AddInParameter("@Ur_bankNo", item.UrBankNo != null ? (object)item.UrBankNo : DBNull.Value, DbType.String, 50)
                            .AddInParameter("@Ur_introducer", item.UrIntroducer != null ? (object)item.UrIntroducer : DBNull.Value, DbType.String, 50)
                            .AddInParameter("@Ur_addUser", item.UrAddUser != null ? (object)item.UrAddUser : DBNull.Value, DbType.String, 50)
                            .AddInParameter("@Ur_rolestate", item.UrRolestate != null ? (object)item.UrRolestate : DBNull.Value, DbType.String, 50)
                            .AddInParameter("@Ur_addTime", item.UrAddTime, DbType.DateTime, 8)
                            .AddInParameter("@Ur_state", item.UrState, DbType.AnsiStringFixedLength, 1)
                            .AddInParameter("@Ur_del", item.UrDel, DbType.AnsiStringFixedLength, 1)
                            .AddInParameter("@Ur_errorlogin", item.UrErrorlogin != null ? (object)item.UrErrorlogin : DBNull.Value, DbType.String, 100)
                            .AddInParameter("@Ur_lockTime", item.UrLockTime, DbType.DateTime, 8)
                            .AddInParameter("@Ur_lockBindIp", item.UrLockBindIp != null ? (object)item.UrLockBindIp : DBNull.Value, DbType.String, 500)
                            .AddInParameter("@Ur_text1", item.UrText1 != null ? (object)item.UrText1 : DBNull.Value, DbType.String, 100)
                            .AddInParameter("@Ur_text2", item.UrText2 != null ? (object)item.UrText2 : DBNull.Value, DbType.String, 100)
                             .AddInParameter("@Ur_id", item.UrId, DbType.String, 50)
                            .ExecNonQuery(tm);
            //return 0;
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
            const string format = @"select * FROM users {0}";
            string sql = format;

            if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
            if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
            sql = string.Format(sql, (top > 0) ? "LIMIT 0, " + top : string.Empty);
            return Database.CreateSqlDao(sql)
                      .AddParameters(paras)
                            .ExecTable();
        }

        /// <summary>
        /// 获取集合
        /// </summary>
        /// <param name="where"></param>
        /// <param name="top"></param>
        /// <param name="sort"></param>
        /// <returns></returns>
        public virtual DataTable GetList(string where, int top, string sort, IEnumerable<DbParameter> para)
        {
            string sql = @"select distinct AUser.*,Ausers.Ur_name as Ur_truename from users AUser";
            sql += " left join  roleuser ARUser on ARUser.Ur_id = AUser.Ur_id";
            sql += " left join role Arole on ARUser.Rl_id = Arole.Rl_id";
            sql += " left join users Ausers on AUser.Ur_addUser = Ausers.Ur_id";

            if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
            if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
            sql = string.Format(sql, (top > 0) ? "LIMIT 0, " + top : string.Empty);
            return Database.CreateSqlDao(sql)
                .AddParameters(para)
                            .ExecTable();
        }


        /// <summary>
        /// 根据用户id查询角色
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public virtual DataTable GetRoleByUserId(string userid)
        {
            string sql = @"select distinct Arole.*  from roleuser ARUser";
            sql += " inner join users AUser on ARUser.Ur_id = AUser.Ur_id";
            sql += " inner join role Arole on ARUser.Rl_id = Arole.Rl_id";
            sql += " left join users Ausers on AUser.Ur_addUser = Ausers.Ur_id"
                + " where Arole.Rl_del = 0 and Arole.Rl_state = 0 and AUser.Ur_id =@Ur_id"
                + " order by Arole.Rl_name ";
            return Database.CreateSqlDao(sql)
                       .AddInParameter("@Ur_id", userid)
                            .ExecTable();
        }
        #endregion
    }
}
