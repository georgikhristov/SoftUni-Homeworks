function reverseWordsInString(str) {
    str = str.split(' ');
    
    for (var i in str) {
        str[i] = reverseString(str[i]);
    }
    return str.join(' ');
}

function reverseString(input) {
    var reversed = '';
    for (var i = input.length - 1; i >= 0 ; i--) {
        reversed += input[i];
    }
    return reversed;
}

function onProblem05Click() {
    console.log(reverseWordsInString('Hello, how are you.'));
    console.log(reverseWordsInString('Life is pretty good, isn’t it?'));
}