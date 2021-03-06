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
        //deklaracja zmiennych

        float maIndexPołożeniaKulek = 0.0F;
        int maPromieńKulki = 5;
        Brush maKolorKulki = Brushes.LightGray;
        Graphics maWykresOsi;
        Graphics chuj;
        Pen maPióro;
        Pen maPióro2;
        Pen PenChuj;
        float maXmax, maYmax;
        Brush maKolorLinii = Brushes.LightGray;
        Font maCzcionka = new Font("Times New Roman", 10, FontStyle.Bold);
        DashStyle maStylLiniOsi;        
        DashStyle maStylLiniWykresu;
        float maGrubośćPióra2 = 3F;
        PointF[] maPunktyWykresu = new PointF[199];
        float maGrubośćOsi = 2F;
        int maSzybkosckulki;
        

        public Andrzejewski()
        {
            InitializeComponent();
            //lokalizacja i zwymiarowanie formularza
            Location = new Point(20, 20);
            Width = (int)(Screen.PrimaryScreen.Bounds.Height * 1.7);
            Height = (int)(Screen.PrimaryScreen.Bounds.Height * 1);
            StartPosition = FormStartPosition.Manual;
            //zablokowanie zmiany rozmiarów formularza
            SetAutoSizeMode(AutoSizeMode.GrowAndShrink);
            //lokalizacja i zwymiarowanie kontrolki PictureBox
            maPicBox.Location = new Point(Left + 10, Top + 30);
            maPicBox.Width = (int)(Width * 0.7F);
            maPicBox.Height = (int)(Height * 0.8F);
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            chuj = Graphics.FromImage(pictureBox1.Image);
            
            //utworzenie bitmapy
            maPicBox.Image = new Bitmap(maPicBox.Width, maPicBox.Height);
            //utworzenie egzemplarza powierzchni graficznej na bit mapie
            maWykresOsi = Graphics.FromImage(maPicBox.Image);
            //przekonwertowanie wartości zsówaka na typ string
            matbSzybkoscKulki.Text = Convert.ToString(matbSzybkoscKulki.Value);
            //utworzenie egzemplarza pióra 
            maPióro = new Pen(Color.White, 1F);
            //nadanie rodzaju kreski dla pióra
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
            //odświerzenie picbox
            maPicBox.Refresh();
            //utworzenie egzemplarza pióra
            maPióro = new Pen(maKolorLinii, maGrubośćOsi);
            //ustawienie atrybutów pióra
            maPióro.DashStyle = maStylLiniOsi;
            //ustawienie zakończeń linii osi układu współrzędnych
            maPióro.StartCap = LineCap.ArrowAnchor;
            //ustawienie osi układu współrzędnych
            maWykresOsi.DrawLine(maPióro, (int)(Width * 0.02), maYmax / 1.5F, maXmax - (int)(Width * 0.02F), maYmax / 1.5F);
            maWykresOsi.DrawLine(maPióro, maXmax / 2, maYmax - (int)(Height * 0.04), maXmax / 2, (int)(Height * 0.04));
            //utworzenie egzemplarza pióra2
            maPióro2 = new Pen(maKolorLinii, maGrubośćPióra2);
            //ustawienie atrybutów dla pióra2
            maPióro2.DashStyle = maStylLiniWykresu;
            //obliczenie oraz wyznaczenie punktów wykrresu

            //PenChuj = new Pen();
            
            float maj = -1;
            for (int mai = 0; mai < 199; mai++)
            {
                if (maj > -1 && mai % 5 == 0)
                    chuj.DrawImage(chuj, maPunktyWykresu[mai - 5], maPunktyWykresu[mai]);
                maj += 0.01f;
            }
            //wykreślenie kulek na torze 
            //maWykresOsi.FillEllipse(maKolorKulki, maPunktyWykresu[(int)maIndexPołożeniaKulek].X - 10,
               // maPunktyWykresu[(int)maIndexPołożeniaKulek].Y - maPromieńKulki, 2 * maPromieńKulki, 2 * maPromieńKulki);
              //chuj.DrawImage(chuj, maPunktyWykresu[(int)maIndexPołożeniaKulek].X - 10);
              

            SolidBrush maXiY = new SolidBrush(Color.Black);
            //określenie rozmiaru powierzchni dla opisu osi Y
            SizeF maRozmiarPowierzchniOpisuOsiY = maWykresOsi.MeasureString(" Y", maCzcionka);
            //ustalenie odstępu od osi Y
            Point maoffsetDlaOsiY = new Point(-5, -10);
            //lokalizacja opisu osi Y
            PointF maLokalizacjaOpisuOsiY = new PointF(maWykresOsi.VisibleClipBounds.Width / 2 -
                maoffsetDlaOsiY.X, maRozmiarPowierzchniOpisuOsiY.Height - maoffsetDlaOsiY.Y);
            //wykreślenie opisu osi Y
            maWykresOsi.DrawString(" Y", maCzcionka, maXiY, maLokalizacjaOpisuOsiY);
            //wyreślenie opisu osi X
            SizeF maRozmiarPowierzchniOpisuOsiX = maWykresOsi.MeasureString(" X", maCzcionka);
            //ustalenie odstępu od osi X
            Point maoffsetDlaOsiX = new Point(20, 20);
            //lokalizacja opisu osi X
            PointF maLokalizacjaOpisuOsiX = new PointF(maWykresOsi.VisibleClipBounds.Width -
                maRozmiarPowierzchniOpisuOsiX.Width - maoffsetDlaOsiX.X, maWykresOsi.VisibleClipBounds.Height / 1.5f -
                maRozmiarPowierzchniOpisuOsiX.Height + maoffsetDlaOsiX.Y);
            //wykreślenie opisu osi X
            maWykresOsi.DrawString(" X", maCzcionka, maXiY, maLokalizacjaOpisuOsiX);
        }

        private void maRysujBut_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
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
                //wyznaczenie punktów dla rysowania wykresu
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
               
                maWykresOsi.Clear(matbZaciemnienie.BackColor);
            }
            else //dodano aby obiekt poruszający się zwolnił pod koniec wykresu
                if (maIndexPołożeniaKulek < 195)
            {
                maIndexPołożeniaKulek += 1;
                maWykresOsi.Clear(matbZaciemnienie.BackColor);
            }
            else
                maIndexPołożeniaKulek = 0;
            Refresh();

        }

        private void matbSzybkoscKulki_Scroll(object sender, EventArgs e)
        {
            //dodanie wartości dla timer1
            timer1.Interval = maSzybkosckulki + matbSzybkoscKulki.Value;
            maTBPredkosc.Text = Convert.ToString(matbSzybkoscKulki.Value);
            Refresh();
        }

        private void mabutStop_Click(object sender, EventArgs e)
        {
            //zastopowanie wykresu
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
            Refresh();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        public void mabutKolorLinii_Click(object sender, EventArgs e)
        {
            //zmiana koloru linii
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
            //ustawienie kolorów szarości
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
            
            
        }

        private void maTBWielkoscKulki_Scroll(object sender, EventArgs e)
        {
            //ustawienie promienia kulki
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

        private void kropkowaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            maStylLiniOsi = DashStyle.Dot;
        }

        private void kreskowaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            maStylLiniOsi = DashStyle.Dash;
        }

        private void kreskowokropkowaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            maStylLiniOsi = DashStyle.DashDot;
        }

        private void ciagłaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            maStylLiniOsi = DashStyle.Solid;
        }

        private void kropkowaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            maStylLiniWykresu = DashStyle.Dot;
        }

        private void kreskowaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            maStylLiniWykresu = DashStyle.Dash;
        }

        private void kropkowokreskowaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            maStylLiniWykresu = DashStyle.DashDot;
        }

        private void ciagłaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            maStylLiniWykresu = DashStyle.Solid;
        }

        private void kolorKulkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ustawienie koloru piłki
            macolorDialog1.ShowDialog();
            maKolorKulki = new SolidBrush(macolorDialog1.Color);
        }

        private void kolorWykresuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            macolorDialog1.ShowDialog();
            maKolorLinii = new SolidBrush(macolorDialog1.Color);
        }

        private void roToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void krójPismaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FontDialog maOknoWyboruCzcionki = new FontDialog(); //deklaruje zmienną czcionki 
            maOknoWyboruCzcionki.ShowDialog();  //otwiera okno z formatowaniem czcionek
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Andrzejewski_Load(object sender, EventArgs e)
        {
            //zlokalizowanie kontrolek
            maRysujBut.Location = new Point(maRysujBut.Location.X + (int)(Height * 0.5), maRysujBut.Location.Y + (int)(Height * 0.04));
            matbSzybkoscKulki.Location = new Point(maRysujBut.Location.X ,maRysujBut.Location.Y + (int)(Height * 0.2));
            malblPredkosc.Location = new Point(matbSzybkoscKulki.Location.X + (int)(Height * 0.02), matbSzybkoscKulki.Location.Y - (int)(Height * 0.02));
            maTBPredkosc.Location = new Point(matbSzybkoscKulki.Location.X, matbSzybkoscKulki.Location.Y + (int)(Height * 0.05));
            mabutStop.Location = new Point(maTBPredkosc.Location.X, maTBPredkosc.Location.Y + (int)(Height * 0.05));
            mabutKolorLinii.Location = new Point(mabutStop.Location.X, mabutStop.Location.Y + (int)(Height * 0.09));
            butkolory.Location = new Point(maRysujBut.Location.X, maRysujBut.Location.Y + (int)(Height * 0.09));
            matbZaciemnienie.Location = new Point(maPicBox.Location.X, maPicBox.Location.Y + (int)(Height * 0.01));
            malblJasnosc.Location = new Point(matbZaciemnienie.Location.X + (int)(Height * 0.03), matbZaciemnienie.Location.Y + (int)(Height * 0.05));
            lblGruboscKulki.Location = new Point(mabutKolorLinii.Location.X + (int)(Height * 0.02), mabutKolorLinii.Location.Y + (int)(Height * 0.09));
            maTBWielkoscKulki.Location = new Point(lblGruboscKulki.Location.X, lblGruboscKulki.Location.Y + (int)(Height * 0.04));
        }
    }
}
