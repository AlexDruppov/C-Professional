using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class ProductList
    {
        public string Category {  get; set; }
        
        public ProductList(string category) {
            Category = category;
        }
    }
}
