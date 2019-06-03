using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Drawing.Drawing2D;

namespace Sprawdzian
{
    public partial class Form1 : Form
    {
        const int maMargines = 20;
        float maXDolne, maXGórne, maKrokH;
        Graphics maRysownica;
        int maLiczbaPrzedziałów;
        float[,] maWartośćFunkcji;
        Pen maDługopis = new Pen(Color.Black, 1.5F);
        Pen maUkładWspółrzędnych = new Pen(Color.Black, 2.0F);

        static Form1 maFormularz;

        public Form1()
        {
            #region Lokalizacja Kontrolek
            InitializeComponent();
            Location = new Point(20, 20);
            Width = (int)(Screen.PrimaryScreen.Bounds.Width * 0.8F);
            Height = (int)(Screen.PrimaryScreen.Bounds.Height * 0.8F);
            StartPosition = FormStartPosition.Manual;
            // PICBOX
            maPicBoxRysownica.Location = new Point(Left + maMargines, Top + maMargines);
            maPicBoxRysownica.Width = (int)(Width * 0.75F);
            maPicBoxRysownica.Height = (int)(Height * 0.75F);
            maPicBoxRysownica.BackColor = Color.Cornsilk;
            maPicBoxRysownica.Image = new Bitmap(maPicBoxRysownica.Width, maPicBoxRysownica.Height);

            maRysownica = Graphics.FromImage(maPicBoxRysownica.Image);
            // Kontrolki
            MŚ_L_XD.Location = new Point(maPicBoxRysownica.Location.X + maPicBoxRysownica.Width + MŚ_L_XD.Width, maPicBoxRysownica.Location.Y);
            maTXTDolna.Location = new Point(MŚ_L_XD.Location.X, MŚ_L_XD.Location.Y + 2 * MŚ_L_XD.Height);
            MŚ_L_XG.Location = new Point(MŚ_L_XD.Location.X, maTXTDolna.Location.Y + 3 * maTXTDolna.Height);
            maTXTGórna.Location = new Point(MŚ_L_XG.Location.X, MŚ_L_XG.Location.Y + 2 * MŚ_L_XG.Height);
            MŚ_L_KrokH.Location = new Point(maTXTGórna.Location.X, maTXTGórna.Location.Y + 3 * maTXTGórna.Height);
            maTXTKrokH.Location = new Point(MŚ_L_KrokH.Location.X, MŚ_L_KrokH.Location.Y + 2 * MŚ_L_KrokH.Height);
            maButOdśwież.Location = new Point(maTXTKrokH.Location.X, maTXTKrokH.Location.Y + 2 * maButOdśwież.Height);
            #endregion
            maFormularz = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Location = new Point(maPicBoxRysownica.Width - maMargines, maPicBoxRysownica.Height / 2);
            label2.Location = new Point(maPicBoxRysownica.Height / 2 + maMargines, maPicBoxRysownica.Height / 4 - maMargines);
            maRysownica.DrawLine(maUkładWspółrzędnych, 0 + maMargines, maPicBoxRysownica.Height / 2, maPicBoxRysownica.Width - maMargines, maPicBoxRysownica.Height / 2);
            maRysownica.DrawLine(maUkładWspółrzędnych, maPicBoxRysownica.Height / 2, 0, maPicBoxRysownica.Height / 2, maPicBoxRysownica.Height);
        }

