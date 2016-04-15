using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ZBobb;

namespace Empire_Simulator
{
    class GeneratorMapy
    { 

        private Dictionary<Osada, PictureBox> osadyNaMapie;
        private Dictionary<Handlarz, PictureBox> handlarzeNaMapie;
        private PictureBox tloMapy;
        private TextBoxLabel stanOsady;

        public GeneratorMapy()
        {
            osadyNaMapie = new Dictionary<Osada, PictureBox>();
            handlarzeNaMapie = new Dictionary<Handlarz, PictureBox>();
            tloMapy = new PictureBox();
            stanOsady = new TextBoxLabel();
        }
        private void dodajTlo(OknoGry okno)
        {
            tloMapy.Image = global::Empire_Simulator.Properties.Resources.tloEmpireSimulator;
            tloMapy.Location = new System.Drawing.Point(1, 3);
            tloMapy.Name = "mapa";
            tloMapy.Size = new System.Drawing.Size(1200, 794);
            tloMapy.TabIndex = 0;
            tloMapy.TabStop = false;
            naniesOsadyNaMape(tloMapy);
            naniesHandlarzyNaMape(tloMapy);
            dodajPoleOpisuOsady();

            okno.Controls.Add(tloMapy);
        }
        private void dodajPoleOpisuOsady()
        {
            tloMapy.Controls.Add(stanOsady);
            stanOsady.Parent = tloMapy;
            stanOsady.Multiline = true;
            stanOsady.Location = new System.Drawing.Point(899, 228);
            stanOsady.Size = new System.Drawing.Size(207, 207);

            stanOsady.BackAlpha = 50;
            stanOsady.Font = new System.Drawing.Font("SketchFlow Print", 14, System.Drawing.FontStyle.Bold);
            stanOsady.ReadOnly = true;
            stanOsady.BorderStyle = BorderStyle.None;



        }
        private void dodajOsady(Swiat swiat)
        {

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

        private void dodajHandlarzy(Swiat swiat)
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

        private void naniesOsadyNaMape(PictureBox tloMapy)
        {
            foreach (KeyValuePair<Osada, PictureBox> para in osadyNaMapie)
            {
                tloMapy.Controls.Add(para.Value);
                para.Value.MouseClick += new MouseEventHandler(wypisywanieStanuWioski);


            }
        }
        private void naniesHandlarzyNaMape(PictureBox tloMapy)
        {
            foreach (KeyValuePair<Handlarz, PictureBox> para in handlarzeNaMapie)
            {
                tloMapy.Controls.Add(para.Value);
            }
        }

        public void generujMape(OknoGry okno, Swiat swiat)
        {
            dodajOsady(swiat);
            dodajHandlarzy(swiat);
            dodajTlo(okno);

        }
        public AktualizatorMapy generujAktualizatoraMapy()
        {
            return new AktualizatorMapy(osadyNaMapie, handlarzeNaMapie);
        }

        private void wypisywanieStanuWioski(object sender, MouseEventArgs e)
        {
            var box = sender as PictureBox;
            foreach (KeyValuePair<Osada, PictureBox> para in osadyNaMapie)
            {
                if (para.Value == box)
                {
                    stanOsady.Text = para.Key.ToString();

                    break;
                }
            }




        }

    }

    class TextBoxLabel : AlphaBlendTextBox
    {
        public TextBoxLabel()
        {
            this.SetStyle(ControlStyles.Selectable, false);
            this.TabStop = false;
        }
        protected override void WndProc(ref Message m)
        {
            // Workaround required since TextBox calls Focus() on a mouse click
            // Intercept WM_NCHITTEST to make it transparent to mouse clicks
            if (m.Msg == 0x84) m.Result = IntPtr.Zero;
            else base.WndProc(ref m);
        }
    }


}
