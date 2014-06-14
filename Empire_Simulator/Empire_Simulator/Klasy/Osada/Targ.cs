using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Empire_Simulator
{
    /// <summary>
    /// Targ posiadany przez miasto i uzywany do komunikacji miedzy handlarzami a miastem
    /// </summary>
    class Targ
    {
        // #################################### POLA #########################################
        private List<string> coSprzedawac;
        private Magazyn magazyn;
        private IStrategiaHandlu strategia;

        //##################################### KONSTRUKTOR #################################
       


        public Targ(Magazyn magazyn, IStrategiaHandlu strategia, List<string> coSprzedawac)
        {
            this.coSprzedawac = coSprzedawac;
            this.strategia = strategia;
            this.magazyn = magazyn;
        }      

        //###################################### METODY ########################################
        /// <summary>
        /// wymiany uzywam ze strategi handlu
        /// </summary>
        /// <param name="handlarz"></param>
        public void WymianaTowaru(Handlarz handlarz)
        {
            strategia.wymianaTowaru(magazyn, handlarz, coSprzedawac);
        }
        



            
         
    }
}
