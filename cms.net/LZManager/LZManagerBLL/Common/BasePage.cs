using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LZManager.DAL;
using System.Web;
using System.Data;
using System.Text.RegularExpressions;
using System.Configuration;
using LZWebApp.BLL.Roulette;
using System.Web.UI;
using System.Reflection;

namespace LZManager.BLL.Common
{
    public class BasePage : System.Web.UI.Page
    {
        NxLogMO loPfO = new NxLogMO("LZBgAuthorityConn");
        UserManage userManage = new UserManage();
        OrganizeManage organizeManage = new OrganizeManage();
        public string loginnameCookie = "LoginUser";  // 获取Cookie名称
        public string loginidCookie = "LoginUserId";  // 获取用户ID
        public string UserNameCookie = "LoginUserName";  // 获取用户姓名
        public static string keypassword = "lzwzkfb";
        public static string keypasswordiv = "admin";
        CommonSearchDO commonSearchDO = new CommonSearchDO();
        NxPlatformMO _mo = new NxPlatformMO("LZBgAuthorityConn");

        #region 获取用户信息

        /// <summary>
        /// 从Cookie中获取用户名
        /// </summary>
        /// <returns></returns>
        public string GetUserLoginName()
        {
            return  EncryptionUtils.DESDecrypt(CookieUtil.GetCookie(loginnameCookie), keypassword, keypasswordiv);
        }

        /// <summary>
        /// 从Cookie中获取用户名
        /// </summary>
        /// <returns></returns>
        public string GetUserName()
        {
           return  EncryptionUtils.DESDecrypt(CookieUtil.GetCookie(UserNameCookie), keypassword, keypasswordiv);
        }

        /// <summary>
        /// 从Cookie中获取用户名ID
        /// </summary>
        /// <returns></returns>
        public string GetUserID()
        {
            return CookieUtil.GetCookie(loginidCookie);
        }

        /// <summary>
        /// 获取用户基本信息
        /// </summary>
        /// <returns></returns>
        public UsersEO GetUser()
        {
            UsersEO usersEO = new UsersEO();
            if (GetUserID() != "")
            {
                usersEO = userManage.GetUser(GetUserID());
            }
            return usersEO;
        }

        /// <summary>
        /// 获取机构用户基本信息
        /// </summary>
        /// <returns></returns>
        public OrganizeEO GetOrgnizeUser()
        {
            OrganizeEO usersEO = new OrganizeEO();
            if (GetUserID() != "")
            {
                usersEO = organizeManage.GetUser(GetUserID());
            }
            return usersEO;
        }

        /// <summary>
        /// 生成23位自动编码
        /// </summary>
        /// <returns></returns>
        public string GetBigGuid()
        {
            string result = (Guid.NewGuid().ToString()).Substring(28) + DateTime.Now.ToString("yyyyMMddHHmmss");
            return result;
        }

        /// <summary>
        /// 生成10位自动编码
        /// </summary>
        /// <returns></returns>
        private string GetGuid()
        {
            string result = (Guid.NewGuid().ToString()).Substring(28) + DateTime.Now.ToString("ss");
            return result;
        }

        /// <summary>
        /// 获取客户端IP
        /// </summary>
        /// <returns></returns>
        public string GetClientIP()
        {
            String result = HttpContext.Current.Request.Headers["Cdn-Src-Ip"];

            if (string.IsNullOrEmpty(result))
                result = HttpContext.Current.Request.UserHostAddress;
            return result ?? string.Empty;
        }

        /// <summary>
        /// 获取用户级别
        /// </summary>
        /// <returns></returns>
        public List<string[]> GetUserLeaveByString()
        {


            bool isEng = this.IsLanguageEng();
            string[] f = new string[] { "顶级管理员", "200" };
            string[] a = new string[] { "超级管理员", "100" };
            string[] b = new string[] { "开发管理员", "90" };
            string[] c = new string[] { "普通管理员", "80" };
            string[] d = new string[] { "用户", "70" };
            if (isEng)
            {
                a = new string[] { "Super admin", "100" };
                b = new string[] { "Develop admin", "90" };
                c = new string[] { "Admin", "80" };
                d = new string[] { "User", "70" };
            }

            List<string[]> list = new List<string[]>();
            list.Add(f);
            list.Add(a);
            list.Add(b);
            list.Add(c);
            list.Add(d);
            return list;
        }

