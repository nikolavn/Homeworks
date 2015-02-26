//Problem 20. Palindromes
//• Write a program that extracts from a given text all palindromes, e.g.  ABBA ,  lamal ,  exe .


using System;

class Palindromes
{
    static void Main()
    {
        string[] palindromes = { "ABBA", "lamal", "exe", "not", "palindrome", "a" };

        foreach (var word in palindromes)
        {
            Console.WriteLine("{0} is palindrome: {1}", word, IsPalindrome(word));
        }
    }

    private static bool IsPalindrome(string text)
    {
        int midPoint = text.Length / 2;
        bool isPalindrome = true;

        for (int counter = 0; counter < midPoint; counter++)
        {
            if (text[counter] != text[text.Length - 1 - counter])
            {
                isPalindrome = false;
            }
        }

        return isPalindrome;
    }
}

