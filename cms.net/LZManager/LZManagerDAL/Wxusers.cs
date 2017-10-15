//==========================================================
// 此代码由代码生成器工具自动生成，请不要修改
// 代码生成器核心库版本号：2.0
// 创建时间：2017/10/8 15:03:09
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
	/// 【表 wxusers 的实体类】
	/// </summary>
	[SerializableAttribute]
	public class WxusersEO : DataEntityBase, IRowMapper<WxusersEO>
	{
		protected string _originalWxId;

		/// <summary>
		/// 主键是否有原始值（即数据库中保存的值），用于实体对象更新时
		/// </summary>
		public bool HasOriginal { get; protected set; }

		/// <summary>
		/// 【主键 varchar】
		/// </summary>
		public virtual string WxId { get; set; }

		/// <summary>
		/// 【数据库中的原始主键值副本】
		/// </summary>
		public virtual string OriginalWxId
		{
			get { return _originalWxId; }
			set { HasOriginal = true; _originalWxId = value; }
		}

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string WxOpenid { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string WxNickname { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string WxHeadurl { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string WxSex { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string WxDuid { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string WxState { get; set; }

		/// <summary>
		/// 【字段 datetime】
		/// </summary>
		public virtual DateTime? WxBindtime { get; set; }

		/// <summary>
		/// 默认构造函数
		/// </summary>
		public WxusersEO() 
		{
			WxId = string.Empty;
		}

		/// <summary>
		/// 自定义构造函数
		/// </summary>
		/// <param name = "wxId"></param>
		/// <param name = "wxOpenid"></param>
		/// <param name = "wxNickname"></param>
		/// <param name = "wxHeadurl"></param>
		/// <param name = "wxSex"></param>
		/// <param name = "wxDuid"></param>
		/// <param name = "wxState"></param>
		/// <param name = "wxBindtime"></param>
		public WxusersEO(string wxId, string wxOpenid, string wxNickname, string wxHeadurl, string wxSex, string wxDuid, string wxState, DateTime? wxBindtime) 
		{
			WxId = wxId;
			WxOpenid = wxOpenid;
			WxNickname = wxNickname;
			WxHeadurl = wxHeadurl;
			WxSex = wxSex;
			WxDuid = wxDuid;
			WxState = wxState;
			WxBindtime = wxBindtime;
		}

		/// <summary>
		/// 将结果集映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public WxusersEO MapRow(IDataReader reader)
		{
			return GetItem(reader);
		}

		/// <summary>
		/// 将结果集映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static WxusersEO GetItem(IDataReader reader)
		{
			WxusersEO ret = new WxusersEO();

			ret.WxId = (string)reader["Wx_id"];
			ret.OriginalWxId = ret.WxId;
			ret.WxOpenid = (reader["Wx_openid"] is DBNull) ? null : (string)reader["Wx_openid"];
			ret.WxNickname = (reader["Wx_nickname"] is DBNull) ? null : (string)reader["Wx_nickname"];
			ret.WxHeadurl = (reader["Wx_headurl"] is DBNull) ? null : (string)reader["Wx_headurl"];
			ret.WxSex = (reader["Wx_sex"] is DBNull) ? null : (string)reader["Wx_sex"];
			ret.WxDuid = (reader["Wx_duid"] is DBNull) ? null : (string)reader["Wx_duid"];
			ret.WxState = (reader["Wx_state"] is DBNull) ? null : (string)reader["Wx_state"];
			ret.WxBindtime = (reader["Wx_bindtime"] is DBNull) ? (DateTime?)null : DateTime.Parse(reader["Wx_bindtime"].ToString());
			return ret;
		}
	}


	#endregion

	#region  MO

	/// <summary>
	/// 【表 wxusers 的操作类】
	/// </summary>
	public class WxusersMO : DataManagerBase
	{

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "routeData">路由数据</param>
		public WxusersMO(object routeData = null) : base(routeData) { }

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">连接字符串名称</param>
		public WxusersMO(string connectionStringName) : base(connectionStringName) { }

		#region  Get方法集合

		/// <summary>
		/// 按 PK（主键） 查询
		/// </summary>
		/// <param name="tm">事务管理对象</param>
		/// <param name = "wxId"></param>
		/// <return></return>
		public virtual WxusersEO GetByPK(string wxId, TransactionManager tm = null)
		{
			const string sql = @"SELECT Wx_id, Wx_openid, Wx_nickname, Wx_headurl, Wx_sex, Wx_duid, Wx_state, Wx_bindtime FROM wxusers WHERE Wx_id=@Wx_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Wx_id", wxId, DbType.String, 150)
							.ExecSingle<WxusersEO>(WxusersEO.GetItem, tm);
		}




		#region  按 WxOpenid（字段） 查询

		/// <summary>
		/// 按 WxOpenid（字段） 查询
		/// </summary>
		/// <param name = "wxOpenid"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<WxusersEO> GetByWxOpenid(string wxOpenid)
		{
			return GetByWxOpenid(wxOpenid, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 WxOpenid（字段） 查询
		/// </summary>
		/// <param name = "wxOpenid"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<WxusersEO> GetByWxOpenid(string wxOpenid, TransactionManager tm)
		{
			return GetByWxOpenid(wxOpenid, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 WxOpenid（字段） 查询
		/// </summary>
		/// <param name = "wxOpenid"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<WxusersEO> GetByWxOpenid(string wxOpenid, int top)
		{
			return GetByWxOpenid(wxOpenid, top, string.Empty, null);
		}

		/// <summary>
		/// 按 WxOpenid（字段） 查询
		/// </summary>
		/// <param name = "wxOpenid"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<WxusersEO> GetByWxOpenid(string wxOpenid, int top, TransactionManager tm)
		{
			return GetByWxOpenid(wxOpenid, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 WxOpenid（字段） 查询
		/// </summary>
		/// <param name = "wxOpenid"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<WxusersEO> GetByWxOpenid(string wxOpenid, string sort)
		{
			return GetByWxOpenid(wxOpenid, 0, sort, null);
		}

		/// <summary>
		/// 按 WxOpenid（字段） 查询
		/// </summary>
		/// <param name = "wxOpenid"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<WxusersEO> GetByWxOpenid(string wxOpenid, string sort, TransactionManager tm)
		{
			return GetByWxOpenid(wxOpenid, 0, sort, tm);
		}

		/// <summary>
		/// 按 WxOpenid（字段） 查询
		/// </summary>
		/// <param name = "wxOpenid"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<WxusersEO> GetByWxOpenid(string wxOpenid, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Wx_id, Wx_openid, Wx_nickname, Wx_headurl, Wx_sex, Wx_duid, Wx_state, Wx_bindtime FROM wxusers WHERE Wx_openid=@WxOpenid";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@WxOpenid", wxOpenid, DbType.String, 150)
							.ExecList<WxusersEO>(WxusersEO.GetItem, tm);
		}

		#endregion

		#region  按 WxNickname（字段） 查询

		/// <summary>
		/// 按 WxNickname（字段） 查询
		/// </summary>
		/// <param name = "wxNickname"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<WxusersEO> GetByWxNickname(string wxNickname)
		{
			return GetByWxNickname(wxNickname, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 WxNickname（字段） 查询
		/// </summary>
		/// <param name = "wxNickname"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<WxusersEO> GetByWxNickname(string wxNickname, TransactionManager tm)
		{
			return GetByWxNickname(wxNickname, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 WxNickname（字段） 查询
		/// </summary>
		/// <param name = "wxNickname"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<WxusersEO> GetByWxNickname(string wxNickname, int top)
		{
			return GetByWxNickname(wxNickname, top, string.Empty, null);
		}

		/// <summary>
		/// 按 WxNickname（字段） 查询
		/// </summary>
		/// <param name = "wxNickname"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<WxusersEO> GetByWxNickname(string wxNickname, int top, TransactionManager tm)
		{
			return GetByWxNickname(wxNickname, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 WxNickname（字段） 查询
		/// </summary>
		/// <param name = "wxNickname"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<WxusersEO> GetByWxNickname(string wxNickname, string sort)
		{
			return GetByWxNickname(wxNickname, 0, sort, null);
		}

		/// <summary>
		/// 按 WxNickname（字段） 查询
		/// </summary>
		/// <param name = "wxNickname"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<WxusersEO> GetByWxNickname(string wxNickname, string sort, TransactionManager tm)
		{
			return GetByWxNickname(wxNickname, 0, sort, tm);
		}

		/// <summary>
		/// 按 WxNickname（字段） 查询
		/// </summary>
		/// <param name = "wxNickname"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<WxusersEO> GetByWxNickname(string wxNickname, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Wx_id, Wx_openid, Wx_nickname, Wx_headurl, Wx_sex, Wx_duid, Wx_state, Wx_bindtime FROM wxusers WHERE Wx_nickname=@WxNickname";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@WxNickname", wxNickname, DbType.String, 300)
							.ExecList<WxusersEO>(WxusersEO.GetItem, tm);
		}

		#endregion

		#region  按 WxHeadurl（字段） 查询

		/// <summary>
		/// 按 WxHeadurl（字段） 查询
		/// </summary>
		/// <param name = "wxHeadurl"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<WxusersEO> GetByWxHeadurl(string wxHeadurl)
		{
			return GetByWxHeadurl(wxHeadurl, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 WxHeadurl（字段） 查询
		/// </summary>
		/// <param name = "wxHeadurl"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<WxusersEO> GetByWxHeadurl(string wxHeadurl, TransactionManager tm)
		{
			return GetByWxHeadurl(wxHeadurl, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 WxHeadurl（字段） 查询
		/// </summary>
		/// <param name = "wxHeadurl"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<WxusersEO> GetByWxHeadurl(string wxHeadurl, int top)
		{
			return GetByWxHeadurl(wxHeadurl, top, string.Empty, null);
		}

		/// <summary>
		/// 按 WxHeadurl（字段） 查询
		/// </summary>
		/// <param name = "wxHeadurl"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<WxusersEO> GetByWxHeadurl(string wxHeadurl, int top, TransactionManager tm)
		{
			return GetByWxHeadurl(wxHeadurl, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 WxHeadurl（字段） 查询
		/// </summary>
		/// <param name = "wxHeadurl"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<WxusersEO> GetByWxHeadurl(string wxHeadurl, string sort)
		{
			return GetByWxHeadurl(wxHeadurl, 0, sort, null);
		}

		/// <summary>
		/// 按 WxHeadurl（字段） 查询
		/// </summary>
		/// <param name = "wxHeadurl"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<WxusersEO> GetByWxHeadurl(string wxHeadurl, string sort, TransactionManager tm)
		{
			return GetByWxHeadurl(wxHeadurl, 0, sort, tm);
		}

		/// <summary>
		/// 按 WxHeadurl（字段） 查询
		/// </summary>
		/// <param name = "wxHeadurl"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<WxusersEO> GetByWxHeadurl(string wxHeadurl, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Wx_id, Wx_openid, Wx_nickname, Wx_headurl, Wx_sex, Wx_duid, Wx_state, Wx_bindtime FROM wxusers WHERE Wx_headurl=@WxHeadurl";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@WxHeadurl", wxHeadurl, DbType.String, 150)
							.ExecList<WxusersEO>(WxusersEO.GetItem, tm);
		}

		#endregion

		#region  按 WxSex（字段） 查询

		/// <summary>
		/// 按 WxSex（字段） 查询
		/// </summary>
		/// <param name = "wxSex"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<WxusersEO> GetByWxSex(string wxSex)
		{
			return GetByWxSex(wxSex, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 WxSex（字段） 查询
		/// </summary>
		/// <param name = "wxSex"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<WxusersEO> GetByWxSex(string wxSex, TransactionManager tm)
		{
			return GetByWxSex(wxSex, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 WxSex（字段） 查询
		/// </summary>
		/// <param name = "wxSex"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<WxusersEO> GetByWxSex(string wxSex, int top)
		{
			return GetByWxSex(wxSex, top, string.Empty, null);
		}

		/// <summary>
		/// 按 WxSex（字段） 查询
		/// </summary>
		/// <param name = "wxSex"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<WxusersEO> GetByWxSex(string wxSex, int top, TransactionManager tm)
		{
			return GetByWxSex(wxSex, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 WxSex（字段） 查询
		/// </summary>
		/// <param name = "wxSex"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<WxusersEO> GetByWxSex(string wxSex, string sort)
		{
			return GetByWxSex(wxSex, 0, sort, null);
		}

		/// <summary>
		/// 按 WxSex（字段） 查询
		/// </summary>
		/// <param name = "wxSex"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<WxusersEO> GetByWxSex(string wxSex, string sort, TransactionManager tm)
		{
			return GetByWxSex(wxSex, 0, sort, tm);
		}

		/// <summary>
		/// 按 WxSex（字段） 查询
		/// </summary>
		/// <param name = "wxSex"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<WxusersEO> GetByWxSex(string wxSex, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Wx_id, Wx_openid, Wx_nickname, Wx_headurl, Wx_sex, Wx_duid, Wx_state, Wx_bindtime FROM wxusers WHERE Wx_sex=@WxSex";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@WxSex", wxSex, DbType.String, 150)
							.ExecList<WxusersEO>(WxusersEO.GetItem, tm);
		}

		#endregion

		#region  按 WxDuid（字段） 查询

		/// <summary>
		/// 按 WxDuid（字段） 查询
		/// </summary>
		/// <param name = "wxDuid"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<WxusersEO> GetByWxDuid(string wxDuid)
		{
			return GetByWxDuid(wxDuid, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 WxDuid（字段） 查询
		/// </summary>
		/// <param name = "wxDuid"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<WxusersEO> GetByWxDuid(string wxDuid, TransactionManager tm)
		{
			return GetByWxDuid(wxDuid, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 WxDuid（字段） 查询
		/// </summary>
		/// <param name = "wxDuid"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<WxusersEO> GetByWxDuid(string wxDuid, int top)
		{
			return GetByWxDuid(wxDuid, top, string.Empty, null);
		}

		/// <summary>
		/// 按 WxDuid（字段） 查询
		/// </summary>
		/// <param name = "wxDuid"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<WxusersEO> GetByWxDuid(string wxDuid, int top, TransactionManager tm)
		{
			return GetByWxDuid(wxDuid, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 WxDuid（字段） 查询
		/// </summary>
		/// <param name = "wxDuid"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<WxusersEO> GetByWxDuid(string wxDuid, string sort)
		{
			return GetByWxDuid(wxDuid, 0, sort, null);
		}

		/// <summary>
		/// 按 WxDuid（字段） 查询
		/// </summary>
		/// <param name = "wxDuid"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<WxusersEO> GetByWxDuid(string wxDuid, string sort, TransactionManager tm)
		{
			return GetByWxDuid(wxDuid, 0, sort, tm);
		}

		/// <summary>
		/// 按 WxDuid（字段） 查询
		/// </summary>
		/// <param name = "wxDuid"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<WxusersEO> GetByWxDuid(string wxDuid, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Wx_id, Wx_openid, Wx_nickname, Wx_headurl, Wx_sex, Wx_duid, Wx_state, Wx_bindtime FROM wxusers WHERE Wx_duid=@WxDuid";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@WxDuid", wxDuid, DbType.String, 150)
							.ExecList<WxusersEO>(WxusersEO.GetItem, tm);
		}

		#endregion

		#region  按 WxState（字段） 查询

		/// <summary>
		/// 按 WxState（字段） 查询
		/// </summary>
		/// <param name = "wxState"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<WxusersEO> GetByWxState(string wxState)
		{
			return GetByWxState(wxState, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 WxState（字段） 查询
		/// </summary>
		/// <param name = "wxState"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<WxusersEO> GetByWxState(string wxState, TransactionManager tm)
		{
			return GetByWxState(wxState, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 WxState（字段） 查询
		/// </summary>
		/// <param name = "wxState"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<WxusersEO> GetByWxState(string wxState, int top)
		{
			return GetByWxState(wxState, top, string.Empty, null);
		}

		/// <summary>
		/// 按 WxState（字段） 查询
		/// </summary>
		/// <param name = "wxState"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<WxusersEO> GetByWxState(string wxState, int top, TransactionManager tm)
		{
			return GetByWxState(wxState, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 WxState（字段） 查询
		/// </summary>
		/// <param name = "wxState"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<WxusersEO> GetByWxState(string wxState, string sort)
		{
			return GetByWxState(wxState, 0, sort, null);
		}

		/// <summary>
		/// 按 WxState（字段） 查询
		/// </summary>
		/// <param name = "wxState"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<WxusersEO> GetByWxState(string wxState, string sort, TransactionManager tm)
		{
			return GetByWxState(wxState, 0, sort, tm);
		}

		/// <summary>
		/// 按 WxState（字段） 查询
		/// </summary>
		/// <param name = "wxState"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<WxusersEO> GetByWxState(string wxState, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Wx_id, Wx_openid, Wx_nickname, Wx_headurl, Wx_sex, Wx_duid, Wx_state, Wx_bindtime FROM wxusers WHERE Wx_state=@WxState";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@WxState", wxState, DbType.String, 30)
							.ExecList<WxusersEO>(WxusersEO.GetItem, tm);
		}

		#endregion

		#region  按 WxBindtime（字段） 查询

		/// <summary>
		/// 按 WxBindtime（字段） 查询
		/// </summary>
		/// <param name = "wxBindtime"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<WxusersEO> GetByWxBindtime(DateTime? wxBindtime)
		{
			return GetByWxBindtime(wxBindtime, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 WxBindtime（字段） 查询
		/// </summary>
		/// <param name = "wxBindtime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<WxusersEO> GetByWxBindtime(DateTime? wxBindtime, TransactionManager tm)
		{
			return GetByWxBindtime(wxBindtime, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 WxBindtime（字段） 查询
		/// </summary>
		/// <param name = "wxBindtime"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<WxusersEO> GetByWxBindtime(DateTime? wxBindtime, int top)
		{
			return GetByWxBindtime(wxBindtime, top, string.Empty, null);
		}

		/// <summary>
		/// 按 WxBindtime（字段） 查询
		/// </summary>
		/// <param name = "wxBindtime"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<WxusersEO> GetByWxBindtime(DateTime? wxBindtime, int top, TransactionManager tm)
		{
			return GetByWxBindtime(wxBindtime, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 WxBindtime（字段） 查询
		/// </summary>
		/// <param name = "wxBindtime"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<WxusersEO> GetByWxBindtime(DateTime? wxBindtime, string sort)
		{
			return GetByWxBindtime(wxBindtime, 0, sort, null);
		}

		/// <summary>
		/// 按 WxBindtime（字段） 查询
		/// </summary>
		/// <param name = "wxBindtime"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<WxusersEO> GetByWxBindtime(DateTime? wxBindtime, string sort, TransactionManager tm)
		{
			return GetByWxBindtime(wxBindtime, 0, sort, tm);
		}

		/// <summary>
		/// 按 WxBindtime（字段） 查询
		/// </summary>
		/// <param name = "wxBindtime"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<WxusersEO> GetByWxBindtime(DateTime? wxBindtime, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Wx_id, Wx_openid, Wx_nickname, Wx_headurl, Wx_sex, Wx_duid, Wx_state, Wx_bindtime FROM wxusers WHERE Wx_bindtime=@WxBindtime";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@WxBindtime", wxBindtime, DbType.DateTime, 0)
							.ExecList<WxusersEO>(WxusersEO.GetItem, tm);
		}

		#endregion

		#region  自定义条件查询

		/// <summary>
		/// 获取所有数据
		/// </summary>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<WxusersEO> GetAll(TransactionManager tm = null)
		{
			return GetTopSort(string.Empty, null, -1, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "values">where子句中定义的参数值集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<WxusersEO> Get(string where, params object[] values)
		{
			return GetTopSort(where, -1, string.Empty, null, values);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "paras">where子句中定义的参数集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<WxusersEO> Get(string where, IEnumerable<DbParameter> paras)
		{
			return GetTopSort(where, paras, -1, string.Empty, null);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<WxusersEO> Get(string where, TransactionManager tm)
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
		public virtual IEnumerable<WxusersEO> Get(string where, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<WxusersEO> Get(string where, IEnumerable<DbParameter> paras, TransactionManager tm)
		{
			return GetTopSort(where, paras, -1, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<WxusersEO> GetTop(string where, int top)
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
		public virtual IEnumerable<WxusersEO> GetTop(string where, int top, params object[] values)
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
		public virtual IEnumerable<WxusersEO> GetTop(string where, IEnumerable<DbParameter> paras, int top)
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
		public virtual IEnumerable<WxusersEO> GetTop(string where, int top, TransactionManager tm)
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
		public virtual IEnumerable<WxusersEO> GetTop(string where, int top, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<WxusersEO> GetTop(string where, IEnumerable<DbParameter> paras, int top, TransactionManager tm)
		{
			return GetTopSort(where, paras, top, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<WxusersEO> GetSort(string where, string sort)
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
		public virtual IEnumerable<WxusersEO> GetSort(string where, string sort, params object[] values)
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
		public virtual IEnumerable<WxusersEO> GetSort(string where, IEnumerable<DbParameter> paras, string sort)
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
		public virtual IEnumerable<WxusersEO> GetSort(string where, string sort, TransactionManager tm)
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
		public virtual IEnumerable<WxusersEO> GetSort(string where, string sort, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<WxusersEO> GetSort(string where, IEnumerable<DbParameter> paras, string sort, TransactionManager tm)
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
		public virtual IEnumerable<WxusersEO> GetTopSort(string where, int top, string sort)
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
		public virtual IEnumerable<WxusersEO> GetTopSort(string where, int top, string sort, params object[] values)
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
		public virtual IEnumerable<WxusersEO> GetTopSort(string where, IEnumerable<DbParameter> paras, int top, string sort)
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
		public virtual IEnumerable<WxusersEO> GetTopSort(string where, int top, string sort, TransactionManager tm)
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
		public virtual IEnumerable<WxusersEO> GetTopSort(string where, int top, string sort, TransactionManager tm, params object[] values)
		{
			const string format = @"SELECT {0} Wx_id, Wx_openid, Wx_nickname, Wx_headurl, Wx_sex, Wx_duid, Wx_state, Wx_bindtime FROM wxusers";
			string sql = format;

			if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameters(values)
							.ExecList<WxusersEO>(WxusersEO.GetItem, tm);
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
		public virtual IEnumerable<WxusersEO> GetTopSort(string where, IEnumerable<DbParameter> paras, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Wx_id, Wx_openid, Wx_nickname, Wx_headurl, Wx_sex, Wx_duid, Wx_state, Wx_bindtime FROM wxusers";
			string sql = format;

			if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddParameters(paras)
							.ExecList<WxusersEO>(WxusersEO.GetItem, tm);
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
			const string format = @"SELECT Wx_id, Wx_openid, Wx_nickname, Wx_headurl, Wx_sex, Wx_duid, Wx_state, Wx_bindtime FROM wxusers {0} {1}";
			 string sql = string.Format(format, string.IsNullOrEmpty(where) ? string.Empty : "WHERE " + where, string.IsNullOrEmpty(sort) ? string.Empty : "ORDER BY " + sort);

			return Database.CreatePager(sql, pageSize, "Wx_id");
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
		public virtual List<WxusersEO> GetPageList(int pageIndex , int pageSize, string where = null, string sort = null, IEnumerable<DbParameter> paras = null)
		{
			var pager = GetPager(pageSize, where, sort);

			pager.AddParameters(paras);
			return pager.GetPageList<WxusersEO>(pageIndex);
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
		public virtual IEnumerable<WxusersEO> GetPageMutil(int pageIndex , int pageSize, string where = null, string sort = null, IEnumerable<DbParameter> paras = null)
		{
			var pager = GetPager(pageSize, where, sort);

			pager.AddParameters(paras);
			return pager.GetPageMutil<WxusersEO>(pageIndex);
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
		public virtual int Add(WxusersEO item, TransactionManager tm = null)
		{
			const string sql = @"INSERT INTO wxusers (Wx_id, Wx_openid, Wx_nickname, Wx_headurl, Wx_sex, Wx_duid, Wx_state, Wx_bindtime) VALUES (@Wx_id, @Wx_openid, @Wx_nickname, @Wx_headurl, @Wx_sex, @Wx_duid, @Wx_state, @Wx_bindtime) ";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Wx_id", item.WxId, DbType.String, 150)
							.AddInParameter("@Wx_openid", item.WxOpenid != null ?  (object)item.WxOpenid : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Wx_nickname", item.WxNickname != null ?  (object)item.WxNickname : DBNull.Value, DbType.String, 300)
							.AddInParameter("@Wx_headurl", item.WxHeadurl != null ?  (object)item.WxHeadurl : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Wx_sex", item.WxSex != null ?  (object)item.WxSex : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Wx_duid", item.WxDuid != null ?  (object)item.WxDuid : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Wx_state", item.WxState != null ?  (object)item.WxState : DBNull.Value, DbType.String, 30)
							.AddInParameter("@Wx_bindtime", item.WxBindtime.HasValue ? (object)item.WxBindtime.Value : DBNull.Value, DbType.DateTime, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 插入一组数据
		/// </summary>
		/// <param name = "items">要插入的实体对象集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Add(IEnumerable<WxusersEO> items, TransactionManager tm = null)
		{
			int ret = 0;
			const string sql = @"INSERT INTO wxusers (Wx_id, Wx_openid, Wx_nickname, Wx_headurl, Wx_sex, Wx_duid, Wx_state, Wx_bindtime) VALUES (@Wx_id, @Wx_openid, @Wx_nickname, @Wx_headurl, @Wx_sex, @Wx_duid, @Wx_state, @Wx_bindtime) ";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@Wx_id", DbType.String, 150)
									.AddParameter("@Wx_openid", DbType.String, 150)
									.AddParameter("@Wx_nickname", DbType.String, 300)
									.AddParameter("@Wx_headurl", DbType.String, 150)
									.AddParameter("@Wx_sex", DbType.String, 150)
									.AddParameter("@Wx_duid", DbType.String, 150)
									.AddParameter("@Wx_state", DbType.String, 30)
									.AddParameter("@Wx_bindtime", DbType.DateTime, 0);

			foreach (WxusersEO item in items)
			{
				sqlDao
					.SetParameterValue("@Wx_id", item.WxId)
					.SetParameterValue("@Wx_openid", item.WxOpenid != null ?  (object)item.WxOpenid : DBNull.Value)
					.SetParameterValue("@Wx_nickname", item.WxNickname != null ?  (object)item.WxNickname : DBNull.Value)
					.SetParameterValue("@Wx_headurl", item.WxHeadurl != null ?  (object)item.WxHeadurl : DBNull.Value)
					.SetParameterValue("@Wx_sex", item.WxSex != null ?  (object)item.WxSex : DBNull.Value)
					.SetParameterValue("@Wx_duid", item.WxDuid != null ?  (object)item.WxDuid : DBNull.Value)
					.SetParameterValue("@Wx_state", item.WxState != null ?  (object)item.WxState : DBNull.Value)
					.SetParameterValue("@Wx_bindtime", item.WxBindtime.HasValue ? (object)item.WxBindtime.Value : DBNull.Value)
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
		public virtual int Put(WxusersEO item, TransactionManager tm = null)
		{
			const string sql = @"UPDATE wxusers SET Wx_id=@Wx_id, Wx_openid=@Wx_openid, Wx_nickname=@Wx_nickname, Wx_headurl=@Wx_headurl, Wx_sex=@Wx_sex, Wx_duid=@Wx_duid, Wx_state=@Wx_state, Wx_bindtime=@Wx_bindtime WHERE Wx_id=@OriginalWx_id";
			return Database.CreateSqlDao (sql)
							.AddInParameter("@OriginalWxId", (item.HasOriginal) ? item.OriginalWxId : item.WxId, DbType.String, 150)
							.AddInParameter("@Wx_id", item.WxId, DbType.String, 150)
							.AddInParameter("@Wx_openid", item.WxOpenid != null ?  (object)item.WxOpenid : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Wx_nickname", item.WxNickname != null ?  (object)item.WxNickname : DBNull.Value, DbType.String, 300)
							.AddInParameter("@Wx_headurl", item.WxHeadurl != null ?  (object)item.WxHeadurl : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Wx_sex", item.WxSex != null ?  (object)item.WxSex : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Wx_duid", item.WxDuid != null ?  (object)item.WxDuid : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Wx_state", item.WxState != null ?  (object)item.WxState : DBNull.Value, DbType.String, 30)
							.AddInParameter("@Wx_bindtime", item.WxBindtime.HasValue ? (object)item.WxBindtime.Value : DBNull.Value, DbType.DateTime, 0)
							.ExecNonQuery(tm);
		}


		/// <summary>
		/// 更新数据
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Put(IEnumerable<WxusersEO> items, TransactionManager tm = null)
		{

			int ret = 0;
			const string sql = @"UPDATE wxusers SET Wx_id=@Wx_id, Wx_openid=@Wx_openid, Wx_nickname=@Wx_nickname, Wx_headurl=@Wx_headurl, Wx_sex=@Wx_sex, Wx_duid=@Wx_duid, Wx_state=@Wx_state, Wx_bindtime=@Wx_bindtime WHERE Wx_id=@OriginalWx_id";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@OriginalWxId", DbType.String, 150)
									.AddParameter("@Wx_id", DbType.String, 150)
									.AddParameter("@Wx_openid", DbType.String, 150)
									.AddParameter("@Wx_nickname", DbType.String, 300)
									.AddParameter("@Wx_headurl", DbType.String, 150)
									.AddParameter("@Wx_sex", DbType.String, 150)
									.AddParameter("@Wx_duid", DbType.String, 150)
									.AddParameter("@Wx_state", DbType.String, 30)
									.AddParameter("@Wx_bindtime", DbType.DateTime, 0);

			foreach (WxusersEO item in items)
			{
				ret += sqlDao
							.SetParameterValue("@OriginalWxId", (item.HasOriginal) ? item.OriginalWxId : item.WxId)
							.SetParameterValue("@Wx_id", item.WxId)
							.SetParameterValue("@Wx_openid", item.WxOpenid != null ?  (object)item.WxOpenid : DBNull.Value)
							.SetParameterValue("@Wx_nickname", item.WxNickname != null ?  (object)item.WxNickname : DBNull.Value)
							.SetParameterValue("@Wx_headurl", item.WxHeadurl != null ?  (object)item.WxHeadurl : DBNull.Value)
							.SetParameterValue("@Wx_sex", item.WxSex != null ?  (object)item.WxSex : DBNull.Value)
							.SetParameterValue("@Wx_duid", item.WxDuid != null ?  (object)item.WxDuid : DBNull.Value)
							.SetParameterValue("@Wx_state", item.WxState != null ?  (object)item.WxState : DBNull.Value)
							.SetParameterValue("@Wx_bindtime", item.WxBindtime.HasValue ? (object)item.WxBindtime.Value : DBNull.Value)
							.ExecNonQuery(tm);
			}
			return ret;
		}


		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "wxId"></param>
		/// <param name = "wxOpenid"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutWxOpenidByPK(string wxId, string wxOpenid, TransactionManager tm = null)
		{
			const string sql = @"UPDATE wxusers SET Wx_openid = @Wx_openid  WHERE Wx_id = @Wx_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Wx_id", wxId, DbType.String, 150)
							.AddInParameter("@Wx_openid", wxOpenid != null ?  (object)wxOpenid : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "wxId"></param>
		/// <param name = "wxNickname"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutWxNicknameByPK(string wxId, string wxNickname, TransactionManager tm = null)
		{
			const string sql = @"UPDATE wxusers SET Wx_nickname = @Wx_nickname  WHERE Wx_id = @Wx_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Wx_id", wxId, DbType.String, 150)
							.AddInParameter("@Wx_nickname", wxNickname != null ?  (object)wxNickname : DBNull.Value, DbType.String, 300)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "wxId"></param>
		/// <param name = "wxHeadurl"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutWxHeadurlByPK(string wxId, string wxHeadurl, TransactionManager tm = null)
		{
			const string sql = @"UPDATE wxusers SET Wx_headurl = @Wx_headurl  WHERE Wx_id = @Wx_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Wx_id", wxId, DbType.String, 150)
							.AddInParameter("@Wx_headurl", wxHeadurl != null ?  (object)wxHeadurl : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "wxId"></param>
		/// <param name = "wxSex"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutWxSexByPK(string wxId, string wxSex, TransactionManager tm = null)
		{
			const string sql = @"UPDATE wxusers SET Wx_sex = @Wx_sex  WHERE Wx_id = @Wx_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Wx_id", wxId, DbType.String, 150)
							.AddInParameter("@Wx_sex", wxSex != null ?  (object)wxSex : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "wxId"></param>
		/// <param name = "wxDuid"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutWxDuidByPK(string wxId, string wxDuid, TransactionManager tm = null)
		{
			const string sql = @"UPDATE wxusers SET Wx_duid = @Wx_duid  WHERE Wx_id = @Wx_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Wx_id", wxId, DbType.String, 150)
							.AddInParameter("@Wx_duid", wxDuid != null ?  (object)wxDuid : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "wxId"></param>
		/// <param name = "wxState"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutWxStateByPK(string wxId, string wxState, TransactionManager tm = null)
		{
			const string sql = @"UPDATE wxusers SET Wx_state = @Wx_state  WHERE Wx_id = @Wx_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Wx_id", wxId, DbType.String, 150)
							.AddInParameter("@Wx_state", wxState != null ?  (object)wxState : DBNull.Value, DbType.String, 30)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "wxId"></param>
		/// <param name = "wxBindtime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutWxBindtimeByPK(string wxId, DateTime? wxBindtime, TransactionManager tm = null)
		{
			const string sql = @"UPDATE wxusers SET Wx_bindtime = @Wx_bindtime  WHERE Wx_id = @Wx_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Wx_id", wxId, DbType.String, 150)
							.AddInParameter("@Wx_bindtime", wxBindtime.HasValue ? (object)wxBindtime.Value : DBNull.Value, DbType.DateTime, 0)
							.ExecNonQuery(tm);
		}


		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "wxOpenid"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutWxOpenid(string wxOpenid, TransactionManager tm = null)
		{
			const string sql = @"UPDATE wxusers SET Wx_openid=@Wx_openid";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Wx_openid", wxOpenid != null ?  (object)wxOpenid : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "wxNickname"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutWxNickname(string wxNickname, TransactionManager tm = null)
		{
			const string sql = @"UPDATE wxusers SET Wx_nickname=@Wx_nickname";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Wx_nickname", wxNickname != null ?  (object)wxNickname : DBNull.Value, DbType.String, 300)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "wxHeadurl"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutWxHeadurl(string wxHeadurl, TransactionManager tm = null)
		{
			const string sql = @"UPDATE wxusers SET Wx_headurl=@Wx_headurl";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Wx_headurl", wxHeadurl != null ?  (object)wxHeadurl : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "wxSex"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutWxSex(string wxSex, TransactionManager tm = null)
		{
			const string sql = @"UPDATE wxusers SET Wx_sex=@Wx_sex";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Wx_sex", wxSex != null ?  (object)wxSex : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "wxDuid"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutWxDuid(string wxDuid, TransactionManager tm = null)
		{
			const string sql = @"UPDATE wxusers SET Wx_duid=@Wx_duid";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Wx_duid", wxDuid != null ?  (object)wxDuid : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "wxState"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutWxState(string wxState, TransactionManager tm = null)
		{
			const string sql = @"UPDATE wxusers SET Wx_state=@Wx_state";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Wx_state", wxState != null ?  (object)wxState : DBNull.Value, DbType.String, 30)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "wxBindtime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutWxBindtime(DateTime? wxBindtime, TransactionManager tm = null)
		{
			const string sql = @"UPDATE wxusers SET Wx_bindtime=@Wx_bindtime";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Wx_bindtime", wxBindtime.HasValue ? (object)wxBindtime.Value : DBNull.Value, DbType.DateTime, 0)
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
			const string format = @"UPDATE wxusers SET {0} {1}";
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
			const string format = @"UPDATE wxusers SET {0} {1}";
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
		/// <param name = "wxId"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByPK(string wxId, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM wxusers WHERE Wx_id=@Wx_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Wx_id", wxId, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Remove(WxusersEO item, TransactionManager tm = null)
		{
			return RemoveByPK(item.WxId, tm);
		}

		/// <summary>
		/// 删除指定实体集合对应的记录集
		/// </summary>
		/// <param name = "items">要删除的实体集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Remove(IEnumerable<WxusersEO> items, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM wxusers WHERE Wx_id=@OriginalWx_id";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@OriginalWxId", DbType.String, 150);
			int ret = 0;
			foreach (WxusersEO item in items)
			{
				ret += sqlDao
							.SetParameterValue("@OriginalWxId", (item.HasOriginal) ? item.OriginalWxId : item.WxId)
							.ExecNonQuery(tm);
			}
			return ret;
		}




		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "wxOpenid"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByWxOpenid(string wxOpenid, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM wxusers WHERE Wx_openid=@Wx_openid";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Wx_openid", wxOpenid != null ?  (object)wxOpenid : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "wxNickname"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByWxNickname(string wxNickname, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM wxusers WHERE Wx_nickname=@Wx_nickname";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Wx_nickname", wxNickname != null ?  (object)wxNickname : DBNull.Value, DbType.String, 300)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "wxHeadurl"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByWxHeadurl(string wxHeadurl, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM wxusers WHERE Wx_headurl=@Wx_headurl";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Wx_headurl", wxHeadurl != null ?  (object)wxHeadurl : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "wxSex"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByWxSex(string wxSex, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM wxusers WHERE Wx_sex=@Wx_sex";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Wx_sex", wxSex != null ?  (object)wxSex : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "wxDuid"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByWxDuid(string wxDuid, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM wxusers WHERE Wx_duid=@Wx_duid";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Wx_duid", wxDuid != null ?  (object)wxDuid : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "wxState"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByWxState(string wxState, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM wxusers WHERE Wx_state=@Wx_state";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Wx_state", wxState != null ?  (object)wxState : DBNull.Value, DbType.String, 30)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "wxBindtime"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByWxBindtime(DateTime? wxBindtime, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM wxusers WHERE Wx_bindtime=@Wx_bindtime";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Wx_bindtime", wxBindtime.HasValue ? (object)wxBindtime.Value : DBNull.Value, DbType.DateTime, 0)
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
			const string format = @"DELETE FROM wxusers {0}";
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
			const string format = @"DELETE FROM wxusers {0}";
			string sql = string.Format(format, string.IsNullOrEmpty(where) ? string.Empty : " WHERE " + where);
			return Database.CreateSqlDao(sql)
							.AddParameters(paras)
							.ExecNonQuery(tm);
		}
		#endregion

		#region  自定义方法集合
        public virtual DataTable GetTable(string where, params object[] values)
        {
            return GetTopSortTable(where, -1, string.Empty, null, values);
        }

        public virtual DataTable GetTopSortTable(string where, int top, string sort, TransactionManager tm, params object[] values)
        {
            const string format = @"SELECT {0} Wx_id, Wx_openid, Wx_nickname, Wx_headurl, Wx_sex, Wx_duid, Wx_state,Wx_bindtime FROM wxusers";
            string sql = format;

            if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
            if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
            sql = string.Format(sql, string.Empty);
            sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
            return Database.CreateSqlDao(sql)
                            .ExecTable();
        }
		#endregion
	}


	#endregion
}
