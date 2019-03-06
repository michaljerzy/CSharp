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

namespace _06_03_2019_Andrzejewski
{
    public partial class Andrzejewski : Form
    {
        // Deklaracja stałych
        const int Margines = 10;
        const int PromieńKulki = 20;
        //deklaracja zmiennych referencyjnych do obiektów graficznych
        Graphics Rysownica;
        Pen PioroXY, PioroSIN, PioroCOS;
        // deklaracja zmiennych pomocniczych
        int Xmax, Ymax, Xs, Ys;

        private void Andrzejewski_Paint(object sender, PaintEventArgs e)
        {
            //wykreślenie linii osi układu współrzędynch 
            Rysownica.DrawLine(PioroXY, Xs - PunktWjednostkachMiasryOsiX / 2, Ymax / 2,
                Xs + PunktWjednostkachMiasryOsiX / 2, Ymax / 2);
            Rysownica.DrawLine(PioroXY, Xs + Margines / 2, Ymax - 2 * Margines,
                Xs + Margines / 2, Margines);
            //wykreślenie linii toru SIN oraz COS
            Rysownica.DrawCurve(PioroSIN, PunktyNaTorzeLiniiSIN);
            Rysownica.DrawCurve(PioroCOS, PunktyNaTorzeLiniiCOS);
            //wykreśnie kulek na obu torach linii SIN oraz COS według indeksu ustawionego przez zegar
            Rysownica.FillEllipse(Brushes.Yellow, PunktyNaTorzeLiniiSIN[IndexPołożeniaKulek].X
                - PromieńKulki, PunktyNaTorzeLiniiSIN[IndexPołożeniaKulek].Y
                - PromieńKulki, 2 * PromieńKulki, 2 * PromieńKulki);

            Rysownica.FillEllipse(Brushes.Green, PunktyNaTorzeLiniiCOS[IndexPołożeniaKulek].X
                - PromieńKulki, PunktyNaTorzeLiniiCOS[IndexPołożeniaKulek].Y
                - PromieńKulki, 2 * PromieńKulki, 2 * PromieńKulki);


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (IndexPołożeniaKulek < PunktWjednostkachMiasryOsiX)
                IndexPołożeniaKulek ++;
            else
                IndexPołożeniaKulek = 0;
            //odświerzenie powierzchni graficznej
            this.Refresh();
        }

        int WspolczynnikSkaliDlaOsiY, PunktWjednostkachMiasryOsiY, PunktWjednostkachMiasryOsiX;
        int IndexPołożeniaKulek;
        //deklaracje tablic dla przechowania współrzędnych punktów toru animacji
        Point[] PunktyNaTorzeLiniiSIN, PunktyNaTorzeLiniiCOS;


        public Andrzejewski()
        {
            InitializeComponent();
            // lokalizacja i zwymiraowanie formularza
            this.Location = new Point(10, 10);
            this.Width = (int)(Screen.PrimaryScreen.Bounds.Width * 0.75F);
            this.Height = (int)(Screen.PrimaryScreen.Bounds.Height * 0.75F);
            this.StartPosition = FormStartPosition.Manual;
            //Utworzenie egzemplarza powierzchni graficznej
            Rysownica = this.CreateGraphics();
            //utworzenie egzemplarza  piór 
            PioroSIN = new Pen(Color.BlueViolet, 1F);
            PioroCOS = new Pen(Color.CadetBlue, 1F);
            PioroXY = new Pen(Color.DeepSkyBlue, 1F);
            PioroXY.DashStyle = DashStyle.Dash;

            //sformatowanie pióra dla wykreślenia osi układu współrzędnych
            PioroXY.StartCap = LineCap.Flat;
            //utworzenie większego grotu strzałek
            AdjustableArrowCap DużyGrotStrzałki = new AdjustableArrowCap(5, 10);
            PioroXY.CustomEndCap = DużyGrotStrzałki;

            // wyznaczenie rozmiarów powierzchni graficznej
            Xmax = this.Size.Width - Margines;
            Ymax = this.Size.Height - Margines;
            //wyznacznie współczynnika skali dla osi Y
            WspolczynnikSkaliDlaOsiY = Ymax / 8;
            // ustalenie jednolitej miart w radianach do obu osi
            PunktWjednostkachMiasryOsiY = (int)(WspolczynnikSkaliDlaOsiY * Math.PI);
            PunktWjednostkachMiasryOsiX = (int)(4 * PunktWjednostkachMiasryOsiY);
            //wyznaczeniee środka układu współrzędnych
            Xs = Xmax / 2;
            Ys = Ymax / 2;
            //Utworzenie egzemplarzy tablic opisu punktów na torze SIN oraz COS
            PunktyNaTorzeLiniiSIN = new Point[PunktWjednostkachMiasryOsiX + 1];
            PunktyNaTorzeLiniiCOS = new Point[PunktWjednostkachMiasryOsiX + 1];
            // deklaracje i ustawienia początkowe przed wyznaczeniem współrzędnych linii toru
            float Fi, Fi_w_Radianach;
            IndexPołożeniaKulek = 0;
            int PrzrostZmianX = (Xmax - 2 * Margines) / PunktWjednostkachMiasryOsiX;
            int IndexPunktowOsiX;
            // wyznaczenie współrzędnych linii toru
            for (Fi = Xs - PunktWjednostkachMiasryOsiX / 2 + Margines, IndexPunktowOsiX = 0; 
                IndexPunktowOsiX <= PunktWjednostkachMiasryOsiX; Fi = Fi + PrzrostZmianX)
            {//przeliczenie kąta Fi na Radiany
                Fi_w_Radianach = (float)((Fi * Math.PI) / 180F);
                //wyznaczenie współrzędnych dla kolejnego puntktu toru linii SIN oraz COS
                PunktyNaTorzeLiniiSIN[IndexPunktowOsiX] =
                new Point((int)Fi, Ys - (int)(WspolczynnikSkaliDlaOsiY * Math.Sin(Fi_w_Radianach)));
                PunktyNaTorzeLiniiSIN[IndexPunktowOsiX] =
                new Point((int)Fi, Ys + (int)(WspolczynnikSkaliDlaOsiY * Math.Cos(Fi_w_Radianach)));
                // zwiększamy index punktu na linii toru
                IndexPunktowOsiX++;
            }
            //ustawienie interwału dla zegara i jego uaktywnienie
            timer1.Interval = 6;
            timer1.Enabled = true;
        }

        private void Andrzejewski_Load(object sender, EventArgs e)
        {

        }
    }
}
