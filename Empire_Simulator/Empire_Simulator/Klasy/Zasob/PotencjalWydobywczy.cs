using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Empire_Simulator
{
    /// <summary>
    /// Potencjal wydobywczy bedzie gotowym obiektem zawieajacym liste obiektow zasobu jakie generuje dana
    /// osada
    /// </summary>
    class PotencjalWydobywczy
    {

        // ######################### POLA##########################
        private List<string> generowaneZasoby = new List<string>();

        //########################## KONSTRUKTOR ##################

        public PotencjalWydobywczy(List<string> lista)
        {
            this.generowaneZasoby = lista;
        }
        
        //############################# METODY #######################
        /// <summary>
        /// metoda zwracajaca liste potencjalu
        /// </summary>
        /// <returns></returns>
        public List<string> pobierzPotencjal()
        {
            return generowaneZasoby;
        }
        
        //########################## METODY DO TESTOW ###############

        public override string ToString()
        {
            string lista = "";
            foreach (string element in generowaneZasoby){
                lista = lista + " " + element;
            }
            return lista;
        } 
    }
}
