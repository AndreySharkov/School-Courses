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
    toArray() {
        let list = []
        list.push(this.firstName)
        list.push(this.lastName)
        list.push(this.age)
        list.push(this.email)

        return list
    }
}
let person = new Person('Anna', 'Simpson', 22, 'anna@yahoo.com');
console.log(person.toArray());