<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeIndex.aspx.cs" Inherits="LZManager.Frameworks.HomeIndex" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>系统首页</title>
    <link href="Themes/Styles/Site.css" rel="stylesheet" type="text/css" />
    <link href="Themes/easyui.css" rel="stylesheet" type="text/css" />
    <link href="Themes/icon.css" rel="stylesheet" type="text/css" />
    <script src="Themes/Scripts/jquery-1.4.4.min.js" type="text/javascript"></script>
    <script src="Themes/Scripts/jquery.easyui.min.js" type="text/javascript"></script>
    <script src="Themes/Scripts/FunctionJS.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function () {
            $("#BeautifulGreetings").text(BeautifulGreetings());
            closeTq();
        })

        function openTq() {
            $('#div_tq').window('open');
        }
        function closeTq() {
            $('#div_tq').window('close');
        }

        function openDl() {
            //$('#div_tq').window('open');
            alert("暂未开放！")
        }
        function closeDl() {
           // $('#div_tq').window('close');
        }

        function openDlxx() {
            //$('#div_tq').window('open');
            alert("暂未开放！")
        }
        function closeDlxx() {
            // $('#div_tq').window('close');
        }

        function editpwd() {  // 密码修改
            top.AddPanel("../Users/UsersPasswordEdit.aspx", "密码修改");
        }
    </script>
    <style type="text/css">
        .shortcuticons
        {
            float: left;
            border: solid 1px #fff;
            width: 62px;
            height: 55px;
            margin: 5px;
            padding: 5px;
            cursor: pointer;
            vertical-align: middle;
            text-align: center;
            word-break: keep-all;
            white-space: nowrap;
            overflow: hidden;
            text-overflow: ellipsis;
        }
        .shortcuticons:hover
        {
            color: #FFF;
            border: solid 1px #3399dd;
            background: #2288cc;
            filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#33bbee', endColorstr='#2288cc');
            background: linear-gradient(top, #33bbee, #2288cc);
            background: -moz-linear-gradient(top, #33bbee, #2288cc);
            background: -webkit-gradient(linear, 0% 0%, 0% 100%, from(#33bbee), to(#2288cc));
            text-shadow: -1px -1px 1px #1c6a9e;
            width: 62px;
            height: 55px;
            font-weight: bold;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="box">
        <div class="box-title">
            <img src="Themes/Images/sun_2.png" alt="" width="20" height="20" />
            <label id="BeautifulGreetings">
            </label>
            <%=Resources.Resource.administrators%>(<asp:Label ID="lblUser" runat="server" Text=""></asp:Label>)
        </div>
        <div class="box-content">
            <div onclick="openDlxx()"
                class="shortcuticons">
                <img src="Themes/Images/32/596.png" alt="" /><br />
                <%=Resources.Resource.personal_information%></div>
            <div onclick="openDl()" class="shortcuticons">
                <img src="Themes/Images/32/316.png" alt="" /><br />
                <%=Resources.Resource.login_information%></div>
            <div onclick="openTq()" class="shortcuticons">
                <img src="Themes/Images/32/367.png" alt="" /><br /><%=Resources.Resource.weather_forecast%></div>
            <br />
            <br />
            <br />
            <br />
        </div>
    </div>
    <div class="blank10">
    </div>
    <div class="box">
        <div class="box-title">
            <img src="Themes/Images/milestone.png" alt="" width="20" height="20" /><%=Resources.Resource.current_login_situation%>（<%=Resources.Resource.online%>【<asp:Label
                ID="lblOnline" runat="server" Text="0"></asp:Label>】）
        </div>
        <div class="box-content">
            <%=Resources.Resource.login_timesofthismonth%>：<asp:Label ID="lblNum" runat="server" Text=""></asp:Label> <%=Resources.Resource.time%>
            <br />
             <%=Resources.Resource.Login_IP%>：<asp:Label ID="lblNowLoginIp" runat="server" Text=""></asp:Label><br />
            <%=Resources.Resource.login_time%>：<asp:Label ID="lblNowLoginTime" runat="server" Text=""></asp:Label><br />
             <%=Resources.Resource.last_login_ip%>：<asp:Label ID="lblLastLoginIp" runat="server" Text=""></asp:Label><br />
             <%=Resources.Resource.last_login_time%>：<asp:Label ID="lblLastLoginTime" runat="server" Text=""></asp:Label><br />
            <br />
            <img src="Themes/Images/exclamation_octagon_fram.png" style="vertical-align: middle;
                margin-bottom: 3px;" width="16" height="16" alt="tip" />
            <%=Resources.Resource.String16 %> <a href="javascript:void(0);" title="修改登录密码" style="text-decoration: underline;
                color: Blue;" onclick="editpwd()"><%=Resources.Resource.Password_modification %></a>
        </div>
    </div>
    <div class="blank10">
    </div>

    <div id="div_tq" class="easyui-window" title="天气预报"  style="width:450px;height:300px;padding:5px;background: #fafafa;">
		<div class="easyui-layout" fit="true">
			<div region="center" border="false" style="padding:10px;background:#fff;border:1px solid #ccc;">
                <div style=" width:60px; height:60px; float:left; padding-left:50px;"><img id="img" runat="server" />  <br /></div>
                <div style=" padding-left:50px; float:left;">
                星期：<asp:Label ID="lab_Week" runat="server" Text="Label"></asp:Label><br />
                时间：<asp:Label ID="lab_Time" runat="server" Text="Label"></asp:Label><br />
                城市：<asp:Label ID="lab_City" runat="server" Text="Label"></asp:Label><br />
                天气：<asp:Label ID="lab_Tianqi" runat="server" Text="Label"></asp:Label><br />
                温度：<asp:Label ID="lab_wendu" runat="server" Text="Label"></asp:Label><br />
                风力：<asp:Label ID="lab_Fengli" runat="server" Text="Label"></asp:Label><br />
                紫外线：<asp:Label ID="lab_UV" runat="server" Text="Label"></asp:Label><br />
                洗车：<asp:Label ID="lab_Xc" runat="server" Text="Label"></asp:Label><br />
                舒适度：<asp:Label ID="lab_Co" runat="server" Text="Label"></asp:Label><br />   
                </div>
			</div>
			<div region="south" border="false" style="text-align:right;height:30px;line-height:30px;">
                <a class="easyui-linkbutton" iconCls="icon-ok" href="javascript:void(0)" onclick="closeTq()">Ok</a>
			</div>
		</div>
	</div>
    </form>
</body>
</html>
