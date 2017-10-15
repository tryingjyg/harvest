//==========================================================
// 此代码由代码生成器工具自动生成，请不要修改
// 代码生成器核心库版本号：2.0
// 创建时间：2017/10/13 14:32:27
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
	/// 【表 log_charge 的实体类】
	/// </summary>
	[SerializableAttribute]
	public class LogChargeEO : DataEntityBase, IRowMapper<LogChargeEO>
	{
		protected string _originalInvoiceNo;

		/// <summary>
		/// 主键是否有原始值（即数据库中保存的值），用于实体对象更新时
		/// </summary>
		public bool HasOriginal { get; protected set; }

		/// <summary>
		/// 【主键 varchar】
		/// </summary>
		public virtual string InvoiceNo { get; set; }

		/// <summary>
		/// 【数据库中的原始主键值副本】
		/// </summary>
		public virtual string OriginalInvoiceNo
		{
			get { return _originalInvoiceNo; }
			set { HasOriginal = true; _originalInvoiceNo = value; }
		}

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string UpInvoiceNo { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string OutTradeNo { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string PayWay { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string AppId { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string Money { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string Qn { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string Duid { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string CreateTime { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string Extend1 { get; set; }

		/// <summary>
		/// 默认构造函数
		/// </summary>
		public LogChargeEO() 
		{
			InvoiceNo = string.Empty;
		}

		/// <summary>
		/// 自定义构造函数
		/// </summary>
		/// <param name = "invoiceNo"></param>
		/// <param name = "upInvoiceNo"></param>
		/// <param name = "outTradeNo"></param>
		/// <param name = "payWay"></param>
		/// <param name = "appId"></param>
		/// <param name = "money"></param>
		/// <param name = "qn"></param>
		/// <param name = "duid"></param>
		/// <param name = "createTime"></param>
		/// <param name = "extend1"></param>
		public LogChargeEO(string invoiceNo, string upInvoiceNo, string outTradeNo, string payWay, string appId, string money, string qn, string duid, string createTime, string extend1) 
		{
			InvoiceNo = invoiceNo;
			UpInvoiceNo = upInvoiceNo;
			OutTradeNo = outTradeNo;
			PayWay = payWay;
			AppId = appId;
			Money = money;
			Qn = qn;
			Duid = duid;
			CreateTime = createTime;
			Extend1 = extend1;
		}

		/// <summary>
		/// 将结果集映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public LogChargeEO MapRow(IDataReader reader)
		{
			return GetItem(reader);
		}

		/// <summary>
		/// 将结果集映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static LogChargeEO GetItem(IDataReader reader)
		{
			LogChargeEO ret = new LogChargeEO();

			ret.InvoiceNo = (string)reader["invoice_no"];
			ret.OriginalInvoiceNo = ret.InvoiceNo;
			ret.UpInvoiceNo = (reader["up_invoice_no"] is DBNull) ? null : (string)reader["up_invoice_no"];
			ret.OutTradeNo = (reader["out_trade_no"] is DBNull) ? null : (string)reader["out_trade_no"];
			ret.PayWay = (reader["pay_way"] is DBNull) ? null : (string)reader["pay_way"];
			ret.AppId = (reader["app_id"] is DBNull) ? null : (string)reader["app_id"];
			ret.Money = (reader["money"] is DBNull) ? null : (string)reader["money"];
			ret.Qn = (reader["qn"] is DBNull) ? null : (string)reader["qn"];
			ret.Duid = (reader["duid"] is DBNull) ? null : (string)reader["duid"];
			ret.CreateTime = (reader["createTime"] is DBNull) ? null : (string)reader["createTime"];
			ret.Extend1 = (reader["extend1"] is DBNull) ? null : (string)reader["extend1"];
			return ret;
		}
	}


	#endregion

	#region  MO

	/// <summary>
	/// 【表 log_charge 的操作类】
	/// </summary>
	public class LogChargeMO : DataManagerBase
	{

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "routeData">路由数据</param>
		public LogChargeMO(object routeData = null) : base(routeData) { }

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">连接字符串名称</param>
		public LogChargeMO(string connectionStringName) : base(connectionStringName) { }

		#region  Get方法集合

		/// <summary>
		/// 按 PK（主键） 查询
		/// </summary>
		/// <param name="tm">事务管理对象</param>
		/// <param name = "invoiceNo"></param>
		/// <return></return>
		public virtual LogChargeEO GetByPK(string invoiceNo, TransactionManager tm = null)
		{
			const string sql = @"SELECT invoice_no, up_invoice_no, out_trade_no, pay_way, app_id, money, qn, duid, createTime, extend1 FROM log_charge WHERE invoice_no=@invoice_no";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@invoice_no", invoiceNo, DbType.String, 150)
							.ExecSingle<LogChargeEO>(LogChargeEO.GetItem, tm);
		}




		#region  按 UpInvoiceNo（字段） 查询

		/// <summary>
		/// 按 UpInvoiceNo（字段） 查询
		/// </summary>
		/// <param name = "upInvoiceNo"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> GetByUpInvoiceNo(string upInvoiceNo)
		{
			return GetByUpInvoiceNo(upInvoiceNo, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 UpInvoiceNo（字段） 查询
		/// </summary>
		/// <param name = "upInvoiceNo"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> GetByUpInvoiceNo(string upInvoiceNo, TransactionManager tm)
		{
			return GetByUpInvoiceNo(upInvoiceNo, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 UpInvoiceNo（字段） 查询
		/// </summary>
		/// <param name = "upInvoiceNo"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> GetByUpInvoiceNo(string upInvoiceNo, int top)
		{
			return GetByUpInvoiceNo(upInvoiceNo, top, string.Empty, null);
		}

		/// <summary>
		/// 按 UpInvoiceNo（字段） 查询
		/// </summary>
		/// <param name = "upInvoiceNo"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> GetByUpInvoiceNo(string upInvoiceNo, int top, TransactionManager tm)
		{
			return GetByUpInvoiceNo(upInvoiceNo, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 UpInvoiceNo（字段） 查询
		/// </summary>
		/// <param name = "upInvoiceNo"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> GetByUpInvoiceNo(string upInvoiceNo, string sort)
		{
			return GetByUpInvoiceNo(upInvoiceNo, 0, sort, null);
		}

		/// <summary>
		/// 按 UpInvoiceNo（字段） 查询
		/// </summary>
		/// <param name = "upInvoiceNo"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> GetByUpInvoiceNo(string upInvoiceNo, string sort, TransactionManager tm)
		{
			return GetByUpInvoiceNo(upInvoiceNo, 0, sort, tm);
		}

		/// <summary>
		/// 按 UpInvoiceNo（字段） 查询
		/// </summary>
		/// <param name = "upInvoiceNo"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> GetByUpInvoiceNo(string upInvoiceNo, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} invoice_no, up_invoice_no, out_trade_no, pay_way, app_id, money, qn, duid, createTime, extend1 FROM log_charge WHERE up_invoice_no=@UpInvoiceNo";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@UpInvoiceNo", upInvoiceNo, DbType.String, 150)
							.ExecList<LogChargeEO>(LogChargeEO.GetItem, tm);
		}

		#endregion

		#region  按 OutTradeNo（字段） 查询

		/// <summary>
		/// 按 OutTradeNo（字段） 查询
		/// </summary>
		/// <param name = "outTradeNo"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> GetByOutTradeNo(string outTradeNo)
		{
			return GetByOutTradeNo(outTradeNo, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 OutTradeNo（字段） 查询
		/// </summary>
		/// <param name = "outTradeNo"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> GetByOutTradeNo(string outTradeNo, TransactionManager tm)
		{
			return GetByOutTradeNo(outTradeNo, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 OutTradeNo（字段） 查询
		/// </summary>
		/// <param name = "outTradeNo"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> GetByOutTradeNo(string outTradeNo, int top)
		{
			return GetByOutTradeNo(outTradeNo, top, string.Empty, null);
		}

		/// <summary>
		/// 按 OutTradeNo（字段） 查询
		/// </summary>
		/// <param name = "outTradeNo"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> GetByOutTradeNo(string outTradeNo, int top, TransactionManager tm)
		{
			return GetByOutTradeNo(outTradeNo, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 OutTradeNo（字段） 查询
		/// </summary>
		/// <param name = "outTradeNo"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> GetByOutTradeNo(string outTradeNo, string sort)
		{
			return GetByOutTradeNo(outTradeNo, 0, sort, null);
		}

		/// <summary>
		/// 按 OutTradeNo（字段） 查询
		/// </summary>
		/// <param name = "outTradeNo"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> GetByOutTradeNo(string outTradeNo, string sort, TransactionManager tm)
		{
			return GetByOutTradeNo(outTradeNo, 0, sort, tm);
		}

		/// <summary>
		/// 按 OutTradeNo（字段） 查询
		/// </summary>
		/// <param name = "outTradeNo"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> GetByOutTradeNo(string outTradeNo, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} invoice_no, up_invoice_no, out_trade_no, pay_way, app_id, money, qn, duid, createTime, extend1 FROM log_charge WHERE out_trade_no=@OutTradeNo";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@OutTradeNo", outTradeNo, DbType.String, 150)
							.ExecList<LogChargeEO>(LogChargeEO.GetItem, tm);
		}

		#endregion

		#region  按 PayWay（字段） 查询

		/// <summary>
		/// 按 PayWay（字段） 查询
		/// </summary>
		/// <param name = "payWay"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> GetByPayWay(string payWay)
		{
			return GetByPayWay(payWay, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 PayWay（字段） 查询
		/// </summary>
		/// <param name = "payWay"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> GetByPayWay(string payWay, TransactionManager tm)
		{
			return GetByPayWay(payWay, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 PayWay（字段） 查询
		/// </summary>
		/// <param name = "payWay"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> GetByPayWay(string payWay, int top)
		{
			return GetByPayWay(payWay, top, string.Empty, null);
		}

		/// <summary>
		/// 按 PayWay（字段） 查询
		/// </summary>
		/// <param name = "payWay"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> GetByPayWay(string payWay, int top, TransactionManager tm)
		{
			return GetByPayWay(payWay, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 PayWay（字段） 查询
		/// </summary>
		/// <param name = "payWay"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> GetByPayWay(string payWay, string sort)
		{
			return GetByPayWay(payWay, 0, sort, null);
		}

		/// <summary>
		/// 按 PayWay（字段） 查询
		/// </summary>
		/// <param name = "payWay"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> GetByPayWay(string payWay, string sort, TransactionManager tm)
		{
			return GetByPayWay(payWay, 0, sort, tm);
		}

		/// <summary>
		/// 按 PayWay（字段） 查询
		/// </summary>
		/// <param name = "payWay"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> GetByPayWay(string payWay, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} invoice_no, up_invoice_no, out_trade_no, pay_way, app_id, money, qn, duid, createTime, extend1 FROM log_charge WHERE pay_way=@PayWay";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@PayWay", payWay, DbType.String, 150)
							.ExecList<LogChargeEO>(LogChargeEO.GetItem, tm);
		}

		#endregion

		#region  按 AppId（字段） 查询

		/// <summary>
		/// 按 AppId（字段） 查询
		/// </summary>
		/// <param name = "appId"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> GetByAppId(string appId)
		{
			return GetByAppId(appId, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 AppId（字段） 查询
		/// </summary>
		/// <param name = "appId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> GetByAppId(string appId, TransactionManager tm)
		{
			return GetByAppId(appId, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 AppId（字段） 查询
		/// </summary>
		/// <param name = "appId"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> GetByAppId(string appId, int top)
		{
			return GetByAppId(appId, top, string.Empty, null);
		}

		/// <summary>
		/// 按 AppId（字段） 查询
		/// </summary>
		/// <param name = "appId"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> GetByAppId(string appId, int top, TransactionManager tm)
		{
			return GetByAppId(appId, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 AppId（字段） 查询
		/// </summary>
		/// <param name = "appId"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> GetByAppId(string appId, string sort)
		{
			return GetByAppId(appId, 0, sort, null);
		}

		/// <summary>
		/// 按 AppId（字段） 查询
		/// </summary>
		/// <param name = "appId"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> GetByAppId(string appId, string sort, TransactionManager tm)
		{
			return GetByAppId(appId, 0, sort, tm);
		}

		/// <summary>
		/// 按 AppId（字段） 查询
		/// </summary>
		/// <param name = "appId"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> GetByAppId(string appId, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} invoice_no, up_invoice_no, out_trade_no, pay_way, app_id, money, qn, duid, createTime, extend1 FROM log_charge WHERE app_id=@AppId";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@AppId", appId, DbType.String, 150)
							.ExecList<LogChargeEO>(LogChargeEO.GetItem, tm);
		}

		#endregion

		#region  按 Money（字段） 查询

		/// <summary>
		/// 按 Money（字段） 查询
		/// </summary>
		/// <param name = "money"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> GetByMoney(string money)
		{
			return GetByMoney(money, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 Money（字段） 查询
		/// </summary>
		/// <param name = "money"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> GetByMoney(string money, TransactionManager tm)
		{
			return GetByMoney(money, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 Money（字段） 查询
		/// </summary>
		/// <param name = "money"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> GetByMoney(string money, int top)
		{
			return GetByMoney(money, top, string.Empty, null);
		}

		/// <summary>
		/// 按 Money（字段） 查询
		/// </summary>
		/// <param name = "money"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> GetByMoney(string money, int top, TransactionManager tm)
		{
			return GetByMoney(money, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 Money（字段） 查询
		/// </summary>
		/// <param name = "money"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> GetByMoney(string money, string sort)
		{
			return GetByMoney(money, 0, sort, null);
		}

		/// <summary>
		/// 按 Money（字段） 查询
		/// </summary>
		/// <param name = "money"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> GetByMoney(string money, string sort, TransactionManager tm)
		{
			return GetByMoney(money, 0, sort, tm);
		}

		/// <summary>
		/// 按 Money（字段） 查询
		/// </summary>
		/// <param name = "money"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> GetByMoney(string money, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} invoice_no, up_invoice_no, out_trade_no, pay_way, app_id, money, qn, duid, createTime, extend1 FROM log_charge WHERE money=@Money";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Money", money, DbType.String, 192)
							.ExecList<LogChargeEO>(LogChargeEO.GetItem, tm);
		}

		#endregion

		#region  按 Qn（字段） 查询

		/// <summary>
		/// 按 Qn（字段） 查询
		/// </summary>
		/// <param name = "qn"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> GetByQn(string qn)
		{
			return GetByQn(qn, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 Qn（字段） 查询
		/// </summary>
		/// <param name = "qn"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> GetByQn(string qn, TransactionManager tm)
		{
			return GetByQn(qn, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 Qn（字段） 查询
		/// </summary>
		/// <param name = "qn"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> GetByQn(string qn, int top)
		{
			return GetByQn(qn, top, string.Empty, null);
		}

		/// <summary>
		/// 按 Qn（字段） 查询
		/// </summary>
		/// <param name = "qn"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> GetByQn(string qn, int top, TransactionManager tm)
		{
			return GetByQn(qn, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 Qn（字段） 查询
		/// </summary>
		/// <param name = "qn"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> GetByQn(string qn, string sort)
		{
			return GetByQn(qn, 0, sort, null);
		}

		/// <summary>
		/// 按 Qn（字段） 查询
		/// </summary>
		/// <param name = "qn"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> GetByQn(string qn, string sort, TransactionManager tm)
		{
			return GetByQn(qn, 0, sort, tm);
		}

		/// <summary>
		/// 按 Qn（字段） 查询
		/// </summary>
		/// <param name = "qn"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> GetByQn(string qn, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} invoice_no, up_invoice_no, out_trade_no, pay_way, app_id, money, qn, duid, createTime, extend1 FROM log_charge WHERE qn=@Qn";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Qn", qn, DbType.String, 150)
							.ExecList<LogChargeEO>(LogChargeEO.GetItem, tm);
		}

		#endregion

		#region  按 Duid（字段） 查询

		/// <summary>
		/// 按 Duid（字段） 查询
		/// </summary>
		/// <param name = "duid"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> GetByDuid(string duid)
		{
			return GetByDuid(duid, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 Duid（字段） 查询
		/// </summary>
		/// <param name = "duid"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> GetByDuid(string duid, TransactionManager tm)
		{
			return GetByDuid(duid, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 Duid（字段） 查询
		/// </summary>
		/// <param name = "duid"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> GetByDuid(string duid, int top)
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
		public virtual IEnumerable<LogChargeEO> GetByDuid(string duid, int top, TransactionManager tm)
		{
			return GetByDuid(duid, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 Duid（字段） 查询
		/// </summary>
		/// <param name = "duid"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> GetByDuid(string duid, string sort)
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
		public virtual IEnumerable<LogChargeEO> GetByDuid(string duid, string sort, TransactionManager tm)
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
		public virtual IEnumerable<LogChargeEO> GetByDuid(string duid, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} invoice_no, up_invoice_no, out_trade_no, pay_way, app_id, money, qn, duid, createTime, extend1 FROM log_charge WHERE duid=@Duid";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Duid", duid, DbType.String, 150)
							.ExecList<LogChargeEO>(LogChargeEO.GetItem, tm);
		}

		#endregion

		#region  按 CreateTime（字段） 查询

		/// <summary>
		/// 按 CreateTime（字段） 查询
		/// </summary>
		/// <param name = "createTime"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> GetByCreateTime(string createTime)
		{
			return GetByCreateTime(createTime, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 CreateTime（字段） 查询
		/// </summary>
		/// <param name = "createTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> GetByCreateTime(string createTime, TransactionManager tm)
		{
			return GetByCreateTime(createTime, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 CreateTime（字段） 查询
		/// </summary>
		/// <param name = "createTime"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> GetByCreateTime(string createTime, int top)
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
		public virtual IEnumerable<LogChargeEO> GetByCreateTime(string createTime, int top, TransactionManager tm)
		{
			return GetByCreateTime(createTime, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 CreateTime（字段） 查询
		/// </summary>
		/// <param name = "createTime"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> GetByCreateTime(string createTime, string sort)
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
		public virtual IEnumerable<LogChargeEO> GetByCreateTime(string createTime, string sort, TransactionManager tm)
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
		public virtual IEnumerable<LogChargeEO> GetByCreateTime(string createTime, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} invoice_no, up_invoice_no, out_trade_no, pay_way, app_id, money, qn, duid, createTime, extend1 FROM log_charge WHERE createTime=@CreateTime";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@CreateTime", createTime, DbType.String, 150)
							.ExecList<LogChargeEO>(LogChargeEO.GetItem, tm);
		}

		#endregion

		#region  按 Extend1（字段） 查询

		/// <summary>
		/// 按 Extend1（字段） 查询
		/// </summary>
		/// <param name = "extend1"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> GetByExtend1(string extend1)
		{
			return GetByExtend1(extend1, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 Extend1（字段） 查询
		/// </summary>
		/// <param name = "extend1"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> GetByExtend1(string extend1, TransactionManager tm)
		{
			return GetByExtend1(extend1, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 Extend1（字段） 查询
		/// </summary>
		/// <param name = "extend1"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> GetByExtend1(string extend1, int top)
		{
			return GetByExtend1(extend1, top, string.Empty, null);
		}

		/// <summary>
		/// 按 Extend1（字段） 查询
		/// </summary>
		/// <param name = "extend1"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> GetByExtend1(string extend1, int top, TransactionManager tm)
		{
			return GetByExtend1(extend1, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 Extend1（字段） 查询
		/// </summary>
		/// <param name = "extend1"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> GetByExtend1(string extend1, string sort)
		{
			return GetByExtend1(extend1, 0, sort, null);
		}

		/// <summary>
		/// 按 Extend1（字段） 查询
		/// </summary>
		/// <param name = "extend1"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> GetByExtend1(string extend1, string sort, TransactionManager tm)
		{
			return GetByExtend1(extend1, 0, sort, tm);
		}

		/// <summary>
		/// 按 Extend1（字段） 查询
		/// </summary>
		/// <param name = "extend1"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> GetByExtend1(string extend1, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} invoice_no, up_invoice_no, out_trade_no, pay_way, app_id, money, qn, duid, createTime, extend1 FROM log_charge WHERE extend1=@Extend1";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Extend1", extend1, DbType.String, 150)
							.ExecList<LogChargeEO>(LogChargeEO.GetItem, tm);
		}

		#endregion

		#region  自定义条件查询

		/// <summary>
		/// 获取所有数据
		/// </summary>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> GetAll(TransactionManager tm = null)
		{
			return GetTopSort(string.Empty, null, -1, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "values">where子句中定义的参数值集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> Get(string where, params object[] values)
		{
			return GetTopSort(where, -1, string.Empty, null, values);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "paras">where子句中定义的参数集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> Get(string where, IEnumerable<DbParameter> paras)
		{
			return GetTopSort(where, paras, -1, string.Empty, null);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> Get(string where, TransactionManager tm)
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
		public virtual IEnumerable<LogChargeEO> Get(string where, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<LogChargeEO> Get(string where, IEnumerable<DbParameter> paras, TransactionManager tm)
		{
			return GetTopSort(where, paras, -1, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> GetTop(string where, int top)
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
		public virtual IEnumerable<LogChargeEO> GetTop(string where, int top, params object[] values)
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
		public virtual IEnumerable<LogChargeEO> GetTop(string where, IEnumerable<DbParameter> paras, int top)
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
		public virtual IEnumerable<LogChargeEO> GetTop(string where, int top, TransactionManager tm)
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
		public virtual IEnumerable<LogChargeEO> GetTop(string where, int top, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<LogChargeEO> GetTop(string where, IEnumerable<DbParameter> paras, int top, TransactionManager tm)
		{
			return GetTopSort(where, paras, top, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<LogChargeEO> GetSort(string where, string sort)
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
		public virtual IEnumerable<LogChargeEO> GetSort(string where, string sort, params object[] values)
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
		public virtual IEnumerable<LogChargeEO> GetSort(string where, IEnumerable<DbParameter> paras, string sort)
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
		public virtual IEnumerable<LogChargeEO> GetSort(string where, string sort, TransactionManager tm)
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
		public virtual IEnumerable<LogChargeEO> GetSort(string where, string sort, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<LogChargeEO> GetSort(string where, IEnumerable<DbParameter> paras, string sort, TransactionManager tm)
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
		public virtual IEnumerable<LogChargeEO> GetTopSort(string where, int top, string sort)
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
		public virtual IEnumerable<LogChargeEO> GetTopSort(string where, int top, string sort, params object[] values)
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
		public virtual IEnumerable<LogChargeEO> GetTopSort(string where, IEnumerable<DbParameter> paras, int top, string sort)
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
		public virtual IEnumerable<LogChargeEO> GetTopSort(string where, int top, string sort, TransactionManager tm)
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
		public virtual IEnumerable<LogChargeEO> GetTopSort(string where, int top, string sort, TransactionManager tm, params object[] values)
		{
			const string format = @"SELECT {0} invoice_no, up_invoice_no, out_trade_no, pay_way, app_id, money, qn, duid, createTime, extend1 FROM log_charge";
			string sql = format;

			if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameters(values)
							.ExecList<LogChargeEO>(LogChargeEO.GetItem, tm);
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
		public virtual IEnumerable<LogChargeEO> GetTopSort(string where, IEnumerable<DbParameter> paras, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} invoice_no, up_invoice_no, out_trade_no, pay_way, app_id, money, qn, duid, createTime, extend1 FROM log_charge";
			string sql = format;

			if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddParameters(paras)
							.ExecList<LogChargeEO>(LogChargeEO.GetItem, tm);
		}

        public virtual DataTable GetTopSortTable(string where, int top, string sort, TransactionManager tm)
        {
            const string format = @"SELECT {0} invoice_no, up_invoice_no, out_trade_no, pay_way, app_id, money, qn, duid, createTime, extend1 FROM log_charge";
            string sql = format;

            if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
            if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
            sql = string.Format(sql, string.Empty);
            sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
            return Database.CreateSqlDao(sql)
                            .ExecTable();
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
			const string format = @"SELECT invoice_no, up_invoice_no, out_trade_no, pay_way, app_id, money, qn, duid, createTime, extend1 FROM log_charge {0} {1}";
			 string sql = string.Format(format, string.IsNullOrEmpty(where) ? string.Empty : "WHERE " + where, string.IsNullOrEmpty(sort) ? string.Empty : "ORDER BY " + sort);

			return Database.CreatePager(sql, pageSize, "invoice_no");
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
		public virtual List<LogChargeEO> GetPageList(int pageIndex , int pageSize, string where = null, string sort = null, IEnumerable<DbParameter> paras = null)
		{
			var pager = GetPager(pageSize, where, sort);

			pager.AddParameters(paras);
			return pager.GetPageList<LogChargeEO>(pageIndex);
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
		public virtual IEnumerable<LogChargeEO> GetPageMutil(int pageIndex , int pageSize, string where = null, string sort = null, IEnumerable<DbParameter> paras = null)
		{
			var pager = GetPager(pageSize, where, sort);

			pager.AddParameters(paras);
			return pager.GetPageMutil<LogChargeEO>(pageIndex);
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
		public virtual int Add(LogChargeEO item, TransactionManager tm = null)
		{
			const string sql = @"INSERT INTO log_charge (invoice_no, up_invoice_no, out_trade_no, pay_way, app_id, money, qn, duid, createTime, extend1) VALUES (@invoice_no, @up_invoice_no, @out_trade_no, @pay_way, @app_id, @money, @qn, @duid, @createTime, @extend1) ";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@invoice_no", item.InvoiceNo, DbType.String, 150)
							.AddInParameter("@up_invoice_no", item.UpInvoiceNo != null ?  (object)item.UpInvoiceNo : DBNull.Value, DbType.String, 150)
							.AddInParameter("@out_trade_no", item.OutTradeNo != null ?  (object)item.OutTradeNo : DBNull.Value, DbType.String, 150)
							.AddInParameter("@pay_way", item.PayWay != null ?  (object)item.PayWay : DBNull.Value, DbType.String, 150)
							.AddInParameter("@app_id", item.AppId != null ?  (object)item.AppId : DBNull.Value, DbType.String, 150)
							.AddInParameter("@money", item.Money != null ?  (object)item.Money : DBNull.Value, DbType.String, 192)
							.AddInParameter("@qn", item.Qn != null ?  (object)item.Qn : DBNull.Value, DbType.String, 150)
							.AddInParameter("@duid", item.Duid != null ?  (object)item.Duid : DBNull.Value, DbType.String, 150)
							.AddInParameter("@createTime", item.CreateTime != null ?  (object)item.CreateTime : DBNull.Value, DbType.String, 150)
							.AddInParameter("@extend1", item.Extend1 != null ?  (object)item.Extend1 : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 插入一组数据
		/// </summary>
		/// <param name = "items">要插入的实体对象集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Add(IEnumerable<LogChargeEO> items, TransactionManager tm = null)
		{
			int ret = 0;
			const string sql = @"INSERT INTO log_charge (invoice_no, up_invoice_no, out_trade_no, pay_way, app_id, money, qn, duid, createTime, extend1) VALUES (@invoice_no, @up_invoice_no, @out_trade_no, @pay_way, @app_id, @money, @qn, @duid, @createTime, @extend1) ";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@invoice_no", DbType.String, 150)
									.AddParameter("@up_invoice_no", DbType.String, 150)
									.AddParameter("@out_trade_no", DbType.String, 150)
									.AddParameter("@pay_way", DbType.String, 150)
									.AddParameter("@app_id", DbType.String, 150)
									.AddParameter("@money", DbType.String, 192)
									.AddParameter("@qn", DbType.String, 150)
									.AddParameter("@duid", DbType.String, 150)
									.AddParameter("@createTime", DbType.String, 150)
									.AddParameter("@extend1", DbType.String, 150);

			foreach (LogChargeEO item in items)
			{
				sqlDao
					.SetParameterValue("@invoice_no", item.InvoiceNo)
					.SetParameterValue("@up_invoice_no", item.UpInvoiceNo != null ?  (object)item.UpInvoiceNo : DBNull.Value)
					.SetParameterValue("@out_trade_no", item.OutTradeNo != null ?  (object)item.OutTradeNo : DBNull.Value)
					.SetParameterValue("@pay_way", item.PayWay != null ?  (object)item.PayWay : DBNull.Value)
					.SetParameterValue("@app_id", item.AppId != null ?  (object)item.AppId : DBNull.Value)
					.SetParameterValue("@money", item.Money != null ?  (object)item.Money : DBNull.Value)
					.SetParameterValue("@qn", item.Qn != null ?  (object)item.Qn : DBNull.Value)
					.SetParameterValue("@duid", item.Duid != null ?  (object)item.Duid : DBNull.Value)
					.SetParameterValue("@createTime", item.CreateTime != null ?  (object)item.CreateTime : DBNull.Value)
					.SetParameterValue("@extend1", item.Extend1 != null ?  (object)item.Extend1 : DBNull.Value)
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
		public virtual int Put(LogChargeEO item, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_charge SET invoice_no=@invoice_no, up_invoice_no=@up_invoice_no, out_trade_no=@out_trade_no, pay_way=@pay_way, app_id=@app_id, money=@money, qn=@qn, duid=@duid, createTime=@createTime, extend1=@extend1 WHERE invoice_no=@OriginalInvoice_no";
			return Database.CreateSqlDao (sql)
							.AddInParameter("@OriginalInvoiceNo", (item.HasOriginal) ? item.OriginalInvoiceNo : item.InvoiceNo, DbType.String, 150)
							.AddInParameter("@invoice_no", item.InvoiceNo, DbType.String, 150)
							.AddInParameter("@up_invoice_no", item.UpInvoiceNo != null ?  (object)item.UpInvoiceNo : DBNull.Value, DbType.String, 150)
							.AddInParameter("@out_trade_no", item.OutTradeNo != null ?  (object)item.OutTradeNo : DBNull.Value, DbType.String, 150)
							.AddInParameter("@pay_way", item.PayWay != null ?  (object)item.PayWay : DBNull.Value, DbType.String, 150)
							.AddInParameter("@app_id", item.AppId != null ?  (object)item.AppId : DBNull.Value, DbType.String, 150)
							.AddInParameter("@money", item.Money != null ?  (object)item.Money : DBNull.Value, DbType.String, 192)
							.AddInParameter("@qn", item.Qn != null ?  (object)item.Qn : DBNull.Value, DbType.String, 150)
							.AddInParameter("@duid", item.Duid != null ?  (object)item.Duid : DBNull.Value, DbType.String, 150)
							.AddInParameter("@createTime", item.CreateTime != null ?  (object)item.CreateTime : DBNull.Value, DbType.String, 150)
							.AddInParameter("@extend1", item.Extend1 != null ?  (object)item.Extend1 : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}


		/// <summary>
		/// 更新数据
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Put(IEnumerable<LogChargeEO> items, TransactionManager tm = null)
		{

			int ret = 0;
			const string sql = @"UPDATE log_charge SET invoice_no=@invoice_no, up_invoice_no=@up_invoice_no, out_trade_no=@out_trade_no, pay_way=@pay_way, app_id=@app_id, money=@money, qn=@qn, duid=@duid, createTime=@createTime, extend1=@extend1 WHERE invoice_no=@OriginalInvoice_no";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@OriginalInvoiceNo", DbType.String, 150)
									.AddParameter("@invoice_no", DbType.String, 150)
									.AddParameter("@up_invoice_no", DbType.String, 150)
									.AddParameter("@out_trade_no", DbType.String, 150)
									.AddParameter("@pay_way", DbType.String, 150)
									.AddParameter("@app_id", DbType.String, 150)
									.AddParameter("@money", DbType.String, 192)
									.AddParameter("@qn", DbType.String, 150)
									.AddParameter("@duid", DbType.String, 150)
									.AddParameter("@createTime", DbType.String, 150)
									.AddParameter("@extend1", DbType.String, 150);

			foreach (LogChargeEO item in items)
			{
				ret += sqlDao
							.SetParameterValue("@OriginalInvoiceNo", (item.HasOriginal) ? item.OriginalInvoiceNo : item.InvoiceNo)
							.SetParameterValue("@invoice_no", item.InvoiceNo)
							.SetParameterValue("@up_invoice_no", item.UpInvoiceNo != null ?  (object)item.UpInvoiceNo : DBNull.Value)
							.SetParameterValue("@out_trade_no", item.OutTradeNo != null ?  (object)item.OutTradeNo : DBNull.Value)
							.SetParameterValue("@pay_way", item.PayWay != null ?  (object)item.PayWay : DBNull.Value)
							.SetParameterValue("@app_id", item.AppId != null ?  (object)item.AppId : DBNull.Value)
							.SetParameterValue("@money", item.Money != null ?  (object)item.Money : DBNull.Value)
							.SetParameterValue("@qn", item.Qn != null ?  (object)item.Qn : DBNull.Value)
							.SetParameterValue("@duid", item.Duid != null ?  (object)item.Duid : DBNull.Value)
							.SetParameterValue("@createTime", item.CreateTime != null ?  (object)item.CreateTime : DBNull.Value)
							.SetParameterValue("@extend1", item.Extend1 != null ?  (object)item.Extend1 : DBNull.Value)
							.ExecNonQuery(tm);
			}
			return ret;
		}


		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "invoiceNo"></param>
		/// <param name = "upInvoiceNo"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutUpInvoiceNoByPK(string invoiceNo, string upInvoiceNo, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_charge SET up_invoice_no = @up_invoice_no  WHERE invoice_no = @invoice_no";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@invoice_no", invoiceNo, DbType.String, 150)
							.AddInParameter("@up_invoice_no", upInvoiceNo != null ?  (object)upInvoiceNo : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "invoiceNo"></param>
		/// <param name = "outTradeNo"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutOutTradeNoByPK(string invoiceNo, string outTradeNo, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_charge SET out_trade_no = @out_trade_no  WHERE invoice_no = @invoice_no";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@invoice_no", invoiceNo, DbType.String, 150)
							.AddInParameter("@out_trade_no", outTradeNo != null ?  (object)outTradeNo : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "invoiceNo"></param>
		/// <param name = "payWay"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutPayWayByPK(string invoiceNo, string payWay, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_charge SET pay_way = @pay_way  WHERE invoice_no = @invoice_no";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@invoice_no", invoiceNo, DbType.String, 150)
							.AddInParameter("@pay_way", payWay != null ?  (object)payWay : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "invoiceNo"></param>
		/// <param name = "appId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutAppIdByPK(string invoiceNo, string appId, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_charge SET app_id = @app_id  WHERE invoice_no = @invoice_no";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@invoice_no", invoiceNo, DbType.String, 150)
							.AddInParameter("@app_id", appId != null ?  (object)appId : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "invoiceNo"></param>
		/// <param name = "money"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutMoneyByPK(string invoiceNo, string money, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_charge SET money = @money  WHERE invoice_no = @invoice_no";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@invoice_no", invoiceNo, DbType.String, 150)
							.AddInParameter("@money", money != null ?  (object)money : DBNull.Value, DbType.String, 192)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "invoiceNo"></param>
		/// <param name = "qn"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutQnByPK(string invoiceNo, string qn, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_charge SET qn = @qn  WHERE invoice_no = @invoice_no";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@invoice_no", invoiceNo, DbType.String, 150)
							.AddInParameter("@qn", qn != null ?  (object)qn : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "invoiceNo"></param>
		/// <param name = "duid"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutDuidByPK(string invoiceNo, string duid, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_charge SET duid = @duid  WHERE invoice_no = @invoice_no";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@invoice_no", invoiceNo, DbType.String, 150)
							.AddInParameter("@duid", duid != null ?  (object)duid : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "invoiceNo"></param>
		/// <param name = "createTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutCreateTimeByPK(string invoiceNo, string createTime, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_charge SET createTime = @createTime  WHERE invoice_no = @invoice_no";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@invoice_no", invoiceNo, DbType.String, 150)
							.AddInParameter("@createTime", createTime != null ?  (object)createTime : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "invoiceNo"></param>
		/// <param name = "extend1"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutExtend1ByPK(string invoiceNo, string extend1, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_charge SET extend1 = @extend1  WHERE invoice_no = @invoice_no";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@invoice_no", invoiceNo, DbType.String, 150)
							.AddInParameter("@extend1", extend1 != null ?  (object)extend1 : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}


		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "upInvoiceNo"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutUpInvoiceNo(string upInvoiceNo, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_charge SET up_invoice_no=@up_invoice_no";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@up_invoice_no", upInvoiceNo != null ?  (object)upInvoiceNo : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "outTradeNo"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutOutTradeNo(string outTradeNo, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_charge SET out_trade_no=@out_trade_no";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@out_trade_no", outTradeNo != null ?  (object)outTradeNo : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "payWay"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutPayWay(string payWay, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_charge SET pay_way=@pay_way";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@pay_way", payWay != null ?  (object)payWay : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "appId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutAppId(string appId, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_charge SET app_id=@app_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@app_id", appId != null ?  (object)appId : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "money"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutMoney(string money, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_charge SET money=@money";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@money", money != null ?  (object)money : DBNull.Value, DbType.String, 192)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "qn"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutQn(string qn, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_charge SET qn=@qn";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@qn", qn != null ?  (object)qn : DBNull.Value, DbType.String, 150)
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
			const string sql = @"UPDATE log_charge SET duid=@duid";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@duid", duid != null ?  (object)duid : DBNull.Value, DbType.String, 150)
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
			const string sql = @"UPDATE log_charge SET createTime=@createTime";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@createTime", createTime != null ?  (object)createTime : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "extend1"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutExtend1(string extend1, TransactionManager tm = null)
		{
			const string sql = @"UPDATE log_charge SET extend1=@extend1";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@extend1", extend1 != null ?  (object)extend1 : DBNull.Value, DbType.String, 150)
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
			const string format = @"UPDATE log_charge SET {0} {1}";
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
			const string format = @"UPDATE log_charge SET {0} {1}";
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
		/// <param name = "invoiceNo"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByPK(string invoiceNo, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM log_charge WHERE invoice_no=@invoice_no";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@invoice_no", invoiceNo, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Remove(LogChargeEO item, TransactionManager tm = null)
		{
			return RemoveByPK(item.InvoiceNo, tm);
		}

		/// <summary>
		/// 删除指定实体集合对应的记录集
		/// </summary>
		/// <param name = "items">要删除的实体集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Remove(IEnumerable<LogChargeEO> items, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM log_charge WHERE invoice_no=@OriginalInvoice_no";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@OriginalInvoiceNo", DbType.String, 150);
			int ret = 0;
			foreach (LogChargeEO item in items)
			{
				ret += sqlDao
							.SetParameterValue("@OriginalInvoiceNo", (item.HasOriginal) ? item.OriginalInvoiceNo : item.InvoiceNo)
							.ExecNonQuery(tm);
			}
			return ret;
		}




		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "upInvoiceNo"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByUpInvoiceNo(string upInvoiceNo, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM log_charge WHERE up_invoice_no=@up_invoice_no";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@up_invoice_no", upInvoiceNo != null ?  (object)upInvoiceNo : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "outTradeNo"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByOutTradeNo(string outTradeNo, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM log_charge WHERE out_trade_no=@out_trade_no";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@out_trade_no", outTradeNo != null ?  (object)outTradeNo : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "payWay"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByPayWay(string payWay, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM log_charge WHERE pay_way=@pay_way";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@pay_way", payWay != null ?  (object)payWay : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "appId"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByAppId(string appId, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM log_charge WHERE app_id=@app_id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@app_id", appId != null ?  (object)appId : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "money"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByMoney(string money, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM log_charge WHERE money=@money";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@money", money != null ?  (object)money : DBNull.Value, DbType.String, 192)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "qn"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByQn(string qn, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM log_charge WHERE qn=@qn";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@qn", qn != null ?  (object)qn : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "duid"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByDuid(string duid, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM log_charge WHERE duid=@duid";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@duid", duid != null ?  (object)duid : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "createTime"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByCreateTime(string createTime, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM log_charge WHERE createTime=@createTime";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@createTime", createTime != null ?  (object)createTime : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "extend1"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByExtend1(string extend1, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM log_charge WHERE extend1=@extend1";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@extend1", extend1 != null ?  (object)extend1 : DBNull.Value, DbType.String, 150)
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
			const string format = @"DELETE FROM log_charge {0}";
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
			const string format = @"DELETE FROM log_charge {0}";
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
