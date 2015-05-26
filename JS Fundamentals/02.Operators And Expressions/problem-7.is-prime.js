/*
Problem 7. Is prime

Write an expression that checks if given positive integer number n (n ≤ 100) is prime.
Examples:

n	Prime?
1	false
2	true
3	true
4	false
9	false
37	true
97	true
51	false
-3	false
0	false
*/

var numbers = [1, 2, 3, 4, 9, 37, 97, 51, -3, 0];
var len = numbers.length;

for (var i = 0; i < len; i += 1) {
	var isPrime = true;
	if (numbers[i] < 2) {isPrime = false;} 
	else if (numbers[i] === 2) {} 
	else {
		for (var j = 2; j <= Math.ceil(Math.sqrt(numbers[i])); j += 1) {
			if (numbers[i] % j === 0){ isPrime = false;}
		}
	}

	console.log(isPrime ? numbers[i] + ' is prime.' : numbers[i] + ' isn\'t prime.');
}