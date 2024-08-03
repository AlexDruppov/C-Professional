using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Word
    {
        public string English { get; set; }
        public string German { get; set; }
        
        public Word(string german, string english)
        {
            English = english;
            German = german;
            
        }
    }
}
