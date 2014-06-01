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
        public void laduj(KeyValuePair<string, Zasob> towar){
            ladunek.Add(towar.Key, towar.Value);
        }
        /// <summary>
        /// Rozladowuje towar z wozu handlarza zwracajac ilosc surowca
        /// oczywiscie narazie żeby tylko działało, wiec bez zadnego sprawdzania.
        /// </summary>
        /// <returns>ilosc surowca</returns>
        public KeyValuePair<string, Zasob> rozladuj(){
            KeyValuePair<string, Zasob> towar = ladunek.FirstOrDefault();
            ladunek.Clear();
            return towar;
        }

        public string NazwaPrzewozonegoZasobu()
        {
            return ladunek.FirstOrDefault().Value.nazwaZasobu();
        }


        //Chyba bardziej do testow:
        public override string ToString()
        {
            string stan = string.Format("Pojemnosc wozu: {0} kg. \n stan Wozu: ", ladownosc);
            foreach (KeyValuePair<string, Zasob> para in ladunek)
            {
                stan = string.Format("{0} \n{1} : {2}", stan, para.Key, para.Value.ToString());
            }
            return stan;
        }




    }
}
