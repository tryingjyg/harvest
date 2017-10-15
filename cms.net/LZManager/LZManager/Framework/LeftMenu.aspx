<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LeftMenu.aspx.cs" Inherits="LZManager.Framework.LeftMenu" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta http-equiv="X-UA-Compatible" content="IE=EmulateIE9" />
    <script src="../JavaScript/Dialog/jquery-1.7.2.min.js" type="text/javascript"></script>
    <style type="text/css">
        /* 收缩展开效果 */
        body
        {
            font-size: 10px;
        }
        .text
        {
            line-height: 22px;
            padding: 0 6px;
            color: #666;
            cursor: pointer;
            font-size: 11px;
            background-color:White;
        }
        .title
        {
            font-size: 13px;
            background-image: url(../Images/left/bg_top.png);
            color: White;
            height: 25px;
            vertical-align: middle;
            cursor: pointer;
        }
        .box
        {
            position: relative;
            border: 1px solid #e7e7e7;
            cursor: pointer;
            font-size: 11px;
        }
        A:link
        {
            color: #000000;
            text-decoration: none;
            font-size: 13px;
        }
        A:visited
        {
            color: #000000;
            text-decoration: none;
            font-size: 13px;
        }
        A:hover
        {
            color: Silver;
            text-decoration: none;
            font-size: 13px;
        }
        A:active
        {
            color: Silver;
            text-decoration: none;
            font-size: 13px;
        }
        #menuTree A
        {
            text-decoration: none;
        }
    </style>
    <script type="text/javascript">
        // 收缩展开效果
        $(document).ready(function () {
            $("div.text").hide(); //默认隐藏div，或者在样式表中添加.text{display:none}，推荐使用后者
            var onclickup;
            var divname;
            $(".title").click(function () {

                if (divname != $(this).attr("id")) {
                    if (onclickup != $(this)) {
                        if (onclickup != null) {
                            onclickup.next(".text").slideToggle("slow");
                        }
                        $(this).next(".text").slideToggle("slow");
                        onclickup = $(this);
                        divname = $(this).attr("id");
                    }
                }
            })
        });
    </script>
</head>
<body style="background-position-y: -120px; background-image: url(../images/left/bg.gif);
    background-repeat: repeat-x">
    <table height="100%" cellspacing="0" cellpadding="0" width="100%">
        <tbody>
            <tr>
                <td style="font-size: 15px; background-image: url(../Images/left/bg_left_tc.gif);
                    color: white; font-family: system" align="center" height="30px">
                    Main Menu
                </td>
            </tr>
            <tr>
                <td id="menuTree" style="padding-right: 2px; padding-left: 2px; padding-bottom: 2px;
                    padding-top: 2px; height: 100%;  wbackground-color: white" valign="top">
                    <div id="left" style="white-space: 100%; height: 100%" runat="server">
                    </div>
                </td>
            </tr>
            <tr>
                <td style="background-image: url(../Images/left/bg_left_bc.gif)">
                </td>
            </tr>
        </tbody>
    </table>
</body>
</html>
