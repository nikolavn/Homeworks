/* Task Description */
/* 
	Write a function that sums an array of numbers:
		numbers must be always of type Number
		returns `null` if the array is empty
		throws Error if the parameter is not passed (undefined)
		throws if any of the elements is not convertible to Number	

*/

function sum(array) {
	if (!array) {
		throw Error('Parameter should be passed');
	}

	if (array.map(Number).some(function(item) {
			return isNaN(item);
		})) {
		throw Error('Array contains values not convertible to Number');
	}
	
	if (!array.length) {
		return null;
	}

	return array.map(Number).reduce(function(sum, number) {
		return sum + number;
	}, 0);
}

module.exports = sum;