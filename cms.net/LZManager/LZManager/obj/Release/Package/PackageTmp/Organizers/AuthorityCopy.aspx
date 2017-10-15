<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AuthorityCopy.aspx.cs"
    Inherits="LZManager.Organizers.AuthorityCopy" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>权限复制/转移</title>
    <link rel="stylesheet" href="../css/Site_Css.css" type="text/css" />
    <link rel="stylesheet" href="../css/table/default/Css.css" type="text/css" />
    <script src="../JavaScript/Dialog/jquery-1.7.2.min.js" type="text/javascript"></script>
    <style type="text/css">
        .item_normal
        {
            border-left: #000000 1px solid;
            border-right: #000000 1px solid;
            width: 150px;
            background-color: #ffffff;
            line-height: 20px;
            overflow: hidden;
        }
        .itemBg
        {
            border-left: #000000 1px solid;
            border-right: #000000 1px solid;
            cursor: default;
            background-color: #ffffff;
            width: 150px;
        }
        .item_high
        {
            border-left: #000000 1px solid;
            border-right: #000000 1px solid;
            background-color: #0256b8;
            cursor: default;
            width: 150px;
            color: #666666;
        }
        .item_button
        {
            border-left: #000000 1px solid;
            border-right: #000000 1px solid;
            border-bottom: #000000 1px solid;
            text-align: right;
            background-color: #ffffff;
            width: 150px;
            cursor: hand;
        }
        .suggest_hidden
        {
            display: none;
        }
    </style>
    <script type="text/javascript">
        //下面来开始写JAVASCRIPT。 
        //首先创建XMLHttpRequest对象。我把它写成一个方法，以免多次调用。 
        var array = new Array(); //定义一个全局变量数组，用来存放拆分字符串的值，后面具体介绍。
        var zz = -1; //此为指针，后面用到
        function xmlHttpInitializtions() {
            try {
                xmlhttpRequest = new ActiveXObject("Msxml2.XMLHTTP");
            }
            catch (e) {
                try {
                    xmlhttpRequest = new ActiveXObject("Microsoft.XMLHTTP");
                }
                catch (e2) {
                    xmlhttpRequest = false;
                }
            }
            if (!xmlhttpRequest && typeof XMLHttpRequest != 'undefined') {
                xmlhttpRequest = new XMLHttpRequest();
            }
        } function beKeyUp() {
            var key = document.getElementById("txtToUser").value;
            if (key.length > 0)//有值才POST，这里最好加个Trim()方法，但是JAVASCRIPT没有现成的方法，自己定义。
            {
                alert("1");
                xmlHttpInitializtions();
                xmlhttpRequest.Open("POST", "SearchCommon.aspx?key=" + escape(key), true); //POST
                xmlhttpRequest.onreadystatechange = stateChange; //返回状态调用方法stateChange
                xmlhttpRequest.Send();
            }
        }
        function stateChange() {
            if (xmlhttpRequest.readystate == 4) {
                if (xmlhttpRequest.status == 200) {
                    var responseStr = xmlhttpRequest.responseText; //获取返回值
                    if (responseStr.length > 0)//返回值不为空才执行下面的代码
                    {
                        array = responseStr.split('|'); //根据‘|’拆分，根据自己任意特殊字符，初始化数组
                        positionDiv(); //调用方法，定位DIV显示，具体见方法解释
                        document.getElementById("search_suggest").innerHTML = ""; //每次清空DIV内容
                        for (var i = 0; i < array.length; i++) {
                            if (array[i] != "")//项值不为空，组合DIV，每个DIV有onmouseover、onmouseout、onclick对应事件
                            {
                                document.getElementById("search_suggest").innerHTML += "<div id='item" + i + "' class='itemBg' onmouseover='beMouseOver(" + i + ")' onmouseout='beMouseOut(" + i + ")' onclick='beClick(" + i + ")'>" + array[i] + "</div>";
                            }
                        }
                        //最后一个DIV显示 关闭 效果 onclick方法
                        document.getElementById("search_suggest").innerHTML += "<div class='item_button' onclick='hiddenDiv();'><font color='#666666'>关闭</font></div>";
                        document.getElementById("search_suggest").style.display = "inline";
                    }
                    else {
                        document.getElementById("search_suggest").style.display = "none";
                    }
                }
            }
        }
        //定位DIV显示
        function positionDiv() {
            var DivRef = document.getElementById("search_suggest");
            DivRef.style.position = "absolute";
            var t = document.getElementById("txtToUser");
            DivRef.style.top = getAbsolutePos(t).y; //相对文本框的TOP高度，方法见下面
            DivRef.style.left = getAbsolutePos(t).x; //相对文本框的LEFT宽度
            DivRef.style.height = array.length * 20; //DIV的高度等于每行20个象素乘行数（也就是数组的长度，体现全局数组的作用，不然要传入数组长度的参数）
        }
        //实现最后一个DIV 关闭 onclick方法
        function hiddenDiv() {
            document.getElementById("search_suggest").style.display = "none";
        }
        //定位方法，不做解释
        function getAbsolutePos(el) {
            var SL = 0, ST = -13;
            var is_div = /^div$/i.test(el.tagName);
            if (is_div && el.scrollLeft) SL = el.scrollLeft;
            if (is_div && el.scrollTop) ST = el.scrollTop;
            var r = { x: el.offsetLeft - SL, y: el.offsetTop - ST };
            if (el.offsetParent) {
                var tmp = this.getAbsolutePos(el.offsetParent);
                r.x += tmp.x;
                r.y += tmp.y;
            }
            return r;
        }
        //函数鼠标经过效果        
        function beMouseOverEFF(i) {
            if ((i >= 0) & (i <= array.length - 1)) {
                document.getElementById("item" + i).className = "item_high";
            }
        }

        //函数鼠标移开效果
        function beMouseOutEFF(i) {
            if ((i >= 0) & (i <= array.length - 1)) {
                document.getElementById("item" + i).className = "item_normal";
            }
        }

        //函数鼠标经过
        function beMouseOver(i) {
            document.getElementById("txtToUser").focus();
            beMouseOutEFF(zz);
            zz = i;
            beMouseOverEFF(zz);
        }

        //函数鼠标移开
        function beMouseOut(i) {
            beMouseOutEFF(i);
        }
        //函数单击
        function beClick(i) {
            document.getElementById("txtToUser").value = array[i];
            document.getElementById("search_suggest").style.display = "none";
            document.getElementById("txtToUser").focus();
        }
 

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
                    <%=Resources.Resource.copyaccount%>:
                </td>
                <td class="table_none">
                    <asp:Label ID="lblUser" runat="server" Text=""></asp:Label>
                    <font color="red">*</font>
                </td>
            </tr>
            <tr id="trPass" runat="server">
                <td class="table_body">
                    <%=Resources.Resource.targetaccount%>:
                </td>
                <td class="table_none">
                    <asp:TextBox ID="txtToUser" Width="150px" runat="server" CssClass="TextBox" autocpmplete="off"></asp:TextBox>
                    <font color="red">*</font>
                    <asp:Button ID="btnYZ" runat="server" Text="<%$ Resources:Resource,verification%>" Width="75px" OnClick="btn_Click" />
                    <asp:Label ID="Label1" runat="server" Text="" Font-Size="10px" ForeColor="Red"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="table_body">
                    <%=Resources.Resource.operationtype%>:
                </td>
                <td class="table_none" align="left">
                    <asp:RadioButtonList ID="rdoType" runat="server" Height="24px" RepeatDirection="Horizontal"
                        Width="600px">
                        <asp:ListItem Value="0" Selected="True" Text="<%$ Resources:Resource,copy %>"></asp:ListItem>
                        <asp:ListItem Value="1" Text="<%$ Resources:Resource,transfer %>"></asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td class="table_body">
                </td>
                <td class="table_body" align="right">
                    <asp:Button ID="btnOK" runat="server" CssClass="button_bak" Text="<%$ Resources:Resource,Determine%>" OnClick="btnOK_Click"
                        Height="28px" Width="150px" OnClientClick="top.ShowDiv_load()" />
                    <asp:Button ID="btnReturn" runat="server" CssClass="button_bak" Text="<%$ Resources:Resource,Return%>" OnClick="btnReturn_Click"
                        Height="28px" Width="150px" />
                </td>
            </tr>
        </tbody>
        <div id="div1" runat="server" visible="false">
            <table width="100%" border="0" cellspacing="1" cellpadding="3" align="center">
                <tr>
                    <td bgcolor="#ffffb9" height="30px">
                        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Small" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
            </table>
            <br />
        </div>
    </table>
    </form>
</body>
</html>
