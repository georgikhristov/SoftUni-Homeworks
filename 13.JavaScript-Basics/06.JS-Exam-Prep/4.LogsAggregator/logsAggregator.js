function solve(input) {
    var n = input[0];

    var array = {};

    for (var i = 0; i < n; i++) {
        var row = input[i + 1].split(' ');
        var ip = row[0];
        var user = row[1];
        var time = parseInt(row[2]);

        if (!(array.hasOwnProperty(user))) {
            array[user] = {};
            array[user][ip] = time;
        } else {
            if (!(array[user].hasOwnProperty(ip))) {
                array[user][ip] = time;
            } else {
                array[user][ip] += time;
            }
        }
        //console.log(array[user][ip]);
    }

    var userKeys = [];
    for (var user in array) {
        if (array.hasOwnProperty(user)) {
            userKeys.push(user);
        }
    }
    userKeys.sort();
    var output = '';
    for (var i = 0; i < userKeys.length; i++) {
        var ipKeys = [];
        var sumTime = 0;
        for (var ip in array[userKeys[i]]) {
            if (array[userKeys[i]].hasOwnProperty(ip)) {
                ipKeys.push(ip);
                sumTime += array[userKeys[i]][ip];
            }
        }
        output += userKeys[i] + ': ' + sumTime + ' [' + ipKeys.sort().join(', ')+ ']\n';
    }
    console.log(output);

}

solve(['7',
'192.168.0.11 peter 33',
'10.10.17.33 alex 12',
'10.10.17.35 peter 30',
'10.10.17.34 peter 120',
'10.10.17.34 peter 120',
'212.50.118.81 alex 46',
'212.50.118.81 alex 4']);