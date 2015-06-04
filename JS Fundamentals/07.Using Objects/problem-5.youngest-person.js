/*
Problem 5. Youngest person

Write a function that finds the youngest person in a given array of people and prints his/hers full name
Each person has properties firstname, lastname and age.

Example:

var people = [
  { firstname : 'Gosho', lastname: 'Petrov', age: 32 }, 
  { firstname : 'Bay', lastname: 'Ivan', age: 81},… ];
*/

function findYoungestPerson(people) {
	var minimumAge = Number.MAX_VALUE;
	var indexOfYoungestPerson = 0;

	for (var index = 0; index < people.length; index++) {
		if (people[index].age < minimumAge) {
			minimumAge = people[index].age;
			indexOfYoungestPerson = index;
		}
	}

	return 'Youngest person: ' +
		people[indexOfYoungestPerson].firstname + " " +
		people[indexOfYoungestPerson].lastname + " " +
		people[indexOfYoungestPerson].age;
}

var testListOfPeople = [{
	firstname: 'Pesho',
	lastname: 'Petrov',
	age: 21
}, {
	firstname: 'Gosho',
	lastname: 'Georgiev',
	age: 13
}, {
	firstname: 'Misho',
	lastname: 'Mihov',
	age: 44
}, {
	firstname: 'Sasho',
	lastname: 'Sashev',
	age: 2
}, {
	firstname: 'Ivan',
	lastname: 'Ivanov',
	age: 84
}]

console.log(findYoungestPerson(testListOfPeople));