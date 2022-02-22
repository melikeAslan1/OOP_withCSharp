using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15Subat
{
    class Personel
    {
      private int id;

      public int getID()
        {
            return id;
        }

        public void setID(int _id)
        {
            id = _id;
        }

        //özellik-property
        string _perAd;

        public string PerAd
        {
            get { return _perAd; }
            set { _perAd = value; }
            //compiler get i ve set i arkada metot a cevirir. 
            // class içinde değişken tanımlanırken başın abişey yazmazsan otomatik private olur. 
        }

        // C# 3.0 sonrası

        public decimal Maas { get; set; }





    }


    class Program
    {
        static void Main(string[] args)
        {
            //Class members: 1.Variables(fields)
            // 2. Methods  3. Property
            // bunlardan bahsedildi.


            Personel p = new Personel();
           // p.id = 12;
            
        }
    }
}
