




// 修改状态
var my_ajax = createAjax();

function UpDateState(id, state) {
    if(confirm('您确定要接受该问题么?'))
    {
        my_ajax.open('get', 'UpdateState.ashx?id=' + id + "&state=" + state, true);
        my_ajax.send(null);
    }
}

my_ajax.onreadystatechange = function () {
    if (my_ajax.readyState === 4) {
        var result = my_ajax.responseText.toString();
        if (result == "1") {
            alert("接受成功!");
        }
        else {
            alert("接受失败,内部错误！");
        }
    }
};



// 修改 管理员提交信息
var my_ajax_solve = createAjax();

function Updatesolvedescription(message, id, state) {
    if (confirm(message)) {
        var solvedescription = document.getElementById("txt_solvedescription_" + id + "").value;
        my_ajax_solve.open('get', 'Updatesolvedescription.ashx?id=' + id + "&state=" + state + "&message=" + solvedescription, true);
        my_ajax_solve.send(null);
    }
}

my_ajax_solve.onreadystatechange = function () {
    if (my_ajax_solve.readyState === 4) {
        var result = my_ajax_solve.responseText.toString();
        if (result == "1") {
            alert("接受成功!");
        }
        else {
            alert("接受失败,内部错误！");
        }
    }
};




//Ajax
function createAjax() {
    var xmlHttp;

    try {
        // Firefox, Opera 8.0+, Safari
        xmlHttp = new XMLHttpRequest();
        return xmlHttp;
    }
    catch (e) {

        // Internet Explorer
        try {
            xmlHttp = new ActiveXObject("Msxml2.XMLHTTP");
            return xmlHttp;
        }
        catch (e) {

            try {
                xmlHttp = new ActiveXObject("Microsoft.XMLHTTP");
                return xmlHttp;
            }
            catch (e) {
                alert("您的浏览器不支持AJAX！");
                return false;
            }
        }
    }
}
