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

namespace Sprawdzian_Andrzejewski1
{
    public partial class Andrzejewski : Form
    {
        const int Margines = 20;
        const int Odstep = 10;
        float Xl, Xp, h;
        int LiczbaPrzedziałówH;
        Graphics Rysownica;
        float[,] TWF;// TablicaWartościFunkcji

        //deklaracja pomocnicza 
        static Andrzejewski UchwytFormularza;

        public Andrzejewski()
        {
            InitializeComponent();
            this.Location = new Point(20, 20);
            this.Width = (int)(Screen.PrimaryScreen.Bounds.Width * 0.8F);
            this.Height = (int)(Screen.PrimaryScreen.Bounds.Height * 0.7F);
            this.StartPosition = FormStartPosition.Manual;
            //lokalizacja i zwymiarowanie kontrolki PictureBox
            pbRysownica.Location = new Point(this.Left + Margines, this.Top + 3 * Margines);
            pbRysownica.Width = (int)(this.Width * 0.75F);
            pbRysownica.Height = (int)(this.Height * 0.7F);
            pbRysownica.BackColor = Color.Bisque;
            pbRysownica.BorderStyle = BorderStyle.Fixed3D;
            //utworzenie podpięcia mapy bitowej
            pbRysownica.Image = new Bitmap(pbRysownica.Width, pbRysownica.Height);
            //utworzenie egzemplarza powierzni fraficznej
            Rysownica = Graphics.FromImage(pbRysownica.Image);
            //przechowanie referencji do egzemplarza formularza
            Rysownica.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            UchwytFormularza = this;

            //pozycjonowanie kontrolek
            lblTytuł.Location = new Point(pbRysownica.Location.X + (pbRysownica.Width - lblTytuł.Width) / 2, pbRysownica.Location.Y - 2 * Margines);
            lblXd.Location = new Point(pbRysownica.Location.X + pbRysownica.Width + Margines, pbRysownica.Location.Y);
            txtXd.Location = new Point(lblXd.Location.X + lblXd.Width + 10, lblXd.Location.Y);
            lblXg.Location = new Point(lblXd.Location.X, lblXd.Location.Y + 3 * Margines);
            txtXg.Location = new Point(txtXd.Location.X, lblXg.Location.Y);
            lblh.Location = new Point(lblXg.Location.X + lblXg.Width - lblh.Width, lblXg.Location.Y + 3 * Margines);
            txtH.Location = new Point(txtXg.Location.X, txtXg.Location.Y + 3 * Margines);
            btnStart.Location = new Point(lblh.Location.X, txtH.Location.Y + 3 * Margines);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtXd.Text))
            {
                //1.1.1 zapalenie kontrolki errorpovider
                errorProvider1.SetError(txtXd, "Błąd: musisz wpisać wartość przedziału Xd!");
                return;
            }
            else
                errorProvider1.Dispose();
            try
            {
                Xl = float.Parse(txtXd.Text);
            }
            catch (FormatException)
            {
                errorProvider1.SetError(txtXd, "Błąd: wystapił niedozwolony znak w zapisie wysokości Xd");
                return;
            }

            if (string.IsNullOrEmpty(txtXg.Text))
            {
                errorProvider1.SetError(txtXg, "Błąd: musisz wpisać wartość przedziału Xg!");
                return;
            }
            else
                errorProvider1.Dispose();
            try
            {
                Xp = float.Parse(txtXg.Text);
            }
            catch (FormatException)
            {
                errorProvider1.SetError(txtXg, "Błąd: wystapił niedozwolony znak w zapisie wysokości Xg");
                return;
            }

            if (string.IsNullOrEmpty(txtH.Text))
            {
                errorProvider1.SetError(txtH, "Błąd: musisz wpisać wartość kroku 'h'!");
                return;
            }
            else
                errorProvider1.Dispose();

