function calcCylinderVol(value) {
    var radius = value[0];
    var height = value[1];
    var volume = radius * radius * Math.PI * height;
    console.log("The volume of a cylinder with radius "
        + radius + " and height " + height + " is " + volume.toFixed(3));
}

calcCylinderVol([2, 4]);
calcCylinderVol([5, 8]);
calcCylinderVol([12, 3]);