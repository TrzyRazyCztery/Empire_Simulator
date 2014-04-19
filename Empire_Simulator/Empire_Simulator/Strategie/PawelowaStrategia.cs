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
    class PawelowaStrategia : IStrategiaOsady, IStrategiaHandlu, IStrategiaHandlarza
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
                pair.Value.zmienIloscZasobu(-(liczbaLudnosci)); // zmiana w zwiazku z populacja
            }

        }





        //######################################### STRATEGIA HANDLARZA #################################
        public void Handluj()
        {
        }



        //####################################### STRATEGIA HANDLU ######################################
        /// <summary>
        /// Obecna wymiana polega na tym ze handlarz wymienia sie z targiem porowno, tj rozladowuje swoje zasoby i sa
        /// ladowane do magazynua potem z magazynu bierzemy surowiec ktorego jest najwiecej i ladujemy mu na woz
        /// Pożadana strategia jest raczej inna, pozniewaz obecna jest strasznie trywialna.
        /// </summary>
        /// <param name="magazyn"></param>
        /// <param name="handlarz"></param>
        public void wymianaTowaru(Magazyn magazyn, Handlarz handlarz)
        {
            KeyValuePair<string, Zasob> towarHandlarza = handlarz.zwrocWoz().rozladuj();
            Dictionary<string, Zasob> stanMagazynu = magazyn.pobierzStanMagazynu();
            Zasob towarDoMagazynu = stanMagazynu[towarHandlarza.Key];
            
            towarDoMagazynu.zmienIloscZasobu(towarHandlarza.Value.iloscZasobu());

            KeyValuePair<string, Zasob> towarZMagazynu = new KeyValuePair<string,Zasob>( "", new Zasob("", 0,0));
            foreach( KeyValuePair<string, Zasob> para in stanMagazynu){
                if(para.Value.iloscZasobu() > towarZMagazynu.Value.iloscZasobu()){
                    towarZMagazynu = para;
                }
            }
            towarZMagazynu.Value.zmienIloscZasobu(-towarHandlarza.Value.iloscZasobu());
            handlarz.zwrocWoz().laduj(new KeyValuePair<string,Zasob>(towarZMagazynu.Key, new Zasob(towarZMagazynu.Key, towarHandlarza.Value.iloscZasobu(), towarZMagazynu.Value.zwrocWageZasobu())));



        }

       
    }
}
