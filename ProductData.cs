using System;
using System.Collections.Generic;

namespace lesson13_14
{
    public interface IProductData
    {
        public void Product();
        public void AddProduct();
        

    }

    class ProductInfo : IProductData
    {
        
        List<string> AllProduct = new List<string> { "IPhone, ID = [1]", "IPad ID = [2]", "Microsoft Surface ID = [3]", "MacBook Pro ID = [4]" };
        void IProductData.Product()//since the class realize only one interface - so no need to define the interface name
        {
           foreach (string item in AllProduct)
           {
               Console.WriteLine(item);

           }


        }
            
        
        void IProductData.AddProduct()//since the class realize only one interface - so no need to define the interface name
        {
            string NewProduct;
            Console.WriteLine("New product info: ");
            NewProduct = Console.ReadLine();

            AllProduct.Add(NewProduct);
            Console.WriteLine("New item added!");


        }
        

            
    }
}

