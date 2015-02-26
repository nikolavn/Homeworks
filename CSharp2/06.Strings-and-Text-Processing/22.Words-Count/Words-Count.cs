//Problem 22. Words count
//• Write a program that reads a string from the console and lists all different words in the string along 
//with information how many times each word is found.


using System;
using System.Collections.Generic;
using System.Linq;

class WordsCount
{
    static void Main()
    {
        string text = @"Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.";
        Dictionary<string, int> words = new Dictionary<string, int>();

        string[] wordsInText = text.Split(new char[] { '.', ',', ' ', '!', '?', '-', ':', ';' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (var word in wordsInText)
        {
            if (words.ContainsKey(word))
            {
                words[word]++;
            }
            else
            {
                words.Add(word, 1);
            }
        }

        var sortedWords = words.OrderByDescending(w => w.Value);

        foreach (var word in sortedWords)
        {
            Console.WriteLine("Word \"{0}\" is found {1} time(s)", word.Key, words[word.Key]);
        }
    }
}

