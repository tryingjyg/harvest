<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RoleList.aspx.cs" Inherits="LZManager.Role.RoleList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="../css/Site_Css.css" type="text/css" />
    <link rel="stylesheet" href="../css/table/default/Css.css" type="text/css" />
    <script src="../JavaScript/Dialog/jquery-1.7.2.min.js" type="text/javascript"></script>
    <script  type="text/javascript">

        $(function () {

            //alert("进来了这个页面");
            $("#<%=btnDel.ClientID%>").click(function () {

                var lenthCheck = $("input[type='checkbox']:checked").length;

                if (lenthCheck < 1) {

                    alert("Please select the record to delete!");

                    return false;


                }

                if (confirm("Are you sure you want to delete the changed character？")) {






                } else {

                    return false;

                }






            });

        })


    </script>

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
                 <%=Resources.Resource.role_name%>:
            </td>
            <td bgcolor="#e9f2f7" width="23%">
                <asp:TextBox ID="txtRlName" CssClass="text_input" runat="server" MaxLength="50" Width="50%"></asp:TextBox>
            </td>
            <td bgcolor="#cadee8" width="10%">
              <%=Resources.Resource.platform%>:
            </td>
            <td bgcolor="#e9f2f7" width="23%">
                <asp:DropDownList ID="ddlPf" runat="server">
                    <asp:ListItem Selected="True" Value="" Text="<%$ Resources:Resource,allplatform %>"></asp:ListItem>
                </asp:DropDownList>
            </td>
            <td bgcolor="#cadee8" width="10%">
             <%=Resources.Resource.On_Off%>:
            </td>
            <td bgcolor="#e9f2f7">
                <asp:RadioButtonList ID="rblState" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem Selected="True" Value="0" Text="<%$ Resources:Resource,on %>"></asp:ListItem>
                    <asp:ListItem Value="1" Text="<%$ Resources:Resource,off %>"></asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td align="right" colspan="6">
                <asp:Button ID="btnSearch" runat="server" CssClass="button_bak" Text="<%$ Resources:Resource,search %>" Height="28px"
                    Width="80px" OnClick="btnSearch_Click" OnClientClick="top.ShowDiv_load()" />
                <asp:Button ID="btnReset" runat="server" CssClass="button_bak" Text="<%$ Resources:Resource,reset %>" Height="28px"
                    Width="80px" OnClick="btnReset_Click" />
            </td>
        </tr>
    </table>
    <hr style="filter: alpha(opacity=100, finishopacity=0, style=3)" width="100%" color="#7898a8"
        size="3">
    <table width="100%" border="0" cellspacing="0" cellpadding="3" align="center">
        <tr>
            <td>
                
                <asp:CheckBox ID="chbSelectAll" Text="<%$ Resources:Resource,all %>" runat="server" AutoPostBack="True" OnCheckedChanged="chbSelectAll_CheckedChanged" />
                <asp:CheckBox ID="chbUnSelectAll" Text="<%$ Resources:Resource,inverse %>" runat="server" AutoPostBack="True" OnCheckedChanged="chbUnSelectAll_CheckedChanged" />
            </td>
            <td align="right">
                <asp:Button ID="btnAdd" runat="server" CssClass="button_bak" Text="<%$ Resources:Resource,add %>" OnClick="btnAdd_Click"
                    Height="28px" Width="80px" />
                <asp:Button ID="btnEdit" runat="server" CssClass="button_bak" Text="<%$ Resources:Resource,update %>" OnClick="btnEdit_Click"
                    Height="28px" Width="80px" />
                <asp:Button ID="btnAddPermissions" runat="server" CssClass="button_bak" Text="<%$ Resources:Resource,authority_setting_for_different_roles %>"
                    Height="28px"  OnClick="btnAddPermissions_Click" />
                <asp:Button ID="btnDel" runat="server" CssClass="button_bak" Text="<%$ Resources:Resource,delete %>" OnClick="btnDel_Click"
                    Height="28px" Width="80px" />
            </td>
        </tr>
    </table>
    <asp:GridView ID="gvRole" runat="server" AllowSorting="True" AllowPaging="True" PageSize="15"
        AutoGenerateColumns="False" DataKeyNames="Rl_id,Rl_name,Pf_id" OnRowDataBound="gvRole_RowDataBound"
        CellSpacing="1" CssClass="table-box" GridLines="None" BackColor="#E9F2F7" EmptyDataText="<%$ Resources:Resource,No_data %>"
        OnSorting="gvRole_Sorting" onpageindexchanging="gvRole_PageIndexChanging">
        <AlternatingRowStyle CssClass="row1" BackColor="#cadee8" />
        <Columns>
            <asp:TemplateField HeaderText="<%$ Resources:Resource,select %>">
                <ItemTemplate>
                    <asp:CheckBox ID="chbSelect" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="Rl_name" HeaderText="<%$ Resources:Resource,role_name %>" SortExpression="Rl_name" />
            <asp:BoundField DataField="Pf_name" HeaderText="<%$ Resources:Resource,platform %>" SortExpression="Pf_name" />
            <asp:BoundField DataField="Pf_text1" HeaderText="<%$ Resources:Resource,platform %>" SortExpression="Pf_text1" />
            <asp:BoundField DataField="Rl_state" HeaderText="<%$ Resources:Resource,On_Off %>" SortExpression="Rl_state" />
            <asp:BoundField DataField="Ur_name" HeaderText="<%$ Resources:Resource,added_by %>" SortExpression="Ur_name" />
            <asp:BoundField DataField="Rl_addTime" HeaderText="<%$ Resources:Resource,added_time %>" SortExpression="Rl_addTime" />
        </Columns>
        <HeaderStyle BackColor="#7898A8" CssClass="table_title" ForeColor="White" Height="35px"
            Font-Size="Medium" />
        <RowStyle Height="28px" HorizontalAlign="Center" />
    </asp:GridView>
    </form>
</body>
</html>
