using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager c = new CustomerManager();
            c.Add();

            Customer customer = new Customer();

            customer.City = "Ankara";
            customer.FirstName ="Engin";
            customer.Id =1;
            customer.LastName ="Demiroğ";

            Customer customer2 = new Customer
            {
                // ctrl+space
                Id=2, City ="izmir", FirstName="melike", LastName="aslan"
            };

            Console.WriteLine(customer2.FirstName);


        }
    }

    
}
