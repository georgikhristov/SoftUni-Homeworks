function treeHouseCompare(value) {
    var a = value[0];
    var b = value[1];
    var houseArea = a * a * 4 / 3;
    var treeArea = b * b * (1 / 3 + Math.PI * 4 / 9);
    if (houseArea > treeArea) {
        console.log("house/" + houseArea.toFixed(2));
    } else {
        console.log("tree/" + treeArea.toFixed(2));
    }
}

treeHouseCompare([3, 2]);
treeHouseCompare([3, 3]);
treeHouseCompare([4, 5]);