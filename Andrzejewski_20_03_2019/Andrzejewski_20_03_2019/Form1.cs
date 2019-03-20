using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//dodanie przestrzeni nazw 2D
using System.Drawing.Drawing2D;

namespace Andrzejewski_20_03_2019
{
    public partial class Andrzejewski : Form
    {// deklaracja rysownicy
        Graphics Rysownica;
        Punkt[] TablFigGeom;
        int IndexFigur;
        //deklaracje stałych
        const int MarginesPanel = 10;
        const int MarginesFormularza = 20;

        public Andrzejewski()
        {
            InitializeComponent();
            //lokalizacja i zwymiarowanie formularza
            this.Left = MarginesFormularza;
            this.Top = MarginesFormularza;
            this.Width = (int)(Width * 1.1F);
            this.Height = (int)(Height * 0.9F);
            this.StartPosition = FormStartPosition.Manual;
            //loklizacja i zwymiarowanie kontrolki panel
            panelRysownica.Location = new Point(txtN.Location.X + txtN.Width + 50, 3 * MarginesFormularza);
            panelRysownica.Width = (int)(this.Width * 0.6F);
            panelRysownica.Height = (int)(this.Height * 0.7F);
            panelRysownica.BackColor = Color.Beige;
            panelRysownica.BorderStyle = BorderStyle.Fixed3D;
            //lokalizacha kontrolki wyboru figur geometrycznych
            checkedListBox1.Location = new Point(panelRysownica.Location.X + panelRysownica.Width + MarginesFormularza,
                panelRysownica.Location.Y);
            lblwybierzfigurę.Location = new Point(checkedListBox1.Location.X, (int)(checkedListBox1.Location.Y * 0.1F));
            butStart.Location = new Point(checkedListBox1.Location.X, (int)(checkedListBox1.Location.Y - 32));
            //utworzenie egzemplarza powierzchni graficznej
            Rysownica = panelRysownica.CreateGraphics();
        }
        class Punkt
        {
            const int PromieńPuntu = 5;
            int RozmiarPunktu;
            // deklaracja atrybutów, które mają być dostępne dla klas pochodnycych
            protected int X;
            protected int Y;
            protected Color Kolor;
            protected bool Widoczny;
            //atrybuty dla klas pochodnych 
            protected DashStyle StylLinii;
            protected int GrubośćLinii;
            //deklaracje konstruktorow 
            public Punkt(int x, int y)
            {
                X = x;
                Y = y;
                //ustawienia domyślne
                RozmiarPunktu = 2 * PromieńPuntu;
                Kolor = Color.Black;
                GrubośćLinii = 1;
                StylLinii = DashStyle.Solid;
                Widoczny = false;

            }
            public Punkt(int X, int Y, Color Kolor)
            {
                //autoreferencja
                this.X = X;
                this.Y = Y;
                this.Kolor = Kolor;
                //ustawienia domyślne
                RozmiarPunktu = 2 * PromieńPuntu;
                Kolor = Color.Black;
                GrubośćLinii = 1;
                StylLinii = DashStyle.Solid;
                Widoczny = false;
            }
            //deklarache metrod prywatnych
            private void UstawXY(int x, int y)
            {
                X = x;
                Y = y;
            }

            private void UstawXY(Point NowaLokalizacja)
            {
                X = NowaLokalizacja.X;
                Y = NowaLokalizacja.Y;
            }
            //deklaracja metod publicznych przycisków dla obsługi przycisków funkcjonalnych programu
            public void PrzesuńDoNowegoXY(Control Kontrolka, Graphics PowierzchniaGraficzna, int x, int y)
            {
                Wymaz(Kontrolka, PowierzchniaGraficzna);
                UstawXY(x, y);
                Wykresl(PowierzchniaGraficzna);
            }
            public void FormatujFG(Color Kolor, DashStyle StylLinii, int GruboscLinii)
            {
                this.Kolor = Kolor;
                this.StylLinii = StylLinii;
                this.GrubośćLinii = GrubośćLinii;
            }
            //deklaracja metod wirtualnych
            public virtual void Wykresl(Graphics PowierzchniaGraficzna)
            {
                //wykreślenie (wymalowanie) punktu
                SolidBrush Pedzel = new SolidBrush(Kolor);
                PowierzchniaGraficzna.FillEllipse(Pedzel, X - RozmiarPunktu / 2, Y = RozmiarPunktu / 2, RozmiarPunktu, RozmiarPunktu);
                //ustawienie atrybutu widoczności
                Widoczny = true;
                Pedzel.Dispose();

            }

