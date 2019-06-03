using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using static Andrzejewski_Projekt3_48660.Andrzejewski_48660;

namespace Andrzejewski_Projekt3_48660
{
    class maOstrosłupSześciokątny : maWielościany
    {
        float maOś_Duża, maOś_Mała;
        float maKątMiędzyWierzchołkami, maKątPołożenia;
        Point[] maWielokątPodłogi;
        private int maPromień;
        private Color maKolorLinii;
        private DashStyle maStylLinii;
        private int maGrubośćLinii;

        public maOstrosłupSześciokątny(int maPromień, int maWysokość, int maStopieńWielokątaPodstawy, int maXŚrodekSufitu, int maYŚrodekSufitu, int maXŚrodekPodłogi, int maYŚrodekPodłogi, Color maKolorLinii, DashStyle maStylLinii, int maGrubośćLinii) : base(maPromień, maKolorLinii, maStylLinii, maGrubośćLinii)
        {
            this.maRodzajBryły = maTypBryły.ma_OstrosłupSześciokątny;
            this.maWysokość = maWysokość;
            this.maStopieńWielokątaPodstawy = maStopieńWielokątaPodstawy;
            this.maOś_Duża = this.maPromień * 2;
            this.maOś_Mała = this.maPromień / 2;
            this.maXŚrodekPodłogi = maXŚrodekPodłogi;
            this.maYŚrodekPodłogi = maYŚrodekPodłogi;
            this.maXŚrodekSufitu = maXŚrodekSufitu;
            this.maYŚrodekSufitu = maYŚrodekSufitu - maWysokość;
            this.maKątMiędzyWierzchołkami = 360 / maStopieńWielokątaPodstawy;
            this.maKątPołożenia = 0f;
            this.maKątPochylenia = 90;
            this.maWielokątPodłogi = new Point[maStopieńWielokątaPodstawy + 1];

            for (int i = 0; i <= maStopieńWielokątaPodstawy; i++)
            {
                maWielokątPodłogi[i] = new Point();

                maWielokątPodłogi[i].X = (int)(this.maXŚrodekPodłogi + (maOś_Duża / 2) * Math.Cos(Math.PI * (maKątPołożenia + i * maKątMiędzyWierzchołkami) / 180));
                maWielokątPodłogi[i].Y = (int)(this.maXŚrodekPodłogi + (maOś_Duża / 2) * Math.Sin(Math.PI * (maKątPołożenia + i * maKątMiędzyWierzchołkami) / 180));
            }

            float maPolePodstawy = (float)((3 * Math.Pow(maOś_Duża / 2, 2) * Math.Sqrt(3)) / 2);
            float maPoleBoku = (float)((maOś_Duża / 4) * Math.Sqrt((5 / 4) * Math.Pow(maOś_Duża / 2, 2) + Math.Pow(maWysokość, 2)));
            this.maObjętośćBryły = (maPolePodstawy * maWysokość / 3);
            this.maPowierzchniaBryły = (maPolePodstawy + maPoleBoku * 6);
        }

        public override void maWykreśl()
        {
            Pen maDługopis = new Pen(this.maKolor_linii, this.maGrubość_linii);
            maDługopis.DashStyle = this.maStyl_linii;
            for (int i = 0; i < maWielokątPodłogi.Length - 1; i++)
                maRysownica.DrawLine(maDługopis, maWielokątPodłogi[i], maWielokątPodłogi[i + 1]);

            //wykreślenie krawędzi bocznych ostrosłupa
            for (int pwi = 0; pwi <= maStopieńWielokątaPodstawy; pwi++)
                maRysownica.DrawLine(maDługopis, maWielokątPodłogi[pwi], new Point(maXŚrodekSufitu, maYŚrodekSufitu));
            maDługopis.Dispose();
        }
        public override void maWymaż()
        {
            Pen maDługopis = new Pen(Color.White, this.maGrubość_linii);
            maDługopis.DashStyle = this.maStyl_linii;

            for (int i = 0; i < maWielokątPodłogi.Length - 1; i++)
                maRysownica.DrawLine(maDługopis, maWielokątPodłogi[i], maWielokątPodłogi[i + 1]);

            //wykreślenie krawędzi bocznych ostrosłupa
            for (int pwi = 0; pwi <= maStopieńWielokątaPodstawy; pwi++)
                maRysownica.DrawLine(maDługopis, maWielokątPodłogi[pwi], new Point(maXŚrodekSufitu, maYŚrodekSufitu));

            maDługopis.Dispose();
        }

