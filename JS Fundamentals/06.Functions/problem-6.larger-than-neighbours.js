/*
Problem 6. Larger than neighbours

Write a function that checks if the element at given position in given array of integers is bigger than 
its two neighbours (when such exist).
*/


function compareToNeighbours(array, elmentIndex) {
	if (elmentIndex < 0 || elmentIndex > array.length) {
		console.log('Element is outside array!');
		return;
	}

	if (elmentIndex === 1 || elmentIndex === array.length - 1) {
		console.log('Element doesn\'t have 2 neighbours!');
		return;
	}

	if (array[elmentIndex] > array[elmentIndex - 1] && array[elmentIndex] > array[elmentIndex + 1]) {
		console.log('Element '+array[elmentIndex]+' is bigger than both neighbours '+array[elmentIndex - 1]+' and '+array[elmentIndex + 1]);
	} else {
		console.log('Element '+array[elmentIndex]+' is smaller than one or both neighbours '+array[elmentIndex - 1]+' and '+array[elmentIndex + 1]);
	}
}

var array = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3];
var elementAtIndex = 3;

compareToNeighbours(array, elementAtIndex);