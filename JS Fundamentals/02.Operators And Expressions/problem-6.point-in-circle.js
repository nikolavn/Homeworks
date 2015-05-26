/*
Problem 6. Point in Circle

Write an expression that checks if given point P(x, y) is within a circle K({0,0}, 5). //{0,0} is the centre and 5 is the radius
Examples:

x		y		inside
0		1		true
-5		0		true
-4		5		false
1.5		-3		true
-4		-3.5	false
100		-30		false
0		0		true
0.2		-0.8	true
0.9		-4.93	false
2		2.655	true
*/

var point1 = {
	'X': 0,
	'Y': 1
};
var point2 = {
	'X': -5,
	'Y': 0
};
var point3 = {
	'X': -4,
	'Y': 5
};
var point4 = {
	'X': 1.5,
	'Y': -3
};
var point5 = {
	'X': -4,
	'Y': -3.5
};
var point6 = {
	'X': 100,
	'Y': -30
};
var point7 = {
	'X': 0,
	'Y': 0
};
var point8 = {
	'X': 0.2,
	'Y': -0.8
};
var point9 = {
	'X': 0.9,
	'Y': -4.93
};
var point10 = {
	'X': 2,
	'Y': 2.655
};

var points = [];
var circleRadius = 5;
/*Add point objects to the array*/
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

console.log('Is point inside circle K({0,0},5)?');

for (var i = 0; i < pointsCount; i += 1) {
	var distanceFromCenter = Math.sqrt((points[i]['X'] * points[i]['X']) + (points[i]['Y'] * points[i]['Y']));

	console.log(distanceFromCenter <= circleRadius ? 
		'Point: ' + Object.keys(points[i])[0] + ':' + points[i]['X'] + ', ' + Object.keys(points[i])[1] + ':' + points[i]['Y'] + ' --> Yes.' : 
		'Point: ' + Object.keys(points[i])[0] + ':' + points[i]['X'] + ', ' + Object.keys(points[i])[1] + ':' + points[i]['Y'] + ' --> No.');
}