using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using static Andrzejewsk_10_04_19.Form1;

namespace Andrzejewsk_10_04_19
{
    class Ostrosłup : Wielościany
    {
        float Oś_duża, Oś_mała;
        //int KątNachylenia, Xf, Xc
        float KątMiędzyWierzchołkami, KątPołożenia;
        Point[] WielokątPodłogi;

        public Ostrosłup(int R, int WysokośćOstrosłupa, int StopieńWielokątaPodstawy, int XsS, int YsS, int XsP, int YsP,
            Color KolorLinii, DashStyle StylLinii, int GrubośćLinii) : base(R, StopieńWielokątaPodstawy, KolorLinii, StylLinii, GrubośćLinii)
        {
            this.RodzajBryły = TypBryły.BG_Ostrosłup;
            this.WysokośćBryły = WysokośćOstrosłupa;
            this.StopieńWielokątaPodstawy = StopieńWielokątaPodstawy;

            this.Oś_duża = this.Promień * 2;
            this.Oś_mała = this.Promień / 2;
            this.KątPochylylenia = 90;
            this.XsS = XsS;
            this.YsS = YsS;
            this.XsP = XsP;
            this.YsP = YsP;

            //wyznaczenie współrzędnych wielokąta podłogi
            this.KątMiędzyWierzchołkami = 360 / StopieńWielokątaPodstawy;
            this.KątPołożenia = 0f;
            //utworzenie egzemplarzy dla tablic wierzchołków wielokąta podłogi
            this.WielokątPodłogi = new Point[StopieńWielokątaPodstawy + 1];
            //utworzenie egzemlarzy punktów wierzchołków wielokąta podłogi
            //wyznaczenie współrzędnych wierzchołków wielokąta podłogi
            for (int i = 0; i <= StopieńWielokątaPodstawy; i++)
            {
                WielokątPodłogi[i] = new Point();
                WielokątPodłogi[i].X = (int)(this.XsP + Oś_duża / 2 * Math.Cos(Math.PI * (KątPołożenia + i * KątMiędzyWierzchołkami) / 180f));
                WielokątPodłogi[i].Y = (int)(this.YsP + Oś_mała / 2 * Math.Sin(Math.PI * (KątPołożenia + i * KątMiędzyWierzchołkami) / 180f));
            }
            //obliczenie objętości i pola powierzchni Ostrosłupa
            float PowierzchniaWielokąta = (float)(StopieńWielokątaPodstawy * R * R / 2 * Math.Sin(2 * Math.PI / StopieńWielokątaPodstawy));
            float avPolygonSide = (float)(2 * R * Math.Sin(Math.PI / StopieńWielokątaPodstawy));
            float avOstrosłupSide = (float)(Math.Sqrt(Math.Pow(WysokośćOstrosłupa, 2) + Math.Pow(R, 2)));
            this.ObjętośćBryły = (float)(PowierzchniaWielokąta * WysokośćOstrosłupa / 3);
            this.PowierzchniaBryły = (float)(avPolygonSide * (StopieńWielokątaPodstawy / 2) * Math.Sqrt(Math.Pow(avOstrosłupSide, 2) -
                Math.Pow(avPolygonSide / 2, 2)));
        }
            public override void Wykreśl()
        {
            //utworzenie pióra
            Pen Pióro = new Pen(this.Kolor_linii, this.Grubość_linii);
            Pióro.DashStyle = this.Styl_linii;
            //wykreślenie podłogi
            for(int i = 0; i < WielokątPodłogi.Length - 1; i++)
                Rysownica.DrawLine(Pióro, WielokątPodłogi[i], WielokątPodłogi[i + 1]);

            //wykreślenie krawędzi bocznych ostrosłupa
            for (int i = 0; i <= StopieńWielokątaPodstawy; i++)
                Rysownica.DrawLine(Pióro, WielokątPodłogi[i], new Point(XsS, YsS));
            //zwolninie pióra
            Pióro.Dispose();
        }
        public override void Wymaż()
        {
            //utworzenie pióra
            Pen Pióro = new Pen(UchwytFormularza.pbRysownica.BackColor, this.Grubość_linii);
            Pióro.DashStyle = this.Styl_linii;
            //wykreślenie podłogi
            for(int i = 0; i < WielokątPodłogi.Length - 1; i++)
                Rysownica.DrawLine(Pióro, WielokątPodłogi[i], WielokątPodłogi[i + 1]);
//wykreślenie krawędzi bocznych ostrosłupa
            for (int i = 0; i <= StopieńWielokątaPodstawy; i++)
                Rysownica.DrawLine(Pióro, WielokątPodłogi[i], new Point(XsS, YsS));
            //zwolninie pióra
            Pióro.Dispose();
        }
        public override void Obróć_i_wykreśl(float kątObrotu)
        {
            Wymaż();
            //wyznaczenie współrzędnych wierzchołków wielokąta podło obróconych o kątObrotu
            if (!this.KierunekObrotu)
                this.KątPołożenia += kątObrotu;
            else
                this.KątPołożenia -= kątObrotu;
            for (int i = 0; i <= StopieńWielokątaPodstawy; i++)
            {
                WielokątPodłogi[i].X = (int)(this.XsP + Oś_duża / 2 * Math.Cos(Math.PI * (KątPołożenia + i * KątMiędzyWierzchołkami) / 180f));
                WielokątPodłogi[i].Y = (int)(this.YsP + Oś_mała / 2 * Math.Sin(Math.PI * (KątPołożenia + i * KątMiędzyWierzchołkami) / 180f));
            }
            Wykreśl();
        }
        public override void PrzesuńDoNowegoXY(int x, int y)
        {
            Wymaż();
            this.XsP = x - (int)(this.WysokośćBryły / (Math.Tan(Math.PI * KątPochylylenia / 180f)));
            this.YsP = y;
            this.XsS = x + (int)(this.WysokośćBryły / (Math.Tan(Math.PI * KątPochylylenia / 180f)));
            this.YsS = y - WysokośćBryły;

            for(int i = 0; i <= StopieńWielokątaPodstawy; i++)
            {
                WielokątPodłogi[i].X = (int)(this.XsP + Oś_duża / 2 * Math.Cos(Math.PI * (KątPochylylenia + i * KątMiędzyWierzchołkami) / 180f));
                WielokątPodłogi[i].Y = (int)(thisYXsP + Oś_mała / 2 * Math.Sin(Math.PI * (KątPochylylenia + i * KątMiędzyWierzchołkami) / 180f));
            }
            Wykreśl();
        }
    }
    
}