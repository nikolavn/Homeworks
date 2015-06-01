/*
Problem 8. Number as words

Write a script that converts a number in the range [0…999] to words, corresponding to its English pronunciation.
Examples:

numbers		number as words
0			Zero
9			Nine
10			Ten
12			Twelve
19			Nineteen
25			Twenty five
98			Ninety eight
98			Ninety eight
273			Two hundred and seventy three
400			Four hundred
501			Five hundred and one
617			Six hundred and seventeen
711			Seven hundred and eleven
999			Nine hundred and ninety nine
*/

var numbers = [0,9,10,12,19,25,98,273,400,501,617,711,999];
var len = numbers.length;

var hundreds = [
	"one hundred", "two hundred", "three hundred", "four hundred", "five hundred",
	"six hundred", "seven hundred", "eight hundred", "nine hundred"
];
var tens = [
	"ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety"
];
var ones = [
	"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"
];
var special = [
	"eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen",
	"eighteen", "nineteen"
];

for (var i = 0; i < len; i+=1) {

		var firstDigit = Math.floor(numbers[i] / 100);
        var secondDigit = Math.floor((numbers[i] % 100) / 10);
        var thirdDigit = Math.floor(numbers[i] % 10);

        if (numbers[i] >= 0 && numbers[i] < 10)
        {
            console.log("The number you entered is: %s", ones[thirdDigit]);
        }
        else if (numbers[i]===10) {
        	console.log("The number you entered is: %s", tens[0]);
        }
        else if (numbers[i] > 10 && numbers[i] < 20)
        {
            console.log("The number you entered is: %s", special[thirdDigit - 1]);
        }
        else if (numbers[i] >= 20 && numbers[i] < 100 && thirdDigit !== 0)
        {
            console.log("The number you entered is: %s %s", tens[secondDigit - 1], ones[thirdDigit]);
        }
        else if (numbers[i] >= 20 && numbers[i] < 100 && thirdDigit === 0)
        {
            console.log("The number you entered is: %s", tens[secondDigit - 1]);
        }
        else if (numbers[i] >= 100)
        {
            switch (secondDigit)
            {
                case 0:
                    switch (thirdDigit)
                    {
                        case 0:
                            console.log("The number you entered is: %s", hundreds[firstDigit - 1]); break;
                        default:
                            console.log("The number you entered is: %s and %s", hundreds[firstDigit - 1],
                                ones[thirdDigit]);
                            break;
                    } break;

                case 1:
                    console.log("The number you entered is: %s and %s",
                        hundreds[firstDigit - 1], special[thirdDigit - 1]); break;
                default:
                    console.log("The number you entered is: %s and %s %s",
                        hundreds[firstDigit - 1], tens[secondDigit - 1], ones[thirdDigit]); break;
            }
        }
}