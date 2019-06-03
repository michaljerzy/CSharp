using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;
using static Andrzejewski_48660_Projekt3_2Semestr.Andrzejewski;

namespace Andrzejewski_48660_Projekt3_2Semestr
{
    class maWaleck : maBryłaAbstrakcyjna
    {
        public int maStopieńWielokątaPodstawy;
        float maOśDuża, maOśMała;
        float maKątMiędzyWierzchołkami, maKątPołożenia;
        Point[] maWielokątPodłogi;
        Point[] maWielokątSufitu;
        Point maPoprzedniPunktLokacji;

        public maWaleck(int maPromien, Color maKolorLinii, DashStyle maStylLinii, int maGruboscLinii, int maWysokosc, int maStopienWielokataPodstawy, Point maSrodekPodlogi) : base(maPromien, maKolorLinii, maStylLinii, maGruboscLinii)
        {
            maRodzajBryły = maTypBryły.maWalec;
            maWysokośćBryły = maWysokosc;
            maPoprzedniPunktLokacji = maSrodekPodlogi;
            maStopieńWielokątaPodstawy = maStopienWielokataPodstawy;
            maOśDuża = maPromien * 2;
            maOśMała = maPromien / 2;
            maXŚrodkaPodłogi = maSrodekPodlogi.X;
            maYŚrodkaPodłogi = maSrodekPodlogi.Y;
            maXŚrodkaSufitu = maXŚrodkaPodłogi;
            maYŚrodkaSufitu = maYŚrodkaPodłogi - maWysokośćBryły;
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

                maWielokątSufitu[i].X = maWielokątPodłogi[i].X;
                maWielokątSufitu[i].Y = maWielokątPodłogi[i].Y - maWysokośćBryły;

            }
        }

        public override void maObróćIWykreśl(int maKątObrotu)
        {
            maWymaż();
            if (!maKierunekObrotu)
            {
                maKątObrotu *= 1;
            }
            else
            {
                maKątObrotu *= -1;
            }

            for (int i = 0; i <= maStopieńWielokątaPodstawy; i++)
            {
                maWielokątPodłogi[i] = new Point();
                maWielokątSufitu[i] = new Point();

                maWielokątPodłogi[i].X = (int)(maXŚrodkaPodłogi + (maOśDuża / 2) * Math.Cos(Math.PI * (maKątObrotu + i * maKątMiędzyWierzchołkami) / 180f));
                maWielokątPodłogi[i].Y = (int)(maYŚrodkaPodłogi + (maOśMała / 2) * Math.Sin(Math.PI * (maKątObrotu + i * maKątMiędzyWierzchołkami) / 180f));

                maWielokątSufitu[i].X = maWielokątPodłogi[i].X;
                maWielokątSufitu[i].Y = maWielokątPodłogi[i].Y - maWysokośćBryły;
            }

            maWykreśl();
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

                maWielokątSufitu[i].X = maWielokątPodłogi[i].X;
                maWielokątSufitu[i].Y = maWielokątPodłogi[i].Y - maWysokośćBryły;
            }

        }


        public override void maWykreśl()
        {
            Pen maPen = new Pen(maKolorLinii, maGrubośćLinii);
            maPen.DashStyle = maStylLinii;

            maRysownica.DrawEllipse(maPen, maXŚrodkaPodłogi - maOśDuża / 2, maYŚrodkaPodłogi - maOśMała / 2, maOśDuża, maOśMała);
            maRysownica.DrawEllipse(maPen, maXŚrodkaSufitu - maOśDuża / 2, maYŚrodkaSufitu - maOśMała / 2, maOśDuża, maOśMała);

            maRysownica.DrawLine(maPen, maXŚrodkaPodłogi + maOśDuża / 2, maYŚrodkaPodłogi, maXŚrodkaPodłogi + maOśDuża / 2, maYŚrodkaSufitu);
            maRysownica.DrawLine(maPen, maXŚrodkaPodłogi - maOśDuża / 2, maYŚrodkaPodłogi, maXŚrodkaPodłogi - maOśDuża / 2, maYŚrodkaSufitu);

            for (int i = 0; i <= maStopieńWielokątaPodstawy; i++)
            {
                maRysownica.DrawLine(maPen, maWielokątSufitu[i], maWielokątPodłogi[i]);
            }
            maPen.Dispose();
        }

        public override void maWymaż()
        {
            Pen maPen = new Pen(Color.White, maGrubośćLinii);
            maPen.DashStyle = maStylLinii;

            maRysownica.DrawEllipse(maPen, maXŚrodkaPodłogi - maOśDuża / 2, maYŚrodkaPodłogi - maOśMała / 2, maOśDuża, maOśMała);
            maRysownica.DrawEllipse(maPen, maXŚrodkaSufitu - maOśDuża / 2, maYŚrodkaSufitu - maOśMała / 2, maOśDuża, maOśMała);

            maRysownica.DrawLine(maPen, maXŚrodkaPodłogi + maOśDuża / 2, maYŚrodkaPodłogi, maXŚrodkaPodłogi + maOśDuża / 2, maYŚrodkaSufitu);
            maRysownica.DrawLine(maPen, maXŚrodkaPodłogi - maOśDuża / 2, maYŚrodkaPodłogi, maXŚrodkaPodłogi - maOśDuża / 2, maYŚrodkaSufitu);

            for (int i = 0; i <= maStopieńWielokątaPodstawy; i++)
            {
                maRysownica.DrawLine(maPen, maWielokątSufitu[i], maWielokątPodłogi[i]);
            }
            maPen.Dispose();
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
            // puste ponieważ walec nie będzie pochylany.
        }

        public override void maZmieńPromieńBryły(int maPro)
        {
            maWymaż();
            maOśDuża = maPro * 2;
            maOśMała = maPro / 2;
            maPromień = maPro;
            maLiczObjętośćIPole();
        }

        public override void maZmieńStylLinii(DashStyle maDashStyle)
        {
            maStylLinii = maDashStyle;
        }

        public override void maZmieńWysokośćBryły(int maWys)
        {
            maWymaż();
            maYŚrodkaSufitu = maYŚrodkaPodłogi - maWys;
            maWysokośćBryły = maWys;
            maLiczObjętośćIPole();


        }

        void maLiczObjętośćIPole()
        {
            maObjętośćBryły = (float)(Math.PI * Math.Pow(maPromień, 2) * maWysokośćBryły);
            maPowierzchniaBryły = (float)(2 * Math.PI * maPromień * (maPromień + maWysokośćBryły));
        }

        public override void maWrócDoStarychWspółrzędnych()
        {
            maPrzesuńDoNowegoXY(maPoprzedniPunktLokacji.X, maPoprzedniPunktLokacji.Y);
        }
    }
}
