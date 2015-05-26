/*
Problem 8. Trapezoid area

Write an expression that calculates trapezoid's area by given sides a and b and height h.
Examples:

a		b		h		area
5		7		12		72
2		1		33		49.5
8.5		4.3		2.7		17.28
100		200		300		45000
0.222	0.333	0.555	0.1540125
*/
var trapezoidOne = {
	'side A': 5,
	'side B': 7,
	'height': 12
};
var trapezoidTwo = {
	'side A': 2,
	'side B': 1,
	'height': 33
};
var trapezoidThree = {
	'side A': 8.5,
	'side B': 4.3,
	'height': 2.7
};
var trapezoidFour = {
	'side A': 100,
	'side B': 200,
	'height': 300
};
var trapezoidFive = {
	'side A': 0.222,
	'side B': 0.333,
	'height': 0.555
};

var trapezoids = [];

trapezoids.push(trapezoidOne);
trapezoids.push(trapezoidTwo);
trapezoids.push(trapezoidThree);
trapezoids.push(trapezoidFour);
trapezoids.push(trapezoidFive);

var trapCount = trapezoids.length;

for (var i = 0; i < trapCount; i += 1) {
	console.log('side A:' + trapezoids[i]['side A'] + ', side B:' + trapezoids[i]['side B'] + ', Height:' +
	 trapezoids[i]['height'] + ', Area: ' + ((trapezoids[i]['side A'] + trapezoids[i]['side B']) / 2) * trapezoids[i]['height']);
}