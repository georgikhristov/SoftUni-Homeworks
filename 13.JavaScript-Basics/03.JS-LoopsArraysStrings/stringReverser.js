function reverseString(input) {
    var reversed = '';
    for (var i = input.length - 1; i >= 0 ; i--) {
        reversed += input[i];
    }
    console.log(reversed);
}
function onProblem10Click(){
    reverseString('sample');
    reverseString('softUni');
    reverseString('java script');
}