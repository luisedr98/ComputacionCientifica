using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppImplementacion
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void BtnInterpolar_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(700, 420);
            for (int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 420; j++)
                {
                    if (i>=350)
                    {
                        int r = ((255 * (j - 420)) / -420) + ((240 * (j)) / 420);
                        int g = ((165 * (j - 420)) / -420) + ((230 * (j)) / 420);
                        int b = (140 * (j)) / 420;
                        bmp.SetPixel(i, j, Color.FromArgb(r, g, b));
                    }
                    
                   
                }
            }
            PbxPantalla.Image = bmp;
        }

        private void BtnInterpolarHorizontal_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(700, 420);
            for (int i = 0; i < 700; i++)
            {
                for (int j = 0; j < 420; j++)
                {
                    int r = ((255 * (i - 700)) / -700) + ((240 * (i)) / 700);
                    int g = ((165 * (i - 700)) / -700) + ((230 * (i)) / 700);
                    int b = (140 * (i)) / 700;
                    bmp.SetPixel(i, j, Color.FromArgb(r,g,b));
                }
            }
            PbxPantalla.Image = bmp;
        }

        private void BnEjes3D_Click(object sender, EventArgs e)
        {
            Color c = Color.Blue;
            Segmento3D s = new Segmento3D(0, 0, 0, 0, 0, 5, PbxPantalla);
            PbxPantalla.Image = s.Encender(c);
            s = new Segmento3D(0, 0, 0, 5, 0, 0, PbxPantalla);
            PbxPantalla.Image = s.Encender(c);
            s = new Segmento3D(0, 8, 0, 0, 0, 0, PbxPantalla);
            PbxPantalla.Image = s.Encender(c);

            //ejes 8
            s = new Segmento3D(0, 8, 0, 0, 5, 5, PbxPantalla);
            PbxPantalla.Image = s.Encender(c);
            //eje 9
            s = new Segmento3D(8, 8, 0, 0, 0, 5, PbxPantalla);
            PbxPantalla.Image = s.Encender(c);
            //eje 4
            s = new Segmento3D(8, 8, 0, 5, 0, 0, PbxPantalla);
            PbxPantalla.Image = s.Encender(c);
            //eje 5
            s = new Segmento3D(0, 8, 5, 5, 0, 0, PbxPantalla);
            PbxPantalla.Image = s.Encender(c);
            //eje 7
            s = new Segmento3D(0, 0, 0, 5, 5, 5, PbxPantalla);
            PbxPantalla.Image = s.Encender(c);
            //eje 6
            s = new Segmento3D(0, 0, 5, 5, 0, 5, PbxPantalla);
            PbxPantalla.Image = s.Encender(c);
        }

        private void BtnSuperficie3D_Click(object sender, EventArgs e)
        {
            Vector3D v = new Vector3D(PbxPantalla);
            double t = -5;
            double h;
            do
            {
                h = -4;
                do
                {
                    //tiene dos de radio
                    double Xo = t;
                    double Yo = h;
                    double Zo = (0.17 * (Math.Pow(t, 2) + Math.Pow(h, 2))) - 3;
                    v.Encender(Xo, Yo, Zo, Color.Red);
                    h = h + 0.1;
                } while (h <= 4);
                t = t + 0.1;
            } while (t <= 5);
            PbxPantalla.Image = v.bmp;
        }

        private void BtnResorte_Click(object sender, EventArgs e)
        {
            Vector3D v = new Vector3D(PbxPantalla);
            double Xo, Yo, Zo;
            double h = 0;
            do
            {
                //tiene dos de radio 
                //la primera coordena en X es la pos 
                //la primera coordena en Y es la pos
                Xo = 1 + 2 * Math.Cos(h);
                Yo = 2 + 2 * Math.Sin(h);
                Zo = -4 + (h / 3); //separación entre cada vuelta (helongacion)

                v.Encender(Xo, Yo, Zo, Color.Red);

                h = h + 0.02;
            } while (h <=30); //numero de vueltas
            PbxPantalla.Image = v.Grafico();
        }

        private void BtnTiroParabolico_Click(object sender, EventArgs e)
        {
            Circunferencia c; 
            Vector v = new Vector(PbxPantalla);
            double t = -8;
            do
            {
                int xo = v.PantallaSx(t);
                int yo = v.PantallaSy(((-Math.Pow(t, 2) - (12* t) - 32 )));
                v.Encender(xo, yo, Color.Blue);
                t = t + 0.001;
            } while (t <= -4);
            PbxPantalla.Image = v.bmp;

            t = -4;
            do
            {
                int xo = v.PantallaSx(t);
                int yo = v.PantallaSy(((-Math.Pow(t, 2) - (3 * t) + 4)/1.06));
                v.Encender(xo, yo, Color.Blue);
                t = t + 0.001;
            } while (t <= 1);
            PbxPantalla.Image = v.bmp;


            //t = -8;
            //double radio = 0.5;
            //do
            //{
            //    double xo = (t);
            //    double yo = ((-Math.Pow(t, 2) - (12 * t) - 32));
            //    c = new Circunferencia(xo, yo, radio, PbxPantalla);
            //    PbxPantalla.Image = c.Encender(Color.Green);
            //    PbxPantalla.Refresh();
            //    Thread.Sleep(5);
            //    PbxPantalla.Image = c.Apagar(PbxPantalla);
            //    t = t + 0.1;
            //    c = null;
            //} while (t <= -4);
        }

        private void BtnEjes2D_Click(object sender, EventArgs e)
        {
            Segmento s = new Segmento(-10, 10, 0, 0, PbxPantalla);
            PbxPantalla.Image = s.Encender(Color.Red);
            s = new Segmento(0, 0, 5.98, -5.98, PbxPantalla);
            PbxPantalla.Image = s.Encender(Color.Red);
        }

        private void PbxPantalla_Click(object sender, EventArgs e)
        {

        }
    }
}
