using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empire_Simulator
{
    /// <summary>
    /// Jest to klasa której obiekt potrafi wygenerowac swiat na podstawie podanej strategi
    /// </summary>
    class GeneratorSwiata
    {
        private IStrategiaGenerowaniaSwiata strategiaGenerowania;
        FabrykaHandlarzy fabrykaHandlarzy;
        FabrykaOsad fabrykaOsad;
        List<Osada> listaOsad;
        List<Handlarz> listaHandlarzy;

        public GeneratorSwiata()
        {
            strategiaGenerowania = new PodstawowaStrategiaGenerowaniaSwiata();
            fabrykaOsad = new FabrykaOsad(new FabrykaZasobow(),
                                          strategiaGenerowania.strategiaOsady(),
                                          strategiaGenerowania.strategiaHandlu());
            listaOsad = generujOsady();
            fabrykaHandlarzy = new FabrykaHandlarzy(strategiaGenerowania.pojemnoscWozuHandlarza());
            listaHandlarzy = generujHandlarzy();
            ustalPierwszeCeleILadunkiHandlarzom();
            

        }
        /// <summary>
        /// metoda jest tylko chwilowa gdy nie ma jeszcze rozwiazanego w pełni problemu startu handlarzy
        /// </summary>
        private void ustalPierwszeCeleILadunkiHandlarzom()
        {
            List<String> zasoby = new List<String>();
            zasoby.Add("Mieso");
            zasoby.Add("Jedwab");
            zasoby.Add("Drewno");
            foreach (Handlarz handlarz in listaHandlarzy)
            {
                handlarz.ustalStrategie(strategiaGenerowania.strategiaHandlarza(listaOsad, listaHandlarzy));
                handlarz.ladujTowar(new KeyValuePair<string, Zasob>(zasoby[listaHandlarzy.IndexOf(handlarz) % zasoby.Count], new Zasob(zasoby[listaHandlarzy.IndexOf(handlarz) % zasoby.Count], 100, 5)));
            }
        }
        /// <summary>
        /// metoda generujaca osady na podstawie strategi
        /// </summary>
        /// <returns>lista Osad</returns>
        private List<Osada> generujOsady()
        {
            List<Osada> lista = new List<Osada>();
            for (int i = 0; i < strategiaGenerowania.iloscOsadDoWygenerowania(); i++)
            {
                lista.Add(fabrykaOsad.losujOsade());
            }
            return lista;
        }
        /// <summary>
        /// metoda generujaca handlarzy na podstawie strategi
        /// </summary>
        /// <returns>lista Handlarzy</returns>
        private List<Handlarz> generujHandlarzy()
        {
       
            List<Handlarz> lista = new List<Handlarz>();
            for (int i = 0; i < strategiaGenerowania.iloscHandlarzyDoWygenerowania(); i++)
            {
                Handlarz handlarz = fabrykaHandlarzy.generujHandlarza();
                
                lista.Add(handlarz);
            }
            return lista;
        }

        /// <summary>
        /// zwraca wygenerowany Świat
        /// </summary>
        /// <returns>Obekt klasy Świat</returns>
        public Swiat generujSwiat()
        {
            return new Swiat(listaOsad, listaHandlarzy);
        }
    }
}
