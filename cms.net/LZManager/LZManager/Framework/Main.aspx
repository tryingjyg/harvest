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
                                ��ǰʱ�䣺<span id="clock"></span>
                            </td>
                        </tr>
                        <tr>
                            <td style="font-weight: bold; font-size: 16px">
                                <asp:Label ID="lblUser" runat="server" Text=""></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                ��ӭ��������<asp:Label ID="lbl_Pname" runat="server" Text="ͨ��" CssClass="ptext"></asp:Label>����ƽ̨��
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
                    ���������Ϣ
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
                    ��½�ʺţ�
                </td>
                <td style="color: #880000">
                    <asp:Label ID="lblUserName" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="right">
                    ע��ʱ�䣺
                </td>
                <td style="color: #880000">
                    <asp:Label ID="lblAddTime" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="right">
                    ��½������
                </td>
                <td style="color: #880000">
                    <asp:Label ID="lblNum" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="right">
                    �ϴε�½��Ϣ
                </td>
                <td style="color: #880000">
                </td>
            </tr>
            <tr>
                <td align="right">
                    ��¼ʱ�䣺
                </td>
                <td style="color: #880000">
                    <asp:Label ID="lblLastLoginTime" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="right">
                    IP��ַ��
                </td>
                <td style="color: #880000">
                    <asp:Label ID="lblLastLoginIp" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="right">
                    ���ε�½��Ϣ
                </td>
                <td style="color: #880000">
                </td>
            </tr>
            <tr>
                <td align="right">
                    ��¼ʱ�䣺
                </td>
                <td style="color: #880000">
                    <asp:Label ID="lblNowLoginTime" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="right">
                    IP��ַ��
                </td>
                <td style="color: #880000">
                    <asp:Label ID="lblNowLoginIp" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="right">
                    ��ݹ��ڣ�
                </td>
                <td style="color: #880000">
                    60 ����
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
