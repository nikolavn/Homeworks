//Problem 25. Extract text from HTML
//• Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.

//Example input:
//<html>
//  <head><title>News</title></head>
//  <body><p><a href="http://academy.telerik.com">Telerik
//    Academy</a>aims to provide free real-world practical
//    training for young people who want to turn into
//    skilful .NET software engineers.</p></body>
//</html>


//Output: 

//Title: News

//Text: Telerik Academy aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.


using System;
using System.Text;

class ExtractTextFromHTML
{
    static void Main()
    {
        string input = @"<html><head><title>News</title></head><body><p><a href=""http://academy.telerik.com"">Telerik Academy</a> aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.</p></body></html>";

        string titleStart = "<title>";
        string titleEnd = "</title>";
        StringBuilder title = new StringBuilder();

        for (int counter = input.IndexOf(titleStart) + titleStart.Length; counter < input.IndexOf(titleEnd); counter++)
        {
            title.Append(input[counter]);
        }

        Console.WriteLine("Title: {0}",title.ToString());
        Console.WriteLine("Text: {0}", TextBetweenSymbols('>', '<', input));
    }

    private static string TextBetweenSymbols(char startSymbol, char endSymbol, string textInput)
    {
        string inTag = "<body>";
        int currentPosition = textInput.IndexOf(inTag)+inTag.Length;
        StringBuilder text = new StringBuilder();

        while (textInput.IndexOf(endSymbol, currentPosition) != -1)
        {
            int start = textInput.IndexOf(startSymbol, currentPosition);
            int end = textInput.IndexOf(endSymbol, start);

            if ((end - start) > 0)
            {
                text.Append(textInput.Substring(start + 1, end - start - 1));
            }

            currentPosition = end + 1;
        }

        return text.ToString();
    }
}

