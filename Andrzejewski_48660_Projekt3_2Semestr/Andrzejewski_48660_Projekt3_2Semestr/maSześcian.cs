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
    class maSześcian : maBryłaAbstrakcyjna
    {
        float maOśDuża, maOśMała;
        float maKątPołożenia;
        Point[] maWielokątPodłogi;
        Point[] maWielokątSufitu;
        Point maPoprzedniPunktLokacji;

        public maSześcian(int maPromien, Color maKolorLinii, DashStyle maStylLinii, int maGruboscLinii, Point maSrodekPodlogi) : base(maPromien, maKolorLinii, maStylLinii, maGruboscLinii)
        {
            maRodzajBryły = maTypBryły.maSześcian;
            maPromień = maPromien;
            maPoprzedniPunktLokacji = maSrodekPodlogi;
            maOśDuża = maPromien * 2;
            maOśMała = maPromien / 2;
            maXŚrodkaPodłogi = maSrodekPodlogi.X;
            maYŚrodkaPodłogi = maSrodekPodlogi.Y;
            maGrubośćLinii = maGruboscLinii;
            this.maStylLinii = maStylLinii;
            this.maKolorLinii = maKolorLinii;
            maKątPołożenia = 0;
            maWielokątPodłogi = new Point[5];
            maWielokątSufitu = new Point[5];

            for (int i = 0; i <= 4; i++)
            {
                maWielokątPodłogi[i] = new Point();
                maWielokątSufitu[i] = new Point();

                maWielokątPodłogi[i].X = (int)(maXŚrodkaPodłogi + (maOśDuża / 2) * Math.Cos(Math.PI * (maKątPołożenia + i * 90) / 180f));
                maWielokątPodłogi[i].Y = (int)(maYŚrodkaPodłogi + (maOśMała / 2) * Math.Sin(Math.PI * (maKątPołożenia + i * 90) / 180f));

                maWielokątSufitu[i].X = maWielokątPodłogi[i].X;
                maWielokątSufitu[i].Y = maWielokątPodłogi[i].Y - (int)(Math.Sqrt(2) * maPromień);

            }
            maLiczObjętośćIPolePowierzchni();
        }
        void maLiczObjętośćIPolePowierzchni()
        {
            maObjętośćBryły = (float)Math.Pow((int)(Math.Sqrt(2) * maPromień / 2), 3);
            maPowierzchniaBryły = 6 * (float)(2 * maPromień / Math.Sqrt(2));
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

                maWielokątPodłogi[i].X = (int)(maXŚrodkaPodłogi + (maOśDuża / 2) * Math.Cos(Math.PI * (maKątPołożenia + i * 90) / 180f));
                maWielokątPodłogi[i].Y = (int)(maYŚrodkaPodłogi + (maOśMała / 2) * Math.Sin(Math.PI * (maKątPołożenia + i * 90) / 180f));

                maWielokątSufitu[i].X = maWielokątPodłogi[i].X;
                maWielokątSufitu[i].Y = maWielokątPodłogi[i].Y - (int)(Math.Sqrt(2) * maPromień);

            }

            maWykreśl();
        }

        public override void maPrzesuńDoNowegoXY(int maX, int maY)
        {
            maWymaż();
            maXŚrodkaPodłogi = maX;
            maYŚrodkaPodłogi = maY;
            maXŚrodkaSufitu = maX;
            maYŚrodkaSufitu = maY - maGetWysokośćBryły;

            for (int i = 0; i <= 4; i++)
            {
                maWielokątPodłogi[i] = new Point();
                maWielokątSufitu[i] = new Point();

                maWielokątPodłogi[i].X = (int)(maXŚrodkaPodłogi + (maOśDuża / 2) * Math.Cos(Math.PI * (maKątPołożenia + i * 90) / 180f));
                maWielokątPodłogi[i].Y = (int)(maYŚrodkaPodłogi + (maOśMała / 2) * Math.Sin(Math.PI * (maKątPołożenia + i * 90) / 180f));

                maWielokątSufitu[i].X = maWielokątPodłogi[i].X;
                maWielokątSufitu[i].Y = maWielokątPodłogi[i].Y - (int)(Math.Sqrt(2) * maPromień);
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
            //funkcja pusta
        }

        public override void maZmieńPromieńBryły(int maPro)
        {
            maWymaż();
            maOśDuża = maPro * 2;
            maOśMała = maPro / 2;
            maPromień = maPro;
            maLiczObjętośćIPolePowierzchni();
        }

        public override void maZmieńStylLinii(DashStyle maDashStyle)
        {
            maStylLinii = maDashStyle;
        }

        public override void maZmieńWysokośćBryły(int maWys)
        {
            // wysokość i szerokość bryły w moim kodzie jest dyktowana przez promień.
        }

        public override void maWrócDoStarychWspółrzędnych()
        {
            maPrzesuńDoNowegoXY(maPoprzedniPunktLokacji.X, maPoprzedniPunktLokacji.Y);
        }
    }
}
