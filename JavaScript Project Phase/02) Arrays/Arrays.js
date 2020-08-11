
// Print elements
let nums1 = [4, 5, 6, 7,];

console.log(nums1);

console.log('');
for (let num of nums1) {
    process.stdout.write(`${num}, `);
}

console.log('');
nums1.forEach(function(num) {
    process.stdout.write(`${num}, `);
});

// Change element
console.log('');
let nums2 = [1, 2, 3, 8, 5, 6].map(function(num) {
    if (num === 8) return 4;
    return num;
})
console.log(nums2);

// Append A
console.log('');
let animals = ["koal", "pand", "zebr"];

for (let i = 0; i < animals.length; i++) {
    animals[i] += "a";
}
console.log(animals);

// Colors
console.log('');
let colors = [
    ["lime", "forest green", "olive", "pale green", "spring green"],
    ["orange red", "red", "tomato"],
    ["orchid", "violet", "pink", "hot pink"]
]

console.log(colors[0]);
console.log(colors[1]);
console.log(colors[2]);
console.log(colors[0][4]);

// Sum
console.log('');
let nums3 = [3, 4, 5, 6, 7];
let sum = 0;

for(let num of nums3) {
    sum += num;
}
console.log(sum);

// Matrix
console.log('');

let matrix = [4][4];
