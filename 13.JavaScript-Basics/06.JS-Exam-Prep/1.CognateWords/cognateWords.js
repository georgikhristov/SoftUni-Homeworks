function cognateWords(test) {
    var input = test[0].split(/[^A-Za-z]/);
    //console.log(input);
    var words = [];
    //removing the empty strings
    //=====1=====
    //for (var i = 0; i < input.length; i++) {
    //    if (input[i]) {
    //        words.push(input[i]);
    //    }
    //}
    //=====2=====
    //words = input.filter(function (w) { return w != ''; });
    //=====3=====
    words = input.filter(Boolean);
    
    //console.log(words);
    var output = [];
    for (var a = 0; a < words.length; a++) {
        for (var b = 0; b < words.length; b++) {
            for (var c = 0; c < words.length; c++) {
                var check = ((a != b) && (words[a] + words[b] == words[c]));
                if (check) {
                    var result = words[a] + '|' + words[b] + '=' + words[c];
                    if (output.indexOf(result) < 0) {
                        output.push(result);
                    }
                }
            }
        }
    }

    for (var i = 0; i < output.length; i++) {
        console.log(output[i]);
    }
    if (output.length == 0) {
        console.log('No');
    }
}
cognateWords('java..?|basics/*-+=javabasics');
cognateWords('a a aa a');