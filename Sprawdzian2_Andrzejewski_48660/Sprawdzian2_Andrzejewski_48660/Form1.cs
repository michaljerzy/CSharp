using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sprawdzian2_Andrzejewski_48660
{
    public partial class Andrzejewski : Form
    {
        int maMin;
        int maMax;
        int maIle;
        Random maLosowa = new Random();
        delegate void FiltrLiczb(int x);
        FiltrLiczb MetodyFiltrowaniaLiczb = null;

        public Andrzejewski()
        {
            InitializeComponent();
            MetodyFiltrowaniaLiczb = CzyLiczbaPierwsza;
            MetodyFiltrowaniaLiczb += CzyLiczbaPierwszaMersenne;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            maLBWygenerowaneLiczby.Items.Clear();
            maLBLiczbyPierwszeMersebbe.Items.Clear();
            maLBPozostałe.Items.Clear();
            maMin = int.Parse(maTBDolnaGranica.Text);
            maMax = int.Parse(maTBGórnaGranica.Text);
            maIle = int.Parse(maTBLiczby.Text);
            for(int i = 0; i < maIle; i++)
            {
                maLBWygenerowaneLiczby.Items.Add(maLosowa.Next(maMin, maMax));
            }

            if(MetodyFiltrowaniaLiczb != null)
            {
                foreach(int Item in maLBWygenerowaneLiczby.Items)
                {
                    MetodyFiltrowaniaLiczb(Item);
                }
            }
        }
        private void CzyLiczbaPierwsza(int liczba)
        {
            int Pierwiastek;
            Pierwiastek = (int)(Math.Sqrt(liczba));

            for (int i = 2; i <= Pierwiastek; i++)
            {
                if (liczba % i == 0)
                {
                    maLBPozostałe.Items.Add(liczba);
                    return;
                }

            }
            maLBPierwsze.Items.Add(liczba);
        }
        private void CzyLiczbaPierwszaMersenne(int liczba)
        {
            if(liczba<100)
            {
                for(int n = 1; n<=6; n++)
                {
                    if((Math.Pow(2,n)-1)==liczba)
                    {
                        maLBLiczbyPierwszeMersebbe.Items.Add(liczba);
                        break;
                    }
                }
            }


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
