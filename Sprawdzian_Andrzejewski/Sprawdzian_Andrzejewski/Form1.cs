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

namespace Sprawdzian_Andrzejewski
{
    public partial class Andrzejewski : Form
    {
        const int MA_Margines = 20;

        float MA_XD, MA_XG, MA_KrokH;
        Graphics MA_rys;
        int MA_LiczbaPrzedziałów;
        float[,] MA_WartosciFunkcji;
        Pen MA_Długopis = new Pen(Color.Red, 1.5f);
        Pen MA_UkładWspółrzędnych = new Pen(Color.Black, 2.0f);

        static Andrzejewski MA_Formularz;


        public Andrzejewski()
        {
            #region Lokalizacja Kontrolek
            InitializeComponent();
            Location = new Point(20, 20);
            Width = (int)(Screen.PrimaryScreen.Bounds.Width * 0.8F);
            Height = (int)(Screen.PrimaryScreen.Bounds.Height * 0.8F);
            StartPosition = FormStartPosition.Manual;
            // PICBOX
            MA_PicBox1.Location = new Point(Left + MA_Margines, Top + MA_Margines);
            MA_PicBox1.Width = (int)(Width * 0.75F);
            MA_PicBox1.Height = (int)(Height * 0.75F);
            MA_PicBox1.BackColor = Color.Cornsilk;
            MA_PicBox1.Image = new Bitmap(MA_PicBox1.Width, MA_PicBox1.Height);

            MA_rys = Graphics.FromImage(MA_PicBox1.Image);
            // Kontrolki
            MA_L_XD.Location = new Point(MA_PicBox1.Location.X + MA_PicBox1.Width + MA_L_XD.Width, MA_PicBox1.Location.Y);
            MA_TXT_XD.Location = new Point(MA_L_XD.Location.X, MA_L_XD.Location.Y + 2 * MA_L_XD.Height);
            MA_L_XG.Location = new Point(MA_L_XD.Location.X, MA_TXT_XD.Location.Y + 3 * MA_TXT_XD.Height);
            MA_TXT_XG.Location = new Point(MA_L_XG.Location.X, MA_L_XG.Location.Y + 2 * MA_L_XG.Height);
            MA_L_KrokH.Location = new Point(MA_TXT_XG.Location.X, MA_TXT_XG.Location.Y + 3 * MA_TXT_XG.Height);
            MA_TXT_KrokH.Location = new Point(MA_L_KrokH.Location.X, MA_L_KrokH.Location.Y + 2 * MA_L_KrokH.Height);
            MA_BTN_Odśwież.Location = new Point(MA_TXT_KrokH.Location.X, MA_TXT_KrokH.Location.Y + 2 * MA_BTN_Odśwież.Height);

            // Rysownica

            #endregion
            MA_Formularz = this;
            MA_PicBox1.Image = new Bitmap(MA_PicBox1.Width, MA_PicBox1.Height);
        }

        private void Andrzejewski_Load(object sender, EventArgs e)
        {
            label1.Location = new Point(MA_PicBox1.Width - MA_Margines, MA_PicBox1.Height / 2);
            label2.Location = new Point(MA_PicBox1.Height / 2 + MA_Margines, MA_PicBox1.Height / 4 - MA_Margines);
            MA_rys.DrawLine(MA_UkładWspółrzędnych, 0 + MA_Margines, MA_PicBox1.Height / 2, MA_PicBox1.Width - MA_Margines, MA_PicBox1.Height / 2);
            MA_rys.DrawLine(MA_UkładWspółrzędnych, MA_PicBox1.Height / 2, 0, MA_PicBox1.Height / 2, MA_PicBox1.Height);
        }

