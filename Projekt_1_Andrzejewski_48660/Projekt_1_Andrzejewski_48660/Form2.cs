using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_1_Andrzejewski_48660
{
    public partial class FormKolor : Form
    {
        public Brush maKolorPiłki;

        public FormKolor()
        {
            InitializeComponent();
        }

        public void butCzerwony_Click(object sender, EventArgs e)
        {
            maKolorPiłki = Brushes.Red;
            Close();

        }

        public void butNiebieski_Click(object sender, EventArgs e)
        {
            maKolorPiłki = Brushes.Blue;
            Close();
        }

        public void butFioletowy_Click(object sender, EventArgs e)
        {
            var kolor = new ColorDialog();
            kolor.ShowDialog();
            kolor.Color = butFioletowy.ForeColor;
            //string kolor1 = ColorDialog.;
            Close();

        }

        public void butZielony_Click(object sender, EventArgs e)
        {
            maKolorPiłki = Brushes.Green;
            Close();

        }

        public void butRóż_Click(object sender, EventArgs e)
        {
            maKolorPiłki = Brushes.Pink;
            Close();

        }

        public void butpomarańczowy_Click(object sender, EventArgs e)
        {
            maKolorPiłki = Brushes.Orange;
            Close();

        }

        public void button4_Click(object sender, EventArgs e)
        {
            maKolorPiłki = Brushes.Yellow;
            Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            maKolorPiłki = Brushes.White;
            Close();

        }

        private void butCzarny_Click(object sender, EventArgs e)
        {
            maKolorPiłki = Brushes.Black;
            Close();

        }
    }
}
