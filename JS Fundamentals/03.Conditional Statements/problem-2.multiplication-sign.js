/*
Problem 2. Multiplication Sign

Write a script that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
Use a sequence of if operators.
Examples:

a		b		c		result
5		2		2		+
-2		-2		1		+
-2		4		3		-
0		-2.5	4		0
-1		-0.5	-5.1	-
*/
var combinations = [{
	'a': 5,
	'b': 2,
	'c': 2
}, {
	'a': -2,
	'b': -2,
	'c': 1
}, {
	'a': -2,
	'b': 4,
	'c': 3
}, {
	'a': 0,
	'b': -2.5,
	'c': 4
}, {
	'a': -1,
	'b': -0.5,
	'c': -5.1
}];

var len = combinations.length;

for (var i = 0; i < len; i += 1) {

	if (combinations[i]['a'] === 0 || combinations[i]['b'] === 0 || combinations[i]['c'] === 0) {
		console.log("0");
	} else if (combinations[i]['a'] > 0 && combinations[i]['b'] > 0 && combinations[i]['c'] > 0) {
		console.log("+");
	} else if (combinations[i]['a'] < 0 && combinations[i]['b'] > 0 && combinations[i]['c'] > 0) {
		console.log("-");
	} else if (combinations[i]['a'] > 0 && combinations[i]['b'] < 0 && combinations[i]['c'] > 0) {
		console.log("-");
	} else if (combinations[i]['a'] > 0 && combinations[i]['b'] > 0 && combinations[i]['c'] < 0) {
		console.log("-");
	} else if (combinations[i]['a'] < 0 && combinations[i]['b'] < 0 && combinations[i]['c'] > 0) {
		console.log("+");
	} else if (combinations[i]['a'] < 0 && combinations[i]['b'] > 0 && combinations[i]['c'] < 0) {
		console.log("+");
	} else if (combinations[i]['a'] > 0 && combinations[i]['b'] < 0 && combinations[i]['c'] < 0) {
		console.log("+");
	} else if (combinations[i]['a'] < 0 && combinations[i]['b'] < 0 && combinations[i]['c'] < 0) {
		console.log("-");
	}
}