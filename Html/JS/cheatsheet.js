// =========================================================
// TOPIC 1: ADVANCED FUNCTIONS (Context, Closures, Currying)
// =========================================================

// 1. Context Manipulation (.call, .apply, .bind)
const person = { name: "Alice" };
function greet(greeting, punctuation) {
    return `${greeting}, my name is ${this.name}${punctuation}`;
}

// .call() - passes 'this' context, followed by individual arguments
console.log(greet.call(person, "Hello", "!")); // "Hello, my name is Alice!"

// .apply() - passes 'this' context, followed by an array of arguments
console.log(greet.apply(person, ["Hi", "."])); // "Hi, my name is Alice."

// .bind() - returns a NEW function with 'this' permanently bound
const boundGreet = greet.bind(person, "Hey");
console.log(boundGreet("?")); // "Hey, my name is Alice?"

// ---------------------------------------------------------
// 2. IIFE (Immediately Invoked Function Expression)
// Used to create a private scope that runs immediately
(function() {
    let privateVar = "I cannot be accessed outside";
    console.log("IIFE ran successfully!");
})();

// ---------------------------------------------------------
// 3. Closures
// A function that remembers the variables from its lexical scope (outer function)
function createCounter() {
    let count = 0; // 'count' is encapsulated and hidden
    return function() {
        count++;
        return count; // inner function still has access to 'count'
    };
}
const counter = createCounter();
console.log(counter()); // 1
console.log(counter()); // 2

// ---------------------------------------------------------
// 4. Currying
// Transforming a function with multiple arguments into a sequence of nested unary functions
const sum3 = a => b => c => a + b + c;
console.log(sum3(5)(6)(8)); // 19


// =========================================================
// TOPIC 2: ERROR HANDLING
// =========================================================



function divide(a, b) {
    if (b === 0) {
        // throw creates a custom error and stops the function execution
        throw new Error("Division by zero is not allowed!");
    }
    return a / b;
}

try {
    // Code that might throw an error goes here
    let result = divide(10, 0);
    console.log(result);
} catch (error) {
    // If an error is thrown, execution jumps to this catch block
    console.error("Error caught:", error.message);
} finally {
    // Executes ALWAYS, regardless of whether an error occurred or not
    console.log("Execution finished.");
}


// =========================================================
// TOPIC 3: UNIT TESTING (Mocha & Chai)
// =========================================================



// Note: This block should be run using Node & Mocha in a separate test file (e.g., math.test.js)
// Require Chai's expect assertion library
// const { expect } = require('chai');

// Function we are testing
const mathHelpers = { 
    add: (a, b) => a + b 
};

// describe() groups related tests together into a test suite
describe("Math Helpers Test Suite", function() {

    // it() defines a single, specific test case
    it("should return the correct sum when adding two positive numbers", function() {
        
        // 1. Arrange (Set up test data)
        let a = 5;
        let b = 10;
        
        // 2. Act (Execute the function being tested)
        let result = mathHelpers.add(a, b);
        
        // 3. Assert (Check if the result matches expectations using Chai)
        // expect(result).to.equal(15);
        // expect(result).to.be.a('number');
    });

    it("should handle negative numbers correctly", function() {
        let result = mathHelpers.add(-5, -5);
        // expect(result).to.equal(-10);
    });
});