'use strict';

// 1. store the element that says 'The King' in the 'king' variable.
// console.log it.
const king = document.getElementById('b325');
console.log('king', king);

// 2. store 'The Businessman' and 'The Lamplighter'
// in the 'businessLamp' variable.
// console.log each of them.
const businessLamp = document.querySelectorAll('.asteroid.big');
Array.from(businessLamp).forEach(e => {
    console.log('businessLamp', e);
});

// 3. store 'The King' and 'The Conceited Man'
// in the 'conceitedKing' variable.
// alert them one by one.
const conceitedKing = document.querySelectorAll('section.container');
Array.from(conceitedKing).forEach(e => {
    console.log('conceitedKing', e);
    alert(e.textContent);
});

// 4. store 'The King', 'The Conceited Man' and 'The Lamplighter'
// in the 'noBusiness' variable.
// console.log each of them.
const noBusiness = document.querySelectorAll('div.asteroid');
Array.from(noBusiness).forEach(e => {
    console.log('noBusiness', e);
});
