namespace FilesAndFoldersImplementation
{
    using System;

    class Startup
    {
        static void Main()
        {
            var folder = new Folder("Globalization", "C:\\Windows\\Globalization");
            WalkDirectoryTree(folder);

            Console.WriteLine($"Folder: {folder.Name}, Size: {(folder.Size / 1024)} KB");

            foreach (var dir in folder.ChildFolders)
            {
                Console.WriteLine($"Folder: {dir.Name}, Size: {(dir.Size / 1024)} KB");
            }
        }

        static void WalkDirectoryTree(Folder root)
        {
            foreach (var file in root.Directory.GetFiles("*.*"))
            {
                root.Files.Add(new File(file.Name, file.Length));
            }

            foreach (var directory in root.Directory.GetDirectories())
            {
                var currentSubDirectory = new Folder(directory.Name, directory.FullName);
                root.ChildFolders.Add(currentSubDirectory);
                WalkDirectoryTree(currentSubDirectory);
            }
        }
    }
}
