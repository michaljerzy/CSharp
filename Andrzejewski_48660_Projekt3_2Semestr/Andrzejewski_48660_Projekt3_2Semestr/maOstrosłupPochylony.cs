using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static Andrzejewski_48660_Projekt3_2Semestr.Andrzejewski;

namespace Andrzejewski_48660_Projekt3_2Semestr
{
    class maOstrosłupPochylony : maBryłaAbstrakcyjna
    {
        public int maStopieńWielokątaPodstawy;
        float maOśDuża, maOśMała;
        float maKątMiędzyWierzchołkami, maKątPołożenia;
        Point[] maWielokątPodłogi;
        Point maSufit;
        Point maPoprzedniPunktLokacji;

        public maOstrosłupPochylony(int maPromien, Color maKolorLinii, DashStyle maStylLinii, int maGruboscLinii, int maWysokosc, int maStopienWielokataPodstawy, Point maSrodekPodlogi, int maKątPochylenia) : base(maPromien, maKolorLinii, maStylLinii, maGruboscLinii)
        {
            maRodzajBryły = maTypBryły.maOstrosłupPochylony;
            maWysokośćBryły = maWysokosc;
            maPoprzedniPunktLokacji = maSrodekPodlogi;
            maStopieńWielokątaPodstawy = maStopienWielokataPodstawy;
            maOśDuża = maPromien * 2;
            this.maKątPochylenia = maKątPochylenia;
            maOśMała = maPromien / 2;
            maXŚrodkaPodłogi = maSrodekPodlogi.X;
            maYŚrodkaPodłogi = maSrodekPodlogi.Y;
            maSufit.X = maXŚrodkaPodłogi - (90 - maKątPochylenia);
            maSufit.Y = maYŚrodkaPodłogi - maWysokośćBryły;
            maGrubośćLinii = maGruboscLinii;
            this.maStylLinii = maStylLinii;
            this.maKolorLinii = maKolorLinii;
            maWielokątPodłogi = new Point[maStopienWielokataPodstawy + 1];

            maKątMiędzyWierzchołkami = 360 / maStopienWielokataPodstawy;
            maKątPołożenia = 0f;

            for (int i = 0; i <= maStopieńWielokątaPodstawy; i++)
            {
                maWielokątPodłogi[i] = new Point();

                maWielokątPodłogi[i].X = (int)(maXŚrodkaPodłogi + (maOśDuża / 2) * Math.Cos(Math.PI * (maKątPołożenia + i * maKątMiędzyWierzchołkami) / 180f));
                maWielokątPodłogi[i].Y = (int)(maYŚrodkaPodłogi + (maOśMała / 2) * Math.Sin(Math.PI * (maKątPołożenia + i * maKątMiędzyWierzchołkami) / 180f));

            }
            maObjętoścIPolePowierzchni();
        }

        public override void maWykreśl()
        {
            Pen maPen = new Pen(maKolorLinii, maGrubośćLinii);
            maPen.DashStyle = maStylLinii;

            for (int i = 0; i < maWielokątPodłogi.Length - 1; i++)
            {
                maRysownica.DrawLine(maPen, maWielokątPodłogi[i], maWielokątPodłogi[i + 1]);
                maRysownica.DrawLine(maPen, maSufit, maWielokątPodłogi[i]);

            }

            maPen.Dispose();
        }

        public override void maWymaż()
        {
            Pen maPen = new Pen(Color.White, maGrubośćLinii);
            maPen.DashStyle = maStylLinii;

            for (int i = 0; i < maWielokątPodłogi.Length - 1; i++)
            {
                maRysownica.DrawLine(maPen, maWielokątPodłogi[i], maWielokątPodłogi[i + 1]);
                maRysownica.DrawLine(maPen, maSufit, maWielokątPodłogi[i]);

            }

            maPen.Dispose();
        }

        public override void maObróćIWykreśl(int maKątObrotu)
        {
            maWymaż();

            if (!maKierunekObrotu)
            {
                maKątPołożenia = maKątObrotu;
            }
            else
            {
                maKątPołożenia = -maKątObrotu;
            }
            for (int i = 0; i < maWielokątPodłogi.Length; i++)
            {

                maWielokątPodłogi[i].X = (int)(maXŚrodkaPodłogi + (maOśDuża / 2) * Math.Cos(Math.PI * (maKątPołożenia + i * maKątMiędzyWierzchołkami) / 180f));
                maWielokątPodłogi[i].Y = (int)(maYŚrodkaPodłogi + (maOśMała / 2) * Math.Sin(Math.PI * (maKątPołożenia + i * maKątMiędzyWierzchołkami) / 180f));

            }

            maWykreśl();

        }

