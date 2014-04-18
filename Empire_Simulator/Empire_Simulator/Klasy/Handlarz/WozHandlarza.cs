using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Empire_Simulator
{
    /// <summary>
    /// klasa woz handlarza bedzie obiektem trzymajacym zasoby przewozone przez Handlarza
    /// uzywam slownika dlatego ze w przyszlosci planuje to ze handlarz bedzie wozil kilka roznych towarow
    /// </summary>
    class WozHandlarza
    {
        private Dictionary<string, Zasob> ladunek = new Dictionary<string, Zasob>();
        private int ladownosc;

        public WozHandlarza(int ladownosc){
            this.ladownosc = ladownosc;
        }
        /// <summary>
        /// laduje towar o konkretnej nazwie i ilosci na woz
        /// (przepelnienie do ogarniecia)
        /// </summary>
        public void laduj(KeyValuePair<string, int> towar){
            foreach(KeyValuePair<string, Zasob> zasob in ladunek){
                if( zasob.Key.Equals(towar.Key)){
                    zasob.Value.zmienIloscZasobu(towar.Value);
                }
            }
        }
        /// <summary>
        /// Rozladowuje towar z wozu handlarza zwracajac ilosc surowca
        /// oczywiscie narazie żeby tylko działało, wiec bez zadnego sprawdzania.
        /// </summary>
        /// <returns>ilosc surowca</returns>
        public KeyValuePair<string, int> rozladuj(){
            foreach( KeyValuePair<string, Zasob> zasob in ladunek){
                if (zasob.Value.iloscZasobu() != 0){
                    // jesli ktoregos zasobu nie jest 0 (bo tak zakladam dla podstawowej strategi ze bedzie tylko jedna)
                    // to usuwam ja z wozu dajac minus przed iloscia do "zmienIloscZasobu"
                    // i tworze na tego podstawie nowy klucz z wartoscia string int 
                    // gdzie string to nazwa zasobu ktory posiadal handlarz na wozie a into to ilosc tego zasobu ktory posiadal
                    KeyValuePair<string, int> towar = new KeyValuePair<string, int>(zasob.Key, zasob.Value.iloscZasobu());
                    zasob.Value.zmienIloscZasobu(-towar.Value);
                    return towar;
                }
            }
            return new KeyValuePair<string,int>("", 0);
        }


        //Chyba bardziej do testow:
        public override string ToString()
        {
            string stan = string.Format("Pojemnosc wozu: {0} \n stan Wozu: ", ladownosc);
            foreach (KeyValuePair<string, Zasob> para in ladunek)
            {
                stan = string.Format("{0} \n{1} : {2}", stan, para.Key, para.Value.ToString());
            }
            return stan;
        }




    }
}
