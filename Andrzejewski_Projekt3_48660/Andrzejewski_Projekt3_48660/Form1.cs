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
using System.IO;
using static Andrzejewski_Projekt3_48660.maWalec;
using static Andrzejewski_Projekt3_48660.maStożek;
using static Andrzejewski_Projekt3_48660.maBryłaAbstrakcyjna;

namespace Andrzejewski_Projekt3_48660 
{
    public partial class Andrzejewski_48660 : Form
    {
        Random maRandom = new Random();
        bool maKierunekWPrawo = true;
        bool maKierunekWPrawoPanel = true;
        bool maifWybórKoloru = false;
        bool maAutomatyczny = true;
        bool maPokazSlajdów = false;
        public static Andrzejewski_48660 maUchwytFormularza;
        public static Color maKolorTła = Color.Aqua;
        const int maMargines = 50;
        Color maKolorPióra = Color.Black;
        List<maBryłaAbstrakcyjna> maListaBrył = new List<maBryłaAbstrakcyjna>();
        public static Graphics maRysownica;
        Point maPunktNaRysownicy = new Point(-1, -1);
        int maPromień, maWysokość, maStopieńWielokąta, maKątNachylenia;
        int maIndexFigury = 0;

        public Andrzejewski_48660()
        {
            InitializeComponent();
            DoubleBuffered = true;
            maUchwytFormularza = this;
            maPicBoxRysownica.Image = new Bitmap(maPicBoxRysownica.Width, maPicBoxRysownica.Height);
            maRysownica = Graphics.FromImage(maPicBoxRysownica.Image);
            //ustalenie wartości startowych
            maPromień = maTBPromień.Value;
            maWysokość = maTBWysokość.Value;
            maStopieńWielokąta = maTBStopieńWielokąta.Value;
            maKątNachylenia = maTBKątNachylenia.Value;
        }
      

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void maPicBoxRysownica_Click(object sender, EventArgs e)
        {

        }

        private void mapicWybórKoloru_MouseDown(object sender, MouseEventArgs e)
        {
            maifWybórKoloru = true;
        }

        private void mapicWybórKoloru_MouseUp(object sender, MouseEventArgs e)
        {
            maifWybórKoloru = false;
        }

        private void mapicWybórKoloru_MouseMove(object sender, MouseEventArgs e)
        {
            if (maifWybórKoloru)
            {
                Bitmap Rysownica = (Bitmap)mapicWybórKoloru.Image.Clone();
                maKolorPióra = Rysownica.GetPixel(e.X, e.Y);
                maTBred.Value = maKolorPióra.R;
                maTBGreen.Value = maKolorPióra.G;
                maTBblack.Value = maKolorPióra.B;
                maTBAlpha.Value = maKolorPióra.A;
                maTBR.Text = maKolorPióra.R.ToString();
                maTBG.Text = maKolorPióra.G.ToString();
                maTBB.Text = maKolorPióra.B.ToString();
                maTBA.Text = maKolorPióra.A.ToString();
                maPBKolor.BackColor = maKolorPióra;

            }
        }

        private void maWłączenieWszystkichPrzyciskówNaPanelu()
        {

            maTBPanelGrubośćLinii.Visible = true;
            maLBLPanelGrubośćLinii.Visible = true;
            maTBPanelWysokosć.Visible = true;
            maLBLPanelWysokość.Visible = true;
            maTBPanelPromień.Visible = true;
            maLBLPanelPromień.Visible = true;
            maBUTPanelKolor.Visible = true;
            maPanelKątNachylenia.Visible = true;
            label4.Visible = true;
            maBUTPanelKiereunekObrotu.Visible = true;
            panel1.Visible = true;

        }

        private void maWyłączenieWszystkichPrzyciskówNaPanelu()
        {

            maTBPanelGrubośćLinii.Visible = false;
            maLBLPanelGrubośćLinii.Visible = false;
            maTBPanelWysokosć.Visible = false;
            maLBLPanelWysokość.Visible = false;
            maTBPanelPromień.Visible = false;
            maLBLPanelPromień.Visible = false;
            maBUTPanelKolor.Visible = false;
            maPanelKątNachylenia.Visible = false;
            label4.Visible = false;
            maBUTPanelKiereunekObrotu.Visible = false;
            panel1.Visible = false;

        }
        private void maAktywacjaPrzyciskówPaneli()
        {
            maWłączenieWszystkichPrzyciskówNaPanelu();

            if (maListaBrył[maIndexFigury].maRodzajBryły == maBryłaAbstrakcyjna.maTypBryły.ma_Stożek)
            {

            }

        }

        private void mapicWybórKoloru_Click(object sender, EventArgs e)
        {
            

        }

