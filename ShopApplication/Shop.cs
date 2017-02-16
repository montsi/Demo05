using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApplication
{
    class Shop
    {
        public string Name { get; set; }
        private List<Product> products;

        public Shop()
        {
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void PrintData()
        {
            Console.WriteLine("Name: " + Name);
            foreach (Product product in products)
            {
                Console.WriteLine(" - " + product.ToString());
            }
        }
    }
}
