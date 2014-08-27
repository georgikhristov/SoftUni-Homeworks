function displayProperties() {
    console.log(Object.getOwnPropertyNames(document).sort().join('\n'));
}

function onProblem03Click() {
    displayProperties();
}