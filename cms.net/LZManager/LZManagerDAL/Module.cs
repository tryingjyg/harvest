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
	/// 【表 module 的实体类】
	/// </summary>
	[SerializableAttribute]
	public class ModuleEO : DataEntityBase, IRowMapper<ModuleEO>
	{
		protected string _originalMdId;

		/// <summary>
		/// 主键是否有原始值（即数据库中保存的值），用于实体对象更新时
		/// </summary>
		public bool HasOriginal { get; protected set; }

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
		/// 【字段 varchar】
		/// </summary>
		public virtual string MdName { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string MdParentid { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string MdAddress { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string PfId { get; set; }

		/// <summary>
		/// 【字段 char】
		/// </summary>
		public virtual string MdUseFlag { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string MdNotes { get; set; }

		/// <summary>
		/// 【字段 char】
		/// </summary>
		public virtual string MdDeleteFlag { get; set; }

		/// <summary>
		/// 【字段 datetime】
		/// </summary>
		public virtual DateTime MdAddTime { get; set; }

		/// <summary>
		/// 【字段 char】
		/// </summary>
		public virtual string MdExistsTreeView { get; set; }

		/// <summary>
		/// 【字段 int】
		/// </summary>
		public virtual int? MdFiledOrder { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string MdImgUrl { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string MdText1 { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string MdText2 { get; set; }

		/// <summary>
		/// 默认构造函数
		/// </summary>
		public ModuleEO() 
		{
			MdId = string.Empty;
		}

		/// <summary>
		/// 自定义构造函数
		/// </summary>
		/// <param name = "mdId"></param>
		/// <param name = "mdName"></param>
		/// <param name = "mdParentid"></param>
		/// <param name = "mdAddress"></param>
		/// <param name = "pfId"></param>
		/// <param name = "mdUseFlag"></param>
		/// <param name = "mdNotes"></param>
		/// <param name = "mdDeleteFlag"></param>
		/// <param name = "mdAddTime"></param>
		/// <param name = "mdExistsTreeView"></param>
		/// <param name = "mdFiledOrder"></param>
		/// <param name = "mdImgUrl"></param>
		/// <param name = "mdText1"></param>
		/// <param name = "mdText2"></param>
		public ModuleEO(string mdId, string mdName, string mdParentid, string mdAddress, string pfId, string mdUseFlag, string mdNotes, string mdDeleteFlag, DateTime mdAddTime, string mdExistsTreeView, int? mdFiledOrder, string mdImgUrl, string mdText1, string mdText2) 
		{
			MdId = mdId;
			MdName = mdName;
			MdParentid = mdParentid;
			MdAddress = mdAddress;
			PfId = pfId;
			MdUseFlag = mdUseFlag;
			MdNotes = mdNotes;
			MdDeleteFlag = mdDeleteFlag;
			MdAddTime = mdAddTime;
			MdExistsTreeView = mdExistsTreeView;
			MdFiledOrder = mdFiledOrder;
			MdImgUrl = mdImgUrl;
			MdText1 = mdText1;
			MdText2 = mdText2;
		}

		/// <summary>
		/// 将结果集映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public ModuleEO MapRow(IDataReader reader)
		{
			return GetItem(reader);
		}

		/// <summary>
		/// 将结果集映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static ModuleEO GetItem(IDataReader reader)
		{
			ModuleEO ret = new ModuleEO();

			ret.MdId = (string)reader["Md_id"];
			ret.OriginalMdId = ret.MdId;
			ret.MdName = (reader["Md_name"] is DBNull) ? null : (string)reader["Md_name"];
			ret.MdParentid = (reader["Md_parentid"] is DBNull) ? null : (string)reader["Md_parentid"];
			ret.MdAddress = (reader["Md_address"] is DBNull) ? null : (string)reader["Md_address"];
			ret.PfId = (reader["Pf_id"] is DBNull) ? null : (string)reader["Pf_id"];
			ret.MdUseFlag = (reader["Md_useFlag"] is DBNull) ? null : (string)reader["Md_useFlag"];
			ret.MdNotes = (reader["Md_notes"] is DBNull) ? null : (string)reader["Md_notes"];
			ret.MdDeleteFlag = (reader["Md_deleteFlag"] is DBNull) ? null : (string)reader["Md_deleteFlag"];
			ret.MdAddTime = DateTime.Parse(reader["Md_addTime"].ToString());
			ret.MdExistsTreeView = (reader["Md_existsTreeView"] is DBNull) ? null : (string)reader["Md_existsTreeView"];
			ret.MdFiledOrder = (reader["Md_filedOrder"] is DBNull) ? (int?)null : int.Parse(reader["Md_filedOrder"].ToString());
			ret.MdImgUrl = (reader["Md_imgUrl"] is DBNull) ? null : (string)reader["Md_imgUrl"];
			ret.MdText1 = (reader["Md_text1"] is DBNull) ? null : (string)reader["Md_text1"];
			ret.MdText2 = (reader["Md_text2"] is DBNull) ? null : (string)reader["Md_text2"];
			return ret;
		}
	}


	#endregion

	#region  MO

	/// <summary>
	/// 【表 module 的操作类】
	/// </summary>
    public partial class ModuleMO : DataManagerBase
	{

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "routeData">路由数据</param>
		public ModuleMO(object routeData = null) : base(routeData) { }

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">连接字符串名称</param>
		public ModuleMO(string connectionStringName) : base(connectionStringName) { }

		#region  Get方法集合

		/// <summary>
		/// 按 PK（主键） 查询
		/// </summary>
		/// <param name="tm">事务管理对象</param>
		/// <param name = "mdId"></param>
		/// <return></return>
		public virtual ModuleEO GetByPK(string mdId, TransactionManager tm = null)
		{
			const string sql = @"SELECT Md_id, Md_name, Md_parentid, Md_address, Pf_id, Md_useFlag, Md_notes, Md_deleteFlag, Md_addTime, Md_existsTreeView, Md_filedOrder, Md_imgUrl, Md_text1, Md_text2 FROM module WHERE Md_id=@Md_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Md_id", mdId, DbType.String, 150)
							.ExecSingle<ModuleEO>(ModuleEO.GetItem, tm);
		}




		#region  按 MdName（字段） 查询

		/// <summary>
		/// 按 MdName（字段） 查询
		/// </summary>
		/// <param name = "mdName"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdName(string mdName)
		{
			return GetByMdName(mdName, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 MdName（字段） 查询
		/// </summary>
		/// <param name = "mdName"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdName(string mdName, TransactionManager tm)
		{
			return GetByMdName(mdName, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 MdName（字段） 查询
		/// </summary>
		/// <param name = "mdName"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdName(string mdName, int top)
		{
			return GetByMdName(mdName, top, string.Empty, null);
		}

		/// <summary>
		/// 按 MdName（字段） 查询
		/// </summary>
		/// <param name = "mdName"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdName(string mdName, int top, TransactionManager tm)
		{
			return GetByMdName(mdName, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 MdName（字段） 查询
		/// </summary>
		/// <param name = "mdName"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdName(string mdName, string sort)
		{
			return GetByMdName(mdName, 0, sort, null);
		}

		/// <summary>
		/// 按 MdName（字段） 查询
		/// </summary>
		/// <param name = "mdName"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdName(string mdName, string sort, TransactionManager tm)
		{
			return GetByMdName(mdName, 0, sort, tm);
		}

		/// <summary>
		/// 按 MdName（字段） 查询
		/// </summary>
		/// <param name = "mdName"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdName(string mdName, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Md_id, Md_name, Md_parentid, Md_address, Pf_id, Md_useFlag, Md_notes, Md_deleteFlag, Md_addTime, Md_existsTreeView, Md_filedOrder, Md_imgUrl, Md_text1, Md_text2 FROM module WHERE Md_name=@MdName";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@MdName", mdName, DbType.String, 300)
							.ExecList<ModuleEO>(ModuleEO.GetItem, tm);
		}

		#endregion

		#region  按 MdParentid（字段） 查询

		/// <summary>
		/// 按 MdParentid（字段） 查询
		/// </summary>
		/// <param name = "mdParentid"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdParentid(string mdParentid)
		{
			return GetByMdParentid(mdParentid, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 MdParentid（字段） 查询
		/// </summary>
		/// <param name = "mdParentid"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdParentid(string mdParentid, TransactionManager tm)
		{
			return GetByMdParentid(mdParentid, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 MdParentid（字段） 查询
		/// </summary>
		/// <param name = "mdParentid"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdParentid(string mdParentid, int top)
		{
			return GetByMdParentid(mdParentid, top, string.Empty, null);
		}

		/// <summary>
		/// 按 MdParentid（字段） 查询
		/// </summary>
		/// <param name = "mdParentid"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdParentid(string mdParentid, int top, TransactionManager tm)
		{
			return GetByMdParentid(mdParentid, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 MdParentid（字段） 查询
		/// </summary>
		/// <param name = "mdParentid"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdParentid(string mdParentid, string sort)
		{
			return GetByMdParentid(mdParentid, 0, sort, null);
		}

		/// <summary>
		/// 按 MdParentid（字段） 查询
		/// </summary>
		/// <param name = "mdParentid"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdParentid(string mdParentid, string sort, TransactionManager tm)
		{
			return GetByMdParentid(mdParentid, 0, sort, tm);
		}

		/// <summary>
		/// 按 MdParentid（字段） 查询
		/// </summary>
		/// <param name = "mdParentid"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdParentid(string mdParentid, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Md_id, Md_name, Md_parentid, Md_address, Pf_id, Md_useFlag, Md_notes, Md_deleteFlag, Md_addTime, Md_existsTreeView, Md_filedOrder, Md_imgUrl, Md_text1, Md_text2 FROM module WHERE Md_parentid=@MdParentid";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@MdParentid", mdParentid, DbType.String, 150)
							.ExecList<ModuleEO>(ModuleEO.GetItem, tm);
		}

		#endregion

		#region  按 MdAddress（字段） 查询

		/// <summary>
		/// 按 MdAddress（字段） 查询
		/// </summary>
		/// <param name = "mdAddress"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdAddress(string mdAddress)
		{
			return GetByMdAddress(mdAddress, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 MdAddress（字段） 查询
		/// </summary>
		/// <param name = "mdAddress"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdAddress(string mdAddress, TransactionManager tm)
		{
			return GetByMdAddress(mdAddress, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 MdAddress（字段） 查询
		/// </summary>
		/// <param name = "mdAddress"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdAddress(string mdAddress, int top)
		{
			return GetByMdAddress(mdAddress, top, string.Empty, null);
		}

		/// <summary>
		/// 按 MdAddress（字段） 查询
		/// </summary>
		/// <param name = "mdAddress"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdAddress(string mdAddress, int top, TransactionManager tm)
		{
			return GetByMdAddress(mdAddress, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 MdAddress（字段） 查询
		/// </summary>
		/// <param name = "mdAddress"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdAddress(string mdAddress, string sort)
		{
			return GetByMdAddress(mdAddress, 0, sort, null);
		}

		/// <summary>
		/// 按 MdAddress（字段） 查询
		/// </summary>
		/// <param name = "mdAddress"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdAddress(string mdAddress, string sort, TransactionManager tm)
		{
			return GetByMdAddress(mdAddress, 0, sort, tm);
		}

		/// <summary>
		/// 按 MdAddress（字段） 查询
		/// </summary>
		/// <param name = "mdAddress"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdAddress(string mdAddress, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Md_id, Md_name, Md_parentid, Md_address, Pf_id, Md_useFlag, Md_notes, Md_deleteFlag, Md_addTime, Md_existsTreeView, Md_filedOrder, Md_imgUrl, Md_text1, Md_text2 FROM module WHERE Md_address=@MdAddress";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@MdAddress", mdAddress, DbType.String, 600)
							.ExecList<ModuleEO>(ModuleEO.GetItem, tm);
		}

		#endregion

		#region  按 PfId（字段） 查询

		/// <summary>
		/// 按 PfId（字段） 查询
		/// </summary>
		/// <param name = "pfId"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByPfId(string pfId)
		{
			return GetByPfId(pfId, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 PfId（字段） 查询
		/// </summary>
		/// <param name = "pfId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByPfId(string pfId, TransactionManager tm)
		{
			return GetByPfId(pfId, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 PfId（字段） 查询
		/// </summary>
		/// <param name = "pfId"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByPfId(string pfId, int top)
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
		public virtual IEnumerable<ModuleEO> GetByPfId(string pfId, int top, TransactionManager tm)
		{
			return GetByPfId(pfId, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 PfId（字段） 查询
		/// </summary>
		/// <param name = "pfId"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByPfId(string pfId, string sort)
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
		public virtual IEnumerable<ModuleEO> GetByPfId(string pfId, string sort, TransactionManager tm)
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
		public virtual IEnumerable<ModuleEO> GetByPfId(string pfId, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Md_id, Md_name, Md_parentid, Md_address, Pf_id, Md_useFlag, Md_notes, Md_deleteFlag, Md_addTime, Md_existsTreeView, Md_filedOrder, Md_imgUrl, Md_text1, Md_text2 FROM module WHERE Pf_id=@PfId";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@PfId", pfId, DbType.String, 150)
							.ExecList<ModuleEO>(ModuleEO.GetItem, tm);
		}

		#endregion

		#region  按 MdUseFlag（字段） 查询

		/// <summary>
		/// 按 MdUseFlag（字段） 查询
		/// </summary>
		/// <param name = "mdUseFlag"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdUseFlag(string mdUseFlag)
		{
			return GetByMdUseFlag(mdUseFlag, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 MdUseFlag（字段） 查询
		/// </summary>
		/// <param name = "mdUseFlag"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdUseFlag(string mdUseFlag, TransactionManager tm)
		{
			return GetByMdUseFlag(mdUseFlag, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 MdUseFlag（字段） 查询
		/// </summary>
		/// <param name = "mdUseFlag"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdUseFlag(string mdUseFlag, int top)
		{
			return GetByMdUseFlag(mdUseFlag, top, string.Empty, null);
		}

		/// <summary>
		/// 按 MdUseFlag（字段） 查询
		/// </summary>
		/// <param name = "mdUseFlag"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdUseFlag(string mdUseFlag, int top, TransactionManager tm)
		{
			return GetByMdUseFlag(mdUseFlag, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 MdUseFlag（字段） 查询
		/// </summary>
		/// <param name = "mdUseFlag"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdUseFlag(string mdUseFlag, string sort)
		{
			return GetByMdUseFlag(mdUseFlag, 0, sort, null);
		}

		/// <summary>
		/// 按 MdUseFlag（字段） 查询
		/// </summary>
		/// <param name = "mdUseFlag"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdUseFlag(string mdUseFlag, string sort, TransactionManager tm)
		{
			return GetByMdUseFlag(mdUseFlag, 0, sort, tm);
		}

		/// <summary>
		/// 按 MdUseFlag（字段） 查询
		/// </summary>
		/// <param name = "mdUseFlag"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdUseFlag(string mdUseFlag, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Md_id, Md_name, Md_parentid, Md_address, Pf_id, Md_useFlag, Md_notes, Md_deleteFlag, Md_addTime, Md_existsTreeView, Md_filedOrder, Md_imgUrl, Md_text1, Md_text2 FROM module WHERE Md_useFlag=@MdUseFlag";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@MdUseFlag", mdUseFlag, DbType.String, 3)
							.ExecList<ModuleEO>(ModuleEO.GetItem, tm);
		}

		#endregion

		#region  按 MdNotes（字段） 查询

		/// <summary>
		/// 按 MdNotes（字段） 查询
		/// </summary>
		/// <param name = "mdNotes"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdNotes(string mdNotes)
		{
			return GetByMdNotes(mdNotes, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 MdNotes（字段） 查询
		/// </summary>
		/// <param name = "mdNotes"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdNotes(string mdNotes, TransactionManager tm)
		{
			return GetByMdNotes(mdNotes, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 MdNotes（字段） 查询
		/// </summary>
		/// <param name = "mdNotes"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdNotes(string mdNotes, int top)
		{
			return GetByMdNotes(mdNotes, top, string.Empty, null);
		}

		/// <summary>
		/// 按 MdNotes（字段） 查询
		/// </summary>
		/// <param name = "mdNotes"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdNotes(string mdNotes, int top, TransactionManager tm)
		{
			return GetByMdNotes(mdNotes, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 MdNotes（字段） 查询
		/// </summary>
		/// <param name = "mdNotes"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdNotes(string mdNotes, string sort)
		{
			return GetByMdNotes(mdNotes, 0, sort, null);
		}

		/// <summary>
		/// 按 MdNotes（字段） 查询
		/// </summary>
		/// <param name = "mdNotes"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdNotes(string mdNotes, string sort, TransactionManager tm)
		{
			return GetByMdNotes(mdNotes, 0, sort, tm);
		}

		/// <summary>
		/// 按 MdNotes（字段） 查询
		/// </summary>
		/// <param name = "mdNotes"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdNotes(string mdNotes, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Md_id, Md_name, Md_parentid, Md_address, Pf_id, Md_useFlag, Md_notes, Md_deleteFlag, Md_addTime, Md_existsTreeView, Md_filedOrder, Md_imgUrl, Md_text1, Md_text2 FROM module WHERE Md_notes=@MdNotes";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@MdNotes", mdNotes, DbType.String, 765)
							.ExecList<ModuleEO>(ModuleEO.GetItem, tm);
		}

		#endregion

		#region  按 MdDeleteFlag（字段） 查询

		/// <summary>
		/// 按 MdDeleteFlag（字段） 查询
		/// </summary>
		/// <param name = "mdDeleteFlag"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdDeleteFlag(string mdDeleteFlag)
		{
			return GetByMdDeleteFlag(mdDeleteFlag, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 MdDeleteFlag（字段） 查询
		/// </summary>
		/// <param name = "mdDeleteFlag"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdDeleteFlag(string mdDeleteFlag, TransactionManager tm)
		{
			return GetByMdDeleteFlag(mdDeleteFlag, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 MdDeleteFlag（字段） 查询
		/// </summary>
		/// <param name = "mdDeleteFlag"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdDeleteFlag(string mdDeleteFlag, int top)
		{
			return GetByMdDeleteFlag(mdDeleteFlag, top, string.Empty, null);
		}

		/// <summary>
		/// 按 MdDeleteFlag（字段） 查询
		/// </summary>
		/// <param name = "mdDeleteFlag"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdDeleteFlag(string mdDeleteFlag, int top, TransactionManager tm)
		{
			return GetByMdDeleteFlag(mdDeleteFlag, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 MdDeleteFlag（字段） 查询
		/// </summary>
		/// <param name = "mdDeleteFlag"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdDeleteFlag(string mdDeleteFlag, string sort)
		{
			return GetByMdDeleteFlag(mdDeleteFlag, 0, sort, null);
		}

		/// <summary>
		/// 按 MdDeleteFlag（字段） 查询
		/// </summary>
		/// <param name = "mdDeleteFlag"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdDeleteFlag(string mdDeleteFlag, string sort, TransactionManager tm)
		{
			return GetByMdDeleteFlag(mdDeleteFlag, 0, sort, tm);
		}

		/// <summary>
		/// 按 MdDeleteFlag（字段） 查询
		/// </summary>
		/// <param name = "mdDeleteFlag"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdDeleteFlag(string mdDeleteFlag, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Md_id, Md_name, Md_parentid, Md_address, Pf_id, Md_useFlag, Md_notes, Md_deleteFlag, Md_addTime, Md_existsTreeView, Md_filedOrder, Md_imgUrl, Md_text1, Md_text2 FROM module WHERE Md_deleteFlag=@MdDeleteFlag";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@MdDeleteFlag", mdDeleteFlag, DbType.String, 3)
							.ExecList<ModuleEO>(ModuleEO.GetItem, tm);
		}

		#endregion

		#region  按 MdAddTime（字段） 查询

		/// <summary>
		/// 按 MdAddTime（字段） 查询
		/// </summary>
		/// <param name = "mdAddTime"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdAddTime(DateTime mdAddTime)
		{
			return GetByMdAddTime(mdAddTime, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 MdAddTime（字段） 查询
		/// </summary>
		/// <param name = "mdAddTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdAddTime(DateTime mdAddTime, TransactionManager tm)
		{
			return GetByMdAddTime(mdAddTime, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 MdAddTime（字段） 查询
		/// </summary>
		/// <param name = "mdAddTime"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdAddTime(DateTime mdAddTime, int top)
		{
			return GetByMdAddTime(mdAddTime, top, string.Empty, null);
		}

		/// <summary>
		/// 按 MdAddTime（字段） 查询
		/// </summary>
		/// <param name = "mdAddTime"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdAddTime(DateTime mdAddTime, int top, TransactionManager tm)
		{
			return GetByMdAddTime(mdAddTime, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 MdAddTime（字段） 查询
		/// </summary>
		/// <param name = "mdAddTime"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdAddTime(DateTime mdAddTime, string sort)
		{
			return GetByMdAddTime(mdAddTime, 0, sort, null);
		}

		/// <summary>
		/// 按 MdAddTime（字段） 查询
		/// </summary>
		/// <param name = "mdAddTime"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdAddTime(DateTime mdAddTime, string sort, TransactionManager tm)
		{
			return GetByMdAddTime(mdAddTime, 0, sort, tm);
		}

		/// <summary>
		/// 按 MdAddTime（字段） 查询
		/// </summary>
		/// <param name = "mdAddTime"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdAddTime(DateTime mdAddTime, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Md_id, Md_name, Md_parentid, Md_address, Pf_id, Md_useFlag, Md_notes, Md_deleteFlag, Md_addTime, Md_existsTreeView, Md_filedOrder, Md_imgUrl, Md_text1, Md_text2 FROM module WHERE Md_addTime=@MdAddTime";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@MdAddTime", mdAddTime, DbType.DateTime, 0)
							.ExecList<ModuleEO>(ModuleEO.GetItem, tm);
		}

		#endregion

		#region  按 MdExistsTreeView（字段） 查询

		/// <summary>
		/// 按 MdExistsTreeView（字段） 查询
		/// </summary>
		/// <param name = "mdExistsTreeView"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdExistsTreeView(string mdExistsTreeView)
		{
			return GetByMdExistsTreeView(mdExistsTreeView, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 MdExistsTreeView（字段） 查询
		/// </summary>
		/// <param name = "mdExistsTreeView"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdExistsTreeView(string mdExistsTreeView, TransactionManager tm)
		{
			return GetByMdExistsTreeView(mdExistsTreeView, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 MdExistsTreeView（字段） 查询
		/// </summary>
		/// <param name = "mdExistsTreeView"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdExistsTreeView(string mdExistsTreeView, int top)
		{
			return GetByMdExistsTreeView(mdExistsTreeView, top, string.Empty, null);
		}

		/// <summary>
		/// 按 MdExistsTreeView（字段） 查询
		/// </summary>
		/// <param name = "mdExistsTreeView"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdExistsTreeView(string mdExistsTreeView, int top, TransactionManager tm)
		{
			return GetByMdExistsTreeView(mdExistsTreeView, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 MdExistsTreeView（字段） 查询
		/// </summary>
		/// <param name = "mdExistsTreeView"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdExistsTreeView(string mdExistsTreeView, string sort)
		{
			return GetByMdExistsTreeView(mdExistsTreeView, 0, sort, null);
		}

		/// <summary>
		/// 按 MdExistsTreeView（字段） 查询
		/// </summary>
		/// <param name = "mdExistsTreeView"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdExistsTreeView(string mdExistsTreeView, string sort, TransactionManager tm)
		{
			return GetByMdExistsTreeView(mdExistsTreeView, 0, sort, tm);
		}

		/// <summary>
		/// 按 MdExistsTreeView（字段） 查询
		/// </summary>
		/// <param name = "mdExistsTreeView"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdExistsTreeView(string mdExistsTreeView, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Md_id, Md_name, Md_parentid, Md_address, Pf_id, Md_useFlag, Md_notes, Md_deleteFlag, Md_addTime, Md_existsTreeView, Md_filedOrder, Md_imgUrl, Md_text1, Md_text2 FROM module WHERE Md_existsTreeView=@MdExistsTreeView";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@MdExistsTreeView", mdExistsTreeView, DbType.String, 3)
							.ExecList<ModuleEO>(ModuleEO.GetItem, tm);
		}

		#endregion

		#region  按 MdFiledOrder（字段） 查询

		/// <summary>
		/// 按 MdFiledOrder（字段） 查询
		/// </summary>
		/// <param name = "mdFiledOrder"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdFiledOrder(int? mdFiledOrder)
		{
			return GetByMdFiledOrder(mdFiledOrder, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 MdFiledOrder（字段） 查询
		/// </summary>
		/// <param name = "mdFiledOrder"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdFiledOrder(int? mdFiledOrder, TransactionManager tm)
		{
			return GetByMdFiledOrder(mdFiledOrder, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 MdFiledOrder（字段） 查询
		/// </summary>
		/// <param name = "mdFiledOrder"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdFiledOrder(int? mdFiledOrder, int top)
		{
			return GetByMdFiledOrder(mdFiledOrder, top, string.Empty, null);
		}

		/// <summary>
		/// 按 MdFiledOrder（字段） 查询
		/// </summary>
		/// <param name = "mdFiledOrder"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdFiledOrder(int? mdFiledOrder, int top, TransactionManager tm)
		{
			return GetByMdFiledOrder(mdFiledOrder, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 MdFiledOrder（字段） 查询
		/// </summary>
		/// <param name = "mdFiledOrder"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdFiledOrder(int? mdFiledOrder, string sort)
		{
			return GetByMdFiledOrder(mdFiledOrder, 0, sort, null);
		}

		/// <summary>
		/// 按 MdFiledOrder（字段） 查询
		/// </summary>
		/// <param name = "mdFiledOrder"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdFiledOrder(int? mdFiledOrder, string sort, TransactionManager tm)
		{
			return GetByMdFiledOrder(mdFiledOrder, 0, sort, tm);
		}

		/// <summary>
		/// 按 MdFiledOrder（字段） 查询
		/// </summary>
		/// <param name = "mdFiledOrder"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdFiledOrder(int? mdFiledOrder, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Md_id, Md_name, Md_parentid, Md_address, Pf_id, Md_useFlag, Md_notes, Md_deleteFlag, Md_addTime, Md_existsTreeView, Md_filedOrder, Md_imgUrl, Md_text1, Md_text2 FROM module WHERE Md_filedOrder=@MdFiledOrder";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@MdFiledOrder", mdFiledOrder, DbType.Int32, 0)
							.ExecList<ModuleEO>(ModuleEO.GetItem, tm);
		}

		#endregion

		#region  按 MdImgUrl（字段） 查询

		/// <summary>
		/// 按 MdImgUrl（字段） 查询
		/// </summary>
		/// <param name = "mdImgUrl"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdImgUrl(string mdImgUrl)
		{
			return GetByMdImgUrl(mdImgUrl, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 MdImgUrl（字段） 查询
		/// </summary>
		/// <param name = "mdImgUrl"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdImgUrl(string mdImgUrl, TransactionManager tm)
		{
			return GetByMdImgUrl(mdImgUrl, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 MdImgUrl（字段） 查询
		/// </summary>
		/// <param name = "mdImgUrl"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdImgUrl(string mdImgUrl, int top)
		{
			return GetByMdImgUrl(mdImgUrl, top, string.Empty, null);
		}

		/// <summary>
		/// 按 MdImgUrl（字段） 查询
		/// </summary>
		/// <param name = "mdImgUrl"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdImgUrl(string mdImgUrl, int top, TransactionManager tm)
		{
			return GetByMdImgUrl(mdImgUrl, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 MdImgUrl（字段） 查询
		/// </summary>
		/// <param name = "mdImgUrl"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdImgUrl(string mdImgUrl, string sort)
		{
			return GetByMdImgUrl(mdImgUrl, 0, sort, null);
		}

		/// <summary>
		/// 按 MdImgUrl（字段） 查询
		/// </summary>
		/// <param name = "mdImgUrl"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdImgUrl(string mdImgUrl, string sort, TransactionManager tm)
		{
			return GetByMdImgUrl(mdImgUrl, 0, sort, tm);
		}

		/// <summary>
		/// 按 MdImgUrl（字段） 查询
		/// </summary>
		/// <param name = "mdImgUrl"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdImgUrl(string mdImgUrl, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Md_id, Md_name, Md_parentid, Md_address, Pf_id, Md_useFlag, Md_notes, Md_deleteFlag, Md_addTime, Md_existsTreeView, Md_filedOrder, Md_imgUrl, Md_text1, Md_text2 FROM module WHERE Md_imgUrl=@MdImgUrl";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@MdImgUrl", mdImgUrl, DbType.String, 600)
							.ExecList<ModuleEO>(ModuleEO.GetItem, tm);
		}

		#endregion

		#region  按 MdText1（字段） 查询

		/// <summary>
		/// 按 MdText1（字段） 查询
		/// </summary>
		/// <param name = "mdText1"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdText1(string mdText1)
		{
			return GetByMdText1(mdText1, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 MdText1（字段） 查询
		/// </summary>
		/// <param name = "mdText1"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdText1(string mdText1, TransactionManager tm)
		{
			return GetByMdText1(mdText1, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 MdText1（字段） 查询
		/// </summary>
		/// <param name = "mdText1"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdText1(string mdText1, int top)
		{
			return GetByMdText1(mdText1, top, string.Empty, null);
		}

		/// <summary>
		/// 按 MdText1（字段） 查询
		/// </summary>
		/// <param name = "mdText1"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdText1(string mdText1, int top, TransactionManager tm)
		{
			return GetByMdText1(mdText1, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 MdText1（字段） 查询
		/// </summary>
		/// <param name = "mdText1"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdText1(string mdText1, string sort)
		{
			return GetByMdText1(mdText1, 0, sort, null);
		}

		/// <summary>
		/// 按 MdText1（字段） 查询
		/// </summary>
		/// <param name = "mdText1"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdText1(string mdText1, string sort, TransactionManager tm)
		{
			return GetByMdText1(mdText1, 0, sort, tm);
		}

		/// <summary>
		/// 按 MdText1（字段） 查询
		/// </summary>
		/// <param name = "mdText1"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdText1(string mdText1, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Md_id, Md_name, Md_parentid, Md_address, Pf_id, Md_useFlag, Md_notes, Md_deleteFlag, Md_addTime, Md_existsTreeView, Md_filedOrder, Md_imgUrl, Md_text1, Md_text2 FROM module WHERE Md_text1=@MdText1";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@MdText1", mdText1, DbType.String, 600)
							.ExecList<ModuleEO>(ModuleEO.GetItem, tm);
		}

		#endregion

		#region  按 MdText2（字段） 查询

		/// <summary>
		/// 按 MdText2（字段） 查询
		/// </summary>
		/// <param name = "mdText2"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdText2(string mdText2)
		{
			return GetByMdText2(mdText2, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 MdText2（字段） 查询
		/// </summary>
		/// <param name = "mdText2"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdText2(string mdText2, TransactionManager tm)
		{
			return GetByMdText2(mdText2, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 MdText2（字段） 查询
		/// </summary>
		/// <param name = "mdText2"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdText2(string mdText2, int top)
		{
			return GetByMdText2(mdText2, top, string.Empty, null);
		}

		/// <summary>
		/// 按 MdText2（字段） 查询
		/// </summary>
		/// <param name = "mdText2"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdText2(string mdText2, int top, TransactionManager tm)
		{
			return GetByMdText2(mdText2, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 MdText2（字段） 查询
		/// </summary>
		/// <param name = "mdText2"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdText2(string mdText2, string sort)
		{
			return GetByMdText2(mdText2, 0, sort, null);
		}

		/// <summary>
		/// 按 MdText2（字段） 查询
		/// </summary>
		/// <param name = "mdText2"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdText2(string mdText2, string sort, TransactionManager tm)
		{
			return GetByMdText2(mdText2, 0, sort, tm);
		}

		/// <summary>
		/// 按 MdText2（字段） 查询
		/// </summary>
		/// <param name = "mdText2"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetByMdText2(string mdText2, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Md_id, Md_name, Md_parentid, Md_address, Pf_id, Md_useFlag, Md_notes, Md_deleteFlag, Md_addTime, Md_existsTreeView, Md_filedOrder, Md_imgUrl, Md_text1, Md_text2 FROM module WHERE Md_text2=@MdText2";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@MdText2", mdText2, DbType.String, 600)
							.ExecList<ModuleEO>(ModuleEO.GetItem, tm);
		}

		#endregion

		#region  自定义条件查询

		/// <summary>
		/// 获取所有数据
		/// </summary>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetAll(TransactionManager tm = null)
		{
			return GetTopSort(string.Empty, null, -1, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "values">where子句中定义的参数值集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> Get(string where, params object[] values)
		{
			return GetTopSort(where, -1, string.Empty, null, values);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "paras">where子句中定义的参数集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> Get(string where, IEnumerable<DbParameter> paras)
		{
			return GetTopSort(where, paras, -1, string.Empty, null);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> Get(string where, TransactionManager tm)
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
		public virtual IEnumerable<ModuleEO> Get(string where, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<ModuleEO> Get(string where, IEnumerable<DbParameter> paras, TransactionManager tm)
		{
			return GetTopSort(where, paras, -1, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetTop(string where, int top)
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
		public virtual IEnumerable<ModuleEO> GetTop(string where, int top, params object[] values)
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
		public virtual IEnumerable<ModuleEO> GetTop(string where, IEnumerable<DbParameter> paras, int top)
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
		public virtual IEnumerable<ModuleEO> GetTop(string where, int top, TransactionManager tm)
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
		public virtual IEnumerable<ModuleEO> GetTop(string where, int top, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<ModuleEO> GetTop(string where, IEnumerable<DbParameter> paras, int top, TransactionManager tm)
		{
			return GetTopSort(where, paras, top, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<ModuleEO> GetSort(string where, string sort)
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
		public virtual IEnumerable<ModuleEO> GetSort(string where, string sort, params object[] values)
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
		public virtual IEnumerable<ModuleEO> GetSort(string where, IEnumerable<DbParameter> paras, string sort)
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
		public virtual IEnumerable<ModuleEO> GetSort(string where, string sort, TransactionManager tm)
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
		public virtual IEnumerable<ModuleEO> GetSort(string where, string sort, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<ModuleEO> GetSort(string where, IEnumerable<DbParameter> paras, string sort, TransactionManager tm)
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
		public virtual IEnumerable<ModuleEO> GetTopSort(string where, int top, string sort)
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
		public virtual IEnumerable<ModuleEO> GetTopSort(string where, int top, string sort, params object[] values)
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
		public virtual IEnumerable<ModuleEO> GetTopSort(string where, IEnumerable<DbParameter> paras, int top, string sort)
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
		public virtual IEnumerable<ModuleEO> GetTopSort(string where, int top, string sort, TransactionManager tm)
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
		public virtual IEnumerable<ModuleEO> GetTopSort(string where, int top, string sort, TransactionManager tm, params object[] values)
		{
			const string format = @"SELECT {0} Md_id, Md_name, Md_parentid, Md_address, Pf_id, Md_useFlag, Md_notes, Md_deleteFlag, Md_addTime, Md_existsTreeView, Md_filedOrder, Md_imgUrl, Md_text1, Md_text2 FROM module";
			string sql = format;

			if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameters(values)
							.ExecList<ModuleEO>(ModuleEO.GetItem, tm);
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
		public virtual IEnumerable<ModuleEO> GetTopSort(string where, IEnumerable<DbParameter> paras, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Md_id, Md_name, Md_parentid, Md_address, Pf_id, Md_useFlag, Md_notes, Md_deleteFlag, Md_addTime, Md_existsTreeView, Md_filedOrder, Md_imgUrl, Md_text1, Md_text2 FROM module";
			string sql = format;

			if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddParameters(paras)
							.ExecList<ModuleEO>(ModuleEO.GetItem, tm);
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
			const string format = @"SELECT Md_id, Md_name, Md_parentid, Md_address, Pf_id, Md_useFlag, Md_notes, Md_deleteFlag, Md_addTime, Md_existsTreeView, Md_filedOrder, Md_imgUrl, Md_text1, Md_text2 FROM module {0} {1}";
			 string sql = string.Format(format, string.IsNullOrEmpty(where) ? string.Empty : "WHERE " + where, string.IsNullOrEmpty(sort) ? string.Empty : "ORDER BY " + sort);

			return Database.CreatePager(sql, pageSize, "Md_id");
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
		public virtual List<ModuleEO> GetPageList(int pageIndex , int pageSize, string where = null, string sort = null, IEnumerable<DbParameter> paras = null)
		{
			var pager = GetPager(pageSize, where, sort);

			pager.AddParameters(paras);
			return pager.GetPageList<ModuleEO>(pageIndex);
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
		public virtual IEnumerable<ModuleEO> GetPageMutil(int pageIndex , int pageSize, string where = null, string sort = null, IEnumerable<DbParameter> paras = null)
		{
			var pager = GetPager(pageSize, where, sort);

			pager.AddParameters(paras);
			return pager.GetPageMutil<ModuleEO>(pageIndex);
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
		public virtual int Add(ModuleEO item, TransactionManager tm = null)
		{
			const string sql = @"INSERT INTO module (Md_id, Md_name, Md_parentid, Md_address, Pf_id, Md_useFlag, Md_notes, Md_deleteFlag, Md_addTime, Md_existsTreeView, Md_filedOrder, Md_imgUrl, Md_text1, Md_text2) VALUES (@Md_id, @Md_name, @Md_parentid, @Md_address, @Pf_id, @Md_useFlag, @Md_notes, @Md_deleteFlag, @Md_addTime, @Md_existsTreeView, @Md_filedOrder, @Md_imgUrl, @Md_text1, @Md_text2) ";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Md_id", item.MdId, DbType.String, 150)
							.AddInParameter("@Md_name", item.MdName != null ?  (object)item.MdName : DBNull.Value, DbType.String, 300)
							.AddInParameter("@Md_parentid", item.MdParentid != null ?  (object)item.MdParentid : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Md_address", item.MdAddress != null ?  (object)item.MdAddress : DBNull.Value, DbType.String, 600)
							.AddInParameter("@Pf_id", item.PfId != null ?  (object)item.PfId : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Md_useFlag", item.MdUseFlag != null ?  (object)item.MdUseFlag : DBNull.Value, DbType.String, 3)
							.AddInParameter("@Md_notes", item.MdNotes != null ?  (object)item.MdNotes : DBNull.Value, DbType.String, 765)
							.AddInParameter("@Md_deleteFlag", item.MdDeleteFlag != null ?  (object)item.MdDeleteFlag : DBNull.Value, DbType.String, 3)
							.AddInParameter("@Md_addTime", item.MdAddTime, DbType.DateTime, 0)
							.AddInParameter("@Md_existsTreeView", item.MdExistsTreeView != null ?  (object)item.MdExistsTreeView : DBNull.Value, DbType.String, 3)
							.AddInParameter("@Md_filedOrder", item.MdFiledOrder.HasValue ? (object)item.MdFiledOrder.Value : DBNull.Value, DbType.Int32, 0)
							.AddInParameter("@Md_imgUrl", item.MdImgUrl != null ?  (object)item.MdImgUrl : DBNull.Value, DbType.String, 600)
							.AddInParameter("@Md_text1", item.MdText1 != null ?  (object)item.MdText1 : DBNull.Value, DbType.String, 600)
							.AddInParameter("@Md_text2", item.MdText2 != null ?  (object)item.MdText2 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 插入一组数据
		/// </summary>
		/// <param name = "items">要插入的实体对象集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Add(IEnumerable<ModuleEO> items, TransactionManager tm = null)
		{
			int ret = 0;
			const string sql = @"INSERT INTO module (Md_id, Md_name, Md_parentid, Md_address, Pf_id, Md_useFlag, Md_notes, Md_deleteFlag, Md_addTime, Md_existsTreeView, Md_filedOrder, Md_imgUrl, Md_text1, Md_text2) VALUES (@Md_id, @Md_name, @Md_parentid, @Md_address, @Pf_id, @Md_useFlag, @Md_notes, @Md_deleteFlag, @Md_addTime, @Md_existsTreeView, @Md_filedOrder, @Md_imgUrl, @Md_text1, @Md_text2) ";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@Md_id", DbType.String, 150)
									.AddParameter("@Md_name", DbType.String, 300)
									.AddParameter("@Md_parentid", DbType.String, 150)
									.AddParameter("@Md_address", DbType.String, 600)
									.AddParameter("@Pf_id", DbType.String, 150)
									.AddParameter("@Md_useFlag", DbType.String, 3)
									.AddParameter("@Md_notes", DbType.String, 765)
									.AddParameter("@Md_deleteFlag", DbType.String, 3)
									.AddParameter("@Md_addTime", DbType.DateTime, 0)
									.AddParameter("@Md_existsTreeView", DbType.String, 3)
									.AddParameter("@Md_filedOrder", DbType.Int32, 0)
									.AddParameter("@Md_imgUrl", DbType.String, 600)
									.AddParameter("@Md_text1", DbType.String, 600)
									.AddParameter("@Md_text2", DbType.String, 600);

			foreach (ModuleEO item in items)
			{
				sqlDao
					.SetParameterValue("@Md_id", item.MdId)
					.SetParameterValue("@Md_name", item.MdName != null ?  (object)item.MdName : DBNull.Value)
					.SetParameterValue("@Md_parentid", item.MdParentid != null ?  (object)item.MdParentid : DBNull.Value)
					.SetParameterValue("@Md_address", item.MdAddress != null ?  (object)item.MdAddress : DBNull.Value)
					.SetParameterValue("@Pf_id", item.PfId != null ?  (object)item.PfId : DBNull.Value)
					.SetParameterValue("@Md_useFlag", item.MdUseFlag != null ?  (object)item.MdUseFlag : DBNull.Value)
					.SetParameterValue("@Md_notes", item.MdNotes != null ?  (object)item.MdNotes : DBNull.Value)
					.SetParameterValue("@Md_deleteFlag", item.MdDeleteFlag != null ?  (object)item.MdDeleteFlag : DBNull.Value)
					.SetParameterValue("@Md_addTime", item.MdAddTime)
					.SetParameterValue("@Md_existsTreeView", item.MdExistsTreeView != null ?  (object)item.MdExistsTreeView : DBNull.Value)
					.SetParameterValue("@Md_filedOrder", item.MdFiledOrder.HasValue ? (object)item.MdFiledOrder.Value : DBNull.Value)
					.SetParameterValue("@Md_imgUrl", item.MdImgUrl != null ?  (object)item.MdImgUrl : DBNull.Value)
					.SetParameterValue("@Md_text1", item.MdText1 != null ?  (object)item.MdText1 : DBNull.Value)
					.SetParameterValue("@Md_text2", item.MdText2 != null ?  (object)item.MdText2 : DBNull.Value)
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
		public virtual int Put(ModuleEO item, TransactionManager tm = null)
		{
			const string sql = @"UPDATE module SET Md_id=@Md_id, Md_name=@Md_name, Md_parentid=@Md_parentid, Md_address=@Md_address, Pf_id=@Pf_id, Md_useFlag=@Md_useFlag, Md_notes=@Md_notes, Md_deleteFlag=@Md_deleteFlag, Md_addTime=@Md_addTime, Md_existsTreeView=@Md_existsTreeView, Md_filedOrder=@Md_filedOrder, Md_imgUrl=@Md_imgUrl, Md_text1=@Md_text1, Md_text2=@Md_text2 WHERE Md_id=@OriginalMd_id";
			return Database.CreateSqlDao (sql)
							.AddInParameter("@OriginalMdId", (item.HasOriginal) ? item.OriginalMdId : item.MdId, DbType.String, 150)
							.AddInParameter("@Md_id", item.MdId, DbType.String, 150)
							.AddInParameter("@Md_name", item.MdName != null ?  (object)item.MdName : DBNull.Value, DbType.String, 300)
							.AddInParameter("@Md_parentid", item.MdParentid != null ?  (object)item.MdParentid : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Md_address", item.MdAddress != null ?  (object)item.MdAddress : DBNull.Value, DbType.String, 600)
							.AddInParameter("@Pf_id", item.PfId != null ?  (object)item.PfId : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Md_useFlag", item.MdUseFlag != null ?  (object)item.MdUseFlag : DBNull.Value, DbType.String, 3)
							.AddInParameter("@Md_notes", item.MdNotes != null ?  (object)item.MdNotes : DBNull.Value, DbType.String, 765)
							.AddInParameter("@Md_deleteFlag", item.MdDeleteFlag != null ?  (object)item.MdDeleteFlag : DBNull.Value, DbType.String, 3)
							.AddInParameter("@Md_addTime", item.MdAddTime, DbType.DateTime, 0)
							.AddInParameter("@Md_existsTreeView", item.MdExistsTreeView != null ?  (object)item.MdExistsTreeView : DBNull.Value, DbType.String, 3)
							.AddInParameter("@Md_filedOrder", item.MdFiledOrder.HasValue ? (object)item.MdFiledOrder.Value : DBNull.Value, DbType.Int32, 0)
							.AddInParameter("@Md_imgUrl", item.MdImgUrl != null ?  (object)item.MdImgUrl : DBNull.Value, DbType.String, 600)
							.AddInParameter("@Md_text1", item.MdText1 != null ?  (object)item.MdText1 : DBNull.Value, DbType.String, 600)
							.AddInParameter("@Md_text2", item.MdText2 != null ?  (object)item.MdText2 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}


		/// <summary>
		/// 更新数据
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Put(IEnumerable<ModuleEO> items, TransactionManager tm = null)
		{

			int ret = 0;
			const string sql = @"UPDATE module SET Md_id=@Md_id, Md_name=@Md_name, Md_parentid=@Md_parentid, Md_address=@Md_address, Pf_id=@Pf_id, Md_useFlag=@Md_useFlag, Md_notes=@Md_notes, Md_deleteFlag=@Md_deleteFlag, Md_addTime=@Md_addTime, Md_existsTreeView=@Md_existsTreeView, Md_filedOrder=@Md_filedOrder, Md_imgUrl=@Md_imgUrl, Md_text1=@Md_text1, Md_text2=@Md_text2 WHERE Md_id=@OriginalMd_id";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@OriginalMdId", DbType.String, 150)
									.AddParameter("@Md_id", DbType.String, 150)
									.AddParameter("@Md_name", DbType.String, 300)
									.AddParameter("@Md_parentid", DbType.String, 150)
									.AddParameter("@Md_address", DbType.String, 600)
									.AddParameter("@Pf_id", DbType.String, 150)
									.AddParameter("@Md_useFlag", DbType.String, 3)
									.AddParameter("@Md_notes", DbType.String, 765)
									.AddParameter("@Md_deleteFlag", DbType.String, 3)
									.AddParameter("@Md_addTime", DbType.DateTime, 0)
									.AddParameter("@Md_existsTreeView", DbType.String, 3)
									.AddParameter("@Md_filedOrder", DbType.Int32, 0)
									.AddParameter("@Md_imgUrl", DbType.String, 600)
									.AddParameter("@Md_text1", DbType.String, 600)
									.AddParameter("@Md_text2", DbType.String, 600);

			foreach (ModuleEO item in items)
			{
				ret += sqlDao
							.SetParameterValue("@OriginalMdId", (item.HasOriginal) ? item.OriginalMdId : item.MdId)
							.SetParameterValue("@Md_id", item.MdId)
							.SetParameterValue("@Md_name", item.MdName != null ?  (object)item.MdName : DBNull.Value)
							.SetParameterValue("@Md_parentid", item.MdParentid != null ?  (object)item.MdParentid : DBNull.Value)
							.SetParameterValue("@Md_address", item.MdAddress != null ?  (object)item.MdAddress : DBNull.Value)
							.SetParameterValue("@Pf_id", item.PfId != null ?  (object)item.PfId : DBNull.Value)
							.SetParameterValue("@Md_useFlag", item.MdUseFlag != null ?  (object)item.MdUseFlag : DBNull.Value)
							.SetParameterValue("@Md_notes", item.MdNotes != null ?  (object)item.MdNotes : DBNull.Value)
							.SetParameterValue("@Md_deleteFlag", item.MdDeleteFlag != null ?  (object)item.MdDeleteFlag : DBNull.Value)
							.SetParameterValue("@Md_addTime", item.MdAddTime)
							.SetParameterValue("@Md_existsTreeView", item.MdExistsTreeView != null ?  (object)item.MdExistsTreeView : DBNull.Value)
							.SetParameterValue("@Md_filedOrder", item.MdFiledOrder.HasValue ? (object)item.MdFiledOrder.Value : DBNull.Value)
							.SetParameterValue("@Md_imgUrl", item.MdImgUrl != null ?  (object)item.MdImgUrl : DBNull.Value)
							.SetParameterValue("@Md_text1", item.MdText1 != null ?  (object)item.MdText1 : DBNull.Value)
							.SetParameterValue("@Md_text2", item.MdText2 != null ?  (object)item.MdText2 : DBNull.Value)
							.ExecNonQuery(tm);
			}
			return ret;
		}


		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "mdId"></param>
		/// <param name = "mdName"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutMdNameByPK(string mdId, string mdName, TransactionManager tm = null)
		{
			const string sql = @"UPDATE module SET Md_name = @Md_name  WHERE Md_id = @Md_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Md_id", mdId, DbType.String, 150)
							.AddInParameter("@Md_name", mdName != null ?  (object)mdName : DBNull.Value, DbType.String, 300)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "mdId"></param>
		/// <param name = "mdParentid"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutMdParentidByPK(string mdId, string mdParentid, TransactionManager tm = null)
		{
			const string sql = @"UPDATE module SET Md_parentid = @Md_parentid  WHERE Md_id = @Md_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Md_id", mdId, DbType.String, 150)
							.AddInParameter("@Md_parentid", mdParentid != null ?  (object)mdParentid : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "mdId"></param>
		/// <param name = "mdAddress"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutMdAddressByPK(string mdId, string mdAddress, TransactionManager tm = null)
		{
			const string sql = @"UPDATE module SET Md_address = @Md_address  WHERE Md_id = @Md_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Md_id", mdId, DbType.String, 150)
							.AddInParameter("@Md_address", mdAddress != null ?  (object)mdAddress : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "mdId"></param>
		/// <param name = "pfId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutPfIdByPK(string mdId, string pfId, TransactionManager tm = null)
		{
			const string sql = @"UPDATE module SET Pf_id = @Pf_id  WHERE Md_id = @Md_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Md_id", mdId, DbType.String, 150)
							.AddInParameter("@Pf_id", pfId != null ?  (object)pfId : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "mdId"></param>
		/// <param name = "mdUseFlag"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutMdUseFlagByPK(string mdId, string mdUseFlag, TransactionManager tm = null)
		{
			const string sql = @"UPDATE module SET Md_useFlag = @Md_useFlag  WHERE Md_id = @Md_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Md_id", mdId, DbType.String, 150)
							.AddInParameter("@Md_useFlag", mdUseFlag != null ?  (object)mdUseFlag : DBNull.Value, DbType.String, 3)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "mdId"></param>
		/// <param name = "mdNotes"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutMdNotesByPK(string mdId, string mdNotes, TransactionManager tm = null)
		{
			const string sql = @"UPDATE module SET Md_notes = @Md_notes  WHERE Md_id = @Md_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Md_id", mdId, DbType.String, 150)
							.AddInParameter("@Md_notes", mdNotes != null ?  (object)mdNotes : DBNull.Value, DbType.String, 765)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "mdId"></param>
		/// <param name = "mdDeleteFlag"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutMdDeleteFlagByPK(string mdId, string mdDeleteFlag, TransactionManager tm = null)
		{
			const string sql = @"UPDATE module SET Md_deleteFlag = @Md_deleteFlag  WHERE Md_id = @Md_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Md_id", mdId, DbType.String, 150)
							.AddInParameter("@Md_deleteFlag", mdDeleteFlag != null ?  (object)mdDeleteFlag : DBNull.Value, DbType.String, 3)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "mdId"></param>
		/// <param name = "mdAddTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutMdAddTimeByPK(string mdId, DateTime mdAddTime, TransactionManager tm = null)
		{
			const string sql = @"UPDATE module SET Md_addTime = @Md_addTime  WHERE Md_id = @Md_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Md_id", mdId, DbType.String, 150)
							.AddInParameter("@Md_addTime", mdAddTime, DbType.DateTime, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "mdId"></param>
		/// <param name = "mdExistsTreeView"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutMdExistsTreeViewByPK(string mdId, string mdExistsTreeView, TransactionManager tm = null)
		{
			const string sql = @"UPDATE module SET Md_existsTreeView = @Md_existsTreeView  WHERE Md_id = @Md_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Md_id", mdId, DbType.String, 150)
							.AddInParameter("@Md_existsTreeView", mdExistsTreeView != null ?  (object)mdExistsTreeView : DBNull.Value, DbType.String, 3)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "mdId"></param>
		/// <param name = "mdFiledOrder"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutMdFiledOrderByPK(string mdId, int? mdFiledOrder, TransactionManager tm = null)
		{
			const string sql = @"UPDATE module SET Md_filedOrder = @Md_filedOrder  WHERE Md_id = @Md_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Md_id", mdId, DbType.String, 150)
							.AddInParameter("@Md_filedOrder", mdFiledOrder.HasValue ? (object)mdFiledOrder.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "mdId"></param>
		/// <param name = "mdImgUrl"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutMdImgUrlByPK(string mdId, string mdImgUrl, TransactionManager tm = null)
		{
			const string sql = @"UPDATE module SET Md_imgUrl = @Md_imgUrl  WHERE Md_id = @Md_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Md_id", mdId, DbType.String, 150)
							.AddInParameter("@Md_imgUrl", mdImgUrl != null ?  (object)mdImgUrl : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "mdId"></param>
		/// <param name = "mdText1"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutMdText1ByPK(string mdId, string mdText1, TransactionManager tm = null)
		{
			const string sql = @"UPDATE module SET Md_text1 = @Md_text1  WHERE Md_id = @Md_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Md_id", mdId, DbType.String, 150)
							.AddInParameter("@Md_text1", mdText1 != null ?  (object)mdText1 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "mdId"></param>
		/// <param name = "mdText2"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutMdText2ByPK(string mdId, string mdText2, TransactionManager tm = null)
		{
			const string sql = @"UPDATE module SET Md_text2 = @Md_text2  WHERE Md_id = @Md_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Md_id", mdId, DbType.String, 150)
							.AddInParameter("@Md_text2", mdText2 != null ?  (object)mdText2 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}


		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "mdName"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutMdName(string mdName, TransactionManager tm = null)
		{
			const string sql = @"UPDATE module SET Md_name=@Md_name";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Md_name", mdName != null ?  (object)mdName : DBNull.Value, DbType.String, 300)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "mdParentid"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutMdParentid(string mdParentid, TransactionManager tm = null)
		{
			const string sql = @"UPDATE module SET Md_parentid=@Md_parentid";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Md_parentid", mdParentid != null ?  (object)mdParentid : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "mdAddress"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutMdAddress(string mdAddress, TransactionManager tm = null)
		{
			const string sql = @"UPDATE module SET Md_address=@Md_address";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Md_address", mdAddress != null ?  (object)mdAddress : DBNull.Value, DbType.String, 600)
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
			const string sql = @"UPDATE module SET Pf_id=@Pf_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pf_id", pfId != null ?  (object)pfId : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "mdUseFlag"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutMdUseFlag(string mdUseFlag, TransactionManager tm = null)
		{
			const string sql = @"UPDATE module SET Md_useFlag=@Md_useFlag";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Md_useFlag", mdUseFlag != null ?  (object)mdUseFlag : DBNull.Value, DbType.String, 3)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "mdNotes"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutMdNotes(string mdNotes, TransactionManager tm = null)
		{
			const string sql = @"UPDATE module SET Md_notes=@Md_notes";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Md_notes", mdNotes != null ?  (object)mdNotes : DBNull.Value, DbType.String, 765)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "mdDeleteFlag"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutMdDeleteFlag(string mdDeleteFlag, TransactionManager tm = null)
		{
			const string sql = @"UPDATE module SET Md_deleteFlag=@Md_deleteFlag";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Md_deleteFlag", mdDeleteFlag != null ?  (object)mdDeleteFlag : DBNull.Value, DbType.String, 3)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "mdAddTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutMdAddTime(DateTime mdAddTime, TransactionManager tm = null)
		{
			const string sql = @"UPDATE module SET Md_addTime=@Md_addTime";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Md_addTime", mdAddTime, DbType.DateTime, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "mdExistsTreeView"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutMdExistsTreeView(string mdExistsTreeView, TransactionManager tm = null)
		{
			const string sql = @"UPDATE module SET Md_existsTreeView=@Md_existsTreeView";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Md_existsTreeView", mdExistsTreeView != null ?  (object)mdExistsTreeView : DBNull.Value, DbType.String, 3)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "mdFiledOrder"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutMdFiledOrder(int? mdFiledOrder, TransactionManager tm = null)
		{
			const string sql = @"UPDATE module SET Md_filedOrder=@Md_filedOrder";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Md_filedOrder", mdFiledOrder.HasValue ? (object)mdFiledOrder.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "mdImgUrl"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutMdImgUrl(string mdImgUrl, TransactionManager tm = null)
		{
			const string sql = @"UPDATE module SET Md_imgUrl=@Md_imgUrl";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Md_imgUrl", mdImgUrl != null ?  (object)mdImgUrl : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "mdText1"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutMdText1(string mdText1, TransactionManager tm = null)
		{
			const string sql = @"UPDATE module SET Md_text1=@Md_text1";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Md_text1", mdText1 != null ?  (object)mdText1 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "mdText2"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutMdText2(string mdText2, TransactionManager tm = null)
		{
			const string sql = @"UPDATE module SET Md_text2=@Md_text2";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Md_text2", mdText2 != null ?  (object)mdText2 : DBNull.Value, DbType.String, 600)
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
			const string format = @"UPDATE module SET {0} {1}";
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
			const string format = @"UPDATE module SET {0} {1}";
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
		/// <param name = "mdId"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByPK(string mdId, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM module WHERE Md_id=@Md_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Md_id", mdId, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Remove(ModuleEO item, TransactionManager tm = null)
		{
			return RemoveByPK(item.MdId, tm);
		}

		/// <summary>
		/// 删除指定实体集合对应的记录集
		/// </summary>
		/// <param name = "items">要删除的实体集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Remove(IEnumerable<ModuleEO> items, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM module WHERE Md_id=@OriginalMd_id";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@OriginalMdId", DbType.String, 150);
			int ret = 0;
			foreach (ModuleEO item in items)
			{
				ret += sqlDao
							.SetParameterValue("@OriginalMdId", (item.HasOriginal) ? item.OriginalMdId : item.MdId)
							.ExecNonQuery(tm);
			}
			return ret;
		}




		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "mdName"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByMdName(string mdName, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM module WHERE Md_name=@Md_name";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Md_name", mdName != null ?  (object)mdName : DBNull.Value, DbType.String, 300)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "mdParentid"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByMdParentid(string mdParentid, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM module WHERE Md_parentid=@Md_parentid";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Md_parentid", mdParentid != null ?  (object)mdParentid : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "mdAddress"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByMdAddress(string mdAddress, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM module WHERE Md_address=@Md_address";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Md_address", mdAddress != null ?  (object)mdAddress : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "pfId"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByPfId(string pfId, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM module WHERE Pf_id=@Pf_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Pf_id", pfId != null ?  (object)pfId : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "mdUseFlag"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByMdUseFlag(string mdUseFlag, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM module WHERE Md_useFlag=@Md_useFlag";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Md_useFlag", mdUseFlag != null ?  (object)mdUseFlag : DBNull.Value, DbType.String, 3)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "mdNotes"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByMdNotes(string mdNotes, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM module WHERE Md_notes=@Md_notes";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Md_notes", mdNotes != null ?  (object)mdNotes : DBNull.Value, DbType.String, 765)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "mdDeleteFlag"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByMdDeleteFlag(string mdDeleteFlag, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM module WHERE Md_deleteFlag=@Md_deleteFlag";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Md_deleteFlag", mdDeleteFlag != null ?  (object)mdDeleteFlag : DBNull.Value, DbType.String, 3)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "mdAddTime"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByMdAddTime(DateTime mdAddTime, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM module WHERE Md_addTime=@Md_addTime";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Md_addTime", mdAddTime, DbType.DateTime, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "mdExistsTreeView"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByMdExistsTreeView(string mdExistsTreeView, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM module WHERE Md_existsTreeView=@Md_existsTreeView";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Md_existsTreeView", mdExistsTreeView != null ?  (object)mdExistsTreeView : DBNull.Value, DbType.String, 3)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "mdFiledOrder"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByMdFiledOrder(int? mdFiledOrder, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM module WHERE Md_filedOrder=@Md_filedOrder";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Md_filedOrder", mdFiledOrder.HasValue ? (object)mdFiledOrder.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "mdImgUrl"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByMdImgUrl(string mdImgUrl, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM module WHERE Md_imgUrl=@Md_imgUrl";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Md_imgUrl", mdImgUrl != null ?  (object)mdImgUrl : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "mdText1"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByMdText1(string mdText1, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM module WHERE Md_text1=@Md_text1";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Md_text1", mdText1 != null ?  (object)mdText1 : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "mdText2"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByMdText2(string mdText2, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM module WHERE Md_text2=@Md_text2";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Md_text2", mdText2 != null ?  (object)mdText2 : DBNull.Value, DbType.String, 600)
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
			const string format = @"DELETE FROM module {0}";
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
			const string format = @"DELETE FROM module {0}";
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
