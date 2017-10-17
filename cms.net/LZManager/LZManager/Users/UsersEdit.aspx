﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UsersEdit.aspx.cs" Inherits="LZManager.Users.UsersEdit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>用户信息</title>
    <link rel="stylesheet" href="../css/Site_Css.css" type="text/css" />
    <link rel="stylesheet" href="../css/table/default/Css.css" type="text/css" />
    <script src="../JavaScript/Dialog/jquery-1.7.2.min.js" type="text/javascript"></script>
    <script type="text/javascript">


        $(function () {

            $("#<%=btnReturn.ClientID%>").click(function () {
                window.location.href = "UsersList.aspx";
            });

        });


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
        <asp:CheckBox ID="cbk_password" runat="server" Text="<%$ Resources:Resource,Dopasswordreset%>" OnCheckedChanged="cbk_password_CheckedChanged"
            AutoPostBack="true" Visible="false" />
        <table width="100%" border="0" cellspacing="1" cellpadding="3" align="center">
            <tbody>
                <tr>
                    <td class="table_body">
                        <%=Resources.Resource.user_account%>:
                    </td>
                    <td class="table_none">
                        <asp:TextBox ID="txtLoginName" CssClass="text_input" runat="server" Width="50%" MaxLength="50"></asp:TextBox>
                        <font color="red">*</font>
                    </td>
                </tr>
                <tr id="trPass" runat="server">
                    <td class="table_body">
                        <%=Resources.Resource.user_password%>:
                    </td>
                    <td class="table_none">
                        <asp:TextBox ID="txtPass" CssClass="text_input" runat="server" TextMode="Password"
                            Width="50%" MaxLength="100"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="<%$ Resources:Resource,not_empty %>" ForeColor="Red" ControlToValidate="txtPass"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server"
                            ControlToValidate="txtPass" ErrorMessage="<%$ Resources:Resource,password_check %>"
                            ForeColor="Red"
                            ValidationExpression="^[^,;']{6,16}$"></asp:RegularExpressionValidator>

                    </td>
                </tr>
                <tr>
                    <td class="table_body">
                        <%=Resources.Resource.username%>:
                    </td>
                    <td class="table_none">
                        <asp:TextBox ID="txtName" CssClass="text_input" runat="server" Width="50%" MaxLength="50"></asp:TextBox>
                        <font color="red">*</font>
                    </td>
                </tr>
                <tr>
                    <td class="table_body">上级机构:
                    </td>
                    <td class="table_none">
                        <asp:TextBox ID="txtParent" CssClass="text_input" runat="server" Width="50%" MaxLength="50"></asp:TextBox>
                        <font color="red">*</font>
                    </td>
                </tr>
                <%--<tr>
                    <td class="table_body">电话:
                    </td>
                    <td class="table_none">
                        <asp:TextBox ID="txtPhone" CssClass="text_input" runat="server" Width="50%" MaxLength="50"></asp:TextBox>
                        <font color="red">*</font>
                    </td>
                </tr>--%>
                <tr>
                    <td class="table_body">地区:
                    </td>
                    <td class="table_none">
                        <asp:TextBox ID="txtZone" CssClass="text_input" runat="server" Width="50%" MaxLength="50"></asp:TextBox>
                        <font color="red">*</font>
                    </td>
                </tr>
                <tr>
                    <td class="table_body">联系人:
                    </td>
                    <td class="table_none">
                        <asp:TextBox ID="txtContactPeople" CssClass="text_input" runat="server" Width="50%" MaxLength="50"></asp:TextBox>
                        <font color="red">*</font>
                    </td>
                </tr>
                <tr>
                    <td class="table_body">联系方式:
                    </td>
                    <td class="table_none">
                        <asp:TextBox ID="txtContact" CssClass="text_input" runat="server" Width="50%" MaxLength="50"></asp:TextBox>
                        <font color="red">*</font>
                    </td>
                </tr>
                <tr>
                    <td class="table_body">游戏Id:
                    </td>
                    <td class="table_none">
                        <asp:TextBox ID="txtGameId" CssClass="text_input" runat="server" Width="50%" MaxLength="50"></asp:TextBox>
                        <font color="red">*</font>
                    </td>
                </tr>
                <tr>
                    <td class="table_body">钻石数量:
                    </td>
                    <td class="table_none">
                        <asp:TextBox ID="txtDiamondNum" CssClass="text_input" runat="server" Width="50%" MaxLength="50"></asp:TextBox>
                        <font color="red">*</font>
                    </td>
                </tr>

                <%--<tr>
                    <td class="table_body">开户名:
                    </td>
                    <td class="table_none">
                        <asp:TextBox ID="txtBankName" CssClass="text_input" runat="server" Width="50%" MaxLength="50"></asp:TextBox>
                        <font color="red">*</font>
                    </td>
                </tr>
                <tr>
                    <td class="table_body">开户行:
                    </td>
                    <td class="table_none">
                        <asp:TextBox ID="txtBank" CssClass="text_input" runat="server" Width="50%" MaxLength="50"></asp:TextBox>
                        <font color="red">*</font>
                    </td>
                </tr>
                <tr>
                    <td class="table_body">银行账号:
                    </td>
                    <td class="table_none">
                        <asp:TextBox ID="txtBankNo" CssClass="text_input" runat="server" Width="50%" MaxLength="50"></asp:TextBox>
                        <font color="red">*</font>
                    </td>
                </tr>
                <tr>
                    <td class="table_body">介绍人:
                    </td>
                    <td class="table_none">
                        <asp:TextBox ID="txtIntrdouce" CssClass="text_input" runat="server" Width="50%" MaxLength="50"></asp:TextBox>
                        <font color="red">*</font>
                    </td>
                </tr>--%>
                <tr>
                    <td class="table_body">分成比例:
                    </td>
                    <td class="table_none">
                        <asp:TextBox ID="txtPercent" CssClass="text_input" runat="server" Width="50%" MaxLength="50"></asp:TextBox>
                        <font color="red">*</font>
                    </td>
                </tr>
                <tr>
                    <td class="table_body">账号级别:
                    </td>
                    <td class="table_none">
                        <asp:DropDownList ID="ddlDepartment" runat="server" Width="20%">
                        </asp:DropDownList>
                    </td>
                </tr>
                <%--<tr>
                    <td class="table_body">
                        <%=Resources.Resource.accountlevel%>:
                    </td>
                    <td class="table_none">
                        <asp:DropDownList ID="ddlUserLeave" runat="server" Width="20%">
                            <asp:ListItem Selected="True" Value="" Text="<%$ Resources:Resource,Pleaseselecttheaccountlevel %>"></asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>--%>
                <tr>
                    <td class="table_body">
                        <%=Resources.Resource.role_name%>(<%=Resources.Resource.multiselect%>):
                    </td>
                    <td class="table_none">
                        <asp:CheckBoxList ID="cblRoles" runat="server" RepeatDirection="Horizontal" RepeatColumns="4">
                        </asp:CheckBoxList>
                        <asp:LinkButton ID="lkRoleEdit" runat="server" Font-Bold="True" Font-Size="Small"
                            ForeColor="Red" OnClick="lbRoleEdit_Click" Visible="False"><%=Resources.Resource.TheroleofinformationandclickCreate%></asp:LinkButton>
                    </td>
                </tr>
                <tr style="display: none">
                    <td class="table_body">
                        <%=Resources.Resource.Account_managemen%>:<span style="color: Red; font-size: 8px">(<%=Resources.Resource.Managerorabovelevel%>,最多4个人)</span>
                    </td>
                    <td class="table_none">
                        <asp:CheckBoxList ID="cbAccountManagement" runat="server" RepeatDirection="Horizontal"
                            RepeatColumns="4">
                        </asp:CheckBoxList>
                    </td>
                </tr>
                <tr>
                    <td class="table_body">
                        <%=Resources.Resource.BindingcommonlyusedIP%>:
                    </td>
                    <td class="table_none">
                        <asp:TextBox ID="txtUserIps" runat="server" Height="112px" TextMode="MultiLine" Width="438px"></asp:TextBox><span
                            style="color: Red; font-size: 10px">* <%=Resources.Resource.MultipleIPpleaseuseseparation%></span>
                    </td>
                </tr>
                <tr>
                    <td class="table_body">
                        <%=Resources.Resource.On_Off%>:
                    </td>
                    <td class="table_none">
                        <asp:RadioButtonList ID="rblState" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem Selected="True" Value="0" Text="<%$ Resources:Resource,On%>"></asp:ListItem>
                            <asp:ListItem Value="1" Text="<%$ Resources:Resource,Off%>"></asp:ListItem>
                            <asp:ListItem Value="2" Text="<%$ Resources:Resource,forbidden%>"></asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td class="table_body"></td>
                    <td class="table_body">
                        <asp:Button ID="btnOK" runat="server" CssClass="button_bak" Text="<%$ Resources:Resource,Determine%>" OnClick="btnOK_Click"
                            Height="28px" Width="80px" OnClientClick="top.ShowDiv_load()" />
                        <asp:Button ID="btnReturn" runat="server" CssClass="button_bak" Text="<%$ Resources:Resource,Return%>" OnClick="btnReturn_Click"
                            Height="28px" Width="80px" />
                        <asp:HiddenField ID="hfLoginName" runat="server" />
                    </td>
                </tr>
            </tbody>
        </table>
    </form>
</body>
</html>
