/*
Problem 2. Divisible by 7 and 5

Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.
Examples:

n	Divided by 7 and 5?
3	false
0	true
5	false
7	false
35	true
140	true
*/

var numbers = [3, 0, 5, 7, 35, 140];
var len = numbers.length;

console.log('Divides by 5 and 7 at the same time:');

for (i = 0; i < len; i += 1) {
	console.log(numbers[i] % 35 === 0 ?
		numbers[i] + ' --> true' :
		numbers[i] + ' --> false');
}