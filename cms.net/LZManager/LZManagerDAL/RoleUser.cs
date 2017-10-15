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
	/// 【表 roleuser 的实体类】
	/// </summary>
	[SerializableAttribute]
	public class RoleuserEO : DataEntityBase, IRowMapper<RoleuserEO>
	{
		protected string _originalUrId;
		protected string _originalRlId;

		/// <summary>
		/// 主键是否有原始值（即数据库中保存的值），用于实体对象更新时
		/// </summary>
		public bool HasOriginal { get; protected set; }

		/// <summary>
		/// 【主键 varchar】
		/// </summary>
		public virtual string UrId { get; set; }

		/// <summary>
		/// 【数据库中的原始主键值副本】
		/// </summary>
		public virtual string OriginalUrId
		{
			get { return _originalUrId; }
			set { HasOriginal = true; _originalUrId = value; }
		}

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
		public virtual string RuAddUser { get; set; }

		/// <summary>
		/// 【字段 datetime】
		/// </summary>
		public virtual DateTime RuAddTime { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string RuText1 { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string RuText2 { get; set; }

		/// <summary>
		/// 默认构造函数
		/// </summary>
		public RoleuserEO() 
		{
			UrId = string.Empty;
			RlId = string.Empty;
		}

		/// <summary>
		/// 自定义构造函数
		/// </summary>
		/// <param name = "urId"></param>
		/// <param name = "rlId"></param>
		/// <param name = "ruAddUser"></param>
		/// <param name = "ruAddTime"></param>
		/// <param name = "ruText1"></param>
		/// <param name = "ruText2"></param>
		public RoleuserEO(string urId, string rlId, string ruAddUser, DateTime ruAddTime, string ruText1, string ruText2) 
		{
			UrId = urId;
			RlId = rlId;
			RuAddUser = ruAddUser;
			RuAddTime = ruAddTime;
			RuText1 = ruText1;
			RuText2 = ruText2;
		}

		/// <summary>
		/// 将结果集映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public RoleuserEO MapRow(IDataReader reader)
		{
			return GetItem(reader);
		}

		/// <summary>
		/// 将结果集映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static RoleuserEO GetItem(IDataReader reader)
		{
			RoleuserEO ret = new RoleuserEO();

			ret.UrId = (string)reader["Ur_id"];
			ret.OriginalUrId = ret.UrId;
			ret.RlId = (string)reader["Rl_id"];
			ret.OriginalRlId = ret.RlId;
			ret.RuAddUser = (reader["Ru_AddUser"] is DBNull) ? null : (string)reader["Ru_AddUser"];
			ret.RuAddTime = DateTime.Parse(reader["Ru_AddTime"].ToString());
			ret.RuText1 = (reader["Ru_text1"] is DBNull) ? null : (string)reader["Ru_text1"];
			ret.RuText2 = (reader["Ru_text2"] is DBNull) ? null : (string)reader["Ru_text2"];
			return ret;
		}
	}


	#endregion

	#region  MO

	/// <summary>
	/// 【表 roleuser 的操作类】
	/// </summary>
    public partial class RoleuserMO : DataManagerBase
	{

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "routeData">路由数据</param>
		public RoleuserMO(object routeData = null) : base(routeData) { }

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">连接字符串名称</param>
		public RoleuserMO(string connectionStringName) : base(connectionStringName) { }

		#region  Get方法集合

		/// <summary>
		/// 按 PK（主键） 查询
		/// </summary>
		/// <param name="tm">事务管理对象</param>
		/// <param name = "urId"></param>
		/// <param name = "rlId"></param>
		/// <return></return>
		public virtual RoleuserEO GetByPK(string urId, string rlId, TransactionManager tm = null)
		{
			const string sql = @"SELECT Ur_id, Rl_id, Ru_AddUser, Ru_AddTime, Ru_text1, Ru_text2 FROM roleuser WHERE Ur_id=@Ur_id and Rl_id=@Rl_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_id", urId, DbType.String, 150)
							.AddInParameter("@Rl_id", rlId, DbType.String, 150)
							.ExecSingle<RoleuserEO>(RoleuserEO.GetItem, tm);
		}




		#region  按 UrId（字段） 查询

		/// <summary>
		/// 按 UrId（字段） 查询
		/// </summary>
		/// <param name = "urId"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleuserEO> GetByUrId(string urId)
		{
			return GetByUrId(urId, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 UrId（字段） 查询
		/// </summary>
		/// <param name = "urId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleuserEO> GetByUrId(string urId, TransactionManager tm)
		{
			return GetByUrId(urId, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 UrId（字段） 查询
		/// </summary>
		/// <param name = "urId"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleuserEO> GetByUrId(string urId, int top)
		{
			return GetByUrId(urId, top, string.Empty, null);
		}

		/// <summary>
		/// 按 UrId（字段） 查询
		/// </summary>
		/// <param name = "urId"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleuserEO> GetByUrId(string urId, int top, TransactionManager tm)
		{
			return GetByUrId(urId, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 UrId（字段） 查询
		/// </summary>
		/// <param name = "urId"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleuserEO> GetByUrId(string urId, string sort)
		{
			return GetByUrId(urId, 0, sort, null);
		}

		/// <summary>
		/// 按 UrId（字段） 查询
		/// </summary>
		/// <param name = "urId"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleuserEO> GetByUrId(string urId, string sort, TransactionManager tm)
		{
			return GetByUrId(urId, 0, sort, tm);
		}

		/// <summary>
		/// 按 UrId（字段） 查询
		/// </summary>
		/// <param name = "urId"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleuserEO> GetByUrId(string urId, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Ur_id, Rl_id, Ru_AddUser, Ru_AddTime, Ru_text1, Ru_text2 FROM roleuser WHERE Ur_id=@UrId";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@UrId", urId, DbType.String, 150)
							.ExecList<RoleuserEO>(RoleuserEO.GetItem, tm);
		}

		#endregion

		#region  按 RlId（字段） 查询

		/// <summary>
		/// 按 RlId（字段） 查询
		/// </summary>
		/// <param name = "rlId"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleuserEO> GetByRlId(string rlId)
		{
			return GetByRlId(rlId, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 RlId（字段） 查询
		/// </summary>
		/// <param name = "rlId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleuserEO> GetByRlId(string rlId, TransactionManager tm)
		{
			return GetByRlId(rlId, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 RlId（字段） 查询
		/// </summary>
		/// <param name = "rlId"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleuserEO> GetByRlId(string rlId, int top)
		{
			return GetByRlId(rlId, top, string.Empty, null);
		}

		/// <summary>
		/// 按 RlId（字段） 查询
		/// </summary>
		/// <param name = "rlId"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleuserEO> GetByRlId(string rlId, int top, TransactionManager tm)
		{
			return GetByRlId(rlId, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 RlId（字段） 查询
		/// </summary>
		/// <param name = "rlId"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleuserEO> GetByRlId(string rlId, string sort)
		{
			return GetByRlId(rlId, 0, sort, null);
		}

		/// <summary>
		/// 按 RlId（字段） 查询
		/// </summary>
		/// <param name = "rlId"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleuserEO> GetByRlId(string rlId, string sort, TransactionManager tm)
		{
			return GetByRlId(rlId, 0, sort, tm);
		}

		/// <summary>
		/// 按 RlId（字段） 查询
		/// </summary>
		/// <param name = "rlId"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleuserEO> GetByRlId(string rlId, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Ur_id, Rl_id, Ru_AddUser, Ru_AddTime, Ru_text1, Ru_text2 FROM roleuser WHERE Rl_id=@RlId";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@RlId", rlId, DbType.String, 150)
							.ExecList<RoleuserEO>(RoleuserEO.GetItem, tm);
		}

		#endregion

		#region  按 RuAddUser（字段） 查询

		/// <summary>
		/// 按 RuAddUser（字段） 查询
		/// </summary>
		/// <param name = "ruAddUser"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleuserEO> GetByRuAddUser(string ruAddUser)
		{
			return GetByRuAddUser(ruAddUser, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 RuAddUser（字段） 查询
		/// </summary>
		/// <param name = "ruAddUser"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleuserEO> GetByRuAddUser(string ruAddUser, TransactionManager tm)
		{
			return GetByRuAddUser(ruAddUser, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 RuAddUser（字段） 查询
		/// </summary>
		/// <param name = "ruAddUser"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleuserEO> GetByRuAddUser(string ruAddUser, int top)
		{
			return GetByRuAddUser(ruAddUser, top, string.Empty, null);
		}

		/// <summary>
		/// 按 RuAddUser（字段） 查询
		/// </summary>
		/// <param name = "ruAddUser"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleuserEO> GetByRuAddUser(string ruAddUser, int top, TransactionManager tm)
		{
			return GetByRuAddUser(ruAddUser, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 RuAddUser（字段） 查询
		/// </summary>
		/// <param name = "ruAddUser"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleuserEO> GetByRuAddUser(string ruAddUser, string sort)
		{
			return GetByRuAddUser(ruAddUser, 0, sort, null);
		}

		/// <summary>
		/// 按 RuAddUser（字段） 查询
		/// </summary>
		/// <param name = "ruAddUser"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleuserEO> GetByRuAddUser(string ruAddUser, string sort, TransactionManager tm)
		{
			return GetByRuAddUser(ruAddUser, 0, sort, tm);
		}

		/// <summary>
		/// 按 RuAddUser（字段） 查询
		/// </summary>
		/// <param name = "ruAddUser"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleuserEO> GetByRuAddUser(string ruAddUser, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Ur_id, Rl_id, Ru_AddUser, Ru_AddTime, Ru_text1, Ru_text2 FROM roleuser WHERE Ru_AddUser=@RuAddUser";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@RuAddUser", ruAddUser, DbType.String, 150)
							.ExecList<RoleuserEO>(RoleuserEO.GetItem, tm);
		}

		#endregion

		#region  按 RuAddTime（字段） 查询

		/// <summary>
		/// 按 RuAddTime（字段） 查询
		/// </summary>
		/// <param name = "ruAddTime"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleuserEO> GetByRuAddTime(DateTime ruAddTime)
		{
			return GetByRuAddTime(ruAddTime, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 RuAddTime（字段） 查询
		/// </summary>
		/// <param name = "ruAddTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleuserEO> GetByRuAddTime(DateTime ruAddTime, TransactionManager tm)
		{
			return GetByRuAddTime(ruAddTime, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 RuAddTime（字段） 查询
		/// </summary>
		/// <param name = "ruAddTime"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleuserEO> GetByRuAddTime(DateTime ruAddTime, int top)
		{
			return GetByRuAddTime(ruAddTime, top, string.Empty, null);
		}

		/// <summary>
		/// 按 RuAddTime（字段） 查询
		/// </summary>
		/// <param name = "ruAddTime"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleuserEO> GetByRuAddTime(DateTime ruAddTime, int top, TransactionManager tm)
		{
			return GetByRuAddTime(ruAddTime, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 RuAddTime（字段） 查询
		/// </summary>
		/// <param name = "ruAddTime"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleuserEO> GetByRuAddTime(DateTime ruAddTime, string sort)
		{
			return GetByRuAddTime(ruAddTime, 0, sort, null);
		}

		/// <summary>
		/// 按 RuAddTime（字段） 查询
		/// </summary>
		/// <param name = "ruAddTime"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleuserEO> GetByRuAddTime(DateTime ruAddTime, string sort, TransactionManager tm)
		{
			return GetByRuAddTime(ruAddTime, 0, sort, tm);
		}

		/// <summary>
		/// 按 RuAddTime（字段） 查询
		/// </summary>
		/// <param name = "ruAddTime"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleuserEO> GetByRuAddTime(DateTime ruAddTime, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Ur_id, Rl_id, Ru_AddUser, Ru_AddTime, Ru_text1, Ru_text2 FROM roleuser WHERE Ru_AddTime=@RuAddTime";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@RuAddTime", ruAddTime, DbType.DateTime, 0)
							.ExecList<RoleuserEO>(RoleuserEO.GetItem, tm);
		}

		#endregion

		#region  按 RuText1（字段） 查询

		/// <summary>
		/// 按 RuText1（字段） 查询
		/// </summary>
		/// <param name = "ruText1"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleuserEO> GetByRuText1(string ruText1)
		{
			return GetByRuText1(ruText1, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 RuText1（字段） 查询
		/// </summary>
		/// <param name = "ruText1"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleuserEO> GetByRuText1(string ruText1, TransactionManager tm)
		{
			return GetByRuText1(ruText1, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 RuText1（字段） 查询
		/// </summary>
		/// <param name = "ruText1"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleuserEO> GetByRuText1(string ruText1, int top)
		{
			return GetByRuText1(ruText1, top, string.Empty, null);
		}

		/// <summary>
		/// 按 RuText1（字段） 查询
		/// </summary>
		/// <param name = "ruText1"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleuserEO> GetByRuText1(string ruText1, int top, TransactionManager tm)
		{
			return GetByRuText1(ruText1, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 RuText1（字段） 查询
		/// </summary>
		/// <param name = "ruText1"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleuserEO> GetByRuText1(string ruText1, string sort)
		{
			return GetByRuText1(ruText1, 0, sort, null);
		}

		/// <summary>
		/// 按 RuText1（字段） 查询
		/// </summary>
		/// <param name = "ruText1"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleuserEO> GetByRuText1(string ruText1, string sort, TransactionManager tm)
		{
			return GetByRuText1(ruText1, 0, sort, tm);
		}

		/// <summary>
		/// 按 RuText1（字段） 查询
		/// </summary>
		/// <param name = "ruText1"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleuserEO> GetByRuText1(string ruText1, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Ur_id, Rl_id, Ru_AddUser, Ru_AddTime, Ru_text1, Ru_text2 FROM roleuser WHERE Ru_text1=@RuText1";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@RuText1", ruText1, DbType.String, 600)
							.ExecList<RoleuserEO>(RoleuserEO.GetItem, tm);
		}

		#endregion

		#region  按 RuText2（字段） 查询

		/// <summary>
		/// 按 RuText2（字段） 查询
		/// </summary>
		/// <param name = "ruText2"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleuserEO> GetByRuText2(string ruText2)
		{
			return GetByRuText2(ruText2, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 RuText2（字段） 查询
		/// </summary>
		/// <param name = "ruText2"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleuserEO> GetByRuText2(string ruText2, TransactionManager tm)
		{
			return GetByRuText2(ruText2, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 RuText2（字段） 查询
		/// </summary>
		/// <param name = "ruText2"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleuserEO> GetByRuText2(string ruText2, int top)
		{
			return GetByRuText2(ruText2, top, string.Empty, null);
		}

		/// <summary>
		/// 按 RuText2（字段） 查询
		/// </summary>
		/// <param name = "ruText2"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleuserEO> GetByRuText2(string ruText2, int top, TransactionManager tm)
		{
			return GetByRuText2(ruText2, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 RuText2（字段） 查询
		/// </summary>
		/// <param name = "ruText2"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleuserEO> GetByRuText2(string ruText2, string sort)
		{
			return GetByRuText2(ruText2, 0, sort, null);
		}

		/// <summary>
		/// 按 RuText2（字段） 查询
		/// </summary>
		/// <param name = "ruText2"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleuserEO> GetByRuText2(string ruText2, string sort, TransactionManager tm)
		{
			return GetByRuText2(ruText2, 0, sort, tm);
		}

		/// <summary>
		/// 按 RuText2（字段） 查询
		/// </summary>
		/// <param name = "ruText2"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleuserEO> GetByRuText2(string ruText2, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Ur_id, Rl_id, Ru_AddUser, Ru_AddTime, Ru_text1, Ru_text2 FROM roleuser WHERE Ru_text2=@RuText2";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@RuText2", ruText2, DbType.String, 600)
							.ExecList<RoleuserEO>(RoleuserEO.GetItem, tm);
		}

		#endregion

		#region  自定义条件查询

		/// <summary>
		/// 获取所有数据
		/// </summary>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleuserEO> GetAll(TransactionManager tm = null)
		{
			return GetTopSort(string.Empty, null, -1, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "values">where子句中定义的参数值集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleuserEO> Get(string where, params object[] values)
		{
			return GetTopSort(where, -1, string.Empty, null, values);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "paras">where子句中定义的参数集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleuserEO> Get(string where, IEnumerable<DbParameter> paras)
		{
			return GetTopSort(where, paras, -1, string.Empty, null);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleuserEO> Get(string where, TransactionManager tm)
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
		public virtual IEnumerable<RoleuserEO> Get(string where, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<RoleuserEO> Get(string where, IEnumerable<DbParameter> paras, TransactionManager tm)
		{
			return GetTopSort(where, paras, -1, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleuserEO> GetTop(string where, int top)
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
		public virtual IEnumerable<RoleuserEO> GetTop(string where, int top, params object[] values)
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
		public virtual IEnumerable<RoleuserEO> GetTop(string where, IEnumerable<DbParameter> paras, int top)
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
		public virtual IEnumerable<RoleuserEO> GetTop(string where, int top, TransactionManager tm)
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
		public virtual IEnumerable<RoleuserEO> GetTop(string where, int top, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<RoleuserEO> GetTop(string where, IEnumerable<DbParameter> paras, int top, TransactionManager tm)
		{
			return GetTopSort(where, paras, top, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RoleuserEO> GetSort(string where, string sort)
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
		public virtual IEnumerable<RoleuserEO> GetSort(string where, string sort, params object[] values)
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
		public virtual IEnumerable<RoleuserEO> GetSort(string where, IEnumerable<DbParameter> paras, string sort)
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
		public virtual IEnumerable<RoleuserEO> GetSort(string where, string sort, TransactionManager tm)
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
		public virtual IEnumerable<RoleuserEO> GetSort(string where, string sort, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<RoleuserEO> GetSort(string where, IEnumerable<DbParameter> paras, string sort, TransactionManager tm)
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
		public virtual IEnumerable<RoleuserEO> GetTopSort(string where, int top, string sort)
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
		public virtual IEnumerable<RoleuserEO> GetTopSort(string where, int top, string sort, params object[] values)
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
		public virtual IEnumerable<RoleuserEO> GetTopSort(string where, IEnumerable<DbParameter> paras, int top, string sort)
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
		public virtual IEnumerable<RoleuserEO> GetTopSort(string where, int top, string sort, TransactionManager tm)
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
		public virtual IEnumerable<RoleuserEO> GetTopSort(string where, int top, string sort, TransactionManager tm, params object[] values)
		{
			const string format = @"SELECT {0} Ur_id, Rl_id, Ru_AddUser, Ru_AddTime, Ru_text1, Ru_text2 FROM roleuser";
			string sql = format;

			if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameters(values)
							.ExecList<RoleuserEO>(RoleuserEO.GetItem, tm);
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
		public virtual IEnumerable<RoleuserEO> GetTopSort(string where, IEnumerable<DbParameter> paras, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Ur_id, Rl_id, Ru_AddUser, Ru_AddTime, Ru_text1, Ru_text2 FROM roleuser";
			string sql = format;

			if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddParameters(paras)
							.ExecList<RoleuserEO>(RoleuserEO.GetItem, tm);
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
			const string format = @"SELECT Ur_id, Rl_id, Ru_AddUser, Ru_AddTime, Ru_text1, Ru_text2 FROM roleuser {0} {1}";
			 string sql = string.Format(format, string.IsNullOrEmpty(where) ? string.Empty : "WHERE " + where, string.IsNullOrEmpty(sort) ? string.Empty : "ORDER BY " + sort);

			return Database.CreatePager(sql, pageSize, "Ur_id,Rl_id");
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
		public virtual List<RoleuserEO> GetPageList(int pageIndex , int pageSize, string where = null, string sort = null, IEnumerable<DbParameter> paras = null)
		{
			var pager = GetPager(pageSize, where, sort);

			pager.AddParameters(paras);
			return pager.GetPageList<RoleuserEO>(pageIndex);
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
		public virtual IEnumerable<RoleuserEO> GetPageMutil(int pageIndex , int pageSize, string where = null, string sort = null, IEnumerable<DbParameter> paras = null)
		{
			var pager = GetPager(pageSize, where, sort);

			pager.AddParameters(paras);
			return pager.GetPageMutil<RoleuserEO>(pageIndex);
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
		public virtual int Add(RoleuserEO item, TransactionManager tm = null)
		{
			const string sql = @"INSERT INTO roleuser (Ur_id, Rl_id, Ru_AddUser, Ru_AddTime, Ru_text1, Ru_text2) VALUES (@Ur_id, @Rl_id, @Ru_AddUser, @Ru_AddTime, @Ru_text1, @Ru_text2) ";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_id", item.UrId, DbType.String, 150)
							.AddInParameter("@Rl_id", item.RlId, DbType.String, 150)
							.AddInParameter("@Ru_AddUser", item.RuAddUser != null ?  (object)item.RuAddUser : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Ru_AddTime", item.RuAddTime, DbType.DateTime, 0)
							.AddInParameter("@Ru_text1", item.RuText1 != null ?  (object)item.RuText1 : DBNull.Value, DbType.String, 600)
							.AddInParameter("@Ru_text2", item.RuText2 != null ?  (object)item.RuText2 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 插入一组数据
		/// </summary>
		/// <param name = "items">要插入的实体对象集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Add(IEnumerable<RoleuserEO> items, TransactionManager tm = null)
		{
			int ret = 0;
			const string sql = @"INSERT INTO roleuser (Ur_id, Rl_id, Ru_AddUser, Ru_AddTime, Ru_text1, Ru_text2) VALUES (@Ur_id, @Rl_id, @Ru_AddUser, @Ru_AddTime, @Ru_text1, @Ru_text2) ";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@Ur_id", DbType.String, 150)
									.AddParameter("@Rl_id", DbType.String, 150)
									.AddParameter("@Ru_AddUser", DbType.String, 150)
									.AddParameter("@Ru_AddTime", DbType.DateTime, 0)
									.AddParameter("@Ru_text1", DbType.String, 600)
									.AddParameter("@Ru_text2", DbType.String, 600);

			foreach (RoleuserEO item in items)
			{
				sqlDao
					.SetParameterValue("@Ur_id", item.UrId)
					.SetParameterValue("@Rl_id", item.RlId)
					.SetParameterValue("@Ru_AddUser", item.RuAddUser != null ?  (object)item.RuAddUser : DBNull.Value)
					.SetParameterValue("@Ru_AddTime", item.RuAddTime)
					.SetParameterValue("@Ru_text1", item.RuText1 != null ?  (object)item.RuText1 : DBNull.Value)
					.SetParameterValue("@Ru_text2", item.RuText2 != null ?  (object)item.RuText2 : DBNull.Value)
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
		public virtual int Put(RoleuserEO item, TransactionManager tm = null)
		{
			const string sql = @"UPDATE roleuser SET Ur_id=@Ur_id, Rl_id=@Rl_id, Ru_AddUser=@Ru_AddUser, Ru_AddTime=@Ru_AddTime, Ru_text1=@Ru_text1, Ru_text2=@Ru_text2 WHERE Ur_id=@OriginalUr_id and Rl_id=@OriginalRl_id";
			return Database.CreateSqlDao (sql)
							.AddInParameter("@OriginalUrId", (item.HasOriginal) ? item.OriginalUrId : item.UrId, DbType.String, 150)
							.AddInParameter("@OriginalRlId", (item.HasOriginal) ? item.OriginalRlId : item.RlId, DbType.String, 150)
							.AddInParameter("@Ur_id", item.UrId, DbType.String, 150)
							.AddInParameter("@Rl_id", item.RlId, DbType.String, 150)
							.AddInParameter("@Ru_AddUser", item.RuAddUser != null ?  (object)item.RuAddUser : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Ru_AddTime", item.RuAddTime, DbType.DateTime, 0)
							.AddInParameter("@Ru_text1", item.RuText1 != null ?  (object)item.RuText1 : DBNull.Value, DbType.String, 600)
							.AddInParameter("@Ru_text2", item.RuText2 != null ?  (object)item.RuText2 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}


		/// <summary>
		/// 更新数据
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Put(IEnumerable<RoleuserEO> items, TransactionManager tm = null)
		{

			int ret = 0;
			const string sql = @"UPDATE roleuser SET Ur_id=@Ur_id, Rl_id=@Rl_id, Ru_AddUser=@Ru_AddUser, Ru_AddTime=@Ru_AddTime, Ru_text1=@Ru_text1, Ru_text2=@Ru_text2 WHERE Ur_id=@OriginalUr_id and Rl_id=@OriginalRl_id";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@OriginalUrId", DbType.String, 150)
									.AddParameter("@OriginalRlId", DbType.String, 150)
									.AddParameter("@Ur_id", DbType.String, 150)
									.AddParameter("@Rl_id", DbType.String, 150)
									.AddParameter("@Ru_AddUser", DbType.String, 150)
									.AddParameter("@Ru_AddTime", DbType.DateTime, 0)
									.AddParameter("@Ru_text1", DbType.String, 600)
									.AddParameter("@Ru_text2", DbType.String, 600);

			foreach (RoleuserEO item in items)
			{
				ret += sqlDao
							.SetParameterValue("@OriginalUrId", (item.HasOriginal) ? item.OriginalUrId : item.UrId)
							.SetParameterValue("@OriginalRlId", (item.HasOriginal) ? item.OriginalRlId : item.RlId)
							.SetParameterValue("@Ur_id", item.UrId)
							.SetParameterValue("@Rl_id", item.RlId)
							.SetParameterValue("@Ru_AddUser", item.RuAddUser != null ?  (object)item.RuAddUser : DBNull.Value)
							.SetParameterValue("@Ru_AddTime", item.RuAddTime)
							.SetParameterValue("@Ru_text1", item.RuText1 != null ?  (object)item.RuText1 : DBNull.Value)
							.SetParameterValue("@Ru_text2", item.RuText2 != null ?  (object)item.RuText2 : DBNull.Value)
							.ExecNonQuery(tm);
			}
			return ret;
		}


		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "urId"></param>
		/// <param name = "rlId"></param>
		/// <param name = "ruAddUser"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutRuAddUserByPK(string urId, string rlId, string ruAddUser, TransactionManager tm = null)
		{
			const string sql = @"UPDATE roleuser SET Ru_AddUser = @Ru_AddUser  WHERE Ur_id = @Ur_id and Rl_id = @Rl_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_id", urId, DbType.String, 150)
							.AddInParameter("@Rl_id", rlId, DbType.String, 150)
							.AddInParameter("@Ru_AddUser", ruAddUser != null ?  (object)ruAddUser : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "urId"></param>
		/// <param name = "rlId"></param>
		/// <param name = "ruAddTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutRuAddTimeByPK(string urId, string rlId, DateTime ruAddTime, TransactionManager tm = null)
		{
			const string sql = @"UPDATE roleuser SET Ru_AddTime = @Ru_AddTime  WHERE Ur_id = @Ur_id and Rl_id = @Rl_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_id", urId, DbType.String, 150)
							.AddInParameter("@Rl_id", rlId, DbType.String, 150)
							.AddInParameter("@Ru_AddTime", ruAddTime, DbType.DateTime, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "urId"></param>
		/// <param name = "rlId"></param>
		/// <param name = "ruText1"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutRuText1ByPK(string urId, string rlId, string ruText1, TransactionManager tm = null)
		{
			const string sql = @"UPDATE roleuser SET Ru_text1 = @Ru_text1  WHERE Ur_id = @Ur_id and Rl_id = @Rl_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_id", urId, DbType.String, 150)
							.AddInParameter("@Rl_id", rlId, DbType.String, 150)
							.AddInParameter("@Ru_text1", ruText1 != null ?  (object)ruText1 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "urId"></param>
		/// <param name = "rlId"></param>
		/// <param name = "ruText2"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutRuText2ByPK(string urId, string rlId, string ruText2, TransactionManager tm = null)
		{
			const string sql = @"UPDATE roleuser SET Ru_text2 = @Ru_text2  WHERE Ur_id = @Ur_id and Rl_id = @Rl_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_id", urId, DbType.String, 150)
							.AddInParameter("@Rl_id", rlId, DbType.String, 150)
							.AddInParameter("@Ru_text2", ruText2 != null ?  (object)ruText2 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}


		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "ruAddUser"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutRuAddUser(string ruAddUser, TransactionManager tm = null)
		{
			const string sql = @"UPDATE roleuser SET Ru_AddUser=@Ru_AddUser";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ru_AddUser", ruAddUser != null ?  (object)ruAddUser : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "ruAddTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutRuAddTime(DateTime ruAddTime, TransactionManager tm = null)
		{
			const string sql = @"UPDATE roleuser SET Ru_AddTime=@Ru_AddTime";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ru_AddTime", ruAddTime, DbType.DateTime, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "ruText1"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutRuText1(string ruText1, TransactionManager tm = null)
		{
			const string sql = @"UPDATE roleuser SET Ru_text1=@Ru_text1";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ru_text1", ruText1 != null ?  (object)ruText1 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "ruText2"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutRuText2(string ruText2, TransactionManager tm = null)
		{
			const string sql = @"UPDATE roleuser SET Ru_text2=@Ru_text2";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ru_text2", ruText2 != null ?  (object)ruText2 : DBNull.Value, DbType.String, 600)
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
			const string format = @"UPDATE roleuser SET {0} {1}";
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
			const string format = @"UPDATE roleuser SET {0} {1}";
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
		/// <param name = "urId"></param>
		/// <param name = "rlId"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByPK(string urId, string rlId, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM roleuser WHERE Ur_id=@Ur_id and Rl_id=@Rl_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_id", urId, DbType.String, 150)
							.AddInParameter("@Rl_id", rlId, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Remove(RoleuserEO item, TransactionManager tm = null)
		{
			return RemoveByPK(item.UrId, item.RlId, tm);
		}

		/// <summary>
		/// 删除指定实体集合对应的记录集
		/// </summary>
		/// <param name = "items">要删除的实体集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Remove(IEnumerable<RoleuserEO> items, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM roleuser WHERE Ur_id=@OriginalUr_id and Rl_id=@OriginalRl_id";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@OriginalUrId", DbType.String, 150)
									.AddParameter("@OriginalRlId", DbType.String, 150);
			int ret = 0;
			foreach (RoleuserEO item in items)
			{
				ret += sqlDao
							.SetParameterValue("@OriginalUrId", (item.HasOriginal) ? item.OriginalUrId : item.UrId)
							.SetParameterValue("@OriginalRlId", (item.HasOriginal) ? item.OriginalRlId : item.RlId)
							.ExecNonQuery(tm);
			}
			return ret;
		}




		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "ruAddUser"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByRuAddUser(string ruAddUser, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM roleuser WHERE Ru_AddUser=@Ru_AddUser";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ru_AddUser", ruAddUser != null ?  (object)ruAddUser : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "ruAddTime"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByRuAddTime(DateTime ruAddTime, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM roleuser WHERE Ru_AddTime=@Ru_AddTime";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ru_AddTime", ruAddTime, DbType.DateTime, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "ruText1"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByRuText1(string ruText1, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM roleuser WHERE Ru_text1=@Ru_text1";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ru_text1", ruText1 != null ?  (object)ruText1 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "ruText2"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByRuText2(string ruText2, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM roleuser WHERE Ru_text2=@Ru_text2";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ru_text2", ruText2 != null ?  (object)ruText2 : DBNull.Value, DbType.String, 600)
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
			const string format = @"DELETE FROM roleuser {0}";
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
			const string format = @"DELETE FROM roleuser {0}";
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
