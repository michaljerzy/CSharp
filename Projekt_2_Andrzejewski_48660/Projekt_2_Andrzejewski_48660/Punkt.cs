using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static Projekt_2_Andrzejewski_48660.Form1;

namespace Projekt_2_Andrzejewski_48660
{
    abstract class Punkt
    {
        Graphics Rysownica;
        const int PromieńPunkt = 5;
        int RozmiarPunktu;
        protected int X;
        protected int Y;
        protected Color Kolor;
        protected bool Widoczny;
        protected DashStyle StylLinii;
        protected int GruboścLinii;

        public enum TypFigury
        {
            Kwadrat, Prostokąt, Trójkąt
        }

        public TypFigury RodzajFigury;

        public Punkt()
        {
            X = 0; Y = 0;
            RozmiarPunktu = 2 * PromieńPunkt;
            Kolor = Color.Black;
            StylLinii = DashStyle.Solid;
            GruboścLinii = 1;
            Widoczny = false;
        }
        public Punkt(int x, int y)
        {
            X = x; Y = y;
            RozmiarPunktu = 2 * PromieńPunkt;
            Kolor = Color.Black;
            StylLinii = DashStyle.Solid;
            Widoczny = false;
        }
        public Punkt(int x, int y, Color Kolor)
        {
            X = x; Y = y;
            RozmiarPunktu = 2 * PromieńPunkt;
            this.Kolor = Kolor;
            StylLinii = DashStyle.Solid;
            GruboścLinii = 1;
            Widoczny = false;
            
        }
        public Punkt(int X, int Y, Color Kolor, DashStyle StylLinii, int GrubośćLinii)
        {
            this.X = X; this.Y = Y;
            RozmiarPunktu = 2 * PromieńPunkt;
            this.Kolor = Kolor;
            this.StylLinii = StylLinii;
            this.GruboścLinii = GrubośćLinii;
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
            Rysownica.FillEllipse(Pędzel, X - RozmiarPunktu / 2, Y - RozmiarPunktu / 2, RozmiarPunktu, RozmiarPunktu);
            Pędzel.Dispose();
            
        }

        public virtual void Wymaż()
        {
            //SolidBrush Pędzel = new SolidBrush();
            Rysownica.FillEllipse(Pędzel, X - RozmiarPunktu / 2, Y - RozmiarPunktu / 2, RozmiarPunktu, RozmiarPunktu);

            Pędzel.Dispose();
        }


        public void PrzesunDoNowegoXY(int x, int y)
        {
            Wymaż();
            UstawXY(x, y);
            Wykreśl();
            
        }
    }
}
