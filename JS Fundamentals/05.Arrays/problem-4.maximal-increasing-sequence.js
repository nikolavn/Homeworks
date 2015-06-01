/*
Problem 4. Maximal increasing sequence

Write a script that finds the maximal increasing sequence in an array.
Example:

input					result
3, 2, 3, 4, 2, 2, 4		2, 3, 4
*/

var array = [3, 2, 3, 4, 2, 3, 4, 5, 6, 2, 4];
var maxSequenceLength = 0,
	sequenceLastMemberID = 0,
	tempSequence = 1;

for (var counter = 1; counter < array.length; counter++) {
	if (array[counter] > array[counter - 1]) {
		tempSequence++;
	} else {
		if (tempSequence > maxSequenceLength) {
			maxSequenceLength = tempSequence;
			sequenceLastMemberID = counter - 1;
		}
		tempSequence = 1;
	}

}

console.log(array);
console.log("Maximum sequence length: " + maxSequenceLength);

var output = "";

for (var i = sequenceLastMemberID - maxSequenceLength + 1; i <= sequenceLastMemberID; i++) {
	if (i == sequenceLastMemberID) {
		output += array[i];
	} else {
		output += array[i] + ",";
	}
}
console.log("Maximum sequence -> "+output);