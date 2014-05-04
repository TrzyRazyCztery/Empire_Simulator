using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empire_Simulator
{
    public delegate void DelegatAktualizacjiOsad();
    class AktualizacjaOsad
    {
        private static DelegatAktualizacjiOsad delegatAktualizacjiOsad = null;

        public AktualizacjaOsad(List<Osada> listaOsad)
        {
            foreach (Osada osada in listaOsad)
            {
                delegatAktualizacjiOsad += new DelegatAktualizacjiOsad(osada.aktualizuj);
            }
        }
        public DelegatAktualizacjiOsad pobierzGotowyDelegat()
        {
            return delegatAktualizacjiOsad;
        }
    }
}
