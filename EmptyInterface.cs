using System;
namespace lesson13_14
{
    public interface ICustomerInfo 
    {
        public void Customer();
        public void CustomerOrder();

    }

    class CustomerData : ICustomerInfo
    {
        string CustomerName;
        int CustomerOrder;
        int PersonalNumber;
        void ICustomerInfo.Customer()
        {
            Console.WriteLine("Please enter your name:");
            CustomerName = Console.ReadLine();
            Random rnd = new Random();


            PersonalNumber = rnd.Next();
            
            Console.WriteLine($"Dear {CustomerName}, your personal information save!\nYour personal ID is: {PersonalNumber}");

        }
        
        void ICustomerInfo.CustomerOrder()
        {
            Console.WriteLine("Choose product to order by ID of product!");
            CustomerOrder = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Order complete! Please wait!");

        }
        
        

    }
}

