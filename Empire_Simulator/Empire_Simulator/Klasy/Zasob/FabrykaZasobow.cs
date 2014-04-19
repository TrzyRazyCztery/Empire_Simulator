using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Empire_Simulator
{

    /// <summary>
    /// Fabryka Zasobow to klasa ktora potrafi generowac gotowe do uzycia obiekty zasobow na podstawie
    /// swoich danyh
    /// </summary>
    public class FabrykaZasobow
    {
        // ########################################## POLA ###############################################
        private static readonly List<string>          UTWORZONE_NAZWY_ZASOBOW = new List<string>(new[] { "Jedwab", "Mieso", "Drewno" });
        // Lista ktora na kolejnych indeksach ma nazwy zasobów
        private static readonly List<LosowanieZasobu> UTWORZONE_ILOSCI_ZASOBOW = new List<LosowanieZasobu>(
                                                                         new[] { new LosowanieZasobu(200,300),
                                                                                 new LosowanieZasobu(200,300), 
                                                                                 new LosowanieZasobu(200,300), 
                                                                                });
        // lista ktora  na indeksach ma obiekty potrafiace losowac ilosci zasobi z danego zakresu, jesli chce 
        // by mozliwosc wylosowania jedwabiu byla 1-10 to obiekt potrafiacy losowac z takiego przedzialu umieszczam
        // na liscie  takim samym numerze indeksu co nazwa interesujacego mnie zasobu

        private static readonly List<int>             UTWORZONE_WAGI_ZASOBOW = new List<int>(new[] { 1, 5, 15 });
        // podobnie jak poprzednio tylko juz konkretne wartosci intowe ktore sa wagą zasobu ktory znajduje sie na liscie
        // utworzonych nazw zasobow na tym indeksie co jego waga

        


        //############################################# METODY #############################################
        /// <summary>
        /// Tworzy tyle obiektow zasobu ile jest nazw w liscie utworzonych nazw zasobow i umieszcza je na liscie
        /// dzieki temu uzywajac pozniej takiej fabryki wiemy ze dostaniemy liste obiektow na ktorej znadzie
        /// sie obiekt kazdego z zasobow dostepnych w grze
        /// </summary>
        /// <returns>lista konkretnych gotowych obiektow typu zasób</returns>
        public List<Zasob> tworzenieZasobow()
        {
            List<Zasob> zasoby = new List<Zasob>();

            for (int i = 0; i < UTWORZONE_NAZWY_ZASOBOW.Count; i++)
            {
                zasoby.Add(new Zasob(UTWORZONE_NAZWY_ZASOBOW.ElementAt(i),
                                     UTWORZONE_ILOSCI_ZASOBOW.ElementAt(i).losujZasob(),
                                     // jako ze w tym miejscu na liscie byly obiekty potrafiace losowac to
                                     // uzywamy tu metody "losojZasob"
                                     UTWORZONE_WAGI_ZASOBOW.ElementAt(i)));
            }

            return zasoby;
        }

        /// <summary>
        /// zwraca liste ktorej uzywa losowanie potencjalu
        /// </summary>
        /// <returns></returns>
        public List<string> listaZasobow()
        {
            return UTWORZONE_NAZWY_ZASOBOW;
        }
       
    }
}
