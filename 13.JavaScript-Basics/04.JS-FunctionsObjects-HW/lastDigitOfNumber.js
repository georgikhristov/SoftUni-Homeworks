﻿function lastDigitAsText(value) {
    var name = "";
    switch (Math.abs(value % 10)) {
        case 0: name = "zero"; break;
        case 1: name = "one"; break;
        case 2: name = "two"; break;
        case 3: name = "three"; break;
        case 4: name = "four"; break;
        case 5: name = "five"; break;
        case 6: name = "six"; break;
        case 7: name = "seven"; break;
        case 8: name = "eight"; break;
        case 9: name = "nine"; break;
        default: break;
    }
    console.log('The last digit of ' + value + ' is ' + name);
}

function onProblem01Click() {
    lastDigitAsText(6);
    lastDigitAsText(-55);
    lastDigitAsText(133);
    lastDigitAsText(14567);

}