        /// <summary>
        /// 获取部门
        /// </summary>
        /// <returns></returns>
        public string[] GetDepartment()
        {
            //string[] a = new string[] { "WPT 产品与开发部", "WPT海外发展部", "WPT 赛事管理部", "WPT 加州" };
            string[] a = new string[] { "管理员", "机构代理", "普通代理"};
            if (this.IsLanguageEng())
            {
                a = new string[] { "admin", "orangize", "agent",};
            }


            return a;
        }
        #endregion

        #region 相关操作
        /// <summary>
        /// 插入Log
        /// </summary>
        /// <param name="name">操作名称</param>
        /// <param name="content">操作内容</param>
        /// <param name="lgtext">操作类型</param>
        /// <param name="Platformid">平台id，0权限系统、1德州金币版后台</param>
        public bool InsertLog(string name, string content, int lgtext, string Platformid)
        {
            NxLogEO logEO = new NxLogEO();
            logEO.LgId = GetBigGuid();
            logEO.UrId = GetUserID();
            logEO.LgUserip = GetClientIP();
            logEO.LgAddtime = DateTime.Now;
            logEO.LgName = name;
            logEO.LgContent = content;
            logEO.LgText1 = lgtext.ToString();
            logEO.LgText2 = Platformid.ToString();

            return loPfO.Add(logEO) > 0;
        }

        /// <summary>
        /// 获取用户所具有的平台列表
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public DataTable GetPlatformTableByUserid()
        {
            return commonSearchDO.GetPlatformTableByUserid(GetUserID());
        }

        /// <summary>
        /// 获取用户所具有模块列表
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public DataTable GetModuleTableByUserid(string Platformid = "")
        {
            return commonSearchDO.GetModuleTableByUserid(GetUserID(), Platformid);
        }

        public DataTable GetNewModuleTableByUserid(string Platformid = "")
        {
            CommonSearch commonSearch = new CommonSearch();

            return commonSearch.GetModuleTableByUseridForMenu(GetUserID(), Platformid); //周杨新增

           // return commonSearchDO.GetModuleTableByUserid(GetUserID(), Platformid);
        }

        /// <summary>
        /// 获取用户所具有角色列表
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public DataTable GetRoleTable()
        {
            return commonSearchDO.GetRoleTable(GetUserID());
        }

