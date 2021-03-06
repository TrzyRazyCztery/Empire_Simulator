﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empire_Simulator
{
    class PodstawowaStrategiaGenerowaniaSwiata : IStrategiaGenerowaniaSwiata
    {

        public int iloscOsadDoWygenerowania()
        {
            return 6;
        }

        public int iloscHandlarzyDoWygenerowania()
        {
            return 5;
        }

        public int pojemnoscWozuHandlarza()
        {
            return 80;
        }

        public IStrategiaHandlarza strategiaHandlarza(List<Osada>listaOsad, List<Handlarz> listaHandlarzy)
        {
            return new PodstawowaStrategiaHandlarza(listaOsad, listaHandlarzy);
        }

        public IStrategiaHandlu strategiaHandlu()
        {
            return new PodstawowaStrategiaHandlu();
        }

        public IStrategiaOsady strategiaOsady()
        {
            return new PodstawowaStrategiaOsady();
        }
    }
}
