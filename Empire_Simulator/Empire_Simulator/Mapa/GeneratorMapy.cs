using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Empire_Simulator
{
    class GeneratorMapy
    {
        OknoGry okno;
        Swiat swiat;
        Dictionary<Osada, PictureBox> osadyNaMapie;
        Dictionary<Handlarz, PictureBox> handlarzeNaMapie;

        public GeneratorMapy(Swiat swiat)
        {
            this.okno = new OknoGry();
            this.swiat = swiat;
            osadyNaMapie = new Dictionary<Osada,PictureBox>();
            handlarzeNaMapie = new Dictionary<Handlarz, PictureBox>();
            dodajOsady();
            dodajHandlarzy();
        }
        public void dodajLayout()
        {
            PictureBox tloMapy = new PictureBox();
            tloMapy.Image = global::Empire_Simulator.Properties.Resources.tloEmpireSimulator1;
            tloMapy.Location = new System.Drawing.Point(1, 3);
            tloMapy.Name = "mapa";
            tloMapy.Size = new System.Drawing.Size(799, 794);
            tloMapy.TabIndex = 0;
            tloMapy.TabStop = false;
            naniesOsadyNaMape(tloMapy);
            naniesHandlarzyNaMape(tloMapy);
            
            this.okno.Controls.Add(tloMapy);
        }

        public void dodajOsady(){

            foreach (Osada osada in swiat.pobierzListeOsad())
            {
                osadyNaMapie.Add(osada, new PictureBox());
                PictureBox tempPictureBox = osadyNaMapie[osada];
                tempPictureBox.Image = global::Empire_Simulator.Properties.Resources.osada1;
                tempPictureBox.Location = new System.Drawing.Point(Convert.ToInt32(osada.pozycjaOsady().X), Convert.ToInt32(osada.pozycjaOsady().Y));
                tempPictureBox.Name = "Osada";
                tempPictureBox.Size = tempPictureBox.Image.Size;
                tempPictureBox.BackColor = System.Drawing.Color.Transparent;
                
            }
                 
        }

        public void dodajHandlarzy()
        {
            foreach (Handlarz handlarz in swiat.pobierzListeHandlarzy())
            {
                handlarzeNaMapie.Add(handlarz, new PictureBox());
                PictureBox tempPictureBox = handlarzeNaMapie[handlarz];
                tempPictureBox.Image = global::Empire_Simulator.Properties.Resources.handlarz;
                tempPictureBox.Location = new System.Drawing.Point(Convert.ToInt32(handlarz.zwrocPozycje().X), Convert.ToInt32(handlarz.zwrocPozycje().Y));
                tempPictureBox.Name = "Handlarz";
                tempPictureBox.Size = tempPictureBox.Image.Size;
                tempPictureBox.BackColor = System.Drawing.Color.Transparent;
            }
        }

        public void naniesOsadyNaMape(PictureBox tloMapy)
        {
            foreach (KeyValuePair<Osada, PictureBox> para in osadyNaMapie)
            {
                tloMapy.Controls.Add(para.Value);
            } 
        }
        public void naniesHandlarzyNaMape(PictureBox tloMapy)
        {
            foreach (KeyValuePair<Handlarz, PictureBox> para in handlarzeNaMapie)
            {
                tloMapy.Controls.Add(para.Value);
            }
        }

        public void wyswietlMape()
        {
            this.okno.Show();
            this.okno.Refresh();
        }
        public void Run()
        {
            dodajLayout();
            wyswietlMape();
            Thread.Sleep(10000);
        }
            
    }

        
            

}

