//Problem 13. Count words

//Write a program that reads a list of words from the file words.txt and finds how many times each of the words is contained in another file test.txt.
//The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order.
//Handle all possible exceptions in your methods.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


class CountWords
{
    private static string wordsPath = @"../../Files/words.txt";
    private static string testPath = @"../../Files/test.txt";
    private static string resultPath = @"../../Files/result.txt";    
    
    static void Main()
    {
        try
        {
            Console.WriteLine("Initial text: ");
            PrintResult(testPath);

            Console.WriteLine("Words to find: ");
            PrintResult(wordsPath);

            Console.WriteLine("Words occurances: ");
            CountWordsOccurances();
            PrintResult(resultPath);
        }

        catch (FileNotFoundException fnfe)
        {
            Console.WriteLine(fnfe.Message);
        }

        catch (IOException ioe)
        {
            Console.WriteLine(ioe.Message);
        }

        catch (UnauthorizedAccessException unauth)
        {
            Console.WriteLine(unauth.Message);
        }

        catch (OutOfMemoryException nomem)
        {
            Console.WriteLine(nomem.Message);
        }
    }

    private static void CountWordsOccurances()
    {
        Dictionary<string, int> wordsInText = new Dictionary<string, int>();
        List<string> wordsToFind = new List<string>();
        Dictionary<string, int> sorted = new Dictionary<string, int>();
        string currentLine;

        using (StreamReader reader = new StreamReader(testPath))
        {
            while ((currentLine = reader.ReadLine()) != null)
            {
                var splitted = currentLine.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var word in splitted)
                {
                    if (wordsInText.ContainsKey(word))
                    {
                        wordsInText[word]++;
                    }
                    else
                    {
                        wordsInText.Add(word, 1);
                    }
                }
            }
        }

        using (StreamReader wordsReader = new StreamReader(wordsPath))
        {
            while ((currentLine = wordsReader.ReadLine()) != null)
            {
                wordsToFind.Add(currentLine.Trim());
            }
        }

        foreach (var word in wordsToFind)
        {
            if (wordsInText.ContainsKey(word))
            {
                sorted.Add(word, wordsInText[word]);
            }
        }

        using (StreamWriter writeResult = new StreamWriter(resultPath))
        {
            foreach (var word in sorted.OrderByDescending(k => k.Value))
            {
                writeResult.Write(word.Key);
                writeResult.Write("-");
                writeResult.WriteLine(word.Value);
            }

        }
    }

    private static void PrintResult(string filePath)
    {

        using (StreamReader readerResult = new StreamReader(filePath))
        {
            string contents = readerResult.ReadLine();
            while (contents != null)
            {
                Console.WriteLine(contents);
                Console.WriteLine();
                contents = readerResult.ReadLine();
            }
        }
    }
}
