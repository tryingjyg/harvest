<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrganizersList.aspx.cs" Inherits="LZManager.Organizers.OrganizersList" %>

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

                if (confirm("Are you sure you want to delete the platform？")) {

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
            <td bgcolor="#cadee8">
                <%=Resources.Resource.Admin_acount%>:
            </td>
            <td bgcolor="#e9f2f7">
                <asp:TextBox ID="txtLoginName" CssClass="text_input" runat="server" MaxLength="50"
                    Width="50%"></asp:TextBox>
            </td>
            <td bgcolor="#cadee8">
                <%=Resources.Resource.Admin_name%>:
            </td>
            <td bgcolor="#e9f2f7">
                <asp:TextBox ID="txtName" CssClass="text_input" runat="server" Width="50%" MaxLength="50"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td bgcolor="#cadee8">
                <%=Resources.Resource.Admin_department%>:
            </td>
            <td bgcolor="#e9f2f7">
                <asp:DropDownList ID="ddlDepartment" runat="server" Width="200px">
                    <asp:ListItem Selected="True" Value="" Text="<%$ Resources:Resource,alldepartment %>"></asp:ListItem>
                </asp:DropDownList>
            </td>
            <td bgcolor="#cadee8">
                <%=Resources.Resource.On_Off%>:
            </td>
            <td bgcolor="#e9f2f7">
                <asp:RadioButtonList ID="rblState" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem Selected="True" Value="0" Text="<%$ Resources:Resource,On %>"></asp:ListItem>
                    <asp:ListItem Value="1" Text="<%$ Resources:Resource,Off %>"></asp:ListItem>
                    <asp:ListItem Value="2" Text="<%$ Resources:Resource,forbidden %>"></asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td bgcolor="#cadee8">
                <%=Resources.Resource.owned_roles%>:
            </td>
            <td bgcolor="#e9f2f7">
                <asp:DropDownList ID="ddlRoleName" runat="server" Width="200px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td colspan="4" align="right">
                <asp:Button ID="btnSearch" runat="server" CssClass="button_bak" Text="<%$ Resources:Resource,search %>"
                    Height="28px" Width="80px" OnClick="btnSearch_Click" OnClientClick="top.ShowDiv_load()" />
                <asp:Button ID="btnReset" runat="server" CssClass="button_bak" Text="<%$ Resources:Resource,reset %>"
                    Height="28px" Width="80px" OnClick="btnReset_Click" />
            </td>
        </tr>
    </table>
    <hr style="filter: alpha(opacity=100, finishopacity=0, style=3)" width="100%" color="#7898a8"
        size="3">
    <table width="100%" border="0" cellspacing="0" cellpadding="3" align="center">
        <tr>
            <td>
                <asp:CheckBox ID="chbSelectAll" Text="<%$ Resources:Resource,all %>" runat="server"
                    AutoPostBack="True" OnCheckedChanged="chbSelectAll_CheckedChanged" />
                <asp:CheckBox ID="chbUnSelectAll" Text="<%$ Resources:Resource,inverse %>" runat="server"
                    AutoPostBack="True" OnCheckedChanged="chbUnSelectAll_CheckedChanged" />
            </td>
            <td align="right">
                <asp:Button ID="btnAdd" runat="server" CssClass="button_bak" Text="<%$ Resources:Resource,add %>"
                    OnClick="btnAdd_Click" Height="28px" Width="80px" />
                <asp:Button ID="btnEdit" runat="server" CssClass="button_bak" Text="<%$ Resources:Resource,update %>"
                    OnClick="btnEdit_Click" Height="28px" Width="80px" />
                <asp:Button ID="btnAuthorityCopy" runat="server" CssClass="button_bak" Text="<%$ Resources:Resource,authority_copytransfer %>"
                    Height="28px"  OnClick="btnAuthorityCopy_Click" />
                <asp:Button ID="btnDel" runat="server" CssClass="button_bak" Text="<%$ Resources:Resource,delete %>"
                    OnClick="btnDel_Click" Height="28px" Width="80px" />
            </td>
        </tr>
    </table>
    <asp:GridView ID="gvUsers" runat="server" AllowSorting="True" AllowPaging="True"
        PageSize="10" AutoGenerateColumns="False" DataKeyNames="Ur_id,Ur_name" OnRowDataBound="gvUsers_RowDataBound"
        CellSpacing="1" CssClass="table-box" GridLines="None" BackColor="#E9F2F7" EmptyDataText="<%$ Resources:Resource,No_data %>"
        OnSorting="gvUsers_Sorting" OnPageIndexChanging="gvUsers_PageIndexChanging">
        <AlternatingRowStyle CssClass="row1" BackColor="#cadee8" />
        <Columns>
            <asp:TemplateField HeaderText="<%$ Resources:Resource,select %>">
                <ItemTemplate>
                    <asp:CheckBox ID="chbSelect" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="Ur_no" HeaderText="<%$ Resources:Resource,organizeno %>"
                SortExpression="Ur_no" />
            <asp:BoundField DataField="Ur_Name" HeaderText="<%$ Resources:Resource,organizename %>"
                SortExpression="Ur_Name" />
            <asp:BoundField DataField="Ur_UserName" HeaderText="<%$ Resources:Resource,username %>"
                SortExpression="Ur_UserName" />
            <asp:BoundField DataField="Ur_zone" HeaderText="<%$ Resources:Resource,organizezone %>"
                SortExpression="Ur_zone" />
            <%--<asp:TemplateField HeaderText="<%$ Resources:Resource,accountlevel %>">
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# GetUserLeaveNameById(Eval("Ur_text1")) %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>--%>
            <%--<asp:TemplateField HeaderText="<%$ Resources:Resource,owned_roles %>" >
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# GetRoleList(Eval("Ur_id")) %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>--%>
            <asp:BoundField DataField="Ur_people" HeaderText="<%$ Resources:Resource,organizepeople %>"
                SortExpression="Ur_people" />
            <asp:BoundField DataField="Ur_Contact" HeaderText="<%$ Resources:Resource,organizecontact %>"
                SortExpression="Ur_Contact" />
            <asp:BoundField DataField="Ur_percent" HeaderText="<%$ Resources:Resource,organizepercent %>"
                SortExpression="Ur_percent" />
            <asp:BoundField DataField="Ur_bankName" HeaderText="<%$ Resources:Resource,organizebackname %>"
                SortExpression="Ur_bankName" />
            <asp:BoundField DataField="Ur_bank" HeaderText="<%$ Resources:Resource,organizeback %>"
                SortExpression="Ur_bank" />
            <asp:BoundField DataField="Ur_bankNo" HeaderText="<%$ Resources:Resource,organizebackno %>"
                SortExpression="Ur_bankNo" />
            <asp:BoundField DataField="Ur_introducer" HeaderText="<%$ Resources:Resource,organizeintroducer %>"
                SortExpression="Ur_introducer" />
            <asp:BoundField DataField="Ur_state" HeaderText="<%$ Resources:Resource,On_Off %>"
                SortExpression="Ur_state" />
            <asp:BoundField DataField="Ur_addTime" HeaderText="<%$ Resources:Resource,added_time %>"
                SortExpression="Ur_addTime" />
        </Columns>
        <HeaderStyle BackColor="#7898A8" CssClass="table_title" ForeColor="White" Height="35px"
            Font-Size="Medium" />
        <RowStyle Height="28px" HorizontalAlign="Center" />
    </asp:GridView>
    </form>
</body>
</html>
