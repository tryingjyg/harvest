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
	/// 【表 permissionstatalp 的实体类】
	/// </summary>
	[SerializableAttribute]
	public class PermissionstatalpEO : DataEntityBase, IRowMapper<PermissionstatalpEO>
	{
		protected string _originalPtId;
		protected string _originalPmId;

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
		public virtual string PpUser { get; set; }

		/// <summary>
		/// 【字段 datetime】
		/// </summary>
		public virtual DateTime PpAddTime { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string PpText1 { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string PpText2 { get; set; }

		/// <summary>
		/// 默认构造函数
		/// </summary>
		public PermissionstatalpEO() 
		{
			PtId = string.Empty;
			PmId = string.Empty;
		}

		/// <summary>
		/// 自定义构造函数
		/// </summary>
		/// <param name = "ptId"></param>
		/// <param name = "pmId"></param>
		/// <param name = "ppUser"></param>
		/// <param name = "ppAddTime"></param>
		/// <param name = "ppText1"></param>
		/// <param name = "ppText2"></param>
		public PermissionstatalpEO(string ptId, string pmId, string ppUser, DateTime ppAddTime, string ppText1, string ppText2) 
		{
			PtId = ptId;
			PmId = pmId;
			PpUser = ppUser;
			PpAddTime = ppAddTime;
			PpText1 = ppText1;
			PpText2 = ppText2;
		}

		/// <summary>
		/// 将结果集映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public PermissionstatalpEO MapRow(IDataReader reader)
		{
			return GetItem(reader);
		}

		/// <summary>
		/// 将结果集映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static PermissionstatalpEO GetItem(IDataReader reader)
		{
			PermissionstatalpEO ret = new PermissionstatalpEO();

			ret.PtId = (string)reader["Pt_id"];
			ret.OriginalPtId = ret.PtId;
			ret.PmId = (string)reader["Pm_id"];
			ret.OriginalPmId = ret.PmId;
			ret.PpUser = (reader["Pp_user"] is DBNull) ? null : (string)reader["Pp_user"];
			ret.PpAddTime = DateTime.Parse(reader["Pp_addTime"].ToString());
			ret.PpText1 = (reader["Pp_text1"] is DBNull) ? null : (string)reader["Pp_text1"];
			ret.PpText2 = (reader["Pp_text2"] is DBNull) ? null : (string)reader["Pp_text2"];
			return ret;
		}
	}


	#endregion

	#region  MO

	/// <summary>
	/// 【表 permissionstatalp 的操作类】
	/// </summary>
    public partial class PermissionstatalpMO : DataManagerBase
	{

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "routeData">路由数据</param>
		public PermissionstatalpMO(object routeData = null) : base(routeData) { }

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">连接字符串名称</param>
		public PermissionstatalpMO(string connectionStringName) : base(connectionStringName) { }

		#region  Get方法集合

		/// <summary>
		/// 按 PK（主键） 查询
		/// </summary>
		/// <param name="tm">事务管理对象</param>
		/// <param name = "ptId"></param>
		/// <param name = "pmId"></param>
		/// <return></return>
		public virtual PermissionstatalpEO GetByPK(string ptId, string pmId, TransactionManager tm = null)
		{
			const string sql = @"SELECT Pt_id, Pm_id, Pp_user, Pp_addTime, Pp_text1, Pp_text2 FROM permissionstatalp WHERE Pt_id=@Pt_id and Pm_id=@Pm_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pt_id", ptId, DbType.String, 150)
							.AddInParameter("@Pm_id", pmId, DbType.String, 150)
							.ExecSingle<PermissionstatalpEO>(PermissionstatalpEO.GetItem, tm);
		}




		#region  按 PtId（字段） 查询

		/// <summary>
		/// 按 PtId（字段） 查询
		/// </summary>
		/// <param name = "ptId"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalpEO> GetByPtId(string ptId)
		{
			return GetByPtId(ptId, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 PtId（字段） 查询
		/// </summary>
		/// <param name = "ptId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalpEO> GetByPtId(string ptId, TransactionManager tm)
		{
			return GetByPtId(ptId, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 PtId（字段） 查询
		/// </summary>
		/// <param name = "ptId"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalpEO> GetByPtId(string ptId, int top)
		{
			return GetByPtId(ptId, top, string.Empty, null);
		}

		/// <summary>
		/// 按 PtId（字段） 查询
		/// </summary>
		/// <param name = "ptId"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalpEO> GetByPtId(string ptId, int top, TransactionManager tm)
		{
			return GetByPtId(ptId, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 PtId（字段） 查询
		/// </summary>
		/// <param name = "ptId"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalpEO> GetByPtId(string ptId, string sort)
		{
			return GetByPtId(ptId, 0, sort, null);
		}

		/// <summary>
		/// 按 PtId（字段） 查询
		/// </summary>
		/// <param name = "ptId"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalpEO> GetByPtId(string ptId, string sort, TransactionManager tm)
		{
			return GetByPtId(ptId, 0, sort, tm);
		}

		/// <summary>
		/// 按 PtId（字段） 查询
		/// </summary>
		/// <param name = "ptId"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalpEO> GetByPtId(string ptId, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Pt_id, Pm_id, Pp_user, Pp_addTime, Pp_text1, Pp_text2 FROM permissionstatalp WHERE Pt_id=@PtId";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@PtId", ptId, DbType.String, 150)
							.ExecList<PermissionstatalpEO>(PermissionstatalpEO.GetItem, tm);
		}

		#endregion

		#region  按 PmId（字段） 查询

		/// <summary>
		/// 按 PmId（字段） 查询
		/// </summary>
		/// <param name = "pmId"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalpEO> GetByPmId(string pmId)
		{
			return GetByPmId(pmId, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 PmId（字段） 查询
		/// </summary>
		/// <param name = "pmId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalpEO> GetByPmId(string pmId, TransactionManager tm)
		{
			return GetByPmId(pmId, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 PmId（字段） 查询
		/// </summary>
		/// <param name = "pmId"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalpEO> GetByPmId(string pmId, int top)
		{
			return GetByPmId(pmId, top, string.Empty, null);
		}

		/// <summary>
		/// 按 PmId（字段） 查询
		/// </summary>
		/// <param name = "pmId"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalpEO> GetByPmId(string pmId, int top, TransactionManager tm)
		{
			return GetByPmId(pmId, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 PmId（字段） 查询
		/// </summary>
		/// <param name = "pmId"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalpEO> GetByPmId(string pmId, string sort)
		{
			return GetByPmId(pmId, 0, sort, null);
		}

		/// <summary>
		/// 按 PmId（字段） 查询
		/// </summary>
		/// <param name = "pmId"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalpEO> GetByPmId(string pmId, string sort, TransactionManager tm)
		{
			return GetByPmId(pmId, 0, sort, tm);
		}

		/// <summary>
		/// 按 PmId（字段） 查询
		/// </summary>
		/// <param name = "pmId"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalpEO> GetByPmId(string pmId, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Pt_id, Pm_id, Pp_user, Pp_addTime, Pp_text1, Pp_text2 FROM permissionstatalp WHERE Pm_id=@PmId";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@PmId", pmId, DbType.String, 150)
							.ExecList<PermissionstatalpEO>(PermissionstatalpEO.GetItem, tm);
		}

		#endregion

		#region  按 PpUser（字段） 查询

		/// <summary>
		/// 按 PpUser（字段） 查询
		/// </summary>
		/// <param name = "ppUser"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalpEO> GetByPpUser(string ppUser)
		{
			return GetByPpUser(ppUser, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 PpUser（字段） 查询
		/// </summary>
		/// <param name = "ppUser"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalpEO> GetByPpUser(string ppUser, TransactionManager tm)
		{
			return GetByPpUser(ppUser, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 PpUser（字段） 查询
		/// </summary>
		/// <param name = "ppUser"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalpEO> GetByPpUser(string ppUser, int top)
		{
			return GetByPpUser(ppUser, top, string.Empty, null);
		}

		/// <summary>
		/// 按 PpUser（字段） 查询
		/// </summary>
		/// <param name = "ppUser"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalpEO> GetByPpUser(string ppUser, int top, TransactionManager tm)
		{
			return GetByPpUser(ppUser, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 PpUser（字段） 查询
		/// </summary>
		/// <param name = "ppUser"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalpEO> GetByPpUser(string ppUser, string sort)
		{
			return GetByPpUser(ppUser, 0, sort, null);
		}

		/// <summary>
		/// 按 PpUser（字段） 查询
		/// </summary>
		/// <param name = "ppUser"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalpEO> GetByPpUser(string ppUser, string sort, TransactionManager tm)
		{
			return GetByPpUser(ppUser, 0, sort, tm);
		}

		/// <summary>
		/// 按 PpUser（字段） 查询
		/// </summary>
		/// <param name = "ppUser"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalpEO> GetByPpUser(string ppUser, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Pt_id, Pm_id, Pp_user, Pp_addTime, Pp_text1, Pp_text2 FROM permissionstatalp WHERE Pp_user=@PpUser";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@PpUser", ppUser, DbType.String, 150)
							.ExecList<PermissionstatalpEO>(PermissionstatalpEO.GetItem, tm);
		}

		#endregion

		#region  按 PpAddTime（字段） 查询

		/// <summary>
		/// 按 PpAddTime（字段） 查询
		/// </summary>
		/// <param name = "ppAddTime"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalpEO> GetByPpAddTime(DateTime ppAddTime)
		{
			return GetByPpAddTime(ppAddTime, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 PpAddTime（字段） 查询
		/// </summary>
		/// <param name = "ppAddTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalpEO> GetByPpAddTime(DateTime ppAddTime, TransactionManager tm)
		{
			return GetByPpAddTime(ppAddTime, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 PpAddTime（字段） 查询
		/// </summary>
		/// <param name = "ppAddTime"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalpEO> GetByPpAddTime(DateTime ppAddTime, int top)
		{
			return GetByPpAddTime(ppAddTime, top, string.Empty, null);
		}

		/// <summary>
		/// 按 PpAddTime（字段） 查询
		/// </summary>
		/// <param name = "ppAddTime"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalpEO> GetByPpAddTime(DateTime ppAddTime, int top, TransactionManager tm)
		{
			return GetByPpAddTime(ppAddTime, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 PpAddTime（字段） 查询
		/// </summary>
		/// <param name = "ppAddTime"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalpEO> GetByPpAddTime(DateTime ppAddTime, string sort)
		{
			return GetByPpAddTime(ppAddTime, 0, sort, null);
		}

		/// <summary>
		/// 按 PpAddTime（字段） 查询
		/// </summary>
		/// <param name = "ppAddTime"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalpEO> GetByPpAddTime(DateTime ppAddTime, string sort, TransactionManager tm)
		{
			return GetByPpAddTime(ppAddTime, 0, sort, tm);
		}

		/// <summary>
		/// 按 PpAddTime（字段） 查询
		/// </summary>
		/// <param name = "ppAddTime"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalpEO> GetByPpAddTime(DateTime ppAddTime, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Pt_id, Pm_id, Pp_user, Pp_addTime, Pp_text1, Pp_text2 FROM permissionstatalp WHERE Pp_addTime=@PpAddTime";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@PpAddTime", ppAddTime, DbType.DateTime, 0)
							.ExecList<PermissionstatalpEO>(PermissionstatalpEO.GetItem, tm);
		}

		#endregion

		#region  按 PpText1（字段） 查询

		/// <summary>
		/// 按 PpText1（字段） 查询
		/// </summary>
		/// <param name = "ppText1"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalpEO> GetByPpText1(string ppText1)
		{
			return GetByPpText1(ppText1, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 PpText1（字段） 查询
		/// </summary>
		/// <param name = "ppText1"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalpEO> GetByPpText1(string ppText1, TransactionManager tm)
		{
			return GetByPpText1(ppText1, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 PpText1（字段） 查询
		/// </summary>
		/// <param name = "ppText1"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalpEO> GetByPpText1(string ppText1, int top)
		{
			return GetByPpText1(ppText1, top, string.Empty, null);
		}

		/// <summary>
		/// 按 PpText1（字段） 查询
		/// </summary>
		/// <param name = "ppText1"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalpEO> GetByPpText1(string ppText1, int top, TransactionManager tm)
		{
			return GetByPpText1(ppText1, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 PpText1（字段） 查询
		/// </summary>
		/// <param name = "ppText1"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalpEO> GetByPpText1(string ppText1, string sort)
		{
			return GetByPpText1(ppText1, 0, sort, null);
		}

		/// <summary>
		/// 按 PpText1（字段） 查询
		/// </summary>
		/// <param name = "ppText1"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalpEO> GetByPpText1(string ppText1, string sort, TransactionManager tm)
		{
			return GetByPpText1(ppText1, 0, sort, tm);
		}

		/// <summary>
		/// 按 PpText1（字段） 查询
		/// </summary>
		/// <param name = "ppText1"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalpEO> GetByPpText1(string ppText1, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Pt_id, Pm_id, Pp_user, Pp_addTime, Pp_text1, Pp_text2 FROM permissionstatalp WHERE Pp_text1=@PpText1";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@PpText1", ppText1, DbType.String, 600)
							.ExecList<PermissionstatalpEO>(PermissionstatalpEO.GetItem, tm);
		}

		#endregion

		#region  按 PpText2（字段） 查询

		/// <summary>
		/// 按 PpText2（字段） 查询
		/// </summary>
		/// <param name = "ppText2"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalpEO> GetByPpText2(string ppText2)
		{
			return GetByPpText2(ppText2, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 PpText2（字段） 查询
		/// </summary>
		/// <param name = "ppText2"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalpEO> GetByPpText2(string ppText2, TransactionManager tm)
		{
			return GetByPpText2(ppText2, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 PpText2（字段） 查询
		/// </summary>
		/// <param name = "ppText2"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalpEO> GetByPpText2(string ppText2, int top)
		{
			return GetByPpText2(ppText2, top, string.Empty, null);
		}

		/// <summary>
		/// 按 PpText2（字段） 查询
		/// </summary>
		/// <param name = "ppText2"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalpEO> GetByPpText2(string ppText2, int top, TransactionManager tm)
		{
			return GetByPpText2(ppText2, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 PpText2（字段） 查询
		/// </summary>
		/// <param name = "ppText2"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalpEO> GetByPpText2(string ppText2, string sort)
		{
			return GetByPpText2(ppText2, 0, sort, null);
		}

		/// <summary>
		/// 按 PpText2（字段） 查询
		/// </summary>
		/// <param name = "ppText2"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalpEO> GetByPpText2(string ppText2, string sort, TransactionManager tm)
		{
			return GetByPpText2(ppText2, 0, sort, tm);
		}

		/// <summary>
		/// 按 PpText2（字段） 查询
		/// </summary>
		/// <param name = "ppText2"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalpEO> GetByPpText2(string ppText2, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Pt_id, Pm_id, Pp_user, Pp_addTime, Pp_text1, Pp_text2 FROM permissionstatalp WHERE Pp_text2=@PpText2";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@PpText2", ppText2, DbType.String, 600)
							.ExecList<PermissionstatalpEO>(PermissionstatalpEO.GetItem, tm);
		}

		#endregion

		#region  自定义条件查询

		/// <summary>
		/// 获取所有数据
		/// </summary>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalpEO> GetAll(TransactionManager tm = null)
		{
			return GetTopSort(string.Empty, null, -1, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "values">where子句中定义的参数值集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalpEO> Get(string where, params object[] values)
		{
			return GetTopSort(where, -1, string.Empty, null, values);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "paras">where子句中定义的参数集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalpEO> Get(string where, IEnumerable<DbParameter> paras)
		{
			return GetTopSort(where, paras, -1, string.Empty, null);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalpEO> Get(string where, TransactionManager tm)
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
		public virtual IEnumerable<PermissionstatalpEO> Get(string where, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<PermissionstatalpEO> Get(string where, IEnumerable<DbParameter> paras, TransactionManager tm)
		{
			return GetTopSort(where, paras, -1, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalpEO> GetTop(string where, int top)
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
		public virtual IEnumerable<PermissionstatalpEO> GetTop(string where, int top, params object[] values)
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
		public virtual IEnumerable<PermissionstatalpEO> GetTop(string where, IEnumerable<DbParameter> paras, int top)
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
		public virtual IEnumerable<PermissionstatalpEO> GetTop(string where, int top, TransactionManager tm)
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
		public virtual IEnumerable<PermissionstatalpEO> GetTop(string where, int top, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<PermissionstatalpEO> GetTop(string where, IEnumerable<DbParameter> paras, int top, TransactionManager tm)
		{
			return GetTopSort(where, paras, top, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<PermissionstatalpEO> GetSort(string where, string sort)
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
		public virtual IEnumerable<PermissionstatalpEO> GetSort(string where, string sort, params object[] values)
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
		public virtual IEnumerable<PermissionstatalpEO> GetSort(string where, IEnumerable<DbParameter> paras, string sort)
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
		public virtual IEnumerable<PermissionstatalpEO> GetSort(string where, string sort, TransactionManager tm)
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
		public virtual IEnumerable<PermissionstatalpEO> GetSort(string where, string sort, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<PermissionstatalpEO> GetSort(string where, IEnumerable<DbParameter> paras, string sort, TransactionManager tm)
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
		public virtual IEnumerable<PermissionstatalpEO> GetTopSort(string where, int top, string sort)
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
		public virtual IEnumerable<PermissionstatalpEO> GetTopSort(string where, int top, string sort, params object[] values)
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
		public virtual IEnumerable<PermissionstatalpEO> GetTopSort(string where, IEnumerable<DbParameter> paras, int top, string sort)
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
		public virtual IEnumerable<PermissionstatalpEO> GetTopSort(string where, int top, string sort, TransactionManager tm)
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
		public virtual IEnumerable<PermissionstatalpEO> GetTopSort(string where, int top, string sort, TransactionManager tm, params object[] values)
		{
			const string format = @"SELECT {0} Pt_id, Pm_id, Pp_user, Pp_addTime, Pp_text1, Pp_text2 FROM permissionstatalp";
			string sql = format;

			if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameters(values)
							.ExecList<PermissionstatalpEO>(PermissionstatalpEO.GetItem, tm);
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
		public virtual IEnumerable<PermissionstatalpEO> GetTopSort(string where, IEnumerable<DbParameter> paras, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Pt_id, Pm_id, Pp_user, Pp_addTime, Pp_text1, Pp_text2 FROM permissionstatalp";
			string sql = format;

			if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddParameters(paras)
							.ExecList<PermissionstatalpEO>(PermissionstatalpEO.GetItem, tm);
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
			const string format = @"SELECT Pt_id, Pm_id, Pp_user, Pp_addTime, Pp_text1, Pp_text2 FROM permissionstatalp {0} {1}";
			 string sql = string.Format(format, string.IsNullOrEmpty(where) ? string.Empty : "WHERE " + where, string.IsNullOrEmpty(sort) ? string.Empty : "ORDER BY " + sort);

			return Database.CreatePager(sql, pageSize, "Pt_id,Pm_id");
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
		public virtual List<PermissionstatalpEO> GetPageList(int pageIndex , int pageSize, string where = null, string sort = null, IEnumerable<DbParameter> paras = null)
		{
			var pager = GetPager(pageSize, where, sort);

			pager.AddParameters(paras);
			return pager.GetPageList<PermissionstatalpEO>(pageIndex);
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
		public virtual IEnumerable<PermissionstatalpEO> GetPageMutil(int pageIndex , int pageSize, string where = null, string sort = null, IEnumerable<DbParameter> paras = null)
		{
			var pager = GetPager(pageSize, where, sort);

			pager.AddParameters(paras);
			return pager.GetPageMutil<PermissionstatalpEO>(pageIndex);
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
		public virtual int Add(PermissionstatalpEO item, TransactionManager tm = null)
		{
			const string sql = @"INSERT INTO permissionstatalp (Pt_id, Pm_id, Pp_user, Pp_addTime, Pp_text1, Pp_text2) VALUES (@Pt_id, @Pm_id, @Pp_user, @Pp_addTime, @Pp_text1, @Pp_text2) ";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pt_id", item.PtId, DbType.String, 150)
							.AddInParameter("@Pm_id", item.PmId, DbType.String, 150)
							.AddInParameter("@Pp_user", item.PpUser != null ?  (object)item.PpUser : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Pp_addTime", item.PpAddTime, DbType.DateTime, 0)
							.AddInParameter("@Pp_text1", item.PpText1 != null ?  (object)item.PpText1 : DBNull.Value, DbType.String, 600)
							.AddInParameter("@Pp_text2", item.PpText2 != null ?  (object)item.PpText2 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 插入一组数据
		/// </summary>
		/// <param name = "items">要插入的实体对象集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Add(IEnumerable<PermissionstatalpEO> items, TransactionManager tm = null)
		{
			int ret = 0;
			const string sql = @"INSERT INTO permissionstatalp (Pt_id, Pm_id, Pp_user, Pp_addTime, Pp_text1, Pp_text2) VALUES (@Pt_id, @Pm_id, @Pp_user, @Pp_addTime, @Pp_text1, @Pp_text2) ";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@Pt_id", DbType.String, 150)
									.AddParameter("@Pm_id", DbType.String, 150)
									.AddParameter("@Pp_user", DbType.String, 150)
									.AddParameter("@Pp_addTime", DbType.DateTime, 0)
									.AddParameter("@Pp_text1", DbType.String, 600)
									.AddParameter("@Pp_text2", DbType.String, 600);

			foreach (PermissionstatalpEO item in items)
			{
				sqlDao
					.SetParameterValue("@Pt_id", item.PtId)
					.SetParameterValue("@Pm_id", item.PmId)
					.SetParameterValue("@Pp_user", item.PpUser != null ?  (object)item.PpUser : DBNull.Value)
					.SetParameterValue("@Pp_addTime", item.PpAddTime)
					.SetParameterValue("@Pp_text1", item.PpText1 != null ?  (object)item.PpText1 : DBNull.Value)
					.SetParameterValue("@Pp_text2", item.PpText2 != null ?  (object)item.PpText2 : DBNull.Value)
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
		public virtual int Put(PermissionstatalpEO item, TransactionManager tm = null)
		{
			const string sql = @"UPDATE permissionstatalp SET Pt_id=@Pt_id, Pm_id=@Pm_id, Pp_user=@Pp_user, Pp_addTime=@Pp_addTime, Pp_text1=@Pp_text1, Pp_text2=@Pp_text2 WHERE Pt_id=@OriginalPt_id and Pm_id=@OriginalPm_id";
			return Database.CreateSqlDao (sql)
							.AddInParameter("@OriginalPtId", (item.HasOriginal) ? item.OriginalPtId : item.PtId, DbType.String, 150)
							.AddInParameter("@OriginalPmId", (item.HasOriginal) ? item.OriginalPmId : item.PmId, DbType.String, 150)
							.AddInParameter("@Pt_id", item.PtId, DbType.String, 150)
							.AddInParameter("@Pm_id", item.PmId, DbType.String, 150)
							.AddInParameter("@Pp_user", item.PpUser != null ?  (object)item.PpUser : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Pp_addTime", item.PpAddTime, DbType.DateTime, 0)
							.AddInParameter("@Pp_text1", item.PpText1 != null ?  (object)item.PpText1 : DBNull.Value, DbType.String, 600)
							.AddInParameter("@Pp_text2", item.PpText2 != null ?  (object)item.PpText2 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}


		/// <summary>
		/// 更新数据
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Put(IEnumerable<PermissionstatalpEO> items, TransactionManager tm = null)
		{

			int ret = 0;
			const string sql = @"UPDATE permissionstatalp SET Pt_id=@Pt_id, Pm_id=@Pm_id, Pp_user=@Pp_user, Pp_addTime=@Pp_addTime, Pp_text1=@Pp_text1, Pp_text2=@Pp_text2 WHERE Pt_id=@OriginalPt_id and Pm_id=@OriginalPm_id";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@OriginalPtId", DbType.String, 150)
									.AddParameter("@OriginalPmId", DbType.String, 150)
									.AddParameter("@Pt_id", DbType.String, 150)
									.AddParameter("@Pm_id", DbType.String, 150)
									.AddParameter("@Pp_user", DbType.String, 150)
									.AddParameter("@Pp_addTime", DbType.DateTime, 0)
									.AddParameter("@Pp_text1", DbType.String, 600)
									.AddParameter("@Pp_text2", DbType.String, 600);

			foreach (PermissionstatalpEO item in items)
			{
				ret += sqlDao
							.SetParameterValue("@OriginalPtId", (item.HasOriginal) ? item.OriginalPtId : item.PtId)
							.SetParameterValue("@OriginalPmId", (item.HasOriginal) ? item.OriginalPmId : item.PmId)
							.SetParameterValue("@Pt_id", item.PtId)
							.SetParameterValue("@Pm_id", item.PmId)
							.SetParameterValue("@Pp_user", item.PpUser != null ?  (object)item.PpUser : DBNull.Value)
							.SetParameterValue("@Pp_addTime", item.PpAddTime)
							.SetParameterValue("@Pp_text1", item.PpText1 != null ?  (object)item.PpText1 : DBNull.Value)
							.SetParameterValue("@Pp_text2", item.PpText2 != null ?  (object)item.PpText2 : DBNull.Value)
							.ExecNonQuery(tm);
			}
			return ret;
		}


		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "ptId"></param>
		/// <param name = "pmId"></param>
		/// <param name = "ppUser"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutPpUserByPK(string ptId, string pmId, string ppUser, TransactionManager tm = null)
		{
			const string sql = @"UPDATE permissionstatalp SET Pp_user = @Pp_user  WHERE Pt_id = @Pt_id and Pm_id = @Pm_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pt_id", ptId, DbType.String, 150)
							.AddInParameter("@Pm_id", pmId, DbType.String, 150)
							.AddInParameter("@Pp_user", ppUser != null ?  (object)ppUser : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "ptId"></param>
		/// <param name = "pmId"></param>
		/// <param name = "ppAddTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutPpAddTimeByPK(string ptId, string pmId, DateTime ppAddTime, TransactionManager tm = null)
		{
			const string sql = @"UPDATE permissionstatalp SET Pp_addTime = @Pp_addTime  WHERE Pt_id = @Pt_id and Pm_id = @Pm_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pt_id", ptId, DbType.String, 150)
							.AddInParameter("@Pm_id", pmId, DbType.String, 150)
							.AddInParameter("@Pp_addTime", ppAddTime, DbType.DateTime, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "ptId"></param>
		/// <param name = "pmId"></param>
		/// <param name = "ppText1"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutPpText1ByPK(string ptId, string pmId, string ppText1, TransactionManager tm = null)
		{
			const string sql = @"UPDATE permissionstatalp SET Pp_text1 = @Pp_text1  WHERE Pt_id = @Pt_id and Pm_id = @Pm_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pt_id", ptId, DbType.String, 150)
							.AddInParameter("@Pm_id", pmId, DbType.String, 150)
							.AddInParameter("@Pp_text1", ppText1 != null ?  (object)ppText1 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "ptId"></param>
		/// <param name = "pmId"></param>
		/// <param name = "ppText2"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutPpText2ByPK(string ptId, string pmId, string ppText2, TransactionManager tm = null)
		{
			const string sql = @"UPDATE permissionstatalp SET Pp_text2 = @Pp_text2  WHERE Pt_id = @Pt_id and Pm_id = @Pm_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pt_id", ptId, DbType.String, 150)
							.AddInParameter("@Pm_id", pmId, DbType.String, 150)
							.AddInParameter("@Pp_text2", ppText2 != null ?  (object)ppText2 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}


		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "ppUser"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutPpUser(string ppUser, TransactionManager tm = null)
		{
			const string sql = @"UPDATE permissionstatalp SET Pp_user=@Pp_user";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pp_user", ppUser != null ?  (object)ppUser : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "ppAddTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutPpAddTime(DateTime ppAddTime, TransactionManager tm = null)
		{
			const string sql = @"UPDATE permissionstatalp SET Pp_addTime=@Pp_addTime";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pp_addTime", ppAddTime, DbType.DateTime, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "ppText1"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutPpText1(string ppText1, TransactionManager tm = null)
		{
			const string sql = @"UPDATE permissionstatalp SET Pp_text1=@Pp_text1";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pp_text1", ppText1 != null ?  (object)ppText1 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "ppText2"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutPpText2(string ppText2, TransactionManager tm = null)
		{
			const string sql = @"UPDATE permissionstatalp SET Pp_text2=@Pp_text2";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pp_text2", ppText2 != null ?  (object)ppText2 : DBNull.Value, DbType.String, 600)
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
			const string format = @"UPDATE permissionstatalp SET {0} {1}";
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
			const string format = @"UPDATE permissionstatalp SET {0} {1}";
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
		/// <param name = "pmId"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByPK(string ptId, string pmId, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM permissionstatalp WHERE Pt_id=@Pt_id and Pm_id=@Pm_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pt_id", ptId, DbType.String, 150)
							.AddInParameter("@Pm_id", pmId, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Remove(PermissionstatalpEO item, TransactionManager tm = null)
		{
			return RemoveByPK(item.PtId, item.PmId, tm);
		}

		/// <summary>
		/// 删除指定实体集合对应的记录集
		/// </summary>
		/// <param name = "items">要删除的实体集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Remove(IEnumerable<PermissionstatalpEO> items, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM permissionstatalp WHERE Pt_id=@OriginalPt_id and Pm_id=@OriginalPm_id";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@OriginalPtId", DbType.String, 150)
									.AddParameter("@OriginalPmId", DbType.String, 150);
			int ret = 0;
			foreach (PermissionstatalpEO item in items)
			{
				ret += sqlDao
							.SetParameterValue("@OriginalPtId", (item.HasOriginal) ? item.OriginalPtId : item.PtId)
							.SetParameterValue("@OriginalPmId", (item.HasOriginal) ? item.OriginalPmId : item.PmId)
							.ExecNonQuery(tm);
			}
			return ret;
		}




		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "ppUser"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByPpUser(string ppUser, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM permissionstatalp WHERE Pp_user=@Pp_user";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pp_user", ppUser != null ?  (object)ppUser : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "ppAddTime"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByPpAddTime(DateTime ppAddTime, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM permissionstatalp WHERE Pp_addTime=@Pp_addTime";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pp_addTime", ppAddTime, DbType.DateTime, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "ppText1"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByPpText1(string ppText1, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM permissionstatalp WHERE Pp_text1=@Pp_text1";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pp_text1", ppText1 != null ?  (object)ppText1 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "ppText2"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByPpText2(string ppText2, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM permissionstatalp WHERE Pp_text2=@Pp_text2";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pp_text2", ppText2 != null ?  (object)ppText2 : DBNull.Value, DbType.String, 600)
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
			const string format = @"DELETE FROM permissionstatalp {0}";
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
			const string format = @"DELETE FROM permissionstatalp {0}";
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
