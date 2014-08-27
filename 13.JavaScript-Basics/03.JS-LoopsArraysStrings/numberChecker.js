function printNumbers(n) {
    var result = '';
    if (n < 1) {
        result = 'no';
    } else {
        for (var i = 1; i <= n; i++) {
            if ((i % 4 != 0) && (i % 5 != 0)) {
                result += i + ' ';
            }
        }
    }
    console.log(result);
}

function onProblem01Click() {
    printNumbers(20);
    printNumbers(-5);
    printNumbers(13);
}
