/*
Problem 4. Third digit

Write an expression that checks for given integer if its third digit (right-to-left) is 7.
Examples:

n		Third digit 7?
5		false
701		true
1732	true
9703	true
877		false
777877	false
9999799	true
*/

var numbers = [5, 701, 1732, 9703, 877, 777877, 9999799];
var len = numbers.length;

console.log('Is third digit R->L 7?');

for (var i = 0; i < len; i += 1) {
	if ((numbers[i] / 100 | 0) === 0) {
		console.log(numbers[i] + ' --> No.');
	} else {
		var divided = (numbers[i] / 100 | 0);
		if (divided % 10 === 7) {
			console.log(numbers[i] + ' --> Yes.');
		} else {
			console.log(numbers[i] + ' --> No.');
		}
	}
}