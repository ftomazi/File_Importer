using System;
using System.Collections.Generic;
using System.Threading;

namespace FileImporter
{
    public class ServicePool
    {
        public static void ProcessFiles(List<string> files)
        {
            foreach (var item in files)
            {
                if (item.Substring(item.Length -4, 4).Equals(Configuration.fileExtension, StringComparison.InvariantCultureIgnoreCase))
                    ThreadPool.QueueUserWorkItem(new WaitCallback(Process), item);
            }
        }

        static void Process(object callback)
        {
            Console.WriteLine("CallBack: " + callback.ToString());

            var fileName = callback.ToString();
            var processor = new Processor(new Report());
            var file = new System.IO.StreamReader(Configuration.InputPath + fileName);
            string line = string.Empty;

            while ((line = file.ReadLine()) != null)
            {
                if (line.Length < 3)
                    continue;

                string type = line.Substring(0, 3);
                switch (type)
                {
                    case "001":
                        processor.Process(SalesManParser.Parse(line));
                        break;
                    case "002":
                        processor.Process(CustomerParser.Parse(line));
                        break;
                    case "003":
                        processor.Process(SalesParser.Parse(line));
                        break;
                    default:
                        break;
                }
            }

            string outPut = string.Format("Count Customers:{0}; Count salesMan:{1}; ID Major sale:{2}; Worst saleMan:{3}",
                processor.ReportResult.CountCustomers,
                processor.ReportResult.CountSalesMans,
                processor.ReportResult.IdMajorSale,
                processor.ReportResult.WorstSaleMan);

            Console.WriteLine(outPut);
            FileManager.WriteOutput(fileName, outPut);
        }
    }
}
