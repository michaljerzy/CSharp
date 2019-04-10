using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;

namespace Projekt_2_Andrzejewski_48660
{
    public class Figury
    {
        public class Linia
        {
            const int PromienPunku = 5;
            int RozmiarPunktu;
            protected int X;
            protected int Y;
            protected bool Widoczny;
            protected DashStyle StylLinii;
            protected int GruboscLinii;
            

            public Punkt()
            {
                X = 0; Y = 0;
                RozmiarPunktu = 2 * PromienPunku;
                StylLinii = DashStyle.Solid;
                GruboscLinii = 1;
                Widoczny = false;
            }
            public Punkt(int x, int y)
            {
                X = x; Y = y;
                RozmiarPunktu = 2 * PromienPunku;
                StylLinii = DashStyle.Solid;
                GruboscLinii = 1;
                Widoczny = false;

            }
            public Punkt(int x, int y)
            {
                X = x; Y = y;
                RozmiarPunktu = 2 * PromienPunku;
                StylLinii = DashStyle.Solid;
                GruboscLinii = 1;
                Widoczny = false;
            }
            public Punkt(int X, int Y, DashStyle StylLinii, int GrubiscLinii)
            {
                this.X = X; this.Y = Y;
                RozmiarPunktu = 2 * PromienPunku;
                this.StylLinii = StylLinii;
                this.GruboscLinii = GruboscLinii;
                Widoczny = false;
            }
            private void UstawXY(int X, int Y)
            {
                this.X = X;
                this.Y = Y;
            }
            private void Ustaw(Punkt NowaLokalizacja)
            {
                X = NowaLokalizacja.X;
                Y = NowaLokalizacja.Y;
            }
        }

    }
}
