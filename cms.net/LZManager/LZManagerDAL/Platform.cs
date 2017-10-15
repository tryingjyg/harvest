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
    /// 【表 platform 的实体类】
    /// </summary>
    [SerializableAttribute]
    public class NxPlatformEO : DataEntityBase, IRowMapper<NxPlatformEO>
    {
        protected string _originalPfId;

        /// <summary>
        /// 主键是否有原始值（即数据库中保存的值），用于实体对象更新时
        /// </summary>
        public bool HasOriginal { get; protected set; }

        /// <summary>
        /// 【主键 varchar】
        /// </summary>
        public virtual string PfId { get; set; }

        /// <summary>
        /// 【数据库中的原始主键值副本】
        /// </summary>
        public virtual string OriginalPfId
        {
            get { return _originalPfId; }
            set { HasOriginal = true; _originalPfId = value; }
        }

        /// <summary>
        /// 【字段 varchar】
        /// </summary>
        public virtual string PfName { get; set; }

        /// <summary>
        /// 【字段 varchar】
        /// </summary>
        public virtual string PfImgUrl { get; set; }

        /// <summary>
        /// 【字段 varchar】
        /// </summary>
        public virtual string PfImgWaterUrl { get; set; }

        /// <summary>
        /// 【字段 varchar】
        /// </summary>
        public virtual string PfAddUser { get; set; }

        /// <summary>
        /// 【字段 datetime】
        /// </summary>
        public virtual DateTime PfAddTime { get; set; }

        /// <summary>
        /// 【字段 char】
        /// </summary>
        public virtual string PfState { get; set; }

        /// <summary>
        /// 【字段 char】
        /// </summary>
        public virtual string PfDel { get; set; }

        /// <summary>
        /// 【字段 char】
        /// </summary>
        public virtual string PfIsRepair { get; set; }

        /// <summary>
        /// 【字段 varchar】
        /// </summary>
        public virtual string PfNewFunction { get; set; }

        /// <summary>
        /// 【字段 datetime】
        /// </summary>
        public virtual DateTime PfNewEndTime { get; set; }

        /// <summary>
        /// 【字段 char】
        /// </summary>
        public virtual string PfIsNewShow { get; set; }

        /// <summary>
        /// 【字段 int】
        /// </summary>
        public virtual int? PfSort { get; set; }

        /// <summary>
        /// 【字段 varchar】
        /// </summary>
        public virtual string PfText1 { get; set; }

        /// <summary>
        /// 【字段 varchar】
        /// </summary>
        public virtual string PfText2 { get; set; }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public NxPlatformEO()
        {
            PfId = string.Empty;
            PfState = string.Empty;
            PfDel = string.Empty;
        }

        /// <summary>
        /// 自定义构造函数
        /// </summary>
        /// <param name = "pfId"></param>
        /// <param name = "pfName"></param>
        /// <param name = "pfImgUrl"></param>
        /// <param name = "pfImgWaterUrl"></param>
        /// <param name = "pfAddUser"></param>
        /// <param name = "pfAddTime"></param>
        /// <param name = "pfState"></param>
        /// <param name = "pfDel"></param>
        /// <param name = "pfIsRepair"></param>
        /// <param name = "pfNewFunction"></param>
        /// <param name = "pfNewEndTime"></param>
        /// <param name = "pfIsNewShow"></param>
        /// <param name = "pfSort"></param>
        /// <param name = "pfText1"></param>
        /// <param name = "pfText2"></param>
        public NxPlatformEO(string pfId, string pfName, string pfImgUrl, string pfImgWaterUrl, string pfAddUser, DateTime pfAddTime, string pfState, string pfDel, string pfIsRepair, string pfNewFunction, DateTime pfNewEndTime, string pfIsNewShow, int? pfSort, string pfText1, string pfText2)
        {
            PfId = pfId;
            PfName = pfName;
            PfImgUrl = pfImgUrl;
            PfImgWaterUrl = pfImgWaterUrl;
            PfAddUser = pfAddUser;
            PfAddTime = pfAddTime;
            PfState = pfState;
            PfDel = pfDel;
            PfIsRepair = pfIsRepair;
            PfNewFunction = pfNewFunction;
            PfNewEndTime = pfNewEndTime;
            PfIsNewShow = pfIsNewShow;
            PfSort = pfSort;
            PfText1 = pfText1;
            PfText2 = pfText2;
        }

        /// <summary>
        /// 将结果集映射成实体对象
        /// </summary>
        /// <param name = "reader">只进结果集流</param>
        /// <return>实体对象</return>
        public NxPlatformEO MapRow(IDataReader reader)
        {
            return GetItem(reader);
        }

        /// <summary>
        /// 将结果集映射成实体对象
        /// </summary>
        /// <param name = "reader">只进结果集流</param>
        /// <return>实体对象</return>
        public static NxPlatformEO GetItem(IDataReader reader)
        {
            NxPlatformEO ret = new NxPlatformEO();

            ret.PfId = (string)reader["Pf_id"];
            ret.OriginalPfId = ret.PfId;
            ret.PfName = (reader["Pf_name"] is DBNull) ? null : (string)reader["Pf_name"];
            ret.PfImgUrl = (reader["Pf_imgUrl"] is DBNull) ? null : (string)reader["Pf_imgUrl"];
            ret.PfImgWaterUrl = (reader["Pf_imgWaterUrl"] is DBNull) ? null : (string)reader["Pf_imgWaterUrl"];
            ret.PfAddUser = (reader["Pf_addUser"] is DBNull) ? null : (string)reader["Pf_addUser"];
            ret.PfAddTime = DateTime.Parse(reader["Pf_addTime"].ToString());
            ret.PfState = (string)reader["Pf_state"];
            ret.PfDel = (string)reader["Pf_del"];
            ret.PfIsRepair = (reader["Pf_isRepair"] is DBNull) ? null : (string)reader["Pf_isRepair"];
            ret.PfNewFunction = (reader["Pf_newFunction"] is DBNull) ? null : (string)reader["Pf_newFunction"];
            ret.PfNewEndTime = DateTime.Parse(reader["Pf_newEndTime"].ToString());
            ret.PfIsNewShow = (reader["Pf_isNewShow"] is DBNull) ? null : (string)reader["Pf_isNewShow"];
            ret.PfSort = (reader["Pf_sort"] is DBNull) ? (int?)null : int.Parse(reader["Pf_sort"].ToString());
            ret.PfText1 = (reader["Pf_text1"] is DBNull) ? null : (string)reader["Pf_text1"];
            ret.PfText2 = (reader["Pf_text2"] is DBNull) ? null : (string)reader["Pf_text2"];
            return ret;
        }
    }


    #endregion

    #region  MO

    /// <summary>
    /// 【表 platform 的操作类】
    /// </summary>
    public partial class NxPlatformMO : DataManagerBase
    {

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name = "routeData">路由数据</param>
        public NxPlatformMO(object routeData = null) : base(routeData) { }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name = "connectionStringName">连接字符串名称</param>
        public NxPlatformMO(string connectionStringName) : base(connectionStringName) { }

        #region  Get方法集合

        /// <summary>
        /// 按 PK（主键） 查询
        /// </summary>
        /// <param name="tm">事务管理对象</param>
        /// <param name = "pfId"></param>
        /// <return></return>
        public virtual NxPlatformEO GetByPK(string pfId, TransactionManager tm = null)
        {
            const string sql = @"SELECT Pf_id, Pf_name, Pf_imgUrl, Pf_imgWaterUrl, Pf_addUser, Pf_addTime, Pf_state, Pf_del, Pf_isRepair, Pf_newFunction, Pf_newEndTime, Pf_isNewShow, Pf_sort, Pf_text1, Pf_text2 FROM platform WHERE Pf_id=@Pf_id";
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@Pf_id", pfId, DbType.String, 150)
                            .ExecSingle<NxPlatformEO>(NxPlatformEO.GetItem, tm);
        }




        #region  按 PfName（字段） 查询

        /// <summary>
        /// 按 PfName（字段） 查询
        /// </summary>
        /// <param name = "pfName"></param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfName(string pfName)
        {
            return GetByPfName(pfName, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 PfName（字段） 查询
        /// </summary>
        /// <param name = "pfName"></param>
        /// <param name="tm">事务管理对象</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfName(string pfName, TransactionManager tm)
        {
            return GetByPfName(pfName, 0, string.Empty, tm);
        }

        /// <summary>
        /// 按 PfName（字段） 查询
        /// </summary>
        /// <param name = "pfName"></param>
        /// <param name = "top">获取行数</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfName(string pfName, int top)
        {
            return GetByPfName(pfName, top, string.Empty, null);
        }

        /// <summary>
        /// 按 PfName（字段） 查询
        /// </summary>
        /// <param name = "pfName"></param>
        /// <param name = "top">获取行数</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfName(string pfName, int top, TransactionManager tm)
        {
            return GetByPfName(pfName, top, string.Empty, tm);
        }

        /// <summary>
        /// 按 PfName（字段） 查询
        /// </summary>
        /// <param name = "pfName"></param>
        /// <param name = "sort">排序表达式</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfName(string pfName, string sort)
        {
            return GetByPfName(pfName, 0, sort, null);
        }

        /// <summary>
        /// 按 PfName（字段） 查询
        /// </summary>
        /// <param name = "pfName"></param>
        /// <param name = "sort">排序表达式</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfName(string pfName, string sort, TransactionManager tm)
        {
            return GetByPfName(pfName, 0, sort, tm);
        }

        /// <summary>
        /// 按 PfName（字段） 查询
        /// </summary>
        /// <param name = "pfName"></param>
        /// <param name = "top">获取行数</param>
        /// <param name = "sort">排序表达式</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfName(string pfName, int top, string sort, TransactionManager tm)
        {
            const string format = @"SELECT {0} Pf_id, Pf_name, Pf_imgUrl, Pf_imgWaterUrl, Pf_addUser, Pf_addTime, Pf_state, Pf_del, Pf_isRepair, Pf_newFunction, Pf_newEndTime, Pf_isNewShow, Pf_sort, Pf_text1, Pf_text2 FROM platform WHERE Pf_name=@PfName";
            string sql = format;

            if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
            sql = string.Format(sql, string.Empty);
            sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@PfName", pfName, DbType.String, 150)
                            .ExecList<NxPlatformEO>(NxPlatformEO.GetItem, tm);
        }

        #endregion

        #region  按 PfImgUrl（字段） 查询

        /// <summary>
        /// 按 PfImgUrl（字段） 查询
        /// </summary>
        /// <param name = "pfImgUrl"></param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfImgUrl(string pfImgUrl)
        {
            return GetByPfImgUrl(pfImgUrl, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 PfImgUrl（字段） 查询
        /// </summary>
        /// <param name = "pfImgUrl"></param>
        /// <param name="tm">事务管理对象</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfImgUrl(string pfImgUrl, TransactionManager tm)
        {
            return GetByPfImgUrl(pfImgUrl, 0, string.Empty, tm);
        }

        /// <summary>
        /// 按 PfImgUrl（字段） 查询
        /// </summary>
        /// <param name = "pfImgUrl"></param>
        /// <param name = "top">获取行数</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfImgUrl(string pfImgUrl, int top)
        {
            return GetByPfImgUrl(pfImgUrl, top, string.Empty, null);
        }

        /// <summary>
        /// 按 PfImgUrl（字段） 查询
        /// </summary>
        /// <param name = "pfImgUrl"></param>
        /// <param name = "top">获取行数</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfImgUrl(string pfImgUrl, int top, TransactionManager tm)
        {
            return GetByPfImgUrl(pfImgUrl, top, string.Empty, tm);
        }

        /// <summary>
        /// 按 PfImgUrl（字段） 查询
        /// </summary>
        /// <param name = "pfImgUrl"></param>
        /// <param name = "sort">排序表达式</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfImgUrl(string pfImgUrl, string sort)
        {
            return GetByPfImgUrl(pfImgUrl, 0, sort, null);
        }

        /// <summary>
        /// 按 PfImgUrl（字段） 查询
        /// </summary>
        /// <param name = "pfImgUrl"></param>
        /// <param name = "sort">排序表达式</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfImgUrl(string pfImgUrl, string sort, TransactionManager tm)
        {
            return GetByPfImgUrl(pfImgUrl, 0, sort, tm);
        }

        /// <summary>
        /// 按 PfImgUrl（字段） 查询
        /// </summary>
        /// <param name = "pfImgUrl"></param>
        /// <param name = "top">获取行数</param>
        /// <param name = "sort">排序表达式</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfImgUrl(string pfImgUrl, int top, string sort, TransactionManager tm)
        {
            const string format = @"SELECT {0} Pf_id, Pf_name, Pf_imgUrl, Pf_imgWaterUrl, Pf_addUser, Pf_addTime, Pf_state, Pf_del, Pf_isRepair, Pf_newFunction, Pf_newEndTime, Pf_isNewShow, Pf_sort, Pf_text1, Pf_text2 FROM platform WHERE Pf_imgUrl=@PfImgUrl";
            string sql = format;

            if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
            sql = string.Format(sql, string.Empty);
            sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@PfImgUrl", pfImgUrl, DbType.String, 600)
                            .ExecList<NxPlatformEO>(NxPlatformEO.GetItem, tm);
        }

        #endregion

        #region  按 PfImgWaterUrl（字段） 查询

        /// <summary>
        /// 按 PfImgWaterUrl（字段） 查询
        /// </summary>
        /// <param name = "pfImgWaterUrl"></param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfImgWaterUrl(string pfImgWaterUrl)
        {
            return GetByPfImgWaterUrl(pfImgWaterUrl, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 PfImgWaterUrl（字段） 查询
        /// </summary>
        /// <param name = "pfImgWaterUrl"></param>
        /// <param name="tm">事务管理对象</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfImgWaterUrl(string pfImgWaterUrl, TransactionManager tm)
        {
            return GetByPfImgWaterUrl(pfImgWaterUrl, 0, string.Empty, tm);
        }

        /// <summary>
        /// 按 PfImgWaterUrl（字段） 查询
        /// </summary>
        /// <param name = "pfImgWaterUrl"></param>
        /// <param name = "top">获取行数</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfImgWaterUrl(string pfImgWaterUrl, int top)
        {
            return GetByPfImgWaterUrl(pfImgWaterUrl, top, string.Empty, null);
        }

        /// <summary>
        /// 按 PfImgWaterUrl（字段） 查询
        /// </summary>
        /// <param name = "pfImgWaterUrl"></param>
        /// <param name = "top">获取行数</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfImgWaterUrl(string pfImgWaterUrl, int top, TransactionManager tm)
        {
            return GetByPfImgWaterUrl(pfImgWaterUrl, top, string.Empty, tm);
        }

        /// <summary>
        /// 按 PfImgWaterUrl（字段） 查询
        /// </summary>
        /// <param name = "pfImgWaterUrl"></param>
        /// <param name = "sort">排序表达式</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfImgWaterUrl(string pfImgWaterUrl, string sort)
        {
            return GetByPfImgWaterUrl(pfImgWaterUrl, 0, sort, null);
        }

        /// <summary>
        /// 按 PfImgWaterUrl（字段） 查询
        /// </summary>
        /// <param name = "pfImgWaterUrl"></param>
        /// <param name = "sort">排序表达式</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfImgWaterUrl(string pfImgWaterUrl, string sort, TransactionManager tm)
        {
            return GetByPfImgWaterUrl(pfImgWaterUrl, 0, sort, tm);
        }

        /// <summary>
        /// 按 PfImgWaterUrl（字段） 查询
        /// </summary>
        /// <param name = "pfImgWaterUrl"></param>
        /// <param name = "top">获取行数</param>
        /// <param name = "sort">排序表达式</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfImgWaterUrl(string pfImgWaterUrl, int top, string sort, TransactionManager tm)
        {
            const string format = @"SELECT {0} Pf_id, Pf_name, Pf_imgUrl, Pf_imgWaterUrl, Pf_addUser, Pf_addTime, Pf_state, Pf_del, Pf_isRepair, Pf_newFunction, Pf_newEndTime, Pf_isNewShow, Pf_sort, Pf_text1, Pf_text2 FROM platform WHERE Pf_imgWaterUrl=@PfImgWaterUrl";
            string sql = format;

            if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
            sql = string.Format(sql, string.Empty);
            sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@PfImgWaterUrl", pfImgWaterUrl, DbType.String, 765)
                            .ExecList<NxPlatformEO>(NxPlatformEO.GetItem, tm);
        }

        #endregion

        #region  按 PfAddUser（字段） 查询

        /// <summary>
        /// 按 PfAddUser（字段） 查询
        /// </summary>
        /// <param name = "pfAddUser"></param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfAddUser(string pfAddUser)
        {
            return GetByPfAddUser(pfAddUser, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 PfAddUser（字段） 查询
        /// </summary>
        /// <param name = "pfAddUser"></param>
        /// <param name="tm">事务管理对象</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfAddUser(string pfAddUser, TransactionManager tm)
        {
            return GetByPfAddUser(pfAddUser, 0, string.Empty, tm);
        }

        /// <summary>
        /// 按 PfAddUser（字段） 查询
        /// </summary>
        /// <param name = "pfAddUser"></param>
        /// <param name = "top">获取行数</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfAddUser(string pfAddUser, int top)
        {
            return GetByPfAddUser(pfAddUser, top, string.Empty, null);
        }

        /// <summary>
        /// 按 PfAddUser（字段） 查询
        /// </summary>
        /// <param name = "pfAddUser"></param>
        /// <param name = "top">获取行数</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfAddUser(string pfAddUser, int top, TransactionManager tm)
        {
            return GetByPfAddUser(pfAddUser, top, string.Empty, tm);
        }

        /// <summary>
        /// 按 PfAddUser（字段） 查询
        /// </summary>
        /// <param name = "pfAddUser"></param>
        /// <param name = "sort">排序表达式</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfAddUser(string pfAddUser, string sort)
        {
            return GetByPfAddUser(pfAddUser, 0, sort, null);
        }

        /// <summary>
        /// 按 PfAddUser（字段） 查询
        /// </summary>
        /// <param name = "pfAddUser"></param>
        /// <param name = "sort">排序表达式</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfAddUser(string pfAddUser, string sort, TransactionManager tm)
        {
            return GetByPfAddUser(pfAddUser, 0, sort, tm);
        }

        /// <summary>
        /// 按 PfAddUser（字段） 查询
        /// </summary>
        /// <param name = "pfAddUser"></param>
        /// <param name = "top">获取行数</param>
        /// <param name = "sort">排序表达式</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfAddUser(string pfAddUser, int top, string sort, TransactionManager tm)
        {
            const string format = @"SELECT {0} Pf_id, Pf_name, Pf_imgUrl, Pf_imgWaterUrl, Pf_addUser, Pf_addTime, Pf_state, Pf_del, Pf_isRepair, Pf_newFunction, Pf_newEndTime, Pf_isNewShow, Pf_sort, Pf_text1, Pf_text2 FROM platform WHERE Pf_addUser=@PfAddUser";
            string sql = format;

            if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
            sql = string.Format(sql, string.Empty);
            sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@PfAddUser", pfAddUser, DbType.String, 150)
                            .ExecList<NxPlatformEO>(NxPlatformEO.GetItem, tm);
        }

        #endregion

        #region  按 PfAddTime（字段） 查询

        /// <summary>
        /// 按 PfAddTime（字段） 查询
        /// </summary>
        /// <param name = "pfAddTime"></param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfAddTime(DateTime pfAddTime)
        {
            return GetByPfAddTime(pfAddTime, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 PfAddTime（字段） 查询
        /// </summary>
        /// <param name = "pfAddTime"></param>
        /// <param name="tm">事务管理对象</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfAddTime(DateTime pfAddTime, TransactionManager tm)
        {
            return GetByPfAddTime(pfAddTime, 0, string.Empty, tm);
        }

        /// <summary>
        /// 按 PfAddTime（字段） 查询
        /// </summary>
        /// <param name = "pfAddTime"></param>
        /// <param name = "top">获取行数</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfAddTime(DateTime pfAddTime, int top)
        {
            return GetByPfAddTime(pfAddTime, top, string.Empty, null);
        }

        /// <summary>
        /// 按 PfAddTime（字段） 查询
        /// </summary>
        /// <param name = "pfAddTime"></param>
        /// <param name = "top">获取行数</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfAddTime(DateTime pfAddTime, int top, TransactionManager tm)
        {
            return GetByPfAddTime(pfAddTime, top, string.Empty, tm);
        }

        /// <summary>
        /// 按 PfAddTime（字段） 查询
        /// </summary>
        /// <param name = "pfAddTime"></param>
        /// <param name = "sort">排序表达式</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfAddTime(DateTime pfAddTime, string sort)
        {
            return GetByPfAddTime(pfAddTime, 0, sort, null);
        }

        /// <summary>
        /// 按 PfAddTime（字段） 查询
        /// </summary>
        /// <param name = "pfAddTime"></param>
        /// <param name = "sort">排序表达式</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfAddTime(DateTime pfAddTime, string sort, TransactionManager tm)
        {
            return GetByPfAddTime(pfAddTime, 0, sort, tm);
        }

        /// <summary>
        /// 按 PfAddTime（字段） 查询
        /// </summary>
        /// <param name = "pfAddTime"></param>
        /// <param name = "top">获取行数</param>
        /// <param name = "sort">排序表达式</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfAddTime(DateTime pfAddTime, int top, string sort, TransactionManager tm)
        {
            const string format = @"SELECT {0} Pf_id, Pf_name, Pf_imgUrl, Pf_imgWaterUrl, Pf_addUser, Pf_addTime, Pf_state, Pf_del, Pf_isRepair, Pf_newFunction, Pf_newEndTime, Pf_isNewShow, Pf_sort, Pf_text1, Pf_text2 FROM platform WHERE Pf_addTime=@PfAddTime";
            string sql = format;

            if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
            sql = string.Format(sql, string.Empty);
            sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@PfAddTime", pfAddTime, DbType.DateTime, 0)
                            .ExecList<NxPlatformEO>(NxPlatformEO.GetItem, tm);
        }

        #endregion

        #region  按 PfState（字段） 查询

        /// <summary>
        /// 按 PfState（字段） 查询
        /// </summary>
        /// <param name = "pfState"></param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfState(string pfState)
        {
            return GetByPfState(pfState, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 PfState（字段） 查询
        /// </summary>
        /// <param name = "pfState"></param>
        /// <param name="tm">事务管理对象</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfState(string pfState, TransactionManager tm)
        {
            return GetByPfState(pfState, 0, string.Empty, tm);
        }

        /// <summary>
        /// 按 PfState（字段） 查询
        /// </summary>
        /// <param name = "pfState"></param>
        /// <param name = "top">获取行数</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfState(string pfState, int top)
        {
            return GetByPfState(pfState, top, string.Empty, null);
        }

        /// <summary>
        /// 按 PfState（字段） 查询
        /// </summary>
        /// <param name = "pfState"></param>
        /// <param name = "top">获取行数</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfState(string pfState, int top, TransactionManager tm)
        {
            return GetByPfState(pfState, top, string.Empty, tm);
        }

        /// <summary>
        /// 按 PfState（字段） 查询
        /// </summary>
        /// <param name = "pfState"></param>
        /// <param name = "sort">排序表达式</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfState(string pfState, string sort)
        {
            return GetByPfState(pfState, 0, sort, null);
        }

        /// <summary>
        /// 按 PfState（字段） 查询
        /// </summary>
        /// <param name = "pfState"></param>
        /// <param name = "sort">排序表达式</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfState(string pfState, string sort, TransactionManager tm)
        {
            return GetByPfState(pfState, 0, sort, tm);
        }

        /// <summary>
        /// 按 PfState（字段） 查询
        /// </summary>
        /// <param name = "pfState"></param>
        /// <param name = "top">获取行数</param>
        /// <param name = "sort">排序表达式</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfState(string pfState, int top, string sort, TransactionManager tm)
        {
            const string format = @"SELECT {0} Pf_id, Pf_name, Pf_imgUrl, Pf_imgWaterUrl, Pf_addUser, Pf_addTime, Pf_state, Pf_del, Pf_isRepair, Pf_newFunction, Pf_newEndTime, Pf_isNewShow, Pf_sort, Pf_text1, Pf_text2 FROM platform WHERE Pf_state=@PfState";
            string sql = format;

            if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
            sql = string.Format(sql, string.Empty);
            sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@PfState", pfState, DbType.String, 3)
                            .ExecList<NxPlatformEO>(NxPlatformEO.GetItem, tm);
        }

        #endregion

        #region  按 PfDel（字段） 查询

        /// <summary>
        /// 按 PfDel（字段） 查询
        /// </summary>
        /// <param name = "pfDel"></param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfDel(string pfDel)
        {
            return GetByPfDel(pfDel, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 PfDel（字段） 查询
        /// </summary>
        /// <param name = "pfDel"></param>
        /// <param name="tm">事务管理对象</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfDel(string pfDel, TransactionManager tm)
        {
            return GetByPfDel(pfDel, 0, string.Empty, tm);
        }

        /// <summary>
        /// 按 PfDel（字段） 查询
        /// </summary>
        /// <param name = "pfDel"></param>
        /// <param name = "top">获取行数</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfDel(string pfDel, int top)
        {
            return GetByPfDel(pfDel, top, string.Empty, null);
        }

        /// <summary>
        /// 按 PfDel（字段） 查询
        /// </summary>
        /// <param name = "pfDel"></param>
        /// <param name = "top">获取行数</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfDel(string pfDel, int top, TransactionManager tm)
        {
            return GetByPfDel(pfDel, top, string.Empty, tm);
        }

        /// <summary>
        /// 按 PfDel（字段） 查询
        /// </summary>
        /// <param name = "pfDel"></param>
        /// <param name = "sort">排序表达式</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfDel(string pfDel, string sort)
        {
            return GetByPfDel(pfDel, 0, sort, null);
        }

        /// <summary>
        /// 按 PfDel（字段） 查询
        /// </summary>
        /// <param name = "pfDel"></param>
        /// <param name = "sort">排序表达式</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfDel(string pfDel, string sort, TransactionManager tm)
        {
            return GetByPfDel(pfDel, 0, sort, tm);
        }

        /// <summary>
        /// 按 PfDel（字段） 查询
        /// </summary>
        /// <param name = "pfDel"></param>
        /// <param name = "top">获取行数</param>
        /// <param name = "sort">排序表达式</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfDel(string pfDel, int top, string sort, TransactionManager tm)
        {
            const string format = @"SELECT {0} Pf_id, Pf_name, Pf_imgUrl, Pf_imgWaterUrl, Pf_addUser, Pf_addTime, Pf_state, Pf_del, Pf_isRepair, Pf_newFunction, Pf_newEndTime, Pf_isNewShow, Pf_sort, Pf_text1, Pf_text2 FROM platform WHERE Pf_del=@PfDel";
            string sql = format;

            if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
            sql = string.Format(sql, string.Empty);
            sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@PfDel", pfDel, DbType.String, 3)
                            .ExecList<NxPlatformEO>(NxPlatformEO.GetItem, tm);
        }

        #endregion

        #region  按 PfIsRepair（字段） 查询

        /// <summary>
        /// 按 PfIsRepair（字段） 查询
        /// </summary>
        /// <param name = "pfIsRepair"></param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfIsRepair(string pfIsRepair)
        {
            return GetByPfIsRepair(pfIsRepair, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 PfIsRepair（字段） 查询
        /// </summary>
        /// <param name = "pfIsRepair"></param>
        /// <param name="tm">事务管理对象</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfIsRepair(string pfIsRepair, TransactionManager tm)
        {
            return GetByPfIsRepair(pfIsRepair, 0, string.Empty, tm);
        }

        /// <summary>
        /// 按 PfIsRepair（字段） 查询
        /// </summary>
        /// <param name = "pfIsRepair"></param>
        /// <param name = "top">获取行数</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfIsRepair(string pfIsRepair, int top)
        {
            return GetByPfIsRepair(pfIsRepair, top, string.Empty, null);
        }

        /// <summary>
        /// 按 PfIsRepair（字段） 查询
        /// </summary>
        /// <param name = "pfIsRepair"></param>
        /// <param name = "top">获取行数</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfIsRepair(string pfIsRepair, int top, TransactionManager tm)
        {
            return GetByPfIsRepair(pfIsRepair, top, string.Empty, tm);
        }

        /// <summary>
        /// 按 PfIsRepair（字段） 查询
        /// </summary>
        /// <param name = "pfIsRepair"></param>
        /// <param name = "sort">排序表达式</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfIsRepair(string pfIsRepair, string sort)
        {
            return GetByPfIsRepair(pfIsRepair, 0, sort, null);
        }

        /// <summary>
        /// 按 PfIsRepair（字段） 查询
        /// </summary>
        /// <param name = "pfIsRepair"></param>
        /// <param name = "sort">排序表达式</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfIsRepair(string pfIsRepair, string sort, TransactionManager tm)
        {
            return GetByPfIsRepair(pfIsRepair, 0, sort, tm);
        }

        /// <summary>
        /// 按 PfIsRepair（字段） 查询
        /// </summary>
        /// <param name = "pfIsRepair"></param>
        /// <param name = "top">获取行数</param>
        /// <param name = "sort">排序表达式</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfIsRepair(string pfIsRepair, int top, string sort, TransactionManager tm)
        {
            const string format = @"SELECT {0} Pf_id, Pf_name, Pf_imgUrl, Pf_imgWaterUrl, Pf_addUser, Pf_addTime, Pf_state, Pf_del, Pf_isRepair, Pf_newFunction, Pf_newEndTime, Pf_isNewShow, Pf_sort, Pf_text1, Pf_text2 FROM platform WHERE Pf_isRepair=@PfIsRepair";
            string sql = format;

            if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
            sql = string.Format(sql, string.Empty);
            sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@PfIsRepair", pfIsRepair, DbType.String, 3)
                            .ExecList<NxPlatformEO>(NxPlatformEO.GetItem, tm);
        }

        #endregion

        #region  按 PfNewFunction（字段） 查询

        /// <summary>
        /// 按 PfNewFunction（字段） 查询
        /// </summary>
        /// <param name = "pfNewFunction"></param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfNewFunction(string pfNewFunction)
        {
            return GetByPfNewFunction(pfNewFunction, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 PfNewFunction（字段） 查询
        /// </summary>
        /// <param name = "pfNewFunction"></param>
        /// <param name="tm">事务管理对象</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfNewFunction(string pfNewFunction, TransactionManager tm)
        {
            return GetByPfNewFunction(pfNewFunction, 0, string.Empty, tm);
        }

        /// <summary>
        /// 按 PfNewFunction（字段） 查询
        /// </summary>
        /// <param name = "pfNewFunction"></param>
        /// <param name = "top">获取行数</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfNewFunction(string pfNewFunction, int top)
        {
            return GetByPfNewFunction(pfNewFunction, top, string.Empty, null);
        }

        /// <summary>
        /// 按 PfNewFunction（字段） 查询
        /// </summary>
        /// <param name = "pfNewFunction"></param>
        /// <param name = "top">获取行数</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfNewFunction(string pfNewFunction, int top, TransactionManager tm)
        {
            return GetByPfNewFunction(pfNewFunction, top, string.Empty, tm);
        }

        /// <summary>
        /// 按 PfNewFunction（字段） 查询
        /// </summary>
        /// <param name = "pfNewFunction"></param>
        /// <param name = "sort">排序表达式</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfNewFunction(string pfNewFunction, string sort)
        {
            return GetByPfNewFunction(pfNewFunction, 0, sort, null);
        }

        /// <summary>
        /// 按 PfNewFunction（字段） 查询
        /// </summary>
        /// <param name = "pfNewFunction"></param>
        /// <param name = "sort">排序表达式</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfNewFunction(string pfNewFunction, string sort, TransactionManager tm)
        {
            return GetByPfNewFunction(pfNewFunction, 0, sort, tm);
        }

        /// <summary>
        /// 按 PfNewFunction（字段） 查询
        /// </summary>
        /// <param name = "pfNewFunction"></param>
        /// <param name = "top">获取行数</param>
        /// <param name = "sort">排序表达式</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfNewFunction(string pfNewFunction, int top, string sort, TransactionManager tm)
        {
            const string format = @"SELECT {0} Pf_id, Pf_name, Pf_imgUrl, Pf_imgWaterUrl, Pf_addUser, Pf_addTime, Pf_state, Pf_del, Pf_isRepair, Pf_newFunction, Pf_newEndTime, Pf_isNewShow, Pf_sort, Pf_text1, Pf_text2 FROM platform WHERE Pf_newFunction=@PfNewFunction";
            string sql = format;

            if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
            sql = string.Format(sql, string.Empty);
            sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@PfNewFunction", pfNewFunction, DbType.String, 6000)
                            .ExecList<NxPlatformEO>(NxPlatformEO.GetItem, tm);
        }

        #endregion

        #region  按 PfNewEndTime（字段） 查询

        /// <summary>
        /// 按 PfNewEndTime（字段） 查询
        /// </summary>
        /// <param name = "pfNewEndTime"></param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfNewEndTime(DateTime pfNewEndTime)
        {
            return GetByPfNewEndTime(pfNewEndTime, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 PfNewEndTime（字段） 查询
        /// </summary>
        /// <param name = "pfNewEndTime"></param>
        /// <param name="tm">事务管理对象</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfNewEndTime(DateTime pfNewEndTime, TransactionManager tm)
        {
            return GetByPfNewEndTime(pfNewEndTime, 0, string.Empty, tm);
        }

        /// <summary>
        /// 按 PfNewEndTime（字段） 查询
        /// </summary>
        /// <param name = "pfNewEndTime"></param>
        /// <param name = "top">获取行数</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfNewEndTime(DateTime pfNewEndTime, int top)
        {
            return GetByPfNewEndTime(pfNewEndTime, top, string.Empty, null);
        }

        /// <summary>
        /// 按 PfNewEndTime（字段） 查询
        /// </summary>
        /// <param name = "pfNewEndTime"></param>
        /// <param name = "top">获取行数</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfNewEndTime(DateTime pfNewEndTime, int top, TransactionManager tm)
        {
            return GetByPfNewEndTime(pfNewEndTime, top, string.Empty, tm);
        }

        /// <summary>
        /// 按 PfNewEndTime（字段） 查询
        /// </summary>
        /// <param name = "pfNewEndTime"></param>
        /// <param name = "sort">排序表达式</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfNewEndTime(DateTime pfNewEndTime, string sort)
        {
            return GetByPfNewEndTime(pfNewEndTime, 0, sort, null);
        }

        /// <summary>
        /// 按 PfNewEndTime（字段） 查询
        /// </summary>
        /// <param name = "pfNewEndTime"></param>
        /// <param name = "sort">排序表达式</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfNewEndTime(DateTime pfNewEndTime, string sort, TransactionManager tm)
        {
            return GetByPfNewEndTime(pfNewEndTime, 0, sort, tm);
        }

        /// <summary>
        /// 按 PfNewEndTime（字段） 查询
        /// </summary>
        /// <param name = "pfNewEndTime"></param>
        /// <param name = "top">获取行数</param>
        /// <param name = "sort">排序表达式</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfNewEndTime(DateTime pfNewEndTime, int top, string sort, TransactionManager tm)
        {
            const string format = @"SELECT {0} Pf_id, Pf_name, Pf_imgUrl, Pf_imgWaterUrl, Pf_addUser, Pf_addTime, Pf_state, Pf_del, Pf_isRepair, Pf_newFunction, Pf_newEndTime, Pf_isNewShow, Pf_sort, Pf_text1, Pf_text2 FROM platform WHERE Pf_newEndTime=@PfNewEndTime";
            string sql = format;

            if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
            sql = string.Format(sql, string.Empty);
            sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@PfNewEndTime", pfNewEndTime, DbType.DateTime, 0)
                            .ExecList<NxPlatformEO>(NxPlatformEO.GetItem, tm);
        }

        #endregion

        #region  按 PfIsNewShow（字段） 查询

        /// <summary>
        /// 按 PfIsNewShow（字段） 查询
        /// </summary>
        /// <param name = "pfIsNewShow"></param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfIsNewShow(string pfIsNewShow)
        {
            return GetByPfIsNewShow(pfIsNewShow, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 PfIsNewShow（字段） 查询
        /// </summary>
        /// <param name = "pfIsNewShow"></param>
        /// <param name="tm">事务管理对象</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfIsNewShow(string pfIsNewShow, TransactionManager tm)
        {
            return GetByPfIsNewShow(pfIsNewShow, 0, string.Empty, tm);
        }

        /// <summary>
        /// 按 PfIsNewShow（字段） 查询
        /// </summary>
        /// <param name = "pfIsNewShow"></param>
        /// <param name = "top">获取行数</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfIsNewShow(string pfIsNewShow, int top)
        {
            return GetByPfIsNewShow(pfIsNewShow, top, string.Empty, null);
        }

        /// <summary>
        /// 按 PfIsNewShow（字段） 查询
        /// </summary>
        /// <param name = "pfIsNewShow"></param>
        /// <param name = "top">获取行数</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfIsNewShow(string pfIsNewShow, int top, TransactionManager tm)
        {
            return GetByPfIsNewShow(pfIsNewShow, top, string.Empty, tm);
        }

        /// <summary>
        /// 按 PfIsNewShow（字段） 查询
        /// </summary>
        /// <param name = "pfIsNewShow"></param>
        /// <param name = "sort">排序表达式</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfIsNewShow(string pfIsNewShow, string sort)
        {
            return GetByPfIsNewShow(pfIsNewShow, 0, sort, null);
        }

        /// <summary>
        /// 按 PfIsNewShow（字段） 查询
        /// </summary>
        /// <param name = "pfIsNewShow"></param>
        /// <param name = "sort">排序表达式</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfIsNewShow(string pfIsNewShow, string sort, TransactionManager tm)
        {
            return GetByPfIsNewShow(pfIsNewShow, 0, sort, tm);
        }

        /// <summary>
        /// 按 PfIsNewShow（字段） 查询
        /// </summary>
        /// <param name = "pfIsNewShow"></param>
        /// <param name = "top">获取行数</param>
        /// <param name = "sort">排序表达式</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfIsNewShow(string pfIsNewShow, int top, string sort, TransactionManager tm)
        {
            const string format = @"SELECT {0} Pf_id, Pf_name, Pf_imgUrl, Pf_imgWaterUrl, Pf_addUser, Pf_addTime, Pf_state, Pf_del, Pf_isRepair, Pf_newFunction, Pf_newEndTime, Pf_isNewShow, Pf_sort, Pf_text1, Pf_text2 FROM platform WHERE Pf_isNewShow=@PfIsNewShow";
            string sql = format;

            if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
            sql = string.Format(sql, string.Empty);
            sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@PfIsNewShow", pfIsNewShow, DbType.String, 3)
                            .ExecList<NxPlatformEO>(NxPlatformEO.GetItem, tm);
        }

        #endregion

        #region  按 PfSort（字段） 查询

        /// <summary>
        /// 按 PfSort（字段） 查询
        /// </summary>
        /// <param name = "pfSort"></param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfSort(int? pfSort)
        {
            return GetByPfSort(pfSort, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 PfSort（字段） 查询
        /// </summary>
        /// <param name = "pfSort"></param>
        /// <param name="tm">事务管理对象</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfSort(int? pfSort, TransactionManager tm)
        {
            return GetByPfSort(pfSort, 0, string.Empty, tm);
        }

        /// <summary>
        /// 按 PfSort（字段） 查询
        /// </summary>
        /// <param name = "pfSort"></param>
        /// <param name = "top">获取行数</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfSort(int? pfSort, int top)
        {
            return GetByPfSort(pfSort, top, string.Empty, null);
        }

        /// <summary>
        /// 按 PfSort（字段） 查询
        /// </summary>
        /// <param name = "pfSort"></param>
        /// <param name = "top">获取行数</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfSort(int? pfSort, int top, TransactionManager tm)
        {
            return GetByPfSort(pfSort, top, string.Empty, tm);
        }

        /// <summary>
        /// 按 PfSort（字段） 查询
        /// </summary>
        /// <param name = "pfSort"></param>
        /// <param name = "sort">排序表达式</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfSort(int? pfSort, string sort)
        {
            return GetByPfSort(pfSort, 0, sort, null);
        }

        /// <summary>
        /// 按 PfSort（字段） 查询
        /// </summary>
        /// <param name = "pfSort"></param>
        /// <param name = "sort">排序表达式</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfSort(int? pfSort, string sort, TransactionManager tm)
        {
            return GetByPfSort(pfSort, 0, sort, tm);
        }

        /// <summary>
        /// 按 PfSort（字段） 查询
        /// </summary>
        /// <param name = "pfSort"></param>
        /// <param name = "top">获取行数</param>
        /// <param name = "sort">排序表达式</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfSort(int? pfSort, int top, string sort, TransactionManager tm)
        {
            const string format = @"SELECT {0} Pf_id, Pf_name, Pf_imgUrl, Pf_imgWaterUrl, Pf_addUser, Pf_addTime, Pf_state, Pf_del, Pf_isRepair, Pf_newFunction, Pf_newEndTime, Pf_isNewShow, Pf_sort, Pf_text1, Pf_text2 FROM platform WHERE Pf_sort=@PfSort";
            string sql = format;

            if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
            sql = string.Format(sql, string.Empty);
            sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@PfSort", pfSort, DbType.Int32, 0)
                            .ExecList<NxPlatformEO>(NxPlatformEO.GetItem, tm);
        }

        #endregion

        #region  按 PfText1（字段） 查询

        /// <summary>
        /// 按 PfText1（字段） 查询
        /// </summary>
        /// <param name = "pfText1"></param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfText1(string pfText1)
        {
            return GetByPfText1(pfText1, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 PfText1（字段） 查询
        /// </summary>
        /// <param name = "pfText1"></param>
        /// <param name="tm">事务管理对象</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfText1(string pfText1, TransactionManager tm)
        {
            return GetByPfText1(pfText1, 0, string.Empty, tm);
        }

        /// <summary>
        /// 按 PfText1（字段） 查询
        /// </summary>
        /// <param name = "pfText1"></param>
        /// <param name = "top">获取行数</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfText1(string pfText1, int top)
        {
            return GetByPfText1(pfText1, top, string.Empty, null);
        }

        /// <summary>
        /// 按 PfText1（字段） 查询
        /// </summary>
        /// <param name = "pfText1"></param>
        /// <param name = "top">获取行数</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfText1(string pfText1, int top, TransactionManager tm)
        {
            return GetByPfText1(pfText1, top, string.Empty, tm);
        }

        /// <summary>
        /// 按 PfText1（字段） 查询
        /// </summary>
        /// <param name = "pfText1"></param>
        /// <param name = "sort">排序表达式</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfText1(string pfText1, string sort)
        {
            return GetByPfText1(pfText1, 0, sort, null);
        }

        /// <summary>
        /// 按 PfText1（字段） 查询
        /// </summary>
        /// <param name = "pfText1"></param>
        /// <param name = "sort">排序表达式</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfText1(string pfText1, string sort, TransactionManager tm)
        {
            return GetByPfText1(pfText1, 0, sort, tm);
        }

        /// <summary>
        /// 按 PfText1（字段） 查询
        /// </summary>
        /// <param name = "pfText1"></param>
        /// <param name = "top">获取行数</param>
        /// <param name = "sort">排序表达式</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfText1(string pfText1, int top, string sort, TransactionManager tm)
        {
            const string format = @"SELECT {0} Pf_id, Pf_name, Pf_imgUrl, Pf_imgWaterUrl, Pf_addUser, Pf_addTime, Pf_state, Pf_del, Pf_isRepair, Pf_newFunction, Pf_newEndTime, Pf_isNewShow, Pf_sort, Pf_text1, Pf_text2 FROM platform WHERE Pf_text1=@PfText1";
            string sql = format;

            if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
            sql = string.Format(sql, string.Empty);
            sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@PfText1", pfText1, DbType.String, 300)
                            .ExecList<NxPlatformEO>(NxPlatformEO.GetItem, tm);
        }

        #endregion

        #region  按 PfText2（字段） 查询

        /// <summary>
        /// 按 PfText2（字段） 查询
        /// </summary>
        /// <param name = "pfText2"></param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfText2(string pfText2)
        {
            return GetByPfText2(pfText2, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 PfText2（字段） 查询
        /// </summary>
        /// <param name = "pfText2"></param>
        /// <param name="tm">事务管理对象</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfText2(string pfText2, TransactionManager tm)
        {
            return GetByPfText2(pfText2, 0, string.Empty, tm);
        }

        /// <summary>
        /// 按 PfText2（字段） 查询
        /// </summary>
        /// <param name = "pfText2"></param>
        /// <param name = "top">获取行数</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfText2(string pfText2, int top)
        {
            return GetByPfText2(pfText2, top, string.Empty, null);
        }

        /// <summary>
        /// 按 PfText2（字段） 查询
        /// </summary>
        /// <param name = "pfText2"></param>
        /// <param name = "top">获取行数</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfText2(string pfText2, int top, TransactionManager tm)
        {
            return GetByPfText2(pfText2, top, string.Empty, tm);
        }

        /// <summary>
        /// 按 PfText2（字段） 查询
        /// </summary>
        /// <param name = "pfText2"></param>
        /// <param name = "sort">排序表达式</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfText2(string pfText2, string sort)
        {
            return GetByPfText2(pfText2, 0, sort, null);
        }

        /// <summary>
        /// 按 PfText2（字段） 查询
        /// </summary>
        /// <param name = "pfText2"></param>
        /// <param name = "sort">排序表达式</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfText2(string pfText2, string sort, TransactionManager tm)
        {
            return GetByPfText2(pfText2, 0, sort, tm);
        }

        /// <summary>
        /// 按 PfText2（字段） 查询
        /// </summary>
        /// <param name = "pfText2"></param>
        /// <param name = "top">获取行数</param>
        /// <param name = "sort">排序表达式</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetByPfText2(string pfText2, int top, string sort, TransactionManager tm)
        {
            const string format = @"SELECT {0} Pf_id, Pf_name, Pf_imgUrl, Pf_imgWaterUrl, Pf_addUser, Pf_addTime, Pf_state, Pf_del, Pf_isRepair, Pf_newFunction, Pf_newEndTime, Pf_isNewShow, Pf_sort, Pf_text1, Pf_text2 FROM platform WHERE Pf_text2=@PfText2";
            string sql = format;

            if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
            sql = string.Format(sql, string.Empty);
            sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@PfText2", pfText2, DbType.String, 300)
                            .ExecList<NxPlatformEO>(NxPlatformEO.GetItem, tm);
        }

        #endregion

        #region  自定义条件查询

        /// <summary>
        /// 获取所有数据
        /// </summary>
        /// <param name="tm">事务管理对象</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetAll(TransactionManager tm = null)
        {
            return GetTopSort(string.Empty, null, -1, string.Empty, tm);
        }

        /// <summary>
        /// 按自定义条件查询
        /// </summary>
        /// <param name = "where">自定义条件,where子句</param>
        /// <param name = "values">where子句中定义的参数值集合</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> Get(string where, params object[] values)
        {
            return GetTopSort(where, -1, string.Empty, null, values);
        }

        /// <summary>
        /// 按自定义条件查询
        /// </summary>
        /// <param name = "where">自定义条件,where子句</param>
        /// <param name = "paras">where子句中定义的参数集合</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> Get(string where, IEnumerable<DbParameter> paras)
        {
            return GetTopSort(where, paras, -1, string.Empty, null);
        }

        /// <summary>
        /// 按自定义条件查询
        /// </summary>
        /// <param name = "where">自定义条件,where子句</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> Get(string where, TransactionManager tm)
        {
            return GetTopSort(where, null, -1, string.Empty, tm);
        }

        /// <summary>
        /// 按自定义条件查询
        /// </summary>
        /// <param name = "where">自定义条件,where子句</param>
        /// <param name="tm">事务管理对象</param>
        /// <param name = "values">where子句中定义的参数值集合</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> Get(string where, TransactionManager tm, params object[] values)
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
        public virtual IEnumerable<NxPlatformEO> Get(string where, IEnumerable<DbParameter> paras, TransactionManager tm)
        {
            return GetTopSort(where, paras, -1, string.Empty, tm);
        }

        /// <summary>
        /// 按自定义条件查询
        /// </summary>
        /// <param name = "where">自定义条件,where子句</param>
        /// <param name = "top">获取行数</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetTop(string where, int top)
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
        public virtual IEnumerable<NxPlatformEO> GetTop(string where, int top, params object[] values)
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
        public virtual IEnumerable<NxPlatformEO> GetTop(string where, IEnumerable<DbParameter> paras, int top)
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
        public virtual IEnumerable<NxPlatformEO> GetTop(string where, int top, TransactionManager tm)
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
        public virtual IEnumerable<NxPlatformEO> GetTop(string where, int top, TransactionManager tm, params object[] values)
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
        public virtual IEnumerable<NxPlatformEO> GetTop(string where, IEnumerable<DbParameter> paras, int top, TransactionManager tm)
        {
            return GetTopSort(where, paras, top, string.Empty, tm);
        }

        /// <summary>
        /// 按自定义条件查询
        /// </summary>
        /// <param name = "where">自定义条件,where子句</param>
        /// <param name = "sort">排序表达式</param>
        /// <return>实体对象集合</return>
        public virtual IEnumerable<NxPlatformEO> GetSort(string where, string sort)
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
        public virtual IEnumerable<NxPlatformEO> GetSort(string where, string sort, params object[] values)
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
        public virtual IEnumerable<NxPlatformEO> GetSort(string where, IEnumerable<DbParameter> paras, string sort)
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
        public virtual IEnumerable<NxPlatformEO> GetSort(string where, string sort, TransactionManager tm)
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
        public virtual IEnumerable<NxPlatformEO> GetSort(string where, string sort, TransactionManager tm, params object[] values)
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
        public virtual IEnumerable<NxPlatformEO> GetSort(string where, IEnumerable<DbParameter> paras, string sort, TransactionManager tm)
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
        public virtual IEnumerable<NxPlatformEO> GetTopSort(string where, int top, string sort)
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
        public virtual IEnumerable<NxPlatformEO> GetTopSort(string where, int top, string sort, params object[] values)
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
        public virtual IEnumerable<NxPlatformEO> GetTopSort(string where, IEnumerable<DbParameter> paras, int top, string sort)
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
        public virtual IEnumerable<NxPlatformEO> GetTopSort(string where, int top, string sort, TransactionManager tm)
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
        public virtual IEnumerable<NxPlatformEO> GetTopSort(string where, int top, string sort, TransactionManager tm, params object[] values)
        {
            const string format = @"SELECT {0} Pf_id, Pf_name, Pf_imgUrl, Pf_imgWaterUrl, Pf_addUser, Pf_addTime, Pf_state, Pf_del, Pf_isRepair, Pf_newFunction, Pf_newEndTime, Pf_isNewShow, Pf_sort, Pf_text1, Pf_text2 FROM platform";
            string sql = format;

            if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
            if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
            sql = string.Format(sql, string.Empty);
            sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
            return Database.CreateSqlDao(sql)
                            .AddInParameters(values)
                            .ExecList<NxPlatformEO>(NxPlatformEO.GetItem, tm);
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
        public virtual IEnumerable<NxPlatformEO> GetTopSort(string where, IEnumerable<DbParameter> paras, int top, string sort, TransactionManager tm)
        {
            const string format = @"SELECT {0} Pf_id, Pf_name, Pf_imgUrl, Pf_imgWaterUrl, Pf_addUser, Pf_addTime, Pf_state, Pf_del, Pf_isRepair, Pf_newFunction, Pf_newEndTime, Pf_isNewShow, Pf_sort, Pf_text1, Pf_text2 FROM platform";
            string sql = format;

            if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
            if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
            sql = string.Format(sql, string.Empty);
            sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
            return Database.CreateSqlDao(sql)
                            .AddParameters(paras)
                            .ExecList<NxPlatformEO>(NxPlatformEO.GetItem, tm);
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
            const string format = @"SELECT Pf_id, Pf_name, Pf_imgUrl, Pf_imgWaterUrl, Pf_addUser, Pf_addTime, Pf_state, Pf_del, Pf_isRepair, Pf_newFunction, Pf_newEndTime, Pf_isNewShow, Pf_sort, Pf_text1, Pf_text2 FROM platform {0} {1}";
            string sql = string.Format(format, string.IsNullOrEmpty(where) ? string.Empty : "WHERE " + where, string.IsNullOrEmpty(sort) ? string.Empty : "ORDER BY " + sort);

            return Database.CreatePager(sql, pageSize, "Pf_id");
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
        public virtual List<NxPlatformEO> GetPageList(int pageIndex, int pageSize, string where = null, string sort = null, IEnumerable<DbParameter> paras = null)
        {
            var pager = GetPager(pageSize, where, sort);

            pager.AddParameters(paras);
            return pager.GetPageList<NxPlatformEO>(pageIndex);
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
        public virtual IEnumerable<NxPlatformEO> GetPageMutil(int pageIndex, int pageSize, string where = null, string sort = null, IEnumerable<DbParameter> paras = null)
        {
            var pager = GetPager(pageSize, where, sort);

            pager.AddParameters(paras);
            return pager.GetPageMutil<NxPlatformEO>(pageIndex);
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
        public virtual int Add(NxPlatformEO item, TransactionManager tm = null)
        {
            const string sql = @"INSERT INTO platform (Pf_id, Pf_name, Pf_imgUrl, Pf_imgWaterUrl, Pf_addUser, Pf_addTime, Pf_state, Pf_del, Pf_isRepair, Pf_newFunction, Pf_newEndTime, Pf_isNewShow, Pf_sort, Pf_text1, Pf_text2) VALUES (@Pf_id, @Pf_name, @Pf_imgUrl, @Pf_imgWaterUrl, @Pf_addUser, @Pf_addTime, @Pf_state, @Pf_del, @Pf_isRepair, @Pf_newFunction, @Pf_newEndTime, @Pf_isNewShow, @Pf_sort, @Pf_text1, @Pf_text2) ";
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@Pf_id", item.PfId, DbType.String, 150)
                            .AddInParameter("@Pf_name", item.PfName != null ? (object)item.PfName : DBNull.Value, DbType.String, 150)
                            .AddInParameter("@Pf_imgUrl", item.PfImgUrl != null ? (object)item.PfImgUrl : DBNull.Value, DbType.String, 600)
                            .AddInParameter("@Pf_imgWaterUrl", item.PfImgWaterUrl != null ? (object)item.PfImgWaterUrl : DBNull.Value, DbType.String, 765)
                            .AddInParameter("@Pf_addUser", item.PfAddUser != null ? (object)item.PfAddUser : DBNull.Value, DbType.String, 150)
                            .AddInParameter("@Pf_addTime", item.PfAddTime, DbType.DateTime, 0)
                            .AddInParameter("@Pf_state", item.PfState, DbType.String, 3)
                            .AddInParameter("@Pf_del", item.PfDel, DbType.String, 3)
                            .AddInParameter("@Pf_isRepair", item.PfIsRepair != null ? (object)item.PfIsRepair : DBNull.Value, DbType.String, 3)
                            .AddInParameter("@Pf_newFunction", item.PfNewFunction != null ? (object)item.PfNewFunction : DBNull.Value, DbType.String, 6000)
                            .AddInParameter("@Pf_newEndTime", item.PfNewEndTime, DbType.DateTime, 0)
                            .AddInParameter("@Pf_isNewShow", item.PfIsNewShow != null ? (object)item.PfIsNewShow : DBNull.Value, DbType.String, 3)
                            .AddInParameter("@Pf_sort", item.PfSort.HasValue ? (object)item.PfSort.Value : DBNull.Value, DbType.Int32, 0)
                            .AddInParameter("@Pf_text1", item.PfText1 != null ? (object)item.PfText1 : DBNull.Value, DbType.String, 300)
                            .AddInParameter("@Pf_text2", item.PfText2 != null ? (object)item.PfText2 : DBNull.Value, DbType.String, 300)
                            .ExecNonQuery(tm);
        }

        /// <summary>
        /// 插入一组数据
        /// </summary>
        /// <param name = "items">要插入的实体对象集合</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>受影响的行数</return>
        public virtual int Add(IEnumerable<NxPlatformEO> items, TransactionManager tm = null)
        {
            int ret = 0;
            const string sql = @"INSERT INTO platform (Pf_id, Pf_name, Pf_imgUrl, Pf_imgWaterUrl, Pf_addUser, Pf_addTime, Pf_state, Pf_del, Pf_isRepair, Pf_newFunction, Pf_newEndTime, Pf_isNewShow, Pf_sort, Pf_text1, Pf_text2) VALUES (@Pf_id, @Pf_name, @Pf_imgUrl, @Pf_imgWaterUrl, @Pf_addUser, @Pf_addTime, @Pf_state, @Pf_del, @Pf_isRepair, @Pf_newFunction, @Pf_newEndTime, @Pf_isNewShow, @Pf_sort, @Pf_text1, @Pf_text2) ";
            var sqlDao = Database.CreateSqlDao(sql)
                                    .AddParameter("@Pf_id", DbType.String, 150)
                                    .AddParameter("@Pf_name", DbType.String, 150)
                                    .AddParameter("@Pf_imgUrl", DbType.String, 600)
                                    .AddParameter("@Pf_imgWaterUrl", DbType.String, 765)
                                    .AddParameter("@Pf_addUser", DbType.String, 150)
                                    .AddParameter("@Pf_addTime", DbType.DateTime, 0)
                                    .AddParameter("@Pf_state", DbType.String, 3)
                                    .AddParameter("@Pf_del", DbType.String, 3)
                                    .AddParameter("@Pf_isRepair", DbType.String, 3)
                                    .AddParameter("@Pf_newFunction", DbType.String, 6000)
                                    .AddParameter("@Pf_newEndTime", DbType.DateTime, 0)
                                    .AddParameter("@Pf_isNewShow", DbType.String, 3)
                                    .AddParameter("@Pf_sort", DbType.Int32, 0)
                                    .AddParameter("@Pf_text1", DbType.String, 300)
                                    .AddParameter("@Pf_text2", DbType.String, 300);

            foreach (NxPlatformEO item in items)
            {
                sqlDao
                    .SetParameterValue("@Pf_id", item.PfId)
                    .SetParameterValue("@Pf_name", item.PfName != null ? (object)item.PfName : DBNull.Value)
                    .SetParameterValue("@Pf_imgUrl", item.PfImgUrl != null ? (object)item.PfImgUrl : DBNull.Value)
                    .SetParameterValue("@Pf_imgWaterUrl", item.PfImgWaterUrl != null ? (object)item.PfImgWaterUrl : DBNull.Value)
                    .SetParameterValue("@Pf_addUser", item.PfAddUser != null ? (object)item.PfAddUser : DBNull.Value)
                    .SetParameterValue("@Pf_addTime", item.PfAddTime)
                    .SetParameterValue("@Pf_state", item.PfState)
                    .SetParameterValue("@Pf_del", item.PfDel)
                    .SetParameterValue("@Pf_isRepair", item.PfIsRepair != null ? (object)item.PfIsRepair : DBNull.Value)
                    .SetParameterValue("@Pf_newFunction", item.PfNewFunction != null ? (object)item.PfNewFunction : DBNull.Value)
                    .SetParameterValue("@Pf_newEndTime", item.PfNewEndTime)
                    .SetParameterValue("@Pf_isNewShow", item.PfIsNewShow != null ? (object)item.PfIsNewShow : DBNull.Value)
                    .SetParameterValue("@Pf_sort", item.PfSort.HasValue ? (object)item.PfSort.Value : DBNull.Value)
                    .SetParameterValue("@Pf_text1", item.PfText1 != null ? (object)item.PfText1 : DBNull.Value)
                    .SetParameterValue("@Pf_text2", item.PfText2 != null ? (object)item.PfText2 : DBNull.Value)
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
        public virtual int Put(NxPlatformEO item, TransactionManager tm = null)
        {
            const string sql = @"UPDATE platform SET Pf_id=@Pf_id, Pf_name=@Pf_name, Pf_imgUrl=@Pf_imgUrl, Pf_imgWaterUrl=@Pf_imgWaterUrl, Pf_addUser=@Pf_addUser, Pf_addTime=@Pf_addTime, Pf_state=@Pf_state, Pf_del=@Pf_del, Pf_isRepair=@Pf_isRepair, Pf_newFunction=@Pf_newFunction, Pf_newEndTime=@Pf_newEndTime, Pf_isNewShow=@Pf_isNewShow, Pf_sort=@Pf_sort, Pf_text1=@Pf_text1, Pf_text2=@Pf_text2 WHERE Pf_id=@OriginalPf_id";
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@OriginalPfId", (item.HasOriginal) ? item.OriginalPfId : item.PfId, DbType.String, 150)
                            .AddInParameter("@Pf_id", item.PfId, DbType.String, 150)
                            .AddInParameter("@Pf_name", item.PfName != null ? (object)item.PfName : DBNull.Value, DbType.String, 150)
                            .AddInParameter("@Pf_imgUrl", item.PfImgUrl != null ? (object)item.PfImgUrl : DBNull.Value, DbType.String, 600)
                            .AddInParameter("@Pf_imgWaterUrl", item.PfImgWaterUrl != null ? (object)item.PfImgWaterUrl : DBNull.Value, DbType.String, 765)
                            .AddInParameter("@Pf_addUser", item.PfAddUser != null ? (object)item.PfAddUser : DBNull.Value, DbType.String, 150)
                            .AddInParameter("@Pf_addTime", item.PfAddTime, DbType.DateTime, 0)
                            .AddInParameter("@Pf_state", item.PfState, DbType.String, 3)
                            .AddInParameter("@Pf_del", item.PfDel, DbType.String, 3)
                            .AddInParameter("@Pf_isRepair", item.PfIsRepair != null ? (object)item.PfIsRepair : DBNull.Value, DbType.String, 3)
                            .AddInParameter("@Pf_newFunction", item.PfNewFunction != null ? (object)item.PfNewFunction : DBNull.Value, DbType.String, 6000)
                            .AddInParameter("@Pf_newEndTime", item.PfNewEndTime, DbType.DateTime, 0)
                            .AddInParameter("@Pf_isNewShow", item.PfIsNewShow != null ? (object)item.PfIsNewShow : DBNull.Value, DbType.String, 3)
                            .AddInParameter("@Pf_sort", item.PfSort.HasValue ? (object)item.PfSort.Value : DBNull.Value, DbType.Int32, 0)
                            .AddInParameter("@Pf_text1", item.PfText1 != null ? (object)item.PfText1 : DBNull.Value, DbType.String, 300)
                            .AddInParameter("@Pf_text2", item.PfText2 != null ? (object)item.PfText2 : DBNull.Value, DbType.String, 300)
                            .ExecNonQuery(tm);
        }


        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name = "items">要更新的实体对象集合</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>受影响的行数</return>
        public virtual int Put(IEnumerable<NxPlatformEO> items, TransactionManager tm = null)
        {

            int ret = 0;
            const string sql = @"UPDATE platform SET Pf_id=@Pf_id, Pf_name=@Pf_name, Pf_imgUrl=@Pf_imgUrl, Pf_imgWaterUrl=@Pf_imgWaterUrl, Pf_addUser=@Pf_addUser, Pf_addTime=@Pf_addTime, Pf_state=@Pf_state, Pf_del=@Pf_del, Pf_isRepair=@Pf_isRepair, Pf_newFunction=@Pf_newFunction, Pf_newEndTime=@Pf_newEndTime, Pf_isNewShow=@Pf_isNewShow, Pf_sort=@Pf_sort, Pf_text1=@Pf_text1, Pf_text2=@Pf_text2 WHERE Pf_id=@OriginalPf_id";
            var sqlDao = Database.CreateSqlDao(sql)
                                    .AddParameter("@OriginalPfId", DbType.String, 150)
                                    .AddParameter("@Pf_id", DbType.String, 150)
                                    .AddParameter("@Pf_name", DbType.String, 150)
                                    .AddParameter("@Pf_imgUrl", DbType.String, 600)
                                    .AddParameter("@Pf_imgWaterUrl", DbType.String, 765)
                                    .AddParameter("@Pf_addUser", DbType.String, 150)
                                    .AddParameter("@Pf_addTime", DbType.DateTime, 0)
                                    .AddParameter("@Pf_state", DbType.String, 3)
                                    .AddParameter("@Pf_del", DbType.String, 3)
                                    .AddParameter("@Pf_isRepair", DbType.String, 3)
                                    .AddParameter("@Pf_newFunction", DbType.String, 6000)
                                    .AddParameter("@Pf_newEndTime", DbType.DateTime, 0)
                                    .AddParameter("@Pf_isNewShow", DbType.String, 3)
                                    .AddParameter("@Pf_sort", DbType.Int32, 0)
                                    .AddParameter("@Pf_text1", DbType.String, 300)
                                    .AddParameter("@Pf_text2", DbType.String, 300);

            foreach (NxPlatformEO item in items)
            {
                ret += sqlDao
                            .SetParameterValue("@OriginalPfId", (item.HasOriginal) ? item.OriginalPfId : item.PfId)
                            .SetParameterValue("@Pf_id", item.PfId)
                            .SetParameterValue("@Pf_name", item.PfName != null ? (object)item.PfName : DBNull.Value)
                            .SetParameterValue("@Pf_imgUrl", item.PfImgUrl != null ? (object)item.PfImgUrl : DBNull.Value)
                            .SetParameterValue("@Pf_imgWaterUrl", item.PfImgWaterUrl != null ? (object)item.PfImgWaterUrl : DBNull.Value)
                            .SetParameterValue("@Pf_addUser", item.PfAddUser != null ? (object)item.PfAddUser : DBNull.Value)
                            .SetParameterValue("@Pf_addTime", item.PfAddTime)
                            .SetParameterValue("@Pf_state", item.PfState)
                            .SetParameterValue("@Pf_del", item.PfDel)
                            .SetParameterValue("@Pf_isRepair", item.PfIsRepair != null ? (object)item.PfIsRepair : DBNull.Value)
                            .SetParameterValue("@Pf_newFunction", item.PfNewFunction != null ? (object)item.PfNewFunction : DBNull.Value)
                            .SetParameterValue("@Pf_newEndTime", item.PfNewEndTime)
                            .SetParameterValue("@Pf_isNewShow", item.PfIsNewShow != null ? (object)item.PfIsNewShow : DBNull.Value)
                            .SetParameterValue("@Pf_sort", item.PfSort.HasValue ? (object)item.PfSort.Value : DBNull.Value)
                            .SetParameterValue("@Pf_text1", item.PfText1 != null ? (object)item.PfText1 : DBNull.Value)
                            .SetParameterValue("@Pf_text2", item.PfText2 != null ? (object)item.PfText2 : DBNull.Value)
                            .ExecNonQuery(tm);
            }
            return ret;
        }


        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// <param name = "pfId"></param>
        /// <param name = "pfName"></param>
        /// <param name="tm">事务管理对象</param>
        /// <return>受影响的行数</return>
        public virtual int PutPfNameByPK(string pfId, string pfName, TransactionManager tm = null)
        {
            const string sql = @"UPDATE platform SET Pf_name = @Pf_name  WHERE Pf_id = @Pf_id";
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@Pf_id", pfId, DbType.String, 150)
                            .AddInParameter("@Pf_name", pfName != null ? (object)pfName : DBNull.Value, DbType.String, 150)
                            .ExecNonQuery(tm);
        }

        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// <param name = "pfId"></param>
        /// <param name = "pfImgUrl"></param>
        /// <param name="tm">事务管理对象</param>
        /// <return>受影响的行数</return>
        public virtual int PutPfImgUrlByPK(string pfId, string pfImgUrl, TransactionManager tm = null)
        {
            const string sql = @"UPDATE platform SET Pf_imgUrl = @Pf_imgUrl  WHERE Pf_id = @Pf_id";
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@Pf_id", pfId, DbType.String, 150)
                            .AddInParameter("@Pf_imgUrl", pfImgUrl != null ? (object)pfImgUrl : DBNull.Value, DbType.String, 600)
                            .ExecNonQuery(tm);
        }

        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// <param name = "pfId"></param>
        /// <param name = "pfImgWaterUrl"></param>
        /// <param name="tm">事务管理对象</param>
        /// <return>受影响的行数</return>
        public virtual int PutPfImgWaterUrlByPK(string pfId, string pfImgWaterUrl, TransactionManager tm = null)
        {
            const string sql = @"UPDATE platform SET Pf_imgWaterUrl = @Pf_imgWaterUrl  WHERE Pf_id = @Pf_id";
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@Pf_id", pfId, DbType.String, 150)
                            .AddInParameter("@Pf_imgWaterUrl", pfImgWaterUrl != null ? (object)pfImgWaterUrl : DBNull.Value, DbType.String, 765)
                            .ExecNonQuery(tm);
        }

        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// <param name = "pfId"></param>
        /// <param name = "pfAddUser"></param>
        /// <param name="tm">事务管理对象</param>
        /// <return>受影响的行数</return>
        public virtual int PutPfAddUserByPK(string pfId, string pfAddUser, TransactionManager tm = null)
        {
            const string sql = @"UPDATE platform SET Pf_addUser = @Pf_addUser  WHERE Pf_id = @Pf_id";
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@Pf_id", pfId, DbType.String, 150)
                            .AddInParameter("@Pf_addUser", pfAddUser != null ? (object)pfAddUser : DBNull.Value, DbType.String, 150)
                            .ExecNonQuery(tm);
        }

        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// <param name = "pfId"></param>
        /// <param name = "pfAddTime"></param>
        /// <param name="tm">事务管理对象</param>
        /// <return>受影响的行数</return>
        public virtual int PutPfAddTimeByPK(string pfId, DateTime pfAddTime, TransactionManager tm = null)
        {
            const string sql = @"UPDATE platform SET Pf_addTime = @Pf_addTime  WHERE Pf_id = @Pf_id";
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@Pf_id", pfId, DbType.String, 150)
                            .AddInParameter("@Pf_addTime", pfAddTime, DbType.DateTime, 0)
                            .ExecNonQuery(tm);
        }

        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// <param name = "pfId"></param>
        /// <param name = "pfState"></param>
        /// <param name="tm">事务管理对象</param>
        /// <return>受影响的行数</return>
        public virtual int PutPfStateByPK(string pfId, string pfState, TransactionManager tm = null)
        {
            const string sql = @"UPDATE platform SET Pf_state = @Pf_state  WHERE Pf_id = @Pf_id";
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@Pf_id", pfId, DbType.String, 150)
                            .AddInParameter("@Pf_state", pfState, DbType.String, 3)
                            .ExecNonQuery(tm);
        }

        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// <param name = "pfId"></param>
        /// <param name = "pfDel"></param>
        /// <param name="tm">事务管理对象</param>
        /// <return>受影响的行数</return>
        public virtual int PutPfDelByPK(string pfId, string pfDel, TransactionManager tm = null)
        {
            const string sql = @"UPDATE platform SET Pf_del = @Pf_del  WHERE Pf_id = @Pf_id";
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@Pf_id", pfId, DbType.String, 150)
                            .AddInParameter("@Pf_del", pfDel, DbType.String, 3)
                            .ExecNonQuery(tm);
        }

        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// <param name = "pfId"></param>
        /// <param name = "pfIsRepair"></param>
        /// <param name="tm">事务管理对象</param>
        /// <return>受影响的行数</return>
        public virtual int PutPfIsRepairByPK(string pfId, string pfIsRepair, TransactionManager tm = null)
        {
            const string sql = @"UPDATE platform SET Pf_isRepair = @Pf_isRepair  WHERE Pf_id = @Pf_id";
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@Pf_id", pfId, DbType.String, 150)
                            .AddInParameter("@Pf_isRepair", pfIsRepair != null ? (object)pfIsRepair : DBNull.Value, DbType.String, 3)
                            .ExecNonQuery(tm);
        }

        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// <param name = "pfId"></param>
        /// <param name = "pfNewFunction"></param>
        /// <param name="tm">事务管理对象</param>
        /// <return>受影响的行数</return>
        public virtual int PutPfNewFunctionByPK(string pfId, string pfNewFunction, TransactionManager tm = null)
        {
            const string sql = @"UPDATE platform SET Pf_newFunction = @Pf_newFunction  WHERE Pf_id = @Pf_id";
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@Pf_id", pfId, DbType.String, 150)
                            .AddInParameter("@Pf_newFunction", pfNewFunction != null ? (object)pfNewFunction : DBNull.Value, DbType.String, 6000)
                            .ExecNonQuery(tm);
        }

        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// <param name = "pfId"></param>
        /// <param name = "pfNewEndTime"></param>
        /// <param name="tm">事务管理对象</param>
        /// <return>受影响的行数</return>
        public virtual int PutPfNewEndTimeByPK(string pfId, DateTime pfNewEndTime, TransactionManager tm = null)
        {
            const string sql = @"UPDATE platform SET Pf_newEndTime = @Pf_newEndTime  WHERE Pf_id = @Pf_id";
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@Pf_id", pfId, DbType.String, 150)
                            .AddInParameter("@Pf_newEndTime", pfNewEndTime, DbType.DateTime, 0)
                            .ExecNonQuery(tm);
        }

        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// <param name = "pfId"></param>
        /// <param name = "pfIsNewShow"></param>
        /// <param name="tm">事务管理对象</param>
        /// <return>受影响的行数</return>
        public virtual int PutPfIsNewShowByPK(string pfId, string pfIsNewShow, TransactionManager tm = null)
        {
            const string sql = @"UPDATE platform SET Pf_isNewShow = @Pf_isNewShow  WHERE Pf_id = @Pf_id";
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@Pf_id", pfId, DbType.String, 150)
                            .AddInParameter("@Pf_isNewShow", pfIsNewShow != null ? (object)pfIsNewShow : DBNull.Value, DbType.String, 3)
                            .ExecNonQuery(tm);
        }

        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// <param name = "pfId"></param>
        /// <param name = "pfSort"></param>
        /// <param name="tm">事务管理对象</param>
        /// <return>受影响的行数</return>
        public virtual int PutPfSortByPK(string pfId, int? pfSort, TransactionManager tm = null)
        {
            const string sql = @"UPDATE platform SET Pf_sort = @Pf_sort  WHERE Pf_id = @Pf_id";
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@Pf_id", pfId, DbType.String, 150)
                            .AddInParameter("@Pf_sort", pfSort.HasValue ? (object)pfSort.Value : DBNull.Value, DbType.Int32, 0)
                            .ExecNonQuery(tm);
        }

        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// <param name = "pfId"></param>
        /// <param name = "pfText1"></param>
        /// <param name="tm">事务管理对象</param>
        /// <return>受影响的行数</return>
        public virtual int PutPfText1ByPK(string pfId, string pfText1, TransactionManager tm = null)
        {
            const string sql = @"UPDATE platform SET Pf_text1 = @Pf_text1  WHERE Pf_id = @Pf_id";
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@Pf_id", pfId, DbType.String, 150)
                            .AddInParameter("@Pf_text1", pfText1 != null ? (object)pfText1 : DBNull.Value, DbType.String, 300)
                            .ExecNonQuery(tm);
        }

        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// <param name = "pfId"></param>
        /// <param name = "pfText2"></param>
        /// <param name="tm">事务管理对象</param>
        /// <return>受影响的行数</return>
        public virtual int PutPfText2ByPK(string pfId, string pfText2, TransactionManager tm = null)
        {
            const string sql = @"UPDATE platform SET Pf_text2 = @Pf_text2  WHERE Pf_id = @Pf_id";
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@Pf_id", pfId, DbType.String, 150)
                            .AddInParameter("@Pf_text2", pfText2 != null ? (object)pfText2 : DBNull.Value, DbType.String, 300)
                            .ExecNonQuery(tm);
        }


        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// <param name = "pfName"></param>
        /// <param name="tm">事务管理对象</param>
        /// <return>受影响的行数</return>
        public virtual int PutPfName(string pfName, TransactionManager tm = null)
        {
            const string sql = @"UPDATE platform SET Pf_name=@Pf_name";
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@Pf_name", pfName != null ? (object)pfName : DBNull.Value, DbType.String, 150)
                            .ExecNonQuery(tm);
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// <param name = "pfImgUrl"></param>
        /// <param name="tm">事务管理对象</param>
        /// <return>受影响的行数</return>
        public virtual int PutPfImgUrl(string pfImgUrl, TransactionManager tm = null)
        {
            const string sql = @"UPDATE platform SET Pf_imgUrl=@Pf_imgUrl";
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@Pf_imgUrl", pfImgUrl != null ? (object)pfImgUrl : DBNull.Value, DbType.String, 600)
                            .ExecNonQuery(tm);
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// <param name = "pfImgWaterUrl"></param>
        /// <param name="tm">事务管理对象</param>
        /// <return>受影响的行数</return>
        public virtual int PutPfImgWaterUrl(string pfImgWaterUrl, TransactionManager tm = null)
        {
            const string sql = @"UPDATE platform SET Pf_imgWaterUrl=@Pf_imgWaterUrl";
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@Pf_imgWaterUrl", pfImgWaterUrl != null ? (object)pfImgWaterUrl : DBNull.Value, DbType.String, 765)
                            .ExecNonQuery(tm);
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// <param name = "pfAddUser"></param>
        /// <param name="tm">事务管理对象</param>
        /// <return>受影响的行数</return>
        public virtual int PutPfAddUser(string pfAddUser, TransactionManager tm = null)
        {
            const string sql = @"UPDATE platform SET Pf_addUser=@Pf_addUser";
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@Pf_addUser", pfAddUser != null ? (object)pfAddUser : DBNull.Value, DbType.String, 150)
                            .ExecNonQuery(tm);
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// <param name = "pfAddTime"></param>
        /// <param name="tm">事务管理对象</param>
        /// <return>受影响的行数</return>
        public virtual int PutPfAddTime(DateTime pfAddTime, TransactionManager tm = null)
        {
            const string sql = @"UPDATE platform SET Pf_addTime=@Pf_addTime";
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@Pf_addTime", pfAddTime, DbType.DateTime, 0)
                            .ExecNonQuery(tm);
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// <param name = "pfState"></param>
        /// <param name="tm">事务管理对象</param>
        /// <return>受影响的行数</return>
        public virtual int PutPfState(string pfState, TransactionManager tm = null)
        {
            const string sql = @"UPDATE platform SET Pf_state=@Pf_state";
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@Pf_state", pfState, DbType.String, 3)
                            .ExecNonQuery(tm);
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// <param name = "pfDel"></param>
        /// <param name="tm">事务管理对象</param>
        /// <return>受影响的行数</return>
        public virtual int PutPfDel(string pfDel, TransactionManager tm = null)
        {
            const string sql = @"UPDATE platform SET Pf_del=@Pf_del";
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@Pf_del", pfDel, DbType.String, 3)
                            .ExecNonQuery(tm);
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// <param name = "pfIsRepair"></param>
        /// <param name="tm">事务管理对象</param>
        /// <return>受影响的行数</return>
        public virtual int PutPfIsRepair(string pfIsRepair, TransactionManager tm = null)
        {
            const string sql = @"UPDATE platform SET Pf_isRepair=@Pf_isRepair";
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@Pf_isRepair", pfIsRepair != null ? (object)pfIsRepair : DBNull.Value, DbType.String, 3)
                            .ExecNonQuery(tm);
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// <param name = "pfNewFunction"></param>
        /// <param name="tm">事务管理对象</param>
        /// <return>受影响的行数</return>
        public virtual int PutPfNewFunction(string pfNewFunction, TransactionManager tm = null)
        {
            const string sql = @"UPDATE platform SET Pf_newFunction=@Pf_newFunction";
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@Pf_newFunction", pfNewFunction != null ? (object)pfNewFunction : DBNull.Value, DbType.String, 6000)
                            .ExecNonQuery(tm);
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// <param name = "pfNewEndTime"></param>
        /// <param name="tm">事务管理对象</param>
        /// <return>受影响的行数</return>
        public virtual int PutPfNewEndTime(DateTime pfNewEndTime, TransactionManager tm = null)
        {
            const string sql = @"UPDATE platform SET Pf_newEndTime=@Pf_newEndTime";
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@Pf_newEndTime", pfNewEndTime, DbType.DateTime, 0)
                            .ExecNonQuery(tm);
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// <param name = "pfIsNewShow"></param>
        /// <param name="tm">事务管理对象</param>
        /// <return>受影响的行数</return>
        public virtual int PutPfIsNewShow(string pfIsNewShow, TransactionManager tm = null)
        {
            const string sql = @"UPDATE platform SET Pf_isNewShow=@Pf_isNewShow";
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@Pf_isNewShow", pfIsNewShow != null ? (object)pfIsNewShow : DBNull.Value, DbType.String, 3)
                            .ExecNonQuery(tm);
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// <param name = "pfSort"></param>
        /// <param name="tm">事务管理对象</param>
        /// <return>受影响的行数</return>
        public virtual int PutPfSort(int? pfSort, TransactionManager tm = null)
        {
            const string sql = @"UPDATE platform SET Pf_sort=@Pf_sort";
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@Pf_sort", pfSort.HasValue ? (object)pfSort.Value : DBNull.Value, DbType.Int32, 0)
                            .ExecNonQuery(tm);
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// <param name = "pfText1"></param>
        /// <param name="tm">事务管理对象</param>
        /// <return>受影响的行数</return>
        public virtual int PutPfText1(string pfText1, TransactionManager tm = null)
        {
            const string sql = @"UPDATE platform SET Pf_text1=@Pf_text1";
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@Pf_text1", pfText1 != null ? (object)pfText1 : DBNull.Value, DbType.String, 300)
                            .ExecNonQuery(tm);
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// <param name = "pfText2"></param>
        /// <param name="tm">事务管理对象</param>
        /// <return>受影响的行数</return>
        public virtual int PutPfText2(string pfText2, TransactionManager tm = null)
        {
            const string sql = @"UPDATE platform SET Pf_text2=@Pf_text2";
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@Pf_text2", pfText2 != null ? (object)pfText2 : DBNull.Value, DbType.String, 300)
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
            const string format = @"UPDATE platform SET {0} {1}";
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
            const string format = @"UPDATE platform SET {0} {1}";
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
        /// <param name = "pfId"></param>
        /// <param name="tm">事务管理对象</param>
        public virtual int RemoveByPK(string pfId, TransactionManager tm = null)
        {
            const string sql = @"DELETE FROM platform WHERE Pf_id=@Pf_id";
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@Pf_id", pfId, DbType.String, 150)
                            .ExecNonQuery(tm);
        }

        /// <summary>
        /// 删除指定实体对应的记录
        /// </summary>
        /// <param name = "item">要删除的实体</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>受影响的行数</return>
        public virtual int Remove(NxPlatformEO item, TransactionManager tm = null)
        {
            return RemoveByPK(item.PfId, tm);
        }

        /// <summary>
        /// 删除指定实体集合对应的记录集
        /// </summary>
        /// <param name = "items">要删除的实体集合</param>
        /// <param name="tm">事务管理对象</param>
        /// <return>受影响的行数</return>
        public virtual int Remove(IEnumerable<NxPlatformEO> items, TransactionManager tm = null)
        {
            const string sql = @"DELETE FROM platform WHERE Pf_id=@OriginalPf_id";
            var sqlDao = Database.CreateSqlDao(sql)
                                    .AddParameter("@OriginalPfId", DbType.String, 150);
            int ret = 0;
            foreach (NxPlatformEO item in items)
            {
                ret += sqlDao
                            .SetParameterValue("@OriginalPfId", (item.HasOriginal) ? item.OriginalPfId : item.PfId)
                            .ExecNonQuery(tm);
            }
            return ret;
        }




        /// <summary>
        /// 按字段删除
        /// </summary>
        /// <param name = "pfName"></param>
        /// <param name="tm">事务管理对象</param>
        public virtual int RemoveByPfName(string pfName, TransactionManager tm = null)
        {
            const string sql = @"DELETE FROM platform WHERE Pf_name=@Pf_name";
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@Pf_name", pfName != null ? (object)pfName : DBNull.Value, DbType.String, 150)
                            .ExecNonQuery(tm);
        }

        /// <summary>
        /// 按字段删除
        /// </summary>
        /// <param name = "pfImgUrl"></param>
        /// <param name="tm">事务管理对象</param>
        public virtual int RemoveByPfImgUrl(string pfImgUrl, TransactionManager tm = null)
        {
            const string sql = @"DELETE FROM platform WHERE Pf_imgUrl=@Pf_imgUrl";
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@Pf_imgUrl", pfImgUrl != null ? (object)pfImgUrl : DBNull.Value, DbType.String, 600)
                            .ExecNonQuery(tm);
        }

        /// <summary>
        /// 按字段删除
        /// </summary>
        /// <param name = "pfImgWaterUrl"></param>
        /// <param name="tm">事务管理对象</param>
        public virtual int RemoveByPfImgWaterUrl(string pfImgWaterUrl, TransactionManager tm = null)
        {
            const string sql = @"DELETE FROM platform WHERE Pf_imgWaterUrl=@Pf_imgWaterUrl";
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@Pf_imgWaterUrl", pfImgWaterUrl != null ? (object)pfImgWaterUrl : DBNull.Value, DbType.String, 765)
                            .ExecNonQuery(tm);
        }

        /// <summary>
        /// 按字段删除
        /// </summary>
        /// <param name = "pfAddUser"></param>
        /// <param name="tm">事务管理对象</param>
        public virtual int RemoveByPfAddUser(string pfAddUser, TransactionManager tm = null)
        {
            const string sql = @"DELETE FROM platform WHERE Pf_addUser=@Pf_addUser";
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@Pf_addUser", pfAddUser != null ? (object)pfAddUser : DBNull.Value, DbType.String, 150)
                            .ExecNonQuery(tm);
        }

        /// <summary>
        /// 按字段删除
        /// </summary>
        /// <param name = "pfAddTime"></param>
        /// <param name="tm">事务管理对象</param>
        public virtual int RemoveByPfAddTime(DateTime pfAddTime, TransactionManager tm = null)
        {
            const string sql = @"DELETE FROM platform WHERE Pf_addTime=@Pf_addTime";
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@Pf_addTime", pfAddTime, DbType.DateTime, 0)
                            .ExecNonQuery(tm);
        }

        /// <summary>
        /// 按字段删除
        /// </summary>
        /// <param name = "pfState"></param>
        /// <param name="tm">事务管理对象</param>
        public virtual int RemoveByPfState(string pfState, TransactionManager tm = null)
        {
            const string sql = @"DELETE FROM platform WHERE Pf_state=@Pf_state";
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@Pf_state", pfState, DbType.String, 3)
                            .ExecNonQuery(tm);
        }

        /// <summary>
        /// 按字段删除
        /// </summary>
        /// <param name = "pfDel"></param>
        /// <param name="tm">事务管理对象</param>
        public virtual int RemoveByPfDel(string pfDel, TransactionManager tm = null)
        {
            const string sql = @"DELETE FROM platform WHERE Pf_del=@Pf_del";
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@Pf_del", pfDel, DbType.String, 3)
                            .ExecNonQuery(tm);
        }

        /// <summary>
        /// 按字段删除
        /// </summary>
        /// <param name = "pfIsRepair"></param>
        /// <param name="tm">事务管理对象</param>
        public virtual int RemoveByPfIsRepair(string pfIsRepair, TransactionManager tm = null)
        {
            const string sql = @"DELETE FROM platform WHERE Pf_isRepair=@Pf_isRepair";
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@Pf_isRepair", pfIsRepair != null ? (object)pfIsRepair : DBNull.Value, DbType.String, 3)
                            .ExecNonQuery(tm);
        }

        /// <summary>
        /// 按字段删除
        /// </summary>
        /// <param name = "pfNewFunction"></param>
        /// <param name="tm">事务管理对象</param>
        public virtual int RemoveByPfNewFunction(string pfNewFunction, TransactionManager tm = null)
        {
            const string sql = @"DELETE FROM platform WHERE Pf_newFunction=@Pf_newFunction";
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@Pf_newFunction", pfNewFunction != null ? (object)pfNewFunction : DBNull.Value, DbType.String, 6000)
                            .ExecNonQuery(tm);
        }

        /// <summary>
        /// 按字段删除
        /// </summary>
        /// <param name = "pfNewEndTime"></param>
        /// <param name="tm">事务管理对象</param>
        public virtual int RemoveByPfNewEndTime(DateTime pfNewEndTime, TransactionManager tm = null)
        {
            const string sql = @"DELETE FROM platform WHERE Pf_newEndTime=@Pf_newEndTime";
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@Pf_newEndTime", pfNewEndTime, DbType.DateTime, 0)
                            .ExecNonQuery(tm);
        }

        /// <summary>
        /// 按字段删除
        /// </summary>
        /// <param name = "pfIsNewShow"></param>
        /// <param name="tm">事务管理对象</param>
        public virtual int RemoveByPfIsNewShow(string pfIsNewShow, TransactionManager tm = null)
        {
            const string sql = @"DELETE FROM platform WHERE Pf_isNewShow=@Pf_isNewShow";
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@Pf_isNewShow", pfIsNewShow != null ? (object)pfIsNewShow : DBNull.Value, DbType.String, 3)
                            .ExecNonQuery(tm);
        }

        /// <summary>
        /// 按字段删除
        /// </summary>
        /// <param name = "pfSort"></param>
        /// <param name="tm">事务管理对象</param>
        public virtual int RemoveByPfSort(int? pfSort, TransactionManager tm = null)
        {
            const string sql = @"DELETE FROM platform WHERE Pf_sort=@Pf_sort";
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@Pf_sort", pfSort.HasValue ? (object)pfSort.Value : DBNull.Value, DbType.Int32, 0)
                            .ExecNonQuery(tm);
        }

        /// <summary>
        /// 按字段删除
        /// </summary>
        /// <param name = "pfText1"></param>
        /// <param name="tm">事务管理对象</param>
        public virtual int RemoveByPfText1(string pfText1, TransactionManager tm = null)
        {
            const string sql = @"DELETE FROM platform WHERE Pf_text1=@Pf_text1";
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@Pf_text1", pfText1 != null ? (object)pfText1 : DBNull.Value, DbType.String, 300)
                            .ExecNonQuery(tm);
        }

        /// <summary>
        /// 按字段删除
        /// </summary>
        /// <param name = "pfText2"></param>
        /// <param name="tm">事务管理对象</param>
        public virtual int RemoveByPfText2(string pfText2, TransactionManager tm = null)
        {
            const string sql = @"DELETE FROM platform WHERE Pf_text2=@Pf_text2";
            return Database.CreateSqlDao(sql)
                            .AddInParameter("@Pf_text2", pfText2 != null ? (object)pfText2 : DBNull.Value, DbType.String, 300)
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
            const string format = @"DELETE FROM platform {0}";
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
            const string format = @"DELETE FROM platform {0}";
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
