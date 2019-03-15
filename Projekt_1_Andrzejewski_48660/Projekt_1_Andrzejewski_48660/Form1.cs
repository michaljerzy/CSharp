﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Projekt_1_Andrzejewski_48660
{
    public partial class Andrzejewski : Form
    {
        float maIndexPołożeniaKulek = 0.0F;
        int maPromieńKulki = 5;
        Brush maKolorKulki = Brushes.LightGray;
        Graphics maWykresOsi;
        Pen maPióro;
        Pen maPióro2;
        float maXmax, maYmax;
        // Color myResult = Color.AliceBlue;
        Brush maKolorLinii = Brushes.LightGray;
        DashStyle maStylLiniOsi = DashStyle.Solid;
        float maGrubośćPióra2 = 3F;
        PointF[] maPunktyWykresu = new PointF[199];
        float maGrubośćOsi = 2F;

        internal static FormKolor form2 = new FormKolor();

        public Andrzejewski()
        {
            InitializeComponent();
            //lokalizacja i zwymiarowanie formularza
            Location = new Point(20, 20);
            Width = (int)(Screen.PrimaryScreen.Bounds.Height * 1.6);
            Height = (int)(Screen.PrimaryScreen.Bounds.Height * 1.2);
            StartPosition = FormStartPosition.Manual;
            //zablokowanie zmiany rozmiarów formularza
            SetAutoSizeMode(AutoSizeMode.GrowAndShrink);
            //lokalizacja i zwymiarowanie kontrolki PictureBox
            maPicBox.Location = new Point(Left + 10, Top + 30);
            maPicBox.Width = (int)(Width * 0.7F);
            maPicBox.Height = (int)(Height * 0.8F);
            //ustawienie koloru tła
            //maPicBox.BackColor = mabutKolorTła.BackColor;
            //utworzenie bitmapy
            maPicBox.Image = new Bitmap(maPicBox.Width, maPicBox.Height);
            //utworzenie egzemplarza powierzchni graficznej na bit mapie
            maWykresOsi = Graphics.FromImage(maPicBox.Image);

            matbSzybkoscKulki.Text = Convert.ToString(matbSzybkoscKulki.Value);


            maPióro = new Pen(Color.White, 1F);
            maPióro.DashStyle = DashStyle.Dash;
            //sformatowanie pióra dla wykreślenia osi układu współrzędnych
            maPióro.EndCap = LineCap.Flat;
            //utworzenie większego grotu strzałek
            AdjustableArrowCap DużyGrotStrzałki = new AdjustableArrowCap(5, 10);
            maPióro.CustomEndCap = DużyGrotStrzałki;

            // określenie parametrów
            maXmax = maPicBox.Width;
            maYmax = maPicBox.Height;
            timer1.Interval = 1;
        }

        private void Andrzejewski_Paint(object sender, PaintEventArgs e)
        {
            maPicBox.Refresh();
            //utworzenie egzemplarza pióra
            maPióro = new Pen(maKolorLinii, maGrubośćOsi);
            //ustawienie atrybutów pióra
            maPióro.DashStyle = DashStyle.Dash;
            //ustawienie zakończeń linii osi układu współrzędnych
            maPióro.StartCap = LineCap.ArrowAnchor;
            //ustawienie osi układu współrzędnych
            maWykresOsi.DrawLine(maPióro, (int)(Width * 0.02), maYmax / 1.5F, maXmax - (int)(Width * 0.02F), maYmax / 1.5F);
            maWykresOsi.DrawLine(maPióro, maXmax / 2, maYmax - (int)(Height * 0.04), maXmax / 2, (int)(Height * 0.04));

            maPióro2 = new Pen(maKolorLinii, maGrubośćPióra2);
            string maStylLinii;

            float maj = -1;
            for (int mai = 0; mai < 199; mai++)
            {
                if (maj > -1 && mai % 5 == 0)
                    maWykresOsi.DrawLine(maPióro2, maPunktyWykresu[mai - 5], maPunktyWykresu[mai]);
                maj += 0.01f;
            }
            //wykreślenie kulek na torze 
            maWykresOsi.FillEllipse(maKolorKulki, maPunktyWykresu[(int)maIndexPołożeniaKulek].X - 10,
                maPunktyWykresu[(int)maIndexPołożeniaKulek].Y - maPromieńKulki, 2 * maPromieńKulki, 2 * maPromieńKulki);
        }

        private void maRysujBut_Click(object sender, EventArgs e)
        {
            mapictureBox1.Visible = false;
            timer1.Enabled = true;
            float maj = -1;
            for (int mai = 0; mai < 199; mai++)
            {

                float maw; //dla przechowywania wartości n-tego wyrazu szeregu
                float maSumaSzeregu = 0.0f; //ustalenie początkowego stanu obliczeń
                maw = maj; //nadanie w wartość zmiennej X 
                int maN = 1;
                while (Math.Abs(maw) >= 0.000001f) //sprawdzenie czy moduł z w jest większy od Eps
                {
                    maSumaSzeregu += maw; //dodawanie do sumy szeregu w
                    maN++; //zwiększenie licznika zsumowanych wyrazów szeregu N o jeden
                    maw *= (float)Math.Sqrt(maN * (maN - 1)) * maj / maN; //obliczanie an (nasze w)
                }
                maPunktyWykresu[mai] = new PointF((maj * maPicBox.Width / 4) + maPicBox.Width / 2.25f,
                    -(maSumaSzeregu * maPicBox.Height / 12) + maYmax - maPicBox.Height / 3.25f);
                maj += 0.01f;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (maIndexPołożeniaKulek < 185)
            {

                maIndexPołożeniaKulek += 3;
                //zamalowanie tła kolorem tła w celu usunięcia śladów "Pena"
                maWykresOsi.Clear(matbZaciemnienie.BackColor);
            }
            else //dodano aby obiekt poruszający się zwolnił pod konie wykresu (inaczej zbyt mocno przyszpiesza)
                if (maIndexPołożeniaKulek < 195)
            {
                maIndexPołożeniaKulek += 1;
                //zamalowanie tła kolorem tła w celu usunięcia śladów "Pena"
                maWykresOsi.Clear(matbZaciemnienie.BackColor);
            }
            else
                maIndexPołożeniaKulek = 0;
            Refresh();

        }

        private void matbSzybkoscKulki_Scroll(object sender, EventArgs e)
        {
            maTBPredkosc.Text = Convert.ToString(matbSzybkoscKulki.Value);
            timer1.Interval = 200 - 3 * matbSzybkoscKulki.Value;
            Refresh();
        }

        private void mabutStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void mabutKolorKulki_Click(object sender, EventArgs e)
        {

        }

        private void maTBPredkosc_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mabutKolorTła_Click(object sender, EventArgs e)
        {
            macolorDialog1.ShowDialog();
            maPicBox.BackColor = macolorDialog1.Color;
            //Refresh();

        }
        string kolor;
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        public void mabutKolorLinii_Click(object sender, EventArgs e)
        {
            macolorDialog1.ShowDialog();
            maKolorLinii = new SolidBrush(macolorDialog1.Color);
            //Refresh();
        }

        private void butCzerwony_Click(object sender, EventArgs e)
        {

        }
        

        public void butkolory_Click(object sender, EventArgs e)
        {
            macolorDialog1.ShowDialog();
            maKolorKulki = new SolidBrush(macolorDialog1.Color); 
        }

        private void matbZaciemnienie_Scroll(object sender, EventArgs e)
        {
            if (matbZaciemnienie.Value == 8)
            {
                BackColor = Color.FromArgb(62, 65, 65);
            }
            if (matbZaciemnienie.Value == 7)
            {
                BackColor = Color.FromArgb(82, 85, 85);
            }
            if (matbZaciemnienie.Value == 6)
            {
                BackColor = Color.FromArgb(102, 105, 105);
            }
            if (matbZaciemnienie.Value == 5)
            {
                BackColor = Color.FromArgb(122, 125, 125);
            }
            if (matbZaciemnienie.Value == 4)
            {
                BackColor = Color.FromArgb(152, 155, 155);
            }
            if (matbZaciemnienie.Value == 3)
            {
                BackColor = Color.FromArgb(172, 175, 175);
            }
            if (matbZaciemnienie.Value == 2)
            {
                BackColor = Color.FromArgb(192, 195, 195);
            }
            if (matbZaciemnienie.Value == 1)
            {
                BackColor = Color.FromArgb(212, 215, 215);
            }
            if (matbZaciemnienie.Value == 0)
            {
                BackColor = Color.FromArgb(232, 235, 235);
            }
        }

        private void matbGruboscKulki_Scroll(object sender, EventArgs e)
        {
            //matbGruboscKulki2.Value = maPromieńKulki;
            
        }

        private void maTBWielkoscKulki_Scroll(object sender, EventArgs e)
        {
            if(maTBWielkoscKulki.Value == 5)
                maPromieńKulki = 5;
            if (maTBWielkoscKulki.Value == 6)
                maPromieńKulki = 6;
            if (maTBWielkoscKulki.Value == 7)
                maPromieńKulki = 7;
            if (maTBWielkoscKulki.Value == 8)
                maPromieńKulki = 8;
            if (maTBWielkoscKulki.Value == 9)
                maPromieńKulki = 9;
            if (maTBWielkoscKulki.Value == 10)
                maPromieńKulki = 10;
            if (maTBWielkoscKulki.Value == 11)
                maPromieńKulki = 11;
            if (maTBWielkoscKulki.Value == 12)
                maPromieńKulki = 12;
            if (maTBWielkoscKulki.Value == 13)
                maPromieńKulki = 13;
            if (maTBWielkoscKulki.Value == 14)
                maPromieńKulki = 14;
            if (maTBWielkoscKulki.Value == 15)
                maPromieńKulki = 15;
        }

        private void Andrzejewski_Load(object sender, EventArgs e)
        {
            //zlokalizowanie kontrolek
            maRysujBut.Location = new Point(maRysujBut.Location.X + (int)(Height * 0.5), maRysujBut.Location.Y + (int)(Height * 0.04));
            matbSzybkoscKulki.Location = new Point(maRysujBut.Location.X ,maRysujBut.Location.Y + (int)(Height * 0.2));
            malblPredkosc.Location = new Point(matbSzybkoscKulki.Location.X + (int)(Height * 0.02), matbSzybkoscKulki.Location.Y - (int)(Height * 0.02));
            maTBPredkosc.Location = new Point(matbSzybkoscKulki.Location.X, matbSzybkoscKulki.Location.Y + (int)(Height * 0.08));
            mabutStop.Location = new Point(maTBPredkosc.Location.X, maTBPredkosc.Location.Y + (int)(Height * 0.08));
            mabutKolorLinii.Location = new Point(mabutStop.Location.X, mabutStop.Location.Y + (int)(Height * 0.09));
            butkolory.Location = new Point(maRysujBut.Location.X, maRysujBut.Location.Y + (int)(Height * 0.09));
            matbZaciemnienie.Location = new Point(maPicBox.Location.X, maPicBox.Location.Y + (int)(Height * 0.01));
            malblJasnosc.Location = new Point(matbZaciemnienie.Location.X + (int)(Height * 0.03), matbZaciemnienie.Location.Y + (int)(Height * 0.05));
            lblGruboscKulki.Location = new Point(mabutKolorLinii.Location.X + (int)(Height * 0.02), mabutKolorLinii.Location.Y + (int)(Height * 0.09));
            
        }
    }
}
