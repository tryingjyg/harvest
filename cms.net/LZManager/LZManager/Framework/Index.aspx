<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="LZManager.Frameworks.Index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html>
<head>
    <title>通用用户权限系统</title>
    <link href="Themes/Styles/Menu.css" rel="stylesheet" type="text/css" />
    <link href="Themes/icon.css" rel="stylesheet" type="text/css" />
    <link href="Themes/easyui.css" rel="stylesheet" type="text/css" />
    <script src="Themes/Scripts/jquery-1.4.4.min.js" type="text/javascript"></script>
    <script src="Themes/Scripts/jquery.easyui.min.js" type="text/javascript"></script>
    <style type="text/css">
        a:link
        {
            color: blue;
            text-decoration: none;
        }
        a:visited
        {
            color: blue;
            text-decoration: none;
        }
        a:hover
        {
            color: Silver;
            text-decoration: none;
        }
        #loading
        {
            position: absolute;
            z-index: 3000;
            left: 45%;
            top: 45%;
            border: 1px solid #ccc;
            width: auto;
            padding: 6px 5px 6px 40px;
            background: #fff url('Themes/Images/loading.gif') no-repeat scroll 7px 2px;
            display: none;
            cursor: pointer;
        }
    </style>
    <script type="text/javascript">
        $(document).ready(function () {
            writeDateInfo();
        });


        function addmenu() {
            var header = $('.layout-expand .layout-button-down').parent().parent();
            var menu = $('<div style="position:absolute;left:0;top:0;background:#fafafa;"></div>').appendTo(header);
            var btn = $('<a href="#">test</a>').appendTo(menu);
            btn.menubutton({
                menu: '#mymenu'
            });
        }
        function AddPanel(url, name) {
            Loading(true);
            if ($('#tt').tabs('exists', name)) {
                $('#tt').tabs('select', name);
                update(name);
            } else {
                /**添加一个tab标签**/
                $('#tt').tabs('add', {
                    title: name,
                    content: '<iframe scrolling="auto" frameborder="0"  src="' + url + '" style="width:100%;height:100%;"></iframe>',
                    closable: true
                });
            }
        }
         
        function update(name) {
            var tab = $('#tt').tabs('getSelected');
            $('#tt').tabs('update', {
                tab: tab,
                options: {
                    title: name
                }
            });

        }

        //当前日期
        function writeDateInfo() {
            var day = "";
            var month = "";
            var ampm = "";
            var ampmhour = "";
            var myweekday = "";
            var year = "";
            mydate = new Date();
            myweekday = mydate.getDay();
            mymonth = mydate.getMonth() + 1;
            myday = mydate.getDate();
            myyear = mydate.getYear();
            year = (myyear > 200) ? myyear : 1900 + myyear;
            if (myweekday == 0)
                weekday = " Sunday";
            else if (myweekday == 1)
                weekday = " Monday";
            else if (myweekday == 2)
                weekday = " Tuesday";
            else if (myweekday == 3)
                weekday = " Wednesday";
            else if (myweekday == 4)
                weekday = " Thursday";
            else if (myweekday == 5)
                weekday = " Friday";
            else if (myweekday == 6)
                weekday = " Saturday";
            $("#datetime").text(year + "year" + mymonth + "month" + myday + "day " + weekday);
        }


        function OutPlant() { // 退出平台
            if (confirm('Are you sure you want to exit the platform？')) {
                top.location.href = "LoginPlant.aspx";
            }
        }

        function IndexOut() {
            if (confirm('Are you sure you want to exit the system？')) {
                top.location.href = "../Login.aspx";
            }
        }

        function returnUp() {
            alert("This function can not be used for the time being！");
        }


        function showLoad() {
            Loading(true);
        }


        /**
        中间加载对话窗
        **/
        function Loading(bool) {
            if (bool) {
                $("#loading").show();
            } else {
                $("#loading").hide();
            }
        }
    </script>
</head>
<body class="easyui-layout">
    <div region="north" style="height: 100px;">
        <div id="Header">
            <div id="HeaderLogo">
            </div>
            <div id="weather">
            </div>
            <div id="Headermenu">
                <table style="padding: 0px; height: 70px;" cellpadding="0" cellspacing="0">
                    <tr valign="bottom">
                        <td id="menutab">
                            <div class="sel">
                                <%=Resources.Resource.system_application%></div>
                            <div class="removesel" onclick="OutPlant()">
                                <%=Resources.Resource.switch_platform%></div>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
        <div id="Headerbotton">
            <div id="left_title">
                <img src="Themes/Images/clock_32.png" alt="" width="20" height="20" style="vertical-align: middle;
                    padding-bottom: 1px;" />
                <span id="datetime"></span>
            </div>
            <div id="conten_title">
                <div id="toolbar" style="text-align: right; padding-right: 3px;">
                    &nbsp;&nbsp;&nbsp;<img src="Themes/Images/refresh.png" title="刷新业务窗口" alt="" onclick="window.location.reload();return false;"
                        width="20" height="20" style="padding-top: 1px; cursor: pointer; vertical-align: middle;" />
                    &nbsp;&nbsp;&nbsp;<img src="Themes/Images/4963_home.png" title="返回首页" alt="" onclick="returnUp()"
                        width="20" height="20" style="padding-top: 1px; cursor: pointer; vertical-align: middle;" />
                    &nbsp; &nbsp;<img src="Themes/Images/button-white-stop.png" title="安全退出" alt="" onclick="IndexOut()"
                        width="20" height="20" style="padding-top: 1px; cursor: pointer; vertical-align: middle;" />
                </div>
            </div>
        </div>
    </div>
    <div region="west" split="true" title="Main Menu" style="width: 280px; padding1: 1px;
        overflow: hidden;">
        <div class="easyui-accordion" fit="true" border="false" id="leftMenu" runat="server">
            <div title="Title1" style="overflow: auto;">
                <p>
                    content1</p>
            </div>
        </div>
    </div>
    <div region="center" style="overflow: hidden;">
        <div class="easyui-tabs" fit="true" border="false" id="tt">
            <div title="<%=Resources.Resource.Welcome%>">
                <iframe scrolling="auto" frameborder="0" scrolling="yes" width="100%" height="100%"
                    src="HomeIndex.aspx"></iframe>
            </div>
        </div>
    </div>
    <div region="south" style="height: 30px; background: #efefef;">
        <div id="botton_toolbar">
            <div style="width: 33%; float: left; text-align: left;">
                <%=Resources.Resource.current_version%> V1.0
            </div>
            <div style="width: 34%; float: left; text-align: center;">
               <%=Resources.Resource.company_name%>
            </div>
            <div style="width: 33%; float: left; text-align: right">
                 <%=Resources.Resource.OnlyWelcome%>:【<asp:Label ID="lblUserName" runat="server" Text="" CssClass="Name"></asp:Label>】
                <%=Resources.Resource.Onlydepartment%>：【<asp:Label ID="lblDepartment" runat="server" Text="" CssClass="Department"></asp:Label>】
                <%=Resources.Resource.OnlyRole%>：【<asp:Label ID="lblLeave" runat="server" Text="" CssClass="Leave"></asp:Label>】
            </div>
        </div>
    </div>
    <div id="loading">
        正在努力的处理中，请稍待。。。
    </div>
</body>
</html>
