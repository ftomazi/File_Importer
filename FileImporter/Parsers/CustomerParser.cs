using FileImporter.Entities;

namespace FileImporter
{
    public class CustomerParser
    {
        public static Customer Parse(string line)
        {
            string[] splitedLine = line.Split(Configuration.lineSeparator);
            Customer customer = null;

            if (splitedLine.Length == 4)
            {
                customer = new Customer();
                customer.Cnpj = splitedLine[1];
                customer.Name = splitedLine[2];
                customer.Area = splitedLine[3];
            }

            return customer;
        }
    }
}
