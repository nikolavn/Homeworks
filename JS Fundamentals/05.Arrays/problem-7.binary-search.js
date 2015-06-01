/*
Problem 7. Binary search

Write a script that finds the index of given element in a sorted array of integers by using the binary search algorithm.
*/

var array = [1, 2, 3, 11, 17, 25, 34, 42, 46, 4, 5, 7, 9, 11, 17];

var elementToFind = 25,
	foundAtIndex = 0;
var isFound = false;
var startIndex = 0;
var sortedArray = sortArray(array);
console.log(sortedArray);

var endIndex = sortedArray.length;

while ((startIndex <= endIndex) && !isFound) {
	var elementIndex = Math.floor((startIndex + endIndex) / 2);

	if (sortedArray[elementIndex] == elementToFind) {
		foundAtIndex = elementIndex;
		isFound = true;

	} else if (sortedArray[elementIndex] > elementToFind) {
		endIndex = elementIndex - 1;
	} else {
		startIndex = elementIndex + 1;
	}
}

if (foundAtIndex !== 0) {
	console.log("Element " + elementToFind + " is found at index: " + foundAtIndex + " (position: " + (foundAtIndex + 1) + ")");
} else {
	console.log("Element not found!");
}

function sortArray(array) {
	var temp;

	for (var counter = 0; counter < array.length - 1; counter++) {
		for (var i = counter + 1; i < array.length; i++) {
			if (array[counter] > array[i]) {
				temp = array[counter];
				array[counter] = array[i];
				array[i] = temp;
			}
		}
	}

	return array;
}