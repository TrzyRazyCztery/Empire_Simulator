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
            Osada sampleOsada2 = sampleFabryka.losujOsade();
            Osada sampleOsada3 = sampleFabryka.losujOsade();
            Osada sampleOsada4 = sampleFabryka.losujOsade();
       
            FabrykaHandlarzy fH = new FabrykaHandlarzy(strategiaOsady, 80);

            Handlarz h1 = fH.generujHandlarza();
            Handlarz h2 = fH.generujHandlarza();
            Handlarz h3 = fH.generujHandlarza();

            
            KeyValuePair<string, Zasob> ladunek = new KeyValuePair<string,Zasob>("Mieso", new Zasob("Mieso", 40, 3));
            KeyValuePair<string, Zasob> ladunek2 = new KeyValuePair<string, Zasob>("Jedwab", new Zasob("Jedwab",40, 5));
            KeyValuePair<string, Zasob> ladunek3 = new KeyValuePair<string, Zasob>("Drewno", new Zasob("Drewno", 40, 5));

            h1.zwrocWoz().laduj(ladunek);
            h2.zwrocWoz().laduj(ladunek2);
            h3.zwrocWoz().laduj(ladunek3);
            Console.WriteLine(sampleOsada.ToString());
            Console.WriteLine(sampleOsada2.ToString());
            Console.WriteLine(sampleOsada3.ToString());
           
            for (int i = 0; i <= 10; i++)
            {
                sampleOsada.aktualizuj();
                sampleOsada2.aktualizuj();
                sampleOsada3.aktualizuj();
                sampleOsada.Targowisko().WymianaTowaru(h1);
                sampleOsada.Targowisko().WymianaTowaru(h2);
                sampleOsada.Targowisko().WymianaTowaru(h3);
                sampleOsada.aktualizuj();
                sampleOsada2.aktualizuj();
                sampleOsada3.aktualizuj();
                sampleOsada.Targowisko().WymianaTowaru(h3);
                sampleOsada.Targowisko().WymianaTowaru(h1);
                sampleOsada.Targowisko().WymianaTowaru(h2);
                sampleOsada.aktualizuj();
                sampleOsada2.aktualizuj();
                sampleOsada3.aktualizuj();
                sampleOsada.Targowisko().WymianaTowaru(h2);
                sampleOsada.Targowisko().WymianaTowaru(h3);
                sampleOsada.Targowisko().WymianaTowaru(h1);
                Console.WriteLine("\n\n Po aktualizacji \n\n");
                Console.WriteLine(sampleOsada.ToString());
                Console.WriteLine(sampleOsada2.ToString());
                Console.WriteLine(sampleOsada3.ToString());
            }
            Console.WriteLine("\n\n Po aktualizacji \n\n");
            Console.WriteLine(sampleOsada.ToString());
            Console.WriteLine(sampleOsada2.ToString());
            Console.WriteLine(sampleOsada3.ToString());
            
            Console.ReadKey();
        }
    }
}
