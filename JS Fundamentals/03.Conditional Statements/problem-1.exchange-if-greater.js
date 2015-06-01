/*
Problem 1. Exchange if greater

Write an if statement that takes two double variables a and b and exchanges their values if the first one is greater than the second.
As a result print the values a and b, separated by a space.
Examples:

a   b   result
5   2   2 5
3   4   3 4
5.5 4.5 4.5 5.5
*/

var combinations = [{
    'a': 5,
    'b': 2
}, {
    'a': 3,
    'b': 4
}, {
    'a': 5.5,
    'b': 4.5
}];
var len = combinations.length;

for (var i = 0; i < len; i += 1) {

    if (combinations[i]['a'] > combinations[i]['b']) {
        var helper = 0;
        helper = combinations[i]['a'];
        combinations[i]['a'] = combinations[i]['b'];
        combinations[i]['b'] = helper;

        console.log(combinations[i]['a'] + ' ' + combinations[i]['b']);
    } else {
        console.log(combinations[i]['a'] + ' ' + combinations[i]['b']);
    }
}
