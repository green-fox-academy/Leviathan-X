'use strict';

const content = document.querySelectorAll('p');

// If the fourth p has a 'dolphin' class, replace apple's content with 'pear'
if (content[3].classList.contains('dolphin')) {
    content[0].textContent = 'pear';
}

// If the first p has an 'apple' class, replace cat's content with 'dog'
if (content[0].classList.contains('apple')) {
    content[2].textContent = 'dog';
}

// Make apple red by adding a .red class
content[0].classList.add('red');

// Make balloon less balloon-like (change its shape)
content[1].classList.remove('balloon');

//
content.forEach(e => {
    console.log('content', e);
})