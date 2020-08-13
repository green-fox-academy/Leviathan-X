'use strict';
const asteroidList = document.querySelector('ul.asteroids');

// Remove the king from the list.
const king = document.querySelector('li');
asteroidList.removeChild(king);

// Fill the list based on the following list of objects.
// Only add the asteroids to the list.
// Each list item should have its category as a class and its content as text content.
const planetData = [
    {
      category: 'inhabited',
      content: 'Foxes',
      asteroid: true,
    },
    {
      category: 'inhabited',
      content: 'Whales and Rabbits',
      asteroid: true,
    },
    {
      category: 'uninhabited',
      content: 'Baobabs and Roses',
      asteroid: true,
    },
    {
      category: 'inhabited',
      content: 'Giant monsters',
      asteroid: false,
    },
    {
      category: 'inhabited',
      content: 'Sheep',
      asteroid: true,
    },
  ];
Array.from(planetData).forEach(planetInput => {
    const newPlanet = document.createElement('li');
    newPlanet.className = planetInput.category;
    newPlanet.textContent = planetInput.content;
    console.log(newPlanet);

    if (planetInput.asteroid === true) {
        asteroidList.appendChild(newPlanet);
    }
})
