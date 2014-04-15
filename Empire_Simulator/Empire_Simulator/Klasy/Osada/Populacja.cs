using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Empire_Simulator
{
    /// <summary>
    /// Klasa Tworzaca obiekty populacji tj zawierajace informacie o liczbie ludnosci
    /// </summary>
    class Populacja
    {
        //############################# POLA ################################
        private int liczbaMieszkancow;

        //############################# KONSTRUKTOR #########################
        public Populacja(int liczbaPopulacji)
        {
            this.liczbaMieszkancow = liczbaPopulacji;
        }


        //############################# METODY #############################

        /// <summary>
        /// zwraca informacje o liczbie ludnosci
        /// </summary>
        /// <returns> Intowa wartosc oznaczajaca liczbe ludnosci danej poulacji</returns>
        public int liczbaLudnosci(){
            return this.liczbaMieszkancow;
        }

        /// <summary>
        /// metoda do zmiany liczebnosci populacji, na razie jesli nie ma wystarczajacej liczby ludnosci
        /// zeby zmniejszyc ustawiamy ja na zero
        /// </summary>
        /// <param name="wartosc"></param>
        public void zmienLiczbeLudnosci(int wartosc)
        {
            if (this.liczbaMieszkancow + wartosc < 0)
            {
                this.liczbaMieszkancow = 0;
            }
            else
            {
                this.liczbaMieszkancow = liczbaMieszkancow + wartosc;
            }
        }
        
    }
}
