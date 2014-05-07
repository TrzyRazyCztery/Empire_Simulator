using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Empire_Simulator
{
    class Test
    {
        static void Main(string[] args)
        {

            GeneratorSwiata generatorSwiata = new GeneratorSwiata();
            Swiat swiat = generatorSwiata.generujSwiat();
            AktualizacjaStanuSwiata aktualizacjaSwiata = new AktualizacjaStanuSwiata(swiat);
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("\n Dzien: {0} \n", i);
                foreach (Osada osada in swiat.pobierzListeOsad())
                {
                    Console.WriteLine(osada.ToString());
                }
                Console.WriteLine("\n\n");
                foreach (Handlarz handlarz in swiat.pobierzListeHandlarzy())
                {
                    Console.WriteLine(handlarz.ToString());
                }
                aktualizacjaSwiata.aktualizujSwiat(i);
            }
            GeneratorMapy generator = new GeneratorMapy(swiat);
            Thread watekMapy = new Thread(new ThreadStart(generator.Run));
            watekMapy.Start();

            
            while (true) {
            };
            
        }
    }
}
