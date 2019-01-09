using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInventoryProject
{
    class Product
    {
        int Id;
        public double Price;
        int Quanity;
        public string ProductName { get; set; }
        public Product(string name)
        {
            ProductName = name;
        }

        public Product(int id, string name, double price, int quanity )
        {
            
            Id = id;
            Price = price;
            Quanity = quanity;
        }
    }


}
