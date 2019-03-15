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
    public partial class maMenuForm : Form
    {
        public maMenuForm()
        {
            InitializeComponent();
            BackColor = Color.FromArgb(0, 0, 0);
            //lokalizacja i zwymiarowanie formularza
            Location = new Point(20, 20);
            Width = (int)(Screen.PrimaryScreen.Bounds.Height * 1.9);
            Height = (int)(Screen.PrimaryScreen.Bounds.Height * 1.2);
            StartPosition = FormStartPosition.Manual;
            //zablokowanie zmiany rozmiarów formularza
            SetAutoSizeMode(AutoSizeMode.GrowAndShrink);
        }

        private void butmenu_Click(object sender, EventArgs e)
        {
            maMenuForm form = new maMenuForm();
            form.Show();
            Close();
        }
    }
}
