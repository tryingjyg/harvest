//==========================================================
// 此代码由代码生成器工具自动生成，请不要修改
// 代码生成器核心库版本号：2.0
// 创建时间：2017/9/23 14:14:50
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
	/// 【表 organize 的实体类】
	/// </summary>
	[SerializableAttribute]
	public class OrganizeEO : DataEntityBase, IRowMapper<OrganizeEO>
	{
		protected string _originalUrId;

		/// <summary>
		/// 主键是否有原始值（即数据库中保存的值），用于实体对象更新时
		/// </summary>
		public bool HasOriginal { get; protected set; }

		/// <summary>
		/// 【主键 varchar】
		/// </summary>
		public virtual string UrId { get; set; }

		/// <summary>
		/// 【数据库中的原始主键值副本】
		/// </summary>
		public virtual string OriginalUrId
		{
			get { return _originalUrId; }
			set { HasOriginal = true; _originalUrId = value; }
		}

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string UrNo { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string UrName { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string UrUserName { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string UrPassWord { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string UrZone { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string UrPeople { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string UrContact { get; set; }

		/// <summary>
		/// 【字段 datetime】
		/// </summary>
		public virtual DateTime UrAddTime { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string UrPercent { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string UrBankName { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string UrBank { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string UrBankNo { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string UrIntroducer { get; set; }

		/// <summary>
		/// 【字段 char】
		/// </summary>
		public virtual string UrState { get; set; }

		/// <summary>
		/// 【字段 char】
		/// </summary>
		public virtual string UrDel { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string UrErrorlogin { get; set; }

		/// <summary>
		/// 【字段 datetime】
		/// </summary>
		public virtual DateTime UrLockTime { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string UrLockBindIp { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string UrText1 { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string UrText2 { get; set; }

		/// <summary>
		/// 默认构造函数
		/// </summary>
		public OrganizeEO() 
		{
			UrId = string.Empty;
			UrNo = string.Empty;
		}

		/// <summary>
		/// 自定义构造函数
		/// </summary>
		/// <param name = "urId"></param>
		/// <param name = "urNo"></param>
		/// <param name = "urName"></param>
		/// <param name = "urUserName"></param>
		/// <param name = "urPassWord"></param>
		/// <param name = "urZone"></param>
		/// <param name = "urPeople"></param>
		/// <param name = "urContact"></param>
		/// <param name = "urAddTime"></param>
		/// <param name = "urPercent"></param>
		/// <param name = "urBankName"></param>
		/// <param name = "urBank"></param>
		/// <param name = "urBankNo"></param>
		/// <param name = "urIntroducer"></param>
		/// <param name = "urState"></param>
		/// <param name = "urDel"></param>
		/// <param name = "urErrorlogin"></param>
		/// <param name = "urLockTime"></param>
		/// <param name = "urLockBindIp"></param>
		/// <param name = "urText1"></param>
		/// <param name = "urText2"></param>
		public OrganizeEO(string urId, string urNo, string urName, string urUserName, string urPassWord, string urZone, string urPeople, string urContact, DateTime urAddTime, string urPercent, string urBankName, string urBank, string urBankNo, string urIntroducer, string urState, string urDel, string urErrorlogin, DateTime urLockTime, string urLockBindIp, string urText1, string urText2) 
		{
			UrId = urId;
			UrNo = urNo;
			UrName = urName;
			UrUserName = urUserName;
			UrPassWord = urPassWord;
			UrZone = urZone;
			UrPeople = urPeople;
			UrContact = urContact;
			UrAddTime = urAddTime;
			UrPercent = urPercent;
			UrBankName = urBankName;
			UrBank = urBank;
			UrBankNo = urBankNo;
			UrIntroducer = urIntroducer;
			UrState = urState;
			UrDel = urDel;
			UrErrorlogin = urErrorlogin;
			UrLockTime = urLockTime;
			UrLockBindIp = urLockBindIp;
			UrText1 = urText1;
			UrText2 = urText2;
		}

		/// <summary>
		/// 将结果集映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public OrganizeEO MapRow(IDataReader reader)
		{
			return GetItem(reader);
		}

		/// <summary>
		/// 将结果集映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static OrganizeEO GetItem(IDataReader reader)
		{
			OrganizeEO ret = new OrganizeEO();

			ret.UrId = (string)reader["Ur_id"];
			ret.OriginalUrId = ret.UrId;
			ret.UrNo = (string)reader["Ur_no"];
			ret.UrName = (reader["Ur_Name"] is DBNull) ? null : (string)reader["Ur_Name"];
			ret.UrUserName = (reader["Ur_UserName"] is DBNull) ? null : (string)reader["Ur_UserName"];
			ret.UrPassWord = (reader["Ur_PassWord"] is DBNull) ? null : (string)reader["Ur_PassWord"];
			ret.UrZone = (reader["Ur_zone"] is DBNull) ? null : (string)reader["Ur_zone"];
			ret.UrPeople = (reader["Ur_people"] is DBNull) ? null : (string)reader["Ur_people"];
			ret.UrContact = (reader["Ur_Contact"] is DBNull) ? null : (string)reader["Ur_Contact"];
			ret.UrAddTime = DateTime.Parse(reader["Ur_addTime"].ToString());
			ret.UrPercent = (reader["Ur_percent"] is DBNull) ? null : (string)reader["Ur_percent"];
			ret.UrBankName = (reader["Ur_bankName"] is DBNull) ? null : (string)reader["Ur_bankName"];
			ret.UrBank = (reader["Ur_bank"] is DBNull) ? null : (string)reader["Ur_bank"];
			ret.UrBankNo = (reader["Ur_bankNo"] is DBNull) ? null : (string)reader["Ur_bankNo"];
			ret.UrIntroducer = (reader["Ur_introducer"] is DBNull) ? null : (string)reader["Ur_introducer"];
			ret.UrState = (reader["Ur_state"] is DBNull) ? null : (string)reader["Ur_state"];
			ret.UrDel = (reader["Ur_del"] is DBNull) ? null : (string)reader["Ur_del"];
			ret.UrErrorlogin = (reader["Ur_errorlogin"] is DBNull) ? null : (string)reader["Ur_errorlogin"];
			ret.UrLockTime = DateTime.Parse(reader["Ur_lockTime"].ToString());
			ret.UrLockBindIp = (reader["Ur_lockBindIp"] is DBNull) ? null : (string)reader["Ur_lockBindIp"];
			ret.UrText1 = (reader["Ur_text1"] is DBNull) ? null : (string)reader["Ur_text1"];
			ret.UrText2 = (reader["Ur_text2"] is DBNull) ? null : (string)reader["Ur_text2"];
			return ret;
		}
	}


	#endregion

	#region  MO

	/// <summary>
	/// 【表 organize 的操作类】
	/// </summary>
	public partial class OrganizeMO : DataManagerBase
	{

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "routeData">路由数据</param>
		public OrganizeMO(object routeData = null) : base(routeData) { }

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">连接字符串名称</param>
		public OrganizeMO(string connectionStringName) : base(connectionStringName) { }

		#region  Get方法集合

		/// <summary>
		/// 按 PK（主键） 查询
		/// </summary>
		/// <param name="tm">事务管理对象</param>
		/// <param name = "urId"></param>
		/// <return></return>
		public virtual OrganizeEO GetByPK(string urId, TransactionManager tm = null)
		{
			const string sql = @"SELECT Ur_id, Ur_no, Ur_Name, Ur_UserName, Ur_PassWord, Ur_zone, Ur_people, Ur_Contact, Ur_addTime, Ur_percent, Ur_bankName, Ur_bank, Ur_bankNo, Ur_introducer, Ur_state, Ur_del, Ur_errorlogin, Ur_lockTime, Ur_lockBindIp, Ur_text1, Ur_text2 FROM organize WHERE Ur_id=@Ur_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_id", urId, DbType.String, 150)
							.ExecSingle<OrganizeEO>(OrganizeEO.GetItem, tm);
		}




		#region  按 UrNo（字段） 查询

		/// <summary>
		/// 按 UrNo（字段） 查询
		/// </summary>
		/// <param name = "urNo"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrNo(string urNo)
		{
			return GetByUrNo(urNo, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 UrNo（字段） 查询
		/// </summary>
		/// <param name = "urNo"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrNo(string urNo, TransactionManager tm)
		{
			return GetByUrNo(urNo, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 UrNo（字段） 查询
		/// </summary>
		/// <param name = "urNo"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrNo(string urNo, int top)
		{
			return GetByUrNo(urNo, top, string.Empty, null);
		}

		/// <summary>
		/// 按 UrNo（字段） 查询
		/// </summary>
		/// <param name = "urNo"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrNo(string urNo, int top, TransactionManager tm)
		{
			return GetByUrNo(urNo, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 UrNo（字段） 查询
		/// </summary>
		/// <param name = "urNo"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrNo(string urNo, string sort)
		{
			return GetByUrNo(urNo, 0, sort, null);
		}

		/// <summary>
		/// 按 UrNo（字段） 查询
		/// </summary>
		/// <param name = "urNo"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrNo(string urNo, string sort, TransactionManager tm)
		{
			return GetByUrNo(urNo, 0, sort, tm);
		}

		/// <summary>
		/// 按 UrNo（字段） 查询
		/// </summary>
		/// <param name = "urNo"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrNo(string urNo, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Ur_id, Ur_no, Ur_Name, Ur_UserName, Ur_PassWord, Ur_zone, Ur_people, Ur_Contact, Ur_addTime, Ur_percent, Ur_bankName, Ur_bank, Ur_bankNo, Ur_introducer, Ur_state, Ur_del, Ur_errorlogin, Ur_lockTime, Ur_lockBindIp, Ur_text1, Ur_text2 FROM organize WHERE Ur_no=@UrNo";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@UrNo", urNo, DbType.String, 150)
							.ExecList<OrganizeEO>(OrganizeEO.GetItem, tm);
		}

		#endregion

		#region  按 UrName（字段） 查询

		/// <summary>
		/// 按 UrName（字段） 查询
		/// </summary>
		/// <param name = "urName"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrName(string urName)
		{
			return GetByUrName(urName, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 UrName（字段） 查询
		/// </summary>
		/// <param name = "urName"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrName(string urName, TransactionManager tm)
		{
			return GetByUrName(urName, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 UrName（字段） 查询
		/// </summary>
		/// <param name = "urName"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrName(string urName, int top)
		{
			return GetByUrName(urName, top, string.Empty, null);
		}

		/// <summary>
		/// 按 UrName（字段） 查询
		/// </summary>
		/// <param name = "urName"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrName(string urName, int top, TransactionManager tm)
		{
			return GetByUrName(urName, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 UrName（字段） 查询
		/// </summary>
		/// <param name = "urName"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrName(string urName, string sort)
		{
			return GetByUrName(urName, 0, sort, null);
		}

		/// <summary>
		/// 按 UrName（字段） 查询
		/// </summary>
		/// <param name = "urName"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrName(string urName, string sort, TransactionManager tm)
		{
			return GetByUrName(urName, 0, sort, tm);
		}

		/// <summary>
		/// 按 UrName（字段） 查询
		/// </summary>
		/// <param name = "urName"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrName(string urName, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Ur_id, Ur_no, Ur_Name, Ur_UserName, Ur_PassWord, Ur_zone, Ur_people, Ur_Contact, Ur_addTime, Ur_percent, Ur_bankName, Ur_bank, Ur_bankNo, Ur_introducer, Ur_state, Ur_del, Ur_errorlogin, Ur_lockTime, Ur_lockBindIp, Ur_text1, Ur_text2 FROM organize WHERE Ur_Name=@UrName";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@UrName", urName, DbType.String, 150)
							.ExecList<OrganizeEO>(OrganizeEO.GetItem, tm);
		}

		#endregion

		#region  按 UrUserName（字段） 查询

		/// <summary>
		/// 按 UrUserName（字段） 查询
		/// </summary>
		/// <param name = "urUserName"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrUserName(string urUserName)
		{
			return GetByUrUserName(urUserName, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 UrUserName（字段） 查询
		/// </summary>
		/// <param name = "urUserName"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrUserName(string urUserName, TransactionManager tm)
		{
			return GetByUrUserName(urUserName, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 UrUserName（字段） 查询
		/// </summary>
		/// <param name = "urUserName"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrUserName(string urUserName, int top)
		{
			return GetByUrUserName(urUserName, top, string.Empty, null);
		}

		/// <summary>
		/// 按 UrUserName（字段） 查询
		/// </summary>
		/// <param name = "urUserName"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrUserName(string urUserName, int top, TransactionManager tm)
		{
			return GetByUrUserName(urUserName, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 UrUserName（字段） 查询
		/// </summary>
		/// <param name = "urUserName"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrUserName(string urUserName, string sort)
		{
			return GetByUrUserName(urUserName, 0, sort, null);
		}

		/// <summary>
		/// 按 UrUserName（字段） 查询
		/// </summary>
		/// <param name = "urUserName"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrUserName(string urUserName, string sort, TransactionManager tm)
		{
			return GetByUrUserName(urUserName, 0, sort, tm);
		}

		/// <summary>
		/// 按 UrUserName（字段） 查询
		/// </summary>
		/// <param name = "urUserName"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrUserName(string urUserName, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Ur_id, Ur_no, Ur_Name, Ur_UserName, Ur_PassWord, Ur_zone, Ur_people, Ur_Contact, Ur_addTime, Ur_percent, Ur_bankName, Ur_bank, Ur_bankNo, Ur_introducer, Ur_state, Ur_del, Ur_errorlogin, Ur_lockTime, Ur_lockBindIp, Ur_text1, Ur_text2 FROM organize WHERE Ur_UserName=@UrUserName";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@UrUserName", urUserName, DbType.String, 150)
							.ExecList<OrganizeEO>(OrganizeEO.GetItem, tm);
		}

		#endregion

		#region  按 UrPassWord（字段） 查询

		/// <summary>
		/// 按 UrPassWord（字段） 查询
		/// </summary>
		/// <param name = "urPassWord"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrPassWord(string urPassWord)
		{
			return GetByUrPassWord(urPassWord, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 UrPassWord（字段） 查询
		/// </summary>
		/// <param name = "urPassWord"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrPassWord(string urPassWord, TransactionManager tm)
		{
			return GetByUrPassWord(urPassWord, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 UrPassWord（字段） 查询
		/// </summary>
		/// <param name = "urPassWord"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrPassWord(string urPassWord, int top)
		{
			return GetByUrPassWord(urPassWord, top, string.Empty, null);
		}

		/// <summary>
		/// 按 UrPassWord（字段） 查询
		/// </summary>
		/// <param name = "urPassWord"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrPassWord(string urPassWord, int top, TransactionManager tm)
		{
			return GetByUrPassWord(urPassWord, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 UrPassWord（字段） 查询
		/// </summary>
		/// <param name = "urPassWord"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrPassWord(string urPassWord, string sort)
		{
			return GetByUrPassWord(urPassWord, 0, sort, null);
		}

		/// <summary>
		/// 按 UrPassWord（字段） 查询
		/// </summary>
		/// <param name = "urPassWord"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrPassWord(string urPassWord, string sort, TransactionManager tm)
		{
			return GetByUrPassWord(urPassWord, 0, sort, tm);
		}

		/// <summary>
		/// 按 UrPassWord（字段） 查询
		/// </summary>
		/// <param name = "urPassWord"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrPassWord(string urPassWord, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Ur_id, Ur_no, Ur_Name, Ur_UserName, Ur_PassWord, Ur_zone, Ur_people, Ur_Contact, Ur_addTime, Ur_percent, Ur_bankName, Ur_bank, Ur_bankNo, Ur_introducer, Ur_state, Ur_del, Ur_errorlogin, Ur_lockTime, Ur_lockBindIp, Ur_text1, Ur_text2 FROM organize WHERE Ur_PassWord=@UrPassWord";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@UrPassWord", urPassWord, DbType.String, 150)
							.ExecList<OrganizeEO>(OrganizeEO.GetItem, tm);
		}

		#endregion

		#region  按 UrZone（字段） 查询

		/// <summary>
		/// 按 UrZone（字段） 查询
		/// </summary>
		/// <param name = "urZone"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrZone(string urZone)
		{
			return GetByUrZone(urZone, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 UrZone（字段） 查询
		/// </summary>
		/// <param name = "urZone"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrZone(string urZone, TransactionManager tm)
		{
			return GetByUrZone(urZone, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 UrZone（字段） 查询
		/// </summary>
		/// <param name = "urZone"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrZone(string urZone, int top)
		{
			return GetByUrZone(urZone, top, string.Empty, null);
		}

		/// <summary>
		/// 按 UrZone（字段） 查询
		/// </summary>
		/// <param name = "urZone"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrZone(string urZone, int top, TransactionManager tm)
		{
			return GetByUrZone(urZone, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 UrZone（字段） 查询
		/// </summary>
		/// <param name = "urZone"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrZone(string urZone, string sort)
		{
			return GetByUrZone(urZone, 0, sort, null);
		}

		/// <summary>
		/// 按 UrZone（字段） 查询
		/// </summary>
		/// <param name = "urZone"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrZone(string urZone, string sort, TransactionManager tm)
		{
			return GetByUrZone(urZone, 0, sort, tm);
		}

		/// <summary>
		/// 按 UrZone（字段） 查询
		/// </summary>
		/// <param name = "urZone"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrZone(string urZone, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Ur_id, Ur_no, Ur_Name, Ur_UserName, Ur_PassWord, Ur_zone, Ur_people, Ur_Contact, Ur_addTime, Ur_percent, Ur_bankName, Ur_bank, Ur_bankNo, Ur_introducer, Ur_state, Ur_del, Ur_errorlogin, Ur_lockTime, Ur_lockBindIp, Ur_text1, Ur_text2 FROM organize WHERE Ur_zone=@UrZone";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@UrZone", urZone, DbType.String, 150)
							.ExecList<OrganizeEO>(OrganizeEO.GetItem, tm);
		}

		#endregion

		#region  按 UrPeople（字段） 查询

		/// <summary>
		/// 按 UrPeople（字段） 查询
		/// </summary>
		/// <param name = "urPeople"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrPeople(string urPeople)
		{
			return GetByUrPeople(urPeople, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 UrPeople（字段） 查询
		/// </summary>
		/// <param name = "urPeople"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrPeople(string urPeople, TransactionManager tm)
		{
			return GetByUrPeople(urPeople, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 UrPeople（字段） 查询
		/// </summary>
		/// <param name = "urPeople"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrPeople(string urPeople, int top)
		{
			return GetByUrPeople(urPeople, top, string.Empty, null);
		}

		/// <summary>
		/// 按 UrPeople（字段） 查询
		/// </summary>
		/// <param name = "urPeople"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrPeople(string urPeople, int top, TransactionManager tm)
		{
			return GetByUrPeople(urPeople, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 UrPeople（字段） 查询
		/// </summary>
		/// <param name = "urPeople"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrPeople(string urPeople, string sort)
		{
			return GetByUrPeople(urPeople, 0, sort, null);
		}

		/// <summary>
		/// 按 UrPeople（字段） 查询
		/// </summary>
		/// <param name = "urPeople"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrPeople(string urPeople, string sort, TransactionManager tm)
		{
			return GetByUrPeople(urPeople, 0, sort, tm);
		}

		/// <summary>
		/// 按 UrPeople（字段） 查询
		/// </summary>
		/// <param name = "urPeople"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrPeople(string urPeople, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Ur_id, Ur_no, Ur_Name, Ur_UserName, Ur_PassWord, Ur_zone, Ur_people, Ur_Contact, Ur_addTime, Ur_percent, Ur_bankName, Ur_bank, Ur_bankNo, Ur_introducer, Ur_state, Ur_del, Ur_errorlogin, Ur_lockTime, Ur_lockBindIp, Ur_text1, Ur_text2 FROM organize WHERE Ur_people=@UrPeople";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@UrPeople", urPeople, DbType.String, 150)
							.ExecList<OrganizeEO>(OrganizeEO.GetItem, tm);
		}

		#endregion

		#region  按 UrContact（字段） 查询

		/// <summary>
		/// 按 UrContact（字段） 查询
		/// </summary>
		/// <param name = "urContact"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrContact(string urContact)
		{
			return GetByUrContact(urContact, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 UrContact（字段） 查询
		/// </summary>
		/// <param name = "urContact"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrContact(string urContact, TransactionManager tm)
		{
			return GetByUrContact(urContact, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 UrContact（字段） 查询
		/// </summary>
		/// <param name = "urContact"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrContact(string urContact, int top)
		{
			return GetByUrContact(urContact, top, string.Empty, null);
		}

		/// <summary>
		/// 按 UrContact（字段） 查询
		/// </summary>
		/// <param name = "urContact"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrContact(string urContact, int top, TransactionManager tm)
		{
			return GetByUrContact(urContact, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 UrContact（字段） 查询
		/// </summary>
		/// <param name = "urContact"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrContact(string urContact, string sort)
		{
			return GetByUrContact(urContact, 0, sort, null);
		}

		/// <summary>
		/// 按 UrContact（字段） 查询
		/// </summary>
		/// <param name = "urContact"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrContact(string urContact, string sort, TransactionManager tm)
		{
			return GetByUrContact(urContact, 0, sort, tm);
		}

		/// <summary>
		/// 按 UrContact（字段） 查询
		/// </summary>
		/// <param name = "urContact"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrContact(string urContact, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Ur_id, Ur_no, Ur_Name, Ur_UserName, Ur_PassWord, Ur_zone, Ur_people, Ur_Contact, Ur_addTime, Ur_percent, Ur_bankName, Ur_bank, Ur_bankNo, Ur_introducer, Ur_state, Ur_del, Ur_errorlogin, Ur_lockTime, Ur_lockBindIp, Ur_text1, Ur_text2 FROM organize WHERE Ur_Contact=@UrContact";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@UrContact", urContact, DbType.String, 150)
							.ExecList<OrganizeEO>(OrganizeEO.GetItem, tm);
		}

		#endregion

		#region  按 UrAddTime（字段） 查询

		/// <summary>
		/// 按 UrAddTime（字段） 查询
		/// </summary>
		/// <param name = "urAddTime"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrAddTime(DateTime urAddTime)
		{
			return GetByUrAddTime(urAddTime, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 UrAddTime（字段） 查询
		/// </summary>
		/// <param name = "urAddTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrAddTime(DateTime urAddTime, TransactionManager tm)
		{
			return GetByUrAddTime(urAddTime, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 UrAddTime（字段） 查询
		/// </summary>
		/// <param name = "urAddTime"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrAddTime(DateTime urAddTime, int top)
		{
			return GetByUrAddTime(urAddTime, top, string.Empty, null);
		}

		/// <summary>
		/// 按 UrAddTime（字段） 查询
		/// </summary>
		/// <param name = "urAddTime"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrAddTime(DateTime urAddTime, int top, TransactionManager tm)
		{
			return GetByUrAddTime(urAddTime, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 UrAddTime（字段） 查询
		/// </summary>
		/// <param name = "urAddTime"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrAddTime(DateTime urAddTime, string sort)
		{
			return GetByUrAddTime(urAddTime, 0, sort, null);
		}

		/// <summary>
		/// 按 UrAddTime（字段） 查询
		/// </summary>
		/// <param name = "urAddTime"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrAddTime(DateTime urAddTime, string sort, TransactionManager tm)
		{
			return GetByUrAddTime(urAddTime, 0, sort, tm);
		}

		/// <summary>
		/// 按 UrAddTime（字段） 查询
		/// </summary>
		/// <param name = "urAddTime"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrAddTime(DateTime urAddTime, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Ur_id, Ur_no, Ur_Name, Ur_UserName, Ur_PassWord, Ur_zone, Ur_people, Ur_Contact, Ur_addTime, Ur_percent, Ur_bankName, Ur_bank, Ur_bankNo, Ur_introducer, Ur_state, Ur_del, Ur_errorlogin, Ur_lockTime, Ur_lockBindIp, Ur_text1, Ur_text2 FROM organize WHERE Ur_addTime=@UrAddTime";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@UrAddTime", urAddTime, DbType.DateTime, 0)
							.ExecList<OrganizeEO>(OrganizeEO.GetItem, tm);
		}

		#endregion

		#region  按 UrPercent（字段） 查询

		/// <summary>
		/// 按 UrPercent（字段） 查询
		/// </summary>
		/// <param name = "urPercent"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrPercent(string urPercent)
		{
			return GetByUrPercent(urPercent, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 UrPercent（字段） 查询
		/// </summary>
		/// <param name = "urPercent"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrPercent(string urPercent, TransactionManager tm)
		{
			return GetByUrPercent(urPercent, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 UrPercent（字段） 查询
		/// </summary>
		/// <param name = "urPercent"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrPercent(string urPercent, int top)
		{
			return GetByUrPercent(urPercent, top, string.Empty, null);
		}

		/// <summary>
		/// 按 UrPercent（字段） 查询
		/// </summary>
		/// <param name = "urPercent"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrPercent(string urPercent, int top, TransactionManager tm)
		{
			return GetByUrPercent(urPercent, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 UrPercent（字段） 查询
		/// </summary>
		/// <param name = "urPercent"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrPercent(string urPercent, string sort)
		{
			return GetByUrPercent(urPercent, 0, sort, null);
		}

		/// <summary>
		/// 按 UrPercent（字段） 查询
		/// </summary>
		/// <param name = "urPercent"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrPercent(string urPercent, string sort, TransactionManager tm)
		{
			return GetByUrPercent(urPercent, 0, sort, tm);
		}

		/// <summary>
		/// 按 UrPercent（字段） 查询
		/// </summary>
		/// <param name = "urPercent"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrPercent(string urPercent, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Ur_id, Ur_no, Ur_Name, Ur_UserName, Ur_PassWord, Ur_zone, Ur_people, Ur_Contact, Ur_addTime, Ur_percent, Ur_bankName, Ur_bank, Ur_bankNo, Ur_introducer, Ur_state, Ur_del, Ur_errorlogin, Ur_lockTime, Ur_lockBindIp, Ur_text1, Ur_text2 FROM organize WHERE Ur_percent=@UrPercent";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@UrPercent", urPercent, DbType.String, 150)
							.ExecList<OrganizeEO>(OrganizeEO.GetItem, tm);
		}

		#endregion

		#region  按 UrBankName（字段） 查询

		/// <summary>
		/// 按 UrBankName（字段） 查询
		/// </summary>
		/// <param name = "urBankName"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrBankName(string urBankName)
		{
			return GetByUrBankName(urBankName, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 UrBankName（字段） 查询
		/// </summary>
		/// <param name = "urBankName"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrBankName(string urBankName, TransactionManager tm)
		{
			return GetByUrBankName(urBankName, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 UrBankName（字段） 查询
		/// </summary>
		/// <param name = "urBankName"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrBankName(string urBankName, int top)
		{
			return GetByUrBankName(urBankName, top, string.Empty, null);
		}

		/// <summary>
		/// 按 UrBankName（字段） 查询
		/// </summary>
		/// <param name = "urBankName"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrBankName(string urBankName, int top, TransactionManager tm)
		{
			return GetByUrBankName(urBankName, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 UrBankName（字段） 查询
		/// </summary>
		/// <param name = "urBankName"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrBankName(string urBankName, string sort)
		{
			return GetByUrBankName(urBankName, 0, sort, null);
		}

		/// <summary>
		/// 按 UrBankName（字段） 查询
		/// </summary>
		/// <param name = "urBankName"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrBankName(string urBankName, string sort, TransactionManager tm)
		{
			return GetByUrBankName(urBankName, 0, sort, tm);
		}

		/// <summary>
		/// 按 UrBankName（字段） 查询
		/// </summary>
		/// <param name = "urBankName"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrBankName(string urBankName, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Ur_id, Ur_no, Ur_Name, Ur_UserName, Ur_PassWord, Ur_zone, Ur_people, Ur_Contact, Ur_addTime, Ur_percent, Ur_bankName, Ur_bank, Ur_bankNo, Ur_introducer, Ur_state, Ur_del, Ur_errorlogin, Ur_lockTime, Ur_lockBindIp, Ur_text1, Ur_text2 FROM organize WHERE Ur_bankName=@UrBankName";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@UrBankName", urBankName, DbType.String, 150)
							.ExecList<OrganizeEO>(OrganizeEO.GetItem, tm);
		}

		#endregion

		#region  按 UrBank（字段） 查询

		/// <summary>
		/// 按 UrBank（字段） 查询
		/// </summary>
		/// <param name = "urBank"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrBank(string urBank)
		{
			return GetByUrBank(urBank, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 UrBank（字段） 查询
		/// </summary>
		/// <param name = "urBank"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrBank(string urBank, TransactionManager tm)
		{
			return GetByUrBank(urBank, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 UrBank（字段） 查询
		/// </summary>
		/// <param name = "urBank"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrBank(string urBank, int top)
		{
			return GetByUrBank(urBank, top, string.Empty, null);
		}

		/// <summary>
		/// 按 UrBank（字段） 查询
		/// </summary>
		/// <param name = "urBank"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrBank(string urBank, int top, TransactionManager tm)
		{
			return GetByUrBank(urBank, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 UrBank（字段） 查询
		/// </summary>
		/// <param name = "urBank"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrBank(string urBank, string sort)
		{
			return GetByUrBank(urBank, 0, sort, null);
		}

		/// <summary>
		/// 按 UrBank（字段） 查询
		/// </summary>
		/// <param name = "urBank"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrBank(string urBank, string sort, TransactionManager tm)
		{
			return GetByUrBank(urBank, 0, sort, tm);
		}

		/// <summary>
		/// 按 UrBank（字段） 查询
		/// </summary>
		/// <param name = "urBank"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrBank(string urBank, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Ur_id, Ur_no, Ur_Name, Ur_UserName, Ur_PassWord, Ur_zone, Ur_people, Ur_Contact, Ur_addTime, Ur_percent, Ur_bankName, Ur_bank, Ur_bankNo, Ur_introducer, Ur_state, Ur_del, Ur_errorlogin, Ur_lockTime, Ur_lockBindIp, Ur_text1, Ur_text2 FROM organize WHERE Ur_bank=@UrBank";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@UrBank", urBank, DbType.String, 150)
							.ExecList<OrganizeEO>(OrganizeEO.GetItem, tm);
		}

		#endregion

		#region  按 UrBankNo（字段） 查询

		/// <summary>
		/// 按 UrBankNo（字段） 查询
		/// </summary>
		/// <param name = "urBankNo"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrBankNo(string urBankNo)
		{
			return GetByUrBankNo(urBankNo, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 UrBankNo（字段） 查询
		/// </summary>
		/// <param name = "urBankNo"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrBankNo(string urBankNo, TransactionManager tm)
		{
			return GetByUrBankNo(urBankNo, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 UrBankNo（字段） 查询
		/// </summary>
		/// <param name = "urBankNo"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrBankNo(string urBankNo, int top)
		{
			return GetByUrBankNo(urBankNo, top, string.Empty, null);
		}

		/// <summary>
		/// 按 UrBankNo（字段） 查询
		/// </summary>
		/// <param name = "urBankNo"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrBankNo(string urBankNo, int top, TransactionManager tm)
		{
			return GetByUrBankNo(urBankNo, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 UrBankNo（字段） 查询
		/// </summary>
		/// <param name = "urBankNo"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrBankNo(string urBankNo, string sort)
		{
			return GetByUrBankNo(urBankNo, 0, sort, null);
		}

		/// <summary>
		/// 按 UrBankNo（字段） 查询
		/// </summary>
		/// <param name = "urBankNo"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrBankNo(string urBankNo, string sort, TransactionManager tm)
		{
			return GetByUrBankNo(urBankNo, 0, sort, tm);
		}

		/// <summary>
		/// 按 UrBankNo（字段） 查询
		/// </summary>
		/// <param name = "urBankNo"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrBankNo(string urBankNo, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Ur_id, Ur_no, Ur_Name, Ur_UserName, Ur_PassWord, Ur_zone, Ur_people, Ur_Contact, Ur_addTime, Ur_percent, Ur_bankName, Ur_bank, Ur_bankNo, Ur_introducer, Ur_state, Ur_del, Ur_errorlogin, Ur_lockTime, Ur_lockBindIp, Ur_text1, Ur_text2 FROM organize WHERE Ur_bankNo=@UrBankNo";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@UrBankNo", urBankNo, DbType.String, 150)
							.ExecList<OrganizeEO>(OrganizeEO.GetItem, tm);
		}

		#endregion

		#region  按 UrIntroducer（字段） 查询

		/// <summary>
		/// 按 UrIntroducer（字段） 查询
		/// </summary>
		/// <param name = "urIntroducer"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrIntroducer(string urIntroducer)
		{
			return GetByUrIntroducer(urIntroducer, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 UrIntroducer（字段） 查询
		/// </summary>
		/// <param name = "urIntroducer"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrIntroducer(string urIntroducer, TransactionManager tm)
		{
			return GetByUrIntroducer(urIntroducer, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 UrIntroducer（字段） 查询
		/// </summary>
		/// <param name = "urIntroducer"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrIntroducer(string urIntroducer, int top)
		{
			return GetByUrIntroducer(urIntroducer, top, string.Empty, null);
		}

		/// <summary>
		/// 按 UrIntroducer（字段） 查询
		/// </summary>
		/// <param name = "urIntroducer"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrIntroducer(string urIntroducer, int top, TransactionManager tm)
		{
			return GetByUrIntroducer(urIntroducer, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 UrIntroducer（字段） 查询
		/// </summary>
		/// <param name = "urIntroducer"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrIntroducer(string urIntroducer, string sort)
		{
			return GetByUrIntroducer(urIntroducer, 0, sort, null);
		}

		/// <summary>
		/// 按 UrIntroducer（字段） 查询
		/// </summary>
		/// <param name = "urIntroducer"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrIntroducer(string urIntroducer, string sort, TransactionManager tm)
		{
			return GetByUrIntroducer(urIntroducer, 0, sort, tm);
		}

		/// <summary>
		/// 按 UrIntroducer（字段） 查询
		/// </summary>
		/// <param name = "urIntroducer"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrIntroducer(string urIntroducer, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Ur_id, Ur_no, Ur_Name, Ur_UserName, Ur_PassWord, Ur_zone, Ur_people, Ur_Contact, Ur_addTime, Ur_percent, Ur_bankName, Ur_bank, Ur_bankNo, Ur_introducer, Ur_state, Ur_del, Ur_errorlogin, Ur_lockTime, Ur_lockBindIp, Ur_text1, Ur_text2 FROM organize WHERE Ur_introducer=@UrIntroducer";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@UrIntroducer", urIntroducer, DbType.String, 150)
							.ExecList<OrganizeEO>(OrganizeEO.GetItem, tm);
		}

		#endregion

		#region  按 UrState（字段） 查询

		/// <summary>
		/// 按 UrState（字段） 查询
		/// </summary>
		/// <param name = "urState"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrState(string urState)
		{
			return GetByUrState(urState, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 UrState（字段） 查询
		/// </summary>
		/// <param name = "urState"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrState(string urState, TransactionManager tm)
		{
			return GetByUrState(urState, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 UrState（字段） 查询
		/// </summary>
		/// <param name = "urState"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrState(string urState, int top)
		{
			return GetByUrState(urState, top, string.Empty, null);
		}

		/// <summary>
		/// 按 UrState（字段） 查询
		/// </summary>
		/// <param name = "urState"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrState(string urState, int top, TransactionManager tm)
		{
			return GetByUrState(urState, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 UrState（字段） 查询
		/// </summary>
		/// <param name = "urState"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrState(string urState, string sort)
		{
			return GetByUrState(urState, 0, sort, null);
		}

		/// <summary>
		/// 按 UrState（字段） 查询
		/// </summary>
		/// <param name = "urState"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrState(string urState, string sort, TransactionManager tm)
		{
			return GetByUrState(urState, 0, sort, tm);
		}

		/// <summary>
		/// 按 UrState（字段） 查询
		/// </summary>
		/// <param name = "urState"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrState(string urState, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Ur_id, Ur_no, Ur_Name, Ur_UserName, Ur_PassWord, Ur_zone, Ur_people, Ur_Contact, Ur_addTime, Ur_percent, Ur_bankName, Ur_bank, Ur_bankNo, Ur_introducer, Ur_state, Ur_del, Ur_errorlogin, Ur_lockTime, Ur_lockBindIp, Ur_text1, Ur_text2 FROM organize WHERE Ur_state=@UrState";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@UrState", urState, DbType.String, 3)
							.ExecList<OrganizeEO>(OrganizeEO.GetItem, tm);
		}

		#endregion

		#region  按 UrDel（字段） 查询

		/// <summary>
		/// 按 UrDel（字段） 查询
		/// </summary>
		/// <param name = "urDel"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrDel(string urDel)
		{
			return GetByUrDel(urDel, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 UrDel（字段） 查询
		/// </summary>
		/// <param name = "urDel"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrDel(string urDel, TransactionManager tm)
		{
			return GetByUrDel(urDel, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 UrDel（字段） 查询
		/// </summary>
		/// <param name = "urDel"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrDel(string urDel, int top)
		{
			return GetByUrDel(urDel, top, string.Empty, null);
		}

		/// <summary>
		/// 按 UrDel（字段） 查询
		/// </summary>
		/// <param name = "urDel"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrDel(string urDel, int top, TransactionManager tm)
		{
			return GetByUrDel(urDel, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 UrDel（字段） 查询
		/// </summary>
		/// <param name = "urDel"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrDel(string urDel, string sort)
		{
			return GetByUrDel(urDel, 0, sort, null);
		}

		/// <summary>
		/// 按 UrDel（字段） 查询
		/// </summary>
		/// <param name = "urDel"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrDel(string urDel, string sort, TransactionManager tm)
		{
			return GetByUrDel(urDel, 0, sort, tm);
		}

		/// <summary>
		/// 按 UrDel（字段） 查询
		/// </summary>
		/// <param name = "urDel"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrDel(string urDel, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Ur_id, Ur_no, Ur_Name, Ur_UserName, Ur_PassWord, Ur_zone, Ur_people, Ur_Contact, Ur_addTime, Ur_percent, Ur_bankName, Ur_bank, Ur_bankNo, Ur_introducer, Ur_state, Ur_del, Ur_errorlogin, Ur_lockTime, Ur_lockBindIp, Ur_text1, Ur_text2 FROM organize WHERE Ur_del=@UrDel";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@UrDel", urDel, DbType.String, 3)
							.ExecList<OrganizeEO>(OrganizeEO.GetItem, tm);
		}

		#endregion

		#region  按 UrErrorlogin（字段） 查询

		/// <summary>
		/// 按 UrErrorlogin（字段） 查询
		/// </summary>
		/// <param name = "urErrorlogin"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrErrorlogin(string urErrorlogin)
		{
			return GetByUrErrorlogin(urErrorlogin, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 UrErrorlogin（字段） 查询
		/// </summary>
		/// <param name = "urErrorlogin"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrErrorlogin(string urErrorlogin, TransactionManager tm)
		{
			return GetByUrErrorlogin(urErrorlogin, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 UrErrorlogin（字段） 查询
		/// </summary>
		/// <param name = "urErrorlogin"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrErrorlogin(string urErrorlogin, int top)
		{
			return GetByUrErrorlogin(urErrorlogin, top, string.Empty, null);
		}

		/// <summary>
		/// 按 UrErrorlogin（字段） 查询
		/// </summary>
		/// <param name = "urErrorlogin"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrErrorlogin(string urErrorlogin, int top, TransactionManager tm)
		{
			return GetByUrErrorlogin(urErrorlogin, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 UrErrorlogin（字段） 查询
		/// </summary>
		/// <param name = "urErrorlogin"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrErrorlogin(string urErrorlogin, string sort)
		{
			return GetByUrErrorlogin(urErrorlogin, 0, sort, null);
		}

		/// <summary>
		/// 按 UrErrorlogin（字段） 查询
		/// </summary>
		/// <param name = "urErrorlogin"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrErrorlogin(string urErrorlogin, string sort, TransactionManager tm)
		{
			return GetByUrErrorlogin(urErrorlogin, 0, sort, tm);
		}

		/// <summary>
		/// 按 UrErrorlogin（字段） 查询
		/// </summary>
		/// <param name = "urErrorlogin"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrErrorlogin(string urErrorlogin, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Ur_id, Ur_no, Ur_Name, Ur_UserName, Ur_PassWord, Ur_zone, Ur_people, Ur_Contact, Ur_addTime, Ur_percent, Ur_bankName, Ur_bank, Ur_bankNo, Ur_introducer, Ur_state, Ur_del, Ur_errorlogin, Ur_lockTime, Ur_lockBindIp, Ur_text1, Ur_text2 FROM organize WHERE Ur_errorlogin=@UrErrorlogin";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@UrErrorlogin", urErrorlogin, DbType.String, 300)
							.ExecList<OrganizeEO>(OrganizeEO.GetItem, tm);
		}

		#endregion

		#region  按 UrLockTime（字段） 查询

		/// <summary>
		/// 按 UrLockTime（字段） 查询
		/// </summary>
		/// <param name = "urLockTime"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrLockTime(DateTime urLockTime)
		{
			return GetByUrLockTime(urLockTime, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 UrLockTime（字段） 查询
		/// </summary>
		/// <param name = "urLockTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrLockTime(DateTime urLockTime, TransactionManager tm)
		{
			return GetByUrLockTime(urLockTime, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 UrLockTime（字段） 查询
		/// </summary>
		/// <param name = "urLockTime"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrLockTime(DateTime urLockTime, int top)
		{
			return GetByUrLockTime(urLockTime, top, string.Empty, null);
		}

		/// <summary>
		/// 按 UrLockTime（字段） 查询
		/// </summary>
		/// <param name = "urLockTime"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrLockTime(DateTime urLockTime, int top, TransactionManager tm)
		{
			return GetByUrLockTime(urLockTime, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 UrLockTime（字段） 查询
		/// </summary>
		/// <param name = "urLockTime"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrLockTime(DateTime urLockTime, string sort)
		{
			return GetByUrLockTime(urLockTime, 0, sort, null);
		}

		/// <summary>
		/// 按 UrLockTime（字段） 查询
		/// </summary>
		/// <param name = "urLockTime"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrLockTime(DateTime urLockTime, string sort, TransactionManager tm)
		{
			return GetByUrLockTime(urLockTime, 0, sort, tm);
		}

		/// <summary>
		/// 按 UrLockTime（字段） 查询
		/// </summary>
		/// <param name = "urLockTime"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrLockTime(DateTime urLockTime, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Ur_id, Ur_no, Ur_Name, Ur_UserName, Ur_PassWord, Ur_zone, Ur_people, Ur_Contact, Ur_addTime, Ur_percent, Ur_bankName, Ur_bank, Ur_bankNo, Ur_introducer, Ur_state, Ur_del, Ur_errorlogin, Ur_lockTime, Ur_lockBindIp, Ur_text1, Ur_text2 FROM organize WHERE Ur_lockTime=@UrLockTime";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@UrLockTime", urLockTime, DbType.DateTime, 0)
							.ExecList<OrganizeEO>(OrganizeEO.GetItem, tm);
		}

		#endregion

		#region  按 UrLockBindIp（字段） 查询

		/// <summary>
		/// 按 UrLockBindIp（字段） 查询
		/// </summary>
		/// <param name = "urLockBindIp"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrLockBindIp(string urLockBindIp)
		{
			return GetByUrLockBindIp(urLockBindIp, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 UrLockBindIp（字段） 查询
		/// </summary>
		/// <param name = "urLockBindIp"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrLockBindIp(string urLockBindIp, TransactionManager tm)
		{
			return GetByUrLockBindIp(urLockBindIp, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 UrLockBindIp（字段） 查询
		/// </summary>
		/// <param name = "urLockBindIp"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrLockBindIp(string urLockBindIp, int top)
		{
			return GetByUrLockBindIp(urLockBindIp, top, string.Empty, null);
		}

		/// <summary>
		/// 按 UrLockBindIp（字段） 查询
		/// </summary>
		/// <param name = "urLockBindIp"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrLockBindIp(string urLockBindIp, int top, TransactionManager tm)
		{
			return GetByUrLockBindIp(urLockBindIp, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 UrLockBindIp（字段） 查询
		/// </summary>
		/// <param name = "urLockBindIp"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrLockBindIp(string urLockBindIp, string sort)
		{
			return GetByUrLockBindIp(urLockBindIp, 0, sort, null);
		}

		/// <summary>
		/// 按 UrLockBindIp（字段） 查询
		/// </summary>
		/// <param name = "urLockBindIp"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrLockBindIp(string urLockBindIp, string sort, TransactionManager tm)
		{
			return GetByUrLockBindIp(urLockBindIp, 0, sort, tm);
		}

		/// <summary>
		/// 按 UrLockBindIp（字段） 查询
		/// </summary>
		/// <param name = "urLockBindIp"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrLockBindIp(string urLockBindIp, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Ur_id, Ur_no, Ur_Name, Ur_UserName, Ur_PassWord, Ur_zone, Ur_people, Ur_Contact, Ur_addTime, Ur_percent, Ur_bankName, Ur_bank, Ur_bankNo, Ur_introducer, Ur_state, Ur_del, Ur_errorlogin, Ur_lockTime, Ur_lockBindIp, Ur_text1, Ur_text2 FROM organize WHERE Ur_lockBindIp=@UrLockBindIp";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@UrLockBindIp", urLockBindIp, DbType.String, 765)
							.ExecList<OrganizeEO>(OrganizeEO.GetItem, tm);
		}

		#endregion

		#region  按 UrText1（字段） 查询

		/// <summary>
		/// 按 UrText1（字段） 查询
		/// </summary>
		/// <param name = "urText1"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrText1(string urText1)
		{
			return GetByUrText1(urText1, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 UrText1（字段） 查询
		/// </summary>
		/// <param name = "urText1"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrText1(string urText1, TransactionManager tm)
		{
			return GetByUrText1(urText1, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 UrText1（字段） 查询
		/// </summary>
		/// <param name = "urText1"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrText1(string urText1, int top)
		{
			return GetByUrText1(urText1, top, string.Empty, null);
		}

		/// <summary>
		/// 按 UrText1（字段） 查询
		/// </summary>
		/// <param name = "urText1"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrText1(string urText1, int top, TransactionManager tm)
		{
			return GetByUrText1(urText1, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 UrText1（字段） 查询
		/// </summary>
		/// <param name = "urText1"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrText1(string urText1, string sort)
		{
			return GetByUrText1(urText1, 0, sort, null);
		}

		/// <summary>
		/// 按 UrText1（字段） 查询
		/// </summary>
		/// <param name = "urText1"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrText1(string urText1, string sort, TransactionManager tm)
		{
			return GetByUrText1(urText1, 0, sort, tm);
		}

		/// <summary>
		/// 按 UrText1（字段） 查询
		/// </summary>
		/// <param name = "urText1"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrText1(string urText1, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Ur_id, Ur_no, Ur_Name, Ur_UserName, Ur_PassWord, Ur_zone, Ur_people, Ur_Contact, Ur_addTime, Ur_percent, Ur_bankName, Ur_bank, Ur_bankNo, Ur_introducer, Ur_state, Ur_del, Ur_errorlogin, Ur_lockTime, Ur_lockBindIp, Ur_text1, Ur_text2 FROM organize WHERE Ur_text1=@UrText1";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@UrText1", urText1, DbType.String, 300)
							.ExecList<OrganizeEO>(OrganizeEO.GetItem, tm);
		}

		#endregion

		#region  按 UrText2（字段） 查询

		/// <summary>
		/// 按 UrText2（字段） 查询
		/// </summary>
		/// <param name = "urText2"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrText2(string urText2)
		{
			return GetByUrText2(urText2, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 UrText2（字段） 查询
		/// </summary>
		/// <param name = "urText2"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrText2(string urText2, TransactionManager tm)
		{
			return GetByUrText2(urText2, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 UrText2（字段） 查询
		/// </summary>
		/// <param name = "urText2"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrText2(string urText2, int top)
		{
			return GetByUrText2(urText2, top, string.Empty, null);
		}

		/// <summary>
		/// 按 UrText2（字段） 查询
		/// </summary>
		/// <param name = "urText2"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrText2(string urText2, int top, TransactionManager tm)
		{
			return GetByUrText2(urText2, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 UrText2（字段） 查询
		/// </summary>
		/// <param name = "urText2"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrText2(string urText2, string sort)
		{
			return GetByUrText2(urText2, 0, sort, null);
		}

		/// <summary>
		/// 按 UrText2（字段） 查询
		/// </summary>
		/// <param name = "urText2"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrText2(string urText2, string sort, TransactionManager tm)
		{
			return GetByUrText2(urText2, 0, sort, tm);
		}

		/// <summary>
		/// 按 UrText2（字段） 查询
		/// </summary>
		/// <param name = "urText2"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetByUrText2(string urText2, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Ur_id, Ur_no, Ur_Name, Ur_UserName, Ur_PassWord, Ur_zone, Ur_people, Ur_Contact, Ur_addTime, Ur_percent, Ur_bankName, Ur_bank, Ur_bankNo, Ur_introducer, Ur_state, Ur_del, Ur_errorlogin, Ur_lockTime, Ur_lockBindIp, Ur_text1, Ur_text2 FROM organize WHERE Ur_text2=@UrText2";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@UrText2", urText2, DbType.String, 300)
							.ExecList<OrganizeEO>(OrganizeEO.GetItem, tm);
		}

		#endregion

		#region  自定义条件查询

		/// <summary>
		/// 获取所有数据
		/// </summary>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetAll(TransactionManager tm = null)
		{
			return GetTopSort(string.Empty, null, -1, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "values">where子句中定义的参数值集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> Get(string where, params object[] values)
		{
			return GetTopSort(where, -1, string.Empty, null, values);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "paras">where子句中定义的参数集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> Get(string where, IEnumerable<DbParameter> paras)
		{
			return GetTopSort(where, paras, -1, string.Empty, null);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> Get(string where, TransactionManager tm)
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
		public virtual IEnumerable<OrganizeEO> Get(string where, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<OrganizeEO> Get(string where, IEnumerable<DbParameter> paras, TransactionManager tm)
		{
			return GetTopSort(where, paras, -1, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetTop(string where, int top)
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
		public virtual IEnumerable<OrganizeEO> GetTop(string where, int top, params object[] values)
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
		public virtual IEnumerable<OrganizeEO> GetTop(string where, IEnumerable<DbParameter> paras, int top)
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
		public virtual IEnumerable<OrganizeEO> GetTop(string where, int top, TransactionManager tm)
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
		public virtual IEnumerable<OrganizeEO> GetTop(string where, int top, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<OrganizeEO> GetTop(string where, IEnumerable<DbParameter> paras, int top, TransactionManager tm)
		{
			return GetTopSort(where, paras, top, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<OrganizeEO> GetSort(string where, string sort)
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
		public virtual IEnumerable<OrganizeEO> GetSort(string where, string sort, params object[] values)
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
		public virtual IEnumerable<OrganizeEO> GetSort(string where, IEnumerable<DbParameter> paras, string sort)
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
		public virtual IEnumerable<OrganizeEO> GetSort(string where, string sort, TransactionManager tm)
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
		public virtual IEnumerable<OrganizeEO> GetSort(string where, string sort, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<OrganizeEO> GetSort(string where, IEnumerable<DbParameter> paras, string sort, TransactionManager tm)
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
		public virtual IEnumerable<OrganizeEO> GetTopSort(string where, int top, string sort)
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
		public virtual IEnumerable<OrganizeEO> GetTopSort(string where, int top, string sort, params object[] values)
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
		public virtual IEnumerable<OrganizeEO> GetTopSort(string where, IEnumerable<DbParameter> paras, int top, string sort)
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
		public virtual IEnumerable<OrganizeEO> GetTopSort(string where, int top, string sort, TransactionManager tm)
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
		public virtual IEnumerable<OrganizeEO> GetTopSort(string where, int top, string sort, TransactionManager tm, params object[] values)
		{
			const string format = @"SELECT {0} Ur_id, Ur_no, Ur_Name, Ur_UserName, Ur_PassWord, Ur_zone, Ur_people, Ur_Contact, Ur_addTime, Ur_percent, Ur_bankName, Ur_bank, Ur_bankNo, Ur_introducer, Ur_state, Ur_del, Ur_errorlogin, Ur_lockTime, Ur_lockBindIp, Ur_text1, Ur_text2 FROM organize";
			string sql = format;

			if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameters(values)
							.ExecList<OrganizeEO>(OrganizeEO.GetItem, tm);
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
		public virtual IEnumerable<OrganizeEO> GetTopSort(string where, IEnumerable<DbParameter> paras, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} Ur_id, Ur_no, Ur_Name, Ur_UserName, Ur_PassWord, Ur_zone, Ur_people, Ur_Contact, Ur_addTime, Ur_percent, Ur_bankName, Ur_bank, Ur_bankNo, Ur_introducer, Ur_state, Ur_del, Ur_errorlogin, Ur_lockTime, Ur_lockBindIp, Ur_text1, Ur_text2 FROM organize";
			string sql = format;

			if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddParameters(paras)
							.ExecList<OrganizeEO>(OrganizeEO.GetItem, tm);
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
			const string format = @"SELECT Ur_id, Ur_no, Ur_Name, Ur_UserName, Ur_PassWord, Ur_zone, Ur_people, Ur_Contact, Ur_addTime, Ur_percent, Ur_bankName, Ur_bank, Ur_bankNo, Ur_introducer, Ur_state, Ur_del, Ur_errorlogin, Ur_lockTime, Ur_lockBindIp, Ur_text1, Ur_text2 FROM organize {0} {1}";
			 string sql = string.Format(format, string.IsNullOrEmpty(where) ? string.Empty : "WHERE " + where, string.IsNullOrEmpty(sort) ? string.Empty : "ORDER BY " + sort);

			return Database.CreatePager(sql, pageSize, "Ur_id");
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
		public virtual List<OrganizeEO> GetPageList(int pageIndex , int pageSize, string where = null, string sort = null, IEnumerable<DbParameter> paras = null)
		{
			var pager = GetPager(pageSize, where, sort);

			pager.AddParameters(paras);
			return pager.GetPageList<OrganizeEO>(pageIndex);
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
		public virtual IEnumerable<OrganizeEO> GetPageMutil(int pageIndex , int pageSize, string where = null, string sort = null, IEnumerable<DbParameter> paras = null)
		{
			var pager = GetPager(pageSize, where, sort);

			pager.AddParameters(paras);
			return pager.GetPageMutil<OrganizeEO>(pageIndex);
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
		public virtual int Add(OrganizeEO item, TransactionManager tm = null)
		{
			const string sql = @"INSERT INTO organize (Ur_id, Ur_no, Ur_Name, Ur_UserName, Ur_PassWord, Ur_zone, Ur_people, Ur_Contact, Ur_addTime, Ur_percent, Ur_bankName, Ur_bank, Ur_bankNo, Ur_introducer, Ur_state, Ur_del, Ur_errorlogin, Ur_lockTime, Ur_lockBindIp, Ur_text1, Ur_text2) VALUES (@Ur_id, @Ur_no, @Ur_Name, @Ur_UserName, @Ur_PassWord, @Ur_zone, @Ur_people, @Ur_Contact, @Ur_addTime, @Ur_percent, @Ur_bankName, @Ur_bank, @Ur_bankNo, @Ur_introducer, @Ur_state, @Ur_del, @Ur_errorlogin, @Ur_lockTime, @Ur_lockBindIp, @Ur_text1, @Ur_text2) ";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_id", item.UrId, DbType.String, 150)
							.AddInParameter("@Ur_no", item.UrNo, DbType.String, 150)
							.AddInParameter("@Ur_Name", item.UrName != null ?  (object)item.UrName : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Ur_UserName", item.UrUserName != null ?  (object)item.UrUserName : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Ur_PassWord", item.UrPassWord != null ?  (object)item.UrPassWord : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Ur_zone", item.UrZone != null ?  (object)item.UrZone : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Ur_people", item.UrPeople != null ?  (object)item.UrPeople : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Ur_Contact", item.UrContact != null ?  (object)item.UrContact : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Ur_addTime", item.UrAddTime, DbType.DateTime, 0)
							.AddInParameter("@Ur_percent", item.UrPercent != null ?  (object)item.UrPercent : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Ur_bankName", item.UrBankName != null ?  (object)item.UrBankName : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Ur_bank", item.UrBank != null ?  (object)item.UrBank : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Ur_bankNo", item.UrBankNo != null ?  (object)item.UrBankNo : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Ur_introducer", item.UrIntroducer != null ?  (object)item.UrIntroducer : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Ur_state", item.UrState != null ?  (object)item.UrState : DBNull.Value, DbType.String, 3)
							.AddInParameter("@Ur_del", item.UrDel != null ?  (object)item.UrDel : DBNull.Value, DbType.String, 3)
							.AddInParameter("@Ur_errorlogin", item.UrErrorlogin != null ?  (object)item.UrErrorlogin : DBNull.Value, DbType.String, 300)
							.AddInParameter("@Ur_lockTime", item.UrLockTime, DbType.DateTime, 0)
							.AddInParameter("@Ur_lockBindIp", item.UrLockBindIp != null ?  (object)item.UrLockBindIp : DBNull.Value, DbType.String, 765)
							.AddInParameter("@Ur_text1", item.UrText1 != null ?  (object)item.UrText1 : DBNull.Value, DbType.String, 300)
							.AddInParameter("@Ur_text2", item.UrText2 != null ?  (object)item.UrText2 : DBNull.Value, DbType.String, 300)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 插入一组数据
		/// </summary>
		/// <param name = "items">要插入的实体对象集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Add(IEnumerable<OrganizeEO> items, TransactionManager tm = null)
		{
			int ret = 0;
			const string sql = @"INSERT INTO organize (Ur_id, Ur_no, Ur_Name, Ur_UserName, Ur_PassWord, Ur_zone, Ur_people, Ur_Contact, Ur_addTime, Ur_percent, Ur_bankName, Ur_bank, Ur_bankNo, Ur_introducer, Ur_state, Ur_del, Ur_errorlogin, Ur_lockTime, Ur_lockBindIp, Ur_text1, Ur_text2) VALUES (@Ur_id, @Ur_no, @Ur_Name, @Ur_UserName, @Ur_PassWord, @Ur_zone, @Ur_people, @Ur_Contact, @Ur_addTime, @Ur_percent, @Ur_bankName, @Ur_bank, @Ur_bankNo, @Ur_introducer, @Ur_state, @Ur_del, @Ur_errorlogin, @Ur_lockTime, @Ur_lockBindIp, @Ur_text1, @Ur_text2) ";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@Ur_id", DbType.String, 150)
									.AddParameter("@Ur_no", DbType.String, 150)
									.AddParameter("@Ur_Name", DbType.String, 150)
									.AddParameter("@Ur_UserName", DbType.String, 150)
									.AddParameter("@Ur_PassWord", DbType.String, 150)
									.AddParameter("@Ur_zone", DbType.String, 150)
									.AddParameter("@Ur_people", DbType.String, 150)
									.AddParameter("@Ur_Contact", DbType.String, 150)
									.AddParameter("@Ur_addTime", DbType.DateTime, 0)
									.AddParameter("@Ur_percent", DbType.String, 150)
									.AddParameter("@Ur_bankName", DbType.String, 150)
									.AddParameter("@Ur_bank", DbType.String, 150)
									.AddParameter("@Ur_bankNo", DbType.String, 150)
									.AddParameter("@Ur_introducer", DbType.String, 150)
									.AddParameter("@Ur_state", DbType.String, 3)
									.AddParameter("@Ur_del", DbType.String, 3)
									.AddParameter("@Ur_errorlogin", DbType.String, 300)
									.AddParameter("@Ur_lockTime", DbType.DateTime, 0)
									.AddParameter("@Ur_lockBindIp", DbType.String, 765)
									.AddParameter("@Ur_text1", DbType.String, 300)
									.AddParameter("@Ur_text2", DbType.String, 300);

			foreach (OrganizeEO item in items)
			{
				sqlDao
					.SetParameterValue("@Ur_id", item.UrId)
					.SetParameterValue("@Ur_no", item.UrNo)
					.SetParameterValue("@Ur_Name", item.UrName != null ?  (object)item.UrName : DBNull.Value)
					.SetParameterValue("@Ur_UserName", item.UrUserName != null ?  (object)item.UrUserName : DBNull.Value)
					.SetParameterValue("@Ur_PassWord", item.UrPassWord != null ?  (object)item.UrPassWord : DBNull.Value)
					.SetParameterValue("@Ur_zone", item.UrZone != null ?  (object)item.UrZone : DBNull.Value)
					.SetParameterValue("@Ur_people", item.UrPeople != null ?  (object)item.UrPeople : DBNull.Value)
					.SetParameterValue("@Ur_Contact", item.UrContact != null ?  (object)item.UrContact : DBNull.Value)
					.SetParameterValue("@Ur_addTime", item.UrAddTime)
					.SetParameterValue("@Ur_percent", item.UrPercent != null ?  (object)item.UrPercent : DBNull.Value)
					.SetParameterValue("@Ur_bankName", item.UrBankName != null ?  (object)item.UrBankName : DBNull.Value)
					.SetParameterValue("@Ur_bank", item.UrBank != null ?  (object)item.UrBank : DBNull.Value)
					.SetParameterValue("@Ur_bankNo", item.UrBankNo != null ?  (object)item.UrBankNo : DBNull.Value)
					.SetParameterValue("@Ur_introducer", item.UrIntroducer != null ?  (object)item.UrIntroducer : DBNull.Value)
					.SetParameterValue("@Ur_state", item.UrState != null ?  (object)item.UrState : DBNull.Value)
					.SetParameterValue("@Ur_del", item.UrDel != null ?  (object)item.UrDel : DBNull.Value)
					.SetParameterValue("@Ur_errorlogin", item.UrErrorlogin != null ?  (object)item.UrErrorlogin : DBNull.Value)
					.SetParameterValue("@Ur_lockTime", item.UrLockTime)
					.SetParameterValue("@Ur_lockBindIp", item.UrLockBindIp != null ?  (object)item.UrLockBindIp : DBNull.Value)
					.SetParameterValue("@Ur_text1", item.UrText1 != null ?  (object)item.UrText1 : DBNull.Value)
					.SetParameterValue("@Ur_text2", item.UrText2 != null ?  (object)item.UrText2 : DBNull.Value)
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
		public virtual int Put(OrganizeEO item, TransactionManager tm = null)
		{
			const string sql = @"UPDATE organize SET Ur_id=@Ur_id, Ur_no=@Ur_no, Ur_Name=@Ur_Name, Ur_UserName=@Ur_UserName, Ur_PassWord=@Ur_PassWord, Ur_zone=@Ur_zone, Ur_people=@Ur_people, Ur_Contact=@Ur_Contact, Ur_addTime=@Ur_addTime, Ur_percent=@Ur_percent, Ur_bankName=@Ur_bankName, Ur_bank=@Ur_bank, Ur_bankNo=@Ur_bankNo, Ur_introducer=@Ur_introducer, Ur_state=@Ur_state, Ur_del=@Ur_del, Ur_errorlogin=@Ur_errorlogin, Ur_lockTime=@Ur_lockTime, Ur_lockBindIp=@Ur_lockBindIp, Ur_text1=@Ur_text1, Ur_text2=@Ur_text2 WHERE Ur_id=@OriginalUr_id";
			return Database.CreateSqlDao (sql)
							.AddInParameter("@OriginalUrId", (item.HasOriginal) ? item.OriginalUrId : item.UrId, DbType.String, 150)
							.AddInParameter("@Ur_id", item.UrId, DbType.String, 150)
							.AddInParameter("@Ur_no", item.UrNo, DbType.String, 150)
							.AddInParameter("@Ur_Name", item.UrName != null ?  (object)item.UrName : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Ur_UserName", item.UrUserName != null ?  (object)item.UrUserName : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Ur_PassWord", item.UrPassWord != null ?  (object)item.UrPassWord : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Ur_zone", item.UrZone != null ?  (object)item.UrZone : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Ur_people", item.UrPeople != null ?  (object)item.UrPeople : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Ur_Contact", item.UrContact != null ?  (object)item.UrContact : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Ur_addTime", item.UrAddTime, DbType.DateTime, 0)
							.AddInParameter("@Ur_percent", item.UrPercent != null ?  (object)item.UrPercent : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Ur_bankName", item.UrBankName != null ?  (object)item.UrBankName : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Ur_bank", item.UrBank != null ?  (object)item.UrBank : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Ur_bankNo", item.UrBankNo != null ?  (object)item.UrBankNo : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Ur_introducer", item.UrIntroducer != null ?  (object)item.UrIntroducer : DBNull.Value, DbType.String, 150)
							.AddInParameter("@Ur_state", item.UrState != null ?  (object)item.UrState : DBNull.Value, DbType.String, 3)
							.AddInParameter("@Ur_del", item.UrDel != null ?  (object)item.UrDel : DBNull.Value, DbType.String, 3)
							.AddInParameter("@Ur_errorlogin", item.UrErrorlogin != null ?  (object)item.UrErrorlogin : DBNull.Value, DbType.String, 300)
							.AddInParameter("@Ur_lockTime", item.UrLockTime, DbType.DateTime, 0)
							.AddInParameter("@Ur_lockBindIp", item.UrLockBindIp != null ?  (object)item.UrLockBindIp : DBNull.Value, DbType.String, 765)
							.AddInParameter("@Ur_text1", item.UrText1 != null ?  (object)item.UrText1 : DBNull.Value, DbType.String, 300)
							.AddInParameter("@Ur_text2", item.UrText2 != null ?  (object)item.UrText2 : DBNull.Value, DbType.String, 300)
							.ExecNonQuery(tm);
		}


		/// <summary>
		/// 更新数据
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Put(IEnumerable<OrganizeEO> items, TransactionManager tm = null)
		{

			int ret = 0;
			const string sql = @"UPDATE organize SET Ur_id=@Ur_id, Ur_no=@Ur_no, Ur_Name=@Ur_Name, Ur_UserName=@Ur_UserName, Ur_PassWord=@Ur_PassWord, Ur_zone=@Ur_zone, Ur_people=@Ur_people, Ur_Contact=@Ur_Contact, Ur_addTime=@Ur_addTime, Ur_percent=@Ur_percent, Ur_bankName=@Ur_bankName, Ur_bank=@Ur_bank, Ur_bankNo=@Ur_bankNo, Ur_introducer=@Ur_introducer, Ur_state=@Ur_state, Ur_del=@Ur_del, Ur_errorlogin=@Ur_errorlogin, Ur_lockTime=@Ur_lockTime, Ur_lockBindIp=@Ur_lockBindIp, Ur_text1=@Ur_text1, Ur_text2=@Ur_text2 WHERE Ur_id=@OriginalUr_id";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@OriginalUrId", DbType.String, 150)
									.AddParameter("@Ur_id", DbType.String, 150)
									.AddParameter("@Ur_no", DbType.String, 150)
									.AddParameter("@Ur_Name", DbType.String, 150)
									.AddParameter("@Ur_UserName", DbType.String, 150)
									.AddParameter("@Ur_PassWord", DbType.String, 150)
									.AddParameter("@Ur_zone", DbType.String, 150)
									.AddParameter("@Ur_people", DbType.String, 150)
									.AddParameter("@Ur_Contact", DbType.String, 150)
									.AddParameter("@Ur_addTime", DbType.DateTime, 0)
									.AddParameter("@Ur_percent", DbType.String, 150)
									.AddParameter("@Ur_bankName", DbType.String, 150)
									.AddParameter("@Ur_bank", DbType.String, 150)
									.AddParameter("@Ur_bankNo", DbType.String, 150)
									.AddParameter("@Ur_introducer", DbType.String, 150)
									.AddParameter("@Ur_state", DbType.String, 3)
									.AddParameter("@Ur_del", DbType.String, 3)
									.AddParameter("@Ur_errorlogin", DbType.String, 300)
									.AddParameter("@Ur_lockTime", DbType.DateTime, 0)
									.AddParameter("@Ur_lockBindIp", DbType.String, 765)
									.AddParameter("@Ur_text1", DbType.String, 300)
									.AddParameter("@Ur_text2", DbType.String, 300);

			foreach (OrganizeEO item in items)
			{
				ret += sqlDao
							.SetParameterValue("@OriginalUrId", (item.HasOriginal) ? item.OriginalUrId : item.UrId)
							.SetParameterValue("@Ur_id", item.UrId)
							.SetParameterValue("@Ur_no", item.UrNo)
							.SetParameterValue("@Ur_Name", item.UrName != null ?  (object)item.UrName : DBNull.Value)
							.SetParameterValue("@Ur_UserName", item.UrUserName != null ?  (object)item.UrUserName : DBNull.Value)
							.SetParameterValue("@Ur_PassWord", item.UrPassWord != null ?  (object)item.UrPassWord : DBNull.Value)
							.SetParameterValue("@Ur_zone", item.UrZone != null ?  (object)item.UrZone : DBNull.Value)
							.SetParameterValue("@Ur_people", item.UrPeople != null ?  (object)item.UrPeople : DBNull.Value)
							.SetParameterValue("@Ur_Contact", item.UrContact != null ?  (object)item.UrContact : DBNull.Value)
							.SetParameterValue("@Ur_addTime", item.UrAddTime)
							.SetParameterValue("@Ur_percent", item.UrPercent != null ?  (object)item.UrPercent : DBNull.Value)
							.SetParameterValue("@Ur_bankName", item.UrBankName != null ?  (object)item.UrBankName : DBNull.Value)
							.SetParameterValue("@Ur_bank", item.UrBank != null ?  (object)item.UrBank : DBNull.Value)
							.SetParameterValue("@Ur_bankNo", item.UrBankNo != null ?  (object)item.UrBankNo : DBNull.Value)
							.SetParameterValue("@Ur_introducer", item.UrIntroducer != null ?  (object)item.UrIntroducer : DBNull.Value)
							.SetParameterValue("@Ur_state", item.UrState != null ?  (object)item.UrState : DBNull.Value)
							.SetParameterValue("@Ur_del", item.UrDel != null ?  (object)item.UrDel : DBNull.Value)
							.SetParameterValue("@Ur_errorlogin", item.UrErrorlogin != null ?  (object)item.UrErrorlogin : DBNull.Value)
							.SetParameterValue("@Ur_lockTime", item.UrLockTime)
							.SetParameterValue("@Ur_lockBindIp", item.UrLockBindIp != null ?  (object)item.UrLockBindIp : DBNull.Value)
							.SetParameterValue("@Ur_text1", item.UrText1 != null ?  (object)item.UrText1 : DBNull.Value)
							.SetParameterValue("@Ur_text2", item.UrText2 != null ?  (object)item.UrText2 : DBNull.Value)
							.ExecNonQuery(tm);
			}
			return ret;
		}


		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "urId"></param>
		/// <param name = "urNo"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutUrNoByPK(string urId, string urNo, TransactionManager tm = null)
		{
			const string sql = @"UPDATE organize SET Ur_no = @Ur_no  WHERE Ur_id = @Ur_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_id", urId, DbType.String, 150)
							.AddInParameter("@Ur_no", urNo, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "urId"></param>
		/// <param name = "urName"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutUrNameByPK(string urId, string urName, TransactionManager tm = null)
		{
			const string sql = @"UPDATE organize SET Ur_Name = @Ur_Name  WHERE Ur_id = @Ur_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_id", urId, DbType.String, 150)
							.AddInParameter("@Ur_Name", urName != null ?  (object)urName : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "urId"></param>
		/// <param name = "urUserName"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutUrUserNameByPK(string urId, string urUserName, TransactionManager tm = null)
		{
			const string sql = @"UPDATE organize SET Ur_UserName = @Ur_UserName  WHERE Ur_id = @Ur_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_id", urId, DbType.String, 150)
							.AddInParameter("@Ur_UserName", urUserName != null ?  (object)urUserName : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "urId"></param>
		/// <param name = "urPassWord"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutUrPassWordByPK(string urId, string urPassWord, TransactionManager tm = null)
		{
			const string sql = @"UPDATE organize SET Ur_PassWord = @Ur_PassWord  WHERE Ur_id = @Ur_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_id", urId, DbType.String, 150)
							.AddInParameter("@Ur_PassWord", urPassWord != null ?  (object)urPassWord : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "urId"></param>
		/// <param name = "urZone"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutUrZoneByPK(string urId, string urZone, TransactionManager tm = null)
		{
			const string sql = @"UPDATE organize SET Ur_zone = @Ur_zone  WHERE Ur_id = @Ur_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_id", urId, DbType.String, 150)
							.AddInParameter("@Ur_zone", urZone != null ?  (object)urZone : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "urId"></param>
		/// <param name = "urPeople"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutUrPeopleByPK(string urId, string urPeople, TransactionManager tm = null)
		{
			const string sql = @"UPDATE organize SET Ur_people = @Ur_people  WHERE Ur_id = @Ur_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_id", urId, DbType.String, 150)
							.AddInParameter("@Ur_people", urPeople != null ?  (object)urPeople : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "urId"></param>
		/// <param name = "urContact"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutUrContactByPK(string urId, string urContact, TransactionManager tm = null)
		{
			const string sql = @"UPDATE organize SET Ur_Contact = @Ur_Contact  WHERE Ur_id = @Ur_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_id", urId, DbType.String, 150)
							.AddInParameter("@Ur_Contact", urContact != null ?  (object)urContact : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "urId"></param>
		/// <param name = "urAddTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutUrAddTimeByPK(string urId, DateTime urAddTime, TransactionManager tm = null)
		{
			const string sql = @"UPDATE organize SET Ur_addTime = @Ur_addTime  WHERE Ur_id = @Ur_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_id", urId, DbType.String, 150)
							.AddInParameter("@Ur_addTime", urAddTime, DbType.DateTime, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "urId"></param>
		/// <param name = "urPercent"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutUrPercentByPK(string urId, string urPercent, TransactionManager tm = null)
		{
			const string sql = @"UPDATE organize SET Ur_percent = @Ur_percent  WHERE Ur_id = @Ur_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_id", urId, DbType.String, 150)
							.AddInParameter("@Ur_percent", urPercent != null ?  (object)urPercent : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "urId"></param>
		/// <param name = "urBankName"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutUrBankNameByPK(string urId, string urBankName, TransactionManager tm = null)
		{
			const string sql = @"UPDATE organize SET Ur_bankName = @Ur_bankName  WHERE Ur_id = @Ur_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_id", urId, DbType.String, 150)
							.AddInParameter("@Ur_bankName", urBankName != null ?  (object)urBankName : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "urId"></param>
		/// <param name = "urBank"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutUrBankByPK(string urId, string urBank, TransactionManager tm = null)
		{
			const string sql = @"UPDATE organize SET Ur_bank = @Ur_bank  WHERE Ur_id = @Ur_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_id", urId, DbType.String, 150)
							.AddInParameter("@Ur_bank", urBank != null ?  (object)urBank : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "urId"></param>
		/// <param name = "urBankNo"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutUrBankNoByPK(string urId, string urBankNo, TransactionManager tm = null)
		{
			const string sql = @"UPDATE organize SET Ur_bankNo = @Ur_bankNo  WHERE Ur_id = @Ur_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_id", urId, DbType.String, 150)
							.AddInParameter("@Ur_bankNo", urBankNo != null ?  (object)urBankNo : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "urId"></param>
		/// <param name = "urIntroducer"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutUrIntroducerByPK(string urId, string urIntroducer, TransactionManager tm = null)
		{
			const string sql = @"UPDATE organize SET Ur_introducer = @Ur_introducer  WHERE Ur_id = @Ur_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_id", urId, DbType.String, 150)
							.AddInParameter("@Ur_introducer", urIntroducer != null ?  (object)urIntroducer : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "urId"></param>
		/// <param name = "urState"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutUrStateByPK(string urId, string urState, TransactionManager tm = null)
		{
			const string sql = @"UPDATE organize SET Ur_state = @Ur_state  WHERE Ur_id = @Ur_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_id", urId, DbType.String, 150)
							.AddInParameter("@Ur_state", urState != null ?  (object)urState : DBNull.Value, DbType.String, 3)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "urId"></param>
		/// <param name = "urDel"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutUrDelByPK(string urId, string urDel, TransactionManager tm = null)
		{
			const string sql = @"UPDATE organize SET Ur_del = @Ur_del  WHERE Ur_id = @Ur_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_id", urId, DbType.String, 150)
							.AddInParameter("@Ur_del", urDel != null ?  (object)urDel : DBNull.Value, DbType.String, 3)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "urId"></param>
		/// <param name = "urErrorlogin"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutUrErrorloginByPK(string urId, string urErrorlogin, TransactionManager tm = null)
		{
			const string sql = @"UPDATE organize SET Ur_errorlogin = @Ur_errorlogin  WHERE Ur_id = @Ur_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_id", urId, DbType.String, 150)
							.AddInParameter("@Ur_errorlogin", urErrorlogin != null ?  (object)urErrorlogin : DBNull.Value, DbType.String, 300)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "urId"></param>
		/// <param name = "urLockTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutUrLockTimeByPK(string urId, DateTime urLockTime, TransactionManager tm = null)
		{
			const string sql = @"UPDATE organize SET Ur_lockTime = @Ur_lockTime  WHERE Ur_id = @Ur_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_id", urId, DbType.String, 150)
							.AddInParameter("@Ur_lockTime", urLockTime, DbType.DateTime, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "urId"></param>
		/// <param name = "urLockBindIp"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutUrLockBindIpByPK(string urId, string urLockBindIp, TransactionManager tm = null)
		{
			const string sql = @"UPDATE organize SET Ur_lockBindIp = @Ur_lockBindIp  WHERE Ur_id = @Ur_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_id", urId, DbType.String, 150)
							.AddInParameter("@Ur_lockBindIp", urLockBindIp != null ?  (object)urLockBindIp : DBNull.Value, DbType.String, 765)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "urId"></param>
		/// <param name = "urText1"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutUrText1ByPK(string urId, string urText1, TransactionManager tm = null)
		{
			const string sql = @"UPDATE organize SET Ur_text1 = @Ur_text1  WHERE Ur_id = @Ur_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_id", urId, DbType.String, 150)
							.AddInParameter("@Ur_text1", urText1 != null ?  (object)urText1 : DBNull.Value, DbType.String, 300)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "urId"></param>
		/// <param name = "urText2"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutUrText2ByPK(string urId, string urText2, TransactionManager tm = null)
		{
			const string sql = @"UPDATE organize SET Ur_text2 = @Ur_text2  WHERE Ur_id = @Ur_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_id", urId, DbType.String, 150)
							.AddInParameter("@Ur_text2", urText2 != null ?  (object)urText2 : DBNull.Value, DbType.String, 300)
							.ExecNonQuery(tm);
		}


		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "urNo"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutUrNo(string urNo, TransactionManager tm = null)
		{
			const string sql = @"UPDATE organize SET Ur_no=@Ur_no";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_no", urNo, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "urName"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutUrName(string urName, TransactionManager tm = null)
		{
			const string sql = @"UPDATE organize SET Ur_Name=@Ur_Name";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_Name", urName != null ?  (object)urName : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "urUserName"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutUrUserName(string urUserName, TransactionManager tm = null)
		{
			const string sql = @"UPDATE organize SET Ur_UserName=@Ur_UserName";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_UserName", urUserName != null ?  (object)urUserName : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "urPassWord"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutUrPassWord(string urPassWord, TransactionManager tm = null)
		{
			const string sql = @"UPDATE organize SET Ur_PassWord=@Ur_PassWord";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_PassWord", urPassWord != null ?  (object)urPassWord : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "urZone"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutUrZone(string urZone, TransactionManager tm = null)
		{
			const string sql = @"UPDATE organize SET Ur_zone=@Ur_zone";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_zone", urZone != null ?  (object)urZone : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "urPeople"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutUrPeople(string urPeople, TransactionManager tm = null)
		{
			const string sql = @"UPDATE organize SET Ur_people=@Ur_people";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_people", urPeople != null ?  (object)urPeople : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "urContact"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutUrContact(string urContact, TransactionManager tm = null)
		{
			const string sql = @"UPDATE organize SET Ur_Contact=@Ur_Contact";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_Contact", urContact != null ?  (object)urContact : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "urAddTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutUrAddTime(DateTime urAddTime, TransactionManager tm = null)
		{
			const string sql = @"UPDATE organize SET Ur_addTime=@Ur_addTime";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_addTime", urAddTime, DbType.DateTime, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "urPercent"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutUrPercent(string urPercent, TransactionManager tm = null)
		{
			const string sql = @"UPDATE organize SET Ur_percent=@Ur_percent";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_percent", urPercent != null ?  (object)urPercent : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "urBankName"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutUrBankName(string urBankName, TransactionManager tm = null)
		{
			const string sql = @"UPDATE organize SET Ur_bankName=@Ur_bankName";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_bankName", urBankName != null ?  (object)urBankName : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "urBank"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutUrBank(string urBank, TransactionManager tm = null)
		{
			const string sql = @"UPDATE organize SET Ur_bank=@Ur_bank";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_bank", urBank != null ?  (object)urBank : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "urBankNo"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutUrBankNo(string urBankNo, TransactionManager tm = null)
		{
			const string sql = @"UPDATE organize SET Ur_bankNo=@Ur_bankNo";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_bankNo", urBankNo != null ?  (object)urBankNo : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "urIntroducer"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutUrIntroducer(string urIntroducer, TransactionManager tm = null)
		{
			const string sql = @"UPDATE organize SET Ur_introducer=@Ur_introducer";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_introducer", urIntroducer != null ?  (object)urIntroducer : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "urState"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutUrState(string urState, TransactionManager tm = null)
		{
			const string sql = @"UPDATE organize SET Ur_state=@Ur_state";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_state", urState != null ?  (object)urState : DBNull.Value, DbType.String, 3)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "urDel"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutUrDel(string urDel, TransactionManager tm = null)
		{
			const string sql = @"UPDATE organize SET Ur_del=@Ur_del";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_del", urDel != null ?  (object)urDel : DBNull.Value, DbType.String, 3)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "urErrorlogin"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutUrErrorlogin(string urErrorlogin, TransactionManager tm = null)
		{
			const string sql = @"UPDATE organize SET Ur_errorlogin=@Ur_errorlogin";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_errorlogin", urErrorlogin != null ?  (object)urErrorlogin : DBNull.Value, DbType.String, 300)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "urLockTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutUrLockTime(DateTime urLockTime, TransactionManager tm = null)
		{
			const string sql = @"UPDATE organize SET Ur_lockTime=@Ur_lockTime";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_lockTime", urLockTime, DbType.DateTime, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "urLockBindIp"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutUrLockBindIp(string urLockBindIp, TransactionManager tm = null)
		{
			const string sql = @"UPDATE organize SET Ur_lockBindIp=@Ur_lockBindIp";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_lockBindIp", urLockBindIp != null ?  (object)urLockBindIp : DBNull.Value, DbType.String, 765)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "urText1"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutUrText1(string urText1, TransactionManager tm = null)
		{
			const string sql = @"UPDATE organize SET Ur_text1=@Ur_text1";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_text1", urText1 != null ?  (object)urText1 : DBNull.Value, DbType.String, 300)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "urText2"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutUrText2(string urText2, TransactionManager tm = null)
		{
			const string sql = @"UPDATE organize SET Ur_text2=@Ur_text2";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_text2", urText2 != null ?  (object)urText2 : DBNull.Value, DbType.String, 300)
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
			const string format = @"UPDATE organize SET {0} {1}";
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
			const string format = @"UPDATE organize SET {0} {1}";
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
		/// <param name = "urId"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByPK(string urId, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM organize WHERE Ur_id=@Ur_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_id", urId, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Remove(OrganizeEO item, TransactionManager tm = null)
		{
			return RemoveByPK(item.UrId, tm);
		}

		/// <summary>
		/// 删除指定实体集合对应的记录集
		/// </summary>
		/// <param name = "items">要删除的实体集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Remove(IEnumerable<OrganizeEO> items, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM organize WHERE Ur_id=@OriginalUr_id";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@OriginalUrId", DbType.String, 150);
			int ret = 0;
			foreach (OrganizeEO item in items)
			{
				ret += sqlDao
							.SetParameterValue("@OriginalUrId", (item.HasOriginal) ? item.OriginalUrId : item.UrId)
							.ExecNonQuery(tm);
			}
			return ret;
		}




		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "urNo"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByUrNo(string urNo, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM organize WHERE Ur_no=@Ur_no";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_no", urNo, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "urName"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByUrName(string urName, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM organize WHERE Ur_Name=@Ur_Name";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_Name", urName != null ?  (object)urName : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "urUserName"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByUrUserName(string urUserName, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM organize WHERE Ur_UserName=@Ur_UserName";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_UserName", urUserName != null ?  (object)urUserName : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "urPassWord"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByUrPassWord(string urPassWord, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM organize WHERE Ur_PassWord=@Ur_PassWord";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_PassWord", urPassWord != null ?  (object)urPassWord : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "urZone"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByUrZone(string urZone, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM organize WHERE Ur_zone=@Ur_zone";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_zone", urZone != null ?  (object)urZone : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "urPeople"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByUrPeople(string urPeople, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM organize WHERE Ur_people=@Ur_people";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_people", urPeople != null ?  (object)urPeople : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "urContact"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByUrContact(string urContact, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM organize WHERE Ur_Contact=@Ur_Contact";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_Contact", urContact != null ?  (object)urContact : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "urAddTime"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByUrAddTime(DateTime urAddTime, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM organize WHERE Ur_addTime=@Ur_addTime";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_addTime", urAddTime, DbType.DateTime, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "urPercent"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByUrPercent(string urPercent, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM organize WHERE Ur_percent=@Ur_percent";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_percent", urPercent != null ?  (object)urPercent : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "urBankName"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByUrBankName(string urBankName, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM organize WHERE Ur_bankName=@Ur_bankName";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_bankName", urBankName != null ?  (object)urBankName : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "urBank"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByUrBank(string urBank, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM organize WHERE Ur_bank=@Ur_bank";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_bank", urBank != null ?  (object)urBank : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "urBankNo"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByUrBankNo(string urBankNo, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM organize WHERE Ur_bankNo=@Ur_bankNo";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_bankNo", urBankNo != null ?  (object)urBankNo : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "urIntroducer"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByUrIntroducer(string urIntroducer, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM organize WHERE Ur_introducer=@Ur_introducer";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_introducer", urIntroducer != null ?  (object)urIntroducer : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "urState"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByUrState(string urState, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM organize WHERE Ur_state=@Ur_state";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_state", urState != null ?  (object)urState : DBNull.Value, DbType.String, 3)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "urDel"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByUrDel(string urDel, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM organize WHERE Ur_del=@Ur_del";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_del", urDel != null ?  (object)urDel : DBNull.Value, DbType.String, 3)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "urErrorlogin"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByUrErrorlogin(string urErrorlogin, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM organize WHERE Ur_errorlogin=@Ur_errorlogin";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_errorlogin", urErrorlogin != null ?  (object)urErrorlogin : DBNull.Value, DbType.String, 300)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "urLockTime"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByUrLockTime(DateTime urLockTime, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM organize WHERE Ur_lockTime=@Ur_lockTime";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_lockTime", urLockTime, DbType.DateTime, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "urLockBindIp"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByUrLockBindIp(string urLockBindIp, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM organize WHERE Ur_lockBindIp=@Ur_lockBindIp";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_lockBindIp", urLockBindIp != null ?  (object)urLockBindIp : DBNull.Value, DbType.String, 765)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "urText1"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByUrText1(string urText1, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM organize WHERE Ur_text1=@Ur_text1";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_text1", urText1 != null ?  (object)urText1 : DBNull.Value, DbType.String, 300)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "urText2"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByUrText2(string urText2, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM organize WHERE Ur_text2=@Ur_text2";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Ur_text2", urText2 != null ?  (object)urText2 : DBNull.Value, DbType.String, 300)
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
			const string format = @"DELETE FROM organize {0}";
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
			const string format = @"DELETE FROM organize {0}";
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
