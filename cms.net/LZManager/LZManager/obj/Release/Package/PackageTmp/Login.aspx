<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LZManager.Login" %>

<html>
<head>
    <link href="Css/Login/User_Login.css" rel="stylesheet" type="text/css" />
    <script src="JavaScript/Dialog/jquery-1.7.2.min.js" type="text/javascript"></script>
    <title>BG后台</title>
    <script type="text/javascript">
        function RegestLogin() {
            var user = document.getElementById("txtUser").value;
            var pass = document.getElementById("txtPassword").value;

            if (user == "") {
                alert("用户名不能为空!");
                return false;
            }
            else if (pass == "") {
                alert("密码不能为空!");
                return false;
            }
            else {
                return true;
            }
        }

        $(function () {
            $("#<%=btnland.ClientID%>").click(function () {
                var postData = { "remarkid": "150796870710345", "roomId": "212548", "gameId": "sdmj/ddz", "gameType": "jiaofen", "chargeType": true, "roundNum": 8, "playerNum": 3, "uidAr": "[10280,10345,10343]", "ownerUid": 10280, "destUid": 10345, "useNum": -1, "lastNum": 98, "serverId": 31, "statue": 0, "unidId": "jlsfjalsdjfasjfljasdfa", "duid": 0, "createTime": "1213" };
                $.ajax({
                    type: "post",
                    url: "/WptMall/ConsumeReturn.ashx",
                    data: postData,
                    success: function (joResult) {
                        alert(joResult.data + " " + joResult.msg);
                    }
                })
            });

        })



    </script>
</head>
<body id="userlogin_body">
    <form runat="server" defaultbutton="btnland">
        <div id="user_login">
            <dl>
                <dd id="user_top">
                    <ul>
                        <li class="user_top_l"></li>
                        <li class="user_top_c"></li>
                        <li class="user_top_r"></li>
                    </ul>
                    <dd id="user_main">
                        <ul>
                            <li class="user_main_l"></li>
                            <li class="user_main_c">
                                <div class="user_main_box">
                                    <ul>
                                        <li class="user_main_text"><%=Resources.Resource.username%>： </li>
                                        <li class="user_main_input">
                                            <asp:TextBox ID="txtUser" runat="server" CssClass="TxtUserNameCssClass"></asp:TextBox>
                                        </li>
                                    </ul>
                                    <ul>
                                        <li class="user_main_text"><%=Resources.Resource.password%>： </li>
                                        <li class="user_main_input">
                                            <asp:TextBox ID="txtPassword" runat="server" CssClass="TxtPasswordCssClass" TextMode="Password"></asp:TextBox>
                                        </li>
                                    </ul>
                                    <ul>
                                        <li class="user_main_text"><%=Resources.Resource.verification_code%>： </li>
                                        <li class="user_main_input">

                                            <%--验证码--%>
                                            <asp:TextBox ID="txtValidate" runat="server" CssClass="TxtValidateCodeCssClass"></asp:TextBox>


                                        </li>
                                        <li class="user_main_text">
                                            <asp:ImageButton ID="yzm" runat="server" ImageUrl="Validate/ValidateCode.aspx" />
                                            <%--<asp:LinkButton ID="ChangeCode" runat="server" Text="看不清？换一个" OnClick="ChangeCode_Click" />--%> </li>
                                        <li class="user_main_text">
                                            <asp:LinkButton ID="ChangeCode" runat="server" Text="换一个" OnClick="ChangeCode_Click" />
                                        </li>
                                    </ul>

                                    <ul>

                                        <li class="user_main_text"><%=Resources.Resource.language%>： </li>
                                        <li class="user_main_input">
                                            <asp:DropDownList ID="ddlTranLanguage" runat="server" OnSelectedIndexChanged="ChangeLang" AutoPostBack="True">
                                                <asp:ListItem Value="china" Selected="True">中文</asp:ListItem>
                                                <asp:ListItem Value="eng">English</asp:ListItem>

                                            </asp:DropDownList>
                                        </li>
                                    </ul>
                                    <ul>
                                        <li class="user_main_text">Cookie： </li>
                                        <li class="user_main_input">
                                            <asp:DropDownList ID="ddlCookie" runat="server">
                                                <asp:ListItem Value="None" Selected="True">not save</asp:ListItem>
                                                <asp:ListItem Value="Day">save the day</asp:ListItem>
                                                <asp:ListItem Value="Month">save the month</asp:ListItem>
                                                <asp:ListItem Value="Year">save the year</asp:ListItem>
                                            </asp:DropDownList>
                                        </li>
                                    </ul>

                                </div>
                            </li>
                            <li class="user_main_r">
                                <asp:Button ID="btnland" runat="server" Text=" " CssClass="IbtnEnterCssClass"
                                    OnClick="btnland_Click" />
                            </li>
                        </ul>

                        <dd id="user_bottom">
                            <ul>
                                <li class="user_bottom_l"></li>
                                <li class="user_bottom_c"><span style="margin-top: 40px"><%--如果您尚未在本站注册为用户，请先点此--%> <%--<a href="#">
                                暂不开放</a>--%> </span></li>
                                <li class="user_bottom_r"></li>
                            </ul>
                        </dd>
            </dl>
        </div>
        <span id="ValrUserName" style="display: none; color: red"></span><span id="ValrPassword"
            style="display: none; color: red"></span><span id="ValrValidateCode" style="display: none; color: red"></span>
        <div id="ValidationSummary1" style="display: none; color: red">
        </div>
    </form>
</body>
</html>
