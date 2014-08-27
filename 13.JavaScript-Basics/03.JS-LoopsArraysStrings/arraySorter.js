function sortArray() {
    var arr = arguments[0];
    for (var i = 0; i < arr.length; i++) {
        var min = arr[i];
        var index = i;
        for (var j = i; j < arr.length; j++) {
            if (min > arr[j]) {
                min = arr[j];
                index = j;
            }
        }
        arr.splice(index, 1);
        arr.splice(i, 0, min);
    }
    console.log(arr);
}

function onProblem08Click() {
    sortArray([5, 4, 3, 2, 1]);
    sortArray([12, 12, 50, 2, 6, 22, 51, 712, 6, 3, 3]);
}