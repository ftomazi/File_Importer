using FileImporter.Entities;

namespace FileImporter
{
    public class Processor
    {
        public Processor(Report report)
        {
            this.ReportResult = report;
        }

        public Report ReportResult { get; set; }

        public void Process(Customer obj)
        {
            if (!(obj is null))
                ReportResult.AddCustomer();
        }

        public void Process(SalesMan obj)
        {
            if (!(obj is null))
                ReportResult.AddSalesMan();
        }

        public void Process(Sales obj)
        {
            if (!(obj is null))
            {
                ReportResult.UpdateWorstrSaleMan(obj);
                ReportResult.UpdateMaxSale(obj);
            }
        }
        
    }
}
