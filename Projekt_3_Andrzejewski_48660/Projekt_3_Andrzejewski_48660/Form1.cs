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
using static Projekt_3_Andrzejewski_48660.maWalec;

namespace Projekt_3_Andrzejewski_48660
{
    public partial class Andrzejewski : Form
    {
        #region Przyciski Dynamiczne

        Button maBUTZmieńKolor;
        TextBox maLBLKierunekObrotu;
        TextBox maLBLNumerBryły;
        RadioButton maRBWLewo;
        RadioButton maRBObrótWPrawo;
        TextBox label2;
        TrackBar maTBPromieńFigury;
        TrackBar trackBar1;
        ComboBox maCBStylLinii;
        TrackBar maTBGrubośćLinii;
        TextBox label3;
        TextBox label1;
        TextBox label4;
        TextBox label5;
        #endregion



        public static Andrzejewski maUchwytFormularza;
        const int maMargines = 50;
        Color maKolorPióra = Color.Black;
        Pen maDługopis;
        DashStyle maStylLinii;
        List<Point> maListaPunktów;
        List<maBryłaAbstrakcyjna> maListaBrył = new List<maBryłaAbstrakcyjna>)();
        public static Graphics maRysownica;
        public enum maBryły
        {
            Stożek, Walec, Graniastosłup
        }

        public Andrzejewski()
        {
            InitializeComponent();
            maUchwytFormularza = this;
            maPicBoxRysownica.Image = new Bitmap(maPicBoxRysownica.Width, maPicBoxRysownica.Height);
            maRysownica = Graphics.FromImage(maPicBoxRysownica.Image);
            //zlokalizowanie formularza i zwymiarowanie
            this.Left = maMargines;
            this.Top = maMargines;
            this.Width = (int)(Screen.PrimaryScreen.Bounds.Width * 0.93F);
            this.Height = (int)(Screen.PrimaryScreen.Bounds.Height * 0.85F);
            this.StartPosition = FormStartPosition.Manual;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.SetAutoSizeMode(AutoSizeMode.GrowAndShrink);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.AutoScroll = true;
        }

        private void maPicBoxRysownica_Click(object sender, EventArgs e)
        {

        }

        private void maLBLKierunekObrotu_Click(object sender, EventArgs e)
        {

        }

        private void maBUTWłączSlajder_Click(object sender, EventArgs e)
        {
          

        private void maPicBoxRysownica_Paint(object sender, PaintEventArgs e)
        {
            foreach(maBryłaAbstrakcyjna maBryła in maListaBrył)
        }
    }
}
