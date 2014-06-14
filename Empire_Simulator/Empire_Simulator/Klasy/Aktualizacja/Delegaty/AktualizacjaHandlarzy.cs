using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empire_Simulator
{
    /// <summary>
    /// klasa Towrzaca obiekt delegata który zawiera w  sobie wywoałanie w kolejnosci aktualizacji każdego z handlarzy
    /// </summary>
    public delegate void DelegatAktualizacjiHandlarzy();
    class AktualizacjaHandlarzy
    {
        private static DelegatAktualizacjiHandlarzy delegatAktualizacjiHandlarzy = null;
        /// <summary>
        /// metoda pobiera listę handlarzy i uzupelnia delegat o metody aktualizacji kazdego z nich
        /// </summary>
        /// <param name="listaHandlarzy"></param>
        public AktualizacjaHandlarzy(List<Handlarz> listaHandlarzy)
        {
            foreach (Handlarz handlarz in listaHandlarzy)
            {
                delegatAktualizacjiHandlarzy += new DelegatAktualizacjiHandlarzy(handlarz.aktualizuj); 
            }
        }
        /// <summary>
        /// zwraca gotowego do użycia delegtata
        /// </summary>
        /// <returns></returns>
        public DelegatAktualizacjiHandlarzy pobierzGotowyDelegat()
        {
            return delegatAktualizacjiHandlarzy;
        }
    }
}
