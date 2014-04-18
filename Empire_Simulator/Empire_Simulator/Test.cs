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
            PawelowaStrategia strategia = new PawelowaStrategia();
            FabrykaOsad sampleFabryka = new FabrykaOsad(a, strategia);
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

            FabrykaHandlarzy fH = new FabrykaHandlarzy(strategia);

            Handlarz h1 = fH.generujHandlarza();
            Handlarz h2 = fH.generujHandlarza();

            Console.WriteLine(h1.ToString());
            Console.WriteLine(h2.ToString());

           
            
            Console.ReadKey();
        }
    }
}
