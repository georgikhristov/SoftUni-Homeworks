function isPrime(value) {
    var end = Math.sqrt(value);
    for (var i = 2; i <= end; i++) {
        if (value % i == 0) {
            return false;
        }
    }
    return true;
}

console.log(7 + " is prime? " + isPrime(7));
console.log(254 + " is prime? " + isPrime(254));
console.log(587 + " is prime? " + isPrime(587));