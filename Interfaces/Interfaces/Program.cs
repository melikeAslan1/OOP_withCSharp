using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            //PersonManager manager = new PersonManager();
            //Customer customer = new Customer
            //{
            //    Id = 1,
            //    FirstName = "Engin",
            //    LastName = "Demiroğ",
            //    Address = "Ankara",
            //};

            //Student student = new Student
            //{
            //    Id = 1,
            //    FirstName = "Engin",
            //    LastName = "Demiroğ",

            //};

            //manager.Add(student);




            //  IPerson person = new IPerson();     --HATA VERİR ÇÜNKÜ BİR İNTERFACE İN İNSTANCE INI OLUŞTURAMAZSIN.

            IPerson person = new Student();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());



        }
    }

    // soyut nesne:
    interface IPerson
    {
        //interface in amacı bir nesne oluşturup diğer nesneleri ondan implemente etmektir.
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

    }

    //somut nesne: customer ve student
    class Customer : IPerson
    {
       

        public string Address { get; set; }
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    class Student : IPerson
    {
        public string Departmant { get; set; }
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}

