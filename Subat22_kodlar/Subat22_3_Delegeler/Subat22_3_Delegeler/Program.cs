using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subat22_3_Delegeler
{// Delegate:Temsilci
    class Program
    {

        delegate void temsilci();

       static public void Mesaj()
        {
            Console.WriteLine("mesaj");
        }

       static public void Gunaydın()
        {
            Console.WriteLine("Gunaydın");
        }

        
        public void Merhaba(string str) {
            Console.WriteLine("merhaba+ str");
        }
       
        public String Hi()
        {
            return "Hi";
;        }
        static void Main(string[] args)
        {
            //delege olusturma, metot ekleme çıkarma çalıştırmayı gorduk.
            temsilci t = new temsilci(Mesaj);  //delegeye metot bağladım. 

            t += Mesaj;
            t += Gunaydın;

            //t+=Hi;   //return type yanlış

            // t+=Merhaba;

            //t -= Mesaj;

            //t();  //Mtodları çağırma işlemi.

            foreach (Delegate del in t.GetInvocationList())
            {
                //Console.WriteLine(del.Method.Name);

                //bu kısmı anlayamadım tam.
                if (del.Method.Name != "Mesaj")
                    del.DynamicInvoke();

            }  

        }
    }
}
