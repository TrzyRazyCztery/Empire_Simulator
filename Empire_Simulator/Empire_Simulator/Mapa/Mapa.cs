using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Empire_Simulator
{
    class Mapa
    {
        private AktualizatorMapy aktualizatorMapy;
        private OknoGry oknoGry;

        public Mapa(Dictionary<Osada, PictureBox> osadyNaMapie, Dictionary<Handlarz, PictureBox> handlarzeNaMapie, OknoGry oknoGry)
        {
            this.aktualizatorMapy = new AktualizatorMapy(osadyNaMapie, handlarzeNaMapie);
            this.oknoGry = oknoGry;

        }

        public void aktualizujMape()
        {
            aktualizatorMapy.Aktualizuj();
        }




        public void WyswietlMape(){
            oknoGry.Show();
            aktualizujMape();
            oknoGry.Refresh();
            
            Thread.Sleep(1000);
        }
        public void Run()
        {
            WyswietlMape();
            
            
        }

    }
}
