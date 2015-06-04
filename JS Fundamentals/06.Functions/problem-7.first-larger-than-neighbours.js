/*
Problem 7. First larger than neighbours

Write a function that returns the index of the first element in array that is larger than its neighbours or -1, if there’s no such element.
Use the function from the previous exercise.
*/
function compareToNeighbours(array,elementIndex){
	if (array[elementIndex] > array[elementIndex - 1] && array[elementIndex] > array[elementIndex + 1])
        {
            return true;
        }
        else
        {
            return false;
        }
}


var array = [4, 1, 1, 0, 2, 3, 4, 4, 1, 2, 4, 9, 3 ];
var counter = 1;
isFound = false;

while (!isFound&&counter<array.length)
        {
            isFound = compareToNeighbours(array, counter);
            counter++;
        }
 if (counter!=array.length)
        {
            console.log('First element larger than neighbours is at index: '+(counter-1));
        }
        else
        {
            console.log(-1);
        }
