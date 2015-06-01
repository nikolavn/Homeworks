/*
Problem 3. The biggest of Three

Write a script that finds the biggest of three numbers.
Use nested if statements.
Examples:

a		b		c		biggest
5		2		2		5
-2		-2		1		1
-2		4		3		4
0		-2.5	5		5
-0.1	-0.5	-1.1	-0.1
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
	'c': 5
}, {
	'a': -0.1,
	'b': -0.5,
	'c': -1.1
}];

var len = combinations.length;

for (var i = 0; i < len; i += 1) {

	if (combinations[i]['a'] > combinations[i]['b'] && combinations[i]['a'] > combinations[i]['c']) {
		console.log(combinations[i]['a']);
	} else if (combinations[i]['b'] > combinations[i]['a'] && combinations[i]['b'] > combinations[i]['c']) {
		console.log(combinations[i]['b']);
	} else if (combinations[i]['c'] > combinations[i]['a'] && combinations[i]['c'] > combinations[i]['b']) {
		console.log(combinations[i]['c']);
	}
}