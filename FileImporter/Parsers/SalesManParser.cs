using FileImporter.Entities;
using System;

namespace FileImporter
{
    public class SalesManParser
    {
        public static SalesMan Parse(string line)
        {
            string[] splitedLine = line.Split(Configuration.lineSeparator);
            SalesMan saleman = null; 

            if (splitedLine.Length == 4)
            {
                saleman = new SalesMan();
                saleman.Cpf = splitedLine[1]; //TODO: Utils.TrataValidaCPF(splitedLine[1]);
                saleman.Name = splitedLine[2];
                saleman.Salary = Convert.ToDecimal(splitedLine[3], new System.Globalization.CultureInfo("en-US"));
            }

            return saleman;
        }
    }
}
