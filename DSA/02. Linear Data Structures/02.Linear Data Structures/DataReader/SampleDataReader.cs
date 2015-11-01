namespace DataReader
{
    using System.IO;

    public class SampleDataReader
    {
        private TextReader textReader;

        public static SampleDataReader Create(TextReader textReader)
        {
            return new SampleDataReader(textReader);
        }

        private SampleDataReader(TextReader textReader)
        {
            this.textReader = textReader;
        }

        public string Read()
        {
            return textReader.ReadLine();
        }
    }
}
