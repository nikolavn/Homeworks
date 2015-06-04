/*
Problem 6.

Write a function that groups an array of people by age, first or last name.
The function must return an associative array, with keys - the groups, and values - arrays with people in this groups
Use function overloading (i.e. just one function)

Example:

var people = {…};
var groupedByFname = group(people, 'firstname');
var groupedByAge= group(people, 'age');
*/

function groupPeople(people, groupCriteria) {
	var groupedList = [];

	for (var person in people) {
		var member = people[person][groupCriteria];
		groupedList[member] = groupedList[member] || [];
		groupedList[member].push(people[person]);
	}

	return groupedList;
}

var testListOfPeople = [{
	firstname: 'Pesho',
	lastname: 'Petrov',
	age: 21
}, {
	firstname: 'Pesho',
	lastname: 'Georgiev',
	age: 21
}, {
	firstname: 'Misho',
	lastname: 'Mihov',
	age: 44
}, {
	firstname: 'Sasho',
	lastname: 'Ivanov',
	age: 21
}, {
	firstname: 'Misho',
	lastname: 'Ivanov',
	age: 84
}];

var groupedByAge = groupPeople(testListOfPeople, 'age');
var groupedByLastName = groupPeople(testListOfPeople, 'lastname');
var groupedByFirstName = groupPeople(testListOfPeople, 'firstname');


console.log('Grouped by Age');
for (var pers in groupedByAge) {
	console.log('-------');
	console.log(groupedByAge[pers]);
}

console.log('==========');
console.log('Grouped by Last Name');
for (var pers in groupedByLastName) {
	console.log('-------');
	console.log(groupedByLastName[pers]);
}

console.log('==========');
console.log('Grouped by First Name');
for (var pers in groupedByFirstName) {
	console.log('-------');
	console.log(groupedByFirstName[pers]);
}