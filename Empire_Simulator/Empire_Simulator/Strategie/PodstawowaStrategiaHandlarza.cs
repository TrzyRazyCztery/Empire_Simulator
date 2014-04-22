using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace Empire_Simulator
{
    class PodstawowaStrategiaHandlarza : IStrategiaHandlarza
    {
        List<Osada> listaOsad;
        public PodstawowaStrategiaHandlarza(List<Osada> listaOsad)
        {
            this.listaOsad = listaOsad;
        }

        /// <summary>
        /// Wyznaczanie celu podrozy poprzez wybranie wioski ktora ma najmniej surowca ktory posiada handlarz
        /// </summary>
        /// <param name="handlarz"></param>
        /// <returns></returns>

        public Point WyznaczCelPodrozy(Handlarz handlarz)
        {
            foreach (Osada osada in listaOsad)
            {
                Zasob najmniej = new Zasob("x", 10000, 0);
                Magazyn magazyn = osada.magazyny();
                foreach (KeyValuePair<string, Zasob> para in magazyn.pobierzStanMagazynu())
                {
                    if (para.Value.iloscZasobu() < najmniej.iloscZasobu())
                    {
                        najmniej = para.Value;
                    }
                }
                if (najmniej.nazwaZasobu().Equals(handlarz.zwrocWoz().NazwaPrzewozonegoZasobu()))
                {
                    return osada.pozycjaOsady();
                }
            }
            return listaOsad.FirstOrDefault().pozycjaOsady();
        }

    }
}
