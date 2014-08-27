function findLargestBySumOfDigits() {
    var validInput = true;
    var largest;
    var maxSum = 0;
    for (var i = 0; i < arguments.length; i++) {
        var num = Math.abs(arguments[i]);
        if (num == NaN || num != Math.floor(num)) {
            validInput = false;
            break;
        }
        var sum = 0;
        while (num / 10 > 0) {
            sum += num % 10;
            num /= 10;
        }
        if (sum > maxSum) {
            maxSum = sum;
            largest = arguments[i];
        }
    }
    return validInput ? largest : undefined;
}

function onProblem03Click() {
    console.log(findLargestBySumOfDigits(5, 10, 15, 111));
    console.log(findLargestBySumOfDigits(33, 44, -99, 0, 20));
    console.log(findLargestBySumOfDigits('hello'));
    console.log(findLargestBySumOfDigits(5, 3.3));

}