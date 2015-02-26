//Problem 24. Order words
//• Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.


using System;
using System.Collections.Generic;
using System.Linq;


class OrderWords
{
    static void Main()
    {
        //Console.WriteLine("Enter words separated with space: ");
        //string text = Console.ReadLine();
        string sampleText = @"Write a program that reads a list of words separated by spaces and prints the list in an alphabetical order";
        HashSet<string> words = new HashSet<string>();

        string[] splitText = sampleText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (var word in splitText)
        {
            words.Add(word.Trim().ToLower());
        }

        var orderedWords = words.OrderBy(w => w);

        Console.WriteLine("Words in text in alphabetical order: ");

        foreach (var word in orderedWords)
        {
            Console.WriteLine(word);
        }
    }
}

