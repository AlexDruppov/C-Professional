using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, double> sorted = new SortedList<string, double>();

            sorted.Add("Mustang", 25600);
            sorted.Add("Corvete", 45000);
            sorted.Add("Camaro", 21000);

            foreach (var item in sorted)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            for (int i = sorted.Count -1; i >=0; i--)
            {
                Console.WriteLine($"{sorted.Keys[i]} - {sorted.Values[i]}");
            }

            Console.ReadKey();
        }
    }
}
