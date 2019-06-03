using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using static Andrzejewski_48660_Projekt3_2Semestr.Andrzejewski;

namespace Andrzejewski_48660_Projekt3_2Semestr
{
    abstract class maBryłaAbstrakcyjna : IComparable<maBryłaAbstrakcyjna>
    {
        public enum maTypBryły
        {
            maWalec, maOstrosłup, maGraniastosłup, maKula, maStożek, maSześcian, maOstrosłupPochylony,
            maGraniastosłupPochylony, maStożekPochylony, maBrylant
        }

        public maTypBryły maRodzajBryły;

        protected int maXŚrodkaPodłogi, maYŚrodkaPodłogi;
        protected int maYŚrodkaSufitu, maXŚrodkaSufitu;
        protected int maKątPochylenia;
        protected int maWysokośćBryły;
        protected int maPromień;
        protected int maGrubośćLinii;
        protected bool maKierunekObrotu;
        protected Color maKolorLinii;
        protected DashStyle maStylLinii;
        protected float maPowierzchniaBryły;
        protected float maObjętośćBryły;


        public int maGetKątPochylenia { get { return maKątPochylenia; } set { } }
        public int maGetWysokośćBryły { get { return maWysokośćBryły; } set { } }
        public int maGetPromień { get { return maPromień; } set { } }
        public int maGetGrubośćLinii { get { return maGrubośćLinii; } set { } }
        public DashStyle maGetStylLinii { get { return maStylLinii; } set { } }

        public maBryłaAbstrakcyjna(int maPromień, Color maKolorLinii, DashStyle maStylLinii, int maGrubośćLinii)
        {
            this.maKolorLinii = maKolorLinii;
            this.maPromień = maPromień;
            this.maStylLinii = maStylLinii;
            this.maGrubośćLinii = maGrubośćLinii;
        }

        public abstract void maWykreśl();
        public abstract void maWymaż();
        public abstract void maObróćIWykreśl(int maKątObrotu);
        public abstract void maPrzesuńDoNowegoXY(int maX, int maY);
        public abstract void maZmieńWysokośćBryły(int maWys);
        public abstract void maZmieńPromieńBryły(int maPro);
        public abstract void maZmieńKolorLinii(Color maCol);
        public abstract void maZmieńGrubośćLinii(int maGrubosc);
        public abstract void maZmieńStylLinii(DashStyle maDashStyle);
        public abstract void maZmieńKątNachylenia(int maKąt);
        public abstract void maWrócDoStarychWspółrzędnych();

        public void maWLewo()
        {
            maKierunekObrotu = true;
        }
        public void maWPrawo()
        {
            maKierunekObrotu = false;
        }

        public int CompareTo(maBryłaAbstrakcyjna maBryła)
        {
            if (maUchwytFormularza.maRBTNPolePowierzchni.Checked)
            {
                if (maPowierzchniaBryły < maBryła.maPowierzchniaBryły)
                {
                    return 1;
                }
                else if (maPowierzchniaBryły > maBryła.maPowierzchniaBryły)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
            else if (maUchwytFormularza.maRBTNObjętośćBryły.Checked)
            {
                if (maObjętośćBryły < maBryła.maObjętośćBryły)
                {
                    return 1;
                }
                else if (maObjętośćBryły > maBryła.maObjętośćBryły)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
            else if (maUchwytFormularza.maRBTNPromieńBryły.Checked)
            {
                if (maPromień < maBryła.maPromień)
                {
                    return 1;

                }
                else if (maPromień > maBryła.maPromień)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
            else if (maUchwytFormularza.maRBTNWysokość.Checked)
            {
                if (maWysokośćBryły < maBryła.maWysokośćBryły)
                {
                    return 1;
                }
                if (maWysokośćBryły > maBryła.maWysokośćBryły)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }


        }
    }
}
