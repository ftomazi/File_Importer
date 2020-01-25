using System.IO;

namespace FileImporter
{
    public static class Configuration
    {
        public const char lineSeparator = ';';
        public const char itenSeparator = ',';
        public const string fileExtension = ".dat";
        private const string inputPath = @"\data\in\";
        private const string outputPath = @"\data\out\";
                
        public static string InputPath
        {
            get
            {
                return string.Concat(Directory.GetCurrentDirectory(), inputPath);
            }
        }

        public static string OutputPath
        {
            get
            {
                return string.Concat(Directory.GetCurrentDirectory(), outputPath);
            }
        }
    }
}
