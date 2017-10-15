<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QrCode.aspx.cs"
    Inherits="LZManager.Users.QrCode" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>权限复制/转移</title>
    <link rel="stylesheet" href="../css/Site_Css.css" type="text/css" />
    <link rel="stylesheet" href="../css/table/default/Css.css" type="text/css" />
    <script src="../JavaScript/Dialog/jquery-1.7.2.min.js" type="text/javascript"></script>
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
                    二维码图片:
                </td>
                <td class="table_none" align="left">
                    <asp:Image ID ="img" ImageUrl="../Images/farmework/close.png" runat="server" Width ="200px" Height ="200px"/>
                </td>
            </tr>
            <tr>
                <td class="table_body">
                </td>
                <td class="table_body" align="right">
                    <asp:Button ID="btnReturn" runat="server" CssClass="button_bak" Text="<%$ Resources:Resource,Return%>" OnClick="btnReturn_Click"
                        Height="28px" Width="150px" />
                </td>
            </tr>
        </tbody>
    </table>
    </form>
</body>
</html>
