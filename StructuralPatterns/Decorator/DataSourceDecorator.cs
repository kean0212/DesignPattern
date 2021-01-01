namespace StructuralPatterns.Decorator
{
    public class DataSourceDecorator : IDataSource
    {
        private readonly IDataSource _wrapee;

        public DataSourceDecorator(IDataSource source)
        {
            _wrapee = source;
        }

        public virtual string ReadData()
        {
            return _wrapee.ReadData();
        }

        public virtual void WriteData(string data)
        {
            _wrapee.WriteData(data);
        }
    }
}
