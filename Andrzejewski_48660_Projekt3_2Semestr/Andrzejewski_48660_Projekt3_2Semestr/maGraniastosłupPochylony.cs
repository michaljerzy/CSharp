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
    class maGraniastosłupPochylony : maBryłaAbstrakcyjna
    {
        public int maStopieńWielokątaPodstawy;
        float maOśDuża, maOśMała;
        float maKątMiędzyWierzchołkami, maKątPołożenia;
        Point[] maWielokątPodłogi;
        Point[] maWielokątSufitu;
        Point maPoprzedniPunktLokacji;

        public maGraniastosłupPochylony(int maPromien, Color maKolorLinii, DashStyle maStylLinii, int maGruboscLinii, int maWysokosc, int maStopienWielokataPodstawy, Point maSrodekPodlogi, int maKątNachylenia) : base(maPromien, maKolorLinii, maStylLinii, maGruboscLinii)
        {
            maRodzajBryły = maTypBryły.maGraniastosłupPochylony;
            maWysokośćBryły = maWysokosc;
            maPoprzedniPunktLokacji = maSrodekPodlogi;
            maStopieńWielokątaPodstawy = maStopienWielokataPodstawy;
            maOśDuża = maPromien * 2;
            maOśMała = maPromien / 2;
            maXŚrodkaPodłogi = maSrodekPodlogi.X;
            maYŚrodkaPodłogi = maSrodekPodlogi.Y;
            maXŚrodkaSufitu = maXŚrodkaPodłogi;
            maYŚrodkaSufitu = maYŚrodkaPodłogi - maWysokośćBryły;
            maKątPochylenia = maKątNachylenia;
            maGrubośćLinii = maGruboscLinii;
            this.maStylLinii = maStylLinii;
            this.maKolorLinii = maKolorLinii;
            maWielokątPodłogi = new Point[maStopienWielokataPodstawy + 1];
            maWielokątSufitu = new Point[maStopienWielokataPodstawy + 1];

            maKątMiędzyWierzchołkami = 360 / maStopienWielokataPodstawy;
            maKątPołożenia = 0f;

            for (int i = 0; i <= maStopienWielokataPodstawy; i++)
            {
                maWielokątPodłogi[i] = new Point();
                maWielokątSufitu[i] = new Point();

                maWielokątPodłogi[i].X = (int)(maXŚrodkaPodłogi + (maOśDuża / 2) * Math.Cos(Math.PI * (maKątPołożenia + i * maKątMiędzyWierzchołkami) / 180f));
                maWielokątPodłogi[i].Y = (int)(maYŚrodkaPodłogi + (maOśMała / 2) * Math.Sin(Math.PI * (maKątPołożenia + i * maKątMiędzyWierzchołkami) / 180f));

                maWielokątSufitu[i].X = maWielokątPodłogi[i].X - (90 - maKątPochylenia);
                maWielokątSufitu[i].Y = maWielokątPodłogi[i].Y - maWysokośćBryły;

            }
            maLiczObjętośćIPolePowierzchni();
        }

        public override void maWykreśl()
        {
            Pen maPen = new Pen(maKolorLinii, maGrubośćLinii);
            maPen.DashStyle = maStylLinii;

            for (int i = 0; i < maWielokątPodłogi.Length - 1; i++)
            {
                maRysownica.DrawLine(maPen, maWielokątPodłogi[i], maWielokątPodłogi[i + 1]);
                maRysownica.DrawLine(maPen, maWielokątSufitu[i], maWielokątSufitu[i + 1]);
                maRysownica.DrawLine(maPen, maWielokątSufitu[i], maWielokątPodłogi[i]);
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
                maRysownica.DrawLine(maPen, maWielokątSufitu[i], maWielokątSufitu[i + 1]);
                maRysownica.DrawLine(maPen, maWielokątSufitu[i], maWielokątPodłogi[i]);
            }

            maPen.Dispose();
        }

        public override void maZmieńWysokośćBryły(int maWys)
        {
            maWymaż();
            maWysokośćBryły = maWys;
            maLiczObjętośćIPolePowierzchni();
        }

        public override void maZmieńPromieńBryły(int maPro)
        {
            maWymaż();
            maOśDuża = maPro * 2;
            maOśMała = maPro / 2;
            maPromień = maPro;
            maLiczObjętośćIPolePowierzchni();
        }

        public override void maZmieńKolorLinii(Color maCol)
        {
            maKolorLinii = maCol;
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
                maWielokątPodłogi[i] = new Point();
                maWielokątSufitu[i] = new Point();

                maWielokątPodłogi[i].X = (int)(maXŚrodkaPodłogi + (maOśDuża / 2) * Math.Cos(Math.PI * (maKątPołożenia + i * maKątMiędzyWierzchołkami) / 180f));
                maWielokątPodłogi[i].Y = (int)(maYŚrodkaPodłogi + (maOśMała / 2) * Math.Sin(Math.PI * (maKątPołożenia + i * maKątMiędzyWierzchołkami) / 180f));

                maWielokątSufitu[i].X = maWielokątPodłogi[i].X - (90 - maKątPochylenia);
                maWielokątSufitu[i].Y = maWielokątPodłogi[i].Y - maWysokośćBryły;

            }
            maWykreśl();
        }

        public override void maZmieńGrubośćLinii(int maGrubosc)
        {
            maGrubośćLinii = maGrubosc;
        }

        public override void maZmieńKątNachylenia(int maKąt)
        {
            maKątPochylenia = maKąt;
        }

        public override void maPrzesuńDoNowegoXY(int maX, int maY)
        {
            maWymaż();
            maXŚrodkaPodłogi = maX;
            maYŚrodkaPodłogi = maY;
            maXŚrodkaSufitu = maX;
            maYŚrodkaSufitu = maY - maWysokośćBryły;

            for (int i = 0; i <= maStopieńWielokątaPodstawy; i++)
            {
                maWielokątPodłogi[i] = new Point();
                maWielokątSufitu[i] = new Point();

                maWielokątPodłogi[i].X = (int)(maXŚrodkaPodłogi + (maOśDuża / 2) * Math.Cos(Math.PI * (maKątPołożenia + i * maKątMiędzyWierzchołkami) / 180f));
                maWielokątPodłogi[i].Y = (int)(maYŚrodkaPodłogi + (maOśMała / 2) * Math.Sin(Math.PI * (maKątPołożenia + i * maKątMiędzyWierzchołkami) / 180f));

                maWielokątSufitu[i].X = maWielokątPodłogi[i].X - (90 - maKątPochylenia);
                maWielokątSufitu[i].Y = maWielokątPodłogi[i].Y - maWysokośćBryły;
            }
        }

        public override void maZmieńStylLinii(DashStyle maDashStyle)
        {
            maStylLinii = maDashStyle;
        }

        void maLiczObjętośćIPolePowierzchni()
        {
            switch (maStopieńWielokątaPodstawy)
            {
                case 3:
                    maObjętośćBryły = (float)(((3 * maPromień * maPromień * Math.Sqrt(3)) / 4) * maWysokośćBryły);
                    maPowierzchniaBryły = (float)(2 * ((3 * maPromień * maPromień * Math.Sqrt(3)) / 4) + (3 * maPromień / Math.Sqrt(3) * maWysokośćBryły));
                    break;
                case 4:
                    maObjętośćBryły = (float)(maOśDuża / Math.Sqrt(2)) * maWysokośćBryły;
                    maPowierzchniaBryły = (float)(2 * (Math.Pow(maOśDuża / Math.Sqrt(2), 2)) + 4 * ((maOśDuża / Math.Sqrt(2))) * maWysokośćBryły);
                    break;
                default:
                    maObjętośćBryły = (float)(maStopieńWielokątaPodstawy * ((3 * maPromień * maPromień * Math.Sqrt(3)) / 4) * maWysokośćBryły);
                    maPowierzchniaBryły = (float)(2 * maStopieńWielokątaPodstawy * ((3 * maPromień * maPromień * Math.Sqrt(3)) / 4) + maStopieńWielokątaPodstawy * (maPromień * Math.Sqrt(3) * maWysokośćBryły));
                    break;
            }
        }
        public override void maWrócDoStarychWspółrzędnych()
        {
            maPrzesuńDoNowegoXY(maPoprzedniPunktLokacji.X, maPoprzedniPunktLokacji.Y);
        }
    }
}
