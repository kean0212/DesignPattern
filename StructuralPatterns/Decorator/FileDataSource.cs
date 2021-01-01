using System;

namespace StructuralPatterns.Decorator
{
    public class FileDataSource : IDataSource
    {
        private readonly string _fileName;

        public FileDataSource(string fileName)
        {
            _fileName = fileName;
        }

        public string ReadData()
        {
            throw new System.NotImplementedException();
        }

        public void WriteData(string data)
        {
            Console.WriteLine($"{nameof(FileDataSource)}.{nameof(WriteData)}({data})");
        }
    }
}
