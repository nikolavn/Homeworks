/*
Problem 2. Numbers not divisible

Write a script that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time
*/

var end = 65;

for (var i = 0; i < end; i+=1) {
	if (i%21!==0) {
		console.log(i);
	}
}
