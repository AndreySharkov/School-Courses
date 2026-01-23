let numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

let multiplied = numbers.map(num => num * 2);
console.log('Масив с умножени числа:', multiplied);

let evenNumbers = numbers.filter(num => num % 2 === 0);
console.log('Масив с четни числа:', evenNumbers);

let sum = numbers.reduce((total, num) => total + num, 0);
console.log('Сума на числата:', sum);
