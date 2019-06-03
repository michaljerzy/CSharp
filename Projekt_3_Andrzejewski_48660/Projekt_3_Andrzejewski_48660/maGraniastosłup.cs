using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using static Projekt_3_Andrzejewski_48660.Andrzejewski;

namespace Projekt_3_Andrzejewski_48660
{
    class maGraniastosłup : maBryłaAbstrakcyjna
    {
        public int maStopieńWielokątaPodstawy;
        float maOś_Duża, maOś_Mała;
        float maKątMiędztWierzchołkami, maKątPołożenia;
        Point[] maWielokątPodłogi;
        Point[] maWielokątSufitu;

        public maGraniastosłup(int maPromień, int maWysokość, int maStopieńWielokątaPodstawy, int maXŚrodekSufitu, int maYŚrodekSufitu, int maXŚrodekPodłogi, int maYŚrodekPodłogi, Color maKolor_Linii, DashStyle maStyl_Linii, int maGrubość_Linii, float maObjętośćBryły, float maPowierzchniaBryły) : base(maPromień, maKolor_Linii, maStyl_Linii, maGrubość_Linii)
        {
            this.maRodzajBryły = maTypBryły.ma_Walec;
            this.maWysokość = maWysokość;
            this.maStopieńWielokątaPodstawy = maStopieńWielokątaPodstawy;
            this.maOś_Duża = this.maPromień * 2;
            this.maOś_Mała = this.maPromień / 2;
            this.maPowierzchniaBryły = maPowierzchniaBryły;
            this.maObjętośćBryły = maObjętośćBryły;
            this.maXŚrodekPodłogi = maXŚrodekPodłogi;
            this.maYŚrodekPodłogi = maYŚrodekPodłogi;
            this.maXŚrodekSufitu = maXŚrodekSufitu;
            this.maYŚrodekSufitu = maYŚrodekSufitu - maWysokość;
            this.maGrubość_linii = maGrubośćlinii;
            this.maStyl_linii = maStyl_linii;
            this.maKolor_linii = maKolor_linii;
            maKątMiędztWierzchołkami = 360 / maStopieńWielokątaPodstawy;
            maKątPołożenia = 0f;

            maWielokątPodłogi = new Point[maStopieńWielokątaPodstawy + 1];
            maWielokątSufitu = new Point[maStopieńWielokątaPodstawy + 1];

            for (int i = 0; i <= maStopieńWielokątaPodstawy; i++)
            {
                maWielokątPodłogi[i].X = maWielokątPodłogi[i].X;
                maWielokątPodłogi[i].Y = maWielokątPodłogi[i].Y - maWysokość;

                maWielokątPodłogi[i].X = (int)(maXŚrodekPodłogi + (maOś_Duża / 2) * Math.Cos(Math.PI * (maKątPołożenia + i * maKątMiędztWierzchołkami) / 180));
                maWielokątPodłogi[i].Y = (int)(maXŚrodekPodłogi + (maOś_Duża / 2) * Math.Sin(Math.PI * (maKątPołożenia + i * maKątMiędztWierzchołkami) / 180));
                maWielokątSufitu[i] = new Point();
                maWielokątSufitu[i] = new Point();
            }

            maObjętośćBryły = (float)(Math.PI * Math.Pow(maPromień, 2) * maWysokość);
            maPowierzchniaBryły = (float)(2 * Math.PI * maPromień * (maPromień + maWysokość));
        }

        public override void maWykreśl()
        {
            Pen maDługopis = new Pen(maKolor_linii, maGrubość_linii);
            maDługopis.DashStyle = maStyl_linii;
            maRysownica.DrawEllipse(maDługopis, maXŚrodekPodłogi - maOś_Duża / 2, maYŚrodekPodłogi - maOś_Mała / 2, maOś_Duża, maOś_Mała);
            maRysownica.DrawEllipse(maDługopis, maXŚrodekSufitu - maOś_Duża / 2, maYŚrodekSufitu - maOś_Mała / 2, maOś_Duża, maOś_Mała);

            maRysownica.DrawLine(maDługopis, maXŚrodekPodłogi + maOś_Duża / 2, maYŚrodekPodłogi, maXŚrodekSufitu + maOś_Duża / 2, maYŚrodekSufitu);
            maRysownica.DrawLine(maDługopis, maXŚrodekPodłogi - maOś_Duża / 2, maYŚrodekPodłogi, maXŚrodekSufitu - maOś_Duża / 2, maYŚrodekSufitu);

            for (int i = 0; i <= maStopieńWielokątaPodstawy; i++)
            {
                maRysownica.DrawLine(maDługopis, maWielokątSufitu[i], maWielokątPodłogi[i]);
            }
            maDługopis.Dispose();
        }
        public override void maWymaż()
        {
            Pen maDługopis = new Pen(Color.White, maGrubość_linii);
            maDługopis.DashStyle = maStyl_linii;

            maRysownica.DrawEllipse(maDługopis, maXŚrodekPodłogi - maOś_Duża / 2, maYŚrodekPodłogi - maOś_Mała / 2, maOś_Duża, maOś_Mała);
            maRysownica.DrawEllipse(maDługopis, maXŚrodekSufitu - maOś_Duża / 2, maYŚrodekSufitu - maOś_Mała / 2, maOś_Duża, maOś_Mała);

            maRysownica.DrawLine(maDługopis, maXŚrodekPodłogi + maOś_Duża / 2, maYŚrodekPodłogi, maXŚrodekSufitu + maOś_Duża / 2, maYŚrodekSufitu);
            maRysownica.DrawLine(maDługopis, maXŚrodekPodłogi - maOś_Duża / 2, maYŚrodekPodłogi, maXŚrodekSufitu - maOś_Duża / 2, maYŚrodekSufitu);

            for (int i = 0; i <= maStopieńWielokątaPodstawy; i++)
            {
                maRysownica.DrawLine(maDługopis, maWielokątSufitu[i], maWielokątPodłogi[i]);
            }
            maDługopis.Dispose();
        }

