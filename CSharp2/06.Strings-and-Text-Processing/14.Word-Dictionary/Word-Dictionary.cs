//Problem 14. Word dictionary

//A dictionary is stored as a sequence of text lines containing words and their explanations.
//Write a program that enters a word and translates it by using the dictionary.
//Sample dictionary:

//input	        output
//.NET	        platform for applications from Microsoft
//CLR	        managed execution environment for .NET
//namespace	    hierarchical organization of classes

using System;
using System.Collections.Generic;

class WordDictionary
{
    static void Main()
    {
        Dictionary<string, string> myDictionary = InitializeDictionary();       

        Console.WriteLine("Enter word: ");
        string lookupWord = Console.ReadLine();  
      
        bool isInDictionary = myDictionary.ContainsKey(lookupWord);

        while (!isInDictionary)
        {
            Console.WriteLine("\nDictionary contains: ");

            foreach (var word in myDictionary)
            {
                Console.WriteLine(word.Key);
            }
            Console.WriteLine("\nEnter new word: ");
            lookupWord = Console.ReadLine();
            isInDictionary = myDictionary.ContainsKey(lookupWord);
        }

        Console.WriteLine("{0} means: {1}",lookupWord,myDictionary[lookupWord]);
        
        
    }

    private static Dictionary<string,string> InitializeDictionary()
    {
        Dictionary<string, string> sampleDictionary = new Dictionary<string, string>();
        sampleDictionary.Add(".NET", "platform for applications from Microsoft");
        sampleDictionary.Add("CLR", "managed execution environment for .NET");
        sampleDictionary.Add("namespace", "hierarchical organization of classes");

        return sampleDictionary;
    }
}

