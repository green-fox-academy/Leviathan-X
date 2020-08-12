'use strict';

const content = document.querySelectorAll('li');
content.forEach(e => {
    console.log('content', e);
});

// 1) replace the list items' content with items from this list:
// ['apple', 'banana', 'cat', 'dog']
let newContent = ['apple', 'banana', 'cat', 'dog'];
newContent.forEach(e => {
    console.log('newContent', e);
});

for (let i = 0; i < content.length; i++) {
    content[i].textContent = newContent[i];
}

// 2) change the <ul> element's background color to 'limegreen'
// - use css class to change the color instead of the style property

