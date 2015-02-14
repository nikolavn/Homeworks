using System;

class QuotesInString
{
    static void Main()
    {
        string withQuotedStrings = "The \"use\" of quotations causes difficulties.";
        string withoutQuotedStrings = @"The ""use"" of quotations causes difficulties.";

        Console.WriteLine(withQuotedStrings);
        Console.WriteLine();
        Console.WriteLine(withoutQuotedStrings);
        Console.WriteLine();
    }
}

