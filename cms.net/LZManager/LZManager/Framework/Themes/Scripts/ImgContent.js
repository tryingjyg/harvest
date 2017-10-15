function yj(id) {
    var obj = document.getElementById(id);
    var content = obj.innerHTML;
    var s = obj.style;
    var width = s.width.replace(/px/gi, "");
    var height = s.height.replace(/px/gi, "");
    var bc = s.borderColor;
    var bg = s.backgroundImage;
    var bgc = s.backgroundColor;
    var p = s.padding;
    var pt = s.paddingTop.replace(/px/gi, "");
    var pr = s.paddingRight.replace(/px/gi, "");
    var pb = s.paddingBottom.replace(/px/gi, "");
    var pl = s.paddingLeft.replace(/px/gi, "");
    s.padding = "";
    s.width = "";
    s.height = "";
    s.border = "";
    s.background = "";
    bc = (bc == "") ? "#000000" : bc;
    if (window.navigator.userAgent.indexOf("Firefox") >= 0) {
        bc = String(bc).toLowerCase().replace(/rgb\(.+?\)/g, function () { return "#" + arguments[0].replace(/(\s|\(|\)|rgb)/g, "").replace(/\d+\,*/g, function () { return parseInt(arguments[0]).toString(16).toLowerCase(); }); }).substring(0, 7);
    }
    bgc = (bgc == "") ? "none" : bgc;
    pt = (pt == "") ? 0 : Math.round(pt);
    pr = (pr == "") ? 0 : Math.round(pr);
    pb = (pb == "") ? 0 : Math.round(pb);
    pl = (pl == "") ? 0 : Math.round(pl);
    width = (width == "") ? (20 + pl + pr) : Math.round(width) + pl + pr + 2;
    height = (height == "") ? (20 + pt + pb) : Math.round(height) + pt + pb + 2;
    a1 = "<div style='font:0px;margin:0px;margin-left:5px;width:" + (width - 10) + "px;height:1px;background:" + bc + " '></div>";
    a2 = "<div style='font:0px;margin:0px;margin-left:3px;width:" + (width - 10) + "px;height:1px;background:" + bgc + " " + bg + " -4px 0px;border-left:2px solid " + bc + ";border-right:2px solid " + bc + ";'></div>";
    a3 = "<div style='font:0px;margin:0px;margin-left:2px;width:" + (width - 6) + "px;height:1px;background:" + bgc + " " + bg + " -2px -1px;border-left:1px solid " + bc + ";border-right:1px solid " + bc + ";'></div>";
    a4 = "<div style='font:0px;margin:0px;margin-left:1px;width:" + (width - 4) + "px;height:2px;background:" + bgc + " " + bg + " -1px -2px;border-left:1px solid " + bc + ";border-right:1px solid " + bc + ";'></div>";
    a5 = "<div style='margin:0px;padding:" + p + ";width:" + (width - 2 - pl - pr) + "px;height:" + (height - 10 - pt - pb) + "px;background:" + bgc + " " + bg + " 0px -4px;border-left:1px solid " + bc + ";border-right:1px solid " + bc + ";'>" + content + "</div>";
    a6 = "<div style='font:0px;margin:0px;margin-left:1px;width:" + (width - 4) + "px;height:2px;background:" + bgc + " " + bg + " -1px -" + (height - 2 - 10 + 4) + "px;border-left:1px solid " + bc + ";border-right:1px solid " + bc + ";'></div>";
    a7 = "<div style='font:0px;margin:0px;margin-left:2px;width:" + (width - 6) + "px;height:1px;background:" + bgc + " " + bg + " -2px -" + (height - 2 - 10 + 6) + "px;border-left:1px solid " + bc + ";border-right:1px solid " + bc + ";'></div>";
    a8 = "<div style='font:0px;margin:0px;margin-left:3px;width:" + (width - 10) + "px;height:1px;background:" + bgc + " " + bg + " -4px -" + (height - 2 - 10 + 7) + "px;border-left:2px solid " + bc + ";border-right:2px solid " + bc + ";'></div>";
    a9 = "<div style='font:0px;margin:0px;margin-left:5px;width:" + (width - 10) + "px;height:1px;background:" + bc + " '></div>";
    obj.innerHTML = a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9;
}