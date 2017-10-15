<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserInfo.aspx.cs" Inherits="LZManager.Users.UserInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>用户个人信息</title>
    <link rel="stylesheet" href="../css/Site_Css.css" type="text/css" />
    <link rel="stylesheet" href="../css/table/default/Css.css" type="text/css" />
    <script src="../JavaScript/Dialog/jquery-1.7.2.min.js" type="text/javascript"></script>
    <script type="text/javascript">


        <%--$(function () {

            $("#<%=btnReturn.ClientID%>").click(function () {
                window.location.href = "UsersList.aspx";
            });

        });--%>


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
            <tbody>
                <tr>
                    <td class="table_body">
                        <%=Resources.Resource.user_account%>:
                    </td>
                    <td class="table_none">
                        <asp:Label ID="txtLoginName" CssClass="text_input" runat="server" Width="50%" MaxLength="50"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="table_body">
                        <%=Resources.Resource.username%>:
                    </td>
                    <td class="table_none">
                        <asp:Label ID="txtName" CssClass="text_input" runat="server" Width="50%" MaxLength="50"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="table_body">上级机构:
                    </td>
                    <td class="table_none">
                        <asp:Label ID="txtParent" CssClass="text_input" runat="server" Width="50%" MaxLength="50"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="table_body">电话:
                    </td>
                    <td class="table_none">
                        <asp:Label ID="txtPhone" CssClass="text_input" runat="server" Width="50%" MaxLength="50"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="table_body">地区:
                    </td>
                    <td class="table_none">
                        <asp:Label ID="txtArea" CssClass="text_input" runat="server" Width="50%" MaxLength="50"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="table_body">联系人:
                    </td>
                    <td class="table_none">
                        <asp:Label ID="txtContactPeople" CssClass="text_input" runat="server" Width="50%" MaxLength="50"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="table_body">联系方式:
                    </td>
                    <td class="table_none">
                        <asp:Label ID="txtContact" CssClass="text_input" runat="server" Width="50%" MaxLength="50"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="table_body">游戏Id:
                    </td>
                    <td class="table_none">
                        <asp:Label ID="txtGameId" CssClass="text_input" runat="server" Width="50%" MaxLength="50"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="table_body">钻石数量:
                    </td>
                    <td class="table_none">
                        <asp:Label ID="lblDiamond" CssClass="text_input" runat="server" Width="50%" MaxLength="50"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="table_body">可提现金额:
                    </td>
                    <td class="table_none">
                        <asp:Label ID="lblMoney" CssClass="text_input" runat="server" Width="50%" MaxLength="50"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="table_body">开户名:
                    </td>
                    <td class="table_none">
                        <asp:Label ID="txtBankName" CssClass="text_input" runat="server" Width="50%" MaxLength="50"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="table_body">开户行:
                    </td>
                    <td class="table_none">
                        <asp:Label ID="txtBank" CssClass="text_input" runat="server" Width="50%" MaxLength="50"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="table_body">银行账号:
                    </td>
                    <td class="table_none">
                        <asp:Label ID="txtBankNo" CssClass="text_input" runat="server" Width="50%" MaxLength="50"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="table_body">分成比例:
                    </td>
                    <td class="table_none">
                        <asp:Label ID="txtPercent" CssClass="text_input" runat="server" Width="50%" MaxLength="50"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="table_body">介绍人:
                    </td>
                    <td class="table_none">
                        <asp:Label ID="txtIntrdouce" CssClass="text_input" runat="server" Width="50%" MaxLength="50"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="table_body"></td>
                    <td class="table_body">
                        <asp:Button ID="btnOK" runat="server" CssClass="button_bak" Text="<%$ Resources:Resource,Determine%>" OnClick="btnOK_Click"
                            Height="28px" Width="80px" OnClientClick="top.ShowDiv_load()" />
                        <asp:Button ID="btnChangePwd" runat="server" CssClass="button_bak" Text="修改密码" OnClick="btnChangePwd_Click"
                            Height="28px" Width="80px" />
                        <asp:HiddenField ID="hfLoginName" runat="server" />
                    </td>
                </tr>
            </tbody>
        </table>
    </form>
</body>
</html>
