using System.Collections.Generic;
using LZManager.DAL;
using System.Data;
using System;
using System.Data.Common;

namespace LZManager.BLL
{
    public class UserManage
    {
        UsersMO usersMO = new UsersMO("LZBgAuthorityConn");

        /// <summary>
        /// 根据用户名和密码查询用户信息
        /// </summary>
        /// <param name="username">用户名</param>
        /// <param name="password">密码</param>
        /// <returns></returns>
        public UsersEO GetUser(string username, string password)
        {
            UsersEO UsersEO = new UsersEO();
            foreach (UsersEO tsersEOs in usersMO.Get(" Ur_loginName = @Ur_loginName and Ur_pass = @Ur_pass and Ur_del = 0 ", username, password))
            {
                UsersEO = tsersEOs;
                break;
            }
            return UsersEO;
        }

        /// <summary>
        /// 根据ID查询用户基本信息
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public UsersEO GetUser(string id)
        {
            return usersMO.GetByPK(id);
        }

        /// <summary>
        /// 查询所有用户基本信息
        /// </summary>
        /// <returns></returns>
        public IEnumerable<UsersEO> GetAllUsers()
        {
            return usersMO.GetAll();
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="set"></param>
        /// <param name="where"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        //public int DelUsers(string set, string where, params object[] values)
        //{
        //    return usersMO.Put(set, where, null, values);
        //}
        public int DelUsers(string set, string where, IEnumerable<DbParameter> paras)
        {
            return usersMO.Put(set, where, paras,null);
        }

        /// <summary>
        /// 创建用户
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public int AddUser(UsersEO item)
        {
            return usersMO.Add(item);
        }

        /// <summary>
        /// 修改用户
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public int EditUser(UsersEO item)
        {
            return usersMO.UpdateUser(item);
        }

        /// <summary>
        /// 修改用户
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public int EditStateByPk(string urId,string state)
        {
            return usersMO.PutUrStateByPK(urId, state);
        }

        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="urId"></param>
        /// <returns></returns>
        public UsersEO GetUserByPK(string urId)
        {
            return usersMO.GetByPK(urId);
        }

        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="urId"></param>
        /// <returns></returns>
        public UsersEO GetUserByLoginName(string loginName)
        {
            try
            {
                UsersEO _eo = new UsersEO();
                IEnumerable<UsersEO> _eos = usersMO.GetByUrLoginName(loginName);

                foreach (UsersEO _eof in _eos)
                {
                    _eo = _eof;
                    break;
                }
                return _eo;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 修改输入密码次数和时间
        /// </summary>
        /// <param name="urId"></param>
        /// <returns></returns>
        public int EditErrorloginLockTimeByPK(string urId, string num, DateTime datetime)
        {
            return usersMO.Put(" Ur_errorlogin = @Ur_errorlogin , Ur_lockTime = @Ur_lockTime ", " Ur_id = @Ur_id ", num, datetime, urId);
        }

        /// <summary>
        /// 根据条件查询数据
        /// </summary>
        /// <param name="where"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public IEnumerable<UsersEO> Get(string where, params object[] values)
        {
            return usersMO.GetTopSort(where, -1, string.Empty, null, values);
        }

        /// <summary>
        /// 按自定义条件查询
        /// </summary>
        /// <param name = "where">自定义条件,where子句</param>
        /// <param name = "top">获取行数</param>
        /// <param name = "sort">排序表达式</param>
        /// <return>Table</return>
        public virtual DataTable GetTable(string where, IEnumerable<DbParameter> paras)
        {
            return usersMO.GetTable(where, -1, string.Empty,paras);
        }

        public virtual DataTable GetList(string where, IEnumerable<DbParameter> paras)
        {
            return usersMO.GetList(where, -1, string.Empty,paras);
        }


        /// <summary>
        /// 根据用户id查询角色
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public virtual DataTable GetRoleByUserId(string userid)
        {
            return usersMO.GetRoleByUserId(userid);
        }

        /// <summary>
        /// 按照Ur_id更新玩家可提现金额
        /// </summary>
        /// <param name="urId"></param>
        /// <param name="urMoney"></param>
        /// <returns></returns>
        public virtual int PutUrMoneyByPK(string urId, string urMoney)
        {
            return usersMO.PutUrMoneyByPK(urId,urMoney);
        }

        /// <summary>
        /// 按照Ur_gameid更新玩家可提现金额
        /// </summary>
        /// <param name="gameId"></param>
        /// <param name="urMoney"></param>
        /// <returns></returns>
        public virtual int PutUrMoneyByGameId(string gameId, string urMoney)
        {
            return usersMO.PutUrMoneyByGameId(gameId, urMoney);
        }

        public virtual int PutUrDiamondByGameId(string gameId, string diamondNum)
        {
            return usersMO.PutUrDiamondByGameId(gameId, diamondNum);
        }
    }
}
