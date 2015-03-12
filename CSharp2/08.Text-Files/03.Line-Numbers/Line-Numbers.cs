//Problem 3. Line numbers

//Write a program that reads a text file and inserts line numbers in front of each of its lines.
//The result should be written to another text file.

using System;
using System.IO;

class LineNumbers
{
    static void Main()
    {
        string sourcePath = @"../../Files/text.txt";
        string resultPath = @"../../Files/result.txt";

        using (StreamReader reader = new StreamReader(sourcePath))
        {
            using(StreamWriter writer = new StreamWriter(resultPath))
            {
                string currentLine;
                int lineNumber = 1;

                while ((currentLine = reader.ReadLine())!=null)
                {
                    writer.WriteLine("{0,2}. {1}",lineNumber,currentLine);
                    lineNumber++;
                }
            }
        }

        using (StreamReader resultReader = new StreamReader(resultPath))
        {
            string resultLine;

            while ((resultLine = resultReader.ReadLine()) != null)
            {
                Console.WriteLine(resultLine);
            }
        }
    }
}

