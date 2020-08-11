'use strict';

// Simple Replace
console.log('');
let starString = 'In a dishwasher far far away';

starString = starString.replace("dishwasher", "galaxy");

console.log(starString);

// Replace
console.log('');
let toBeReversed = `.eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI`;

toBeReversed = toBeReversed.split("").reverse().join("");

console.log(toBeReversed);

// URL Fixer
console.log('');
let url = 'https//www.reddit.com/r/nevertellmethebots';

url = url.replace("bots", "odds");
url = url.replace("https//", "https://");

console.log(url);

// He will never
console.log('');
let out = '';
let notSoCrypticMessage = [1, 12, 1, 2, 11, 1, 7, 11, 1, 49, 1, 3, 11, 1, 50, 11];
let hashmap = {
    7: 'run around and desert you',
    50: 'tell a lie and hurt you ',
    49: 'make you cry, ',
    2: 'let you down',
    12: 'give you up, ',
    1: 'Never gonna ',
    11: '\n',
    3: 'say goodbye '
  };

notSoCrypticMessage.forEach(function(crypt){
  out += hashmap[crypt];
})
console.log(out)

