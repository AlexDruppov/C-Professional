using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, double> ammount = new Dictionary<int, double>();

            ammount.Add(122221, 15000.75);
            ammount.Add(233332, 19990.75);
            ammount.Add(344443, 9571.74);

            foreach (var item in ammount) 
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            Console.ReadKey();
        }
    }
}
