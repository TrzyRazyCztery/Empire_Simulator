using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Empire_Simulator
{
    /// <summary>
    /// Magazyn jest obiektem posiadanym przez osadę, i przetrzymującym w swoich polach
    /// ilośći zasobów posiadane przez ową wioskę
    /// </summary>
    class Magazyn
    {
        // ############################## POLA ######################################


        private Dictionary<string, Zasob> zasoby;
        // słownik przetrzymujący pary postaci: Nazwa zasobu - obiekt zasobu
        

        
        // ############################## KONSTRUKTOR ###############################
        public Magazyn(Dictionary<string, Zasob> zasoby)
        {
            this.zasoby = zasoby;
        }



        // ############################## METODY ####################################


        /// <summary>
        /// metoda zwracająca obecny stan Magazynu
        /// </summary>
        /// <returns>słownik zawierajacy stan magazynu</returns>
        public Dictionary<string, Zasob> pobierzStanMagazynu(){
            return zasoby;
        }


        //jesli chciialbym moc podmieniac stan magazynu zamiast podmieniac wartosci w obiektach zasobow
        //public void zmienStanMagazynu(Dictionary<string,Zasob> zasoby)
        //{
        //    this.zasoby = zasoby;
        //}





        //########################## METODY TESTOWE ##############################


        //zwraca stan magazynu jako liste zasobow i ich ilosc
        public override string ToString()
        {
            string stan = "stan Magazynu: ";
            foreach (KeyValuePair<string, Zasob> para in zasoby)
            {
                stan = string.Format("{0} \n{1} : {2}",stan, para.Key, para.Value.ToString());
            }
            return stan;
        }

    }
}
