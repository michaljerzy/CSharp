using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing;
using static Projekt_1_Semestr_2_Andrzejewski_48660.Andrzejewski;
using static Projekt_1_Semestr_2_Andrzejewski_48660.Elipsa;
using static Projekt_1_Semestr_2_Andrzejewski_48660.Punkt;

namespace Projekt_1_Semestr_2_Andrzejewski_48660
{
    public class Punkt
    {
        const int PromieńPunktu = 5;
        int RozmiarPunktu;
        protected int X;
        protected int Y;
        protected Color Kolor;
        protected bool Widoczny;
        protected DashStyle StylLinii;
        protected int GrubośćLinii;

        public Punkt()
        {
            X = 0;Y = 0;
            RozmiarPunktu = 2 * PromieńPunktu;
            Kolor = Color.Black;
            StylLinii = DashStyle.Solid;
            GrubośćLinii = 1;
            Widoczny = false;
        }
        public Punkt(int x, int y)
        {
            X = x; Y = y;
            RozmiarPunktu = 2 * PromieńPunktu;
            Kolor = Color.Black;
            StylLinii = DashStyle.Solid;
            GrubośćLinii = 1;
            Widoczny = false;
        }
        public Punkt(int x, int y, Color kolor)
        {
            X = x; Y = y;
            RozmiarPunktu = 2 * PromieńPunktu;
            Kolor = kolor;
            StylLinii = DashStyle.Solid;
            GrubośćLinii = 1;
            Widoczny = false;
        }
        public Punkt(int X, int Y, Color Kolor, DashStyle StylLinii, int GrubośćLinii)
        {
            this.X = X; this.Y = Y;
            RozmiarPunktu = 2 * PromieńPunktu;
            this.Kolor = Kolor;
            this.StylLinii = StylLinii;
            this.GrubośćLinii = GrubośćLinii;
            Widoczny = false;
        }
        public virtual void Wykreśli(Graphics Rysownica)
        {
            SolidBrush Pędzel = new SolidBrush(this.Kolor);
            Rysownica.FillEllipse(Pędzel, X - RozmiarPunktu / 2, Y - RozmiarPunktu / 2, RozmiarPunktu, RozmiarPunktu);
            Pędzel.Dispose();
        }
    }
}
