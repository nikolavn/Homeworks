/*
Problem 1. English digit

Write a function that returns the last digit of given integer as an English word.
Examples:

input	output
512		two
1024	four
12309	nine
*/

var numbers = [512, 1024, 12309, 5173, 9012731, 6, 56197, '126b'];


for (var i = 0; i < numbers.length; i += 1) {
	console.log('Last digit of ' + numbers[i] + ' is ' + lastDigit(numbers[i]));
}


function lastDigit(number) {
	var digit = number % 10;
	var digitAsText = '';

	switch (digit) {
		case 0:
			digitAsText = 'zero';
			break;
		case 1:
			digitAsText = 'one';
			break;
		case 2:
			digitAsText = 'two';
			break;
		case 3:
			digitAsText = 'three';
			break;
		case 4:
			digitAsText = 'four';
			break;
		case 5:
			digitAsText = 'five';
			break;
		case 6:
			digitAsText = 'six';
			break;
		case 7:
			digitAsText = 'seven';
			break;
		case 8:
			digitAsText = 'eight';
			break;
		case 9:
			digitAsText = 'nine';
			break;
		default:
			digitAsText = 'not a digit';
			break;
	}

	return digitAsText;
}