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
       
        private Magazyn magazyn;


        //##################################### KONSTRUKTOR #################################
       


        public Targ(Magazyn magazyn)
        {
            this.magazyn = magazyn;
        }      

        //###################################### METODY ########################################
    }
}
