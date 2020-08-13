'use strict';

// Turn the party on and off by clicking the button. (the whole page)
const div = document.querySelector('div');
const button = document.querySelector('button');

let status = false;

button.onclick = () => {
    if (status === false) status = true;
    else status = false;

    const gif = document.createElement('img');
    gif.setAttribute('src', 'https://media.giphy.com/media/4c4jQPdVv381G/giphy.gif');   // Don't quite get it how to take it from the .party background

    if (status === true) {
        div.appendChild(gif);
    }
    else {
        div.removeChild(gif);   // Doesn't work for some reason - "The node to be removed is not a child of this node." WHUT?
    }
};
