using System.IO.Compression;


namespace Entites
{
    public class Zip
    {
        public static void ZipDirectory(string sourceDir, string zipFilePath)
        {
            ZipFile.CreateFromDirectory(sourceDir, zipFilePath);
        }
    }
}