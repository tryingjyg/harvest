using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TinyFx;
using System.Data;
using LZManager.BLL.Common;
using LZManager.DAL;

namespace LZManager.BLL
{
    /// <summary>
    /// 通用查询缓存
    /// </summary>
    public class CommonSearchDO 
    {
        CommonSearch commonSearch = new CommonSearch();
        private static object lockHelp = new object();

        /// <summary>
        /// 获取用户所具有的平台列表
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public DataTable GetPlatformTableByUserid(string userid)
        {
            string cacheStrphold = string.Format("CommonSearch_GetPlatformTableByUserid_{0}",userid);
            if ((WebCache.GetCache(cacheStrphold) == null))
            {
                lock (lockHelp)
                {
                    if ((WebCache.GetCache(cacheStrphold) == null))
                    {
                        DataTable dt = commonSearch.GetPlatformTableByUserid(userid);

                        WebCache.SetCache(cacheStrphold, dt, 60);
                    }
                }
            }
            return (DataTable)WebCache.GetCache(cacheStrphold);


        }

        /// <summary>
        /// 获取用户所具有模块列表
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public DataTable GetModuleTableByUserid(string userid, string Platformid)
        {
            /*  周杨
            string cacheStrphold = string.Format("CommonSearch_GetModuleTableByUserid_{0}_{1}", userid, Platformid);
            if ((WebCache.GetCache(cacheStrphold) == null))
            {
                lock (lockHelp)
                {
                    if ((WebCache.GetCache(cacheStrphold) == null))
                    {
                        DataTable dt = commonSearch.GetModuleTableByUserid(userid, Platformid);

                        WebCache.SetCache(cacheStrphold, dt, 60);
                    }
                }
            }
            return (DataTable)WebCache.GetCache(cacheStrphold);
             */
            DataTable dt = commonSearch.GetModuleTableByUserid(userid, Platformid); //周杨新增
            return dt;
        }

     

        /// <summary>
        /// 获取用户具有的权限
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public DataTable GetPermissionsNameByUseridModouleid(string userid, string moduleid)
        {
            string cacheStrphold = string.Format("CommonSearch_GetPermissionsNameByUseridModouleid_{0}_{1}", userid, moduleid);
            if ((WebCache.GetCache(cacheStrphold) == null))
            {
                lock (lockHelp)
                {
                    if ((WebCache.GetCache(cacheStrphold) == null))
                    {
                        DataTable dt = commonSearch.GetPermissionsNameByUseridModouleid(userid, moduleid);

                        WebCache.SetCache(cacheStrphold, dt, 60);
                    }
                }
            }
            return (DataTable)WebCache.GetCache(cacheStrphold);
        }


        /// <summary>
        /// 获取用户具有的权限
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public DataTable GetRoleTable(string userid)
        {
            string cacheStrphold = string.Format("CommonSearch_GetRoleTable_{0}", userid);
            if ((WebCache.GetCache(cacheStrphold) == null))
            {
                lock (lockHelp)
                {
                    if ((WebCache.GetCache(cacheStrphold) == null))
                    {
                        DataTable dt = commonSearch.GetRoleTable(userid);

                        WebCache.SetCache(cacheStrphold, dt, 60);
                    }
                }
            }
            return (DataTable)WebCache.GetCache(cacheStrphold);
        }


        /// <summary>
        /// 获取用户具有的权限
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public DataTable GetGameListByRoleId(string roleid, int channelid)
        {
            string cacheStrphold = string.Format("CommonSearch_GetGameListByRoleId_{0}_{1}", roleid, channelid);
            if ((WebCache.GetCache(cacheStrphold) == null))
            {
                lock (lockHelp)
                {
                    if ((WebCache.GetCache(cacheStrphold) == null))
                    {
                        DataTable dt = commonSearch.GetGameListByRoleId(roleid);

                        WebCache.SetCache(cacheStrphold, dt, 60);
                    }
                }
            }
            return (DataTable)WebCache.GetCache(cacheStrphold);
        }
    }
}
