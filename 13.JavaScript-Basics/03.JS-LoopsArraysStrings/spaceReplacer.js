function replaceSpaces(input) {
    for (var i = 0; i < input.length; i++) {
        input = input.replace(/\s+/, '');
    }
    console.log(input);
}
function onProblem13Click() {
    replaceSpaces('But you were         living in another world tryin\' to get your message through');
}