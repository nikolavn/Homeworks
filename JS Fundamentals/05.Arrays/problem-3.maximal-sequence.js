/*
Problem 3. Maximal sequence

Write a script that finds the maximal sequence of equal elements in an array.
Example:

input							result
2, 1, 1, 2, 3, 3, 2, 2, 2, 1	2, 2, 2
*/

var array = [1, 1, 1, 1, 1, 2, 3, 3, 3, 2, 2, 2, 2];

var maxSequenceLength = 1,
	currentElement = array[0],
	maxSequenceElement = 0,
	tempSequenceLength = 0;

for (var counter = 0; counter < array.length; counter++) {
	if (array[counter] == currentElement) {
		tempSequenceLength++;

		if (counter == array.length - 1) /*ensures sequence will be caught if is in the end of array*/ {
			if (tempSequenceLength > maxSequenceLength) {
				maxSequenceLength = tempSequenceLength;
				maxSequenceElement = currentElement;
			}
		}
	} else {
		if (tempSequenceLength > maxSequenceLength) {
			maxSequenceLength = tempSequenceLength;
			maxSequenceElement = currentElement;
		}
		tempSequenceLength = 1;
		currentElement = array[counter];
	}
}

console.log("Max sequence length: " + maxSequenceLength);

var output = "";

for (var k = 0; k < maxSequenceLength; k++) {
	output += maxSequenceElement + " ";

}

console.log(array + " --> " + output);