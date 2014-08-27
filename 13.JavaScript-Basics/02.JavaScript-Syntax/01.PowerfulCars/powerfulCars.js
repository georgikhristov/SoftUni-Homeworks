function convertKWtoHP(value) {
    return value / 0.746;
}

console.log(75 + "KW = " + convertKWtoHP(75).toFixed(2) + "HP");
console.log(150 + "KW = " + convertKWtoHP(150).toFixed(2) + "HP");
console.log(1000 + "KW = " + convertKWtoHP(1000).toFixed(2) + "HP");