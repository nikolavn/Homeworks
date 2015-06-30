/* Task Description */
/* 
* Create a module for a Telerik Academy course
  * The course has a title and presentations
    * Each presentation also has a title
    * There is a homework for each presentation
  * There is a set of students listed for the course
    * Each student has firstname, lastname and an ID
      * IDs must be unique integer numbers which are at least 1
  * Each student can submit a homework for each presentation in the course
  
  * Create method init
    * Accepts a string - course title
    * Accepts an array of strings - presentation titles
    * Throws if there is an invalid title
      * Titles do not start or end with spaces
      * Titles do not have consecutive spaces
      * Titles have at least one character
    * Throws if there are no presentations
    
  * Create method addStudent which lists a student for the course
    * Accepts a string in the format 'Firstname Lastname'
    * Throws if any of the names are not valid
      * Names start with an upper case letter
      * All other symbols in the name (if any) are lowercase letters
    * Generates a unique student ID and returns it
    
  * Create method getAllStudents that returns an array of students in the format:
    * {firstname: 'string', lastname: 'string', id: StudentID}
  
  * Create method submitHomework  
    * Accepts studentID and homeworkID
      * homeworkID 1 is for the first presentation
      * homeworkID 2 is for the second one
      * ...
    * Throws if any of the IDs are invalid
    
  * Create method pushExamResults
    * Accepts an array of items in the format {StudentID: ..., Score: ...}
      * StudentIDs which are not listed get 0 points
    * Throw if there is an invalid StudentID
    * Throw if same StudentID is given more than once ( he tried to cheat (: )
    * Throw if Score is not a number
    
  * Create method getTopStudents which returns an array of the top 10 performing students
    * Array must be sorted from best to worst
    * If there are less than 10, return them all
    * The final score that is used to calculate the top performing students is done as follows:
      * 75% of the exam result
      * 25% the submitted homework (count of submitted homeworks / count of all homeworks) for the course
*/

function solve() {
    var Course = {
        init: function(title, presentations) {
            this.courseTitle = title;
            this.presentationsList = presentations;
            this.students = [];
            studentID = 0;

            return this;
        },
        addStudent: function(name) {

            var nameAsArray = [];
            studentID += 1;

            nameAsArray = name.split(' ');

            if (nameAsArray.length > 2 || nameAsArray.length < 2) {
                throw new Error('Student can not have more or less than 2 names');
            }

            if (!nameAsArray.every(isValidName)) {
                throw new Error('Name is invalid. Should contain only letters starting with capital one.');
            }

            var currentStudent = {
                firstname: nameAsArray[0],
                lastname: nameAsArray[1],
                id: studentID
            };

            this.students.push(currentStudent);

            return studentID;
        },
        getAllStudents: function() {
            return this.students.slice();
        },
        submitHomework: function(studentID, homeworkID) {
            if (!isValidID(studentID, 1, this.students.length)) {
                throw new Error('Student with this ID: ' + studentID + 'doesn\'t exist');
            }
            if (!isValidID(homeworkID, 1, this.presentationsList.length)) {
                throw new Error('Homework with this ID: ' + homeworkID + 'does\'t exist');
            }
        },
        pushExamResults: function(results) {},
        getTopStudents: function() {}
    };

    Object.defineProperty(Course, 'courseTitle', {
        get: function() {
            return this._title;
        },
        set: function(value) {
            if (!isValidTitle(value)) {
                throw new Error('Course title is not valid');
            }

            this._title = value;
        }
    });

    Object.defineProperty(Course, 'presentationsList', {
        get: function() {
            return this._presentationsList;
        },
        set: function(value) {
            if (!value.every(isValidTitle)) {
                throw new Error('One or more presentations have invalid title.');
            }

            if (!arrayExists(value)) {
                throw new Error('Presentations list is empty');
            }

            this._presentationsList = value;
        }
    });

    Object.defineProperty(Course, 'students', {
        get: function() {
            return this._students;
        },
        set: function(value) {
            this._students = value;
        }
    });

    function arrayExists(array) {
        return typeof array !== "undefined" && array !== null && array.length > 0;
    }

    function isValidID(id, min, max) {
        if ((isNaN(id) || isNaN(Number(id))) || (min > id || id > max)) {
            return false;
        }

        return true;
    }

    function isValidName(name) {
        return /^[A-Z][a-z]*$/g.test(name);
    }

    function isValidTitle(title) {
        if (title.length === 0 || (title !== title.trim()) || title.match(/\s{2,}/)) {
            return false;
        }

        return true;
    }

    return Course;
}

module.exports = solve;
