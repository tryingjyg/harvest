<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SqlSelect.aspx.cs" Inherits="LZManager.SQL.SqlSelect" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link rel="stylesheet" href="../css/Site_Css.css" type="text/css" />
    <link rel="stylesheet" href="../css/table/default/Css.css" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
        <asp:TextBox ID="txtSql" runat="server" Width="593px" Height="183px" TextMode="MultiLine"></asp:TextBox>
    </div>
    <table width="55%" border="0" cellspacing="0" cellpadding="3" align="center">
        <tr>
            <td>
                <%=Resources.Resource.link%>:<asp:TextBox ID="txtConn" runat="server" Text="" Height="16px"
                    TextMode="MultiLine" Width="258px"></asp:TextBox>
            </td>
            <td align="right">
                <asp:Button ID="btnSearch" runat="server" CssClass="button_bak" Text="<%$ Resources:Resource,execute %>"
                    OnClick="btnDel_Click" Height="28px" Width="137px" />
                <asp:Button ID="btnOut" runat="server" CssClass="button_bak" Text="<%$ Resources:Resource,Export %>"
                    Height="28px" Width="137px" OnClick="btnOut_Click" />
            </td>
        </tr>
    </table>
    <hr style="filter: alpha(opacity=100, finishopacity=0, style=3)" width="55%" color="#7898a8"
        size="3">
    <div align="center">
        <asp:GridView ID="gvTable" runat="server" Width="80%" BackColor="White" BorderColor="#999999"
            BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical">
            <AlternatingRowStyle BackColor="#DCDCDC" />
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#0000A9" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#000065" />
        </asp:GridView>
    </div>
    </form>
</body>
</html>
