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
            PawelowaStrategia strategiaOsady = new PawelowaStrategia();
            FabrykaOsad sampleFabryka = new FabrykaOsad(a, strategiaOsady, strategiaOsady);
            Osada sampleOsada = sampleFabryka.losujOsade();

            Console.WriteLine(sampleOsada.ToString());
            Console.WriteLine(" ");
            sampleOsada.aktualizuj();
            Console.WriteLine(sampleOsada.ToString());
            Console.WriteLine(" ");
       
            FabrykaHandlarzy fH = new FabrykaHandlarzy(strategiaOsady, 80);

            Handlarz h1 = fH.generujHandlarza();
            Handlarz h2 = fH.generujHandlarza();

            
            KeyValuePair<string, Zasob> ladunek = new KeyValuePair<string,Zasob>("Mieso", new Zasob("Mieso", 20, 3));
            KeyValuePair<string, Zasob> ladunek2 = new KeyValuePair<string, Zasob>("Jedwab", new Zasob("Jedwab",20, 5));
            
            h1.zwrocWoz().laduj(ladunek);
            h2.zwrocWoz().laduj(ladunek2);

            Console.WriteLine(h1.ToString());
            Console.WriteLine(h2.ToString());

            sampleOsada.Targowisko().WymianaTowaru(h1);
            sampleOsada.Targowisko().WymianaTowaru(h2);

            Console.WriteLine(h1.ToString());
            Console.WriteLine(h2.ToString());
            Console.WriteLine(sampleOsada.ToString());


           
            
            Console.ReadKey();
        }
    }
}
