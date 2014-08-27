function findYoungestPerson(persons) {
    var minAge = Infinity;
    var youngest;
    for (var i in persons) {
        if (persons[i].age < minAge) {
            minAge = persons[i].age;
            youngest = persons[i];
        }
    }
    return 'The youngest person is ' + youngest.firstname + " " + youngest.lastname;
}

function onProblem07Click() {
    var persons = [
      { firstname: 'George', lastname: 'Kolev', age: 32 },
      { firstname: 'Bay', lastname: 'Ivan', age: 81 },
      { firstname: 'Baba', lastname: 'Ginka', age: 40 }];
    console.log(findYoungestPerson(persons));

}