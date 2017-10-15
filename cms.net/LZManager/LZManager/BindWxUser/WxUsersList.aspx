<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WxUsersList.aspx.cs" Inherits="LZManager.BindWxUser.WxUsersList" %>

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
            $("#<%=btnAuthorityCopy.ClientID%>").click(function () {


                var lenthCheck = $("input[type='checkbox']:checked").length;
                if (lenthCheck < 1) {

                    alert("Please select the record to delete!");

                    return false;


                }

                if (confirm("Are you sure you want to btnAuthorityCopy the platform？")) {

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
                        OnClick="btnEdit_Click" Height="28px" Width="80px" />--%>
                    <asp:Button ID="btnAuthorityCopy" runat="server" CssClass="button_bak" Text="代理转移"
                        Height="28px" OnClick="btnAuthorityCopy_Click" />
                    <%--<asp:Button ID="btnDel" runat="server" CssClass="button_bak" Text="<%$ Resources:Resource,delete %>"
                        OnClick="btnDel_Click" Height="28px" Width="80px" />
                    <asp:Button ID="btnQrCode" runat="server" CssClass="button_bak" Text="生成二维码"
                        OnClick="btnQrCode_Click" Height="28px" Width="80px" />--%>
                </td>
            </tr>
        </table>
        <asp:GridView ID="gvUsers" runat="server" AllowSorting="True" AllowPaging="True"
            PageSize="10" AutoGenerateColumns="False" DataKeyNames="Wx_id,Wx_nickname,Wx_state,Wx_openid" OnRowDataBound="gvUsers_RowDataBound"
            CellSpacing="1" CssClass="table-box" GridLines="None" BackColor="#E9F2F7" EmptyDataText="<%$ Resources:Resource,No_data %>"
            OnSorting="gvUsers_Sorting" OnPageIndexChanging="gvUsers_PageIndexChanging">
            <AlternatingRowStyle CssClass="row1" BackColor="#cadee8" />
            <Columns>
                <asp:TemplateField HeaderText="<%$ Resources:Resource,select %>">
                    <ItemTemplate>
                        <asp:CheckBox ID="chbSelect" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Wx_id" HeaderText="用户UINIId"
                    SortExpression="Wx_id" />
                <asp:BoundField DataField="Wx_openid" HeaderText="用户OPENID"
                    SortExpression="Wx_openid" />
                <asp:BoundField DataField="Wx_nickname" HeaderText="昵称"
                    SortExpression="Wx_nickname" />
                <asp:BoundField DataField="Wx_headurl" HeaderText="头像地址"
                    SortExpression="Wx_headurl">
                    <ItemStyle Width="100px" />
                </asp:BoundField>
                <asp:BoundField DataField="Wx_sex" HeaderText="性别"
                    SortExpression="Wx_sex" />
                <asp:BoundField DataField="Wx_duid" HeaderText="代理ID"
                    SortExpression="Wx_duid" />
                <asp:BoundField DataField="Wx_bindtime" HeaderText="绑定时间"
                    SortExpression="Wx_bindtime" />
            </Columns>
            <HeaderStyle BackColor="#7898A8" CssClass="table_title" ForeColor="White" Height="35px"
                Font-Size="Medium" />
            <RowStyle Height="28px" HorizontalAlign="Center" />
        </asp:GridView>
    </form>
</body>
</html>
