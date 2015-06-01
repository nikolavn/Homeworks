/*
Problem 6. Quadratic equation

Write a script that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
Calculates and prints its real roots.
Note: Quadratic equations may have 0, 1 or 2 real roots.

Examples:

a		b		c		roots
2		5		-3		x1=-3; x2=0.5
-1		3		0		x1=3; x2=0
-0.5	4		-8		x1=x2=4
5		2		8		no real roots
*/
var combinations = [{
	'a': 2,
	'b': 5,
	'c': -3
}, {
	'a': -1,
	'b': 3,
	'c': 0
}, {
	'a': -0.5,
	'b': 4,
	'c': -8
}, {
	'a': 0,
	'b': -2.5,
	'c': 5
}, {
	'a': 5,
	'b': 2,
	'c': 8
}];

var len = combinations.length;

for (var i = 0; i < len; i += 1) {

	if (combinations[i]['a'] == 0) {
		console.log("The equation has one root: x= %d", -combinations[i]['c'] / combinations[i]['b']);
	} else {
		
		if ((combinations[i]['b'] == 0) && ((combinations[i]['c'] < 0 && combinations[i]['a'] > 0) || (combinations[i]['a'] < 0 && combinations[i]['c'] > 0))) {
			console.log("The equation has 2 roots: x1= %d and x2= -%d", Math.sqrt(-(combinations[i]['c'] / combinations[i]['a'])));
		} else {
			
			if (combinations[i]['b'] == 0 && combinations[i]['c'] == 0) {
				console.log("The Equation has one root: x=0");
			} else {
				
				if (combinations[i]['c'] == 0) {
					console.log("The equation has 2 roots: x1= 0 and x2= %d", -combinations[i]['b'] / combinations[i]['a']);
				} else {
					
					var discriminant = combinations[i]['b'] * combinations[i]['b'] - 4 * combinations[i]['a'] * combinations[i]['c'];
					
					if (discriminant < 0) {
						console.log("The equation doesn't have real roots");
					} else {
						
						if (discriminant == 0) {
							console.log("The equation has only one root: x= %d", -combinations[i]['b'] / 2 * combinations[i]['a']);
						} else {
							var root1 = (-combinations[i]['b'] - Math.sqrt(discriminant)) / (2 * combinations[i]['a']);
							var root2 = (-combinations[i]['b'] + Math.sqrt(discriminant)) / (2 * combinations[i]['a']);
							console.log("The roots of the equation are: x1= %d and x2= %d", root1, root2);
						}
					}
				}
			}
		}
	}
}