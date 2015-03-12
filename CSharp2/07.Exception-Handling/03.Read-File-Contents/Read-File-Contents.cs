//Problem 3. Read file contents

//Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
//Find in MSDN how to use System.IO.File.ReadAllText(…).
//Be sure to catch all possible exceptions and print user-friendly error messages.

using System;
using System.IO;

class ReadFileContents
{
    static void Main()
    {
        string path = @"../../test.txt";

        try
        {
            File.ReadAllText(path);
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Invalid or empty path \"{0}\" !", path);
        }        
        catch(PathTooLongException)
        {
            Console.WriteLine("File path \"{0}\" is too long!", path);
        }
        catch(DirectoryNotFoundException)
        {
            Console.WriteLine("The path \"{0}\" specified is invalid", path);
        }        
        catch(UnauthorizedAccessException)
        {
            Console.WriteLine("File is read-only or you don't have access or path speciefies directory or operation is not supported by platform!");
        }
        catch(FileNotFoundException)
        {
            Console.WriteLine("The file specified by the path \"{0}\" can not be found!", path);
        }
        catch(NotSupportedException)
        {
            Console.WriteLine("The path \"{0}\" is in invalid format!", path);
        }        
    }
}

