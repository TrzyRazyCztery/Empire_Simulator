using System;
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
            return 3;
        }

        public int pojemnoscWozuHandlarza()
        {
            return 80;
        }

        public IStrategiaHandlarza strategiaHandlarza(List<Osada>listaOsad)
        {
            return new PodstawowaStrategiaHandlarza(listaOsad);
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