        private void maPicBoxRysownica_Paint(object sender, PaintEventArgs e)
        {
            if (maPokazSlajdów && maListaBrył.Count > 0)
            {
                maRysownica.Clear(maKolorTła);
                maListaBrył[maIndexFigury].maPrzesuńDoNowegoXY(maPicBoxRysownica.Width / 2, maPicBoxRysownica.Height / 2);
                maListaBrył[maIndexFigury].maObróćIWykreśl(3);
            }
            else
                foreach (maBryłaAbstrakcyjna maBryła in maListaBrył)
                {//kreśli figurę wraz z animacją
                    maBryła.maObróćIWykreśl(3);
                }           
        }

        private void maBUTNowaBryła_Click(object sender, EventArgs e)
        {
            if(maPunktNaRysownicy.X != -1)
            {
                DashStyle maStylLinii = DashStyle.Dot;
                Color maKolorLinii = Color.Black;
                SolidBrush maRysowanie = new SolidBrush(maKolorTła);
                maRysownica.FillEllipse(maRysowanie, maPunktNaRysownicy.X - 5, maPunktNaRysownicy.Y - 5, 10, 10);
                switch(maCMBWybórBryły.SelectedIndex)
                {
                    case 0:
                        maWalec maWalec = new maWalec(maPromień, maWysokość, maStopieńWielokąta, maPunktNaRysownicy.X,
                            maPunktNaRysownicy.Y, maPunktNaRysownicy.X, maPunktNaRysownicy.Y + maWysokość,
                            maKolorLinii, maStylLinii, maRandom.Next(1, 4));
                        maListaBrył.Add(maWalec);
                        break;
                    case 1:
                        maStożek maStożek = new maStożek(maPromień, maWysokość, maStopieńWielokąta, maPunktNaRysownicy.X,
                            maPunktNaRysownicy.Y, maPunktNaRysownicy.X, maPunktNaRysownicy.Y + maWysokość,
                            maKolorLinii, maStylLinii, maRandom.Next(1, 4));
                        maListaBrył.Add(maStożek);
                        break;
                    case 2:
                        maStożekPochyły maStożekPochyły = new maStożekPochyły(maPromień, maWysokość, maStopieńWielokąta, maPunktNaRysownicy.X,
                            maPunktNaRysownicy.Y, maPunktNaRysownicy.X, maPunktNaRysownicy.Y + maWysokość,
                            maKolorLinii, maStylLinii, maRandom.Next(1, 4));
                        maListaBrył.Add(maStożekPochyły);
                        break;
                    case 3:
                         maOstrosłupCzworokątny maOstrosłupCzworokątny = new maOstrosłupCzworokątny(maPromień, maWysokość, maStopieńWielokąta, maPunktNaRysownicy.X,
                            maPunktNaRysownicy.Y, maPunktNaRysownicy.X, maPunktNaRysownicy.Y + maWysokość,
                            maKolorLinii, maStylLinii, maRandom.Next(1, 4));
                        maListaBrył.Add(maOstrosłupCzworokątny);
                        break;
                    case 4:
                        maOstrosłupSześciokątny maOstrosłupSześciokątny = new maOstrosłupSześciokątny(maPromień, maWysokość, maStopieńWielokąta, maPunktNaRysownicy.X,
                           maPunktNaRysownicy.Y, maPunktNaRysownicy.X, maPunktNaRysownicy.Y + maWysokość,
                           maKolorLinii, maStylLinii, maRandom.Next(1, 4));
                        maListaBrył.Add(maOstrosłupSześciokątny);
                        break;
                    case 5:
                        maGraniastosłupSześciokątny maGraniastosłupSześciokątny = new maGraniastosłupSześciokątny(maPromień, maWysokość, 4, maPunktNaRysownicy.X, maPunktNaRysownicy.Y, maPunktNaRysownicy.X, maPunktNaRysownicy.Y + maWysokość,
                            maKolorLinii, maStylLinii, maRandom.Next(1, 4));
                        maListaBrył.Add(maGraniastosłupSześciokątny);
                        break;
                    case 6:
                        GraniastosłupTrójkątny GraniastosłupTrójkątny = new GraniastosłupTrójkątny(maPromień, maWysokość, 4, maPunktNaRysownicy.X, maPunktNaRysownicy.Y, maPunktNaRysownicy.X, maPunktNaRysownicy.Y + maWysokość,
                            maKolorLinii, maStylLinii, maRandom.Next(1, 4));
                        maListaBrył.Add(GraniastosłupTrójkątny);
                        break;
                }
                if (maKierunekWPrawo)
                    maListaBrył[maListaBrył.Count - 1].maKierunekWPrawi();
                else
                    maListaBrył[maListaBrył.Count - 1].maKierunekWLewo();
            }
        }

        private void maBUTKierunekWLewo_Click(object sender, EventArgs e)
        {
            foreach (maBryłaAbstrakcyjna maBryła in maListaBrył)
                maBryła.maKierunekWLewo();
        }

        private void maBUTKierunekWPrawo_Click(object sender, EventArgs e)
        {
            foreach (maBryłaAbstrakcyjna maBryła in maListaBrył)
                maBryła.maKierunekWPrawi();
        }

