function bitChecker(value) {
    var mask = 1 << 3;
    if ((mask & value) == 0) {
        console.log(false);
    } else {
        console.log(true);
    }
}

bitChecker(333);
bitChecker(425);
bitChecker(2567564754);