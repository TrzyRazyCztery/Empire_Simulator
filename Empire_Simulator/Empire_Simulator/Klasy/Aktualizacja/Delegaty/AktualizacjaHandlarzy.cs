using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empire_Simulator
{
    public delegate void DelegatAktualizacjiHandlarzy();
    class AktualizacjaHandlarzy
    {
        private static DelegatAktualizacjiHandlarzy delegatAktualizacjiHandlarzy = null;

        public AktualizacjaHandlarzy(List<Handlarz> listaHandlarzy)
        {
            foreach (Handlarz handlarz in listaHandlarzy)
            {
                delegatAktualizacjiHandlarzy += new DelegatAktualizacjiHandlarzy(handlarz.aktualizuj); 
            }
        }
        public DelegatAktualizacjiHandlarzy pobierzGotowyDelegat()
        {
            return delegatAktualizacjiHandlarzy;
        }
    }
}
