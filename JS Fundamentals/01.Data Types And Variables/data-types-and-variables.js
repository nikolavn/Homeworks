/*Problem 1. JavaScript literals

Assign all the possible JavaScript literals to different variables.*/

var integerLiteral = 1;
var floatingPointLiteral = 1.35;
var boolLiteral = true;
var stringLiteral = 'This is a string';
var arrayLiteral = ['this','is','array'];
var objectLiteral = {'type':'dog','name':'bobcho','age':13};

/*Problem 2. Quoted text

Create a string variable with quoted text in it.
For example: `'How you doin'?', Joey said'.*/

var quotedTextString = '"How you doing\'?" Joey said';
console.log(quotedTextString);

/*Problem 3. Typeof variables

Try typeof on all variables you created.*/

console.log(integerLiteral+' is: '+typeof(integerLiteral));
console.log(floatingPointLiteral+' is: '+typeof(floatingPointLiteral));
console.log(boolLiteral+' is: '+typeof(boolLiteral));
console.log(stringLiteral+' is: '+typeof(stringLiteral));
console.log(arrayLiteral+' is: '+typeof(arrayLiteral));
console.log(objectLiteral+' is: '+typeof(objectLiteral));

/*Problem 4. Typeof null

Create null, undefined variables and try typeof on them.*/

var nullVariable = null;
var undefinedVariable = undefined;

console.log(nullVariable+' is: '+typeof(nullVariable));
console.log(undefinedVariable+' is: '+typeof(undefinedVariable));