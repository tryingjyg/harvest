using System.Collections.Generic;
using LZManager.DAL;
using System.Data;
using System;
using System.Data.Common;

namespace LZManager.BLL
{
    public class WxUserManage
    {
        WxusersMO wxUserMo = new WxusersMO("LZBgAuthorityConn");

        public int addWxUser(WxusersEO lpEo)
        {
            return wxUserMo.Add(lpEo);
        }

        public WxusersEO getWxUserByPk(string pk)
        {
            return wxUserMo.GetByPK(pk);
        }

        /// <summary>
        /// 更新代理ID
        /// </summary>
        /// <param name="wxId"></param>
        /// <param name="wxDuid"></param>
        /// <returns></returns>
        public int PutWxDuidByPK(string wxId, string wxDuid)
        {
            return wxUserMo.PutWxDuidByPK(wxId, wxDuid, null);
        }
        /// <summary>
        /// 按自定义条件查询
        /// </summary>
        /// <param name = "where">自定义条件,where子句</param>
        /// <param name = "top">获取行数</param>
        /// <param name = "sort">排序表达式</param>
        /// <return>Table</return>
        public virtual DataTable GetTable(string where, params object[] values)
        {
            //return lgPayMO.GetTable(where, -1, string.Empty, paras);
            return wxUserMo.GetTable(where, values);
        }

    }
}