        public override void maObróćIWykreśl(float maKątObrotu)
        {
            maWymaż();
            if (!this.maKierunekObratu)
            {
                this.maKątPołożenia += maKątObrotu;
            }
            else
            {
                this.maKątPołożenia -= maKątObrotu;
            }
            for (int i = 0; i <= maStopieńWielokątaPodstawy; i++)
            {


                maWielokątPodłogi[i].X = (int)(this.maXŚrodekPodłogi + (maOś_Duża / 2) * Math.Cos(Math.PI * (maKątPołożenia + i * maKątMiędzyWierzchołkami) / 180));
                maWielokątPodłogi[i].Y = (int)(this.maXŚrodekPodłogi + (maOś_Duża / 2) * Math.Sin(Math.PI * (maKątPołożenia + i * maKątMiędzyWierzchołkami) / 180));
            }
            maWykreśl();
        }
        public override void maPrzesuńDoNowegoXY(int maX, int maY)
        {
            maWymaż();
            maRysownica.Clear(Color.Aqua);
            this.maXŚrodekPodłogi = maX - (int)(this.maWysokość / (Math.Tan(Math.PI * maKątPochylenia / 180f)));
            this.maYŚrodekPodłogi = maY;
            this.maXŚrodekSufitu = maX + (int)(this.maWysokość / (Math.Tan(Math.PI * maKątPochylenia / 180f))); 
            this.maYŚrodekSufitu = maY - maWysokość;

            for (int i = 0; i <= maStopieńWielokątaPodstawy; i++)
            {

                maWielokątPodłogi[i].X = (int)(this.maXŚrodekPodłogi + (maOś_Duża / 2) * Math.Cos(Math.PI * (maKątPołożenia + i * maKątMiędzyWierzchołkami) / 180));
                maWielokątPodłogi[i].Y = (int)(this.maXŚrodekPodłogi + (maOś_Duża / 2) * Math.Sin(Math.PI * (maKątPołożenia + i * maKątMiędzyWierzchołkami) / 180));
            }
            maWykreśl();
        }
        public override void maZmieńWysokośćFigury(int maWysokośćBryły)
        {
            maWysokość = maWysokośćBryły;
        }
        public override void maZmieńPromieńFigury(int maPromieńFigury)
        {
            maWymaż();
            maOś_Duża = maPromieńFigury * 2;
            maOś_Mała = maPromieńFigury / 2;

        }
        public override void maUstawStopieńWielokąta(int maStopień)
        {

        }
        public override void maUstawKątNachyleniaStożka(int X) { /*pusta implementacja */ }
        public override void maObliczeniePolaObjętościItp()
        {
            //obliczenie objętości i pola powierzchni figury
            float maPolePodstawy = (float)((3 * Math.Pow(maOś_Duża / 2, 2) * Math.Sqrt(3)) / 2);
            float maPoleBoku = (float)((maOś_Duża / 4) * Math.Sqrt((5 / 4) * Math.Pow(maOś_Duża / 2, 2) + Math.Pow(maWysokość, 2)));
            this.maObjętośćBryły = (maPolePodstawy * maWysokość / 3);
            this.maPowierzchniaBryły = (6 * maPolePodstawy + maPoleBoku);
        }
    }
}
