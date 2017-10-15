<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MallTChargeDiamondList.aspx.cs" Inherits="LZManager.MallCharge.MallTChargeDiamondList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="../css/Site_Css.css" type="text/css" />
    <link rel="stylesheet" href="../css/table/default/Css.css" type="text/css" />

    <script src="../JavaScript/Dialog/jquery-1.7.2.min.js" type="text/javascript"></script>
    <script type="text/javascript">

        $(function () {
            //alert("进来了这个页面");
            <%--            $("#<%=btnDel.ClientID%>").click(function () {


                var lenthCheck = $("input[type='checkbox']:checked").length;
                if (lenthCheck < 1) {

                    alert("Please select the record to delete!");

                    return false;


                }

                if (confirm("Are you sure you want to delete the platform？")) {

                } else {

                    return false;

                }

            });--%>

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
                <td bgcolor="#cadee8">代理ID:
                </td>
                <td bgcolor="#e9f2f7">
                    <asp:TextBox ID="txtdId" CssClass="text_input" runat="server" MaxLength="50"
                        Width="50%"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td bgcolor="#cadee8">开始时间:
                </td>
                <td bgcolor="#e9f2f7">
                    <asp:TextBox ID="txtBeginTime" CssClass="text_input" runat="server" MaxLength="50"
                        Width="50%"></asp:TextBox>
                </td>
                <td bgcolor="#cadee8">结束时间:
                </td>
                <td bgcolor="#e9f2f7">
                    <asp:TextBox ID="txtEndTime" CssClass="text_input" runat="server" Width="50%" MaxLength="50"></asp:TextBox>
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
                    <%--<asp:Button ID="btnAdd" runat="server" CssClass="button_bak" Text="<%$ Resources:Resource,add %>"
                        OnClick="btnAdd_Click" Height="28px" Width="80px" />
                    <asp:Button ID="btnEdit" runat="server" CssClass="button_bak" Text="<%$ Resources:Resource,update %>"
                        OnClick="btnEdit_Click" Height="28px" Width="80px" />
                    <asp:Button ID="btnAuthorityCopy" runat="server" CssClass="button_bak" Text="<%$ Resources:Resource,authority_copytransfer %>"
                        Height="28px" OnClick="btnAuthorityCopy_Click" />
                    <asp:Button ID="btnDel" runat="server" CssClass="button_bak" Text="<%$ Resources:Resource,delete %>"
                        OnClick="btnDel_Click" Height="28px" Width="80px" />--%>
                </td>
            </tr>
        </table>
        <asp:GridView ID="gvUsers" runat="server" AllowSorting="True" AllowPaging="True"
            PageSize="10" AutoGenerateColumns="False" DataKeyNames="remarkid" OnRowDataBound="gvUsers_RowDataBound"
            CellSpacing="1" CssClass="table-box" GridLines="None" BackColor="#E9F2F7" EmptyDataText="<%$ Resources:Resource,No_data %>"
            OnSorting="gvUsers_Sorting" OnPageIndexChanging="gvUsers_PageIndexChanging">
            <AlternatingRowStyle CssClass="row1" BackColor="#cadee8" />
            <Columns>
                <asp:TemplateField HeaderText="<%$ Resources:Resource,select %>">
                    <ItemTemplate>
                        <asp:CheckBox ID="chbSelect" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="remarkid" HeaderText="订单号"
                    SortExpression="remarkid" />
                <asp:BoundField DataField="dstuin" HeaderText="充值账号"
                    SortExpression="dstuin" />
                <asp:BoundField DataField="roleid" HeaderText="角色ID"
                    SortExpression="roleid" />
                <asp:BoundField DataField="rolename" HeaderText="角色名"
                    SortExpression="rolename" />
                <asp:BoundField DataField="srcuin" HeaderText="充值人"
                    SortExpression="srcuin" />
                <asp:BoundField DataField="srcuin" HeaderText="返现ID"
                    SortExpression="srcuin" />
                <asp:BoundField DataField="source" HeaderText="充值来源"
                    SortExpression="duid" />
                <asp:BoundField DataField="amount" HeaderText="数量"
                    SortExpression="amount" />
                <asp:BoundField DataField="uiip" HeaderText="充值IP"
                    SortExpression="uiip" />
                <asp:BoundField DataField="description" HeaderText="充值说明"
                    SortExpression="description" />
                <asp:BoundField DataField="paystatus" HeaderText="是否成功"
                    SortExpression="paystatus" />
                <asp:BoundField DataField="createTime" HeaderText="充值时间"
                    SortExpression="createTime" />
                <%--<asp:BoundField DataField="Mg_presentnum" HeaderText="<%$ Resources:Resource,goodspresentnum %>"
                    SortExpression="Mg_presentnum" />
                <asp:BoundField DataField="Mg_adddTime" HeaderText="<%$ Resources:Resource,added_time %>"
                    SortExpression="Mg_adddTime" />--%>

                <%--<asp:TemplateField HeaderText="<%$ Resources:Resource,owned_roles %>" >
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# GetRoleList(Eval("Ur_id")) %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>--%>
            </Columns>
            <HeaderStyle BackColor="#7898A8" CssClass="table_title" ForeColor="White" Height="35px"
                Font-Size="Medium" />
            <RowStyle Height="28px" HorizontalAlign="Center" />
        </asp:GridView>
    </form>
</body>
</html>
