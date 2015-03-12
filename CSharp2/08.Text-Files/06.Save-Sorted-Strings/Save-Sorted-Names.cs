//Problem 6. Save sorted names

//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
//Example:

//input.txt	  output.txt
//Ivan          George
//Peter         Ivan
//Maria         Maria
//George	    Peter

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class SaveSortedNames
{
    static void Main()
    {
        string inputPath = @"../../Files/input.txt";
        string outputPath = @"../../Files/output.txt";

        List<string> names = new List<string>();

        using (StreamReader reader = new StreamReader(inputPath))
        {
            string currentLine;

            while ((currentLine = reader.ReadLine()) != null)
            {
                names.Add(currentLine);
            }
        }

        var sorted = names.OrderBy(n => n);

        using (StreamWriter writer = new StreamWriter(outputPath))
        {
            foreach (var name in sorted)
            {
                writer.WriteLine(name);
            }
        }

        using (StreamReader resultReader = new StreamReader(outputPath))
        {
            Console.WriteLine(resultReader.ReadToEnd());
        }
    }
}
