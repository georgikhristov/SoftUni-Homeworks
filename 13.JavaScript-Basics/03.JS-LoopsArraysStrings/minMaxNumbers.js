function findMinAndMax() {
    var min = Number.POSITIVE_INFINITY;
    var max = Number.NEGATIVE_INFINITY;
    for (var i = 0; i < arguments[0].length; i++) {
        if (arguments[0][i] < min) {
            min = arguments[0][i];
        }
        if (arguments[0][i] > max) {
            max = arguments[0][i];
        }
    }
    console.log('Min -> ' + min + '\nMax -> ' + max);
}

function onProblem02Click() {
    findMinAndMax([1, 2, 1, 15, 20, 5, 7, 31]);
    findMinAndMax([2, 2, 2, 2, 2]);
    findMinAndMax([500, 1, -23, 0, -300, 28, 35, 12]);
}