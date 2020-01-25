using System;
using System.Collections.Generic;

namespace FileImporter.Entities
{
    public class SaleIten    {

        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public static List<SaleIten> Parse(string input)
        {
            var saleItens = new List<SaleIten>();
            string[] itensSplited = input
                .Replace("[", string.Empty)
                .Replace("]", string.Empty)
                .Split(Configuration.itenSeparator);

            foreach (var item in itensSplited)
            {
                saleItens.Add(SaleItenParse(item));
            }
            return saleItens;
        }

        public static SaleIten SaleItenParse(string input)
        {
            string[] itemSplited = input.Split('-');
            SaleIten sale = null;

            if (itemSplited.Length == 3)
            {
                sale = new SaleIten();
                sale.Id = Convert.ToInt32(itemSplited[0]);
                sale.Quantity = Convert.ToInt32(itemSplited[1]);
                sale.Price = Convert.ToDecimal(itemSplited[2], new System.Globalization.CultureInfo("en-US"));
            }

            return sale;
        }

        public decimal Total
        {
            get
            {
                return Quantity * Price;
            }
        }
    }
}
