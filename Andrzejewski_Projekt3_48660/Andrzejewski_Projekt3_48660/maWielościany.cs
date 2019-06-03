using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Andrzejewski_Projekt3_48660
{
    class maWielościany : maBryłaAbstrakcyjna
    {
        protected int maStopieńWielokątaPodstawy;
        public maWielościany(int maPromień, Color maKolorLinii, DashStyle maStylLinii, int maGrubośćLinii) :
            base(maKolorLinii, maStylLinii, maGrubośćLinii)
        {
            maPromień = maPromień;
            this.maStopieńWielokątaPodstawy = maStopieńWielokątaPodstawy;
        }
        public override void maWykreśl() { /*pusta implementacja */ }
        public override void maWymaż() { /*pusta implementacja */ }
        public override void maObróćIWykreśl(float marotateAngle) { /*pusta implementacja */ }
        public override void maPrzesuńDoNowegoXY(int max, int may) { /*pusta implementacja */ }
        public override void maZmieńPromieńFigury(int maPromień) { /*pusta implementacja */ }
        public override void maZmieńWysokośćFigury(int maWysokość) { /*pusta implementacja */ }
        public override void maUstawStopieńWielokąta(int maStopień) { /*pusta implementacja */ }
        public override void maUstawKątNachyleniaStożka(int maX) { /*pusta implementacja */ }
        public override void maObliczeniePolaObjętościItp() { /*pusta implementacja */ }
    }
}
