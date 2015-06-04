/*
Problem 2. Remove elements

Write a function that removes all elements with a given value.
Attach it to the array type.
Read about prototype and how to attach methods.

var arr = [1,2,1,4,1,3,4,1,111,3,2,1,'1'];
arr.remove(1); //arr = [2,4,3,4,111,3,2,'1'];
*/

Array.prototype.removeElement = function (element){
	var output = [];

	for (var index = 0; index < this.length; index+=1) {
		if (this[index]!==element) {
			output.push(this[index]);
		}
	}

	return output;
};

var inputArray = [1,2,1,4,1,3,4,1,111,3,2,1,'1'];

console.log('Initial array: '+inputArray);
inputArray = inputArray.removeElement(1);
console.log('Initial array w/o number 1: '+inputArray);

