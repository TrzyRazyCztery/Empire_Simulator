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
        private Osada celPodrozy;
        //####################################### KONSTRUKTOR ##############################

        public Handlarz( int ladownoscWozu, string nazwa)
        {
            this.pozycja = new Point(500, 500);
            this.woz = new WozHandlarza(ladownoscWozu);
            this.nazwa = nazwa;

        }

        //####################################### METODY #####################################
        
        public void ustalStrategie(IStrategiaHandlarza strategia){
            this.aktualnaStrategia = strategia;
        }
        
        /// <summary>
        /// Wyznacza cel podróży na podstawie tego co ma na wozie i strategi handlarza
        /// </summary>
        /// <returns>obiekt osady do ktorej sie kieruje</returns>
        public Osada WyznaczCelPodrozy()
        {
            return aktualnaStrategia.wyznaczCelPodrozy(this);
        }
        /// <summary>
        /// Zwraca to co ma na wozie (Czy to napewno dobry pomysl?)
        /// lepiej chyba bedzie jesli kazda kominikacja z wozem bedzie
        /// odbywala sie za pomoca handlarza
        /// </summary>
        /// <returns>obiekt wozu handlarza</returns>
        
        public WozHandlarza zwrocWoz()
        {
            return woz;
        }
        
        /// <summary>
        /// rozladowuje towar ze swjojego wozu
        /// </summary>
        /// <returns> para nazwy zasobu z zasobem</returns>
        public KeyValuePair<string, Zasob> rozladujTowar()
        {
            return woz.rozladuj();
        }
        /// <summary>
        /// laduje dany towar na woz
        /// i ustala sobie na podstawie tego co zaladowal nowy cel podróży.
        /// </summary>
        /// <param name="towar"></param>
        
        public void ladujTowar(KeyValuePair<string, Zasob> towar)
        {
            woz.laduj(towar);
            celPodrozy = WyznaczCelPodrozy();
        }

        /// <summary>
        /// zwraca pozycje w jakiej znajduje się handlarz
        /// </summary>
        /// <returns>Point(X,Y)</returns>
        public Point zwrocPozycje()
        {
            return this.pozycja;
        }
        /// <summary>
        /// Aktualizuje stan handlarza
        /// przesuwa go do nowej pozyjci i ew wsyła na targ jesli jest blisko osady
        /// </summary>
        public void aktualizuj()
        {
            this.pozycja = aktualnaStrategia.podrozuj(pozycja, celPodrozy.pozycjaOsady());
            if (Point.Subtract(pozycja, celPodrozy.pozycjaOsady()).Length <= 20)
            {
                celPodrozy.Targowisko().WymianaTowaru(this);
            }
        }
        /// <summary>
        /// zwraca do jakiej osady podróżuje handlarz
        /// </summary>
        /// <returns>obiekt osady</returns>
        public Osada zwrocCelPodrozy()
        {
            return celPodrozy;
        }

        //#################################### METODY DO TESTOW ###############################

        public override string ToString()
        {
            return string.Format("{0} \n" +
                                 "{2} \n" +
                                 "{3} \n" +
                                 "{1}", this.nazwa, this.woz.ToString(), this.pozycja.ToString(), this.celPodrozy.pozycjaOsady()); 
        }

        public void reczneUstawienieCelu(Osada osada)
        {
            this.celPodrozy = osada;
        }

      
    }
}
