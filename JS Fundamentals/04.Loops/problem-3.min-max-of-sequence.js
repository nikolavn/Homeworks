/*
Problem 3. Min/Max of sequence

Write a script that finds the max and min number from a sequence of numbers.
*/

var sequence = [5,13,45,3,43,21,145,12,56,76,34,32,123,82];
var min = Number.MAX_VALUE;
var max = Number.MIN_VALUE;

for (var i = 0; i < sequence.length; i+=1) {	
	if (sequence[i]>max) {
		max = sequence[i];
	}
	if (sequence[i]<min) {
		min = sequence[i];
	}
}

console.log('Min: %d, max: %d',min,max);