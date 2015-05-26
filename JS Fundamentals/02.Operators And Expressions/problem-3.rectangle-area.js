/*
Problem 3. Rectangle area

Write an expression that calculates rectangle’s area by given width and height.
Examples:

width	height	area
3		4		12
2.5		3		7.5
5		5		25
*/

var rectangleOne = {
	'width': 3,
	'height': 4
};
var rectangleTwo = {
	'width': 2.5,
	'height': 3
};
var rectangleThree = {
	'width': 5,
	'height': 5
};

var rectangles = [];
/*Add rectangles to the array*/
rectangles.push(rectangleOne);
rectangles.push(rectangleTwo);
rectangles.push(rectangleThree);

var rectCount = rectangles.length;

for (var i = 0; i < rectCount; i += 1) {
	console.log('Width:' + rectangles[i]['width'] + ', Height:' + rectangles[i]['height'] +
		', Area: ' + rectangles[i]['width'] * rectangles[i]['height']);
}