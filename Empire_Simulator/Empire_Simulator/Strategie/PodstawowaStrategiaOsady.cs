using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;


namespace Empire_Simulator
{
    /// <summary>
    /// Własna strategia implementujaca interfejs strategi osady 
    /// </summary>
    class PodstawowaStrategiaOsady : IStrategiaOsady
    {
        public void aktualizujStanPopulacji(Populacja populacja, Magazyn magazyn)
        {
            int warunekZwiekszenia = 1;
            int warunekZmniejszenia = 0;
            // prosta strategia, jesli wszystkie produkty sa powyzej 10 zwiekszamy populacje o 10
            // jesli mamy 0 jakiegos zasobu zmniejszamy populacje o 10
            foreach(KeyValuePair<string, Zasob> para in magazyn.pobierzStanMagazynu()){
                if (para.Value.iloscZasobu() < 30) { warunekZwiekszenia = 0;}
                if (para.Value.iloscZasobu() == 0) { warunekZmniejszenia = 1;}
            }
            if (warunekZmniejszenia == 1){populacja.zmienLiczbeLudnosci(-10);}
            if (warunekZwiekszenia == 1){populacja.zmienLiczbeLudnosci(10);}


            
        }

        /// <summary>
        /// (w takiej prostej strategi przyjmuje ze kazda osoba wykorzystuje 1 kazdego surowca w wiosce, dodatkowo produkujac 2 surowca
        /// ktory jest wydobywany w danej wiosce)
        /// </summary>
        /// <param name="magazyn"></param>
        /// <param name="potencjalWydobywczy"></param>
        /// <param name="liczbaLudnosci"></param>
        public void aktualizujStanyMagazynowe(Magazyn magazyn, PotencjalWydobywczy potencjalWydobywczy, int liczbaLudnosci)
        {
            //Dictionary<string, Zasob> stan = magazyn.pobierzStanMagazynu(); Jesli chcialbym pobierac stan magazynu zmieniac i wysylac do magazynu
            foreach (KeyValuePair<string, Zasob> pair in magazyn.pobierzStanMagazynu())
            {
                if (potencjalWydobywczy.pobierzPotencjal().Contains(pair.Key))
                {
                    pair.Value.zmienIloscZasobu(3*liczbaLudnosci);//zmiana w zwiazku z potencjalem wydobywczym
                }
                pair.Value.zmienIloscZasobu(-(liczbaLudnosci/3)); // zmiana w zwiazku z populacja
            }

        }

       
    }
}
