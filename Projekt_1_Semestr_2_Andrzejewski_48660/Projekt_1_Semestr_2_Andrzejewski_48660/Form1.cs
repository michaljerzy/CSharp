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
using System.Drawing;
using static Projekt_1_Semestr_2_Andrzejewski_48660.Punkt;
using static Projekt_1_Semestr_2_Andrzejewski_48660.WielokątForemny;

namespace Projekt_1_Semestr_2_Andrzejewski_48660
{
    public partial class Andrzejewski : Form
    {
        const int Margines = 10;
        const int promieńPunktu = 3;
        Graphics Rysownica;
        Point Punkt;
        Pen Pióro;
        Graphics RysownicaTymczasowa;
        Pen PióroTymczasowe = new Pen(Color.Black, 1);
        static Andrzejewski Chwytak;

        public Andrzejewski()
        {
            InitializeComponent();
            maPBRysownica.Image = new Bitmap(maPBRysownica.Width, maPBRysownica.Height);
            Rysownica = Graphics.FromImage(maPBRysownica.Image);
            
        }

        private void maPBRysownica_MouseDown(object sender, MouseEventArgs e)
        {
            txtX.Text = e.Location.X.ToString();
            txtY.Text = e.Location.Y.ToString();

            if (e.Button == MouseButtons.Left)
                Punkt = e.Location;
        }

        private void maPBRysownica_MouseUp(object sender, MouseEventArgs e)
        {
            txtX.Text = e.Location.X.ToString();
            txtY.Text = e.Location.Y.ToString();
            int lewyGórnyNarożnikX = (Punkt.X > e.Location.X) ? e.Location.X : Punkt.X;
            int lewyGórnyNarożnikY = (Punkt.Y > e.Location.Y) ? e.Location.Y : Punkt.Y;
            int Szerokość = Math.Abs(Punkt.X - e.Location.X);
            int Wysokość = Math.Abs(Punkt.Y - e.Location.Y);
        }
        /*
        private void timer1_Tick(object sender, EventArgs e)
        {
            Rysownica.Clear()
        }
        */
    }
}
