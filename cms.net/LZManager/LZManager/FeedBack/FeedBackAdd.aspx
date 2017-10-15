<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FeedBackAdd.aspx.cs" Inherits="LZManager.FeedBack.FeedBackAdd" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
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
        <tr>
            <td bgcolor="#cadee8" width="10%">
                所属平台:
            </td>
            <td bgcolor="#e9f2f7" width="40%">
                <asp:DropDownList ID="ddlPf" runat="server" Width="200px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td bgcolor="#cadee8">
                反馈标题：
            </td>
            <td bgcolor="#e9f2f7">
                <asp:TextBox ID="txtTitle" runat="server" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td bgcolor="#cadee8">
                图片上传：
            </td>
            <td bgcolor="#e9f2f7">
                <asp:FileUpload ID="FileUpload1" runat="server" Width="250px" />
            </td>
        </tr>
        <tr>
            <td bgcolor="#cadee8">
                反馈内容：
            </td>
            <td bgcolor="#e9f2f7">
                <asp:TextBox ID="txtMessage" runat="server" Width="500px" Height="274px" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td bgcolor="#cadee8" colspan="2" align="center" height="40px">
                <asp:Button ID="btnAdd" runat="server" Text="提交信息" CssClass="button_bak" Width="100px"
                    Height="30px" OnClick="btnAdd_Click" OnClientClick="top.ShowDiv_load()" />
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
