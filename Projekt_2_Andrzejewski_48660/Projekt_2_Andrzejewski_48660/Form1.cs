
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

namespace Projekt_2_Andrzejewski_48660
{
    
    public partial class Form1 : Form
    {
        public static Form1 Uchwyt;
        List<TypFigury> LBG = new List<TypFigury>();
        Graphics Rysownica;
        bool paint = false;
        SolidBrush color;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {


            if (paint)
            {
                color = new SolidBrush(Color.Black);
                Graphics Rysownica1 = panel1.CreateGraphics();
                Rysownica1.FillEllipse(color, e.X, e.Y, 10, 10);
                Rysownica1.Dispose();

            }

        }

        private void butClear_Click(object sender, EventArgs e)
        {
            Graphics Rysownica = panel1.CreateGraphics();
            Rysownica.Clear(panel1.BackColor);
        }

        private void picBoxTrojkat_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_BackgroundImageChanged(object sender, EventArgs e)
        {

        }

        private void picBoxProstokat_Click(object sender, EventArgs e)
        {
            
        }

        private void picBoxProstokat_MouseClick(object sender, MouseEventArgs e)
        {
            ShowDialog();
        }

        private void button1_BackgroundImageLayoutChanged(object sender, EventArgs e)
        {

        }

        private void matxbPołożenieX_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void panel1_Move(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void picBoxPunkt_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