        private void MA_BTN_Odśwież_Click(object sender, EventArgs e)
        {
            MA_PicBox1.Refresh();
            Refresh();
            while (!float.TryParse(MA_TXT_XD.Text, out MA_XD))
            {
                errorProvider1.SetError(MA_TXT_XD, "ERROR: Wprowadzono niepoprawny znak. Musisz wpisać liczbę rzeczywistą.");
            }
            while (!float.TryParse(MA_TXT_XG.Text, out MA_XG))
            {
                errorProvider1.SetError(MA_TXT_XG, "ERROR: Wprowadzono niepoprawny znak. Musisz wpisać liczbę rzeczywistą.");
            }
            while (!float.TryParse(MA_TXT_KrokH.Text, out MA_KrokH))
            {
                errorProvider1.SetError(MA_TXT_KrokH, "ERROR: Wprowadzono niepoprawny znak. Musisz wpisać liczbę rzeczywistą.");
            }

            MA_LiczbaPrzedziałów = (int)((MA_XG - MA_XD) / MA_KrokH + 1);
            MA_WartosciFunkcji = new float[MA_LiczbaPrzedziałów + 1, 2];
            int i;
            float ObecnyX;
            for (i = 0, ObecnyX = MA_XD; i < MA_WartosciFunkcji.GetLength(0); i++, ObecnyX = MA_XD + (MA_KrokH * i))
            {
                if (ObecnyX < 0)
                {
                    MA_WartosciFunkcji[i, 0] = ObecnyX;
                    MA_WartosciFunkcji[i, 1] = (float)(ObecnyX*(2*ObecnyX+(1/ObecnyX*ObecnyX)+Math.Sin(ObecnyX)));
                }
                if (ObecnyX >= 0)
                {
                    MA_WartosciFunkcji[i, 0] = ObecnyX;
                    MA_WartosciFunkcji[i, 1] = (float)((ObecnyX + 2)* (1/Math.Tan(ObecnyX*ObecnyX+1)));
                }
            }
            MA_PicBox1.Paint += new PaintEventHandler(MA_PicBox1_Paint);
            MA_PicBox1.Refresh();
            Refresh();
        }

        void MA_PicBox1_Paint(object sender, PaintEventArgs e)
        {
            if (MA_WartosciFunkcji != null)
            {
                for (int i = 0; i < MA_WartosciFunkcji.GetLength(0) - 1; i++)
                {
                     MA_rys.DrawLine(MA_Długopis, MA_PrzeliczanieWspółrzędnych.MA_WspX(MA_WartosciFunkcji[i, 0]), MA_PrzeliczanieWspółrzędnych.MA_WspY(MA_WartosciFunkcji[i, 1]), MA_PrzeliczanieWspółrzędnych.MA_WspX(MA_WartosciFunkcji[i + 1, 0]), MA_PrzeliczanieWspółrzędnych.MA_WspY(MA_WartosciFunkcji[i + 1, 1]));
                }
     
            }
            
        }

        class MA_MetodyStat
        {
            public static float MA_MinFx(float[,] MA_Tab)
            {
                float MA_WarMin;
                MA_WarMin = MA_Tab[0, 1];
                for (int i = 1; i < MA_Tab.GetLength(0); i++)
                {
                    if (MA_WarMin > MA_Tab[i, 1])
                    {
                        MA_WarMin = MA_Tab[i, 1];
                    }

                }
                return MA_WarMin;
            }
            public static float MA_MaxFx(float[,] MA_Tab)
            {
                float MA_WarMax;
                MA_WarMax = MA_Tab[0, 1];
                for (int i = 1; i < MA_Tab.GetLength(0); i++)
                {
                    if (MA_WarMax < MA_Tab[i, 1])
                    {
                        MA_WarMax = MA_Tab[i, 1];
                    }

                }
                return MA_WarMax;
            }
        }
        static class MA_PrzeliczanieWspółrzędnych
        {
            static float MA_SkalaX, MA_SkalaY;
            static float MA_PrzesunięcieX, MA_PrzesunięcieY;
            static int MA_XEkranuMax, MA_XEkranuMin, MA_YEkranuMin, MA_YEkranuMax;
            static MA_PrzeliczanieWspółrzędnych()
            {
                Xmin = (int)MA_Formularz.MA_XD;
                Xmax = (int)MA_Formularz.MA_XG;
                Ymin = (int)MA_MetodyStat.MA_MinFx(MA_Formularz.MA_WartosciFunkcji);
                Ymax = (int)MA_MetodyStat.MA_MaxFx(MA_Formularz.MA_WartosciFunkcji);

                MA_XEkranuMin = MA_Margines;
                MA_XEkranuMax = MA_Formularz.MA_PicBox1.Width - 2 * MA_Margines;
                MA_YEkranuMin = MA_Margines;
                MA_YEkranuMax = MA_Formularz.MA_PicBox1.Height - 2 * MA_Margines;

                MA_SkalaX = (MA_XEkranuMax - MA_XEkranuMin) / (Xmax - Xmin);
                MA_SkalaY = (MA_YEkranuMax - MA_YEkranuMin) / (Ymax - Ymin);
                MA_PrzesunięcieX = MA_XEkranuMin - Xmin * MA_SkalaX;
                MA_PrzesunięcieY = MA_YEkranuMin - Ymin * MA_SkalaY;
            }
            public static float Xmax { get; private set; }
            public static float Xmin { get; private set; }
            public static float Ymin { get; private set; }
            public static float Ymax { get; private set; }

            public static int MA_WspX(float x)
            {
                return (int)(x * MA_SkalaX + MA_PrzesunięcieX);
            }
            public static float MA_WspY(float y)
            {
                return (int)(y * MA_SkalaY + MA_PrzesunięcieY);
            }
        }
    }
}