        /// <summary>
        /// 该用户是否有权限访问该页面
        /// </summary>
        /// <param name="page">页面</param>
        /// <param name="url">父级URL</param>
        /// <param name="type">类型：0父页面 1子页面</param>
        /// <returns></returns>
        public DataTable GetAuthorityUrl(Page page, string url, int type)
        {
            DataTable dt = new DataTable();
      
            try
            {
                string moduleid = ""; // 模块的id
                string moduleUrlLog = ""; // Log模块地址

                // 判断用户是否登陆
                if (GetUser().UrId == "")
                {
                    Response.Redirect(ConfigurationManager.AppSettings["WebLoginURL"].ToString());
                    return dt;
                }

                // 判断访问页面是否有权限
                int flag = -1;

                if (url.Length > 0)
                {
                    foreach (DataRow dtr in GetModuleTableByUserid().Select(" Md_address like '%" + url.Split('?')[0] + "%' ")) // 查询跟传入页面匹配的页面
                    { 
                      
                        string moduleUrl = dtr["Md_address"].ToString().Split('?')[0]; // 模块的地址

                        if (moduleUrl.Substring(0, 4) != "http")
                        {
                            int startlength = moduleUrl.Substring(0, moduleUrl.LastIndexOf('.')).LastIndexOf('.');
                            moduleUrl = moduleUrl.Substring(startlength + 2, moduleUrl.Length - startlength - 2);

                            if (moduleUrl.Split('?')[0] == url.Split('?')[0])
                            {
                                moduleid = dtr["Md_id"].ToString(); // 模块id
                                flag = 1;
                                break;
                            }
                            else
                            {
                                moduleUrlLog = moduleUrl;
                            }
                        }
                        else
                        {
                            moduleUrlLog = moduleUrl;
                            if (moduleUrl == url.Split('?')[0]) 
                            {
                                moduleid = dtr["Md_id"].ToString(); // 模块id
                                flag = 1;
                                break;
                            }
                        }
                    }
                }

                if (flag < 0)
                {
                    Jswork.JavaScriptLocationHref(ConfigurationManager.AppSettings["WebErrorURL"].ToString(), page);
                    InsertLog("非法登录", "非法登录页面" + url + "========" + moduleUrlLog, -1, GetPlatformIdByValue(1));
                }
                else
                {
                    int result = -1;
                    dt = commonSearchDO.GetPermissionsNameByUseridModouleid(GetUserID(), moduleid);
                    if (type == 1) // 如果为子页面
                    {
                        string[] parameters = HttpContext.Current.Request.Url.Query.ToString().Split('&'); //  筛选参数
                        for (int i = 0; i < parameters.Length; i++)
                        {
                            if (parameters[i].Length > 6) // 选择参数为action 的参数
                            {
                                if (parameters[i].Substring(0, 6) == "Action")
                                {
                                    result = 1;
                                    if (parameters[i].Substring(7, 1) == "0") // 增加
                                    {
                                        if (dt.Select(" Pm_name = '添加'").Length <= 0) // 没有增加的权限
                                        {
                                            Jswork.GoHistoryAlert("亲，您没有该操作的权限！", -1, page);
                                            InsertLog("非法操作", "非法登录页面" + url + "", -1, GetPlatformIdByValue(1));
                                        }
                                    }
                                    else
                                    {
                                        if (dt.Select(" Pm_name = '修改'").Length <= 0 && dt.Select(" Pm_name = '查询'").Length <= 0) // 没有修改的权限
                                        {
                                            Jswork.JavaScriptLocationHref(ConfigurationManager.AppSettings["WebErrorURL"].ToString(), page);
                                            InsertLog("非法操作", "非法登录页面" + url + "", -1, GetPlatformIdByValue(1));
                                        }
                                    }
                                }
                            }
                        }
                        if (result < 0)
                        {
                            Jswork.GoHistoryAlert("亲，您没有该操作的权限！", -1, this.Page);
                            InsertLog("非法操作", "非法登录页面" + url + "", -1, GetPlatformIdByValue(1));
                        }
                    }
                }

                return dt;
            }
            catch(Exception ex)
            {
                Jswork.GoHistoryAlert("系统异常！", -1, page);
                InsertLog("系统异常", ex.Message, -1, GetPlatformIdByValue(1));
                return null;
            }
        }

