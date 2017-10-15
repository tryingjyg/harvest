//==========================================================
// 此代码由代码生成器工具自动生成，请不要修改
// 代码生成器核心库版本号：2.0
// 创建时间：2017/10/14 13:25:17
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
	/// 【表 log_consume 的实体类】
	/// </summary>
	[SerializableAttribute]
	public class LogConsumeEO : DataEntityBase, IRowMapper<LogConsumeEO>
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
		public virtual string RoomId { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string GameId { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string GameType { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string ChargeType { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string RoundNum { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string PlayerNum { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string UidAr { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string OwnerUid { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string DestUid { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string UseNum { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string LastNum { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string CreateTime { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string Statue { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string ServerId { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string UnidId { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string Duid { get; set; }

		/// <summary>
		/// 默认构造函数
		/// </summary>
		public LogConsumeEO() 
		{
			Remarkid = string.Empty;
			RoomId = string.Empty;
			GameId = string.Empty;
			GameType = string.Empty;
			ChargeType = string.Empty;
			RoundNum = string.Empty;
			PlayerNum = string.Empty;
			UidAr = string.Empty;
			OwnerUid = string.Empty;
			DestUid = string.Empty;
			UseNum = string.Empty;
			LastNum = string.Empty;
			CreateTime = string.Empty;
			Statue = string.Empty;
			ServerId = string.Empty;
			UnidId = string.Empty;
			Duid = string.Empty;
		}

		/// <summary>
		/// 自定义构造函数
		/// </summary>
		/// <param name = "remarkid"></param>
		/// <param name = "roomId"></param>
		/// <param name = "gameId"></param>
		/// <param name = "gameType"></param>
		/// <param name = "chargeType"></param>
		/// <param name = "roundNum"></param>
		/// <param name = "playerNum"></param>
		/// <param name = "uidAr"></param>
		/// <param name = "ownerUid"></param>
		/// <param name = "destUid"></param>
		/// <param name = "useNum"></param>
		/// <param name = "lastNum"></param>
		/// <param name = "createTime"></param>
		/// <param name = "statue"></param>
		/// <param name = "serverId"></param>
		/// <param name = "unidId"></param>
		/// <param name = "duid"></param>
		public LogConsumeEO(string remarkid, string roomId, string gameId, string gameType, string chargeType, string roundNum, string playerNum, string uidAr, string ownerUid, string destUid, string useNum, string lastNum, string createTime, string statue, string serverId, string unidId, string duid) 
		{
			Remarkid = remarkid;
			RoomId = roomId;
			GameId = gameId;
			GameType = gameType;
			ChargeType = chargeType;
			RoundNum = roundNum;
			PlayerNum = playerNum;
			UidAr = uidAr;
			OwnerUid = ownerUid;
			DestUid = destUid;
			UseNum = useNum;
			LastNum = lastNum;
			CreateTime = createTime;
			Statue = statue;
			ServerId = serverId;
			UnidId = unidId;
			Duid = duid;
		}

		/// <summary>
		/// 将结果集映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public LogConsumeEO MapRow(IDataReader reader)
		{
			return GetItem(reader);
		}

		/// <summary>
		/// 将结果集映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static LogConsumeEO GetItem(IDataReader reader)
		{
			LogConsumeEO ret = new LogConsumeEO();

			ret.Remarkid = (string)reader["remarkid"];
			ret.OriginalRemarkid = ret.Remarkid;
			ret.RoomId = (string)reader["roomId"];
			ret.GameId = (string)reader["gameId"];
			ret.GameType = (string)reader["gameType"];
			ret.ChargeType = (string)reader["chargeType"];
			ret.RoundNum = (string)reader["roundNum"];
			ret.PlayerNum = (string)reader["playerNum"];
			ret.UidAr = (string)reader["uidAr"];
			ret.OwnerUid = (string)reader["ownerUid"];
			ret.DestUid = (string)reader["destUid"];
			ret.UseNum = (string)reader["useNum"];
			ret.LastNum = (string)reader["lastNum"];
			ret.CreateTime = (string)reader["createTime"];
			ret.Statue = (string)reader["statue"];
			ret.ServerId = (string)reader["serverId"];
			ret.UnidId = (string)reader["unidId"];
			ret.Duid = (string)reader["duid"];
			return ret;
		}
	}


	#endregion

	#region  MO

	/// <summary>
	/// 【表 log_consume 的操作类】
	/// </summary>
	public class LogConsumeMO : DataManagerBase
	{

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "routeData">路由数据</param>
		public LogConsumeMO(object routeData = null) : base(routeData) { }

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">连接字符串名称</param>
		public LogConsumeMO(string connectionStringName) : base(connectionStringName) { }

		#region  Get方法集合

		/// <summary>
		/// 按 PK（主键） 查询
		/// </summary>
		/// <param name="tm">事务管理对象</param>
		/// <param name = "remarkid"></param>
		/// <return></return>
		public virtual LogConsumeEO GetByPK(string remarkid, TransactionManager tm = null)
		{
			const string sql = @"SELECT remarkid, roomId, gameId, gameType, chargeType, roundNum, playerNum, uidAr, ownerUid, destUid, useNum, lastNum, createTime, statue, serverId, unidId, duid FROM log_consume WHERE remarkid=@remarkid";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@remarkid", remarkid, DbType.String, 96)
							.ExecSingle<LogConsumeEO>(LogConsumeEO.GetItem, tm);
		}




		#region  按 RoomId（字段） 查询

		/// <summary>
		/// 按 RoomId（字段） 查询
		/// </summary>
		/// <param name = "roomId"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByRoomId(string roomId)
		{
			return GetByRoomId(roomId, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 RoomId（字段） 查询
		/// </summary>
		/// <param name = "roomId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByRoomId(string roomId, TransactionManager tm)
		{
			return GetByRoomId(roomId, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 RoomId（字段） 查询
		/// </summary>
		/// <param name = "roomId"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByRoomId(string roomId, int top)
		{
			return GetByRoomId(roomId, top, string.Empty, null);
		}

		/// <summary>
		/// 按 RoomId（字段） 查询
		/// </summary>
		/// <param name = "roomId"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByRoomId(string roomId, int top, TransactionManager tm)
		{
			return GetByRoomId(roomId, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 RoomId（字段） 查询
		/// </summary>
		/// <param name = "roomId"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByRoomId(string roomId, string sort)
		{
			return GetByRoomId(roomId, 0, sort, null);
		}

		/// <summary>
		/// 按 RoomId（字段） 查询
		/// </summary>
		/// <param name = "roomId"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByRoomId(string roomId, string sort, TransactionManager tm)
		{
			return GetByRoomId(roomId, 0, sort, tm);
		}

		/// <summary>
		/// 按 RoomId（字段） 查询
		/// </summary>
		/// <param name = "roomId"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByRoomId(string roomId, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} remarkid, roomId, gameId, gameType, chargeType, roundNum, playerNum, uidAr, ownerUid, destUid, useNum, lastNum, createTime, statue, serverId, unidId, duid FROM log_consume WHERE roomId=@RoomId";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@RoomId", roomId, DbType.String, 33)
							.ExecList<LogConsumeEO>(LogConsumeEO.GetItem, tm);
		}

		#endregion

		#region  按 GameId（字段） 查询

		/// <summary>
		/// 按 GameId（字段） 查询
		/// </summary>
		/// <param name = "gameId"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByGameId(string gameId)
		{
			return GetByGameId(gameId, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 GameId（字段） 查询
		/// </summary>
		/// <param name = "gameId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByGameId(string gameId, TransactionManager tm)
		{
			return GetByGameId(gameId, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 GameId（字段） 查询
		/// </summary>
		/// <param name = "gameId"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByGameId(string gameId, int top)
		{
			return GetByGameId(gameId, top, string.Empty, null);
		}

		/// <summary>
		/// 按 GameId（字段） 查询
		/// </summary>
		/// <param name = "gameId"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByGameId(string gameId, int top, TransactionManager tm)
		{
			return GetByGameId(gameId, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 GameId（字段） 查询
		/// </summary>
		/// <param name = "gameId"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByGameId(string gameId, string sort)
		{
			return GetByGameId(gameId, 0, sort, null);
		}

		/// <summary>
		/// 按 GameId（字段） 查询
		/// </summary>
		/// <param name = "gameId"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByGameId(string gameId, string sort, TransactionManager tm)
		{
			return GetByGameId(gameId, 0, sort, tm);
		}

		/// <summary>
		/// 按 GameId（字段） 查询
		/// </summary>
		/// <param name = "gameId"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByGameId(string gameId, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} remarkid, roomId, gameId, gameType, chargeType, roundNum, playerNum, uidAr, ownerUid, destUid, useNum, lastNum, createTime, statue, serverId, unidId, duid FROM log_consume WHERE gameId=@GameId";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@GameId", gameId, DbType.String, 96)
							.ExecList<LogConsumeEO>(LogConsumeEO.GetItem, tm);
		}

		#endregion

		#region  按 GameType（字段） 查询

		/// <summary>
		/// 按 GameType（字段） 查询
		/// </summary>
		/// <param name = "gameType"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByGameType(string gameType)
		{
			return GetByGameType(gameType, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 GameType（字段） 查询
		/// </summary>
		/// <param name = "gameType"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByGameType(string gameType, TransactionManager tm)
		{
			return GetByGameType(gameType, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 GameType（字段） 查询
		/// </summary>
		/// <param name = "gameType"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByGameType(string gameType, int top)
		{
			return GetByGameType(gameType, top, string.Empty, null);
		}

		/// <summary>
		/// 按 GameType（字段） 查询
		/// </summary>
		/// <param name = "gameType"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByGameType(string gameType, int top, TransactionManager tm)
		{
			return GetByGameType(gameType, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 GameType（字段） 查询
		/// </summary>
		/// <param name = "gameType"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByGameType(string gameType, string sort)
		{
			return GetByGameType(gameType, 0, sort, null);
		}

		/// <summary>
		/// 按 GameType（字段） 查询
		/// </summary>
		/// <param name = "gameType"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByGameType(string gameType, string sort, TransactionManager tm)
		{
			return GetByGameType(gameType, 0, sort, tm);
		}

		/// <summary>
		/// 按 GameType（字段） 查询
		/// </summary>
		/// <param name = "gameType"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByGameType(string gameType, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} remarkid, roomId, gameId, gameType, chargeType, roundNum, playerNum, uidAr, ownerUid, destUid, useNum, lastNum, createTime, statue, serverId, unidId, duid FROM log_consume WHERE gameType=@GameType";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@GameType", gameType, DbType.String, 96)
							.ExecList<LogConsumeEO>(LogConsumeEO.GetItem, tm);
		}

		#endregion

		#region  按 ChargeType（字段） 查询

		/// <summary>
		/// 按 ChargeType（字段） 查询
		/// </summary>
		/// <param name = "chargeType"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByChargeType(string chargeType)
		{
			return GetByChargeType(chargeType, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 ChargeType（字段） 查询
		/// </summary>
		/// <param name = "chargeType"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByChargeType(string chargeType, TransactionManager tm)
		{
			return GetByChargeType(chargeType, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 ChargeType（字段） 查询
		/// </summary>
		/// <param name = "chargeType"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByChargeType(string chargeType, int top)
		{
			return GetByChargeType(chargeType, top, string.Empty, null);
		}

		/// <summary>
		/// 按 ChargeType（字段） 查询
		/// </summary>
		/// <param name = "chargeType"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByChargeType(string chargeType, int top, TransactionManager tm)
		{
			return GetByChargeType(chargeType, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 ChargeType（字段） 查询
		/// </summary>
		/// <param name = "chargeType"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByChargeType(string chargeType, string sort)
		{
			return GetByChargeType(chargeType, 0, sort, null);
		}

		/// <summary>
		/// 按 ChargeType（字段） 查询
		/// </summary>
		/// <param name = "chargeType"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByChargeType(string chargeType, string sort, TransactionManager tm)
		{
			return GetByChargeType(chargeType, 0, sort, tm);
		}

		/// <summary>
		/// 按 ChargeType（字段） 查询
		/// </summary>
		/// <param name = "chargeType"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByChargeType(string chargeType, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} remarkid, roomId, gameId, gameType, chargeType, roundNum, playerNum, uidAr, ownerUid, destUid, useNum, lastNum, createTime, statue, serverId, unidId, duid FROM log_consume WHERE chargeType=@ChargeType";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@ChargeType", chargeType, DbType.String, 96)
							.ExecList<LogConsumeEO>(LogConsumeEO.GetItem, tm);
		}

		#endregion

		#region  按 RoundNum（字段） 查询

		/// <summary>
		/// 按 RoundNum（字段） 查询
		/// </summary>
		/// <param name = "roundNum"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByRoundNum(string roundNum)
		{
			return GetByRoundNum(roundNum, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 RoundNum（字段） 查询
		/// </summary>
		/// <param name = "roundNum"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByRoundNum(string roundNum, TransactionManager tm)
		{
			return GetByRoundNum(roundNum, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 RoundNum（字段） 查询
		/// </summary>
		/// <param name = "roundNum"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByRoundNum(string roundNum, int top)
		{
			return GetByRoundNum(roundNum, top, string.Empty, null);
		}

		/// <summary>
		/// 按 RoundNum（字段） 查询
		/// </summary>
		/// <param name = "roundNum"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByRoundNum(string roundNum, int top, TransactionManager tm)
		{
			return GetByRoundNum(roundNum, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 RoundNum（字段） 查询
		/// </summary>
		/// <param name = "roundNum"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByRoundNum(string roundNum, string sort)
		{
			return GetByRoundNum(roundNum, 0, sort, null);
		}

		/// <summary>
		/// 按 RoundNum（字段） 查询
		/// </summary>
		/// <param name = "roundNum"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByRoundNum(string roundNum, string sort, TransactionManager tm)
		{
			return GetByRoundNum(roundNum, 0, sort, tm);
		}

		/// <summary>
		/// 按 RoundNum（字段） 查询
		/// </summary>
		/// <param name = "roundNum"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByRoundNum(string roundNum, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} remarkid, roomId, gameId, gameType, chargeType, roundNum, playerNum, uidAr, ownerUid, destUid, useNum, lastNum, createTime, statue, serverId, unidId, duid FROM log_consume WHERE roundNum=@RoundNum";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@RoundNum", roundNum, DbType.String, 96)
							.ExecList<LogConsumeEO>(LogConsumeEO.GetItem, tm);
		}

		#endregion

		#region  按 PlayerNum（字段） 查询

		/// <summary>
		/// 按 PlayerNum（字段） 查询
		/// </summary>
		/// <param name = "playerNum"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByPlayerNum(string playerNum)
		{
			return GetByPlayerNum(playerNum, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 PlayerNum（字段） 查询
		/// </summary>
		/// <param name = "playerNum"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByPlayerNum(string playerNum, TransactionManager tm)
		{
			return GetByPlayerNum(playerNum, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 PlayerNum（字段） 查询
		/// </summary>
		/// <param name = "playerNum"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByPlayerNum(string playerNum, int top)
		{
			return GetByPlayerNum(playerNum, top, string.Empty, null);
		}

		/// <summary>
		/// 按 PlayerNum（字段） 查询
		/// </summary>
		/// <param name = "playerNum"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByPlayerNum(string playerNum, int top, TransactionManager tm)
		{
			return GetByPlayerNum(playerNum, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 PlayerNum（字段） 查询
		/// </summary>
		/// <param name = "playerNum"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByPlayerNum(string playerNum, string sort)
		{
			return GetByPlayerNum(playerNum, 0, sort, null);
		}

		/// <summary>
		/// 按 PlayerNum（字段） 查询
		/// </summary>
		/// <param name = "playerNum"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByPlayerNum(string playerNum, string sort, TransactionManager tm)
		{
			return GetByPlayerNum(playerNum, 0, sort, tm);
		}

		/// <summary>
		/// 按 PlayerNum（字段） 查询
		/// </summary>
		/// <param name = "playerNum"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByPlayerNum(string playerNum, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} remarkid, roomId, gameId, gameType, chargeType, roundNum, playerNum, uidAr, ownerUid, destUid, useNum, lastNum, createTime, statue, serverId, unidId, duid FROM log_consume WHERE playerNum=@PlayerNum";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@PlayerNum", playerNum, DbType.String, 39)
							.ExecList<LogConsumeEO>(LogConsumeEO.GetItem, tm);
		}

		#endregion

		#region  按 UidAr（字段） 查询

		/// <summary>
		/// 按 UidAr（字段） 查询
		/// </summary>
		/// <param name = "uidAr"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByUidAr(string uidAr)
		{
			return GetByUidAr(uidAr, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 UidAr（字段） 查询
		/// </summary>
		/// <param name = "uidAr"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByUidAr(string uidAr, TransactionManager tm)
		{
			return GetByUidAr(uidAr, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 UidAr（字段） 查询
		/// </summary>
		/// <param name = "uidAr"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByUidAr(string uidAr, int top)
		{
			return GetByUidAr(uidAr, top, string.Empty, null);
		}

		/// <summary>
		/// 按 UidAr（字段） 查询
		/// </summary>
		/// <param name = "uidAr"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByUidAr(string uidAr, int top, TransactionManager tm)
		{
			return GetByUidAr(uidAr, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 UidAr（字段） 查询
		/// </summary>
		/// <param name = "uidAr"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByUidAr(string uidAr, string sort)
		{
			return GetByUidAr(uidAr, 0, sort, null);
		}

		/// <summary>
		/// 按 UidAr（字段） 查询
		/// </summary>
		/// <param name = "uidAr"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByUidAr(string uidAr, string sort, TransactionManager tm)
		{
			return GetByUidAr(uidAr, 0, sort, tm);
		}

		/// <summary>
		/// 按 UidAr（字段） 查询
		/// </summary>
		/// <param name = "uidAr"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByUidAr(string uidAr, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} remarkid, roomId, gameId, gameType, chargeType, roundNum, playerNum, uidAr, ownerUid, destUid, useNum, lastNum, createTime, statue, serverId, unidId, duid FROM log_consume WHERE uidAr=@UidAr";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@UidAr", uidAr, DbType.String, 96)
							.ExecList<LogConsumeEO>(LogConsumeEO.GetItem, tm);
		}

		#endregion

		#region  按 OwnerUid（字段） 查询

		/// <summary>
		/// 按 OwnerUid（字段） 查询
		/// </summary>
		/// <param name = "ownerUid"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByOwnerUid(string ownerUid)
		{
			return GetByOwnerUid(ownerUid, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 OwnerUid（字段） 查询
		/// </summary>
		/// <param name = "ownerUid"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByOwnerUid(string ownerUid, TransactionManager tm)
		{
			return GetByOwnerUid(ownerUid, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 OwnerUid（字段） 查询
		/// </summary>
		/// <param name = "ownerUid"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByOwnerUid(string ownerUid, int top)
		{
			return GetByOwnerUid(ownerUid, top, string.Empty, null);
		}

		/// <summary>
		/// 按 OwnerUid（字段） 查询
		/// </summary>
		/// <param name = "ownerUid"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByOwnerUid(string ownerUid, int top, TransactionManager tm)
		{
			return GetByOwnerUid(ownerUid, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 OwnerUid（字段） 查询
		/// </summary>
		/// <param name = "ownerUid"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByOwnerUid(string ownerUid, string sort)
		{
			return GetByOwnerUid(ownerUid, 0, sort, null);
		}

		/// <summary>
		/// 按 OwnerUid（字段） 查询
		/// </summary>
		/// <param name = "ownerUid"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByOwnerUid(string ownerUid, string sort, TransactionManager tm)
		{
			return GetByOwnerUid(ownerUid, 0, sort, tm);
		}

		/// <summary>
		/// 按 OwnerUid（字段） 查询
		/// </summary>
		/// <param name = "ownerUid"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByOwnerUid(string ownerUid, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} remarkid, roomId, gameId, gameType, chargeType, roundNum, playerNum, uidAr, ownerUid, destUid, useNum, lastNum, createTime, statue, serverId, unidId, duid FROM log_consume WHERE ownerUid=@OwnerUid";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@OwnerUid", ownerUid, DbType.String, 96)
							.ExecList<LogConsumeEO>(LogConsumeEO.GetItem, tm);
		}

		#endregion

		#region  按 DestUid（字段） 查询

		/// <summary>
		/// 按 DestUid（字段） 查询
		/// </summary>
		/// <param name = "destUid"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByDestUid(string destUid)
		{
			return GetByDestUid(destUid, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 DestUid（字段） 查询
		/// </summary>
		/// <param name = "destUid"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByDestUid(string destUid, TransactionManager tm)
		{
			return GetByDestUid(destUid, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 DestUid（字段） 查询
		/// </summary>
		/// <param name = "destUid"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByDestUid(string destUid, int top)
		{
			return GetByDestUid(destUid, top, string.Empty, null);
		}

		/// <summary>
		/// 按 DestUid（字段） 查询
		/// </summary>
		/// <param name = "destUid"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByDestUid(string destUid, int top, TransactionManager tm)
		{
			return GetByDestUid(destUid, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 DestUid（字段） 查询
		/// </summary>
		/// <param name = "destUid"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByDestUid(string destUid, string sort)
		{
			return GetByDestUid(destUid, 0, sort, null);
		}

		/// <summary>
		/// 按 DestUid（字段） 查询
		/// </summary>
		/// <param name = "destUid"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByDestUid(string destUid, string sort, TransactionManager tm)
		{
			return GetByDestUid(destUid, 0, sort, tm);
		}

		/// <summary>
		/// 按 DestUid（字段） 查询
		/// </summary>
		/// <param name = "destUid"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByDestUid(string destUid, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} remarkid, roomId, gameId, gameType, chargeType, roundNum, playerNum, uidAr, ownerUid, destUid, useNum, lastNum, createTime, statue, serverId, unidId, duid FROM log_consume WHERE destUid=@DestUid";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@DestUid", destUid, DbType.String, 96)
							.ExecList<LogConsumeEO>(LogConsumeEO.GetItem, tm);
		}

		#endregion

		#region  按 UseNum（字段） 查询

		/// <summary>
		/// 按 UseNum（字段） 查询
		/// </summary>
		/// <param name = "useNum"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByUseNum(string useNum)
		{
			return GetByUseNum(useNum, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 UseNum（字段） 查询
		/// </summary>
		/// <param name = "useNum"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByUseNum(string useNum, TransactionManager tm)
		{
			return GetByUseNum(useNum, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 UseNum（字段） 查询
		/// </summary>
		/// <param name = "useNum"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByUseNum(string useNum, int top)
		{
			return GetByUseNum(useNum, top, string.Empty, null);
		}

		/// <summary>
		/// 按 UseNum（字段） 查询
		/// </summary>
		/// <param name = "useNum"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByUseNum(string useNum, int top, TransactionManager tm)
		{
			return GetByUseNum(useNum, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 UseNum（字段） 查询
		/// </summary>
		/// <param name = "useNum"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByUseNum(string useNum, string sort)
		{
			return GetByUseNum(useNum, 0, sort, null);
		}

		/// <summary>
		/// 按 UseNum（字段） 查询
		/// </summary>
		/// <param name = "useNum"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByUseNum(string useNum, string sort, TransactionManager tm)
		{
			return GetByUseNum(useNum, 0, sort, tm);
		}

		/// <summary>
		/// 按 UseNum（字段） 查询
		/// </summary>
		/// <param name = "useNum"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByUseNum(string useNum, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} remarkid, roomId, gameId, gameType, chargeType, roundNum, playerNum, uidAr, ownerUid, destUid, useNum, lastNum, createTime, statue, serverId, unidId, duid FROM log_consume WHERE useNum=@UseNum";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@UseNum", useNum, DbType.String, 96)
							.ExecList<LogConsumeEO>(LogConsumeEO.GetItem, tm);
		}

		#endregion

		#region  按 LastNum（字段） 查询

		/// <summary>
		/// 按 LastNum（字段） 查询
		/// </summary>
		/// <param name = "lastNum"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByLastNum(string lastNum)
		{
			return GetByLastNum(lastNum, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 LastNum（字段） 查询
		/// </summary>
		/// <param name = "lastNum"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByLastNum(string lastNum, TransactionManager tm)
		{
			return GetByLastNum(lastNum, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 LastNum（字段） 查询
		/// </summary>
		/// <param name = "lastNum"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByLastNum(string lastNum, int top)
		{
			return GetByLastNum(lastNum, top, string.Empty, null);
		}

		/// <summary>
		/// 按 LastNum（字段） 查询
		/// </summary>
		/// <param name = "lastNum"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByLastNum(string lastNum, int top, TransactionManager tm)
		{
			return GetByLastNum(lastNum, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 LastNum（字段） 查询
		/// </summary>
		/// <param name = "lastNum"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByLastNum(string lastNum, string sort)
		{
			return GetByLastNum(lastNum, 0, sort, null);
		}

		/// <summary>
		/// 按 LastNum（字段） 查询
		/// </summary>
		/// <param name = "lastNum"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByLastNum(string lastNum, string sort, TransactionManager tm)
		{
			return GetByLastNum(lastNum, 0, sort, tm);
		}

		/// <summary>
		/// 按 LastNum（字段） 查询
		/// </summary>
		/// <param name = "lastNum"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByLastNum(string lastNum, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} remarkid, roomId, gameId, gameType, chargeType, roundNum, playerNum, uidAr, ownerUid, destUid, useNum, lastNum, createTime, statue, serverId, unidId, duid FROM log_consume WHERE lastNum=@LastNum";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@LastNum", lastNum, DbType.String, 96)
							.ExecList<LogConsumeEO>(LogConsumeEO.GetItem, tm);
		}

		#endregion

		#region  按 CreateTime（字段） 查询

		/// <summary>
		/// 按 CreateTime（字段） 查询
		/// </summary>
		/// <param name = "createTime"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByCreateTime(string createTime)
		{
			return GetByCreateTime(createTime, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 CreateTime（字段） 查询
		/// </summary>
		/// <param name = "createTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByCreateTime(string createTime, TransactionManager tm)
		{
			return GetByCreateTime(createTime, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 CreateTime（字段） 查询
		/// </summary>
		/// <param name = "createTime"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByCreateTime(string createTime, int top)
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
		public virtual IEnumerable<LogConsumeEO> GetByCreateTime(string createTime, int top, TransactionManager tm)
		{
			return GetByCreateTime(createTime, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 CreateTime（字段） 查询
		/// </summary>
		/// <param name = "createTime"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByCreateTime(string createTime, string sort)
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
		public virtual IEnumerable<LogConsumeEO> GetByCreateTime(string createTime, string sort, TransactionManager tm)
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
		public virtual IEnumerable<LogConsumeEO> GetByCreateTime(string createTime, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} remarkid, roomId, gameId, gameType, chargeType, roundNum, playerNum, uidAr, ownerUid, destUid, useNum, lastNum, createTime, statue, serverId, unidId, duid FROM log_consume WHERE createTime=@CreateTime";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@CreateTime", createTime, DbType.String, 96)
							.ExecList<LogConsumeEO>(LogConsumeEO.GetItem, tm);
		}

		#endregion

		#region  按 Statue（字段） 查询

		/// <summary>
		/// 按 Statue（字段） 查询
		/// </summary>
		/// <param name = "statue"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByStatue(string statue)
		{
			return GetByStatue(statue, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 Statue（字段） 查询
		/// </summary>
		/// <param name = "statue"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByStatue(string statue, TransactionManager tm)
		{
			return GetByStatue(statue, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 Statue（字段） 查询
		/// </summary>
		/// <param name = "statue"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByStatue(string statue, int top)
		{
			return GetByStatue(statue, top, string.Empty, null);
		}

		/// <summary>
		/// 按 Statue（字段） 查询
		/// </summary>
		/// <param name = "statue"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByStatue(string statue, int top, TransactionManager tm)
		{
			return GetByStatue(statue, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 Statue（字段） 查询
		/// </summary>
		/// <param name = "statue"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByStatue(string statue, string sort)
		{
			return GetByStatue(statue, 0, sort, null);
		}

		/// <summary>
		/// 按 Statue（字段） 查询
		/// </summary>
		/// <param name = "statue"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByStatue(string statue, string sort, TransactionManager tm)
		{
			return GetByStatue(statue, 0, sort, tm);
		}

		/// <summary>
		/// 按 Statue（字段） 查询
		/// </summary>
		/// <param name = "statue"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByStatue(string statue, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} remarkid, roomId, gameId, gameType, chargeType, roundNum, playerNum, uidAr, ownerUid, destUid, useNum, lastNum, createTime, statue, serverId, unidId, duid FROM log_consume WHERE statue=@Statue";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Statue", statue, DbType.String, 96)
							.ExecList<LogConsumeEO>(LogConsumeEO.GetItem, tm);
		}

		#endregion

		#region  按 ServerId（字段） 查询

		/// <summary>
		/// 按 ServerId（字段） 查询
		/// </summary>
		/// <param name = "serverId"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByServerId(string serverId)
		{
			return GetByServerId(serverId, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 ServerId（字段） 查询
		/// </summary>
		/// <param name = "serverId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByServerId(string serverId, TransactionManager tm)
		{
			return GetByServerId(serverId, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 ServerId（字段） 查询
		/// </summary>
		/// <param name = "serverId"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByServerId(string serverId, int top)
		{
			return GetByServerId(serverId, top, string.Empty, null);
		}

		/// <summary>
		/// 按 ServerId（字段） 查询
		/// </summary>
		/// <param name = "serverId"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByServerId(string serverId, int top, TransactionManager tm)
		{
			return GetByServerId(serverId, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 ServerId（字段） 查询
		/// </summary>
		/// <param name = "serverId"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByServerId(string serverId, string sort)
		{
			return GetByServerId(serverId, 0, sort, null);
		}

		/// <summary>
		/// 按 ServerId（字段） 查询
		/// </summary>
		/// <param name = "serverId"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByServerId(string serverId, string sort, TransactionManager tm)
		{
			return GetByServerId(serverId, 0, sort, tm);
		}

		/// <summary>
		/// 按 ServerId（字段） 查询
		/// </summary>
		/// <param name = "serverId"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByServerId(string serverId, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} remarkid, roomId, gameId, gameType, chargeType, roundNum, playerNum, uidAr, ownerUid, destUid, useNum, lastNum, createTime, statue, serverId, unidId, duid FROM log_consume WHERE serverId=@ServerId";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@ServerId", serverId, DbType.String, 96)
							.ExecList<LogConsumeEO>(LogConsumeEO.GetItem, tm);
		}

		#endregion

		#region  按 UnidId（字段） 查询

		/// <summary>
		/// 按 UnidId（字段） 查询
		/// </summary>
		/// <param name = "unidId"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByUnidId(string unidId)
		{
			return GetByUnidId(unidId, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 UnidId（字段） 查询
		/// </summary>
		/// <param name = "unidId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByUnidId(string unidId, TransactionManager tm)
		{
			return GetByUnidId(unidId, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 UnidId（字段） 查询
		/// </summary>
		/// <param name = "unidId"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByUnidId(string unidId, int top)
		{
			return GetByUnidId(unidId, top, string.Empty, null);
		}

		/// <summary>
		/// 按 UnidId（字段） 查询
		/// </summary>
		/// <param name = "unidId"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByUnidId(string unidId, int top, TransactionManager tm)
		{
			return GetByUnidId(unidId, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 UnidId（字段） 查询
		/// </summary>
		/// <param name = "unidId"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByUnidId(string unidId, string sort)
		{
			return GetByUnidId(unidId, 0, sort, null);
		}

		/// <summary>
		/// 按 UnidId（字段） 查询
		/// </summary>
		/// <param name = "unidId"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByUnidId(string unidId, string sort, TransactionManager tm)
		{
			return GetByUnidId(unidId, 0, sort, tm);
		}

		/// <summary>
		/// 按 UnidId（字段） 查询
		/// </summary>
		/// <param name = "unidId"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByUnidId(string unidId, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} remarkid, roomId, gameId, gameType, chargeType, roundNum, playerNum, uidAr, ownerUid, destUid, useNum, lastNum, createTime, statue, serverId, unidId, duid FROM log_consume WHERE unidId=@UnidId";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@UnidId", unidId, DbType.String, 96)
							.ExecList<LogConsumeEO>(LogConsumeEO.GetItem, tm);
		}

		#endregion

		#region  按 Duid（字段） 查询

		/// <summary>
		/// 按 Duid（字段） 查询
		/// </summary>
		/// <param name = "duid"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByDuid(string duid)
		{
			return GetByDuid(duid, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 Duid（字段） 查询
		/// </summary>
		/// <param name = "duid"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByDuid(string duid, TransactionManager tm)
		{
			return GetByDuid(duid, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 Duid（字段） 查询
		/// </summary>
		/// <param name = "duid"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByDuid(string duid, int top)
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
		public virtual IEnumerable<LogConsumeEO> GetByDuid(string duid, int top, TransactionManager tm)
		{
			return GetByDuid(duid, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 Duid（字段） 查询
		/// </summary>
		/// <param name = "duid"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetByDuid(string duid, string sort)
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
		public virtual IEnumerable<LogConsumeEO> GetByDuid(string duid, string sort, TransactionManager tm)
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
		public virtual IEnumerable<LogConsumeEO> GetByDuid(string duid, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} remarkid, roomId, gameId, gameType, chargeType, roundNum, playerNum, uidAr, ownerUid, destUid, useNum, lastNum, createTime, statue, serverId, unidId, duid FROM log_consume WHERE duid=@Duid";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Duid", duid, DbType.String, 96)
							.ExecList<LogConsumeEO>(LogConsumeEO.GetItem, tm);
		}

		#endregion

		#region  自定义条件查询

		/// <summary>
		/// 获取所有数据
		/// </summary>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetAll(TransactionManager tm = null)
		{
			return GetTopSort(string.Empty, null, -1, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "values">where子句中定义的参数值集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> Get(string where, params object[] values)
		{
			return GetTopSort(where, -1, string.Empty, null, values);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "paras">where子句中定义的参数集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> Get(string where, IEnumerable<DbParameter> paras)
		{
			return GetTopSort(where, paras, -1, string.Empty, null);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> Get(string where, TransactionManager tm)
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
		public virtual IEnumerable<LogConsumeEO> Get(string where, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<LogConsumeEO> Get(string where, IEnumerable<DbParameter> paras, TransactionManager tm)
		{
			return GetTopSort(where, paras, -1, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetTop(string where, int top)
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
		public virtual IEnumerable<LogConsumeEO> GetTop(string where, int top, params object[] values)
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
		public virtual IEnumerable<LogConsumeEO> GetTop(string where, IEnumerable<DbParameter> paras, int top)
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
		public virtual IEnumerable<LogConsumeEO> GetTop(string where, int top, TransactionManager tm)
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
		public virtual IEnumerable<LogConsumeEO> GetTop(string where, int top, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<LogConsumeEO> GetTop(string where, IEnumerable<DbParameter> paras, int top, TransactionManager tm)
		{
			return GetTopSort(where, paras, top, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogConsumeEO> GetSort(string where, string sort)
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
		public virtual IEnumerable<LogConsumeEO> GetSort(string where, string sort, params object[] values)
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
		public virtual IEnumerable<LogConsumeEO> GetSort(string where, IEnumerable<DbParameter> paras, string sort)
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
		public virtual IEnumerable<LogConsumeEO> GetSort(string where, string sort, TransactionManager tm)
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
		public virtual IEnumerable<LogConsumeEO> GetSort(string where, string sort, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<LogConsumeEO> GetSort(string where, IEnumerable<DbParameter> paras, string sort, TransactionManager tm)
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
		public virtual IEnumerable<LogConsumeEO> GetTopSort(string where, int top, string sort)
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
		public virtual IEnumerable<LogConsumeEO> GetTopSort(string where, int top, string sort, params object[] values)
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
		public virtual IEnumerable<LogConsumeEO> GetTopSort(string where, IEnumerable<DbParameter> paras, int top, string sort)
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
		public virtual IEnumerable<LogConsumeEO> GetTopSort(string where, int top, string sort, TransactionManager tm)
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
		public virtual IEnumerable<LogConsumeEO> GetTopSort(string where, int top, string sort, TransactionManager tm, params object[] values)
		{
			const string format = @"SELECT {0} remarkid, roomId, gameId, gameType, chargeType, roundNum, playerNum, uidAr, ownerUid, destUid, useNum, lastNum, createTime, statue, serverId, unidId, duid FROM log_consume";
			string sql = format;

			if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameters(values)
							.ExecList<LogConsumeEO>(LogConsumeEO.GetItem, tm);
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
		public virtual IEnumerable<LogConsumeEO> GetTopSort(string where, IEnumerable<DbParameter> paras, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} remarkid, roomId, gameId, gameType, chargeType, roundNum, playerNum, uidAr, ownerUid, destUid, useNum, lastNum, createTime, statue, serverId, unidId, duid FROM log_consume";
			string sql = format;

			if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddParameters(paras)
							.ExecList<LogConsumeEO>(LogConsumeEO.GetItem, tm);
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
			const string format = @"SELECT remarkid, roomId, gameId, gameType, chargeType, roundNum, playerNum, uidAr, ownerUid, destUid, useNum, lastNum, createTime, statue, serverId, unidId, duid FROM log_consume {0} {1}";
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
		public virtual List<LogConsumeEO> GetPageList(int pageIndex , int pageSize, string where = null, string sort = null, IEnumerable<DbParameter> paras = null)
		{
			var pager = GetPager(pageSize, where, sort);

			pager.AddParameters(paras);
			return pager.GetPageList<LogConsumeEO>(pageIndex);
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
		public virtual IEnumerable<LogConsumeEO> GetPageMutil(int pageIndex , int pageSize, string where = null, string sort = null, IEnumerable<DbParameter> paras = null)
		{
			var pager = GetPager(pageSize, where, sort);

			pager.AddParameters(paras);
			return pager.GetPageMutil<LogConsumeEO>(pageIndex);
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
		public virtual int Add(LogConsumeEO item, TransactionManager tm = null)
		{
			const string sql = @"INSERT INTO log_consume (remarkid, roomId, gameId, gameType, chargeType, roundNum, playerNum, uidAr, ownerUid, destUid, useNum, lastNum, createTime, statue, serverId, unidId, duid) VALUES (@remarkid, @roomId, @gameId, @gameType, @chargeType, @roundNum, @playerNum, @uidAr, @ownerUid, @destUid, @useNum, @lastNum, @createTime, @statue, @serverId, @unidId, @duid) ";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@remarkid", item.Remarkid, DbType.String, 96)
							.AddInParameter("@roomId", item.RoomId, DbType.String, 33)
							.AddInParameter("@gameId", item.GameId, DbType.String, 96)
							.AddInParameter("@gameType", item.GameType, DbType.String, 96)
							.AddInParameter("@chargeType", item.ChargeType, DbType.String, 96)
							.AddInParameter("@roundNum", item.RoundNum, DbType.String, 96)
							.AddInParameter("@playerNum", item.PlayerNum, DbType.String, 39)
							.AddInParameter("@uidAr", item.UidAr, DbType.String, 96)
							.AddInParameter("@ownerUid", item.OwnerUid, DbType.String, 96)
							.AddInParameter("@destUid", item.DestUid, DbType.String, 96)
							.AddInParameter("@useNum", item.UseNum, DbType.String, 96)
							.AddInParameter("@lastNum", item.LastNum, DbType.String, 96)
							.AddInParameter("@createTime", item.CreateTime, DbType.String, 96)
							.AddInParameter("@statue", item.Statue, DbType.String, 96)
							.AddInParameter("@serverId", item.ServerId, DbType.String, 96)
							.AddInParameter("@unidId", item.UnidId, DbType.String, 96)
							.AddInParameter("@duid", item.Duid, DbType.String, 96)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 插入一组数据
		/// </summary>
		/// <param name = "items">要插入的实体对象集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Add(IEnumerable<LogConsumeEO> items, TransactionManager tm = null)
		{
			int ret = 0;
			const string sql = @"INSERT INTO log_consume (remarkid, roomId, gameId, gameType, chargeType, roundNum, playerNum, uidAr, ownerUid, destUid, useNum, lastNum, createTime, statue, serverId, unidId, duid) VALUES (@remarkid, @roomId, @gameId, @gameType, @chargeType, @roundNum, @playerNum, @uidAr, @ownerUid, @destUid, @useNum, @lastNum, @createTime, @statue, @serverId, @unidId, @duid) ";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@remarkid", DbType.String, 96)
									.AddParameter("@roomId", DbType.String, 33)
									.AddParameter("@gameId", DbType.String, 96)
									.AddParameter("@gameType", DbType.String, 96)
									.AddParameter("@chargeType", DbType.String, 96)
									.AddParameter("@roundNum", DbType.String, 96)
									.AddParameter("@playerNum", DbType.String, 39)
									.AddParameter("@uidAr", DbType.String, 96)
									.AddParameter("@ownerUid", DbType.String, 96)
									.AddParameter("@destUid", DbType.String, 96)
									.AddParameter("@useNum", DbType.String, 96)
									.AddParameter("@lastNum", DbType.String, 96)
									.AddParameter("@createTime", DbType.String, 96)
									.AddParameter("@statue", DbType.String, 96)
									.AddParameter("@serverId", DbType.String, 96)
									.AddParameter("@unidId", DbType.String, 96)
									.AddParameter("@duid", DbType.String, 96);

			foreach (LogConsumeEO item in items)
			{
				sqlDao
					.SetParameterValue("@remarkid", item.Remarkid)
					.SetParameterValue("@roomId", item.RoomId)
					.SetParameterValue("@gameId", item.GameId)
					.SetParameterValue("@gameType", item.GameType)
					.SetParameterValue("@chargeType", item.ChargeType)
					.SetParameterValue("@roundNum", item.RoundNum)
					.SetParameterValue("@playerNum", item.PlayerNum)
					.SetParameterValue("@uidAr", item.UidAr)
					.SetParameterValue("@ownerUid", item.OwnerUid)
					.SetParameterValue("@destUid", item.DestUid)
					.SetParameterValue("@useNum", item.UseNum)
					.SetParameterValue("@lastNum", item.LastNum)
					.SetParameterValue("@createTime", item.CreateTime)
					.SetParameterValue("@statue", item.Statue)
					.SetParameterValue("@serverId", item.ServerId)
					.SetParameterValue("@unidId", item.UnidId)
					.SetParameterValue("@duid", item.Duid)
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
		public virtual int Put(LogConsumeEO item, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_consume SET remarkid=@remarkid, roomId=@roomId, gameId=@gameId, gameType=@gameType, chargeType=@chargeType, roundNum=@roundNum, playerNum=@playerNum, uidAr=@uidAr, ownerUid=@ownerUid, destUid=@destUid, useNum=@useNum, lastNum=@lastNum, createTime=@createTime, statue=@statue, serverId=@serverId, unidId=@unidId, duid=@duid WHERE remarkid=@OriginalRemarkid";
			return Database.CreateSqlDao (sql)
							.AddInParameter("@OriginalRemarkid", (item.HasOriginal) ? item.OriginalRemarkid : item.Remarkid, DbType.String, 96)
							.AddInParameter("@remarkid", item.Remarkid, DbType.String, 96)
							.AddInParameter("@roomId", item.RoomId, DbType.String, 33)
							.AddInParameter("@gameId", item.GameId, DbType.String, 96)
							.AddInParameter("@gameType", item.GameType, DbType.String, 96)
							.AddInParameter("@chargeType", item.ChargeType, DbType.String, 96)
							.AddInParameter("@roundNum", item.RoundNum, DbType.String, 96)
							.AddInParameter("@playerNum", item.PlayerNum, DbType.String, 39)
							.AddInParameter("@uidAr", item.UidAr, DbType.String, 96)
							.AddInParameter("@ownerUid", item.OwnerUid, DbType.String, 96)
							.AddInParameter("@destUid", item.DestUid, DbType.String, 96)
							.AddInParameter("@useNum", item.UseNum, DbType.String, 96)
							.AddInParameter("@lastNum", item.LastNum, DbType.String, 96)
							.AddInParameter("@createTime", item.CreateTime, DbType.String, 96)
							.AddInParameter("@statue", item.Statue, DbType.String, 96)
							.AddInParameter("@serverId", item.ServerId, DbType.String, 96)
							.AddInParameter("@unidId", item.UnidId, DbType.String, 96)
							.AddInParameter("@duid", item.Duid, DbType.String, 96)
							.ExecNonQuery(tm);
		}


		/// <summary>
		/// 更新数据
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Put(IEnumerable<LogConsumeEO> items, TransactionManager tm = null)
		{

			int ret = 0;
			const string sql = @"UPDATE log_consume SET remarkid=@remarkid, roomId=@roomId, gameId=@gameId, gameType=@gameType, chargeType=@chargeType, roundNum=@roundNum, playerNum=@playerNum, uidAr=@uidAr, ownerUid=@ownerUid, destUid=@destUid, useNum=@useNum, lastNum=@lastNum, createTime=@createTime, statue=@statue, serverId=@serverId, unidId=@unidId, duid=@duid WHERE remarkid=@OriginalRemarkid";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@OriginalRemarkid", DbType.String, 96)
									.AddParameter("@remarkid", DbType.String, 96)
									.AddParameter("@roomId", DbType.String, 33)
									.AddParameter("@gameId", DbType.String, 96)
									.AddParameter("@gameType", DbType.String, 96)
									.AddParameter("@chargeType", DbType.String, 96)
									.AddParameter("@roundNum", DbType.String, 96)
									.AddParameter("@playerNum", DbType.String, 39)
									.AddParameter("@uidAr", DbType.String, 96)
									.AddParameter("@ownerUid", DbType.String, 96)
									.AddParameter("@destUid", DbType.String, 96)
									.AddParameter("@useNum", DbType.String, 96)
									.AddParameter("@lastNum", DbType.String, 96)
									.AddParameter("@createTime", DbType.String, 96)
									.AddParameter("@statue", DbType.String, 96)
									.AddParameter("@serverId", DbType.String, 96)
									.AddParameter("@unidId", DbType.String, 96)
									.AddParameter("@duid", DbType.String, 96);

			foreach (LogConsumeEO item in items)
			{
				ret += sqlDao
							.SetParameterValue("@OriginalRemarkid", (item.HasOriginal) ? item.OriginalRemarkid : item.Remarkid)
							.SetParameterValue("@remarkid", item.Remarkid)
							.SetParameterValue("@roomId", item.RoomId)
							.SetParameterValue("@gameId", item.GameId)
							.SetParameterValue("@gameType", item.GameType)
							.SetParameterValue("@chargeType", item.ChargeType)
							.SetParameterValue("@roundNum", item.RoundNum)
							.SetParameterValue("@playerNum", item.PlayerNum)
							.SetParameterValue("@uidAr", item.UidAr)
							.SetParameterValue("@ownerUid", item.OwnerUid)
							.SetParameterValue("@destUid", item.DestUid)
							.SetParameterValue("@useNum", item.UseNum)
							.SetParameterValue("@lastNum", item.LastNum)
							.SetParameterValue("@createTime", item.CreateTime)
							.SetParameterValue("@statue", item.Statue)
							.SetParameterValue("@serverId", item.ServerId)
							.SetParameterValue("@unidId", item.UnidId)
							.SetParameterValue("@duid", item.Duid)
							.ExecNonQuery(tm);
			}
			return ret;
		}


		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "remarkid"></param>
		/// <param name = "roomId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutRoomIdByPK(string remarkid, string roomId, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_consume SET roomId = @roomId  WHERE remarkid = @remarkid";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@remarkid", remarkid, DbType.String, 96)
							.AddInParameter("@roomId", roomId, DbType.String, 33)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "remarkid"></param>
		/// <param name = "gameId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutGameIdByPK(string remarkid, string gameId, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_consume SET gameId = @gameId  WHERE remarkid = @remarkid";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@remarkid", remarkid, DbType.String, 96)
							.AddInParameter("@gameId", gameId, DbType.String, 96)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "remarkid"></param>
		/// <param name = "gameType"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutGameTypeByPK(string remarkid, string gameType, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_consume SET gameType = @gameType  WHERE remarkid = @remarkid";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@remarkid", remarkid, DbType.String, 96)
							.AddInParameter("@gameType", gameType, DbType.String, 96)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "remarkid"></param>
		/// <param name = "chargeType"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutChargeTypeByPK(string remarkid, string chargeType, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_consume SET chargeType = @chargeType  WHERE remarkid = @remarkid";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@remarkid", remarkid, DbType.String, 96)
							.AddInParameter("@chargeType", chargeType, DbType.String, 96)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "remarkid"></param>
		/// <param name = "roundNum"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutRoundNumByPK(string remarkid, string roundNum, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_consume SET roundNum = @roundNum  WHERE remarkid = @remarkid";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@remarkid", remarkid, DbType.String, 96)
							.AddInParameter("@roundNum", roundNum, DbType.String, 96)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "remarkid"></param>
		/// <param name = "playerNum"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutPlayerNumByPK(string remarkid, string playerNum, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_consume SET playerNum = @playerNum  WHERE remarkid = @remarkid";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@remarkid", remarkid, DbType.String, 96)
							.AddInParameter("@playerNum", playerNum, DbType.String, 39)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "remarkid"></param>
		/// <param name = "uidAr"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutUidArByPK(string remarkid, string uidAr, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_consume SET uidAr = @uidAr  WHERE remarkid = @remarkid";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@remarkid", remarkid, DbType.String, 96)
							.AddInParameter("@uidAr", uidAr, DbType.String, 96)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "remarkid"></param>
		/// <param name = "ownerUid"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutOwnerUidByPK(string remarkid, string ownerUid, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_consume SET ownerUid = @ownerUid  WHERE remarkid = @remarkid";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@remarkid", remarkid, DbType.String, 96)
							.AddInParameter("@ownerUid", ownerUid, DbType.String, 96)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "remarkid"></param>
		/// <param name = "destUid"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutDestUidByPK(string remarkid, string destUid, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_consume SET destUid = @destUid  WHERE remarkid = @remarkid";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@remarkid", remarkid, DbType.String, 96)
							.AddInParameter("@destUid", destUid, DbType.String, 96)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "remarkid"></param>
		/// <param name = "useNum"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutUseNumByPK(string remarkid, string useNum, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_consume SET useNum = @useNum  WHERE remarkid = @remarkid";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@remarkid", remarkid, DbType.String, 96)
							.AddInParameter("@useNum", useNum, DbType.String, 96)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "remarkid"></param>
		/// <param name = "lastNum"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutLastNumByPK(string remarkid, string lastNum, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_consume SET lastNum = @lastNum  WHERE remarkid = @remarkid";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@remarkid", remarkid, DbType.String, 96)
							.AddInParameter("@lastNum", lastNum, DbType.String, 96)
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
			const string sql = @"UPDATE log_consume SET createTime = @createTime  WHERE remarkid = @remarkid";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@remarkid", remarkid, DbType.String, 96)
							.AddInParameter("@createTime", createTime, DbType.String, 96)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "remarkid"></param>
		/// <param name = "statue"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutStatueByPK(string remarkid, string statue, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_consume SET statue = @statue  WHERE remarkid = @remarkid";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@remarkid", remarkid, DbType.String, 96)
							.AddInParameter("@statue", statue, DbType.String, 96)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "remarkid"></param>
		/// <param name = "serverId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutServerIdByPK(string remarkid, string serverId, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_consume SET serverId = @serverId  WHERE remarkid = @remarkid";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@remarkid", remarkid, DbType.String, 96)
							.AddInParameter("@serverId", serverId, DbType.String, 96)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "remarkid"></param>
		/// <param name = "unidId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutUnidIdByPK(string remarkid, string unidId, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_consume SET unidId = @unidId  WHERE remarkid = @remarkid";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@remarkid", remarkid, DbType.String, 96)
							.AddInParameter("@unidId", unidId, DbType.String, 96)
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
			const string sql = @"UPDATE log_consume SET duid = @duid  WHERE remarkid = @remarkid";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@remarkid", remarkid, DbType.String, 96)
							.AddInParameter("@duid", duid, DbType.String, 96)
							.ExecNonQuery(tm);
		}


		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "roomId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutRoomId(string roomId, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_consume SET roomId=@roomId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@roomId", roomId, DbType.String, 33)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "gameId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutGameId(string gameId, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_consume SET gameId=@gameId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@gameId", gameId, DbType.String, 96)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "gameType"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutGameType(string gameType, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_consume SET gameType=@gameType";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@gameType", gameType, DbType.String, 96)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "chargeType"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutChargeType(string chargeType, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_consume SET chargeType=@chargeType";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@chargeType", chargeType, DbType.String, 96)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "roundNum"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutRoundNum(string roundNum, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_consume SET roundNum=@roundNum";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@roundNum", roundNum, DbType.String, 96)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "playerNum"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutPlayerNum(string playerNum, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_consume SET playerNum=@playerNum";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@playerNum", playerNum, DbType.String, 39)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "uidAr"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutUidAr(string uidAr, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_consume SET uidAr=@uidAr";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@uidAr", uidAr, DbType.String, 96)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "ownerUid"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutOwnerUid(string ownerUid, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_consume SET ownerUid=@ownerUid";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@ownerUid", ownerUid, DbType.String, 96)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "destUid"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutDestUid(string destUid, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_consume SET destUid=@destUid";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@destUid", destUid, DbType.String, 96)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "useNum"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutUseNum(string useNum, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_consume SET useNum=@useNum";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@useNum", useNum, DbType.String, 96)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "lastNum"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutLastNum(string lastNum, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_consume SET lastNum=@lastNum";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@lastNum", lastNum, DbType.String, 96)
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
			const string sql = @"UPDATE log_consume SET createTime=@createTime";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@createTime", createTime, DbType.String, 96)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "statue"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutStatue(string statue, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_consume SET statue=@statue";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@statue", statue, DbType.String, 96)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "serverId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutServerId(string serverId, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_consume SET serverId=@serverId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@serverId", serverId, DbType.String, 96)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "unidId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutUnidId(string unidId, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_consume SET unidId=@unidId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@unidId", unidId, DbType.String, 96)
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
			const string sql = @"UPDATE log_consume SET duid=@duid";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@duid", duid, DbType.String, 96)
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
			const string format = @"UPDATE log_consume SET {0} {1}";
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
			const string format = @"UPDATE log_consume SET {0} {1}";
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
			const string sql = @"DELETE FROM log_consume WHERE remarkid=@remarkid";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@remarkid", remarkid, DbType.String, 96)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Remove(LogConsumeEO item, TransactionManager tm = null)
		{
			return RemoveByPK(item.Remarkid, tm);
		}

		/// <summary>
		/// 删除指定实体集合对应的记录集
		/// </summary>
		/// <param name = "items">要删除的实体集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Remove(IEnumerable<LogConsumeEO> items, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM log_consume WHERE remarkid=@OriginalRemarkid";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@OriginalRemarkid", DbType.String, 96);
			int ret = 0;
			foreach (LogConsumeEO item in items)
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
		/// <param name = "roomId"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByRoomId(string roomId, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM log_consume WHERE roomId=@roomId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@roomId", roomId, DbType.String, 33)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "gameId"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByGameId(string gameId, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM log_consume WHERE gameId=@gameId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@gameId", gameId, DbType.String, 96)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "gameType"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByGameType(string gameType, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM log_consume WHERE gameType=@gameType";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@gameType", gameType, DbType.String, 96)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "chargeType"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByChargeType(string chargeType, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM log_consume WHERE chargeType=@chargeType";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@chargeType", chargeType, DbType.String, 96)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "roundNum"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByRoundNum(string roundNum, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM log_consume WHERE roundNum=@roundNum";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@roundNum", roundNum, DbType.String, 96)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "playerNum"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByPlayerNum(string playerNum, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM log_consume WHERE playerNum=@playerNum";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@playerNum", playerNum, DbType.String, 39)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "uidAr"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByUidAr(string uidAr, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM log_consume WHERE uidAr=@uidAr";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@uidAr", uidAr, DbType.String, 96)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "ownerUid"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByOwnerUid(string ownerUid, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM log_consume WHERE ownerUid=@ownerUid";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@ownerUid", ownerUid, DbType.String, 96)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "destUid"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByDestUid(string destUid, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM log_consume WHERE destUid=@destUid";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@destUid", destUid, DbType.String, 96)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "useNum"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByUseNum(string useNum, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM log_consume WHERE useNum=@useNum";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@useNum", useNum, DbType.String, 96)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "lastNum"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByLastNum(string lastNum, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM log_consume WHERE lastNum=@lastNum";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@lastNum", lastNum, DbType.String, 96)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "createTime"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByCreateTime(string createTime, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM log_consume WHERE createTime=@createTime";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@createTime", createTime, DbType.String, 96)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "statue"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByStatue(string statue, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM log_consume WHERE statue=@statue";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@statue", statue, DbType.String, 96)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "serverId"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByServerId(string serverId, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM log_consume WHERE serverId=@serverId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@serverId", serverId, DbType.String, 96)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "unidId"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByUnidId(string unidId, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM log_consume WHERE unidId=@unidId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@unidId", unidId, DbType.String, 96)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "duid"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByDuid(string duid, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM log_consume WHERE duid=@duid";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@duid", duid, DbType.String, 96)
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
			const string format = @"DELETE FROM log_consume {0}";
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
			const string format = @"DELETE FROM log_consume {0}";
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
