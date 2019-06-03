using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        int Min;
        int Max;
        int Ile;
        Random Losowa = new Random();
        FiltrLiczb filtrLiczb = null;

        delegate void FiltrLiczb(int liczba);

        public Form1()
        {
            InitializeComponent();
            filtrLiczb = CzyLiczbaPierwsza;
            filtrLiczb += CzyLiczbaParzysta;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListBoxWykaz.Items.Clear();
            ListBoxNieparzyste.Items.Clear();
            ListBoxNiePierwsze.Items.Clear();
            ListBoxParzyste.Items.Clear();
            ListBoxPierwsze.Items.Clear();
            Min = int.Parse(textBox1.Text);
            Max = int.Parse(textBox2.Text);
            Ile = int.Parse(textBox3.Text);

            for (int i = 0; i < Ile; i++)
            {
                ListBoxWykaz.Items.Add(Losowa.Next(Min, Max));
            }

            if(filtrLiczb != null)
            {
                foreach (int Item in ListBoxWykaz.Items)
                {
                    filtrLiczb(Item);
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
                    ListBoxNiePierwsze.Items.Add(liczba);
                    return;
                }                                 
                               
            }
            ListBoxPierwsze.Items.Add(liczba);
        }
        private void CzyLiczbaParzysta(int liczba)
        {
           if(liczba % 2 == 0)
           {
                ListBoxParzyste.Items.Add(liczba);
               
            }
            else
            {
                ListBoxNieparzyste.Items.Add(liczba);
            }
        }
    }
}
