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
	/// 【表 rolegame 的实体类】
	/// </summary>
	[SerializableAttribute]
	public class RolegameEO : DataEntityBase, IRowMapper<RolegameEO>
	{
		protected string _originalRlId;
		protected string _originalGmId;

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
		/// 【主键 varchar】
		/// </summary>
		public virtual string GmId { get; set; }

		/// <summary>
		/// 【数据库中的原始主键值副本】
		/// </summary>
		public virtual string OriginalGmId
		{
			get { return _originalGmId; }
			set { HasOriginal = true; _originalGmId = value; }
		}

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string UrId { get; set; }

		/// <summary>
		/// 【字段 date】
		/// </summary>
		public virtual DateTime? RgAddTime { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string RgText1 { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string RgText2 { get; set; }

		/// <summary>
		/// 默认构造函数
		/// </summary>
		public RolegameEO() 
		{
			RlId = string.Empty;
			GmId = string.Empty;
		}

		/// <summary>
		/// 自定义构造函数
		/// </summary>
		/// <param name = "rlId"></param>
		/// <param name = "gmId"></param>
		/// <param name = "urId"></param>
		/// <param name = "rgAddTime"></param>
		/// <param name = "rgText1"></param>
		/// <param name = "rgText2"></param>
		public RolegameEO(string rlId, string gmId, string urId, DateTime? rgAddTime, string rgText1, string rgText2) 
		{
			RlId = rlId;
			GmId = gmId;
			UrId = urId;
			RgAddTime = rgAddTime;
			RgText1 = rgText1;
			RgText2 = rgText2;
		}

		/// <summary>
		/// 将结果集映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public RolegameEO MapRow(IDataReader reader)
		{
			return GetItem(reader);
		}

		/// <summary>
		/// 将结果集映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static RolegameEO GetItem(IDataReader reader)
		{
			RolegameEO ret = new RolegameEO();

			ret.RlId = (string)reader["Rl_id"];
			ret.OriginalRlId = ret.RlId;
			ret.GmId = (string)reader["Gm_id"];
			ret.OriginalGmId = ret.GmId;
			ret.UrId = (reader["Ur_id"] is DBNull) ? null : (string)reader["Ur_id"];
			ret.RgAddTime = (reader["Rg_addTime"] is DBNull) ? (DateTime?)null : DateTime.Parse(reader["Rg_addTime"].ToString());
			ret.RgText1 = (reader["Rg_text1"] is DBNull) ? null : (string)reader["Rg_text1"];
			ret.RgText2 = (reader["Rg_text2"] is DBNull) ? null : (string)reader["Rg_text2"];
			return ret;
		}
	}


	#endregion

	#region  MO

	/// <summary>
	/// 【表 rolegame 的操作类】
	/// </summary>
    public partial class RolegameMO : DataManagerBase
	{

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "routeData">路由数据</param>
		public RolegameMO(object routeData = null) : base(routeData) { }

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">连接字符串名称</param>
		public RolegameMO(string connectionStringName) : base(connectionStringName) { }

		#region  Get方法集合

		/// <summary>
		/// 按 PK（主键） 查询
		/// </summary>
		/// <param name="tm">事务管理对象</param>
		/// <param name = "rlId"></param>
		/// <param name = "gmId"></param>
		/// <return></return>
		public virtual RolegameEO GetByPK(string rlId, string gmId, TransactionManager tm = null)
		{
			const string sql = @"SELECT Rl_id, Gm_id, Ur_id, Rg_addTime, Rg_text1, Rg_text2 FROM rolegame WHERE Rl_id=@Rl_id and Gm_id=@Gm_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Rl_id", rlId, DbType.String, 150)
							.AddInParameter("@Gm_id", gmId, DbType.String, 150)
							.ExecSingle<RolegameEO>(RolegameEO.GetItem, tm);
		}




		#region  按 RlId（字段） 查询

		/// <summary>
		/// 按 RlId（字段） 查询
		/// </summary>
		/// <param name = "rlId"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolegameEO> GetByRlId(string rlId)
		{
			return GetByRlId(rlId, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 RlId（字段） 查询
		/// </summary>
		/// <param name = "rlId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolegameEO> GetByRlId(string rlId, TransactionManager tm)
		{
			return GetByRlId(rlId, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 RlId（字段） 查询
		/// </summary>
		/// <param name = "rlId"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolegameEO> GetByRlId(string rlId, int top)
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
		public virtual IEnumerable<RolegameEO> GetByRlId(string rlId, int top, TransactionManager tm)
		{
			return GetByRlId(rlId, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 RlId（字段） 查询
		/// </summary>
		/// <param name = "rlId"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolegameEO> GetByRlId(string rlId, string sort)
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
		public virtual IEnumerable<RolegameEO> GetByRlId(string rlId, string sort, TransactionManager tm)
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
		public virtual IEnumerable<RolegameEO> GetByRlId(string rlId, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Rl_id, Gm_id, Ur_id, Rg_addTime, Rg_text1, Rg_text2 FROM rolegame WHERE Rl_id=@RlId";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@RlId", rlId, DbType.String, 150)
							.ExecList<RolegameEO>(RolegameEO.GetItem, tm);
		}

		#endregion

		#region  按 GmId（字段） 查询

		/// <summary>
		/// 按 GmId（字段） 查询
		/// </summary>
		/// <param name = "gmId"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolegameEO> GetByGmId(string gmId)
		{
			return GetByGmId(gmId, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 GmId（字段） 查询
		/// </summary>
		/// <param name = "gmId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolegameEO> GetByGmId(string gmId, TransactionManager tm)
		{
			return GetByGmId(gmId, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 GmId（字段） 查询
		/// </summary>
		/// <param name = "gmId"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolegameEO> GetByGmId(string gmId, int top)
		{
			return GetByGmId(gmId, top, string.Empty, null);
		}

		/// <summary>
		/// 按 GmId（字段） 查询
		/// </summary>
		/// <param name = "gmId"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolegameEO> GetByGmId(string gmId, int top, TransactionManager tm)
		{
			return GetByGmId(gmId, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 GmId（字段） 查询
		/// </summary>
		/// <param name = "gmId"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolegameEO> GetByGmId(string gmId, string sort)
		{
			return GetByGmId(gmId, 0, sort, null);
		}

		/// <summary>
		/// 按 GmId（字段） 查询
		/// </summary>
		/// <param name = "gmId"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolegameEO> GetByGmId(string gmId, string sort, TransactionManager tm)
		{
			return GetByGmId(gmId, 0, sort, tm);
		}

		/// <summary>
		/// 按 GmId（字段） 查询
		/// </summary>
		/// <param name = "gmId"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolegameEO> GetByGmId(string gmId, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Rl_id, Gm_id, Ur_id, Rg_addTime, Rg_text1, Rg_text2 FROM rolegame WHERE Gm_id=@GmId";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@GmId", gmId, DbType.String, 150)
							.ExecList<RolegameEO>(RolegameEO.GetItem, tm);
		}

		#endregion

		#region  按 UrId（字段） 查询

		/// <summary>
		/// 按 UrId（字段） 查询
		/// </summary>
		/// <param name = "urId"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolegameEO> GetByUrId(string urId)
		{
			return GetByUrId(urId, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 UrId（字段） 查询
		/// </summary>
		/// <param name = "urId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolegameEO> GetByUrId(string urId, TransactionManager tm)
		{
			return GetByUrId(urId, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 UrId（字段） 查询
		/// </summary>
		/// <param name = "urId"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolegameEO> GetByUrId(string urId, int top)
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
		public virtual IEnumerable<RolegameEO> GetByUrId(string urId, int top, TransactionManager tm)
		{
			return GetByUrId(urId, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 UrId（字段） 查询
		/// </summary>
		/// <param name = "urId"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolegameEO> GetByUrId(string urId, string sort)
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
		public virtual IEnumerable<RolegameEO> GetByUrId(string urId, string sort, TransactionManager tm)
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
		public virtual IEnumerable<RolegameEO> GetByUrId(string urId, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Rl_id, Gm_id, Ur_id, Rg_addTime, Rg_text1, Rg_text2 FROM rolegame WHERE Ur_id=@UrId";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@UrId", urId, DbType.String, 150)
							.ExecList<RolegameEO>(RolegameEO.GetItem, tm);
		}

		#endregion

		#region  按 RgAddTime（字段） 查询

		/// <summary>
		/// 按 RgAddTime（字段） 查询
		/// </summary>
		/// <param name = "rgAddTime"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolegameEO> GetByRgAddTime(DateTime? rgAddTime)
		{
			return GetByRgAddTime(rgAddTime, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 RgAddTime（字段） 查询
		/// </summary>
		/// <param name = "rgAddTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolegameEO> GetByRgAddTime(DateTime? rgAddTime, TransactionManager tm)
		{
			return GetByRgAddTime(rgAddTime, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 RgAddTime（字段） 查询
		/// </summary>
		/// <param name = "rgAddTime"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolegameEO> GetByRgAddTime(DateTime? rgAddTime, int top)
		{
			return GetByRgAddTime(rgAddTime, top, string.Empty, null);
		}

		/// <summary>
		/// 按 RgAddTime（字段） 查询
		/// </summary>
		/// <param name = "rgAddTime"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolegameEO> GetByRgAddTime(DateTime? rgAddTime, int top, TransactionManager tm)
		{
			return GetByRgAddTime(rgAddTime, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 RgAddTime（字段） 查询
		/// </summary>
		/// <param name = "rgAddTime"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolegameEO> GetByRgAddTime(DateTime? rgAddTime, string sort)
		{
			return GetByRgAddTime(rgAddTime, 0, sort, null);
		}

		/// <summary>
		/// 按 RgAddTime（字段） 查询
		/// </summary>
		/// <param name = "rgAddTime"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolegameEO> GetByRgAddTime(DateTime? rgAddTime, string sort, TransactionManager tm)
		{
			return GetByRgAddTime(rgAddTime, 0, sort, tm);
		}

		/// <summary>
		/// 按 RgAddTime（字段） 查询
		/// </summary>
		/// <param name = "rgAddTime"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolegameEO> GetByRgAddTime(DateTime? rgAddTime, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Rl_id, Gm_id, Ur_id, Rg_addTime, Rg_text1, Rg_text2 FROM rolegame WHERE Rg_addTime=@RgAddTime";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@RgAddTime", rgAddTime, DbType.Date, 0)
							.ExecList<RolegameEO>(RolegameEO.GetItem, tm);
		}

		#endregion

		#region  按 RgText1（字段） 查询

		/// <summary>
		/// 按 RgText1（字段） 查询
		/// </summary>
		/// <param name = "rgText1"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolegameEO> GetByRgText1(string rgText1)
		{
			return GetByRgText1(rgText1, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 RgText1（字段） 查询
		/// </summary>
		/// <param name = "rgText1"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolegameEO> GetByRgText1(string rgText1, TransactionManager tm)
		{
			return GetByRgText1(rgText1, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 RgText1（字段） 查询
		/// </summary>
		/// <param name = "rgText1"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolegameEO> GetByRgText1(string rgText1, int top)
		{
			return GetByRgText1(rgText1, top, string.Empty, null);
		}

		/// <summary>
		/// 按 RgText1（字段） 查询
		/// </summary>
		/// <param name = "rgText1"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolegameEO> GetByRgText1(string rgText1, int top, TransactionManager tm)
		{
			return GetByRgText1(rgText1, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 RgText1（字段） 查询
		/// </summary>
		/// <param name = "rgText1"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolegameEO> GetByRgText1(string rgText1, string sort)
		{
			return GetByRgText1(rgText1, 0, sort, null);
		}

		/// <summary>
		/// 按 RgText1（字段） 查询
		/// </summary>
		/// <param name = "rgText1"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolegameEO> GetByRgText1(string rgText1, string sort, TransactionManager tm)
		{
			return GetByRgText1(rgText1, 0, sort, tm);
		}

		/// <summary>
		/// 按 RgText1（字段） 查询
		/// </summary>
		/// <param name = "rgText1"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolegameEO> GetByRgText1(string rgText1, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Rl_id, Gm_id, Ur_id, Rg_addTime, Rg_text1, Rg_text2 FROM rolegame WHERE Rg_text1=@RgText1";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@RgText1", rgText1, DbType.String, 600)
							.ExecList<RolegameEO>(RolegameEO.GetItem, tm);
		}

		#endregion

		#region  按 RgText2（字段） 查询

		/// <summary>
		/// 按 RgText2（字段） 查询
		/// </summary>
		/// <param name = "rgText2"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolegameEO> GetByRgText2(string rgText2)
		{
			return GetByRgText2(rgText2, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 RgText2（字段） 查询
		/// </summary>
		/// <param name = "rgText2"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolegameEO> GetByRgText2(string rgText2, TransactionManager tm)
		{
			return GetByRgText2(rgText2, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 RgText2（字段） 查询
		/// </summary>
		/// <param name = "rgText2"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolegameEO> GetByRgText2(string rgText2, int top)
		{
			return GetByRgText2(rgText2, top, string.Empty, null);
		}

		/// <summary>
		/// 按 RgText2（字段） 查询
		/// </summary>
		/// <param name = "rgText2"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolegameEO> GetByRgText2(string rgText2, int top, TransactionManager tm)
		{
			return GetByRgText2(rgText2, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 RgText2（字段） 查询
		/// </summary>
		/// <param name = "rgText2"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolegameEO> GetByRgText2(string rgText2, string sort)
		{
			return GetByRgText2(rgText2, 0, sort, null);
		}

		/// <summary>
		/// 按 RgText2（字段） 查询
		/// </summary>
		/// <param name = "rgText2"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolegameEO> GetByRgText2(string rgText2, string sort, TransactionManager tm)
		{
			return GetByRgText2(rgText2, 0, sort, tm);
		}

		/// <summary>
		/// 按 RgText2（字段） 查询
		/// </summary>
		/// <param name = "rgText2"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolegameEO> GetByRgText2(string rgText2, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Rl_id, Gm_id, Ur_id, Rg_addTime, Rg_text1, Rg_text2 FROM rolegame WHERE Rg_text2=@RgText2";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@RgText2", rgText2, DbType.String, 600)
							.ExecList<RolegameEO>(RolegameEO.GetItem, tm);
		}

		#endregion

		#region  自定义条件查询

		/// <summary>
		/// 获取所有数据
		/// </summary>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolegameEO> GetAll(TransactionManager tm = null)
		{
			return GetTopSort(string.Empty, null, -1, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "values">where子句中定义的参数值集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolegameEO> Get(string where, params object[] values)
		{
			return GetTopSort(where, -1, string.Empty, null, values);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "paras">where子句中定义的参数集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolegameEO> Get(string where, IEnumerable<DbParameter> paras)
		{
			return GetTopSort(where, paras, -1, string.Empty, null);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolegameEO> Get(string where, TransactionManager tm)
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
		public virtual IEnumerable<RolegameEO> Get(string where, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<RolegameEO> Get(string where, IEnumerable<DbParameter> paras, TransactionManager tm)
		{
			return GetTopSort(where, paras, -1, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolegameEO> GetTop(string where, int top)
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
		public virtual IEnumerable<RolegameEO> GetTop(string where, int top, params object[] values)
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
		public virtual IEnumerable<RolegameEO> GetTop(string where, IEnumerable<DbParameter> paras, int top)
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
		public virtual IEnumerable<RolegameEO> GetTop(string where, int top, TransactionManager tm)
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
		public virtual IEnumerable<RolegameEO> GetTop(string where, int top, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<RolegameEO> GetTop(string where, IEnumerable<DbParameter> paras, int top, TransactionManager tm)
		{
			return GetTopSort(where, paras, top, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolegameEO> GetSort(string where, string sort)
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
		public virtual IEnumerable<RolegameEO> GetSort(string where, string sort, params object[] values)
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
		public virtual IEnumerable<RolegameEO> GetSort(string where, IEnumerable<DbParameter> paras, string sort)
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
		public virtual IEnumerable<RolegameEO> GetSort(string where, string sort, TransactionManager tm)
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
		public virtual IEnumerable<RolegameEO> GetSort(string where, string sort, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<RolegameEO> GetSort(string where, IEnumerable<DbParameter> paras, string sort, TransactionManager tm)
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
		public virtual IEnumerable<RolegameEO> GetTopSort(string where, int top, string sort)
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
		public virtual IEnumerable<RolegameEO> GetTopSort(string where, int top, string sort, params object[] values)
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
		public virtual IEnumerable<RolegameEO> GetTopSort(string where, IEnumerable<DbParameter> paras, int top, string sort)
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
		public virtual IEnumerable<RolegameEO> GetTopSort(string where, int top, string sort, TransactionManager tm)
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
		public virtual IEnumerable<RolegameEO> GetTopSort(string where, int top, string sort, TransactionManager tm, params object[] values)
		{
			const string format = @"SELECT {0} Rl_id, Gm_id, Ur_id, Rg_addTime, Rg_text1, Rg_text2 FROM rolegame";
			string sql = format;

			if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameters(values)
							.ExecList<RolegameEO>(RolegameEO.GetItem, tm);
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
		public virtual IEnumerable<RolegameEO> GetTopSort(string where, IEnumerable<DbParameter> paras, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Rl_id, Gm_id, Ur_id, Rg_addTime, Rg_text1, Rg_text2 FROM rolegame";
			string sql = format;

			if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddParameters(paras)
							.ExecList<RolegameEO>(RolegameEO.GetItem, tm);
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
			const string format = @"SELECT Rl_id, Gm_id, Ur_id, Rg_addTime, Rg_text1, Rg_text2 FROM rolegame {0} {1}";
			 string sql = string.Format(format, string.IsNullOrEmpty(where) ? string.Empty : "WHERE " + where, string.IsNullOrEmpty(sort) ? string.Empty : "ORDER BY " + sort);

			return Database.CreatePager(sql, pageSize, "Rl_id,Gm_id");
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
		public virtual List<RolegameEO> GetPageList(int pageIndex , int pageSize, string where = null, string sort = null, IEnumerable<DbParameter> paras = null)
		{
			var pager = GetPager(pageSize, where, sort);

			pager.AddParameters(paras);
			return pager.GetPageList<RolegameEO>(pageIndex);
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
		public virtual IEnumerable<RolegameEO> GetPageMutil(int pageIndex , int pageSize, string where = null, string sort = null, IEnumerable<DbParameter> paras = null)
		{
			var pager = GetPager(pageSize, where, sort);

			pager.AddParameters(paras);
			return pager.GetPageMutil<RolegameEO>(pageIndex);
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
		public virtual int Add(RolegameEO item, TransactionManager tm = null)
		{
			const string sql = @"INSERT INTO rolegame (Rl_id, Gm_id, Ur_id, Rg_addTime, Rg_text1, Rg_text2) VALUES (@Rl_id, @Gm_id, @Ur_id, @Rg_addTime, @Rg_text1, @Rg_text2) ";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Rl_id", item.RlId, DbType.String, 150)
							.AddInParameter("@Gm_id", item.GmId, DbType.String, 150)
							.AddInParameter("@Ur_id", item.UrId != null ?  (object)item.UrId : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Rg_addTime", item.RgAddTime.HasValue ? (object)item.RgAddTime.Value : DBNull.Value, DbType.Date, 0)
							.AddInParameter("@Rg_text1", item.RgText1 != null ?  (object)item.RgText1 : DBNull.Value, DbType.String, 600)
							.AddInParameter("@Rg_text2", item.RgText2 != null ?  (object)item.RgText2 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 插入一组数据
		/// </summary>
		/// <param name = "items">要插入的实体对象集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Add(IEnumerable<RolegameEO> items, TransactionManager tm = null)
		{
			int ret = 0;
			const string sql = @"INSERT INTO rolegame (Rl_id, Gm_id, Ur_id, Rg_addTime, Rg_text1, Rg_text2) VALUES (@Rl_id, @Gm_id, @Ur_id, @Rg_addTime, @Rg_text1, @Rg_text2) ";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@Rl_id", DbType.String, 150)
									.AddParameter("@Gm_id", DbType.String, 150)
									.AddParameter("@Ur_id", DbType.String, 150)
									.AddParameter("@Rg_addTime", DbType.Date, 0)
									.AddParameter("@Rg_text1", DbType.String, 600)
									.AddParameter("@Rg_text2", DbType.String, 600);

			foreach (RolegameEO item in items)
			{
				sqlDao
					.SetParameterValue("@Rl_id", item.RlId)
					.SetParameterValue("@Gm_id", item.GmId)
					.SetParameterValue("@Ur_id", item.UrId != null ?  (object)item.UrId : DBNull.Value)
					.SetParameterValue("@Rg_addTime", item.RgAddTime.HasValue ? (object)item.RgAddTime.Value : DBNull.Value)
					.SetParameterValue("@Rg_text1", item.RgText1 != null ?  (object)item.RgText1 : DBNull.Value)
					.SetParameterValue("@Rg_text2", item.RgText2 != null ?  (object)item.RgText2 : DBNull.Value)
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
		public virtual int Put(RolegameEO item, TransactionManager tm = null)
		{
			const string sql = @"UPDATE rolegame SET Rl_id=@Rl_id, Gm_id=@Gm_id, Ur_id=@Ur_id, Rg_addTime=@Rg_addTime, Rg_text1=@Rg_text1, Rg_text2=@Rg_text2 WHERE Rl_id=@OriginalRl_id and Gm_id=@OriginalGm_id";
			return Database.CreateSqlDao (sql)
							.AddInParameter("@OriginalRlId", (item.HasOriginal) ? item.OriginalRlId : item.RlId, DbType.String, 150)
							.AddInParameter("@OriginalGmId", (item.HasOriginal) ? item.OriginalGmId : item.GmId, DbType.String, 150)
							.AddInParameter("@Rl_id", item.RlId, DbType.String, 150)
							.AddInParameter("@Gm_id", item.GmId, DbType.String, 150)
							.AddInParameter("@Ur_id", item.UrId != null ?  (object)item.UrId : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Rg_addTime", item.RgAddTime.HasValue ? (object)item.RgAddTime.Value : DBNull.Value, DbType.Date, 0)
							.AddInParameter("@Rg_text1", item.RgText1 != null ?  (object)item.RgText1 : DBNull.Value, DbType.String, 600)
							.AddInParameter("@Rg_text2", item.RgText2 != null ?  (object)item.RgText2 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}


		/// <summary>
		/// 更新数据
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Put(IEnumerable<RolegameEO> items, TransactionManager tm = null)
		{

			int ret = 0;
			const string sql = @"UPDATE rolegame SET Rl_id=@Rl_id, Gm_id=@Gm_id, Ur_id=@Ur_id, Rg_addTime=@Rg_addTime, Rg_text1=@Rg_text1, Rg_text2=@Rg_text2 WHERE Rl_id=@OriginalRl_id and Gm_id=@OriginalGm_id";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@OriginalRlId", DbType.String, 150)
									.AddParameter("@OriginalGmId", DbType.String, 150)
									.AddParameter("@Rl_id", DbType.String, 150)
									.AddParameter("@Gm_id", DbType.String, 150)
									.AddParameter("@Ur_id", DbType.String, 150)
									.AddParameter("@Rg_addTime", DbType.Date, 0)
									.AddParameter("@Rg_text1", DbType.String, 600)
									.AddParameter("@Rg_text2", DbType.String, 600);

			foreach (RolegameEO item in items)
			{
				ret += sqlDao
							.SetParameterValue("@OriginalRlId", (item.HasOriginal) ? item.OriginalRlId : item.RlId)
							.SetParameterValue("@OriginalGmId", (item.HasOriginal) ? item.OriginalGmId : item.GmId)
							.SetParameterValue("@Rl_id", item.RlId)
							.SetParameterValue("@Gm_id", item.GmId)
							.SetParameterValue("@Ur_id", item.UrId != null ?  (object)item.UrId : DBNull.Value)
							.SetParameterValue("@Rg_addTime", item.RgAddTime.HasValue ? (object)item.RgAddTime.Value : DBNull.Value)
							.SetParameterValue("@Rg_text1", item.RgText1 != null ?  (object)item.RgText1 : DBNull.Value)
							.SetParameterValue("@Rg_text2", item.RgText2 != null ?  (object)item.RgText2 : DBNull.Value)
							.ExecNonQuery(tm);
			}
			return ret;
		}


		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "rlId"></param>
		/// <param name = "gmId"></param>
		/// <param name = "urId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutUrIdByPK(string rlId, string gmId, string urId, TransactionManager tm = null)
		{
			const string sql = @"UPDATE rolegame SET Ur_id = @Ur_id  WHERE Rl_id = @Rl_id and Gm_id = @Gm_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Rl_id", rlId, DbType.String, 150)
							.AddInParameter("@Gm_id", gmId, DbType.String, 150)
							.AddInParameter("@Ur_id", urId != null ?  (object)urId : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "rlId"></param>
		/// <param name = "gmId"></param>
		/// <param name = "rgAddTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutRgAddTimeByPK(string rlId, string gmId, DateTime? rgAddTime, TransactionManager tm = null)
		{
			const string sql = @"UPDATE rolegame SET Rg_addTime = @Rg_addTime  WHERE Rl_id = @Rl_id and Gm_id = @Gm_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Rl_id", rlId, DbType.String, 150)
							.AddInParameter("@Gm_id", gmId, DbType.String, 150)
							.AddInParameter("@Rg_addTime", rgAddTime.HasValue ? (object)rgAddTime.Value : DBNull.Value, DbType.Date, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "rlId"></param>
		/// <param name = "gmId"></param>
		/// <param name = "rgText1"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutRgText1ByPK(string rlId, string gmId, string rgText1, TransactionManager tm = null)
		{
			const string sql = @"UPDATE rolegame SET Rg_text1 = @Rg_text1  WHERE Rl_id = @Rl_id and Gm_id = @Gm_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Rl_id", rlId, DbType.String, 150)
							.AddInParameter("@Gm_id", gmId, DbType.String, 150)
							.AddInParameter("@Rg_text1", rgText1 != null ?  (object)rgText1 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "rlId"></param>
		/// <param name = "gmId"></param>
		/// <param name = "rgText2"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutRgText2ByPK(string rlId, string gmId, string rgText2, TransactionManager tm = null)
		{
			const string sql = @"UPDATE rolegame SET Rg_text2 = @Rg_text2  WHERE Rl_id = @Rl_id and Gm_id = @Gm_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Rl_id", rlId, DbType.String, 150)
							.AddInParameter("@Gm_id", gmId, DbType.String, 150)
							.AddInParameter("@Rg_text2", rgText2 != null ?  (object)rgText2 : DBNull.Value, DbType.String, 600)
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
			const string sql = @"UPDATE rolegame SET Ur_id=@Ur_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_id", urId != null ?  (object)urId : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "rgAddTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutRgAddTime(DateTime? rgAddTime, TransactionManager tm = null)
		{
			const string sql = @"UPDATE rolegame SET Rg_addTime=@Rg_addTime";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Rg_addTime", rgAddTime.HasValue ? (object)rgAddTime.Value : DBNull.Value, DbType.Date, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "rgText1"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutRgText1(string rgText1, TransactionManager tm = null)
		{
			const string sql = @"UPDATE rolegame SET Rg_text1=@Rg_text1";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Rg_text1", rgText1 != null ?  (object)rgText1 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "rgText2"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutRgText2(string rgText2, TransactionManager tm = null)
		{
			const string sql = @"UPDATE rolegame SET Rg_text2=@Rg_text2";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Rg_text2", rgText2 != null ?  (object)rgText2 : DBNull.Value, DbType.String, 600)
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
			const string format = @"UPDATE rolegame SET {0} {1}";
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
			const string format = @"UPDATE rolegame SET {0} {1}";
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
		/// <param name = "gmId"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByPK(string rlId, string gmId, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM rolegame WHERE Rl_id=@Rl_id and Gm_id=@Gm_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Rl_id", rlId, DbType.String, 150)
							.AddInParameter("@Gm_id", gmId, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Remove(RolegameEO item, TransactionManager tm = null)
		{
			return RemoveByPK(item.RlId, item.GmId, tm);
		}

		/// <summary>
		/// 删除指定实体集合对应的记录集
		/// </summary>
		/// <param name = "items">要删除的实体集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Remove(IEnumerable<RolegameEO> items, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM rolegame WHERE Rl_id=@OriginalRl_id and Gm_id=@OriginalGm_id";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@OriginalRlId", DbType.String, 150)
									.AddParameter("@OriginalGmId", DbType.String, 150);
			int ret = 0;
			foreach (RolegameEO item in items)
			{
				ret += sqlDao
							.SetParameterValue("@OriginalRlId", (item.HasOriginal) ? item.OriginalRlId : item.RlId)
							.SetParameterValue("@OriginalGmId", (item.HasOriginal) ? item.OriginalGmId : item.GmId)
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
			const string sql = @"DELETE FROM rolegame WHERE Ur_id=@Ur_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_id", urId != null ?  (object)urId : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "rgAddTime"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByRgAddTime(DateTime? rgAddTime, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM rolegame WHERE Rg_addTime=@Rg_addTime";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Rg_addTime", rgAddTime.HasValue ? (object)rgAddTime.Value : DBNull.Value, DbType.Date, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "rgText1"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByRgText1(string rgText1, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM rolegame WHERE Rg_text1=@Rg_text1";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Rg_text1", rgText1 != null ?  (object)rgText1 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "rgText2"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByRgText2(string rgText2, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM rolegame WHERE Rg_text2=@Rg_text2";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Rg_text2", rgText2 != null ?  (object)rgText2 : DBNull.Value, DbType.String, 600)
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
			const string format = @"DELETE FROM rolegame {0}";
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
			const string format = @"DELETE FROM rolegame {0}";
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
