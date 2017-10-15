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
	/// 【表 game 的实体类】
	/// </summary>
	[SerializableAttribute]
	public class GameEO : DataEntityBase, IRowMapper<GameEO>
	{
		protected string _originalGmId;

		/// <summary>
		/// 主键是否有原始值（即数据库中保存的值），用于实体对象更新时
		/// </summary>
		public bool HasOriginal { get; protected set; }

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
		public virtual string GmName { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string GmGameId { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string CnChannelId { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string GmDescription { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string UrId { get; set; }

		/// <summary>
		/// 【字段 date】
		/// </summary>
		public virtual DateTime? GmAdddTime { get; set; }

		/// <summary>
		/// 【字段 char】
		/// </summary>
		public virtual string GmState { get; set; }

		/// <summary>
		/// 【字段 char】
		/// </summary>
		public virtual string GmDel { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string GmText1 { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string GmText2 { get; set; }

		/// <summary>
		/// 默认构造函数
		/// </summary>
		public GameEO() 
		{
			GmId = string.Empty;
		}

		/// <summary>
		/// 自定义构造函数
		/// </summary>
		/// <param name = "gmId"></param>
		/// <param name = "gmName"></param>
		/// <param name = "gmGameId"></param>
		/// <param name = "cnChannelId"></param>
		/// <param name = "gmDescription"></param>
		/// <param name = "urId"></param>
		/// <param name = "gmAdddTime"></param>
		/// <param name = "gmState"></param>
		/// <param name = "gmDel"></param>
		/// <param name = "gmText1"></param>
		/// <param name = "gmText2"></param>
		public GameEO(string gmId, string gmName, string gmGameId, string cnChannelId, string gmDescription, string urId, DateTime? gmAdddTime, string gmState, string gmDel, string gmText1, string gmText2) 
		{
			GmId = gmId;
			GmName = gmName;
			GmGameId = gmGameId;
			CnChannelId = cnChannelId;
			GmDescription = gmDescription;
			UrId = urId;
			GmAdddTime = gmAdddTime;
			GmState = gmState;
			GmDel = gmDel;
			GmText1 = gmText1;
			GmText2 = gmText2;
		}

		/// <summary>
		/// 将结果集映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public GameEO MapRow(IDataReader reader)
		{
			return GetItem(reader);
		}

		/// <summary>
		/// 将结果集映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static GameEO GetItem(IDataReader reader)
		{
			GameEO ret = new GameEO();

			ret.GmId = (string)reader["Gm_id"];
			ret.OriginalGmId = ret.GmId;
			ret.GmName = (reader["Gm_name"] is DBNull) ? null : (string)reader["Gm_name"];
			ret.GmGameId = (reader["Gm_gameId"] is DBNull) ? null : (string)reader["Gm_gameId"];
			ret.CnChannelId = (reader["Cn_channelId"] is DBNull) ? null : (string)reader["Cn_channelId"];
			ret.GmDescription = (reader["Gm_description"] is DBNull) ? null : (string)reader["Gm_description"];
			ret.UrId = (reader["Ur_id"] is DBNull) ? null : (string)reader["Ur_id"];
			ret.GmAdddTime = (reader["Gm_adddTime"] is DBNull) ? (DateTime?)null : DateTime.Parse(reader["Gm_adddTime"].ToString());
			ret.GmState = (reader["Gm_state"] is DBNull) ? null : (string)reader["Gm_state"];
			ret.GmDel = (reader["Gm_del"] is DBNull) ? null : (string)reader["Gm_del"];
			ret.GmText1 = (reader["Gm_text1"] is DBNull) ? null : (string)reader["Gm_text1"];
			ret.GmText2 = (reader["Gm_text2"] is DBNull) ? null : (string)reader["Gm_text2"];
			return ret;
		}
	}


	#endregion

	#region  MO

	/// <summary>
	/// 【表 game 的操作类】
	/// </summary>
    public partial class GameMO : DataManagerBase
	{

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "routeData">路由数据</param>
		public GameMO(object routeData = null) : base(routeData) { }

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">连接字符串名称</param>
		public GameMO(string connectionStringName) : base(connectionStringName) { }

		#region  Get方法集合

		/// <summary>
		/// 按 PK（主键） 查询
		/// </summary>
		/// <param name="tm">事务管理对象</param>
		/// <param name = "gmId"></param>
		/// <return></return>
		public virtual GameEO GetByPK(string gmId, TransactionManager tm = null)
		{
			const string sql = @"SELECT Gm_id, Gm_name, Gm_gameId, Cn_channelId, Gm_description, Ur_id, Gm_adddTime, Gm_state, Gm_del, Gm_text1, Gm_text2 FROM game WHERE Gm_id=@Gm_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Gm_id", gmId, DbType.String, 150)
							.ExecSingle<GameEO>(GameEO.GetItem, tm);
		}




		#region  按 GmName（字段） 查询

		/// <summary>
		/// 按 GmName（字段） 查询
		/// </summary>
		/// <param name = "gmName"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByGmName(string gmName)
		{
			return GetByGmName(gmName, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 GmName（字段） 查询
		/// </summary>
		/// <param name = "gmName"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByGmName(string gmName, TransactionManager tm)
		{
			return GetByGmName(gmName, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 GmName（字段） 查询
		/// </summary>
		/// <param name = "gmName"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByGmName(string gmName, int top)
		{
			return GetByGmName(gmName, top, string.Empty, null);
		}

		/// <summary>
		/// 按 GmName（字段） 查询
		/// </summary>
		/// <param name = "gmName"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByGmName(string gmName, int top, TransactionManager tm)
		{
			return GetByGmName(gmName, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 GmName（字段） 查询
		/// </summary>
		/// <param name = "gmName"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByGmName(string gmName, string sort)
		{
			return GetByGmName(gmName, 0, sort, null);
		}

		/// <summary>
		/// 按 GmName（字段） 查询
		/// </summary>
		/// <param name = "gmName"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByGmName(string gmName, string sort, TransactionManager tm)
		{
			return GetByGmName(gmName, 0, sort, tm);
		}

		/// <summary>
		/// 按 GmName（字段） 查询
		/// </summary>
		/// <param name = "gmName"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByGmName(string gmName, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Gm_id, Gm_name, Gm_gameId, Cn_channelId, Gm_description, Ur_id, Gm_adddTime, Gm_state, Gm_del, Gm_text1, Gm_text2 FROM game WHERE Gm_name=@GmName";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@GmName", gmName, DbType.String, 150)
							.ExecList<GameEO>(GameEO.GetItem, tm);
		}

		#endregion

		#region  按 GmGameId（字段） 查询

		/// <summary>
		/// 按 GmGameId（字段） 查询
		/// </summary>
		/// <param name = "gmGameId"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByGmGameId(string gmGameId)
		{
			return GetByGmGameId(gmGameId, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 GmGameId（字段） 查询
		/// </summary>
		/// <param name = "gmGameId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByGmGameId(string gmGameId, TransactionManager tm)
		{
			return GetByGmGameId(gmGameId, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 GmGameId（字段） 查询
		/// </summary>
		/// <param name = "gmGameId"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByGmGameId(string gmGameId, int top)
		{
			return GetByGmGameId(gmGameId, top, string.Empty, null);
		}

		/// <summary>
		/// 按 GmGameId（字段） 查询
		/// </summary>
		/// <param name = "gmGameId"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByGmGameId(string gmGameId, int top, TransactionManager tm)
		{
			return GetByGmGameId(gmGameId, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 GmGameId（字段） 查询
		/// </summary>
		/// <param name = "gmGameId"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByGmGameId(string gmGameId, string sort)
		{
			return GetByGmGameId(gmGameId, 0, sort, null);
		}

		/// <summary>
		/// 按 GmGameId（字段） 查询
		/// </summary>
		/// <param name = "gmGameId"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByGmGameId(string gmGameId, string sort, TransactionManager tm)
		{
			return GetByGmGameId(gmGameId, 0, sort, tm);
		}

		/// <summary>
		/// 按 GmGameId（字段） 查询
		/// </summary>
		/// <param name = "gmGameId"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByGmGameId(string gmGameId, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Gm_id, Gm_name, Gm_gameId, Cn_channelId, Gm_description, Ur_id, Gm_adddTime, Gm_state, Gm_del, Gm_text1, Gm_text2 FROM game WHERE Gm_gameId=@GmGameId";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@GmGameId", gmGameId, DbType.String, 30)
							.ExecList<GameEO>(GameEO.GetItem, tm);
		}

		#endregion

		#region  按 CnChannelId（字段） 查询

		/// <summary>
		/// 按 CnChannelId（字段） 查询
		/// </summary>
		/// <param name = "cnChannelId"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByCnChannelId(string cnChannelId)
		{
			return GetByCnChannelId(cnChannelId, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 CnChannelId（字段） 查询
		/// </summary>
		/// <param name = "cnChannelId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByCnChannelId(string cnChannelId, TransactionManager tm)
		{
			return GetByCnChannelId(cnChannelId, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 CnChannelId（字段） 查询
		/// </summary>
		/// <param name = "cnChannelId"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByCnChannelId(string cnChannelId, int top)
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
		public virtual IEnumerable<GameEO> GetByCnChannelId(string cnChannelId, int top, TransactionManager tm)
		{
			return GetByCnChannelId(cnChannelId, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 CnChannelId（字段） 查询
		/// </summary>
		/// <param name = "cnChannelId"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByCnChannelId(string cnChannelId, string sort)
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
		public virtual IEnumerable<GameEO> GetByCnChannelId(string cnChannelId, string sort, TransactionManager tm)
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
		public virtual IEnumerable<GameEO> GetByCnChannelId(string cnChannelId, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Gm_id, Gm_name, Gm_gameId, Cn_channelId, Gm_description, Ur_id, Gm_adddTime, Gm_state, Gm_del, Gm_text1, Gm_text2 FROM game WHERE Cn_channelId=@CnChannelId";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@CnChannelId", cnChannelId, DbType.String, 150)
							.ExecList<GameEO>(GameEO.GetItem, tm);
		}

		#endregion

		#region  按 GmDescription（字段） 查询

		/// <summary>
		/// 按 GmDescription（字段） 查询
		/// </summary>
		/// <param name = "gmDescription"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByGmDescription(string gmDescription)
		{
			return GetByGmDescription(gmDescription, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 GmDescription（字段） 查询
		/// </summary>
		/// <param name = "gmDescription"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByGmDescription(string gmDescription, TransactionManager tm)
		{
			return GetByGmDescription(gmDescription, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 GmDescription（字段） 查询
		/// </summary>
		/// <param name = "gmDescription"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByGmDescription(string gmDescription, int top)
		{
			return GetByGmDescription(gmDescription, top, string.Empty, null);
		}

		/// <summary>
		/// 按 GmDescription（字段） 查询
		/// </summary>
		/// <param name = "gmDescription"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByGmDescription(string gmDescription, int top, TransactionManager tm)
		{
			return GetByGmDescription(gmDescription, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 GmDescription（字段） 查询
		/// </summary>
		/// <param name = "gmDescription"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByGmDescription(string gmDescription, string sort)
		{
			return GetByGmDescription(gmDescription, 0, sort, null);
		}

		/// <summary>
		/// 按 GmDescription（字段） 查询
		/// </summary>
		/// <param name = "gmDescription"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByGmDescription(string gmDescription, string sort, TransactionManager tm)
		{
			return GetByGmDescription(gmDescription, 0, sort, tm);
		}

		/// <summary>
		/// 按 GmDescription（字段） 查询
		/// </summary>
		/// <param name = "gmDescription"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByGmDescription(string gmDescription, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Gm_id, Gm_name, Gm_gameId, Cn_channelId, Gm_description, Ur_id, Gm_adddTime, Gm_state, Gm_del, Gm_text1, Gm_text2 FROM game WHERE Gm_description=@GmDescription";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@GmDescription", gmDescription, DbType.String, 6000)
							.ExecList<GameEO>(GameEO.GetItem, tm);
		}

		#endregion

		#region  按 UrId（字段） 查询

		/// <summary>
		/// 按 UrId（字段） 查询
		/// </summary>
		/// <param name = "urId"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByUrId(string urId)
		{
			return GetByUrId(urId, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 UrId（字段） 查询
		/// </summary>
		/// <param name = "urId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByUrId(string urId, TransactionManager tm)
		{
			return GetByUrId(urId, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 UrId（字段） 查询
		/// </summary>
		/// <param name = "urId"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByUrId(string urId, int top)
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
		public virtual IEnumerable<GameEO> GetByUrId(string urId, int top, TransactionManager tm)
		{
			return GetByUrId(urId, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 UrId（字段） 查询
		/// </summary>
		/// <param name = "urId"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByUrId(string urId, string sort)
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
		public virtual IEnumerable<GameEO> GetByUrId(string urId, string sort, TransactionManager tm)
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
		public virtual IEnumerable<GameEO> GetByUrId(string urId, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Gm_id, Gm_name, Gm_gameId, Cn_channelId, Gm_description, Ur_id, Gm_adddTime, Gm_state, Gm_del, Gm_text1, Gm_text2 FROM game WHERE Ur_id=@UrId";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@UrId", urId, DbType.String, 150)
							.ExecList<GameEO>(GameEO.GetItem, tm);
		}

		#endregion

		#region  按 GmAdddTime（字段） 查询

		/// <summary>
		/// 按 GmAdddTime（字段） 查询
		/// </summary>
		/// <param name = "gmAdddTime"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByGmAdddTime(DateTime? gmAdddTime)
		{
			return GetByGmAdddTime(gmAdddTime, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 GmAdddTime（字段） 查询
		/// </summary>
		/// <param name = "gmAdddTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByGmAdddTime(DateTime? gmAdddTime, TransactionManager tm)
		{
			return GetByGmAdddTime(gmAdddTime, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 GmAdddTime（字段） 查询
		/// </summary>
		/// <param name = "gmAdddTime"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByGmAdddTime(DateTime? gmAdddTime, int top)
		{
			return GetByGmAdddTime(gmAdddTime, top, string.Empty, null);
		}

		/// <summary>
		/// 按 GmAdddTime（字段） 查询
		/// </summary>
		/// <param name = "gmAdddTime"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByGmAdddTime(DateTime? gmAdddTime, int top, TransactionManager tm)
		{
			return GetByGmAdddTime(gmAdddTime, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 GmAdddTime（字段） 查询
		/// </summary>
		/// <param name = "gmAdddTime"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByGmAdddTime(DateTime? gmAdddTime, string sort)
		{
			return GetByGmAdddTime(gmAdddTime, 0, sort, null);
		}

		/// <summary>
		/// 按 GmAdddTime（字段） 查询
		/// </summary>
		/// <param name = "gmAdddTime"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByGmAdddTime(DateTime? gmAdddTime, string sort, TransactionManager tm)
		{
			return GetByGmAdddTime(gmAdddTime, 0, sort, tm);
		}

		/// <summary>
		/// 按 GmAdddTime（字段） 查询
		/// </summary>
		/// <param name = "gmAdddTime"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByGmAdddTime(DateTime? gmAdddTime, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Gm_id, Gm_name, Gm_gameId, Cn_channelId, Gm_description, Ur_id, Gm_adddTime, Gm_state, Gm_del, Gm_text1, Gm_text2 FROM game WHERE Gm_adddTime=@GmAdddTime";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@GmAdddTime", gmAdddTime, DbType.Date, 0)
							.ExecList<GameEO>(GameEO.GetItem, tm);
		}

		#endregion

		#region  按 GmState（字段） 查询

		/// <summary>
		/// 按 GmState（字段） 查询
		/// </summary>
		/// <param name = "gmState"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByGmState(string gmState)
		{
			return GetByGmState(gmState, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 GmState（字段） 查询
		/// </summary>
		/// <param name = "gmState"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByGmState(string gmState, TransactionManager tm)
		{
			return GetByGmState(gmState, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 GmState（字段） 查询
		/// </summary>
		/// <param name = "gmState"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByGmState(string gmState, int top)
		{
			return GetByGmState(gmState, top, string.Empty, null);
		}

		/// <summary>
		/// 按 GmState（字段） 查询
		/// </summary>
		/// <param name = "gmState"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByGmState(string gmState, int top, TransactionManager tm)
		{
			return GetByGmState(gmState, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 GmState（字段） 查询
		/// </summary>
		/// <param name = "gmState"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByGmState(string gmState, string sort)
		{
			return GetByGmState(gmState, 0, sort, null);
		}

		/// <summary>
		/// 按 GmState（字段） 查询
		/// </summary>
		/// <param name = "gmState"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByGmState(string gmState, string sort, TransactionManager tm)
		{
			return GetByGmState(gmState, 0, sort, tm);
		}

		/// <summary>
		/// 按 GmState（字段） 查询
		/// </summary>
		/// <param name = "gmState"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByGmState(string gmState, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Gm_id, Gm_name, Gm_gameId, Cn_channelId, Gm_description, Ur_id, Gm_adddTime, Gm_state, Gm_del, Gm_text1, Gm_text2 FROM game WHERE Gm_state=@GmState";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@GmState", gmState, DbType.String, 3)
							.ExecList<GameEO>(GameEO.GetItem, tm);
		}

		#endregion

		#region  按 GmDel（字段） 查询

		/// <summary>
		/// 按 GmDel（字段） 查询
		/// </summary>
		/// <param name = "gmDel"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByGmDel(string gmDel)
		{
			return GetByGmDel(gmDel, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 GmDel（字段） 查询
		/// </summary>
		/// <param name = "gmDel"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByGmDel(string gmDel, TransactionManager tm)
		{
			return GetByGmDel(gmDel, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 GmDel（字段） 查询
		/// </summary>
		/// <param name = "gmDel"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByGmDel(string gmDel, int top)
		{
			return GetByGmDel(gmDel, top, string.Empty, null);
		}

		/// <summary>
		/// 按 GmDel（字段） 查询
		/// </summary>
		/// <param name = "gmDel"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByGmDel(string gmDel, int top, TransactionManager tm)
		{
			return GetByGmDel(gmDel, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 GmDel（字段） 查询
		/// </summary>
		/// <param name = "gmDel"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByGmDel(string gmDel, string sort)
		{
			return GetByGmDel(gmDel, 0, sort, null);
		}

		/// <summary>
		/// 按 GmDel（字段） 查询
		/// </summary>
		/// <param name = "gmDel"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByGmDel(string gmDel, string sort, TransactionManager tm)
		{
			return GetByGmDel(gmDel, 0, sort, tm);
		}

		/// <summary>
		/// 按 GmDel（字段） 查询
		/// </summary>
		/// <param name = "gmDel"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByGmDel(string gmDel, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Gm_id, Gm_name, Gm_gameId, Cn_channelId, Gm_description, Ur_id, Gm_adddTime, Gm_state, Gm_del, Gm_text1, Gm_text2 FROM game WHERE Gm_del=@GmDel";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@GmDel", gmDel, DbType.String, 3)
							.ExecList<GameEO>(GameEO.GetItem, tm);
		}

		#endregion

		#region  按 GmText1（字段） 查询

		/// <summary>
		/// 按 GmText1（字段） 查询
		/// </summary>
		/// <param name = "gmText1"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByGmText1(string gmText1)
		{
			return GetByGmText1(gmText1, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 GmText1（字段） 查询
		/// </summary>
		/// <param name = "gmText1"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByGmText1(string gmText1, TransactionManager tm)
		{
			return GetByGmText1(gmText1, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 GmText1（字段） 查询
		/// </summary>
		/// <param name = "gmText1"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByGmText1(string gmText1, int top)
		{
			return GetByGmText1(gmText1, top, string.Empty, null);
		}

		/// <summary>
		/// 按 GmText1（字段） 查询
		/// </summary>
		/// <param name = "gmText1"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByGmText1(string gmText1, int top, TransactionManager tm)
		{
			return GetByGmText1(gmText1, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 GmText1（字段） 查询
		/// </summary>
		/// <param name = "gmText1"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByGmText1(string gmText1, string sort)
		{
			return GetByGmText1(gmText1, 0, sort, null);
		}

		/// <summary>
		/// 按 GmText1（字段） 查询
		/// </summary>
		/// <param name = "gmText1"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByGmText1(string gmText1, string sort, TransactionManager tm)
		{
			return GetByGmText1(gmText1, 0, sort, tm);
		}

		/// <summary>
		/// 按 GmText1（字段） 查询
		/// </summary>
		/// <param name = "gmText1"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByGmText1(string gmText1, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Gm_id, Gm_name, Gm_gameId, Cn_channelId, Gm_description, Ur_id, Gm_adddTime, Gm_state, Gm_del, Gm_text1, Gm_text2 FROM game WHERE Gm_text1=@GmText1";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@GmText1", gmText1, DbType.String, 600)
							.ExecList<GameEO>(GameEO.GetItem, tm);
		}

		#endregion

		#region  按 GmText2（字段） 查询

		/// <summary>
		/// 按 GmText2（字段） 查询
		/// </summary>
		/// <param name = "gmText2"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByGmText2(string gmText2)
		{
			return GetByGmText2(gmText2, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 GmText2（字段） 查询
		/// </summary>
		/// <param name = "gmText2"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByGmText2(string gmText2, TransactionManager tm)
		{
			return GetByGmText2(gmText2, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 GmText2（字段） 查询
		/// </summary>
		/// <param name = "gmText2"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByGmText2(string gmText2, int top)
		{
			return GetByGmText2(gmText2, top, string.Empty, null);
		}

		/// <summary>
		/// 按 GmText2（字段） 查询
		/// </summary>
		/// <param name = "gmText2"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByGmText2(string gmText2, int top, TransactionManager tm)
		{
			return GetByGmText2(gmText2, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 GmText2（字段） 查询
		/// </summary>
		/// <param name = "gmText2"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByGmText2(string gmText2, string sort)
		{
			return GetByGmText2(gmText2, 0, sort, null);
		}

		/// <summary>
		/// 按 GmText2（字段） 查询
		/// </summary>
		/// <param name = "gmText2"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByGmText2(string gmText2, string sort, TransactionManager tm)
		{
			return GetByGmText2(gmText2, 0, sort, tm);
		}

		/// <summary>
		/// 按 GmText2（字段） 查询
		/// </summary>
		/// <param name = "gmText2"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetByGmText2(string gmText2, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Gm_id, Gm_name, Gm_gameId, Cn_channelId, Gm_description, Ur_id, Gm_adddTime, Gm_state, Gm_del, Gm_text1, Gm_text2 FROM game WHERE Gm_text2=@GmText2";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@GmText2", gmText2, DbType.String, 600)
							.ExecList<GameEO>(GameEO.GetItem, tm);
		}

		#endregion

		#region  自定义条件查询

		/// <summary>
		/// 获取所有数据
		/// </summary>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetAll(TransactionManager tm = null)
		{
			return GetTopSort(string.Empty, null, -1, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "values">where子句中定义的参数值集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> Get(string where, params object[] values)
		{
			return GetTopSort(where, -1, string.Empty, null, values);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "paras">where子句中定义的参数集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> Get(string where, IEnumerable<DbParameter> paras)
		{
			return GetTopSort(where, paras, -1, string.Empty, null);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> Get(string where, TransactionManager tm)
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
		public virtual IEnumerable<GameEO> Get(string where, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<GameEO> Get(string where, IEnumerable<DbParameter> paras, TransactionManager tm)
		{
			return GetTopSort(where, paras, -1, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetTop(string where, int top)
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
		public virtual IEnumerable<GameEO> GetTop(string where, int top, params object[] values)
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
		public virtual IEnumerable<GameEO> GetTop(string where, IEnumerable<DbParameter> paras, int top)
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
		public virtual IEnumerable<GameEO> GetTop(string where, int top, TransactionManager tm)
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
		public virtual IEnumerable<GameEO> GetTop(string where, int top, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<GameEO> GetTop(string where, IEnumerable<DbParameter> paras, int top, TransactionManager tm)
		{
			return GetTopSort(where, paras, top, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<GameEO> GetSort(string where, string sort)
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
		public virtual IEnumerable<GameEO> GetSort(string where, string sort, params object[] values)
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
		public virtual IEnumerable<GameEO> GetSort(string where, IEnumerable<DbParameter> paras, string sort)
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
		public virtual IEnumerable<GameEO> GetSort(string where, string sort, TransactionManager tm)
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
		public virtual IEnumerable<GameEO> GetSort(string where, string sort, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<GameEO> GetSort(string where, IEnumerable<DbParameter> paras, string sort, TransactionManager tm)
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
		public virtual IEnumerable<GameEO> GetTopSort(string where, int top, string sort)
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
		public virtual IEnumerable<GameEO> GetTopSort(string where, int top, string sort, params object[] values)
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
		public virtual IEnumerable<GameEO> GetTopSort(string where, IEnumerable<DbParameter> paras, int top, string sort)
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
		public virtual IEnumerable<GameEO> GetTopSort(string where, int top, string sort, TransactionManager tm)
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
		public virtual IEnumerable<GameEO> GetTopSort(string where, int top, string sort, TransactionManager tm, params object[] values)
		{
			const string format = @"SELECT {0} Gm_id, Gm_name, Gm_gameId, Cn_channelId, Gm_description, Ur_id, Gm_adddTime, Gm_state, Gm_del, Gm_text1, Gm_text2 FROM game";
			string sql = format;

			if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameters(values)
							.ExecList<GameEO>(GameEO.GetItem, tm);
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
		public virtual IEnumerable<GameEO> GetTopSort(string where, IEnumerable<DbParameter> paras, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Gm_id, Gm_name, Gm_gameId, Cn_channelId, Gm_description, Ur_id, Gm_adddTime, Gm_state, Gm_del, Gm_text1, Gm_text2 FROM game";
			string sql = format;

			if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddParameters(paras)
							.ExecList<GameEO>(GameEO.GetItem, tm);
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
			const string format = @"SELECT Gm_id, Gm_name, Gm_gameId, Cn_channelId, Gm_description, Ur_id, Gm_adddTime, Gm_state, Gm_del, Gm_text1, Gm_text2 FROM game {0} {1}";
			 string sql = string.Format(format, string.IsNullOrEmpty(where) ? string.Empty : "WHERE " + where, string.IsNullOrEmpty(sort) ? string.Empty : "ORDER BY " + sort);

			return Database.CreatePager(sql, pageSize, "Gm_id");
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
		public virtual List<GameEO> GetPageList(int pageIndex , int pageSize, string where = null, string sort = null, IEnumerable<DbParameter> paras = null)
		{
			var pager = GetPager(pageSize, where, sort);

			pager.AddParameters(paras);
			return pager.GetPageList<GameEO>(pageIndex);
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
		public virtual IEnumerable<GameEO> GetPageMutil(int pageIndex , int pageSize, string where = null, string sort = null, IEnumerable<DbParameter> paras = null)
		{
			var pager = GetPager(pageSize, where, sort);

			pager.AddParameters(paras);
			return pager.GetPageMutil<GameEO>(pageIndex);
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
		public virtual int Add(GameEO item, TransactionManager tm = null)
		{
			const string sql = @"INSERT INTO game (Gm_id, Gm_name, Gm_gameId, Cn_channelId, Gm_description, Ur_id, Gm_adddTime, Gm_state, Gm_del, Gm_text1, Gm_text2) VALUES (@Gm_id, @Gm_name, @Gm_gameId, @Cn_channelId, @Gm_description, @Ur_id, @Gm_adddTime, @Gm_state, @Gm_del, @Gm_text1, @Gm_text2) ";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Gm_id", item.GmId, DbType.String, 150)
							.AddInParameter("@Gm_name", item.GmName != null ?  (object)item.GmName : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Gm_gameId", item.GmGameId != null ?  (object)item.GmGameId : DBNull.Value, DbType.String, 30)
							.AddInParameter("@Cn_channelId", item.CnChannelId != null ?  (object)item.CnChannelId : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Gm_description", item.GmDescription != null ?  (object)item.GmDescription : DBNull.Value, DbType.String, 6000)
							.AddInParameter("@Ur_id", item.UrId != null ?  (object)item.UrId : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Gm_adddTime", item.GmAdddTime.HasValue ? (object)item.GmAdddTime.Value : DBNull.Value, DbType.Date, 0)
							.AddInParameter("@Gm_state", item.GmState != null ?  (object)item.GmState : DBNull.Value, DbType.String, 3)
							.AddInParameter("@Gm_del", item.GmDel != null ?  (object)item.GmDel : DBNull.Value, DbType.String, 3)
							.AddInParameter("@Gm_text1", item.GmText1 != null ?  (object)item.GmText1 : DBNull.Value, DbType.String, 600)
							.AddInParameter("@Gm_text2", item.GmText2 != null ?  (object)item.GmText2 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 插入一组数据
		/// </summary>
		/// <param name = "items">要插入的实体对象集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Add(IEnumerable<GameEO> items, TransactionManager tm = null)
		{
			int ret = 0;
			const string sql = @"INSERT INTO game (Gm_id, Gm_name, Gm_gameId, Cn_channelId, Gm_description, Ur_id, Gm_adddTime, Gm_state, Gm_del, Gm_text1, Gm_text2) VALUES (@Gm_id, @Gm_name, @Gm_gameId, @Cn_channelId, @Gm_description, @Ur_id, @Gm_adddTime, @Gm_state, @Gm_del, @Gm_text1, @Gm_text2) ";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@Gm_id", DbType.String, 150)
									.AddParameter("@Gm_name", DbType.String, 150)
									.AddParameter("@Gm_gameId", DbType.String, 30)
									.AddParameter("@Cn_channelId", DbType.String, 150)
									.AddParameter("@Gm_description", DbType.String, 6000)
									.AddParameter("@Ur_id", DbType.String, 150)
									.AddParameter("@Gm_adddTime", DbType.Date, 0)
									.AddParameter("@Gm_state", DbType.String, 3)
									.AddParameter("@Gm_del", DbType.String, 3)
									.AddParameter("@Gm_text1", DbType.String, 600)
									.AddParameter("@Gm_text2", DbType.String, 600);

			foreach (GameEO item in items)
			{
				sqlDao
					.SetParameterValue("@Gm_id", item.GmId)
					.SetParameterValue("@Gm_name", item.GmName != null ?  (object)item.GmName : DBNull.Value)
					.SetParameterValue("@Gm_gameId", item.GmGameId != null ?  (object)item.GmGameId : DBNull.Value)
					.SetParameterValue("@Cn_channelId", item.CnChannelId != null ?  (object)item.CnChannelId : DBNull.Value)
					.SetParameterValue("@Gm_description", item.GmDescription != null ?  (object)item.GmDescription : DBNull.Value)
					.SetParameterValue("@Ur_id", item.UrId != null ?  (object)item.UrId : DBNull.Value)
					.SetParameterValue("@Gm_adddTime", item.GmAdddTime.HasValue ? (object)item.GmAdddTime.Value : DBNull.Value)
					.SetParameterValue("@Gm_state", item.GmState != null ?  (object)item.GmState : DBNull.Value)
					.SetParameterValue("@Gm_del", item.GmDel != null ?  (object)item.GmDel : DBNull.Value)
					.SetParameterValue("@Gm_text1", item.GmText1 != null ?  (object)item.GmText1 : DBNull.Value)
					.SetParameterValue("@Gm_text2", item.GmText2 != null ?  (object)item.GmText2 : DBNull.Value)
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
		public virtual int Put(GameEO item, TransactionManager tm = null)
		{
			const string sql = @"UPDATE game SET Gm_id=@Gm_id, Gm_name=@Gm_name, Gm_gameId=@Gm_gameId, Cn_channelId=@Cn_channelId, Gm_description=@Gm_description, Ur_id=@Ur_id, Gm_adddTime=@Gm_adddTime, Gm_state=@Gm_state, Gm_del=@Gm_del, Gm_text1=@Gm_text1, Gm_text2=@Gm_text2 WHERE Gm_id=@OriginalGm_id";
			return Database.CreateSqlDao (sql)
							.AddInParameter("@OriginalGmId", (item.HasOriginal) ? item.OriginalGmId : item.GmId, DbType.String, 150)
							.AddInParameter("@Gm_id", item.GmId, DbType.String, 150)
							.AddInParameter("@Gm_name", item.GmName != null ?  (object)item.GmName : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Gm_gameId", item.GmGameId != null ?  (object)item.GmGameId : DBNull.Value, DbType.String, 30)
							.AddInParameter("@Cn_channelId", item.CnChannelId != null ?  (object)item.CnChannelId : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Gm_description", item.GmDescription != null ?  (object)item.GmDescription : DBNull.Value, DbType.String, 6000)
							.AddInParameter("@Ur_id", item.UrId != null ?  (object)item.UrId : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Gm_adddTime", item.GmAdddTime.HasValue ? (object)item.GmAdddTime.Value : DBNull.Value, DbType.Date, 0)
							.AddInParameter("@Gm_state", item.GmState != null ?  (object)item.GmState : DBNull.Value, DbType.String, 3)
							.AddInParameter("@Gm_del", item.GmDel != null ?  (object)item.GmDel : DBNull.Value, DbType.String, 3)
							.AddInParameter("@Gm_text1", item.GmText1 != null ?  (object)item.GmText1 : DBNull.Value, DbType.String, 600)
							.AddInParameter("@Gm_text2", item.GmText2 != null ?  (object)item.GmText2 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}


		/// <summary>
		/// 更新数据
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Put(IEnumerable<GameEO> items, TransactionManager tm = null)
		{

			int ret = 0;
			const string sql = @"UPDATE game SET Gm_id=@Gm_id, Gm_name=@Gm_name, Gm_gameId=@Gm_gameId, Cn_channelId=@Cn_channelId, Gm_description=@Gm_description, Ur_id=@Ur_id, Gm_adddTime=@Gm_adddTime, Gm_state=@Gm_state, Gm_del=@Gm_del, Gm_text1=@Gm_text1, Gm_text2=@Gm_text2 WHERE Gm_id=@OriginalGm_id";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@OriginalGmId", DbType.String, 150)
									.AddParameter("@Gm_id", DbType.String, 150)
									.AddParameter("@Gm_name", DbType.String, 150)
									.AddParameter("@Gm_gameId", DbType.String, 30)
									.AddParameter("@Cn_channelId", DbType.String, 150)
									.AddParameter("@Gm_description", DbType.String, 6000)
									.AddParameter("@Ur_id", DbType.String, 150)
									.AddParameter("@Gm_adddTime", DbType.Date, 0)
									.AddParameter("@Gm_state", DbType.String, 3)
									.AddParameter("@Gm_del", DbType.String, 3)
									.AddParameter("@Gm_text1", DbType.String, 600)
									.AddParameter("@Gm_text2", DbType.String, 600);

			foreach (GameEO item in items)
			{
				ret += sqlDao
							.SetParameterValue("@OriginalGmId", (item.HasOriginal) ? item.OriginalGmId : item.GmId)
							.SetParameterValue("@Gm_id", item.GmId)
							.SetParameterValue("@Gm_name", item.GmName != null ?  (object)item.GmName : DBNull.Value)
							.SetParameterValue("@Gm_gameId", item.GmGameId != null ?  (object)item.GmGameId : DBNull.Value)
							.SetParameterValue("@Cn_channelId", item.CnChannelId != null ?  (object)item.CnChannelId : DBNull.Value)
							.SetParameterValue("@Gm_description", item.GmDescription != null ?  (object)item.GmDescription : DBNull.Value)
							.SetParameterValue("@Ur_id", item.UrId != null ?  (object)item.UrId : DBNull.Value)
							.SetParameterValue("@Gm_adddTime", item.GmAdddTime.HasValue ? (object)item.GmAdddTime.Value : DBNull.Value)
							.SetParameterValue("@Gm_state", item.GmState != null ?  (object)item.GmState : DBNull.Value)
							.SetParameterValue("@Gm_del", item.GmDel != null ?  (object)item.GmDel : DBNull.Value)
							.SetParameterValue("@Gm_text1", item.GmText1 != null ?  (object)item.GmText1 : DBNull.Value)
							.SetParameterValue("@Gm_text2", item.GmText2 != null ?  (object)item.GmText2 : DBNull.Value)
							.ExecNonQuery(tm);
			}
			return ret;
		}


		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "gmId"></param>
		/// <param name = "gmName"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutGmNameByPK(string gmId, string gmName, TransactionManager tm = null)
		{
			const string sql = @"UPDATE game SET Gm_name = @Gm_name  WHERE Gm_id = @Gm_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Gm_id", gmId, DbType.String, 150)
							.AddInParameter("@Gm_name", gmName != null ?  (object)gmName : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "gmId"></param>
		/// <param name = "gmGameId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutGmGameIdByPK(string gmId, string gmGameId, TransactionManager tm = null)
		{
			const string sql = @"UPDATE game SET Gm_gameId = @Gm_gameId  WHERE Gm_id = @Gm_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Gm_id", gmId, DbType.String, 150)
							.AddInParameter("@Gm_gameId", gmGameId != null ?  (object)gmGameId : DBNull.Value, DbType.String, 30)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "gmId"></param>
		/// <param name = "cnChannelId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutCnChannelIdByPK(string gmId, string cnChannelId, TransactionManager tm = null)
		{
			const string sql = @"UPDATE game SET Cn_channelId = @Cn_channelId  WHERE Gm_id = @Gm_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Gm_id", gmId, DbType.String, 150)
							.AddInParameter("@Cn_channelId", cnChannelId != null ?  (object)cnChannelId : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "gmId"></param>
		/// <param name = "gmDescription"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutGmDescriptionByPK(string gmId, string gmDescription, TransactionManager tm = null)
		{
			const string sql = @"UPDATE game SET Gm_description = @Gm_description  WHERE Gm_id = @Gm_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Gm_id", gmId, DbType.String, 150)
							.AddInParameter("@Gm_description", gmDescription != null ?  (object)gmDescription : DBNull.Value, DbType.String, 6000)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "gmId"></param>
		/// <param name = "urId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutUrIdByPK(string gmId, string urId, TransactionManager tm = null)
		{
			const string sql = @"UPDATE game SET Ur_id = @Ur_id  WHERE Gm_id = @Gm_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Gm_id", gmId, DbType.String, 150)
							.AddInParameter("@Ur_id", urId != null ?  (object)urId : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "gmId"></param>
		/// <param name = "gmAdddTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutGmAdddTimeByPK(string gmId, DateTime? gmAdddTime, TransactionManager tm = null)
		{
			const string sql = @"UPDATE game SET Gm_adddTime = @Gm_adddTime  WHERE Gm_id = @Gm_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Gm_id", gmId, DbType.String, 150)
							.AddInParameter("@Gm_adddTime", gmAdddTime.HasValue ? (object)gmAdddTime.Value : DBNull.Value, DbType.Date, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "gmId"></param>
		/// <param name = "gmState"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutGmStateByPK(string gmId, string gmState, TransactionManager tm = null)
		{
			const string sql = @"UPDATE game SET Gm_state = @Gm_state  WHERE Gm_id = @Gm_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Gm_id", gmId, DbType.String, 150)
							.AddInParameter("@Gm_state", gmState != null ?  (object)gmState : DBNull.Value, DbType.String, 3)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "gmId"></param>
		/// <param name = "gmDel"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutGmDelByPK(string gmId, string gmDel, TransactionManager tm = null)
		{
			const string sql = @"UPDATE game SET Gm_del = @Gm_del  WHERE Gm_id = @Gm_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Gm_id", gmId, DbType.String, 150)
							.AddInParameter("@Gm_del", gmDel != null ?  (object)gmDel : DBNull.Value, DbType.String, 3)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "gmId"></param>
		/// <param name = "gmText1"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutGmText1ByPK(string gmId, string gmText1, TransactionManager tm = null)
		{
			const string sql = @"UPDATE game SET Gm_text1 = @Gm_text1  WHERE Gm_id = @Gm_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Gm_id", gmId, DbType.String, 150)
							.AddInParameter("@Gm_text1", gmText1 != null ?  (object)gmText1 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "gmId"></param>
		/// <param name = "gmText2"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutGmText2ByPK(string gmId, string gmText2, TransactionManager tm = null)
		{
			const string sql = @"UPDATE game SET Gm_text2 = @Gm_text2  WHERE Gm_id = @Gm_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Gm_id", gmId, DbType.String, 150)
							.AddInParameter("@Gm_text2", gmText2 != null ?  (object)gmText2 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}


		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "gmName"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutGmName(string gmName, TransactionManager tm = null)
		{
			const string sql = @"UPDATE game SET Gm_name=@Gm_name";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Gm_name", gmName != null ?  (object)gmName : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "gmGameId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutGmGameId(string gmGameId, TransactionManager tm = null)
		{
			const string sql = @"UPDATE game SET Gm_gameId=@Gm_gameId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Gm_gameId", gmGameId != null ?  (object)gmGameId : DBNull.Value, DbType.String, 30)
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
			const string sql = @"UPDATE game SET Cn_channelId=@Cn_channelId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Cn_channelId", cnChannelId != null ?  (object)cnChannelId : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "gmDescription"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutGmDescription(string gmDescription, TransactionManager tm = null)
		{
			const string sql = @"UPDATE game SET Gm_description=@Gm_description";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Gm_description", gmDescription != null ?  (object)gmDescription : DBNull.Value, DbType.String, 6000)
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
			const string sql = @"UPDATE game SET Ur_id=@Ur_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_id", urId != null ?  (object)urId : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "gmAdddTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutGmAdddTime(DateTime? gmAdddTime, TransactionManager tm = null)
		{
			const string sql = @"UPDATE game SET Gm_adddTime=@Gm_adddTime";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Gm_adddTime", gmAdddTime.HasValue ? (object)gmAdddTime.Value : DBNull.Value, DbType.Date, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "gmState"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutGmState(string gmState, TransactionManager tm = null)
		{
			const string sql = @"UPDATE game SET Gm_state=@Gm_state";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Gm_state", gmState != null ?  (object)gmState : DBNull.Value, DbType.String, 3)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "gmDel"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutGmDel(string gmDel, TransactionManager tm = null)
		{
			const string sql = @"UPDATE game SET Gm_del=@Gm_del";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Gm_del", gmDel != null ?  (object)gmDel : DBNull.Value, DbType.String, 3)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "gmText1"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutGmText1(string gmText1, TransactionManager tm = null)
		{
			const string sql = @"UPDATE game SET Gm_text1=@Gm_text1";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Gm_text1", gmText1 != null ?  (object)gmText1 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "gmText2"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutGmText2(string gmText2, TransactionManager tm = null)
		{
			const string sql = @"UPDATE game SET Gm_text2=@Gm_text2";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Gm_text2", gmText2 != null ?  (object)gmText2 : DBNull.Value, DbType.String, 600)
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
			const string format = @"UPDATE game SET {0} {1}";
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
			const string format = @"UPDATE game SET {0} {1}";
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
		/// <param name = "gmId"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByPK(string gmId, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM game WHERE Gm_id=@Gm_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Gm_id", gmId, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Remove(GameEO item, TransactionManager tm = null)
		{
			return RemoveByPK(item.GmId, tm);
		}

		/// <summary>
		/// 删除指定实体集合对应的记录集
		/// </summary>
		/// <param name = "items">要删除的实体集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Remove(IEnumerable<GameEO> items, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM game WHERE Gm_id=@OriginalGm_id";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@OriginalGmId", DbType.String, 150);
			int ret = 0;
			foreach (GameEO item in items)
			{
				ret += sqlDao
							.SetParameterValue("@OriginalGmId", (item.HasOriginal) ? item.OriginalGmId : item.GmId)
							.ExecNonQuery(tm);
			}
			return ret;
		}




		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "gmName"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByGmName(string gmName, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM game WHERE Gm_name=@Gm_name";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Gm_name", gmName != null ?  (object)gmName : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "gmGameId"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByGmGameId(string gmGameId, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM game WHERE Gm_gameId=@Gm_gameId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Gm_gameId", gmGameId != null ?  (object)gmGameId : DBNull.Value, DbType.String, 30)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "cnChannelId"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByCnChannelId(string cnChannelId, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM game WHERE Cn_channelId=@Cn_channelId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Cn_channelId", cnChannelId != null ?  (object)cnChannelId : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "gmDescription"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByGmDescription(string gmDescription, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM game WHERE Gm_description=@Gm_description";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Gm_description", gmDescription != null ?  (object)gmDescription : DBNull.Value, DbType.String, 6000)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "urId"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByUrId(string urId, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM game WHERE Ur_id=@Ur_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_id", urId != null ?  (object)urId : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "gmAdddTime"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByGmAdddTime(DateTime? gmAdddTime, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM game WHERE Gm_adddTime=@Gm_adddTime";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Gm_adddTime", gmAdddTime.HasValue ? (object)gmAdddTime.Value : DBNull.Value, DbType.Date, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "gmState"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByGmState(string gmState, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM game WHERE Gm_state=@Gm_state";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Gm_state", gmState != null ?  (object)gmState : DBNull.Value, DbType.String, 3)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "gmDel"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByGmDel(string gmDel, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM game WHERE Gm_del=@Gm_del";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Gm_del", gmDel != null ?  (object)gmDel : DBNull.Value, DbType.String, 3)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "gmText1"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByGmText1(string gmText1, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM game WHERE Gm_text1=@Gm_text1";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Gm_text1", gmText1 != null ?  (object)gmText1 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "gmText2"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByGmText2(string gmText2, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM game WHERE Gm_text2=@Gm_text2";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Gm_text2", gmText2 != null ?  (object)gmText2 : DBNull.Value, DbType.String, 600)
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
			const string format = @"DELETE FROM game {0}";
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
			const string format = @"DELETE FROM game {0}";
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
