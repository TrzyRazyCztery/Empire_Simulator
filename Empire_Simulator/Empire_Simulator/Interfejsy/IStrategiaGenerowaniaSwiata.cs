using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empire_Simulator
{
    interface IStrategiaGenerowaniaSwiata
    {
        int iloscOsadDoWygenerowania();
        int iloscHandlarzyDoWygenerowania();
        int pojemnoscWozuHandlarza();
        IStrategiaHandlarza strategiaHandlarza(List<Osada> listaOsad, List<Handlarz> listaHandlarzy);
        IStrategiaHandlu strategiaHandlu();
        IStrategiaOsady strategiaOsady();

    }
}
