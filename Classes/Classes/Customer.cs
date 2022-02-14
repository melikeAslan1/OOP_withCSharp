using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Customer
    {


        //field:
        //public string FirstName;

        private string _firstName;
        // property:
        public string FirstName 
        { 
            get 
            {
                return "Mr. "+_firstName;
            }        
            set 
            {
                _firstName = value;
            } 
        }     // encapsulation için gerekli.
        // bi class ın içinde özellik tanımlarken field değil property tanımlamalıyım.
        //prop + tab
        public int Id { get; set; }   // bu bir property dir. müşterinin özellikleri bunun içinde tutulur.
        public string LastName { get; set; }
        public string City { get; set; }
        





    }
}
