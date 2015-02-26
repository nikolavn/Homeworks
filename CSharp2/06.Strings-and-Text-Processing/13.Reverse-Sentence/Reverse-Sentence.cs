//Problem 13. Reverse sentence

//Write a program that reverses the words in given sentence.
//Example:

//input	                                    output
//C# is not C++, not PHP and not Delphi!	Delphi not and PHP, not C++ not is C#!

using System;
using System.Collections.Generic;
using System.Text;

class ReverseSentence
{
    static void Main()
    {
        string text = @"C# is not C++, not PHP and not Delphi!";
        string[] textAsWords = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        Stack<string> words = new Stack<string>();
        Queue<char> punctuation = new Queue<char>();
        List<bool> wordsWithPunctuation = new List<bool>();
        StringBuilder result = new StringBuilder();

        foreach (var word in textAsWords)
        {
            wordsWithPunctuation.Add(ContainsPunctuation(word));
        }

        for (int currentWord = 0; currentWord < wordsWithPunctuation.Count; currentWord++)
        {
            if (!wordsWithPunctuation[currentWord])
            {
                words.Push(textAsWords[currentWord]);
            }
            else
            {
                punctuation.Enqueue(textAsWords[currentWord][textAsWords[currentWord].Length - 1]);
                textAsWords[currentWord] = textAsWords[currentWord].Remove(textAsWords[currentWord].Length - 1);
                words.Push(textAsWords[currentWord]);
            }
        }

        for (int currentWord = 0; currentWord < wordsWithPunctuation.Count; currentWord++)
        {
            if (!wordsWithPunctuation[currentWord])
            {
                result.Append(words.Pop() + " ");
            }
            else
            {
                result.Append(words.Pop());
                result.Append(punctuation.Dequeue() + " ");
            }
        }

        Console.WriteLine(result.ToString().Trim());
    }

    private static bool ContainsPunctuation(string text)
    {
        char[] punctSigns = new char[] { ',', '.', '?', '!', ':', ';' };
        bool hasPunct = false;

        for (int currentSign = 0; currentSign < punctSigns.Length; currentSign++)
        {
            if (text.Contains(punctSigns[currentSign].ToString()))
            {
                hasPunct = true;
            }
        }

        return hasPunct;
    }
}