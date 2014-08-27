function solve(input) {
    for (var i = 0; i < input.length; i++) {
        input[i] = input[i].split('').filter(Boolean);
    }
    var letters = [];
    for (var i = 0; i < 26; i++) {
        letters[i] = String.fromCharCode(97 + i);
    }
    for (var letter in letters) {
        for (var i = 0; i < input.length - 1; i++) {
            for (var j = 1; j < input[i].length; j++) {
                var validCell = (j < input[i + 1].length - 1);      
                var validLetter = (input[i][j] == letters[letter] || input[i][j] == '#');
                if (validCell && validLetter) {
                    var isTriangle = true;
                    for (var k = j - 1; k <= j + 1; k++) {
                        var isEqual = (input[i + 1][k] == input[i][j]) || (input[i + 1][k] == '#') || (input[i + 1][k] == letters[letter]);
                        if (!isEqual) {
                            isTriangle = false;
                            break;
                        }
                    }
                    if (isTriangle) {
                        input[i][j] = '#';
                        input[i+1][j-1] = '#';
                        input[i+1][j] = '#';
                        input[i+1][j+1] = '#';
                    }
                }
            }
        }
        for (var i in input) {
            for (var j in input[i]) {
                if (input[i][j] == '#') {
                    input[i][j] = '*';
                }
            }
        }
    }
    for (var i = 0; i < input.length; i++) {
        input[i] = input[i].join('');
    }
    console.log(input.join('\n'));
}

solve(['abcdexgh', 'bbbdxxxh', 'abcxxxxx']);