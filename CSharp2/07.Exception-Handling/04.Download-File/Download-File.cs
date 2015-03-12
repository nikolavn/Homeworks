//Problem 4. Download file

//Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
//Find in Google how to download files in C#.
//Be sure to catch all exceptions and to free any used resources in the finally block.

using System;
using System.IO;
using System.Net;

class DownloadFile
{
    static void Main()
    {
        WebClient myWebClient = new WebClient();

        try
        {
            string remoteUri = @"http://telerikacademy.com/Content/Images/";
            string fileName = @"../../news-img01.png";
            string fullWebResource = null;
            
            fullWebResource = remoteUri + fileName;

            myWebClient.DownloadFile(fullWebResource, fileName);
        }
        catch (ArgumentException argEx)
        {
            Console.WriteLine(argEx.Message);
        }
        catch (WebException webEx)
        {
            Console.WriteLine(webEx.Message);
        }
        catch(NotSupportedException nsuppEx)
        {
            Console.WriteLine(nsuppEx.Message);
        }
        finally
        {
            myWebClient.Dispose();
        }
    }
}
