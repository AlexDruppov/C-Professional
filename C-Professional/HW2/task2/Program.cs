using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();

            CustomerList customer1 = new CustomerList("Alex Great");
            CustomerList customer2 = new CustomerList("Jhon Bond");

            ProductList product1 = new ProductList("Cars");
            ProductList product2 = new ProductList("Books");

            shop.AddThings(customer1, product1);
            shop.AddThings(customer2, product2);
            

            Console.WriteLine($"{customer1.Name} bought:");
            foreach (var box in shop.GetProducts(customer1))
            {
                Console.WriteLine(box.Category);
            }

            Console.WriteLine($"Customer who bought {product1.Category}:");
            foreach (var box in shop.GetCustomers(product1))
            {
                Console.WriteLine(customer1.Name);
            }

            Console.ReadKey();
        }
    }
}
