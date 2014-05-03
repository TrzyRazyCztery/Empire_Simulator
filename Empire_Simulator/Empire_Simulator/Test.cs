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
            GeneratorSwiata generatorSwiata = new GeneratorSwiata();
            Swiat swiat = generatorSwiata.generujSwiat();

            foreach (Osada osada in swiat.pobierzListeOsad())
            {
                Console.WriteLine(osada.ToString());
            }

            foreach (Handlarz handlarz in swiat.pobierzListeHandlarzy())
            {
                Console.WriteLine(handlarz.ToString());
            }
            
            
            Console.ReadKey();
        }
    }
}
