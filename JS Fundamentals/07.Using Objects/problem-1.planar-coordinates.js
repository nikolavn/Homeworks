/*
Problem 1. Planar coordinates

Write functions for working with shapes in standard Planar coordinate system.
Points are represented by coordinates P(X, Y)
Lines are represented by two points, marking their beginning and ending L(P1(X1,Y1), P2(X2,Y2))
Calculate the distance between two points.
Check if three segment lines can form a triangle.
*/

function Point(x, y) {
	if (isNaN(x) || isNaN(y)) {
		throw new Error('Points coordinates should be numbers!');
	}

	this.x = x;
	this.y = y;
}

Point.prototype.toString = function() {
	return 'P(' + this.x + ', ' + this.y + ')';
};

function Line(startPoint, endPoint) {
	if (!(startPoint instanceof Point) || !(endPoint instanceof Point)) {
		throw new Error('Line should start and end with points!');
	}

	this.startPoint = startPoint;
	this.endPoint = endPoint;
}

Line.prototype.calculateLength = function() {
	return Math.sqrt((this.startPoint.x - this.endPoint.x) * (this.startPoint.x - this.endPoint.x) +
		(this.startPoint.y - this.endPoint.y) * (this.startPoint.y - this.endPoint.y)
	);
};

Line.prototype.toString = function(){
	return 'L(' + this.startPoint.toString() + ', ' + this.endPoint.toString() + ')';
};



function Triangle(lineA, lineB, lineC) {
	if (!(lineA instanceof Line) || !(lineB instanceof Line) || !(lineC instanceof Line)) {
		throw new Error('Triangle should be made of lines!');
	}

	this.lineA = lineA;
	this.lineB = lineB;
	this.lineC = lineC;
}

Triangle.prototype.exists = function() {
	return this.lineA.calculateLength() < this.lineB.calculateLength() + this.lineC.calculateLength() &&
		this.lineB.calculateLength() < this.lineC.calculateLength() + this.lineA.calculateLength() &&
		this.lineC.calculateLength() < this.lineA.calculateLength() + this.lineB.calculateLength();
};

var point1 = new Point(4, 7),
	point2 = new Point(12, 3),
	point3 = new Point(5, 8),
	point4 = new Point(1, 10),
	point5 = new Point(32, 10),
	line1 = new Line(point1, point2),
	line2 = new Line(point2, point3),
	line3 = new Line(point3, point1),
	line4 = new Line(point4,point5);


console.log('Point 1 = '+point1.toString());
console.log('Point 2 = '+point2.toString());
console.log('Point 3 = '+point3.toString());
console.log('Point 4 = '+point4.toString());
console.log('Point 5 = '+point5.toString());
console.log('Line 1 = '+line1.toString());
console.log('Line 2 = '+line2.toString());
console.log('Line 3 = '+line3.toString());
console.log('Line 4 = '+line4.toString());
console.log('Can form triangle line 1, 2 and 3: '+new Triangle(line1,line2,line3).exists());
console.log('Can form triangle line 1, 2 and 4: '+new Triangle(line1,line2,line4).exists());