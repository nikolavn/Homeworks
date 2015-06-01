/*
Problem 2. Lexicographically comparison

Write a script that compares two char arrays lexicographically (letter by letter).
*/

var charArray1 = 'Velociraptor';
var charArray2 = 'Velociriptor';

if (charArray1.length !== charArray2.length) {
	console.log('Arrays "%s" and "%s" are not equal', charArray1, charArray2);
} else {
	var areEqual = true;
	for (var i = 0; i < charArray1.length; i += 1) {
		if (charArray1[i] !== charArray2[i]) {
			areEqual = false;
		}
	}
	console.log(areEqual ? 'Arrays "%s" and "%s" are equal' : 'Arrays "%s" and "%s" are not equal', charArray1, charArray2);
}