using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace Empire_Simulator
{
    class AktualizatorMapy
    {
        private Dictionary<Osada, PictureBox> osadyNaMapie;
        private Dictionary<Handlarz, PictureBox> handlarzeNaMapie;

        public AktualizatorMapy(Dictionary<Osada, PictureBox> osady, Dictionary<Handlarz, PictureBox> handlarze)
        {
            this.osadyNaMapie = osady;
            this.handlarzeNaMapie = handlarze;
        }

        public void Aktualizuj()
        {
            foreach (KeyValuePair<Osada, PictureBox> para in osadyNaMapie)
            {
                if (para.Key.populacjaOsady() >= 0 && para.Key.populacjaOsady() < 60)
                {
                    para.Value.Image = global::Empire_Simulator.Properties.Resources.osada1;
                    para.Value.Size = para.Value.Image.Size;
                }
                else if (para.Key.populacjaOsady() >= 60 && para.Key.populacjaOsady() < 120)
                {
                    para.Value.Image = global::Empire_Simulator.Properties.Resources.osada2;
                    para.Value.Size = para.Value.Image.Size;
                }
                else if (para.Key.populacjaOsady() >= 120 && para.Key.populacjaOsady() < 200)
                {
                    para.Value.Image = global::Empire_Simulator.Properties.Resources.osada3;
                    para.Value.Size = para.Value.Image.Size;
                }
                else if (para.Key.populacjaOsady() >= 200)
                {
                    para.Value.Image = global::Empire_Simulator.Properties.Resources.osada4;
                    para.Value.Size = para.Value.Image.Size;
                }
            }
            foreach (KeyValuePair<Handlarz, PictureBox> para in handlarzeNaMapie)
            {
                bool wOkolicyOsady = false;
                para.Value.Location = new System.Drawing.Point(Convert.ToInt32(para.Key.zwrocPozycje().X), Convert.ToInt32(para.Key.zwrocPozycje().Y));
                foreach (KeyValuePair<Osada, PictureBox> temp in osadyNaMapie)
                {
                    if (Point.Subtract(new Point(para.Key.zwrocPozycje().X + 50, para.Key.zwrocPozycje().Y + 25), new Point(temp.Key.pozycjaOsady().X + 50 , temp.Key.pozycjaOsady().Y + 50)).Length <= 70) {
                        para.Value.Visible = false;
                        wOkolicyOsady = true;
                        break;
                    }   
                }
                if (wOkolicyOsady == false)
                {
                    para.Value.Visible = true;
                }

                para.Value.Location = new System.Drawing.Point(Convert.ToInt32(para.Key.zwrocPozycje().X), Convert.ToInt32(para.Key.zwrocPozycje().Y));
            }                                                                                                               
        }
    }
}
