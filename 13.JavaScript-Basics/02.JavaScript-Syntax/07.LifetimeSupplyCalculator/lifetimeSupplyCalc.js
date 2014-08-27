function calcSupply(value) {
    var age = value[0];
    var maxAge = value[1];
    var amount = value[2];
    var supply = (maxAge - age) * amount * 365;
    console.log(supply + "kg of chocolate would be enough until you are "
        + maxAge + " years old if you eat " + amount + " kg per day.");
}
calcSupply([38, 118, 0.5]);
calcSupply([20, 87, 2]);
calcSupply([16, 102, 1.1]);