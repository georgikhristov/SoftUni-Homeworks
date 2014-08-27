function findMostFreqNum() {
    var arr = arguments[0];
    var maxLength = 0;
    var mostFreqNum = arr[0];
    for (var i = 0; i < arr.length; i++) {
        var length = 0;
        for (var j = 0; j < arr.length; j++) {
            if (arr[i] === arr[j]) {
                length++;
            }
        }
        if (length > maxLength) {
            maxLength = length;
            mostFreqNum = arr[i];
        }
    }
    console.log(mostFreqNum + ' (' + maxLength + ' times)');
}

function onProblem09Click() {
    findMostFreqNum([4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3]);
    findMostFreqNum([2, 1, 1, 5, 7, 1, 2, 5, 7, 3, 87, 2, 12, 634, 123, 51, 1]);
    findMostFreqNum([1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13]);
}