        private void maNUMStopień_ValueChanged(object sender, EventArgs e)
        {
        }

        private void maBUTWłączenieSlajdera_Click(object sender, EventArgs e)
        {
            if(maListaBrył.Count > 0)
            {
                maIndexFigury = 0;
                maTXTBOXIndexFigury.Text = "0";
                maRysownica.Clear(Color.Aqua);
                if(!maPokazSlajdów)
                {
                    if(pwRadioButtonRęcznie.Checked)
                    {
                        maBUTFiguraNastępna.Enabled = true;
                        maBUTFiguraPoprzednia.Enabled = true;
                        maBUTNoweAtrybuty.Enabled = true;
                    }
                }
                else
                {
                    foreach (maBryłaAbstrakcyjna maBryła in maListaBrył)
                        maBryła.maPrzesuńDoNowegoXY(maRandom.Next(0, maPicBoxRysownica.Width - 30), maRandom.Next(0, maPicBoxRysownica.Height - 30));
                }
            }
        }

        private void pwRadioButtonRęcznie_CheckedChanged(object sender, EventArgs e)
        {
            if(maPokazSlajdów)
            {
                maBUTFiguraNastępna.Enabled = true;
                maBUTFiguraPoprzednia.Enabled = true;
                maBUTNoweAtrybuty.Enabled = true;
            }
            maAutomatyczny = false;
        }

        private void maTBWysokość_Scroll(object sender, EventArgs e)
        {
            maWysokość = maTBWysokość.Value;
        }

        private void maTBStopieńWielokąta_Scroll(object sender, EventArgs e)
        {
            maStopieńWielokąta = maTBStopieńWielokąta.Value;
        }

        private void maTBKątNachylenia_Scroll(object sender, EventArgs e)
        {
            maKątNachylenia = maTBKątNachylenia.Value;
        }

        private void maTimerObrotów_Tick(object sender, EventArgs e)
        {
            Refresh();
            maPicBoxRysownica.BackColor = maKolorTła;
            if(maListaBrył.Count > 0 )
            {
                
            }
        }

        private void maTBGreen_Scroll(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void maBUTNoweAtrybuty_Click(object sender, EventArgs e)
        {

        }

        private void maBUTFiguraNastępna_Click(object sender, EventArgs e)
        {

        }

        private void maBUTFiguraPoprzednia_Click(object sender, EventArgs e)
        {

        }

        private void maTXTBOXIndexFigury_TextChanged(object sender, EventArgs e)
        {

        }

        private void maLBLIndexFigury_Click(object sender, EventArgs e)
        {

        }

        private void pwRadioButtonAuto_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void maTBA_TextChanged(object sender, EventArgs e)
        {

        }

        private void maTBG_TextChanged(object sender, EventArgs e)
        {

        }

        private void maTBR_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maTBAlpha_Scroll(object sender, EventArgs e)
        {

        }

        private void maTBblack_Scroll(object sender, EventArgs e)
        {

        }

        private void maTBB_TextChanged(object sender, EventArgs e)
        {

        }

        private void maTBred_Scroll(object sender, EventArgs e)
        {

        }

        private void maPBKolor_Click(object sender, EventArgs e)
        {

        }

        private void maLBLNachylenie_Click(object sender, EventArgs e)
        {

        }

        private void maLBLStopień_Click(object sender, EventArgs e)
        {

        }

        private void maLBLStopieńWielokąta_Click(object sender, EventArgs e)
        {

        }

        private void maLBLWysokość_Click(object sender, EventArgs e)
        {

        }

        private void maLBLPromień_Click(object sender, EventArgs e)
        {

        }

        private void maCMBWybórBryły_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maLBLWybórFigury_Click(object sender, EventArgs e)
        {

        }

        private void maLBLPanelGrubośćLinii_Click(object sender, EventArgs e)
        {
            Refresh(); //odświerzenie wszystkiego
            maPicBoxRysownica.BackColor = maKolorTła; //zmiana koloru tła rysownicy
            if (maListaBrył.Count > 0)
            { //potrzebne dla ustalenia maximum trackBaru usunięcia figury o indexie
               // pwTrackBarUsuńWybranąFigurę.Maximum = LBG_Wielogórski49141.Count - 1;
            }
        }

        private void maPicBoxRysownica_MouseClick(object sender, MouseEventArgs e)
        {
            SolidBrush maRysowanie = new SolidBrush(Color.Red);
            maRysownica.FillEllipse(maRysowanie, maPunktNaRysownicy.X - 5, maPunktNaRysownicy.Y - 5, 20, 20);
            maPunktNaRysownicy = new Point(e.Location.X, e.Location.Y);
            maRysownica.FillEllipse(Brushes.Red, maPunktNaRysownicy.X - 5, maPunktNaRysownicy.Y - 5, 10, 10);
        }

        private void maTBPromień_Scroll(object sender, EventArgs e)
        {
            maPromień = maTBPromień.Value;
        }
    }
}
