namespace FilesAndFoldersImplementation
{
    public class File
    {
        private string name;
        private long size;

        public File(string name,long size)
        {
            this.Name = name;
            this.Size = size;
        }

        public string Name { get; set; }
        public long Size { get; set; }
    }
}
