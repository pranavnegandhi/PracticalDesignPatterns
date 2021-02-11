namespace FactoryMethod
{
    public class JpegWriterFactory : IFileWriterFactory
    {
        public IFileWriter Create()
        {
            return new JpegWriter();
        }
    }
}