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

namespace Projekt1_Andrzejewski_48660
{
    public partial class Form1 : Form
    {

        Graphics Rysownica;
        Pen Wykres;
        Pen Pioro;

        //deklaracje stały opisujących pęd linii "skrajne" położenie pęku lini
        const int Margines = 30; // odstęp czubka wachkarza od górnej krawędzi formularza
        const float StartFi = 145F; // kąt lewej krawędzi wachlarza (peku linii)
        const float KoniecFi = 35F; // kąt prawej krawędzi wachlarza
        const float PrzyrostKątaFi = 2.1F; //Przyrost zmiany kąta Fi

        int Xo, Yo, Xs, Ys, Xmax, Ymax;

        public Form1()
        {
            InitializeComponent();
            //zwymiarowanie formularza
            this.Location = new Point(40, 40);
            this.Width = (int)(Screen.PrimaryScreen.Bounds.Height * 1.2F);
            this.Height = (int)(Screen.PrimaryScreen.Bounds.Height * 0.9F);
            this.StartPosition = FormStartPosition.Manual;
            //zablokowanie zmiany rozmiarów formularza
            this.SetAutoSizeMode(AutoSizeMode.GrowAndShrink);
            //lokalizacja, kolor i zwymiarownie kontrolki picturebox
            picBoxRysownica.Location = new Point(this.Left + 5, this.Top + 20);
            picBoxRysownica.Width = (int)(this.Width * 0.65F);
            picBoxRysownica.Height = (int)(this.Height * 0.8F);
            picBoxRysownica.BackColor = Color.LightGray;
            //obramowanie PictureBox
            picBoxRysownica.BorderStyle = BorderStyle.Fixed3D;
            // utworzenie bitmapy dla picture box
            picBoxRysownica.Image = new Bitmap(picBoxRysownica.Width, picBoxRysownica.Height);
            // utworzenie bitmap dla picture box
            Rysownica = Graphics.FromImage(picBoxRysownica.Image);
            //określenie parametru szyby samochodowej
            Xmax = picBoxRysownica.Width;
            Ymax = picBoxRysownica.Height;
            

        }

        private void picBoxRysownica_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        

        }

        private void picBoxRysownica_Paint(object sender, PaintEventArgs e)
        {
            //utworzenie egzemplarza pióra
            Pioro = new Pen(Color.LightPink, 1000F);
            //ustawienie atrybutów pióra
            Pioro.DashStyle = DashStyle.Solid;
            //ustawienie zakończeń linii układu współrzędnych
            Pioro.StartCap = LineCap.Square;
            Pioro.EndCap = LineCap.ArrowAnchor;

            Rysownica.DrawLine(Pioro, 43, 43, 1, 1);

        }
    }
}
