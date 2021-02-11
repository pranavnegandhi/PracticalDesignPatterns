namespace FactoryMethod
{
    public interface IFileWriterFactory
    {
        public IFileWriter Create();
    }
}