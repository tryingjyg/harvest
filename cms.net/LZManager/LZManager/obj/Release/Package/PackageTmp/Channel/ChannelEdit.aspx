<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChannelEdit.aspx.cs" Inherits="LZManager.Game.ChannelEdit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link rel="stylesheet" href="../css/Site_Css.css" type="text/css" />
    <link rel="stylesheet" href="../css/table/default/Css.css" type="text/css" />
    <style type="text/css">
        .text_input
        {
        }
    </style>
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
            <td class="table_body">
                <%=Resources.Resource.channel_name%>:
            </td>
            <td class="table_none">
                <asp:TextBox ID="txtChannelName" CssClass="text_input" runat="server" Width="50%"
                    MaxLength="50"></asp:TextBox>
                <font color="red">*</font>
            </td>
        </tr>
        <tr>
            <td class="table_body">
                <%=Resources.Resource.channel_ID%>:
            </td>
            <td class="table_none">
                <asp:TextBox ID="txtChannelId" CssClass="text_input" runat="server" Width="50%" MaxLength="50"></asp:TextBox>
                <font color="red">*</font>
            </td>
        </tr>
        <tr>
            <td class="table_body">
                <%=Resources.Resource.channel_description%>：
            </td>
            <td class="table_none">
                <asp:TextBox ID="txtDescription" CssClass="text_input" runat="server" Width="50%"
                    MaxLength="2" Height="126px" TextMode="MultiLine"></asp:TextBox>
                <font color="red">*</font>
            </td>
        </tr>
        <tr>
            <td class="table_body">
                <%=Resources.Resource.On_Off%>:
            </td>
            <td class="table_none">
                <asp:RadioButtonList ID="rblState" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem Selected="True" Value="0" Text="<%$ Resources:Resource,on %>"></asp:ListItem>
                    <asp:ListItem Value="1" Text="<%$ Resources:Resource,off %>"></asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td class="table_body">
            </td>
            <td class="table_body">
                <asp:Button ID="btnOK" runat="server" CssClass="button_bak" Text="<%$ Resources:Resource,Determine %>"
                    OnClick="btnOK_Click" Height="28px" Width="80px" OnClientClick="top.ShowDiv_load()" />
                <asp:Button ID="btnReturn" runat="server" CssClass="button_bak" Text="<%$ Resources:Resource,Return%>"
                    OnClick="btnReturn_Click" Height="28px" Width="80px" />
                <asp:HiddenField ID="Cnid" runat="server" />
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
