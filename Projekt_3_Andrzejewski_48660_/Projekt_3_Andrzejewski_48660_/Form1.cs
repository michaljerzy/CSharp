using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using static Projekt_3_Andrzejewski_48660_.maBryłaAbstrakcyjna;
using static Projekt_3_Andrzejewski_48660_.maWalec;


namespace Projekt_3_Andrzejewski_48660_
{
    public partial class Andrzejewski : Form
    {
        bool maKierunekWPrawo = true;
        bool ifWybórKoloru = false;
        public static Andrzejewski maUchwytFormularza;
        const int maMargines = 50;
        Color maKolorPióra = Color.Black;
        Pen maDługopis;
        DashStyle maStylLinii;
        List<Point> maListaPunktów;
        List<maBryłaAbstrakcyjna> maListaBrył = new List<maBryłaAbstrakcyjna>();
        public static Graphics maRysownica;
        Point maPunktNaRysownicy = new Point(-1, -1);
        public enum maBryły
        {
            Stożek, Walec, Graniastosłup
        }

        public Andrzejewski()
        {
            
            InitializeComponent();
            DoubleBuffered = true;
            maUchwytFormularza = this;
            maPicBoxRysownica.Image = new Bitmap(maPicBoxRysownica.Width, maPicBoxRysownica.Height);
            maRysownica = Graphics.FromImage(maPicBoxRysownica.Image);
        }
    }
}
