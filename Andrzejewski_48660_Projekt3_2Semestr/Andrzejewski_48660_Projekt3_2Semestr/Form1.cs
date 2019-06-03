using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Andrzejewski_48660_Projekt3_2Semestr
{
    public partial class Andrzejewski : Form
    {

        #region zmienne pomocnicze;
        int maRotAngle = 1;
        public static Andrzejewski maUchwytFormularza;
        public static Graphics maRysownica;
        const int maMargines = 10;
        bool maCzyPrezentacja;  
        bool maCzyZostałaZaznaczonaPozycja;
        Point maStartPoint;
        SolidBrush maPędzel = new SolidBrush(Color.Blue); 
        List<maBryłaAbstrakcyjna> maListaBryl;
        DashStyle[] maStyleLinii;
        int maIndexBryły;
        Button maButtonKolor;
        Button maButtonWPrawo;
        Button maButtonWLewo;
        Label maLabel;
        TrackBar maTrackBarGruboscLinii;
        TrackBar maTrackBarWysokoscBryły;
        TrackBar maTrackBarPromienBryły;
        ComboBox maComboBoxStyleLinii;
        NumericUpDown maNumericUpDownKatNachylenia;
        #endregion

        public Andrzejewski()
        {
            InitializeComponent();
            Width = (int)(Screen.PrimaryScreen.Bounds.Width * 0.9f);
            Height = (int)(Screen.PrimaryScreen.Bounds.Height * 0.9f);
            StartPosition = FormStartPosition.Manual;
            SetAutoSizeMode(AutoSizeMode.GrowAndShrink);
            Location = new Point(100, 50);
            DoubleBuffered = true;
            maPicBoxRysownica.Image = new Bitmap(maPicBoxRysownica.Width, maPicBoxRysownica.Height);

            maRysownica = Graphics.FromImage(maPicBoxRysownica.Image);
            maUchwytFormularza = this;
            maStyleLinii = new DashStyle[4] { DashStyle.Dash, DashStyle.DashDot, DashStyle.Solid, DashStyle.Dot };
            maListaBryl = new List<maBryłaAbstrakcyjna>();
            pwRadioButtonAuto.Enabled = false;
            pwRadioButtonRęcznie.Enabled = false;
            maBUTFiguraPoprzednia.Enabled = false;
            maBUTFiguraNastępna.Enabled = false;
            maBUTWyłączSlajder.Enabled = false;
            maTXTBOXIndexFigury.Enabled = false;

            #region PictureBox 
            maPicBoxRysownica.Location = new Point(maMargines + Width / 6, (int)(Height / 2 * 0.1f) + maMargines);
            maPicBoxRysownica.Width = (int)(Width * 0.6f);
            maPicBoxRysownica.Height = (int)(Height * 0.7f);
            maPicBoxRysownica.BorderStyle = BorderStyle.Fixed3D;
            maPicBoxRysownica.BackColor = Color.White;
            #endregion

            #region Panel - Modyfikatory
            maPanelEdycji.BackColor = Color.LightYellow;
            maPanelEdycji.Location = new Point(maPicBoxRysownica.Location.X + maPicBoxRysownica.Width, maPicBoxRysownica.Location.Y + (int)(maPicBoxRysownica.Height * 0.85f));
            maPanelEdycji.Width = Width - (maPicBoxRysownica.Location.X + maPicBoxRysownica.Width) - 2 * maMargines;
            #endregion

            #region Lokalizacja kontrolek
            maGBoxUsuwanieBrył.Location = new Point(maPicBoxRysownica.Location.X , maPicBoxRysownica.Location.X + (int)(Height * 0.48F));
            maGBoxSlajder.Location = new Point(maPicBoxRysownica.Location.X + (int)(Width * 0.6F), maPicBoxRysownica.Location.Y + (int)(Height * 0.01F));
            maGBoxKryteriaPokazu.Location = new Point(maGBoxUsuwanieBrył.Location.X, maGBoxUsuwanieBrył.Location.Y + (int)(Height * 0.09F));
            #endregion
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Witaj w programie rysujący przestrzenne figury geometryczne. By zacząć, wybierz figurę z listy, ustal jej parametry i kliknij guzik 'Dodaj Nową Bryłę' ");

        }

        private void maPicBoxRysownica_Click(object sender, EventArgs e)
        {

        }

        private void maPicBoxRysownica_Paint(object sender, PaintEventArgs e)
        {
            if (maCzyZostałaZaznaczonaPozycja)
            {
                e.Graphics.FillEllipse(maPędzel, maStartPoint.X, maStartPoint.Y, 10, 10);
            }

            if (!maCzyPrezentacja)
            {
                foreach (maBryłaAbstrakcyjna bryła in maListaBryl)
                {
                    bryła.maWykreśl();
                }
            }
            else
            {
                if (maCzyZostałaZaznaczonaPozycja)
                {
                    maRysownica.Clear(maPicBoxRysownica.BackColor);
                    maListaBryl[maIndexBryły].maWykreśl();
                }
            }
        }

        private void maPicBoxRysownica_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                maStartPoint = e.Location;
                maCzyZostałaZaznaczonaPozycja = true;
                Refresh();
            }
        }

        #region Kontrolki Dynamiczne
        Control maNowyButtonKolor(int maWys, int maDl, Point maPoz)
        {
            maButtonKolor = new Button();
            maButtonKolor.Location = maPoz;
            maButtonKolor.Width = maDl;
            maButtonKolor.Height = maWys;
            maButtonKolor.Text = "Zmień Kolor";
            maButtonKolor.BackColor = Color.Red;
            maButtonKolor.Click += maButtonKolor_Click;

            return maButtonKolor;
        }

        private void maButtonKolor_Click(object sender, EventArgs e)
        {
            ColorDialog maColorDialog = new ColorDialog();

            if (maColorDialog.ShowDialog() == DialogResult.OK)
            {
                maListaBryl[maIndexBryły].maZmieńKolorLinii(maColorDialog.Color);
                maButtonKolor.BackColor = maColorDialog.Color;
            }
        }

        Control maNowyTrackBarWysokosc(Point maPozycja, int maCurrentVal)
        {
            maTrackBarWysokoscBryły = new TrackBar();
            maTrackBarWysokoscBryły.Minimum = 20;
            maTrackBarWysokoscBryły.Maximum = 300;
            maTrackBarWysokoscBryły.Width = 90;
            maTrackBarWysokoscBryły.Location = maPozycja;
            maTrackBarWysokoscBryły.Value = maCurrentVal;

            maTrackBarWysokoscBryły.Scroll += maTrackBarWysokoscBryły_Scroll;


            return maTrackBarWysokoscBryły;
        }

        private void maTrackBarWysokoscBryły_Scroll(object sender, EventArgs e)
        {
            maRysownica.Clear(maPicBoxRysownica.BackColor);
            maListaBryl[maIndexBryły].maZmieńWysokośćBryły(maTrackBarWysokoscBryły.Value);
        }

        Control maNowyTrackBarPromien(Point maPozycja, int maCurrentVal)
        {
            maTrackBarPromienBryły = new TrackBar();
            maTrackBarPromienBryły.Minimum = 20;
            maTrackBarPromienBryły.Maximum = 200;
            maTrackBarPromienBryły.Width = 90;
            maTrackBarPromienBryły.Location = maPozycja;
            maTrackBarPromienBryły.Value = maCurrentVal;

            maTrackBarPromienBryły.Scroll += maTrackBarPromienBryły_Scroll;

            return maTrackBarPromienBryły;
        }

        private void maTrackBarPromienBryły_Scroll(object sender, EventArgs e)
        {
            maRysownica.Clear(maPicBoxRysownica.BackColor);
            maListaBryl[maIndexBryły].maZmieńPromieńBryły(maTrackBarPromienBryły.Value);
        }

        Control maNowyTrackBarGruboscLinii(Point maPozycja, int maCurrentVal)
        {
            maTrackBarGruboscLinii = new TrackBar();
            maTrackBarGruboscLinii.Minimum = 1;
            maTrackBarGruboscLinii.Maximum = 5;
            maTrackBarGruboscLinii.Value = maCurrentVal;
            maTrackBarGruboscLinii.Location = maPozycja;
            maTrackBarGruboscLinii.Width = 90;

            maTrackBarGruboscLinii.Scroll += maTrackBarGruboscLinii_Scroll;

            return maTrackBarGruboscLinii;
        }

        private void maTrackBarGruboscLinii_Scroll(object sender, EventArgs e)
        {
            maRysownica.Clear(maPicBoxRysownica.BackColor);
            maListaBryl[maIndexBryły].maZmieńGrubośćLinii(maTrackBarGruboscLinii.Value);
        }

        Control maNowyNUDKatNachylenia(int maCurrentVal, Point maPozycja)
        {
            maNumericUpDownKatNachylenia = new NumericUpDown();
            maNumericUpDownKatNachylenia.Minimum = 1;
            maNumericUpDownKatNachylenia.Maximum = 180;
            maNumericUpDownKatNachylenia.Value = maCurrentVal;
            maNumericUpDownKatNachylenia.Location = maPozycja;
            maNumericUpDownKatNachylenia.Width = 50;

            maNumericUpDownKatNachylenia.ValueChanged += maNumericUpDownKatNachylenia_ValueChanged;


            return maNumericUpDownKatNachylenia;
        }

        private void maNumericUpDownKatNachylenia_ValueChanged(object sender, EventArgs e)
        {
            maRysownica.Clear(maPicBoxRysownica.BackColor);
            maListaBryl[maIndexBryły].maZmieńKątNachylenia((int)maNumericUpDownKatNachylenia.Value);
        }

        Control maNowyButtonWLewo(Point maPozycja)
        {
            maButtonWLewo = new Button();
            maButtonWLewo.Text = "<";
            maButtonWLewo.Width = 20;
            maButtonWLewo.Location = maPozycja;

            maButtonWLewo.Click += maButtonWLewo_Click;

            return maButtonWLewo;
        }

        private void maButtonWLewo_Click(object sender, EventArgs e)
        {
            maRysownica.Clear(maPicBoxRysownica.BackColor);
            maListaBryl[maIndexBryły].maWLewo();
        }

        Control maNowyButtonWPrawo(Point maPozycja)
        {
            maButtonWPrawo = new Button();
            maButtonWPrawo.Text = ">";
            maButtonWPrawo.Location = maPozycja;
            maButtonWPrawo.Width = 20;

            maButtonWPrawo.Click += maButtonWPrawo_Click;

            return maButtonWPrawo;
        }

        private void maButtonWPrawo_Click(object sender, EventArgs e)
        {
            maRysownica.Clear(maPicBoxRysownica.BackColor);
            maListaBryl[maIndexBryły].maWPrawo();
        }

        Control maNowyComboBox(Point maPozycja, DashStyle maObecnyStylLinii)
        {
            maComboBoxStyleLinii = new ComboBox();
            maComboBoxStyleLinii.Items.Add("Linia Ciągła");
            maComboBoxStyleLinii.Items.Add("Linia Kropkowana");
            maComboBoxStyleLinii.Items.Add("Linia Kreskowa");
            maComboBoxStyleLinii.Items.Add("Linia Kreskowo-Kropkowa");
            maComboBoxStyleLinii.Location = maPozycja;

            if (maObecnyStylLinii == DashStyle.Solid)
            {
                maComboBoxStyleLinii.SelectedIndex = 0;
            }
            else if (maObecnyStylLinii == DashStyle.Dot)
            {
                maComboBoxStyleLinii.SelectedIndex = 1;

            }
            else if (maObecnyStylLinii == DashStyle.Dash)
            {
                maComboBoxStyleLinii.SelectedIndex = 2;
            }
            else if (maObecnyStylLinii == DashStyle.DashDot)
            {
                maComboBoxStyleLinii.SelectedIndex = 3;
            }

            maComboBoxStyleLinii.SelectedIndexChanged += maComboBoxStyleLinii_SelectedIndexChanged;

            return maComboBoxStyleLinii;
        }

        private void maComboBoxStyleLinii_SelectedIndexChanged(object sender, EventArgs e)
        {
            maRysownica.Clear(maPicBoxRysownica.BackColor);
            switch (maComboBoxStyleLinii.SelectedIndex)
            {
                case 0:
                    maListaBryl[maIndexBryły].maZmieńStylLinii(DashStyle.Solid);
                    break;
                case 1:
                    maListaBryl[maIndexBryły].maZmieńStylLinii(DashStyle.Dot);
                    break;
                case 2:
                    maListaBryl[maIndexBryły].maZmieńStylLinii(DashStyle.Dash);
                    break;
                case 3:
                    maListaBryl[maIndexBryły].maZmieńStylLinii(DashStyle.DashDot);
                    break;
            }

            maPicBoxRysownica.Refresh();
        }

        Control maNowyLabel(string maTekst, Point maPozycja)
        {
            maLabel = new Label();
            maLabel.Text = maTekst;
            maLabel.Location = maPozycja;

            return maLabel;
        }
        #endregion

        private void maBUTNowaBryła_Click(object sender, EventArgs e)
        {
            if (maStartPoint != new Point(0, 0))
            {
                switch (maCMBWybórBryły.SelectedIndex)
                {
                    case 0:
                        maListaBryl.Add(new maWaleck(maTBPromien.Value, Color.Red, DashStyle.Solid, 2, maTBPromien.Value, (int)maNUDStopieńWielokąta.Value, maStartPoint));
                        break;
                    case 1:
                        maListaBryl.Add(new maOstrosłup(maTBPromien.Value, Color.Red, DashStyle.Solid, 2, maTBPromien.Value, (int)maNUDStopieńWielokąta.Value, maStartPoint));
                        break;
                    case 2:
                        maListaBryl.Add(new maGraniastosłup(maTBPromien.Value, Color.Red, DashStyle.Solid, 2, maTBPromien.Value, (int)maNUDStopieńWielokąta.Value, maStartPoint));
                        break;
                    case 3:
                        maListaBryl.Add(new maKula(maTBPromien.Value, maStartPoint, Color.Red, DashStyle.Solid, 2));
                        break;
                    case 4:
                        maListaBryl.Add(new maStożek(maTBPromien.Value, Color.Red, DashStyle.Solid, 2, maTBPromien.Value, (int)maNUDStopieńWielokąta.Value, maStartPoint));
                        break;
                    case 5:
                        maListaBryl.Add(new maOstrosłupPochylony(maTBPromien.Value, Color.Red, DashStyle.Solid, 2, maTBPromien.Value, (int)maNUDStopieńWielokąta.Value, maStartPoint, (int)(maNUDKątNachylenia.Value)));
                        break;
                    case 6:
                        maListaBryl.Add(new maGraniastosłupPochylony(maTBPromien.Value, Color.Red, DashStyle.Solid, 2, maTBPromien.Value, (int)maNUDStopieńWielokąta.Value, maStartPoint, (int)(maNUDKątNachylenia.Value)));
                        break;
                    case 7:
                        maListaBryl.Add(new maStożekPochylony(maTBPromien.Value, Color.Red, DashStyle.Solid, 2, maTBPromien.Value, (int)maNUDStopieńWielokąta.Value, maStartPoint, (int)(maNUDKątNachylenia.Value)));
                        break;
                    case 8:
                        maListaBryl.Add(new maSześcian(maTBPromien.Value, Color.Red, DashStyle.Solid, 2, maStartPoint));
                        break;
                    case 9:
                        maListaBryl.Add(new maBrylant(maTBPromien.Value, Color.Red, DashStyle.Solid, 2, maTBPromien.Value, (int)maNUDStopieńWielokąta.Value, maStartPoint));
                        break;
                    default:
                        MessageBox.Show("Nie została wybrana żadna figura!");
                        break;
                }

                maTimerDodawanie.Enabled = true;
                maPicBoxRysownica.Refresh();
                maCzyZostałaZaznaczonaPozycja = false;
                maNUDNumerBryłyDoSkasowania.Maximum = maListaBryl.Count;
                maNUDNumerBryłyDoSkasowania.Minimum = 1;
                maStartPoint = new Point(0, 0);
            }
            else
            {
                MessageBox.Show("Ustal pozycję wyświetlania figury.");
            }

        }

        private void maBUTKierunekWLewo_Click(object sender, EventArgs e)
        {
            foreach (maBryłaAbstrakcyjna maBryła in maListaBryl)
            {
                maBryła.maWLewo();
            }
        }

        private void maBUTKierunekWPrawo_Click(object sender, EventArgs e)
        {
            foreach (maBryłaAbstrakcyjna maBryła in maListaBryl)
            {
                maBryła.maWPrawo();
            }
        }

        private void maTimerDodawanie_Tick(object sender, EventArgs e)
        {
            maRotAngle++;
            if (!maCzyPrezentacja)
            {
                foreach (maBryłaAbstrakcyjna maBryła in maListaBryl)
                {
                    maBryła.maObróćIWykreśl(maRotAngle);
                }
            }
            else
            {
                maListaBryl[maIndexBryły].maObróćIWykreśl(maRotAngle);
            }

            Refresh();
        }

        private void maTimerPokazSlajdów_Tick(object sender, EventArgs e)
        {
            maRysownica.Clear(maPicBoxRysownica.BackColor);

            if (maIndexBryły >= maListaBryl.Count - 1)
            {
                maIndexBryły = 0;
            }
            else
            {
                maIndexBryły++;
            }
            maTXTBOXIndexFigury.Text = (maIndexBryły + 1).ToString();
        }

        void maDodajDoPaneluKontrolkiBryłyNiePochylone()
        {
            maPanelEdycji.Controls.Add(maNowyLabel("Zmień Kolor", new Point(10, 10)));
            maPanelEdycji.Controls.Add(maNowyButtonKolor(25, 60, new Point(10, 30)));
            maPanelEdycji.Controls.Add(maNowyLabel("Zmień Typ Linii", new Point(10, 70)));
            maPanelEdycji.Controls.Add(maNowyComboBox(new Point(10, 100), maListaBryl[maIndexBryły].maGetStylLinii));
            maPanelEdycji.Controls.Add(maNowyLabel("Zmień Grubość Linii", new Point(10, 130)));
            maPanelEdycji.Controls.Add(maNowyTrackBarGruboscLinii(new Point(10, 150), maListaBryl[maIndexBryły].maGetGrubośćLinii));
            maPanelEdycji.Controls.Add(maNowyLabel("Zmień Wysokość Bryły", new Point(160, 10)));
            maPanelEdycji.Controls.Add(maNowyTrackBarWysokosc(new Point(160, 40), maListaBryl[maIndexBryły].maGetWysokośćBryły));
            maPanelEdycji.Controls.Add(maNowyLabel("Zmień Promień Bryły", new Point(160, 85)));
            maPanelEdycji.Controls.Add(maNowyTrackBarPromien(new Point(160, 100), maListaBryl[maIndexBryły].maGetPromień));
            maPanelEdycji.Controls.Add(maNowyLabel("Zmień Kierunek Obrotu", new Point(160, 150)));
            maPanelEdycji.Controls.Add(maNowyButtonWLewo(new Point(180, 170)));
            maPanelEdycji.Controls.Add(maNowyButtonWPrawo(new Point(210, 170)));


        }

        void maDodajDoPaneluKontrolkiSześcian()
        {
            maPanelEdycji.Controls.Add(maNowyLabel("Zmień Kolor", new Point(10, 10)));
            maPanelEdycji.Controls.Add(maNowyButtonKolor(25, 60, new Point(10, 30)));
            maPanelEdycji.Controls.Add(maNowyLabel("Zmień Typ Linii", new Point(10, 70)));
            maPanelEdycji.Controls.Add(maNowyComboBox(new Point(10, 100), maListaBryl[maIndexBryły].maGetStylLinii));
            maPanelEdycji.Controls.Add(maNowyLabel("Zmień Grubość Linii", new Point(10, 130)));
            maPanelEdycji.Controls.Add(maNowyTrackBarGruboscLinii(new Point(10, 150), maListaBryl[maIndexBryły].maGetGrubośćLinii));
            maPanelEdycji.Controls.Add(maNowyLabel("Zmień Promień Bryły", new Point(160, 10)));
            maPanelEdycji.Controls.Add(maNowyTrackBarPromien(new Point(160, 40), maListaBryl[maIndexBryły].maGetPromień));
            maPanelEdycji.Controls.Add(maNowyLabel("Zmień Kierunek Obrotu", new Point(160, 150)));
            maPanelEdycji.Controls.Add(maNowyButtonWLewo(new Point(180, 170)));
            maPanelEdycji.Controls.Add(maNowyButtonWPrawo(new Point(210, 170)));
        }

        void maDodajDoPaneluKontrolkiBryłyPochylone()
        {
            maPanelEdycji.Controls.Add(maNowyLabel("Zmień Kolor", new Point(10, 10)));
            maPanelEdycji.Controls.Add(maNowyButtonKolor(25, 60, new Point(10, 30)));
            maPanelEdycji.Controls.Add(maNowyLabel("Zmień Typ Linii", new Point(10, 70)));
            maPanelEdycji.Controls.Add(maNowyComboBox(new Point(10, 100), maListaBryl[maIndexBryły].maGetStylLinii));
            maPanelEdycji.Controls.Add(maNowyLabel("Zmień Grubość Linii", new Point(10, 130)));
            maPanelEdycji.Controls.Add(maNowyTrackBarGruboscLinii(new Point(10, 150), maListaBryl[maIndexBryły].maGetGrubośćLinii));
            maPanelEdycji.Controls.Add(maNowyLabel("Zmień Kąt Nachylenia", new Point(10, 200)));
            maPanelEdycji.Controls.Add(maNowyNUDKatNachylenia(maListaBryl[maIndexBryły].maGetKątPochylenia, new Point(10, 220)));
            maPanelEdycji.Controls.Add(maNowyLabel("Zmień Wysokość Bryły", new Point(160, 10)));
            maPanelEdycji.Controls.Add(maNowyTrackBarWysokosc(new Point(160, 40), maListaBryl[maIndexBryły].maGetWysokośćBryły));
            maPanelEdycji.Controls.Add(maNowyLabel("Zmień Promień Bryły", new Point(160, 85)));
            maPanelEdycji.Controls.Add(maNowyTrackBarPromien(new Point(160, 100), maListaBryl[maIndexBryły].maGetPromień));
            maPanelEdycji.Controls.Add(maNowyLabel("Zmień Kierunek Obrotu", new Point(160, 150)));
            maPanelEdycji.Controls.Add(maNowyButtonWLewo(new Point(180, 170)));
            maPanelEdycji.Controls.Add(maNowyButtonWPrawo(new Point(210, 170)));

        }

        private void maTXTBOXIndexFigury_TextChanged(object sender, EventArgs e)
        {
            maCzyścPanel();
            switch (maListaBryl[maIndexBryły].maRodzajBryły)
            {
                case maBryłaAbstrakcyjna.maTypBryły.maWalec:
                    maDodajDoPaneluKontrolkiBryłyNiePochylone();
                    break;
                case maBryłaAbstrakcyjna.maTypBryły.maSześcian:
                    maDodajDoPaneluKontrolkiSześcian();
                    break;
                case maBryłaAbstrakcyjna.maTypBryły.maStożek:
                    maDodajDoPaneluKontrolkiBryłyNiePochylone();
                    break;
                case maBryłaAbstrakcyjna.maTypBryły.maOstrosłup:
                    maDodajDoPaneluKontrolkiBryłyNiePochylone();
                    break;
                case maBryłaAbstrakcyjna.maTypBryły.maKula:
                    maDodajDoPaneluKontrolkiSześcian();
                    break;
                case maBryłaAbstrakcyjna.maTypBryły.maGraniastosłup:
                    maDodajDoPaneluKontrolkiBryłyNiePochylone();
                    break;
                case maBryłaAbstrakcyjna.maTypBryły.maOstrosłupPochylony:
                    maDodajDoPaneluKontrolkiBryłyPochylone();
                    break;
                case maBryłaAbstrakcyjna.maTypBryły.maStożekPochylony:
                    maDodajDoPaneluKontrolkiBryłyPochylone();
                    break;
                case maBryłaAbstrakcyjna.maTypBryły.maGraniastosłupPochylony:
                    maDodajDoPaneluKontrolkiBryłyPochylone();
                    break;
                case maBryłaAbstrakcyjna.maTypBryły.maBrylant:
                    maDodajDoPaneluKontrolkiBryłyNiePochylone();
                    break;

            }
        }
            void maCzyścPanel()
            {
                maPanelEdycji.Controls.Clear();
            }

        private void maBUTWłączenieSlajdera_Click(object sender, EventArgs e)
        {
            if(maListaBryl.Count > 0)
            {
                maBUTWyłączSlajder.Enabled = true;
                maTXTBOXIndexFigury.Enabled = true;
                pwRadioButtonAuto.Enabled = true;
                pwRadioButtonRęcznie.Enabled = true;
                maBUTFiguraPoprzednia.Enabled = true;
                maBUTFiguraNastępna.Enabled = true;
                maGBoxUsuwanieBrył.Enabled = false;
                maCzyPrezentacja = true;
                maGBoxKryteriaPokazu.Enabled = false;
                maBUTNowaBryła.Enabled = false;
                maBUTKierunekWLewo.Enabled = false;
                maBUTKierunekWPrawo.Enabled = false;
                pwRadioButtonAuto.Enabled = true;
                pwRadioButtonRęcznie.Enabled = true;

                maListaBryl.Sort();
                

                foreach(maBryłaAbstrakcyjna maBryła in maListaBryl)
                {
                    maBryła.maPrzesuńDoNowegoXY(maPicBoxRysownica.Width / 2, maPicBoxRysownica.Height / 2);
                }
                maTXTBOXIndexFigury.Text = (maIndexBryły + 1).ToString();
                Refresh();
            }
            else
            {
                MessageBox.Show("Brak brył! Dodaj jakąś używając guzika 'Dodaj Nową Bryłę'");
            }
        }

        private void maBTNUsuńPierwsząBryłę_Click(object sender, EventArgs e)
        {
            maListaBryl.RemoveAt(0);
            maRysownica.Clear(maPicBoxRysownica.BackColor);
        }

        private void maBTNUsuńOstatniąBryłę_Click(object sender, EventArgs e)
        {
            maListaBryl.RemoveAt(maListaBryl.Count - 1);
            maRysownica.Clear(maPicBoxRysownica.BackColor);
        }

        private void maBTNUsuńWybranąBryłę_Click(object sender, EventArgs e)
        {
            maListaBryl.RemoveAt((int)maNUDNumerBryłyDoSkasowania.Value);
            maRysownica.Clear(maPicBoxRysownica.BackColor);
        }

        private void maBUTNoweAtrybuty_Click(object sender, EventArgs e)
        {
            maTXTBOXIndexFigury.Enabled = false;
            pwRadioButtonAuto.Enabled = false;
            pwRadioButtonRęcznie.Enabled = false;
            maBUTFiguraPoprzednia.Enabled = false;
            maBUTFiguraNastępna.Enabled = false;
            maCzyPrezentacja = false;
            maGBoxKryteriaPokazu.Enabled = true;
            maListaBryl.Sort();
            maBUTNowaBryła.Enabled = true;
            maBUTKierunekWPrawo.Enabled = true;
            maBUTKierunekWLewo.Enabled = true;
            maPanelEdycji.Visible = false;
            maGBoxUsuwanieBrył.Enabled = true;

            foreach (maBryłaAbstrakcyjna mśBryła in maListaBryl)
            {
                mśBryła.maWrócDoStarychWspółrzędnych();
            }
        }

        private void maPanelEdycji_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pwRadioButtonAuto_CheckedChanged(object sender, EventArgs e)
        {
            if(pwRadioButtonAuto.Checked)
            {
                maTimerPokazSlajdów.Enabled = true;
                maBUTFiguraNastępna.Enabled = false;
                maBUTFiguraPoprzednia.Enabled = false;
                maPanelEdycji.Visible = false;
            }
        }

        private void pwRadioButtonRęcznie_CheckedChanged(object sender, EventArgs e)
        {
           if( pwRadioButtonRęcznie.Checked)
            {
                maTimerPokazSlajdów.Enabled = false;
                maBUTFiguraNastępna.Enabled = true;
                maBUTFiguraPoprzednia.Enabled = true;
                maPanelEdycji.Visible = true;
            }
        }

        private void maBUTFiguraNastępna_Click(object sender, EventArgs e)
        {
            maRysownica.Clear(maPicBoxRysownica.BackColor);
            if (maIndexBryły >= maListaBryl.Count - 1)
            {
                maIndexBryły = 0;

            }
            else
            {
                maIndexBryły++;
            }
            maTXTBOXIndexFigury.Text = (maIndexBryły + 1).ToString();
        }

        private void maBUTFiguraPoprzednia_Click(object sender, EventArgs e)
        {
            maRysownica.Clear(maPicBoxRysownica.BackColor);
            if (maIndexBryły == 0)
            {
                maIndexBryły = maListaBryl.Count - 1;

            }
            else
            {
                maIndexBryły--;
            }
            maTXTBOXIndexFigury.Text = (maIndexBryły + 1).ToString();
        }

        private void maBTNLosoweAtrybutyGraficzne_Click(object sender, EventArgs e)
        {
            maRysownica.Clear(maPicBoxRysownica.BackColor);

            Random mśRandom = new Random();
            foreach (maBryłaAbstrakcyjna Bryła in maListaBryl)
            {
                Bryła.maZmieńStylLinii(maStyleLinii[mśRandom.Next(0, 3)]);
                Bryła.maZmieńKolorLinii(Color.FromArgb(mśRandom.Next(0, 255), mśRandom.Next(0, 255), mśRandom.Next(0, 255)));
                Bryła.maZmieńGrubośćLinii(mśRandom.Next(1, 5));
            }
        }

        private void maBTNLosujPołożenie_Click(object sender, EventArgs e)
        {
            Random mśRandom = new Random();

            foreach (maBryłaAbstrakcyjna maBryła in maListaBryl)
            {
                maBryła.maPrzesuńDoNowegoXY(mśRandom.Next(0, maPicBoxRysownica.Width), mśRandom.Next(0, maPicBoxRysownica.Height));
            }
        }
    }
}
