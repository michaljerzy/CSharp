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

namespace SinusCosinusy
{
    public partial class Form1 : Form
    {

        
        
        //deklaracja zmiennej referencyjnej do egzemplarza powierzchni graficznej
        Graphics Rysownica;
        //deklaracja zmiennej referencyjnej egzemplarza pióra
        Pen Pioro;

        Pen Wykres;

        Pen kolo;

        //deklaracje stały opisujących pęd linii "skrajne" położenie pęku lini
        const int Margines = 30; // odstęp czubka wachkarza od górnej krawędzi formularza
        const float StartFi = 145F; // kąt lewej krawędzi wachlarza (peku linii)
        const float KoniecFi = 35F; // kąt prawej krawędzi wachlarza
        const float PrzyrostKątaFi = 2.1F; //Przyrost zmiany kąta Fi

        int Xo, Yo, Xs, Ys, Xmax, Ymax;

        private void tbGrubość_Scroll_Scroll(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            kolo = new Pen(Color.Red, 0.05F);
            //utworzenie egzemplarza pióra
            Pioro = new Pen(Color.DarkBlue, 1F);
            // ustawienie atrybutów pióra
            Pioro.DashStyle = DashStyle.Dash;
            // ustawienie zakończeń linii osi układu współrzędnych
            Pioro.StartCap = LineCap.Square;
            Pioro.EndCap = LineCap.ArrowAnchor;
            //utworzenie egzemnplarza wykres
            Wykres = new Pen(Color.DarkOliveGreen, 5F);
            // ustawienie atrybutów wykresu
            Wykres.DashStyle = DashStyle.Solid;
            // wykreślenie osi ukłau współrzędnych
            Rysownica.DrawLine(Pioro, Margines, Ymax / 2, Xmax - Margines, Ymax / 2);
            Rysownica.DrawLine(Pioro, Xmax / 2, Ymax - Margines, Xmax / 2, Margines);
            // wykreślenie lini 1 i -1
            Rysownica.DrawLine(Pioro, 200000F, 35F,35F,173F);
            Rysownica.DrawLine(Pioro, 200000F, 35F, 35F, 259F);


            float x1 = 0;
            float y1 = 0;
            float y2 = 0;

            float yEx = 215;
            float eF = 41.6F;

            for(float x = 0; x < 20; x += 0.001F)
            {
                y2 = (float)Math.Sin(x);

                //Rysownica.DrawEllipse(kolo, 50, 50, 200, 200);

                Rysownica.DrawLine(Wykres, x1 * eF, y1 * eF + yEx, x * eF, y2 * eF + yEx);
                x1 = x;
                y1 = y2;
            }


            Pioro.Color = Color.Green;
            Pioro.DashStyle = DashStyle.Solid;
            Pioro.EndCap = LineCap.Round;

            //Wykreślenie (wymalowanie) opisów tekstowych osi układu współrzędnych
            //deklaracja pędzla
            SolidBrush PedzelZnakow = new SolidBrush(Color.RoyalBlue);
            //ustalenie czcionki dla opusi osi 
            Font FontOpisuOsi = new Font("Times New Roman", 10, FontStyle.Bold);
            // określenie rozmiatu powierzchni dla opisu osi Y
            SizeF RozmiarPowierzchniOpisuOsiY = Rysownica.MeasureString(" Y", FontOpisuOsi);
            //Ustalenie odstępu od osi Y
            Point offsetDlaOsiY = new Point(10, 10);
            //lokalizacja opisu osi Y
            PointF LokalizacjaOpisuOsiY = new PointF(Rysownica.VisibleClipBounds.Width / 2 - offsetDlaOsiY.X, RozmiarPowierzchniOpisuOsiY.Height - offsetDlaOsiY.Y);
            //wykreślenie odpisu osi Y
            Rysownica.DrawString(" Y", FontOpisuOsi, PedzelZnakow, LokalizacjaOpisuOsiY);
            // wykreślenie opisu osi X
            SizeF RozmiarPowierzchniOpisuOsiX = Rysownica.MeasureString(" X", FontOpisuOsi);
            //ustalenie odstępu od osi X
            Point offsetDlaOsiX = new Point(20, 10);
            //lokalizacha opisu osi X
            PointF LokalizacjaOpisuOsiX = new PointF(Rysownica.VisibleClipBounds.Width - RozmiarPowierzchniOpisuOsiX.Width - offsetDlaOsiX.X,
            Rysownica.VisibleClipBounds.Height / 2 -
            RozmiarPowierzchniOpisuOsiY.Height + offsetDlaOsiY.Y);
            //wykreślenie opisu oosi X
            Rysownica.DrawString(" X", FontOpisuOsi, PedzelZnakow, LokalizacjaOpisuOsiX);
            //zwolnienie zasobów graficznych
            Pioro.Dispose();
            PedzelZnakow.Dispose();
            Rysownica.Dispose();
        }

        float R, KatFi, FiWradianach;


        public Form1()
        {
            InitializeComponent();
            //lokalizacja i zwymiarowanie formularza
            this.Location = new Point(20, 20);
            this.Width = (int)(Screen.PrimaryScreen.Bounds.Width * 0.6F);
            this.Height = (int)(Screen.PrimaryScreen.Bounds.Height * 0.6F);
            this.StartPosition = FormStartPosition.Manual;
            /* zablokowanie zmian rozmiarów formularza techniką "Przeciągania krawędzi" */
            this.SetAutoSizeMode(System.Windows.Forms.AutoSizeMode.GrowAndShrink);
            //ustalenie koloru powierzchni formularza (i Rysownicy)
            this.BackColor = Color.LightBlue;
            //utworzenie egzemolarza powierzchni grafizcznej, czyli rysownicy
            Rysownica = this.CreateGraphics();
            //określenie maksymalnych współrzędnych Rysownicy
            Xmax = this.Size.Width - Margines;
            Ymax = this.Size.Height - Margines;
            //wyznaczenie środka układu współrzędnych
            Xs = Xmax / 2;
            Ys = Ymax / 2;
            // wyznaczenie promienia okręgi po którym będzie przemieszczał drugi punkt linii kreślonego wachlarza
            R = Ymax / 2 - 2 * Margines;
        }
    }
}
