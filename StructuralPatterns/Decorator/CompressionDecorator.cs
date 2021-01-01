namespace StructuralPatterns.Decorator
{
    public class CompressionDecorator : DataSourceDecorator
    {
        public CompressionDecorator(IDataSource source) : base(source)
        {
        }

        public override string ReadData()
        {
            var data = base.ReadData();
            // This simulates the decompression step
            return $"Decompressed Data: {data}";
        }

        public override void WriteData(string data)
        {
            // This simulates the compression step
            var compressedData = $"Compressed Data: {data}";
            base.WriteData(compressedData);
        }
    }
}
