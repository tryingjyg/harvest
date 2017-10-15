using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using TinyFx.Data;

namespace LZManager.DAL
{
    public  class CommonSearch
    {

        /// <summary>
        /// 根据用户ID获取用户所具有的平台数据
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public DataTable GetPlatformTableByUserid(string userid)
        {
            Database db1 = DatabaseFactory.Create("LZBgAuthorityConn");
            StringBuilder str = new StringBuilder();
            str.Append(" select distinct APlatform.Pf_id,APlatform.Pf_name, APlatform.Pf_imgUrl, APlatform.Pf_imgWaterUrl, APlatform.Pf_addUser, APlatform.Pf_addTime, APlatform.Pf_state, APlatform.Pf_del, APlatform.Pf_isRepair, APlatform.Pf_newFunction, APlatform.Pf_newEndTime, APlatform.Pf_isNewShow, APlatform.Pf_sort, APlatform.Pf_text1, APlatform.Pf_text2 from roleuser RUser ");//, ARole.Rl_id,RUser.Rl_id
            str.Append(" left join role ARole on ARole.Rl_id = RUser.Rl_id ");
            str.Append(" left join platform APlatform on APlatform.Pf_id = ARole.Pf_id  ");
            str.Append(" where RUser.Ur_id = '" + userid + "' and APlatform.Pf_del = 0 and  APlatform.Pf_state = 0 order by APlatform.Pf_sort asc");
            SqlDao ddc = db1.CreateSqlDao(str.ToString());
           
            return ddc.ExecTable();
           
        }



        /// <summary>
        /// 根据用户名id获取用户所具有模块列表
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public DataTable GetModuleTableByUserid(string userid, string platformid)
        {
            Database db1 = DatabaseFactory.Create("LZBgAuthorityConn");
            StringBuilder str = new StringBuilder();
            str.Append(" select  distinct AModule.* from roleuser RUser ");
            str.Append(" left join role ARole on ARole.Rl_id = RUser.Rl_id ");
            str.Append(" left join rolemodule RModule on RModule.Rl_id = ARole.Rl_id ");
            str.Append(" left join module AModule on AModule.Md_id = RModule.Md_id ");
            str.Append(" where RUser.Ur_id = '" + userid + "' ");
            if (platformid != "")
            {
                str.Append(" and AModule.Pf_id = '" + platformid + "' ");
            }
            //周杨20140402注释 str.Append(" and Md_deleteFlag = 0 and Md_useFlag = 0 and AModule.Md_existsTreeView = 0 ");
            
            str.Append(" and Md_deleteFlag = 0 and Md_useFlag = 0");//周杨

            SqlDao ddc = db1.CreateSqlDao(str.ToString());
            return ddc.ExecTable();
        }

        public DataTable GetModuleTableByUseridForMenu(string userid, string platformid)
        {
            Database db1 = DatabaseFactory.Create("LZBgAuthorityConn");
            StringBuilder str = new StringBuilder();
            str.Append(" select  distinct AModule.* from roleuser RUser ");
            str.Append(" left join role ARole on ARole.Rl_id = RUser.Rl_id ");
            str.Append(" left join rolemodule RModule on RModule.Rl_id = ARole.Rl_id ");
            str.Append(" left join module AModule on AModule.Md_id = RModule.Md_id ");
            str.Append(" where RUser.Ur_id = '" + userid + "' ");
            if (platformid != "")
            {
                str.Append(" and AModule.Pf_id = '" + platformid + "' ");
            }
             str.Append(" and Md_deleteFlag = 0 and Md_useFlag = 0 and AModule.Md_existsTreeView = 0 ");

            

            SqlDao ddc = db1.CreateSqlDao(str.ToString());
            return ddc.ExecTable();
        }

        /// <summary>
        /// 获取用户所具有角色列表
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public DataTable GetRoleTable(string userid)
        {
            Database db1 = DatabaseFactory.Create("LZBgAuthorityConn");
            StringBuilder str = new StringBuilder();
            str.Append(" select  distinct ARole.* from roleuser RUser ");
            str.Append(" left join role ARole on ARole.Rl_id = RUser.Rl_id ");
            str.Append(" where RUser.Ur_id = '" + userid + "' ");
            str.Append(" and Rl_state = 0 and Rl_del = 0 ");
            SqlDao ddc = db1.CreateSqlDao(str.ToString());
            return ddc.ExecTable();
        }


        /// <summary>
        /// 根据用户ID 和模块ID 查询模块具有的功能
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public DataTable GetPermissionsNameByUseridModouleid(string userid, string moduleid)
        {
            Database db1 = DatabaseFactory.Create("LZBgAuthorityConn");
            StringBuilder str = new StringBuilder();
            str.Append(" select  APermiss.Pm_name from roleuser ARoleUser ");
            str.Append(" inner join users AUser on ");
            str.Append(" AUser.Ur_id = ARoleUser.Ur_id ");
            str.Append(" inner join rolemodule ARoleMod on ");
            str.Append(" ARoleMod.Rl_id = ARoleUser.Rl_id  ");
            str.Append(" inner join permissionstatal APermissTat on ");
            str.Append(" APermissTat.Pt_id = ARoleMod.Pt_id ");
            str.Append(" inner join permissionstatalp APermissTatP on ");
            str.Append(" APermissTatP.Pt_id = APermissTat.Pt_id ");
            str.Append(" inner join permissions APermiss on ");
            str.Append(" APermiss.Pm_Id = APermissTatP.Pm_id ");
            str.Append(" where AUser.Ur_id ='" + userid + "' ");
            str.Append(" and ARoleMod.Md_id = '" + moduleid + "' ");
            SqlDao ddc = db1.CreateSqlDao(str.ToString());
            return ddc.ExecTable();
        }


        /// <summary>
        /// 根据角色ID 查询用户所具有的的游戏列表
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public DataTable GetGameListByRoleId(string roleid)
        {
            Database db1 = DatabaseFactory.Create("LZBgAuthorityConn");
            StringBuilder str = new StringBuilder();
            str.Append(" select distinct gm.Gm_name,gm.Gm_gameId,cn.Cn_channelId,cn.Cn_name from Game gm ");
            str.Append(" inner join rolegame rg on  ");
            str.Append(" rg.Gm_id = gm.Gm_id ");
            str.Append(" inner join channel cn  ");
            str.Append(" on gm.Cn_channelId = cn.Cn_id ");
            str.Append(" where " + roleid + " ");
            str.Append(" order by gm.Gm_name ");
            SqlDao ddc = db1.CreateSqlDao(str.ToString());
            return ddc.ExecTable();
        }
    }
}
