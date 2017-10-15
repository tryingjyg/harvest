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
	/// 【表 channel 的实体类】
	/// </summary>
	[SerializableAttribute]
	public class ChannelEO : DataEntityBase, IRowMapper<ChannelEO>
	{
		protected string _originalCnId;

		/// <summary>
		/// 主键是否有原始值（即数据库中保存的值），用于实体对象更新时
		/// </summary>
		public bool HasOriginal { get; protected set; }

		/// <summary>
		/// 【主键 varchar】
		/// </summary>
		public virtual string CnId { get; set; }

		/// <summary>
		/// 【数据库中的原始主键值副本】
		/// </summary>
		public virtual string OriginalCnId
		{
			get { return _originalCnId; }
			set { HasOriginal = true; _originalCnId = value; }
		}

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string CnChannelId { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string CnName { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string CnDescription { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string UrId { get; set; }

		/// <summary>
		/// 【字段 date】
		/// </summary>
		public virtual DateTime? CnAddTime { get; set; }

		/// <summary>
		/// 【字段 char】
		/// </summary>
		public virtual string CnState { get; set; }

		/// <summary>
		/// 【字段 char】
		/// </summary>
		public virtual string CnDel { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string CnText1 { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string CnText2 { get; set; }

		/// <summary>
		/// 默认构造函数
		/// </summary>
		public ChannelEO() 
		{
			CnId = string.Empty;
		}

		/// <summary>
		/// 自定义构造函数
		/// </summary>
		/// <param name = "cnId"></param>
		/// <param name = "cnChannelId"></param>
		/// <param name = "cnName"></param>
		/// <param name = "cnDescription"></param>
		/// <param name = "urId"></param>
		/// <param name = "cnAddTime"></param>
		/// <param name = "cnState"></param>
		/// <param name = "cnDel"></param>
		/// <param name = "cnText1"></param>
		/// <param name = "cnText2"></param>
		public ChannelEO(string cnId, string cnChannelId, string cnName, string cnDescription, string urId, DateTime? cnAddTime, string cnState, string cnDel, string cnText1, string cnText2) 
		{
			CnId = cnId;
			CnChannelId = cnChannelId;
			CnName = cnName;
			CnDescription = cnDescription;
			UrId = urId;
			CnAddTime = cnAddTime;
			CnState = cnState;
			CnDel = cnDel;
			CnText1 = cnText1;
			CnText2 = cnText2;
		}

		/// <summary>
		/// 将结果集映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public ChannelEO MapRow(IDataReader reader)
		{
			return GetItem(reader);
		}

		/// <summary>
		/// 将结果集映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static ChannelEO GetItem(IDataReader reader)
		{
			ChannelEO ret = new ChannelEO();

			ret.CnId = (string)reader["Cn_id"];
			ret.OriginalCnId = ret.CnId;
			ret.CnChannelId = (reader["Cn_channelId"] is DBNull) ? null : (string)reader["Cn_channelId"];
			ret.CnName = (reader["Cn_name"] is DBNull) ? null : (string)reader["Cn_name"];
			ret.CnDescription = (reader["Cn_description"] is DBNull) ? null : (string)reader["Cn_description"];
			ret.UrId = (reader["Ur_id"] is DBNull) ? null : (string)reader["Ur_id"];
			ret.CnAddTime = (reader["Cn_addTime"] is DBNull) ? (DateTime?)null : DateTime.Parse(reader["Cn_addTime"].ToString());
			ret.CnState = (reader["Cn_state"] is DBNull) ? null : (string)reader["Cn_state"];
			ret.CnDel = (reader["Cn_Del"] is DBNull) ? null : (string)reader["Cn_Del"];
			ret.CnText1 = (reader["Cn_text1"] is DBNull) ? null : (string)reader["Cn_text1"];
			ret.CnText2 = (reader["Cn_text2"] is DBNull) ? null : (string)reader["Cn_text2"];
			return ret;
		}
	}


	#endregion

	#region  MO

	/// <summary>
	/// 【表 channel 的操作类】
	/// </summary>
    public partial class ChannelMO : DataManagerBase
	{

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "routeData">路由数据</param>
		public ChannelMO(object routeData = null) : base(routeData) { }

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">连接字符串名称</param>
		public ChannelMO(string connectionStringName) : base(connectionStringName) { }

		#region  Get方法集合

		/// <summary>
		/// 按 PK（主键） 查询
		/// </summary>
		/// <param name="tm">事务管理对象</param>
		/// <param name = "cnId"></param>
		/// <return></return>
		public virtual ChannelEO GetByPK(string cnId, TransactionManager tm = null)
		{
			const string sql = @"SELECT Cn_id, Cn_channelId, Cn_name, Cn_description, Ur_id, Cn_addTime, Cn_state, Cn_Del, Cn_text1, Cn_text2 FROM channel WHERE Cn_id=@Cn_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Cn_id", cnId, DbType.String, 150)
							.ExecSingle<ChannelEO>(ChannelEO.GetItem, tm);
		}




		#region  按 CnChannelId（字段） 查询

		/// <summary>
		/// 按 CnChannelId（字段） 查询
		/// </summary>
		/// <param name = "cnChannelId"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetByCnChannelId(string cnChannelId)
		{
			return GetByCnChannelId(cnChannelId, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 CnChannelId（字段） 查询
		/// </summary>
		/// <param name = "cnChannelId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetByCnChannelId(string cnChannelId, TransactionManager tm)
		{
			return GetByCnChannelId(cnChannelId, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 CnChannelId（字段） 查询
		/// </summary>
		/// <param name = "cnChannelId"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetByCnChannelId(string cnChannelId, int top)
		{
			return GetByCnChannelId(cnChannelId, top, string.Empty, null);
		}

		/// <summary>
		/// 按 CnChannelId（字段） 查询
		/// </summary>
		/// <param name = "cnChannelId"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetByCnChannelId(string cnChannelId, int top, TransactionManager tm)
		{
			return GetByCnChannelId(cnChannelId, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 CnChannelId（字段） 查询
		/// </summary>
		/// <param name = "cnChannelId"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetByCnChannelId(string cnChannelId, string sort)
		{
			return GetByCnChannelId(cnChannelId, 0, sort, null);
		}

		/// <summary>
		/// 按 CnChannelId（字段） 查询
		/// </summary>
		/// <param name = "cnChannelId"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetByCnChannelId(string cnChannelId, string sort, TransactionManager tm)
		{
			return GetByCnChannelId(cnChannelId, 0, sort, tm);
		}

		/// <summary>
		/// 按 CnChannelId（字段） 查询
		/// </summary>
		/// <param name = "cnChannelId"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetByCnChannelId(string cnChannelId, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Cn_id, Cn_channelId, Cn_name, Cn_description, Ur_id, Cn_addTime, Cn_state, Cn_Del, Cn_text1, Cn_text2 FROM channel WHERE Cn_channelId=@CnChannelId";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@CnChannelId", cnChannelId, DbType.String, 150)
							.ExecList<ChannelEO>(ChannelEO.GetItem, tm);
		}

		#endregion

		#region  按 CnName（字段） 查询

		/// <summary>
		/// 按 CnName（字段） 查询
		/// </summary>
		/// <param name = "cnName"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetByCnName(string cnName)
		{
			return GetByCnName(cnName, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 CnName（字段） 查询
		/// </summary>
		/// <param name = "cnName"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetByCnName(string cnName, TransactionManager tm)
		{
			return GetByCnName(cnName, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 CnName（字段） 查询
		/// </summary>
		/// <param name = "cnName"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetByCnName(string cnName, int top)
		{
			return GetByCnName(cnName, top, string.Empty, null);
		}

		/// <summary>
		/// 按 CnName（字段） 查询
		/// </summary>
		/// <param name = "cnName"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetByCnName(string cnName, int top, TransactionManager tm)
		{
			return GetByCnName(cnName, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 CnName（字段） 查询
		/// </summary>
		/// <param name = "cnName"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetByCnName(string cnName, string sort)
		{
			return GetByCnName(cnName, 0, sort, null);
		}

		/// <summary>
		/// 按 CnName（字段） 查询
		/// </summary>
		/// <param name = "cnName"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetByCnName(string cnName, string sort, TransactionManager tm)
		{
			return GetByCnName(cnName, 0, sort, tm);
		}

		/// <summary>
		/// 按 CnName（字段） 查询
		/// </summary>
		/// <param name = "cnName"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetByCnName(string cnName, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Cn_id, Cn_channelId, Cn_name, Cn_description, Ur_id, Cn_addTime, Cn_state, Cn_Del, Cn_text1, Cn_text2 FROM channel WHERE Cn_name=@CnName";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@CnName", cnName, DbType.String, 150)
							.ExecList<ChannelEO>(ChannelEO.GetItem, tm);
		}

		#endregion

		#region  按 CnDescription（字段） 查询

		/// <summary>
		/// 按 CnDescription（字段） 查询
		/// </summary>
		/// <param name = "cnDescription"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetByCnDescription(string cnDescription)
		{
			return GetByCnDescription(cnDescription, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 CnDescription（字段） 查询
		/// </summary>
		/// <param name = "cnDescription"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetByCnDescription(string cnDescription, TransactionManager tm)
		{
			return GetByCnDescription(cnDescription, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 CnDescription（字段） 查询
		/// </summary>
		/// <param name = "cnDescription"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetByCnDescription(string cnDescription, int top)
		{
			return GetByCnDescription(cnDescription, top, string.Empty, null);
		}

		/// <summary>
		/// 按 CnDescription（字段） 查询
		/// </summary>
		/// <param name = "cnDescription"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetByCnDescription(string cnDescription, int top, TransactionManager tm)
		{
			return GetByCnDescription(cnDescription, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 CnDescription（字段） 查询
		/// </summary>
		/// <param name = "cnDescription"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetByCnDescription(string cnDescription, string sort)
		{
			return GetByCnDescription(cnDescription, 0, sort, null);
		}

		/// <summary>
		/// 按 CnDescription（字段） 查询
		/// </summary>
		/// <param name = "cnDescription"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetByCnDescription(string cnDescription, string sort, TransactionManager tm)
		{
			return GetByCnDescription(cnDescription, 0, sort, tm);
		}

		/// <summary>
		/// 按 CnDescription（字段） 查询
		/// </summary>
		/// <param name = "cnDescription"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetByCnDescription(string cnDescription, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Cn_id, Cn_channelId, Cn_name, Cn_description, Ur_id, Cn_addTime, Cn_state, Cn_Del, Cn_text1, Cn_text2 FROM channel WHERE Cn_description=@CnDescription";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@CnDescription", cnDescription, DbType.String, 6000)
							.ExecList<ChannelEO>(ChannelEO.GetItem, tm);
		}

		#endregion

		#region  按 UrId（字段） 查询

		/// <summary>
		/// 按 UrId（字段） 查询
		/// </summary>
		/// <param name = "urId"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetByUrId(string urId)
		{
			return GetByUrId(urId, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 UrId（字段） 查询
		/// </summary>
		/// <param name = "urId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetByUrId(string urId, TransactionManager tm)
		{
			return GetByUrId(urId, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 UrId（字段） 查询
		/// </summary>
		/// <param name = "urId"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetByUrId(string urId, int top)
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
		public virtual IEnumerable<ChannelEO> GetByUrId(string urId, int top, TransactionManager tm)
		{
			return GetByUrId(urId, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 UrId（字段） 查询
		/// </summary>
		/// <param name = "urId"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetByUrId(string urId, string sort)
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
		public virtual IEnumerable<ChannelEO> GetByUrId(string urId, string sort, TransactionManager tm)
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
		public virtual IEnumerable<ChannelEO> GetByUrId(string urId, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Cn_id, Cn_channelId, Cn_name, Cn_description, Ur_id, Cn_addTime, Cn_state, Cn_Del, Cn_text1, Cn_text2 FROM channel WHERE Ur_id=@UrId";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@UrId", urId, DbType.String, 150)
							.ExecList<ChannelEO>(ChannelEO.GetItem, tm);
		}

		#endregion

		#region  按 CnAddTime（字段） 查询

		/// <summary>
		/// 按 CnAddTime（字段） 查询
		/// </summary>
		/// <param name = "cnAddTime"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetByCnAddTime(DateTime? cnAddTime)
		{
			return GetByCnAddTime(cnAddTime, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 CnAddTime（字段） 查询
		/// </summary>
		/// <param name = "cnAddTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetByCnAddTime(DateTime? cnAddTime, TransactionManager tm)
		{
			return GetByCnAddTime(cnAddTime, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 CnAddTime（字段） 查询
		/// </summary>
		/// <param name = "cnAddTime"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetByCnAddTime(DateTime? cnAddTime, int top)
		{
			return GetByCnAddTime(cnAddTime, top, string.Empty, null);
		}

		/// <summary>
		/// 按 CnAddTime（字段） 查询
		/// </summary>
		/// <param name = "cnAddTime"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetByCnAddTime(DateTime? cnAddTime, int top, TransactionManager tm)
		{
			return GetByCnAddTime(cnAddTime, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 CnAddTime（字段） 查询
		/// </summary>
		/// <param name = "cnAddTime"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetByCnAddTime(DateTime? cnAddTime, string sort)
		{
			return GetByCnAddTime(cnAddTime, 0, sort, null);
		}

		/// <summary>
		/// 按 CnAddTime（字段） 查询
		/// </summary>
		/// <param name = "cnAddTime"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetByCnAddTime(DateTime? cnAddTime, string sort, TransactionManager tm)
		{
			return GetByCnAddTime(cnAddTime, 0, sort, tm);
		}

		/// <summary>
		/// 按 CnAddTime（字段） 查询
		/// </summary>
		/// <param name = "cnAddTime"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetByCnAddTime(DateTime? cnAddTime, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Cn_id, Cn_channelId, Cn_name, Cn_description, Ur_id, Cn_addTime, Cn_state, Cn_Del, Cn_text1, Cn_text2 FROM channel WHERE Cn_addTime=@CnAddTime";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@CnAddTime", cnAddTime, DbType.Date, 0)
							.ExecList<ChannelEO>(ChannelEO.GetItem, tm);
		}

		#endregion

		#region  按 CnState（字段） 查询

		/// <summary>
		/// 按 CnState（字段） 查询
		/// </summary>
		/// <param name = "cnState"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetByCnState(string cnState)
		{
			return GetByCnState(cnState, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 CnState（字段） 查询
		/// </summary>
		/// <param name = "cnState"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetByCnState(string cnState, TransactionManager tm)
		{
			return GetByCnState(cnState, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 CnState（字段） 查询
		/// </summary>
		/// <param name = "cnState"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetByCnState(string cnState, int top)
		{
			return GetByCnState(cnState, top, string.Empty, null);
		}

		/// <summary>
		/// 按 CnState（字段） 查询
		/// </summary>
		/// <param name = "cnState"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetByCnState(string cnState, int top, TransactionManager tm)
		{
			return GetByCnState(cnState, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 CnState（字段） 查询
		/// </summary>
		/// <param name = "cnState"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetByCnState(string cnState, string sort)
		{
			return GetByCnState(cnState, 0, sort, null);
		}

		/// <summary>
		/// 按 CnState（字段） 查询
		/// </summary>
		/// <param name = "cnState"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetByCnState(string cnState, string sort, TransactionManager tm)
		{
			return GetByCnState(cnState, 0, sort, tm);
		}

		/// <summary>
		/// 按 CnState（字段） 查询
		/// </summary>
		/// <param name = "cnState"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetByCnState(string cnState, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Cn_id, Cn_channelId, Cn_name, Cn_description, Ur_id, Cn_addTime, Cn_state, Cn_Del, Cn_text1, Cn_text2 FROM channel WHERE Cn_state=@CnState";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@CnState", cnState, DbType.String, 3)
							.ExecList<ChannelEO>(ChannelEO.GetItem, tm);
		}

		#endregion

		#region  按 CnDel（字段） 查询

		/// <summary>
		/// 按 CnDel（字段） 查询
		/// </summary>
		/// <param name = "cnDel"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetByCnDel(string cnDel)
		{
			return GetByCnDel(cnDel, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 CnDel（字段） 查询
		/// </summary>
		/// <param name = "cnDel"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetByCnDel(string cnDel, TransactionManager tm)
		{
			return GetByCnDel(cnDel, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 CnDel（字段） 查询
		/// </summary>
		/// <param name = "cnDel"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetByCnDel(string cnDel, int top)
		{
			return GetByCnDel(cnDel, top, string.Empty, null);
		}

		/// <summary>
		/// 按 CnDel（字段） 查询
		/// </summary>
		/// <param name = "cnDel"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetByCnDel(string cnDel, int top, TransactionManager tm)
		{
			return GetByCnDel(cnDel, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 CnDel（字段） 查询
		/// </summary>
		/// <param name = "cnDel"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetByCnDel(string cnDel, string sort)
		{
			return GetByCnDel(cnDel, 0, sort, null);
		}

		/// <summary>
		/// 按 CnDel（字段） 查询
		/// </summary>
		/// <param name = "cnDel"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetByCnDel(string cnDel, string sort, TransactionManager tm)
		{
			return GetByCnDel(cnDel, 0, sort, tm);
		}

		/// <summary>
		/// 按 CnDel（字段） 查询
		/// </summary>
		/// <param name = "cnDel"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetByCnDel(string cnDel, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Cn_id, Cn_channelId, Cn_name, Cn_description, Ur_id, Cn_addTime, Cn_state, Cn_Del, Cn_text1, Cn_text2 FROM channel WHERE Cn_Del=@CnDel";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@CnDel", cnDel, DbType.String, 3)
							.ExecList<ChannelEO>(ChannelEO.GetItem, tm);
		}

		#endregion

		#region  按 CnText1（字段） 查询

		/// <summary>
		/// 按 CnText1（字段） 查询
		/// </summary>
		/// <param name = "cnText1"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetByCnText1(string cnText1)
		{
			return GetByCnText1(cnText1, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 CnText1（字段） 查询
		/// </summary>
		/// <param name = "cnText1"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetByCnText1(string cnText1, TransactionManager tm)
		{
			return GetByCnText1(cnText1, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 CnText1（字段） 查询
		/// </summary>
		/// <param name = "cnText1"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetByCnText1(string cnText1, int top)
		{
			return GetByCnText1(cnText1, top, string.Empty, null);
		}

		/// <summary>
		/// 按 CnText1（字段） 查询
		/// </summary>
		/// <param name = "cnText1"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetByCnText1(string cnText1, int top, TransactionManager tm)
		{
			return GetByCnText1(cnText1, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 CnText1（字段） 查询
		/// </summary>
		/// <param name = "cnText1"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetByCnText1(string cnText1, string sort)
		{
			return GetByCnText1(cnText1, 0, sort, null);
		}

		/// <summary>
		/// 按 CnText1（字段） 查询
		/// </summary>
		/// <param name = "cnText1"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetByCnText1(string cnText1, string sort, TransactionManager tm)
		{
			return GetByCnText1(cnText1, 0, sort, tm);
		}

		/// <summary>
		/// 按 CnText1（字段） 查询
		/// </summary>
		/// <param name = "cnText1"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetByCnText1(string cnText1, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Cn_id, Cn_channelId, Cn_name, Cn_description, Ur_id, Cn_addTime, Cn_state, Cn_Del, Cn_text1, Cn_text2 FROM channel WHERE Cn_text1=@CnText1";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@CnText1", cnText1, DbType.String, 600)
							.ExecList<ChannelEO>(ChannelEO.GetItem, tm);
		}

		#endregion

		#region  按 CnText2（字段） 查询

		/// <summary>
		/// 按 CnText2（字段） 查询
		/// </summary>
		/// <param name = "cnText2"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetByCnText2(string cnText2)
		{
			return GetByCnText2(cnText2, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 CnText2（字段） 查询
		/// </summary>
		/// <param name = "cnText2"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetByCnText2(string cnText2, TransactionManager tm)
		{
			return GetByCnText2(cnText2, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 CnText2（字段） 查询
		/// </summary>
		/// <param name = "cnText2"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetByCnText2(string cnText2, int top)
		{
			return GetByCnText2(cnText2, top, string.Empty, null);
		}

		/// <summary>
		/// 按 CnText2（字段） 查询
		/// </summary>
		/// <param name = "cnText2"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetByCnText2(string cnText2, int top, TransactionManager tm)
		{
			return GetByCnText2(cnText2, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 CnText2（字段） 查询
		/// </summary>
		/// <param name = "cnText2"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetByCnText2(string cnText2, string sort)
		{
			return GetByCnText2(cnText2, 0, sort, null);
		}

		/// <summary>
		/// 按 CnText2（字段） 查询
		/// </summary>
		/// <param name = "cnText2"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetByCnText2(string cnText2, string sort, TransactionManager tm)
		{
			return GetByCnText2(cnText2, 0, sort, tm);
		}

		/// <summary>
		/// 按 CnText2（字段） 查询
		/// </summary>
		/// <param name = "cnText2"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetByCnText2(string cnText2, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Cn_id, Cn_channelId, Cn_name, Cn_description, Ur_id, Cn_addTime, Cn_state, Cn_Del, Cn_text1, Cn_text2 FROM channel WHERE Cn_text2=@CnText2";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@CnText2", cnText2, DbType.String, 600)
							.ExecList<ChannelEO>(ChannelEO.GetItem, tm);
		}

		#endregion

		#region  自定义条件查询

		/// <summary>
		/// 获取所有数据
		/// </summary>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetAll(TransactionManager tm = null)
		{
			return GetTopSort(string.Empty, null, -1, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "values">where子句中定义的参数值集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> Get(string where, params object[] values)
		{
			return GetTopSort(where, -1, string.Empty, null, values);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "paras">where子句中定义的参数集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> Get(string where, IEnumerable<DbParameter> paras)
		{
			return GetTopSort(where, paras, -1, string.Empty, null);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> Get(string where, TransactionManager tm)
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
		public virtual IEnumerable<ChannelEO> Get(string where, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<ChannelEO> Get(string where, IEnumerable<DbParameter> paras, TransactionManager tm)
		{
			return GetTopSort(where, paras, -1, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetTop(string where, int top)
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
		public virtual IEnumerable<ChannelEO> GetTop(string where, int top, params object[] values)
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
		public virtual IEnumerable<ChannelEO> GetTop(string where, IEnumerable<DbParameter> paras, int top)
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
		public virtual IEnumerable<ChannelEO> GetTop(string where, int top, TransactionManager tm)
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
		public virtual IEnumerable<ChannelEO> GetTop(string where, int top, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<ChannelEO> GetTop(string where, IEnumerable<DbParameter> paras, int top, TransactionManager tm)
		{
			return GetTopSort(where, paras, top, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ChannelEO> GetSort(string where, string sort)
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
		public virtual IEnumerable<ChannelEO> GetSort(string where, string sort, params object[] values)
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
		public virtual IEnumerable<ChannelEO> GetSort(string where, IEnumerable<DbParameter> paras, string sort)
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
		public virtual IEnumerable<ChannelEO> GetSort(string where, string sort, TransactionManager tm)
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
		public virtual IEnumerable<ChannelEO> GetSort(string where, string sort, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<ChannelEO> GetSort(string where, IEnumerable<DbParameter> paras, string sort, TransactionManager tm)
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
		public virtual IEnumerable<ChannelEO> GetTopSort(string where, int top, string sort)
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
		public virtual IEnumerable<ChannelEO> GetTopSort(string where, int top, string sort, params object[] values)
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
		public virtual IEnumerable<ChannelEO> GetTopSort(string where, IEnumerable<DbParameter> paras, int top, string sort)
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
		public virtual IEnumerable<ChannelEO> GetTopSort(string where, int top, string sort, TransactionManager tm)
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
		public virtual IEnumerable<ChannelEO> GetTopSort(string where, int top, string sort, TransactionManager tm, params object[] values)
		{
			const string format = @"SELECT {0} Cn_id, Cn_channelId, Cn_name, Cn_description, Ur_id, Cn_addTime, Cn_state, Cn_Del, Cn_text1, Cn_text2 FROM channel";
			string sql = format;

			if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameters(values)
							.ExecList<ChannelEO>(ChannelEO.GetItem, tm);
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
		public virtual IEnumerable<ChannelEO> GetTopSort(string where, IEnumerable<DbParameter> paras, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Cn_id, Cn_channelId, Cn_name, Cn_description, Ur_id, Cn_addTime, Cn_state, Cn_Del, Cn_text1, Cn_text2 FROM channel";
			string sql = format;

			if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddParameters(paras)
							.ExecList<ChannelEO>(ChannelEO.GetItem, tm);
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
			const string format = @"SELECT Cn_id, Cn_channelId, Cn_name, Cn_description, Ur_id, Cn_addTime, Cn_state, Cn_Del, Cn_text1, Cn_text2 FROM channel {0} {1}";
			 string sql = string.Format(format, string.IsNullOrEmpty(where) ? string.Empty : "WHERE " + where, string.IsNullOrEmpty(sort) ? string.Empty : "ORDER BY " + sort);

			return Database.CreatePager(sql, pageSize, "Cn_id");
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
		public virtual List<ChannelEO> GetPageList(int pageIndex , int pageSize, string where = null, string sort = null, IEnumerable<DbParameter> paras = null)
		{
			var pager = GetPager(pageSize, where, sort);

			pager.AddParameters(paras);
			return pager.GetPageList<ChannelEO>(pageIndex);
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
		public virtual IEnumerable<ChannelEO> GetPageMutil(int pageIndex , int pageSize, string where = null, string sort = null, IEnumerable<DbParameter> paras = null)
		{
			var pager = GetPager(pageSize, where, sort);

			pager.AddParameters(paras);
			return pager.GetPageMutil<ChannelEO>(pageIndex);
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
		public virtual int Add(ChannelEO item, TransactionManager tm = null)
		{
			const string sql = @"INSERT INTO channel (Cn_id, Cn_channelId, Cn_name, Cn_description, Ur_id, Cn_addTime, Cn_state, Cn_Del, Cn_text1, Cn_text2) VALUES (@Cn_id, @Cn_channelId, @Cn_name, @Cn_description, @Ur_id, @Cn_addTime, @Cn_state, @Cn_Del, @Cn_text1, @Cn_text2) ";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Cn_id", item.CnId, DbType.String, 150)
							.AddInParameter("@Cn_channelId", item.CnChannelId != null ?  (object)item.CnChannelId : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Cn_name", item.CnName != null ?  (object)item.CnName : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Cn_description", item.CnDescription != null ?  (object)item.CnDescription : DBNull.Value, DbType.String, 6000)
							.AddInParameter("@Ur_id", item.UrId != null ?  (object)item.UrId : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Cn_addTime", item.CnAddTime.HasValue ? (object)item.CnAddTime.Value : DBNull.Value, DbType.Date, 0)
							.AddInParameter("@Cn_state", item.CnState != null ?  (object)item.CnState : DBNull.Value, DbType.String, 3)
							.AddInParameter("@Cn_Del", item.CnDel != null ?  (object)item.CnDel : DBNull.Value, DbType.String, 3)
							.AddInParameter("@Cn_text1", item.CnText1 != null ?  (object)item.CnText1 : DBNull.Value, DbType.String, 600)
							.AddInParameter("@Cn_text2", item.CnText2 != null ?  (object)item.CnText2 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 插入一组数据
		/// </summary>
		/// <param name = "items">要插入的实体对象集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Add(IEnumerable<ChannelEO> items, TransactionManager tm = null)
		{
			int ret = 0;
			const string sql = @"INSERT INTO channel (Cn_id, Cn_channelId, Cn_name, Cn_description, Ur_id, Cn_addTime, Cn_state, Cn_Del, Cn_text1, Cn_text2) VALUES (@Cn_id, @Cn_channelId, @Cn_name, @Cn_description, @Ur_id, @Cn_addTime, @Cn_state, @Cn_Del, @Cn_text1, @Cn_text2) ";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@Cn_id", DbType.String, 150)
									.AddParameter("@Cn_channelId", DbType.String, 150)
									.AddParameter("@Cn_name", DbType.String, 150)
									.AddParameter("@Cn_description", DbType.String, 6000)
									.AddParameter("@Ur_id", DbType.String, 150)
									.AddParameter("@Cn_addTime", DbType.Date, 0)
									.AddParameter("@Cn_state", DbType.String, 3)
									.AddParameter("@Cn_Del", DbType.String, 3)
									.AddParameter("@Cn_text1", DbType.String, 600)
									.AddParameter("@Cn_text2", DbType.String, 600);

			foreach (ChannelEO item in items)
			{
				sqlDao
					.SetParameterValue("@Cn_id", item.CnId)
					.SetParameterValue("@Cn_channelId", item.CnChannelId != null ?  (object)item.CnChannelId : DBNull.Value)
					.SetParameterValue("@Cn_name", item.CnName != null ?  (object)item.CnName : DBNull.Value)
					.SetParameterValue("@Cn_description", item.CnDescription != null ?  (object)item.CnDescription : DBNull.Value)
					.SetParameterValue("@Ur_id", item.UrId != null ?  (object)item.UrId : DBNull.Value)
					.SetParameterValue("@Cn_addTime", item.CnAddTime.HasValue ? (object)item.CnAddTime.Value : DBNull.Value)
					.SetParameterValue("@Cn_state", item.CnState != null ?  (object)item.CnState : DBNull.Value)
					.SetParameterValue("@Cn_Del", item.CnDel != null ?  (object)item.CnDel : DBNull.Value)
					.SetParameterValue("@Cn_text1", item.CnText1 != null ?  (object)item.CnText1 : DBNull.Value)
					.SetParameterValue("@Cn_text2", item.CnText2 != null ?  (object)item.CnText2 : DBNull.Value)
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
		public virtual int Put(ChannelEO item, TransactionManager tm = null)
		{
			const string sql = @"UPDATE channel SET Cn_id=@Cn_id, Cn_channelId=@Cn_channelId, Cn_name=@Cn_name, Cn_description=@Cn_description, Ur_id=@Ur_id, Cn_addTime=@Cn_addTime, Cn_state=@Cn_state, Cn_Del=@Cn_Del, Cn_text1=@Cn_text1, Cn_text2=@Cn_text2 WHERE Cn_id=@OriginalCn_id";
			return Database.CreateSqlDao (sql)
							.AddInParameter("@OriginalCnId", (item.HasOriginal) ? item.OriginalCnId : item.CnId, DbType.String, 150)
							.AddInParameter("@Cn_id", item.CnId, DbType.String, 150)
							.AddInParameter("@Cn_channelId", item.CnChannelId != null ?  (object)item.CnChannelId : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Cn_name", item.CnName != null ?  (object)item.CnName : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Cn_description", item.CnDescription != null ?  (object)item.CnDescription : DBNull.Value, DbType.String, 6000)
							.AddInParameter("@Ur_id", item.UrId != null ?  (object)item.UrId : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Cn_addTime", item.CnAddTime.HasValue ? (object)item.CnAddTime.Value : DBNull.Value, DbType.Date, 0)
							.AddInParameter("@Cn_state", item.CnState != null ?  (object)item.CnState : DBNull.Value, DbType.String, 3)
							.AddInParameter("@Cn_Del", item.CnDel != null ?  (object)item.CnDel : DBNull.Value, DbType.String, 3)
							.AddInParameter("@Cn_text1", item.CnText1 != null ?  (object)item.CnText1 : DBNull.Value, DbType.String, 600)
							.AddInParameter("@Cn_text2", item.CnText2 != null ?  (object)item.CnText2 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}


		/// <summary>
		/// 更新数据
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Put(IEnumerable<ChannelEO> items, TransactionManager tm = null)
		{

			int ret = 0;
			const string sql = @"UPDATE channel SET Cn_id=@Cn_id, Cn_channelId=@Cn_channelId, Cn_name=@Cn_name, Cn_description=@Cn_description, Ur_id=@Ur_id, Cn_addTime=@Cn_addTime, Cn_state=@Cn_state, Cn_Del=@Cn_Del, Cn_text1=@Cn_text1, Cn_text2=@Cn_text2 WHERE Cn_id=@OriginalCn_id";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@OriginalCnId", DbType.String, 150)
									.AddParameter("@Cn_id", DbType.String, 150)
									.AddParameter("@Cn_channelId", DbType.String, 150)
									.AddParameter("@Cn_name", DbType.String, 150)
									.AddParameter("@Cn_description", DbType.String, 6000)
									.AddParameter("@Ur_id", DbType.String, 150)
									.AddParameter("@Cn_addTime", DbType.Date, 0)
									.AddParameter("@Cn_state", DbType.String, 3)
									.AddParameter("@Cn_Del", DbType.String, 3)
									.AddParameter("@Cn_text1", DbType.String, 600)
									.AddParameter("@Cn_text2", DbType.String, 600);

			foreach (ChannelEO item in items)
			{
				ret += sqlDao
							.SetParameterValue("@OriginalCnId", (item.HasOriginal) ? item.OriginalCnId : item.CnId)
							.SetParameterValue("@Cn_id", item.CnId)
							.SetParameterValue("@Cn_channelId", item.CnChannelId != null ?  (object)item.CnChannelId : DBNull.Value)
							.SetParameterValue("@Cn_name", item.CnName != null ?  (object)item.CnName : DBNull.Value)
							.SetParameterValue("@Cn_description", item.CnDescription != null ?  (object)item.CnDescription : DBNull.Value)
							.SetParameterValue("@Ur_id", item.UrId != null ?  (object)item.UrId : DBNull.Value)
							.SetParameterValue("@Cn_addTime", item.CnAddTime.HasValue ? (object)item.CnAddTime.Value : DBNull.Value)
							.SetParameterValue("@Cn_state", item.CnState != null ?  (object)item.CnState : DBNull.Value)
							.SetParameterValue("@Cn_Del", item.CnDel != null ?  (object)item.CnDel : DBNull.Value)
							.SetParameterValue("@Cn_text1", item.CnText1 != null ?  (object)item.CnText1 : DBNull.Value)
							.SetParameterValue("@Cn_text2", item.CnText2 != null ?  (object)item.CnText2 : DBNull.Value)
							.ExecNonQuery(tm);
			}
			return ret;
		}


		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "cnId"></param>
		/// <param name = "cnChannelId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutCnChannelIdByPK(string cnId, string cnChannelId, TransactionManager tm = null)
		{
			const string sql = @"UPDATE channel SET Cn_channelId = @Cn_channelId  WHERE Cn_id = @Cn_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Cn_id", cnId, DbType.String, 150)
							.AddInParameter("@Cn_channelId", cnChannelId != null ?  (object)cnChannelId : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "cnId"></param>
		/// <param name = "cnName"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutCnNameByPK(string cnId, string cnName, TransactionManager tm = null)
		{
			const string sql = @"UPDATE channel SET Cn_name = @Cn_name  WHERE Cn_id = @Cn_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Cn_id", cnId, DbType.String, 150)
							.AddInParameter("@Cn_name", cnName != null ?  (object)cnName : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "cnId"></param>
		/// <param name = "cnDescription"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutCnDescriptionByPK(string cnId, string cnDescription, TransactionManager tm = null)
		{
			const string sql = @"UPDATE channel SET Cn_description = @Cn_description  WHERE Cn_id = @Cn_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Cn_id", cnId, DbType.String, 150)
							.AddInParameter("@Cn_description", cnDescription != null ?  (object)cnDescription : DBNull.Value, DbType.String, 6000)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "cnId"></param>
		/// <param name = "urId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutUrIdByPK(string cnId, string urId, TransactionManager tm = null)
		{
			const string sql = @"UPDATE channel SET Ur_id = @Ur_id  WHERE Cn_id = @Cn_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Cn_id", cnId, DbType.String, 150)
							.AddInParameter("@Ur_id", urId != null ?  (object)urId : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "cnId"></param>
		/// <param name = "cnAddTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutCnAddTimeByPK(string cnId, DateTime? cnAddTime, TransactionManager tm = null)
		{
			const string sql = @"UPDATE channel SET Cn_addTime = @Cn_addTime  WHERE Cn_id = @Cn_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Cn_id", cnId, DbType.String, 150)
							.AddInParameter("@Cn_addTime", cnAddTime.HasValue ? (object)cnAddTime.Value : DBNull.Value, DbType.Date, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "cnId"></param>
		/// <param name = "cnState"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutCnStateByPK(string cnId, string cnState, TransactionManager tm = null)
		{
			const string sql = @"UPDATE channel SET Cn_state = @Cn_state  WHERE Cn_id = @Cn_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Cn_id", cnId, DbType.String, 150)
							.AddInParameter("@Cn_state", cnState != null ?  (object)cnState : DBNull.Value, DbType.String, 3)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "cnId"></param>
		/// <param name = "cnDel"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutCnDelByPK(string cnId, string cnDel, TransactionManager tm = null)
		{
			const string sql = @"UPDATE channel SET Cn_Del = @Cn_Del  WHERE Cn_id = @Cn_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Cn_id", cnId, DbType.String, 150)
							.AddInParameter("@Cn_Del", cnDel != null ?  (object)cnDel : DBNull.Value, DbType.String, 3)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "cnId"></param>
		/// <param name = "cnText1"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutCnText1ByPK(string cnId, string cnText1, TransactionManager tm = null)
		{
			const string sql = @"UPDATE channel SET Cn_text1 = @Cn_text1  WHERE Cn_id = @Cn_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Cn_id", cnId, DbType.String, 150)
							.AddInParameter("@Cn_text1", cnText1 != null ?  (object)cnText1 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "cnId"></param>
		/// <param name = "cnText2"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutCnText2ByPK(string cnId, string cnText2, TransactionManager tm = null)
		{
			const string sql = @"UPDATE channel SET Cn_text2 = @Cn_text2  WHERE Cn_id = @Cn_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Cn_id", cnId, DbType.String, 150)
							.AddInParameter("@Cn_text2", cnText2 != null ?  (object)cnText2 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}


		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "cnChannelId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutCnChannelId(string cnChannelId, TransactionManager tm = null)
		{
			const string sql = @"UPDATE channel SET Cn_channelId=@Cn_channelId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Cn_channelId", cnChannelId != null ?  (object)cnChannelId : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "cnName"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutCnName(string cnName, TransactionManager tm = null)
		{
			const string sql = @"UPDATE channel SET Cn_name=@Cn_name";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Cn_name", cnName != null ?  (object)cnName : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "cnDescription"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutCnDescription(string cnDescription, TransactionManager tm = null)
		{
			const string sql = @"UPDATE channel SET Cn_description=@Cn_description";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Cn_description", cnDescription != null ?  (object)cnDescription : DBNull.Value, DbType.String, 6000)
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
			const string sql = @"UPDATE channel SET Ur_id=@Ur_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_id", urId != null ?  (object)urId : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "cnAddTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutCnAddTime(DateTime? cnAddTime, TransactionManager tm = null)
		{
			const string sql = @"UPDATE channel SET Cn_addTime=@Cn_addTime";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Cn_addTime", cnAddTime.HasValue ? (object)cnAddTime.Value : DBNull.Value, DbType.Date, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "cnState"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutCnState(string cnState, TransactionManager tm = null)
		{
			const string sql = @"UPDATE channel SET Cn_state=@Cn_state";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Cn_state", cnState != null ?  (object)cnState : DBNull.Value, DbType.String, 3)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "cnDel"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutCnDel(string cnDel, TransactionManager tm = null)
		{
			const string sql = @"UPDATE channel SET Cn_Del=@Cn_Del";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Cn_Del", cnDel != null ?  (object)cnDel : DBNull.Value, DbType.String, 3)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "cnText1"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutCnText1(string cnText1, TransactionManager tm = null)
		{
			const string sql = @"UPDATE channel SET Cn_text1=@Cn_text1";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Cn_text1", cnText1 != null ?  (object)cnText1 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "cnText2"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutCnText2(string cnText2, TransactionManager tm = null)
		{
			const string sql = @"UPDATE channel SET Cn_text2=@Cn_text2";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Cn_text2", cnText2 != null ?  (object)cnText2 : DBNull.Value, DbType.String, 600)
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
			const string format = @"UPDATE channel SET {0} {1}";
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
			const string format = @"UPDATE channel SET {0} {1}";
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
		/// <param name = "cnId"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByPK(string cnId, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM channel WHERE Cn_id=@Cn_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Cn_id", cnId, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Remove(ChannelEO item, TransactionManager tm = null)
		{
			return RemoveByPK(item.CnId, tm);
		}

		/// <summary>
		/// 删除指定实体集合对应的记录集
		/// </summary>
		/// <param name = "items">要删除的实体集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Remove(IEnumerable<ChannelEO> items, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM channel WHERE Cn_id=@OriginalCn_id";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@OriginalCnId", DbType.String, 150);
			int ret = 0;
			foreach (ChannelEO item in items)
			{
				ret += sqlDao
							.SetParameterValue("@OriginalCnId", (item.HasOriginal) ? item.OriginalCnId : item.CnId)
							.ExecNonQuery(tm);
			}
			return ret;
		}




		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "cnChannelId"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByCnChannelId(string cnChannelId, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM channel WHERE Cn_channelId=@Cn_channelId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Cn_channelId", cnChannelId != null ?  (object)cnChannelId : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "cnName"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByCnName(string cnName, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM channel WHERE Cn_name=@Cn_name";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Cn_name", cnName != null ?  (object)cnName : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "cnDescription"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByCnDescription(string cnDescription, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM channel WHERE Cn_description=@Cn_description";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Cn_description", cnDescription != null ?  (object)cnDescription : DBNull.Value, DbType.String, 6000)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "urId"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByUrId(string urId, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM channel WHERE Ur_id=@Ur_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_id", urId != null ?  (object)urId : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "cnAddTime"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByCnAddTime(DateTime? cnAddTime, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM channel WHERE Cn_addTime=@Cn_addTime";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Cn_addTime", cnAddTime.HasValue ? (object)cnAddTime.Value : DBNull.Value, DbType.Date, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "cnState"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByCnState(string cnState, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM channel WHERE Cn_state=@Cn_state";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Cn_state", cnState != null ?  (object)cnState : DBNull.Value, DbType.String, 3)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "cnDel"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByCnDel(string cnDel, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM channel WHERE Cn_Del=@Cn_Del";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Cn_Del", cnDel != null ?  (object)cnDel : DBNull.Value, DbType.String, 3)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "cnText1"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByCnText1(string cnText1, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM channel WHERE Cn_text1=@Cn_text1";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Cn_text1", cnText1 != null ?  (object)cnText1 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "cnText2"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByCnText2(string cnText2, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM channel WHERE Cn_text2=@Cn_text2";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Cn_text2", cnText2 != null ?  (object)cnText2 : DBNull.Value, DbType.String, 600)
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
			const string format = @"DELETE FROM channel {0}";
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
			const string format = @"DELETE FROM channel {0}";
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
