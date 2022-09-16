using System;
using System.Collections.Generic;
using System.Linq;

namespace lesson13_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ICustomerInfo b = new CustomerData();
            b.Customer();
           
            IProductData c = new ProductInfo();
            c.Product();
            b.CustomerOrder();

            Console.WriteLine("Would you like to add new product?\nPress 'Enter' to continue");
            Console.ReadKey();
            c.AddProduct();
            
        }
    }
}
  