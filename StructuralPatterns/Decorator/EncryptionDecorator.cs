namespace StructuralPatterns.Decorator
{
    public class EncryptionDecorator : DataSourceDecorator
    {
        public EncryptionDecorator(IDataSource source) : base(source)
        {
        }

        public override string ReadData()
        {
            var data = base.ReadData();
            // This simulates the decryption step
            return $"Decrypted Data: {data}";
        }

        public override void WriteData(string data)
        {
            // This simulates the encryption step
            var encryptedData = $"Encrypted Data: {data}";
            base.WriteData(encryptedData);
        }
    }
}
