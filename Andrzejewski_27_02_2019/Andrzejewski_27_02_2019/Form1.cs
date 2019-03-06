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

namespace Andrzejewski_27_02_2019
{
    public partial class Andrzejewski : Form
    {
        Graphics SzybaSamochodowa;
        const int Margines = 40;
        const float StartFi = 145F;
        const float KoniecFi = 35F;
        bool KierunekWprawo = true;
        float PrzyrostKataFi = 1.1F;
        // deklaracje pomocnicze
        float Xo, Yo,Xmax, Ymax, R, KątFi, Fi_Radiant;

        private void btnWycieraczki_Click(object sender, EventArgs e)
        {
            //ustawienie interwału dla zegara
            timer1.Interval = trbSuwakPrędkości.Value;
            //włączenie zegara
            timer1.Enabled = true;
            //pierwsze wykreślenie wycieraczek
            picBoxRysownica.Refresh();
        }

        private void btnZatrzymaj_Click(object sender, EventArgs e)
        {
            //wyłączenie zegara
            timer1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //wyłączenie zegara
            timer1.Enabled = false;
            //wymazanie wycieraczek
            SzybaSamochodowa.Clear(Color.LightGreen);
            // wyzwolenie zdarzenia paint dla kontrolki pictrebox 
            picBoxRysownica.Refresh();
        }

        private void Andrzejewski_Load(object sender, EventArgs e)
        {
            //lokalizacja i ewentualnie zwymiarowanie kontrolek umieszczonych na formularzu
            lblSuwak.Location = new Point(picBoxRysownica.Location.X +
                picBoxRysownica.Width + 20, picBoxRysownica.Location.Y);
            trbSuwakPrędkości.Location = new Point(lblSuwak.Location.X,
                lblSuwak.Location.Y + lblSuwak.Height + 10);
            btnWycieraczki.Location = new Point(trbSuwakPrędkości.Location.X,
                trbSuwakPrędkości.Location.Y + trbSuwakPrędkości.Height + 10);
            btnZatrzymajWycieraczki.Location = new Point(btnWycieraczki.Location.X,
                btnWycieraczki.Location.Y + btnWycieraczki.Height + 10);
            btnWyłaczWycieraczki.Location = new Point(btnZatrzymajWycieraczki.Location.X,
                btnZatrzymajWycieraczki.Location.Y + btnZatrzymajWycieraczki.Height + 10);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // obsługa "tikół" od zegarka
            if(KierunekWprawo)
            {
                //sprawdzenie czy wycieraczki nie doszłt do skrajnego położenia
                if(KątFi < KoniecFi)
                {
                    //zmiana kierunku ruchu wycueraczek
                    KierunekWprawo = false;
                    //zmiana kolotu pióra
                    Pióro.Color = KolorRuchWlewo;
                }
                else
                {
                    if(KątFi > StartFi)
                    {
                        //zmiana kierunku ruchu wycieraczek
                        KierunekWprawo = true;
                        // zmiana koloru pióra
                        Pióro.Color = KolorRuchWprawo;
                    }
                }
                //wyzwolenie zdarzenia Paint dla kontrolki picture box dla wykreślenia wycieraczek w nowym położeniu
                picBoxRysownica.Refresh();
            }
        }

        // uchwyty wycieraczek 
        float Xs_1, Ys_1, Xs_2, Ys_2;
        //kolory wycieraczek
        Color KolorRuchWprawo, KolorRuchWlewo;
        // deklaracja pióra
        Pen Pióro;

        private void picBoxRysownica_Paint(object sender, PaintEventArgs e)
        {
            //wymazanie starego położenia wycieraczki
            SzybaSamochodowa.Clear(Color.LightGreen);
            //sprawdzenie kieruunku ruchu wycieraczki
            if (KierunekWprawo)
            {
                KątFi = KątFi - PrzyrostKataFi;
            }
            else
            {
                KątFi = KątFi + PrzyrostKataFi;
            }

            // przeliczenie kąta Fi na radiany
            Fi_Radiant = (float)(KątFi * Math.PI / 180);
            // wyznaczenie współrzędnych "końca" wycieraczki z okręgu
            Xo = (float)(Xs_1 + R * Math.Cos(Fi_Radiant));
            Yo = (float)(Ys_1 - R * Math.Sin(Fi_Radiant));
            //wykreślenie 1 wycieraczki w nowym położeniu
            SzybaSamochodowa.DrawLine(Pióro, Xs_1, Ys_1, Xo, Yo);
            //wyznaczenie współrzędnych końca drugiej wycieraczki
            Xo = (float)(Xs_2 + R * Math.Cos(Fi_Radiant));
            Yo = (float)(Ys_2 - R * Math.Sin(Fi_Radiant));
            //wykreślenie 1 wycieraczki w nowym położeniu
            SzybaSamochodowa.DrawLine(Pióro, Xs_2, Ys_2, Xo, Yo);
        }

        

        public Andrzejewski()
        {
            InitializeComponent();

            //lokalizacja i zwymiarownia formularza
            this.Location = new Point(20, 20);
            this.Width = (int)(Screen.PrimaryScreen.Bounds.Height * 0.9F);
            this.Height = (int)(Screen.PrimaryScreen.Bounds.Height * 0.8F);
            this.StartPosition = FormStartPosition.Manual;
            //zablokowanie zmiany rozmiarów formularza
            this.SetAutoSizeMode(System.Windows.Forms.AutoSizeMode.GrowAndShrink);
            //lokalizacja i zwymiarowanie kontrolki PictureBox
            picBoxRysownica.Location = new Point(this.Left + 30, this.Top + 30);
            picBoxRysownica.Width = (int)(this.Width * 0.8F);
            picBoxRysownica.Width = (int)(this.Height * 0.8F);
            //ustawienie koloru tła dla kontrolki PictureBox
            picBoxRysownica.BackColor = Color.LightGreen;
            // obramowanie kontrolki PictureBox, czli szybu samochodowej
            picBoxRysownica.BorderStyle = BorderStyle.Fixed3D;
            // utworzenie bitmapy dla picture box
            picBoxRysownica.Image = new Bitmap(picBoxRysownica.Width, picBoxRysownica.Height);
            // utworzenie egzemplarza powierzchni graficznej na bit mapie
            SzybaSamochodowa = Graphics.FromImage(picBoxRysownica.Image);
            //określenie parametru szyby samochodowej
            Xmax = picBoxRysownica.Width;
            Ymax = picBoxRysownica.Height;
            //wyznaczenie współrzednych "uchwytów" wycieraczek
            Xs_1 = Xmax / 4;
            Ys_1 = Ymax / 2 + Ymax / 4;
            Xs_2 = 3 * Xs_1;
            Ys_1 = Ys_2;
            //wyznaczenie promienia okręgi po którym przemieszcza się ruchomy koniec wycieraczek
            R = Ymax / 2 - Margines;
            //ustawienie kąta startu ruchu wycieraczek
            KątFi = StartFi;
            // ustalenie koloru wycieraczek
            KolorRuchWprawo = Color.Red;
            KolorRuchWlewo = Color.YellowGreen;
            // sformatowanie pióra
            Pióro = new Pen(KolorRuchWprawo, 8F);
            Pióro.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            Pióro.StartCap = System.Drawing.Drawing2D.LineCap.RoundAnchor;
            Pióro.EndCap = System.Drawing.Drawing2D.LineCap.Round;

        }
    }
}
