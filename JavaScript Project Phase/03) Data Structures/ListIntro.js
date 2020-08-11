'use strict';

// -- Pt. 1 --
console.log('');

// Create an empty list which will contain names (strings)
let names = [];

// Print out the number of elements in the list
console.log(names.length);

// Add William to the list
names.push('William');

// Print out whether the list is empty or not
console.log(names[0] !== undefined);

// Add John to the list
// Add Amanda to the list
names.push('John');
names.push('Amanda');

// Print out the number of elements in the list
console.log(names.length);

// Print out the 3rd element
console.log(names[2]);

// Iterate through the list and print out each name
console.log('');
names.forEach(name => {
console.log(name);
});

// Iterate through the list and print
console.log('');
for (let i = 0; i < names.length; i++) {
    console.log(`${i+1}. ${names[i]}`);
}

// Remove the 2nd element
// delete names[1];
names.splice(1, 1);

// Iterate through the list in a reversed order and print out each name
console.log('');
names.reverse().forEach(name => {
console.log(name);
});

// Remove all elements
console.log(names);

console.log('');
names = [];
console.log(names[0] !== undefined);

// -- Pt. 2 --
let listA = []
listA.push('Apple', 'Avocado', 'Blueberries', 'Durian', 'Lychee');

// Create a new list ('List B') with the values of List A
let listB = [...listA];

console.log(listA);
console.log(listB);

// Print out whether List A contains Durian or not
console.log(listA.includes('Durian'));

// Remove Durian from List B
listB.splice(3, 1);

// Add Kiwifruit to List A after the 4th element
listB.splice(4, 0, 'Kiwifruit');

// Compare the size of List A and List B
console.log('');
if (listA.length > listB.length) console.log('listA is bigger');
else if (listA.length < listB.length) console.log('listB is bigger');
else if (listA.length === listB.length) console.log('lists have same size');
else console.log('Fuck! Error!');

// Get the index of Avocado from List A
// Get the index of Durian from List B
console.log('');
console.log(listA.indexOf('Avocado'));
console.log(listB.indexOf('Durian'));

// Add Passion Fruit and Pomelo to List B in a single statement
listB.push('Passion Fruit', 'Pomelo');

// Print out the 3rd element from List A
console.log(listA[2]);