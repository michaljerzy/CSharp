using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//dodanie nowej przestrzeni nazw
using System.Drawing.Drawing2D;

namespace _13._03._2019_Andrzejewski
{
    public partial class Andrzejewski : Form
    {
        const int Margines = 20;
        float xl, xp, h;
        int LiczbaPrzedziałówH;
        Graphics Rysownica;
        float[,] TWF; //TWF = tablica wartości funkcji
        //deklaracja pomocnicza
        static Andrzejewski UchwytFormularza;

        public Andrzejewski()
        {
            InitializeComponent();
            this.Location = new Point(20, 20);
            this.Width = (int)(Screen.PrimaryScreen.Bounds.Width * 0.8F);
            this.Height = (int)(Screen.PrimaryScreen.Bounds.Width * 0.7F);
            this.StartPosition = FormStartPosition.Manual;
            //lokalizacja i zwymiarowanie kontrolki picturebox
            pbRysownica.Location = new Point(this.Left + Margines, this.Top + 3 * Margines);
            pbRysownica.Width = (int)(this.Width * 0.75F);
            pbRysownica.Height = (int)(this.Height * 0.7F);
            pbRysownica.BackColor = Color.CadetBlue;
            pbRysownica.BorderStyle = BorderStyle.Fixed3D;
            // utworzenie i podpięcie mapy bitowej
            pbRysownica.Image = new Bitmap(pbRysownica.Width, pbRysownica.Height);
            //utworzenie egzemolarza powierzchni graficznej
            Rysownica = Graphics.FromImage(pbRysownica.Image);
            //przechowanie referencji do egzemplarza formularza
            UchwytFormularza = this;

        }
        // deklaracja pomicniczej klasy statycznej
        static class MetodyStatyczne
        {
            public static float MinFx(float[,] TWF)
            {
                float WartośćMin;
                WartośćMin = TWF[0, 1];
                for (int i = 1; i < TWF.GetLength(0); i++)
                {
                    if(WartośćMin > TWF[i, 1])
                    {
                        WartośćMin = TWF[i, 1];
                    }
                    //zwrotne przekazanie minimalnej wartości funkcji
                }
                return WartośćMin;
            }

            public static float MaxFx(float[,] TWF)
            {
                float WartośćMax;
                WartośćMax = TWF[0, 1];
                for (int i = 1; i < TWF.GetLength(0); i++)
                {
                    if (WartośćMax < TWF[i, 1])
                    {
                        WartośćMax = TWF[i, 1];
                    }
                    //zwrotne przekazanie minimalnej wartości funkcji
                }
                return WartośćMax;
            }
        }// od Metody Statyczne

        private void btnWykreślenieWykresu_Click(object sender, EventArgs e)
        {
            //pobranie danych wejściowych
            xl = float.Parse(tbxl.Text);
            xp = float.Parse(tbxp.Text);
            h = float.Parse(txtH.Text);
            //wyznaczenie liczby przedziałów h w przedziale [Xl, Xp]
            LiczbaPrzedziałówH = (int)((xp - xl)/h + 1);
            //utworzenie egzemplarza tablicy zmian wartości funkcji w przedziale w przedziale [xl,xp]
            TWF = new float[LiczbaPrzedziałówH + 1, 2];
            // stablicowanie funkcji w przedziale [xl, xp]
            int i; float X;
            for (i = 0, X = xl; i < TWF.GetLength(0); i++, X = X + i*h )
            {
                TWF[i, 0] = X;
                TWF[i, 1] = (float)(Math.Cos(X) * Math.Sin(X) * X / (1 + X * X));
            }
            // programowe podłączenie metody obsługo zdarzenia Paint do kontrolki PicBox
            pbRysownica.Paint += new PaintEventHandler(pbRysownica_Paint);
            //odświerzenie powierzchni kontrolki picturebox 
            pbRysownica.Refresh();
            this.Refresh();
        }

        void pbRysownica_Paint(object sender, PaintEventArgs e)
        {
            //utworzenie egzemplarza generatora liczb losowych
            Random rnd = new Random();
            Color KolorLiniiWykresu = Color.FromArgb(rnd.Next(0,255), rnd.Next(0,255), rnd.Next(0,255));
            //utworzenia pióra
            Pen Pióro = new Pen(KolorLiniiWykresu, 1.666666666666666F);
            //kreślenie linii wykresu
            for (int j = 0; j < TWF.GetLength(0) - 1; j++)
                Rysownica.DrawLine(Pióro, PrzeliczanieWspółrzędnych.WspX(TWF[j, 0]), 
                                          PrzeliczanieWspółrzędnych.WspY(TWF[j, 1]),
                                          PrzeliczanieWspółrzędnych.WspX(TWF[j+1, 0]),
                                          PrzeliczanieWspółrzędnych.WspY(TWF[j+1, 1]));


        }

        public static class PrzeliczanieWspółrzędnych
        {
            static float WspółczynnikSkaliDlaOsiX, WspółczynnikSkaliDlaOsiY;
            static float PrzesunięcieX, PrzesunięciaY;
            //deklaracja zmiennych dla przechowania rozmiarów "ekranu"
            static int Xe_max, Ye_max, Xe_min, Ye_min;
            static PrzeliczanieWspółrzędnych()
            {//deklaracja konstruktora klasy statycznej PrzeliczenieWspółrzędnych
                Xmin = UchwytFormularza.xl;
                Xmax = UchwytFormularza.xp;
                Ymin = MetodyStatyczne.MinFx(UchwytFormularza.TWF);
                Ymax = MetodyStatyczne.MinFx(UchwytFormularza.TWF);
                // ustalenie rozmiarów powierzchni graficznej 
                Xe_min = Margines;
                Xe_max = UchwytFormularza.pbRysownica.Width - 2 * Margines;
                Ye_min = Margines;
                Ye_max = UchwytFormularza.pbRysownica.Height - (Margines * 2);
                //wyznaczenie waartości współczynników skali i przesunięć
                WspółczynnikSkaliDlaOsiX = (Xe_max - Xe_min) / (Xmax - Xmin);
                WspółczynnikSkaliDlaOsiX = (Ye_max - Ye_min) / (Ymax - Ymin);
                PrzesunięcieX = Xe_min - Xmin * WspółczynnikSkaliDlaOsiX;
                PrzesunięciaY = Ye_min - Xmin * WspółczynnikSkaliDlaOsiY;

            }
            //deklaracja właściwości opisujacych rzeczywistą powierzchnię 
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
        //deklaracje metod odwzorowania współrzędnych 
        public static int WspX (float x)
            {
                return (int)(x * WspółczynnikSkaliDlaOsiX + PrzesunięcieX);
            }

        public static int WspY (float y)
            {
                return (int)(y * WspółczynnikSkaliDlaOsiY + PrzesunięciaY);
            }

        }

        private void Andrzejewski_Load(object sender, EventArgs e)
        {

        }
    }// od class PrzeliczanieWspółrzędnych

}
