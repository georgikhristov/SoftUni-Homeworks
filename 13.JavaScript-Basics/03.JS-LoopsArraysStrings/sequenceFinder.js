function findMaxSequence() {
    var arr = arguments[0];
    var currentLength = 1;
    var maxLength = 1;
    var index = 0;
    for (var i = 0; i < arr.length - 1; i++) {
        if (arr[i] === arr[i + 1]) {
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
    for (var i = index - maxLength + 1; i <= index; i++) {
        maxSequence.push(arr[i]);
    }
    console.log(maxSequence);
}


function onProblem06Click(){
    findMaxSequence([2, 1, 1,1, 2, 3, 3, 2, 2, 2, 1]);
    findMaxSequence(['happy']);
    findMaxSequence([2, 'qwe', 'qwe', 3, 3, '3']);
}

