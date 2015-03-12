//Problem 2. Concatenate text files

//Write a program that concatenates two text files into another text file.

using System;
using System.IO;
using System.Text;

class ConcatenateTextFiles
{
    static void Main()
    {
        try
        {
            string fileOne = @"../../Files/TextFile1.txt";
            string fileTwo = @"../../Files/TextFile2.txt";

            StreamReader readerOne = new StreamReader(fileOne);
            StreamReader readerTwo = new StreamReader(fileTwo);
            StreamWriter writer = new StreamWriter("../../Files/result.txt");

            try
            {
                string currentLine;

                while ((currentLine = readerOne.ReadLine()) != null)
                {
                    writer.WriteLine(currentLine);
                }

                while ((currentLine = readerTwo.ReadLine()) != null)
                {
                    writer.WriteLine(currentLine);
                }
            }
            finally
            {
                readerOne.Close();
                readerTwo.Close();
                writer.Close();
            }

            using (StreamReader reader = new StreamReader("../../Files/result.txt"))
            {
                string resultLine = reader.ReadLine();

                while (resultLine != null)
                {
                    Console.WriteLine(resultLine);
                    resultLine = reader.ReadLine();
                }
            }
        }
        catch(System.Exception exception)
        {
            Console.WriteLine(exception.Message);
        }
    }
}

