using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product { Name = "Soda", Price = "1,29" };
            Product product2 = new Product { Name = "Candy bar", Price = "2,30" };
            Product product3 = new Product { Name = "Potato chips", Price = "2,59" };

            Shop shop = new Shop { Name = "Prisma"};

            shop.AddProduct(product1);
            shop.AddProduct(product2);
            shop.AddProduct(product3);

            shop.PrintData();
        }
    }
}
