'use strict';

// 1)  Fill every paragraph with the last one's content.
const content = document.querySelectorAll('p');
//content.forEach(e => {
//    console.log('content', e);
//    e.textContent = content[3].textContent;
//});

// 2)  Do the same again, but you should keep the cat strong.
content.forEach(e => {
    console.log('content', e);
    e.innerHTML = content[3].innerHTML;
});