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

namespace Andrzejewski_48660_SprNr1
{
    public partial class Andrzejewski : Form
    {
        Graphics maWykresOsi;
        PointF[] maPunktyWykresu;
        float maXmax, maYmax,maY;
        Pen maPióro;
        Pen maPióro2;
        int makroki;
        Font maCzcionka = new Font("Times New Roman", 10, FontStyle.Bold);


        bool maPorbanieZmiennychXd(out float maXd, out float maXg, out float mah)
        {
            maXd = 0.0F; maXg = 0.0F; mah = 0.0F;
            if (string.IsNullOrEmpty(maTBXg.Text))
            {
                maerrorProvider1.SetError(maTBXg, "Wpisz liczbę!");
            }
            else { maerrorProvider1.Clear(); }

            if (!float.TryParse(maTBXg.Text, out maXg))
            {
                maerrorProvider1.SetError(maTBXg, "Podaj liczbę!");
                return false;
            }
            else { maerrorProvider1.Clear(); }


            if (string.IsNullOrEmpty(maTBXd.Text))
            {
                maerrorProvider1.SetError(maTBXd, "Wpisz liczbę!");
            }
            else { maerrorProvider1.Clear(); }

            if (!float.TryParse(maTBXd.Text, out maXd))
            {
                maerrorProvider1.SetError(maTBXd, "Podaj liczbę!");
                return false;
            }
            else { maerrorProvider1.Clear(); }

            
            if (maXd >= maXg)
            {
                maerrorProvider1.SetError(malblXd, "Dolna granica musi być mniejasza od górnej!");
                return false;
            }
            else { maerrorProvider1.Clear(); }

            if (string.IsNullOrEmpty(maTBH.Text))
            {
                maerrorProvider1.SetError(maTBH, "Wpisz liczbę!");
            }
            else { maerrorProvider1.Clear(); }

            if (!float.TryParse(maTBH.Text, out mah))
            {
                maerrorProvider1.SetError(maTBH, "Podaj liczbę!");
                return false;
            }
            else { maerrorProvider1.Clear(); }

            if ((mah == 0) || (mah > (maXg - maXd)))
            {
                maerrorProvider1.SetError(maTBH, "Krok 'h' zmian zmiennej niezależnej maX musi być !=0.0 i nie może być większy od szerokości przedziału: maXg - maXd");
                return false;
            }
            else { maerrorProvider1.Clear(); }

            return true;
        }

        public Andrzejewski()
        {
            InitializeComponent();
            Location = new Point(20, 20);
            Width = (int)(Screen.PrimaryScreen.Bounds.Height * 1.3);
            Height = (int)(Screen.PrimaryScreen.Bounds.Height * 0.9);
            StartPosition = FormStartPosition.Manual;
            SetAutoSizeMode(AutoSizeMode.GrowAndShrink);
            //lokalizacja i zwymiarowanie kontrolki PictureBox
            maRysownica.Location = new Point(Left + 10, Top + 30);
            maRysownica.Width = (int)(Width * 0.7F);
            maRysownica.Height = (int)(Height * 0.8F);
            maRysownica.BackColor = Color.LightCoral;
            //utworzenie bitmapy
            maRysownica.Image = new Bitmap(maRysownica.Width, maRysownica.Height);
            //utworzenie egzemplarza powierzchni graficznej na bit mapie
            maWykresOsi = Graphics.FromImage(maRysownica.Image);
            //przekonwertowanie wartości zsówaka na typ string

            maXmax = maRysownica.Width;
            maYmax = maRysownica.Height;

            mabutStart.Location = new Point(maRysownica.Location.X + (int)0.9F, maRysownica.Location.Y);
        }

        private void Andrzejewski_Load(object sender, EventArgs e)
        {
            
        }

        private void maRysownica_Paint(object sender, PaintEventArgs e)
        {
            //odświerzenie picbox
            maRysownica.Refresh();
            //utworzenie egzemplarza pióra
            maPióro = new Pen(Color.Azure, 2F);
            //ustawienie atrybutów pióra
            maPióro.DashStyle = DashStyle.Dash;
            //ustawienie zakończeń linii osi układu współrzędnych
            maPióro.StartCap = LineCap.ArrowAnchor;
            //ustawienie osi układu współrzędnych
            maWykresOsi.DrawLine(maPióro, (int)(Width * 0.02), maYmax / 1.5F, maXmax - (int)(Width * 0.02F), maYmax / 1.5F);
            maWykresOsi.DrawLine(maPióro, maXmax / 2, maYmax - (int)(Height * 0.04), maXmax / 2, (int)(Height * 0.04));
            //utworzenie egzemplarza pióra2
            maPióro2 = new Pen(Color.Black, 1F);
            //ustawienie atrybutów dla pióra2
            maPióro2.DashStyle = DashStyle.Dot;

            SolidBrush maXiY = new SolidBrush(Color.Black);
            //określenie rozmiaru powierzchni dla opisu osi Y
            SizeF maRozmiarPowierzchniOpisuOsiY = maWykresOsi.MeasureString(" Y", maCzcionka);
            //ustalenie odstępu od osi Y
            Point maoffsetDlaOsiY = new Point(-5, -10);
            //lokalizacja opisu osi Y
            PointF maLokalizacjaOpisuOsiY = new PointF(maWykresOsi.VisibleClipBounds.Width / 2 -
                maoffsetDlaOsiY.X, maRozmiarPowierzchniOpisuOsiY.Height - maoffsetDlaOsiY.Y);
            //wykreślenie opisu osi Y
            maWykresOsi.DrawString(" Y", maCzcionka , maXiY, maLokalizacjaOpisuOsiY);
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

            for (int mai = 0; mai < makroki; mai++)
            {
                    maWykresOsi.DrawLine(maPióro, maPunktyWykresu[mai], maPunktyWykresu[mai + 1]);
            }

        }


        private void mabutStart_Click(object sender, EventArgs e)
        {
            int maIndex=0;
            float maXd, maXg, mah;
            if (!maPorbanieZmiennychXd(out maXd, out maXg, out mah))
            {
                maerrorProvider1.SetError(mabutStart, "Wystąpił błąd podczas wczytania danych");
                return;
            }
            else { maerrorProvider1.Clear(); }

            timer1.Enabled = true;
            makroki =Math.Abs((int)((maXg + maXd) / mah));
            maPunktyWykresu = new PointF[makroki + 1];


            float maj = -1;
            for (float mai = maXd; mai < maXg; mai =+ mah)
            {

                if(maj<-1)
                {
                    maY = (float)((Math.PI * Math.Pow(maj, 5F)) - (Math.Abs(Math.Pow(maj + Math.PI, 0.5F))));
                }
                if(maj>=-1||maj<1)
                {
                    maY = (float)(Math.Log(((Math.Abs(maj + Math.Pow(Math.Pow(maj, 3F) + Math.PI, 0.5F) + Math.PI)) * (Math.Cos(Math.Pow(Math.E, maj) + Math.Pow(Math.E, -maj)) / (Math.Pow(maj, 2) + 1))), Math.E));
                }
                if(maj>=1)
                {
                    maY = (float)(Math.PI * Math.Pow(maj, 3F) - (Math.Pow(Math.PI * maj + 4F, 0.5F)));
                }

                maPunktyWykresu[maIndex] = new PointF(maj , maY);
 
                maIndex += 1;
            }
        }
    }
}
