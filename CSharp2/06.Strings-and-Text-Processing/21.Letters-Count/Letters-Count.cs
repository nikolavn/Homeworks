//Problem 21. Letters count

//• Write a program that reads a string from the console and prints all different letters in the string along with 
//information how many times each letter is found. 


using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string text = @"Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.";
        Dictionary<char, int> letters = new Dictionary<char, int>();

        for (int currentCharacter = 0; currentCharacter < text.Length; currentCharacter++)
        {
            if (Char.IsLetter(text[currentCharacter]))
            {
                if (letters.ContainsKey(text[currentCharacter]))
                {
                    letters[text[currentCharacter]]++;
                }
                else
                {
                    letters.Add(text[currentCharacter], 1);
                }
            }
        }

        var sortedLetters = letters.OrderByDescending(l => l.Value);

        foreach (var letter in sortedLetters)
        {
            Console.WriteLine("Letter \"{0}\" is found {1} time(s)",letter.Key,letters[letter.Key]);
        }
    }
}

