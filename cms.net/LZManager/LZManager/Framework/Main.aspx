<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="LZManager.Framework.Main" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html>
<head>
    <meta http-equiv="X-UA-Compatible" content="IE=EmulateIE9" />
    <meta http-equiv="Content-Type" content="text/html; charset=gb2312">
    <link href="../Css/admin.css" rel="stylesheet" type="text/css" />
    <script src="../JavaScript/top/Clock.js" type="text/javascript"></script>
    <script src="../JavaScript/Script/reflection.js" type="text/javascript"></script>
</head>
<body>
    <div style=" width:100%; height:100%; padding-top:40px;">
        <table cellspacing="0" cellpadding="0" width="90%" align="center" border="0">
            <tr height="100">
                <td align="middle" width="100">
                    <asp:Image ID="imglogo" runat="server"  CssClass="reflect" />
                </td>
                <td width="60">
                    &nbsp;
                </td>
                <td>
                    <table cellspacing="0" cellpadding="0" width="100%" border="0" height="100px">
                        <tr>
                            <td>
                                当前时间：<span id="clock"></span>
                            </td>
                        </tr>
                        <tr>
                            <td style="font-weight: bold; font-size: 16px">
                                <asp:Label ID="lblUser" runat="server" Text=""></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                欢迎进入联众<asp:Label ID="lbl_Pname" runat="server" Text="通用" CssClass="ptext"></asp:Label>管理平台！
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td colspan="3" height="10">
                </td>
            </tr>
        </table>
        <table cellspacing="0" cellpadding="0" width="95%" align="center" border="0">
            <tr height="20">
                <td>
                </td>
            </tr>
            <tr height="22">
                <td style="padding-left: 20px; font-weight: bold; color: #ffffff" align="middle"
                    background="../images/farmework/title_bg2.jpg">
                    您的相关信息
                </td>
            </tr>
            <tr bgcolor="#ecf4fc" height="12">
                <td>
                </td>
            </tr>
            <tr height="20">
                <td>
                </td>
            </tr>
        </table>
        <table cellspacing="0" cellpadding="2" width="95%" align="center" border="0">
            <tr>
                <td align="right" width="100">
                    登陆帐号：
                </td>
                <td style="color: #880000">
                    <asp:Label ID="lblUserName" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="right">
                    注册时间：
                </td>
                <td style="color: #880000">
                    <asp:Label ID="lblAddTime" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="right">
                    登陆次数：
                </td>
                <td style="color: #880000">
                    <asp:Label ID="lblNum" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="right">
                    上次登陆信息
                </td>
                <td style="color: #880000">
                </td>
            </tr>
            <tr>
                <td align="right">
                    登录时间：
                </td>
                <td style="color: #880000">
                    <asp:Label ID="lblLastLoginTime" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="right">
                    IP地址：
                </td>
                <td style="color: #880000">
                    <asp:Label ID="lblLastLoginIp" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="right">
                    本次登陆信息
                </td>
                <td style="color: #880000">
                </td>
            </tr>
            <tr>
                <td align="right">
                    登录时间：
                </td>
                <td style="color: #880000">
                    <asp:Label ID="lblNowLoginTime" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="right">
                    IP地址：
                </td>
                <td style="color: #880000">
                    <asp:Label ID="lblNowLoginIp" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="right">
                    身份过期：
                </td>
                <td style="color: #880000">
                    60 分钟
                </td>
            </tr>
        </table>
    </div>
    <script type="text/javascript">
        var clock = new Clock();
        clock.display(document.getElementById("clock"));
    </script>
</body>
</html>
