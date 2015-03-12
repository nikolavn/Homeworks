//Problem 8. Replace whole word

//Modify the solution of the previous problem to replace only whole words (not strings).

using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class ReplaceWholeWords
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

        string pattern = String.Format(@"\b{0}\b", targetString);
        string replaced = Regex.Replace(result.ToString(),pattern,replacementString,RegexOptions.None);

        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.Write(replaced);
        }

        using (StreamReader resultReader = new StreamReader(filePath))
        {
            string currentLine;

            while ((currentLine = resultReader.ReadLine()) != null)
            {
                Console.WriteLine(currentLine);
            }
        }
    }
}

