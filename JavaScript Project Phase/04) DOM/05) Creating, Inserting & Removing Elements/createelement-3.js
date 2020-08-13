'use strict';

const petsList = document.querySelector('#pets');

const kids = [
    { 'petName': 'Wattled crane', 'owner': 'Bryant' },
    { 'petName': 'Devil, tasmanian', 'owner': 'Alejandro' },
    { 'petName': 'Mynah, common', 'owner': 'Nelie' },
    { 'petName': 'Dolphin, common', 'owner': 'Mariele' },
    { 'petName': 'Gray duiker', 'owner': 'Maddalena' },
    { 'petName': 'Crab (unidentified)', 'owner': 'Lucine' },
    { 'petName': 'Ant (unidentified)', 'owner': 'Lorianna' },
    { 'petName': 'Bison, american', 'owner': 'Tommie' },
    { 'petName': 'Yellow mongoose', 'owner': 'Vivyan' },
    { 'petName': 'Carpet snake', 'owner': 'Veda' },
    { 'petName': 'Lesser mouse lemur', 'owner': 'Isidor' },
  ];

const owners = []
Array.from(kids).forEach(input => {
    // 1) Create an <article> element for each kid
    const newKid = document.createElement('article');
    //newKid.textContent = input.owner;

    // 2) Create a <h3> and a <p> element for each article and append them as a child to the <article>
    //       - The H3 should contain the owner's name
    //       - The p should contain the pet's name
    const newH3 = document.createElement('h3');
    newH3.textContent = input.owner;
    const newP = document.createElement('p');
    newP.textContent = input.petName;
    
    newKid.appendChild(newH3);
    newKid.appendChild(newP);

    owners.push(newKid);
})

// 3) Add the article to the pets div.
Array.from(owners).forEach(input => {
  petsList.appendChild(input);
})