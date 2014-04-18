using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Empire_Simulator
{
    class Handlarz
    {
        //####################################### POLA #####################################
        private WozHandlarza woz;
        private StrategiaHandlarza aktualnaStrategia;
        private string nazwa;

        //####################################### KONSTRUKTOR ##############################

        public Handlarz(StrategiaHandlarza strategia, int ladownoscWozu, string nazwa)
        {
            woz = new WozHandlarza(ladownoscWozu);
            this.aktualnaStrategia = strategia;
            this.nazwa = nazwa;

        }

        //####################################### METODY #####################################

        public void zamien()
        {

        }


        //#################################### METODY DO TESTOW ###############################

        public override string ToString()
        {
            return string.Format("{0} \n" +
                                 "{1}", this.nazwa, this.woz.ToString()); 
        }
        
    }
}
