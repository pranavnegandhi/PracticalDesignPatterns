namespace FactoryMethod
{
    public interface IFileWriter
    {
        void Write(byte[] data, string filename);
    }
}