        private void maButOdśwież_Click(object sender, EventArgs e)
        {
            maPicBoxRysownica.Refresh();
            Refresh();
            while (!float.TryParse(maTXTDolna.Text, out maXDolne))
            {
                errorProvider1.SetError(maTXTDolna, "ERROR: Wprowadzono niepoprawny znak. Musisz wpisać liczbę rzeczywistą.");
            }
            while (!float.TryParse(maTXTGórna.Text, out maXGórne))
            {
                errorProvider1.SetError(maTXTGórna, "ERROR: Wprowadzono niepoprawny znak. Musisz wpisać liczbę rzeczywistą.");
            }
            while (!float.TryParse(maTXTKrokH.Text, out maKrokH))
            {
                errorProvider1.SetError(maTXTKrokH, "ERROR: Wprowadzono niepoprawny znak. Musisz wpisać liczbę rzeczywistą.");
            }

            maLiczbaPrzedziałów = (int)((maXGórne - maXDolne) / maKrokH + 1);
            maWartośćFunkcji = new float[maLiczbaPrzedziałów + 1, 2];
            int i;
            float ObecnyX;
            for (i = 0, ObecnyX = maXDolne; i < maWartośćFunkcji.GetLength(0); i++, ObecnyX = maXDolne + (maKrokH * i))
            {
                if (ObecnyX < -5)
                {
                    maWartośćFunkcji[i, 0] = ObecnyX;
                    maWartośćFunkcji[i, 1] = (float)(Math.Sin(Math.Sqrt(1 + Math.Sqrt((1 + ObecnyX * ObecnyX))) / Math.Sqrt(1 + 2 * ObecnyX * ObecnyX) + 1));
                }
                if (ObecnyX >= -5 && ObecnyX < 5)
                {
                    maWartośćFunkcji[i, 0] = ObecnyX;
                    maWartośćFunkcji[i, 1] = (float)(Math.Cos(ObecnyX) * 2 * Math.Log(1 + Math.Abs(ObecnyX)));
                }
                if (ObecnyX >= 5)
                {
                    maWartośćFunkcji[i, 0] = ObecnyX;
                    maWartośćFunkcji[i, 1] = (float)((Math.Sin(ObecnyX) * Math.Sqrt(1 + Math.Pow(Math.E, ObecnyX))) + 2 * Math.Log(ObecnyX) - Math.Sin(ObecnyX) / (1 + Math.Pow(ObecnyX, 3) / 3));
                }
            }
            maPicBoxRysownica.Paint += new PaintEventHandler(maPicBoxRysownica_Paint);
            maPicBoxRysownica.Refresh();
            Refresh();
        }

        void maPicBoxRysownica_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < maWartośćFunkcji.GetLength(0) - 1; i++)
            {
                maRysownica.DrawLine(maDługopis, maPrzeliczanieWspółrzędnych.maWspX(maWartośćFunkcji[i, 0]), maPrzeliczanieWspółrzędnych.maWspY(maWartośćFunkcji[i, 1]), maPrzeliczanieWspółrzędnych.maWspX(maWartośćFunkcji[i + 1, 0]), maPrzeliczanieWspółrzędnych.maWspY(maWartośćFunkcji[i + 1, 1]));
            }
        }

        class maMetodyStat
        {
            public static float maMinFX(float[,] matab)
            {
                float maWartośćMIN;
                maWartośćMIN = matab[0, 1];
                for (int i = 1; i < matab.GetLength(0); i++)
                {
                    if (maWartośćMIN > matab[i, 1])
                    {
                        maWartośćMIN = matab[i, 1];
                    }

                }
                return maWartośćMIN;
            }
            public static float maMaxFX(float[,] maTAB)
            {
                float maWartośćMAX;
                maWartośćMAX = maTAB[0, 1];
                for (int i = 1; i < maTAB.GetLength(0); i++)
                {
                    if (maWartośćMAX < maTAB[i, 1])
                    {
                        maWartośćMAX = maTAB[i, 1];
                    }

                }
                return maWartośćMAX;
            }
        }
        static class maPrzeliczanieWspółrzędnych
        {
            static float maSkalaX, maSkalaY;
            static float maPrzesunięcieX, maPrzesunięcieY;
            static int ma_XEkranuMax, ma_XEkranuMin, ma_YEkranuMin, ma_YEkranuMax;
            static maPrzeliczanieWspółrzędnych()
            {
                Xmin = (int)maFormularz.maXDolne;
                Xmax = (int)maFormularz.maXGórne;
                Ymin = (int)maMetodyStat.maMinFX(maFormularz.maWartośćFunkcji);
                Ymax = (int)maMetodyStat.maMaxFX(maFormularz.maWartośćFunkcji);

                ma_XEkranuMin = maMargines;
                ma_XEkranuMax = maFormularz.maPicBoxRysownica.Width - 2 * maMargines;
                ma_YEkranuMin = maMargines;
                ma_YEkranuMax = maFormularz.maPicBoxRysownica.Height - 2 * maMargines;

                maSkalaX = (ma_XEkranuMax - ma_XEkranuMin) / (Xmax - Xmin);
                maSkalaY = (ma_YEkranuMax - ma_YEkranuMin) / (Ymax - Ymin);
                maPrzesunięcieX = ma_XEkranuMin - Xmin * maSkalaX;
                maPrzesunięcieY = ma_YEkranuMin - Ymin * maSkalaY;
            }
            public static float Xmax { get; private set; }
            public static float Xmin { get; private set; }
            public static float Ymin { get; private set; }
            public static float Ymax { get; private set; }

            public static int maWspX(float x)
            {
                return (int)(x * maSkalaX + maPrzesunięcieX);
            }
            public static float maWspY(float y)
            {
                return (int)(y * maSkalaY + maPrzesunięcieY);
            }
        }
    }
}
