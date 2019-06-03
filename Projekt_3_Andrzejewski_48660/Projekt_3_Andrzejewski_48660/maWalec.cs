using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;
using static Projekt_3_Andrzejewski_48660.Andrzejewski;
using static Projekt_3_Andrzejewski_48660.maBryłaAbstrakcyjna;

namespace Projekt_3_Andrzejewski_48660
{
    class maWalec : maBryłaAbstrakcyjna
    {
        public int maStopieńWielokątaPodstawy;
        float maOś_Duża, maOś_Mała;
        float maKątMiędzyWierzchołkami, maKątPołożenia;
        Point[] maWielokątPodłogi;
        Point[] maWielokątSufitu;

        public maWalec(int maPromień, int maWysokość, int maStopieńWielokątaPodstawy, int maXŚrodekSufitu, int maYŚrodekSufitu, int maXŚrodekPodłogi, int maYŚrodekPodłogi, Color maKolorLinii, DashStyle maStylLinii, int maGrubośćLinii) : base(maPromień, maKolorLinii, maStylLinii, maGrubośćLinii)
        {
            this.maRodzajBryły = maTypBryły.ma_Walec;
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

            maWielokątPodłogi = new Point[maStopieńWielokątaPodstawy + 1];
            maWielokątSufitu = new Point[maStopieńWielokątaPodstawy + 1];

            for (int i = 0; i <= maStopieńWielokątaPodstawy; i++)
            {
                maWielokątPodłogi[i].X = maWielokątPodłogi[i].X;
                maWielokątPodłogi[i].Y = maWielokątPodłogi[i].Y - maWysokość;

                maWielokątPodłogi[i].X = (int)(this.maXŚrodekPodłogi + (maOś_Duża / 2) * Math.Cos(Math.PI * (maKątPołożenia + i * maKątMiędzyWierzchołkami) / 180));
                maWielokątPodłogi[i].Y = (int)(this.maXŚrodekPodłogi + (maOś_Duża / 2) * Math.Sin(Math.PI * (maKątPołożenia + i * maKątMiędzyWierzchołkami) / 180));
                maWielokątSufitu[i] = new Point();
                maWielokątSufitu[i] = new Point();
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
            maRysownica.DrawEllipse(maDługopis, this.maXŚrodekSufitu - this.maOś_Duża / 2, this.maYŚrodekSufitu - this.maOś_Mała / 2, this.maOś_Duża, this.maOś_Mała);

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
            Pen maDługopis = new Pen(Color.White, this.maGrubość_linii);
            maDługopis.DashStyle = this.maStyl_linii;

            maRysownica.DrawEllipse(maDługopis, this.maXŚrodekPodłogi - this.maOś_Duża / 2, this.maYŚrodekPodłogi - this.maOś_Mała / 2, this.maOś_Duża, this.maOś_Mała);
            maRysownica.DrawEllipse(maDługopis, this.maXŚrodekSufitu - this.maOś_Duża / 2, this.maYŚrodekSufitu - this.maOś_Mała / 2, this.maOś_Duża, this.maOś_Mała);

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
                maWielokątPodłogi[i] = new Point();
                maWielokątSufitu[i] = new Point();

                maWielokątPodłogi[i].X = maWielokątPodłogi[i].X;
                maWielokątPodłogi[i].Y = maWielokątPodłogi[i].Y - maWysokość;

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
            maStopieńWielokątaPodstawy = maStopień;
            maKątMiędzyWierzchołkami = 360 / maStopień;
            this.maKątPołożenia = 0f;
            //utworzenie egzemplarzy dla tablic wierzchołków wielokąta podłogi
            this.maWielokątPodłogi = new Point[maStopień];
            this.maWielokątSufitu = new Point[maStopień];
            //utworzenie egzemlarzy punktów wierzchołków wielokąta podłogi
            //wyznaczenie współrzędnych wierzchołków wielokąta podłogi
            for (int i = 0; i < maStopień; i++)
            {
                maWielokątPodłogi[i] = new Point();
                maWielokątPodłogi[i].X = (int)(this.maXŚrodekPodłogi + (maOś_Duża / 2) * Math.Cos(Math.PI * (maKątPołożenia + i * maKątMiędzyWierzchołkami) / 180));
                maWielokątPodłogi[i].Y = (int)(this.maXŚrodekPodłogi + (maOś_Duża / 2) * Math.Sin(Math.PI * (maKątPołożenia + i * maKątMiędzyWierzchołkami) / 180));
            }
        }
        public override void maUstawKątNachyleniaStożka(int X) { /*pusta implementacja */ }
        public override void maObliczeniePolaObjętościItp()
        {
            //obliczenie objętości i pola powierzchni figury
            float maPolePodstawy = (float)(Math.PI * Math.Pow(maOś_Duża / 2, 2));
            float maPoleBoku = (float)(2 * Math.PI * maOś_Duża / 2 * maWysokość);
            this.maObjętośćBryły = maPolePodstawy * maWysokość;
            this.maPowierzchniaBryły = (2 * maPolePodstawy + maPoleBoku);
        }


    }
}
