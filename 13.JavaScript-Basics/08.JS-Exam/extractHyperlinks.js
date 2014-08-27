function solve(input) {
    //Get all non-closing tags
    var tags = input.join(' ').match(/<(.*?)>/gim).filter(Boolean);

    //Get all 'a href' tags
    var links = [];
    for (var i = 0; i < tags.length; i++) {
        var str = tags[i].match(/a\s+(.*?)href\s*=\s*('(.*?)'|"(.*?)")/gim);
        if (str != null) {
            links.push(str[0]);
        }
    }

    //Get all 'href = ''|"" ' strings
    var hrefs = [];
    for (var i = 0; i < links.length; i++) {
        var str = links[i].match(/href\s*=\s*('(.*?)'|"(.*?)")/gim);
        if (str != null) {
            hrefs.push(str[0]);
        }
    }

    //Get only the hyperlinks
    var arr = [];
    for (var i = 0; i < hrefs.length; i++) {
        var str = hrefs[i].match(/('(.*?)'|"(.*?)")/gim);
        if (str != null) {
            var link = '';
            //remove the quote signs
            for (var j = 1; j < str[0].length - 1; j++) {
                link += str[0][j];
            }
            arr.push(link);
        }
    }
    console.log(arr.join('\n'));
}
//solve(['<a href="http://softuni.bg" class="new"></a>']);
//solve(['<p>This text has no links</p>']);

solve(['<!DOCTYPE html>',
'<html>',
'<head>',
'  <title>Hyperlinks</title>',
'  <link href="theme.css" rel="stylesheet" />',
'</head>',
'<body>',
'<ul><li><A   hrEf="/"  id="home">Home</a></li><li><a',
' class="selected" href="/courses">Courses</a>',
'</li><li><a href = ',
'\'/forum\' >Forum</a></li><li><a class="href"',
'onclick="go()" href= "#">Forum</a></li>',
'<li><a id="js" href =',
'"javascript:alert(\'hi\')" class="new">click</a></li>',
'<li><a id=\'nakov\' href =',
'\'http://www.nakov.com\' class=\'new\'>nak</a></li></ul>',
'<A href="#"></a>',
'a id="href">href=\'fake\'<img src=\'http://abv.bg/i.gif\' ',
'alt=\'abv\'/></a><a href="#">&lt;a href=\'hello\'&gt;</a>',
'<!-- This code is commented:',
'  <a href="#commented">commentex hyperlink</a> -->',
'</body>']);


