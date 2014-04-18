using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Empire_Simulator
{
    /// <summary>
    /// Obiekt zasobu przechowujacy jego nazwe wage i ilosc
    /// </summary>
    public class Zasob
    {
        //######################################### POLA ############################################
        private string nazwa;
        private int ilosc;
        private int waga;

        //######################################### KONSTRUKTOR #####################################

        public Zasob(string nazwa, int ilosc, int waga)
        {
            this.nazwa = nazwa;
            this.ilosc = ilosc;
            this.waga = waga;
        }

        //######################################### METODY ##########################################

        /// <summary>
        /// Zwracajaca nazwe zasobu przechowywanego w obiekcie
        /// </summary>
        /// <returns> string z nazwa</returns>
        public string nazwaZasobu()
        {
            return this.nazwa;
        }
        /// <summary>
        /// Zwracajaca ilosc zasobu przechowywanego w klasie
        /// </summary>
        /// <returns> intowa ilosc zasobu</returns>
        public int iloscZasobu()
        {
            return this.ilosc;
        }
        /// <summary>
        /// Metoda zmieniajaca ilosc zasobu o podana wartosc, ujemna albo dodatnią
        /// Na razie przyjalem że gdy nie mam wystarczajcych zasobow na pokrycie czegos
        /// wartosc mojego zasobu sie zeruje
        /// </summary>
        /// <param name="wartosc"></param>
        public void zmienIloscZasobu(int wartosc)
        {
            if (this.ilosc + wartosc < 0)
            {
                this.ilosc = 0;
            }
            else
            {
                this.ilosc = ilosc + wartosc;
            }
        }
        public int zwrocWageZasobu()
        {
            return this.waga;
        }




        //#################################### METODY DO TESTOW ######################################
        override public string ToString()
        {
            return string.Format("{0} {1}, waga {2} kg.", ilosc, nazwa, ilosc * waga);
        }
        
       

        

    }
}
