//Problem 9. Delete odd lines

//Write a program that deletes from given text file all odd lines.
//The result should be in the same file.

using System;
using System.Collections.Generic;
using System.IO;

class DeleteOddLines
{
    static void Main()
    {
        string filePath = @"../../Files/text.txt";
        string currentLine;
        int currentLineNumber = 1;
        List<string> linesToKeep = new List<string>();

        using (StreamReader reader = new StreamReader(filePath))
        {
            while ((currentLine = reader.ReadLine()) != null)
            {
                if (currentLineNumber%2 == 0)
                {
                    linesToKeep.Add(currentLine);
                }

                currentLineNumber++;
            }
        }

        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (var line in linesToKeep)
            {
                writer.WriteLine(line);
            }
        }

        using (StreamReader resultReader = new StreamReader(filePath))
        {
            Console.WriteLine(resultReader.ReadToEnd());
        }
    }
}

