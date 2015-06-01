/*
Problem 6. Most frequent number

Write a script that finds the most frequent number in an array.
Example:

input									result
4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3	4 (5 times)
*/

var array = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3];

var currentElement = 0,
	elementsCount = 1,
	tempCount = 1,
	indexOfMostFrequent = 0;

for (var arrayCounter = 0; arrayCounter < array.length - 1; arrayCounter++) {
	currentElement = array[arrayCounter];

	for (var subArrayCounter = arrayCounter + 1; subArrayCounter < array.length; subArrayCounter++) {
		if (array[subArrayCounter] == currentElement) {
			tempCount++;
		}

		if (tempCount > elementsCount) {
			elementsCount = tempCount;
			indexOfMostFrequent = arrayCounter;
		}
	}
	tempCount = 1;
}

console.log(array);

if (elementsCount == 1) {
	console.log("Each element appears one time.");
} else {
	console.log("Most frequent element: " + array[indexOfMostFrequent] + " (" + elementsCount + " times)");
}