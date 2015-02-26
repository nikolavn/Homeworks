//Problem 8. Extract sentences

//Write a program that extracts from a given text all sentences containing given word.
//Example:

//The word is: in

//The text is: We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

//The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.

//Consider that the sentences are separated by . and the words – by non-letter symbols.

using System;
using System.Text;

class ExtractSentences
{
    static void Main()
    {
        string text = @"We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";

        string[] sentences = text.Split(new string[] { "." }, StringSplitOptions.RemoveEmptyEntries);
        StringBuilder output = new StringBuilder();
        string stringToFind = "in";

        Console.WriteLine("Original text: \n{0}\n",text);

        foreach (var sentence in sentences)
        {
            if (ContainsString(sentence, stringToFind))
            {
                output.Append(sentence + ".");
            }
        }

        Console.WriteLine("Sentences that contain word \"{0}\" :\n{1}\n",stringToFind,output.ToString());
    }

    private static bool ContainsString(string text, string stringToFind)
    {
        int position = -1;
        bool isFound = false;

        while (text.IndexOf(stringToFind, position + 1) != -1)
        {            
            if (!Char.IsLetter(text[text.IndexOf(stringToFind, position + 1) - 1]) && !Char.IsLetter(text[text.IndexOf(stringToFind, position + 1) + stringToFind.Length]))
            {
                isFound = true;
                break;
            }

            position++;
        }

        return isFound;
    }
}

