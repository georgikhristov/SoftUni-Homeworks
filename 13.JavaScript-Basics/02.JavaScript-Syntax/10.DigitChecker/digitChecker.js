function checkDigit(value) {
    var thirdDigit = Math.floor(value % 1000 / 100);
    var isThree = ((thirdDigit == 3) ? true : false);
    console.log("Third digit of " + value + " is 3? " + isThree);
}

checkDigit(1235);
checkDigit(25368);
checkDigit(123456);