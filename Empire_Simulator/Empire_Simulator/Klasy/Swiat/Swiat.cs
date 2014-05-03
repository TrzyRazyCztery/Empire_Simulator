using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Empire_Simulator
{
    class Swiat
    {
        private List<Osada> listOsad;
        private List<Handlarz> listaHandlarzy;

        public Swiat()
        {
            listaHandlarzy = new List<Handlarz>();
            listOsad = new List<Osada>();
        }

        public void dodajOsade(Osada osada)
        {
            this.listOsad.Add(osada);
        }

        public void dodajHandlarza(Handlarz handlarz)
        {
            this.listaHandlarzy.Add(handlarz);
        }

        public List<Handlarz> pobierzListeHandlarzy()
        {
            return listaHandlarzy;
        }

        public List<Osada> pobierzListeOsad()
        {
            return listOsad;
        }
    }
}
