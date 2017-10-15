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
	/// 【表 permissions 的实体类】
	/// </summary>
	[SerializableAttribute]
	public class PermissionsEO : DataEntityBase, IRowMapper<PermissionsEO>
	{
		protected string _originalPmId;

		/// <summary>
		/// 主键是否有原始值（即数据库中保存的值），用于实体对象更新时
		/// </summary>
		public bool HasOriginal { get; protected set; }

		/// <summary>
		/// 【主键 varchar】
		/// </summary>
		public virtual string PmId { get; set; }

		/// <summary>
		/// 【数据库中的原始主键值副本】
		/// </summary>
		public virtual string OriginalPmId
		{
			get { return _originalPmId; }
			set { HasOriginal = true; _originalPmId = value; }
		}

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string PmName { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string PmAddUser { get; set; }

		/// <summary>
		/// 【字段 datetime】
		/// </summary>
		public virtual DateTime PmAddTime { get; set; }

		/// <summary>
		/// 【字段 char】
		/// </summary>
		public virtual string PmState { get; set; }

		/// <summary>
		/// 【字段 char】
		/// </summary>
		public virtual string PmDel { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string PmText1 { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string PmText2 { get; set; }

		/// <summary>
		/// 默认构造函数
		/// </summary>
		public PermissionsEO() 
		{
			PmId = string.Empty;
		}

		/// <summary>
		/// 自定义构造函数
		/// </summary>
		/// <param name = "pmId"></param>
		/// <param name = "pmName"></param>
		/// <param name = "pmAddUser"></param>
		/// <param name = "pmAddTime"></param>
		/// <param name = "pmState"></param>
		/// <param name = "pmDel"></param>
		/// <param name = "pmText1"></param>
		/// <param name = "pmText2"></param>
		public PermissionsEO(string pmId, string pmName, string pmAddUser, DateTime pmAddTime, string pmState, string pmDel, string pmText1, string pmText2) 
		{
			PmId = pmId;
			PmName = pmName;
			PmAddUser = pmAddUser;
			PmAddTime = pmAddTime;
			PmState = pmState;
			PmDel = pmDel;
			PmText1 = pmText1;
			PmText2 = pmText2;
		}

		/// <summary>
		/// 将结果集映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public PermissionsEO MapRow(IDataReader reader)
		{
			return GetItem(reader);
		}

		/// <summary>
		/// 将结果集映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static PermissionsEO GetItem(IDataReader reader)
		{
			PermissionsEO ret = new PermissionsEO();

			ret.PmId = (string)reader["Pm_Id"];
			ret.OriginalPmId = ret.PmId;
			ret.PmName = (reader["Pm_name"] is DBNull) ? null : (string)reader["Pm_name"];
			ret.PmAddUser = (reader["Pm_addUser"] is DBNull) ? null : (string)reader["Pm_addUser"];
			ret.PmAddTime = DateTime.Parse(reader["Pm_addTime"].ToString());
			ret.PmState = (reader["Pm_state"] is DBNull) ? null : (string)reader["Pm_state"];
			ret.PmDel = (reader["Pm_del"] is DBNull) ? null : (string)reader["Pm_del"];
			ret.PmText1 = (reader["Pm_text1"] is DBNull) ? null : (string)reader["Pm_text1"];
			ret.PmText2 = (reader["Pm_text2"] is DBNull) ? null : (string)reader["Pm_text2"];
			return ret;
		}
	}


	#endregion

	#region  MO

	/// <summary>
	/// 【表 permissions 的操作类】
	/// </summary>
    public partial class PermissionsMO : DataManagerBase
	{

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "routeData">路由数据</param>
		public PermissionsMO(object routeData = null) : base(routeData) { }

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">连接字符串名称</param>
		public PermissionsMO(string connectionStringName) : base(connectionStringName) { }

		#region  Get方法集合

		/// <summary>
		/// 按 PK（主键） 查询
		/// </summary>
		/// <param name="tm">事务管理对象</param>
		/// <param name = "pmId"></param>
		/// <return></return>
		public virtual PermissionsEO GetByPK(string pmId, TransactionManager tm = null)
		{
			const string sql = @"SELECT Pm_Id, Pm_name, Pm_addUser, Pm_addTime, Pm_state, Pm_del, Pm_text1, Pm_text2 FROM permissions WHERE Pm_Id=@Pm_Id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pm_Id", pmId, DbType.String, 150)
							.ExecSingle<PermissionsEO>(PermissionsEO.GetItem, tm);
		}




		#region  按 PmName（字段） 查询

		/// <summary>
		/// 按 PmName（字段） 查询
		/// </summary>
		/// <param name = "pmName"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionsEO> GetByPmName(string pmName)
		{
			return GetByPmName(pmName, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 PmName（字段） 查询
		/// </summary>
		/// <param name = "pmName"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionsEO> GetByPmName(string pmName, TransactionManager tm)
		{
			return GetByPmName(pmName, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 PmName（字段） 查询
		/// </summary>
		/// <param name = "pmName"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionsEO> GetByPmName(string pmName, int top)
		{
			return GetByPmName(pmName, top, string.Empty, null);
		}

		/// <summary>
		/// 按 PmName（字段） 查询
		/// </summary>
		/// <param name = "pmName"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionsEO> GetByPmName(string pmName, int top, TransactionManager tm)
		{
			return GetByPmName(pmName, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 PmName（字段） 查询
		/// </summary>
		/// <param name = "pmName"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionsEO> GetByPmName(string pmName, string sort)
		{
			return GetByPmName(pmName, 0, sort, null);
		}

		/// <summary>
		/// 按 PmName（字段） 查询
		/// </summary>
		/// <param name = "pmName"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionsEO> GetByPmName(string pmName, string sort, TransactionManager tm)
		{
			return GetByPmName(pmName, 0, sort, tm);
		}

		/// <summary>
		/// 按 PmName（字段） 查询
		/// </summary>
		/// <param name = "pmName"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionsEO> GetByPmName(string pmName, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Pm_Id, Pm_name, Pm_addUser, Pm_addTime, Pm_state, Pm_del, Pm_text1, Pm_text2 FROM permissions WHERE Pm_name=@PmName";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@PmName", pmName, DbType.String, 150)
							.ExecList<PermissionsEO>(PermissionsEO.GetItem, tm);
		}

		#endregion

		#region  按 PmAddUser（字段） 查询

		/// <summary>
		/// 按 PmAddUser（字段） 查询
		/// </summary>
		/// <param name = "pmAddUser"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionsEO> GetByPmAddUser(string pmAddUser)
		{
			return GetByPmAddUser(pmAddUser, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 PmAddUser（字段） 查询
		/// </summary>
		/// <param name = "pmAddUser"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionsEO> GetByPmAddUser(string pmAddUser, TransactionManager tm)
		{
			return GetByPmAddUser(pmAddUser, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 PmAddUser（字段） 查询
		/// </summary>
		/// <param name = "pmAddUser"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionsEO> GetByPmAddUser(string pmAddUser, int top)
		{
			return GetByPmAddUser(pmAddUser, top, string.Empty, null);
		}

		/// <summary>
		/// 按 PmAddUser（字段） 查询
		/// </summary>
		/// <param name = "pmAddUser"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionsEO> GetByPmAddUser(string pmAddUser, int top, TransactionManager tm)
		{
			return GetByPmAddUser(pmAddUser, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 PmAddUser（字段） 查询
		/// </summary>
		/// <param name = "pmAddUser"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionsEO> GetByPmAddUser(string pmAddUser, string sort)
		{
			return GetByPmAddUser(pmAddUser, 0, sort, null);
		}

		/// <summary>
		/// 按 PmAddUser（字段） 查询
		/// </summary>
		/// <param name = "pmAddUser"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionsEO> GetByPmAddUser(string pmAddUser, string sort, TransactionManager tm)
		{
			return GetByPmAddUser(pmAddUser, 0, sort, tm);
		}

		/// <summary>
		/// 按 PmAddUser（字段） 查询
		/// </summary>
		/// <param name = "pmAddUser"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionsEO> GetByPmAddUser(string pmAddUser, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Pm_Id, Pm_name, Pm_addUser, Pm_addTime, Pm_state, Pm_del, Pm_text1, Pm_text2 FROM permissions WHERE Pm_addUser=@PmAddUser";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@PmAddUser", pmAddUser, DbType.String, 150)
							.ExecList<PermissionsEO>(PermissionsEO.GetItem, tm);
		}

		#endregion

		#region  按 PmAddTime（字段） 查询

		/// <summary>
		/// 按 PmAddTime（字段） 查询
		/// </summary>
		/// <param name = "pmAddTime"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionsEO> GetByPmAddTime(DateTime pmAddTime)
		{
			return GetByPmAddTime(pmAddTime, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 PmAddTime（字段） 查询
		/// </summary>
		/// <param name = "pmAddTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionsEO> GetByPmAddTime(DateTime pmAddTime, TransactionManager tm)
		{
			return GetByPmAddTime(pmAddTime, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 PmAddTime（字段） 查询
		/// </summary>
		/// <param name = "pmAddTime"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionsEO> GetByPmAddTime(DateTime pmAddTime, int top)
		{
			return GetByPmAddTime(pmAddTime, top, string.Empty, null);
		}

		/// <summary>
		/// 按 PmAddTime（字段） 查询
		/// </summary>
		/// <param name = "pmAddTime"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionsEO> GetByPmAddTime(DateTime pmAddTime, int top, TransactionManager tm)
		{
			return GetByPmAddTime(pmAddTime, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 PmAddTime（字段） 查询
		/// </summary>
		/// <param name = "pmAddTime"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionsEO> GetByPmAddTime(DateTime pmAddTime, string sort)
		{
			return GetByPmAddTime(pmAddTime, 0, sort, null);
		}

		/// <summary>
		/// 按 PmAddTime（字段） 查询
		/// </summary>
		/// <param name = "pmAddTime"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionsEO> GetByPmAddTime(DateTime pmAddTime, string sort, TransactionManager tm)
		{
			return GetByPmAddTime(pmAddTime, 0, sort, tm);
		}

		/// <summary>
		/// 按 PmAddTime（字段） 查询
		/// </summary>
		/// <param name = "pmAddTime"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionsEO> GetByPmAddTime(DateTime pmAddTime, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Pm_Id, Pm_name, Pm_addUser, Pm_addTime, Pm_state, Pm_del, Pm_text1, Pm_text2 FROM permissions WHERE Pm_addTime=@PmAddTime";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@PmAddTime", pmAddTime, DbType.DateTime, 0)
							.ExecList<PermissionsEO>(PermissionsEO.GetItem, tm);
		}

		#endregion

		#region  按 PmState（字段） 查询

		/// <summary>
		/// 按 PmState（字段） 查询
		/// </summary>
		/// <param name = "pmState"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionsEO> GetByPmState(string pmState)
		{
			return GetByPmState(pmState, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 PmState（字段） 查询
		/// </summary>
		/// <param name = "pmState"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionsEO> GetByPmState(string pmState, TransactionManager tm)
		{
			return GetByPmState(pmState, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 PmState（字段） 查询
		/// </summary>
		/// <param name = "pmState"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionsEO> GetByPmState(string pmState, int top)
		{
			return GetByPmState(pmState, top, string.Empty, null);
		}

		/// <summary>
		/// 按 PmState（字段） 查询
		/// </summary>
		/// <param name = "pmState"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionsEO> GetByPmState(string pmState, int top, TransactionManager tm)
		{
			return GetByPmState(pmState, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 PmState（字段） 查询
		/// </summary>
		/// <param name = "pmState"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionsEO> GetByPmState(string pmState, string sort)
		{
			return GetByPmState(pmState, 0, sort, null);
		}

		/// <summary>
		/// 按 PmState（字段） 查询
		/// </summary>
		/// <param name = "pmState"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionsEO> GetByPmState(string pmState, string sort, TransactionManager tm)
		{
			return GetByPmState(pmState, 0, sort, tm);
		}

		/// <summary>
		/// 按 PmState（字段） 查询
		/// </summary>
		/// <param name = "pmState"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionsEO> GetByPmState(string pmState, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Pm_Id, Pm_name, Pm_addUser, Pm_addTime, Pm_state, Pm_del, Pm_text1, Pm_text2 FROM permissions WHERE Pm_state=@PmState";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@PmState", pmState, DbType.String, 3)
							.ExecList<PermissionsEO>(PermissionsEO.GetItem, tm);
		}

		#endregion

		#region  按 PmDel（字段） 查询

		/// <summary>
		/// 按 PmDel（字段） 查询
		/// </summary>
		/// <param name = "pmDel"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionsEO> GetByPmDel(string pmDel)
		{
			return GetByPmDel(pmDel, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 PmDel（字段） 查询
		/// </summary>
		/// <param name = "pmDel"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionsEO> GetByPmDel(string pmDel, TransactionManager tm)
		{
			return GetByPmDel(pmDel, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 PmDel（字段） 查询
		/// </summary>
		/// <param name = "pmDel"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionsEO> GetByPmDel(string pmDel, int top)
		{
			return GetByPmDel(pmDel, top, string.Empty, null);
		}

		/// <summary>
		/// 按 PmDel（字段） 查询
		/// </summary>
		/// <param name = "pmDel"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionsEO> GetByPmDel(string pmDel, int top, TransactionManager tm)
		{
			return GetByPmDel(pmDel, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 PmDel（字段） 查询
		/// </summary>
		/// <param name = "pmDel"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionsEO> GetByPmDel(string pmDel, string sort)
		{
			return GetByPmDel(pmDel, 0, sort, null);
		}

		/// <summary>
		/// 按 PmDel（字段） 查询
		/// </summary>
		/// <param name = "pmDel"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionsEO> GetByPmDel(string pmDel, string sort, TransactionManager tm)
		{
			return GetByPmDel(pmDel, 0, sort, tm);
		}

		/// <summary>
		/// 按 PmDel（字段） 查询
		/// </summary>
		/// <param name = "pmDel"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionsEO> GetByPmDel(string pmDel, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Pm_Id, Pm_name, Pm_addUser, Pm_addTime, Pm_state, Pm_del, Pm_text1, Pm_text2 FROM permissions WHERE Pm_del=@PmDel";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@PmDel", pmDel, DbType.String, 3)
							.ExecList<PermissionsEO>(PermissionsEO.GetItem, tm);
		}

		#endregion

		#region  按 PmText1（字段） 查询

		/// <summary>
		/// 按 PmText1（字段） 查询
		/// </summary>
		/// <param name = "pmText1"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionsEO> GetByPmText1(string pmText1)
		{
			return GetByPmText1(pmText1, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 PmText1（字段） 查询
		/// </summary>
		/// <param name = "pmText1"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionsEO> GetByPmText1(string pmText1, TransactionManager tm)
		{
			return GetByPmText1(pmText1, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 PmText1（字段） 查询
		/// </summary>
		/// <param name = "pmText1"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionsEO> GetByPmText1(string pmText1, int top)
		{
			return GetByPmText1(pmText1, top, string.Empty, null);
		}

		/// <summary>
		/// 按 PmText1（字段） 查询
		/// </summary>
		/// <param name = "pmText1"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionsEO> GetByPmText1(string pmText1, int top, TransactionManager tm)
		{
			return GetByPmText1(pmText1, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 PmText1（字段） 查询
		/// </summary>
		/// <param name = "pmText1"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionsEO> GetByPmText1(string pmText1, string sort)
		{
			return GetByPmText1(pmText1, 0, sort, null);
		}

		/// <summary>
		/// 按 PmText1（字段） 查询
		/// </summary>
		/// <param name = "pmText1"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionsEO> GetByPmText1(string pmText1, string sort, TransactionManager tm)
		{
			return GetByPmText1(pmText1, 0, sort, tm);
		}

		/// <summary>
		/// 按 PmText1（字段） 查询
		/// </summary>
		/// <param name = "pmText1"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionsEO> GetByPmText1(string pmText1, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Pm_Id, Pm_name, Pm_addUser, Pm_addTime, Pm_state, Pm_del, Pm_text1, Pm_text2 FROM permissions WHERE Pm_text1=@PmText1";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@PmText1", pmText1, DbType.String, 600)
							.ExecList<PermissionsEO>(PermissionsEO.GetItem, tm);
		}

		#endregion

		#region  按 PmText2（字段） 查询

		/// <summary>
		/// 按 PmText2（字段） 查询
		/// </summary>
		/// <param name = "pmText2"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionsEO> GetByPmText2(string pmText2)
		{
			return GetByPmText2(pmText2, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 PmText2（字段） 查询
		/// </summary>
		/// <param name = "pmText2"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionsEO> GetByPmText2(string pmText2, TransactionManager tm)
		{
			return GetByPmText2(pmText2, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 PmText2（字段） 查询
		/// </summary>
		/// <param name = "pmText2"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionsEO> GetByPmText2(string pmText2, int top)
		{
			return GetByPmText2(pmText2, top, string.Empty, null);
		}

		/// <summary>
		/// 按 PmText2（字段） 查询
		/// </summary>
		/// <param name = "pmText2"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionsEO> GetByPmText2(string pmText2, int top, TransactionManager tm)
		{
			return GetByPmText2(pmText2, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 PmText2（字段） 查询
		/// </summary>
		/// <param name = "pmText2"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionsEO> GetByPmText2(string pmText2, string sort)
		{
			return GetByPmText2(pmText2, 0, sort, null);
		}

		/// <summary>
		/// 按 PmText2（字段） 查询
		/// </summary>
		/// <param name = "pmText2"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionsEO> GetByPmText2(string pmText2, string sort, TransactionManager tm)
		{
			return GetByPmText2(pmText2, 0, sort, tm);
		}

		/// <summary>
		/// 按 PmText2（字段） 查询
		/// </summary>
		/// <param name = "pmText2"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionsEO> GetByPmText2(string pmText2, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Pm_Id, Pm_name, Pm_addUser, Pm_addTime, Pm_state, Pm_del, Pm_text1, Pm_text2 FROM permissions WHERE Pm_text2=@PmText2";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@PmText2", pmText2, DbType.String, 600)
							.ExecList<PermissionsEO>(PermissionsEO.GetItem, tm);
		}

		#endregion

		#region  自定义条件查询

		/// <summary>
		/// 获取所有数据
		/// </summary>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionsEO> GetAll(TransactionManager tm = null)
		{
			return GetTopSort(string.Empty, null, -1, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "values">where子句中定义的参数值集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionsEO> Get(string where, params object[] values)
		{
			return GetTopSort(where, -1, string.Empty, null, values);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "paras">where子句中定义的参数集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionsEO> Get(string where, IEnumerable<DbParameter> paras)
		{
			return GetTopSort(where, paras, -1, string.Empty, null);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionsEO> Get(string where, TransactionManager tm)
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
		public virtual IEnumerable<PermissionsEO> Get(string where, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<PermissionsEO> Get(string where, IEnumerable<DbParameter> paras, TransactionManager tm)
		{
			return GetTopSort(where, paras, -1, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionsEO> GetTop(string where, int top)
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
		public virtual IEnumerable<PermissionsEO> GetTop(string where, int top, params object[] values)
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
		public virtual IEnumerable<PermissionsEO> GetTop(string where, IEnumerable<DbParameter> paras, int top)
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
		public virtual IEnumerable<PermissionsEO> GetTop(string where, int top, TransactionManager tm)
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
		public virtual IEnumerable<PermissionsEO> GetTop(string where, int top, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<PermissionsEO> GetTop(string where, IEnumerable<DbParameter> paras, int top, TransactionManager tm)
		{
			return GetTopSort(where, paras, top, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionsEO> GetSort(string where, string sort)
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
		public virtual IEnumerable<PermissionsEO> GetSort(string where, string sort, params object[] values)
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
		public virtual IEnumerable<PermissionsEO> GetSort(string where, IEnumerable<DbParameter> paras, string sort)
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
		public virtual IEnumerable<PermissionsEO> GetSort(string where, string sort, TransactionManager tm)
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
		public virtual IEnumerable<PermissionsEO> GetSort(string where, string sort, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<PermissionsEO> GetSort(string where, IEnumerable<DbParameter> paras, string sort, TransactionManager tm)
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
		public virtual IEnumerable<PermissionsEO> GetTopSort(string where, int top, string sort)
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
		public virtual IEnumerable<PermissionsEO> GetTopSort(string where, int top, string sort, params object[] values)
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
		public virtual IEnumerable<PermissionsEO> GetTopSort(string where, IEnumerable<DbParameter> paras, int top, string sort)
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
		public virtual IEnumerable<PermissionsEO> GetTopSort(string where, int top, string sort, TransactionManager tm)
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
		public virtual IEnumerable<PermissionsEO> GetTopSort(string where, int top, string sort, TransactionManager tm, params object[] values)
		{
			const string format = @"SELECT {0} Pm_Id, Pm_name, Pm_addUser, Pm_addTime, Pm_state, Pm_del, Pm_text1, Pm_text2 FROM permissions";
			string sql = format;

			if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameters(values)
							.ExecList<PermissionsEO>(PermissionsEO.GetItem, tm);
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
		public virtual IEnumerable<PermissionsEO> GetTopSort(string where, IEnumerable<DbParameter> paras, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Pm_Id, Pm_name, Pm_addUser, Pm_addTime, Pm_state, Pm_del, Pm_text1, Pm_text2 FROM permissions";
			string sql = format;

			if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddParameters(paras)
							.ExecList<PermissionsEO>(PermissionsEO.GetItem, tm);
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
			const string format = @"SELECT Pm_Id, Pm_name, Pm_addUser, Pm_addTime, Pm_state, Pm_del, Pm_text1, Pm_text2 FROM permissions {0} {1}";
			 string sql = string.Format(format, string.IsNullOrEmpty(where) ? string.Empty : "WHERE " + where, string.IsNullOrEmpty(sort) ? string.Empty : "ORDER BY " + sort);

			return Database.CreatePager(sql, pageSize, "Pm_Id");
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
		public virtual List<PermissionsEO> GetPageList(int pageIndex , int pageSize, string where = null, string sort = null, IEnumerable<DbParameter> paras = null)
		{
			var pager = GetPager(pageSize, where, sort);

			pager.AddParameters(paras);
			return pager.GetPageList<PermissionsEO>(pageIndex);
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
		public virtual IEnumerable<PermissionsEO> GetPageMutil(int pageIndex , int pageSize, string where = null, string sort = null, IEnumerable<DbParameter> paras = null)
		{
			var pager = GetPager(pageSize, where, sort);

			pager.AddParameters(paras);
			return pager.GetPageMutil<PermissionsEO>(pageIndex);
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
		public virtual int Add(PermissionsEO item, TransactionManager tm = null)
		{
			const string sql = @"INSERT INTO permissions (Pm_Id, Pm_name, Pm_addUser, Pm_addTime, Pm_state, Pm_del, Pm_text1, Pm_text2) VALUES (@Pm_Id, @Pm_name, @Pm_addUser, @Pm_addTime, @Pm_state, @Pm_del, @Pm_text1, @Pm_text2) ";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pm_Id", item.PmId, DbType.String, 150)
							.AddInParameter("@Pm_name", item.PmName != null ?  (object)item.PmName : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Pm_addUser", item.PmAddUser != null ?  (object)item.PmAddUser : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Pm_addTime", item.PmAddTime, DbType.DateTime, 0)
							.AddInParameter("@Pm_state", item.PmState != null ?  (object)item.PmState : DBNull.Value, DbType.String, 3)
							.AddInParameter("@Pm_del", item.PmDel != null ?  (object)item.PmDel : DBNull.Value, DbType.String, 3)
							.AddInParameter("@Pm_text1", item.PmText1 != null ?  (object)item.PmText1 : DBNull.Value, DbType.String, 600)
							.AddInParameter("@Pm_text2", item.PmText2 != null ?  (object)item.PmText2 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 插入一组数据
		/// </summary>
		/// <param name = "items">要插入的实体对象集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Add(IEnumerable<PermissionsEO> items, TransactionManager tm = null)
		{
			int ret = 0;
			const string sql = @"INSERT INTO permissions (Pm_Id, Pm_name, Pm_addUser, Pm_addTime, Pm_state, Pm_del, Pm_text1, Pm_text2) VALUES (@Pm_Id, @Pm_name, @Pm_addUser, @Pm_addTime, @Pm_state, @Pm_del, @Pm_text1, @Pm_text2) ";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@Pm_Id", DbType.String, 150)
									.AddParameter("@Pm_name", DbType.String, 150)
									.AddParameter("@Pm_addUser", DbType.String, 150)
									.AddParameter("@Pm_addTime", DbType.DateTime, 0)
									.AddParameter("@Pm_state", DbType.String, 3)
									.AddParameter("@Pm_del", DbType.String, 3)
									.AddParameter("@Pm_text1", DbType.String, 600)
									.AddParameter("@Pm_text2", DbType.String, 600);

			foreach (PermissionsEO item in items)
			{
				sqlDao
					.SetParameterValue("@Pm_Id", item.PmId)
					.SetParameterValue("@Pm_name", item.PmName != null ?  (object)item.PmName : DBNull.Value)
					.SetParameterValue("@Pm_addUser", item.PmAddUser != null ?  (object)item.PmAddUser : DBNull.Value)
					.SetParameterValue("@Pm_addTime", item.PmAddTime)
					.SetParameterValue("@Pm_state", item.PmState != null ?  (object)item.PmState : DBNull.Value)
					.SetParameterValue("@Pm_del", item.PmDel != null ?  (object)item.PmDel : DBNull.Value)
					.SetParameterValue("@Pm_text1", item.PmText1 != null ?  (object)item.PmText1 : DBNull.Value)
					.SetParameterValue("@Pm_text2", item.PmText2 != null ?  (object)item.PmText2 : DBNull.Value)
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
		public virtual int Put(PermissionsEO item, TransactionManager tm = null)
		{
			const string sql = @"UPDATE permissions SET Pm_Id=@Pm_Id, Pm_name=@Pm_name, Pm_addUser=@Pm_addUser, Pm_addTime=@Pm_addTime, Pm_state=@Pm_state, Pm_del=@Pm_del, Pm_text1=@Pm_text1, Pm_text2=@Pm_text2 WHERE Pm_Id=@OriginalPm_Id";
			return Database.CreateSqlDao (sql)
							.AddInParameter("@OriginalPmId", (item.HasOriginal) ? item.OriginalPmId : item.PmId, DbType.String, 150)
							.AddInParameter("@Pm_Id", item.PmId, DbType.String, 150)
							.AddInParameter("@Pm_name", item.PmName != null ?  (object)item.PmName : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Pm_addUser", item.PmAddUser != null ?  (object)item.PmAddUser : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Pm_addTime", item.PmAddTime, DbType.DateTime, 0)
							.AddInParameter("@Pm_state", item.PmState != null ?  (object)item.PmState : DBNull.Value, DbType.String, 3)
							.AddInParameter("@Pm_del", item.PmDel != null ?  (object)item.PmDel : DBNull.Value, DbType.String, 3)
							.AddInParameter("@Pm_text1", item.PmText1 != null ?  (object)item.PmText1 : DBNull.Value, DbType.String, 600)
							.AddInParameter("@Pm_text2", item.PmText2 != null ?  (object)item.PmText2 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}


		/// <summary>
		/// 更新数据
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Put(IEnumerable<PermissionsEO> items, TransactionManager tm = null)
		{

			int ret = 0;
			const string sql = @"UPDATE permissions SET Pm_Id=@Pm_Id, Pm_name=@Pm_name, Pm_addUser=@Pm_addUser, Pm_addTime=@Pm_addTime, Pm_state=@Pm_state, Pm_del=@Pm_del, Pm_text1=@Pm_text1, Pm_text2=@Pm_text2 WHERE Pm_Id=@OriginalPm_Id";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@OriginalPmId", DbType.String, 150)
									.AddParameter("@Pm_Id", DbType.String, 150)
									.AddParameter("@Pm_name", DbType.String, 150)
									.AddParameter("@Pm_addUser", DbType.String, 150)
									.AddParameter("@Pm_addTime", DbType.DateTime, 0)
									.AddParameter("@Pm_state", DbType.String, 3)
									.AddParameter("@Pm_del", DbType.String, 3)
									.AddParameter("@Pm_text1", DbType.String, 600)
									.AddParameter("@Pm_text2", DbType.String, 600);

			foreach (PermissionsEO item in items)
			{
				ret += sqlDao
							.SetParameterValue("@OriginalPmId", (item.HasOriginal) ? item.OriginalPmId : item.PmId)
							.SetParameterValue("@Pm_Id", item.PmId)
							.SetParameterValue("@Pm_name", item.PmName != null ?  (object)item.PmName : DBNull.Value)
							.SetParameterValue("@Pm_addUser", item.PmAddUser != null ?  (object)item.PmAddUser : DBNull.Value)
							.SetParameterValue("@Pm_addTime", item.PmAddTime)
							.SetParameterValue("@Pm_state", item.PmState != null ?  (object)item.PmState : DBNull.Value)
							.SetParameterValue("@Pm_del", item.PmDel != null ?  (object)item.PmDel : DBNull.Value)
							.SetParameterValue("@Pm_text1", item.PmText1 != null ?  (object)item.PmText1 : DBNull.Value)
							.SetParameterValue("@Pm_text2", item.PmText2 != null ?  (object)item.PmText2 : DBNull.Value)
							.ExecNonQuery(tm);
			}
			return ret;
		}


		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "pmId"></param>
		/// <param name = "pmName"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutPmNameByPK(string pmId, string pmName, TransactionManager tm = null)
		{
			const string sql = @"UPDATE permissions SET Pm_name = @Pm_name  WHERE Pm_Id = @Pm_Id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pm_Id", pmId, DbType.String, 150)
							.AddInParameter("@Pm_name", pmName != null ?  (object)pmName : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "pmId"></param>
		/// <param name = "pmAddUser"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutPmAddUserByPK(string pmId, string pmAddUser, TransactionManager tm = null)
		{
			const string sql = @"UPDATE permissions SET Pm_addUser = @Pm_addUser  WHERE Pm_Id = @Pm_Id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pm_Id", pmId, DbType.String, 150)
							.AddInParameter("@Pm_addUser", pmAddUser != null ?  (object)pmAddUser : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "pmId"></param>
		/// <param name = "pmAddTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutPmAddTimeByPK(string pmId, DateTime pmAddTime, TransactionManager tm = null)
		{
			const string sql = @"UPDATE permissions SET Pm_addTime = @Pm_addTime  WHERE Pm_Id = @Pm_Id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pm_Id", pmId, DbType.String, 150)
							.AddInParameter("@Pm_addTime", pmAddTime, DbType.DateTime, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "pmId"></param>
		/// <param name = "pmState"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutPmStateByPK(string pmId, string pmState, TransactionManager tm = null)
		{
			const string sql = @"UPDATE permissions SET Pm_state = @Pm_state  WHERE Pm_Id = @Pm_Id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pm_Id", pmId, DbType.String, 150)
							.AddInParameter("@Pm_state", pmState != null ?  (object)pmState : DBNull.Value, DbType.String, 3)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "pmId"></param>
		/// <param name = "pmDel"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutPmDelByPK(string pmId, string pmDel, TransactionManager tm = null)
		{
			const string sql = @"UPDATE permissions SET Pm_del = @Pm_del  WHERE Pm_Id = @Pm_Id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pm_Id", pmId, DbType.String, 150)
							.AddInParameter("@Pm_del", pmDel != null ?  (object)pmDel : DBNull.Value, DbType.String, 3)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "pmId"></param>
		/// <param name = "pmText1"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutPmText1ByPK(string pmId, string pmText1, TransactionManager tm = null)
		{
			const string sql = @"UPDATE permissions SET Pm_text1 = @Pm_text1  WHERE Pm_Id = @Pm_Id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pm_Id", pmId, DbType.String, 150)
							.AddInParameter("@Pm_text1", pmText1 != null ?  (object)pmText1 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "pmId"></param>
		/// <param name = "pmText2"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutPmText2ByPK(string pmId, string pmText2, TransactionManager tm = null)
		{
			const string sql = @"UPDATE permissions SET Pm_text2 = @Pm_text2  WHERE Pm_Id = @Pm_Id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pm_Id", pmId, DbType.String, 150)
							.AddInParameter("@Pm_text2", pmText2 != null ?  (object)pmText2 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}


		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "pmName"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutPmName(string pmName, TransactionManager tm = null)
		{
			const string sql = @"UPDATE permissions SET Pm_name=@Pm_name";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pm_name", pmName != null ?  (object)pmName : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "pmAddUser"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutPmAddUser(string pmAddUser, TransactionManager tm = null)
		{
			const string sql = @"UPDATE permissions SET Pm_addUser=@Pm_addUser";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pm_addUser", pmAddUser != null ?  (object)pmAddUser : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "pmAddTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutPmAddTime(DateTime pmAddTime, TransactionManager tm = null)
		{
			const string sql = @"UPDATE permissions SET Pm_addTime=@Pm_addTime";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pm_addTime", pmAddTime, DbType.DateTime, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "pmState"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutPmState(string pmState, TransactionManager tm = null)
		{
			const string sql = @"UPDATE permissions SET Pm_state=@Pm_state";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pm_state", pmState != null ?  (object)pmState : DBNull.Value, DbType.String, 3)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "pmDel"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutPmDel(string pmDel, TransactionManager tm = null)
		{
			const string sql = @"UPDATE permissions SET Pm_del=@Pm_del";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pm_del", pmDel != null ?  (object)pmDel : DBNull.Value, DbType.String, 3)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "pmText1"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutPmText1(string pmText1, TransactionManager tm = null)
		{
			const string sql = @"UPDATE permissions SET Pm_text1=@Pm_text1";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pm_text1", pmText1 != null ?  (object)pmText1 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "pmText2"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutPmText2(string pmText2, TransactionManager tm = null)
		{
			const string sql = @"UPDATE permissions SET Pm_text2=@Pm_text2";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pm_text2", pmText2 != null ?  (object)pmText2 : DBNull.Value, DbType.String, 600)
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
			const string format = @"UPDATE permissions SET {0} {1}";
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
			const string format = @"UPDATE permissions SET {0} {1}";
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
		/// <param name = "pmId"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByPK(string pmId, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM permissions WHERE Pm_Id=@Pm_Id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pm_Id", pmId, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Remove(PermissionsEO item, TransactionManager tm = null)
		{
			return RemoveByPK(item.PmId, tm);
		}

		/// <summary>
		/// 删除指定实体集合对应的记录集
		/// </summary>
		/// <param name = "items">要删除的实体集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Remove(IEnumerable<PermissionsEO> items, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM permissions WHERE Pm_Id=@OriginalPm_Id";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@OriginalPmId", DbType.String, 150);
			int ret = 0;
			foreach (PermissionsEO item in items)
			{
				ret += sqlDao
							.SetParameterValue("@OriginalPmId", (item.HasOriginal) ? item.OriginalPmId : item.PmId)
							.ExecNonQuery(tm);
			}
			return ret;
		}




		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "pmName"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByPmName(string pmName, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM permissions WHERE Pm_name=@Pm_name";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pm_name", pmName != null ?  (object)pmName : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "pmAddUser"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByPmAddUser(string pmAddUser, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM permissions WHERE Pm_addUser=@Pm_addUser";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pm_addUser", pmAddUser != null ?  (object)pmAddUser : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "pmAddTime"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByPmAddTime(DateTime pmAddTime, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM permissions WHERE Pm_addTime=@Pm_addTime";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pm_addTime", pmAddTime, DbType.DateTime, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "pmState"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByPmState(string pmState, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM permissions WHERE Pm_state=@Pm_state";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pm_state", pmState != null ?  (object)pmState : DBNull.Value, DbType.String, 3)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "pmDel"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByPmDel(string pmDel, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM permissions WHERE Pm_del=@Pm_del";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pm_del", pmDel != null ?  (object)pmDel : DBNull.Value, DbType.String, 3)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "pmText1"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByPmText1(string pmText1, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM permissions WHERE Pm_text1=@Pm_text1";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pm_text1", pmText1 != null ?  (object)pmText1 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "pmText2"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByPmText2(string pmText2, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM permissions WHERE Pm_text2=@Pm_text2";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pm_text2", pmText2 != null ?  (object)pmText2 : DBNull.Value, DbType.String, 600)
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
			const string format = @"DELETE FROM permissions {0}";
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
			const string format = @"DELETE FROM permissions {0}";
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
