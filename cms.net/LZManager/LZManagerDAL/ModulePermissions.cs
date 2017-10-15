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
	/// 【表 modulepermissions 的实体类】
	/// </summary>
	[SerializableAttribute]
	public class ModulepermissionsEO : DataEntityBase, IRowMapper<ModulepermissionsEO>
	{
		protected string _originalMdId;
		protected string _originalPmId;

		/// <summary>
		/// 主键是否有原始值（即数据库中保存的值），用于实体对象更新时
		/// </summary>
		public bool HasOriginal { get; protected set; }

		/// <summary>
		/// 【主键 varchar】
		/// </summary>
		public virtual string MdId { get; set; }

		/// <summary>
		/// 【数据库中的原始主键值副本】
		/// </summary>
		public virtual string OriginalMdId
		{
			get { return _originalMdId; }
			set { HasOriginal = true; _originalMdId = value; }
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
		public virtual string MpUser { get; set; }

		/// <summary>
		/// 【字段 char】
		/// </summary>
		public virtual string MpAddTime { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string MpText1 { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string MpText2 { get; set; }

		/// <summary>
		/// 默认构造函数
		/// </summary>
		public ModulepermissionsEO() 
		{
			MdId = string.Empty;
			PmId = string.Empty;
		}

		/// <summary>
		/// 自定义构造函数
		/// </summary>
		/// <param name = "mdId"></param>
		/// <param name = "pmId"></param>
		/// <param name = "mpUser"></param>
		/// <param name = "mpAddTime"></param>
		/// <param name = "mpText1"></param>
		/// <param name = "mpText2"></param>
		public ModulepermissionsEO(string mdId, string pmId, string mpUser, string mpAddTime, string mpText1, string mpText2) 
		{
			MdId = mdId;
			PmId = pmId;
			MpUser = mpUser;
			MpAddTime = mpAddTime;
			MpText1 = mpText1;
			MpText2 = mpText2;
		}

		/// <summary>
		/// 将结果集映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public ModulepermissionsEO MapRow(IDataReader reader)
		{
			return GetItem(reader);
		}

		/// <summary>
		/// 将结果集映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static ModulepermissionsEO GetItem(IDataReader reader)
		{
			ModulepermissionsEO ret = new ModulepermissionsEO();

			ret.MdId = (string)reader["Md_id"];
			ret.OriginalMdId = ret.MdId;
			ret.PmId = (string)reader["Pm_id"];
			ret.OriginalPmId = ret.PmId;
			ret.MpUser = (reader["Mp_user"] is DBNull) ? null : (string)reader["Mp_user"];
			ret.MpAddTime = (reader["Mp_addTime"] is DBNull) ? null : (string)reader["Mp_addTime"];
			ret.MpText1 = (reader["Mp_text1"] is DBNull) ? null : (string)reader["Mp_text1"];
			ret.MpText2 = (reader["Mp_text2"] is DBNull) ? null : (string)reader["Mp_text2"];
			return ret;
		}
	}


	#endregion

	#region  MO

	/// <summary>
	/// 【表 modulepermissions 的操作类】
	/// </summary>
    public partial class ModulepermissionsMO : DataManagerBase
	{

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "routeData">路由数据</param>
		public ModulepermissionsMO(object routeData = null) : base(routeData) { }

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">连接字符串名称</param>
		public ModulepermissionsMO(string connectionStringName) : base(connectionStringName) { }

		#region  Get方法集合

		/// <summary>
		/// 按 PK（主键） 查询
		/// </summary>
		/// <param name="tm">事务管理对象</param>
		/// <param name = "mdId"></param>
		/// <param name = "pmId"></param>
		/// <return></return>
		public virtual ModulepermissionsEO GetByPK(string mdId, string pmId, TransactionManager tm = null)
		{
			const string sql = @"SELECT Md_id, Pm_id, Mp_user, Mp_addTime, Mp_text1, Mp_text2 FROM modulepermissions WHERE Md_id=@Md_id and Pm_id=@Pm_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Md_id", mdId, DbType.String, 150)
							.AddInParameter("@Pm_id", pmId, DbType.String, 150)
							.ExecSingle<ModulepermissionsEO>(ModulepermissionsEO.GetItem, tm);
		}




		#region  按 MdId（字段） 查询

		/// <summary>
		/// 按 MdId（字段） 查询
		/// </summary>
		/// <param name = "mdId"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModulepermissionsEO> GetByMdId(string mdId)
		{
			return GetByMdId(mdId, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 MdId（字段） 查询
		/// </summary>
		/// <param name = "mdId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModulepermissionsEO> GetByMdId(string mdId, TransactionManager tm)
		{
			return GetByMdId(mdId, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 MdId（字段） 查询
		/// </summary>
		/// <param name = "mdId"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModulepermissionsEO> GetByMdId(string mdId, int top)
		{
			return GetByMdId(mdId, top, string.Empty, null);
		}

		/// <summary>
		/// 按 MdId（字段） 查询
		/// </summary>
		/// <param name = "mdId"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModulepermissionsEO> GetByMdId(string mdId, int top, TransactionManager tm)
		{
			return GetByMdId(mdId, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 MdId（字段） 查询
		/// </summary>
		/// <param name = "mdId"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModulepermissionsEO> GetByMdId(string mdId, string sort)
		{
			return GetByMdId(mdId, 0, sort, null);
		}

		/// <summary>
		/// 按 MdId（字段） 查询
		/// </summary>
		/// <param name = "mdId"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModulepermissionsEO> GetByMdId(string mdId, string sort, TransactionManager tm)
		{
			return GetByMdId(mdId, 0, sort, tm);
		}

		/// <summary>
		/// 按 MdId（字段） 查询
		/// </summary>
		/// <param name = "mdId"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModulepermissionsEO> GetByMdId(string mdId, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Md_id, Pm_id, Mp_user, Mp_addTime, Mp_text1, Mp_text2 FROM modulepermissions WHERE Md_id=@MdId";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@MdId", mdId, DbType.String, 150)
							.ExecList<ModulepermissionsEO>(ModulepermissionsEO.GetItem, tm);
		}

		#endregion

		#region  按 PmId（字段） 查询

		/// <summary>
		/// 按 PmId（字段） 查询
		/// </summary>
		/// <param name = "pmId"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModulepermissionsEO> GetByPmId(string pmId)
		{
			return GetByPmId(pmId, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 PmId（字段） 查询
		/// </summary>
		/// <param name = "pmId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModulepermissionsEO> GetByPmId(string pmId, TransactionManager tm)
		{
			return GetByPmId(pmId, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 PmId（字段） 查询
		/// </summary>
		/// <param name = "pmId"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModulepermissionsEO> GetByPmId(string pmId, int top)
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
		public virtual IEnumerable<ModulepermissionsEO> GetByPmId(string pmId, int top, TransactionManager tm)
		{
			return GetByPmId(pmId, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 PmId（字段） 查询
		/// </summary>
		/// <param name = "pmId"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModulepermissionsEO> GetByPmId(string pmId, string sort)
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
		public virtual IEnumerable<ModulepermissionsEO> GetByPmId(string pmId, string sort, TransactionManager tm)
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
		public virtual IEnumerable<ModulepermissionsEO> GetByPmId(string pmId, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Md_id, Pm_id, Mp_user, Mp_addTime, Mp_text1, Mp_text2 FROM modulepermissions WHERE Pm_id=@PmId";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@PmId", pmId, DbType.String, 150)
							.ExecList<ModulepermissionsEO>(ModulepermissionsEO.GetItem, tm);
		}

		#endregion

		#region  按 MpUser（字段） 查询

		/// <summary>
		/// 按 MpUser（字段） 查询
		/// </summary>
		/// <param name = "mpUser"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModulepermissionsEO> GetByMpUser(string mpUser)
		{
			return GetByMpUser(mpUser, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 MpUser（字段） 查询
		/// </summary>
		/// <param name = "mpUser"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModulepermissionsEO> GetByMpUser(string mpUser, TransactionManager tm)
		{
			return GetByMpUser(mpUser, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 MpUser（字段） 查询
		/// </summary>
		/// <param name = "mpUser"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModulepermissionsEO> GetByMpUser(string mpUser, int top)
		{
			return GetByMpUser(mpUser, top, string.Empty, null);
		}

		/// <summary>
		/// 按 MpUser（字段） 查询
		/// </summary>
		/// <param name = "mpUser"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModulepermissionsEO> GetByMpUser(string mpUser, int top, TransactionManager tm)
		{
			return GetByMpUser(mpUser, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 MpUser（字段） 查询
		/// </summary>
		/// <param name = "mpUser"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModulepermissionsEO> GetByMpUser(string mpUser, string sort)
		{
			return GetByMpUser(mpUser, 0, sort, null);
		}

		/// <summary>
		/// 按 MpUser（字段） 查询
		/// </summary>
		/// <param name = "mpUser"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModulepermissionsEO> GetByMpUser(string mpUser, string sort, TransactionManager tm)
		{
			return GetByMpUser(mpUser, 0, sort, tm);
		}

		/// <summary>
		/// 按 MpUser（字段） 查询
		/// </summary>
		/// <param name = "mpUser"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModulepermissionsEO> GetByMpUser(string mpUser, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Md_id, Pm_id, Mp_user, Mp_addTime, Mp_text1, Mp_text2 FROM modulepermissions WHERE Mp_user=@MpUser";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@MpUser", mpUser, DbType.String, 150)
							.ExecList<ModulepermissionsEO>(ModulepermissionsEO.GetItem, tm);
		}

		#endregion

		#region  按 MpAddTime（字段） 查询

		/// <summary>
		/// 按 MpAddTime（字段） 查询
		/// </summary>
		/// <param name = "mpAddTime"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModulepermissionsEO> GetByMpAddTime(string mpAddTime)
		{
			return GetByMpAddTime(mpAddTime, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 MpAddTime（字段） 查询
		/// </summary>
		/// <param name = "mpAddTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModulepermissionsEO> GetByMpAddTime(string mpAddTime, TransactionManager tm)
		{
			return GetByMpAddTime(mpAddTime, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 MpAddTime（字段） 查询
		/// </summary>
		/// <param name = "mpAddTime"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModulepermissionsEO> GetByMpAddTime(string mpAddTime, int top)
		{
			return GetByMpAddTime(mpAddTime, top, string.Empty, null);
		}

		/// <summary>
		/// 按 MpAddTime（字段） 查询
		/// </summary>
		/// <param name = "mpAddTime"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModulepermissionsEO> GetByMpAddTime(string mpAddTime, int top, TransactionManager tm)
		{
			return GetByMpAddTime(mpAddTime, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 MpAddTime（字段） 查询
		/// </summary>
		/// <param name = "mpAddTime"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModulepermissionsEO> GetByMpAddTime(string mpAddTime, string sort)
		{
			return GetByMpAddTime(mpAddTime, 0, sort, null);
		}

		/// <summary>
		/// 按 MpAddTime（字段） 查询
		/// </summary>
		/// <param name = "mpAddTime"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModulepermissionsEO> GetByMpAddTime(string mpAddTime, string sort, TransactionManager tm)
		{
			return GetByMpAddTime(mpAddTime, 0, sort, tm);
		}

		/// <summary>
		/// 按 MpAddTime（字段） 查询
		/// </summary>
		/// <param name = "mpAddTime"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModulepermissionsEO> GetByMpAddTime(string mpAddTime, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Md_id, Pm_id, Mp_user, Mp_addTime, Mp_text1, Mp_text2 FROM modulepermissions WHERE Mp_addTime=@MpAddTime";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@MpAddTime", mpAddTime, DbType.String, 30)
							.ExecList<ModulepermissionsEO>(ModulepermissionsEO.GetItem, tm);
		}

		#endregion

		#region  按 MpText1（字段） 查询

		/// <summary>
		/// 按 MpText1（字段） 查询
		/// </summary>
		/// <param name = "mpText1"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModulepermissionsEO> GetByMpText1(string mpText1)
		{
			return GetByMpText1(mpText1, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 MpText1（字段） 查询
		/// </summary>
		/// <param name = "mpText1"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModulepermissionsEO> GetByMpText1(string mpText1, TransactionManager tm)
		{
			return GetByMpText1(mpText1, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 MpText1（字段） 查询
		/// </summary>
		/// <param name = "mpText1"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModulepermissionsEO> GetByMpText1(string mpText1, int top)
		{
			return GetByMpText1(mpText1, top, string.Empty, null);
		}

		/// <summary>
		/// 按 MpText1（字段） 查询
		/// </summary>
		/// <param name = "mpText1"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModulepermissionsEO> GetByMpText1(string mpText1, int top, TransactionManager tm)
		{
			return GetByMpText1(mpText1, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 MpText1（字段） 查询
		/// </summary>
		/// <param name = "mpText1"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModulepermissionsEO> GetByMpText1(string mpText1, string sort)
		{
			return GetByMpText1(mpText1, 0, sort, null);
		}

		/// <summary>
		/// 按 MpText1（字段） 查询
		/// </summary>
		/// <param name = "mpText1"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModulepermissionsEO> GetByMpText1(string mpText1, string sort, TransactionManager tm)
		{
			return GetByMpText1(mpText1, 0, sort, tm);
		}

		/// <summary>
		/// 按 MpText1（字段） 查询
		/// </summary>
		/// <param name = "mpText1"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModulepermissionsEO> GetByMpText1(string mpText1, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Md_id, Pm_id, Mp_user, Mp_addTime, Mp_text1, Mp_text2 FROM modulepermissions WHERE Mp_text1=@MpText1";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@MpText1", mpText1, DbType.String, 600)
							.ExecList<ModulepermissionsEO>(ModulepermissionsEO.GetItem, tm);
		}

		#endregion

		#region  按 MpText2（字段） 查询

		/// <summary>
		/// 按 MpText2（字段） 查询
		/// </summary>
		/// <param name = "mpText2"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModulepermissionsEO> GetByMpText2(string mpText2)
		{
			return GetByMpText2(mpText2, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 MpText2（字段） 查询
		/// </summary>
		/// <param name = "mpText2"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModulepermissionsEO> GetByMpText2(string mpText2, TransactionManager tm)
		{
			return GetByMpText2(mpText2, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 MpText2（字段） 查询
		/// </summary>
		/// <param name = "mpText2"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModulepermissionsEO> GetByMpText2(string mpText2, int top)
		{
			return GetByMpText2(mpText2, top, string.Empty, null);
		}

		/// <summary>
		/// 按 MpText2（字段） 查询
		/// </summary>
		/// <param name = "mpText2"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModulepermissionsEO> GetByMpText2(string mpText2, int top, TransactionManager tm)
		{
			return GetByMpText2(mpText2, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 MpText2（字段） 查询
		/// </summary>
		/// <param name = "mpText2"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModulepermissionsEO> GetByMpText2(string mpText2, string sort)
		{
			return GetByMpText2(mpText2, 0, sort, null);
		}

		/// <summary>
		/// 按 MpText2（字段） 查询
		/// </summary>
		/// <param name = "mpText2"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModulepermissionsEO> GetByMpText2(string mpText2, string sort, TransactionManager tm)
		{
			return GetByMpText2(mpText2, 0, sort, tm);
		}

		/// <summary>
		/// 按 MpText2（字段） 查询
		/// </summary>
		/// <param name = "mpText2"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModulepermissionsEO> GetByMpText2(string mpText2, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Md_id, Pm_id, Mp_user, Mp_addTime, Mp_text1, Mp_text2 FROM modulepermissions WHERE Mp_text2=@MpText2";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@MpText2", mpText2, DbType.String, 600)
							.ExecList<ModulepermissionsEO>(ModulepermissionsEO.GetItem, tm);
		}

		#endregion

		#region  自定义条件查询

		/// <summary>
		/// 获取所有数据
		/// </summary>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModulepermissionsEO> GetAll(TransactionManager tm = null)
		{
			return GetTopSort(string.Empty, null, -1, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "values">where子句中定义的参数值集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModulepermissionsEO> Get(string where, params object[] values)
		{
			return GetTopSort(where, -1, string.Empty, null, values);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "paras">where子句中定义的参数集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModulepermissionsEO> Get(string where, IEnumerable<DbParameter> paras)
		{
			return GetTopSort(where, paras, -1, string.Empty, null);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModulepermissionsEO> Get(string where, TransactionManager tm)
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
		public virtual IEnumerable<ModulepermissionsEO> Get(string where, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<ModulepermissionsEO> Get(string where, IEnumerable<DbParameter> paras, TransactionManager tm)
		{
			return GetTopSort(where, paras, -1, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModulepermissionsEO> GetTop(string where, int top)
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
		public virtual IEnumerable<ModulepermissionsEO> GetTop(string where, int top, params object[] values)
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
		public virtual IEnumerable<ModulepermissionsEO> GetTop(string where, IEnumerable<DbParameter> paras, int top)
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
		public virtual IEnumerable<ModulepermissionsEO> GetTop(string where, int top, TransactionManager tm)
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
		public virtual IEnumerable<ModulepermissionsEO> GetTop(string where, int top, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<ModulepermissionsEO> GetTop(string where, IEnumerable<DbParameter> paras, int top, TransactionManager tm)
		{
			return GetTopSort(where, paras, top, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModulepermissionsEO> GetSort(string where, string sort)
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
		public virtual IEnumerable<ModulepermissionsEO> GetSort(string where, string sort, params object[] values)
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
		public virtual IEnumerable<ModulepermissionsEO> GetSort(string where, IEnumerable<DbParameter> paras, string sort)
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
		public virtual IEnumerable<ModulepermissionsEO> GetSort(string where, string sort, TransactionManager tm)
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
		public virtual IEnumerable<ModulepermissionsEO> GetSort(string where, string sort, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<ModulepermissionsEO> GetSort(string where, IEnumerable<DbParameter> paras, string sort, TransactionManager tm)
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
		public virtual IEnumerable<ModulepermissionsEO> GetTopSort(string where, int top, string sort)
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
		public virtual IEnumerable<ModulepermissionsEO> GetTopSort(string where, int top, string sort, params object[] values)
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
		public virtual IEnumerable<ModulepermissionsEO> GetTopSort(string where, IEnumerable<DbParameter> paras, int top, string sort)
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
		public virtual IEnumerable<ModulepermissionsEO> GetTopSort(string where, int top, string sort, TransactionManager tm)
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
		public virtual IEnumerable<ModulepermissionsEO> GetTopSort(string where, int top, string sort, TransactionManager tm, params object[] values)
		{
			const string format = @"SELECT {0} Md_id, Pm_id, Mp_user, Mp_addTime, Mp_text1, Mp_text2 FROM modulepermissions";
			string sql = format;

			if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameters(values)
							.ExecList<ModulepermissionsEO>(ModulepermissionsEO.GetItem, tm);
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
		public virtual IEnumerable<ModulepermissionsEO> GetTopSort(string where, IEnumerable<DbParameter> paras, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Md_id, Pm_id, Mp_user, Mp_addTime, Mp_text1, Mp_text2 FROM modulepermissions";
			string sql = format;

			if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddParameters(paras)
							.ExecList<ModulepermissionsEO>(ModulepermissionsEO.GetItem, tm);
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
			const string format = @"SELECT Md_id, Pm_id, Mp_user, Mp_addTime, Mp_text1, Mp_text2 FROM modulepermissions {0} {1}";
			 string sql = string.Format(format, string.IsNullOrEmpty(where) ? string.Empty : "WHERE " + where, string.IsNullOrEmpty(sort) ? string.Empty : "ORDER BY " + sort);

			return Database.CreatePager(sql, pageSize, "Pm_id,Md_id");
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
		public virtual List<ModulepermissionsEO> GetPageList(int pageIndex , int pageSize, string where = null, string sort = null, IEnumerable<DbParameter> paras = null)
		{
			var pager = GetPager(pageSize, where, sort);

			pager.AddParameters(paras);
			return pager.GetPageList<ModulepermissionsEO>(pageIndex);
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
		public virtual IEnumerable<ModulepermissionsEO> GetPageMutil(int pageIndex , int pageSize, string where = null, string sort = null, IEnumerable<DbParameter> paras = null)
		{
			var pager = GetPager(pageSize, where, sort);

			pager.AddParameters(paras);
			return pager.GetPageMutil<ModulepermissionsEO>(pageIndex);
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
		public virtual int Add(ModulepermissionsEO item, TransactionManager tm = null)
		{
			const string sql = @"INSERT INTO modulepermissions (Md_id, Pm_id, Mp_user, Mp_addTime, Mp_text1, Mp_text2) VALUES (@Md_id, @Pm_id, @Mp_user, @Mp_addTime, @Mp_text1, @Mp_text2) ";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Md_id", item.MdId, DbType.String, 150)
							.AddInParameter("@Pm_id", item.PmId, DbType.String, 150)
							.AddInParameter("@Mp_user", item.MpUser != null ?  (object)item.MpUser : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Mp_addTime", item.MpAddTime != null ?  (object)item.MpAddTime : DBNull.Value, DbType.String, 30)
							.AddInParameter("@Mp_text1", item.MpText1 != null ?  (object)item.MpText1 : DBNull.Value, DbType.String, 600)
							.AddInParameter("@Mp_text2", item.MpText2 != null ?  (object)item.MpText2 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 插入一组数据
		/// </summary>
		/// <param name = "items">要插入的实体对象集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Add(IEnumerable<ModulepermissionsEO> items, TransactionManager tm = null)
		{
			int ret = 0;
			const string sql = @"INSERT INTO modulepermissions (Md_id, Pm_id, Mp_user, Mp_addTime, Mp_text1, Mp_text2) VALUES (@Md_id, @Pm_id, @Mp_user, @Mp_addTime, @Mp_text1, @Mp_text2) ";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@Md_id", DbType.String, 150)
									.AddParameter("@Pm_id", DbType.String, 150)
									.AddParameter("@Mp_user", DbType.String, 150)
									.AddParameter("@Mp_addTime", DbType.String, 30)
									.AddParameter("@Mp_text1", DbType.String, 600)
									.AddParameter("@Mp_text2", DbType.String, 600);

			foreach (ModulepermissionsEO item in items)
			{
				sqlDao
					.SetParameterValue("@Md_id", item.MdId)
					.SetParameterValue("@Pm_id", item.PmId)
					.SetParameterValue("@Mp_user", item.MpUser != null ?  (object)item.MpUser : DBNull.Value)
					.SetParameterValue("@Mp_addTime", item.MpAddTime != null ?  (object)item.MpAddTime : DBNull.Value)
					.SetParameterValue("@Mp_text1", item.MpText1 != null ?  (object)item.MpText1 : DBNull.Value)
					.SetParameterValue("@Mp_text2", item.MpText2 != null ?  (object)item.MpText2 : DBNull.Value)
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
		public virtual int Put(ModulepermissionsEO item, TransactionManager tm = null)
		{
			const string sql = @"UPDATE modulepermissions SET Md_id=@Md_id, Pm_id=@Pm_id, Mp_user=@Mp_user, Mp_addTime=@Mp_addTime, Mp_text1=@Mp_text1, Mp_text2=@Mp_text2 WHERE Pm_id=@OriginalPm_id and Md_id=@OriginalMd_id";
			return Database.CreateSqlDao (sql)
							.AddInParameter("@OriginalMdId", (item.HasOriginal) ? item.OriginalMdId : item.MdId, DbType.String, 150)
							.AddInParameter("@OriginalPmId", (item.HasOriginal) ? item.OriginalPmId : item.PmId, DbType.String, 150)
							.AddInParameter("@Md_id", item.MdId, DbType.String, 150)
							.AddInParameter("@Pm_id", item.PmId, DbType.String, 150)
							.AddInParameter("@Mp_user", item.MpUser != null ?  (object)item.MpUser : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Mp_addTime", item.MpAddTime != null ?  (object)item.MpAddTime : DBNull.Value, DbType.String, 30)
							.AddInParameter("@Mp_text1", item.MpText1 != null ?  (object)item.MpText1 : DBNull.Value, DbType.String, 600)
							.AddInParameter("@Mp_text2", item.MpText2 != null ?  (object)item.MpText2 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}


		/// <summary>
		/// 更新数据
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Put(IEnumerable<ModulepermissionsEO> items, TransactionManager tm = null)
		{

			int ret = 0;
			const string sql = @"UPDATE modulepermissions SET Md_id=@Md_id, Pm_id=@Pm_id, Mp_user=@Mp_user, Mp_addTime=@Mp_addTime, Mp_text1=@Mp_text1, Mp_text2=@Mp_text2 WHERE Pm_id=@OriginalPm_id and Md_id=@OriginalMd_id";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@OriginalMdId", DbType.String, 150)
									.AddParameter("@OriginalPmId", DbType.String, 150)
									.AddParameter("@Md_id", DbType.String, 150)
									.AddParameter("@Pm_id", DbType.String, 150)
									.AddParameter("@Mp_user", DbType.String, 150)
									.AddParameter("@Mp_addTime", DbType.String, 30)
									.AddParameter("@Mp_text1", DbType.String, 600)
									.AddParameter("@Mp_text2", DbType.String, 600);

			foreach (ModulepermissionsEO item in items)
			{
				ret += sqlDao
							.SetParameterValue("@OriginalMdId", (item.HasOriginal) ? item.OriginalMdId : item.MdId)
							.SetParameterValue("@OriginalPmId", (item.HasOriginal) ? item.OriginalPmId : item.PmId)
							.SetParameterValue("@Md_id", item.MdId)
							.SetParameterValue("@Pm_id", item.PmId)
							.SetParameterValue("@Mp_user", item.MpUser != null ?  (object)item.MpUser : DBNull.Value)
							.SetParameterValue("@Mp_addTime", item.MpAddTime != null ?  (object)item.MpAddTime : DBNull.Value)
							.SetParameterValue("@Mp_text1", item.MpText1 != null ?  (object)item.MpText1 : DBNull.Value)
							.SetParameterValue("@Mp_text2", item.MpText2 != null ?  (object)item.MpText2 : DBNull.Value)
							.ExecNonQuery(tm);
			}
			return ret;
		}


		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "mdId"></param>
		/// <param name = "pmId"></param>
		/// <param name = "mpUser"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutMpUserByPK(string mdId, string pmId, string mpUser, TransactionManager tm = null)
		{
			const string sql = @"UPDATE modulepermissions SET Mp_user = @Mp_user  WHERE Md_id = @Md_id and Pm_id = @Pm_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Md_id", mdId, DbType.String, 150)
							.AddInParameter("@Pm_id", pmId, DbType.String, 150)
							.AddInParameter("@Mp_user", mpUser != null ?  (object)mpUser : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "mdId"></param>
		/// <param name = "pmId"></param>
		/// <param name = "mpAddTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutMpAddTimeByPK(string mdId, string pmId, string mpAddTime, TransactionManager tm = null)
		{
			const string sql = @"UPDATE modulepermissions SET Mp_addTime = @Mp_addTime  WHERE Md_id = @Md_id and Pm_id = @Pm_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Md_id", mdId, DbType.String, 150)
							.AddInParameter("@Pm_id", pmId, DbType.String, 150)
							.AddInParameter("@Mp_addTime", mpAddTime != null ?  (object)mpAddTime : DBNull.Value, DbType.String, 30)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "mdId"></param>
		/// <param name = "pmId"></param>
		/// <param name = "mpText1"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutMpText1ByPK(string mdId, string pmId, string mpText1, TransactionManager tm = null)
		{
			const string sql = @"UPDATE modulepermissions SET Mp_text1 = @Mp_text1  WHERE Md_id = @Md_id and Pm_id = @Pm_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Md_id", mdId, DbType.String, 150)
							.AddInParameter("@Pm_id", pmId, DbType.String, 150)
							.AddInParameter("@Mp_text1", mpText1 != null ?  (object)mpText1 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "mdId"></param>
		/// <param name = "pmId"></param>
		/// <param name = "mpText2"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutMpText2ByPK(string mdId, string pmId, string mpText2, TransactionManager tm = null)
		{
			const string sql = @"UPDATE modulepermissions SET Mp_text2 = @Mp_text2  WHERE Md_id = @Md_id and Pm_id = @Pm_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Md_id", mdId, DbType.String, 150)
							.AddInParameter("@Pm_id", pmId, DbType.String, 150)
							.AddInParameter("@Mp_text2", mpText2 != null ?  (object)mpText2 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}


		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "mpUser"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutMpUser(string mpUser, TransactionManager tm = null)
		{
			const string sql = @"UPDATE modulepermissions SET Mp_user=@Mp_user";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Mp_user", mpUser != null ?  (object)mpUser : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "mpAddTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutMpAddTime(string mpAddTime, TransactionManager tm = null)
		{
			const string sql = @"UPDATE modulepermissions SET Mp_addTime=@Mp_addTime";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Mp_addTime", mpAddTime != null ?  (object)mpAddTime : DBNull.Value, DbType.String, 30)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "mpText1"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutMpText1(string mpText1, TransactionManager tm = null)
		{
			const string sql = @"UPDATE modulepermissions SET Mp_text1=@Mp_text1";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Mp_text1", mpText1 != null ?  (object)mpText1 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "mpText2"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutMpText2(string mpText2, TransactionManager tm = null)
		{
			const string sql = @"UPDATE modulepermissions SET Mp_text2=@Mp_text2";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Mp_text2", mpText2 != null ?  (object)mpText2 : DBNull.Value, DbType.String, 600)
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
			const string format = @"UPDATE modulepermissions SET {0} {1}";
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
			const string format = @"UPDATE modulepermissions SET {0} {1}";
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
		/// <param name = "mdId"></param>
		/// <param name = "pmId"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByPK(string mdId, string pmId, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM modulepermissions WHERE Md_id=@Md_id and Pm_id=@Pm_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Md_id", mdId, DbType.String, 150)
							.AddInParameter("@Pm_id", pmId, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Remove(ModulepermissionsEO item, TransactionManager tm = null)
		{
			return RemoveByPK(item.MdId, item.PmId, tm);
		}

		/// <summary>
		/// 删除指定实体集合对应的记录集
		/// </summary>
		/// <param name = "items">要删除的实体集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Remove(IEnumerable<ModulepermissionsEO> items, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM modulepermissions WHERE Pm_id=@OriginalPm_id and Md_id=@OriginalMd_id";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@OriginalMdId", DbType.String, 150)
									.AddParameter("@OriginalPmId", DbType.String, 150);
			int ret = 0;
			foreach (ModulepermissionsEO item in items)
			{
				ret += sqlDao
							.SetParameterValue("@OriginalMdId", (item.HasOriginal) ? item.OriginalMdId : item.MdId)
							.SetParameterValue("@OriginalPmId", (item.HasOriginal) ? item.OriginalPmId : item.PmId)
							.ExecNonQuery(tm);
			}
			return ret;
		}




		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "mpUser"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByMpUser(string mpUser, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM modulepermissions WHERE Mp_user=@Mp_user";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Mp_user", mpUser != null ?  (object)mpUser : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "mpAddTime"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByMpAddTime(string mpAddTime, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM modulepermissions WHERE Mp_addTime=@Mp_addTime";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Mp_addTime", mpAddTime != null ?  (object)mpAddTime : DBNull.Value, DbType.String, 30)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "mpText1"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByMpText1(string mpText1, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM modulepermissions WHERE Mp_text1=@Mp_text1";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Mp_text1", mpText1 != null ?  (object)mpText1 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "mpText2"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByMpText2(string mpText2, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM modulepermissions WHERE Mp_text2=@Mp_text2";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Mp_text2", mpText2 != null ?  (object)mpText2 : DBNull.Value, DbType.String, 600)
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
			const string format = @"DELETE FROM modulepermissions {0}";
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
			const string format = @"DELETE FROM modulepermissions {0}";
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
