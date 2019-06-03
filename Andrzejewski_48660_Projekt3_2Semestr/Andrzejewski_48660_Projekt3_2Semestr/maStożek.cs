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
    class maStożek : maBryłaAbstrakcyjna
    {
        public int maStopieńWielokątaPodstawy;
        float maOśDuża, maOśMała;
        float maKątMiędzyWierzchołkami, maKątPołożenia;
        Point[] maWielokątPodłogi;
        Point maSufit;
        Point maPoprzedniPunktLokacji;

        public maStożek(int maPromien, Color maKolorLinii, DashStyle maStylLinii, int maGruboscLinii, int maWysokosc, int maStopienWielokataPodstawy, Point maSrodekPodlogi) : base(maPromien, maKolorLinii, maStylLinii, maGruboscLinii)
        {
            maRodzajBryły = maTypBryły.maStożek;
            maWysokośćBryły = maWysokosc;
            maStopieńWielokątaPodstawy = maStopienWielokataPodstawy;
            maPoprzedniPunktLokacji = maSrodekPodlogi;
            maOśDuża = maPromien * 2;
            maOśMała = maPromien / 2;
            maXŚrodkaPodłogi = maSrodekPodlogi.X;
            maYŚrodkaPodłogi = maSrodekPodlogi.Y;
            maSufit.X = maXŚrodkaPodłogi;
            maSufit.Y = maYŚrodkaPodłogi - maWysokośćBryły;
            maGrubośćLinii = maGruboscLinii;
            this.maStylLinii = maStylLinii;
            this.maKolorLinii = maKolorLinii;

            maKątMiędzyWierzchołkami = 360 / maStopienWielokataPodstawy;
            maKątPołożenia = 0f;

            maWielokątPodłogi = new Point[maStopienWielokataPodstawy + 1];

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

            maRysownica.DrawEllipse(maPen, maXŚrodkaPodłogi - maOśDuża / 2, maYŚrodkaPodłogi - maOśMała / 2, maOśDuża, maOśMała);
            maRysownica.DrawLine(maPen, maXŚrodkaPodłogi + maOśDuża / 2, maYŚrodkaPodłogi, maSufit.X, maSufit.Y);
            maRysownica.DrawLine(maPen, maXŚrodkaPodłogi - maOśDuża / 2, maYŚrodkaPodłogi, maSufit.X, maSufit.Y);


            for (int i = 0; i < maWielokątPodłogi.Length - 1; i++)
            {
                maRysownica.DrawLine(maPen, maSufit, maWielokątPodłogi[i]);

            }

            maPen.Dispose();
        }

        public override void maWymaż()
        {
            Pen maPen = new Pen(Color.White, maGrubośćLinii);
            maPen.DashStyle = maStylLinii;

            maRysownica.DrawEllipse(maPen, maXŚrodkaPodłogi - maOśDuża / 2, maYŚrodkaPodłogi - maOśMała / 2, maOśDuża, maOśMała);
            maRysownica.DrawLine(maPen, maXŚrodkaPodłogi + maOśDuża / 2, maYŚrodkaPodłogi, maSufit.X, maSufit.Y);
            maRysownica.DrawLine(maPen, maXŚrodkaPodłogi - maOśDuża / 2, maYŚrodkaPodłogi, maSufit.X, maSufit.Y);


            for (int i = 0; i < maWielokątPodłogi.Length - 1; i++)
            {
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

            for (int i = 0; i <= maStopieńWielokątaPodstawy; i++)
            {
                maWielokątPodłogi[i] = new Point();

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
            maSufit.X = maX;
            maSufit.Y = maY - maWysokośćBryły;

            for (int i = 0; i <= maStopieńWielokątaPodstawy; i++)
            {
                maWielokątPodłogi[i] = new Point();

                maWielokątPodłogi[i].X = (int)(maXŚrodkaPodłogi + (maOśDuża / 2) * Math.Cos(Math.PI * (maKątPołożenia + i * maKątMiędzyWierzchołkami) / 180f));
                maWielokątPodłogi[i].Y = (int)(maYŚrodkaPodłogi + (maOśMała / 2) * Math.Sin(Math.PI * (maKątPołożenia + i * maKątMiędzyWierzchołkami) / 180f));

            }
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
            //Nie pochylona
        }

        public override void maZmieńPromieńBryły(int maPro)
        {
            maWymaż();
            maOśDuża = maPro * 2;
            maOśMała = maPro / 2;
            maPromień = maPro;
            maObjętoścIPolePowierzchni();
        }

        public override void maZmieńStylLinii(DashStyle maDashStyle)
        {
            maStylLinii = maDashStyle;
        }

        public override void maZmieńWysokośćBryły(int maWys)
        {
            maWymaż();
            maSufit.Y = maYŚrodkaPodłogi - maWys;
            maWysokośćBryły = maWys;
            maObjętoścIPolePowierzchni();
        }

        void maObjętoścIPolePowierzchni()
        {
            maObjętośćBryły = (1 / 3) * (float)(Math.PI * maPromień * maPromień * maWysokośćBryły);
            maPowierzchniaBryły = (float)(Math.PI * maPromień * (maPromień + Math.Sqrt(maWysokośćBryły * maWysokośćBryły + maPromień * maPromień)));
        }

        public override void maWrócDoStarychWspółrzędnych()
        {
            maPrzesuńDoNowegoXY(maPoprzedniPunktLokacji.X, maPoprzedniPunktLokacji.Y);
        }
    }
}
