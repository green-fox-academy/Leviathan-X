'use strict';

// Write the image's url to the console.
const urlAddress = document.querySelector('a');
console.log('urlAddress', urlAddress.getAttribute('href'));

// Replace the image with a picture of your favorite animal.
const image = document.querySelector('img');
image.setAttribute('src', 'https://www.svetkomiksu.cz/_obchody/komiksy.shop5.cz/prilohy/65/socha-godzilla-vs-gigan-chou-gekizou-godzilla.jpg.big.jpg')

// Make the link point to the Green Fox Academy website.
urlAddress.setAttribute('href', 'https://www.greenfoxacademy.cz/');

// Disable the second button.
const button = document.querySelector('.this-one')
button.disabled = true;

// Replace its text with 'Don't click me!'.
button.textContent = 'Don\'t Click me!';