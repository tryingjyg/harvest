//==========================================================
// 此代码由代码生成器工具自动生成，请不要修改
// 代码生成器核心库版本号：2.0
// 创建时间：2017/9/29 10:43:19
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
	/// 【表 malltgoods 的实体类】
	/// </summary>
	[SerializableAttribute]
	public class MalltgoodsEO : DataEntityBase, IRowMapper<MalltgoodsEO>
	{
		protected string _originalMgId;

		/// <summary>
		/// 主键是否有原始值（即数据库中保存的值），用于实体对象更新时
		/// </summary>
		public bool HasOriginal { get; protected set; }

		/// <summary>
		/// 【主键 varchar】
		/// </summary>
		public virtual string MgId { get; set; }

		/// <summary>
		/// 【数据库中的原始主键值副本】
		/// </summary>
		public virtual string OriginalMgId
		{
			get { return _originalMgId; }
			set { HasOriginal = true; _originalMgId = value; }
		}

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string MgNo { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string MgName { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string MgPrice { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string MgDiamondsnum { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string MgRate { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string MgPresentnum { get; set; }

		/// <summary>
		/// 【字段 date】
		/// </summary>
		public virtual DateTime? MgAdddTime { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string MgJsondata { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string MgText1 { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string MgText2 { get; set; }

		/// <summary>
		/// 默认构造函数
		/// </summary>
		public MalltgoodsEO() 
		{
			MgId = string.Empty;
		}

		/// <summary>
		/// 自定义构造函数
		/// </summary>
		/// <param name = "mgId"></param>
		/// <param name = "mgNo"></param>
		/// <param name = "mgName"></param>
		/// <param name = "mgPrice"></param>
		/// <param name = "mgDiamondsnum"></param>
		/// <param name = "mgRate"></param>
		/// <param name = "mgPresentnum"></param>
		/// <param name = "mgAdddTime"></param>
		/// <param name = "mgJsondata"></param>
		/// <param name = "mgText1"></param>
		/// <param name = "mgText2"></param>
		public MalltgoodsEO(string mgId, string mgNo, string mgName, string mgPrice, string mgDiamondsnum, string mgRate, string mgPresentnum, DateTime? mgAdddTime, string mgJsondata, string mgText1, string mgText2) 
		{
			MgId = mgId;
			MgNo = mgNo;
			MgName = mgName;
			MgPrice = mgPrice;
			MgDiamondsnum = mgDiamondsnum;
			MgRate = mgRate;
			MgPresentnum = mgPresentnum;
			MgAdddTime = mgAdddTime;
			MgJsondata = mgJsondata;
			MgText1 = mgText1;
			MgText2 = mgText2;
		}

		/// <summary>
		/// 将结果集映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public MalltgoodsEO MapRow(IDataReader reader)
		{
			return GetItem(reader);
		}

		/// <summary>
		/// 将结果集映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static MalltgoodsEO GetItem(IDataReader reader)
		{
			MalltgoodsEO ret = new MalltgoodsEO();

			ret.MgId = (string)reader["Mg_id"];
			ret.OriginalMgId = ret.MgId;
			ret.MgNo = (reader["Mg_no"] is DBNull) ? null : (string)reader["Mg_no"];
			ret.MgName = (reader["Mg_name"] is DBNull) ? null : (string)reader["Mg_name"];
			ret.MgPrice = (reader["Mg_price"] is DBNull) ? null : (string)reader["Mg_price"];
			ret.MgDiamondsnum = (reader["Mg_diamondsnum"] is DBNull) ? null : (string)reader["Mg_diamondsnum"];
			ret.MgRate = (reader["Mg_rate"] is DBNull) ? null : (string)reader["Mg_rate"];
			ret.MgPresentnum = (reader["Mg_presentnum"] is DBNull) ? null : (string)reader["Mg_presentnum"];
			ret.MgAdddTime = (reader["Mg_adddTime"] is DBNull) ? (DateTime?)null : DateTime.Parse(reader["Mg_adddTime"].ToString());
			ret.MgJsondata = (reader["Mg_jsondata"] is DBNull) ? null : (string)reader["Mg_jsondata"];
			ret.MgText1 = (reader["Mg_text1"] is DBNull) ? null : (string)reader["Mg_text1"];
			ret.MgText2 = (reader["Mg_text2"] is DBNull) ? null : (string)reader["Mg_text2"];
			return ret;
		}
	}


	#endregion

	#region  MO

	/// <summary>
	/// 【表 malltgoods 的操作类】
	/// </summary>
	public class MalltgoodsMO : DataManagerBase
	{

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "routeData">路由数据</param>
		public MalltgoodsMO(object routeData = null) : base(routeData) { }

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">连接字符串名称</param>
		public MalltgoodsMO(string connectionStringName) : base(connectionStringName) { }

		#region  Get方法集合

		/// <summary>
		/// 按 PK（主键） 查询
		/// </summary>
		/// <param name="tm">事务管理对象</param>
		/// <param name = "mgId"></param>
		/// <return></return>
		public virtual MalltgoodsEO GetByPK(string mgId, TransactionManager tm = null)
		{
			const string sql = @"SELECT Mg_id, Mg_no, Mg_name, Mg_price, Mg_diamondsnum, Mg_rate, Mg_presentnum, Mg_adddTime, Mg_jsondata, Mg_text1, Mg_text2 FROM malltgoods WHERE Mg_id=@Mg_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Mg_id", mgId, DbType.String, 150)
							.ExecSingle<MalltgoodsEO>(MalltgoodsEO.GetItem, tm);
		}




		#region  按 MgNo（字段） 查询

		/// <summary>
		/// 按 MgNo（字段） 查询
		/// </summary>
		/// <param name = "mgNo"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgNo(string mgNo)
		{
			return GetByMgNo(mgNo, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 MgNo（字段） 查询
		/// </summary>
		/// <param name = "mgNo"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgNo(string mgNo, TransactionManager tm)
		{
			return GetByMgNo(mgNo, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 MgNo（字段） 查询
		/// </summary>
		/// <param name = "mgNo"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgNo(string mgNo, int top)
		{
			return GetByMgNo(mgNo, top, string.Empty, null);
		}

		/// <summary>
		/// 按 MgNo（字段） 查询
		/// </summary>
		/// <param name = "mgNo"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgNo(string mgNo, int top, TransactionManager tm)
		{
			return GetByMgNo(mgNo, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 MgNo（字段） 查询
		/// </summary>
		/// <param name = "mgNo"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgNo(string mgNo, string sort)
		{
			return GetByMgNo(mgNo, 0, sort, null);
		}

		/// <summary>
		/// 按 MgNo（字段） 查询
		/// </summary>
		/// <param name = "mgNo"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgNo(string mgNo, string sort, TransactionManager tm)
		{
			return GetByMgNo(mgNo, 0, sort, tm);
		}

		/// <summary>
		/// 按 MgNo（字段） 查询
		/// </summary>
		/// <param name = "mgNo"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgNo(string mgNo, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Mg_id, Mg_no, Mg_name, Mg_price, Mg_diamondsnum, Mg_rate, Mg_presentnum, Mg_adddTime, Mg_jsondata, Mg_text1, Mg_text2 FROM malltgoods WHERE Mg_no=@MgNo";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@MgNo", mgNo, DbType.String, 150)
							.ExecList<MalltgoodsEO>(MalltgoodsEO.GetItem, tm);
		}

		#endregion

		#region  按 MgName（字段） 查询

		/// <summary>
		/// 按 MgName（字段） 查询
		/// </summary>
		/// <param name = "mgName"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgName(string mgName)
		{
			return GetByMgName(mgName, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 MgName（字段） 查询
		/// </summary>
		/// <param name = "mgName"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgName(string mgName, TransactionManager tm)
		{
			return GetByMgName(mgName, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 MgName（字段） 查询
		/// </summary>
		/// <param name = "mgName"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgName(string mgName, int top)
		{
			return GetByMgName(mgName, top, string.Empty, null);
		}

		/// <summary>
		/// 按 MgName（字段） 查询
		/// </summary>
		/// <param name = "mgName"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgName(string mgName, int top, TransactionManager tm)
		{
			return GetByMgName(mgName, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 MgName（字段） 查询
		/// </summary>
		/// <param name = "mgName"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgName(string mgName, string sort)
		{
			return GetByMgName(mgName, 0, sort, null);
		}

		/// <summary>
		/// 按 MgName（字段） 查询
		/// </summary>
		/// <param name = "mgName"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgName(string mgName, string sort, TransactionManager tm)
		{
			return GetByMgName(mgName, 0, sort, tm);
		}

		/// <summary>
		/// 按 MgName（字段） 查询
		/// </summary>
		/// <param name = "mgName"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgName(string mgName, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Mg_id, Mg_no, Mg_name, Mg_price, Mg_diamondsnum, Mg_rate, Mg_presentnum, Mg_adddTime, Mg_jsondata, Mg_text1, Mg_text2 FROM malltgoods WHERE Mg_name=@MgName";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@MgName", mgName, DbType.String, 150)
							.ExecList<MalltgoodsEO>(MalltgoodsEO.GetItem, tm);
		}

		#endregion

		#region  按 MgPrice（字段） 查询

		/// <summary>
		/// 按 MgPrice（字段） 查询
		/// </summary>
		/// <param name = "mgPrice"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgPrice(string mgPrice)
		{
			return GetByMgPrice(mgPrice, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 MgPrice（字段） 查询
		/// </summary>
		/// <param name = "mgPrice"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgPrice(string mgPrice, TransactionManager tm)
		{
			return GetByMgPrice(mgPrice, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 MgPrice（字段） 查询
		/// </summary>
		/// <param name = "mgPrice"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgPrice(string mgPrice, int top)
		{
			return GetByMgPrice(mgPrice, top, string.Empty, null);
		}

		/// <summary>
		/// 按 MgPrice（字段） 查询
		/// </summary>
		/// <param name = "mgPrice"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgPrice(string mgPrice, int top, TransactionManager tm)
		{
			return GetByMgPrice(mgPrice, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 MgPrice（字段） 查询
		/// </summary>
		/// <param name = "mgPrice"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgPrice(string mgPrice, string sort)
		{
			return GetByMgPrice(mgPrice, 0, sort, null);
		}

		/// <summary>
		/// 按 MgPrice（字段） 查询
		/// </summary>
		/// <param name = "mgPrice"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgPrice(string mgPrice, string sort, TransactionManager tm)
		{
			return GetByMgPrice(mgPrice, 0, sort, tm);
		}

		/// <summary>
		/// 按 MgPrice（字段） 查询
		/// </summary>
		/// <param name = "mgPrice"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgPrice(string mgPrice, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Mg_id, Mg_no, Mg_name, Mg_price, Mg_diamondsnum, Mg_rate, Mg_presentnum, Mg_adddTime, Mg_jsondata, Mg_text1, Mg_text2 FROM malltgoods WHERE Mg_price=@MgPrice";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@MgPrice", mgPrice, DbType.String, 30)
							.ExecList<MalltgoodsEO>(MalltgoodsEO.GetItem, tm);
		}

		#endregion

		#region  按 MgDiamondsnum（字段） 查询

		/// <summary>
		/// 按 MgDiamondsnum（字段） 查询
		/// </summary>
		/// <param name = "mgDiamondsnum"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgDiamondsnum(string mgDiamondsnum)
		{
			return GetByMgDiamondsnum(mgDiamondsnum, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 MgDiamondsnum（字段） 查询
		/// </summary>
		/// <param name = "mgDiamondsnum"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgDiamondsnum(string mgDiamondsnum, TransactionManager tm)
		{
			return GetByMgDiamondsnum(mgDiamondsnum, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 MgDiamondsnum（字段） 查询
		/// </summary>
		/// <param name = "mgDiamondsnum"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgDiamondsnum(string mgDiamondsnum, int top)
		{
			return GetByMgDiamondsnum(mgDiamondsnum, top, string.Empty, null);
		}

		/// <summary>
		/// 按 MgDiamondsnum（字段） 查询
		/// </summary>
		/// <param name = "mgDiamondsnum"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgDiamondsnum(string mgDiamondsnum, int top, TransactionManager tm)
		{
			return GetByMgDiamondsnum(mgDiamondsnum, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 MgDiamondsnum（字段） 查询
		/// </summary>
		/// <param name = "mgDiamondsnum"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgDiamondsnum(string mgDiamondsnum, string sort)
		{
			return GetByMgDiamondsnum(mgDiamondsnum, 0, sort, null);
		}

		/// <summary>
		/// 按 MgDiamondsnum（字段） 查询
		/// </summary>
		/// <param name = "mgDiamondsnum"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgDiamondsnum(string mgDiamondsnum, string sort, TransactionManager tm)
		{
			return GetByMgDiamondsnum(mgDiamondsnum, 0, sort, tm);
		}

		/// <summary>
		/// 按 MgDiamondsnum（字段） 查询
		/// </summary>
		/// <param name = "mgDiamondsnum"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgDiamondsnum(string mgDiamondsnum, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Mg_id, Mg_no, Mg_name, Mg_price, Mg_diamondsnum, Mg_rate, Mg_presentnum, Mg_adddTime, Mg_jsondata, Mg_text1, Mg_text2 FROM malltgoods WHERE Mg_diamondsnum=@MgDiamondsnum";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@MgDiamondsnum", mgDiamondsnum, DbType.String, 150)
							.ExecList<MalltgoodsEO>(MalltgoodsEO.GetItem, tm);
		}

		#endregion

		#region  按 MgRate（字段） 查询

		/// <summary>
		/// 按 MgRate（字段） 查询
		/// </summary>
		/// <param name = "mgRate"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgRate(string mgRate)
		{
			return GetByMgRate(mgRate, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 MgRate（字段） 查询
		/// </summary>
		/// <param name = "mgRate"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgRate(string mgRate, TransactionManager tm)
		{
			return GetByMgRate(mgRate, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 MgRate（字段） 查询
		/// </summary>
		/// <param name = "mgRate"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgRate(string mgRate, int top)
		{
			return GetByMgRate(mgRate, top, string.Empty, null);
		}

		/// <summary>
		/// 按 MgRate（字段） 查询
		/// </summary>
		/// <param name = "mgRate"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgRate(string mgRate, int top, TransactionManager tm)
		{
			return GetByMgRate(mgRate, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 MgRate（字段） 查询
		/// </summary>
		/// <param name = "mgRate"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgRate(string mgRate, string sort)
		{
			return GetByMgRate(mgRate, 0, sort, null);
		}

		/// <summary>
		/// 按 MgRate（字段） 查询
		/// </summary>
		/// <param name = "mgRate"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgRate(string mgRate, string sort, TransactionManager tm)
		{
			return GetByMgRate(mgRate, 0, sort, tm);
		}

		/// <summary>
		/// 按 MgRate（字段） 查询
		/// </summary>
		/// <param name = "mgRate"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgRate(string mgRate, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Mg_id, Mg_no, Mg_name, Mg_price, Mg_diamondsnum, Mg_rate, Mg_presentnum, Mg_adddTime, Mg_jsondata, Mg_text1, Mg_text2 FROM malltgoods WHERE Mg_rate=@MgRate";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@MgRate", mgRate, DbType.String, 150)
							.ExecList<MalltgoodsEO>(MalltgoodsEO.GetItem, tm);
		}

		#endregion

		#region  按 MgPresentnum（字段） 查询

		/// <summary>
		/// 按 MgPresentnum（字段） 查询
		/// </summary>
		/// <param name = "mgPresentnum"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgPresentnum(string mgPresentnum)
		{
			return GetByMgPresentnum(mgPresentnum, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 MgPresentnum（字段） 查询
		/// </summary>
		/// <param name = "mgPresentnum"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgPresentnum(string mgPresentnum, TransactionManager tm)
		{
			return GetByMgPresentnum(mgPresentnum, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 MgPresentnum（字段） 查询
		/// </summary>
		/// <param name = "mgPresentnum"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgPresentnum(string mgPresentnum, int top)
		{
			return GetByMgPresentnum(mgPresentnum, top, string.Empty, null);
		}

		/// <summary>
		/// 按 MgPresentnum（字段） 查询
		/// </summary>
		/// <param name = "mgPresentnum"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgPresentnum(string mgPresentnum, int top, TransactionManager tm)
		{
			return GetByMgPresentnum(mgPresentnum, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 MgPresentnum（字段） 查询
		/// </summary>
		/// <param name = "mgPresentnum"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgPresentnum(string mgPresentnum, string sort)
		{
			return GetByMgPresentnum(mgPresentnum, 0, sort, null);
		}

		/// <summary>
		/// 按 MgPresentnum（字段） 查询
		/// </summary>
		/// <param name = "mgPresentnum"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgPresentnum(string mgPresentnum, string sort, TransactionManager tm)
		{
			return GetByMgPresentnum(mgPresentnum, 0, sort, tm);
		}

		/// <summary>
		/// 按 MgPresentnum（字段） 查询
		/// </summary>
		/// <param name = "mgPresentnum"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgPresentnum(string mgPresentnum, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Mg_id, Mg_no, Mg_name, Mg_price, Mg_diamondsnum, Mg_rate, Mg_presentnum, Mg_adddTime, Mg_jsondata, Mg_text1, Mg_text2 FROM malltgoods WHERE Mg_presentnum=@MgPresentnum";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@MgPresentnum", mgPresentnum, DbType.String, 150)
							.ExecList<MalltgoodsEO>(MalltgoodsEO.GetItem, tm);
		}

		#endregion

		#region  按 MgAdddTime（字段） 查询

		/// <summary>
		/// 按 MgAdddTime（字段） 查询
		/// </summary>
		/// <param name = "mgAdddTime"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgAdddTime(DateTime? mgAdddTime)
		{
			return GetByMgAdddTime(mgAdddTime, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 MgAdddTime（字段） 查询
		/// </summary>
		/// <param name = "mgAdddTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgAdddTime(DateTime? mgAdddTime, TransactionManager tm)
		{
			return GetByMgAdddTime(mgAdddTime, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 MgAdddTime（字段） 查询
		/// </summary>
		/// <param name = "mgAdddTime"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgAdddTime(DateTime? mgAdddTime, int top)
		{
			return GetByMgAdddTime(mgAdddTime, top, string.Empty, null);
		}

		/// <summary>
		/// 按 MgAdddTime（字段） 查询
		/// </summary>
		/// <param name = "mgAdddTime"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgAdddTime(DateTime? mgAdddTime, int top, TransactionManager tm)
		{
			return GetByMgAdddTime(mgAdddTime, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 MgAdddTime（字段） 查询
		/// </summary>
		/// <param name = "mgAdddTime"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgAdddTime(DateTime? mgAdddTime, string sort)
		{
			return GetByMgAdddTime(mgAdddTime, 0, sort, null);
		}

		/// <summary>
		/// 按 MgAdddTime（字段） 查询
		/// </summary>
		/// <param name = "mgAdddTime"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgAdddTime(DateTime? mgAdddTime, string sort, TransactionManager tm)
		{
			return GetByMgAdddTime(mgAdddTime, 0, sort, tm);
		}

		/// <summary>
		/// 按 MgAdddTime（字段） 查询
		/// </summary>
		/// <param name = "mgAdddTime"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgAdddTime(DateTime? mgAdddTime, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Mg_id, Mg_no, Mg_name, Mg_price, Mg_diamondsnum, Mg_rate, Mg_presentnum, Mg_adddTime, Mg_jsondata, Mg_text1, Mg_text2 FROM malltgoods WHERE Mg_adddTime=@MgAdddTime";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@MgAdddTime", mgAdddTime, DbType.Date, 0)
							.ExecList<MalltgoodsEO>(MalltgoodsEO.GetItem, tm);
		}

		#endregion

		#region  按 MgJsondata（字段） 查询

		/// <summary>
		/// 按 MgJsondata（字段） 查询
		/// </summary>
		/// <param name = "mgJsondata"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgJsondata(string mgJsondata)
		{
			return GetByMgJsondata(mgJsondata, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 MgJsondata（字段） 查询
		/// </summary>
		/// <param name = "mgJsondata"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgJsondata(string mgJsondata, TransactionManager tm)
		{
			return GetByMgJsondata(mgJsondata, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 MgJsondata（字段） 查询
		/// </summary>
		/// <param name = "mgJsondata"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgJsondata(string mgJsondata, int top)
		{
			return GetByMgJsondata(mgJsondata, top, string.Empty, null);
		}

		/// <summary>
		/// 按 MgJsondata（字段） 查询
		/// </summary>
		/// <param name = "mgJsondata"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgJsondata(string mgJsondata, int top, TransactionManager tm)
		{
			return GetByMgJsondata(mgJsondata, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 MgJsondata（字段） 查询
		/// </summary>
		/// <param name = "mgJsondata"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgJsondata(string mgJsondata, string sort)
		{
			return GetByMgJsondata(mgJsondata, 0, sort, null);
		}

		/// <summary>
		/// 按 MgJsondata（字段） 查询
		/// </summary>
		/// <param name = "mgJsondata"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgJsondata(string mgJsondata, string sort, TransactionManager tm)
		{
			return GetByMgJsondata(mgJsondata, 0, sort, tm);
		}

		/// <summary>
		/// 按 MgJsondata（字段） 查询
		/// </summary>
		/// <param name = "mgJsondata"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgJsondata(string mgJsondata, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Mg_id, Mg_no, Mg_name, Mg_price, Mg_diamondsnum, Mg_rate, Mg_presentnum, Mg_adddTime, Mg_jsondata, Mg_text1, Mg_text2 FROM malltgoods WHERE Mg_jsondata=@MgJsondata";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@MgJsondata", mgJsondata, DbType.String, 3000)
							.ExecList<MalltgoodsEO>(MalltgoodsEO.GetItem, tm);
		}

		#endregion

		#region  按 MgText1（字段） 查询

		/// <summary>
		/// 按 MgText1（字段） 查询
		/// </summary>
		/// <param name = "mgText1"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgText1(string mgText1)
		{
			return GetByMgText1(mgText1, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 MgText1（字段） 查询
		/// </summary>
		/// <param name = "mgText1"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgText1(string mgText1, TransactionManager tm)
		{
			return GetByMgText1(mgText1, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 MgText1（字段） 查询
		/// </summary>
		/// <param name = "mgText1"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgText1(string mgText1, int top)
		{
			return GetByMgText1(mgText1, top, string.Empty, null);
		}

		/// <summary>
		/// 按 MgText1（字段） 查询
		/// </summary>
		/// <param name = "mgText1"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgText1(string mgText1, int top, TransactionManager tm)
		{
			return GetByMgText1(mgText1, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 MgText1（字段） 查询
		/// </summary>
		/// <param name = "mgText1"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgText1(string mgText1, string sort)
		{
			return GetByMgText1(mgText1, 0, sort, null);
		}

		/// <summary>
		/// 按 MgText1（字段） 查询
		/// </summary>
		/// <param name = "mgText1"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgText1(string mgText1, string sort, TransactionManager tm)
		{
			return GetByMgText1(mgText1, 0, sort, tm);
		}

		/// <summary>
		/// 按 MgText1（字段） 查询
		/// </summary>
		/// <param name = "mgText1"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgText1(string mgText1, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Mg_id, Mg_no, Mg_name, Mg_price, Mg_diamondsnum, Mg_rate, Mg_presentnum, Mg_adddTime, Mg_jsondata, Mg_text1, Mg_text2 FROM malltgoods WHERE Mg_text1=@MgText1";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@MgText1", mgText1, DbType.String, 600)
							.ExecList<MalltgoodsEO>(MalltgoodsEO.GetItem, tm);
		}

		#endregion

		#region  按 MgText2（字段） 查询

		/// <summary>
		/// 按 MgText2（字段） 查询
		/// </summary>
		/// <param name = "mgText2"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgText2(string mgText2)
		{
			return GetByMgText2(mgText2, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 MgText2（字段） 查询
		/// </summary>
		/// <param name = "mgText2"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgText2(string mgText2, TransactionManager tm)
		{
			return GetByMgText2(mgText2, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 MgText2（字段） 查询
		/// </summary>
		/// <param name = "mgText2"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgText2(string mgText2, int top)
		{
			return GetByMgText2(mgText2, top, string.Empty, null);
		}

		/// <summary>
		/// 按 MgText2（字段） 查询
		/// </summary>
		/// <param name = "mgText2"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgText2(string mgText2, int top, TransactionManager tm)
		{
			return GetByMgText2(mgText2, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 MgText2（字段） 查询
		/// </summary>
		/// <param name = "mgText2"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgText2(string mgText2, string sort)
		{
			return GetByMgText2(mgText2, 0, sort, null);
		}

		/// <summary>
		/// 按 MgText2（字段） 查询
		/// </summary>
		/// <param name = "mgText2"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgText2(string mgText2, string sort, TransactionManager tm)
		{
			return GetByMgText2(mgText2, 0, sort, tm);
		}

		/// <summary>
		/// 按 MgText2（字段） 查询
		/// </summary>
		/// <param name = "mgText2"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetByMgText2(string mgText2, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Mg_id, Mg_no, Mg_name, Mg_price, Mg_diamondsnum, Mg_rate, Mg_presentnum, Mg_adddTime, Mg_jsondata, Mg_text1, Mg_text2 FROM malltgoods WHERE Mg_text2=@MgText2";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@MgText2", mgText2, DbType.String, 600)
							.ExecList<MalltgoodsEO>(MalltgoodsEO.GetItem, tm);
		}

		#endregion

		#region  自定义条件查询

		/// <summary>
		/// 获取所有数据
		/// </summary>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetAll(TransactionManager tm = null)
		{
			return GetTopSort(string.Empty, null, -1, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "values">where子句中定义的参数值集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> Get(string where, params object[] values)
		{
			return GetTopSort(where, -1, string.Empty, null, values);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "paras">where子句中定义的参数集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> Get(string where, IEnumerable<DbParameter> paras)
		{
			return GetTopSort(where, paras, -1, string.Empty, null);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> Get(string where, TransactionManager tm)
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
		public virtual IEnumerable<MalltgoodsEO> Get(string where, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<MalltgoodsEO> Get(string where, IEnumerable<DbParameter> paras, TransactionManager tm)
		{
			return GetTopSort(where, paras, -1, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetTop(string where, int top)
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
		public virtual IEnumerable<MalltgoodsEO> GetTop(string where, int top, params object[] values)
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
		public virtual IEnumerable<MalltgoodsEO> GetTop(string where, IEnumerable<DbParameter> paras, int top)
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
		public virtual IEnumerable<MalltgoodsEO> GetTop(string where, int top, TransactionManager tm)
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
		public virtual IEnumerable<MalltgoodsEO> GetTop(string where, int top, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<MalltgoodsEO> GetTop(string where, IEnumerable<DbParameter> paras, int top, TransactionManager tm)
		{
			return GetTopSort(where, paras, top, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<MalltgoodsEO> GetSort(string where, string sort)
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
		public virtual IEnumerable<MalltgoodsEO> GetSort(string where, string sort, params object[] values)
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
		public virtual IEnumerable<MalltgoodsEO> GetSort(string where, IEnumerable<DbParameter> paras, string sort)
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
		public virtual IEnumerable<MalltgoodsEO> GetSort(string where, string sort, TransactionManager tm)
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
		public virtual IEnumerable<MalltgoodsEO> GetSort(string where, string sort, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<MalltgoodsEO> GetSort(string where, IEnumerable<DbParameter> paras, string sort, TransactionManager tm)
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
		public virtual IEnumerable<MalltgoodsEO> GetTopSort(string where, int top, string sort)
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
		public virtual IEnumerable<MalltgoodsEO> GetTopSort(string where, int top, string sort, params object[] values)
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
		public virtual IEnumerable<MalltgoodsEO> GetTopSort(string where, IEnumerable<DbParameter> paras, int top, string sort)
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
		public virtual IEnumerable<MalltgoodsEO> GetTopSort(string where, int top, string sort, TransactionManager tm)
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
		public virtual IEnumerable<MalltgoodsEO> GetTopSort(string where, int top, string sort, TransactionManager tm, params object[] values)
		{
			const string format = @"SELECT {0} Mg_id, Mg_no, Mg_name, Mg_price, Mg_diamondsnum, Mg_rate, Mg_presentnum, Mg_adddTime, Mg_jsondata, Mg_text1, Mg_text2 FROM malltgoods";
			string sql = format;

			if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameters(values)
							.ExecList<MalltgoodsEO>(MalltgoodsEO.GetItem, tm);
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
		public virtual IEnumerable<MalltgoodsEO> GetTopSort(string where, IEnumerable<DbParameter> paras, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Mg_id, Mg_no, Mg_name, Mg_price, Mg_diamondsnum, Mg_rate, Mg_presentnum, Mg_adddTime, Mg_jsondata, Mg_text1, Mg_text2 FROM malltgoods";
			string sql = format;

			if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddParameters(paras)
							.ExecList<MalltgoodsEO>(MalltgoodsEO.GetItem, tm);
		}

        public virtual DataTable GetList(string where)
        {
            const string sql = @"SELECT Mg_id, Mg_no, Mg_name, Mg_price, Mg_diamondsnum, Mg_rate, Mg_presentnum, Mg_adddTime, Mg_jsondata, Mg_text1, Mg_text2 FROM malltgoods";
            return Database.CreateSqlDao(sql).ExecTable();
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
			const string format = @"SELECT Mg_id, Mg_no, Mg_name, Mg_price, Mg_diamondsnum, Mg_rate, Mg_presentnum, Mg_adddTime, Mg_jsondata, Mg_text1, Mg_text2 FROM malltgoods {0} {1}";
			 string sql = string.Format(format, string.IsNullOrEmpty(where) ? string.Empty : "WHERE " + where, string.IsNullOrEmpty(sort) ? string.Empty : "ORDER BY " + sort);

			return Database.CreatePager(sql, pageSize, "Mg_id");
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
		public virtual List<MalltgoodsEO> GetPageList(int pageIndex , int pageSize, string where = null, string sort = null, IEnumerable<DbParameter> paras = null)
		{
			var pager = GetPager(pageSize, where, sort);

			pager.AddParameters(paras);
			return pager.GetPageList<MalltgoodsEO>(pageIndex);
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
		public virtual IEnumerable<MalltgoodsEO> GetPageMutil(int pageIndex , int pageSize, string where = null, string sort = null, IEnumerable<DbParameter> paras = null)
		{
			var pager = GetPager(pageSize, where, sort);

			pager.AddParameters(paras);
			return pager.GetPageMutil<MalltgoodsEO>(pageIndex);
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
		public virtual int Add(MalltgoodsEO item, TransactionManager tm = null)
		{
			const string sql = @"INSERT INTO malltgoods (Mg_id, Mg_no, Mg_name, Mg_price, Mg_diamondsnum, Mg_rate, Mg_presentnum, Mg_adddTime, Mg_jsondata, Mg_text1, Mg_text2) VALUES (@Mg_id, @Mg_no, @Mg_name, @Mg_price, @Mg_diamondsnum, @Mg_rate, @Mg_presentnum, @Mg_adddTime, @Mg_jsondata, @Mg_text1, @Mg_text2) ";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Mg_id", item.MgId, DbType.String, 150)
							.AddInParameter("@Mg_no", item.MgNo != null ?  (object)item.MgNo : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Mg_name", item.MgName != null ?  (object)item.MgName : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Mg_price", item.MgPrice != null ?  (object)item.MgPrice : DBNull.Value, DbType.String, 30)
							.AddInParameter("@Mg_diamondsnum", item.MgDiamondsnum != null ?  (object)item.MgDiamondsnum : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Mg_rate", item.MgRate != null ?  (object)item.MgRate : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Mg_presentnum", item.MgPresentnum != null ?  (object)item.MgPresentnum : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Mg_adddTime", item.MgAdddTime.HasValue ? (object)item.MgAdddTime.Value : DBNull.Value, DbType.Date, 0)
							.AddInParameter("@Mg_jsondata", item.MgJsondata != null ?  (object)item.MgJsondata : DBNull.Value, DbType.String, 3000)
							.AddInParameter("@Mg_text1", item.MgText1 != null ?  (object)item.MgText1 : DBNull.Value, DbType.String, 600)
							.AddInParameter("@Mg_text2", item.MgText2 != null ?  (object)item.MgText2 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 插入一组数据
		/// </summary>
		/// <param name = "items">要插入的实体对象集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Add(IEnumerable<MalltgoodsEO> items, TransactionManager tm = null)
		{
			int ret = 0;
			const string sql = @"INSERT INTO malltgoods (Mg_id, Mg_no, Mg_name, Mg_price, Mg_diamondsnum, Mg_rate, Mg_presentnum, Mg_adddTime, Mg_jsondata, Mg_text1, Mg_text2) VALUES (@Mg_id, @Mg_no, @Mg_name, @Mg_price, @Mg_diamondsnum, @Mg_rate, @Mg_presentnum, @Mg_adddTime, @Mg_jsondata, @Mg_text1, @Mg_text2) ";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@Mg_id", DbType.String, 150)
									.AddParameter("@Mg_no", DbType.String, 150)
									.AddParameter("@Mg_name", DbType.String, 150)
									.AddParameter("@Mg_price", DbType.String, 30)
									.AddParameter("@Mg_diamondsnum", DbType.String, 150)
									.AddParameter("@Mg_rate", DbType.String, 150)
									.AddParameter("@Mg_presentnum", DbType.String, 150)
									.AddParameter("@Mg_adddTime", DbType.Date, 0)
									.AddParameter("@Mg_jsondata", DbType.String, 3000)
									.AddParameter("@Mg_text1", DbType.String, 600)
									.AddParameter("@Mg_text2", DbType.String, 600);

			foreach (MalltgoodsEO item in items)
			{
				sqlDao
					.SetParameterValue("@Mg_id", item.MgId)
					.SetParameterValue("@Mg_no", item.MgNo != null ?  (object)item.MgNo : DBNull.Value)
					.SetParameterValue("@Mg_name", item.MgName != null ?  (object)item.MgName : DBNull.Value)
					.SetParameterValue("@Mg_price", item.MgPrice != null ?  (object)item.MgPrice : DBNull.Value)
					.SetParameterValue("@Mg_diamondsnum", item.MgDiamondsnum != null ?  (object)item.MgDiamondsnum : DBNull.Value)
					.SetParameterValue("@Mg_rate", item.MgRate != null ?  (object)item.MgRate : DBNull.Value)
					.SetParameterValue("@Mg_presentnum", item.MgPresentnum != null ?  (object)item.MgPresentnum : DBNull.Value)
					.SetParameterValue("@Mg_adddTime", item.MgAdddTime.HasValue ? (object)item.MgAdddTime.Value : DBNull.Value)
					.SetParameterValue("@Mg_jsondata", item.MgJsondata != null ?  (object)item.MgJsondata : DBNull.Value)
					.SetParameterValue("@Mg_text1", item.MgText1 != null ?  (object)item.MgText1 : DBNull.Value)
					.SetParameterValue("@Mg_text2", item.MgText2 != null ?  (object)item.MgText2 : DBNull.Value)
					.ExecNonQuery(tm);
				++ret;
			}
			return ret;
		}
        #endregion

        #region  Put方法集合

        public virtual int UpdateGoods(MalltgoodsEO item, TransactionManager tm = null)
        {
            const string sql = @"UPDATE malltgoods SET Mg_no=@Mg_no, Mg_name=@Mg_name, Mg_price=@Mg_price, Mg_diamondsnum=@Mg_diamondsnum, Mg_rate=@Mg_rate, Mg_presentnum=@Mg_presentnum, Mg_adddTime=@Mg_adddTime, Mg_jsondata=@Mg_jsondata, Mg_text1=@Mg_text1, Mg_text2=@Mg_text2 WHERE  Mg_id=@Mg_id";
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@Mg_no", item.MgNo != null ? (object)item.MgNo : DBNull.Value, DbType.String, 150)
                            .AddInParameter("@Mg_name", item.MgName != null ? (object)item.MgName : DBNull.Value, DbType.String, 150)
                            .AddInParameter("@Mg_price", item.MgPrice != null ? (object)item.MgPrice : DBNull.Value, DbType.String, 30)
                            .AddInParameter("@Mg_diamondsnum", item.MgDiamondsnum != null ? (object)item.MgDiamondsnum : DBNull.Value, DbType.String, 150)
                            .AddInParameter("@Mg_rate", item.MgRate != null ? (object)item.MgRate : DBNull.Value, DbType.String, 150)
                            .AddInParameter("@Mg_presentnum", item.MgPresentnum != null ? (object)item.MgPresentnum : DBNull.Value, DbType.String, 150)
                            .AddInParameter("@Mg_adddTime", item.MgAdddTime.HasValue ? (object)item.MgAdddTime.Value : DBNull.Value, DbType.Date, 0)
                            .AddInParameter("@Mg_jsondata", item.MgJsondata != null ? (object)item.MgJsondata : DBNull.Value, DbType.String, 3000)
                            .AddInParameter("@Mg_text1", item.MgText1 != null ? (object)item.MgText1 : DBNull.Value, DbType.String, 600)
                            .AddInParameter("@Mg_text2", item.MgText2 != null ? (object)item.MgText2 : DBNull.Value, DbType.String, 600)
                            .AddInParameter("@Mg_id", item.MgId, DbType.String, 150)
                            .ExecNonQuery(tm);
            //return 0;
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name = "item">要更新的实体对象</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>受影响的行数</return>
        public virtual int Put(MalltgoodsEO item, TransactionManager tm = null)
		{
			const string sql = @"UPDATE malltgoods SET Mg_id=@Mg_id, Mg_no=@Mg_no, Mg_name=@Mg_name, Mg_price=@Mg_price, Mg_diamondsnum=@Mg_diamondsnum, Mg_rate=@Mg_rate, Mg_presentnum=@Mg_presentnum, Mg_adddTime=@Mg_adddTime, Mg_jsondata=@Mg_jsondata, Mg_text1=@Mg_text1, Mg_text2=@Mg_text2 WHERE Mg_id=@OriginalMg_id";
			return Database.CreateSqlDao (sql)
							.AddInParameter("@OriginalMgId", (item.HasOriginal) ? item.OriginalMgId : item.MgId, DbType.String, 150)
							.AddInParameter("@Mg_id", item.MgId, DbType.String, 150)
							.AddInParameter("@Mg_no", item.MgNo != null ?  (object)item.MgNo : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Mg_name", item.MgName != null ?  (object)item.MgName : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Mg_price", item.MgPrice != null ?  (object)item.MgPrice : DBNull.Value, DbType.String, 30)
							.AddInParameter("@Mg_diamondsnum", item.MgDiamondsnum != null ?  (object)item.MgDiamondsnum : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Mg_rate", item.MgRate != null ?  (object)item.MgRate : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Mg_presentnum", item.MgPresentnum != null ?  (object)item.MgPresentnum : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Mg_adddTime", item.MgAdddTime.HasValue ? (object)item.MgAdddTime.Value : DBNull.Value, DbType.Date, 0)
							.AddInParameter("@Mg_jsondata", item.MgJsondata != null ?  (object)item.MgJsondata : DBNull.Value, DbType.String, 3000)
							.AddInParameter("@Mg_text1", item.MgText1 != null ?  (object)item.MgText1 : DBNull.Value, DbType.String, 600)
							.AddInParameter("@Mg_text2", item.MgText2 != null ?  (object)item.MgText2 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}


		/// <summary>
		/// 更新数据
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Put(IEnumerable<MalltgoodsEO> items, TransactionManager tm = null)
		{

			int ret = 0;
			const string sql = @"UPDATE malltgoods SET Mg_id=@Mg_id, Mg_no=@Mg_no, Mg_name=@Mg_name, Mg_price=@Mg_price, Mg_diamondsnum=@Mg_diamondsnum, Mg_rate=@Mg_rate, Mg_presentnum=@Mg_presentnum, Mg_adddTime=@Mg_adddTime, Mg_jsondata=@Mg_jsondata, Mg_text1=@Mg_text1, Mg_text2=@Mg_text2 WHERE Mg_id=@OriginalMg_id";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@OriginalMgId", DbType.String, 150)
									.AddParameter("@Mg_id", DbType.String, 150)
									.AddParameter("@Mg_no", DbType.String, 150)
									.AddParameter("@Mg_name", DbType.String, 150)
									.AddParameter("@Mg_price", DbType.String, 30)
									.AddParameter("@Mg_diamondsnum", DbType.String, 150)
									.AddParameter("@Mg_rate", DbType.String, 150)
									.AddParameter("@Mg_presentnum", DbType.String, 150)
									.AddParameter("@Mg_adddTime", DbType.Date, 0)
									.AddParameter("@Mg_jsondata", DbType.String, 3000)
									.AddParameter("@Mg_text1", DbType.String, 600)
									.AddParameter("@Mg_text2", DbType.String, 600);

			foreach (MalltgoodsEO item in items)
			{
				ret += sqlDao
							.SetParameterValue("@OriginalMgId", (item.HasOriginal) ? item.OriginalMgId : item.MgId)
							.SetParameterValue("@Mg_id", item.MgId)
							.SetParameterValue("@Mg_no", item.MgNo != null ?  (object)item.MgNo : DBNull.Value)
							.SetParameterValue("@Mg_name", item.MgName != null ?  (object)item.MgName : DBNull.Value)
							.SetParameterValue("@Mg_price", item.MgPrice != null ?  (object)item.MgPrice : DBNull.Value)
							.SetParameterValue("@Mg_diamondsnum", item.MgDiamondsnum != null ?  (object)item.MgDiamondsnum : DBNull.Value)
							.SetParameterValue("@Mg_rate", item.MgRate != null ?  (object)item.MgRate : DBNull.Value)
							.SetParameterValue("@Mg_presentnum", item.MgPresentnum != null ?  (object)item.MgPresentnum : DBNull.Value)
							.SetParameterValue("@Mg_adddTime", item.MgAdddTime.HasValue ? (object)item.MgAdddTime.Value : DBNull.Value)
							.SetParameterValue("@Mg_jsondata", item.MgJsondata != null ?  (object)item.MgJsondata : DBNull.Value)
							.SetParameterValue("@Mg_text1", item.MgText1 != null ?  (object)item.MgText1 : DBNull.Value)
							.SetParameterValue("@Mg_text2", item.MgText2 != null ?  (object)item.MgText2 : DBNull.Value)
							.ExecNonQuery(tm);
			}
			return ret;
		}


		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "mgId"></param>
		/// <param name = "mgNo"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutMgNoByPK(string mgId, string mgNo, TransactionManager tm = null)
		{
			const string sql = @"UPDATE malltgoods SET Mg_no = @Mg_no  WHERE Mg_id = @Mg_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Mg_id", mgId, DbType.String, 150)
							.AddInParameter("@Mg_no", mgNo != null ?  (object)mgNo : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "mgId"></param>
		/// <param name = "mgName"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutMgNameByPK(string mgId, string mgName, TransactionManager tm = null)
		{
			const string sql = @"UPDATE malltgoods SET Mg_name = @Mg_name  WHERE Mg_id = @Mg_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Mg_id", mgId, DbType.String, 150)
							.AddInParameter("@Mg_name", mgName != null ?  (object)mgName : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "mgId"></param>
		/// <param name = "mgPrice"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutMgPriceByPK(string mgId, string mgPrice, TransactionManager tm = null)
		{
			const string sql = @"UPDATE malltgoods SET Mg_price = @Mg_price  WHERE Mg_id = @Mg_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Mg_id", mgId, DbType.String, 150)
							.AddInParameter("@Mg_price", mgPrice != null ?  (object)mgPrice : DBNull.Value, DbType.String, 30)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "mgId"></param>
		/// <param name = "mgDiamondsnum"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutMgDiamondsnumByPK(string mgId, string mgDiamondsnum, TransactionManager tm = null)
		{
			const string sql = @"UPDATE malltgoods SET Mg_diamondsnum = @Mg_diamondsnum  WHERE Mg_id = @Mg_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Mg_id", mgId, DbType.String, 150)
							.AddInParameter("@Mg_diamondsnum", mgDiamondsnum != null ?  (object)mgDiamondsnum : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "mgId"></param>
		/// <param name = "mgRate"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutMgRateByPK(string mgId, string mgRate, TransactionManager tm = null)
		{
			const string sql = @"UPDATE malltgoods SET Mg_rate = @Mg_rate  WHERE Mg_id = @Mg_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Mg_id", mgId, DbType.String, 150)
							.AddInParameter("@Mg_rate", mgRate != null ?  (object)mgRate : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "mgId"></param>
		/// <param name = "mgPresentnum"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutMgPresentnumByPK(string mgId, string mgPresentnum, TransactionManager tm = null)
		{
			const string sql = @"UPDATE malltgoods SET Mg_presentnum = @Mg_presentnum  WHERE Mg_id = @Mg_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Mg_id", mgId, DbType.String, 150)
							.AddInParameter("@Mg_presentnum", mgPresentnum != null ?  (object)mgPresentnum : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "mgId"></param>
		/// <param name = "mgAdddTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutMgAdddTimeByPK(string mgId, DateTime? mgAdddTime, TransactionManager tm = null)
		{
			const string sql = @"UPDATE malltgoods SET Mg_adddTime = @Mg_adddTime  WHERE Mg_id = @Mg_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Mg_id", mgId, DbType.String, 150)
							.AddInParameter("@Mg_adddTime", mgAdddTime.HasValue ? (object)mgAdddTime.Value : DBNull.Value, DbType.Date, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "mgId"></param>
		/// <param name = "mgJsondata"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutMgJsondataByPK(string mgId, string mgJsondata, TransactionManager tm = null)
		{
			const string sql = @"UPDATE malltgoods SET Mg_jsondata = @Mg_jsondata  WHERE Mg_id = @Mg_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Mg_id", mgId, DbType.String, 150)
							.AddInParameter("@Mg_jsondata", mgJsondata != null ?  (object)mgJsondata : DBNull.Value, DbType.String, 3000)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "mgId"></param>
		/// <param name = "mgText1"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutMgText1ByPK(string mgId, string mgText1, TransactionManager tm = null)
		{
			const string sql = @"UPDATE malltgoods SET Mg_text1 = @Mg_text1  WHERE Mg_id = @Mg_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Mg_id", mgId, DbType.String, 150)
							.AddInParameter("@Mg_text1", mgText1 != null ?  (object)mgText1 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "mgId"></param>
		/// <param name = "mgText2"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutMgText2ByPK(string mgId, string mgText2, TransactionManager tm = null)
		{
			const string sql = @"UPDATE malltgoods SET Mg_text2 = @Mg_text2  WHERE Mg_id = @Mg_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Mg_id", mgId, DbType.String, 150)
							.AddInParameter("@Mg_text2", mgText2 != null ?  (object)mgText2 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}


		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "mgNo"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutMgNo(string mgNo, TransactionManager tm = null)
		{
			const string sql = @"UPDATE malltgoods SET Mg_no=@Mg_no";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Mg_no", mgNo != null ?  (object)mgNo : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "mgName"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutMgName(string mgName, TransactionManager tm = null)
		{
			const string sql = @"UPDATE malltgoods SET Mg_name=@Mg_name";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Mg_name", mgName != null ?  (object)mgName : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "mgPrice"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutMgPrice(string mgPrice, TransactionManager tm = null)
		{
			const string sql = @"UPDATE malltgoods SET Mg_price=@Mg_price";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Mg_price", mgPrice != null ?  (object)mgPrice : DBNull.Value, DbType.String, 30)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "mgDiamondsnum"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutMgDiamondsnum(string mgDiamondsnum, TransactionManager tm = null)
		{
			const string sql = @"UPDATE malltgoods SET Mg_diamondsnum=@Mg_diamondsnum";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Mg_diamondsnum", mgDiamondsnum != null ?  (object)mgDiamondsnum : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "mgRate"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutMgRate(string mgRate, TransactionManager tm = null)
		{
			const string sql = @"UPDATE malltgoods SET Mg_rate=@Mg_rate";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Mg_rate", mgRate != null ?  (object)mgRate : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "mgPresentnum"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutMgPresentnum(string mgPresentnum, TransactionManager tm = null)
		{
			const string sql = @"UPDATE malltgoods SET Mg_presentnum=@Mg_presentnum";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Mg_presentnum", mgPresentnum != null ?  (object)mgPresentnum : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "mgAdddTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutMgAdddTime(DateTime? mgAdddTime, TransactionManager tm = null)
		{
			const string sql = @"UPDATE malltgoods SET Mg_adddTime=@Mg_adddTime";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Mg_adddTime", mgAdddTime.HasValue ? (object)mgAdddTime.Value : DBNull.Value, DbType.Date, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "mgJsondata"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutMgJsondata(string mgJsondata, TransactionManager tm = null)
		{
			const string sql = @"UPDATE malltgoods SET Mg_jsondata=@Mg_jsondata";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Mg_jsondata", mgJsondata != null ?  (object)mgJsondata : DBNull.Value, DbType.String, 3000)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "mgText1"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutMgText1(string mgText1, TransactionManager tm = null)
		{
			const string sql = @"UPDATE malltgoods SET Mg_text1=@Mg_text1";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Mg_text1", mgText1 != null ?  (object)mgText1 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "mgText2"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutMgText2(string mgText2, TransactionManager tm = null)
		{
			const string sql = @"UPDATE malltgoods SET Mg_text2=@Mg_text2";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Mg_text2", mgText2 != null ?  (object)mgText2 : DBNull.Value, DbType.String, 600)
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
			const string format = @"UPDATE malltgoods SET {0} {1}";
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
			const string format = @"UPDATE malltgoods SET {0} {1}";
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
		/// <param name = "mgId"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByPK(string mgId, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM malltgoods WHERE Mg_id=@Mg_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Mg_id", mgId, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Remove(MalltgoodsEO item, TransactionManager tm = null)
		{
			return RemoveByPK(item.MgId, tm);
		}

		/// <summary>
		/// 删除指定实体集合对应的记录集
		/// </summary>
		/// <param name = "items">要删除的实体集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Remove(IEnumerable<MalltgoodsEO> items, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM malltgoods WHERE Mg_id=@OriginalMg_id";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@OriginalMgId", DbType.String, 150);
			int ret = 0;
			foreach (MalltgoodsEO item in items)
			{
				ret += sqlDao
							.SetParameterValue("@OriginalMgId", (item.HasOriginal) ? item.OriginalMgId : item.MgId)
							.ExecNonQuery(tm);
			}
			return ret;
		}




		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "mgNo"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByMgNo(string mgNo, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM malltgoods WHERE Mg_no=@Mg_no";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Mg_no", mgNo != null ?  (object)mgNo : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "mgName"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByMgName(string mgName, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM malltgoods WHERE Mg_name=@Mg_name";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Mg_name", mgName != null ?  (object)mgName : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "mgPrice"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByMgPrice(string mgPrice, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM malltgoods WHERE Mg_price=@Mg_price";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Mg_price", mgPrice != null ?  (object)mgPrice : DBNull.Value, DbType.String, 30)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "mgDiamondsnum"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByMgDiamondsnum(string mgDiamondsnum, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM malltgoods WHERE Mg_diamondsnum=@Mg_diamondsnum";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Mg_diamondsnum", mgDiamondsnum != null ?  (object)mgDiamondsnum : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "mgRate"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByMgRate(string mgRate, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM malltgoods WHERE Mg_rate=@Mg_rate";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Mg_rate", mgRate != null ?  (object)mgRate : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "mgPresentnum"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByMgPresentnum(string mgPresentnum, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM malltgoods WHERE Mg_presentnum=@Mg_presentnum";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Mg_presentnum", mgPresentnum != null ?  (object)mgPresentnum : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "mgAdddTime"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByMgAdddTime(DateTime? mgAdddTime, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM malltgoods WHERE Mg_adddTime=@Mg_adddTime";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Mg_adddTime", mgAdddTime.HasValue ? (object)mgAdddTime.Value : DBNull.Value, DbType.Date, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "mgJsondata"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByMgJsondata(string mgJsondata, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM malltgoods WHERE Mg_jsondata=@Mg_jsondata";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Mg_jsondata", mgJsondata != null ?  (object)mgJsondata : DBNull.Value, DbType.String, 3000)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "mgText1"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByMgText1(string mgText1, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM malltgoods WHERE Mg_text1=@Mg_text1";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Mg_text1", mgText1 != null ?  (object)mgText1 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "mgText2"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByMgText2(string mgText2, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM malltgoods WHERE Mg_text2=@Mg_text2";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Mg_text2", mgText2 != null ?  (object)mgText2 : DBNull.Value, DbType.String, 600)
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
			const string format = @"DELETE FROM malltgoods {0}";
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
			const string format = @"DELETE FROM malltgoods {0}";
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
