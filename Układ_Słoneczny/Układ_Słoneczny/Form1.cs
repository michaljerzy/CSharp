using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Układ_Słoneczny
{
    public partial class Form1 : Form
    {
        int counter = 0;


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
            //lokalizaca i zwymiarowanie formularza
            Location = new Point(20, 20);
            Width = (int)(Screen.PrimaryScreen.Bounds.Height * 2);
            Height = (int)(Screen.PrimaryScreen.Bounds.Height * 1.4);
            StartPosition = FormStartPosition.Manual;
            timer1.Interval = 10;
            timer1.Tick += new EventHandler(timer1_Tick);
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
                int x = pictureBox1.Location.X;
                int y = pictureBox1.Location.Y;
                pictureBox1.Location = new Point(x + 25, y+5);
                int s = pictureBox2.Location.X;
                int o = pictureBox2.Location.Y;
                pictureBox2.Location = new Point(x + 10, y);
            int q = pictureBox4.Location.X;
            int p = pictureBox4.Location.Y;
            pictureBox4.Location = new Point(x + 10, y);
            Random r = new Random();
            BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), 0);


        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;
            pictureBox1.Location = new Point(x - 10, y-25);
            int s = pictureBox2.Location.X;
            int o = pictureBox2.Location.Y;
            pictureBox2.Location = new Point(x + 9, y);
            int q = pictureBox4.Location.X;
            int p = pictureBox4.Location.Y;
            pictureBox4.Location = new Point(x + 10, y);
            Random r = new Random();
            BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), 0);
        }
    }
}
