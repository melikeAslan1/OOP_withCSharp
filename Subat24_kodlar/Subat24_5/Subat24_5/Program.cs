using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subat24_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 0, c = 0;

            try
            {
                c = a / b;
                Console.WriteLine("Istısnadan sonra...");
            }

            catch(Exception ex)
            {
                Console.WriteLine("ISTISNAI bir durum var...");
            }
            finally
            {
                Console.WriteLine("ne olursa olsun çalış...");
            }
        }
    }
}
