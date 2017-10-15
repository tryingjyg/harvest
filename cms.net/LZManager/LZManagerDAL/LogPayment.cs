//==========================================================
// 此代码由代码生成器工具自动生成，请不要修改
// 代码生成器核心库版本号：2.0
// 创建时间：2017/10/8 18:08:27
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
	/// 【表 log_payment 的实体类】
	/// </summary>
	[SerializableAttribute]
	public class LogPaymentEO : DataEntityBase, IRowMapper<LogPaymentEO>
	{
		protected string _originalRemarkid;

		/// <summary>
		/// 主键是否有原始值（即数据库中保存的值），用于实体对象更新时
		/// </summary>
		public bool HasOriginal { get; protected set; }

		/// <summary>
		/// 【主键 varchar】
		/// </summary>
		public virtual string Remarkid { get; set; }

		/// <summary>
		/// 【数据库中的原始主键值副本】
		/// </summary>
		public virtual string OriginalRemarkid
		{
			get { return _originalRemarkid; }
			set { HasOriginal = true; _originalRemarkid = value; }
		}

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string Areaid { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string Worldid { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string Dstuin { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string Roleid { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string Rolename { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string Srcuin { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string Source { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string Amount { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string Uiip { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string Paystatus { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string Paymsg { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string CreateTime { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string FinishTime { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string Description { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string Duid { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string Extend1 { get; set; }

		/// <summary>
		/// 默认构造函数
		/// </summary>
		public LogPaymentEO() 
		{
			Remarkid = string.Empty;
		}

		/// <summary>
		/// 自定义构造函数
		/// </summary>
		/// <param name = "remarkid"></param>
		/// <param name = "areaid"></param>
		/// <param name = "worldid"></param>
		/// <param name = "dstuin"></param>
		/// <param name = "roleid"></param>
		/// <param name = "rolename"></param>
		/// <param name = "srcuin"></param>
		/// <param name = "source"></param>
		/// <param name = "amount"></param>
		/// <param name = "uiip"></param>
		/// <param name = "paystatus"></param>
		/// <param name = "paymsg"></param>
		/// <param name = "createTime"></param>
		/// <param name = "finishTime"></param>
		/// <param name = "description"></param>
		/// <param name = "duid"></param>
		/// <param name = "extend1"></param>
		public LogPaymentEO(string remarkid, string areaid, string worldid, string dstuin, string roleid, string rolename, string srcuin, string source, string amount, string uiip, string paystatus, string paymsg, string createTime, string finishTime, string description, string duid, string extend1) 
		{
			Remarkid = remarkid;
			Areaid = areaid;
			Worldid = worldid;
			Dstuin = dstuin;
			Roleid = roleid;
			Rolename = rolename;
			Srcuin = srcuin;
			Source = source;
			Amount = amount;
			Uiip = uiip;
			Paystatus = paystatus;
			Paymsg = paymsg;
			CreateTime = createTime;
			FinishTime = finishTime;
			Description = description;
			Duid = duid;
			Extend1 = extend1;
		}

		/// <summary>
		/// 将结果集映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public LogPaymentEO MapRow(IDataReader reader)
		{
			return GetItem(reader);
		}

		/// <summary>
		/// 将结果集映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static LogPaymentEO GetItem(IDataReader reader)
		{
			LogPaymentEO ret = new LogPaymentEO();

			ret.Remarkid = (string)reader["remarkid"];
			ret.OriginalRemarkid = ret.Remarkid;
			ret.Areaid = (reader["areaid"] is DBNull) ? null : (string)reader["areaid"];
			ret.Worldid = (reader["worldid"] is DBNull) ? null : (string)reader["worldid"];
			ret.Dstuin = (reader["dstuin"] is DBNull) ? null : (string)reader["dstuin"];
			ret.Roleid = (reader["roleid"] is DBNull) ? null : (string)reader["roleid"];
			ret.Rolename = (reader["rolename"] is DBNull) ? null : (string)reader["rolename"];
			ret.Srcuin = (reader["srcuin"] is DBNull) ? null : (string)reader["srcuin"];
			ret.Source = (reader["source"] is DBNull) ? null : (string)reader["source"];
			ret.Amount = (reader["amount"] is DBNull) ? null : (string)reader["amount"];
			ret.Uiip = (reader["uiip"] is DBNull) ? null : (string)reader["uiip"];
			ret.Paystatus = (reader["paystatus"] is DBNull) ? null : (string)reader["paystatus"];
			ret.Paymsg = (reader["paymsg"] is DBNull) ? null : (string)reader["paymsg"];
			ret.CreateTime = (reader["createTime"] is DBNull) ? null : (string)reader["createTime"];
			ret.FinishTime = (reader["finishTime"] is DBNull) ? null : (string)reader["finishTime"];
			ret.Description = (reader["description"] is DBNull) ? null : (string)reader["description"];
			ret.Duid = (reader["duid"] is DBNull) ? null : (string)reader["duid"];
			ret.Extend1 = (reader["extend1"] is DBNull) ? null : (string)reader["extend1"];
			return ret;
		}
	}


	#endregion

	#region  MO

	/// <summary>
	/// 【表 log_payment 的操作类】
	/// </summary>
	public class LogPaymentMO : DataManagerBase
	{

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "routeData">路由数据</param>
		public LogPaymentMO(object routeData = null) : base(routeData) { }

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">连接字符串名称</param>
		public LogPaymentMO(string connectionStringName) : base(connectionStringName) { }

		#region  Get方法集合

		/// <summary>
		/// 按 PK（主键） 查询
		/// </summary>
		/// <param name="tm">事务管理对象</param>
		/// <param name = "remarkid"></param>
		/// <return></return>
		public virtual LogPaymentEO GetByPK(string remarkid, TransactionManager tm = null)
		{
			const string sql = @"SELECT remarkid, areaid, worldid, dstuin, roleid, rolename, srcuin, source, amount, uiip, paystatus, paymsg, createTime, finishTime, description, duid, extend1 FROM log_payment WHERE remarkid=@remarkid";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@remarkid", remarkid, DbType.String, 150)
							.ExecSingle<LogPaymentEO>(LogPaymentEO.GetItem, tm);
		}




		#region  按 Areaid（字段） 查询

		/// <summary>
		/// 按 Areaid（字段） 查询
		/// </summary>
		/// <param name = "areaid"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByAreaid(string areaid)
		{
			return GetByAreaid(areaid, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 Areaid（字段） 查询
		/// </summary>
		/// <param name = "areaid"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByAreaid(string areaid, TransactionManager tm)
		{
			return GetByAreaid(areaid, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 Areaid（字段） 查询
		/// </summary>
		/// <param name = "areaid"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByAreaid(string areaid, int top)
		{
			return GetByAreaid(areaid, top, string.Empty, null);
		}

		/// <summary>
		/// 按 Areaid（字段） 查询
		/// </summary>
		/// <param name = "areaid"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByAreaid(string areaid, int top, TransactionManager tm)
		{
			return GetByAreaid(areaid, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 Areaid（字段） 查询
		/// </summary>
		/// <param name = "areaid"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByAreaid(string areaid, string sort)
		{
			return GetByAreaid(areaid, 0, sort, null);
		}

		/// <summary>
		/// 按 Areaid（字段） 查询
		/// </summary>
		/// <param name = "areaid"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByAreaid(string areaid, string sort, TransactionManager tm)
		{
			return GetByAreaid(areaid, 0, sort, tm);
		}

		/// <summary>
		/// 按 Areaid（字段） 查询
		/// </summary>
		/// <param name = "areaid"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByAreaid(string areaid, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} remarkid, areaid, worldid, dstuin, roleid, rolename, srcuin, source, amount, uiip, paystatus, paymsg, createTime, finishTime, description, duid, extend1 FROM log_payment WHERE areaid=@Areaid";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Areaid", areaid, DbType.String, 150)
							.ExecList<LogPaymentEO>(LogPaymentEO.GetItem, tm);
		}

		#endregion

		#region  按 Worldid（字段） 查询

		/// <summary>
		/// 按 Worldid（字段） 查询
		/// </summary>
		/// <param name = "worldid"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByWorldid(string worldid)
		{
			return GetByWorldid(worldid, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 Worldid（字段） 查询
		/// </summary>
		/// <param name = "worldid"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByWorldid(string worldid, TransactionManager tm)
		{
			return GetByWorldid(worldid, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 Worldid（字段） 查询
		/// </summary>
		/// <param name = "worldid"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByWorldid(string worldid, int top)
		{
			return GetByWorldid(worldid, top, string.Empty, null);
		}

		/// <summary>
		/// 按 Worldid（字段） 查询
		/// </summary>
		/// <param name = "worldid"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByWorldid(string worldid, int top, TransactionManager tm)
		{
			return GetByWorldid(worldid, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 Worldid（字段） 查询
		/// </summary>
		/// <param name = "worldid"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByWorldid(string worldid, string sort)
		{
			return GetByWorldid(worldid, 0, sort, null);
		}

		/// <summary>
		/// 按 Worldid（字段） 查询
		/// </summary>
		/// <param name = "worldid"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByWorldid(string worldid, string sort, TransactionManager tm)
		{
			return GetByWorldid(worldid, 0, sort, tm);
		}

		/// <summary>
		/// 按 Worldid（字段） 查询
		/// </summary>
		/// <param name = "worldid"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByWorldid(string worldid, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} remarkid, areaid, worldid, dstuin, roleid, rolename, srcuin, source, amount, uiip, paystatus, paymsg, createTime, finishTime, description, duid, extend1 FROM log_payment WHERE worldid=@Worldid";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Worldid", worldid, DbType.String, 150)
							.ExecList<LogPaymentEO>(LogPaymentEO.GetItem, tm);
		}

		#endregion

		#region  按 Dstuin（字段） 查询

		/// <summary>
		/// 按 Dstuin（字段） 查询
		/// </summary>
		/// <param name = "dstuin"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByDstuin(string dstuin)
		{
			return GetByDstuin(dstuin, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 Dstuin（字段） 查询
		/// </summary>
		/// <param name = "dstuin"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByDstuin(string dstuin, TransactionManager tm)
		{
			return GetByDstuin(dstuin, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 Dstuin（字段） 查询
		/// </summary>
		/// <param name = "dstuin"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByDstuin(string dstuin, int top)
		{
			return GetByDstuin(dstuin, top, string.Empty, null);
		}

		/// <summary>
		/// 按 Dstuin（字段） 查询
		/// </summary>
		/// <param name = "dstuin"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByDstuin(string dstuin, int top, TransactionManager tm)
		{
			return GetByDstuin(dstuin, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 Dstuin（字段） 查询
		/// </summary>
		/// <param name = "dstuin"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByDstuin(string dstuin, string sort)
		{
			return GetByDstuin(dstuin, 0, sort, null);
		}

		/// <summary>
		/// 按 Dstuin（字段） 查询
		/// </summary>
		/// <param name = "dstuin"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByDstuin(string dstuin, string sort, TransactionManager tm)
		{
			return GetByDstuin(dstuin, 0, sort, tm);
		}

		/// <summary>
		/// 按 Dstuin（字段） 查询
		/// </summary>
		/// <param name = "dstuin"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByDstuin(string dstuin, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} remarkid, areaid, worldid, dstuin, roleid, rolename, srcuin, source, amount, uiip, paystatus, paymsg, createTime, finishTime, description, duid, extend1 FROM log_payment WHERE dstuin=@Dstuin";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Dstuin", dstuin, DbType.String, 150)
							.ExecList<LogPaymentEO>(LogPaymentEO.GetItem, tm);
		}

		#endregion

		#region  按 Roleid（字段） 查询

		/// <summary>
		/// 按 Roleid（字段） 查询
		/// </summary>
		/// <param name = "roleid"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByRoleid(string roleid)
		{
			return GetByRoleid(roleid, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 Roleid（字段） 查询
		/// </summary>
		/// <param name = "roleid"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByRoleid(string roleid, TransactionManager tm)
		{
			return GetByRoleid(roleid, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 Roleid（字段） 查询
		/// </summary>
		/// <param name = "roleid"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByRoleid(string roleid, int top)
		{
			return GetByRoleid(roleid, top, string.Empty, null);
		}

		/// <summary>
		/// 按 Roleid（字段） 查询
		/// </summary>
		/// <param name = "roleid"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByRoleid(string roleid, int top, TransactionManager tm)
		{
			return GetByRoleid(roleid, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 Roleid（字段） 查询
		/// </summary>
		/// <param name = "roleid"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByRoleid(string roleid, string sort)
		{
			return GetByRoleid(roleid, 0, sort, null);
		}

		/// <summary>
		/// 按 Roleid（字段） 查询
		/// </summary>
		/// <param name = "roleid"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByRoleid(string roleid, string sort, TransactionManager tm)
		{
			return GetByRoleid(roleid, 0, sort, tm);
		}

		/// <summary>
		/// 按 Roleid（字段） 查询
		/// </summary>
		/// <param name = "roleid"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByRoleid(string roleid, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} remarkid, areaid, worldid, dstuin, roleid, rolename, srcuin, source, amount, uiip, paystatus, paymsg, createTime, finishTime, description, duid, extend1 FROM log_payment WHERE roleid=@Roleid";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Roleid", roleid, DbType.String, 150)
							.ExecList<LogPaymentEO>(LogPaymentEO.GetItem, tm);
		}

		#endregion

		#region  按 Rolename（字段） 查询

		/// <summary>
		/// 按 Rolename（字段） 查询
		/// </summary>
		/// <param name = "rolename"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByRolename(string rolename)
		{
			return GetByRolename(rolename, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 Rolename（字段） 查询
		/// </summary>
		/// <param name = "rolename"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByRolename(string rolename, TransactionManager tm)
		{
			return GetByRolename(rolename, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 Rolename（字段） 查询
		/// </summary>
		/// <param name = "rolename"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByRolename(string rolename, int top)
		{
			return GetByRolename(rolename, top, string.Empty, null);
		}

		/// <summary>
		/// 按 Rolename（字段） 查询
		/// </summary>
		/// <param name = "rolename"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByRolename(string rolename, int top, TransactionManager tm)
		{
			return GetByRolename(rolename, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 Rolename（字段） 查询
		/// </summary>
		/// <param name = "rolename"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByRolename(string rolename, string sort)
		{
			return GetByRolename(rolename, 0, sort, null);
		}

		/// <summary>
		/// 按 Rolename（字段） 查询
		/// </summary>
		/// <param name = "rolename"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByRolename(string rolename, string sort, TransactionManager tm)
		{
			return GetByRolename(rolename, 0, sort, tm);
		}

		/// <summary>
		/// 按 Rolename（字段） 查询
		/// </summary>
		/// <param name = "rolename"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByRolename(string rolename, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} remarkid, areaid, worldid, dstuin, roleid, rolename, srcuin, source, amount, uiip, paystatus, paymsg, createTime, finishTime, description, duid, extend1 FROM log_payment WHERE rolename=@Rolename";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Rolename", rolename, DbType.String, 192)
							.ExecList<LogPaymentEO>(LogPaymentEO.GetItem, tm);
		}

		#endregion

		#region  按 Srcuin（字段） 查询

		/// <summary>
		/// 按 Srcuin（字段） 查询
		/// </summary>
		/// <param name = "srcuin"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetBySrcuin(string srcuin)
		{
			return GetBySrcuin(srcuin, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 Srcuin（字段） 查询
		/// </summary>
		/// <param name = "srcuin"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetBySrcuin(string srcuin, TransactionManager tm)
		{
			return GetBySrcuin(srcuin, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 Srcuin（字段） 查询
		/// </summary>
		/// <param name = "srcuin"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetBySrcuin(string srcuin, int top)
		{
			return GetBySrcuin(srcuin, top, string.Empty, null);
		}

		/// <summary>
		/// 按 Srcuin（字段） 查询
		/// </summary>
		/// <param name = "srcuin"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetBySrcuin(string srcuin, int top, TransactionManager tm)
		{
			return GetBySrcuin(srcuin, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 Srcuin（字段） 查询
		/// </summary>
		/// <param name = "srcuin"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetBySrcuin(string srcuin, string sort)
		{
			return GetBySrcuin(srcuin, 0, sort, null);
		}

		/// <summary>
		/// 按 Srcuin（字段） 查询
		/// </summary>
		/// <param name = "srcuin"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetBySrcuin(string srcuin, string sort, TransactionManager tm)
		{
			return GetBySrcuin(srcuin, 0, sort, tm);
		}

		/// <summary>
		/// 按 Srcuin（字段） 查询
		/// </summary>
		/// <param name = "srcuin"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetBySrcuin(string srcuin, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} remarkid, areaid, worldid, dstuin, roleid, rolename, srcuin, source, amount, uiip, paystatus, paymsg, createTime, finishTime, description, duid, extend1 FROM log_payment WHERE srcuin=@Srcuin";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Srcuin", srcuin, DbType.String, 150)
							.ExecList<LogPaymentEO>(LogPaymentEO.GetItem, tm);
		}

		#endregion

		#region  按 Source（字段） 查询

		/// <summary>
		/// 按 Source（字段） 查询
		/// </summary>
		/// <param name = "source"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetBySource(string source)
		{
			return GetBySource(source, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 Source（字段） 查询
		/// </summary>
		/// <param name = "source"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetBySource(string source, TransactionManager tm)
		{
			return GetBySource(source, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 Source（字段） 查询
		/// </summary>
		/// <param name = "source"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetBySource(string source, int top)
		{
			return GetBySource(source, top, string.Empty, null);
		}

		/// <summary>
		/// 按 Source（字段） 查询
		/// </summary>
		/// <param name = "source"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetBySource(string source, int top, TransactionManager tm)
		{
			return GetBySource(source, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 Source（字段） 查询
		/// </summary>
		/// <param name = "source"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetBySource(string source, string sort)
		{
			return GetBySource(source, 0, sort, null);
		}

		/// <summary>
		/// 按 Source（字段） 查询
		/// </summary>
		/// <param name = "source"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetBySource(string source, string sort, TransactionManager tm)
		{
			return GetBySource(source, 0, sort, tm);
		}

		/// <summary>
		/// 按 Source（字段） 查询
		/// </summary>
		/// <param name = "source"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetBySource(string source, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} remarkid, areaid, worldid, dstuin, roleid, rolename, srcuin, source, amount, uiip, paystatus, paymsg, createTime, finishTime, description, duid, extend1 FROM log_payment WHERE source=@Source";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Source", source, DbType.String, 150)
							.ExecList<LogPaymentEO>(LogPaymentEO.GetItem, tm);
		}

		#endregion

		#region  按 Amount（字段） 查询

		/// <summary>
		/// 按 Amount（字段） 查询
		/// </summary>
		/// <param name = "amount"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByAmount(string amount)
		{
			return GetByAmount(amount, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 Amount（字段） 查询
		/// </summary>
		/// <param name = "amount"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByAmount(string amount, TransactionManager tm)
		{
			return GetByAmount(amount, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 Amount（字段） 查询
		/// </summary>
		/// <param name = "amount"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByAmount(string amount, int top)
		{
			return GetByAmount(amount, top, string.Empty, null);
		}

		/// <summary>
		/// 按 Amount（字段） 查询
		/// </summary>
		/// <param name = "amount"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByAmount(string amount, int top, TransactionManager tm)
		{
			return GetByAmount(amount, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 Amount（字段） 查询
		/// </summary>
		/// <param name = "amount"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByAmount(string amount, string sort)
		{
			return GetByAmount(amount, 0, sort, null);
		}

		/// <summary>
		/// 按 Amount（字段） 查询
		/// </summary>
		/// <param name = "amount"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByAmount(string amount, string sort, TransactionManager tm)
		{
			return GetByAmount(amount, 0, sort, tm);
		}

		/// <summary>
		/// 按 Amount（字段） 查询
		/// </summary>
		/// <param name = "amount"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByAmount(string amount, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} remarkid, areaid, worldid, dstuin, roleid, rolename, srcuin, source, amount, uiip, paystatus, paymsg, createTime, finishTime, description, duid, extend1 FROM log_payment WHERE amount=@Amount";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Amount", amount, DbType.String, 150)
							.ExecList<LogPaymentEO>(LogPaymentEO.GetItem, tm);
		}

		#endregion

		#region  按 Uiip（字段） 查询

		/// <summary>
		/// 按 Uiip（字段） 查询
		/// </summary>
		/// <param name = "uiip"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByUiip(string uiip)
		{
			return GetByUiip(uiip, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 Uiip（字段） 查询
		/// </summary>
		/// <param name = "uiip"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByUiip(string uiip, TransactionManager tm)
		{
			return GetByUiip(uiip, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 Uiip（字段） 查询
		/// </summary>
		/// <param name = "uiip"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByUiip(string uiip, int top)
		{
			return GetByUiip(uiip, top, string.Empty, null);
		}

		/// <summary>
		/// 按 Uiip（字段） 查询
		/// </summary>
		/// <param name = "uiip"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByUiip(string uiip, int top, TransactionManager tm)
		{
			return GetByUiip(uiip, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 Uiip（字段） 查询
		/// </summary>
		/// <param name = "uiip"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByUiip(string uiip, string sort)
		{
			return GetByUiip(uiip, 0, sort, null);
		}

		/// <summary>
		/// 按 Uiip（字段） 查询
		/// </summary>
		/// <param name = "uiip"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByUiip(string uiip, string sort, TransactionManager tm)
		{
			return GetByUiip(uiip, 0, sort, tm);
		}

		/// <summary>
		/// 按 Uiip（字段） 查询
		/// </summary>
		/// <param name = "uiip"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByUiip(string uiip, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} remarkid, areaid, worldid, dstuin, roleid, rolename, srcuin, source, amount, uiip, paystatus, paymsg, createTime, finishTime, description, duid, extend1 FROM log_payment WHERE uiip=@Uiip";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Uiip", uiip, DbType.String, 150)
							.ExecList<LogPaymentEO>(LogPaymentEO.GetItem, tm);
		}

		#endregion

		#region  按 Paystatus（字段） 查询

		/// <summary>
		/// 按 Paystatus（字段） 查询
		/// </summary>
		/// <param name = "paystatus"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByPaystatus(string paystatus)
		{
			return GetByPaystatus(paystatus, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 Paystatus（字段） 查询
		/// </summary>
		/// <param name = "paystatus"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByPaystatus(string paystatus, TransactionManager tm)
		{
			return GetByPaystatus(paystatus, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 Paystatus（字段） 查询
		/// </summary>
		/// <param name = "paystatus"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByPaystatus(string paystatus, int top)
		{
			return GetByPaystatus(paystatus, top, string.Empty, null);
		}

		/// <summary>
		/// 按 Paystatus（字段） 查询
		/// </summary>
		/// <param name = "paystatus"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByPaystatus(string paystatus, int top, TransactionManager tm)
		{
			return GetByPaystatus(paystatus, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 Paystatus（字段） 查询
		/// </summary>
		/// <param name = "paystatus"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByPaystatus(string paystatus, string sort)
		{
			return GetByPaystatus(paystatus, 0, sort, null);
		}

		/// <summary>
		/// 按 Paystatus（字段） 查询
		/// </summary>
		/// <param name = "paystatus"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByPaystatus(string paystatus, string sort, TransactionManager tm)
		{
			return GetByPaystatus(paystatus, 0, sort, tm);
		}

		/// <summary>
		/// 按 Paystatus（字段） 查询
		/// </summary>
		/// <param name = "paystatus"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByPaystatus(string paystatus, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} remarkid, areaid, worldid, dstuin, roleid, rolename, srcuin, source, amount, uiip, paystatus, paymsg, createTime, finishTime, description, duid, extend1 FROM log_payment WHERE paystatus=@Paystatus";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Paystatus", paystatus, DbType.String, 150)
							.ExecList<LogPaymentEO>(LogPaymentEO.GetItem, tm);
		}

		#endregion

		#region  按 Paymsg（字段） 查询

		/// <summary>
		/// 按 Paymsg（字段） 查询
		/// </summary>
		/// <param name = "paymsg"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByPaymsg(string paymsg)
		{
			return GetByPaymsg(paymsg, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 Paymsg（字段） 查询
		/// </summary>
		/// <param name = "paymsg"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByPaymsg(string paymsg, TransactionManager tm)
		{
			return GetByPaymsg(paymsg, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 Paymsg（字段） 查询
		/// </summary>
		/// <param name = "paymsg"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByPaymsg(string paymsg, int top)
		{
			return GetByPaymsg(paymsg, top, string.Empty, null);
		}

		/// <summary>
		/// 按 Paymsg（字段） 查询
		/// </summary>
		/// <param name = "paymsg"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByPaymsg(string paymsg, int top, TransactionManager tm)
		{
			return GetByPaymsg(paymsg, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 Paymsg（字段） 查询
		/// </summary>
		/// <param name = "paymsg"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByPaymsg(string paymsg, string sort)
		{
			return GetByPaymsg(paymsg, 0, sort, null);
		}

		/// <summary>
		/// 按 Paymsg（字段） 查询
		/// </summary>
		/// <param name = "paymsg"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByPaymsg(string paymsg, string sort, TransactionManager tm)
		{
			return GetByPaymsg(paymsg, 0, sort, tm);
		}

		/// <summary>
		/// 按 Paymsg（字段） 查询
		/// </summary>
		/// <param name = "paymsg"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByPaymsg(string paymsg, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} remarkid, areaid, worldid, dstuin, roleid, rolename, srcuin, source, amount, uiip, paystatus, paymsg, createTime, finishTime, description, duid, extend1 FROM log_payment WHERE paymsg=@Paymsg";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Paymsg", paymsg, DbType.String, 300)
							.ExecList<LogPaymentEO>(LogPaymentEO.GetItem, tm);
		}

		#endregion

		#region  按 CreateTime（字段） 查询

		/// <summary>
		/// 按 CreateTime（字段） 查询
		/// </summary>
		/// <param name = "createTime"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByCreateTime(string createTime)
		{
			return GetByCreateTime(createTime, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 CreateTime（字段） 查询
		/// </summary>
		/// <param name = "createTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByCreateTime(string createTime, TransactionManager tm)
		{
			return GetByCreateTime(createTime, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 CreateTime（字段） 查询
		/// </summary>
		/// <param name = "createTime"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByCreateTime(string createTime, int top)
		{
			return GetByCreateTime(createTime, top, string.Empty, null);
		}

		/// <summary>
		/// 按 CreateTime（字段） 查询
		/// </summary>
		/// <param name = "createTime"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByCreateTime(string createTime, int top, TransactionManager tm)
		{
			return GetByCreateTime(createTime, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 CreateTime（字段） 查询
		/// </summary>
		/// <param name = "createTime"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByCreateTime(string createTime, string sort)
		{
			return GetByCreateTime(createTime, 0, sort, null);
		}

		/// <summary>
		/// 按 CreateTime（字段） 查询
		/// </summary>
		/// <param name = "createTime"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByCreateTime(string createTime, string sort, TransactionManager tm)
		{
			return GetByCreateTime(createTime, 0, sort, tm);
		}

		/// <summary>
		/// 按 CreateTime（字段） 查询
		/// </summary>
		/// <param name = "createTime"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByCreateTime(string createTime, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} remarkid, areaid, worldid, dstuin, roleid, rolename, srcuin, source, amount, uiip, paystatus, paymsg, createTime, finishTime, description, duid, extend1 FROM log_payment WHERE createTime=@CreateTime";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@CreateTime", createTime, DbType.String, 150)
							.ExecList<LogPaymentEO>(LogPaymentEO.GetItem, tm);
		}

		#endregion

		#region  按 FinishTime（字段） 查询

		/// <summary>
		/// 按 FinishTime（字段） 查询
		/// </summary>
		/// <param name = "finishTime"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByFinishTime(string finishTime)
		{
			return GetByFinishTime(finishTime, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 FinishTime（字段） 查询
		/// </summary>
		/// <param name = "finishTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByFinishTime(string finishTime, TransactionManager tm)
		{
			return GetByFinishTime(finishTime, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 FinishTime（字段） 查询
		/// </summary>
		/// <param name = "finishTime"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByFinishTime(string finishTime, int top)
		{
			return GetByFinishTime(finishTime, top, string.Empty, null);
		}

		/// <summary>
		/// 按 FinishTime（字段） 查询
		/// </summary>
		/// <param name = "finishTime"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByFinishTime(string finishTime, int top, TransactionManager tm)
		{
			return GetByFinishTime(finishTime, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 FinishTime（字段） 查询
		/// </summary>
		/// <param name = "finishTime"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByFinishTime(string finishTime, string sort)
		{
			return GetByFinishTime(finishTime, 0, sort, null);
		}

		/// <summary>
		/// 按 FinishTime（字段） 查询
		/// </summary>
		/// <param name = "finishTime"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByFinishTime(string finishTime, string sort, TransactionManager tm)
		{
			return GetByFinishTime(finishTime, 0, sort, tm);
		}

		/// <summary>
		/// 按 FinishTime（字段） 查询
		/// </summary>
		/// <param name = "finishTime"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByFinishTime(string finishTime, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} remarkid, areaid, worldid, dstuin, roleid, rolename, srcuin, source, amount, uiip, paystatus, paymsg, createTime, finishTime, description, duid, extend1 FROM log_payment WHERE finishTime=@FinishTime";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@FinishTime", finishTime, DbType.String, 150)
							.ExecList<LogPaymentEO>(LogPaymentEO.GetItem, tm);
		}

		#endregion

		#region  按 Description（字段） 查询

		/// <summary>
		/// 按 Description（字段） 查询
		/// </summary>
		/// <param name = "description"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByDescription(string description)
		{
			return GetByDescription(description, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 Description（字段） 查询
		/// </summary>
		/// <param name = "description"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByDescription(string description, TransactionManager tm)
		{
			return GetByDescription(description, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 Description（字段） 查询
		/// </summary>
		/// <param name = "description"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByDescription(string description, int top)
		{
			return GetByDescription(description, top, string.Empty, null);
		}

		/// <summary>
		/// 按 Description（字段） 查询
		/// </summary>
		/// <param name = "description"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByDescription(string description, int top, TransactionManager tm)
		{
			return GetByDescription(description, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 Description（字段） 查询
		/// </summary>
		/// <param name = "description"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByDescription(string description, string sort)
		{
			return GetByDescription(description, 0, sort, null);
		}

		/// <summary>
		/// 按 Description（字段） 查询
		/// </summary>
		/// <param name = "description"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByDescription(string description, string sort, TransactionManager tm)
		{
			return GetByDescription(description, 0, sort, tm);
		}

		/// <summary>
		/// 按 Description（字段） 查询
		/// </summary>
		/// <param name = "description"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByDescription(string description, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} remarkid, areaid, worldid, dstuin, roleid, rolename, srcuin, source, amount, uiip, paystatus, paymsg, createTime, finishTime, description, duid, extend1 FROM log_payment WHERE description=@Description";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Description", description, DbType.String, 150)
							.ExecList<LogPaymentEO>(LogPaymentEO.GetItem, tm);
		}

		#endregion

		#region  按 Duid（字段） 查询

		/// <summary>
		/// 按 Duid（字段） 查询
		/// </summary>
		/// <param name = "duid"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByDuid(string duid)
		{
			return GetByDuid(duid, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 Duid（字段） 查询
		/// </summary>
		/// <param name = "duid"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByDuid(string duid, TransactionManager tm)
		{
			return GetByDuid(duid, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 Duid（字段） 查询
		/// </summary>
		/// <param name = "duid"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByDuid(string duid, int top)
		{
			return GetByDuid(duid, top, string.Empty, null);
		}

		/// <summary>
		/// 按 Duid（字段） 查询
		/// </summary>
		/// <param name = "duid"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByDuid(string duid, int top, TransactionManager tm)
		{
			return GetByDuid(duid, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 Duid（字段） 查询
		/// </summary>
		/// <param name = "duid"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByDuid(string duid, string sort)
		{
			return GetByDuid(duid, 0, sort, null);
		}

		/// <summary>
		/// 按 Duid（字段） 查询
		/// </summary>
		/// <param name = "duid"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByDuid(string duid, string sort, TransactionManager tm)
		{
			return GetByDuid(duid, 0, sort, tm);
		}

		/// <summary>
		/// 按 Duid（字段） 查询
		/// </summary>
		/// <param name = "duid"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByDuid(string duid, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} remarkid, areaid, worldid, dstuin, roleid, rolename, srcuin, source, amount, uiip, paystatus, paymsg, createTime, finishTime, description, duid, extend1 FROM log_payment WHERE duid=@Duid";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Duid", duid, DbType.String, 150)
							.ExecList<LogPaymentEO>(LogPaymentEO.GetItem, tm);
		}

		#endregion

		#region  按 Extend1（字段） 查询

		/// <summary>
		/// 按 Extend1（字段） 查询
		/// </summary>
		/// <param name = "extend1"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByExtend1(string extend1)
		{
			return GetByExtend1(extend1, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 Extend1（字段） 查询
		/// </summary>
		/// <param name = "extend1"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByExtend1(string extend1, TransactionManager tm)
		{
			return GetByExtend1(extend1, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 Extend1（字段） 查询
		/// </summary>
		/// <param name = "extend1"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByExtend1(string extend1, int top)
		{
			return GetByExtend1(extend1, top, string.Empty, null);
		}

		/// <summary>
		/// 按 Extend1（字段） 查询
		/// </summary>
		/// <param name = "extend1"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByExtend1(string extend1, int top, TransactionManager tm)
		{
			return GetByExtend1(extend1, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 Extend1（字段） 查询
		/// </summary>
		/// <param name = "extend1"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByExtend1(string extend1, string sort)
		{
			return GetByExtend1(extend1, 0, sort, null);
		}

		/// <summary>
		/// 按 Extend1（字段） 查询
		/// </summary>
		/// <param name = "extend1"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByExtend1(string extend1, string sort, TransactionManager tm)
		{
			return GetByExtend1(extend1, 0, sort, tm);
		}

		/// <summary>
		/// 按 Extend1（字段） 查询
		/// </summary>
		/// <param name = "extend1"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetByExtend1(string extend1, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} remarkid, areaid, worldid, dstuin, roleid, rolename, srcuin, source, amount, uiip, paystatus, paymsg, createTime, finishTime, description, duid, extend1 FROM log_payment WHERE extend1=@Extend1";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Extend1", extend1, DbType.String, 150)
							.ExecList<LogPaymentEO>(LogPaymentEO.GetItem, tm);
		}

		#endregion

		#region  自定义条件查询

		/// <summary>
		/// 获取所有数据
		/// </summary>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetAll(TransactionManager tm = null)
		{
			return GetTopSort(string.Empty, null, -1, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "values">where子句中定义的参数值集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> Get(string where, params object[] values)
		{
			return GetTopSort(where, -1, string.Empty, null, values);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "paras">where子句中定义的参数集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> Get(string where, IEnumerable<DbParameter> paras)
		{
			return GetTopSort(where, paras, -1, string.Empty, null);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> Get(string where, TransactionManager tm)
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
		public virtual IEnumerable<LogPaymentEO> Get(string where, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<LogPaymentEO> Get(string where, IEnumerable<DbParameter> paras, TransactionManager tm)
		{
			return GetTopSort(where, paras, -1, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetTop(string where, int top)
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
		public virtual IEnumerable<LogPaymentEO> GetTop(string where, int top, params object[] values)
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
		public virtual IEnumerable<LogPaymentEO> GetTop(string where, IEnumerable<DbParameter> paras, int top)
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
		public virtual IEnumerable<LogPaymentEO> GetTop(string where, int top, TransactionManager tm)
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
		public virtual IEnumerable<LogPaymentEO> GetTop(string where, int top, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<LogPaymentEO> GetTop(string where, IEnumerable<DbParameter> paras, int top, TransactionManager tm)
		{
			return GetTopSort(where, paras, top, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogPaymentEO> GetSort(string where, string sort)
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
		public virtual IEnumerable<LogPaymentEO> GetSort(string where, string sort, params object[] values)
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
		public virtual IEnumerable<LogPaymentEO> GetSort(string where, IEnumerable<DbParameter> paras, string sort)
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
		public virtual IEnumerable<LogPaymentEO> GetSort(string where, string sort, TransactionManager tm)
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
		public virtual IEnumerable<LogPaymentEO> GetSort(string where, string sort, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<LogPaymentEO> GetSort(string where, IEnumerable<DbParameter> paras, string sort, TransactionManager tm)
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
		public virtual IEnumerable<LogPaymentEO> GetTopSort(string where, int top, string sort)
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
		public virtual IEnumerable<LogPaymentEO> GetTopSort(string where, int top, string sort, params object[] values)
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
		public virtual IEnumerable<LogPaymentEO> GetTopSort(string where, IEnumerable<DbParameter> paras, int top, string sort)
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
		public virtual IEnumerable<LogPaymentEO> GetTopSort(string where, int top, string sort, TransactionManager tm)
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
		public virtual IEnumerable<LogPaymentEO> GetTopSort(string where, int top, string sort, TransactionManager tm, params object[] values)
		{
			const string format = @"SELECT {0} remarkid, areaid, worldid, dstuin, roleid, rolename, srcuin, source, amount, uiip, paystatus, paymsg, createTime, finishTime, description, duid, extend1 FROM log_payment";
			string sql = format;

			if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameters(values)
							.ExecList<LogPaymentEO>(LogPaymentEO.GetItem, tm);
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
		public virtual IEnumerable<LogPaymentEO> GetTopSort(string where, IEnumerable<DbParameter> paras, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} remarkid, areaid, worldid, dstuin, roleid, rolename, srcuin, source, amount, uiip, paystatus, paymsg, createTime, finishTime, description, duid, extend1 FROM log_payment";
			string sql = format;

			if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddParameters(paras)
							.ExecList<LogPaymentEO>(LogPaymentEO.GetItem, tm);
		}

        public virtual DataTable GetTopSortTable(string where, int top, string sort, TransactionManager tm)
        {
            const string format = @"SELECT {0} remarkid, areaid, worldid, dstuin, roleid, rolename, srcuin, source, amount, uiip, paystatus, paymsg, createTime, finishTime, description, duid, extend1 FROM log_payment";
            string sql = format;

            if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
            if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
            sql = string.Format(sql, string.Empty);
            sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
            return Database.CreateSqlDao(sql)
                            .ExecTable();
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
			const string format = @"SELECT remarkid, areaid, worldid, dstuin, roleid, rolename, srcuin, source, amount, uiip, paystatus, paymsg, createTime, finishTime, description, duid, extend1 FROM log_payment {0} {1}";
			 string sql = string.Format(format, string.IsNullOrEmpty(where) ? string.Empty : "WHERE " + where, string.IsNullOrEmpty(sort) ? string.Empty : "ORDER BY " + sort);

			return Database.CreatePager(sql, pageSize, "remarkid");
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
		public virtual List<LogPaymentEO> GetPageList(int pageIndex , int pageSize, string where = null, string sort = null, IEnumerable<DbParameter> paras = null)
		{
			var pager = GetPager(pageSize, where, sort);

			pager.AddParameters(paras);
			return pager.GetPageList<LogPaymentEO>(pageIndex);
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
		public virtual IEnumerable<LogPaymentEO> GetPageMutil(int pageIndex , int pageSize, string where = null, string sort = null, IEnumerable<DbParameter> paras = null)
		{
			var pager = GetPager(pageSize, where, sort);

			pager.AddParameters(paras);
			return pager.GetPageMutil<LogPaymentEO>(pageIndex);
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
		public virtual int Add(LogPaymentEO item, TransactionManager tm = null)
		{
			const string sql = @"INSERT INTO log_payment (remarkid, areaid, worldid, dstuin, roleid, rolename, srcuin, source, amount, uiip, paystatus, paymsg, createTime, finishTime, description, duid, extend1) VALUES (@remarkid, @areaid, @worldid, @dstuin, @roleid, @rolename, @srcuin, @source, @amount, @uiip, @paystatus, @paymsg, @createTime, @finishTime, @description, @duid, @extend1) ";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@remarkid", item.Remarkid, DbType.String, 150)
							.AddInParameter("@areaid", item.Areaid != null ?  (object)item.Areaid : DBNull.Value, DbType.String, 150)
							.AddInParameter("@worldid", item.Worldid != null ?  (object)item.Worldid : DBNull.Value, DbType.String, 150)
							.AddInParameter("@dstuin", item.Dstuin != null ?  (object)item.Dstuin : DBNull.Value, DbType.String, 150)
							.AddInParameter("@roleid", item.Roleid != null ?  (object)item.Roleid : DBNull.Value, DbType.String, 150)
							.AddInParameter("@rolename", item.Rolename != null ?  (object)item.Rolename : DBNull.Value, DbType.String, 192)
							.AddInParameter("@srcuin", item.Srcuin != null ?  (object)item.Srcuin : DBNull.Value, DbType.String, 150)
							.AddInParameter("@source", item.Source != null ?  (object)item.Source : DBNull.Value, DbType.String, 150)
							.AddInParameter("@amount", item.Amount != null ?  (object)item.Amount : DBNull.Value, DbType.String, 150)
							.AddInParameter("@uiip", item.Uiip != null ?  (object)item.Uiip : DBNull.Value, DbType.String, 150)
							.AddInParameter("@paystatus", item.Paystatus != null ?  (object)item.Paystatus : DBNull.Value, DbType.String, 150)
							.AddInParameter("@paymsg", item.Paymsg != null ?  (object)item.Paymsg : DBNull.Value, DbType.String, 300)
							.AddInParameter("@createTime", item.CreateTime != null ?  (object)item.CreateTime : DBNull.Value, DbType.String, 150)
							.AddInParameter("@finishTime", item.FinishTime != null ?  (object)item.FinishTime : DBNull.Value, DbType.String, 150)
							.AddInParameter("@description", item.Description != null ?  (object)item.Description : DBNull.Value, DbType.String, 150)
							.AddInParameter("@duid", item.Duid != null ?  (object)item.Duid : DBNull.Value, DbType.String, 150)
							.AddInParameter("@extend1", item.Extend1 != null ?  (object)item.Extend1 : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 插入一组数据
		/// </summary>
		/// <param name = "items">要插入的实体对象集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Add(IEnumerable<LogPaymentEO> items, TransactionManager tm = null)
		{
			int ret = 0;
			const string sql = @"INSERT INTO log_payment (remarkid, areaid, worldid, dstuin, roleid, rolename, srcuin, source, amount, uiip, paystatus, paymsg, createTime, finishTime, description, duid, extend1) VALUES (@remarkid, @areaid, @worldid, @dstuin, @roleid, @rolename, @srcuin, @source, @amount, @uiip, @paystatus, @paymsg, @createTime, @finishTime, @description, @duid, @extend1) ";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@remarkid", DbType.String, 150)
									.AddParameter("@areaid", DbType.String, 150)
									.AddParameter("@worldid", DbType.String, 150)
									.AddParameter("@dstuin", DbType.String, 150)
									.AddParameter("@roleid", DbType.String, 150)
									.AddParameter("@rolename", DbType.String, 192)
									.AddParameter("@srcuin", DbType.String, 150)
									.AddParameter("@source", DbType.String, 150)
									.AddParameter("@amount", DbType.String, 150)
									.AddParameter("@uiip", DbType.String, 150)
									.AddParameter("@paystatus", DbType.String, 150)
									.AddParameter("@paymsg", DbType.String, 300)
									.AddParameter("@createTime", DbType.String, 150)
									.AddParameter("@finishTime", DbType.String, 150)
									.AddParameter("@description", DbType.String, 150)
									.AddParameter("@duid", DbType.String, 150)
									.AddParameter("@extend1", DbType.String, 150);

			foreach (LogPaymentEO item in items)
			{
				sqlDao
					.SetParameterValue("@remarkid", item.Remarkid)
					.SetParameterValue("@areaid", item.Areaid != null ?  (object)item.Areaid : DBNull.Value)
					.SetParameterValue("@worldid", item.Worldid != null ?  (object)item.Worldid : DBNull.Value)
					.SetParameterValue("@dstuin", item.Dstuin != null ?  (object)item.Dstuin : DBNull.Value)
					.SetParameterValue("@roleid", item.Roleid != null ?  (object)item.Roleid : DBNull.Value)
					.SetParameterValue("@rolename", item.Rolename != null ?  (object)item.Rolename : DBNull.Value)
					.SetParameterValue("@srcuin", item.Srcuin != null ?  (object)item.Srcuin : DBNull.Value)
					.SetParameterValue("@source", item.Source != null ?  (object)item.Source : DBNull.Value)
					.SetParameterValue("@amount", item.Amount != null ?  (object)item.Amount : DBNull.Value)
					.SetParameterValue("@uiip", item.Uiip != null ?  (object)item.Uiip : DBNull.Value)
					.SetParameterValue("@paystatus", item.Paystatus != null ?  (object)item.Paystatus : DBNull.Value)
					.SetParameterValue("@paymsg", item.Paymsg != null ?  (object)item.Paymsg : DBNull.Value)
					.SetParameterValue("@createTime", item.CreateTime != null ?  (object)item.CreateTime : DBNull.Value)
					.SetParameterValue("@finishTime", item.FinishTime != null ?  (object)item.FinishTime : DBNull.Value)
					.SetParameterValue("@description", item.Description != null ?  (object)item.Description : DBNull.Value)
					.SetParameterValue("@duid", item.Duid != null ?  (object)item.Duid : DBNull.Value)
					.SetParameterValue("@extend1", item.Extend1 != null ?  (object)item.Extend1 : DBNull.Value)
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
		public virtual int Put(LogPaymentEO item, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_payment SET remarkid=@remarkid, areaid=@areaid, worldid=@worldid, dstuin=@dstuin, roleid=@roleid, rolename=@rolename, srcuin=@srcuin, source=@source, amount=@amount, uiip=@uiip, paystatus=@paystatus, paymsg=@paymsg, createTime=@createTime, finishTime=@finishTime, description=@description, duid=@duid, extend1=@extend1 WHERE remarkid=@OriginalRemarkid";
			return Database.CreateSqlDao (sql)
							.AddInParameter("@OriginalRemarkid", (item.HasOriginal) ? item.OriginalRemarkid : item.Remarkid, DbType.String, 150)
							.AddInParameter("@remarkid", item.Remarkid, DbType.String, 150)
							.AddInParameter("@areaid", item.Areaid != null ?  (object)item.Areaid : DBNull.Value, DbType.String, 150)
							.AddInParameter("@worldid", item.Worldid != null ?  (object)item.Worldid : DBNull.Value, DbType.String, 150)
							.AddInParameter("@dstuin", item.Dstuin != null ?  (object)item.Dstuin : DBNull.Value, DbType.String, 150)
							.AddInParameter("@roleid", item.Roleid != null ?  (object)item.Roleid : DBNull.Value, DbType.String, 150)
							.AddInParameter("@rolename", item.Rolename != null ?  (object)item.Rolename : DBNull.Value, DbType.String, 192)
							.AddInParameter("@srcuin", item.Srcuin != null ?  (object)item.Srcuin : DBNull.Value, DbType.String, 150)
							.AddInParameter("@source", item.Source != null ?  (object)item.Source : DBNull.Value, DbType.String, 150)
							.AddInParameter("@amount", item.Amount != null ?  (object)item.Amount : DBNull.Value, DbType.String, 150)
							.AddInParameter("@uiip", item.Uiip != null ?  (object)item.Uiip : DBNull.Value, DbType.String, 150)
							.AddInParameter("@paystatus", item.Paystatus != null ?  (object)item.Paystatus : DBNull.Value, DbType.String, 150)
							.AddInParameter("@paymsg", item.Paymsg != null ?  (object)item.Paymsg : DBNull.Value, DbType.String, 300)
							.AddInParameter("@createTime", item.CreateTime != null ?  (object)item.CreateTime : DBNull.Value, DbType.String, 150)
							.AddInParameter("@finishTime", item.FinishTime != null ?  (object)item.FinishTime : DBNull.Value, DbType.String, 150)
							.AddInParameter("@description", item.Description != null ?  (object)item.Description : DBNull.Value, DbType.String, 150)
							.AddInParameter("@duid", item.Duid != null ?  (object)item.Duid : DBNull.Value, DbType.String, 150)
							.AddInParameter("@extend1", item.Extend1 != null ?  (object)item.Extend1 : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}


		/// <summary>
		/// 更新数据
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Put(IEnumerable<LogPaymentEO> items, TransactionManager tm = null)
		{

			int ret = 0;
			const string sql = @"UPDATE log_payment SET remarkid=@remarkid, areaid=@areaid, worldid=@worldid, dstuin=@dstuin, roleid=@roleid, rolename=@rolename, srcuin=@srcuin, source=@source, amount=@amount, uiip=@uiip, paystatus=@paystatus, paymsg=@paymsg, createTime=@createTime, finishTime=@finishTime, description=@description, duid=@duid, extend1=@extend1 WHERE remarkid=@OriginalRemarkid";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@OriginalRemarkid", DbType.String, 150)
									.AddParameter("@remarkid", DbType.String, 150)
									.AddParameter("@areaid", DbType.String, 150)
									.AddParameter("@worldid", DbType.String, 150)
									.AddParameter("@dstuin", DbType.String, 150)
									.AddParameter("@roleid", DbType.String, 150)
									.AddParameter("@rolename", DbType.String, 192)
									.AddParameter("@srcuin", DbType.String, 150)
									.AddParameter("@source", DbType.String, 150)
									.AddParameter("@amount", DbType.String, 150)
									.AddParameter("@uiip", DbType.String, 150)
									.AddParameter("@paystatus", DbType.String, 150)
									.AddParameter("@paymsg", DbType.String, 300)
									.AddParameter("@createTime", DbType.String, 150)
									.AddParameter("@finishTime", DbType.String, 150)
									.AddParameter("@description", DbType.String, 150)
									.AddParameter("@duid", DbType.String, 150)
									.AddParameter("@extend1", DbType.String, 150);

			foreach (LogPaymentEO item in items)
			{
				ret += sqlDao
							.SetParameterValue("@OriginalRemarkid", (item.HasOriginal) ? item.OriginalRemarkid : item.Remarkid)
							.SetParameterValue("@remarkid", item.Remarkid)
							.SetParameterValue("@areaid", item.Areaid != null ?  (object)item.Areaid : DBNull.Value)
							.SetParameterValue("@worldid", item.Worldid != null ?  (object)item.Worldid : DBNull.Value)
							.SetParameterValue("@dstuin", item.Dstuin != null ?  (object)item.Dstuin : DBNull.Value)
							.SetParameterValue("@roleid", item.Roleid != null ?  (object)item.Roleid : DBNull.Value)
							.SetParameterValue("@rolename", item.Rolename != null ?  (object)item.Rolename : DBNull.Value)
							.SetParameterValue("@srcuin", item.Srcuin != null ?  (object)item.Srcuin : DBNull.Value)
							.SetParameterValue("@source", item.Source != null ?  (object)item.Source : DBNull.Value)
							.SetParameterValue("@amount", item.Amount != null ?  (object)item.Amount : DBNull.Value)
							.SetParameterValue("@uiip", item.Uiip != null ?  (object)item.Uiip : DBNull.Value)
							.SetParameterValue("@paystatus", item.Paystatus != null ?  (object)item.Paystatus : DBNull.Value)
							.SetParameterValue("@paymsg", item.Paymsg != null ?  (object)item.Paymsg : DBNull.Value)
							.SetParameterValue("@createTime", item.CreateTime != null ?  (object)item.CreateTime : DBNull.Value)
							.SetParameterValue("@finishTime", item.FinishTime != null ?  (object)item.FinishTime : DBNull.Value)
							.SetParameterValue("@description", item.Description != null ?  (object)item.Description : DBNull.Value)
							.SetParameterValue("@duid", item.Duid != null ?  (object)item.Duid : DBNull.Value)
							.SetParameterValue("@extend1", item.Extend1 != null ?  (object)item.Extend1 : DBNull.Value)
							.ExecNonQuery(tm);
			}
			return ret;
		}


		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "remarkid"></param>
		/// <param name = "areaid"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutAreaidByPK(string remarkid, string areaid, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_payment SET areaid = @areaid  WHERE remarkid = @remarkid";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@remarkid", remarkid, DbType.String, 150)
							.AddInParameter("@areaid", areaid != null ?  (object)areaid : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "remarkid"></param>
		/// <param name = "worldid"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutWorldidByPK(string remarkid, string worldid, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_payment SET worldid = @worldid  WHERE remarkid = @remarkid";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@remarkid", remarkid, DbType.String, 150)
							.AddInParameter("@worldid", worldid != null ?  (object)worldid : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "remarkid"></param>
		/// <param name = "dstuin"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutDstuinByPK(string remarkid, string dstuin, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_payment SET dstuin = @dstuin  WHERE remarkid = @remarkid";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@remarkid", remarkid, DbType.String, 150)
							.AddInParameter("@dstuin", dstuin != null ?  (object)dstuin : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "remarkid"></param>
		/// <param name = "roleid"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutRoleidByPK(string remarkid, string roleid, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_payment SET roleid = @roleid  WHERE remarkid = @remarkid";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@remarkid", remarkid, DbType.String, 150)
							.AddInParameter("@roleid", roleid != null ?  (object)roleid : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "remarkid"></param>
		/// <param name = "rolename"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutRolenameByPK(string remarkid, string rolename, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_payment SET rolename = @rolename  WHERE remarkid = @remarkid";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@remarkid", remarkid, DbType.String, 150)
							.AddInParameter("@rolename", rolename != null ?  (object)rolename : DBNull.Value, DbType.String, 192)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "remarkid"></param>
		/// <param name = "srcuin"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutSrcuinByPK(string remarkid, string srcuin, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_payment SET srcuin = @srcuin  WHERE remarkid = @remarkid";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@remarkid", remarkid, DbType.String, 150)
							.AddInParameter("@srcuin", srcuin != null ?  (object)srcuin : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "remarkid"></param>
		/// <param name = "source"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutSourceByPK(string remarkid, string source, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_payment SET source = @source  WHERE remarkid = @remarkid";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@remarkid", remarkid, DbType.String, 150)
							.AddInParameter("@source", source != null ?  (object)source : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "remarkid"></param>
		/// <param name = "amount"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutAmountByPK(string remarkid, string amount, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_payment SET amount = @amount  WHERE remarkid = @remarkid";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@remarkid", remarkid, DbType.String, 150)
							.AddInParameter("@amount", amount != null ?  (object)amount : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "remarkid"></param>
		/// <param name = "uiip"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutUiipByPK(string remarkid, string uiip, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_payment SET uiip = @uiip  WHERE remarkid = @remarkid";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@remarkid", remarkid, DbType.String, 150)
							.AddInParameter("@uiip", uiip != null ?  (object)uiip : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "remarkid"></param>
		/// <param name = "paystatus"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutPaystatusByPK(string remarkid, string paystatus, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_payment SET paystatus = @paystatus  WHERE remarkid = @remarkid";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@remarkid", remarkid, DbType.String, 150)
							.AddInParameter("@paystatus", paystatus != null ?  (object)paystatus : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "remarkid"></param>
		/// <param name = "paymsg"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutPaymsgByPK(string remarkid, string paymsg, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_payment SET paymsg = @paymsg  WHERE remarkid = @remarkid";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@remarkid", remarkid, DbType.String, 150)
							.AddInParameter("@paymsg", paymsg != null ?  (object)paymsg : DBNull.Value, DbType.String, 300)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "remarkid"></param>
		/// <param name = "createTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutCreateTimeByPK(string remarkid, string createTime, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_payment SET createTime = @createTime  WHERE remarkid = @remarkid";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@remarkid", remarkid, DbType.String, 150)
							.AddInParameter("@createTime", createTime != null ?  (object)createTime : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "remarkid"></param>
		/// <param name = "finishTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutFinishTimeByPK(string remarkid, string finishTime, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_payment SET finishTime = @finishTime  WHERE remarkid = @remarkid";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@remarkid", remarkid, DbType.String, 150)
							.AddInParameter("@finishTime", finishTime != null ?  (object)finishTime : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "remarkid"></param>
		/// <param name = "description"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutDescriptionByPK(string remarkid, string description, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_payment SET description = @description  WHERE remarkid = @remarkid";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@remarkid", remarkid, DbType.String, 150)
							.AddInParameter("@description", description != null ?  (object)description : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "remarkid"></param>
		/// <param name = "duid"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutDuidByPK(string remarkid, string duid, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_payment SET duid = @duid  WHERE remarkid = @remarkid";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@remarkid", remarkid, DbType.String, 150)
							.AddInParameter("@duid", duid != null ?  (object)duid : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "remarkid"></param>
		/// <param name = "extend1"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutExtend1ByPK(string remarkid, string extend1, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_payment SET extend1 = @extend1  WHERE remarkid = @remarkid";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@remarkid", remarkid, DbType.String, 150)
							.AddInParameter("@extend1", extend1 != null ?  (object)extend1 : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}


		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "areaid"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutAreaid(string areaid, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_payment SET areaid=@areaid";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@areaid", areaid != null ?  (object)areaid : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "worldid"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutWorldid(string worldid, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_payment SET worldid=@worldid";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@worldid", worldid != null ?  (object)worldid : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "dstuin"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutDstuin(string dstuin, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_payment SET dstuin=@dstuin";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@dstuin", dstuin != null ?  (object)dstuin : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "roleid"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutRoleid(string roleid, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_payment SET roleid=@roleid";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@roleid", roleid != null ?  (object)roleid : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "rolename"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutRolename(string rolename, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_payment SET rolename=@rolename";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@rolename", rolename != null ?  (object)rolename : DBNull.Value, DbType.String, 192)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "srcuin"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutSrcuin(string srcuin, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_payment SET srcuin=@srcuin";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@srcuin", srcuin != null ?  (object)srcuin : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "source"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutSource(string source, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_payment SET source=@source";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@source", source != null ?  (object)source : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "amount"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutAmount(string amount, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_payment SET amount=@amount";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@amount", amount != null ?  (object)amount : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "uiip"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutUiip(string uiip, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_payment SET uiip=@uiip";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@uiip", uiip != null ?  (object)uiip : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "paystatus"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutPaystatus(string paystatus, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_payment SET paystatus=@paystatus";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@paystatus", paystatus != null ?  (object)paystatus : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "paymsg"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutPaymsg(string paymsg, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_payment SET paymsg=@paymsg";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@paymsg", paymsg != null ?  (object)paymsg : DBNull.Value, DbType.String, 300)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "createTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutCreateTime(string createTime, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_payment SET createTime=@createTime";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@createTime", createTime != null ?  (object)createTime : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "finishTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutFinishTime(string finishTime, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_payment SET finishTime=@finishTime";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@finishTime", finishTime != null ?  (object)finishTime : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "description"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutDescription(string description, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_payment SET description=@description";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@description", description != null ?  (object)description : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "duid"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutDuid(string duid, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_payment SET duid=@duid";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@duid", duid != null ?  (object)duid : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "extend1"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutExtend1(string extend1, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_payment SET extend1=@extend1";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@extend1", extend1 != null ?  (object)extend1 : DBNull.Value, DbType.String, 150)
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
			const string format = @"UPDATE log_payment SET {0} {1}";
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
			const string format = @"UPDATE log_payment SET {0} {1}";
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
		/// <param name = "remarkid"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByPK(string remarkid, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM log_payment WHERE remarkid=@remarkid";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@remarkid", remarkid, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Remove(LogPaymentEO item, TransactionManager tm = null)
		{
			return RemoveByPK(item.Remarkid, tm);
		}

		/// <summary>
		/// 删除指定实体集合对应的记录集
		/// </summary>
		/// <param name = "items">要删除的实体集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Remove(IEnumerable<LogPaymentEO> items, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM log_payment WHERE remarkid=@OriginalRemarkid";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@OriginalRemarkid", DbType.String, 150);
			int ret = 0;
			foreach (LogPaymentEO item in items)
			{
				ret += sqlDao
							.SetParameterValue("@OriginalRemarkid", (item.HasOriginal) ? item.OriginalRemarkid : item.Remarkid)
							.ExecNonQuery(tm);
			}
			return ret;
		}




		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "areaid"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByAreaid(string areaid, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM log_payment WHERE areaid=@areaid";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@areaid", areaid != null ?  (object)areaid : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "worldid"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByWorldid(string worldid, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM log_payment WHERE worldid=@worldid";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@worldid", worldid != null ?  (object)worldid : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "dstuin"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByDstuin(string dstuin, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM log_payment WHERE dstuin=@dstuin";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@dstuin", dstuin != null ?  (object)dstuin : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "roleid"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByRoleid(string roleid, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM log_payment WHERE roleid=@roleid";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@roleid", roleid != null ?  (object)roleid : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "rolename"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByRolename(string rolename, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM log_payment WHERE rolename=@rolename";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@rolename", rolename != null ?  (object)rolename : DBNull.Value, DbType.String, 192)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "srcuin"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveBySrcuin(string srcuin, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM log_payment WHERE srcuin=@srcuin";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@srcuin", srcuin != null ?  (object)srcuin : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "source"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveBySource(string source, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM log_payment WHERE source=@source";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@source", source != null ?  (object)source : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "amount"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByAmount(string amount, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM log_payment WHERE amount=@amount";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@amount", amount != null ?  (object)amount : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "uiip"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByUiip(string uiip, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM log_payment WHERE uiip=@uiip";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@uiip", uiip != null ?  (object)uiip : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "paystatus"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByPaystatus(string paystatus, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM log_payment WHERE paystatus=@paystatus";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@paystatus", paystatus != null ?  (object)paystatus : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "paymsg"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByPaymsg(string paymsg, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM log_payment WHERE paymsg=@paymsg";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@paymsg", paymsg != null ?  (object)paymsg : DBNull.Value, DbType.String, 300)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "createTime"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByCreateTime(string createTime, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM log_payment WHERE createTime=@createTime";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@createTime", createTime != null ?  (object)createTime : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "finishTime"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByFinishTime(string finishTime, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM log_payment WHERE finishTime=@finishTime";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@finishTime", finishTime != null ?  (object)finishTime : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "description"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByDescription(string description, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM log_payment WHERE description=@description";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@description", description != null ?  (object)description : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "duid"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByDuid(string duid, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM log_payment WHERE duid=@duid";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@duid", duid != null ?  (object)duid : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "extend1"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByExtend1(string extend1, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM log_payment WHERE extend1=@extend1";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@extend1", extend1 != null ?  (object)extend1 : DBNull.Value, DbType.String, 150)
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
			const string format = @"DELETE FROM log_payment {0}";
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
			const string format = @"DELETE FROM log_payment {0}";
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
