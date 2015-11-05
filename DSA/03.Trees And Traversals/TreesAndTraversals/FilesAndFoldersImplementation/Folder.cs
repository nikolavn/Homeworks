namespace FilesAndFoldersImplementation
{
    using System.Collections.Generic;
    using System.IO;

    public class Folder
    { 
        public Folder(string name,string path)
        {
            this.Name = name;
            this.Files = new List<File>();
            this.ChildFolders = new List<Folder>();
            this.Directory = new DirectoryInfo(path);
        }

        public string Name { get; set; }

        public ICollection<File> Files { get; set; }

        public ICollection<Folder> ChildFolders { get; set; }

        public DirectoryInfo Directory { get; set; }

        public long Size
        {
            get { return this.CalculateSize(); }
        }

        private long CalculateSize()
        {
            long size = 0;

            foreach (var file in this.Files)
            {
                size += file.Size;
            }

            foreach (var folder in this.ChildFolders)
            {
                size += folder.CalculateSize();                
            }

            return size;
        }

    }
}
