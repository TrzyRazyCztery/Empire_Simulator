using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empire_Simulator
{
    /// <summary>
    /// Jest to klasa której obiekt jest wstanie zaktualizowac caly stan swiata.
    /// </summary>
    class AktualizacjaStanuSwiata
    {
        private IStrategiaAktualizacjiSwiata strategia = new PodstawowaStrategiaAktualizacjiSwiata();
        private DelegatAktualizacjiHandlarzy delegatHandlarzy;
        private DelegatAktualizacjiOsad delegatOsad;
        /// <summary>
        /// klasa AktualizacjiStanuSwiata przyjmuje w konstruktorze obiekt świata i na jego podstawie tworzy odpowiednie delegaty ktrórych bedzie używać
        /// do aktualizacji
        /// </summary>
        /// <param name="swiat"></param>
        public AktualizacjaStanuSwiata(Swiat swiat)
        {
            AktualizacjaHandlarzy GeneratorDelegacjiDoaktualizacjiHandlarzy = new AktualizacjaHandlarzy(swiat.pobierzListeHandlarzy());
            AktualizacjaOsad GeneratorDelegacjiDoAktualizacjiOsad = new AktualizacjaOsad(swiat.pobierzListeOsad());
            delegatHandlarzy = GeneratorDelegacjiDoaktualizacjiHandlarzy.pobierzGotowyDelegat();
            delegatOsad = GeneratorDelegacjiDoAktualizacjiOsad.pobierzGotowyDelegat();
        }

        /// <summary>
        /// w zależności od dnia aktualizuje handlarzy i wioski(w zaleznosci jak wskazuje stragtegiaAktualizacjiSwiata)
        /// </summary>
        /// <param name="dzien"></param>
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
