//Problem 5. Parse tags

//You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
//The tags cannot be nested.
//Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

//The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

using System;

class ParseTags
{
    static void Main()
    {
        string text = @"We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        string openingTag = @"<upcase>";
        string closingTag = @"</upcase>";
        int position = -1;
        int capitalizationStart = 0, capitalizationEnd = 0;
        string replacementText = String.Empty, capitalizedText = String.Empty, normalText = String.Empty;

        Console.WriteLine("Original text: \n{0}\n",text);

        while (text.IndexOf(openingTag, position + 1) != -1)
        {
            capitalizationStart = text.IndexOf(openingTag, position + 1) + openingTag.Length;
            capitalizationEnd = text.IndexOf(closingTag, position + 1);
            for (int counter = capitalizationStart; counter < capitalizationEnd; counter++)
            {
                capitalizedText += Char.ToUpper(text[counter]).ToString();
                normalText += text[counter].ToString();
            }

            text = text.Replace(openingTag + normalText + closingTag, capitalizedText);

            position++;
            normalText = String.Empty;
            capitalizedText = String.Empty;
        }

        //text = text.Replace(openingTag,replacementText);
        //text = text.Replace(closingTag,replacementText);

        Console.WriteLine("Text with tags replaced: \n{0}\n",text);
    }
}

