using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Empire_Simulator
{
    /// <summary>
    /// Tworzy obiekt potrafiacy wylosowac liczbe z zadanego mu przedzialu
    /// </summary>
    class LosowanieZasobu
    {
        static Random generator = new Random();
        private int minimum;
        private int maksimum;

        public LosowanieZasobu(int minimum, int maksimum)
        {
            this.minimum = minimum;
            this.maksimum = maksimum;
        }

        /// <summary>
        /// zraca wartosc int ktora bedzie z przedzialu minimum a maksimum
        /// jakos ze losujemy od zera do maksimum to do wylosowanej liczby dodajemy minimum
        /// dzieki czemu najnizsza wartosc jaka dostaniemy jest wlasnie minimum
        /// w przypadku gdy generator losuje zero
        /// </summary>
        /// <returns></returns>
        public int losujZasob()
        {
           
           return generator.Next(maksimum - minimum) + minimum;
            
        }
    }
}
