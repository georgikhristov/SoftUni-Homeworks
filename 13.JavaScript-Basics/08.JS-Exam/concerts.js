function solve(input) {
    var array = {};
    for (var i = 0; i < input.length; i++) {
        var row = input[i].split(' | ');
        var band = row[0];
        var town = row[1];
        var stadium = row[3];
        if (!(array.hasOwnProperty(town))) {
            array[town] = {};
            array[town][stadium] = [band];
        } else {
            if (!(array[town].hasOwnProperty(stadium))) {
                array[town][stadium] = [band];
            } else {
                var hasBand = array[town][stadium].indexOf(band);
                if (hasBand < 0) {
                    array[town][stadium].push(band);
                }
            }
        }
    }
    var towns = [];
    for (var town in array) {
        if (array.hasOwnProperty(town)) {
            towns.push(town);
        }
    }
    towns.sort();
    var output = [];
    for (var i = 0; i < towns.length; i++) {
        var stadiums = [];
        for (var stadium in array[towns[i]]) {
            if (array[towns[i]].hasOwnProperty(stadium)) {
                var bands = [];
                for (var band in array[towns[i]][stadium]) {
                    if (array[towns[i]][stadium].hasOwnProperty(band)) {
                        bands.push(array[towns[i]][stadium][band]);
                    }
                }
                bands.sort();
                stadiums.push('"' + stadium + '":["' + bands.join('","') + '"]');
            }
        }
        stadiums.sort();
        output[i] = '"' + towns[i] + '":{' + stadiums.join(',') + '}';
        
    }
    console.log('{' + output.join(',')+ '}');
    
}

solve(['ZZ Top | London | 2-Aug-2014 | Wembley Stadium', 'Iron Maiden | London | 28-Jul-2014 | Wembley Stadium', 'Metallica | Sofia | 11-Aug-2014 | Lokomotiv Stadium', 'Helloween | Sofia | 1-Nov-2014 | Vassil Levski Stadium', 'Iron Maiden | Sofia | 20-June-2015 | Vassil Levski Stadium', 'Helloween | Sofia | 30-July-2015 | Vassil Levski Stadium', 'Iron Maiden | Sofia | 26-Sep-2014 | Lokomotiv Stadium', 'Helloween | London | 28-Jul-2014 | Wembley Stadium', 'Twisted Sister | London | 30-Sep-2014 | Wembley Stadium', 'Metallica | London | 03-Oct-2014 | Olympic Stadium', 'Iron Maiden | Sofia | 11-Apr-2016 | Lokomotiv Stadium', 'Iron Maiden | Buenos Aires | 03-Mar-2014 | River Plate Stadium']);