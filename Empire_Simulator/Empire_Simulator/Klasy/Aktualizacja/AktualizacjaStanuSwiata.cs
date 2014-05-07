using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empire_Simulator
{
    class AktualizacjaStanuSwiata
    {
        private IStrategiaAktualizacjiSwiata strategia = new PodstawowaStrategiaAktualizacjiSwiata();
        private DelegatAktualizacjiHandlarzy delegatHandlarzy;
        private DelegatAktualizacjiOsad delegatOsad;
        public AktualizacjaStanuSwiata(Swiat swiat)
        {
            AktualizacjaHandlarzy GeneratorDelegacjiDoaktualizacjiHandlarzy = new AktualizacjaHandlarzy(swiat.pobierzListeHandlarzy());
            AktualizacjaOsad GeneratorDelegacjiDoAktualizacjiOsad = new AktualizacjaOsad(swiat.pobierzListeOsad());
            delegatHandlarzy = GeneratorDelegacjiDoaktualizacjiHandlarzy.pobierzGotowyDelegat();
            delegatOsad = GeneratorDelegacjiDoAktualizacjiOsad.pobierzGotowyDelegat();
        }

        public void aktualizujSwiat(int dzien)
        {
            if (dzien % strategia.coIleDniAktualizowacHandlarza() == 0)
            {
                delegatHandlarzy();
            }
            if (dzien % strategia.coIleDniAktualizowacOsade() == 0)
            {
                delegatOsad();
            }
        }
    }
}
