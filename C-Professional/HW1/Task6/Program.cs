using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (var box in SquaresMethod.GetSquare(numbers))
            {
                Console.WriteLine(box);
            }

            Console.ReadKey();
        }
    }
}
