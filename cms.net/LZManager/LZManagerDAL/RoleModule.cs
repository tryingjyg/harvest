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
	/// 【表 rolemodule 的实体类】
	/// </summary>
	[SerializableAttribute]
	public class RolemoduleEO : DataEntityBase, IRowMapper<RolemoduleEO>
	{
		protected string _originalRlId;
		protected string _originalMdId;
		protected string _originalPtId;

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
		public virtual string MdId { get; set; }

		/// <summary>
		/// 【数据库中的原始主键值副本】
		/// </summary>
		public virtual string OriginalMdId
		{
			get { return _originalMdId; }
			set { HasOriginal = true; _originalMdId = value; }
		}

		/// <summary>
		/// 【主键 varchar】
		/// </summary>
		public virtual string PtId { get; set; }

		/// <summary>
		/// 【数据库中的原始主键值副本】
		/// </summary>
		public virtual string OriginalPtId
		{
			get { return _originalPtId; }
			set { HasOriginal = true; _originalPtId = value; }
		}

		/// <summary>
		/// 【字段 datetime】
		/// </summary>
		public virtual DateTime RmAddTime { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string RmText1 { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string RmText2 { get; set; }

		/// <summary>
		/// 默认构造函数
		/// </summary>
		public RolemoduleEO() 
		{
			RlId = string.Empty;
			MdId = string.Empty;
			PtId = string.Empty;
		}

		/// <summary>
		/// 自定义构造函数
		/// </summary>
		/// <param name = "rlId"></param>
		/// <param name = "mdId"></param>
		/// <param name = "ptId"></param>
		/// <param name = "rmAddTime"></param>
		/// <param name = "rmText1"></param>
		/// <param name = "rmText2"></param>
		public RolemoduleEO(string rlId, string mdId, string ptId, DateTime rmAddTime, string rmText1, string rmText2) 
		{
			RlId = rlId;
			MdId = mdId;
			PtId = ptId;
			RmAddTime = rmAddTime;
			RmText1 = rmText1;
			RmText2 = rmText2;
		}

		/// <summary>
		/// 将结果集映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public RolemoduleEO MapRow(IDataReader reader)
		{
			return GetItem(reader);
		}

		/// <summary>
		/// 将结果集映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static RolemoduleEO GetItem(IDataReader reader)
		{
			RolemoduleEO ret = new RolemoduleEO();

			ret.RlId = (string)reader["Rl_id"];
			ret.OriginalRlId = ret.RlId;
			ret.MdId = (string)reader["Md_id"];
			ret.OriginalMdId = ret.MdId;
			ret.PtId = (string)reader["Pt_id"];
			ret.OriginalPtId = ret.PtId;
			ret.RmAddTime = DateTime.Parse(reader["Rm_addTime"].ToString());
			ret.RmText1 = (reader["Rm_text1"] is DBNull) ? null : (string)reader["Rm_text1"];
			ret.RmText2 = (reader["Rm_text2"] is DBNull) ? null : (string)reader["Rm_text2"];
			return ret;
		}
	}


	#endregion

	#region  MO

	/// <summary>
	/// 【表 rolemodule 的操作类】
	/// </summary>
    public partial class RolemoduleMO : DataManagerBase
	{

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "routeData">路由数据</param>
		public RolemoduleMO(object routeData = null) : base(routeData) { }

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">连接字符串名称</param>
		public RolemoduleMO(string connectionStringName) : base(connectionStringName) { }

		#region  Get方法集合

		/// <summary>
		/// 按 PK（主键） 查询
		/// </summary>
		/// <param name="tm">事务管理对象</param>
		/// <param name = "rlId"></param>
		/// <param name = "mdId"></param>
		/// <param name = "ptId"></param>
		/// <return></return>
		public virtual RolemoduleEO GetByPK(string rlId, string mdId, string ptId, TransactionManager tm = null)
		{
			const string sql = @"SELECT Rl_id, Md_id, Pt_id, Rm_addTime, Rm_text1, Rm_text2 FROM rolemodule WHERE Rl_id=@Rl_id and Md_id=@Md_id and Pt_id=@Pt_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Rl_id", rlId, DbType.String, 150)
							.AddInParameter("@Md_id", mdId, DbType.String, 150)
							.AddInParameter("@Pt_id", ptId, DbType.String, 150)
							.ExecSingle<RolemoduleEO>(RolemoduleEO.GetItem, tm);
		}




		#region  按 RlId（字段） 查询

		/// <summary>
		/// 按 RlId（字段） 查询
		/// </summary>
		/// <param name = "rlId"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolemoduleEO> GetByRlId(string rlId)
		{
			return GetByRlId(rlId, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 RlId（字段） 查询
		/// </summary>
		/// <param name = "rlId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolemoduleEO> GetByRlId(string rlId, TransactionManager tm)
		{
			return GetByRlId(rlId, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 RlId（字段） 查询
		/// </summary>
		/// <param name = "rlId"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolemoduleEO> GetByRlId(string rlId, int top)
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
		public virtual IEnumerable<RolemoduleEO> GetByRlId(string rlId, int top, TransactionManager tm)
		{
			return GetByRlId(rlId, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 RlId（字段） 查询
		/// </summary>
		/// <param name = "rlId"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolemoduleEO> GetByRlId(string rlId, string sort)
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
		public virtual IEnumerable<RolemoduleEO> GetByRlId(string rlId, string sort, TransactionManager tm)
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
		public virtual IEnumerable<RolemoduleEO> GetByRlId(string rlId, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Rl_id, Md_id, Pt_id, Rm_addTime, Rm_text1, Rm_text2 FROM rolemodule WHERE Rl_id=@RlId";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@RlId", rlId, DbType.String, 150)
							.ExecList<RolemoduleEO>(RolemoduleEO.GetItem, tm);
		}

		#endregion

		#region  按 MdId（字段） 查询

		/// <summary>
		/// 按 MdId（字段） 查询
		/// </summary>
		/// <param name = "mdId"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolemoduleEO> GetByMdId(string mdId)
		{
			return GetByMdId(mdId, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 MdId（字段） 查询
		/// </summary>
		/// <param name = "mdId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolemoduleEO> GetByMdId(string mdId, TransactionManager tm)
		{
			return GetByMdId(mdId, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 MdId（字段） 查询
		/// </summary>
		/// <param name = "mdId"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolemoduleEO> GetByMdId(string mdId, int top)
		{
			return GetByMdId(mdId, top, string.Empty, null);
		}

		/// <summary>
		/// 按 MdId（字段） 查询
		/// </summary>
		/// <param name = "mdId"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolemoduleEO> GetByMdId(string mdId, int top, TransactionManager tm)
		{
			return GetByMdId(mdId, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 MdId（字段） 查询
		/// </summary>
		/// <param name = "mdId"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolemoduleEO> GetByMdId(string mdId, string sort)
		{
			return GetByMdId(mdId, 0, sort, null);
		}

		/// <summary>
		/// 按 MdId（字段） 查询
		/// </summary>
		/// <param name = "mdId"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolemoduleEO> GetByMdId(string mdId, string sort, TransactionManager tm)
		{
			return GetByMdId(mdId, 0, sort, tm);
		}

		/// <summary>
		/// 按 MdId（字段） 查询
		/// </summary>
		/// <param name = "mdId"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolemoduleEO> GetByMdId(string mdId, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Rl_id, Md_id, Pt_id, Rm_addTime, Rm_text1, Rm_text2 FROM rolemodule WHERE Md_id=@MdId";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@MdId", mdId, DbType.String, 150)
							.ExecList<RolemoduleEO>(RolemoduleEO.GetItem, tm);
		}

		#endregion

		#region  按 PtId（字段） 查询

		/// <summary>
		/// 按 PtId（字段） 查询
		/// </summary>
		/// <param name = "ptId"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolemoduleEO> GetByPtId(string ptId)
		{
			return GetByPtId(ptId, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 PtId（字段） 查询
		/// </summary>
		/// <param name = "ptId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolemoduleEO> GetByPtId(string ptId, TransactionManager tm)
		{
			return GetByPtId(ptId, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 PtId（字段） 查询
		/// </summary>
		/// <param name = "ptId"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolemoduleEO> GetByPtId(string ptId, int top)
		{
			return GetByPtId(ptId, top, string.Empty, null);
		}

		/// <summary>
		/// 按 PtId（字段） 查询
		/// </summary>
		/// <param name = "ptId"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolemoduleEO> GetByPtId(string ptId, int top, TransactionManager tm)
		{
			return GetByPtId(ptId, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 PtId（字段） 查询
		/// </summary>
		/// <param name = "ptId"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolemoduleEO> GetByPtId(string ptId, string sort)
		{
			return GetByPtId(ptId, 0, sort, null);
		}

		/// <summary>
		/// 按 PtId（字段） 查询
		/// </summary>
		/// <param name = "ptId"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolemoduleEO> GetByPtId(string ptId, string sort, TransactionManager tm)
		{
			return GetByPtId(ptId, 0, sort, tm);
		}

		/// <summary>
		/// 按 PtId（字段） 查询
		/// </summary>
		/// <param name = "ptId"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolemoduleEO> GetByPtId(string ptId, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Rl_id, Md_id, Pt_id, Rm_addTime, Rm_text1, Rm_text2 FROM rolemodule WHERE Pt_id=@PtId";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@PtId", ptId, DbType.String, 150)
							.ExecList<RolemoduleEO>(RolemoduleEO.GetItem, tm);
		}

		#endregion

		#region  按 RmAddTime（字段） 查询

		/// <summary>
		/// 按 RmAddTime（字段） 查询
		/// </summary>
		/// <param name = "rmAddTime"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolemoduleEO> GetByRmAddTime(DateTime rmAddTime)
		{
			return GetByRmAddTime(rmAddTime, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 RmAddTime（字段） 查询
		/// </summary>
		/// <param name = "rmAddTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolemoduleEO> GetByRmAddTime(DateTime rmAddTime, TransactionManager tm)
		{
			return GetByRmAddTime(rmAddTime, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 RmAddTime（字段） 查询
		/// </summary>
		/// <param name = "rmAddTime"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolemoduleEO> GetByRmAddTime(DateTime rmAddTime, int top)
		{
			return GetByRmAddTime(rmAddTime, top, string.Empty, null);
		}

		/// <summary>
		/// 按 RmAddTime（字段） 查询
		/// </summary>
		/// <param name = "rmAddTime"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolemoduleEO> GetByRmAddTime(DateTime rmAddTime, int top, TransactionManager tm)
		{
			return GetByRmAddTime(rmAddTime, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 RmAddTime（字段） 查询
		/// </summary>
		/// <param name = "rmAddTime"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolemoduleEO> GetByRmAddTime(DateTime rmAddTime, string sort)
		{
			return GetByRmAddTime(rmAddTime, 0, sort, null);
		}

		/// <summary>
		/// 按 RmAddTime（字段） 查询
		/// </summary>
		/// <param name = "rmAddTime"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolemoduleEO> GetByRmAddTime(DateTime rmAddTime, string sort, TransactionManager tm)
		{
			return GetByRmAddTime(rmAddTime, 0, sort, tm);
		}

		/// <summary>
		/// 按 RmAddTime（字段） 查询
		/// </summary>
		/// <param name = "rmAddTime"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolemoduleEO> GetByRmAddTime(DateTime rmAddTime, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Rl_id, Md_id, Pt_id, Rm_addTime, Rm_text1, Rm_text2 FROM rolemodule WHERE Rm_addTime=@RmAddTime";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@RmAddTime", rmAddTime, DbType.DateTime, 0)
							.ExecList<RolemoduleEO>(RolemoduleEO.GetItem, tm);
		}

		#endregion

		#region  按 RmText1（字段） 查询

		/// <summary>
		/// 按 RmText1（字段） 查询
		/// </summary>
		/// <param name = "rmText1"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolemoduleEO> GetByRmText1(string rmText1)
		{
			return GetByRmText1(rmText1, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 RmText1（字段） 查询
		/// </summary>
		/// <param name = "rmText1"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolemoduleEO> GetByRmText1(string rmText1, TransactionManager tm)
		{
			return GetByRmText1(rmText1, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 RmText1（字段） 查询
		/// </summary>
		/// <param name = "rmText1"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolemoduleEO> GetByRmText1(string rmText1, int top)
		{
			return GetByRmText1(rmText1, top, string.Empty, null);
		}

		/// <summary>
		/// 按 RmText1（字段） 查询
		/// </summary>
		/// <param name = "rmText1"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolemoduleEO> GetByRmText1(string rmText1, int top, TransactionManager tm)
		{
			return GetByRmText1(rmText1, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 RmText1（字段） 查询
		/// </summary>
		/// <param name = "rmText1"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolemoduleEO> GetByRmText1(string rmText1, string sort)
		{
			return GetByRmText1(rmText1, 0, sort, null);
		}

		/// <summary>
		/// 按 RmText1（字段） 查询
		/// </summary>
		/// <param name = "rmText1"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolemoduleEO> GetByRmText1(string rmText1, string sort, TransactionManager tm)
		{
			return GetByRmText1(rmText1, 0, sort, tm);
		}

		/// <summary>
		/// 按 RmText1（字段） 查询
		/// </summary>
		/// <param name = "rmText1"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolemoduleEO> GetByRmText1(string rmText1, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Rl_id, Md_id, Pt_id, Rm_addTime, Rm_text1, Rm_text2 FROM rolemodule WHERE Rm_text1=@RmText1";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@RmText1", rmText1, DbType.String, 600)
							.ExecList<RolemoduleEO>(RolemoduleEO.GetItem, tm);
		}

		#endregion

		#region  按 RmText2（字段） 查询

		/// <summary>
		/// 按 RmText2（字段） 查询
		/// </summary>
		/// <param name = "rmText2"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolemoduleEO> GetByRmText2(string rmText2)
		{
			return GetByRmText2(rmText2, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 RmText2（字段） 查询
		/// </summary>
		/// <param name = "rmText2"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolemoduleEO> GetByRmText2(string rmText2, TransactionManager tm)
		{
			return GetByRmText2(rmText2, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 RmText2（字段） 查询
		/// </summary>
		/// <param name = "rmText2"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolemoduleEO> GetByRmText2(string rmText2, int top)
		{
			return GetByRmText2(rmText2, top, string.Empty, null);
		}

		/// <summary>
		/// 按 RmText2（字段） 查询
		/// </summary>
		/// <param name = "rmText2"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolemoduleEO> GetByRmText2(string rmText2, int top, TransactionManager tm)
		{
			return GetByRmText2(rmText2, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 RmText2（字段） 查询
		/// </summary>
		/// <param name = "rmText2"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolemoduleEO> GetByRmText2(string rmText2, string sort)
		{
			return GetByRmText2(rmText2, 0, sort, null);
		}

		/// <summary>
		/// 按 RmText2（字段） 查询
		/// </summary>
		/// <param name = "rmText2"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolemoduleEO> GetByRmText2(string rmText2, string sort, TransactionManager tm)
		{
			return GetByRmText2(rmText2, 0, sort, tm);
		}

		/// <summary>
		/// 按 RmText2（字段） 查询
		/// </summary>
		/// <param name = "rmText2"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolemoduleEO> GetByRmText2(string rmText2, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Rl_id, Md_id, Pt_id, Rm_addTime, Rm_text1, Rm_text2 FROM rolemodule WHERE Rm_text2=@RmText2";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@RmText2", rmText2, DbType.String, 600)
							.ExecList<RolemoduleEO>(RolemoduleEO.GetItem, tm);
		}

		#endregion

		#region  自定义条件查询

		/// <summary>
		/// 获取所有数据
		/// </summary>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolemoduleEO> GetAll(TransactionManager tm = null)
		{
			return GetTopSort(string.Empty, null, -1, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "values">where子句中定义的参数值集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolemoduleEO> Get(string where, params object[] values)
		{
			return GetTopSort(where, -1, string.Empty, null, values);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "paras">where子句中定义的参数集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolemoduleEO> Get(string where, IEnumerable<DbParameter> paras)
		{
			return GetTopSort(where, paras, -1, string.Empty, null);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolemoduleEO> Get(string where, TransactionManager tm)
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
		public virtual IEnumerable<RolemoduleEO> Get(string where, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<RolemoduleEO> Get(string where, IEnumerable<DbParameter> paras, TransactionManager tm)
		{
			return GetTopSort(where, paras, -1, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolemoduleEO> GetTop(string where, int top)
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
		public virtual IEnumerable<RolemoduleEO> GetTop(string where, int top, params object[] values)
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
		public virtual IEnumerable<RolemoduleEO> GetTop(string where, IEnumerable<DbParameter> paras, int top)
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
		public virtual IEnumerable<RolemoduleEO> GetTop(string where, int top, TransactionManager tm)
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
		public virtual IEnumerable<RolemoduleEO> GetTop(string where, int top, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<RolemoduleEO> GetTop(string where, IEnumerable<DbParameter> paras, int top, TransactionManager tm)
		{
			return GetTopSort(where, paras, top, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<RolemoduleEO> GetSort(string where, string sort)
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
		public virtual IEnumerable<RolemoduleEO> GetSort(string where, string sort, params object[] values)
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
		public virtual IEnumerable<RolemoduleEO> GetSort(string where, IEnumerable<DbParameter> paras, string sort)
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
		public virtual IEnumerable<RolemoduleEO> GetSort(string where, string sort, TransactionManager tm)
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
		public virtual IEnumerable<RolemoduleEO> GetSort(string where, string sort, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<RolemoduleEO> GetSort(string where, IEnumerable<DbParameter> paras, string sort, TransactionManager tm)
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
		public virtual IEnumerable<RolemoduleEO> GetTopSort(string where, int top, string sort)
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
		public virtual IEnumerable<RolemoduleEO> GetTopSort(string where, int top, string sort, params object[] values)
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
		public virtual IEnumerable<RolemoduleEO> GetTopSort(string where, IEnumerable<DbParameter> paras, int top, string sort)
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
		public virtual IEnumerable<RolemoduleEO> GetTopSort(string where, int top, string sort, TransactionManager tm)
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
		public virtual IEnumerable<RolemoduleEO> GetTopSort(string where, int top, string sort, TransactionManager tm, params object[] values)
		{
			const string format = @"SELECT {0} Rl_id, Md_id, Pt_id, Rm_addTime, Rm_text1, Rm_text2 FROM rolemodule";
			string sql = format;

			if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameters(values)
							.ExecList<RolemoduleEO>(RolemoduleEO.GetItem, tm);
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
		public virtual IEnumerable<RolemoduleEO> GetTopSort(string where, IEnumerable<DbParameter> paras, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Rl_id, Md_id, Pt_id, Rm_addTime, Rm_text1, Rm_text2 FROM rolemodule";
			string sql = format;

			if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddParameters(paras)
							.ExecList<RolemoduleEO>(RolemoduleEO.GetItem, tm);
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
			const string format = @"SELECT Rl_id, Md_id, Pt_id, Rm_addTime, Rm_text1, Rm_text2 FROM rolemodule {0} {1}";
			 string sql = string.Format(format, string.IsNullOrEmpty(where) ? string.Empty : "WHERE " + where, string.IsNullOrEmpty(sort) ? string.Empty : "ORDER BY " + sort);

			return Database.CreatePager(sql, pageSize, "Rl_id,Md_id,Pt_id");
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
		public virtual List<RolemoduleEO> GetPageList(int pageIndex , int pageSize, string where = null, string sort = null, IEnumerable<DbParameter> paras = null)
		{
			var pager = GetPager(pageSize, where, sort);

			pager.AddParameters(paras);
			return pager.GetPageList<RolemoduleEO>(pageIndex);
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
		public virtual IEnumerable<RolemoduleEO> GetPageMutil(int pageIndex , int pageSize, string where = null, string sort = null, IEnumerable<DbParameter> paras = null)
		{
			var pager = GetPager(pageSize, where, sort);

			pager.AddParameters(paras);
			return pager.GetPageMutil<RolemoduleEO>(pageIndex);
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
		public virtual int Add(RolemoduleEO item, TransactionManager tm = null)
		{
			const string sql = @"INSERT INTO rolemodule (Rl_id, Md_id, Pt_id, Rm_addTime, Rm_text1, Rm_text2) VALUES (@Rl_id, @Md_id, @Pt_id, @Rm_addTime, @Rm_text1, @Rm_text2) ";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Rl_id", item.RlId, DbType.String, 150)
							.AddInParameter("@Md_id", item.MdId, DbType.String, 150)
							.AddInParameter("@Pt_id", item.PtId, DbType.String, 150)
							.AddInParameter("@Rm_addTime", item.RmAddTime, DbType.DateTime, 0)
							.AddInParameter("@Rm_text1", item.RmText1 != null ?  (object)item.RmText1 : DBNull.Value, DbType.String, 600)
							.AddInParameter("@Rm_text2", item.RmText2 != null ?  (object)item.RmText2 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 插入一组数据
		/// </summary>
		/// <param name = "items">要插入的实体对象集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Add(IEnumerable<RolemoduleEO> items, TransactionManager tm = null)
		{
			int ret = 0;
			const string sql = @"INSERT INTO rolemodule (Rl_id, Md_id, Pt_id, Rm_addTime, Rm_text1, Rm_text2) VALUES (@Rl_id, @Md_id, @Pt_id, @Rm_addTime, @Rm_text1, @Rm_text2) ";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@Rl_id", DbType.String, 150)
									.AddParameter("@Md_id", DbType.String, 150)
									.AddParameter("@Pt_id", DbType.String, 150)
									.AddParameter("@Rm_addTime", DbType.DateTime, 0)
									.AddParameter("@Rm_text1", DbType.String, 600)
									.AddParameter("@Rm_text2", DbType.String, 600);

			foreach (RolemoduleEO item in items)
			{
				sqlDao
					.SetParameterValue("@Rl_id", item.RlId)
					.SetParameterValue("@Md_id", item.MdId)
					.SetParameterValue("@Pt_id", item.PtId)
					.SetParameterValue("@Rm_addTime", item.RmAddTime)
					.SetParameterValue("@Rm_text1", item.RmText1 != null ?  (object)item.RmText1 : DBNull.Value)
					.SetParameterValue("@Rm_text2", item.RmText2 != null ?  (object)item.RmText2 : DBNull.Value)
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
		public virtual int Put(RolemoduleEO item, TransactionManager tm = null)
		{
			const string sql = @"UPDATE rolemodule SET Rl_id=@Rl_id, Md_id=@Md_id, Pt_id=@Pt_id, Rm_addTime=@Rm_addTime, Rm_text1=@Rm_text1, Rm_text2=@Rm_text2 WHERE Rl_id=@OriginalRl_id and Md_id=@OriginalMd_id and Pt_id=@OriginalPt_id";
			return Database.CreateSqlDao (sql)
							.AddInParameter("@OriginalRlId", (item.HasOriginal) ? item.OriginalRlId : item.RlId, DbType.String, 150)
							.AddInParameter("@OriginalMdId", (item.HasOriginal) ? item.OriginalMdId : item.MdId, DbType.String, 150)
							.AddInParameter("@OriginalPtId", (item.HasOriginal) ? item.OriginalPtId : item.PtId, DbType.String, 150)
							.AddInParameter("@Rl_id", item.RlId, DbType.String, 150)
							.AddInParameter("@Md_id", item.MdId, DbType.String, 150)
							.AddInParameter("@Pt_id", item.PtId, DbType.String, 150)
							.AddInParameter("@Rm_addTime", item.RmAddTime, DbType.DateTime, 0)
							.AddInParameter("@Rm_text1", item.RmText1 != null ?  (object)item.RmText1 : DBNull.Value, DbType.String, 600)
							.AddInParameter("@Rm_text2", item.RmText2 != null ?  (object)item.RmText2 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}


		/// <summary>
		/// 更新数据
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Put(IEnumerable<RolemoduleEO> items, TransactionManager tm = null)
		{

			int ret = 0;
			const string sql = @"UPDATE rolemodule SET Rl_id=@Rl_id, Md_id=@Md_id, Pt_id=@Pt_id, Rm_addTime=@Rm_addTime, Rm_text1=@Rm_text1, Rm_text2=@Rm_text2 WHERE Rl_id=@OriginalRl_id and Md_id=@OriginalMd_id and Pt_id=@OriginalPt_id";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@OriginalRlId", DbType.String, 150)
									.AddParameter("@OriginalMdId", DbType.String, 150)
									.AddParameter("@OriginalPtId", DbType.String, 150)
									.AddParameter("@Rl_id", DbType.String, 150)
									.AddParameter("@Md_id", DbType.String, 150)
									.AddParameter("@Pt_id", DbType.String, 150)
									.AddParameter("@Rm_addTime", DbType.DateTime, 0)
									.AddParameter("@Rm_text1", DbType.String, 600)
									.AddParameter("@Rm_text2", DbType.String, 600);

			foreach (RolemoduleEO item in items)
			{
				ret += sqlDao
							.SetParameterValue("@OriginalRlId", (item.HasOriginal) ? item.OriginalRlId : item.RlId)
							.SetParameterValue("@OriginalMdId", (item.HasOriginal) ? item.OriginalMdId : item.MdId)
							.SetParameterValue("@OriginalPtId", (item.HasOriginal) ? item.OriginalPtId : item.PtId)
							.SetParameterValue("@Rl_id", item.RlId)
							.SetParameterValue("@Md_id", item.MdId)
							.SetParameterValue("@Pt_id", item.PtId)
							.SetParameterValue("@Rm_addTime", item.RmAddTime)
							.SetParameterValue("@Rm_text1", item.RmText1 != null ?  (object)item.RmText1 : DBNull.Value)
							.SetParameterValue("@Rm_text2", item.RmText2 != null ?  (object)item.RmText2 : DBNull.Value)
							.ExecNonQuery(tm);
			}
			return ret;
		}


		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "rlId"></param>
		/// <param name = "mdId"></param>
		/// <param name = "ptId"></param>
		/// <param name = "rmAddTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutRmAddTimeByPK(string rlId, string mdId, string ptId, DateTime rmAddTime, TransactionManager tm = null)
		{
			const string sql = @"UPDATE rolemodule SET Rm_addTime = @Rm_addTime  WHERE Rl_id = @Rl_id and Md_id = @Md_id and Pt_id = @Pt_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Rl_id", rlId, DbType.String, 150)
							.AddInParameter("@Md_id", mdId, DbType.String, 150)
							.AddInParameter("@Pt_id", ptId, DbType.String, 150)
							.AddInParameter("@Rm_addTime", rmAddTime, DbType.DateTime, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "rlId"></param>
		/// <param name = "mdId"></param>
		/// <param name = "ptId"></param>
		/// <param name = "rmText1"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutRmText1ByPK(string rlId, string mdId, string ptId, string rmText1, TransactionManager tm = null)
		{
			const string sql = @"UPDATE rolemodule SET Rm_text1 = @Rm_text1  WHERE Rl_id = @Rl_id and Md_id = @Md_id and Pt_id = @Pt_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Rl_id", rlId, DbType.String, 150)
							.AddInParameter("@Md_id", mdId, DbType.String, 150)
							.AddInParameter("@Pt_id", ptId, DbType.String, 150)
							.AddInParameter("@Rm_text1", rmText1 != null ?  (object)rmText1 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "rlId"></param>
		/// <param name = "mdId"></param>
		/// <param name = "ptId"></param>
		/// <param name = "rmText2"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutRmText2ByPK(string rlId, string mdId, string ptId, string rmText2, TransactionManager tm = null)
		{
			const string sql = @"UPDATE rolemodule SET Rm_text2 = @Rm_text2  WHERE Rl_id = @Rl_id and Md_id = @Md_id and Pt_id = @Pt_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Rl_id", rlId, DbType.String, 150)
							.AddInParameter("@Md_id", mdId, DbType.String, 150)
							.AddInParameter("@Pt_id", ptId, DbType.String, 150)
							.AddInParameter("@Rm_text2", rmText2 != null ?  (object)rmText2 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}


		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "rmAddTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutRmAddTime(DateTime rmAddTime, TransactionManager tm = null)
		{
			const string sql = @"UPDATE rolemodule SET Rm_addTime=@Rm_addTime";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Rm_addTime", rmAddTime, DbType.DateTime, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "rmText1"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutRmText1(string rmText1, TransactionManager tm = null)
		{
			const string sql = @"UPDATE rolemodule SET Rm_text1=@Rm_text1";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Rm_text1", rmText1 != null ?  (object)rmText1 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "rmText2"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutRmText2(string rmText2, TransactionManager tm = null)
		{
			const string sql = @"UPDATE rolemodule SET Rm_text2=@Rm_text2";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Rm_text2", rmText2 != null ?  (object)rmText2 : DBNull.Value, DbType.String, 600)
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
			const string format = @"UPDATE rolemodule SET {0} {1}";
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
			const string format = @"UPDATE rolemodule SET {0} {1}";
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
		/// <param name = "mdId"></param>
		/// <param name = "ptId"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByPK(string rlId, string mdId, string ptId, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM rolemodule WHERE Rl_id=@Rl_id and Md_id=@Md_id and Pt_id=@Pt_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Rl_id", rlId, DbType.String, 150)
							.AddInParameter("@Md_id", mdId, DbType.String, 150)
							.AddInParameter("@Pt_id", ptId, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Remove(RolemoduleEO item, TransactionManager tm = null)
		{
			return RemoveByPK(item.RlId, item.MdId, item.PtId, tm);
		}

		/// <summary>
		/// 删除指定实体集合对应的记录集
		/// </summary>
		/// <param name = "items">要删除的实体集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Remove(IEnumerable<RolemoduleEO> items, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM rolemodule WHERE Rl_id=@OriginalRl_id and Md_id=@OriginalMd_id and Pt_id=@OriginalPt_id";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@OriginalRlId", DbType.String, 150)
									.AddParameter("@OriginalMdId", DbType.String, 150)
									.AddParameter("@OriginalPtId", DbType.String, 150);
			int ret = 0;
			foreach (RolemoduleEO item in items)
			{
				ret += sqlDao
							.SetParameterValue("@OriginalRlId", (item.HasOriginal) ? item.OriginalRlId : item.RlId)
							.SetParameterValue("@OriginalMdId", (item.HasOriginal) ? item.OriginalMdId : item.MdId)
							.SetParameterValue("@OriginalPtId", (item.HasOriginal) ? item.OriginalPtId : item.PtId)
							.ExecNonQuery(tm);
			}
			return ret;
		}




		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "rmAddTime"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByRmAddTime(DateTime rmAddTime, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM rolemodule WHERE Rm_addTime=@Rm_addTime";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Rm_addTime", rmAddTime, DbType.DateTime, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "rmText1"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByRmText1(string rmText1, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM rolemodule WHERE Rm_text1=@Rm_text1";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Rm_text1", rmText1 != null ?  (object)rmText1 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "rmText2"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByRmText2(string rmText2, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM rolemodule WHERE Rm_text2=@Rm_text2";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Rm_text2", rmText2 != null ?  (object)rmText2 : DBNull.Value, DbType.String, 600)
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
			const string format = @"DELETE FROM rolemodule {0}";
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
			const string format = @"DELETE FROM rolemodule {0}";
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
