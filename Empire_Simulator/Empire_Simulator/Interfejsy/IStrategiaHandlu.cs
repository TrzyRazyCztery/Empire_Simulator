using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Empire_Simulator
{
    /// <summary>
    /// interfejs opisujacy jak wyglada wymiana towaru miedzy targiem a handlarzem
    /// </summary>
    interface IStrategiaHandlu
    {
        void wymianaTowaru(Magazyn magazyn, Handlarz handlarz, List<string> coSprzedawac);
    }
}
