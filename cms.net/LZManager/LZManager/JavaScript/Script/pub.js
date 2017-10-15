function $id(s) {
    return document.getElementById(s);
}

//判断小数 
function IsFloat(s) {
    if (!/^[+\-]?\d+(.\d+)?$/.test(s))
        return false;
    else
        return true;
}
//判断正小数
function IsPlusFloat(s) {
    if (!/^[+]?\d+(.\d+)?$/.test(s))
        return false;
    else
        return true;
}

//判断正整数
function IsPlusInt(s) {
    if (!/^\d*$/.test(s))
        return false;
    else
        return true;
}

//判断是否为字母和数字
function CheckName(s) {
    if (!/^[A-Za-z0-9._-]+$/.test(s))
        return false;
    else
        return true;
}


//检测Email格式
function IsEmail(s) {
    var pattern = /^([a-zA-Z0-9._-])+@([a-zA-Z0-9_-])+(\.[a-zA-Z0-9_-])+/;
    flag = pattern.test(s);
    if (!flag) {
        return false;
    }
    return (true);
}

//比较两个数是否相同
function CompValue(s1, s2) {
    if (s1 != s2) {
        return false;
    }
    else
        return true;
}
//判断字符是否为空
function IsEmpty(s) {
    if (s == "") {
        return false;
    }
    else
        return true;
}


//取RadioList的值
function GetRadioList(s) {
    var radListItems = document.all(s);
    var radListItesCount = radListItems.length - 1;
    var radListCheckedValue = "";

    //遍歷Item的Text和Value
    for (var i = 1; i <= radListItesCount; i++) {
        if (radListItems[i].checked)
            radListCheckedValue = radListItems[i].value;
    }

    return radListCheckedValue;
}

function Setfocus() { document.body.focus(); }