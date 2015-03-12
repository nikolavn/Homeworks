//Problem 1. Odd lines

//Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.IO;

class OddLines
{
    static void Main()
    {
        string fileName = @"../../text.txt";
        StreamReader reader = new StreamReader(fileName);

        using (reader)
        {
            int linesCount = 1;
            string currentLine = reader.ReadLine();           

            while (currentLine != null)
            {
                if (linesCount%2!=0)
                {
                    Console.WriteLine(currentLine);

                }
                linesCount++;
                currentLine = reader.ReadLine();
            }
        }
    }
}

