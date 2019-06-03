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

namespace Andrzejewsk_10_04_19
{
    
    public partial class Form1 : Form
    {
        List<bryłaAbstrakcyjna> LBG = new List<bryłaAbstrakcyjna>();
        public Graphics Rysownica;
        public static Form1 UchwytFormularza;

        public Form1()
        {
            InitializeComponent();
            UchwytFormularza = this;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Environment.Exit(0);
        }

        private void rbPromieńPodstawy_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnWłączSlajder_Click(object sender, EventArgs e)
        {
            if (LBG.Count > 0)
            {
                //sortowanie LBG
                LBG.Sort();
                //zmiana lokalizacji wszystkich brył (do środka rysownicy)
                for(int i = 0; i < LBG.Count; i++)
                    LBG[i].PrzesuńDoNowegoXY(pbRysownica.Width/2*(pbRysownica.Height/2))
            }
        }
    }
}
