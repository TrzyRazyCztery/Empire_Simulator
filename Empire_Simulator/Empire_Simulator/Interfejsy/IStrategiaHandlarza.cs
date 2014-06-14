using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;

namespace Empire_Simulator
{
    /// <summary>
    /// Interfejs mówiący o tym jak wyznaczać nowy cel podróży dla handlarza oraz w jaki sposob sie przemieszcza
    /// 
    /// </summary>
    interface IStrategiaHandlarza
    {
        Osada wyznaczCelPodrozy(Handlarz handlarz);
        Point podrozuj(Point pozycja, Point celPodrozy);
    }
}
