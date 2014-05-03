using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Empire_Simulator
{
    class Swiat
    {
        private List<Osada> listaOsad;
        private List<Handlarz> listaHandlarzy;

        public Swiat(List<Osada> listaOsad, List<Handlarz> listaHandlarzy)
        {
            this.listaHandlarzy = listaHandlarzy;
            this.listaOsad = listaOsad;
        }

        public void dodajOsade(Osada osada)
        {
            this.listaOsad.Add(osada);
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
            return listaOsad;
        }
    }
}
