namespace FactoryMethod
{
    public class PngWriter : IFileWriter
    {
        public void Write(byte[] data, string filename)
        {
            // Encode image data to PNG format and write to disk.
            System.Console.WriteLine($"Encoding image data in byte[] {nameof(data)} into PNG format and writing to file {filename}.png");
        }
    }
}