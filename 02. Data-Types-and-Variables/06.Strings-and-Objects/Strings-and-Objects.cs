using System;

class StringsAndObjects
{
    static void Main()
    {
        string hello;
        string world;
        hello = "Hello";
        world = "World";

        object concatenated = hello + " " + world;

        string helloWorld = (string)concatenated;

        Console.WriteLine(helloWorld);
    }
}

