//Problem 7. Replace sub-string

//Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
//Ensure it will work with large files (e.g. 100 MB).

using System;
using System.IO;
using System.Text;

class ReplaceSubstring
{
    static void Main()
    {
        string filePath = @"../../Files/input.txt";
        string targetString = "start";
        string replacementString = "finish";
        StringBuilder result = new StringBuilder();


        using (StreamReader reader = new StreamReader(filePath))
        {
            string currentLine;

            while ((currentLine = reader.ReadLine()) != null)
            {                
                result.AppendLine(currentLine);
            }
        }

        result = result.Replace(targetString, replacementString);

        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.Write(result.ToString());
        }

        //using (StreamReader resultReader = new StreamReader(filePath))
        //{
        //    string currentLine;

        //    while ((currentLine = resultReader.ReadLine()) != null)
        //    {
        //        Console.WriteLine(currentLine);
        //    }
        //}
    }
}


