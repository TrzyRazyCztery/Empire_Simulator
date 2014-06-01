using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empire_Simulator
{
    /// <summary>
    /// Jest to ogolny interfejs generowania swiata, ktory mówi o tym ile osad wygenerowac na mapie, ilu handlarzy,i jaka pojemność bedzie miał wóz handlarze
    /// podaje też z jakich strategi handlarza,handlu i Osady bedziemy korzystac
    /// </summary>
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
