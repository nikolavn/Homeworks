/*
Problem 1. Make person

Write a functio for creating persons.
Each person must have firstname, lastname, age and gender (true is female, false is male)
Generate an array with ten person with different names, ages and genders
*/

console.log('------====== Problem 1 ======------');

function Person(firstname,lastname,age,isFemale){
	this.firstname = firstname;
	this.lastname = lastname;
	this.age = age;
	this.isFemale = isFemale;
}

var people = [];

people.push(new Person('Georgi','Georgiev',21,false));
people.push(new Person('Petar','Petrov',16,false));
people.push(new Person('Mariya','Georgieva',25,true));
people.push(new Person('Vasil','Vasilev',41,false));
people.push(new Person('Angel','Angelov',28,false));
people.push(new Person('Mihaela','Mihailova',11,true));
people.push(new Person('Todor','Todorov',13,false));
people.push(new Person('Penka','Penkova',24,true));
people.push(new Person('Filip','Filipov',36,false));
people.push(new Person('Dimitar','Dimitrov',35,false));

console.log(people);

/*
Problem 2. People of age

Write a function that checks if an array of person contains only people of age (with age 18 or greater)
Use only array methods and no regular loops (for, while)
*/

console.log('------====== Problem 2 ======------');

var olderThan18 = people.every(function(person){
	return person.age>18;
});

var olderThan10 = people.every(function(person){
	return person.age>10;
});

console.log('All are older than 18?: '+olderThan18);
console.log('All are older than 10?: '+olderThan10);

/*
Problem 3. Underage people

Write a function that prints all underaged persons of an array of person
Use Array#filter and Array#forEach
Use only array methods and no regular loops (for, while)
*/

console.log('------====== Problem 3 ======------');

console.log('All underage: ');
var underage = people.filter(function(person){
	return person.age < 18;
}).forEach(function(person){
	console.log(person);
});

/*
Problem 4. Average age of females

Write a function that calculates the average age of all females, extracted from an array of persons
Use Array#filter
Use only array methods and no regular loops (for, while)
*/

console.log('------====== Problem 4 ======------');

var females = people.filter(function(person){
	return person.isFemale;
});

var ageOfFemales = females.reduce(function(ageSum,female){
	
	return ageSum+female.age;
},0);

console.log('Average age of females: '+ageOfFemales/females.length);

/*
Problem 5. Youngest person

Write a function that finds the youngest male person in a given array of people and prints his full name
Use only array methods and no regular loops (for, while)
Use Array#find
*/

console.log('------====== Problem 5 ======------');

if (!Array.prototype.find) {
	Array.prototype.find = function(callback) {
		var i,
			len;

		for (i = 0, len = this.length; i < len; i += 1) {
			if (callback(this[i], i, this)) {
				return this[i];
			}
		}

		return undefined;
	};
}

var youngest = people.sort(function(person1, person2) {
		return person1.age > person2.age;
	})
	.find(function(person) {
		return !person.isFemale;
	});

console.log('Youngest: '+youngest.firstname+' '+youngest.lastname);

/*
Problem 6. Group people

Write a function that groups an array of persons by first letter of first name and returns the groups as a JavaScript Object
Use Array#reduce
Use only array methods and no regular loops (for, while)
*/

console.log('------====== Problem 6 ======------');

var groupedPeople = people.reduce(function(grouped,person){
	if (grouped[person.firstname[0]]) {
		grouped[person.firstname[0]].push(person);
	}
	else{
		grouped[person.firstname[0]] = [person];
	}

	return grouped;
},{});

function sortObject(object) {
    return Object.keys(object).sort().reduce(function (result, key) {
        result[key] = object[key];
        return result;
    }, {});
}

console.log(sortObject(groupedPeople));