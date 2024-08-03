using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Month> months = new List<Month>
            {
                new Month ("January", 1, 31),
                new Month("February", 2, 28),
                new Month("March", 3, 31),
                new Month("April", 4, 30),
                new Month("May", 5, 31),
                new Month("June", 6, 30),
                new Month("July", 7, 31),
                new Month("August", 8, 31),
                new Month("September", 9, 30),
                new Month("October", 10, 31),
                new Month("November", 11, 30),
                new Month("December", 12, 31)
            };

            int searchMonthNumber = 5;
            var resultMonth = from month in months
                         where month.Number == searchMonthNumber
                         select month;

            Console.WriteLine($"{searchMonthNumber} month is:");
            
            foreach (var month in resultMonth) { 
                Console.WriteLine($"{month.Name} - {month.Days}");
            }

            Console.WriteLine("_________________________");

            int searchDays = 31;
            var resultDays = from month in months
                         where month.Days  == searchDays
                         select month;
            
            Console.WriteLine($"{searchDays} days in:");
            
            foreach (var day in resultDays) 
            {
                Console.WriteLine($"{day.Name} is {day.Number}");
            }

            Console.ReadKey();
        }
    }
}
