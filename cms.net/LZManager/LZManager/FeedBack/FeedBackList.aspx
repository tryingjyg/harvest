<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FeedBackList.aspx.cs" Inherits="LZManager.FeedBack.FeedBackList" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="../css/Site_Css.css" type="text/css" />
    <link rel="stylesheet" href="../css/table/default/Css.css" type="text/css" />
    <script src="../JavaScript/Dialog/jquery-1.7.2.min.js" type="text/javascript"></script>
    <script src="../JavaScript/FeedBack/FeedBackList.js" type="text/javascript"></script>
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
            background-color: White;
        }
        .title
        {
            background-color: #E9F2F7;
            font-size: 13px;
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
            $(".title").click(function () {
                $(this).next(".text").slideToggle("slow");
            })
        });
    </script>
</head>
<body>
    <form runat="server">
    <div align="right" style="height: 20px; padding-top: 8px;">
        <a href="FeedBackAdd.aspx" class="cbutton">提交问题信息</a>
    </div>
    <div runat="server" id="div_show">
    </div>
    <div runat="server" id="div_isrepare">

    </div>
    <div align="right">
        <webdiyer:AspNetPager ID="AspNetPager1" runat="server" CustomInfoHTML="第%CurrentPageIndex%页，共%PageCount%页，每页%PageSize%条"
            FirstPageText="首页" LastPageText="尾页" NextPageText="下一页" OnPageChanged="AspNetPager1_PageChanged"
            PrevPageText="上一页">
        </webdiyer:AspNetPager>
    </div>
    </form>
</body>
</html>
