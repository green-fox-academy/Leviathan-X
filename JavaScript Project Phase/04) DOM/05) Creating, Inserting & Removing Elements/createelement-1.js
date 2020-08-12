'use strict';

const asteroidList = document.querySelector('ul.asteroids');

// Add an item that says 'The Green Fox' to the asteroid list.
const newAsteroid1 = document.createElement('li');
newAsteroid1.textContent = 'The Green Fox';
asteroidList.appendChild(newAsteroid1);

// Add an item that says 'The Lamplighter' to the asteroid list.
const newAsteroid2 = document.createElement('li');
newAsteroid2.textContent = 'The Lamplighter';
asteroidList.appendChild(newAsteroid2);

// Add a heading saying 'I can add elements to the DOM!' to the .container.
const containerList = document.querySelector('.container');

const newContainer = document.createElement('h1');
newContainer.textContent = 'I can add elements to the DOM!';
containerList.appendChild(newContainer);

// Add an image, any image, to the container.
const newContainer2 = document.createElement('img');
newContainer2.setAttribute('src', 'https://1gr.cz/fotky/idnes/19/122/r6/JOB801240_GettyImages_938641604.jpg');
containerList.appendChild(newContainer2);
