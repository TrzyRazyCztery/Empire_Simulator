using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Empire_Simulator
{
    class PodstawowaStrategiaHandlu : IStrategiaHandlu
    {
        /// <summary>
        /// Obecna wymiana polega na tym ze handlarz wymienia sie z targiem porowno, tj rozladowuje swoje zasoby i sa
        /// ladowane do magazynua potem z magazynu bierzemy surowiec ktorego jest najwiecej i ladujemy mu na woz
        /// Pożadana strategia jest raczej inna, pozniewaz obecna jest strasznie trywialna.
        /// </summary>
        /// <param name="magazyn"></param>
        /// <param name="handlarz"></param>
        public void wymianaTowaru(Magazyn magazyn, Handlarz handlarz)
        {
            KeyValuePair<string, Zasob> towarHandlarza = handlarz.rozladujTowar();
            Dictionary<string, Zasob> stanMagazynu = magazyn.pobierzStanMagazynu();
            Zasob towarDoMagazynu = stanMagazynu[towarHandlarza.Key];

            towarDoMagazynu.zmienIloscZasobu(towarHandlarza.Value.iloscZasobu());

            KeyValuePair<string, Zasob> towarZMagazynu = new KeyValuePair<string, Zasob>("", new Zasob("", 0, 0));
            foreach (KeyValuePair<string, Zasob> para in stanMagazynu)
            {
                if (para.Value.iloscZasobu() > towarZMagazynu.Value.iloscZasobu())
                {
                    towarZMagazynu = para;
                }
            }
            towarZMagazynu.Value.zmienIloscZasobu(-towarHandlarza.Value.iloscZasobu());
            handlarz.ladujTowar(new KeyValuePair<string, Zasob>(towarZMagazynu.Key, new Zasob(towarZMagazynu.Key, towarHandlarza.Value.iloscZasobu(), towarZMagazynu.Value.zwrocWageZasobu())));



        }
    }
}
