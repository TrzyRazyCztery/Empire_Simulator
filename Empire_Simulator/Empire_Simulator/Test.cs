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
            przykladowyHandlarz.ladujTowar(new KeyValuePair<string,Zasob>("Drewno", new Zasob("Drewno", 40, 20)));
            /*
            Handlarz przykladowyHandlarz2 = new Handlarz(strategiaHandlarza, 80, "Tomasz");
            przykladowyHandlarz2.ladujTowar(new KeyValuePair<string, Zasob>("Jedwab", new Zasob("Jedwab", 40, 20)));
            */
            przykladowyHandlarz.reczneUstawienieCelu(przykladowyHandlarz.WyznaczCelPodrozy());
            //przykladowyHandlarz2.reczneUstawienieCelu(przykladowyHandlarz2.WyznaczCelPodrozy());
            
            for (int i = 0; i <= 30; i++)
            {

                
                Console.WriteLine(przykladowyHandlarz.ToString());
                przykladowyHandlarz.aktualizuj();
                //Console.WriteLine(przykladowyHandlarz2.ToString());
                //przykladowyHandlarz2.aktualizuj();
            }    


            
            
            
            Console.ReadKey();
        }
    }
}
