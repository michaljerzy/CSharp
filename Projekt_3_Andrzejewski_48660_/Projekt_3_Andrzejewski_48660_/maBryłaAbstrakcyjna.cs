using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using static Projekt_3_Andrzejewski_48660_.Program;

namespace Projekt_3_Andrzejewski_48660_
{
    abstract class maBryłaAbstrakcyjna
    {
        public enum maTypBryły
        {
            ma_Walec, ma_WalecPochyły, ma_Stożek, ma_StożekPochyły,
            ma_Kula, ma_Ostrosłup, ma_OstrosłupPochyły, ma_Graniastosłup, ma_GraniastosłupPochyły
        };

        public maTypBryły maRodzajBryły;
        protected int maXŚrodekSufitu, maYŚrodekSufitu;
        protected int maXŚrodekPodłogi, maYŚrodekPodłogi;
        protected int maKątPochylenia, maXf, maXc;
        protected int maWysokość;
        protected int maPromień;
        protected int maGrubość_linii;
        protected Color maKolor_linii;
        protected DashStyle maStyl_linii;
        protected bool maKierunekObratu;
        protected float maPowierzchniaBryły;
        protected float maObjętośćBryły;
        public maBryłaAbstrakcyjna(int maPromień, Color maKolorLinii, DashStyle maStylLinii, int maGrubośćLinii)
        {
            this.maPromień = maPromień;
            this.maKolor_linii = maKolorLinii;
            this.maStyl_linii = maStylLinii;
            this.maGrubość_linii = maGrubośćLinii;
        }
        public maBryłaAbstrakcyjna(Color maKolorLinii, DashStyle maStylLinii, int maGrubośćLinii)
        {
            this.maKolor_linii = maKolorLinii;
            this.maStyl_linii = maStylLinii;
            this.maGrubość_linii = maGrubośćLinii;
        }
        public void maKierunekWLewo()
        {
            this.maKierunekObratu = true;
        }
        public void maKierunekWPrawi()
        {
            this.maKierunekObratu = false;
        }
        public abstract void maWykreśl();
        public abstract void maWymaż();
        public abstract void maObróćIWykreśl(float maKątObrotu);
        public abstract void maPrzesuńDoNowegoXY(int maX, int maY);
        public abstract void maZmieńWysokośćFigury(int maWysokośćBryły);
        public abstract void maZmieńPromieńFigury(int maPromieńFigury);
        public abstract void maUstawStopieńWielokąta(int maStopień);
        public abstract void maUstawKątNachyleniaStożka(int maX);
        public abstract void maObliczeniePolaObjętościItp();
        public void maUstawAtrybutyGraficzne(Color maKolorLinii, DashStyle maStylLinii, int maGrubośćLinii)
        {
            this.maKolor_linii = maKolorLinii;
            this.maStyl_linii = maStylLinii;
            this.maGrubość_linii = maGrubośćLinii;
        }
        public void maUstawAtrybutyGraficzne(Color maKolorLinii)
        {
            this.maKolor_linii = maKolorLinii;
        }
        public void maUstawAtrybutyGraficzne(DashStyle maStylLinii)
        {
            this.maStyl_linii = maStylLinii;
        }
        public void maUstawAtrybutyGraficzne(int maGrubośćLinii)
        {
            this.maGrubość_linii = maGrubośćLinii;
        }
        public void maUstawKątNachylenia(int maKątNachylenia)
        {
            this.maKątPochylenia = maKątNachylenia;
        }
    }
}
