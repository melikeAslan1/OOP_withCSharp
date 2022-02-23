using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subat15_inheritance
{
    class Asker
    {
        public int SicilNo { get; set; }

        public string Vazife { get; set; }

        protected void Islem()
        {
            // protected o class ta ve o class tan türetilen class larda gecerli oluyor. 
        }
    }

    class Er : Asker
    {
        public Er() {
            
            }

    }

    //class Er: Asker, Insan
    //{

      


    //}

    class Insan
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            //inheritance
            Asker asker = new Asker();
            Er er = new Er();

            er.



        }
    }
}
