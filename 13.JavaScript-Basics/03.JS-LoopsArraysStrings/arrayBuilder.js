function createArray(value) {
    var arr = [];
    for (var i = 0; i < value; i++) {
        arr.push(i * 5);
    }
    console.log(arr);
}

function onProblem04Click() {
    createArray(20);
}