            try
            {
                h = float.Parse(txtH.Text);
            }
            catch (FormatException)
            {
                errorProvider1.SetError(txtH, "Błąd: wystapił niedozwolony znak w zapisie kroku h");
                return;
            }
            if (h >= 1 || h <= 0)
            {
                // 1.2.5 zapalenie kontrolki errorProvider1
                errorProvider1.SetError(txtH, "Błąd: funkcjonalność programu ogranicza wartość kroku przedzoałem (0;1)");
                return;
            }
            if (Xl >= Xp)
            {
                errorProvider1.SetError(btnStart, "Błąd: początkowa wartość przedziału  Xd musi być mniejsza od końcowej wartości Xg!");
                return;
            }
            else
                errorProvider1.Dispose();

            //wyznaczenie liczby przedziałów H w przedziale [Xl, Xp]
            LiczbaPrzedziałówH = (int)((Xp - Xl) / h + 1);
            if (LiczbaPrzedziałówH < 2)
            {
                errorProvider1.SetError(btnStart, "Liczba przedziałow jest poniżej 2!. Proszę o zwiększenie odległości pomiędzy Xd a Xg!");
                return;
            }
            else
                errorProvider1.Dispose();
            //utworzenie egzemlarza tablicy zmian wartości funkcji w przedziale [Xl, Xp]
            TWF = new float[LiczbaPrzedziałówH + 1, 2];
            // stablicowanie funkcji w przedziale [Xg, Xd]
            int i; float X;
            for (i = 0, X = Xl; i < TWF.GetLength(0); i++, X = Xl + i * h)
            {
                TWF[i, 0] = X;

                if (X < -20)
                {
                    TWF[i, 1] = (float)Math.Pow(Math.Cos(Math.PI * X) + 2 * Math.Sin(Math.PI * X) / 2, 2);
                    // MessageBox.Show("X=" + X.ToString() + ";" + TWF[i, 1].ToString());
                }

                else if (X >= -20 && X < 0)
                {
                    TWF[i, 1] = (float)(Math.Pow(10, 6) * Math.Log(Math.Abs(X), 2) / Math.Pow(Math.E, X) * (1 + Math.Pow(X, 2)));
                    //MessageBox.Show("X="+ X.ToString() +";" + TWF[i, 1].ToString());
                }

                else
                {
                    TWF[i, 1] = X * (float)Math.Cos(Math.Pow(X, 4) + X) * (float)Math.Sin(X);
                    //MessageBox.Show("X=" + X.ToString() + ";" + TWF[i, 1].ToString());
                }
            }
            //programowe podłączenie metody obsługi zdarzenia Paint do kontrolki PictureBox
            pbRysownica.Paint += new PaintEventHandler(pbRysownica_Paint);
            //odświezenie powierzchni kontrolki PictureBox
            pbRysownica.Refresh();
            this.Refresh();
            txtXd.Enabled = false;
            txtXg.Enabled = false;
            txtH.Enabled = false;
            btnStart.Enabled = false;
        }

        void pbRysownica_Paint(object sender, PaintEventArgs e)
        {
            Rysownica.Clear(Color.Bisque);//wymazanie animacji
            Rectangle rect = new Rectangle(0, 0, pbRysownica.Width, pbRysownica.Height);
            int szerokosc = rect.Width - Odstep * 2;// obliczenie szerokości pola wykresu
            int wysokosc = rect.Height - (int)(Odstep * 2.1);// obliczenie wysokości pola wykresu
            Pen altPen = new Pen(Color.Chocolate);//wprowadzenie zmiennej "Pen" dla funkcji rysowania, ustalenie koloru rysowania (czekoładowy)
            Rysownica.DrawRectangle(altPen, 0 + Odstep, 0 + Odstep, szerokosc, wysokosc); // rysowanie prostokąta z uzyciem zmiennych (narzędzie rysujące = Pen, x0, y0, szerokość, wysokość)

            //utworzenie egzemplarza generator liczb losowych
            Random rnd = new Random();
            Color KolorLiniiWykresu = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
            //utworzenie pióra
            Pen Pióro = new Pen(KolorLiniiWykresu, 2.5F);
            //kreslenie linii wykresu
            for (int j = 0; j < TWF.GetLength(0) - 1; j++)
                Rysownica.DrawLine(Pióro, PrzeliczanieWspółrzędnych.WspX(TWF[j, 0]),
                    PrzeliczanieWspółrzędnych.WspY(TWF[j, 1]),
                    PrzeliczanieWspółrzędnych.WspX(TWF[j + 1, 0]),
                    PrzeliczanieWspółrzędnych.WspY(TWF[j + 1, 1]));
        }

        //deklaracja pomocnicza klasy statycznej
        static class MetodyStatyczne
        {
            public static float MinFx(float[,] TWF)
            {
                float WartośćMin;
                WartośćMin = TWF[0, 1];
                for (int i = 1; i < TWF.GetLength(0); i++)
                    if (WartośćMin > TWF[i, 1])
                        WartośćMin = TWF[i, 1];
                //zwrotne przekazanie minimalnej wartości funkcji
                return WartośćMin;
            }

            public static float MaxFx(float[,] TWF)
            {
                float WartośćMax;
                WartośćMax = TWF[0, 1];
                for (int i = 1; i < TWF.GetLength(0); i++)
                    if (WartośćMax < TWF[i, 1])
                        WartośćMax = TWF[i, 1];
                //zwrotne przekazanie maksymalnej wartości funkcji
                return WartośćMax;
            }
        } //od MetodyStatyczne


        public static class PrzeliczanieWspółrzędnych
        {
            static float WspółczynnikSkaliDlaOsiX, WspółczynnikSkaliDlaOsiY;
            static float PrzesunięcieX, PrzesuniecieY;
            //zmienne dla przechowania rozmiarów "ekranu"
            static int Xe_max, Ye_max, Xe_min, Ye_min;
            static PrzeliczanieWspółrzędnych()
            {
                //deklaracja konstuktora klasy statycznej PrzeliczanieWspółrzędnych
                Xmin = UchwytFormularza.Xl;
                Xmax = UchwytFormularza.Xp;
                Ymin = MetodyStatyczne.MinFx(UchwytFormularza.TWF);
                Ymax = MetodyStatyczne.MaxFx(UchwytFormularza.TWF);
                //deklaracja właściwości opisujących rzeczywistą powierzchnię graficzną
                // ustalenie  rozmiarów powierzchni graficznej
                Xe_min = Margines; Xe_max = UchwytFormularza.pbRysownica.Width - 2 * Margines;

                Ye_min = Margines; Ye_max = UchwytFormularza.pbRysownica.Height - 2 * Margines;
                //wyznaczenie wartości współczynników skali i przesunięć
                WspółczynnikSkaliDlaOsiX = (Xe_max - Xe_min) / (Xmax - Xmin);
                WspółczynnikSkaliDlaOsiY = (Ye_max - Ye_min) / (Ymax - Ymin);
                PrzesunięcieX = Xe_min - Xmin * WspółczynnikSkaliDlaOsiX;
                PrzesuniecieY = Ye_min - Ymin * WspółczynnikSkaliDlaOsiY;

            }
            //deklaracje 
            public static float Xmax
            {
                get;
                private set;
            }
            public static float Xmin
            {
                get;
                private set;
            }
            public static float Ymax
            {
                get;
                private set;
            }
            public static float Ymin
            {
                get;
                private set;
            }

            //deklaracje metod odwzorowania współrzednych
            public static int WspX(float x)
            {
                return (int)(x * WspółczynnikSkaliDlaOsiX + PrzesunięcieX);
            }
            public static int WspY(float y)
            {
                return (int)(y * WspółczynnikSkaliDlaOsiY + PrzesuniecieY);
            }
        }// od class Przeliczenie Współrzędnych
    }
}
