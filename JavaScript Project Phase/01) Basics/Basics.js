'use strict';

console.log('Humpty Dumpty sat on a wall,');
console.log('Humpty Dumpty had a great fall.');
console.log('All the king\'s horses and all the king\'s men');
console.log('Couldn\'t put Humpty together again.');

// Comment

/*
Comment
*/

console.log('\ndon\'t');
console.log("don't", '\n');

console.log('Fizzbuzz:');
for(let i = 1; i < 100; i++) {
    if (i % 3 === 0 && i % 5 === 0) console.log('Fizzbuzz');
    else if (i % 3 === 0) console.log('Fizz');
    else if (i % 5 === 0) console.log('Buzz');
    else console.log(i);
}
console.log('');

let size = 5;
for (let i = 1; i <= size; i++) { 
    let s = ""; 
    for (let j = 1; j <= (2 * size - 1); j++) { 
       (j >= size + 1 - i && j <= size - 1 + i) ? s += "*" : s += " "; 
     } 
    console.log(s); 
}  
