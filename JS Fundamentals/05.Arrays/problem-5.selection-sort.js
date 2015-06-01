/*
Problem 5. Selection sort

Sorting an array means to arrange its elements in increasing order.
Write a script to sort an array.
Use the selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
Hint: Use a second array
*/

var array = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3];


console.log("Unsorted array:");
console.log(array);

for (var counter = 0; counter < array.length - 1; counter++) {
	var temp = 0;

	for (var i = counter + 1; i < array.length; i++) {
		if (array[counter] > array[i]) {
			temp = array[counter];
			array[counter] = array[i];
			array[i] = temp;
		}
	}
}

console.log("Sorted array:");
console.log(array);