        public override void maObróćIWykreśl(float maKątObrotu)
        {
            maWymaż();
            if (!maKierunekObratu)
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

                maWielokątPodłogi[i].X = maWielokątPodłogi[i].X;
                maWielokątPodłogi[i].Y = maWielokątPodłogi[i].Y - maWysokość;

                maWielokątPodłogi[i].X = (int)(maXŚrodekPodłogi + (maOś_Duża / 2) * Math.Cos(Math.PI * (maKątPołożenia + i * maKątMiędztWierzchołkami) / 180));
                maWielokątPodłogi[i].Y = (int)(maXŚrodekPodłogi + (maOś_Duża / 2) * Math.Sin(Math.PI * (maKątPołożenia + i * maKątMiędztWierzchołkami) / 180));
            }
            maWykreśl();
        }
        public override void maPrzesuńDoNowegoXY(int maX, int maY)
        {
            maWymaż();
            maXŚrodekPodłogi = maX;
            maYŚrodekPodłogi = maY;
            maXŚrodekSufitu = maX;
            maYŚrodekSufitu = maY - maWysokość;

            for (int i = 0; i <= maStopieńWielokątaPodstawy; i++)
            {
                maWielokątPodłogi[i] = new Point();
                maWielokątSufitu[i] = new Point();

                maWielokątPodłogi[i].X = maWielokątPodłogi[i].X;
                maWielokątPodłogi[i].Y = maWielokątPodłogi[i].Y - maWysokość;

                maWielokątPodłogi[i].X = (int)(maXŚrodekPodłogi + (maOś_Duża / 2) * Math.Cos(Math.PI * (maKątPołożenia + i * maKątMiędztWierzchołkami) / 180));
                maWielokątPodłogi[i].Y = (int)(maXŚrodekPodłogi + (maOś_Duża / 2) * Math.Sin(Math.PI * (maKątPołożenia + i * maKątMiędztWierzchołkami) / 180));
            }
            maWykreśl();
        }
        public override void maZmieńWysokośćFigury(int maWysokośćBryły)
        {
            maWymaż();
            maWysokość = maWysokośćBryły;
            maObjętośćIPolePowierzchni();
        }
        public override void maZmieńPromieńFigury(int maPromieńFigury)
        {
            maWymaż();
            maOś_Duża = maPromieńFigury * 2;
            maOś_Mała = maPromieńFigury / 2;
            maPromień = maPromieńFigury;
            maObjętośćIPolePowierzchni();
        }

        public void maObjętośćIPolePowierzchni()
        {
            switch (maStopieńWielokątaPodstawy)
            {
                case 3:
                    maObjętośćBryły = (float)(((3 * maPromień * maPromień * Math.Sqrt(3)) / 4) * maWysokość);
                    maPowierzchniaBryły = (float)(2 * ((3 * maPromień * maPromień * Math.Sqrt(3)) / 4) + (3 * maPromień / Math.Sqrt(3)) * maWysokość);
                    break;
                case 4:
                    maObjętośćBryły = (float)(maOś_Duża / Math.Sqrt(2)) * maWysokość;
                    maPowierzchniaBryły = (float)(2 * (maOś_Duża * maOś_Duża) + 4 + ((maOś_Duża / Math.Sqrt(2)) * maWysokość));
                    break;
                default:
                    maObjętośćBryły = (float)(maStopieńWielokątaPodstawy * ((3 * maPromień * maPromień * Math.Sqrt(3)) / 4) * maWysokość);
                    maPowierzchniaBryły = (float)((maStopieńWielokątaPodstawy * ((3 * maPromień * maPromień * Math.Sqrt(3)) / 4)) + maStopieńWielokątaPodstawy * ((3 * maPromień * maPromień * Math.Sqrt(3)) / 4));
                    break;
            }
        }
    }
}
