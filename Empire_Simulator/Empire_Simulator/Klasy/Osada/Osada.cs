using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Empire_Simulator
{
    /// <summary>
    /// Klasa Tworzaca obiekt osady
    /// </summary>
    class Osada
    {

        //################################ POLA ###########################################

        private Magazyn magazyn; 
        private Targ targ; 
        private Populacja populacja; 
        private StrategiaOsady strategia;
        private string nazwa;
        private PotencjalWydobywczy potencjalWydobywczy;

        //############################### KONSTRUKTOR #########################################

        public Osada(StrategiaOsady strategia, string nazwa, Magazyn magazyn, Populacja populacja)
        {
            this.nazwa = nazwa;
            this.populacja = populacja;
            this.magazyn = magazyn;
            this.targ = new Targ(magazyn);
            this.strategia = strategia;
        }


        //############################### METODY ##################################################

        /// <summary>
        /// zwraca Targ
        /// </summary>
        /// <returns>obiekt Targ</returns>
        public Targ Targowisko(){
            return this.targ;
        }

        /// <summary>
        /// Aktualizujue swój stan tj magazyny i populacje, korzystając ze strategi
        /// </summary>
        public void aktualizuj()
        {
            strategia.aktualizujStanyMagazynowe(magazyn, potencjalWydobywczy, populacja.liczbaLudnosci());
            strategia.aktualizujStanPopulacji(populacja, magazyn);
        }

        /// <summary>
        /// Zwraca magazyn
        /// zastanawiam sie czy to nie jest tylko metoda testowa.
        /// </summary>
        /// <returns></returns>
        public Magazyn magazyny()
        {
            return magazyn;
        }


        //################################ METODY DO TESTOW #############################################
        

        //zwraca statystyki osady 
        override public string ToString()
        {
            return string.Format("Osada : {0} \n" +
                                 "Zasoby:  \n" +
                                 "{1} \n" +
                                 "populacja : {2}", this.nazwa, this.magazyn.ToString(), populacja.liczbaLudnosci().ToString());
        }

    }
}
