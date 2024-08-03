using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderedDictionary dictionary = new OrderedDictionary();

            dictionary.Add("Acconut1", 159.99);
            dictionary.Add("Acconut2", 100.36);
            dictionary.Add("Acconut3", 111.98);

            foreach(DictionaryEntry entry in dictionary)
            {
                Console.WriteLine($"{entry.Key} - {entry.Value}");
            }

            var sorted = GetValue(dictionary);

            foreach(var item in sorted)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
        static List<double> GetValue(OrderedDictionary ordered)
        {
            List<double> result = new List<double>();

            foreach (DictionaryEntry item in ordered)
            {
                result.Add((double)item.Value);
            }
            result.Sort();
            return result;

        }
    }
}
