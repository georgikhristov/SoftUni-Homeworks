function findCardFrequencies(input) {
    var cards = input.split(/\W+/).filter(Boolean);
    var unique = {};
    var order = [];
    for (var i in cards) {
        if (!unique.hasOwnProperty(cards[i])) {
            unique[cards[i]] = 1;
            order.push(cards[i]);
        } else {
            unique[cards[i]]++;
        }
    }
    var output = '';
    for (var i in order) {
        output += order[i] + ' -> ' + (unique[order[i]] / cards.length * 100).toFixed(2) + '%\n';
    }
    console.log(output);
}
function onProblem16Click() {
    findCardFrequencies('8♥ 2♣ 4♦ 10♦ J♥ A♠ K♦ 10♥ K♠ K♦');
    findCardFrequencies('J♥ 2♣ 2♦ 2♥ 2♦ 2♠ 2♦ J♥ 2♠');
    findCardFrequencies('10♣ 10♥');
}