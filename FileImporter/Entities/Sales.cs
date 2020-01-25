using System.Collections.Generic;
using System.Linq;

namespace FileImporter.Entities
{
    public class Sales
    {
        public Sales()
        {
            Itens = new List<SaleIten>();
        }

        public int Id { get; set; }
        public List<SaleIten> Itens { get; set; }
        public string SalesName { get; set; }

        public decimal TotalSale
        {
            get
            {
                return Itens.Sum(p => p.Total);
            }
        }
    }
}
