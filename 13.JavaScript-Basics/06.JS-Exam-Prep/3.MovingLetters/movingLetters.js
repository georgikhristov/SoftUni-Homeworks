function solve(input) {
    var words = input[0].split(/[ ]+/);
    
    var maxLength = 0;
    for (var i = 0; i < words.length; i++) {
        if (words[i].length > maxLength) {
            maxLength = words[i].length;
        }
    }
    
    for (var i = 0; i < words.length; i++) {
        words[i] = words[i].split('');
    }

    var letters = '';

    for (var lett = 0; lett < maxLength; lett++) {
        for (var index = 0; index < words.length; index++) {
            if (words[index].length > 0) {
                letters += words[index].pop();
            }
            //if (words[index].length - lett > 0) {
            //    letters += words[index][words[index].length-1 - lett];
            //    console.log(words[index][words[index].length -1- lett]);
            //}
        }
    }
    letters = letters.split('');
    for (var i = 0; i < letters.length; i++) {
        var moves = letters[i].toLowerCase().charCodeAt(0) - 96;
        var newPosition = (moves + i) % letters.length;
        var lett = letters.splice(i, 1);
        //console.log(lett[0]);
        //console.log(letters);
        letters.splice(newPosition, 0, lett[0]);
        //console.log(letters);
    }
    letters = letters.join('');
    console.log(letters);
}

solve(['Fun exam right']);