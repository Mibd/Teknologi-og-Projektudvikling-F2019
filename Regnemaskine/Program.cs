using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regnemaskine
{
    class Program
    {
        static void Main(string[] args)
        {
            String String_var1 = "0"; //Opretter variablen
            String String_var2 = "0";

            Console.WriteLine("Indtast tal1"); //Skriver teksten på konsollen
            String_var1 = Console.ReadLine();  //Henter det indtastede til String_var1
            Console.WriteLine("Indtast tal2");
            String_var2 = Console.ReadLine();

            Double t1 = System.Convert.ToDouble(String_var1); //Konvertere String_var1 til Double (Real)
            Double t2 = System.Convert.ToDouble(String_var2);

            Double Resultat = t1 + t2;

            Console.WriteLine($"Resultatet er = {Resultat:N2}"); //Skriver ud til konsollen. ($ betyder at der er indeholt en variabel), (N2 betyder tusindtals seperator)













            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
