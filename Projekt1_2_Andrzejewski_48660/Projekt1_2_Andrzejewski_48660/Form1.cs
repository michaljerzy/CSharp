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

namespace Projekt1_2_Andrzejewski_48660
{
    public partial class Andrzejewski : Form
    {
        float Margines = 20F;
        const int PromieńKulki = 10;
        Graphics WykresOsi;
        float Xmax, Ymax, Xs, Ys;
        int WspolczynnikSkaliDlaOsiY;
        Pen PioroXY, PioroSzereg;

        int PunktWjednostkachMiasryOsiY, PunktWjednostkachMiasryOsiX;
        int IndexPołożeniaKulek;

        Point[] PunktNaTorzeLiniiSzeregu;

        static void maObliczSumęSzeregu(float Fi, out float maSumaSzeregu)
        {//deklaracje pomocnicze
            float maw; //dla przechowywania wartości n-tego wyrazu szeregu
                       //ustalenie początkowego stanu obliczeń
            maSumaSzeregu = 0.0f;
            float maEps = 0.001F;
            maw = Fi;
            int maN = 0;
            //iteracyjne obliczanie sumy szeregu
            while (Math.Abs(maw) >= maEps) //Abs - moduł = |w|
            {// zwiększenie licznika zsumowanych wyrazów szeregu
                maN++;
                //obliczenie n - tej sumy częściowej szeregu
                maSumaSzeregu += maw;
                //obliczenie n - tego wyrazu szeregu
                maw *= (-1.0f) * ((((2 * maN) - 1) * Fi) / (((2 * maN) + 1) / Fi));
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //wykreślenie linii osi układu współrzędynch 
            WykresOsi.DrawLine(PioroXY, Xs - PunktWjednostkachMiasryOsiX / 2, Ymax / 2,
                Xs + PunktWjednostkachMiasryOsiX / 2, Ymax / 2);
            WykresOsi.DrawLine(PioroXY, Xs + Margines / 2, Ymax - 2 * Margines,
                Xs + Margines / 2, Margines);
            //wykreślenie linii toru SIN oraz COS
            WykresOsi.DrawCurve(PioroSzereg, PunktNaTorzeLiniiSzeregu);
            //wykreśnie kulek na obu torach linii SIN oraz COS według indeksu ustawionego przez zegar
            WykresOsi.FillEllipse(Brushes.Yellow, PunktNaTorzeLiniiSzeregu[IndexPołożeniaKulek].X
                - PromieńKulki, PunktNaTorzeLiniiSzeregu[IndexPołożeniaKulek].Y
                - PromieńKulki, 2 * PromieńKulki, 2 * PromieńKulki);

        }

        public Andrzejewski()
        {
            InitializeComponent();
            //Utworzenie egzemplarza pióra
            PioroSzereg = new Pen(Color.BlueViolet, 1F);
            PioroXY = new Pen(Color.DeepSkyBlue, 1F);
            PioroXY.DashStyle = DashStyle.Dash;
            //lokalizacja i zwymiarowanie formularza
            Location = new Point(20, 20);
            Width = (int)(Screen.PrimaryScreen.Bounds.Height * 1.2);
            Height = (int)(Screen.PrimaryScreen.Bounds.Height * 0.8);
            StartPosition = FormStartPosition.Manual;
            //Zablokowanie zmiany rozmiarów formularza
            SetAutoSizeMode(AutoSizeMode.GrowAndShrink);
            //lokalizacja i zwymiarowanie kontrolki PictureBox
            pictureBox1.Location = new Point(Left + 10, Top + 30);
            pictureBox1.Width = (int)(Width * 0.8F);
            pictureBox1.Height = (int)(Height * 0.7F);
            //Ustawienie koloru tła
            pictureBox1.BackColor = Color.LightBlue;
            //Utworzenie bitmapy
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            //Utworzenie egzemplarza powierzchni gragicznej
            WykresOsi = Graphics.FromImage(pictureBox1.Image);
            //określnie paramtrów Wykresu Osi
            Xmax = pictureBox1.Width;
            Ymax = pictureBox1.Height;
            //sformatowanie pióra dla wykreślenia osi układu współrzędnych
            PioroXY.StartCap = LineCap.Flat;
            //Utworzenie większego grotu strzałek
            AdjustableArrowCap DużyGrotStrzałki = new AdjustableArrowCap(5, 10);
            PioroXY.CustomEndCap = DużyGrotStrzałki;

            //wyznaczenie rozmiarów powierzchni graficznej
            Xmax = Size.Width - Margines;
            Ymax = Size.Height - Margines;
            //wyznaczenie współczynnika skali dla osi y
            WspolczynnikSkaliDlaOsiY = (int)Ymax / 8;
            //ustalenie jednolitej miary w radianach do obu osi
            PunktWjednostkachMiasryOsiX = (int)(WspolczynnikSkaliDlaOsiY * Math.PI);
            PunktWjednostkachMiasryOsiY = (int)(4 * PunktWjednostkachMiasryOsiY);
            //Wyznaczenie środka układu współrzędnych
            Xs = Xmax / 2;
            Ys = Ymax / 2;
            //Utworzenie egzemplarza tablicy opisu punktów na torze naszego szeregu
            PunktNaTorzeLiniiSzeregu = new Point[PunktWjednostkachMiasryOsiX + 1];
            //Deklaracje i ustawienie początkowe przed wyznaczniem współrzędnych linii toru
            float Fi, Fi_w_Radianach;
            IndexPołożeniaKulek = 0;
            float PrzyrostZmianX = (Xmax - 2 * Margines) / PunktWjednostkachMiasryOsiX;
            int IndexPunktowyOsiX;
            int maN = 1;
            float maSumaSzeregu;
            // wyznacznie współrzenych linii toru
            for(Fi = Xs - PunktWjednostkachMiasryOsiX / 2 + Margines, IndexPunktowyOsiX = 0; IndexPunktowyOsiX <= PunktWjednostkachMiasryOsiX; Fi = Fi + PrzyrostZmianX)
            {
                //Przeliczenie kąta Fi na radiany
                Fi_w_Radianach = (float)((Fi * Math.PI) / 180F);
                maN++;
                maObliczSumęSzeregu(Fi, out maSumaSzeregu);
                //Wyznacznie współrzędnych dla kolejdnego punktu toru na osi
                PunktNaTorzeLiniiSzeregu[IndexPunktowyOsiX] = new Point((int)Fi, (int)maSumaSzeregu);
            }
        }
    }
}
