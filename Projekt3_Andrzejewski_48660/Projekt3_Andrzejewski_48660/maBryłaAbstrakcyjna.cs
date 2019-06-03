using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using static Projekt3_Andrzejewski_48660;

namespace Projekt3_Andrzejewski_48660
{
    abstract class maBryłaAbstrakcyjna
    {
        public enum maTypBryły
        {
            ma_Walec, ma_WalecPochyły, ma_Stożek, ma_StożekPochyły,
            ma_Kula, ma_Ostrosłup, ma_OstrosłupPochyły, ma_Graniastosłup, ma_GraniastosłupPochyły
        };

        public maTypBryły maRodzajBryły;
        protected int maXŚrodekSufitu, maYŚrodekSufitu;
        protected int maXŚrodekPodłogi, maYŚrodekPodłogi;
        protected int maKątPochylenia, maXf, maXc;
        protected int maWysokość;
        protected int maPromień;
        protected int maGrubość_Linii;
        protected Color maKolor_linii;
        protected DashStyle maStyl_linii;
        protected bool maKierunekObratu;
        protected float maPowierzchniaBryły;
        protected float maObjętośćBryły;

    }
}
