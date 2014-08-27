function findMostFreqWord(input) {
    var words = input.split(/\W+/).filter(Boolean);
    var unique = {};
    for (var i in words) {
        words[i] = words[i].toLowerCase();
        if (!unique.hasOwnProperty(words[i])) {
            unique[words[i]] = 1;
        } else {
            unique[words[i]]++;
        }
    }
    var max = unique[words[0]];
    for (var i in unique) {
        if (unique[i] > max) {
            max = unique[i];
        }
    }
    var mostFreq = [];
    for (var i in unique) {
        if (unique[i] === max) {
            mostFreq.push(i + ' -> ' + unique[i] + ' times');
        }
    }
    console.log(mostFreq.join('\n'));
}
function onProblem15Click() {
    findMostFreqWord('in the middle of the night');
    findMostFreqWord('Welcome to SoftUni. Welcome to Java. Welcome everyone.');
    findMostFreqWord('Hello my friend, hello my darling. Come on, come here. Welcome, welcome darling.');

}