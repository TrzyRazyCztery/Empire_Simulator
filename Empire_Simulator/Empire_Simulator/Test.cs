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
            FabrykaZasobow przykladowaFabrykaZasobow = new FabrykaZasobow();
            

            PodstawowaStrategiaOsady strategiaOsady = new PodstawowaStrategiaOsady();
            PodstawowaStrategiaHandlu strategiaHandlu = new PodstawowaStrategiaHandlu();
            
            FabrykaOsad przykladowaFabrykaOsad = new FabrykaOsad(przykladowaFabrykaZasobow, strategiaOsady, strategiaHandlu);
            List<Osada> listaOsad = new List<Osada>();
            for (int i = 0; i <= 4; i++)
            {
                listaOsad.Add(przykladowaFabrykaOsad.losujOsade());
            }
            
            PodstawowaStrategiaHandlarza strategiaHandlarza = new PodstawowaStrategiaHandlarza(listaOsad);

            Handlarz przykladowyHandlarz = new Handlarz(strategiaHandlarza, 80, "Andrzej");
            przykladowyHandlarz.zwrocWoz().laduj(new KeyValuePair<string,Zasob>("Drewno", new Zasob("Drewno", 40, 20)));
            Handlarz przykladowyHandlarz2 = new Handlarz(strategiaHandlarza, 80, "Tomasz");
            przykladowyHandlarz2.zwrocWoz().laduj(new KeyValuePair<string, Zasob>("Jedwab", new Zasob("Jedwab", 40, 20)));

            Handlarz przykladowyHandlarz3 = new Handlarz(strategiaHandlarza, 80, "Zdzislaw");
            przykladowyHandlarz3.zwrocWoz().laduj(new KeyValuePair<string, Zasob>("Mieso", new Zasob("Mieso", 40, 20)));

            foreach (Osada osada in listaOsad)
            {
                Console.WriteLine(osada.ToString() + "\n");
            }
            Console.WriteLine(przykladowyHandlarz.ToString());
            Console.WriteLine(przykladowyHandlarz.WyznaczCelPodrozy().ToString());
            Console.WriteLine(przykladowyHandlarz2.ToString());
            Console.WriteLine(przykladowyHandlarz2.WyznaczCelPodrozy().ToString());
            Console.WriteLine(przykladowyHandlarz3.ToString());
            Console.WriteLine(przykladowyHandlarz3.WyznaczCelPodrozy().ToString());


            
            
            
            Console.ReadKey();
        }
    }
}
