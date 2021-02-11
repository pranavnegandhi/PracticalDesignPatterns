namespace FactoryMethod
{
    public class JpegWriter : IFileWriter
    {
        public void Write(byte[] data, string filename)
        {
            // Encode image data to JPEG format and write to disk.
            System.Console.WriteLine($"Encoding image data in byte[] {nameof(data)} into JPEG format and writing to file {filename}.jpeg");
        }
    }
}