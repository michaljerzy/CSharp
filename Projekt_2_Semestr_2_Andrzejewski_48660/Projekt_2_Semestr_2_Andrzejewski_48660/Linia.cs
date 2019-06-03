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
    class Linia : Punkt
    {
        protected int PromieńOkręgu;

        public Linia(int x, int y, int Promień) : base(x, y)
        {
            PromieńOkręgu = Promień;

        }
        public Linia(int x, int y, int Promień, Color Kolor, DashStyle StylLinii, int GrubośćLinii) : base(x, y, Kolor,StylLinii,GrubośćLinii)
        {

        }
        public virtual void Wykreśl(Graphics Rysownica)
        {
            Pen Pióro = new Pen(Kolor, GrubośćLinii);
            Pióro.DashStyle = StylLinii;


            Widoczny = true;
            
        }


    }
}
