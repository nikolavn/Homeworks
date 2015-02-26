//Problem 12. Parse URL
//
//Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], 
//[server] and [resource] elements.
//Example:
//
//URL	Information
//http://telerikacademy.com/Courses/Courses/Details/212	
//
//[protocol] = http 
//[server] = telerikacademy.com 
//[resource] = /Courses/Courses/Details/212

using System;
using System.IO;
using System.Text;

class ParseURL
{
    static void Main()
    {
        string input = @"http://telerikacademy.com/Courses/Courses/Details/212";
        StringBuilder protocol = new StringBuilder();
        StringBuilder server = new StringBuilder();
        StringBuilder resourse = new StringBuilder();
        char delimeter = '/';
        int protocolEndIndex = 0, serverEndIndex = 0;

        protocolEndIndex = input.IndexOf(':');
        serverEndIndex = input.IndexOf(delimeter, protocolEndIndex + 3);

        for (int counter = 0; counter < protocolEndIndex; counter++)
        {
            protocol.Append(input[counter]);
        }

        for (int counter = protocolEndIndex+3; counter < serverEndIndex; counter++)
        {
            server.Append(input[counter]);
        }

        for (int counter = serverEndIndex; counter < input.Length; counter++)
        {
            resourse.Append(input[counter]);
        }

        Console.WriteLine("Original URL: \n{0}",input);
        Console.WriteLine("Parsed: ");
        Console.WriteLine("[protocol]: {0}",protocol.ToString());
        Console.WriteLine("[server]: {0}",server.ToString());
        Console.WriteLine("[resourse]: {0}", resourse.ToString());
    }
}

