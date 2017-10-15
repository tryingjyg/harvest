<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RoleModuleEdit.aspx.cs"
    Inherits="LZManager.Role.RoleModuleEdit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="../css/Site_Css.css" type="text/css" />
    <link rel="stylesheet" href="../css/table/default/Css.css" type="text/css" />
    <script language="javascript" type="text/javascript">
        var XMLHttp = {
            _objPool: [],

            _getInstance: function () {
                for (var i = 0; i < this._objPool.length; i++) {
                    if (this._objPool[i].readyState == 0 || this._objPool[i].readyState == 4) {
                        return this._objPool[i];
                    }
                }

                // IE5中不支持push方法
                this._objPool[this._objPool.length] = this._createObj();

                return this._objPool[this._objPool.length - 1];
            },

            _createObj: function () {
                if (window.XMLHttpRequest) {
                    var objXMLHttp = new XMLHttpRequest();

                }
                else {
                    var MSXML = ['MSXML2.XMLHTTP.5.0', 'MSXML2.XMLHTTP.4.0', 'MSXML2.XMLHTTP.3.0', 'MSXML2.XMLHTTP', 'Microsoft.XMLHTTP'];
                    for (var n = 0; n < MSXML.length; n++) {
                        try {
                            var objXMLHttp = new ActiveXObject(MSXML[n]);
                            break;
                        }
                        catch (e) {
                        }
                    }
                }

                // mozilla某些版本没有readyState属性
                if (objXMLHttp.readyState == null) {
                    objXMLHttp.readyState = 0;

                    objXMLHttp.addEventListener("load", function () {
                        objXMLHttp.readyState = 4;

                        if (typeof objXMLHttp.onreadystatechange == "function") {
                            objXMLHttp.onreadystatechange();
                        }
                    }, false);
                }

                return objXMLHttp;
            },

            // 发送请求(方法[post,get], 地址, 数据, 回调函数)
            sendReq: function (method, url, data, callback) {
                var objXMLHttp = this._getInstance();

                with (objXMLHttp) {
                    try {
                        // 加随机数防止缓存
                        if (url.indexOf("?") > 0) {
                            url += "&randnum=" + Math.random();
                        }
                        else {
                            url += "?randnum=" + Math.random();
                        }

                        open(method, url, true);

                        // 设定请求编码方式
                        setRequestHeader('Content-Type', 'application/x-www-form-urlencoded; charset=UTF-8');
                        send(data);
                        onreadystatechange = function () {
                            if (objXMLHttp.readyState == 4 && (objXMLHttp.status == 200 || objXMLHttp.status == 304)) {
                                callback(objXMLHttp);
                            }
                        }
                    }
                    catch (e) {
                        alert(e);
                    }
                }
            }
        }
        //------------------------------------------------------------------------------------------------------
        //保存权限
        //ParmType  0为添加或删除一个权限 1为添加所有权限（全选）
        function Permsave(ParmType, ModuleID, RoleID, ParmID) {
            //1为全选
            if (ParmType == "1") {
                //是否是选择
                if (document.getElementById(ModuleID + "_all").checked == "checked" || document.getElementById(ModuleID + "_all").checked == true) {
                    var str = document.getElementById(ModuleID + "_hidden").value;
                    var strlist = new Array();
                    strlist = str.split("|");
                    //操作操作列表
                    for (var i = 0; i < strlist.length; i++) {
                        document.getElementById(ModuleID + "_" + strlist[i]).checked = "checked";
                    }
                    //提交数据
                    //所有权限
                    XMLHttp.sendReq('GET', "RoleModuleParm.ashx?&RoleID=" + RoleID + "&ParmID=" + str + "&ParmType=" + ParmType + "&ModuleID=" + ModuleID, '', SaveNode);
                }
                else {
                    document.getElementById(ModuleID + "_all").checked = "";
                }
            }
            else {
                //是否是选择
                if (document.getElementById(ModuleID + "_" + ParmID).checked == "checked" || document.getElementById(ModuleID + "_" + ParmID).checked == true) {
                    document.getElementById(ModuleID + "_" + ParmID).checked = "checked";
                    //添加一个权限
                    XMLHttp.sendReq('GET', "RoleModuleParm.ashx?ParmModule=" + str + "&RoleID=" + RoleID + "&ParmID=" + ParmID + "&ParmType=2&ModuleID=" + ModuleID, '', SaveNode);

                }
                else {
                    document.getElementById(ModuleID + "_all").checked = "";
                    document.getElementById(ModuleID + "_" + ParmID).checked = "";
                    //删除权限
                    XMLHttp.sendReq('GET', "RoleModuleParm.ashx?ParmModule=" + str + "&RoleID=" + RoleID + "&ParmID=" + ParmID + "&ParmType=3&ModuleID=" + ModuleID, '', SaveNode);
                }

            }

        }
        //回调
        function SaveNode(xmlhttp) {
            if (xmlhttp.readyState == 4) {
                //status服务器的http状态码:200=OK,400=Not Found就是未找到
                if (xmlhttp.status == 200) {
                    var Content = xmlhttp.responseText;
                }
                else {
                    alert("你请求的页面出现错误!" + xmlHttp.statusText);
                }
            }
        }
        //展开树目录
        function TreeViewSpread(ParentID, IsChild, RoleID, PlatformID) {
            //是否有下级目录（0有，1没有）
            if (IsChild == "0") {
                //树目录是否为展开
                if (document.getElementById(ParentID + "_Child").style.display == "none") {
                    //展开显示DIV
                    document.getElementById(ParentID + "_Child").style.display = "block";
                    //得到数据
                    XMLHttp.sendReq('GET', "PermissionsTatalTree.ashx?PlatformID=" + PlatformID + "&ParentID=" + ParentID + "&RoleID=" + RoleID, '', TreeNode);
                    //是否是根目录
                    if (document.getElementById(ParentID).className == "TopParentDivYes" || document.getElementById(ParentID).className == "TopParentDivNo") {

                    }
                }
                else {
                    document.getElementById(ParentID + "_Child").style.display = "none";
                }
            }
            else {
                //是否是根目录
                if (document.getElementById(ParentID).className == "TopParentDiv" || document.getElementById(ParentID).className == "TopParentDivNo") {

                }
            }
        }
        //回调
        function TreeNode(xmlhttp) {
            if (xmlhttp.readyState == 4) {
                //status服务器的http状态码:200=OK,400=Not Found就是未找到
                if (xmlhttp.status == 200) {
                    var Content = xmlhttp.responseText;

                    var list = new Array();
                    list = Content.split("|||");
                    document.getElementById(list[0]).style.display = "block";

                    if (list[1].toString() == "") {
                        document.getElementById(list[0]).innerHTML = "暂无子模块";
                    }
                    else {
                        document.getElementById(list[0]).innerHTML = list[1];
                    }
                }
                else {
                    alert("你请求的页面出现错误!" + xmlHttp.statusText);
                }
            }
        }
    </script>
    <style type="text/css">
        #PermissionsTree
        {
            width: 100%;
            background-color: #cadee8;
            background-repeat: repeat-x;
            border: 1px solid #8db6cf;
        }
        
        /*最外层div 有下级目录*/
        .TopParentDivYes
        {
        }
        /*最外层标题Table*/
        .TopModuleTeble
        {
            font-size: 13px;
            height: 35px;
            line-height: 35px;
            font-weight: bold;
        }
        /*最外层表里的标题div*/
        .TopParentTitleYes
        {
            width: 140px;
        }
        .TopParentTitleYes a
        {
            color: Black;
            text-decoration: none;
        }
        .TopParentTitleNo
        {
            width: 140px;
        }
        .TopParentTitleNo a
        {
            color: Black;
            text-decoration: none;
        }
        .TopModuleChild
        {
            border-top: 1px solid #c3d7e3;
            border-bottom: 1px solid #c3d7e3;
            background-color: #ebf6fd;
        }
        .moduleChildNo
        {
            border-top: 1px solid #c3d7e3;
            line-height: 31px;
        }
        /*下级DIV标题表格*/
        .ModuleTeble
        {
            font-size: 12px;
            padding-left: 35px;
            height: 31px;
        }
        
        .ChildTitleYes
        {
            width: 140px;
            padding-left: 10px;
        }
        .ChildTitleYes a
        {
            color: #555555;
            text-decoration: none;
        }
        .ChildTitleNo a
        {
            color: #555555;
            text-decoration: none;
        }
        /*最底层DIV格式*/
        .moduleChild
        {
            padding-left: 45px;
            background-image: url(Img/Per_02.gif);
            background-repeat: repeat-x;
            line-height: 31px;
            height: 31px;
        }
        
        .ChildTitleNo
        {
            width: 140px;
            padding-left: 10px;
        }
        
        /*小图标收缩格式*/
        /* .MapShow
        {
            width:11px;
            padding-left:10px;           
            background-repeat:no-repeat; 
            background-image:url(Img/hidden.gif);
        }
        .MapShow1
        {
            width:11px;
            background-image: url(Img/show.gif);
            background-repeat:no-repeat; 
        }     
        */
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table width="100%" border="0" cellspacing="1" cellpadding="3" align="center">
        <tbody>
            <tr>
                <td>
                </td>
                <td align="right">
                    <asp:Button ID="btnReturn" runat="server" CssClass="button_bak" Text="<%$ Resources:Resource,returnrolelist%>" Height="28px"
                        Width="100px" OnClick="btnReturn_Click" />
                </td>
            </tr>
        </tbody>
    </table>
    <div id="PermissionsTree" runat="server">
    </div>
    </form>
</body>
</html>
