<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PlatformMaintain.aspx.cs" Inherits="LZManager.PlatformMaintain.PlatformMaintain"
    ValidateRequest="false" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="../css/Site_Css.css" type="text/css" />
    <link rel="stylesheet" href="../css/table/default/Css.css" type="text/css" />
    <script src="../JavaScript/My97DatePicker/WdatePicker.js" type="text/javascript"></script>
    <script src="../JavaScript/kindeditor-4.1.2/kindeditor.js" type="text/javascript"></script>
    <script src="../JavaScript/kindeditor-4.1.2/lang/zh_TW.js" type="text/javascript"></script>
    <script type="text/javascript">
        var editor;
        KindEditor.ready(function (K) {
            editor = K.create('#txtPfnewFunction');
        });
    </script>
    <style type="text/css">
        .Enable
        {
            color: Blue;
        }
        .IsEnable
        {
            color: Silver;
        }
        a
        {
            text-decoration: none;
        }
        a:hover
        {
            text-decoration: underline;
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
                平台名称:
            </td>
            <td class="table_none">
                <asp:DropDownList ID="ddlPf" runat="server" />
                <asp:TextBox ID="txtPfname" runat="server" Width="25%" MaxLength="50"></asp:TextBox>
                <asp:Button ID="btnSearch" runat="server" CssClass="button_bak" Text="搜索" Height="28px"
                    Width="80px" OnClick="btnSearch_Click" OnClientClick="top.ShowDiv_load()"/>
                <asp:Button ID="btnReset" runat="server" CssClass="button_bak" Text="重置" Height="28px"
                    Width="80px" OnClick="btnReset_Click" />
            </td>
        </tr>
        <tr>
            <td class="table_body">
                平台维护状态:
            </td>
            <td class="table_none">
                <asp:RadioButtonList ID="rblStatus" runat="server" RepeatDirection="Horizontal" AutoPostBack="True"
                    OnSelectedIndexChanged="rblStatus_SelectedIndexChanged">
                    <asp:ListItem Selected="True" Value="0">开启维护</asp:ListItem>
                    <asp:ListItem Value="1">关闭维护并显示新功能说明</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr id="trNotice" runat="server" visible="false">
            <td class="table_body">
                新功能说明:
            </td>
            <td class="table_none">
                <asp:TextBox ID="txtPfnewFunction" CssClass="text_input" runat="server" Width="100%"
                    Height="250px"></asp:TextBox>
            </td>
        </tr>
        <tr id="trEndTime" runat="server" visible="false">
            <td class="table_body">
                新功能显示的结束时间:
            </td>
            <td class="table_none">
                <asp:TextBox ID="txtEndTime" runat="server" onfocus="WdatePicker({startDate:'%y-%M-01 00:00:00',dateFmt:'yyyy-MM-dd HH:mm:ss',alwaysUseStartDate:true})"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="table_body">
            </td>
            <td class="table_body">
                <asp:Button ID="btnOK" runat="server" CssClass="button_bak" Text="确定" Height="28px"
                    Width="80px" OnClick="btnOK_Click" OnClientClick="top.ShowDiv_load()" />
            </td>
        </tr>
    </table>
    <hr style="filter: alpha(opacity=100, finishopacity=0, style=3)" width="100%" color="#7898a8"
        size="3">
    <asp:GridView ID="gvPlatform" runat="server" AllowSorting="True" 
        AllowPaging="True" PageSize="15"
        AutoGenerateColumns="False" CellSpacing="1" CssClass="table-box" GridLines="None"
        BackColor="#E9F2F7" EmptyDataText="暂无数据" 
        OnRowDataBound="gvPlatform_RowDataBound" 
        onrowcommand="gvPlatform_RowCommand" 
        onpageindexchanging="gvPlatform_PageIndexChanging">
        <AlternatingRowStyle CssClass="row1" BackColor="#cadee8" />
        <Columns>
            <asp:BoundField DataField="Pf_name" HeaderText="平台名称">
                <ItemStyle Width="10%" Wrap="true"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField DataField="Pf_isRepair" HeaderText="是否开启维护">
                <ItemStyle Width="10%" Wrap="true"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField DataField="Pf_isNewShow" HeaderText="是否显示新功能说明">
                <ItemStyle Width="10%" Wrap="true"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField DataField="Pf_newFunction" HeaderText="新功能说明" HtmlEncode="False">
            <ItemStyle Width="12%" Wrap="true"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField DataField="Pf_newEndTime" HeaderText="新功能显示的结束时间">
                <ItemStyle Width="12%" Wrap="true"></ItemStyle>
            </asp:BoundField>
            <asp:TemplateField HeaderText="操作">
                <ItemStyle Width="20%" Wrap="true"></ItemStyle>
                <ItemTemplate>
                    <asp:LinkButton ID="lnkClostWh" runat="server" CommandName='<%#Eval("Pf_id") %>'
                        CommandArgument="CloseWh" OnClientClick="return confirm('您确定要关闭维护么?')">关闭维护</asp:LinkButton>
                    <span style="padding: 10px;"></span>
                    <asp:LinkButton ID="lnkCloseGg" runat="server" CommandName='<%#Eval("Pf_id") %>'
                        CommandArgument="CloseGg"  OnClientClick="return confirm('您确定要关闭公告么?')">关闭公告</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <HeaderStyle BackColor="#7898A8" CssClass="table_title" ForeColor="White" Height="35px"
            Font-Size="Medium" />
        <RowStyle Height="28px" HorizontalAlign="Center" />
    </asp:GridView>
    </form>
</body>
</html>
