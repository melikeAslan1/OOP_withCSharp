using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subat18_Interfaces
{
    interface IArayüz {

        void IslemA();

    }

    class Deneme: IArayüz
    {
        public void IslemA()
        {
           


        }

        public void MethodA()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Interfaces
            Deneme deneme = new Deneme();

            IArayüz deneme2 = new Deneme();

            deneme2.IslemA();

            



            

        }
    }
}
