using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Andrzejewski_Projekt3_48660.Andrzejewski_48660;
using static Andrzejewski_Projekt3_48660.maBryłaAbstrakcyjna;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace Andrzejewski_Projekt3_48660
{
    class maStożekPochyły : maWielościany
    {
        float maOś_Duża, maOś_Mała;
        int maKątNachylenia;
        float maKątMiędzyWierzchołkami, maKątPołożenia;
        Point[] maWielokątPodłogi;
        Point maWielokątSufitu;
        int maZmiennaPomocnicza;

        public maStożekPochyły(int maPromień, int maWysokość, int maStopieńWielokątaPodstawy, int maXŚrodekSufitu, int maYŚrodekSufitu, int maXŚrodekPodłogi, int maYŚrodekPodłogi, Color maKolorLinii, DashStyle maStylLinii, int maGrubośćLinii) : base(maPromień, maKolorLinii, maStylLinii, maGrubośćLinii)
        {
            maZmiennaPomocnicza = maXŚrodekPodłogi;
            this.maRodzajBryły = maTypBryły.ma_StożekPochyły;
            this.maWysokość = maWysokość;
            this.maStopieńWielokątaPodstawy = maStopieńWielokątaPodstawy;
            this.maOś_Duża = this.maPromień * 2;
            this.maOś_Mała = this.maPromień / 2;
            this.maXŚrodekPodłogi = maXŚrodekPodłogi;
            this.maYŚrodekPodłogi = maYŚrodekPodłogi;
            this.maXŚrodekSufitu = maXŚrodekSufitu;
            this.maYŚrodekSufitu = maYŚrodekSufitu - maWysokość;
            maKątMiędzyWierzchołkami = 360 / maStopieńWielokątaPodstawy;
            maKątPołożenia = 0f;
            maKątNachylenia = Math.Abs(maXŚrodekPodłogi - maXŚrodekSufitu);
            maWielokątPodłogi = new Point[maStopieńWielokątaPodstawy];

            for (int i = 0; i < maStopieńWielokątaPodstawy; i++)
            {
                maWielokątPodłogi[i] = new Point();

                maWielokątPodłogi[i].X = (int)(this.maXŚrodekPodłogi + (maOś_Duża / 2) * Math.Cos(Math.PI * (maKątPołożenia + i * maKątMiędzyWierzchołkami) / 180));
                maWielokątPodłogi[i].Y = (int)(this.maXŚrodekPodłogi + (maOś_Duża / 2) * Math.Sin(Math.PI * (maKątPołożenia + i * maKątMiędzyWierzchołkami) / 180));

            }

            float maPolePodstawy = (float)(Math.PI * Math.Pow(maOś_Duża / 2, 2));
            float maPoleBoku = (float)(2 * Math.PI * maOś_Duża / 2 * maWysokość);
            this.maObjętośćBryły = maPolePodstawy * maWysokość;
            this.maPowierzchniaBryły = (2 * maPolePodstawy + maPoleBoku);
        }

        public override void maWykreśl()
        {
            Pen maDługopis = new Pen(this.maKolor_linii, this.maGrubość_linii);
            maDługopis.DashStyle = this.maStyl_linii;
            maRysownica.DrawEllipse(maDługopis, this.maXŚrodekPodłogi - this.maOś_Duża / 2, this.maYŚrodekPodłogi - this.maOś_Mała / 2, this.maOś_Duża, this.maOś_Mała);

            maRysownica.DrawLine(maDługopis, maXŚrodekPodłogi + maOś_Duża / 2, maYŚrodekPodłogi, maXŚrodekSufitu , maYŚrodekSufitu);
            maRysownica.DrawLine(maDługopis, maXŚrodekPodłogi - maOś_Duża / 2, maYŚrodekPodłogi, maXŚrodekSufitu , maYŚrodekSufitu);

            for (int i = 0; i <= maStopieńWielokątaPodstawy; i++)
            {
                maRysownica.DrawLine(maDługopis, maWielokątSufitu, maWielokątPodłogi[i]);
            }
            maDługopis.Dispose();
        }
        public override void maWymaż()
        {
            //utworzenie pióra
            Pen maPióro = new Pen(Color.Aqua, this.maGrubość_linii);
            maPióro.DashStyle = this.maStyl_linii;
            //wykreślenie podłogi
            for (int pwi = 0; pwi < maWielokątPodłogi.Length - 1; pwi++)
                maRysownica.DrawLine(maPióro, maWielokątPodłogi[pwi], maWielokątPodłogi[pwi + 1]);

            //wykreślenie krawędzi bocznych ostrosłupa
            for (int pwi = 0; pwi < maStopieńWielokątaPodstawy; pwi++)
                maRysownica.DrawLine(maPióro, maWielokątPodłogi[pwi], new Point(maXŚrodekSufitu, maYŚrodekSufitu));
            //zwolninie pióra
            maPióro.Dispose();
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
            this.maXŚrodekPodłogi = maX;
            this.maYŚrodekPodłogi = maY;
            this.maXŚrodekSufitu = maX;
            this.maYŚrodekSufitu = maY + maWysokość;

            for (int i = 0; i <= maStopieńWielokątaPodstawy; i++)
            {

                maWielokątPodłogi[i].X = (int)(this.maXŚrodekPodłogi + (maOś_Duża / 2) * Math.Cos(Math.PI * (maKątPołożenia + i * maKątMiędzyWierzchołkami) / 180F));
                maWielokątPodłogi[i].Y = (int)(this.maXŚrodekPodłogi + (maOś_Duża / 2) * Math.Sin(Math.PI * (maKątPołożenia + i * maKątMiędzyWierzchołkami) / 180F));
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
            maStopieńWielokątaPodstawy = maStopień;
            maKątMiędzyWierzchołkami = 360 / maStopień;
            this.maKątPołożenia = 0f;
            //utworzenie egzemplarzy dla tablic wierzchołków wielokąta podłogi
            this.maWielokątPodłogi = new Point[maStopień +1];
            //utworzenie egzemlarzy punktów wierzchołków wielokąta podłogi
            //wyznaczenie współrzędnych wierzchołków wielokąta podłogi
            for (int i = 0; i < maStopień; i++)
            {
                maWielokątPodłogi[i] = new Point();
                maWielokątPodłogi[i].X = (int)(this.maXŚrodekPodłogi + (maOś_Duża / 2) * Math.Cos(Math.PI * (maKątPołożenia + i * maKątMiędzyWierzchołkami) / 180F));
                maWielokątPodłogi[i].Y = (int)(this.maXŚrodekPodłogi + (maOś_Duża / 2) * Math.Sin(Math.PI * (maKątPołożenia + i * maKątMiędzyWierzchołkami) / 180F));
            }
        }
        public override void maUstawKątNachyleniaStożka(int maX)
        {
            maXŚrodekPodłogi = -maX + maZmiennaPomocnicza + 90;
            maKątNachylenia = Math.Abs(maXŚrodekPodłogi - maXŚrodekSufitu);
        }
        public override void maObliczeniePolaObjętościItp()
        {
            //obliczenie objętości i pola powierzchni figury
            float maPolePodstawy = (float)(Math.PI * Math.Pow(maOś_Duża / 2, 2));
            float maPoleBoku = (float)(Math.Sqrt(Math.Pow(maWysokość, 2) + Math.Pow(maOś_Duża / 2, 2)));
            this.maObjętośćBryły = (maPolePodstawy * maWysokość / 3);
            this.maPowierzchniaBryły = maPolePodstawy + maPoleBoku;
        }

    }
}