        /// <summary>
        /// 查询操作权限
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        private bool GetAuthorityCommand(DataTable dt, string name)
        {
            try
            {
                return dt.Select(" Pm_name ='" + name + "'")[0]["Pm_name"].ToString() != null;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 获取游戏名称
        /// </summary>
        /// <returns></returns>
        public string GetGameName(string gameid)
        {
            try
            {
                DataRow[] drs = GetGameList().Select(" Gm_gameId = '" + gameid + "'");
                return drs[0]["Gm_name"].ToString();
            }
            catch {
                return "";
            }
        }

        /// <summary>
        /// 获取用户拥有操作游戏的列表
        /// </summary>
        /// <param name="flag">
        /// 特殊表识别 
        /// 添加此标示多添加一个字段
        /// 联众平台不会添加次标识
        /// 名称为：NewGameid 规则：
        /// gameid+【flag】+channelid
        /// 名称为：NewGameName 规则：
        /// Gm_name( Cn_name )
        /// </param>
        /// <param name="channel">
        /// 渠道值填写则查询渠道本身的游戏不填写则返回所有游戏
        /// </param>
        /// <returns></returns>
        public DataTable GetGameList(string flag = "", int channel = -1)
        {
            StringBuilder str = new StringBuilder();
            str.Append(" 1=1 ");
            DataTable dt = GetRoleTable(); //获得角色列表
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (i == 0)
                {
                    str.Append(" and ( ");
                }
                str.Append(" rg.Rl_id='" + dt.Rows[i]["Rl_id"].ToString() + "' ");
                if (i != dt.Rows.Count - 1)
                {
                    str.Append(" or  ");
                }
                else
                {
                    str.Append(" ) ");
                }
            }

            if (channel != -1)
            {
                str.Append(" and cn.Cn_channelId = '" + channel + "' ");
            }

            DataTable dtgame = commonSearchDO.GetGameListByRoleId(str.ToString(), channel);

            try
            {
                dtgame.Columns.Remove("NewGameid");
                dtgame.Columns.Remove("NewGameName");
                dtgame.Columns.Add("NewGameid");
                dtgame.Columns.Add("NewGameName");
            }
            catch
            {
                dtgame.Columns.Add("NewGameid");
                dtgame.Columns.Add("NewGameName");
            }

            foreach (DataRow dr in dtgame.Rows)
            {
                if (flag != "" && dr["Cn_channelId"].ToString() != "0")
                {
                    dr["NewGameid"] = dr["Gm_gameId"] + flag + dr["Cn_channelId"];
                }
                else
                {
                    dr["NewGameid"] = dr["Gm_gameId"];
                }

                dr["NewGameName"] = dr["Gm_name"] + "(" + dr["Cn_name"] + ")";

            }
            return dtgame;
        }


        #endregion

        #region 判断页面权限

        /// <summary>
        /// 是否具有这个游戏ID的权限
        /// </summary>
        /// <param name="gameid"></param>
        /// <param name="flag">特殊标识与GetGameList 方法同步</param>
        /// <returns></returns>
        public bool IsHaveGame(string gameid, string flag)
        {

            DataRow[] dr = GetGameList(flag).Select(string.Format(" NewGameid= '{0}' ", gameid));
            if (dr.Count() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool IsAdd(DataTable dt)
        {
            return GetAuthorityCommand(dt, "添加");
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool IsEdit(DataTable dt)
        {
            return GetAuthorityCommand(dt, "修改");
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool IsSearch(DataTable dt)
        {
            return GetAuthorityCommand(dt, "查询");
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool IsDel(DataTable dt)
        {
            return GetAuthorityCommand(dt, "删除");
        }

        /// <summary>
        /// 导出
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool IsPrintExcel(DataTable dt)
        {
            return GetAuthorityCommand(dt, "导出");
        }

        /// <summary>
        /// 线上
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool IsOnLine(DataTable dt)
        {
            return GetAuthorityCommand(dt, "线上");
        }

        /// <summary>
        /// 仿真
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool IsOnLineOT(DataTable dt)
        {
            return GetAuthorityCommand(dt, "仿真");
        }

        #endregion

        #region 获取日志平台列表
        /// <summary>
        /// 获取平台ID
        /// </summary>
        /// <param name="value"> 1、权限系统 2、日志查询 3、德州扑克金币版</param>
        /// <returns></returns>
        public string GetPlatformIdByValue(int value)
        {
            string id = "";
            foreach (NxPlatformEO _eo in _mo.Get(" Pf_sort=@Pf_sort ", value.ToString()))
            {
                id = _eo.PfId;
                break;
            }
            return id;
        }
        #endregion

        #region 循环所有类的节点
        public string GetDisPlayName(object entity)
        {
            StringBuilder str = new StringBuilder();
            if (entity != null)
            {
                System.Type t = entity.GetType();
                System.Reflection.MemberInfo[] memberInfot = t.GetMembers();

                foreach (MemberInfo var in memberInfot)
                {
                    if (var.MemberType == MemberTypes.Property)
                    {
                        System.Reflection.PropertyInfo propertyInfo = entity.GetType().GetProperty(var.Name);
                        try
                        {
                            string val = propertyInfo.GetValue(entity, null).ToString();
                            str.Append(var.Name + ":" + val + ",");
                        }
                        catch
                        {

                        }
                    }
                }
            }
            return str.ToString();
        }
        #endregion

        #region 用户操作
        /// <summary>
        /// 冻结账户
        /// </summary>
        public void UserFreeZing(string UrId)
        {
            userManage.EditErrorloginLockTimeByPK(UrId, "5", DateTime.Now); // 修改输错次数
            userManage.EditStateByPk(UrId, "2"); //  将状态改为冻结
            Jswork.Alert("亲, 您的账户已经被冻结请联系管理员或24小时后自动解冻 解冻时间为：" + DateTime.Now.AddDays(1).ToString("yyyy-MM-dd hh:mm:ss") + "", this.Page);
            InsertLog("用户账号冻结", string.Format("id:{0},datetime:{1}", UrId, DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")), 0, GetPlatformIdByValue(1));
        }
        /// <summary>
        /// 解冻账户
        /// </summary>
        public void UserUnFreeZing(string UrId, DateTime dtm)
        {
            userManage.EditErrorloginLockTimeByPK(UrId, "0", DateTime.Now.AddMonths(-1)); // 修改输错次数
            userManage.EditStateByPk(UrId, "0"); //  将状态改为正常状态
            InsertLog("用户账号解冻", string.Format("id:{0},datetime:{1}", UrId, DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")), 0, GetPlatformIdByValue(1));
        }
        /// <summary>
        /// 验证用户登录IP是否合法
        /// </summary>
        /// <returns></returns>
        public bool EistUserLoginIp(string UrId)
        {
            bool result = false;
            UsersEO usersEO = new UsersEO();
            usersEO = userManage.GetUser(UrId); // 根据ID获取用户信息

            if (usersEO != null)
            {
                if (usersEO.UrLockBindIp == "" || usersEO.UrLockBindIp == null)
                {
                    return true;
                }

                foreach (string userip in usersEO.UrLockBindIp.Trim().Split(',')) // 循环用户输入的IP
                {
                    if (CommonUtil.NoHTML(userip) == GetClientIP())
                    {
                        result = true;
                        break;
                    }
                }
            }

            return result;
        }
        /// <summary>
        /// 获取用户账号等级
        /// </summary>
        /// <returns></returns>
        public int GetUserLeave()
        {
            UsersEO userEO = GetUser();
            if (userEO != null)
            {
                return Convert.ToInt32(userEO.UrText1.ToString() == "" ? "0" : userEO.UrText1.ToString());//登录用户的级别
            }
            else
            {
                return 0;
            }
        }
        #endregion

        #region 处理遮挡层
        /// <summary>
        /// 开始处理程序进行DIV遮挡
        /// </summary>
        public void ShowDivImplementation()
        {
            Response.Write("<script>ajaxLoading();</script>");
        }

        /// <summary>
        /// 处理程序完成进行DIV取消
        /// </summary>
        public void CloseDivImplementation()
        {
            Response.Write("<script>ajaxLoadEnd();</script>");
        }

        #endregion


        #region 获取cookie返回中文还是英文

        /// <summary>
        /// 判断当前的cookie值来确定是不是使用英语
        /// </summary>
        /// <returns></returns>
        public bool IsLanguageEng()
        {
            bool flag=false;
            HttpCookie cookie1 = Request.Cookies["langCook"];

            if (cookie1 != null && cookie1.Values["lang"] == "en-us")
            {

                flag = true;
            }

            return flag;
        }

        #endregion



    }
}
