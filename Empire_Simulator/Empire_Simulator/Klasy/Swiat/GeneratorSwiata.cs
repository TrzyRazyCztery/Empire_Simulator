using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empire_Simulator
{
    class GeneratorSwiata
    {
        private IStrategiaGenerowaniaSwiata strategiaGenerowania;
        FabrykaHandlarzy fabrykaHandlarzy;
        FabrykaOsad fabrykaOsad;
        List<Osada> listaOsad;

        public GeneratorSwiata()
        {
            strategiaGenerowania = new PodstawowaStrategiaGenerowaniaSwiata();
            fabrykaOsad = new FabrykaOsad(new FabrykaZasobow(),
                                          strategiaGenerowania.strategiaOsady(),
                                          strategiaGenerowania.strategiaHandlu());
            listaOsad = generujOsady();
            fabrykaHandlarzy = new FabrykaHandlarzy(strategiaGenerowania.strategiaHandlarza(listaOsad), 
                                                    strategiaGenerowania.pojemnoscWozuHandlarza());
            
        }

        private List<Osada> generujOsady()
        {
            List<Osada> lista = new List<Osada>();
            for (int i = 0; i < strategiaGenerowania.iloscOsadDoWygenerowania(); i++)
            {
                lista.Add(fabrykaOsad.losujOsade());
            }
            return lista;
        }
        private List<Handlarz> generujHandlarzy()
        {
            List<String> zasoby = new List<String>();
            zasoby.Add("Mieso");
            zasoby.Add("Jedwab");
            zasoby.Add("Drewno");
            List<Handlarz> lista = new List<Handlarz>();
            for (int i = 0; i < strategiaGenerowania.iloscHandlarzyDoWygenerowania(); i++)
            {
                Handlarz handlarz = fabrykaHandlarzy.generujHandlarza();
                handlarz.ladujTowar(new KeyValuePair<string, Zasob>(zasoby[i % zasoby.Count], new Zasob(zasoby[i % zasoby.Count], 40, 5)));
                lista.Add(handlarz);
            }
            return lista;
        }

        public Swiat generujSwiat()
        {
            return new Swiat(listaOsad, generujHandlarzy());
        }
    }
}
