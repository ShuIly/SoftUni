function getPersons() {
    class Person {
        constructor(firstName, lastName, age, email) {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.email = email;
        }

        toString() {
            return `${this.firstName} ${this.lastName} (age: ${this.age}, email: ${this.email})`;
        }
    }

    let personArr = [];
    personArr.push(new Person('Maria', 'Petrova', 22, 'mp@yahoo.com'));
    personArr.push(new Person('SoftUni'));
    personArr.push(new Person('Stephan', 'Nikolov', 25));
    personArr.push(new Person('Peter', 'Kolev', 24, 'ptr@gmail.com'));

    return personArr;
}