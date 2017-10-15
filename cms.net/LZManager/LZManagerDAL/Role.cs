//==========================================================
// 此代码由代码生成器工具自动生成，请不要修改
// 代码生成器核心库版本号：2.0
// 创建时间：2015/12/24 15:52:20
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
	#region EO

	/// <summary>
	/// 【表 role 的实体类】
	/// </summary>
	[SerializableAttribute]
	public class RoleEO : DataEntityBase, IRowMapper<RoleEO>
	{
		protected string _originalRlId;

		/// <summary>
		/// 主键是否有原始值（即数据库中保存的值），用于实体对象更新时
		/// </summary>
		public bool HasOriginal { get; protected set; }

		/// <summary>
		/// 【主键 varchar】
		/// </summary>
		public virtual string RlId { get; set; }

		/// <summary>
		/// 【数据库中的原始主键值副本】
		/// </summary>
		public virtual string OriginalRlId
		{
			get { return _originalRlId; }
			set { HasOriginal = true; _originalRlId = value; }
		}

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string RlName { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string PfId { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string RlAddUser { get; set; }

		/// <summary>
		/// 【字段 datetime】
		/// </summary>
		public virtual DateTime RlAddTime { get; set; }

		/// <summary>
		/// 【字段 char】
		/// </summary>
		public virtual string RlState { get; set; }

		/// <summary>
		/// 【字段 char】
		/// </summary>
		public virtual string RlDel { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string RlText1 { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string RlText2 { get; set; }

		/// <summary>
		/// 默认构造函数
		/// </summary>
		public RoleEO() 
		{
			RlId = string.Empty;
			RlName = string.Empty;
		}

		/// <summary>
		/// 自定义构造函数
		/// </summary>
		/// <param name = "rlId"></param>
		/// <param name = "rlName"></param>
		/// <param name = "pfId"></param>
		/// <param name = "rlAddUser"></param>
		/// <param name = "rlAddTime"></param>
		/// <param name = "rlState"></param>
		/// <param name = "rlDel"></param>
		/// <param name = "rlText1"></param>
		/// <param name = "rlText2"></param>
		public RoleEO(string rlId, string rlName, string pfId, string rlAddUser, DateTime rlAddTime, string rlState, string rlDel, string rlText1, string rlText2) 
		{
			RlId = rlId;
			RlName = rlName;
			PfId = pfId;
			RlAddUser = rlAddUser;
			RlAddTime = rlAddTime;
			RlState = rlState;
			RlDel = rlDel;
			RlText1 = rlText1;
			RlText2 = rlText2;
		}

		/// <summary>
		/// 将结果集映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public RoleEO MapRow(IDataReader reader)
		{
			return GetItem(reader);
		}

		/// <summary>
		/// 将结果集映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static RoleEO GetItem(IDataReader reader)
		{
			RoleEO ret = new RoleEO();

			ret.RlId = (string)reader["Rl_id"];
			ret.OriginalRlId = ret.RlId;
			ret.RlName = (string)reader["Rl_name"];
			ret.PfId = (reader["Pf_id"] is DBNull) ? null : (string)reader["Pf_id"];
			ret.RlAddUser = (reader["Rl_addUser"] is DBNull) ? null : (string)reader["Rl_addUser"];
			ret.RlAddTime = DateTime.Parse(reader["Rl_addTime"].ToString());
			ret.RlState = (reader["Rl_state"] is DBNull) ? null : (string)reader["Rl_state"];
			ret.RlDel = (reader["Rl_del"] is DBNull) ? null : (string)reader["Rl_del"];
			ret.RlText1 = (reader["Rl_text1"] is DBNull) ? null : (string)reader["Rl_text1"];
			ret.RlText2 = (reader["Rl_text2"] is DBNull) ? null : (string)reader["Rl_text2"];
			return ret;
		}
	}


	#endregion

	#region  MO

	/// <summary>
	/// 【表 role 的操作类】
	/// </summary>
    public partial class RoleMO : DataManagerBase
	{

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "routeData">路由数据</param>
		public RoleMO(object routeData = null) : base(routeData) { }

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">连接字符串名称</param>
		public RoleMO(string connectionStringName) : base(connectionStringName) { }

		#region  Get方法集合

		/// <summary>
		/// 按 PK（主键） 查询
		/// </summary>
		/// <param name="tm">事务管理对象</param>
		/// <param name = "rlId"></param>
		/// <return></return>
		public virtual RoleEO GetByPK(string rlId, TransactionManager tm = null)
		{
			const string sql = @"SELECT Rl_id, Rl_name, Pf_id, Rl_addUser, Rl_addTime, Rl_state, Rl_del, Rl_text1, Rl_text2 FROM role WHERE Rl_id=@Rl_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Rl_id", rlId, DbType.String, 150)
							.ExecSingle<RoleEO>(RoleEO.GetItem, tm);
		}




		#region  按 RlName（字段） 查询

		/// <summary>
		/// 按 RlName（字段） 查询
		/// </summary>
		/// <param name = "rlName"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetByRlName(string rlName)
		{
			return GetByRlName(rlName, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 RlName（字段） 查询
		/// </summary>
		/// <param name = "rlName"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetByRlName(string rlName, TransactionManager tm)
		{
			return GetByRlName(rlName, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 RlName（字段） 查询
		/// </summary>
		/// <param name = "rlName"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetByRlName(string rlName, int top)
		{
			return GetByRlName(rlName, top, string.Empty, null);
		}

		/// <summary>
		/// 按 RlName（字段） 查询
		/// </summary>
		/// <param name = "rlName"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetByRlName(string rlName, int top, TransactionManager tm)
		{
			return GetByRlName(rlName, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 RlName（字段） 查询
		/// </summary>
		/// <param name = "rlName"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetByRlName(string rlName, string sort)
		{
			return GetByRlName(rlName, 0, sort, null);
		}

		/// <summary>
		/// 按 RlName（字段） 查询
		/// </summary>
		/// <param name = "rlName"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetByRlName(string rlName, string sort, TransactionManager tm)
		{
			return GetByRlName(rlName, 0, sort, tm);
		}

		/// <summary>
		/// 按 RlName（字段） 查询
		/// </summary>
		/// <param name = "rlName"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetByRlName(string rlName, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Rl_id, Rl_name, Pf_id, Rl_addUser, Rl_addTime, Rl_state, Rl_del, Rl_text1, Rl_text2 FROM role WHERE Rl_name=@RlName";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@RlName", rlName, DbType.String, 150)
							.ExecList<RoleEO>(RoleEO.GetItem, tm);
		}

		#endregion

		#region  按 PfId（字段） 查询

		/// <summary>
		/// 按 PfId（字段） 查询
		/// </summary>
		/// <param name = "pfId"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetByPfId(string pfId)
		{
			return GetByPfId(pfId, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 PfId（字段） 查询
		/// </summary>
		/// <param name = "pfId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetByPfId(string pfId, TransactionManager tm)
		{
			return GetByPfId(pfId, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 PfId（字段） 查询
		/// </summary>
		/// <param name = "pfId"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetByPfId(string pfId, int top)
		{
			return GetByPfId(pfId, top, string.Empty, null);
		}

		/// <summary>
		/// 按 PfId（字段） 查询
		/// </summary>
		/// <param name = "pfId"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetByPfId(string pfId, int top, TransactionManager tm)
		{
			return GetByPfId(pfId, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 PfId（字段） 查询
		/// </summary>
		/// <param name = "pfId"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetByPfId(string pfId, string sort)
		{
			return GetByPfId(pfId, 0, sort, null);
		}

		/// <summary>
		/// 按 PfId（字段） 查询
		/// </summary>
		/// <param name = "pfId"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetByPfId(string pfId, string sort, TransactionManager tm)
		{
			return GetByPfId(pfId, 0, sort, tm);
		}

		/// <summary>
		/// 按 PfId（字段） 查询
		/// </summary>
		/// <param name = "pfId"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetByPfId(string pfId, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Rl_id, Rl_name, Pf_id, Rl_addUser, Rl_addTime, Rl_state, Rl_del, Rl_text1, Rl_text2 FROM role WHERE Pf_id=@PfId";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@PfId", pfId, DbType.String, 150)
							.ExecList<RoleEO>(RoleEO.GetItem, tm);
		}

		#endregion

		#region  按 RlAddUser（字段） 查询

		/// <summary>
		/// 按 RlAddUser（字段） 查询
		/// </summary>
		/// <param name = "rlAddUser"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetByRlAddUser(string rlAddUser)
		{
			return GetByRlAddUser(rlAddUser, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 RlAddUser（字段） 查询
		/// </summary>
		/// <param name = "rlAddUser"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetByRlAddUser(string rlAddUser, TransactionManager tm)
		{
			return GetByRlAddUser(rlAddUser, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 RlAddUser（字段） 查询
		/// </summary>
		/// <param name = "rlAddUser"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetByRlAddUser(string rlAddUser, int top)
		{
			return GetByRlAddUser(rlAddUser, top, string.Empty, null);
		}

		/// <summary>
		/// 按 RlAddUser（字段） 查询
		/// </summary>
		/// <param name = "rlAddUser"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetByRlAddUser(string rlAddUser, int top, TransactionManager tm)
		{
			return GetByRlAddUser(rlAddUser, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 RlAddUser（字段） 查询
		/// </summary>
		/// <param name = "rlAddUser"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetByRlAddUser(string rlAddUser, string sort)
		{
			return GetByRlAddUser(rlAddUser, 0, sort, null);
		}

		/// <summary>
		/// 按 RlAddUser（字段） 查询
		/// </summary>
		/// <param name = "rlAddUser"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetByRlAddUser(string rlAddUser, string sort, TransactionManager tm)
		{
			return GetByRlAddUser(rlAddUser, 0, sort, tm);
		}

		/// <summary>
		/// 按 RlAddUser（字段） 查询
		/// </summary>
		/// <param name = "rlAddUser"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetByRlAddUser(string rlAddUser, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Rl_id, Rl_name, Pf_id, Rl_addUser, Rl_addTime, Rl_state, Rl_del, Rl_text1, Rl_text2 FROM role WHERE Rl_addUser=@RlAddUser";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@RlAddUser", rlAddUser, DbType.String, 150)
							.ExecList<RoleEO>(RoleEO.GetItem, tm);
		}

		#endregion

		#region  按 RlAddTime（字段） 查询

		/// <summary>
		/// 按 RlAddTime（字段） 查询
		/// </summary>
		/// <param name = "rlAddTime"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetByRlAddTime(DateTime rlAddTime)
		{
			return GetByRlAddTime(rlAddTime, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 RlAddTime（字段） 查询
		/// </summary>
		/// <param name = "rlAddTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetByRlAddTime(DateTime rlAddTime, TransactionManager tm)
		{
			return GetByRlAddTime(rlAddTime, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 RlAddTime（字段） 查询
		/// </summary>
		/// <param name = "rlAddTime"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetByRlAddTime(DateTime rlAddTime, int top)
		{
			return GetByRlAddTime(rlAddTime, top, string.Empty, null);
		}

		/// <summary>
		/// 按 RlAddTime（字段） 查询
		/// </summary>
		/// <param name = "rlAddTime"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetByRlAddTime(DateTime rlAddTime, int top, TransactionManager tm)
		{
			return GetByRlAddTime(rlAddTime, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 RlAddTime（字段） 查询
		/// </summary>
		/// <param name = "rlAddTime"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetByRlAddTime(DateTime rlAddTime, string sort)
		{
			return GetByRlAddTime(rlAddTime, 0, sort, null);
		}

		/// <summary>
		/// 按 RlAddTime（字段） 查询
		/// </summary>
		/// <param name = "rlAddTime"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetByRlAddTime(DateTime rlAddTime, string sort, TransactionManager tm)
		{
			return GetByRlAddTime(rlAddTime, 0, sort, tm);
		}

		/// <summary>
		/// 按 RlAddTime（字段） 查询
		/// </summary>
		/// <param name = "rlAddTime"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetByRlAddTime(DateTime rlAddTime, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Rl_id, Rl_name, Pf_id, Rl_addUser, Rl_addTime, Rl_state, Rl_del, Rl_text1, Rl_text2 FROM role WHERE Rl_addTime=@RlAddTime";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@RlAddTime", rlAddTime, DbType.DateTime, 0)
							.ExecList<RoleEO>(RoleEO.GetItem, tm);
		}

		#endregion

		#region  按 RlState（字段） 查询

		/// <summary>
		/// 按 RlState（字段） 查询
		/// </summary>
		/// <param name = "rlState"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetByRlState(string rlState)
		{
			return GetByRlState(rlState, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 RlState（字段） 查询
		/// </summary>
		/// <param name = "rlState"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetByRlState(string rlState, TransactionManager tm)
		{
			return GetByRlState(rlState, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 RlState（字段） 查询
		/// </summary>
		/// <param name = "rlState"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetByRlState(string rlState, int top)
		{
			return GetByRlState(rlState, top, string.Empty, null);
		}

		/// <summary>
		/// 按 RlState（字段） 查询
		/// </summary>
		/// <param name = "rlState"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetByRlState(string rlState, int top, TransactionManager tm)
		{
			return GetByRlState(rlState, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 RlState（字段） 查询
		/// </summary>
		/// <param name = "rlState"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetByRlState(string rlState, string sort)
		{
			return GetByRlState(rlState, 0, sort, null);
		}

		/// <summary>
		/// 按 RlState（字段） 查询
		/// </summary>
		/// <param name = "rlState"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetByRlState(string rlState, string sort, TransactionManager tm)
		{
			return GetByRlState(rlState, 0, sort, tm);
		}

		/// <summary>
		/// 按 RlState（字段） 查询
		/// </summary>
		/// <param name = "rlState"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetByRlState(string rlState, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Rl_id, Rl_name, Pf_id, Rl_addUser, Rl_addTime, Rl_state, Rl_del, Rl_text1, Rl_text2 FROM role WHERE Rl_state=@RlState";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@RlState", rlState, DbType.String, 3)
							.ExecList<RoleEO>(RoleEO.GetItem, tm);
		}

		#endregion

		#region  按 RlDel（字段） 查询

		/// <summary>
		/// 按 RlDel（字段） 查询
		/// </summary>
		/// <param name = "rlDel"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetByRlDel(string rlDel)
		{
			return GetByRlDel(rlDel, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 RlDel（字段） 查询
		/// </summary>
		/// <param name = "rlDel"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetByRlDel(string rlDel, TransactionManager tm)
		{
			return GetByRlDel(rlDel, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 RlDel（字段） 查询
		/// </summary>
		/// <param name = "rlDel"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetByRlDel(string rlDel, int top)
		{
			return GetByRlDel(rlDel, top, string.Empty, null);
		}

		/// <summary>
		/// 按 RlDel（字段） 查询
		/// </summary>
		/// <param name = "rlDel"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetByRlDel(string rlDel, int top, TransactionManager tm)
		{
			return GetByRlDel(rlDel, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 RlDel（字段） 查询
		/// </summary>
		/// <param name = "rlDel"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetByRlDel(string rlDel, string sort)
		{
			return GetByRlDel(rlDel, 0, sort, null);
		}

		/// <summary>
		/// 按 RlDel（字段） 查询
		/// </summary>
		/// <param name = "rlDel"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetByRlDel(string rlDel, string sort, TransactionManager tm)
		{
			return GetByRlDel(rlDel, 0, sort, tm);
		}

		/// <summary>
		/// 按 RlDel（字段） 查询
		/// </summary>
		/// <param name = "rlDel"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetByRlDel(string rlDel, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Rl_id, Rl_name, Pf_id, Rl_addUser, Rl_addTime, Rl_state, Rl_del, Rl_text1, Rl_text2 FROM role WHERE Rl_del=@RlDel";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@RlDel", rlDel, DbType.String, 3)
							.ExecList<RoleEO>(RoleEO.GetItem, tm);
		}

		#endregion

		#region  按 RlText1（字段） 查询

		/// <summary>
		/// 按 RlText1（字段） 查询
		/// </summary>
		/// <param name = "rlText1"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetByRlText1(string rlText1)
		{
			return GetByRlText1(rlText1, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 RlText1（字段） 查询
		/// </summary>
		/// <param name = "rlText1"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetByRlText1(string rlText1, TransactionManager tm)
		{
			return GetByRlText1(rlText1, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 RlText1（字段） 查询
		/// </summary>
		/// <param name = "rlText1"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetByRlText1(string rlText1, int top)
		{
			return GetByRlText1(rlText1, top, string.Empty, null);
		}

		/// <summary>
		/// 按 RlText1（字段） 查询
		/// </summary>
		/// <param name = "rlText1"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetByRlText1(string rlText1, int top, TransactionManager tm)
		{
			return GetByRlText1(rlText1, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 RlText1（字段） 查询
		/// </summary>
		/// <param name = "rlText1"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetByRlText1(string rlText1, string sort)
		{
			return GetByRlText1(rlText1, 0, sort, null);
		}

		/// <summary>
		/// 按 RlText1（字段） 查询
		/// </summary>
		/// <param name = "rlText1"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetByRlText1(string rlText1, string sort, TransactionManager tm)
		{
			return GetByRlText1(rlText1, 0, sort, tm);
		}

		/// <summary>
		/// 按 RlText1（字段） 查询
		/// </summary>
		/// <param name = "rlText1"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetByRlText1(string rlText1, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Rl_id, Rl_name, Pf_id, Rl_addUser, Rl_addTime, Rl_state, Rl_del, Rl_text1, Rl_text2 FROM role WHERE Rl_text1=@RlText1";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@RlText1", rlText1, DbType.String, 600)
							.ExecList<RoleEO>(RoleEO.GetItem, tm);
		}

		#endregion

		#region  按 RlText2（字段） 查询

		/// <summary>
		/// 按 RlText2（字段） 查询
		/// </summary>
		/// <param name = "rlText2"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetByRlText2(string rlText2)
		{
			return GetByRlText2(rlText2, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 RlText2（字段） 查询
		/// </summary>
		/// <param name = "rlText2"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetByRlText2(string rlText2, TransactionManager tm)
		{
			return GetByRlText2(rlText2, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 RlText2（字段） 查询
		/// </summary>
		/// <param name = "rlText2"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetByRlText2(string rlText2, int top)
		{
			return GetByRlText2(rlText2, top, string.Empty, null);
		}

		/// <summary>
		/// 按 RlText2（字段） 查询
		/// </summary>
		/// <param name = "rlText2"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetByRlText2(string rlText2, int top, TransactionManager tm)
		{
			return GetByRlText2(rlText2, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 RlText2（字段） 查询
		/// </summary>
		/// <param name = "rlText2"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetByRlText2(string rlText2, string sort)
		{
			return GetByRlText2(rlText2, 0, sort, null);
		}

		/// <summary>
		/// 按 RlText2（字段） 查询
		/// </summary>
		/// <param name = "rlText2"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetByRlText2(string rlText2, string sort, TransactionManager tm)
		{
			return GetByRlText2(rlText2, 0, sort, tm);
		}

		/// <summary>
		/// 按 RlText2（字段） 查询
		/// </summary>
		/// <param name = "rlText2"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetByRlText2(string rlText2, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Rl_id, Rl_name, Pf_id, Rl_addUser, Rl_addTime, Rl_state, Rl_del, Rl_text1, Rl_text2 FROM role WHERE Rl_text2=@RlText2";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@RlText2", rlText2, DbType.String, 600)
							.ExecList<RoleEO>(RoleEO.GetItem, tm);
		}

		#endregion

		#region  自定义条件查询

		/// <summary>
		/// 获取所有数据
		/// </summary>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetAll(TransactionManager tm = null)
		{
			return GetTopSort(string.Empty, null, -1, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "values">where子句中定义的参数值集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> Get(string where, params object[] values)
		{
			return GetTopSort(where, -1, string.Empty, null, values);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "paras">where子句中定义的参数集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> Get(string where, IEnumerable<DbParameter> paras)
		{
			return GetTopSort(where, paras, -1, string.Empty, null);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> Get(string where, TransactionManager tm)
		{
			return GetTopSort(where, null , -1, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name="tm">事务管理对象</param>
		/// <param name = "values">where子句中定义的参数值集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> Get(string where, TransactionManager tm, params object[] values)
		{
			return GetTopSort(where, -1, string.Empty, tm, values);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "paras">where子句中定义的参数集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> Get(string where, IEnumerable<DbParameter> paras, TransactionManager tm)
		{
			return GetTopSort(where, paras, -1, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetTop(string where, int top)
		{
			return GetTopSort(where, null, top, string.Empty, null);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "top">获取行数</param>
		/// <param name = "values">where子句中定义的参数值集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetTop(string where, int top, params object[] values)
		{
			return GetTopSort(where, top, string.Empty, null, values);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "paras">where子句中定义的参数集合</param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetTop(string where, IEnumerable<DbParameter> paras, int top)
		{
			return GetTopSort(where, paras, top, string.Empty, null);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetTop(string where, int top, TransactionManager tm)
		{
			return GetTopSort(where, null, top, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <param name = "values">where子句中定义的参数值集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetTop(string where, int top, TransactionManager tm, params object[] values)
		{
			return GetTopSort(where, top, string.Empty, tm, values);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "paras">where子句中定义的参数集合</param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetTop(string where, IEnumerable<DbParameter> paras, int top, TransactionManager tm)
		{
			return GetTopSort(where, paras, top, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetSort(string where, string sort)
		{
			return GetTopSort(where, null, -1, sort, null);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name = "values">where子句中定义的参数值集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetSort(string where, string sort, params object[] values)
		{
			return GetTopSort(where, -1, sort, null, values);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "paras">where子句中定义的参数集合</param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetSort(string where, IEnumerable<DbParameter> paras, string sort)
		{
			return GetTopSort(where, paras, -1, sort, null);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetSort(string where, string sort, TransactionManager tm)
		{
			return GetTopSort(where, null, -1, sort, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <param name = "values">where子句中定义的参数值集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetSort(string where, string sort, TransactionManager tm, params object[] values)
		{
			return GetTopSort(where, -1, sort, tm, values);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "paras">where子句中定义的参数集合</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetSort(string where, IEnumerable<DbParameter> paras, string sort, TransactionManager tm)
		{
			return GetTopSort(where, paras, -1, sort, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetTopSort(string where, int top, string sort)
		{
			return GetTopSort(where, null, top, sort, null);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name = "values">where子句中定义的参数值集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetTopSort(string where, int top, string sort, params object[] values)
		{
			return GetTopSort(where, top, sort, null, values);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "paras">where子句中定义的参数集合</param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetTopSort(string where, IEnumerable<DbParameter> paras, int top, string sort)
		{
			return GetTopSort(where, paras, top, sort, null);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleEO> GetTopSort(string where, int top, string sort, TransactionManager tm)
		{
			return GetTopSort(where, null, top, sort, tm);
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
		public virtual IEnumerable<RoleEO> GetTopSort(string where, int top, string sort, TransactionManager tm, params object[] values)
		{
			const string format = @"SELECT {0} Rl_id, Rl_name, Pf_id, Rl_addUser, Rl_addTime, Rl_state, Rl_del, Rl_text1, Rl_text2 FROM role";
			string sql = format;

			if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameters(values)
							.ExecList<RoleEO>(RoleEO.GetItem, tm);
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
		public virtual IEnumerable<RoleEO> GetTopSort(string where, IEnumerable<DbParameter> paras, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Rl_id, Rl_name, Pf_id, Rl_addUser, Rl_addTime, Rl_state, Rl_del, Rl_text1, Rl_text2 FROM role";
			string sql = format;

			if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddParameters(paras)
							.ExecList<RoleEO>(RoleEO.GetItem, tm);
		}

		#endregion

		#region  分页

		/// <summary>
		/// 获取分页操作对象
		/// </summary>
		/// <param name = "pageSize">页大小</param>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "sort">排序表达式</param>
		/// <return>分页操作对象</return>
		public virtual IDataPager GetPager(int pageSize, string where = null, string sort = null)
		{
			const string format = @"SELECT Rl_id, Rl_name, Pf_id, Rl_addUser, Rl_addTime, Rl_state, Rl_del, Rl_text1, Rl_text2 FROM role {0} {1}";
			 string sql = string.Format(format, string.IsNullOrEmpty(where) ? string.Empty : "WHERE " + where, string.IsNullOrEmpty(sort) ? string.Empty : "ORDER BY " + sort);

			return Database.CreatePager(sql, pageSize, "Rl_id");
		}

		/// <summary>
		/// 获取分页数据
		/// </summary>
		/// <param name = "pageIndex">页索引，从1开始</param>
		/// <param name = "pageSize">页大小</param>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name = "paras">where子句中定义的参数集合</param>
		/// <return>查询到的数据集合</return>
		public virtual List<RoleEO> GetPageList(int pageIndex , int pageSize, string where = null, string sort = null, IEnumerable<DbParameter> paras = null)
		{
			var pager = GetPager(pageSize, where, sort);

			pager.AddParameters(paras);
			return pager.GetPageList<RoleEO>(pageIndex);
		}

		/// <summary>
		/// 获取分页数据
		/// </summary>
		/// <param name = "pageIndex">页索引，从1开始</param>
		/// <param name = "pageSize">页大小</param>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name = "paras">where子句中定义的参数集合</param>
		/// <return>查询到的数据集合</return>
		public virtual IEnumerable<RoleEO> GetPageMutil(int pageIndex , int pageSize, string where = null, string sort = null, IEnumerable<DbParameter> paras = null)
		{
			var pager = GetPager(pageSize, where, sort);

			pager.AddParameters(paras);
			return pager.GetPageMutil<RoleEO>(pageIndex);
		}

		/// <summary>
		/// 获取分页信息
		/// </summary>
		/// <param name = "pageSize">页大小</param>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "paras">where子句中定义的参数集合</param>
		/// <return>
		/// Tuple类型：
		/// 	Item1:数据个数(RecordCount)
		/// 	Item2:总页数(PageCount)
		/// </return>
		public virtual Tuple<long, long> GetPageInfo(int pageSize, string where = null, IEnumerable<DbParameter> paras = null)
		{
			var pager = GetPager(pageSize, where);

			pager.AddParameters(paras);
			return Tuple.Create(pager.GetRecordCount(), pager.PageCount);
		}

		#endregion

		#endregion

		#region  Add方法集合

		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Add(RoleEO item, TransactionManager tm = null)
		{
			const string sql = @"INSERT INTO role (Rl_id, Rl_name, Pf_id, Rl_addUser, Rl_addTime, Rl_state, Rl_del, Rl_text1, Rl_text2) VALUES (@Rl_id, @Rl_name, @Pf_id, @Rl_addUser, @Rl_addTime, @Rl_state, @Rl_del, @Rl_text1, @Rl_text2) ";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Rl_id", item.RlId, DbType.String, 150)
							.AddInParameter("@Rl_name", item.RlName, DbType.String, 150)
							.AddInParameter("@Pf_id", item.PfId != null ?  (object)item.PfId : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Rl_addUser", item.RlAddUser != null ?  (object)item.RlAddUser : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Rl_addTime", item.RlAddTime, DbType.DateTime, 0)
							.AddInParameter("@Rl_state", item.RlState != null ?  (object)item.RlState : DBNull.Value, DbType.String, 3)
							.AddInParameter("@Rl_del", item.RlDel != null ?  (object)item.RlDel : DBNull.Value, DbType.String, 3)
							.AddInParameter("@Rl_text1", item.RlText1 != null ?  (object)item.RlText1 : DBNull.Value, DbType.String, 600)
							.AddInParameter("@Rl_text2", item.RlText2 != null ?  (object)item.RlText2 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 插入一组数据
		/// </summary>
		/// <param name = "items">要插入的实体对象集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Add(IEnumerable<RoleEO> items, TransactionManager tm = null)
		{
			int ret = 0;
			const string sql = @"INSERT INTO role (Rl_id, Rl_name, Pf_id, Rl_addUser, Rl_addTime, Rl_state, Rl_del, Rl_text1, Rl_text2) VALUES (@Rl_id, @Rl_name, @Pf_id, @Rl_addUser, @Rl_addTime, @Rl_state, @Rl_del, @Rl_text1, @Rl_text2) ";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@Rl_id", DbType.String, 150)
									.AddParameter("@Rl_name", DbType.String, 150)
									.AddParameter("@Pf_id", DbType.String, 150)
									.AddParameter("@Rl_addUser", DbType.String, 150)
									.AddParameter("@Rl_addTime", DbType.DateTime, 0)
									.AddParameter("@Rl_state", DbType.String, 3)
									.AddParameter("@Rl_del", DbType.String, 3)
									.AddParameter("@Rl_text1", DbType.String, 600)
									.AddParameter("@Rl_text2", DbType.String, 600);

			foreach (RoleEO item in items)
			{
				sqlDao
					.SetParameterValue("@Rl_id", item.RlId)
					.SetParameterValue("@Rl_name", item.RlName)
					.SetParameterValue("@Pf_id", item.PfId != null ?  (object)item.PfId : DBNull.Value)
					.SetParameterValue("@Rl_addUser", item.RlAddUser != null ?  (object)item.RlAddUser : DBNull.Value)
					.SetParameterValue("@Rl_addTime", item.RlAddTime)
					.SetParameterValue("@Rl_state", item.RlState != null ?  (object)item.RlState : DBNull.Value)
					.SetParameterValue("@Rl_del", item.RlDel != null ?  (object)item.RlDel : DBNull.Value)
					.SetParameterValue("@Rl_text1", item.RlText1 != null ?  (object)item.RlText1 : DBNull.Value)
					.SetParameterValue("@Rl_text2", item.RlText2 != null ?  (object)item.RlText2 : DBNull.Value)
					.ExecNonQuery(tm);
				++ret;
			}
			return ret;
		}
		#endregion

		#region  Put方法集合

		/// <summary>
		/// 更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Put(RoleEO item, TransactionManager tm = null)
		{
			const string sql = @"UPDATE role SET Rl_id=@Rl_id, Rl_name=@Rl_name, Pf_id=@Pf_id, Rl_addUser=@Rl_addUser, Rl_addTime=@Rl_addTime, Rl_state=@Rl_state, Rl_del=@Rl_del, Rl_text1=@Rl_text1, Rl_text2=@Rl_text2 WHERE Rl_id=@OriginalRl_id";
			return Database.CreateSqlDao (sql)
							.AddInParameter("@OriginalRlId", (item.HasOriginal) ? item.OriginalRlId : item.RlId, DbType.String, 150)
							.AddInParameter("@Rl_id", item.RlId, DbType.String, 150)
							.AddInParameter("@Rl_name", item.RlName, DbType.String, 150)
							.AddInParameter("@Pf_id", item.PfId != null ?  (object)item.PfId : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Rl_addUser", item.RlAddUser != null ?  (object)item.RlAddUser : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Rl_addTime", item.RlAddTime, DbType.DateTime, 0)
							.AddInParameter("@Rl_state", item.RlState != null ?  (object)item.RlState : DBNull.Value, DbType.String, 3)
							.AddInParameter("@Rl_del", item.RlDel != null ?  (object)item.RlDel : DBNull.Value, DbType.String, 3)
							.AddInParameter("@Rl_text1", item.RlText1 != null ?  (object)item.RlText1 : DBNull.Value, DbType.String, 600)
							.AddInParameter("@Rl_text2", item.RlText2 != null ?  (object)item.RlText2 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}


		/// <summary>
		/// 更新数据
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Put(IEnumerable<RoleEO> items, TransactionManager tm = null)
		{

			int ret = 0;
			const string sql = @"UPDATE role SET Rl_id=@Rl_id, Rl_name=@Rl_name, Pf_id=@Pf_id, Rl_addUser=@Rl_addUser, Rl_addTime=@Rl_addTime, Rl_state=@Rl_state, Rl_del=@Rl_del, Rl_text1=@Rl_text1, Rl_text2=@Rl_text2 WHERE Rl_id=@OriginalRl_id";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@OriginalRlId", DbType.String, 150)
									.AddParameter("@Rl_id", DbType.String, 150)
									.AddParameter("@Rl_name", DbType.String, 150)
									.AddParameter("@Pf_id", DbType.String, 150)
									.AddParameter("@Rl_addUser", DbType.String, 150)
									.AddParameter("@Rl_addTime", DbType.DateTime, 0)
									.AddParameter("@Rl_state", DbType.String, 3)
									.AddParameter("@Rl_del", DbType.String, 3)
									.AddParameter("@Rl_text1", DbType.String, 600)
									.AddParameter("@Rl_text2", DbType.String, 600);

			foreach (RoleEO item in items)
			{
				ret += sqlDao
							.SetParameterValue("@OriginalRlId", (item.HasOriginal) ? item.OriginalRlId : item.RlId)
							.SetParameterValue("@Rl_id", item.RlId)
							.SetParameterValue("@Rl_name", item.RlName)
							.SetParameterValue("@Pf_id", item.PfId != null ?  (object)item.PfId : DBNull.Value)
							.SetParameterValue("@Rl_addUser", item.RlAddUser != null ?  (object)item.RlAddUser : DBNull.Value)
							.SetParameterValue("@Rl_addTime", item.RlAddTime)
							.SetParameterValue("@Rl_state", item.RlState != null ?  (object)item.RlState : DBNull.Value)
							.SetParameterValue("@Rl_del", item.RlDel != null ?  (object)item.RlDel : DBNull.Value)
							.SetParameterValue("@Rl_text1", item.RlText1 != null ?  (object)item.RlText1 : DBNull.Value)
							.SetParameterValue("@Rl_text2", item.RlText2 != null ?  (object)item.RlText2 : DBNull.Value)
							.ExecNonQuery(tm);
			}
			return ret;
		}


		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "rlId"></param>
		/// <param name = "rlName"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutRlNameByPK(string rlId, string rlName, TransactionManager tm = null)
		{
			const string sql = @"UPDATE role SET Rl_name = @Rl_name  WHERE Rl_id = @Rl_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Rl_id", rlId, DbType.String, 150)
							.AddInParameter("@Rl_name", rlName, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "rlId"></param>
		/// <param name = "pfId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutPfIdByPK(string rlId, string pfId, TransactionManager tm = null)
		{
			const string sql = @"UPDATE role SET Pf_id = @Pf_id  WHERE Rl_id = @Rl_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Rl_id", rlId, DbType.String, 150)
							.AddInParameter("@Pf_id", pfId != null ?  (object)pfId : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "rlId"></param>
		/// <param name = "rlAddUser"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutRlAddUserByPK(string rlId, string rlAddUser, TransactionManager tm = null)
		{
			const string sql = @"UPDATE role SET Rl_addUser = @Rl_addUser  WHERE Rl_id = @Rl_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Rl_id", rlId, DbType.String, 150)
							.AddInParameter("@Rl_addUser", rlAddUser != null ?  (object)rlAddUser : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "rlId"></param>
		/// <param name = "rlAddTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutRlAddTimeByPK(string rlId, DateTime rlAddTime, TransactionManager tm = null)
		{
			const string sql = @"UPDATE role SET Rl_addTime = @Rl_addTime  WHERE Rl_id = @Rl_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Rl_id", rlId, DbType.String, 150)
							.AddInParameter("@Rl_addTime", rlAddTime, DbType.DateTime, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "rlId"></param>
		/// <param name = "rlState"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutRlStateByPK(string rlId, string rlState, TransactionManager tm = null)
		{
			const string sql = @"UPDATE role SET Rl_state = @Rl_state  WHERE Rl_id = @Rl_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Rl_id", rlId, DbType.String, 150)
							.AddInParameter("@Rl_state", rlState != null ?  (object)rlState : DBNull.Value, DbType.String, 3)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "rlId"></param>
		/// <param name = "rlDel"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutRlDelByPK(string rlId, string rlDel, TransactionManager tm = null)
		{
			const string sql = @"UPDATE role SET Rl_del = @Rl_del  WHERE Rl_id = @Rl_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Rl_id", rlId, DbType.String, 150)
							.AddInParameter("@Rl_del", rlDel != null ?  (object)rlDel : DBNull.Value, DbType.String, 3)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "rlId"></param>
		/// <param name = "rlText1"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutRlText1ByPK(string rlId, string rlText1, TransactionManager tm = null)
		{
			const string sql = @"UPDATE role SET Rl_text1 = @Rl_text1  WHERE Rl_id = @Rl_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Rl_id", rlId, DbType.String, 150)
							.AddInParameter("@Rl_text1", rlText1 != null ?  (object)rlText1 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "rlId"></param>
		/// <param name = "rlText2"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutRlText2ByPK(string rlId, string rlText2, TransactionManager tm = null)
		{
			const string sql = @"UPDATE role SET Rl_text2 = @Rl_text2  WHERE Rl_id = @Rl_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Rl_id", rlId, DbType.String, 150)
							.AddInParameter("@Rl_text2", rlText2 != null ?  (object)rlText2 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}


		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "rlName"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutRlName(string rlName, TransactionManager tm = null)
		{
			const string sql = @"UPDATE role SET Rl_name=@Rl_name";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Rl_name", rlName, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "pfId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutPfId(string pfId, TransactionManager tm = null)
		{
			const string sql = @"UPDATE role SET Pf_id=@Pf_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pf_id", pfId != null ?  (object)pfId : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "rlAddUser"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutRlAddUser(string rlAddUser, TransactionManager tm = null)
		{
			const string sql = @"UPDATE role SET Rl_addUser=@Rl_addUser";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Rl_addUser", rlAddUser != null ?  (object)rlAddUser : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "rlAddTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutRlAddTime(DateTime rlAddTime, TransactionManager tm = null)
		{
			const string sql = @"UPDATE role SET Rl_addTime=@Rl_addTime";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Rl_addTime", rlAddTime, DbType.DateTime, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "rlState"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutRlState(string rlState, TransactionManager tm = null)
		{
			const string sql = @"UPDATE role SET Rl_state=@Rl_state";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Rl_state", rlState != null ?  (object)rlState : DBNull.Value, DbType.String, 3)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "rlDel"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutRlDel(string rlDel, TransactionManager tm = null)
		{
			const string sql = @"UPDATE role SET Rl_del=@Rl_del";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Rl_del", rlDel != null ?  (object)rlDel : DBNull.Value, DbType.String, 3)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "rlText1"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutRlText1(string rlText1, TransactionManager tm = null)
		{
			const string sql = @"UPDATE role SET Rl_text1=@Rl_text1";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Rl_text1", rlText1 != null ?  (object)rlText1 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "rlText2"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutRlText2(string rlText2, TransactionManager tm = null)
		{
			const string sql = @"UPDATE role SET Rl_text2=@Rl_text2";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Rl_text2", rlText2 != null ?  (object)rlText2 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按自定义语句更新数据
		/// </summary>
		/// <param name = "set">自定义更新的列，对应update中的set子句</param>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "values">update语句中定义的参数值集合</param>
		/// <return>受影响的行数</return>
		public int Put(string set, string where, params object[] values)
		{
			return Put(set, where, null, values);
		}

		/// <summary>
		/// 按自定义语句更新数据
		/// </summary>
		/// <param name = "set">自定义更新的列，对应update中的set子句</param>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "paras">update语句中定义的参数集合</param>
		/// <return>受影响的行数</return>
		public int Put(string set, string where, IEnumerable<DbParameter> paras)
		{
			return Put(set, where, paras, null);
		}

		/// <summary>
		/// 按自定义语句更新数据
		/// </summary>
		/// <param name = "set">自定义更新的列，对应update中的set子句</param>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(string set, string where, TransactionManager tm)
		{
			return Put(set, where, null, tm);
		}

		/// <summary>
		/// 按自定义语句更新数据
		/// </summary>
		/// <param name = "set">自定义更新的列，对应update中的set子句</param>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name="tm">事务管理对象</param>
		/// <param name = "values">update语句中定义的参数值集合</param>
		/// <return>受影响的行数</return>
		public virtual int Put(string set, string where, TransactionManager tm, params object[] values)
		{
			if (string.IsNullOrEmpty(set)) throw new ArgumentNullException("set");
			const string format = @"UPDATE role SET {0} {1}";
			string sql = string.Format(format, set, (string.IsNullOrEmpty(where) ? string.Empty : " WHERE " + where));

			return Database.CreateSqlDao(sql)
							.AddInParameters(values)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按自定义语句更新数据
		/// </summary>
		/// <param name = "set">自定义更新的列，对应update中的set子句</param>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "paras">update语句中定义的参数集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(string set, string where, IEnumerable<DbParameter> paras, TransactionManager tm)
		{
			if (string.IsNullOrEmpty(set)) throw new ArgumentNullException("set");
			const string format = @"UPDATE role SET {0} {1}";
			string sql = string.Format(format, set, (string.IsNullOrEmpty(where) ? string.Empty : " WHERE " + where));


			return Database.CreateSqlDao(sql)
							.AddParameters(paras)
							.ExecNonQuery(tm);
		}

		#endregion

		#region  Remove方法集合
		/// <summary>
		/// 按主键删除
		/// </summary>
		/// <param name = "rlId"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByPK(string rlId, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM role WHERE Rl_id=@Rl_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Rl_id", rlId, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Remove(RoleEO item, TransactionManager tm = null)
		{
			return RemoveByPK(item.RlId, tm);
		}

		/// <summary>
		/// 删除指定实体集合对应的记录集
		/// </summary>
		/// <param name = "items">要删除的实体集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Remove(IEnumerable<RoleEO> items, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM role WHERE Rl_id=@OriginalRl_id";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@OriginalRlId", DbType.String, 150);
			int ret = 0;
			foreach (RoleEO item in items)
			{
				ret += sqlDao
							.SetParameterValue("@OriginalRlId", (item.HasOriginal) ? item.OriginalRlId : item.RlId)
							.ExecNonQuery(tm);
			}
			return ret;
		}




		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "rlName"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByRlName(string rlName, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM role WHERE Rl_name=@Rl_name";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Rl_name", rlName, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "pfId"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByPfId(string pfId, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM role WHERE Pf_id=@Pf_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pf_id", pfId != null ?  (object)pfId : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "rlAddUser"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByRlAddUser(string rlAddUser, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM role WHERE Rl_addUser=@Rl_addUser";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Rl_addUser", rlAddUser != null ?  (object)rlAddUser : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "rlAddTime"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByRlAddTime(DateTime rlAddTime, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM role WHERE Rl_addTime=@Rl_addTime";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Rl_addTime", rlAddTime, DbType.DateTime, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "rlState"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByRlState(string rlState, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM role WHERE Rl_state=@Rl_state";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Rl_state", rlState != null ?  (object)rlState : DBNull.Value, DbType.String, 3)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "rlDel"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByRlDel(string rlDel, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM role WHERE Rl_del=@Rl_del";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Rl_del", rlDel != null ?  (object)rlDel : DBNull.Value, DbType.String, 3)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "rlText1"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByRlText1(string rlText1, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM role WHERE Rl_text1=@Rl_text1";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Rl_text1", rlText1 != null ?  (object)rlText1 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "rlText2"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByRlText2(string rlText2, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM role WHERE Rl_text2=@Rl_text2";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Rl_text2", rlText2 != null ?  (object)rlText2 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}


		/// <summary>
		/// 删除全部数据
		/// </summary>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int RemoveAll(TransactionManager tm = null)
		{
			return Remove(string.Empty, tm);
		}

		/// <summary>
		/// 删除指定条件的数据
		/// </summary>
		/// <param name = "where">自定义删除条件，where子句。如：id=1 and name='aaa'</param>
		/// <param name = "values">where子句中定义的参数值集合</param>
		/// <return>受影响的行数</return>
		public virtual int Remove(string where, params object[] values)
		{
			return Remove(where, null, values);
		}

		/// <summary>
		/// 删除指定条件的数据
		/// </summary>
		/// <param name = "where">自定义删除条件，where子句。如：id=1 and name='aaa'</param>
		/// <param name = "paras">where子句中定义的参数集合</param>
		/// <return>受影响的行数</return>
		public virtual int Remove(string where, IEnumerable<DbParameter> paras)
		{
			return Remove(where, paras, null);
		}

		/// <summary>
		/// 删除指定条件的数据
		/// </summary>
		/// <param name = "where">自定义删除条件，where子句。如：id=1 and name='aaa'</param>
		/// <param name="tm">事务管理对象</param>
		/// <param name = "values">where子句中定义的参数值集合</param>
		/// <return>受影响的行数</return>
		public virtual int Remove(string where, TransactionManager tm, params object[] values)
		{
			const string format = @"DELETE FROM role {0}";
			string sql = string.Format(format, string.IsNullOrEmpty(where) ? string.Empty : " WHERE " + where);
			return Database.CreateSqlDao(sql)
							.AddInParameters(values)
							.ExecNonQuery(tm);
		}
		/// <summary>
		/// 删除指定条件的数据
		/// </summary>
		/// <param name = "where">自定义删除条件，where子句。如：id=1 and name='aaa'</param>
		/// <param name="tm">事务管理对象</param>
		/// <param name = "paras">where子句中定义的参数集合</param>
		/// <return>受影响的行数</return>
		public virtual int Remove(string where, IEnumerable<DbParameter> paras, TransactionManager tm)
		{
			const string format = @"DELETE FROM role {0}";
			string sql = string.Format(format, string.IsNullOrEmpty(where) ? string.Empty : " WHERE " + where);
			return Database.CreateSqlDao(sql)
							.AddParameters(paras)
							.ExecNonQuery(tm);
		}
		#endregion

		#region  自定义方法集合

		#endregion
	}


	#endregion
}
