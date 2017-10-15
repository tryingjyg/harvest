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
	/// 【表 feedback 的实体类】
	/// </summary>
	[SerializableAttribute]
	public class FeedbackEO : DataEntityBase, IRowMapper<FeedbackEO>
	{
		protected int _originalFbId;

		/// <summary>
		/// 主键是否有原始值（即数据库中保存的值），用于实体对象更新时
		/// </summary>
		public bool HasOriginal { get; protected set; }

		/// <summary>
		/// 【主键 int】
		/// </summary>
		public virtual int FbId { get; set; }

		/// <summary>
		/// 【数据库中的原始主键值副本】
		/// </summary>
		public virtual int OriginalFbId
		{
			get { return _originalFbId; }
			set { HasOriginal = true; _originalFbId = value; }
		}

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string FbTitle { get; set; }

		/// <summary>
		/// 【字段 longtext】
		/// </summary>
		public virtual string FbDescription { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string FbUrl { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string PfId { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string FbAddUser { get; set; }

		/// <summary>
		/// 【字段 datetime】
		/// </summary>
		public virtual DateTime FbAddTime { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string FbSolveUser { get; set; }

		/// <summary>
		/// 【字段 datetime】
		/// </summary>
		public virtual DateTime FbSolveTime { get; set; }

		/// <summary>
		/// 【字段 longtext】
		/// </summary>
		public virtual string FbSolvedescription { get; set; }

		/// <summary>
		/// 【字段 char】
		/// </summary>
		public virtual string FbState { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string FbText1 { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string FbText2 { get; set; }

		/// <summary>
		/// 【字段 char】
		/// </summary>
		public virtual string FbDel { get; set; }

		/// <summary>
		/// 默认构造函数
		/// </summary>
		public FeedbackEO() 
		{
		}

		/// <summary>
		/// 自定义构造函数
		/// </summary>
		/// <param name = "fbId"></param>
		/// <param name = "fbTitle"></param>
		/// <param name = "fbDescription"></param>
		/// <param name = "fbUrl"></param>
		/// <param name = "pfId"></param>
		/// <param name = "fbAddUser"></param>
		/// <param name = "fbAddTime"></param>
		/// <param name = "fbSolveUser"></param>
		/// <param name = "fbSolveTime"></param>
		/// <param name = "fbSolvedescription"></param>
		/// <param name = "fbState"></param>
		/// <param name = "fbText1"></param>
		/// <param name = "fbText2"></param>
		/// <param name = "fbDel"></param>
		public FeedbackEO(int fbId, string fbTitle, string fbDescription, string fbUrl, string pfId, string fbAddUser, DateTime fbAddTime, string fbSolveUser, DateTime fbSolveTime, string fbSolvedescription, string fbState, string fbText1, string fbText2, string fbDel) 
		{
			FbId = fbId;
			FbTitle = fbTitle;
			FbDescription = fbDescription;
			FbUrl = fbUrl;
			PfId = pfId;
			FbAddUser = fbAddUser;
			FbAddTime = fbAddTime;
			FbSolveUser = fbSolveUser;
			FbSolveTime = fbSolveTime;
			FbSolvedescription = fbSolvedescription;
			FbState = fbState;
			FbText1 = fbText1;
			FbText2 = fbText2;
			FbDel = fbDel;
		}

		/// <summary>
		/// 将结果集映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public FeedbackEO MapRow(IDataReader reader)
		{
			return GetItem(reader);
		}

		/// <summary>
		/// 将结果集映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static FeedbackEO GetItem(IDataReader reader)
		{
			FeedbackEO ret = new FeedbackEO();

			ret.FbId = int.Parse(reader["Fb_id"].ToString());
			ret.OriginalFbId = ret.FbId;
			ret.FbTitle = (reader["Fb_title"] is DBNull) ? null : (string)reader["Fb_title"];
			ret.FbDescription = (reader["Fb_description"] is DBNull) ? null : (string)reader["Fb_description"];
			ret.FbUrl = (reader["Fb_url"] is DBNull) ? null : (string)reader["Fb_url"];
			ret.PfId = (reader["Pf_id"] is DBNull) ? null : (string)reader["Pf_id"];
			ret.FbAddUser = (reader["Fb_addUser"] is DBNull) ? null : (string)reader["Fb_addUser"];
			ret.FbAddTime = DateTime.Parse(reader["Fb_addTime"].ToString());
			ret.FbSolveUser = (reader["Fb_solveUser"] is DBNull) ? null : (string)reader["Fb_solveUser"];
			ret.FbSolveTime = DateTime.Parse(reader["Fb_solveTime"].ToString());
			ret.FbSolvedescription = (reader["Fb_solvedescription"] is DBNull) ? null : (string)reader["Fb_solvedescription"];
			ret.FbState = (reader["Fb_state"] is DBNull) ? null : (string)reader["Fb_state"];
			ret.FbText1 = (reader["Fb_text1"] is DBNull) ? null : (string)reader["Fb_text1"];
			ret.FbText2 = (reader["Fb_text2"] is DBNull) ? null : (string)reader["Fb_text2"];
			ret.FbDel = (reader["Fb_del"] is DBNull) ? null : (string)reader["Fb_del"];
			return ret;
		}
	}


	#endregion

	#region  MO

	/// <summary>
	/// 【表 feedback 的操作类】
	/// </summary>
	public partial class FeedbackMO : DataManagerBase
	{

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "routeData">路由数据</param>
		public FeedbackMO(object routeData = null) : base(routeData) { }

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">连接字符串名称</param>
		public FeedbackMO(string connectionStringName) : base(connectionStringName) { }

		#region  Get方法集合

		/// <summary>
		/// 按 PK（主键） 查询
		/// </summary>
		/// <param name="tm">事务管理对象</param>
		/// <param name = "fbId"></param>
		/// <return></return>
		public virtual FeedbackEO GetByPK(int fbId, TransactionManager tm = null)
		{
			const string sql = @"SELECT Fb_id, Fb_title, Fb_description, Fb_url, Pf_id, Fb_addUser, Fb_addTime, Fb_solveUser, Fb_solveTime, Fb_solvedescription, Fb_state, Fb_text1, Fb_text2, Fb_del FROM feedback WHERE Fb_id=@Fb_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Fb_id", fbId, DbType.Int32, 0)
							.ExecSingle<FeedbackEO>(FeedbackEO.GetItem, tm);
		}




		#region  按 FbTitle（字段） 查询

		/// <summary>
		/// 按 FbTitle（字段） 查询
		/// </summary>
		/// <param name = "fbTitle"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbTitle(string fbTitle)
		{
			return GetByFbTitle(fbTitle, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 FbTitle（字段） 查询
		/// </summary>
		/// <param name = "fbTitle"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbTitle(string fbTitle, TransactionManager tm)
		{
			return GetByFbTitle(fbTitle, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 FbTitle（字段） 查询
		/// </summary>
		/// <param name = "fbTitle"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbTitle(string fbTitle, int top)
		{
			return GetByFbTitle(fbTitle, top, string.Empty, null);
		}

		/// <summary>
		/// 按 FbTitle（字段） 查询
		/// </summary>
		/// <param name = "fbTitle"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbTitle(string fbTitle, int top, TransactionManager tm)
		{
			return GetByFbTitle(fbTitle, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 FbTitle（字段） 查询
		/// </summary>
		/// <param name = "fbTitle"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbTitle(string fbTitle, string sort)
		{
			return GetByFbTitle(fbTitle, 0, sort, null);
		}

		/// <summary>
		/// 按 FbTitle（字段） 查询
		/// </summary>
		/// <param name = "fbTitle"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbTitle(string fbTitle, string sort, TransactionManager tm)
		{
			return GetByFbTitle(fbTitle, 0, sort, tm);
		}

		/// <summary>
		/// 按 FbTitle（字段） 查询
		/// </summary>
		/// <param name = "fbTitle"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbTitle(string fbTitle, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Fb_id, Fb_title, Fb_description, Fb_url, Pf_id, Fb_addUser, Fb_addTime, Fb_solveUser, Fb_solveTime, Fb_solvedescription, Fb_state, Fb_text1, Fb_text2, Fb_del FROM feedback WHERE Fb_title=@FbTitle";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@FbTitle", fbTitle, DbType.String, 150)
							.ExecList<FeedbackEO>(FeedbackEO.GetItem, tm);
		}

		#endregion

		#region  按 FbDescription（字段） 查询

		/// <summary>
		/// 按 FbDescription（字段） 查询
		/// </summary>
		/// <param name = "fbDescription"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbDescription(string fbDescription)
		{
			return GetByFbDescription(fbDescription, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 FbDescription（字段） 查询
		/// </summary>
		/// <param name = "fbDescription"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbDescription(string fbDescription, TransactionManager tm)
		{
			return GetByFbDescription(fbDescription, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 FbDescription（字段） 查询
		/// </summary>
		/// <param name = "fbDescription"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbDescription(string fbDescription, int top)
		{
			return GetByFbDescription(fbDescription, top, string.Empty, null);
		}

		/// <summary>
		/// 按 FbDescription（字段） 查询
		/// </summary>
		/// <param name = "fbDescription"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbDescription(string fbDescription, int top, TransactionManager tm)
		{
			return GetByFbDescription(fbDescription, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 FbDescription（字段） 查询
		/// </summary>
		/// <param name = "fbDescription"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbDescription(string fbDescription, string sort)
		{
			return GetByFbDescription(fbDescription, 0, sort, null);
		}

		/// <summary>
		/// 按 FbDescription（字段） 查询
		/// </summary>
		/// <param name = "fbDescription"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbDescription(string fbDescription, string sort, TransactionManager tm)
		{
			return GetByFbDescription(fbDescription, 0, sort, tm);
		}

		/// <summary>
		/// 按 FbDescription（字段） 查询
		/// </summary>
		/// <param name = "fbDescription"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbDescription(string fbDescription, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Fb_id, Fb_title, Fb_description, Fb_url, Pf_id, Fb_addUser, Fb_addTime, Fb_solveUser, Fb_solveTime, Fb_solvedescription, Fb_state, Fb_text1, Fb_text2, Fb_del FROM feedback WHERE Fb_description=@FbDescription";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@FbDescription", fbDescription, DbType.String, 2147483647)
							.ExecList<FeedbackEO>(FeedbackEO.GetItem, tm);
		}

		#endregion

		#region  按 FbUrl（字段） 查询

		/// <summary>
		/// 按 FbUrl（字段） 查询
		/// </summary>
		/// <param name = "fbUrl"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbUrl(string fbUrl)
		{
			return GetByFbUrl(fbUrl, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 FbUrl（字段） 查询
		/// </summary>
		/// <param name = "fbUrl"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbUrl(string fbUrl, TransactionManager tm)
		{
			return GetByFbUrl(fbUrl, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 FbUrl（字段） 查询
		/// </summary>
		/// <param name = "fbUrl"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbUrl(string fbUrl, int top)
		{
			return GetByFbUrl(fbUrl, top, string.Empty, null);
		}

		/// <summary>
		/// 按 FbUrl（字段） 查询
		/// </summary>
		/// <param name = "fbUrl"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbUrl(string fbUrl, int top, TransactionManager tm)
		{
			return GetByFbUrl(fbUrl, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 FbUrl（字段） 查询
		/// </summary>
		/// <param name = "fbUrl"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbUrl(string fbUrl, string sort)
		{
			return GetByFbUrl(fbUrl, 0, sort, null);
		}

		/// <summary>
		/// 按 FbUrl（字段） 查询
		/// </summary>
		/// <param name = "fbUrl"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbUrl(string fbUrl, string sort, TransactionManager tm)
		{
			return GetByFbUrl(fbUrl, 0, sort, tm);
		}

		/// <summary>
		/// 按 FbUrl（字段） 查询
		/// </summary>
		/// <param name = "fbUrl"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbUrl(string fbUrl, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Fb_id, Fb_title, Fb_description, Fb_url, Pf_id, Fb_addUser, Fb_addTime, Fb_solveUser, Fb_solveTime, Fb_solvedescription, Fb_state, Fb_text1, Fb_text2, Fb_del FROM feedback WHERE Fb_url=@FbUrl";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@FbUrl", fbUrl, DbType.String, 600)
							.ExecList<FeedbackEO>(FeedbackEO.GetItem, tm);
		}

		#endregion

		#region  按 PfId（字段） 查询

		/// <summary>
		/// 按 PfId（字段） 查询
		/// </summary>
		/// <param name = "pfId"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByPfId(string pfId)
		{
			return GetByPfId(pfId, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 PfId（字段） 查询
		/// </summary>
		/// <param name = "pfId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByPfId(string pfId, TransactionManager tm)
		{
			return GetByPfId(pfId, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 PfId（字段） 查询
		/// </summary>
		/// <param name = "pfId"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByPfId(string pfId, int top)
		{
			return GetByPfId(pfId, top, string.Empty, null);
		}

		/// <summary>
		/// 按 PfId（字段） 查询
		/// </summary>
		/// <param name = "pfId"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByPfId(string pfId, int top, TransactionManager tm)
		{
			return GetByPfId(pfId, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 PfId（字段） 查询
		/// </summary>
		/// <param name = "pfId"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByPfId(string pfId, string sort)
		{
			return GetByPfId(pfId, 0, sort, null);
		}

		/// <summary>
		/// 按 PfId（字段） 查询
		/// </summary>
		/// <param name = "pfId"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByPfId(string pfId, string sort, TransactionManager tm)
		{
			return GetByPfId(pfId, 0, sort, tm);
		}

		/// <summary>
		/// 按 PfId（字段） 查询
		/// </summary>
		/// <param name = "pfId"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByPfId(string pfId, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Fb_id, Fb_title, Fb_description, Fb_url, Pf_id, Fb_addUser, Fb_addTime, Fb_solveUser, Fb_solveTime, Fb_solvedescription, Fb_state, Fb_text1, Fb_text2, Fb_del FROM feedback WHERE Pf_id=@PfId";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@PfId", pfId, DbType.String, 150)
							.ExecList<FeedbackEO>(FeedbackEO.GetItem, tm);
		}

		#endregion

		#region  按 FbAddUser（字段） 查询

		/// <summary>
		/// 按 FbAddUser（字段） 查询
		/// </summary>
		/// <param name = "fbAddUser"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbAddUser(string fbAddUser)
		{
			return GetByFbAddUser(fbAddUser, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 FbAddUser（字段） 查询
		/// </summary>
		/// <param name = "fbAddUser"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbAddUser(string fbAddUser, TransactionManager tm)
		{
			return GetByFbAddUser(fbAddUser, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 FbAddUser（字段） 查询
		/// </summary>
		/// <param name = "fbAddUser"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbAddUser(string fbAddUser, int top)
		{
			return GetByFbAddUser(fbAddUser, top, string.Empty, null);
		}

		/// <summary>
		/// 按 FbAddUser（字段） 查询
		/// </summary>
		/// <param name = "fbAddUser"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbAddUser(string fbAddUser, int top, TransactionManager tm)
		{
			return GetByFbAddUser(fbAddUser, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 FbAddUser（字段） 查询
		/// </summary>
		/// <param name = "fbAddUser"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbAddUser(string fbAddUser, string sort)
		{
			return GetByFbAddUser(fbAddUser, 0, sort, null);
		}

		/// <summary>
		/// 按 FbAddUser（字段） 查询
		/// </summary>
		/// <param name = "fbAddUser"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbAddUser(string fbAddUser, string sort, TransactionManager tm)
		{
			return GetByFbAddUser(fbAddUser, 0, sort, tm);
		}

		/// <summary>
		/// 按 FbAddUser（字段） 查询
		/// </summary>
		/// <param name = "fbAddUser"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbAddUser(string fbAddUser, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Fb_id, Fb_title, Fb_description, Fb_url, Pf_id, Fb_addUser, Fb_addTime, Fb_solveUser, Fb_solveTime, Fb_solvedescription, Fb_state, Fb_text1, Fb_text2, Fb_del FROM feedback WHERE Fb_addUser=@FbAddUser";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@FbAddUser", fbAddUser, DbType.String, 150)
							.ExecList<FeedbackEO>(FeedbackEO.GetItem, tm);
		}

		#endregion

		#region  按 FbAddTime（字段） 查询

		/// <summary>
		/// 按 FbAddTime（字段） 查询
		/// </summary>
		/// <param name = "fbAddTime"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbAddTime(DateTime fbAddTime)
		{
			return GetByFbAddTime(fbAddTime, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 FbAddTime（字段） 查询
		/// </summary>
		/// <param name = "fbAddTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbAddTime(DateTime fbAddTime, TransactionManager tm)
		{
			return GetByFbAddTime(fbAddTime, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 FbAddTime（字段） 查询
		/// </summary>
		/// <param name = "fbAddTime"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbAddTime(DateTime fbAddTime, int top)
		{
			return GetByFbAddTime(fbAddTime, top, string.Empty, null);
		}

		/// <summary>
		/// 按 FbAddTime（字段） 查询
		/// </summary>
		/// <param name = "fbAddTime"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbAddTime(DateTime fbAddTime, int top, TransactionManager tm)
		{
			return GetByFbAddTime(fbAddTime, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 FbAddTime（字段） 查询
		/// </summary>
		/// <param name = "fbAddTime"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbAddTime(DateTime fbAddTime, string sort)
		{
			return GetByFbAddTime(fbAddTime, 0, sort, null);
		}

		/// <summary>
		/// 按 FbAddTime（字段） 查询
		/// </summary>
		/// <param name = "fbAddTime"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbAddTime(DateTime fbAddTime, string sort, TransactionManager tm)
		{
			return GetByFbAddTime(fbAddTime, 0, sort, tm);
		}

		/// <summary>
		/// 按 FbAddTime（字段） 查询
		/// </summary>
		/// <param name = "fbAddTime"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbAddTime(DateTime fbAddTime, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Fb_id, Fb_title, Fb_description, Fb_url, Pf_id, Fb_addUser, Fb_addTime, Fb_solveUser, Fb_solveTime, Fb_solvedescription, Fb_state, Fb_text1, Fb_text2, Fb_del FROM feedback WHERE Fb_addTime=@FbAddTime";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@FbAddTime", fbAddTime, DbType.DateTime, 0)
							.ExecList<FeedbackEO>(FeedbackEO.GetItem, tm);
		}

		#endregion

		#region  按 FbSolveUser（字段） 查询

		/// <summary>
		/// 按 FbSolveUser（字段） 查询
		/// </summary>
		/// <param name = "fbSolveUser"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbSolveUser(string fbSolveUser)
		{
			return GetByFbSolveUser(fbSolveUser, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 FbSolveUser（字段） 查询
		/// </summary>
		/// <param name = "fbSolveUser"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbSolveUser(string fbSolveUser, TransactionManager tm)
		{
			return GetByFbSolveUser(fbSolveUser, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 FbSolveUser（字段） 查询
		/// </summary>
		/// <param name = "fbSolveUser"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbSolveUser(string fbSolveUser, int top)
		{
			return GetByFbSolveUser(fbSolveUser, top, string.Empty, null);
		}

		/// <summary>
		/// 按 FbSolveUser（字段） 查询
		/// </summary>
		/// <param name = "fbSolveUser"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbSolveUser(string fbSolveUser, int top, TransactionManager tm)
		{
			return GetByFbSolveUser(fbSolveUser, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 FbSolveUser（字段） 查询
		/// </summary>
		/// <param name = "fbSolveUser"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbSolveUser(string fbSolveUser, string sort)
		{
			return GetByFbSolveUser(fbSolveUser, 0, sort, null);
		}

		/// <summary>
		/// 按 FbSolveUser（字段） 查询
		/// </summary>
		/// <param name = "fbSolveUser"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbSolveUser(string fbSolveUser, string sort, TransactionManager tm)
		{
			return GetByFbSolveUser(fbSolveUser, 0, sort, tm);
		}

		/// <summary>
		/// 按 FbSolveUser（字段） 查询
		/// </summary>
		/// <param name = "fbSolveUser"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbSolveUser(string fbSolveUser, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Fb_id, Fb_title, Fb_description, Fb_url, Pf_id, Fb_addUser, Fb_addTime, Fb_solveUser, Fb_solveTime, Fb_solvedescription, Fb_state, Fb_text1, Fb_text2, Fb_del FROM feedback WHERE Fb_solveUser=@FbSolveUser";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@FbSolveUser", fbSolveUser, DbType.String, 150)
							.ExecList<FeedbackEO>(FeedbackEO.GetItem, tm);
		}

		#endregion

		#region  按 FbSolveTime（字段） 查询

		/// <summary>
		/// 按 FbSolveTime（字段） 查询
		/// </summary>
		/// <param name = "fbSolveTime"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbSolveTime(DateTime fbSolveTime)
		{
			return GetByFbSolveTime(fbSolveTime, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 FbSolveTime（字段） 查询
		/// </summary>
		/// <param name = "fbSolveTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbSolveTime(DateTime fbSolveTime, TransactionManager tm)
		{
			return GetByFbSolveTime(fbSolveTime, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 FbSolveTime（字段） 查询
		/// </summary>
		/// <param name = "fbSolveTime"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbSolveTime(DateTime fbSolveTime, int top)
		{
			return GetByFbSolveTime(fbSolveTime, top, string.Empty, null);
		}

		/// <summary>
		/// 按 FbSolveTime（字段） 查询
		/// </summary>
		/// <param name = "fbSolveTime"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbSolveTime(DateTime fbSolveTime, int top, TransactionManager tm)
		{
			return GetByFbSolveTime(fbSolveTime, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 FbSolveTime（字段） 查询
		/// </summary>
		/// <param name = "fbSolveTime"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbSolveTime(DateTime fbSolveTime, string sort)
		{
			return GetByFbSolveTime(fbSolveTime, 0, sort, null);
		}

		/// <summary>
		/// 按 FbSolveTime（字段） 查询
		/// </summary>
		/// <param name = "fbSolveTime"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbSolveTime(DateTime fbSolveTime, string sort, TransactionManager tm)
		{
			return GetByFbSolveTime(fbSolveTime, 0, sort, tm);
		}

		/// <summary>
		/// 按 FbSolveTime（字段） 查询
		/// </summary>
		/// <param name = "fbSolveTime"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbSolveTime(DateTime fbSolveTime, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Fb_id, Fb_title, Fb_description, Fb_url, Pf_id, Fb_addUser, Fb_addTime, Fb_solveUser, Fb_solveTime, Fb_solvedescription, Fb_state, Fb_text1, Fb_text2, Fb_del FROM feedback WHERE Fb_solveTime=@FbSolveTime";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@FbSolveTime", fbSolveTime, DbType.DateTime, 0)
							.ExecList<FeedbackEO>(FeedbackEO.GetItem, tm);
		}

		#endregion

		#region  按 FbSolvedescription（字段） 查询

		/// <summary>
		/// 按 FbSolvedescription（字段） 查询
		/// </summary>
		/// <param name = "fbSolvedescription"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbSolvedescription(string fbSolvedescription)
		{
			return GetByFbSolvedescription(fbSolvedescription, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 FbSolvedescription（字段） 查询
		/// </summary>
		/// <param name = "fbSolvedescription"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbSolvedescription(string fbSolvedescription, TransactionManager tm)
		{
			return GetByFbSolvedescription(fbSolvedescription, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 FbSolvedescription（字段） 查询
		/// </summary>
		/// <param name = "fbSolvedescription"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbSolvedescription(string fbSolvedescription, int top)
		{
			return GetByFbSolvedescription(fbSolvedescription, top, string.Empty, null);
		}

		/// <summary>
		/// 按 FbSolvedescription（字段） 查询
		/// </summary>
		/// <param name = "fbSolvedescription"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbSolvedescription(string fbSolvedescription, int top, TransactionManager tm)
		{
			return GetByFbSolvedescription(fbSolvedescription, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 FbSolvedescription（字段） 查询
		/// </summary>
		/// <param name = "fbSolvedescription"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbSolvedescription(string fbSolvedescription, string sort)
		{
			return GetByFbSolvedescription(fbSolvedescription, 0, sort, null);
		}

		/// <summary>
		/// 按 FbSolvedescription（字段） 查询
		/// </summary>
		/// <param name = "fbSolvedescription"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbSolvedescription(string fbSolvedescription, string sort, TransactionManager tm)
		{
			return GetByFbSolvedescription(fbSolvedescription, 0, sort, tm);
		}

		/// <summary>
		/// 按 FbSolvedescription（字段） 查询
		/// </summary>
		/// <param name = "fbSolvedescription"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbSolvedescription(string fbSolvedescription, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Fb_id, Fb_title, Fb_description, Fb_url, Pf_id, Fb_addUser, Fb_addTime, Fb_solveUser, Fb_solveTime, Fb_solvedescription, Fb_state, Fb_text1, Fb_text2, Fb_del FROM feedback WHERE Fb_solvedescription=@FbSolvedescription";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@FbSolvedescription", fbSolvedescription, DbType.String, 2147483647)
							.ExecList<FeedbackEO>(FeedbackEO.GetItem, tm);
		}

		#endregion

		#region  按 FbState（字段） 查询

		/// <summary>
		/// 按 FbState（字段） 查询
		/// </summary>
		/// <param name = "fbState"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbState(string fbState)
		{
			return GetByFbState(fbState, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 FbState（字段） 查询
		/// </summary>
		/// <param name = "fbState"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbState(string fbState, TransactionManager tm)
		{
			return GetByFbState(fbState, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 FbState（字段） 查询
		/// </summary>
		/// <param name = "fbState"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbState(string fbState, int top)
		{
			return GetByFbState(fbState, top, string.Empty, null);
		}

		/// <summary>
		/// 按 FbState（字段） 查询
		/// </summary>
		/// <param name = "fbState"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbState(string fbState, int top, TransactionManager tm)
		{
			return GetByFbState(fbState, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 FbState（字段） 查询
		/// </summary>
		/// <param name = "fbState"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbState(string fbState, string sort)
		{
			return GetByFbState(fbState, 0, sort, null);
		}

		/// <summary>
		/// 按 FbState（字段） 查询
		/// </summary>
		/// <param name = "fbState"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbState(string fbState, string sort, TransactionManager tm)
		{
			return GetByFbState(fbState, 0, sort, tm);
		}

		/// <summary>
		/// 按 FbState（字段） 查询
		/// </summary>
		/// <param name = "fbState"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbState(string fbState, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Fb_id, Fb_title, Fb_description, Fb_url, Pf_id, Fb_addUser, Fb_addTime, Fb_solveUser, Fb_solveTime, Fb_solvedescription, Fb_state, Fb_text1, Fb_text2, Fb_del FROM feedback WHERE Fb_state=@FbState";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@FbState", fbState, DbType.String, 3)
							.ExecList<FeedbackEO>(FeedbackEO.GetItem, tm);
		}

		#endregion

		#region  按 FbText1（字段） 查询

		/// <summary>
		/// 按 FbText1（字段） 查询
		/// </summary>
		/// <param name = "fbText1"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbText1(string fbText1)
		{
			return GetByFbText1(fbText1, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 FbText1（字段） 查询
		/// </summary>
		/// <param name = "fbText1"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbText1(string fbText1, TransactionManager tm)
		{
			return GetByFbText1(fbText1, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 FbText1（字段） 查询
		/// </summary>
		/// <param name = "fbText1"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbText1(string fbText1, int top)
		{
			return GetByFbText1(fbText1, top, string.Empty, null);
		}

		/// <summary>
		/// 按 FbText1（字段） 查询
		/// </summary>
		/// <param name = "fbText1"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbText1(string fbText1, int top, TransactionManager tm)
		{
			return GetByFbText1(fbText1, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 FbText1（字段） 查询
		/// </summary>
		/// <param name = "fbText1"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbText1(string fbText1, string sort)
		{
			return GetByFbText1(fbText1, 0, sort, null);
		}

		/// <summary>
		/// 按 FbText1（字段） 查询
		/// </summary>
		/// <param name = "fbText1"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbText1(string fbText1, string sort, TransactionManager tm)
		{
			return GetByFbText1(fbText1, 0, sort, tm);
		}

		/// <summary>
		/// 按 FbText1（字段） 查询
		/// </summary>
		/// <param name = "fbText1"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbText1(string fbText1, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Fb_id, Fb_title, Fb_description, Fb_url, Pf_id, Fb_addUser, Fb_addTime, Fb_solveUser, Fb_solveTime, Fb_solvedescription, Fb_state, Fb_text1, Fb_text2, Fb_del FROM feedback WHERE Fb_text1=@FbText1";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@FbText1", fbText1, DbType.String, 600)
							.ExecList<FeedbackEO>(FeedbackEO.GetItem, tm);
		}

		#endregion

		#region  按 FbText2（字段） 查询

		/// <summary>
		/// 按 FbText2（字段） 查询
		/// </summary>
		/// <param name = "fbText2"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbText2(string fbText2)
		{
			return GetByFbText2(fbText2, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 FbText2（字段） 查询
		/// </summary>
		/// <param name = "fbText2"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbText2(string fbText2, TransactionManager tm)
		{
			return GetByFbText2(fbText2, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 FbText2（字段） 查询
		/// </summary>
		/// <param name = "fbText2"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbText2(string fbText2, int top)
		{
			return GetByFbText2(fbText2, top, string.Empty, null);
		}

		/// <summary>
		/// 按 FbText2（字段） 查询
		/// </summary>
		/// <param name = "fbText2"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbText2(string fbText2, int top, TransactionManager tm)
		{
			return GetByFbText2(fbText2, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 FbText2（字段） 查询
		/// </summary>
		/// <param name = "fbText2"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbText2(string fbText2, string sort)
		{
			return GetByFbText2(fbText2, 0, sort, null);
		}

		/// <summary>
		/// 按 FbText2（字段） 查询
		/// </summary>
		/// <param name = "fbText2"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbText2(string fbText2, string sort, TransactionManager tm)
		{
			return GetByFbText2(fbText2, 0, sort, tm);
		}

		/// <summary>
		/// 按 FbText2（字段） 查询
		/// </summary>
		/// <param name = "fbText2"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbText2(string fbText2, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Fb_id, Fb_title, Fb_description, Fb_url, Pf_id, Fb_addUser, Fb_addTime, Fb_solveUser, Fb_solveTime, Fb_solvedescription, Fb_state, Fb_text1, Fb_text2, Fb_del FROM feedback WHERE Fb_text2=@FbText2";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@FbText2", fbText2, DbType.String, 600)
							.ExecList<FeedbackEO>(FeedbackEO.GetItem, tm);
		}

		#endregion

		#region  按 FbDel（字段） 查询

		/// <summary>
		/// 按 FbDel（字段） 查询
		/// </summary>
		/// <param name = "fbDel"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbDel(string fbDel)
		{
			return GetByFbDel(fbDel, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 FbDel（字段） 查询
		/// </summary>
		/// <param name = "fbDel"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbDel(string fbDel, TransactionManager tm)
		{
			return GetByFbDel(fbDel, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 FbDel（字段） 查询
		/// </summary>
		/// <param name = "fbDel"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbDel(string fbDel, int top)
		{
			return GetByFbDel(fbDel, top, string.Empty, null);
		}

		/// <summary>
		/// 按 FbDel（字段） 查询
		/// </summary>
		/// <param name = "fbDel"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbDel(string fbDel, int top, TransactionManager tm)
		{
			return GetByFbDel(fbDel, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 FbDel（字段） 查询
		/// </summary>
		/// <param name = "fbDel"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbDel(string fbDel, string sort)
		{
			return GetByFbDel(fbDel, 0, sort, null);
		}

		/// <summary>
		/// 按 FbDel（字段） 查询
		/// </summary>
		/// <param name = "fbDel"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbDel(string fbDel, string sort, TransactionManager tm)
		{
			return GetByFbDel(fbDel, 0, sort, tm);
		}

		/// <summary>
		/// 按 FbDel（字段） 查询
		/// </summary>
		/// <param name = "fbDel"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetByFbDel(string fbDel, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Fb_id, Fb_title, Fb_description, Fb_url, Pf_id, Fb_addUser, Fb_addTime, Fb_solveUser, Fb_solveTime, Fb_solvedescription, Fb_state, Fb_text1, Fb_text2, Fb_del FROM feedback WHERE Fb_del=@FbDel";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@FbDel", fbDel, DbType.String, 3)
							.ExecList<FeedbackEO>(FeedbackEO.GetItem, tm);
		}

		#endregion

		#region  自定义条件查询

		/// <summary>
		/// 获取所有数据
		/// </summary>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetAll(TransactionManager tm = null)
		{
			return GetTopSort(string.Empty, null, -1, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "values">where子句中定义的参数值集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> Get(string where, params object[] values)
		{
			return GetTopSort(where, -1, string.Empty, null, values);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "paras">where子句中定义的参数集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> Get(string where, IEnumerable<DbParameter> paras)
		{
			return GetTopSort(where, paras, -1, string.Empty, null);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> Get(string where, TransactionManager tm)
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
		public virtual IEnumerable<FeedbackEO> Get(string where, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<FeedbackEO> Get(string where, IEnumerable<DbParameter> paras, TransactionManager tm)
		{
			return GetTopSort(where, paras, -1, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetTop(string where, int top)
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
		public virtual IEnumerable<FeedbackEO> GetTop(string where, int top, params object[] values)
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
		public virtual IEnumerable<FeedbackEO> GetTop(string where, IEnumerable<DbParameter> paras, int top)
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
		public virtual IEnumerable<FeedbackEO> GetTop(string where, int top, TransactionManager tm)
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
		public virtual IEnumerable<FeedbackEO> GetTop(string where, int top, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<FeedbackEO> GetTop(string where, IEnumerable<DbParameter> paras, int top, TransactionManager tm)
		{
			return GetTopSort(where, paras, top, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<FeedbackEO> GetSort(string where, string sort)
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
		public virtual IEnumerable<FeedbackEO> GetSort(string where, string sort, params object[] values)
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
		public virtual IEnumerable<FeedbackEO> GetSort(string where, IEnumerable<DbParameter> paras, string sort)
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
		public virtual IEnumerable<FeedbackEO> GetSort(string where, string sort, TransactionManager tm)
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
		public virtual IEnumerable<FeedbackEO> GetSort(string where, string sort, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<FeedbackEO> GetSort(string where, IEnumerable<DbParameter> paras, string sort, TransactionManager tm)
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
		public virtual IEnumerable<FeedbackEO> GetTopSort(string where, int top, string sort)
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
		public virtual IEnumerable<FeedbackEO> GetTopSort(string where, int top, string sort, params object[] values)
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
		public virtual IEnumerable<FeedbackEO> GetTopSort(string where, IEnumerable<DbParameter> paras, int top, string sort)
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
		public virtual IEnumerable<FeedbackEO> GetTopSort(string where, int top, string sort, TransactionManager tm)
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
		public virtual IEnumerable<FeedbackEO> GetTopSort(string where, int top, string sort, TransactionManager tm, params object[] values)
		{
			const string format = @"SELECT {0} Fb_id, Fb_title, Fb_description, Fb_url, Pf_id, Fb_addUser, Fb_addTime, Fb_solveUser, Fb_solveTime, Fb_solvedescription, Fb_state, Fb_text1, Fb_text2, Fb_del FROM feedback";
			string sql = format;

			if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameters(values)
							.ExecList<FeedbackEO>(FeedbackEO.GetItem, tm);
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
		public virtual IEnumerable<FeedbackEO> GetTopSort(string where, IEnumerable<DbParameter> paras, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Fb_id, Fb_title, Fb_description, Fb_url, Pf_id, Fb_addUser, Fb_addTime, Fb_solveUser, Fb_solveTime, Fb_solvedescription, Fb_state, Fb_text1, Fb_text2, Fb_del FROM feedback";
			string sql = format;

			if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddParameters(paras)
							.ExecList<FeedbackEO>(FeedbackEO.GetItem, tm);
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
			const string format = @"SELECT Fb_id, Fb_title, Fb_description, Fb_url, Pf_id, Fb_addUser, Fb_addTime, Fb_solveUser, Fb_solveTime, Fb_solvedescription, Fb_state, Fb_text1, Fb_text2, Fb_del FROM feedback {0} {1}";
			 string sql = string.Format(format, string.IsNullOrEmpty(where) ? string.Empty : "WHERE " + where, string.IsNullOrEmpty(sort) ? string.Empty : "ORDER BY " + sort);

			return Database.CreatePager(sql, pageSize, "Fb_id");
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
		public virtual List<FeedbackEO> GetPageList(int pageIndex , int pageSize, string where = null, string sort = null, IEnumerable<DbParameter> paras = null)
		{
			var pager = GetPager(pageSize, where, sort);

			pager.AddParameters(paras);
			return pager.GetPageList<FeedbackEO>(pageIndex);
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
		public virtual IEnumerable<FeedbackEO> GetPageMutil(int pageIndex , int pageSize, string where = null, string sort = null, IEnumerable<DbParameter> paras = null)
		{
			var pager = GetPager(pageSize, where, sort);

			pager.AddParameters(paras);
			return pager.GetPageMutil<FeedbackEO>(pageIndex);
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
		public virtual int Add(FeedbackEO item, TransactionManager tm = null)
		{
			const string sql = @"INSERT INTO feedback (Fb_id, Fb_title, Fb_description, Fb_url, Pf_id, Fb_addUser, Fb_addTime, Fb_solveUser, Fb_solveTime, Fb_solvedescription, Fb_state, Fb_text1, Fb_text2, Fb_del) VALUES (@Fb_id, @Fb_title, @Fb_description, @Fb_url, @Pf_id, @Fb_addUser, @Fb_addTime, @Fb_solveUser, @Fb_solveTime, @Fb_solvedescription, @Fb_state, @Fb_text1, @Fb_text2, @Fb_del) ";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Fb_id", item.FbId, DbType.Int32, 0)
							.AddInParameter("@Fb_title", item.FbTitle != null ?  (object)item.FbTitle : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Fb_description", item.FbDescription != null ?  (object)item.FbDescription : DBNull.Value, DbType.String, 2147483647)
							.AddInParameter("@Fb_url", item.FbUrl != null ?  (object)item.FbUrl : DBNull.Value, DbType.String, 600)
							.AddInParameter("@Pf_id", item.PfId != null ?  (object)item.PfId : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Fb_addUser", item.FbAddUser != null ?  (object)item.FbAddUser : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Fb_addTime", item.FbAddTime, DbType.DateTime, 0)
							.AddInParameter("@Fb_solveUser", item.FbSolveUser != null ?  (object)item.FbSolveUser : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Fb_solveTime", item.FbSolveTime, DbType.DateTime, 0)
							.AddInParameter("@Fb_solvedescription", item.FbSolvedescription != null ?  (object)item.FbSolvedescription : DBNull.Value, DbType.String, 2147483647)
							.AddInParameter("@Fb_state", item.FbState != null ?  (object)item.FbState : DBNull.Value, DbType.String, 3)
							.AddInParameter("@Fb_text1", item.FbText1 != null ?  (object)item.FbText1 : DBNull.Value, DbType.String, 600)
							.AddInParameter("@Fb_text2", item.FbText2 != null ?  (object)item.FbText2 : DBNull.Value, DbType.String, 600)
							.AddInParameter("@Fb_del", item.FbDel != null ?  (object)item.FbDel : DBNull.Value, DbType.String, 3)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 插入一组数据
		/// </summary>
		/// <param name = "items">要插入的实体对象集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Add(IEnumerable<FeedbackEO> items, TransactionManager tm = null)
		{
			int ret = 0;
			const string sql = @"INSERT INTO feedback (Fb_id, Fb_title, Fb_description, Fb_url, Pf_id, Fb_addUser, Fb_addTime, Fb_solveUser, Fb_solveTime, Fb_solvedescription, Fb_state, Fb_text1, Fb_text2, Fb_del) VALUES (@Fb_id, @Fb_title, @Fb_description, @Fb_url, @Pf_id, @Fb_addUser, @Fb_addTime, @Fb_solveUser, @Fb_solveTime, @Fb_solvedescription, @Fb_state, @Fb_text1, @Fb_text2, @Fb_del) ";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@Fb_id", DbType.Int32, 0)
									.AddParameter("@Fb_title", DbType.String, 150)
									.AddParameter("@Fb_description", DbType.String, 2147483647)
									.AddParameter("@Fb_url", DbType.String, 600)
									.AddParameter("@Pf_id", DbType.String, 150)
									.AddParameter("@Fb_addUser", DbType.String, 150)
									.AddParameter("@Fb_addTime", DbType.DateTime, 0)
									.AddParameter("@Fb_solveUser", DbType.String, 150)
									.AddParameter("@Fb_solveTime", DbType.DateTime, 0)
									.AddParameter("@Fb_solvedescription", DbType.String, 2147483647)
									.AddParameter("@Fb_state", DbType.String, 3)
									.AddParameter("@Fb_text1", DbType.String, 600)
									.AddParameter("@Fb_text2", DbType.String, 600)
									.AddParameter("@Fb_del", DbType.String, 3);

			foreach (FeedbackEO item in items)
			{
				sqlDao
					.SetParameterValue("@Fb_id", item.FbId)
					.SetParameterValue("@Fb_title", item.FbTitle != null ?  (object)item.FbTitle : DBNull.Value)
					.SetParameterValue("@Fb_description", item.FbDescription != null ?  (object)item.FbDescription : DBNull.Value)
					.SetParameterValue("@Fb_url", item.FbUrl != null ?  (object)item.FbUrl : DBNull.Value)
					.SetParameterValue("@Pf_id", item.PfId != null ?  (object)item.PfId : DBNull.Value)
					.SetParameterValue("@Fb_addUser", item.FbAddUser != null ?  (object)item.FbAddUser : DBNull.Value)
					.SetParameterValue("@Fb_addTime", item.FbAddTime)
					.SetParameterValue("@Fb_solveUser", item.FbSolveUser != null ?  (object)item.FbSolveUser : DBNull.Value)
					.SetParameterValue("@Fb_solveTime", item.FbSolveTime)
					.SetParameterValue("@Fb_solvedescription", item.FbSolvedescription != null ?  (object)item.FbSolvedescription : DBNull.Value)
					.SetParameterValue("@Fb_state", item.FbState != null ?  (object)item.FbState : DBNull.Value)
					.SetParameterValue("@Fb_text1", item.FbText1 != null ?  (object)item.FbText1 : DBNull.Value)
					.SetParameterValue("@Fb_text2", item.FbText2 != null ?  (object)item.FbText2 : DBNull.Value)
					.SetParameterValue("@Fb_del", item.FbDel != null ?  (object)item.FbDel : DBNull.Value)
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
		public virtual int Put(FeedbackEO item, TransactionManager tm = null)
		{
			const string sql = @"UPDATE feedback SET Fb_id=@Fb_id, Fb_title=@Fb_title, Fb_description=@Fb_description, Fb_url=@Fb_url, Pf_id=@Pf_id, Fb_addUser=@Fb_addUser, Fb_addTime=@Fb_addTime, Fb_solveUser=@Fb_solveUser, Fb_solveTime=@Fb_solveTime, Fb_solvedescription=@Fb_solvedescription, Fb_state=@Fb_state, Fb_text1=@Fb_text1, Fb_text2=@Fb_text2, Fb_del=@Fb_del WHERE Fb_id=@OriginalFb_id";
			return Database.CreateSqlDao (sql)
							.AddInParameter("@OriginalFbId", (item.HasOriginal) ? item.OriginalFbId : item.FbId, DbType.Int32, 0)
							.AddInParameter("@Fb_id", item.FbId, DbType.Int32, 0)
							.AddInParameter("@Fb_title", item.FbTitle != null ?  (object)item.FbTitle : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Fb_description", item.FbDescription != null ?  (object)item.FbDescription : DBNull.Value, DbType.String, 2147483647)
							.AddInParameter("@Fb_url", item.FbUrl != null ?  (object)item.FbUrl : DBNull.Value, DbType.String, 600)
							.AddInParameter("@Pf_id", item.PfId != null ?  (object)item.PfId : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Fb_addUser", item.FbAddUser != null ?  (object)item.FbAddUser : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Fb_addTime", item.FbAddTime, DbType.DateTime, 0)
							.AddInParameter("@Fb_solveUser", item.FbSolveUser != null ?  (object)item.FbSolveUser : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Fb_solveTime", item.FbSolveTime, DbType.DateTime, 0)
							.AddInParameter("@Fb_solvedescription", item.FbSolvedescription != null ?  (object)item.FbSolvedescription : DBNull.Value, DbType.String, 2147483647)
							.AddInParameter("@Fb_state", item.FbState != null ?  (object)item.FbState : DBNull.Value, DbType.String, 3)
							.AddInParameter("@Fb_text1", item.FbText1 != null ?  (object)item.FbText1 : DBNull.Value, DbType.String, 600)
							.AddInParameter("@Fb_text2", item.FbText2 != null ?  (object)item.FbText2 : DBNull.Value, DbType.String, 600)
							.AddInParameter("@Fb_del", item.FbDel != null ?  (object)item.FbDel : DBNull.Value, DbType.String, 3)
							.ExecNonQuery(tm);
		}


		/// <summary>
		/// 更新数据
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Put(IEnumerable<FeedbackEO> items, TransactionManager tm = null)
		{

			int ret = 0;
			const string sql = @"UPDATE feedback SET Fb_id=@Fb_id, Fb_title=@Fb_title, Fb_description=@Fb_description, Fb_url=@Fb_url, Pf_id=@Pf_id, Fb_addUser=@Fb_addUser, Fb_addTime=@Fb_addTime, Fb_solveUser=@Fb_solveUser, Fb_solveTime=@Fb_solveTime, Fb_solvedescription=@Fb_solvedescription, Fb_state=@Fb_state, Fb_text1=@Fb_text1, Fb_text2=@Fb_text2, Fb_del=@Fb_del WHERE Fb_id=@OriginalFb_id";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@OriginalFbId", DbType.Int32, 0)
									.AddParameter("@Fb_id", DbType.Int32, 0)
									.AddParameter("@Fb_title", DbType.String, 150)
									.AddParameter("@Fb_description", DbType.String, 2147483647)
									.AddParameter("@Fb_url", DbType.String, 600)
									.AddParameter("@Pf_id", DbType.String, 150)
									.AddParameter("@Fb_addUser", DbType.String, 150)
									.AddParameter("@Fb_addTime", DbType.DateTime, 0)
									.AddParameter("@Fb_solveUser", DbType.String, 150)
									.AddParameter("@Fb_solveTime", DbType.DateTime, 0)
									.AddParameter("@Fb_solvedescription", DbType.String, 2147483647)
									.AddParameter("@Fb_state", DbType.String, 3)
									.AddParameter("@Fb_text1", DbType.String, 600)
									.AddParameter("@Fb_text2", DbType.String, 600)
									.AddParameter("@Fb_del", DbType.String, 3);

			foreach (FeedbackEO item in items)
			{
				ret += sqlDao
							.SetParameterValue("@OriginalFbId", (item.HasOriginal) ? item.OriginalFbId : item.FbId)
							.SetParameterValue("@Fb_id", item.FbId)
							.SetParameterValue("@Fb_title", item.FbTitle != null ?  (object)item.FbTitle : DBNull.Value)
							.SetParameterValue("@Fb_description", item.FbDescription != null ?  (object)item.FbDescription : DBNull.Value)
							.SetParameterValue("@Fb_url", item.FbUrl != null ?  (object)item.FbUrl : DBNull.Value)
							.SetParameterValue("@Pf_id", item.PfId != null ?  (object)item.PfId : DBNull.Value)
							.SetParameterValue("@Fb_addUser", item.FbAddUser != null ?  (object)item.FbAddUser : DBNull.Value)
							.SetParameterValue("@Fb_addTime", item.FbAddTime)
							.SetParameterValue("@Fb_solveUser", item.FbSolveUser != null ?  (object)item.FbSolveUser : DBNull.Value)
							.SetParameterValue("@Fb_solveTime", item.FbSolveTime)
							.SetParameterValue("@Fb_solvedescription", item.FbSolvedescription != null ?  (object)item.FbSolvedescription : DBNull.Value)
							.SetParameterValue("@Fb_state", item.FbState != null ?  (object)item.FbState : DBNull.Value)
							.SetParameterValue("@Fb_text1", item.FbText1 != null ?  (object)item.FbText1 : DBNull.Value)
							.SetParameterValue("@Fb_text2", item.FbText2 != null ?  (object)item.FbText2 : DBNull.Value)
							.SetParameterValue("@Fb_del", item.FbDel != null ?  (object)item.FbDel : DBNull.Value)
							.ExecNonQuery(tm);
			}
			return ret;
		}


		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "fbId"></param>
		/// <param name = "fbTitle"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutFbTitleByPK(int fbId, string fbTitle, TransactionManager tm = null)
		{
			const string sql = @"UPDATE feedback SET Fb_title = @Fb_title  WHERE Fb_id = @Fb_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Fb_id", fbId, DbType.Int32, 0)
							.AddInParameter("@Fb_title", fbTitle != null ?  (object)fbTitle : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "fbId"></param>
		/// <param name = "fbDescription"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutFbDescriptionByPK(int fbId, string fbDescription, TransactionManager tm = null)
		{
			const string sql = @"UPDATE feedback SET Fb_description = @Fb_description  WHERE Fb_id = @Fb_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Fb_id", fbId, DbType.Int32, 0)
							.AddInParameter("@Fb_description", fbDescription != null ?  (object)fbDescription : DBNull.Value, DbType.String, 2147483647)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "fbId"></param>
		/// <param name = "fbUrl"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutFbUrlByPK(int fbId, string fbUrl, TransactionManager tm = null)
		{
			const string sql = @"UPDATE feedback SET Fb_url = @Fb_url  WHERE Fb_id = @Fb_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Fb_id", fbId, DbType.Int32, 0)
							.AddInParameter("@Fb_url", fbUrl != null ?  (object)fbUrl : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "fbId"></param>
		/// <param name = "pfId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutPfIdByPK(int fbId, string pfId, TransactionManager tm = null)
		{
			const string sql = @"UPDATE feedback SET Pf_id = @Pf_id  WHERE Fb_id = @Fb_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Fb_id", fbId, DbType.Int32, 0)
							.AddInParameter("@Pf_id", pfId != null ?  (object)pfId : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "fbId"></param>
		/// <param name = "fbAddUser"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutFbAddUserByPK(int fbId, string fbAddUser, TransactionManager tm = null)
		{
			const string sql = @"UPDATE feedback SET Fb_addUser = @Fb_addUser  WHERE Fb_id = @Fb_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Fb_id", fbId, DbType.Int32, 0)
							.AddInParameter("@Fb_addUser", fbAddUser != null ?  (object)fbAddUser : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "fbId"></param>
		/// <param name = "fbAddTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutFbAddTimeByPK(int fbId, DateTime fbAddTime, TransactionManager tm = null)
		{
			const string sql = @"UPDATE feedback SET Fb_addTime = @Fb_addTime  WHERE Fb_id = @Fb_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Fb_id", fbId, DbType.Int32, 0)
							.AddInParameter("@Fb_addTime", fbAddTime, DbType.DateTime, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "fbId"></param>
		/// <param name = "fbSolveUser"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutFbSolveUserByPK(int fbId, string fbSolveUser, TransactionManager tm = null)
		{
			const string sql = @"UPDATE feedback SET Fb_solveUser = @Fb_solveUser  WHERE Fb_id = @Fb_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Fb_id", fbId, DbType.Int32, 0)
							.AddInParameter("@Fb_solveUser", fbSolveUser != null ?  (object)fbSolveUser : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "fbId"></param>
		/// <param name = "fbSolveTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutFbSolveTimeByPK(int fbId, DateTime fbSolveTime, TransactionManager tm = null)
		{
			const string sql = @"UPDATE feedback SET Fb_solveTime = @Fb_solveTime  WHERE Fb_id = @Fb_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Fb_id", fbId, DbType.Int32, 0)
							.AddInParameter("@Fb_solveTime", fbSolveTime, DbType.DateTime, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "fbId"></param>
		/// <param name = "fbSolvedescription"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutFbSolvedescriptionByPK(int fbId, string fbSolvedescription, TransactionManager tm = null)
		{
			const string sql = @"UPDATE feedback SET Fb_solvedescription = @Fb_solvedescription  WHERE Fb_id = @Fb_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Fb_id", fbId, DbType.Int32, 0)
							.AddInParameter("@Fb_solvedescription", fbSolvedescription != null ?  (object)fbSolvedescription : DBNull.Value, DbType.String, 2147483647)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "fbId"></param>
		/// <param name = "fbState"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutFbStateByPK(int fbId, string fbState, TransactionManager tm = null)
		{
			const string sql = @"UPDATE feedback SET Fb_state = @Fb_state  WHERE Fb_id = @Fb_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Fb_id", fbId, DbType.Int32, 0)
							.AddInParameter("@Fb_state", fbState != null ?  (object)fbState : DBNull.Value, DbType.String, 3)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "fbId"></param>
		/// <param name = "fbText1"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutFbText1ByPK(int fbId, string fbText1, TransactionManager tm = null)
		{
			const string sql = @"UPDATE feedback SET Fb_text1 = @Fb_text1  WHERE Fb_id = @Fb_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Fb_id", fbId, DbType.Int32, 0)
							.AddInParameter("@Fb_text1", fbText1 != null ?  (object)fbText1 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "fbId"></param>
		/// <param name = "fbText2"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutFbText2ByPK(int fbId, string fbText2, TransactionManager tm = null)
		{
			const string sql = @"UPDATE feedback SET Fb_text2 = @Fb_text2  WHERE Fb_id = @Fb_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Fb_id", fbId, DbType.Int32, 0)
							.AddInParameter("@Fb_text2", fbText2 != null ?  (object)fbText2 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "fbId"></param>
		/// <param name = "fbDel"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutFbDelByPK(int fbId, string fbDel, TransactionManager tm = null)
		{
			const string sql = @"UPDATE feedback SET Fb_del = @Fb_del  WHERE Fb_id = @Fb_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Fb_id", fbId, DbType.Int32, 0)
							.AddInParameter("@Fb_del", fbDel != null ?  (object)fbDel : DBNull.Value, DbType.String, 3)
							.ExecNonQuery(tm);
		}


		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "fbTitle"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutFbTitle(string fbTitle, TransactionManager tm = null)
		{
			const string sql = @"UPDATE feedback SET Fb_title=@Fb_title";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Fb_title", fbTitle != null ?  (object)fbTitle : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "fbDescription"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutFbDescription(string fbDescription, TransactionManager tm = null)
		{
			const string sql = @"UPDATE feedback SET Fb_description=@Fb_description";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Fb_description", fbDescription != null ?  (object)fbDescription : DBNull.Value, DbType.String, 2147483647)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "fbUrl"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutFbUrl(string fbUrl, TransactionManager tm = null)
		{
			const string sql = @"UPDATE feedback SET Fb_url=@Fb_url";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Fb_url", fbUrl != null ?  (object)fbUrl : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "pfId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutPfId(string pfId, TransactionManager tm = null)
		{
			const string sql = @"UPDATE feedback SET Pf_id=@Pf_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pf_id", pfId != null ?  (object)pfId : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "fbAddUser"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutFbAddUser(string fbAddUser, TransactionManager tm = null)
		{
			const string sql = @"UPDATE feedback SET Fb_addUser=@Fb_addUser";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Fb_addUser", fbAddUser != null ?  (object)fbAddUser : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "fbAddTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutFbAddTime(DateTime fbAddTime, TransactionManager tm = null)
		{
			const string sql = @"UPDATE feedback SET Fb_addTime=@Fb_addTime";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Fb_addTime", fbAddTime, DbType.DateTime, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "fbSolveUser"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutFbSolveUser(string fbSolveUser, TransactionManager tm = null)
		{
			const string sql = @"UPDATE feedback SET Fb_solveUser=@Fb_solveUser";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Fb_solveUser", fbSolveUser != null ?  (object)fbSolveUser : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "fbSolveTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutFbSolveTime(DateTime fbSolveTime, TransactionManager tm = null)
		{
			const string sql = @"UPDATE feedback SET Fb_solveTime=@Fb_solveTime";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Fb_solveTime", fbSolveTime, DbType.DateTime, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "fbSolvedescription"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutFbSolvedescription(string fbSolvedescription, TransactionManager tm = null)
		{
			const string sql = @"UPDATE feedback SET Fb_solvedescription=@Fb_solvedescription";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Fb_solvedescription", fbSolvedescription != null ?  (object)fbSolvedescription : DBNull.Value, DbType.String, 2147483647)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "fbState"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutFbState(string fbState, TransactionManager tm = null)
		{
			const string sql = @"UPDATE feedback SET Fb_state=@Fb_state";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Fb_state", fbState != null ?  (object)fbState : DBNull.Value, DbType.String, 3)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "fbText1"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutFbText1(string fbText1, TransactionManager tm = null)
		{
			const string sql = @"UPDATE feedback SET Fb_text1=@Fb_text1";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Fb_text1", fbText1 != null ?  (object)fbText1 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "fbText2"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutFbText2(string fbText2, TransactionManager tm = null)
		{
			const string sql = @"UPDATE feedback SET Fb_text2=@Fb_text2";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Fb_text2", fbText2 != null ?  (object)fbText2 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "fbDel"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutFbDel(string fbDel, TransactionManager tm = null)
		{
			const string sql = @"UPDATE feedback SET Fb_del=@Fb_del";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Fb_del", fbDel != null ?  (object)fbDel : DBNull.Value, DbType.String, 3)
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
			const string format = @"UPDATE feedback SET {0} {1}";
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
			const string format = @"UPDATE feedback SET {0} {1}";
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
		/// <param name = "fbId"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByPK(int fbId, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM feedback WHERE Fb_id=@Fb_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Fb_id", fbId, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Remove(FeedbackEO item, TransactionManager tm = null)
		{
			return RemoveByPK(item.FbId, tm);
		}

		/// <summary>
		/// 删除指定实体集合对应的记录集
		/// </summary>
		/// <param name = "items">要删除的实体集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Remove(IEnumerable<FeedbackEO> items, TransactionManager tm = null)
		{
			return Remove(items.Select(w => w.FbId), tm);
		}

		/// <summary>
		/// 根据主键删除一组记录
		/// </summary>
		/// <param name = "fbIds">主键编码集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Remove(IEnumerable<int> fbIds, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM feedback WHERE Fb_id IN ({0})";
			return Database.CreateSqlDao(String.Format(sql, String.Join(",", fbIds)))
							.ExecNonQuery(tm);
		}




		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "fbTitle"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByFbTitle(string fbTitle, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM feedback WHERE Fb_title=@Fb_title";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Fb_title", fbTitle != null ?  (object)fbTitle : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "fbDescription"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByFbDescription(string fbDescription, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM feedback WHERE Fb_description=@Fb_description";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Fb_description", fbDescription != null ?  (object)fbDescription : DBNull.Value, DbType.String, 2147483647)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "fbUrl"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByFbUrl(string fbUrl, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM feedback WHERE Fb_url=@Fb_url";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Fb_url", fbUrl != null ?  (object)fbUrl : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "pfId"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByPfId(string pfId, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM feedback WHERE Pf_id=@Pf_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pf_id", pfId != null ?  (object)pfId : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "fbAddUser"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByFbAddUser(string fbAddUser, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM feedback WHERE Fb_addUser=@Fb_addUser";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Fb_addUser", fbAddUser != null ?  (object)fbAddUser : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "fbAddTime"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByFbAddTime(DateTime fbAddTime, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM feedback WHERE Fb_addTime=@Fb_addTime";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Fb_addTime", fbAddTime, DbType.DateTime, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "fbSolveUser"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByFbSolveUser(string fbSolveUser, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM feedback WHERE Fb_solveUser=@Fb_solveUser";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Fb_solveUser", fbSolveUser != null ?  (object)fbSolveUser : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "fbSolveTime"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByFbSolveTime(DateTime fbSolveTime, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM feedback WHERE Fb_solveTime=@Fb_solveTime";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Fb_solveTime", fbSolveTime, DbType.DateTime, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "fbSolvedescription"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByFbSolvedescription(string fbSolvedescription, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM feedback WHERE Fb_solvedescription=@Fb_solvedescription";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Fb_solvedescription", fbSolvedescription != null ?  (object)fbSolvedescription : DBNull.Value, DbType.String, 2147483647)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "fbState"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByFbState(string fbState, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM feedback WHERE Fb_state=@Fb_state";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Fb_state", fbState != null ?  (object)fbState : DBNull.Value, DbType.String, 3)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "fbText1"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByFbText1(string fbText1, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM feedback WHERE Fb_text1=@Fb_text1";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Fb_text1", fbText1 != null ?  (object)fbText1 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "fbText2"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByFbText2(string fbText2, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM feedback WHERE Fb_text2=@Fb_text2";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Fb_text2", fbText2 != null ?  (object)fbText2 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "fbDel"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByFbDel(string fbDel, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM feedback WHERE Fb_del=@Fb_del";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Fb_del", fbDel != null ?  (object)fbDel : DBNull.Value, DbType.String, 3)
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
			const string format = @"DELETE FROM feedback {0}";
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
			const string format = @"DELETE FROM feedback {0}";
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
