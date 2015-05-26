/*
Problem 9. Point in Circle and outside Rectangle

Write an expression that checks for given point P(x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).
Examples:

x		y		inside K & outside of R
1		4		yes
3		2		yes
0		1		no
4		1		no
2		0		no
4		0		no
2.5		1.5		yes
3.5		1.5		yes
-100	-100	no
*/
var point1 = {
	'X': 1,
	'Y': 2
};
var point2 = {
	'X': 2.5,
	'Y': 2
};
var point3 = {
	'X': 0,
	'Y': 1
};
var point4 = {
	'X': 2.5,
	'Y': 1
};
var point5 = {
	'X': 2,
	'Y': 0
};
var point6 = {
	'X': 4,
	'Y': 0
};
var point7 = {
	'X': 2.5,
	'Y': 1.5
};
var point8 = {
	'X': 2,
	'Y': 1.5
};
var point9 = {
	'X': 1,
	'Y': 2.5
};
var point10 = {
	'X': -100,
	'Y': -100
};

var points = [];
var circleRadius = 3;

points.push(point1);
points.push(point2);
points.push(point3);
points.push(point4);
points.push(point5);
points.push(point6);
points.push(point7);
points.push(point8);
points.push(point9);
points.push(point10);

var pointsCount = points.length;

console.log('Is point inside circle K({1,1},3) and outside rectangle R(top=1, left=-1, width=6, height=2)?');

for (var i = 0; i < pointsCount; i += 1) {
	var isInCircle = false;
	var isOutRectangle = false;

	var distanceFromCenter = Math.sqrt(((1 - points[i]['X']) * (1 - points[i]['X'])) + ((1 - points[i]['Y']) * (1 - points[i]['Y'])))

	if (distanceFromCenter < (circleRadius * circleRadius)) {
		isInCircle = true;
	}

	if (points[i]['X'] < -1 || points[i]['X'] > 5 && points[i]['Y'] < -1 || points[i]['Y'] > 1) {
		isOutRectangle = true;
	}

	console.log(
		isInCircle && isOutRectangle ? 
		'Point: ' + Object.keys(points[i])[0] + ':' + points[i]['X'] + ', ' + Object.keys(points[i])[1] + ':' + points[i]['Y'] + '--> Yes.' : 
		'Point: ' + Object.keys(points[i])[0] + ':' + points[i]['X'] + ', ' + Object.keys(points[i])[1] + ':' + points[i]['Y'] + '--> No.'
		);
}