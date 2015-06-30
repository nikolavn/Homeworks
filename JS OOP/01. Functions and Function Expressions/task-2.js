/* Task description */
/*
	Write a function a function that finds all the prime numbers in a range
		1) it should return the prime numbers in an array
		2) it must throw an Error if any on the range params is not convertible to `string`
		3) it must throw an Error if any of the range params is missing
*/

function findPrimes(start, end) {
	if (arguments.length < 2) {
		throw new Error('You must have both start and end of range');
	}

	if (isNaN(Number(start) || isNaN(Number(end)))) {
		throw new Error('Start and end of range have to be numbers');
	}

	var primes = [];

	start = +start;
	end = +end;

	for (var i = start; i <= end; i += 1) {
		if (isPrime(i)) {
			primes.push(i);
		}
	}

	return primes;
}

module.exports = findPrimes;

function isPrime(number) {
	var isPrimeNumber = true;
	if (number < 2) {
		isPrimeNumber = false;
	} else if (number === 2) {} else {
		for (var j = 2; j <= Math.ceil(Math.sqrt(number)); j += 1) {
			if (number % j === 0) {
				isPrimeNumber = false;
			}
		}
	}

	return isPrimeNumber;
}