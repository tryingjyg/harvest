<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QueryFunction.aspx.cs" Inherits="LZManager.WptMall.QueryFunction" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="../css/Site_Css.css" type="text/css" />
    <link rel="stylesheet" href="../css/table/default/Css.css" type="text/css" />

    <script src="../JavaScript/Dialog/jquery-1.7.2.min.js" type="text/javascript"></script>
    <script src="../JavaScript/My97DatePicker/WdatePicker.js" type="text/javascript"></script>
    <script type="text/javascript">

        $(function () {
            //alert("进来了这个页面");
            <%--$("#<%=btnDel.ClientID%>").click(function () {


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
                <td bgcolor="#cadee8" width="15%">请求线上房间数量
                </td>
            </tr>
            <tr>
                <td bgcolor="#cadee8">请求线上房间数量:
                </td>
                <td bgcolor="#e9f2f7">
                    <asp:TextBox ID="txtRoomNum" CssClass="text_input" runat="server" MaxLength="50"
                        Width="20%" ReadOnly="true"></asp:TextBox>
                </td>
                <td bgcolor="#cadee8">数量:
                </td>
                <td bgcolor="#e9f2f7">
                    <asp:Label ID="lblTotalNum" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="4" align="right">
                    <asp:Button ID="btnRequestRoomNum" runat="server" CssClass="button_bak" Text="查询"
                        Height="28px" Width="80px" OnClick="btnRequestRoomNum_Click" OnClientClick="top.ShowDiv_load()" />
                </td>
            </tr>

            <tr>
                <td bgcolor="#cadee8">查询在线人数:
                </td>
            </tr>
            <tr>
                <td bgcolor="#cadee8">
                    <%=Resources.Resource.playerId%>:
                </td>
                <td bgcolor="#e9f2f7">
                    <asp:TextBox ID="txtOnline" CssClass="text_input" runat="server" MaxLength="50"
                        Width="20%" ReadOnly="true"></asp:TextBox>
                </td>
                <td bgcolor="#cadee8">在线人数:
                </td>
                <td bgcolor="#e9f2f7">
                    <asp:Label ID="lblOnLineNum" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="4" align="right">
                    <asp:Button ID="btnOnLine" runat="server" CssClass="button_bak" Text="查询>"
                        Height="28px" Width="80px" OnClick="btnOnLine_Click" OnClientClick="top.ShowDiv_load()" />
                </td>
            </tr>

            <tr>
                <td bgcolor="#cadee8">
                    <%=Resources.Resource.delroom%>:
                </td>
            </tr>
            <tr>
                <td bgcolor="#cadee8">房间号：
                </td>
                <td bgcolor="#e9f2f7">
                    <asp:TextBox ID="txtRoom" CssClass="text_input" runat="server" MaxLength="50"
                        Width="20%"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="4" align="right">
                    <asp:Button ID="btnDel" runat="server" CssClass="button_bak" Text="<%$ Resources:Resource,delroom %>"
                        Height="28px" Width="80px" OnClick="btnDel_Click" OnClientClick="top.ShowDiv_load()" />
                </td>
            </tr>

            <tr>
                <td bgcolor="#cadee8">查询玩家详细信息:
                </td>
            </tr>
            <tr>
                <td bgcolor="#cadee8">玩家Id：
                </td>
                <td bgcolor="#e9f2f7">
                    <asp:TextBox ID="txtPlayerInfoId" CssClass="text_input" runat="server" MaxLength="50"
                        Width="20%"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="4" align="right">
                    <asp:Button ID="btnQueryPlayerInfo" runat="server" CssClass="button_bak" Text="查询"
                        Height="28px" Width="80px" OnClick="btnQueryPlayerInfo_Click" OnClientClick="top.ShowDiv_load()" />
                </td>
            </tr>

            <tr>
                <td bgcolor="#cadee8">封号:
                </td>
            </tr>
            <tr>
                <td bgcolor="#cadee8">玩家Id：
                </td>
                <td bgcolor="#e9f2f7">
                    <asp:TextBox ID="txfFrobidenPlayerId" CssClass="text_input" runat="server" MaxLength="50"
                        Width="20%"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="4" align="right">
                    <asp:Button ID="btnForbiden" runat="server" CssClass="button_bak" Text="封号"
                        Height="28px" Width="80px" OnClick="btnForbiden_Click" OnClientClick="top.ShowDiv_load()" />
                </td>
            </tr>

            <tr>
                <td bgcolor="#cadee8">解封玩家:
                </td>
            </tr>
            <tr>
                <td bgcolor="#cadee8">玩家Id：
                </td>
                <td bgcolor="#e9f2f7">
                    <asp:TextBox ID="txtdeArchive" CssClass="text_input" runat="server" MaxLength="50"
                        Width="20%"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="4" align="right">
                    <asp:Button ID="btnDeArchive" runat="server" CssClass="button_bak" Text="解封"
                        Height="28px" Width="80px" OnClick="btnDeArchive_Click" OnClientClick="top.ShowDiv_load()" />
                </td>
            </tr>

        </table>

        <hr style="filter: alpha(opacity=100, finishopacity=0, style=3)" width="100%" color="#7898a8"
            size="3">
    </form>
</body>
</html>
