/* Task Description */
/* 
	Create a function constructor for Person. Each Person must have:
	*	properties `firstname`, `lastname` and `age`
		*	firstname and lastname must always be strings between 3 and 20 characters, containing only Latin letters
		*	age must always be a number in the range 0 150
			*	the setter of age can receive a convertible-to-number value
		*	if any of the above is not met, throw Error 		
	*	property `fullname`
		*	the getter returns a string in the format 'FIRST_NAME LAST_NAME'
		*	the setter receives a string is the format 'FIRST_NAME LAST_NAME'
			*	it must parse it and set `firstname` and `lastname`
	*	method `introduce()` that returns a string in the format 'Hello! My name is FULL_NAME and I am AGE-years-old'
	*	all methods and properties must be attached to the prototype of the Person
	*	all methods and property setters must return this, if they are not supposed to return other value
		*	enables method-chaining
*/
function solve() {
	var Person = (function () {
		function Person(firstname, lastname, age) {
			this.firstname = firstname;
			this.lastname = lastname;
			this.age = age;
		}

		Object.defineProperty(Person.prototype, 'firstname', {
			get: function () {
				return this._firstname;
			},
			set: function (value) {
				if (isValidName(value)) {
					this._firstname = value;
					return this;
				}
				else {
					throw new Error('First name should be 3 to 20 symbols and only letters');
				}
			}
		});

		Object.defineProperty(Person.prototype, 'lastname', {
			get: function () {
				return this._lastname;
			},
			set: function (value) {
				if (isValidName(value)) {
					this._lastname = value;
					return this;
				}
				else {
					throw new Error('Last name should be 3 to 20 symbols and only letters');
				}
			}
		});

		Object.defineProperty(Person.prototype, 'age', {
			get: function () {
				return this._age;
			},
			set: function (value) {
				if (isValidAge(value)) {
					this._age = value;
					return this;
				}
				else {
					throw new Error('Age has to be valid number greater than 0 and less than 150.');
				}
			}
		});

		Object.defineProperty(Person.prototype, 'fullname', {
			get: function () {
				return this.firstname + ' ' + this.lastname;
			},
			set: function (value) {
				var fullName = value.split(' ');
				this.firstname = fullName[0];
				this.lastname = fullName[1];
				return this;
			}
		});

		Person.prototype.introduce = function () {
			return 'Hello! My name is ' + this.fullname + ' and I am ' + this.age + '-years-old';
		}

		return Person;
	} ());

	return Person;
}

function isValidName(name) {
	if (/^[A-Za-z]{3,20}$/g.test(name)) {
		return true;
	}

	return false;
}

function isValidAge(age) {
	if (!isNaN(Number(age))) {
		if (0 < Number(age) && Number(age) < 150) {
			return true;
		}
	}
	return false;
}
module.exports = solve;

