using FileImporter.Entities;
using System;

namespace FileImporter
{
    public class SalesParser
    {
        public static Sales Parse(string line)
        {
            string[] splitedLine = line.Split(Configuration.lineSeparator);
            Sales sale = null;  

            if (splitedLine.Length == 4)
            {
                sale = new Sales();
                sale.Id = Convert.ToInt32(splitedLine[1]);
                sale.Itens = SaleIten.Parse(splitedLine[2]);
                sale.SalesName = splitedLine[3];
            }

            return sale;
        }        
    }    
}
