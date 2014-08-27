function findMaxSequence() {
    var arr = arguments[0];
    var currentLength = 1;
    var maxLength = 0;
    var index = 0;
    for (var i = 0; i < arr.length - 1; i++) {
        if (arr[i] < arr[i + 1]) {
            currentLength += 1;
        } else {
            currentLength = 1;
        }
        if (currentLength >= maxLength) {
            maxLength = currentLength;
            index = i + 1;
        }
    }
    var maxSequence = [];
    if (maxLength < 2) {
        console.log('no');
    } else {
        for (var i = index - maxLength + 1; i <= index; i++) {
            maxSequence.push(arr[i]);
        }
        console.log(maxSequence);
    }
    
}

function onProblem07Click() {
    findMaxSequence([3, 2, 3, 4, 2, 2, 4]);
    findMaxSequence([3, 5, 4, 6, 1, 2, 3, 6, 10, 32]);
    findMaxSequence([3, 2, 1]);
}