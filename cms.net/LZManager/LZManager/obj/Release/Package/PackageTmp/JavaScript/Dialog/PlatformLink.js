
var my_ajax = createAjax();

function onLinkPlatform(name, id) {
    if (confirm("Are you sure you want to enter“" + name + "”?")) {
        location.href = "../../Framework/Index.aspx?Platform=" + id;
    }
}

my_ajax.onreadystatechange = function () {
    if (my_ajax.readyState === 4) {
        var result = my_ajax.responseText.toString();
        if (result.substr(0, 1) == "1") {
            eventDialogs.open();
            document.getElementById("div_message").innerHTML = result.substr(1, (result.length - 1));
        }
    }
};


function len(s) {
    var l = 0;
    var a = s.split("");
    for (var i = 0; i < a.length; i++) {
        if (a[i].charCodeAt(0) < 299) {
            l++;
        } else {
            l += 2;
        }
    }
    return l;
}



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
