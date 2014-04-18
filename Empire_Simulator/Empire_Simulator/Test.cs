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

            FabrykaHandlarzy fH = new FabrykaHandlarzy(strategia, 80);

            Handlarz h1 = fH.generujHandlarza();
            Handlarz h2 = fH.generujHandlarza();

            
            KeyValuePair<string, Zasob> ladunek = new KeyValuePair<string,Zasob>("komandos", new Zasob("Komandos", 10, 3));
            KeyValuePair<string, Zasob> ladunek2 = new KeyValuePair<string, Zasob>("amarena", new Zasob("amarena", 17, 5));
            
            h1.zwrocWoz().laduj(ladunek);
            h2.zwrocWoz().laduj(ladunek2);

            Console.WriteLine(h1.ToString());
            Console.WriteLine(h2.ToString());

           
            
            Console.ReadKey();
        }
    }
}
