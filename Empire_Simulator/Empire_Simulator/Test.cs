using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Empire_Simulator
{
    public class Test
    {
         [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GeneratorSwiata generatorSwiata = new GeneratorSwiata();
            Swiat swiat = generatorSwiata.generujSwiat();
            OknoGry okno = new OknoGry(swiat);
            Application.Run(okno);


 
            


          
            
        }
    }
}
