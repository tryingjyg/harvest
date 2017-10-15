<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RoleEdit.aspx.cs" Inherits="LZManager.Role.RoleEdit" %>

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
        <tr>
            <td class="table_body">
                <%=Resources.Resource.role_name%>:
            </td>
            <td class="table_none">
                <asp:TextBox ID="txtRlName" CssClass="text_input" runat="server" Width="50%" MaxLength="50"></asp:TextBox>
                <font color="red">*</font>
            </td>
        </tr>
        <tr>
            <td class="table_body">
                <%=Resources.Resource.platform%>:
            </td>
            <td class="table_none">
                <asp:DropDownList ID="ddlPf" runat="server">
                    <asp:ListItem Selected="True" Value="-1"> All platform</asp:ListItem>
                </asp:DropDownList>
                <asp:LinkButton ID="lkPlatformEdit" runat="server" Font-Bold="True" Font-Size="Small"
                    ForeColor="Red" Visible="False" OnClick="lkPlatformEdit_Click" Text="<%$ Resources:Resource,No_information_click_create_platform %>"></asp:LinkButton>
            </td>
        </tr>
        <tr    style="display: none">
            <td class="table_body">
                <%=Resources.Resource.Belong_to_the_game %>:<span style="color: Red; font-size: 8px">(<%=Resources.Resource.Add_specific_background_to_the_use_of_person %>)</span>
            </td>
            <td class="table_none">
                <asp:CheckBoxList ID="cblGame" runat="server" RepeatDirection="Horizontal" RepeatColumns="4">
                </asp:CheckBoxList>
            </td>
        </tr>
        <tr>
            <td class="table_body">
                <%=Resources.Resource.On_Off%>:
            </td>
            <td class="table_none">
                <asp:RadioButtonList ID="rblState" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem Selected="True" Value="0" Text="<%$ Resources:Resource,On%>"></asp:ListItem>
                    <asp:ListItem Value="1" Text="<%$ Resources:Resource,Off%>"></asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td class="table_body">
            </td>
            <td class="table_body">
                <asp:Button ID="btnOK" runat="server" CssClass="button_bak" Text="<%$ Resources:Resource,Determine%>"
                    Height="28px" Width="80px" OnClick="btnOK_Click" OnClientClick="top.ShowDiv_load()" />
                <asp:Button ID="btnReturn" runat="server" CssClass="button_bak" Text="<%$ Resources:Resource,Return%>"
                    Height="28px" Width="80px" OnClick="btnReturn_Click" />
                <asp:HiddenField ID="hfRoleName" runat="server" />
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
