//Problem 10. Extract text from XML

//Write a program that extracts from given XML file all the text without the tags.
//Example:

//<?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3"><interest>Games</interest><interest>C#
//</interest><interest>Java</interest></interests></student>

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class ExtractTextFromXML
{
    static void Main()
    {
        string filePath = @"../../Files/input.txt";
        string pattern = @">(\b[A-Za-z]+\b)</|>(\s*\b[A-Za-z]+\b)</|>(\b[0-9]+\b)</";
        string result = null;
        string currentLine;

        using (StreamReader reader = new StreamReader(filePath))
        {
            while ((currentLine = reader.ReadLine())!=null)
            {
                foreach (Match match in Regex.Matches(currentLine, pattern))
                {
                    result = match.Value.ToString();
                    result = result.Remove(0, 1);
                    result = result.Remove(result.Length - 2, 2);

                    Console.WriteLine(result != null ? result : "Result is null.");
                }
            }
        }
    }
}

