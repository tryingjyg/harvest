<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Header.aspx.cs" Inherits="LZManager.Framework.Header" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html>
<head id="Head1">
    <title>�ޱ���ҳ</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf8">
    <meta http-equiv="X-UA-Compatible" content="IE=EmulateIE9" />
    <style type="text/css">
        *
        {
            font-size: 12px;
            color: white;
        }
        #logo
        {
            color: white;
        }
        #logo A
        {
            color: white;
        }
        FORM
        {
            margin: 0px;
        }
        .Name
        {
            color: Aqua;
        }
        .Department
        {
            color: Silver;
        }
        .Leave
        {
            color: Red;
        }
         .Plant
        {
            color: Orange;
        }
    </style>
    <script src="../JavaScript/top/Clock.js" type="text/javascript"></script>
    <meta content="MSHTML 6.00.2900.5848" name="GENERATOR">
</head>
<body style="background-image: url(../Images/top/bg.gif); margin: 0px; background-repeat: repeat-x">
    <form id="form1" runat="server">
    <div id="logo" style="background-image: url(../Images/top/logo.png); background-repeat: no-repeat">
        <div style="padding-right: 50px; background-position: right 50%; display: block;
            padding-left: 0px; background-image: url(../Images/top/bg_banner_menu.gif); padding-bottom: 0px;
            padding-top: 3px; background-repeat: no-repeat; height: 30px; text-align: right">
                <img src="../Images/top/mail.gif" align="absMiddle" border="0">��������Ϣ<a id="HyperLink1"
                    href="#">0</a>��
            <img src="../Images/top/menu_seprator.gif" align="absMiddle" />
            <a id="HyperLink2" href="javascript:void()" onclick="top.location.reload()">�л�ƽ̨</a>
            <img src="../Images/top/menu_seprator.gif" align="absMiddle" />
            <a id="HyperLink3" href="../Login.aspx" target="_top">�˳�ϵͳ</a>
        </div>
        <div style="display: block; height: 54px;" align="right">
        </div>
        <div style="background-image: url(../Images/top/bg_nav.gif); background-repeat: repeat-x;
            height: 30px">
            <table cellspacing="0" cellpadding="0" width="100%">
                <tbody>
                    <tr>
                        <td>
                            <div>
                                <img src="../Images/top/nav_pre.gif" align="absMiddle">
                                ��ӭ <span id="lblBra">
                                    <asp:Label ID="lblUserName" runat="server" Text="" CssClass="Name"></asp:Label>
                                </span><span id="lblDep">��<asp:Label ID="lblDepartment" runat="server" Text="" CssClass="Department"></asp:Label>��
                                    ��<asp:Label ID="lblLeave" runat="server" Text="" CssClass="Leave"></asp:Label>��
                                <asp:Label ID="lblPlant" runat="server" Text="" CssClass="Plant"></asp:Label>
                                </span><span style="padding: 20px;"></span>
                            </div>
                        </td>
                        <td align="right" width="60%">
                            <span style="padding-right: 50px"><a href="javascript:history.go(-1);">
                                <img src="../Images/top/nav_back.gif" align="absMiddle" border="0">����</a> <a href="javascript:history.go(1);">
                                    <img src="../Images/top/nav_forward.gif" align="absMiddle" border="0">ǰ��</a>
                                <a href="../Login.aspx" target="_top">
                                    <img src="../Images/top/nav_changePassword.gif" align="absMiddle" border="0">���µ�¼</a>
                                <a onclick=" top.ChangeTitleName('�޸�����')" href="../Users/UsersPasswordEdit.aspx?Urid=<%=strUrid %>&Action=0"
                                    target="right_body">
                                    <img src="../Images/top/nav_resetPassword.gif" align="absMiddle" border="0">�޸�����</a>
                                <a onclick=" top.ChangeTitleName('���ⷴ��')" href="../FeedBack/FeedBackList.aspx" target="right_body">
                                    <img src="../Images/top/nav_help.gif" align="absMiddle" border="0">���ⷴ��</a>
                                <img src="../Images/top/menu_seprator.gif" align="absMiddle">
                                <span id="clock"></span></span>
                        </td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
    <script type="text/javascript">
        var clock = new Clock();
        clock.display(document.getElementById("clock"));       
    </script>
    </form>
</body>
</html>
