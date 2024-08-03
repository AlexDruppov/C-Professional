using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class SquaresMethod
    {
        public static IEnumerable<int> GetSquare(int[] numb)
        {
            foreach (int i in numb) 
            {
                if (i % 2 != 0)
                {
                    yield return i * i;
                }
            }
        }
    }
}
