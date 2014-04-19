using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Empire_Simulator
{
    /// <summary>
    /// zwraca liste wylosowanych zasobow.
    /// </summary>
    class LosowaniePotencjalu
    {
        //######################## POLA #############################
        private List<string> listaDostepnychZasobow;
        private static Random generator = new Random();
        private int ileLosowac;
        private List<string> listaWylosowanychZasobow;

        //######################## KONSTRUKTOR ######################

        public LosowaniePotencjalu(List<string> listaZasobow, int ileLosowac)
        {
            listaWylosowanychZasobow = new List<string>();
            this.ileLosowac = ileLosowac;
            this.listaDostepnychZasobow = listaZasobow;
        }

        //######################## METODY ###########################
        /// <summary>
        /// generuje gotowy obiekt potencjalu zawierajacy liste wydobywanych surowcow
        /// </summary>
        /// <returns>obiekt potencjału</returns>

        public PotencjalWydobywczy generujPotencjal()
        {
            losujZasoby();
            return new PotencjalWydobywczy(listaWylosowanychZasobow);

        }

        /// <summary>
        /// idea losowania jest taka, mam liczbe dosteonych surowcow losuje indeks tej listy 
        /// i usuwam ten surowiec z listy dostepnych i wrzucam go na moja nowa liste wylosowanych surowcow
        /// dzieki czemu wiem ze moja lista wygenerowanych surowcow nie bedzie zawierala powtórzen.
        /// 
        /// </summary>
        private void losujZasoby()
        {
            List<string> listaDostepnychZasobow2 = listaDostepnychZasobow.ToList();
            for (int i = 1; i <= this.ileLosowac; i++)
            {
                int wygenerowanyIndeks = generator.Next(listaDostepnychZasobow2.Count);
                listaWylosowanychZasobow.Add(listaDostepnychZasobow2.ElementAt(wygenerowanyIndeks));
                listaDostepnychZasobow2.RemoveAt(wygenerowanyIndeks);
                
            }
        }



    }
}
