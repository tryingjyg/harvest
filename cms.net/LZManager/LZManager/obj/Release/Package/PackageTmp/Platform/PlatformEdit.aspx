<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PlatformEdit.aspx.cs" Inherits="LZManager.Platform.PlatformEdit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="../css/Site_Css.css" type="text/css" />
    <link rel="stylesheet" href="../css/table/default/Css.css" type="text/css" />
    <script src="../JavaScript/Dialog/jquery-1.7.2.min.js" type="text/javascript"></script>
    
    <script type="text/javascript">


        $(function () {

            $("#<%=btnReturn.ClientID%>").click(function () {
                window.location.href = "PlatformList.aspx";
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
        <tr>
            <td class="table_body">
                <%=Resources.Resource.platform_name%>:
            </td>
            <td class="table_none">
                <asp:TextBox ID="txtPfname" CssClass="text_input" runat="server" Width="50%" MaxLength="50"></asp:TextBox>
                <font color="red">*</font><asp:RequiredFieldValidator ID="RequiredFieldValidator0"
                    runat="server" ErrorMessage="必填！" ForeColor="Red" ControlToValidate="txtPfname"
                    Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="table_body">
                platform name:
            </td>
            <td class="table_none">
                <asp:TextBox ID="txtPfname_en" CssClass="text_input" runat="server" Width="50%" MaxLength="50"></asp:TextBox>
                <font color="red">*</font><asp:RequiredFieldValidator ID="RequiredFieldValidator1"
                    runat="server" ErrorMessage="必填！" ForeColor="Red" ControlToValidate="txtPfname_en"
                    Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="table_body">
                <%=Resources.Resource.platform_picture%>:
            </td>
            <td class="table_none">
                <asp:Image ID="imgUrl" runat="server" /><br />
                <asp:FileUpload ID="FileUpload1" CssClass="text_input" runat="server" Visible="False"
                    Width="250px" /><span style="color: Blue; font-size: 10px">120px*120px</span>
                <asp:Button ID="btnUpload" runat="server" CssClass="button_bak" Text="<%$ Resources:Resource,Re_upload %>"
                    Height="28px" Width="80px" Visible="False" OnClick="btnUpload_Click" />
                <asp:Button ID="btnCancelUpload" runat="server" CssClass="button_bak" Text="<%$ Resources:Resource,Drop_upload %>"
                    Height="28px" Width="80px" Visible="False" OnClick="btnCancelUpload_Click" />
            </td>
        </tr>
        <tr>
            <td class="table_body">
                <%=Resources.Resource.platform_order%>：
            </td>
            <td class="table_none">
                <asp:TextBox ID="txtPfsort" CssClass="text_input" runat="server" Width="10%" MaxLength="2"></asp:TextBox>
                <font color="red">*<%=Resources.Resource.Is_related_to_the_internal_log_query_number%></font>
            </td>
        </tr>
        <tr>
            <td class="table_body">
                <%=Resources.Resource.On_Off%>：
            </td>
            <td class="table_none">
                <asp:RadioButtonList ID="rblState" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem Selected="True" Value="0" Text="<%$ Resources:Resource,on %>"></asp:ListItem>
                    <asp:ListItem Value="1" Text="<%$ Resources:Resource,off %>"></asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td class="table_body">
            </td>
            <td class="table_body">
                <asp:Button ID="btnOK" runat="server" CssClass="button_bak" Text="<%$ Resources:Resource,Determine %>"
                    OnClick="btnOK_Click" Height="28px" Width="80px" OnClientClick="top.ShowDiv_load()" />
                <asp:Button ID="btnReturn" runat="server" CssClass="button_bak" Text="<%$ Resources:Resource,Return%>"
                    OnClick="btnReturn_Click" Height="28px" Width="80px" />
                <asp:HiddenField ID="hfPfName" runat="server" />
                <asp:HiddenField ID="hfPfImg" runat="server" />
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
