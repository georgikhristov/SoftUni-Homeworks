function checkBrackets(input) {
    var openBrackets = 0;
    var closeBrackets = 0;
    for (var i = 0; i < input.length; i++) {
        if (input[i] == '(') {
            openBrackets++;
        }
        if (input[i] == ')') {
            closeBrackets++;
        }
        if (openBrackets < closeBrackets) {
            openBrackets = -1;
            break;
        }
    }
    console.log(openBrackets == closeBrackets ? 'correct' : 'incorrect');
}

function onProblem11Click() {
    checkBrackets('( ( a + b ) / 5 – d )');
    checkBrackets(') ( a + b ) )');
    checkBrackets('( b * ( c + d *2 / ( 2 + ( 12 – c / ( a + 3 ) ) ) )');
    checkBrackets(') ( a + b ( )');
}