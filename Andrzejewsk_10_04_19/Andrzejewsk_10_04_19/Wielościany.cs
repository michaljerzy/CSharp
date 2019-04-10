using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Andrzejewsk_10_04_19
{
    class Wielościany : bryłaAbstrakcyjna
    {

        protected int StopieńWielokątaPodstawy;

        public Wielościany(int R, int StopieńWielokątaPodstawy, Color KolorLinii, DashStyle StylLinii, int GrubośćLinii):
            base(KolorLinii, StylLinii, GrubośćLinii)
        {
            this.Promień = R;
            this.StopieńWielokątaPodstawy = StopieńWielokątaPodstawy;
        }
        public override void Wykreśl()
        { /*pusta imprelentacja metody*/}

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
