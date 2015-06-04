/*
Problem 4. Number of elements

Write a function to count the number of div elements on the web page
*/

function elementCounter(element) {
	var count = document.getElementsByTagName(element).length;

	return count;
}

var input = 'div';

console.log('There are ' + elementCounter(input) + ' ' + input + ' elements on the page.');