using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empire_Simulator
{
    /// <summary>
    /// klasa towrzaca obiekt delegata który zawiera w  sobie wywoałanie w kolejnosci aktualizacji każdej z osad
    /// </summary>
    public delegate void DelegatAktualizacjiOsad();
    class AktualizacjaOsad
    {
        private static DelegatAktualizacjiOsad delegatAktualizacjiOsad = null;
        /// <summary>
        /// metoda pobiera liste osad i dodaje wywołanie metody aktualizuj kazdej z nich do delegata
        /// </summary>
        /// <param name="listaOsad"></param>
        public AktualizacjaOsad(List<Osada> listaOsad)
        {
            foreach (Osada osada in listaOsad)
            {
                delegatAktualizacjiOsad += new DelegatAktualizacjiOsad(osada.aktualizuj);
            }
        }
        /// <summary>
        /// zwraca gotowego delegata
        /// </summary>
        /// <returns></returns>
        public DelegatAktualizacjiOsad pobierzGotowyDelegat()
        {
            return delegatAktualizacjiOsad;
        }
    }
}
