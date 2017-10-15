//==========================================================
// 此代码由代码生成器工具自动生成，请不要修改
// 代码生成器核心库版本号：2.0
// 创建时间：2015/12/21 15:09:29
//==========================================================

using System;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Text;
using System.Xml;
using TinyFx.Common;
using TinyFx.Data;

namespace LZManager.DAL
{	

	/// <summary>
	/// 【表 feedback 的操作类】
	/// </summary>
    public partial class FeedbackMO : DataManagerBase
	{		

        #region  自定义方法集合
        /// <summary>
        /// 获取所有数据
        /// </summary>
        /// <return>实体对象集合</return>
        public DataTable GetAlls(string strWhere, string userid, string shot, params object[] values)
        {
            StringBuilder str = new StringBuilder();
            str.Append(" select fb.*,us.Ur_name,pf.Pf_name,uss.Ur_name as Ur_names from feedback fb  ");
            str.Append(" left join users us  ");
            str.Append(" on fb.Fb_solveUser = us.Ur_id  ");
            str.Append(" left join users uss  ");
            str.Append(" on fb.Fb_addUser = uss.Ur_id  ");
            str.Append("left join platform pf on fb.Pf_id = pf.Pf_id  ");
            str.Append("where fb.Fb_del=0 and  ");
            str.Append("((fb.Fb_addTime >= '" + DateTime.Now.ToString("yyyy-MM-01 00:00:00") + "') or  ");
            str.Append("(fb.Fb_state <> 1)");
            str.Append(")  ");
            if (strWhere != "")
            {
                str.Append(" and " + strWhere);
            }
            if (shot != "")
            {
                str.Append(" order by " + shot);
            }

            return Database.CreateSqlDao(str.ToString()).AddInParameters(values).ExecTable();
        }
        #endregion
	}
}
