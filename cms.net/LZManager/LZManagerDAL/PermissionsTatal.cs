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
	/// 【表 permissionstatal 的实体类】
	/// </summary>
	[SerializableAttribute]
	public class PermissionstatalEO : DataEntityBase, IRowMapper<PermissionstatalEO>
	{
		protected string _originalPtId;

		/// <summary>
		/// 主键是否有原始值（即数据库中保存的值），用于实体对象更新时
		/// </summary>
		public bool HasOriginal { get; protected set; }

		/// <summary>
		/// 【主键 varchar】
		/// </summary>
		public virtual string PtId { get; set; }

		/// <summary>
		/// 【数据库中的原始主键值副本】
		/// </summary>
		public virtual string OriginalPtId
		{
			get { return _originalPtId; }
			set { HasOriginal = true; _originalPtId = value; }
		}

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string PtName { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string PfId { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string PtAddUser { get; set; }

		/// <summary>
		/// 【字段 datetime】
		/// </summary>
		public virtual DateTime PtAddTime { get; set; }

		/// <summary>
		/// 【字段 char】
		/// </summary>
		public virtual string PtState { get; set; }

		/// <summary>
		/// 【字段 char】
		/// </summary>
		public virtual string PtDel { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string PtText1 { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string PtText2 { get; set; }

		/// <summary>
		/// 默认构造函数
		/// </summary>
		public PermissionstatalEO() 
		{
			PtId = string.Empty;
		}

		/// <summary>
		/// 自定义构造函数
		/// </summary>
		/// <param name = "ptId"></param>
		/// <param name = "ptName"></param>
		/// <param name = "pfId"></param>
		/// <param name = "ptAddUser"></param>
		/// <param name = "ptAddTime"></param>
		/// <param name = "ptState"></param>
		/// <param name = "ptDel"></param>
		/// <param name = "ptText1"></param>
		/// <param name = "ptText2"></param>
		public PermissionstatalEO(string ptId, string ptName, string pfId, string ptAddUser, DateTime ptAddTime, string ptState, string ptDel, string ptText1, string ptText2) 
		{
			PtId = ptId;
			PtName = ptName;
			PfId = pfId;
			PtAddUser = ptAddUser;
			PtAddTime = ptAddTime;
			PtState = ptState;
			PtDel = ptDel;
			PtText1 = ptText1;
			PtText2 = ptText2;
		}

		/// <summary>
		/// 将结果集映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public PermissionstatalEO MapRow(IDataReader reader)
		{
			return GetItem(reader);
		}

		/// <summary>
		/// 将结果集映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static PermissionstatalEO GetItem(IDataReader reader)
		{
			PermissionstatalEO ret = new PermissionstatalEO();

			ret.PtId = (string)reader["Pt_id"];
			ret.OriginalPtId = ret.PtId;
			ret.PtName = (reader["Pt_name"] is DBNull) ? null : (string)reader["Pt_name"];
			ret.PfId = (reader["Pf_id"] is DBNull) ? null : (string)reader["Pf_id"];
			ret.PtAddUser = (reader["Pt_addUser"] is DBNull) ? null : (string)reader["Pt_addUser"];
			ret.PtAddTime = DateTime.Parse(reader["Pt_addTime"].ToString());
			ret.PtState = (reader["Pt_state"] is DBNull) ? null : (string)reader["Pt_state"];
			ret.PtDel = (reader["Pt_del"] is DBNull) ? null : (string)reader["Pt_del"];
			ret.PtText1 = (reader["Pt_text1"] is DBNull) ? null : (string)reader["Pt_text1"];
			ret.PtText2 = (reader["Pt_text2"] is DBNull) ? null : (string)reader["Pt_text2"];
			return ret;
		}
	}


	#endregion

	#region  MO

	/// <summary>
	/// 【表 permissionstatal 的操作类】
	/// </summary>
    public partial class PermissionstatalMO : DataManagerBase
	{

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "routeData">路由数据</param>
		public PermissionstatalMO(object routeData = null) : base(routeData) { }

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">连接字符串名称</param>
		public PermissionstatalMO(string connectionStringName) : base(connectionStringName) { }

		#region  Get方法集合

		/// <summary>
		/// 按 PK（主键） 查询
		/// </summary>
		/// <param name="tm">事务管理对象</param>
		/// <param name = "ptId"></param>
		/// <return></return>
		public virtual PermissionstatalEO GetByPK(string ptId, TransactionManager tm = null)
		{
			const string sql = @"SELECT Pt_id, Pt_name, Pf_id, Pt_addUser, Pt_addTime, Pt_state, Pt_del, Pt_text1, Pt_text2 FROM permissionstatal WHERE Pt_id=@Pt_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pt_id", ptId, DbType.String, 150)
							.ExecSingle<PermissionstatalEO>(PermissionstatalEO.GetItem, tm);
		}




		#region  按 PtName（字段） 查询

		/// <summary>
		/// 按 PtName（字段） 查询
		/// </summary>
		/// <param name = "ptName"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalEO> GetByPtName(string ptName)
		{
			return GetByPtName(ptName, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 PtName（字段） 查询
		/// </summary>
		/// <param name = "ptName"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalEO> GetByPtName(string ptName, TransactionManager tm)
		{
			return GetByPtName(ptName, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 PtName（字段） 查询
		/// </summary>
		/// <param name = "ptName"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalEO> GetByPtName(string ptName, int top)
		{
			return GetByPtName(ptName, top, string.Empty, null);
		}

		/// <summary>
		/// 按 PtName（字段） 查询
		/// </summary>
		/// <param name = "ptName"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalEO> GetByPtName(string ptName, int top, TransactionManager tm)
		{
			return GetByPtName(ptName, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 PtName（字段） 查询
		/// </summary>
		/// <param name = "ptName"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalEO> GetByPtName(string ptName, string sort)
		{
			return GetByPtName(ptName, 0, sort, null);
		}

		/// <summary>
		/// 按 PtName（字段） 查询
		/// </summary>
		/// <param name = "ptName"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalEO> GetByPtName(string ptName, string sort, TransactionManager tm)
		{
			return GetByPtName(ptName, 0, sort, tm);
		}

		/// <summary>
		/// 按 PtName（字段） 查询
		/// </summary>
		/// <param name = "ptName"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalEO> GetByPtName(string ptName, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Pt_id, Pt_name, Pf_id, Pt_addUser, Pt_addTime, Pt_state, Pt_del, Pt_text1, Pt_text2 FROM permissionstatal WHERE Pt_name=@PtName";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@PtName", ptName, DbType.String, 150)
							.ExecList<PermissionstatalEO>(PermissionstatalEO.GetItem, tm);
		}

		#endregion

		#region  按 PfId（字段） 查询

		/// <summary>
		/// 按 PfId（字段） 查询
		/// </summary>
		/// <param name = "pfId"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalEO> GetByPfId(string pfId)
		{
			return GetByPfId(pfId, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 PfId（字段） 查询
		/// </summary>
		/// <param name = "pfId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalEO> GetByPfId(string pfId, TransactionManager tm)
		{
			return GetByPfId(pfId, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 PfId（字段） 查询
		/// </summary>
		/// <param name = "pfId"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalEO> GetByPfId(string pfId, int top)
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
		public virtual IEnumerable<PermissionstatalEO> GetByPfId(string pfId, int top, TransactionManager tm)
		{
			return GetByPfId(pfId, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 PfId（字段） 查询
		/// </summary>
		/// <param name = "pfId"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalEO> GetByPfId(string pfId, string sort)
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
		public virtual IEnumerable<PermissionstatalEO> GetByPfId(string pfId, string sort, TransactionManager tm)
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
		public virtual IEnumerable<PermissionstatalEO> GetByPfId(string pfId, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Pt_id, Pt_name, Pf_id, Pt_addUser, Pt_addTime, Pt_state, Pt_del, Pt_text1, Pt_text2 FROM permissionstatal WHERE Pf_id=@PfId";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@PfId", pfId, DbType.String, 150)
							.ExecList<PermissionstatalEO>(PermissionstatalEO.GetItem, tm);
		}

		#endregion

		#region  按 PtAddUser（字段） 查询

		/// <summary>
		/// 按 PtAddUser（字段） 查询
		/// </summary>
		/// <param name = "ptAddUser"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalEO> GetByPtAddUser(string ptAddUser)
		{
			return GetByPtAddUser(ptAddUser, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 PtAddUser（字段） 查询
		/// </summary>
		/// <param name = "ptAddUser"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalEO> GetByPtAddUser(string ptAddUser, TransactionManager tm)
		{
			return GetByPtAddUser(ptAddUser, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 PtAddUser（字段） 查询
		/// </summary>
		/// <param name = "ptAddUser"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalEO> GetByPtAddUser(string ptAddUser, int top)
		{
			return GetByPtAddUser(ptAddUser, top, string.Empty, null);
		}

		/// <summary>
		/// 按 PtAddUser（字段） 查询
		/// </summary>
		/// <param name = "ptAddUser"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalEO> GetByPtAddUser(string ptAddUser, int top, TransactionManager tm)
		{
			return GetByPtAddUser(ptAddUser, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 PtAddUser（字段） 查询
		/// </summary>
		/// <param name = "ptAddUser"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalEO> GetByPtAddUser(string ptAddUser, string sort)
		{
			return GetByPtAddUser(ptAddUser, 0, sort, null);
		}

		/// <summary>
		/// 按 PtAddUser（字段） 查询
		/// </summary>
		/// <param name = "ptAddUser"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalEO> GetByPtAddUser(string ptAddUser, string sort, TransactionManager tm)
		{
			return GetByPtAddUser(ptAddUser, 0, sort, tm);
		}

		/// <summary>
		/// 按 PtAddUser（字段） 查询
		/// </summary>
		/// <param name = "ptAddUser"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalEO> GetByPtAddUser(string ptAddUser, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Pt_id, Pt_name, Pf_id, Pt_addUser, Pt_addTime, Pt_state, Pt_del, Pt_text1, Pt_text2 FROM permissionstatal WHERE Pt_addUser=@PtAddUser";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@PtAddUser", ptAddUser, DbType.String, 150)
							.ExecList<PermissionstatalEO>(PermissionstatalEO.GetItem, tm);
		}

		#endregion

		#region  按 PtAddTime（字段） 查询

		/// <summary>
		/// 按 PtAddTime（字段） 查询
		/// </summary>
		/// <param name = "ptAddTime"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalEO> GetByPtAddTime(DateTime ptAddTime)
		{
			return GetByPtAddTime(ptAddTime, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 PtAddTime（字段） 查询
		/// </summary>
		/// <param name = "ptAddTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalEO> GetByPtAddTime(DateTime ptAddTime, TransactionManager tm)
		{
			return GetByPtAddTime(ptAddTime, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 PtAddTime（字段） 查询
		/// </summary>
		/// <param name = "ptAddTime"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalEO> GetByPtAddTime(DateTime ptAddTime, int top)
		{
			return GetByPtAddTime(ptAddTime, top, string.Empty, null);
		}

		/// <summary>
		/// 按 PtAddTime（字段） 查询
		/// </summary>
		/// <param name = "ptAddTime"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalEO> GetByPtAddTime(DateTime ptAddTime, int top, TransactionManager tm)
		{
			return GetByPtAddTime(ptAddTime, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 PtAddTime（字段） 查询
		/// </summary>
		/// <param name = "ptAddTime"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalEO> GetByPtAddTime(DateTime ptAddTime, string sort)
		{
			return GetByPtAddTime(ptAddTime, 0, sort, null);
		}

		/// <summary>
		/// 按 PtAddTime（字段） 查询
		/// </summary>
		/// <param name = "ptAddTime"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalEO> GetByPtAddTime(DateTime ptAddTime, string sort, TransactionManager tm)
		{
			return GetByPtAddTime(ptAddTime, 0, sort, tm);
		}

		/// <summary>
		/// 按 PtAddTime（字段） 查询
		/// </summary>
		/// <param name = "ptAddTime"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalEO> GetByPtAddTime(DateTime ptAddTime, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Pt_id, Pt_name, Pf_id, Pt_addUser, Pt_addTime, Pt_state, Pt_del, Pt_text1, Pt_text2 FROM permissionstatal WHERE Pt_addTime=@PtAddTime";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@PtAddTime", ptAddTime, DbType.DateTime, 0)
							.ExecList<PermissionstatalEO>(PermissionstatalEO.GetItem, tm);
		}

		#endregion

		#region  按 PtState（字段） 查询

		/// <summary>
		/// 按 PtState（字段） 查询
		/// </summary>
		/// <param name = "ptState"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalEO> GetByPtState(string ptState)
		{
			return GetByPtState(ptState, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 PtState（字段） 查询
		/// </summary>
		/// <param name = "ptState"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalEO> GetByPtState(string ptState, TransactionManager tm)
		{
			return GetByPtState(ptState, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 PtState（字段） 查询
		/// </summary>
		/// <param name = "ptState"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalEO> GetByPtState(string ptState, int top)
		{
			return GetByPtState(ptState, top, string.Empty, null);
		}

		/// <summary>
		/// 按 PtState（字段） 查询
		/// </summary>
		/// <param name = "ptState"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalEO> GetByPtState(string ptState, int top, TransactionManager tm)
		{
			return GetByPtState(ptState, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 PtState（字段） 查询
		/// </summary>
		/// <param name = "ptState"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalEO> GetByPtState(string ptState, string sort)
		{
			return GetByPtState(ptState, 0, sort, null);
		}

		/// <summary>
		/// 按 PtState（字段） 查询
		/// </summary>
		/// <param name = "ptState"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalEO> GetByPtState(string ptState, string sort, TransactionManager tm)
		{
			return GetByPtState(ptState, 0, sort, tm);
		}

		/// <summary>
		/// 按 PtState（字段） 查询
		/// </summary>
		/// <param name = "ptState"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalEO> GetByPtState(string ptState, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Pt_id, Pt_name, Pf_id, Pt_addUser, Pt_addTime, Pt_state, Pt_del, Pt_text1, Pt_text2 FROM permissionstatal WHERE Pt_state=@PtState";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@PtState", ptState, DbType.String, 3)
							.ExecList<PermissionstatalEO>(PermissionstatalEO.GetItem, tm);
		}

		#endregion

		#region  按 PtDel（字段） 查询

		/// <summary>
		/// 按 PtDel（字段） 查询
		/// </summary>
		/// <param name = "ptDel"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalEO> GetByPtDel(string ptDel)
		{
			return GetByPtDel(ptDel, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 PtDel（字段） 查询
		/// </summary>
		/// <param name = "ptDel"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalEO> GetByPtDel(string ptDel, TransactionManager tm)
		{
			return GetByPtDel(ptDel, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 PtDel（字段） 查询
		/// </summary>
		/// <param name = "ptDel"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalEO> GetByPtDel(string ptDel, int top)
		{
			return GetByPtDel(ptDel, top, string.Empty, null);
		}

		/// <summary>
		/// 按 PtDel（字段） 查询
		/// </summary>
		/// <param name = "ptDel"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalEO> GetByPtDel(string ptDel, int top, TransactionManager tm)
		{
			return GetByPtDel(ptDel, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 PtDel（字段） 查询
		/// </summary>
		/// <param name = "ptDel"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalEO> GetByPtDel(string ptDel, string sort)
		{
			return GetByPtDel(ptDel, 0, sort, null);
		}

		/// <summary>
		/// 按 PtDel（字段） 查询
		/// </summary>
		/// <param name = "ptDel"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalEO> GetByPtDel(string ptDel, string sort, TransactionManager tm)
		{
			return GetByPtDel(ptDel, 0, sort, tm);
		}

		/// <summary>
		/// 按 PtDel（字段） 查询
		/// </summary>
		/// <param name = "ptDel"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalEO> GetByPtDel(string ptDel, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Pt_id, Pt_name, Pf_id, Pt_addUser, Pt_addTime, Pt_state, Pt_del, Pt_text1, Pt_text2 FROM permissionstatal WHERE Pt_del=@PtDel";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@PtDel", ptDel, DbType.String, 3)
							.ExecList<PermissionstatalEO>(PermissionstatalEO.GetItem, tm);
		}

		#endregion

		#region  按 PtText1（字段） 查询

		/// <summary>
		/// 按 PtText1（字段） 查询
		/// </summary>
		/// <param name = "ptText1"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalEO> GetByPtText1(string ptText1)
		{
			return GetByPtText1(ptText1, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 PtText1（字段） 查询
		/// </summary>
		/// <param name = "ptText1"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalEO> GetByPtText1(string ptText1, TransactionManager tm)
		{
			return GetByPtText1(ptText1, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 PtText1（字段） 查询
		/// </summary>
		/// <param name = "ptText1"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalEO> GetByPtText1(string ptText1, int top)
		{
			return GetByPtText1(ptText1, top, string.Empty, null);
		}

		/// <summary>
		/// 按 PtText1（字段） 查询
		/// </summary>
		/// <param name = "ptText1"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalEO> GetByPtText1(string ptText1, int top, TransactionManager tm)
		{
			return GetByPtText1(ptText1, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 PtText1（字段） 查询
		/// </summary>
		/// <param name = "ptText1"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalEO> GetByPtText1(string ptText1, string sort)
		{
			return GetByPtText1(ptText1, 0, sort, null);
		}

		/// <summary>
		/// 按 PtText1（字段） 查询
		/// </summary>
		/// <param name = "ptText1"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalEO> GetByPtText1(string ptText1, string sort, TransactionManager tm)
		{
			return GetByPtText1(ptText1, 0, sort, tm);
		}

		/// <summary>
		/// 按 PtText1（字段） 查询
		/// </summary>
		/// <param name = "ptText1"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalEO> GetByPtText1(string ptText1, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Pt_id, Pt_name, Pf_id, Pt_addUser, Pt_addTime, Pt_state, Pt_del, Pt_text1, Pt_text2 FROM permissionstatal WHERE Pt_text1=@PtText1";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@PtText1", ptText1, DbType.String, 600)
							.ExecList<PermissionstatalEO>(PermissionstatalEO.GetItem, tm);
		}

		#endregion

		#region  按 PtText2（字段） 查询

		/// <summary>
		/// 按 PtText2（字段） 查询
		/// </summary>
		/// <param name = "ptText2"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalEO> GetByPtText2(string ptText2)
		{
			return GetByPtText2(ptText2, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 PtText2（字段） 查询
		/// </summary>
		/// <param name = "ptText2"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalEO> GetByPtText2(string ptText2, TransactionManager tm)
		{
			return GetByPtText2(ptText2, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 PtText2（字段） 查询
		/// </summary>
		/// <param name = "ptText2"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalEO> GetByPtText2(string ptText2, int top)
		{
			return GetByPtText2(ptText2, top, string.Empty, null);
		}

		/// <summary>
		/// 按 PtText2（字段） 查询
		/// </summary>
		/// <param name = "ptText2"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalEO> GetByPtText2(string ptText2, int top, TransactionManager tm)
		{
			return GetByPtText2(ptText2, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 PtText2（字段） 查询
		/// </summary>
		/// <param name = "ptText2"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalEO> GetByPtText2(string ptText2, string sort)
		{
			return GetByPtText2(ptText2, 0, sort, null);
		}

		/// <summary>
		/// 按 PtText2（字段） 查询
		/// </summary>
		/// <param name = "ptText2"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalEO> GetByPtText2(string ptText2, string sort, TransactionManager tm)
		{
			return GetByPtText2(ptText2, 0, sort, tm);
		}

		/// <summary>
		/// 按 PtText2（字段） 查询
		/// </summary>
		/// <param name = "ptText2"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalEO> GetByPtText2(string ptText2, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Pt_id, Pt_name, Pf_id, Pt_addUser, Pt_addTime, Pt_state, Pt_del, Pt_text1, Pt_text2 FROM permissionstatal WHERE Pt_text2=@PtText2";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@PtText2", ptText2, DbType.String, 600)
							.ExecList<PermissionstatalEO>(PermissionstatalEO.GetItem, tm);
		}

		#endregion

		#region  自定义条件查询

		/// <summary>
		/// 获取所有数据
		/// </summary>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalEO> GetAll(TransactionManager tm = null)
		{
			return GetTopSort(string.Empty, null, -1, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "values">where子句中定义的参数值集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalEO> Get(string where, params object[] values)
		{
			return GetTopSort(where, -1, string.Empty, null, values);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "paras">where子句中定义的参数集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalEO> Get(string where, IEnumerable<DbParameter> paras)
		{
			return GetTopSort(where, paras, -1, string.Empty, null);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalEO> Get(string where, TransactionManager tm)
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
		public virtual IEnumerable<PermissionstatalEO> Get(string where, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<PermissionstatalEO> Get(string where, IEnumerable<DbParameter> paras, TransactionManager tm)
		{
			return GetTopSort(where, paras, -1, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalEO> GetTop(string where, int top)
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
		public virtual IEnumerable<PermissionstatalEO> GetTop(string where, int top, params object[] values)
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
		public virtual IEnumerable<PermissionstatalEO> GetTop(string where, IEnumerable<DbParameter> paras, int top)
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
		public virtual IEnumerable<PermissionstatalEO> GetTop(string where, int top, TransactionManager tm)
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
		public virtual IEnumerable<PermissionstatalEO> GetTop(string where, int top, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<PermissionstatalEO> GetTop(string where, IEnumerable<DbParameter> paras, int top, TransactionManager tm)
		{
			return GetTopSort(where, paras, top, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalEO> GetSort(string where, string sort)
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
		public virtual IEnumerable<PermissionstatalEO> GetSort(string where, string sort, params object[] values)
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
		public virtual IEnumerable<PermissionstatalEO> GetSort(string where, IEnumerable<DbParameter> paras, string sort)
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
		public virtual IEnumerable<PermissionstatalEO> GetSort(string where, string sort, TransactionManager tm)
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
		public virtual IEnumerable<PermissionstatalEO> GetSort(string where, string sort, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<PermissionstatalEO> GetSort(string where, IEnumerable<DbParameter> paras, string sort, TransactionManager tm)
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
		public virtual IEnumerable<PermissionstatalEO> GetTopSort(string where, int top, string sort)
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
		public virtual IEnumerable<PermissionstatalEO> GetTopSort(string where, int top, string sort, params object[] values)
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
		public virtual IEnumerable<PermissionstatalEO> GetTopSort(string where, IEnumerable<DbParameter> paras, int top, string sort)
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
		public virtual IEnumerable<PermissionstatalEO> GetTopSort(string where, int top, string sort, TransactionManager tm)
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
		public virtual IEnumerable<PermissionstatalEO> GetTopSort(string where, int top, string sort, TransactionManager tm, params object[] values)
		{
			const string format = @"SELECT {0} Pt_id, Pt_name, Pf_id, Pt_addUser, Pt_addTime, Pt_state, Pt_del, Pt_text1, Pt_text2 FROM permissionstatal";
			string sql = format;

			if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameters(values)
							.ExecList<PermissionstatalEO>(PermissionstatalEO.GetItem, tm);
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
		public virtual IEnumerable<PermissionstatalEO> GetTopSort(string where, IEnumerable<DbParameter> paras, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Pt_id, Pt_name, Pf_id, Pt_addUser, Pt_addTime, Pt_state, Pt_del, Pt_text1, Pt_text2 FROM permissionstatal";
			string sql = format;

			if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddParameters(paras)
							.ExecList<PermissionstatalEO>(PermissionstatalEO.GetItem, tm);
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
			const string format = @"SELECT Pt_id, Pt_name, Pf_id, Pt_addUser, Pt_addTime, Pt_state, Pt_del, Pt_text1, Pt_text2 FROM permissionstatal {0} {1}";
			 string sql = string.Format(format, string.IsNullOrEmpty(where) ? string.Empty : "WHERE " + where, string.IsNullOrEmpty(sort) ? string.Empty : "ORDER BY " + sort);

			return Database.CreatePager(sql, pageSize, "Pt_id");
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
		public virtual List<PermissionstatalEO> GetPageList(int pageIndex , int pageSize, string where = null, string sort = null, IEnumerable<DbParameter> paras = null)
		{
			var pager = GetPager(pageSize, where, sort);

			pager.AddParameters(paras);
			return pager.GetPageList<PermissionstatalEO>(pageIndex);
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
		public virtual IEnumerable<PermissionstatalEO> GetPageMutil(int pageIndex , int pageSize, string where = null, string sort = null, IEnumerable<DbParameter> paras = null)
		{
			var pager = GetPager(pageSize, where, sort);

			pager.AddParameters(paras);
			return pager.GetPageMutil<PermissionstatalEO>(pageIndex);
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
		public virtual int Add(PermissionstatalEO item, TransactionManager tm = null)
		{
			const string sql = @"INSERT INTO permissionstatal (Pt_id, Pt_name, Pf_id, Pt_addUser, Pt_addTime, Pt_state, Pt_del, Pt_text1, Pt_text2) VALUES (@Pt_id, @Pt_name, @Pf_id, @Pt_addUser, @Pt_addTime, @Pt_state, @Pt_del, @Pt_text1, @Pt_text2) ";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pt_id", item.PtId, DbType.String, 150)
							.AddInParameter("@Pt_name", item.PtName != null ?  (object)item.PtName : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Pf_id", item.PfId != null ?  (object)item.PfId : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Pt_addUser", item.PtAddUser != null ?  (object)item.PtAddUser : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Pt_addTime", item.PtAddTime, DbType.DateTime, 0)
							.AddInParameter("@Pt_state", item.PtState != null ?  (object)item.PtState : DBNull.Value, DbType.String, 3)
							.AddInParameter("@Pt_del", item.PtDel != null ?  (object)item.PtDel : DBNull.Value, DbType.String, 3)
							.AddInParameter("@Pt_text1", item.PtText1 != null ?  (object)item.PtText1 : DBNull.Value, DbType.String, 600)
							.AddInParameter("@Pt_text2", item.PtText2 != null ?  (object)item.PtText2 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 插入一组数据
		/// </summary>
		/// <param name = "items">要插入的实体对象集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Add(IEnumerable<PermissionstatalEO> items, TransactionManager tm = null)
		{
			int ret = 0;
			const string sql = @"INSERT INTO permissionstatal (Pt_id, Pt_name, Pf_id, Pt_addUser, Pt_addTime, Pt_state, Pt_del, Pt_text1, Pt_text2) VALUES (@Pt_id, @Pt_name, @Pf_id, @Pt_addUser, @Pt_addTime, @Pt_state, @Pt_del, @Pt_text1, @Pt_text2) ";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@Pt_id", DbType.String, 150)
									.AddParameter("@Pt_name", DbType.String, 150)
									.AddParameter("@Pf_id", DbType.String, 150)
									.AddParameter("@Pt_addUser", DbType.String, 150)
									.AddParameter("@Pt_addTime", DbType.DateTime, 0)
									.AddParameter("@Pt_state", DbType.String, 3)
									.AddParameter("@Pt_del", DbType.String, 3)
									.AddParameter("@Pt_text1", DbType.String, 600)
									.AddParameter("@Pt_text2", DbType.String, 600);

			foreach (PermissionstatalEO item in items)
			{
				sqlDao
					.SetParameterValue("@Pt_id", item.PtId)
					.SetParameterValue("@Pt_name", item.PtName != null ?  (object)item.PtName : DBNull.Value)
					.SetParameterValue("@Pf_id", item.PfId != null ?  (object)item.PfId : DBNull.Value)
					.SetParameterValue("@Pt_addUser", item.PtAddUser != null ?  (object)item.PtAddUser : DBNull.Value)
					.SetParameterValue("@Pt_addTime", item.PtAddTime)
					.SetParameterValue("@Pt_state", item.PtState != null ?  (object)item.PtState : DBNull.Value)
					.SetParameterValue("@Pt_del", item.PtDel != null ?  (object)item.PtDel : DBNull.Value)
					.SetParameterValue("@Pt_text1", item.PtText1 != null ?  (object)item.PtText1 : DBNull.Value)
					.SetParameterValue("@Pt_text2", item.PtText2 != null ?  (object)item.PtText2 : DBNull.Value)
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
		public virtual int Put(PermissionstatalEO item, TransactionManager tm = null)
		{
			const string sql = @"UPDATE permissionstatal SET Pt_id=@Pt_id, Pt_name=@Pt_name, Pf_id=@Pf_id, Pt_addUser=@Pt_addUser, Pt_addTime=@Pt_addTime, Pt_state=@Pt_state, Pt_del=@Pt_del, Pt_text1=@Pt_text1, Pt_text2=@Pt_text2 WHERE Pt_id=@OriginalPt_id";
			return Database.CreateSqlDao (sql)
							.AddInParameter("@OriginalPtId", (item.HasOriginal) ? item.OriginalPtId : item.PtId, DbType.String, 150)
							.AddInParameter("@Pt_id", item.PtId, DbType.String, 150)
							.AddInParameter("@Pt_name", item.PtName != null ?  (object)item.PtName : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Pf_id", item.PfId != null ?  (object)item.PfId : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Pt_addUser", item.PtAddUser != null ?  (object)item.PtAddUser : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Pt_addTime", item.PtAddTime, DbType.DateTime, 0)
							.AddInParameter("@Pt_state", item.PtState != null ?  (object)item.PtState : DBNull.Value, DbType.String, 3)
							.AddInParameter("@Pt_del", item.PtDel != null ?  (object)item.PtDel : DBNull.Value, DbType.String, 3)
							.AddInParameter("@Pt_text1", item.PtText1 != null ?  (object)item.PtText1 : DBNull.Value, DbType.String, 600)
							.AddInParameter("@Pt_text2", item.PtText2 != null ?  (object)item.PtText2 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}


		/// <summary>
		/// 更新数据
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Put(IEnumerable<PermissionstatalEO> items, TransactionManager tm = null)
		{

			int ret = 0;
			const string sql = @"UPDATE permissionstatal SET Pt_id=@Pt_id, Pt_name=@Pt_name, Pf_id=@Pf_id, Pt_addUser=@Pt_addUser, Pt_addTime=@Pt_addTime, Pt_state=@Pt_state, Pt_del=@Pt_del, Pt_text1=@Pt_text1, Pt_text2=@Pt_text2 WHERE Pt_id=@OriginalPt_id";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@OriginalPtId", DbType.String, 150)
									.AddParameter("@Pt_id", DbType.String, 150)
									.AddParameter("@Pt_name", DbType.String, 150)
									.AddParameter("@Pf_id", DbType.String, 150)
									.AddParameter("@Pt_addUser", DbType.String, 150)
									.AddParameter("@Pt_addTime", DbType.DateTime, 0)
									.AddParameter("@Pt_state", DbType.String, 3)
									.AddParameter("@Pt_del", DbType.String, 3)
									.AddParameter("@Pt_text1", DbType.String, 600)
									.AddParameter("@Pt_text2", DbType.String, 600);

			foreach (PermissionstatalEO item in items)
			{
				ret += sqlDao
							.SetParameterValue("@OriginalPtId", (item.HasOriginal) ? item.OriginalPtId : item.PtId)
							.SetParameterValue("@Pt_id", item.PtId)
							.SetParameterValue("@Pt_name", item.PtName != null ?  (object)item.PtName : DBNull.Value)
							.SetParameterValue("@Pf_id", item.PfId != null ?  (object)item.PfId : DBNull.Value)
							.SetParameterValue("@Pt_addUser", item.PtAddUser != null ?  (object)item.PtAddUser : DBNull.Value)
							.SetParameterValue("@Pt_addTime", item.PtAddTime)
							.SetParameterValue("@Pt_state", item.PtState != null ?  (object)item.PtState : DBNull.Value)
							.SetParameterValue("@Pt_del", item.PtDel != null ?  (object)item.PtDel : DBNull.Value)
							.SetParameterValue("@Pt_text1", item.PtText1 != null ?  (object)item.PtText1 : DBNull.Value)
							.SetParameterValue("@Pt_text2", item.PtText2 != null ?  (object)item.PtText2 : DBNull.Value)
							.ExecNonQuery(tm);
			}
			return ret;
		}


		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "ptId"></param>
		/// <param name = "ptName"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutPtNameByPK(string ptId, string ptName, TransactionManager tm = null)
		{
			const string sql = @"UPDATE permissionstatal SET Pt_name = @Pt_name  WHERE Pt_id = @Pt_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pt_id", ptId, DbType.String, 150)
							.AddInParameter("@Pt_name", ptName != null ?  (object)ptName : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "ptId"></param>
		/// <param name = "pfId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutPfIdByPK(string ptId, string pfId, TransactionManager tm = null)
		{
			const string sql = @"UPDATE permissionstatal SET Pf_id = @Pf_id  WHERE Pt_id = @Pt_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pt_id", ptId, DbType.String, 150)
							.AddInParameter("@Pf_id", pfId != null ?  (object)pfId : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "ptId"></param>
		/// <param name = "ptAddUser"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutPtAddUserByPK(string ptId, string ptAddUser, TransactionManager tm = null)
		{
			const string sql = @"UPDATE permissionstatal SET Pt_addUser = @Pt_addUser  WHERE Pt_id = @Pt_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pt_id", ptId, DbType.String, 150)
							.AddInParameter("@Pt_addUser", ptAddUser != null ?  (object)ptAddUser : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "ptId"></param>
		/// <param name = "ptAddTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutPtAddTimeByPK(string ptId, DateTime ptAddTime, TransactionManager tm = null)
		{
			const string sql = @"UPDATE permissionstatal SET Pt_addTime = @Pt_addTime  WHERE Pt_id = @Pt_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pt_id", ptId, DbType.String, 150)
							.AddInParameter("@Pt_addTime", ptAddTime, DbType.DateTime, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "ptId"></param>
		/// <param name = "ptState"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutPtStateByPK(string ptId, string ptState, TransactionManager tm = null)
		{
			const string sql = @"UPDATE permissionstatal SET Pt_state = @Pt_state  WHERE Pt_id = @Pt_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pt_id", ptId, DbType.String, 150)
							.AddInParameter("@Pt_state", ptState != null ?  (object)ptState : DBNull.Value, DbType.String, 3)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "ptId"></param>
		/// <param name = "ptDel"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutPtDelByPK(string ptId, string ptDel, TransactionManager tm = null)
		{
			const string sql = @"UPDATE permissionstatal SET Pt_del = @Pt_del  WHERE Pt_id = @Pt_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pt_id", ptId, DbType.String, 150)
							.AddInParameter("@Pt_del", ptDel != null ?  (object)ptDel : DBNull.Value, DbType.String, 3)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "ptId"></param>
		/// <param name = "ptText1"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutPtText1ByPK(string ptId, string ptText1, TransactionManager tm = null)
		{
			const string sql = @"UPDATE permissionstatal SET Pt_text1 = @Pt_text1  WHERE Pt_id = @Pt_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pt_id", ptId, DbType.String, 150)
							.AddInParameter("@Pt_text1", ptText1 != null ?  (object)ptText1 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "ptId"></param>
		/// <param name = "ptText2"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutPtText2ByPK(string ptId, string ptText2, TransactionManager tm = null)
		{
			const string sql = @"UPDATE permissionstatal SET Pt_text2 = @Pt_text2  WHERE Pt_id = @Pt_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pt_id", ptId, DbType.String, 150)
							.AddInParameter("@Pt_text2", ptText2 != null ?  (object)ptText2 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}


		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "ptName"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutPtName(string ptName, TransactionManager tm = null)
		{
			const string sql = @"UPDATE permissionstatal SET Pt_name=@Pt_name";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pt_name", ptName != null ?  (object)ptName : DBNull.Value, DbType.String, 150)
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
			const string sql = @"UPDATE permissionstatal SET Pf_id=@Pf_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pf_id", pfId != null ?  (object)pfId : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "ptAddUser"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutPtAddUser(string ptAddUser, TransactionManager tm = null)
		{
			const string sql = @"UPDATE permissionstatal SET Pt_addUser=@Pt_addUser";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pt_addUser", ptAddUser != null ?  (object)ptAddUser : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "ptAddTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutPtAddTime(DateTime ptAddTime, TransactionManager tm = null)
		{
			const string sql = @"UPDATE permissionstatal SET Pt_addTime=@Pt_addTime";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pt_addTime", ptAddTime, DbType.DateTime, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "ptState"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutPtState(string ptState, TransactionManager tm = null)
		{
			const string sql = @"UPDATE permissionstatal SET Pt_state=@Pt_state";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pt_state", ptState != null ?  (object)ptState : DBNull.Value, DbType.String, 3)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "ptDel"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutPtDel(string ptDel, TransactionManager tm = null)
		{
			const string sql = @"UPDATE permissionstatal SET Pt_del=@Pt_del";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pt_del", ptDel != null ?  (object)ptDel : DBNull.Value, DbType.String, 3)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "ptText1"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutPtText1(string ptText1, TransactionManager tm = null)
		{
			const string sql = @"UPDATE permissionstatal SET Pt_text1=@Pt_text1";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pt_text1", ptText1 != null ?  (object)ptText1 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "ptText2"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutPtText2(string ptText2, TransactionManager tm = null)
		{
			const string sql = @"UPDATE permissionstatal SET Pt_text2=@Pt_text2";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pt_text2", ptText2 != null ?  (object)ptText2 : DBNull.Value, DbType.String, 600)
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
			const string format = @"UPDATE permissionstatal SET {0} {1}";
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
			const string format = @"UPDATE permissionstatal SET {0} {1}";
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
		/// <param name = "ptId"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByPK(string ptId, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM permissionstatal WHERE Pt_id=@Pt_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pt_id", ptId, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Remove(PermissionstatalEO item, TransactionManager tm = null)
		{
			return RemoveByPK(item.PtId, tm);
		}

		/// <summary>
		/// 删除指定实体集合对应的记录集
		/// </summary>
		/// <param name = "items">要删除的实体集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Remove(IEnumerable<PermissionstatalEO> items, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM permissionstatal WHERE Pt_id=@OriginalPt_id";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@OriginalPtId", DbType.String, 150);
			int ret = 0;
			foreach (PermissionstatalEO item in items)
			{
				ret += sqlDao
							.SetParameterValue("@OriginalPtId", (item.HasOriginal) ? item.OriginalPtId : item.PtId)
							.ExecNonQuery(tm);
			}
			return ret;
		}




		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "ptName"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByPtName(string ptName, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM permissionstatal WHERE Pt_name=@Pt_name";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pt_name", ptName != null ?  (object)ptName : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "pfId"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByPfId(string pfId, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM permissionstatal WHERE Pf_id=@Pf_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pf_id", pfId != null ?  (object)pfId : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "ptAddUser"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByPtAddUser(string ptAddUser, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM permissionstatal WHERE Pt_addUser=@Pt_addUser";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pt_addUser", ptAddUser != null ?  (object)ptAddUser : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "ptAddTime"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByPtAddTime(DateTime ptAddTime, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM permissionstatal WHERE Pt_addTime=@Pt_addTime";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pt_addTime", ptAddTime, DbType.DateTime, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "ptState"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByPtState(string ptState, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM permissionstatal WHERE Pt_state=@Pt_state";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pt_state", ptState != null ?  (object)ptState : DBNull.Value, DbType.String, 3)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "ptDel"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByPtDel(string ptDel, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM permissionstatal WHERE Pt_del=@Pt_del";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pt_del", ptDel != null ?  (object)ptDel : DBNull.Value, DbType.String, 3)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "ptText1"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByPtText1(string ptText1, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM permissionstatal WHERE Pt_text1=@Pt_text1";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pt_text1", ptText1 != null ?  (object)ptText1 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "ptText2"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByPtText2(string ptText2, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM permissionstatal WHERE Pt_text2=@Pt_text2";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pt_text2", ptText2 != null ?  (object)ptText2 : DBNull.Value, DbType.String, 600)
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
			const string format = @"DELETE FROM permissionstatal {0}";
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
			const string format = @"DELETE FROM permissionstatal {0}";
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
