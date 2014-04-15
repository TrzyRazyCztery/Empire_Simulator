using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Empire_Simulator
{
    class Test
    {
        static void Main(string[] args)
        {
            FabrykaZasobow a = new FabrykaZasobow();
            FabrykaOsad sampleFabryka = new FabrykaOsad(a, new PawelowaStrategia());
            Osada sampleOsada = sampleFabryka.losujOsade();

            Console.WriteLine(sampleOsada.ToString());
            Console.WriteLine(" ");
            sampleOsada.aktualizuj();
            Console.WriteLine(sampleOsada.ToString());
            Console.WriteLine(" ");
            sampleOsada.aktualizuj();
            Console.WriteLine(sampleOsada.ToString());
            Console.WriteLine(" ");
            sampleOsada.aktualizuj();
            Console.WriteLine(sampleOsada.ToString());
            Console.WriteLine(" ");
            sampleOsada.aktualizuj();
            Console.WriteLine(sampleOsada.ToString());
            Console.WriteLine(" ");
            sampleOsada.aktualizuj();
            Console.WriteLine(sampleOsada.ToString());
            Console.WriteLine(" ");
            sampleOsada.aktualizuj();
            Console.WriteLine(sampleOsada.ToString());

           
            
            Console.ReadKey();
        }
    }
}
