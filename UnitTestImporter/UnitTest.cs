using FileImporter.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestImporter
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethodTotalSale()
        {
            var sale = new Sales();
            var item1 = new SaleIten();
            var item2 = new SaleIten();

            item1.Price = 22.22M;
            item1.Quantity = 44;

            item2.Price = 11.01M;
            item2.Quantity = 2;

            decimal fakeTotal = (item1.Price * item1.Quantity);
            fakeTotal += (item2.Price * item2.Quantity);

            sale.Itens.Add(item1);
            sale.Itens.Add(item2);

            Assert.AreEqual(fakeTotal, sale.TotalSale);
        }

        [TestMethod]
        public void TestMethodSaleItenParsePrice()
        {
            string lineInput = "1-44-22.22";
            decimal priveValue = 22.22M;

            var resultItem = SaleIten.Parse(lineInput);
            SaleIten ff = resultItem[0];

            Assert.AreEqual(priveValue, ff.Price);
        }
    }
}
