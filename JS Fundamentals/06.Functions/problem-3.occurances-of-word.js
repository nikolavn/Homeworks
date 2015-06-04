/*
Problem 3. Occurrences of word

Write a function that finds all the occurrences of word in a text.
The search can be case sensitive or case insensitive.
Use function overloading.
*/

function getWordCount(text, word, isCaseSensitive) {

	function getWordCountCaseInsensitive(word) {
		var myRegEx = '\\b' + word + '\\b';
		var regex = new RegExp(myRegEx, "gi");
		var wordsCount = text.match(regex);

		return wordsCount.length;
	}

	function getWordCountCaseSensitive(word) {
		var myRegEx = '\\b' + word + '\\b';
		var regex = new RegExp(myRegEx, "g");
		var wordsCount = text.match(regex);

		return wordsCount.length;
	}

	switch (arguments.length) {
		case 2:
			return getWordCountCaseInsensitive(word);
		case 3:
			return isCaseSensitive ? getWordCountCaseSensitive(word) : getWordCountCaseInsensitive(word);
	}


}

var text = 'Hello world hello world hello world Hello world';

console.log('hello in: ' + text + ' case sensitive : no --> ' + getWordCount(text, 'hello'));
console.log('hello in: ' + text + ' case sensitive : yes --> ' + getWordCount(text, 'hello', true));
console.log('hello in: ' + text + ' case sensitive : no --> ' + getWordCount(text, 'hello', false));