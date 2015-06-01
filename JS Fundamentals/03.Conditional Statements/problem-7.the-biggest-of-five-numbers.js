/*
Problem 7. The biggest of five numbers

Write a script that finds the greatest of given 5 variables.
Use nested if statements.
Examples:

a		b		c		d		e		biggest
5		2		2		4		1		5
-2		-22		1		0		0		1
-2		4		3		2		0		4
0		-2.5	0		5		5		5
-3		-0.5	-1.1	-2		-0.1	-0.1
*/	

var combinations = [{
	'a': 5,
	'b': 2,
	'c': 2,
	'd': 4,
	'e': 1
}, {
	'a': -2,
	'b': -22,
	'c': 1,
	'd': 0,
	'e': 0
}, {
	'a': -2,
	'b': 4,
	'c': 3,
	'd': 2,
	'e': 0
}, {
	'a': 0,
	'b': -2.5,
	'c': 0,
	'd': 5,
	'e': 5
}, {
	'a': -3,
	'b': -0.5,
	'c': -1.1,
	'd': -2,
	'e': -0.1
}];

var len = combinations.length;

for (var i = 0; i < len; i += 1) {
	var biggest = combinations[i]['a'];

	if (biggest < combinations[i]['b']) {
		biggest = combinations[i]['b'];
	}
	if (biggest < combinations[i]['c']) {
		biggest = combinations[i]['c'];
	}
	if (biggest < combinations[i]['d']) {
		biggest = combinations[i]['d'];
	}
	if (biggest < combinations[i]['e']) {
		biggest = combinations[i]['e'];
	}

	console.log(biggest);
}