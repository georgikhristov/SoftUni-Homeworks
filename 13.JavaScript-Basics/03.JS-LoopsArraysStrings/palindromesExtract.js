function findPalindromes(input) {
    var words = input.split(/\W+/).filter(Boolean);
    var palindromes = [];
    for (var i in words) {
        words[i] = words[i].toLowerCase();
        var isPalindrome = true;
        for (var j = 0; j < words[i].length / 2; j++) {
            if (words[i][j] != words[i][words[i].length - j - 1]) {
                isPalindrome = false;
                break;
            }
        }
        if (isPalindrome) {
            palindromes.push(words[i]);
        }
    }
    console.log(palindromes);
}

function onProblem14Click() {
    findPalindromes('There is a man, his name was Bob.');
    findPalindromes('Hi I am a test- ala bala nica, turska panica, asdffffaffffdsa')
}