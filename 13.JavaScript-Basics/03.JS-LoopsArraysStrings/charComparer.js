function compareChars() {
    var firstArr = arguments[0];
    var secondArr = arguments[1];
    var equal = 'Equal';
    var length = (firstArr.length > secondArr.length ? firstArr.length : secondArr.length);
    for (var i = 0; i < length; i++) {
        if (firstArr[i] != secondArr[i]) {
            equal = 'Not Equal';
            break;
        }
    }
    console.log(equal);
}

function onProblem05Click() {
    compareChars(['1', 'f', '1', 's', 'g', 'j', 'f', 'u', 's', 'q'],['1', 'f', '1', 's', 'g', 'j', 'f', 'u', 's', 'q']);
    compareChars(['3', '5', 'g', 'd'],['5', '3', 'g', 'd']);
    compareChars(['q', 'g', 'q', 'h', 'a', 'k', 'u', '8', '}', 'q', '.', 'h', '|', ';'],['6', 'f', 'w', 'q', ':', '”', 'd', '}', ']', 's', 'r']);
}