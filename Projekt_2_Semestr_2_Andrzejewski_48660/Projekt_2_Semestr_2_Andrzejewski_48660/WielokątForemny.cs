using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing;
using static Projekt_2_Semestr_2_Andrzejewski_48660.Andrzejewski;
using static Projekt_2_Semestr_2_Andrzejewski_48660.Punkt;

namespace Projekt_2_Semestr_2_Andrzejewski_48660
{
    class WielokątForemny : Punkt
    {
        protected int PromieńOkręgu;
        protected int StopieńWielokąta;
        protected Point[] TablicaWierzchołkówWielokąta;
        float KątPołożeniaPierwszegoWierzchołka = 0.0F;
        public WielokątForemny(int StopieńWielokąta, int x, int y, int Promień) : base(x, y)
        {
            this.StopieńWielokąta = StopieńWielokąta;
            PromieńOkręgu = Promień;
            TablicaWierzchołkówWielokąta = new Point[StopieńWielokąta + 1];
            for (int i = 0; i < StopieńWielokąta; i++)
                TablicaWierzchołkówWielokąta[i] = new Point();
        }
        public WielokątForemny(int StopieńWielokąta, int x, int y, int Promień, Color Kolor, DashStyle StylLinii, int GrubośćLinii) : base(x, y, Kolor, StylLinii, GrubośćLinii)
        {
            this.StopieńWielokąta = StopieńWielokąta;
            PromieńOkręgu = Promień;
            TablicaWierzchołkówWielokąta = new Point[StopieńWielokąta + 1];
            for (int i = 0; i < StopieńWielokąta; i++)
                TablicaWierzchołkówWielokąta[i] = new Point();
        }
        public virtual void Wykreśl(Graphics Rysownica)
        {
            Pen Pióro = new Pen(Kolor, GrubośćLinii);
            Pióro.DashStyle = StylLinii;
            float KątMiędzyWierzchołkami = 360F / StopieńWielokąta;
            for (int i = 0; i <= StopieńWielokąta; i++)
            {
                TablicaWierzchołkówWielokąta[i].X = ((int)(X + PromieńOkręgu * Math.Cos(Math.PI * (KątPołożeniaPierwszegoWierzchołka + i * KątMiędzyWierzchołkami) / 180F)));
                TablicaWierzchołkówWielokąta[i].Y = ((int)(Y + PromieńOkręgu * Math.Cos(Math.PI * (KątPołożeniaPierwszegoWierzchołka + i * KątMiędzyWierzchołkami) / 180F)));

            }
            for (int i = 0; i < StopieńWielokąta; i++)
                Rysownica.DrawLine(Pióro, TablicaWierzchołkówWielokąta[i].X, TablicaWierzchołkówWielokąta[i].Y, TablicaWierzchołkówWielokąta[i + 1].X, TablicaWierzchołkówWielokąta[i + 1].Y);
            Widoczny = true;
            Pióro.Dispose();
            
        }
        //public virtual void Wymaż()
    }
}
