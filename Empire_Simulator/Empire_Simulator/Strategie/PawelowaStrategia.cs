using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Empire_Simulator
{
    /// <summary>
    /// Własna strategia implementujaca interfejs strategi osady 
    /// </summary>
    class PawelowaStrategia : StrategiaOsady
    {
        public void aktualizujStanPopulacji(Populacja populacja, Magazyn magazyn)
        {
            int warunekZwiekszenia = 1;
            int warunekZmniejszenia = 0;
            // prosta strategia, jesli wszystkie produkty sa powyzej 10 zwiekszamy populacje o 10
            // jesli mamy 0 jakiegos zasobu zmniejszamy populacje o 10
            foreach(KeyValuePair<string, Zasob> para in magazyn.pobierzStanMagazynu()){
                if (para.Value.iloscZasobu() < 10) { warunekZwiekszenia = 0;}
                if (para.Value.iloscZasobu() == 0) { warunekZmniejszenia = 1;}
            }
            if (warunekZmniejszenia == 1){populacja.zmienLiczbeLudnosci(-10);}
            if (warunekZwiekszenia == 1){populacja.zmienLiczbeLudnosci(10);}


            
        }

        /// <summary>
        /// Na razie obsluguje zmiane statusu magazynu przez odjecie cotygodniowej wartosci stałej
        /// zużywanej przez populacje w wartosci 10 kazdego z zasobow
        /// wchodze do magazynu, jego slownika i w obniekcie zasobu zmieniam ilosc o -10
        /// </summary>
        /// <param name="magazyn"></param>
        /// <param name="potencjalWydobywczy"></param>
        /// <param name="liczbaLudnosci"></param>
        public void aktualizujStanyMagazynowe(Magazyn magazyn, PotencjalWydobywczy potencjalWydobywczy, int liczbaLudnosci)
        {
            //Dictionary<string, Zasob> stan = magazyn.pobierzStanMagazynu(); Jesli chcialbym pobierac stan magazynu zmieniac i wysylac do magazynu
            foreach (KeyValuePair<string, Zasob> pair in magazyn.pobierzStanMagazynu())
            {
                
                pair.Value.zmienIloscZasobu(-10);
            }

        }

    }
}
