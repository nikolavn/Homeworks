//Problem 4. Compare text files

//Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
//Assume the files have equal number of lines.

using System;
using System.IO;

class CompareTextFiles
{
    static void Main()
    {
        string fileOnePath = @"../../Files/text1.txt";
        string fileTwoPath = @"../../Files/text2.txt";

        StreamReader fileOneReader = new StreamReader(fileOnePath);
        StreamReader fileTwoReader = new StreamReader(fileTwoPath);

        try
        {
            string fileOneCurrentLine = fileOneReader.ReadLine();
            string fileTwoCurrentLine = fileTwoReader.ReadLine();

            while (fileOneCurrentLine != null)
            {
                if (fileOneCurrentLine==fileTwoCurrentLine)
                {
                    Console.WriteLine(fileOneCurrentLine+" = "+fileTwoCurrentLine);
                }

                fileOneCurrentLine = fileOneReader.ReadLine();
                fileTwoCurrentLine = fileTwoReader.ReadLine();
            }
        }
        finally
        {
            fileOneReader.Close();
            fileTwoReader.Close();
        }
    }
}

