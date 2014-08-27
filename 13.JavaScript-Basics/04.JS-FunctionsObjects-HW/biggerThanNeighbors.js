function biggerThanNeighbors(index, arr) {
    var result;
    if (index > arr.length - 1 || index < 0) {
        result = 'invalid index';
    } else if (index == arr.length - 1 || index == 0) {
        result = 'only one neighbor'
    } else {
        result = (arr[index] > arr[index - 1]) && (arr[index] > arr[index + 1]) ? 'bigger' : 'not bigger';
    }
    return result;
}

function onProblem04Click() {
    console.log(biggerThanNeighbors(2, [1, 2, 3, 3, 5]));
    console.log(biggerThanNeighbors(2, [1, 2, 5, 3, 4]));
    console.log(biggerThanNeighbors(5, [1, 2, 5, 3, 4]));
    console.log(biggerThanNeighbors(0, [1, 2, 5, 3, 4]));

}