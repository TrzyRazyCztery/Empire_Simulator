using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empire_Simulator
{
    partial class OknoGry : Form
    {
        private Timer timer;
        private Swiat swiat;
        private AktualizatorMapy aktualizatorMapy;
        private AktualizacjaStanuSwiata aktualizacjaStanuSwiata;
        private int dzien, miesiac, rok;
        public OknoGry(Swiat swiat)
        {
            
            InitializeComponent();
            this.swiat = swiat;
            this.aktualizacjaStanuSwiata = new AktualizacjaStanuSwiata(swiat);
            narysujMape();
            dzien = 1;
            miesiac = 1;
            rok = 1;
            timer = new Timer();
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Interval = 100;
            timer.Start();

            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);

        }

        void Timer_Tick(object sender, EventArgs e)
        {
            textBoxLabel1.Text = String.Format("Rok : {0}\r\nMiesiąc : {1}", rok,miesiac);
            aktualizacjaStanuSwiata.aktualizujSwiat(dzien);
            Console.WriteLine(swiat.pobierzListeHandlarzy()[0].zwrocPozycje());
            Console.WriteLine(swiat.pobierzListeHandlarzy()[1].zwrocPozycje());
            aktualizatorMapy.Aktualizuj();
            dzien += 1;
            if (dzien % 32 == 0 ){
                miesiac += 1;
                if (miesiac % 13 == 0)
                {
                    miesiac = 1;
                    rok += 1;
                }
            }
            this.Refresh();
        }

        void narysujMape()
        {
            
            GeneratorMapy generatorMapy= new GeneratorMapy();
            generatorMapy.generujMape(this, swiat);
            aktualizatorMapy = generatorMapy.generujAktualizatoraMapy();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.timer.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.timer.Stop();

        }

        
       

        

    }
}
