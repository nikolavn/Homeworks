//Problem 7. Encode/decode

//Write a program that encodes and decodes a string using given encryption key (cipher).
//The key consists of a sequence of characters.
//The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, 
//the second – with the second, etc. When the last key character is reached, the next is the first.

using System;
using System.Text;

class EncodeDecode
{
    static void Main()
    {
        string text = @"testtextawsl";
        string key = "key";

        Console.WriteLine(EncodeText(text, key));
    }

    private static string EncodeText(string text, string key)
    {
        StringBuilder encodedText = new StringBuilder();
        int numberOfKeys = 0;

        while (numberOfKeys < text.Length - key.Length)
        {
            for (int counter = 0; counter < key.Length; counter++)
            {
                Console.WriteLine((int)text[numberOfKeys + counter]);
                Console.WriteLine((int)key[counter]);
                encodedText.Append((char)((int)text[numberOfKeys + counter] ^ (int)key[counter]));
            }

            numberOfKeys += key.Length;
        }

        return encodedText.ToString();
    }
}

