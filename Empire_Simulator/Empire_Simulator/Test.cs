﻿using System;
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
            
            GeneratorMapy generator = new GeneratorMapy(swiat);
            Mapa mapa = generator.generujMape();
            Thread watekMapy = new Thread(new ThreadStart(mapa.WyswietlMape));
            watekMapy.Start();
          

            
            while (true) {
            };
            
        }
    }
}
