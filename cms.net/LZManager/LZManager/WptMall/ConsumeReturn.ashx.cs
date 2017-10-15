using LZManager.BLL;
using LZManager.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LZManager.WptMall
{
    /// <summary>
    /// ConsumeReturn 的摘要说明
    /// </summary>
    public class ConsumeReturn : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            //`remarkid` varchar(32) NOT NULL COMMENT '流水号',
            //`roomId` int(11) unsigned NOT NULL DEFAULT '0' COMMENT '房间号',
            //`gameId` varchar(32) NOT NULL DEFAULT '' COMMENT '游戏类型',
            //`gameType` varchar(32) NOT NULL DEFAULT '' COMMENT '玩法类型',
            //`chargeType` varchar(32) NOT NULL DEFAULT '' COMMENT '房费模式',
            //`roundNum` int(11) NOT NULL DEFAULT '0' COMMENT '局数',
            //`playerNum` bigint(13)  NOT NULL DEFAULT '0' COMMENT '人数',
            //`uidAr` varchar(32) NOT NULL DEFAULT '0' COMMENT '所有玩家UIDS',
            //`ownerUid` int(11) NOT NULL DEFAULT '0' COMMENT '房主UID',
            //`destUid` int(11) NOT NULL DEFAULT '0' COMMENT '被扣钻人uid',
            //`useNum` int(11)  NOT NULL DEFAULT '0' COMMENT '消耗钻数量',
            //`lastNum` int(11)  NOT NULL DEFAULT '0' COMMENT '扣钻后数量',
            //`createTime` varchar(32) NOT NULL DEFAULT '0' COMMENT '订单生成时间',
            //`statue` int(32) NOT NULL DEFAULT '0' COMMENT '状态',
            //`serverId` int(11) NOT NULL DEFAULT '0' COMMENT '所在房间服id',
            //`unidId` varchar(32) NOT NULL DEFAULT '' COMMENT '被扣钻的人unionid',
            //`duid` int(11) NOT NULL DEFAULT '0' COMMENT '被扣钻人绑定的代理',


            //addUserComsumeLog  consumeLog=
            //{"remarkid":"150796742810343",
            //"roomId":"275034",
            //"gameId":"sdmj/ddz",
            //"chargeType":true,
            //"roundNum":8,
            //"playerNum":3,
            //"uidAr":"[10280,10345,10343]",
            //"ownerUid":10280,
            //"destUid":10343,
            //"useNum":-1,
            //"lastNum":99,
            //"serverId":31,
            //"statue":0,
            //"unidId":"jlsfjalsdjfasjfljasdfa",
            //"duid":0}

            //context.Response.Write("res");
            //return;

            string remarkid = string.IsNullOrEmpty(context.Request["remarkid"]) ? "" : context.Request["remarkid"].ToString();
            string roomId = string.IsNullOrEmpty(context.Request["roomId"]) ? "" : context.Request["roomId"].ToString();
            string gameId = string.IsNullOrEmpty(context.Request["gameId"]) ? "" : context.Request["gameId"].ToString();
            string gameType = string.IsNullOrEmpty(context.Request["gameType"]) ? "ddz" : context.Request["gameType"].ToString();
            string chargeType = string.IsNullOrEmpty(context.Request["chargeType"]) ? "" : context.Request["chargeType"].ToString();
            string roundNum = string.IsNullOrEmpty(context.Request["roundNum"]) ? "" : context.Request["roundNum"].ToString();
            string playerNum = string.IsNullOrEmpty(context.Request["playerNum"]) ? "" : context.Request["playerNum"].ToString();
            string uidAr = string.IsNullOrEmpty(context.Request["uidAr"]) ? "" : context.Request["uidAr"].ToString();
            string ownerUid = string.IsNullOrEmpty(context.Request["ownerUid"]) ? "" : context.Request["ownerUid"].ToString();
            string destUid = string.IsNullOrEmpty(context.Request["destUid"]) ? "" : context.Request["destUid"].ToString();
            string useNum = string.IsNullOrEmpty(context.Request["useNum"]) ? "" : context.Request["useNum"].ToString();
            string lastNum = string.IsNullOrEmpty(context.Request["lastNum"]) ? "" : context.Request["lastNum"].ToString();
            string unidId = string.IsNullOrEmpty(context.Request["unidId"]) ? "" : context.Request["unidId"].ToString();
            string createTime = string.IsNullOrEmpty(context.Request["createTime"]) ? "" : context.Request["createTime"].ToString();
            string statue = string.IsNullOrEmpty(context.Request["statue"]) ? "" : context.Request["statue"].ToString();
            string serverId = string.IsNullOrEmpty(context.Request["serverId"]) ? "" : context.Request["serverId"].ToString();
            string duid = string.IsNullOrEmpty(context.Request["duid"]) ? "" : context.Request["duid"].ToString();

            if (!string.IsNullOrEmpty(duid))
            {
                LogConsumeManage lg = new LogConsumeManage();

                LogConsumeEO lcEo = new LogConsumeEO();
                lcEo.Remarkid = remarkid;
                lcEo.RoomId = roomId;
                lcEo.GameId = gameId;
                lcEo.GameType = gameType;
                lcEo.ChargeType = chargeType;
                lcEo.RoundNum = roundNum;
                lcEo.PlayerNum = playerNum;
                lcEo.UidAr = uidAr;
                lcEo.OwnerUid = ownerUid;
                lcEo.DestUid = destUid;
                lcEo.UseNum = useNum;
                lcEo.LastNum = lastNum;
                lcEo.UnidId = unidId;
                lcEo.CreateTime = createTime;
                lcEo.Statue = statue;
                lcEo.ServerId = serverId;
                lcEo.Duid = duid;

                int res = lg.addLgConsume(lcEo);
                if (res > 0)
                {
                    context.Response.Write("{\"res\":\"0\"," + "\"remarkid\":" + remarkid + "}");
                }
                else
                {
                    //context.Response.Write("{\"res\":\"1\"}");
                    context.Response.Write("{\"res\":\"1\"," + "\"remarkid\":" + remarkid + "}");
                }
            }

            //context.Response.Write("remarkid = " + remarkid);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}