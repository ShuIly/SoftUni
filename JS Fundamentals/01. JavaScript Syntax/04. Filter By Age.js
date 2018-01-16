function filterByAge(minAge, firstName, firstAge, secondName, secondAge) {
    let person1 = {name: firstName, age: firstAge};
    let person2 = {name: secondName, age: secondAge};

    if (firstAge >= minAge) console.log(person1);
    if (secondAge >= minAge) console.log(person2);
}
