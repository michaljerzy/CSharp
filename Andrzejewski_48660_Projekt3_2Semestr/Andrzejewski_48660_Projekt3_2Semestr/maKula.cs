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
    class maKula : maBryłaAbstrakcyjna
    {
        float maOśDuża, maOśMała;
        int maPręg = 0;
        Point maPoprzedniPunktLokacji;

        public maKula(int maPromień, Point maŚrodekPodłogi, Color maKolor, DashStyle maStyl, int maGrubośćLinii) : base(maPromień, maKolor, maStyl, maGrubośćLinii)
        {
            maRodzajBryły = maTypBryły.maKula;
            maPoprzedniPunktLokacji = maŚrodekPodłogi;
            maXŚrodkaPodłogi = maŚrodekPodłogi.X;
            maYŚrodkaPodłogi = maŚrodekPodłogi.Y;
            this.maGrubośćLinii = maGrubośćLinii;
            maOśDuża = maPromień * 2;
            maOśMała = maPromień / 2;
            maKolorLinii = maKolor;
            maStylLinii = maStyl;
        }

        public override void maWykreśl()
        {
            Pen pen = new Pen(maKolorLinii, maGrubośćLinii);
            pen.DashStyle = maStylLinii;

            maRysownica.DrawEllipse(pen, maXŚrodkaPodłogi - maOśDuża / 2, maYŚrodkaPodłogi - maOśMała / 2, maOśDuża, maOśDuża);
            maRysownica.DrawEllipse(pen, maXŚrodkaPodłogi - maOśDuża / 2, maYŚrodkaPodłogi + maOśMała, maOśDuża, maOśMała);
            maRysownica.DrawEllipse(pen, maPręg / 2 + maXŚrodkaPodłogi - maOśDuża / 2, maYŚrodkaPodłogi - maOśMała / 2, maOśDuża - maPręg, maOśDuża);


            pen.Dispose();

        }

        public override void maWymaż()
        {
            Pen pen = new Pen(Color.White, maGrubośćLinii);
            pen.DashStyle = maStylLinii;

            maRysownica.DrawEllipse(pen, maXŚrodkaPodłogi - maOśDuża / 2, maYŚrodkaPodłogi - maOśMała / 2, maOśDuża, maOśDuża);
            maRysownica.DrawEllipse(pen, maXŚrodkaPodłogi - maOśDuża / 2, maYŚrodkaPodłogi + maOśMała, maOśDuża, maOśMała);
            maRysownica.DrawEllipse(pen, maPręg / 2 + maXŚrodkaPodłogi - maOśDuża / 2, maYŚrodkaPodłogi - maOśMała / 2, maOśDuża - maPręg, maOśDuża);


            pen.Dispose();

        }

        public override void maObróćIWykreśl(int maKątObrotu)
        {
            maWymaż();
            maPręg = maKątObrotu % (int)(maOśDuża) * 2;
            maWykreśl();
        }

        public override void maPrzesuńDoNowegoXY(int maX, int maY)
        {
            maWymaż();
            maXŚrodkaPodłogi = maX;
            maYŚrodkaPodłogi = maY;
        }

        public override void maZmieńWysokośćBryły(int maWys)
        {
            // puste
        }

        public override void maZmieńStylLinii(DashStyle maDashStyle)
        {
            maStylLinii = maDashStyle;
        }

        public override void maZmieńPromieńBryły(int maPro)
        {
            maWymaż();
            maOśDuża = maPro * 2;
            maOśMała = maPro / 2;

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
            // puste
        }

        public override void maWrócDoStarychWspółrzędnych()
        {
            maPrzesuńDoNowegoXY(maPoprzedniPunktLokacji.X, maPoprzedniPunktLokacji.Y);
        }
    }
}
