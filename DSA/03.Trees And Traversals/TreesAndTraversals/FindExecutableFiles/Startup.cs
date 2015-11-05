namespace FindExecutableFiles
{
    using System;
    using System.Collections.Specialized;
    using System.IO;

    class Startup
    {
        static StringCollection log = new StringCollection();

        static void Main()
        {
            DirectoryInfo root = new DirectoryInfo("C:\\Windows");

            WalkDirectoryTree(root);
        }

        static void WalkDirectoryTree(DirectoryInfo root)
        {
            FileInfo[] files = null;
            DirectoryInfo[] subDirs = null;

            try
            {
                files = root.GetFiles("*.*");
            }

            catch (UnauthorizedAccessException e)
            {
                log.Add(e.Message);
            }

            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            if (files != null)
            {
                foreach (FileInfo fi in files)
                {
                    if (fi.Extension==".exe")
                    {
                        Console.WriteLine(fi.FullName);
                    }                    
                }

                subDirs = root.GetDirectories();

                foreach (DirectoryInfo dirInfo in subDirs)
                {
                    WalkDirectoryTree(dirInfo);
                }
            }
        }
    }
}
