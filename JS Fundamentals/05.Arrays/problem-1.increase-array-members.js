/*
Problem 1. Increase array members

Write a script that allocates array of 20 integers and initializes each element by its index multiplied by 5.
Print the obtained array on the console.
*/

var array = new Array(20);

for (var i = 0; i < array.length; i += 1) {
	array[i] = 5 * i;
	console.log(array[i]);
}

