<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UsersList.aspx.cs" Inherits="LZManager.Users.UsersList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="../css/Site_Css.css" type="text/css" />
    <link rel="stylesheet" href="../css/table/default/Css.css" type="text/css" />
    <link href="../Css/pop.css" rel="stylesheet" />
    <script src="../JavaScript/Dialog/jquery-1.7.2.min.js" type="text/javascript"></script>
    <script type="text/javascript">

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

      <%--  $(function () {
            //alert("进来了这个页面");
            $("#<%=btnAdd.ClientID%>").click(function () {
                shade.style.display = 'block';
                Layer1.style.display = 'block'
            });

        })--%>


    </script>

</head>
<body>
    <form id="form1" runat="server">
        <div id="shade"></div>
        <div id="Layer1">
            <div id="win_top">pop<a href="#" onclick="shade.style.display='none';Layer1.style.display='none'">关闭</a></div>
            <br />
            <div class="content"><a href="http://yuncode.net" target="_blank">http://yuncode.net</a></div>
        </div>


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
         <%--<asp:Panel ID="Panel_ID" runat="server" CssClass="button_bak" Text="<%$ Resources:Resource,add %>"/>--%>
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
                        Height="28px" OnClick="btnAuthorityCopy_Click" />
                    <asp:Button ID="btnDel" runat="server" CssClass="button_bak" Text="<%$ Resources:Resource,delete %>"
                        OnClick="btnDel_Click" Height="28px" Width="80px" />
                    <asp:Button ID="btnQrCode" runat="server" CssClass="button_bak" Text="生成二维码"
                        OnClick="btnQrCode_Click" Height="28px" Width="80px" />
                </td>
            </tr>
        </table>
        <asp:GridView ID="gvUsers" runat="server" AllowSorting="True" AllowPaging="True"
            PageSize="10" AutoGenerateColumns="False" DataKeyNames="Ur_id,Ur_gameId" OnRowDataBound="gvUsers_RowDataBound"
            CellSpacing="1" CssClass="table-box" GridLines="None" BackColor="#E9F2F7" EmptyDataText="<%$ Resources:Resource,No_data %>"
            OnSorting="gvUsers_Sorting" OnPageIndexChanging="gvUsers_PageIndexChanging">
            <AlternatingRowStyle CssClass="row1" BackColor="#cadee8" />
            <Columns>
                <asp:TemplateField HeaderText="<%$ Resources:Resource,select %>">
                    <ItemTemplate>
                        <asp:CheckBox ID="chbSelect" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Ur_loginName" HeaderText="账号"
                    SortExpression="Ur_loginName" />
                <asp:BoundField DataField="Ur_name" HeaderText="姓名"
                    SortExpression="Ur_name" />
                <asp:BoundField DataField="Ur_parent" HeaderText="上级机构"
                    SortExpression="Ur_parent" />
                <asp:BoundField DataField="Ur_money" HeaderText="可提金额"
                    SortExpression="Ur_money" />
                <asp:BoundField DataField="Ur_zone" HeaderText="地区"
                    SortExpression="Ur_zone" />
                <asp:BoundField DataField="Ur_people" HeaderText="联系人"
                    SortExpression="Ur_people" />
                <asp:BoundField DataField="Ur_Contact" HeaderText="联系方式"
                    SortExpression="Ur_Contact" />
                <asp:BoundField DataField="Ur_gameId" HeaderText="游戏Id"
                    SortExpression="Ur_gameId" />
                <asp:BoundField DataField="Ur_diamondNum" HeaderText="钻石"
                    SortExpression="Ur_diamondNum" />
                <asp:BoundField DataField="Ur_bankName" HeaderText="开户名"
                    SortExpression="Ur_bankName" />
                <asp:BoundField DataField="Ur_bank" HeaderText="开户行"
                    SortExpression="Ur_bank" />
                <asp:BoundField DataField="Ur_bankNo" HeaderText="银行账号"
                    SortExpression="Ur_bankNo" />
                <asp:BoundField DataField="Ur_percent" HeaderText="分成"
                    SortExpression="Ur_percent" />
                <asp:BoundField DataField="Ur_introducer" HeaderText="介绍人"
                    SortExpression="Ur_introducer" />
                <asp:BoundField DataField="Ur_addUser" HeaderText="添加人"
                    SortExpression="Ur_addUser" />
                <asp:BoundField DataField="Ur_rolestate" HeaderText="账号级别"
                    SortExpression="Ur_rolestate" />
                <asp:BoundField DataField="Ur_addTime" HeaderText="添加时间"
                    SortExpression="Ur_addTime" />
            </Columns>
            <HeaderStyle BackColor="#7898A8" CssClass="table_title" ForeColor="White" Height="35px"
                Font-Size="Medium" />
            <RowStyle Height="28px" HorizontalAlign="Center" />
        </asp:GridView>
    </form>
</body>
</html>
