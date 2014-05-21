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
        List<Handlarz> listaHandlarzy;
        public PodstawowaStrategiaHandlarza(List<Osada> listaOsad, List<Handlarz> listaHandlarzy)
        {
            this.listaOsad = listaOsad;
            this.listaHandlarzy = listaHandlarzy;
        }

        /// <summary>
        /// Wyznaczanie celu podrozy poprzez wybranie wioski ktora ma najmniej surowca ktory posiada handlarz
        /// </summary>
        /// <param name="handlarz"></param>
        /// <returns></returns>

        public Osada wyznaczCelPodrozy(Handlarz handlarz)
        {
            Osada cel = listaOsad.FirstOrDefault();
            Zasob najmniej = new Zasob(handlarz.zwrocWoz().NazwaPrzewozonegoZasobu(), 10000, 0);
            foreach (Osada osada in listaOsad)
            {
                bool warunekWolnosciOsady = false;
                foreach (Handlarz temp in listaHandlarzy)
                {
                    if (temp.zwrocCelPodrozy() == osada && temp.zwrocWoz().NazwaPrzewozonegoZasobu() == handlarz.zwrocWoz().NazwaPrzewozonegoZasobu())
                    {
                        warunekWolnosciOsady = true;
                        break;
                    }
                }
                if (warunekWolnosciOsady) { continue; }
                Magazyn magazyn = osada.magazyny();
                foreach (KeyValuePair<string, Zasob> para in magazyn.pobierzStanMagazynu())
                {
                    if (para.Key.Equals(najmniej.nazwaZasobu()))
                    {
                        if (najmniej.iloscZasobu() > para.Value.iloscZasobu())
                        {
                            najmniej = para.Value;
                            cel = osada;
                            break;
                        }
                    }
                }
            }
            return cel;
        }


        public Point podrozuj(Point pozycja, Point celPodrozy)
        {
            if ((celPodrozy.X - pozycja.X) < 10 && (celPodrozy.X - pozycja.X) > -10)
            {
                
            }
            else if (celPodrozy.X < pozycja.X)
            {
                pozycja.X = (pozycja.X - 5);
            }
            else
            {
                pozycja.X = (pozycja.X + 5);
            }
            if ((celPodrozy.Y - pozycja.Y) < 10 && (celPodrozy.Y - pozycja.Y) > -10) 
            {
            }
            else if (celPodrozy.Y < pozycja.Y)
            {
                pozycja.Y = (pozycja.Y - 5);
            }
            else
            {
                pozycja.Y = (pozycja.Y + 5);
            }
            return pozycja;
        }


    }
}
