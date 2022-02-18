using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subat18_7
{
    public interface IBoyanabilir
    {

    }

    class Boyahane
    {
        public void Boya(IBoyanabilir arac,ConsoleColor yeniRenk)
        {
            Arac a = (Arac)arac;
            a.Renk = yeniRenk;

            Console.ForegroundColor = a.Renk;

            Console.WriteLine(a.GetType() );


        }
    }

    abstract class Arac
     {
        public ConsoleColor Renk { get; set; }

        public Arac()
        {
            Random rnd = new Random();
            Renk = (ConsoleColor)rnd.Next(1, 15);
        }   
    }

    class Ferrari : Arac, IBoyanabilir
    {
        public Ferrari()
        {
            Console.ForegroundColor = Renk;
            Console.WriteLine("Ferrari");
        }
    }

    class Mustang:Arac, IBoyanabilir
    {
        public Mustang()
        {
            Console.ForegroundColor = Renk;
            Console.WriteLine("Mustang");

        }
    }

    class BMX:Arac
    {
        public BMX()
        {
            Console.ForegroundColor = Renk;
            Console.WriteLine("BMX");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ferrari f = new Ferrari();
            Mustang m = new Mustang();
            BMX bmx = new BMX();

            Boyahane boyahane = new Boyahane();
            boyahane.Boya(f, ConsoleColor.Red);
            boyahane.Boya(m, ConsoleColor.DarkGreen);

            //boyahane.Boya(bmx, ConsoleColor.Cyan);

        }
    }
}
