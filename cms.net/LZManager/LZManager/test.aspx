<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="LZManager.test" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="JavaScript/Dialog/jquery-1.7.2.min.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function () {


            $("#btnSave").click(function () {
                //                alert("进行了点击");
                //                var strPwd = $("#txtu_password").val();
                //                var reg = /\s/;
                //                if (reg.test(strPwd)) {

                //                    alert("不能为空字符串");
                //                    return false;

                //                }


                $(".text").css("display", "none");


            });


        })


    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <input  type="text"  id="txtu_password"   value=""  class="text"/>
       <input   type="button"  id="btnSave"   value="提交" />

    
    </div>
    </form>
</body>
</html>
