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
	/// 【表 log 的实体类】
	/// </summary>
	[SerializableAttribute]
	public class NxLogEO : DataEntityBase, IRowMapper<NxLogEO>
	{
		protected string _originalLgId;

		/// <summary>
		/// 主键是否有原始值（即数据库中保存的值），用于实体对象更新时
		/// </summary>
		public bool HasOriginal { get; protected set; }

		/// <summary>
		/// 【主键 varchar】
		/// </summary>
		public virtual string LgId { get; set; }

		/// <summary>
		/// 【数据库中的原始主键值副本】
		/// </summary>
		public virtual string OriginalLgId
		{
			get { return _originalLgId; }
			set { HasOriginal = true; _originalLgId = value; }
		}

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string UrId { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string LgUserip { get; set; }

		/// <summary>
		/// 【字段 datetime】
		/// </summary>
		public virtual DateTime LgAddtime { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string LgName { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string LgContent { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string LgText1 { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string LgText2 { get; set; }

		/// <summary>
		/// 默认构造函数
		/// </summary>
		public NxLogEO() 
		{
			LgId = string.Empty;
		}

		/// <summary>
		/// 自定义构造函数
		/// </summary>
		/// <param name = "lgId"></param>
		/// <param name = "urId"></param>
		/// <param name = "lgUserip"></param>
		/// <param name = "lgAddtime"></param>
		/// <param name = "lgName"></param>
		/// <param name = "lgContent"></param>
		/// <param name = "lgText1"></param>
		/// <param name = "lgText2"></param>
		public NxLogEO(string lgId, string urId, string lgUserip, DateTime lgAddtime, string lgName, string lgContent, string lgText1, string lgText2) 
		{
			LgId = lgId;
			UrId = urId;
			LgUserip = lgUserip;
			LgAddtime = lgAddtime;
			LgName = lgName;
			LgContent = lgContent;
			LgText1 = lgText1;
			LgText2 = lgText2;
		}

		/// <summary>
		/// 将结果集映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public NxLogEO MapRow(IDataReader reader)
		{
			return GetItem(reader);
		}

		/// <summary>
		/// 将结果集映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static NxLogEO GetItem(IDataReader reader)
		{
			NxLogEO ret = new NxLogEO();

			ret.LgId = (string)reader["Lg_id"];
			ret.OriginalLgId = ret.LgId;
			ret.UrId = (reader["Ur_id"] is DBNull) ? null : (string)reader["Ur_id"];
			ret.LgUserip = (reader["Lg_userip"] is DBNull) ? null : (string)reader["Lg_userip"];
			ret.LgAddtime = DateTime.Parse(reader["Lg_addtime"].ToString());
			ret.LgName = (reader["Lg_name"] is DBNull) ? null : (string)reader["Lg_name"];
			ret.LgContent = (reader["Lg_content"] is DBNull) ? null : (string)reader["Lg_content"];
			ret.LgText1 = (reader["Lg_text1"] is DBNull) ? null : (string)reader["Lg_text1"];
			ret.LgText2 = (reader["Lg_text2"] is DBNull) ? null : (string)reader["Lg_text2"];
			return ret;
		}
	}


	#endregion

	#region  MO

	/// <summary>
	/// 【表 log 的操作类】
	/// </summary>
    public partial class NxLogMO : DataManagerBase
	{

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "routeData">路由数据</param>
		public NxLogMO(object routeData = null) : base(routeData) { }

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">连接字符串名称</param>
		public NxLogMO(string connectionStringName) : base(connectionStringName) { }

		#region  Get方法集合

		/// <summary>
		/// 按 PK（主键） 查询
		/// </summary>
		/// <param name="tm">事务管理对象</param>
		/// <param name = "lgId"></param>
		/// <return></return>
		public virtual NxLogEO GetByPK(string lgId, TransactionManager tm = null)
		{
			const string sql = @"SELECT Lg_id, Ur_id, Lg_userip, Lg_addtime, Lg_name, Lg_content, Lg_text1, Lg_text2 FROM log WHERE Lg_id=@Lg_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Lg_id", lgId, DbType.String, 150)
							.ExecSingle<NxLogEO>(NxLogEO.GetItem, tm);
		}




		#region  按 UrId（字段） 查询

		/// <summary>
		/// 按 UrId（字段） 查询
		/// </summary>
		/// <param name = "urId"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<NxLogEO> GetByUrId(string urId)
		{
			return GetByUrId(urId, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 UrId（字段） 查询
		/// </summary>
		/// <param name = "urId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<NxLogEO> GetByUrId(string urId, TransactionManager tm)
		{
			return GetByUrId(urId, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 UrId（字段） 查询
		/// </summary>
		/// <param name = "urId"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<NxLogEO> GetByUrId(string urId, int top)
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
		public virtual IEnumerable<NxLogEO> GetByUrId(string urId, int top, TransactionManager tm)
		{
			return GetByUrId(urId, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 UrId（字段） 查询
		/// </summary>
		/// <param name = "urId"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<NxLogEO> GetByUrId(string urId, string sort)
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
		public virtual IEnumerable<NxLogEO> GetByUrId(string urId, string sort, TransactionManager tm)
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
		public virtual IEnumerable<NxLogEO> GetByUrId(string urId, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Lg_id, Ur_id, Lg_userip, Lg_addtime, Lg_name, Lg_content, Lg_text1, Lg_text2 FROM log WHERE Ur_id=@UrId";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@UrId", urId, DbType.String, 150)
							.ExecList<NxLogEO>(NxLogEO.GetItem, tm);
		}

		#endregion

		#region  按 LgUserip（字段） 查询

		/// <summary>
		/// 按 LgUserip（字段） 查询
		/// </summary>
		/// <param name = "lgUserip"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<NxLogEO> GetByLgUserip(string lgUserip)
		{
			return GetByLgUserip(lgUserip, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 LgUserip（字段） 查询
		/// </summary>
		/// <param name = "lgUserip"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<NxLogEO> GetByLgUserip(string lgUserip, TransactionManager tm)
		{
			return GetByLgUserip(lgUserip, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 LgUserip（字段） 查询
		/// </summary>
		/// <param name = "lgUserip"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<NxLogEO> GetByLgUserip(string lgUserip, int top)
		{
			return GetByLgUserip(lgUserip, top, string.Empty, null);
		}

		/// <summary>
		/// 按 LgUserip（字段） 查询
		/// </summary>
		/// <param name = "lgUserip"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<NxLogEO> GetByLgUserip(string lgUserip, int top, TransactionManager tm)
		{
			return GetByLgUserip(lgUserip, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 LgUserip（字段） 查询
		/// </summary>
		/// <param name = "lgUserip"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<NxLogEO> GetByLgUserip(string lgUserip, string sort)
		{
			return GetByLgUserip(lgUserip, 0, sort, null);
		}

		/// <summary>
		/// 按 LgUserip（字段） 查询
		/// </summary>
		/// <param name = "lgUserip"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<NxLogEO> GetByLgUserip(string lgUserip, string sort, TransactionManager tm)
		{
			return GetByLgUserip(lgUserip, 0, sort, tm);
		}

		/// <summary>
		/// 按 LgUserip（字段） 查询
		/// </summary>
		/// <param name = "lgUserip"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<NxLogEO> GetByLgUserip(string lgUserip, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Lg_id, Ur_id, Lg_userip, Lg_addtime, Lg_name, Lg_content, Lg_text1, Lg_text2 FROM log WHERE Lg_userip=@LgUserip";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@LgUserip", lgUserip, DbType.String, 150)
							.ExecList<NxLogEO>(NxLogEO.GetItem, tm);
		}

		#endregion

		#region  按 LgAddtime（字段） 查询

		/// <summary>
		/// 按 LgAddtime（字段） 查询
		/// </summary>
		/// <param name = "lgAddtime"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<NxLogEO> GetByLgAddtime(DateTime lgAddtime)
		{
			return GetByLgAddtime(lgAddtime, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 LgAddtime（字段） 查询
		/// </summary>
		/// <param name = "lgAddtime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<NxLogEO> GetByLgAddtime(DateTime lgAddtime, TransactionManager tm)
		{
			return GetByLgAddtime(lgAddtime, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 LgAddtime（字段） 查询
		/// </summary>
		/// <param name = "lgAddtime"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<NxLogEO> GetByLgAddtime(DateTime lgAddtime, int top)
		{
			return GetByLgAddtime(lgAddtime, top, string.Empty, null);
		}

		/// <summary>
		/// 按 LgAddtime（字段） 查询
		/// </summary>
		/// <param name = "lgAddtime"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<NxLogEO> GetByLgAddtime(DateTime lgAddtime, int top, TransactionManager tm)
		{
			return GetByLgAddtime(lgAddtime, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 LgAddtime（字段） 查询
		/// </summary>
		/// <param name = "lgAddtime"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<NxLogEO> GetByLgAddtime(DateTime lgAddtime, string sort)
		{
			return GetByLgAddtime(lgAddtime, 0, sort, null);
		}

		/// <summary>
		/// 按 LgAddtime（字段） 查询
		/// </summary>
		/// <param name = "lgAddtime"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<NxLogEO> GetByLgAddtime(DateTime lgAddtime, string sort, TransactionManager tm)
		{
			return GetByLgAddtime(lgAddtime, 0, sort, tm);
		}

		/// <summary>
		/// 按 LgAddtime（字段） 查询
		/// </summary>
		/// <param name = "lgAddtime"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<NxLogEO> GetByLgAddtime(DateTime lgAddtime, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Lg_id, Ur_id, Lg_userip, Lg_addtime, Lg_name, Lg_content, Lg_text1, Lg_text2 FROM log WHERE Lg_addtime=@LgAddtime";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@LgAddtime", lgAddtime, DbType.DateTime, 0)
							.ExecList<NxLogEO>(NxLogEO.GetItem, tm);
		}

		#endregion

		#region  按 LgName（字段） 查询

		/// <summary>
		/// 按 LgName（字段） 查询
		/// </summary>
		/// <param name = "lgName"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<NxLogEO> GetByLgName(string lgName)
		{
			return GetByLgName(lgName, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 LgName（字段） 查询
		/// </summary>
		/// <param name = "lgName"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<NxLogEO> GetByLgName(string lgName, TransactionManager tm)
		{
			return GetByLgName(lgName, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 LgName（字段） 查询
		/// </summary>
		/// <param name = "lgName"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<NxLogEO> GetByLgName(string lgName, int top)
		{
			return GetByLgName(lgName, top, string.Empty, null);
		}

		/// <summary>
		/// 按 LgName（字段） 查询
		/// </summary>
		/// <param name = "lgName"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<NxLogEO> GetByLgName(string lgName, int top, TransactionManager tm)
		{
			return GetByLgName(lgName, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 LgName（字段） 查询
		/// </summary>
		/// <param name = "lgName"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<NxLogEO> GetByLgName(string lgName, string sort)
		{
			return GetByLgName(lgName, 0, sort, null);
		}

		/// <summary>
		/// 按 LgName（字段） 查询
		/// </summary>
		/// <param name = "lgName"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<NxLogEO> GetByLgName(string lgName, string sort, TransactionManager tm)
		{
			return GetByLgName(lgName, 0, sort, tm);
		}

		/// <summary>
		/// 按 LgName（字段） 查询
		/// </summary>
		/// <param name = "lgName"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<NxLogEO> GetByLgName(string lgName, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Lg_id, Ur_id, Lg_userip, Lg_addtime, Lg_name, Lg_content, Lg_text1, Lg_text2 FROM log WHERE Lg_name=@LgName";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@LgName", lgName, DbType.String, 150)
							.ExecList<NxLogEO>(NxLogEO.GetItem, tm);
		}

		#endregion

		#region  按 LgContent（字段） 查询

		/// <summary>
		/// 按 LgContent（字段） 查询
		/// </summary>
		/// <param name = "lgContent"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<NxLogEO> GetByLgContent(string lgContent)
		{
			return GetByLgContent(lgContent, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 LgContent（字段） 查询
		/// </summary>
		/// <param name = "lgContent"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<NxLogEO> GetByLgContent(string lgContent, TransactionManager tm)
		{
			return GetByLgContent(lgContent, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 LgContent（字段） 查询
		/// </summary>
		/// <param name = "lgContent"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<NxLogEO> GetByLgContent(string lgContent, int top)
		{
			return GetByLgContent(lgContent, top, string.Empty, null);
		}

		/// <summary>
		/// 按 LgContent（字段） 查询
		/// </summary>
		/// <param name = "lgContent"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<NxLogEO> GetByLgContent(string lgContent, int top, TransactionManager tm)
		{
			return GetByLgContent(lgContent, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 LgContent（字段） 查询
		/// </summary>
		/// <param name = "lgContent"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<NxLogEO> GetByLgContent(string lgContent, string sort)
		{
			return GetByLgContent(lgContent, 0, sort, null);
		}

		/// <summary>
		/// 按 LgContent（字段） 查询
		/// </summary>
		/// <param name = "lgContent"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<NxLogEO> GetByLgContent(string lgContent, string sort, TransactionManager tm)
		{
			return GetByLgContent(lgContent, 0, sort, tm);
		}

		/// <summary>
		/// 按 LgContent（字段） 查询
		/// </summary>
		/// <param name = "lgContent"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<NxLogEO> GetByLgContent(string lgContent, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Lg_id, Ur_id, Lg_userip, Lg_addtime, Lg_name, Lg_content, Lg_text1, Lg_text2 FROM log WHERE Lg_content=@LgContent";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@LgContent", lgContent, DbType.String, 6000)
							.ExecList<NxLogEO>(NxLogEO.GetItem, tm);
		}

		#endregion

		#region  按 LgText1（字段） 查询

		/// <summary>
		/// 按 LgText1（字段） 查询
		/// </summary>
		/// <param name = "lgText1"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<NxLogEO> GetByLgText1(string lgText1)
		{
			return GetByLgText1(lgText1, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 LgText1（字段） 查询
		/// </summary>
		/// <param name = "lgText1"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<NxLogEO> GetByLgText1(string lgText1, TransactionManager tm)
		{
			return GetByLgText1(lgText1, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 LgText1（字段） 查询
		/// </summary>
		/// <param name = "lgText1"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<NxLogEO> GetByLgText1(string lgText1, int top)
		{
			return GetByLgText1(lgText1, top, string.Empty, null);
		}

		/// <summary>
		/// 按 LgText1（字段） 查询
		/// </summary>
		/// <param name = "lgText1"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<NxLogEO> GetByLgText1(string lgText1, int top, TransactionManager tm)
		{
			return GetByLgText1(lgText1, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 LgText1（字段） 查询
		/// </summary>
		/// <param name = "lgText1"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<NxLogEO> GetByLgText1(string lgText1, string sort)
		{
			return GetByLgText1(lgText1, 0, sort, null);
		}

		/// <summary>
		/// 按 LgText1（字段） 查询
		/// </summary>
		/// <param name = "lgText1"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<NxLogEO> GetByLgText1(string lgText1, string sort, TransactionManager tm)
		{
			return GetByLgText1(lgText1, 0, sort, tm);
		}

		/// <summary>
		/// 按 LgText1（字段） 查询
		/// </summary>
		/// <param name = "lgText1"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<NxLogEO> GetByLgText1(string lgText1, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Lg_id, Ur_id, Lg_userip, Lg_addtime, Lg_name, Lg_content, Lg_text1, Lg_text2 FROM log WHERE Lg_text1=@LgText1";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@LgText1", lgText1, DbType.String, 600)
							.ExecList<NxLogEO>(NxLogEO.GetItem, tm);
		}

		#endregion

		#region  按 LgText2（字段） 查询

		/// <summary>
		/// 按 LgText2（字段） 查询
		/// </summary>
		/// <param name = "lgText2"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<NxLogEO> GetByLgText2(string lgText2)
		{
			return GetByLgText2(lgText2, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 LgText2（字段） 查询
		/// </summary>
		/// <param name = "lgText2"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<NxLogEO> GetByLgText2(string lgText2, TransactionManager tm)
		{
			return GetByLgText2(lgText2, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 LgText2（字段） 查询
		/// </summary>
		/// <param name = "lgText2"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<NxLogEO> GetByLgText2(string lgText2, int top)
		{
			return GetByLgText2(lgText2, top, string.Empty, null);
		}

		/// <summary>
		/// 按 LgText2（字段） 查询
		/// </summary>
		/// <param name = "lgText2"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<NxLogEO> GetByLgText2(string lgText2, int top, TransactionManager tm)
		{
			return GetByLgText2(lgText2, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 LgText2（字段） 查询
		/// </summary>
		/// <param name = "lgText2"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<NxLogEO> GetByLgText2(string lgText2, string sort)
		{
			return GetByLgText2(lgText2, 0, sort, null);
		}

		/// <summary>
		/// 按 LgText2（字段） 查询
		/// </summary>
		/// <param name = "lgText2"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<NxLogEO> GetByLgText2(string lgText2, string sort, TransactionManager tm)
		{
			return GetByLgText2(lgText2, 0, sort, tm);
		}

		/// <summary>
		/// 按 LgText2（字段） 查询
		/// </summary>
		/// <param name = "lgText2"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<NxLogEO> GetByLgText2(string lgText2, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Lg_id, Ur_id, Lg_userip, Lg_addtime, Lg_name, Lg_content, Lg_text1, Lg_text2 FROM log WHERE Lg_text2=@LgText2";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@LgText2", lgText2, DbType.String, 600)
							.ExecList<NxLogEO>(NxLogEO.GetItem, tm);
		}

		#endregion

		#region  自定义条件查询

		/// <summary>
		/// 获取所有数据
		/// </summary>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<NxLogEO> GetAll(TransactionManager tm = null)
		{
			return GetTopSort(string.Empty, null, -1, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "values">where子句中定义的参数值集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<NxLogEO> Get(string where, params object[] values)
		{
			return GetTopSort(where, -1, string.Empty, null, values);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "paras">where子句中定义的参数集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<NxLogEO> Get(string where, IEnumerable<DbParameter> paras)
		{
			return GetTopSort(where, paras, -1, string.Empty, null);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<NxLogEO> Get(string where, TransactionManager tm)
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
		public virtual IEnumerable<NxLogEO> Get(string where, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<NxLogEO> Get(string where, IEnumerable<DbParameter> paras, TransactionManager tm)
		{
			return GetTopSort(where, paras, -1, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<NxLogEO> GetTop(string where, int top)
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
		public virtual IEnumerable<NxLogEO> GetTop(string where, int top, params object[] values)
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
		public virtual IEnumerable<NxLogEO> GetTop(string where, IEnumerable<DbParameter> paras, int top)
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
		public virtual IEnumerable<NxLogEO> GetTop(string where, int top, TransactionManager tm)
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
		public virtual IEnumerable<NxLogEO> GetTop(string where, int top, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<NxLogEO> GetTop(string where, IEnumerable<DbParameter> paras, int top, TransactionManager tm)
		{
			return GetTopSort(where, paras, top, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<NxLogEO> GetSort(string where, string sort)
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
		public virtual IEnumerable<NxLogEO> GetSort(string where, string sort, params object[] values)
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
		public virtual IEnumerable<NxLogEO> GetSort(string where, IEnumerable<DbParameter> paras, string sort)
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
		public virtual IEnumerable<NxLogEO> GetSort(string where, string sort, TransactionManager tm)
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
		public virtual IEnumerable<NxLogEO> GetSort(string where, string sort, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<NxLogEO> GetSort(string where, IEnumerable<DbParameter> paras, string sort, TransactionManager tm)
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
		public virtual IEnumerable<NxLogEO> GetTopSort(string where, int top, string sort)
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
		public virtual IEnumerable<NxLogEO> GetTopSort(string where, int top, string sort, params object[] values)
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
		public virtual IEnumerable<NxLogEO> GetTopSort(string where, IEnumerable<DbParameter> paras, int top, string sort)
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
		public virtual IEnumerable<NxLogEO> GetTopSort(string where, int top, string sort, TransactionManager tm)
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
		public virtual IEnumerable<NxLogEO> GetTopSort(string where, int top, string sort, TransactionManager tm, params object[] values)
		{
			const string format = @"SELECT {0} Lg_id, Ur_id, Lg_userip, Lg_addtime, Lg_name, Lg_content, Lg_text1, Lg_text2 FROM log";
			string sql = format;

			if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameters(values)
							.ExecList<NxLogEO>(NxLogEO.GetItem, tm);
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
		public virtual IEnumerable<NxLogEO> GetTopSort(string where, IEnumerable<DbParameter> paras, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Lg_id, Ur_id, Lg_userip, Lg_addtime, Lg_name, Lg_content, Lg_text1, Lg_text2 FROM log";
			string sql = format;

			if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddParameters(paras)
							.ExecList<NxLogEO>(NxLogEO.GetItem, tm);
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
			const string format = @"SELECT Lg_id, Ur_id, Lg_userip, Lg_addtime, Lg_name, Lg_content, Lg_text1, Lg_text2 FROM log {0} {1}";
			 string sql = string.Format(format, string.IsNullOrEmpty(where) ? string.Empty : "WHERE " + where, string.IsNullOrEmpty(sort) ? string.Empty : "ORDER BY " + sort);

			return Database.CreatePager(sql, pageSize, "Lg_id");
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
		public virtual List<NxLogEO> GetPageList(int pageIndex , int pageSize, string where = null, string sort = null, IEnumerable<DbParameter> paras = null)
		{
			var pager = GetPager(pageSize, where, sort);

			pager.AddParameters(paras);
			return pager.GetPageList<NxLogEO>(pageIndex);
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
		public virtual IEnumerable<NxLogEO> GetPageMutil(int pageIndex , int pageSize, string where = null, string sort = null, IEnumerable<DbParameter> paras = null)
		{
			var pager = GetPager(pageSize, where, sort);

			pager.AddParameters(paras);
			return pager.GetPageMutil<NxLogEO>(pageIndex);
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
		public virtual int Add(NxLogEO item, TransactionManager tm = null)
		{
			const string sql = @"INSERT INTO log (Lg_id, Ur_id, Lg_userip, Lg_addtime, Lg_name, Lg_content, Lg_text1, Lg_text2) VALUES (@Lg_id, @Ur_id, @Lg_userip, @Lg_addtime, @Lg_name, @Lg_content, @Lg_text1, @Lg_text2) ";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Lg_id", item.LgId, DbType.String, 150)
							.AddInParameter("@Ur_id", item.UrId != null ?  (object)item.UrId : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Lg_userip", item.LgUserip != null ?  (object)item.LgUserip : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Lg_addtime", item.LgAddtime, DbType.DateTime, 0)
							.AddInParameter("@Lg_name", item.LgName != null ?  (object)item.LgName : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Lg_content", item.LgContent != null ?  (object)item.LgContent : DBNull.Value, DbType.String, 6000)
							.AddInParameter("@Lg_text1", item.LgText1 != null ?  (object)item.LgText1 : DBNull.Value, DbType.String, 600)
							.AddInParameter("@Lg_text2", item.LgText2 != null ?  (object)item.LgText2 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 插入一组数据
		/// </summary>
		/// <param name = "items">要插入的实体对象集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Add(IEnumerable<NxLogEO> items, TransactionManager tm = null)
		{
			int ret = 0;
			const string sql = @"INSERT INTO log (Lg_id, Ur_id, Lg_userip, Lg_addtime, Lg_name, Lg_content, Lg_text1, Lg_text2) VALUES (@Lg_id, @Ur_id, @Lg_userip, @Lg_addtime, @Lg_name, @Lg_content, @Lg_text1, @Lg_text2) ";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@Lg_id", DbType.String, 150)
									.AddParameter("@Ur_id", DbType.String, 150)
									.AddParameter("@Lg_userip", DbType.String, 150)
									.AddParameter("@Lg_addtime", DbType.DateTime, 0)
									.AddParameter("@Lg_name", DbType.String, 150)
									.AddParameter("@Lg_content", DbType.String, 6000)
									.AddParameter("@Lg_text1", DbType.String, 600)
									.AddParameter("@Lg_text2", DbType.String, 600);

			foreach (NxLogEO item in items)
			{
				sqlDao
					.SetParameterValue("@Lg_id", item.LgId)
					.SetParameterValue("@Ur_id", item.UrId != null ?  (object)item.UrId : DBNull.Value)
					.SetParameterValue("@Lg_userip", item.LgUserip != null ?  (object)item.LgUserip : DBNull.Value)
					.SetParameterValue("@Lg_addtime", item.LgAddtime)
					.SetParameterValue("@Lg_name", item.LgName != null ?  (object)item.LgName : DBNull.Value)
					.SetParameterValue("@Lg_content", item.LgContent != null ?  (object)item.LgContent : DBNull.Value)
					.SetParameterValue("@Lg_text1", item.LgText1 != null ?  (object)item.LgText1 : DBNull.Value)
					.SetParameterValue("@Lg_text2", item.LgText2 != null ?  (object)item.LgText2 : DBNull.Value)
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
		public virtual int Put(NxLogEO item, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log SET Lg_id=@Lg_id, Ur_id=@Ur_id, Lg_userip=@Lg_userip, Lg_addtime=@Lg_addtime, Lg_name=@Lg_name, Lg_content=@Lg_content, Lg_text1=@Lg_text1, Lg_text2=@Lg_text2 WHERE Lg_id=@OriginalLg_id";
			return Database.CreateSqlDao (sql)
							.AddInParameter("@OriginalLgId", (item.HasOriginal) ? item.OriginalLgId : item.LgId, DbType.String, 150)
							.AddInParameter("@Lg_id", item.LgId, DbType.String, 150)
							.AddInParameter("@Ur_id", item.UrId != null ?  (object)item.UrId : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Lg_userip", item.LgUserip != null ?  (object)item.LgUserip : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Lg_addtime", item.LgAddtime, DbType.DateTime, 0)
							.AddInParameter("@Lg_name", item.LgName != null ?  (object)item.LgName : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Lg_content", item.LgContent != null ?  (object)item.LgContent : DBNull.Value, DbType.String, 6000)
							.AddInParameter("@Lg_text1", item.LgText1 != null ?  (object)item.LgText1 : DBNull.Value, DbType.String, 600)
							.AddInParameter("@Lg_text2", item.LgText2 != null ?  (object)item.LgText2 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}


		/// <summary>
		/// 更新数据
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Put(IEnumerable<NxLogEO> items, TransactionManager tm = null)
		{

			int ret = 0;
			const string sql = @"UPDATE log SET Lg_id=@Lg_id, Ur_id=@Ur_id, Lg_userip=@Lg_userip, Lg_addtime=@Lg_addtime, Lg_name=@Lg_name, Lg_content=@Lg_content, Lg_text1=@Lg_text1, Lg_text2=@Lg_text2 WHERE Lg_id=@OriginalLg_id";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@OriginalLgId", DbType.String, 150)
									.AddParameter("@Lg_id", DbType.String, 150)
									.AddParameter("@Ur_id", DbType.String, 150)
									.AddParameter("@Lg_userip", DbType.String, 150)
									.AddParameter("@Lg_addtime", DbType.DateTime, 0)
									.AddParameter("@Lg_name", DbType.String, 150)
									.AddParameter("@Lg_content", DbType.String, 6000)
									.AddParameter("@Lg_text1", DbType.String, 600)
									.AddParameter("@Lg_text2", DbType.String, 600);

			foreach (NxLogEO item in items)
			{
				ret += sqlDao
							.SetParameterValue("@OriginalLgId", (item.HasOriginal) ? item.OriginalLgId : item.LgId)
							.SetParameterValue("@Lg_id", item.LgId)
							.SetParameterValue("@Ur_id", item.UrId != null ?  (object)item.UrId : DBNull.Value)
							.SetParameterValue("@Lg_userip", item.LgUserip != null ?  (object)item.LgUserip : DBNull.Value)
							.SetParameterValue("@Lg_addtime", item.LgAddtime)
							.SetParameterValue("@Lg_name", item.LgName != null ?  (object)item.LgName : DBNull.Value)
							.SetParameterValue("@Lg_content", item.LgContent != null ?  (object)item.LgContent : DBNull.Value)
							.SetParameterValue("@Lg_text1", item.LgText1 != null ?  (object)item.LgText1 : DBNull.Value)
							.SetParameterValue("@Lg_text2", item.LgText2 != null ?  (object)item.LgText2 : DBNull.Value)
							.ExecNonQuery(tm);
			}
			return ret;
		}


		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "lgId"></param>
		/// <param name = "urId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutUrIdByPK(string lgId, string urId, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log SET Ur_id = @Ur_id  WHERE Lg_id = @Lg_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Lg_id", lgId, DbType.String, 150)
							.AddInParameter("@Ur_id", urId != null ?  (object)urId : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "lgId"></param>
		/// <param name = "lgUserip"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutLgUseripByPK(string lgId, string lgUserip, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log SET Lg_userip = @Lg_userip  WHERE Lg_id = @Lg_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Lg_id", lgId, DbType.String, 150)
							.AddInParameter("@Lg_userip", lgUserip != null ?  (object)lgUserip : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "lgId"></param>
		/// <param name = "lgAddtime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutLgAddtimeByPK(string lgId, DateTime lgAddtime, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log SET Lg_addtime = @Lg_addtime  WHERE Lg_id = @Lg_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Lg_id", lgId, DbType.String, 150)
							.AddInParameter("@Lg_addtime", lgAddtime, DbType.DateTime, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "lgId"></param>
		/// <param name = "lgName"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutLgNameByPK(string lgId, string lgName, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log SET Lg_name = @Lg_name  WHERE Lg_id = @Lg_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Lg_id", lgId, DbType.String, 150)
							.AddInParameter("@Lg_name", lgName != null ?  (object)lgName : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "lgId"></param>
		/// <param name = "lgContent"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutLgContentByPK(string lgId, string lgContent, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log SET Lg_content = @Lg_content  WHERE Lg_id = @Lg_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Lg_id", lgId, DbType.String, 150)
							.AddInParameter("@Lg_content", lgContent != null ?  (object)lgContent : DBNull.Value, DbType.String, 6000)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "lgId"></param>
		/// <param name = "lgText1"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutLgText1ByPK(string lgId, string lgText1, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log SET Lg_text1 = @Lg_text1  WHERE Lg_id = @Lg_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Lg_id", lgId, DbType.String, 150)
							.AddInParameter("@Lg_text1", lgText1 != null ?  (object)lgText1 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "lgId"></param>
		/// <param name = "lgText2"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutLgText2ByPK(string lgId, string lgText2, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log SET Lg_text2 = @Lg_text2  WHERE Lg_id = @Lg_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Lg_id", lgId, DbType.String, 150)
							.AddInParameter("@Lg_text2", lgText2 != null ?  (object)lgText2 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}


		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "urId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutUrId(string urId, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log SET Ur_id=@Ur_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_id", urId != null ?  (object)urId : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "lgUserip"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutLgUserip(string lgUserip, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log SET Lg_userip=@Lg_userip";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Lg_userip", lgUserip != null ?  (object)lgUserip : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "lgAddtime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutLgAddtime(DateTime lgAddtime, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log SET Lg_addtime=@Lg_addtime";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Lg_addtime", lgAddtime, DbType.DateTime, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "lgName"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutLgName(string lgName, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log SET Lg_name=@Lg_name";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Lg_name", lgName != null ?  (object)lgName : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "lgContent"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutLgContent(string lgContent, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log SET Lg_content=@Lg_content";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Lg_content", lgContent != null ?  (object)lgContent : DBNull.Value, DbType.String, 6000)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "lgText1"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutLgText1(string lgText1, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log SET Lg_text1=@Lg_text1";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Lg_text1", lgText1 != null ?  (object)lgText1 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "lgText2"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutLgText2(string lgText2, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log SET Lg_text2=@Lg_text2";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Lg_text2", lgText2 != null ?  (object)lgText2 : DBNull.Value, DbType.String, 600)
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
			const string format = @"UPDATE log SET {0} {1}";
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
			const string format = @"UPDATE log SET {0} {1}";
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
		/// <param name = "lgId"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByPK(string lgId, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM log WHERE Lg_id=@Lg_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Lg_id", lgId, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Remove(NxLogEO item, TransactionManager tm = null)
		{
			return RemoveByPK(item.LgId, tm);
		}

		/// <summary>
		/// 删除指定实体集合对应的记录集
		/// </summary>
		/// <param name = "items">要删除的实体集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Remove(IEnumerable<NxLogEO> items, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM log WHERE Lg_id=@OriginalLg_id";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@OriginalLgId", DbType.String, 150);
			int ret = 0;
			foreach (NxLogEO item in items)
			{
				ret += sqlDao
							.SetParameterValue("@OriginalLgId", (item.HasOriginal) ? item.OriginalLgId : item.LgId)
							.ExecNonQuery(tm);
			}
			return ret;
		}




		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "urId"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByUrId(string urId, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM log WHERE Ur_id=@Ur_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_id", urId != null ?  (object)urId : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "lgUserip"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByLgUserip(string lgUserip, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM log WHERE Lg_userip=@Lg_userip";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Lg_userip", lgUserip != null ?  (object)lgUserip : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "lgAddtime"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByLgAddtime(DateTime lgAddtime, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM log WHERE Lg_addtime=@Lg_addtime";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Lg_addtime", lgAddtime, DbType.DateTime, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "lgName"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByLgName(string lgName, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM log WHERE Lg_name=@Lg_name";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Lg_name", lgName != null ?  (object)lgName : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "lgContent"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByLgContent(string lgContent, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM log WHERE Lg_content=@Lg_content";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Lg_content", lgContent != null ?  (object)lgContent : DBNull.Value, DbType.String, 6000)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "lgText1"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByLgText1(string lgText1, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM log WHERE Lg_text1=@Lg_text1";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Lg_text1", lgText1 != null ?  (object)lgText1 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "lgText2"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByLgText2(string lgText2, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM log WHERE Lg_text2=@Lg_text2";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Lg_text2", lgText2 != null ?  (object)lgText2 : DBNull.Value, DbType.String, 600)
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
			const string format = @"DELETE FROM log {0}";
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
			const string format = @"DELETE FROM log {0}";
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