        public override void maPrzesuńDoNowegoXY(int maX, int maY)
        {
            maWymaż();
            maXŚrodkaPodłogi = maX;
            maYŚrodkaPodłogi = maY;
            maSufit.X = maXŚrodkaPodłogi - (90 - maKątPochylenia);
            maSufit.Y = maYŚrodkaPodłogi - maWysokośćBryły;

            for (int i = 0; i <= maStopieńWielokątaPodstawy; i++)
            {
                maWielokątPodłogi[i] = new Point();

                maWielokątPodłogi[i].X = (int)(maXŚrodkaPodłogi + (maOśDuża / 2) * Math.Cos(Math.PI * (maKątPołożenia + i * maKątMiędzyWierzchołkami) / 180f));
                maWielokątPodłogi[i].Y = (int)(maYŚrodkaPodłogi + (maOśMała / 2) * Math.Sin(Math.PI * (maKątPołożenia + i * maKątMiędzyWierzchołkami) / 180f));

            }

            maWykreśl();
        }

        public override void maZmieńWysokośćBryły(int maWys)
        {
            maWymaż();
            maSufit.Y = maYŚrodkaPodłogi - maWys;
            maWysokośćBryły = maWys;
            maObjętoścIPolePowierzchni();
        }

        public override void maZmieńPromieńBryły(int maPro)
        {
            maWymaż();
            maOśDuża = maPro * 2;
            maOśMała = maPro / 2;
            maPromień = maPro;
            maObjętoścIPolePowierzchni();
        }

        public override void maZmieńGrubośćLinii(int maGrubosc)
        {
            maGrubośćLinii = maGrubosc;
        }

        public override void maZmieńKolorLinii(Color maCol)
        {
            maKolorLinii = maCol;
        }

        public override void maZmieńKątNachylenia(int maKąt)
        {
            maKątPochylenia = maKąt;
            maSufit.X = maXŚrodkaPodłogi - (90 - maKątPochylenia);
        }

        public override void maZmieńStylLinii(DashStyle maDashStyle)
        {
            maStylLinii = maDashStyle;
        }

        void maObjętoścIPolePowierzchni()
        {
            switch (maStopieńWielokątaPodstawy)
            {
                case 3:
                    maObjętośćBryły = (1 / 3) * (float)((3 * maPromień * maPromień * Math.Sqrt(3)) / 4) * maWysokośćBryły;
                    maPowierzchniaBryły = (float)((3 * maPromień * maPromień * Math.Sqrt(3)) / 4 + 2 * (3 * maPromień) / Math.Sqrt(3) * maWysokośćBryły);
                    break;
                case 4:
                    maObjętośćBryły = (1 / 3) * (float)Math.Pow((maOśDuża / Math.Sqrt(2)), 2) * maWysokośćBryły;
                    maPowierzchniaBryły = (float)(Math.Pow((maOśDuża / Math.Sqrt(2)), 2) + 2 * (maOśDuża / Math.Sqrt(2) * Math.Sqrt(maWysokośćBryły * maWysokośćBryły + maWysokośćBryły * maWysokośćBryły)));
                    break;
                default:
                    maObjętośćBryły = (1 / 3) * (float)(maStopieńWielokątaPodstawy * ((3 * maPromień * maPromień * Math.Sqrt(3)) / 4) * maWysokośćBryły);
                    maPowierzchniaBryły = (float)(maStopieńWielokątaPodstawy * ((3 * maPromień * maPromień * Math.Sqrt(3)) / 4) + maStopieńWielokątaPodstawy * (1 / 2) * (3 * maPromień / Math.Sqrt(3)) * (Math.Sqrt(maPromień * maPromień + maWysokośćBryły * maWysokośćBryły)));
                    break;
            }
        }

        public override void maWrócDoStarychWspółrzędnych()
        {
            maPrzesuńDoNowegoXY(maPoprzedniPunktLokacji.X, maPoprzedniPunktLokacji.Y);
        }
    }
}
