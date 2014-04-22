using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;

namespace Empire_Simulator
{
    class Handlarz
    {
        //####################################### POLA #####################################
        private Point pozycja;
        private WozHandlarza woz;
        private IStrategiaHandlarza aktualnaStrategia;
        private string nazwa;

        //####################################### KONSTRUKTOR ##############################

        public Handlarz(IStrategiaHandlarza strategia, int ladownoscWozu, string nazwa)
        {
            this.pozycja = new Point(500, 500);
            this.woz = new WozHandlarza(ladownoscWozu);
            this.aktualnaStrategia = strategia;
            this.nazwa = nazwa;

        }

        //####################################### METODY #####################################

        public void zamien()
        {

        }
        public Point WyznaczCelPodrozy()
        {
            return aktualnaStrategia.WyznaczCelPodrozy(this);
        }


        //#################################### METODY DO TESTOW ###############################

        public override string ToString()
        {
            return string.Format("{0} \n" +
                                 "{2} \n" +
                                 "{1}", this.nazwa, this.woz.ToString(), this.pozycja.ToString()); 
        }

        public WozHandlarza zwrocWoz()
        {
            return woz;
        }
        
    }
}
