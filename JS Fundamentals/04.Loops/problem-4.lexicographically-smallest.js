/*
Problem 4. Lexicographically smallest

Write a script that finds the lexicographically smallest and largest property in document, window and navigator objects.
*/

var documentProps = [];
var navigatorProps = [];
var windowProps = [];

for (prop in document) {
	documentProps.push(prop);
}
documentProps.sort();

for (prop in navigator) {
	navigatorProps.push(prop);
}
navigatorProps.sort();

for (prop in window) {
	windowProps.push(prop);
}
windowProps.sort();

console.log('In document lexicographically smallest: %s, largest: %s',documentProps[0],documentProps[documentProps.length-1]);
console.log('In window lexicographically smallest: %s, largest: %s',windowProps[0],windowProps[windowProps.length-1]);
console.log('In navigator lexicographically smallest: %s, largest: %s',navigatorProps[0],navigatorProps[navigatorProps.length-1]);