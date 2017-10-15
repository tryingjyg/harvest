<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogList.aspx.cs" Inherits="LZManager.Log.LogList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<meta http-equiv="Content-Type" content="text/html; charset=GB2312" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="../css/Site_Css.css" type="text/css" />
    <link rel="stylesheet" href="../css/table/default/Css.css" type="text/css" />
    <script src="../JavaScript/My97DatePicker/WdatePicker.js" type="text/javascript"></script>
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
                <td bgcolor="#cadee8" width="10%">查询日常日志
                </td>
                <td bgcolor="#e9f2f7">
                    <asp:Button ID="btnDay" runat="server" CssClass="button_bak" Text="查询" Height="28px"
                        Width="80px" OnClick="btnDay_Click" OnClientClick="top.ShowDiv_load()" />
                </td>
            </tr>
            <tr>
                <td bgcolor="#cadee8" width="10%">查询回放日志：
                </td>
                <td bgcolor="#cadee8" width="10%">
                    <%=Resources.Resource.playerId%>:
                </td>
                <td bgcolor="#e9f2f7">
                    <asp:TextBox ID="txtPlayerId" CssClass="text_input" runat="server" MaxLength="50"
                        Width="50%"></asp:TextBox>
                </td>
                <td bgcolor="#e9f2f7">
                    <asp:Button ID="btnReplay" runat="server" CssClass="button_bak" Text="查询" Height="28px"
                        Width="80px" OnClick="btnReplay_Click" OnClientClick="top.ShowDiv_load()" />
                </td>
            </tr>
            <tr>
                <td bgcolor="#cadee8" width="10%">查询输赢信息：
                </td>
                <td bgcolor="#cadee8" width="10%">
                    日期:
                </td>
                <td bgcolor="#e9f2f7">
                    <asp:TextBox ID="txtDate" CssClass="text_input" runat="server" MaxLength="50"
                        Width="50%"></asp:TextBox>
                </td>
                <td bgcolor="#cadee8" width="10%">
                    房间号:
                </td>
                <td bgcolor="#e9f2f7">
                    <asp:TextBox ID="txtRoomNo" CssClass="text_input" runat="server" MaxLength="50"
                        Width="50%"></asp:TextBox>
                </td>
                <td bgcolor="#e9f2f7">
                    <asp:Button ID="btnWinInfo" runat="server" CssClass="button_bak" Text="查询" Height="28px"
                        Width="80px" OnClick="btnWinInfo_Click" OnClientClick="top.ShowDiv_load()" />
                </td>
            </tr>
            <tr>
                <td bgcolor="#cadee8" width="10%">开始时间:
                </td>
                <td bgcolor="#e9f2f7" width="40%">
                    <asp:TextBox ID="txtStartTime" runat="server" ReadOnly="True" onfocus="WdatePicker({startDate:'%y-%M-01 00:00:00',dateFmt:'yyyy-MM-dd HH:mm:ss',alwaysUseStartDate:true})" Width="220px"></asp:TextBox>
                </td>
                <td bgcolor="#cadee8">结束时间:
                </td>
                <td bgcolor="#e9f2f7">
                    <asp:TextBox ID="txtEndTime" runat="server" ReadOnly="True" onfocus="WdatePicker({startDate:'%y-%M-01 00:00:00',dateFmt:'yyyy-MM-dd HH:mm:ss',alwaysUseStartDate:true})" Width="220px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td bgcolor="#cadee8">姓名：</td>
                <td bgcolor="#e9f2f7">
                    <asp:TextBox ID="txtUrName" CssClass="text_input" runat="server" Width="50%"
                        MaxLength="50"></asp:TextBox>
                </td>
                <td bgcolor="#cadee8">查找：</td>
                <td bgcolor="#e9f2f7">
                    <asp:Button ID="btnSearch" runat="server" CssClass="button_bak" Text="搜索" Height="28px"
                        Width="80px" OnClick="btnSearch_Click" OnClientClick="top.ShowDiv_load()" />
                    <asp:Button ID="btnExport" runat="server" CssClass="button_bak" Text="导出Excel" Height="28px"
                        Width="80px" OnClick="btnExport_Click" OnClientClick="top.ShowDiv_load()" />
                    <asp:Button ID="btnReset" runat="server" CssClass="button_bak" Text="重置" Height="28px"
                        Width="80px" OnClick="btnReset_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="4" align="right">&nbsp;</td>
            </tr>
        </table>
        <hr style="filter: alpha(opacity=100, finishopacity=0, style=3)" width="100%" color="#7898a8"
            size="3">
        <asp:GridView ID="gvLogs" runat="server" AllowSorting="True" AllowPaging="True" PageSize="15"
            AutoGenerateColumns="False" CellSpacing="1" CssClass="table-box" GridLines="None"
            BackColor="#E9F2F7" EmptyDataText="暂无数据" OnSorting="gvLogs_Sorting" OnPageIndexChanging="gvLogs_PageIndexChanging" OnRowDataBound="gvLogs_RowDataBound">
            <AlternatingRowStyle CssClass="row1" BackColor="#cadee8" />
            <Columns>
                <asp:BoundField DataField="Ur_name" HeaderText="姓名" SortExpression="Ur_name" ItemStyle-Width="6%" />
                <asp:BoundField DataField="Ur_department" HeaderText="部门" SortExpression="Ur_department" ItemStyle-Width="8%" />
                <asp:BoundField DataField="Lg_userip" HeaderText="ip地址" SortExpression="Lg_userip" ItemStyle-Width="10%" />
                <asp:BoundField DataField="Lg_name" HeaderText="操作内容" SortExpression="Lg_name" ItemStyle-Width="20%" />
                <asp:BoundField DataField="Lg_content" HeaderText="内容" SortExpression="Lg_content" ItemStyle-Width="40%" ItemStyle-HorizontalAlign="Left" />
                <asp:BoundField DataField="Lg_addtime" HeaderText="操作日期" SortExpression="Lg_addtime" ItemStyle-Width="13%" />
            </Columns>
            <HeaderStyle BackColor="#7898A8" CssClass="table_title" ForeColor="White" Height="35px"
                Font-Size="Medium" />
            <RowStyle Height="28px" HorizontalAlign="Center" />
        </asp:GridView>
    </form>
</body>
</html>
