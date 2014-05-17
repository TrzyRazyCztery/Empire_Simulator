using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empire_Simulator
{
    class WatekUruchomieniaMapy
    {
        private OknoGry okno;

        public WatekUruchomieniaMapy(OknoGry okno)
        {
            this.okno = okno;

        }
        [STAThread]
        public void uruchomaMape()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(okno);
        }
    }
}
