/*
Problem 5. Appearance count

Write a function that counts how many times given number appears in given array.
Write a test function to check if the function is working correctly.
*/

function appearanceCount(array, number) {
	var count = 0;

	for (var i = 0; i < array.length; i++) {
		if (array[i] === number) {
			count++;
		}
	}

	return count;
}

var testCases = {
	testCase1: {
		array: [1, 2, 3, 4, 5, 6, 7, 8, 9, 3, 4, 1, 2, 3, 4, 5123, 123, 12, -1, 0, 223],
		number: 4,
		occurances: 3
	},
	testCase2: {
		array: [1, 2, 3, 4, 5, 6, 7, 8, 9, 3, 4, 1, 2, 3, 4, 5123, 123, 12, -1, 0, 223],
		number: 1,
		occurances: 2
	},
	testCase3: {
		array: [1, 2, 3, 4, 5, 6, 7, 8, 9, 3, 4, 1, 2, 3, 4, 5123, 123, 12, -1, 0, 223],
		number: 9,
		occurances: 1
	},
	testCase4: {
		array: [1, 2, 3, 4, 5, 6, 7, 8, 9, 3, 4, 1, 2, 3, 4, 5123, 123, 12, -1, 0, 223],
		number: -1,
		occurances: 1
	}
};

function test(tests) {
	for (var testCase in tests) {
		var currentTest = tests[testCase];

		console.log('\nTest array:' + currentTest.array +
			'\nNumber to find: ' + currentTest.number +
			'\nExpected output: ' + currentTest.occurances +
			'\nCalculated output: ' + appearanceCount(currentTest.array, currentTest.number));
	}
}

test(testCases);