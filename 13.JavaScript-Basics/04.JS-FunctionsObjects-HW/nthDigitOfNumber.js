function findNthDigit(input) {
    var n = input[0];
    var num = Math.abs(input[1]);
    while (num - Math.floor(num) > 0) {
        num *= 10;
    }
    var digit;
    if (Math.floor(num / Math.pow(10,n-1)) > 0) {
        digit = Math.floor(num % Math.pow(10, n) / Math.pow(10, n-1));
    }
    return digit == undefined ? ('The number doesn\'t have ' + n + ' digits') : digit;
}

function onProblem02Click() {
    console.log(findNthDigit([1, 6]));
    console.log(findNthDigit([2, -55]));
    console.log(findNthDigit([6, 923456]));
    console.log(findNthDigit([3, 1451.78]));
    console.log(findNthDigit([6, 888.88]));

}