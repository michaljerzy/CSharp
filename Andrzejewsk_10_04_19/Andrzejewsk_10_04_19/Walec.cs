using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace Andrzejewsk_10_04_19
{
    class Walec : bryłaAbstrakcyjna
    {
        public int StopieńWielokątaPodstawy;
        float Oś_duża, Oś_mała;
        float KątMiędzyWierzchłkami, KątPołożenia;
        Graphics Rysownica;

        Point[] WielokątPodłogi;
        Point[] WielokątSufitu;
        public Walec(int R, int Wysokość, int StopieńWielokąta, int XsS, int YsS, int XsP, int YsP,Color KolorLinii,
            DashStyle StylLinii, int GrubośćLinii) : base (R, KolorLinii,StylLinii, GrubośćLinii)
        {
            this.RodzajBryły = Typbryły.BG_Walec;
            this.WysokośćBryły = Wysokość;
            this.StopieńWielokątaPodstawy = StopieńWielokąta;
            this.Oś_duża = this.Promień * 2;
            this.Oś_mała = this.Promień / 2;
            this.XsS = XsS;
            this.YsS = YsS;
            this.XsP = XsP;
            this.YsP = YsP;
            //wyznaczenie współrzędnych wielokąta podłogi i sufitu 
            this.KątMiędzyWierzchłkami = 360 / StopieńWielokąta;
            this.KątPołożenia = 0F;
            //utworzenie egzemplarzy dla tablic wierzchołków wielokąta
            this.WielokątPodłogi = new Point[StopieńWielokąta];
            this.WielokątSufitu = new Point[StopieńWielokąta];

            //utworzenie egzemplarzy punktów wierzchłków wielokąta poprzez wyznacznie współrzędnych wierzłki wielokąta
            for (int i = 0; i <= StopieńWielokątaPodstawy; i++)
            {
                WielokątPodłogi[i] = new Point();
                WielokątSufitu[i] = new Point();
                WielokątPodłogi[i].X = (int)(this.XsP + Oś_duża / 2 * Math.Cos(Math.PI * (KątPołożenia + i * KątMiędzyWierzchłkami / 180F)));
                WielokątPodłogi[i].Y = (int)(this.XsP + Oś_mała / 2 * Math.Sin(Math.PI * (KątPołożenia + i * KątMiędzyWierzchłkami / 180F)));

                WielokątSufitu[i].X = WielokątSufitu[i].X;
                WielokątSufitu[i].Y = WielokątPodłogi[i].Y - WysokośćBryły;
            }

            //oblicenie objętości i pola powierzchni walca
            ObjętośćBryły = (float)(Math.PI * Math.Pow(Promień, 2) * WysokośćBryły);
            PowierzchniaBryły = (float)(2 * Math.PI * Promień * (Promień + WysokośćBryły));
        }
        public override void Wykreśl()
        {
            //utworzenie Pióra
            Pen Pióro = new Pen(this.Kolor_linii, this.Grubość_linii);
            Pióro.DashStyle = this.Styl_linii;
            //wykreślenie podłogi i sufitu
            Rysownica.DrawEllipse(Pióro, this.XsP - this.Oś_duża / 2,
                                         this.YsP - this.Oś_mała / 2,
                                         this.Oś_duża, this.Oś_mała);

            Rysownica.DrawEllipse(Pióro, this.XsS - this.Oś_duża / 2,
                                         this.YsS - this.Oś_mała / 2,
                                         this.Oś_duża, this.Oś_mała);
            Rysownica.DrawLine(Pióro, this.XsP - this.Oś_duża / 2,
                this.YsP, this.XsS - this.Oś_duża / 2, this.YsS);
            Rysownica.DrawLine(Pióro, this.XsP + this.Oś_duża / 2,
                this.YsP, this.XsS + this.Oś_duża / 2, this.YsS);
            //Wykreślenie "prążków" na ścianie bocznej walca
            for (int i = 0; i <= StopieńWielokątaPodstawy; i++)
            {
                Rysownica.DrawLine(Pióro, WielokątPodłogi[i], WielokątSufitu[i]);
            }
            //zwolnienie pióra
            Pióro.Dispose();

        }

        public override void Wymaż()
        {
            /*pusta imprelentacja metody*/
        }
        public override void Obróć_i_Wykreśl(float rotateAngle)
        {
            /*pusta imprelentacja metody*/
        }
        public override void PrzesuńDoNowegoXY(int x, int y)
        {
            /*pusta imprelentacja metody*/
        }
    }
}
