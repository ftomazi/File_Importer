using FileImporter.Entities;

namespace FileImporter
{
    public class Report
    {
        public int CountCustomers { get; private set; }
        public int CountSalesMans { get; private set; }
        public int IdMajorSale { get; private set; }
        public string WorstSaleMan { get; private set; }
        private decimal? ValueWorstSaleMan { get; set; }
        private decimal ValueMajorSale { get; set; }

        public void AddCustomer()
        {
            this.CountCustomers++;
        }

        public void AddSalesMan()
        {
            this.CountSalesMans++;
        }

        public void UpdateWorstrSaleMan(Sales obj)
        {
            decimal totalSale = obj.TotalSale;

            if (this.ValueWorstSaleMan is null || totalSale < this.ValueWorstSaleMan)
            {
                this.WorstSaleMan = obj.SalesName;
                this.ValueWorstSaleMan = totalSale;
            }
        }

        public void UpdateMaxSale(Sales obj)
        {
            decimal totalSale = obj.TotalSale;

            if (totalSale > this.ValueMajorSale)
            {
                this.ValueMajorSale = totalSale;
                this.IdMajorSale = obj.Id;
            }
        }

    }
}
