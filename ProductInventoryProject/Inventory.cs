using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInventoryProject
{
    class Inventory
    {
        private readonly List<Product> ProductLs = new List<Product>();

        public readonly int NumberOfProducts;
        // Class of 5 unique Customer names
        public Inventory()
        {
            ProductLs.Add(new Product(1, "Product 1", 1.11, 100));
            ProductLs.Add(new Product(2, "Product 2", 2.22, 200));
            ProductLs.Add(new Product(3, "Product 3", 3.33, 300));
            ProductLs.Add(new Product(4, "Product 4", 4.44, 400));
            // Counts the list of Customer(s) and sets it to the NumberOfCustomersInLine
            NumberOfProducts = ProductLs.Count;
        }

        public string ProductCount()
        {
            return ProductLs.Count.ToString();
        }

        public void Add(Product c)
        {
            ProductLs.Add(c);
        }
        // Method for searching the internal list of customers and removes if it is found
        public void Remove(Product c)
        {
            ProductLs.RemoveAll(x => x.ProductName == c.ProductName);
        }


        //public static int GetUnitCount() => Product.Select(x => x.Quantity).Sum();

        //public static decimal GetInventoryValue() => Product.Select(x => (x.Price * x.Quantity)).Sum();
    }


}
