function calcCircleArea(r) {
    var area = r * r * Math.PI;
    return area;
}
function onCalcAreaBtnClick() {
    var arr = jsConsole.readArea("area");

    for (var i = 0; i < arr.length; i++) {
        var area = calcCircleArea(arr[i]);
        jsConsole.writeLine('The area of a circle with radius ' + arr[i] + ' is ' + area);
    }
}