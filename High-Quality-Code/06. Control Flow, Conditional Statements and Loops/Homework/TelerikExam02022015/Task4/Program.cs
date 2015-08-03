using System;

class Program
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        //int size = 8;
        int sideSize = size-2;

        string top = new string(' ',size-1) + new string(':',size);
        string firstAfterTop = new string(' ', sideSize) + new string(':', 1) + new string('/', sideSize) + new string(':', 2);
        string middle = new string(':', size) + new string('X', sideSize) + new string(':',1);
        string lastToBottom = new string(':', 1) + new string(' ', sideSize) + new string(':', 2);
        string bottom = new string(':', size);
        Console.WriteLine(top);
        Console.WriteLine(firstAfterTop);
        for (int spaceCount = 3, xCount = 1; spaceCount < size; spaceCount++,xCount++)
        {
            string temp = new string(' ', size - spaceCount) + new string(':', 1) + new string('/', sideSize) 
                + new string(':',1) +new string('X',xCount) + new string(':', 1);
            Console.WriteLine(temp);
        }
        Console.WriteLine(middle);
        for (int xCount = sideSize-1; xCount > 0; xCount--)
        {
            string temp = new string(':', 1) + new string(' ', sideSize) + new string(':',1) +new string('X',xCount) + new string(':', 1);
            Console.WriteLine(temp);
        }
        Console.WriteLine(lastToBottom);
        Console.WriteLine(bottom);
    }
}

