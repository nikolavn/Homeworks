using System;

class PrintASCIITable
{
    static void Main(string[] args)
    {
        int asciiTableLength = 255;
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        
        for (int i = 0; i < asciiTableLength; i++)
        {
            char character = (char)i;
            if (char.IsControl(character))
            {
                Console.WriteLine((int)i);
            }
            Console.WriteLine(character);
        }
    }
}

