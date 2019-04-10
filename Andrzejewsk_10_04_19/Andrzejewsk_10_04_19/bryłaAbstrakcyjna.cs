using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Andrzejewsk_10_04_19
{
    abstract class bryłaAbstrakcyjna
    {
        public enum Typbryły
        {
            BG_Walec, BG_WalecPochyły, BG_Stożek, BG_StożekPochyły, BG_Graniastosłup, BG_GraniastosłupPochyły
        };

        public Typbryły RodzajBryły;
        protected int XsS, YsS; //środek sufitu
        protected int XsP, YsP; //środek podłogi
        protected int KątPochylania;
        protected int WysokośćBryły;
        protected int Promień;
        protected int Grubość_linii;
        protected Color Kolor_linii;
        protected DashStyle Styl_linii;
        protected bool KierunekObrotu; //false: prawo, true: lewo
        protected float PowierzchniaBryły;
        protected float ObjętośćBryły;
        //deklaracja konstruktora klasy Bryła Abstrakcyjna
        public bryłaAbstrakcyjna(Color KolorLinii, DashStyle StylLinii, int GrubośćLinii)
        {
            this.Kolor_linii = KolorLinii;
            this.Styl_linii = StylLinii;
            this.Grubość_linii = GrubośćLinii;
        }
        public bryłaAbstrakcyjna(int Promień, Color KolorLinii, DashStyle StylLinii, int GrubośćLinii)
        {
            this.Promień = Promień;
            this.Kolor_linii = KolorLinii;
            this.Styl_linii = StylLinii;
            this.Grubość_linii = GrubośćLinii;
        }
        //deklaracja metod abstrakcyjnych

        public abstract void Wykreśl();

        public abstract void Wymaż();

        public abstract void Obróć_i_Wykreśl(float rotateAngle);

        public abstract void PrzesuńDoNowegoXY(int x, int y);

        //deklaracja metod publicznych
        public void UstawAtrybutyGraficzne(Color KoloLinii, DashStyle StylLinii, int GrubośćLinii)
        {
            this.Kolor_linii = KoloLinii;
            this.Styl_linii = StylLinii;
            this.Grubość_linii = GrubośćLinii;
        }

        public void UstawAtrybutyGraficzne(Color KolorLinii)
        {
            this.Kolor_linii = KolorLinii;
        }
        public void UstawAtrybutyGraficzne(DashStyle StylLinii)
        {
            this.Styl_linii = StylLinii;
        }
        public void UstawAtrybutyGraficzne(int GrubośćLinii)
        {
            this.Grubość_linii = GrubośćLinii;
        }
        public void KierunekWLewo()
        {
            this.KierunekObrotu = true;
        }
        public void KierunekWPrawo()
        {
            this.KierunekObrotu = false;
        }
    }
}
