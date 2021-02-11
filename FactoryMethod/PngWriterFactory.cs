namespace FactoryMethod
{
    public class PngWriterFactory : IFileWriterFactory
    {
        public IFileWriter Create()
        {
            return new PngWriter();
        }
    }
}