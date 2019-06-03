using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;
using static Projekt3_Andrzejewski_48660.Andrzejewski;

namespace Projekt3_Andrzejewski_48660
{
    class maWalec : maBryłaAbstrakcyjna
    {
        public int maStopieńWielokątaPodstawy;
        float maOś_Duża, maOś_Mała;
        float maKątMiędztWierzchołkami, maKątPołożenia;
        Point[] maWielokątPodłogi;
        Point[] maWielokątSufitu;

        public maWalec(int maPromień, int maWysokość, int maStopieńWielokątaPodstawy, int maXŚrodekSufitu, int maYŚrodekSufitu, int maXŚrodekPodłogi, int maYŚrodekPodłogi, Color maKolor_Linii, DashStyle maStyl_Linii, int maGrubość_Linii) : base(maPromień, maKolor_Linii, maStyl_Linii, maGrubość_Linii)
        {
            maRodzajBryły = maTypBryły.ma_Walec;
            maWysokość = maWysokość;
            this.maStopieńWielokątaPodstawy = maStopieńWielokątaPodstawy;
            maOś_Duża = maPromień * 2;
            maOś_Mała = maPromień / 2;
            maXŚrodekPodłogi = maXŚrodekPodłogi;
            maYŚrodekPodłogi = maYŚrodekPodłogi;
            maXŚrodekSufitu = maXŚrodekSufitu;
            maYŚrodekSufitu = maYŚrodekSufitu - maWysokość;
            maGrubość_Linii = maGrubość_Linii;
            maStyl_linii = maStyl_linii;
            maKolor_linii = maKolor_linii;
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

             = (float)(Math.PI * Math.Pow(Promień, 2) * WysokośćBryły);
            PowierzchniaBryły = (float)(2 * Math.PI * Promień * (Promień + WysokośćBryły));
        }
    }
}
