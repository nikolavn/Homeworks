//Problem 12. Remove words

//Write a program that removes from a text file all words listed in given another text file.
//Handle all possible exceptions in your methods.

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;


class RemoveWords
{
    private static string inputPath = @"../../Files/input.txt";
    private static string outputPath = @"../../Files/output.txt";
    private static string wordsPath = @"../../Files/words.txt";

    static string ReadList()
    {
        string forbiddenWordsregex = @"\b(" + String.Join("|", File.ReadAllLines(wordsPath)) + @")\b";

        return forbiddenWordsregex;
    }

    static void RemoveForbiddenWords(string words)
    {

        using (StreamReader readInput = new StreamReader(inputPath))
        {
            using (StreamWriter writeOutput = new StreamWriter(outputPath))
            {
                string line = readInput.ReadLine();

                while (line != null)
                {
                    writeOutput.WriteLine(Regex.Replace(line, words, String.Empty));
                    line = readInput.ReadLine();
                }
            }
        }
    }

    static void PrintResult(string filePath)
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

    static void Main(string[] args)
    {
        try
        {
            PrintResult(inputPath);
            RemoveForbiddenWords(ReadList());            
            PrintResult(outputPath);
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

    }
}
