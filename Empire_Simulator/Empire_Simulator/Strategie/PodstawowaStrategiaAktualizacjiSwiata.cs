using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empire_Simulator
{
    class PodstawowaStrategiaAktualizacjiSwiata : IStrategiaAktualizacjiSwiata
    {

        public int coIleDniAktualizowacOsade()
        {
            return 90;
        }

        public int coIleDniAktualizowacHandlarza()
        {
            return 1;
        }
    }
}
