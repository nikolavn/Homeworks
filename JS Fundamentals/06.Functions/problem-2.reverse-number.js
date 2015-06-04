/*
Problem 2. Reverse number

Write a function that reverses the digits of given decimal number.
Example:

input	output
256		652
123.45	54.321
*/

var numbers = [256, 123.45];

for (var i = 0; i < numbers.length; i++) {

	console.log(numbers[i]+' reversed is: '+reverseNumber(numbers[i]));
	
}


function reverseNumber(number){
	var reversed = '';
	number = number.toString();

	for (var j = number.length - 1; j >= 0; j--) {
		reversed+=number[j];
	}

	return reversed;
}