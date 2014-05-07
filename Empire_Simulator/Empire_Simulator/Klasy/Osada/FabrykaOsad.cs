using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;

namespace Empire_Simulator
{
    /// <summary>
    /// Klasa która tworzy Osady
    /// </summary>
    class FabrykaOsad
    {
        // ################################# POLA ##########################################

        private static int LICZNIK_OSAD = 0; //Licznik osad jest stały i zwiekszany co utworzeie obiektu osady
        private static List<Point> POZYCJE_OSAD = new List<Point>();
        private static readonly LosowanieZasobu LOSOWANIE_POPULACJI = new LosowanieZasobu(10, 30); 
        private static readonly LosowanieZasobu LOSOWANIE_POZYCJIX = new LosowanieZasobu(40,650);
        private static readonly LosowanieZasobu LOSOWANIE_POZYCJIY = new LosowanieZasobu(40, 570);
        // LOSOWANIE_POPULACJI jest obiektem ktory jest w stanie wylosowac wartosc z zadanego przedziału
        private FabrykaZasobow fabrykaZasobow;
        // korzystamy z fabryki zasobów (wiecej w klasie fabryka zasobow)
        private IStrategiaOsady strategiaOsady;//implementujemy konkretna strategie osady o interfejsie "strategiaOsady"
        private IStrategiaHandlu strategiaHandlu;

        //################################## KONSTRUKTOR ####################################

        public FabrykaOsad(FabrykaZasobow fabrykaZasobow, IStrategiaOsady strategiaOsady, IStrategiaHandlu strategiaHandlu){
            this.fabrykaZasobow = fabrykaZasobow;
            this.strategiaOsady = strategiaOsady;
            this.strategiaHandlu = strategiaHandlu;
        }

        //################################## METODY #############################################

        /// <summary>
        /// Losuje osadę
        /// </summary>
        /// <returns> konkretny gotowy do użytku obiekt typu osada</returns>
        public Osada losujOsade()
        {
            Dictionary<string, Zasob> zasobyOsady = new Dictionary<string, Zasob>();
            // słownik przechowujący zasoby osady
            List<Zasob> zasoby = fabrykaZasobow.tworzenieZasobow();
            //lista obiektów typu "zasob" wygenerowana przesz fabrykę zasobów"
            LosowaniePotencjalu potencjalWioski = new LosowaniePotencjalu(fabrykaZasobow.listaZasobow(), 1);
            
            foreach(Zasob zasob in zasoby) 
            {
                zasobyOsady.Add(zasob.nazwaZasobu(), zasob);
                // do słownika dodaje parę postaci Nazwa zasobu - obiekt zasobu
            }

            //Tworze i zwracam konkretny obiekt osady na podstawie wczesniej wygenerowanych danych
            return new Osada(strategiaOsady, 
                            strategiaHandlu, 
                            nastepnaNazwa(), 
                            new Magazyn(zasobyOsady), 
                            losowaPopulacja(), 
                            potencjalWioski.generujPotencjal(), 
                            losujPozycje());
        }

        /// <summary>
        /// losowanie populacji korzystając z wczesniej zdefiniowanego obiektu potrafiącego
        /// wylosować wartość.
        /// </summary>
        /// <returns>gotowy do użycia obiekt typu populacja.</returns>
        private Populacja losowaPopulacja()
        {
            return new Populacja(LOSOWANIE_POPULACJI.losujZasob());
        }

        /// <summary>
        /// wyznacza nastepna nazwę której może użyć do nazwania nowotworzonej osady
        /// pobierajac wartosc nazwy automatycznie podnosimy licznik stworzonych wiosek
        /// </summary>
        /// <returns>nazwe dla kolejnej osady postaci: Osada + LICZNIK</returns>
        private string nastepnaNazwa()
        {
            LICZNIK_OSAD += 1;
            return string.Format("Osada {0}", LICZNIK_OSAD);
        }


        /// <summary>
        /// losuje pozycje (korzystajac z modulu losujacego zasoby)  i sprawdza czy wektor dzielacy wylosowana 
        /// pozycje od wszystkich osad ktore posiadam jest dluzszy od 100, co zapewni mi to ze nie
        /// wylosuje wioski jednej zaraz obok drugiej.
        /// </summary>
        /// <returns></returns>
        private Point losujPozycje()
        {

            while (true)
            {
                Point pozycja = new Point(LOSOWANIE_POZYCJIX.losujZasob(), LOSOWANIE_POZYCJIY.losujZasob());
                bool zaBlisko = false;
                foreach (Point pozycjaOsady in POZYCJE_OSAD)
                {
                    if (Point.Subtract(pozycjaOsady, pozycja).Length < 100)
                    {
                        zaBlisko = true;
                        break;
                    }
                }
                if (zaBlisko)
                {
                    continue;
                }
                POZYCJE_OSAD.Add(pozycja);
                return pozycja;
            }
        }
                    


    }


}
