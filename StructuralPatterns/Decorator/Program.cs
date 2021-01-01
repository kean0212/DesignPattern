namespace StructuralPatterns.Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            // This needs an explicit type
            IDataSource dataSource = new FileDataSource("somefile.dat");
            dataSource.WriteData("Hello, world!");

            dataSource = new EncryptionDecorator(dataSource);
            dataSource.WriteData("Something confidential.");

            dataSource = new CompressionDecorator(dataSource);
            dataSource.WriteData("Something need to be compressed.");
        }
    }
}
