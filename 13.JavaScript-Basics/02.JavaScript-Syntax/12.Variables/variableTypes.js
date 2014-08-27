function variableTypes(value) {
    var name = value[0];
    var age = value[1];
    var isMale = value[2];
    var foods = value[3];
    console.log("My name: " + name + " //type is " + typeof name);
    console.log("My age: " + age + " //type is " + typeof age);
    console.log("I am male: " + isMale + " //type is " + typeof isMale);
    console.log("My favourite foods are: " + foods + " //type is " + typeof foods);
}

variableTypes(['Pesho', 22, true, ['fries', 'banana', 'cake']]);
variableTypes(['Tsvety','20', false,['strawberries','tangerines']])