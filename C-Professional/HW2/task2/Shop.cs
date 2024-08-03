using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Shop
    {
        private Dictionary<CustomerList, List<ProductList>> customerlist = new Dictionary<CustomerList, List<ProductList>>();
        private Dictionary<ProductList, List<CustomerList>> productlist = new Dictionary<ProductList, List<CustomerList>>();

        public void AddThings(CustomerList customer, ProductList product)
        {
            if (!customerlist.ContainsKey(customer))
            {
                customerlist[customer] = new List<ProductList>();
            }
            if (!productlist.ContainsKey(product))
            {
                productlist[product] = new List<CustomerList>();
            }

            customerlist[customer].Add(product);
            productlist[product].Add(customer);
        }

        public List<ProductList> GetProducts(CustomerList customer)
        {
            {
                if (customerlist.TryGetValue(customer, out var products))
                {
                    return products;
                }
                return new List<ProductList>();
            }
        }

        public List<CustomerList> GetCustomers(ProductList prod)
        {
            if (productlist.TryGetValue(prod, out var customers))
            {
                return customers;
            }
            return new List<CustomerList>();
        }
    }
}
