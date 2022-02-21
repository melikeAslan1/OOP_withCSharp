using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subat21_1
{
    //Solid Prensipleri 4. prensibin açıklanması
    // Penguen örneğini hatırla. Penguen in hiç kullanmayacağı metodu neden zorla implemente edeyim.
    class Program
    {
        interface IArayuz
        {
            void IslemA();
            void IslemB();
            void IslemC();
            void IslemD();
        }
        class A : IArayuz
        {
            public void IslemA()
            {
                throw new NotImplementedException();
            }

            public void IslemB()
            {
                throw new NotImplementedException();
            }

            public void IslemC()
            {
                throw new NotImplementedException();
            }

            public void IslemD()
            {
                throw new NotImplementedException();
            }
        }
        interface IArayuzII
        {
            void IslemA();
        }
        interface IArayuzIII : IArayuzII
        {
            void IslemB();
        }
        class Deneme : IArayuzIII
        {
            public void IslemA()
            {
                throw new NotImplementedException();
            }

            public void IslemB()
            {
                throw new NotImplementedException();
            }
        }
        static void Main(string[] args)
        {
            




        }
    }
}
