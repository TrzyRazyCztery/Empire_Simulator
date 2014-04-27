using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;

namespace Empire_Simulator
{
    interface IStrategiaHandlarza
    {
        Osada wyznaczCelPodrozy(Handlarz handlarz);
        Point podrozuj(Point pozycja, Point celPodrozy);
    }
}
