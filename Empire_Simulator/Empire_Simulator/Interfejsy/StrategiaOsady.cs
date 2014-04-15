using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Empire_Simulator
{
    /// <summary>
    /// Interfejs strategi osady wymusza metody których używa osada do zaktualizowania swojego statusu
    /// tj. stanow magazynowych i populacji, strategie bedą wymienne
    /// </summary>
    interface StrategiaOsady
    {
        /// <summary>
        /// Aktualizacja statnu popoulacji polega na zwiekszeniu lub zmiejszeniu populacji
        /// w zaleznosci od konkretnej strategi
        /// </summary>
        /// <param name="populacja"></param>
        /// <param name="stanMagazynowy"></param>
        void aktualizujStanPopulacji(Populacja populacja, Magazyn stanMagazynowy);

        /// <summary>
        /// aktualizacja stanów magazynowych polega na zwikszeniu lub zmiejszeniu stanow magazynowych
        /// w zależnosci od potencjalu wydobywczego itp.
        /// </summary>
        /// <param name="magazyn"></param>
        /// <param name="potencjalWydobywczy"></param>
        /// <param name="liczbaLudnosci"></param>

        void aktualizujStanyMagazynowe(Magazyn magazyn, PotencjalWydobywczy potencjalWydobywczy, int liczbaLudnosci);

    }
}
