<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MallTGoodsEdit.aspx.cs" Inherits="LZManager.MallGoods.MallGoodsEdit" %>

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
    <table width="100%" border="0" cellspacing="1" cellpadding="3" align="center">
        <tbody>
            <tr>
                <td class="table_body">
                      <%=Resources.Resource.goodsid%>:
                </td>
                <td class="table_none">
                    <asp:TextBox ID="txtGoodNo" CssClass="text_input" runat="server" Width="50%" MaxLength="50"></asp:TextBox>
                    <font color="red">*</font>
                </td>
            </tr>
             <tr>
                <td class="table_body">
                      <%=Resources.Resource.goodsname%>:
                </td>
                <td class="table_none">
                    <asp:TextBox ID="txtGoodName" CssClass="text_input" runat="server" Width="50%" MaxLength="50"></asp:TextBox>
                    <font color="red">*</font>
                </td>
            </tr>
            <tr>
                <td class="table_body">
                      <%=Resources.Resource.goodsprice%>:
                </td>
                <td class="table_none">
                    <asp:TextBox ID="txtGoodPrice" CssClass="text_input" runat="server" Width="50%" MaxLength="50"></asp:TextBox>
                    <font color="red">*</font>
                </td>
            </tr>
            <tr>
                <td class="table_body">
                    <%=Resources.Resource.goodsdiamondnum%>:
                </td>
                <td class="table_none">
                    <asp:TextBox ID="txtGoodDiamondNum" CssClass="text_input" runat="server" Width="50%" MaxLength="50"></asp:TextBox>
                    <font color="red">*</font>
                </td>
            </tr>

            <tr>
                <td class="table_body">
                    <%=Resources.Resource.goodspresentnum%>:
                </td>
                <td class="table_none">
                    <asp:TextBox ID="txtPresentNum" CssClass="text_input" runat="server" Width="50%" MaxLength="50"></asp:TextBox>
                    <font color="red">*</font>
                </td>
            </tr>
            <tr>
                <td class="table_body">
                    <%=Resources.Resource.goodsrate%>:
                </td>
                <td class="table_none">
                    <asp:TextBox ID="txtRate" CssClass="text_input" runat="server" Width="50%" MaxLength="50"></asp:TextBox>
                    <font color="red">*</font>
                </td>
            </tr>
            <%--<tr>
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
            </tr>--%>
            <tr>
                <td class="table_body">
                </td>
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
