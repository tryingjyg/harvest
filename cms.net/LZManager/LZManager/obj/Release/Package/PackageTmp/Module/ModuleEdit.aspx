<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModuleEdit.aspx.cs" Inherits="LZManager.Module.ModuleEdit" %>

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
        <tr id="trMdParent" runat="server">
            <td class="table_body">
                <%=Resources.Resource.parentmodulename%>:
            </td>
            <td class="table_none">
                <asp:Label ID="lblMdPartentName" runat="server"></asp:Label>
            </td>
        </tr>
        <tr id="trMdParent_en" runat="server">
            <td class="table_body">
                module name:
            </td>
            <td class="table_none">
                <asp:Label ID="lblMdPartentName_en" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="table_body">
                <asp:Label ID="lblMdTitle" runat="server"></asp:Label>
            </td>
            <td class="table_none">
                <asp:TextBox ID="txtMdName" CssClass="text_input" runat="server" Width="50%" MaxLength="100"></asp:TextBox>
                <font color="red">*</font>
            </td>
        </tr>
        <tr>
            <td class="table_body">
                <asp:Label ID="lblMdTitle_en" runat="server"></asp:Label>
            </td>
            <td class="table_none">
                <asp:TextBox ID="txtMdName_en" CssClass="text_input" runat="server" Width="50%" MaxLength="100"></asp:TextBox>
                <font color="red">*</font>
            </td>
        </tr>
        <tr>
            <td class="table_body">
                <%=Resources.Resource.moduleaddress%>:
            </td>
            <td class="table_none">
                <asp:TextBox ID="txtAddress" CssClass="text_input" runat="server" Width="50%" MaxLength="200">#</asp:TextBox>
                <font color="red">*</font>
            </td>
        </tr>
        <tr>
            <td class="table_body">
                <%=Resources.Resource.platform%>:
            </td>
            <td class="table_none">
                <asp:DropDownList ID="ddlPf" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlPf_SelectedIndexChanged">
                </asp:DropDownList>
                <asp:LinkButton ID="lkPlatformEdit" runat="server" Font-Bold="True" Font-Size="Small"
                    ForeColor="Red" Visible="False" OnClick="lkPlatformEdit_Click" Text="<%$ Resources:Resource,No_information_click_create_platform %>"></asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td class="table_body">
                <%=Resources.Resource.Major_function_name%>：
            </td>
            <td class="table_none">
                <asp:CheckBoxList ID="cblPermissionsTatal" runat="server" RepeatDirection="Horizontal">
                </asp:CheckBoxList>
                <asp:LinkButton ID="lkPermissionsTatalEdit" runat="server" Font-Bold="True" Font-Size="Small"
                    ForeColor="Red" Visible="False" OnClick="lkPermissionsTatalEdit_Click" Text="<%$ Resources:Resource,The_general_information_and_click_the_create_function %>"></asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td class="table_body">
                <%=Resources.Resource.Remarks%>:
            </td>
            <td class="table_none">
                <asp:TextBox ID="txtNotes" CssClass="text_input" runat="server" Width="50%" MaxLength="500"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="table_body">
                <%=Resources.Resource.sort%>：
            </td>
            <td class="table_none">
                <asp:TextBox ID="txtSort" CssClass="text_input" runat="server" Width="10%" MaxLength="4"></asp:TextBox>
                <font color="red">*</font>
            </td>
        </tr>
        <tr>
            <td class="table_body">
                <%=Resources.Resource.Whether_to_display_in_the_tree_directory%>:
            </td>
            <td class="table_none">
                <asp:RadioButtonList ID="rblMdExist" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem Selected="True" Value="0" Text="<%$ Resources:Resource,yes %>"></asp:ListItem>
                    <asp:ListItem Value="1" Text="<%$ Resources:Resource,no %>"></asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td class="table_body">
                <%=Resources.Resource.On_Off%>:
            </td>
            <td class="table_none">
                <asp:RadioButtonList ID="rblState" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem Selected="True" Value="0" Text="<%$ Resources:Resource,On %>"></asp:ListItem>
                    <asp:ListItem Value="1" Text="<%$ Resources:Resource,Off %>"></asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td class="table_body">
            </td>
            <td class="table_body">
                <asp:Button ID="btnOK" runat="server" CssClass="button_bak" Text="<%$ Resources:Resource,Determine %>"
                    Height="28px" Width="80px" OnClick="btnOK_Click" OnClientClick="top.ShowDiv_load()" />
                <input id="Button1" type="button" value="<%=Resources.Resource.Return%>" class="button_bak"
                    style="height: 28px; width: 80px;" onclick="javascript:history.go(-1);" />
                <asp:HiddenField ID="hfMdName" runat="server" />
                <asp:HiddenField ID="hfMdId" runat="server" />
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
