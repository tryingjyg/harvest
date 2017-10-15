<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPlant.aspx.cs" Inherits="LZManager.Frameworks.LoginPlant" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<html>
<head>
    <script src="Themes/Scripts/jquery-1.8.2.min.js" type="text/javascript"></script>
    <script src="../JavaScript/Dialog/PlatformLink.js" type="text/javascript"></script>
    <style type="text/css">
        #userlogin_body
        {
            background: url(../../Images/login/user_all_bg.gif) #226cc5 repeat-x 50% top;
            padding-bottom: 0px;
            font: 12px/150% Arial, "宋体" ,Helvetica,sans-serif;
            overflow: hidden;
            margin-top: 10%;
        }
        #menu
        {
            width: 100%;
            height: 70%;
            overflow: hidden;
            background: lightblue;
        }
        .page
        {
            position: absolute;
            width: 100%;
            left: 0px;
            height: 70%;
            background-color: Gray;
        }
        .tip
        {
            display: block;
            height: 20px;
            line-height: 20px;
            text-align: center;
            font-size: 12px;
            background: #999;
        }
        .updivcss
        {
            filter: alpha(Opacity=80);
            -moz-opacity: 0.5;
            opacity: 0.5;
            background-color: #81CEFF;
            width: 50px;
            height: 60%;
            color: #133E71;
        }
        
        .divcss
        {
            width: 50px;
            height: 60%;
            color: White;
           
            
            
        }
        
        
    </style>
    <title>  <%=Resources.Resource.BG_background%></title>
</head>
<body id="userlogin_body">
    <form id="Form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
        <ContentTemplate>
            <div align="center" style="width: 100%;">
                <asp:DataList ID="ddlPlatformList" runat="server" RepeatColumns="5" RepeatDirection="Horizontal"
                    Width="80%" FooterStyle-HorizontalAlign="Left" HorizontalAlign="Center" ItemStyle-Width="200px">
                    <ItemTemplate>
                        <div style="padding-top: 30px;">
                            <table>
                                <tr>
                                    <td>
                                        <asp:Label ID="Label1" runat="server" Text='<% #GetMessage(Eval("Pf_id"),Eval("Pf_name"),Eval("Pf_text1"),Eval("Pf_imgUrl"),0,Eval("Pf_isRepair"),Eval("Pf_imgWaterUrl")) %>'></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center" style="color: White;">
                                        <asp:Label ID="Label2" runat="server" Text='<% #GetMessage(Eval("Pf_id"),Eval("Pf_name"),Eval("Pf_text1"),Eval("Pf_imgUrl"),1,Eval("Pf_isRepair"),Eval("Pf_imgWaterUrl")) %>'></asp:Label>
                                    </td>
                                </tr>
                            </table>
                        </div>
                    </ItemTemplate>
                </asp:DataList>
            </div>
            <div style="float: right; padding-right:100px; padding-top:100px;">
                <webdiyer:AspNetPager ID="AspNetPager1" runat="server" CustomInfoHTML="第%CurrentPageIndex%页，共%PageCount%页，每页%PageSize%条"
                    FirstPageText="首页" LastPageText="尾页" NextPageText="下一页" OnPageChanged="AspNetPager1_PageChanged"
                    PrevPageText="上一页">
                </webdiyer:AspNetPager>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
    </form>
</body>
</html>
