//Problem 12. Index of letters

//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.

using System;

class IndexOfLetters
{
    static void Main()
    {
        char[] alphabet = new char[26];

        Console.WriteLine("Enter word: ");
        string word = Console.ReadLine();

        for (int i = 0; i < alphabet.Length; i++)
        {
            alphabet[i] = (char)(65 + i);
        }

        for (int letterInWord = 0; letterInWord < word.Length; letterInWord++)
        {
            for (int letter = 0; letter < alphabet.Length; letter++)
            {
                if (Char.ToUpper(word[letterInWord]) == alphabet[letter])
                {
                    Console.WriteLine("{0} -> index: {1}", word[letterInWord], letter);
                }
            }
        }
    }
}

