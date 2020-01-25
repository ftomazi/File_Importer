using System;
using System.Collections.Generic;

namespace FileImporter
{
    class Program
    {
        static void Main(string[] args)
        {
            var monitor = new FileManager();
            List<string> fileList = monitor.GetAllDatFiles(Configuration.InputPath);
            ServicePool.ProcessFiles(fileList);

            FileManager.MonitorDirectory(Configuration.InputPath);
            Console.WriteLine("Monitoring...");
            Console.ReadKey();
        }
    }
}
