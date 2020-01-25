using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FileImporter
{
    public class FileManager
    {
        public List<string> GetAllDatFiles(string fullPath)
        {
            DirectoryInfo dir = new DirectoryInfo(fullPath);

            if (!dir.Exists)
                dir.Create();

            return dir.GetFiles()
                .Where(p => p.Extension.Equals(Configuration.fileExtension, StringComparison.InvariantCultureIgnoreCase))
                .Select(p => p.Name).ToList();
        }

        public static void WriteOutput(string fileName, string output)
        {
            string fileNameOut = string.Concat(fileName.Substring(0, fileName.Length - 4), ".done", Configuration.fileExtension);

            DirectoryInfo dir = new DirectoryInfo(Configuration.OutputPath);

            if (!dir.Exists)
                dir.Create();

            File.WriteAllText(Configuration.OutputPath + fileNameOut, output);
        }

        public static void MonitorDirectory(string path)
        {
            FileSystemWatcher fileWatcher = new FileSystemWatcher();
            fileWatcher.Path = path;

            fileWatcher.Created += FileSystemWatcher_Created;
            fileWatcher.EnableRaisingEvents = true;
        }

        private static void FileSystemWatcher_Created(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("File created: {0}", e.Name);

            var fileList = new List<string>();
            fileList.Add(e.Name);

            ServicePool.ProcessFiles(fileList);
        }

    }
}
