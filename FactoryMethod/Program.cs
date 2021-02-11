namespace FactoryMethod
{
    public class Program
    {
        private static IFileWriterFactory _jpegWriterFactory = new JpegWriterFactory();

        private static IFileWriterFactory _pngWriterFactory = new PngWriterFactory();

        public static void Main(string[] args)
        {
            IFileWriter writer;
            byte[] data = new byte[1024];

            if ("jpeg" == args[0])
            {
                writer = _jpegWriterFactory.Create();
            }
            else
            {
                writer = _pngWriterFactory.Create();
            }

            writer.Write(data, "lena");
        }
    }
}