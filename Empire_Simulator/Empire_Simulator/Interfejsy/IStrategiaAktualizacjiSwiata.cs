using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empire_Simulator
{
    /// <summary>
    /// Interfejs Aktualizacji swiata ma metody zwracajace to co ile dni handlarz zmienia swój stan, podobnie tyczy się  to wioski
    /// </summary>
    interface IStrategiaAktualizacjiSwiata
    {
      
        int coIleDniAktualizowacOsade();
        int coIleDniAktualizowacHandlarza();
    }
}
