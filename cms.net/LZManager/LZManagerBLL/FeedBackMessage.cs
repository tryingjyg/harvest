using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LZManager.DAL;
using System.Data;

namespace LZManager.BLL
{
    public class FeedBackMessage
    {
        
        FeedbackMO feedBackMO = new FeedbackMO("LZBgAuthorityConn");
        /// <summary>
        /// 根据条件查询所有数据
        /// </summary>
        /// <param name="strWhere"></param>
        /// <param name="shot"></param>
        /// <returns></returns>
        public DataTable GetAllByWhere(string strWhere, string userid, string shot = "", params object[] values)
        {
            
            return feedBackMO.GetAlls(strWhere,userid, shot,values);
        }
    }
}
