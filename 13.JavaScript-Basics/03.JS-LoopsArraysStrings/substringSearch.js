function countSubstringOccur(input) {
    var str = input[1].toLowerCase();
    var word = input[0].toLowerCase();
    var count = 0;
    for (var i = 0; i < str.length; i++) {
        if (str.substr(i, word.length) == word) {
            count++;
        }
    }
    console.log(count);
}
function onProblem12Click() {
    countSubstringOccur(['in', 'We are living in a yellow submarine. We don\'t have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.']);
    countSubstringOccur(['your', 'No one heard a single word you said. They should have seen it in your eyes. What was going around your head.']);
    countSubstringOccur(['but', 'But you were living in another world tryin\' to get your message through.']);
}