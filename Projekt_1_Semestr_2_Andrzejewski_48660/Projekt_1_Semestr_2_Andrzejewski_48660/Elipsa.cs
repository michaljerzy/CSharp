using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing;
using static Projekt_1_Semestr_2_Andrzejewski_48660.Andrzejewski;
using static Projekt_1_Semestr_2_Andrzejewski_48660.Punkt;
using static Projekt_1_Semestr_2_Andrzejewski_48660.WielokątForemny;


namespace Projekt_1_Semestr_2_Andrzejewski_48660
{
    public class Elipsa : Punkt
    {
        protected int OśDuża, OśMała;
        public Elipsa(int x, int y, int OśDuża, int OśMała) : base(x, y)
        {

        }
        public Elipsa(int x, int y, int OśDuża, int OśMała, Color Kolor, DashStyle RodzajLinii, int GruboścLinii) : base(x,y,Kolor,RodzajLinii,GruboścLinii)
        {

        }


        public override void Wykreśl()
        {
            Pen Pióro = new Pen(Kolor, GrubośćLinii);
            Pióro.DashStyle = DashStyle.Solid;
            
            
        }
    }
}
