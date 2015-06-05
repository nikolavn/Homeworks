/*
Problem 3. Deep copy

Write a function that makes a deep copy of an object.
The function should work for both primitive and reference types.
*/

function deepCopy(target) {
	if (typeof target !== 'object') {
		return target;
	}

	if (Array.isArray(target)) {
		var outputArray = [];

		for (var i = 0; i < target.length; i++) {
			outputArray[i] = target[i];
		}

		return outputArray;
	}

	var copy = {};

	for (var property in target) {
		copy[property] = deepCopy(target[property]);
	}

	return copy;
}


var testPrimitiveValue = 17;
var testArray = [1, 2, "3"];
var testObject = {
	one: "11",
	two: 2,
	three: {
		x: 1,
		y: {
			z: 8,
			p: 9
		}
	},
	four: "4"
};
var copiedPrimitiveValue = deepCopy(testPrimitiveValue);
var copiedArray = deepCopy(testArray);
var copiedObject = deepCopy(testObject);
console.log(copiedPrimitiveValue);
console.log(copiedArray);
console.log(copiedObject);