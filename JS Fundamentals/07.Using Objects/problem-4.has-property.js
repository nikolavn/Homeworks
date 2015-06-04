/*
Problem 4. Has property

Write a function that checks if a given object contains a given property.

var obj  = …;
var hasProp = hasProperty(obj, 'length');
*/

function hasProperty(targetObject, searchedProperty) {
	for (var property in targetObject) {
		if (property === searchedProperty) {
			return true;
		}
	}
	return false;
}

var testObjectOne = {
	fname: 'Gosho',
	lname: 'Petkov',
	weight: 180
};

var testObjectTwo = {
	fname: 'Bobcho',
	breed: 'German Shepheard',
	weight: 65
};
console.log(testObjectOne.weight);
console.log(testObjectTwo.weight);
console.log(testObjectOne, 'has property "fname" ==> ' + hasProperty(testObjectOne, 'fname'));
console.log(testObjectOne, 'has property "weight" ==> ' + hasProperty(testObjectOne, 'weight'));
console.log(testObjectTwo, 'has property "fname" ==> ' + hasProperty(testObjectTwo, 'fname'));
console.log(testObjectTwo, 'has property "weight" ==> ' + hasProperty(testObjectTwo, 'weight'));
console.log(testObjectOne, 'has property "breed" ==> ' + hasProperty(testObjectOne, 'breed'));
console.log(testObjectTwo, 'has property "lname" ==> ' + hasProperty(testObjectTwo, 'lname'));