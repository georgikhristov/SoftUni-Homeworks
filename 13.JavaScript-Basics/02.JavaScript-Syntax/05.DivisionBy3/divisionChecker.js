function divisionBy3(value) {
    var num = value;
    var sum = 0;
    while (num != 0) {
        sum += num % 10;
        num = Math.floor(num / 10);
    }
    if (sum % 3 == 0) {
        console.log("the number " + value + " is divided by 3 without remainder");
    } else {
        console.log("the number " + value + " is NOT divided by 3 without remainder");
    }
}

divisionBy3(12);
divisionBy3(189);
divisionBy3(591);