/*
Problem 4. Sort 3 numbers

Sort 3 real values in descending order.
Use nested if statements.
Note: Don’t use arrays and the built-in sorting functionality.

Examples:

a		b		c		result
5		1		2		5 2 1
-2		-2		1		1 -2 -2
-2		4		3		4 3 -2
0		-2.5	5		5 0 -2.5
-1.1	-0.5	-0.1	-0.1 -0.5 -1.1
10		20		30		30 20 10
1		1		1		1 1 1
*/

var combinations = [{
	'a': 5,
	'b': 1,
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
	'a': -1.1,
	'b': -0.5,
	'c': -0.1
}, {
	'a': 10,
	'b': 20,
	'c': 30
}, {
	'a': 1,
	'b': 1,
	'c': 1
}];

var len = combinations.length;

for (var i = 0; i < len; i += 1) {

	if (combinations[i]['a'] >= combinations[i]['b'] && combinations[i]['a'] >= combinations[i]['c']) {
		if (combinations[i]['b'] >= combinations[i]['c']) {
			console.log(combinations[i]['a'] + " " + combinations[i]['b'] + " " + combinations[i]['c']);
		} else {
			console.log(combinations[i]['a'] + " " + combinations[i]['c'] + " " + combinations[i]['b']);
		}
	} else if (combinations[i]['b'] >= combinations[i]['a'] && combinations[i]['b'] >= combinations[i]['c']) {
		if (combinations[i]['a'] >= combinations[i]['c']) {
			console.log(combinations[i]['b'] + " " + combinations[i]['a'] + " " + combinations[i]['c']);
		} else {
			console.log(combinations[i]['b'] + " " + combinations[i]['c'] + " " + combinations[i]['a']);
		}
	} else if (combinations[i]['c'] >= combinations[i]['a'] && combinations[i]['c'] >= combinations[i]['b']) {
		if (combinations[i]['a'] >= combinations[i]['b']) {
			console.log(combinations[i]['c'] + " " + combinations[i]['a'] + " " + combinations[i]['b']);
		} else {
			console.log(combinations[i]['c'] + " " + combinations[i]['b'] + " " + combinations[i]['a']);
		}
	}
}