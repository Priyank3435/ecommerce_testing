using System;

namespace Assignment2_Software_Quality
{
    namespace Groccery
    {
        public class Product
        {
            public int ProductID { get; set; }
            public string ProductName { get; set; }
            public decimal Price { get; set; }
            public int Stock { get; set; }

            public Product(int productId, string productName, decimal price, int stock)
            {
                ProductID = productId;
                ProductName = productName;
                Price = price;
                Stock = stock;
            }

            public void DecreaseStockCount(int stock)
            {
                if (stock > 0)
                {
                    Stock += stock;
                }
            }

            public void DecreaseStockCount(int stock)
            {
                if (stock > 0 && Stock >= stock)
                {
                    Stock -= stock;
                }
            }
           
        }
    }

}
