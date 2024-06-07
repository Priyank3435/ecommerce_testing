using NUnit.Framework;
using System;

namespace Assignment2_Software_Quality.Test
{
    [TestFixture]
    public class ProductTests
    {
        [Test]
        public void ProductId_WhenIdIs54_ShouldBeGreaterThanOrEqualTo4()
        {
            // Arrange
            int inputId = 54;
            var product = new Product(inputId, "ITEM1", 23.99m, 24225);


            // Act
            var result = product.ProductID;

            // Assert
            Assert.That(result, Is.GreaterThanOrEqualTo(4));
        }

        [Test]
        public void ProductId_WhenIdIs234_ShouldBeInRange()
        {
            // Arrange
            int inputId = 234;
            var product = new Product(inputId, "ITEM2", 232.99m, 124215);

            // Act
            var result = product.ProductID;


            // Assert
            Assert.That(result, Is.InRange(4, 40000));
        }


        [Test]
        public void ProductId_WhenIdIs40000_ShouldEqualInputValue()
        {
            // Arrange
            int inputId = 40000;
            var product = new Product(inputId, "ITEM3", 4332.99m, 2345);

            // Act
            var result = product.ProductID;

            // Assert
            Assert.That(result == inputId, Is.EqualTo(true));
        }

        [Test]
        public void ProductName_WhenNameIsItem4_ShouldMatchInputName()
        {
            // Arrange
            var inputName = "ITEM4";
            var product = new Product(23, inputName, 642.99m, 1245);

            // Act
            var result = product.ProductName;

            // Assert
            Assert.That(result == inputName, Is.EqualTo(true));
        }


        [Test]
        public void ProductName_WhenNameIsEmptyString_ShouldNotBeEmpty()
        {
            // Arrange
            var inputName = "";
            var product = new Product(23, inputName, 232.99m, 25);

            // Act
            var result = product.ProductName;

            // Assert
            Assert.That(result != "", Is.EqualTo(false));
        }

        [Test]
        public void ProductName_WhenNameIsLongString_ShouldMatchInputName()
        {
            // Arrange
            var inputName = "ITEM with Longer Name for Test As you are allow to add";
            var product = new Product(23, inputName, 12.99m, 22);

            // Act

            var result = product.ProductName;

            // Assert
            Assert.That(result == inputName, Is.EqualTo(true));
        }

        [Test]
        public void ProductPrice_WhenPriceIs34m_ShouldMatchInputPrice()
        {
            // Arrange
            var inputPrice = 34m;
            var product = new Product(23, "ITEM7", inputPrice, 1245);

            // Act
            var result = product.Price;

            // Assert
            Assert.That(result == inputPrice, Is.EqualTo(true));
        }

        [Test]
        public void ProductPrice_WhenPriceIs4m_ShouldBeGreaterThanOrEqualTo4()
        {
            // Arrange
            var inputPrice = 4m;
            var product = new Product(23, "ITEM8", inputPrice, 3455);

            // Act
            var result = product.Price;

            // Assert
            Assert.That(result, Is.GreaterThanOrEqualTo(4));
        }

        [Test]
        public void ProductPrice_WhenPriceIs4000m_ShouldBeInRange()
        {
            // Arrange
            var inputPrice = 4000m;
            var product = new Product(23, "ITEM9", inputPrice, 24554);

            // Act

            var result = product.Price;

            // Assert
            Assert.That(result, Is.InRange(4, 40000));
        }

        [Test]
        public void ProductStock_WhenStockIs298945_ShouldBeInRange()
        {
            // Arrange
            var inputStock = 298945;
            var product = new Product(23, "ITEM10", 332m, inputStock);


            // Act
            var result = product.Stock;

            // Assert
            Assert.That(result, Is.InRange(4, 400000));
        }


        [Test]
        public void ProductStock_WhenStockIs3_ShouldNotBeGreaterThan3()
        {
            // Arrange
            var inputStock = 3;
            var product = new Product(23, "ITEM11", 12m, inputStock);


            // Act
            var result = product.Stock;

            // Assert
            Assert.That(result > 3, Is.EqualTo(false));
        }

        [Test]
        public void ProductStock_WhenStockIs40030_ShouldEqualInputStock()
        {
            // Arrange
            var inputStock = 40030;
            var product = new Product(23, "ITEM12", 134m, inputStock);

            // Act

            var result = product.Stock;


            // Assert
            Assert.That(result.Equals(inputStock), Is.EqualTo(true));
        }

        [Test]
        public void IncrementStock_WhenIncreasedBy40_ShouldEqual380()
        {
            // Arrange
            var inputStock = 340;
            var product = new Product(23, "ITEM13", 139m, inputStock);

            // Act
            product.IncreaseStockCount(40);
            var result = product.Stock;

            // Assert
            Assert.That(result, Is.EqualTo(380));
        }


        [Test]
        public void IncrementStock_WhenIncreasedTo300000_ShouldBeLessThanOrEqualTo400000()
        {
            // Arrange
            var inputStock = 100000;
            var product = new Product(23, "ITEM14", 130m, inputStock);

            // Act
            product.IncreaseStockCount(300000);
            var result = product.Stock;

            // Assert
            Assert.That(result, Is.LessThanOrEqualTo(400000));
        }
        
        [Test]
        public void IncrementStock_WhenIncreasedByNegativeValue_ShouldNotChangeStock()
        {
            // Arrange
            var inputStock = 8734;
            var product = new Product(23, "ITEM15", 324m, inputStock);

            // Act
            product.IncreaseStockCount(-100);

            var result = product.Stock;

            // Assert
            Assert.That(result, Is.EqualTo(inputStock));
        }


        [Test]
        public void DecrementStock_WhenDecreasedBy434_ShouldEqual3000()
        {
            // Arrange
            var inputStock = 3434;
            var product = new Product(23, "ITEM16", 643m, inputStock);

            // Act
            product.DecreaseStockCount(434);
            var result = product.Stock;


            // Assert
            Assert.That(result, Is.EqualTo(3000));
        }

        [Test]
        public void DecrementStock_WhenDecreasedToNegative_ShouldNotChangeStock()
        {
            // Arrange
            var inputStock = 10;
            var product = new Product(23, "ITEM17", 1340m, inputStock);


            // Act
            product.DecreaseStockCount(200);
            var result = product.Stock;

            // Assert
            Assert.That(result, Is.EqualTo(inputStock));
        }

        [Test]
        public void DecrementStock_WhenDecreasedByNegativeValue_ShouldNotChangeStock()
        {
            // Arrange
            var inputStock = 2387;
            var product = new Product(23, "ITEM18", 3134m, inputStock);

            // Act
            product.DecreaseStockCount(-1392);
            var result = product.Stock;


            // Assert
            Assert.That(result, Is.EqualTo(inputStock));
        }
    }
}
