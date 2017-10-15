/**初始化**/
$(document).ready(function () {
    writeDateInfo();
    readyIndex();
    iframeresize();
});
//样式
function readyIndex() {
    $(".navPanelMini div").click(function () {
        $('.navPanelMini div').removeClass("selected")
        $(this).addClass("selected");
    }).hover(function () {
        $(this).addClass("navHover");
    }, function () {
        $(this).removeClass("navHover");
    });
    $(".navSelect div").click(function () {
        $('.navSelect div').removeClass("selected")
        $(this).addClass("selected");
    }).hover(function () {
        $(this).addClass("navHover");
    }, function () {
        $(this).removeClass("navHover");
    });
}
/**自应高度**/
function iframeresize() {
    resizeU();
    $(window).resize(resizeU);
    function resizeU() {
        var divkuangH = $(window).height();
        $("#MainContent").height(divkuangH - 123);
        //导航
        var navigationheight = $(".navigation").height();
        var navPanelheight = $("#htmlMenuPanel").height();
        var navSelectheight = $(".navSelect").height();
        $(".navPanelMini").css("height", navigationheight - navSelectheight - 49);
    }
}
//链接内框架frames
function NavMenu(url, title) {
    Loading(true);
}
function NavMenuUrl(url) {
    $("#main").attr("src", url);
    return false;
}
//当前日期
function writeDateInfo() {
    var day = "";
    var month = "";
    var ampm = "";
    var ampmhour = "";
    var myweekday = "";
    var year = "";
    mydate = new Date();
    myweekday = mydate.getDay();
    mymonth = mydate.getMonth() + 1;
    myday = mydate.getDate();
    myyear = mydate.getYear();
    year = (myyear > 200) ? myyear : 1900 + myyear;
    if (myweekday == 0)
        weekday = " 星期日";
    else if (myweekday == 1)
        weekday = " 星期一";
    else if (myweekday == 2)
        weekday = " 星期二";
    else if (myweekday == 3)
        weekday = " 星期三";
    else if (myweekday == 4)
        weekday = " 星期四";
    else if (myweekday == 5)
        weekday = " 星期五";
    else if (myweekday == 6)
        weekday = " 星期六";
    $("#datetime").text(year + "年" + mymonth + "月" + myday + "日 " + weekday);
}
