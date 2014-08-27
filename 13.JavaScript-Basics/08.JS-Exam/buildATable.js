function solve(input) {
    function isSqrt(num) {
        var sqrt = Math.floor(Math.sqrt(num));
        return (sqrt*sqrt == num);
    }
    function isFib(num) {
        return (isSqrt(5 * num * num + 4) || isSqrt(5 * num * num - 4)) ? 'yes' : 'no';
       
    }

    var start = Number(input[0]);
    var end = Number(input[1]);
    var result = '<table>\n<tr><th>Num</th><th>Square</th><th>Fib</th></tr>\n';
    for (var i = start; i <= end; i++) {
        result += '<tr><td>' + i + '</td><td>' + i * i + '</td><td>' + isFib(i) + '</td></tr>\n';
    }
    result += '</table>';
    console.log(result);  
}