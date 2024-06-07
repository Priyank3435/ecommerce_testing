using NUnit.Framework;
using Assignment2_Software_Quality;
using NUnit.Framework.Interfaces;

namespace Assignment2_Software_Quality.Test
{
    [TestFixture]
    public class ProductTests
    {   
        [Test]
        public void ProductId_54_True()
        {
            int inputId = 54;
            var product = new Product(inputId, "ITEM1", 23.99m, 24225);
            var expectedResult = product.ProductID;
            Assert.That(expectedResult, Is.GreaterThanOrEqualTo(4));
        }

        [Test]
        public void ProductId_234_True()
        {
            int inputId = 234;
            var product = new Product(inputId, "ITEM2", 232.99m, 124215);
            Assert.That(product.ProductID, Is.InRange(4, 40000));
        }

        [Test]
        public void ProductId_40000_True()
        {
            int inputId = 40000;
            var product = new Product(inputId, "ITEM3", 4332.99m, 2345);
            var expectedResult = true;
            Assert.That(product.ProductID == inputId, Is.EqualTo(expectedResult));
        }

        [Test]
        public void ProductName_ITEM4_True()
        {
            var inputName = "ITEM4";
            var product = new Product(23, inputName, 642.99m, 1245);
            var expectedResult = true;
            Assert.That(product.ProductName == inputName, Is.EqualTo(expectedResult));
        }

        [Test]
        public void ProductName_EmptyString_False()
        {
            var inputName = "";
            var product = new Product(23, inputName, 232.99m, 25);
            var expectedResult = false;
            Assert.That(product.ProductName != "", Is.EqualTo(expectedResult));
        }

        [Test]
        public void ProductName_LongString_True()
        {
            var inputName = "ITEM with Longer Name for Test As you are allow to add";
            var product = new Product(23, inputName, 12.99m, 22);
            var expectedResult = true;
            Assert.That(product.ProductName == inputName, Is.EqualTo(expectedResult));
        }

        [Test]
        public void ProductPrice_34m_True()
        {
            var inputPrice = 34m;
            var product = new Product(23, "ITEM7", inputPrice, 1245);
            var expectedResult = true;
            Assert.That(product.Price == inputPrice, Is.EqualTo(expectedResult));
        }

        [Test]
        public void ProductPrice_4m_True()
        {
            var inputPrice = 4m;
            var product = new Product(23, "ITEM8", inputPrice, 3455);
            Assert.That(product.Price, Is.GreaterThanOrEqualTo(4));
        }

        [Test]
        public void ProductPrice_4000m_True()
        {
            var inputPrice = 4000m;
            var product = new Product(23, "ITEM9", inputPrice, 24554);
            Assert.That(product.Price, Is.InRange(4, 40000));
        }

        [Test]
        public void ProductStock_298945_True()
        {
            var inputStock = 298945;
            var product = new Product(23, "ITEM10", 332m, inputStock);
            Assert.That(product.Stock, Is.InRange(4, 400000));
        }
        [Test]
        public void ProductStock_3_False()
        {
            var inputStock = 3;
            var product = new Product(23, "ITEM11", 12m, inputStock);
            var expectedResult = false;
            Assert.That(product.Stock > 3, Is.EqualTo(expectedResult));
        }
        [Test]
        public void ProductStock_40030_True()
        {
            var inputStock = 40030;
            var product = new Product(23, "ITEM12", 134m, inputStock);
            var expectedResult = true;
            Assert.That(product.Stock.Equals(40030), Is.EqualTo(expectedResult));
        }

        [Test]
        public void IncrementStock_340_380()
        {
            var inputStock = 340;
            var product = new Product(23, "ITEM13", 139m, inputStock);
            product.IncreaseStockCount(40);
            var expectedResult = 380;
            Assert.That(product.Stock, Is.EqualTo(expectedResult));
        }

        [Test]
        public void IncrementStock_100000_True()
        {
            var inputStock = 100000;
            var product = new Product(23, "ITEM14", 130m, inputStock);
            product.IncreaseStockCount(300000);
            Assert.That(product.Stock, Is.LessThanOrEqualTo(400000));
        }

        [Test]
        public void IncrementStock_8734_8734()
        {
            var inputStock = 8734;
            var product = new Product(23, "ITEM15", 324m, inputStock);
            product.IncreaseStockCount(-100);
            var expectedResult = 8734;
            Assert.That(product.Stock, Is.EqualTo(expectedResult));
        }

        [Test]
        public void DecrementStock_3434_3000()
        {
            var inputStock = 3434;
            var product = new Product(23, "ITEM16", 643m, inputStock);
            product.DecreaseStockCount(434);
            var expectedResult = 3000;
            Assert.That(product.Stock, Is.EqualTo(expectedResult));
        }

        [Test]
        public void DecrementStock_10_10()
        {
            var inputStock = 10;
            var product = new Product(23, "ITEM17", 1340m, inputStock);
            product.DecreaseStockCount(200);
            var expectedResult = 10;
            Assert.That(product.Stock, Is.EqualTo(expectedResult));
        }

        [Test]
        public void DecrementStock_2387_2387()
        {
            var inputStock = 2387;
            var product = new Product(23, "ITEM18", 3134m, inputStock);
            product.DecreaseStockCount(-1392);
            var expectedResult = 2387;
            Assert.That(product.Stock, Is.EqualTo(expectedResult));
        }
    }
}