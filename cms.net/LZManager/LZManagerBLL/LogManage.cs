using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LZManager.DAL;
using System.Data;

namespace LZManager.BLL
{
    public  class LoPfanage
    {
        NxLogMO loPfO = new NxLogMO();
       

       /// <summary>
        /// 根据用户名判断次数(num:0登陆)
       /// </summary>
       /// <param name="userid">用户ID</param>
       /// <param name="num">0：登录</param>
       /// <returns></returns>
        public int GetNumByUserId(string userid, int num)
        {
            return loPfO.GetNumByUserId(userid, num);
        }

        /// <summary>
        /// 根据用户ID类型获取Log信息
        /// </summary>
        /// <param name="userid">用户ID</param>
        /// <param name="num">0：登录</param>
        /// <param name="topnum">获取数据条数</param>
        /// <returns></returns>
        public DataTable GetTableByUserid(string userid, int num, int topnum)
        {
            return loPfO.GetTableByUserid(userid, num, topnum);
        }

        public virtual DataTable GetList(string where)
        {
            return loPfO.GetList(where, -1, string.Empty);
        }      
    }
}
