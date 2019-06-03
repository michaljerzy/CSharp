using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using static Figury.Form1;

namespace Figury
{
    public abstract class FiguryAbstrakcyjne
    {
        const int PromieńPunktu = 5;
        int RozmiarPunktu;
        protected int X;
        protected int Y;
        protected Color Kolor;
        protected bool Widoczny;
        protected DashStyle StylLinii;
        protected int GrubośćLinii;

        public enum TypFigury
        {
            Kwadrat, Trójkąt, Prostokąt
        }
        public TypFigury RodzajFigury;

        public void Figura()
        {
            X = 0; Y = 0;
            RozmiarPunktu = 2 * PromieńPunktu;
            Kolor = Color.Black;
            StylLinii = DashStyle.Solid;
            GrubośćLinii = 1;
            Widoczny = false;
        }

        public void Figura(int x, int y)
        {
            X = x; Y = y;
            RozmiarPunktu = 2 * PromieńPunktu;
            Kolor = Color.Black;
            StylLinii = DashStyle.Solid;
            GrubośćLinii = 1;
            Widoczny = false;
        }

        public void Figura(int x, int y, Color kolor)
        {
            X = x; Y = y;
            RozmiarPunktu = 2 * PromieńPunktu;
            Kolor = kolor;
            StylLinii = DashStyle.Solid;
            GrubośćLinii = 1;
            Widoczny = false;
        }

        public void Figura(int X, int Y, Color Kolor, DashStyle StylLinii, int GrubośćLinii)
        {
            this.X = X; this.Y = Y;
            RozmiarPunktu = 2 * PromieńPunktu;
            this.Kolor = Kolor;
            this.StylLinii = DashStyle.Solid;
            this.GrubośćLinii = 1;
            Widoczny = false;
        }
        public void UstawXY(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public virtual void Wykreśl()
        {
            SolidBrush Pędzel = new SolidBrush(this.Kolor);
            
        }
        public void PrzesunDoNowegoXY(int x, int y)
        {
            
        }
    }
}
