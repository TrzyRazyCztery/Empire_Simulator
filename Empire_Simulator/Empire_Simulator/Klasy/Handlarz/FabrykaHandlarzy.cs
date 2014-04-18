using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Empire_Simulator
{
    /// <summary>
    /// generuje handlarzy z podana strategią i iloscia towaru ktora mogą ze sobą wozić.
    /// </summary>
    class FabrykaHandlarzy
    {
        //################################## POLA ########################################
        private static int LICZNIK_HANDLARZY = 0;
        private StrategiaHandlarza strategia;
        private int ladownoscHandlarzy;

        //################################## KONSTRUKTOR #################################

        public FabrykaHandlarzy(StrategiaHandlarza strategia)
        {
            this.strategia = strategia;
        }


        //################################## METODY ######################################

        public Handlarz generujHandlarza()
        {
            return new Handlarz(strategia, ladownoscHandlarzy, nastepnaNazwa());
        }



        private string nastepnaNazwa()
        {
            LICZNIK_HANDLARZY += 1;
            return string.Format("Handlarz {0}", LICZNIK_HANDLARZY);
        }


    }
}
