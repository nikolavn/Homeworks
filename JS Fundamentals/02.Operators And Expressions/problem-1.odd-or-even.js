/*
Problem 1. Odd or Even

Write an expression that checks if given integer is odd or even.
Examples:

n	Odd?
3	true
2	false
-2	false
-1	true
0	false
*/

var numbers = [3, 2, -2, -1, 0];
var len = numbers.length;

for (var i = 0; i < len; i += 1) {
	console.log(numbers[i] % 2 === 0 ? numbers[i] + ' is even' : numbers[i] + ' is odd');
}