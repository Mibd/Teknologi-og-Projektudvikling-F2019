using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv_Terning
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning t1 = new Terning();

            Console.WriteLine($"Start værdi t1 [{t1.Værdi}]");
            //Console.Write("Press any key to continue . . . ");
            //Console.ReadKey();
            t1.Ryst();
            //Console.WriteLine();
            Console.WriteLine($"værdi efter ryst t1 [{t1.Værdi}]");

            LudoTerning t2 = new LudoTerning();

            Console.WriteLine($"Start værdi t2 [{t2.Værdi}]");
            //Console.Write("Press any key to continue . . . ");
            //Console.ReadKey();
            t2.Ryst();
            //Console.WriteLine();
            Console.WriteLine($"værdi efter ryst t2 [{t2.Værdi}]");
            Console.WriteLine($"Er Globus {t2.ErGlobus()}");
            Console.WriteLine($"Er Stjerne {t2.ErStjerne()}");

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

    }
    public class Terning
    {
        private static System.Random rnd;
        private int værdi;

        public int Værdi
        {
            get
            {
                return this.værdi;
            }
            set
            {
                if (value < 0 || value > 6)
                    value = 1;
                this.værdi = value;
            }
        }
        public void Skriv()
        {
            Console.WriteLine("[" + this.Værdi + "]");
        }
        public void Ryst()
        {
            this.Værdi = rnd.Next(1, 7);
        }

        public Terning()
        {
            this.Ryst();
        }

        public Terning(int værdi)
        {
            this.Værdi = værdi;
        }

        static Terning()
        {
            rnd = new Random();
        }
    }
    public class LudoTerning: Terning
    {
        public bool ErGlobus()

        {
            return this.Værdi == 3;
        }

        public bool ErStjerne()

        {
            return this.Værdi == 5;
        }

        public LudoTerning() : base()

        { }

        public LudoTerning(int værdi) : base(værdi)

        { }

    }
}
