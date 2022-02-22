using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subat17_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            //FIFO FİRST İN FİRST OUT
            Queue q = new Queue();

            q.Enqueue(12);
            q.Enqueue(22);
            q.Enqueue(32);

            Console.WriteLine(q.Peek());   // en üsttekini gösterir.
            Console.WriteLine(q.Dequeue());  // stack deki pop la aynı. en üsttekini alır yani siler.
            Console.WriteLine(q.Peek());



            //Hashtable 
            Hashtable ht = new Hashtable();

            ht.Add(34, "istanbul");
            ht.Add(16, "bursa");
            ht.Add(06, "ankara");
            

            Console.WriteLine(ht[34]);


            //Sorted List
            // sorted listte indis bazlı dolaşabiliyorsun. 

            SortedList s1 = new SortedList();
            s1.Add(34, "Istanbul");
            s1.Add(06, "ankara");
            

            Console.WriteLine(s1.GetByIndex(0));
            //6 sonra 34 sıraladı key e göre sıraladı. ilk 6 o yuzden 6 yı getirdi.











        }
    }
}