            public virtual void Wymaz(Control Kontrolka, Graphics PowierzchniaGraficzna)
            {
                if (Widoczny)
                {
                    SolidBrush Pedzel = new SolidBrush(Kontrolka.BackColor);
                    PowierzchniaGraficzna.FillEllipse(Pedzel, X - RozmiarPunktu / 2, Y = RozmiarPunktu / 2, RozmiarPunktu, RozmiarPunktu);
                    //ustawienie atrybutu widoczności
                    Widoczny = false;
                    Pedzel.Dispose();
                }
            }
        }//do klasy punkt
        class Linia : Punkt
        {
            //deklaracja atrybutu geometrycznego końca linii
            int Xk, Yk;
            //deklaracje kontruktorów
            public Linia(int Xp, int Yp, int Xk, int Yk):base (Xp, Yp)
            {
                this.Xk = Xk;
                this.Yk = Yk;
            }

            public Linia(int Xp, int Yp, int Xk, int Yk, Color Kolor, DashStyle StylLinii, int GruboscLinii) : base(Xp, Yp, Kolor)
            {
                this.Xk = Xk;
                this.Yk = Yk;
                this.StylLinii = StylLinii;
                this.GrubośćLinii = GrubośćLinii;
            }
            //nadpisanie metod wirtualnych
            public override void Wykresl(Graphics PowierzchniaGraficzna)
            {
                Pen Pioro = new Pen(Kolor, GrubośćLinii);
                Pioro.DashStyle = StylLinii;
                //wykreślenie linii
                PowierzchniaGraficzna.DrawLine(Pioro, X, Y, Xk, Yk);
                //utworzenie atrybutów widoczności
                Widoczny = true;
                Pioro.Dispose();
            }
            public override void Wymaz(Control Kontrolka, Graphics PowierzchniaGraficzna)
            {
                if (Widoczny)
                {
                    Pen Pioro = new Pen(Kontrolka.BackColor, GrubośćLinii);
                    Pioro.DashStyle = StylLinii;
                    //wykreślenie linii
                    PowierzchniaGraficzna.DrawLine(Pioro, X, Y, Xk, Yk);
                    //utworzenie atrybutów widoczności
                    Widoczny = true;
                    Pioro.Dispose();
                }
            }
        }// od klasy linia
        class Elipsa : Punkt
        {
            protected int OśDuża;
            protected int OśMała;
            // deklaracje konstruktorów
            public Elipsa(int x, int y, int OśDuża, int OśMała, Color Kolor, DashStyle StylLinii, int GrubośćLinii): base(x, y, Kolor)
            {
                this.OśDuża = OśDuża;
                this.OśMała = OśMała;
                this.StylLinii = StylLinii;
                this.GrubośćLinii = GrubośćLinii;
            }
            //nadpisanie metod wirtualnych
            public override void Wykresl(Graphics PowierzchniaGraficzna)
            {
                Pen Pioro = new Pen(Kolor, GrubośćLinii);
                Pioro.DashStyle = StylLinii;
                //wykreślenie linii
                PowierzchniaGraficzna.DrawEllipse(Pioro, X - OśDuża/2, Y - OśMała/2, OśDuża, OśMała);
                //utworzenie atrybutów widoczności
                Widoczny = true;
                Pioro.Dispose();
            }

            public override void Wymaz(Control Kontrolka, Graphics PowierzchniaGraficzna)
            {
                if (Widoczny)
                {
                    Pen Pioro = new Pen(Kontrolka.BackColor, GrubośćLinii);
                    Pioro.DashStyle = StylLinii;
                    //wykreślenie linii
                    PowierzchniaGraficzna.DrawEllipse(Pioro, X - OśDuża / 2, Y - OśMała / 2, OśDuża, OśMała);
                    //utworzenie atrybutów widoczności
                    Widoczny = false;
                    Pioro.Dispose();
                }
            }
        }//od klasy ellipsa 

        private void butStart_Click(object sender, EventArgs e)
        {
            int N; //ilośc figur
            //pobranie ze sprawdzeniem liczby figur geometrycznych do prezentacji
            if (string.IsNullOrEmpty(txtN.Text.Trim()))
            {
                // zapalenie errorprovider
                errorProvider1.SetError(txtN, "ERROR: musisz podać liczbę figur geometrycznych ");
                return;
            }
            else
                errorProvider1.Dispose();
            //pobranie liczby figur
            if(!int.TryParse(txtN.Text, out N))
            {
                // zapalenie errorprovider
                errorProvider1.SetError(txtN, "ERROR: Wystąpił niedozwolony znak w zapisie liczby figur");
                return;
            }
            else 
                //sprawdzenie warunku wejściowego na N: N > 0
                if (N <= 0)
            {
                // zapalenie errorprovider
                errorProvider1.SetError(txtN, "ERROR: musisz podać liczbę wiekszą od zera ");
                return;
            }
            //utworzenie egzemplarza tablicy "ewidencji" figur geometrycznych 
            TablFigGeom = new Punkt[N];
            // ustawienie indeksu dla tablicy TablFigGeom
            IndexFigur = 0;
            //ustawienie braku aktywności dla kontrolki 
            txtN.Enabled = false;
        }
    }
}
