function convertDigitToWord(value) {
    var name = "";
    switch (value) {
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
        default: console.log(value + " is not a valid digit"); break;
    }
    console.log(name);
}

convertDigitToWord(8);
convertDigitToWord(3);
convertDigitToWord(5);
convertDigitToWord(10);