using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subat17_KolleksiyonlarOrnek
{

    class Program
    {
        static void Main(string[] args)
        {

            ArrayList liste = new ArrayList();

            for (int i = 0; i < 5; i++)
            {
                liste.Add(12);
            }

            //Console.WriteLine(liste.Count);

            //Console.WriteLine(liste.Capacity);

            Console.WriteLine("Adet={0} Kpapasite={1}", liste.Count,liste.Capacity);

            Console.WriteLine($"Adet={liste.Count} Kapasite={liste.Capacity}");

            liste[2] = "11";


            //Stack

            Stack stack = new Stack();

            stack.Push(12);
            //stack değer ekledim.

            stack.Push(22);
            stack.Push(32);

            //ilk gelen en alta ssonra onun üserine ekledim.

            Console.WriteLine(stack.Peek());
            //Peek kolleksiyondan eleman çıkarmadan en üstte kim var ona bakar.

            Console.WriteLine(stack.Pop());
            //  otomatik en üstteki kaydı çeker alır. kolleksiyondan cıkartır. ve onu yazdırır. artık en üstte 22 var.
            //çalışma mekaniği LIFO ya göre.
            Console.WriteLine(stack.Peek());













        }
    }
}
