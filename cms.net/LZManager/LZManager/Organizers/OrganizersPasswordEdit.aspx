﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrganizersPasswordEdit.aspx.cs"
    Inherits="LZManager.Organizers.OrganizersPasswordEdit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="../css/Site_Css.css" type="text/css" />
    <link rel="stylesheet" href="../css/table/default/Css.css" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="divAlert" runat="server" visible="false">
        <table width="100%" border="0" cellspacing="1" cellpadding="3" align="center">
            <tr>
                <td bgcolor="#ffffb9" height="30px">
                    <asp:Label ID="lblAlert" runat="server" Font-Bold="True" Font-Size="Small" ForeColor="Red"></asp:Label>
                </td>
            </tr>
        </table>
        <br />
    </div>
    <table width="100%" border="0" cellspacing="1" cellpadding="3" align="center">
        <tbody>
            <tr>
                <td class="table_body">
                    管理员账号:
                </td>
                <td class="table_none">
                    <asp:Label ID="lblUserName" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="table_body">
                    当前密码:
                </td>
                <td class="table_none">
                    <asp:TextBox ID="txtPass" CssClass="text_input" runat="server" TextMode="Password"
                        Width="50%" MaxLength="100"></asp:TextBox>
                    <font color="red">*</font>
                </td>
            </tr>
            <tr>
                <td class="table_body">
                    新密码:
                </td>
                <td class="table_none">
                    <asp:TextBox ID="txtNewPass" CssClass="text_input" runat="server" Width="50%" MaxLength="100"
                        TextMode="Password"></asp:TextBox>
                    <font color="red">*</font>
                </td>
            </tr>
            <tr>
                <td class="table_body">
                    确认密码:
                </td>
                <td class="table_none">
                    <asp:TextBox ID="txtRePass" CssClass="text_input" runat="server" Width="50%" MaxLength="100"
                        TextMode="Password"></asp:TextBox>
                    <font color="red">*</font>
                </td>
            </tr>
            <tr>
                <td class="table_body">
                </td>
                <td class="table_body">
                    <asp:Button ID="btnOK" runat="server" CssClass="button_bak" Text="确定" Height="28px"
                        Width="80px" OnClick="btnOK_Click" OnClientClick="top.ShowDiv_load()" />
                </td>
            </tr>
        </tbody>
    </table>
    </form>
</body>
</html>
