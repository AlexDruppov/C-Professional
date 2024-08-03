using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Month
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public int Days { get; set; }

        public Month(string name, int number, int days) 
        {
            Name = name;
            Number = number;
            Days = days;
        }
    }
}
