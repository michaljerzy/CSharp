using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;



namespace Projekt3_Andrzejewski48660
{
    public partial class maForm1 : Form
    {
        public maForm1()
        {
            InitializeComponent();
            //ustalenie lokalizacji i rozmiarów formularza
            this.Left = 20;
            this.Top = 20;
            this.Width = (int)(Screen.PrimaryScreen.Bounds.Width * 0.80F);
            this.Height = (int)(Screen.PrimaryScreen.Bounds.Height * 0.85F);
            //ustawienie właściwości StartPosition dla akcepcji naszych ustawień
            this.StartPosition = FormStartPosition.Manual;
            // zablokowanie możliwości zmiany rozmiaru formularza
            this.SetAutoSizeMode(AutoSizeMode.GrowAndShrink);
            // blokada przycisków Minimalizacji i maksymalizacji
            this.MinimizeBox = false; this.MaximizeBox = false;
            //ustawienie pasków przewijania dla formularza
            this.AutoScroll = true;
        }

        static void maObliczSumęSzeregu(float maX, float maEps, out float maSumaSzeregu)
        {//deklaracje pomocnicze
            float maw; //dla przechowywania wartości n-tego wyrazu szeregu
                       //ustalenie początkowego stanu obliczeń
            maSumaSzeregu = 0.0f;
            maw = maX;
            int maN = 0;
            //iteracyjne obliczanie sumy szeregu
            while (Math.Abs(maw) >= maEps) //Abs - moduł = |w|
            {// zwiększenie licznika zsumowanych wyrazów szeregu
                maN++;
                //obliczenie n - tej sumy częściowej szeregu
                maSumaSzeregu += maw;
                //obliczenie n - tego wyrazu szeregu
                maw *= (-1.0f) * ((((2 * maN) - 1) * maX) / (((2 * maN) + 1) / maX));
            }
        }
        
        static float CałkametodąProstokątów(float mad, float mag, float maEps,  out int maLicznikIteracyjny)
        {
            //zadeklarowanie zmiennych
            float mah, maCi, maCi_1, maSumaFx, maX;
            //wywołanie metody maObliczSumęSzeregu
            maObliczSumęSzeregu((mad + mag) / 2.0F, maEps, out float maSumaSzeregu);
            //Pierwsze przybliżenie wartości całki 
            maCi = (mag - mad) * maSumaSzeregu;
            //Nadanie  zmiennej wartości 1 
            maLicznikIteracyjny = 1;
            do
            {
                //przechowanie nowego przybliżenia
                maCi_1 = maCi;
                //zwiększanie licznika
                maLicznikIteracyjny++;
                //obliczenie wysokości podwykresowej
                mah = (mag - mad) / maLicznikIteracyjny;
                //obliczanie środka pierwszego podprzedziału
                maX = mad + mah / 2.0F;
                maSumaFx = 0.0F;
                //obliczanie sumy podprzedziałami
                for (int maj = 1; maj <= maLicznikIteracyjny; maj++)
                {
                    maObliczSumęSzeregu(maX + maj * mah, maEps, out maSumaSzeregu);
                    maSumaFx += maSumaSzeregu; 
                }
                maCi = mah * maSumaFx;
            } while (Math.Abs(maCi - maCi_1) > maEps);
            //zwrócenie wartości maCi
            return maCi;
        }

        static float CałkaMetodąTrapezów(float mad, float mag, float maEps, out int maLicznikIteracyjny)
        {
            float mah, maCi, maCi_1, maSumaFx;
            //wysokość przedziału dla pierwszego szeregu
            mah = mag - mad;
            //wywołanie metody obliczającej sumę szeregu
            maObliczSumęSzeregu(mad, maEps, out float maSumaSzereguA);
            maObliczSumęSzeregu(mag, maEps, out float maSumaSzereguB);
            //sumowanie wartości na końcach szeregu
            float maSumaFaFb = maSumaSzereguA + maSumaSzereguB;

            maCi = mah * maSumaFaFb;
            maLicznikIteracyjny = 1;
            do
            {
                maCi_1 = maCi;
                maLicznikIteracyjny++;
                mah = (mag - mad) / maLicznikIteracyjny;
                maSumaFx = 0.0f;
                //obliczanie sumy podprzedziałami
                for (int j = 1; j < maLicznikIteracyjny; j++)
                {
                    maObliczSumęSzeregu(mad + j * mah, maEps, out float maSumaSzeregu);
                    maSumaFx += maSumaSzeregu;
                }
                maCi = mah * (maSumaFaFb + maSumaFx);
            } while (Math.Abs(maCi - maCi_1) > maEps);
            //zwrócenie wartości maCi
            return maCi;
        }

            bool maPobranieZmiennychX(out float maX,out float maEps)
        {
            maX = 0.0F; maEps = 0.0F;
            if (string.IsNullOrEmpty(matxtZmiennaX.Text))
            {
                maerrorProvider1.SetError(matxtZmiennaX, "Musisz wpisać tutaj X!");
                return false;
            }
            else { maerrorProvider1.Clear(); }
            if (!float.TryParse(matxtZmiennaX.Text, out maX))
            {
                maerrorProvider1.SetError(matxtZmiennaX, "Musi to być liczba!");
                return false;
            }
            else { maerrorProvider1.Clear(); }
            if (maX < -1 || maX > 1)
            {
                maerrorProvider1.SetError(matxtZmiennaX, "X musi być z zakresu [-1;1]");
                return false;
            }
            else { maerrorProvider1.Clear(); }
            if (string.IsNullOrEmpty(matxtEps.Text))
            {
                maerrorProvider1.SetError(matxtEps, "Musisz wpisać tutaj Eps!");
                return false;
            }
            else { maerrorProvider1.Clear(); }
            if (!float.TryParse(matxtEps.Text, out maEps))
            {
                maerrorProvider1.SetError(matxtEps, "Musi to być liczba!");
                return false;
            }
            else { maerrorProvider1.Clear(); }
            if (maEps <= 0 || maEps >= 1)
            {
                maerrorProvider1.SetError(matxtZmiennaX, "Eps musi być z zakresu (0;1)");
                return false;
            }
            else { maerrorProvider1.Clear(); }
            return true;
        }
        //pobranie wartości od użytkownika
        bool maPorbanieZmiennychXd(out float maXd, out float maXg, out float maX, out float maEps, out float mah)
        {
            maXd = 0.0F; maXg = 0.0F; maX = 0.0F; maEps = 0.0F; mah = 0.0F;
            if(string.IsNullOrEmpty(matxtXg.Text))
            {
                maerrorProvider1.SetError(matxtXg, "Wpisz liczbę!");
            }
            else { maerrorProvider1.Clear(); }

            if (!float.TryParse(matxtXg.Text, out maXg))
            {
                maerrorProvider1.SetError(matxtXg, "Podaj liczbę!");
                return false;
            }
            else { maerrorProvider1.Clear(); }

            if (maXg < -1.0F || maXg > 1.0F)
            {
                maerrorProvider1.SetError(matxtXg, "Przedział dolnej granicy musi być między -1, a 1");
                return false;
            }
            else { maerrorProvider1.Clear(); }

            if (string.IsNullOrEmpty(matxtXd.Text))
            {
                maerrorProvider1.SetError(matxtXd, "Wpisz liczbę!");
            }
            else { maerrorProvider1.Clear(); }

            if (!float.TryParse(matxtXd.Text, out maXd))
            {
                maerrorProvider1.SetError(matxtXd, "Podaj liczbę!");
                return false;
            }
            else { maerrorProvider1.Clear(); }

            if(maXd < -1.0F || maXd > 1.0F)
            {
                maerrorProvider1.SetError(matxtXd, "Przedział dolnej granicy musi być między -1, a 1");
                return false;
            }
            else { maerrorProvider1.Clear();  }
            if (maXd >= maXg)
            {
                maerrorProvider1.SetError(matxtXd, "Dolna granica musi być mniejasza od górnej!");
                return false;
            }
            else { maerrorProvider1.Clear();  }

            if (string.IsNullOrEmpty(matxtZmiennaX.Text))
            {
                maerrorProvider1.SetError(matxtZmiennaX, "Wpisz liczbę!");
            }
            else { maerrorProvider1.Clear(); }

            if (!float.TryParse(matxtZmiennaX.Text, out maX))
            {
                maerrorProvider1.SetError(matxtZmiennaX, "Podaj liczbę!");
                return false;
            }
            else { maerrorProvider1.Clear(); }

            if (maX < -1.0F || maX > 1.0F)
            {
                maerrorProvider1.SetError(matxtZmiennaX, "Przedział zmiennej X musi być między -1, a 1");
                return false;
            }
            else { maerrorProvider1.Clear(); }

            if (string.IsNullOrEmpty(matxtEps.Text))
            {
                maerrorProvider1.SetError(matxtEps, "Wpisz liczbę!");
            }
            else { maerrorProvider1.Clear(); }

            if (!float.TryParse(matxtEps.Text, out maEps))
            {
                maerrorProvider1.SetError(matxtEps, "Podaj liczbę!");
                return false;
            }
            else { maerrorProvider1.Clear(); }

            if (maEps <= 0 || maEps >= 1)
            {
                maerrorProvider1.SetError(matxtEps, "Przedział dolnej granicy musi być między -1, a 1");
                return false;
            }
            else { maerrorProvider1.Clear(); }

            if (string.IsNullOrEmpty(matxth.Text))
            {
                maerrorProvider1.SetError(matxth, "Wpisz liczbę!");
            }
            else { maerrorProvider1.Clear(); }

            if (!float.TryParse(matxth.Text, out mah))
            {
                maerrorProvider1.SetError(matxth, "Podaj liczbę!");
                return false;
            }
            else { maerrorProvider1.Clear(); }

            if ((mah == 0) || (mah > (maXg - maXd)))
            {
                maerrorProvider1.SetError(matxtEps, "Krok 'h' zmian zmiennej niezależnej maX musi być !=0.0 i nie może być większy od szerokości przedziału: maXg - maXd");
                return false;
            }
            else { maerrorProvider1.Clear(); }


            return true;
        }
        //pobranie wartości od użytkownika
        bool maPobranieZmiennychCałkowania(out float mad, out float mag, out float maEps, out string maWyborMetody)
        {
            mad = 0.0F; mag = 0.0F; maEps = 0.0F; maWyborMetody = "";
            if (macmbWybórMetody.SelectedIndex < 0) //sprawdza czy została wybrana metoda
            { //wypisanie błędu obok pola tekstowego
                maerrorProvider1.SetError(macmbWybórMetody, "Musisz wybrać metodę całkowania");
                return false;
            }
            else
            {
                maWyborMetody = macmbWybórMetody.SelectedItem.ToString(); //wczytuje text  do stringa
                maerrorProvider1.Clear();  //jeżeli wszystko dobrze to usuwa okienko z błędem
            }
            if (string.IsNullOrEmpty(matxtCG.Text))
            {
                maerrorProvider1.SetError(matxtCG, "Wpisz liczbę!");
            }
            else { maerrorProvider1.Clear(); }

            if (!float.TryParse(matxtCG.Text, out mag))
            {
                maerrorProvider1.SetError(matxtCG, "Podaj liczbę!");
                return false;
            }
            else { maerrorProvider1.Clear(); }
            if (mag > 1.0f || mag < -1.0f)
            {
                maerrorProvider1.SetError(matxtCG, "Górna granica całkowania musi być pomiędzy 1, a -1");
                return false;
            }
            else { maerrorProvider1.Clear(); }
            if (string.IsNullOrEmpty(matxtCD.Text))
            {
                maerrorProvider1.SetError(matxtCD, "Wpisz liczbę!");
            }
            else { maerrorProvider1.Clear(); }

            if (!float.TryParse(matxtCD.Text, out mad))
            {
                maerrorProvider1.SetError(matxtXd, "Podaj liczbę!");
                return false;
            }
            else { maerrorProvider1.Clear(); }
            if (mad > 1.0f || mad < -1.0f)
            {
                maerrorProvider1.SetError(matxtCD, "Dolna granica całkowania musi być pomiędzy 1, a -1");
                return false;
            }
            else { maerrorProvider1.Clear(); }
            if (mad >= mag)
            {
                maerrorProvider1.SetError(matxtCD, "Dolna granica musi być mniejasza od górnej!");
                return false;
            }
            else { maerrorProvider1.Clear(); }

            if (string.IsNullOrEmpty(matxtEps2.Text))
            {
                maerrorProvider1.SetError(matxtEps2, "Wpisz liczbę!");
            }
            else { maerrorProvider1.Clear(); }

            if (!float.TryParse(matxtEps2.Text, out maEps))
            {
                maerrorProvider1.SetError(matxtEps2, "Podaj liczbę!");
                return false;
            }
            else { maerrorProvider1.Clear(); }

            if (maEps < 0 || maEps >= 1)
            {
                maerrorProvider1.SetError(matxtEps, "Przedział dolnej granicy musi być między -1, a 1");
                return false;
            }
            else { maerrorProvider1.Clear(); }

            return true;
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblXd_Click(object sender, EventArgs e)
        {

        }

        private void lblXg_Click(object sender, EventArgs e)
        {

        }

        private void txtXg_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
 
        }

        private void butFunkcjaX_Click(object sender, EventArgs e)
        {
            float maX, maEps;
            if (!maPobranieZmiennychX(out maX, out maEps))
            {
                maerrorProvider1.SetError(mabutFunkcjaX, "Wystąpił błąd podczas wczytywania danych ");
                return;
            }
            else
                maerrorProvider1.Dispose();
            float maSumaSzeregu;
            maObliczSumęSzeregu(maX, maEps, out maSumaSzeregu);
            matxtObliczanieFX.Text = string.Format("{0}", maSumaSzeregu);
            matxtZmiennaX.Enabled = false;
            matxtEps.Enabled = false;
            mapictureBox1.Visible = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void butTabela_Click(object sender, EventArgs e)
        {
            madataGridView1.ClearSelection();
            float maXd, maXg, maX, maEps, mah;
            if (!maPorbanieZmiennychXd(out maXd, out maXg, out maX, out maEps, out mah))
            {
                maerrorProvider1.SetError(mabutTabela, "Wystąpił błąd podczas wczytania danych");
                return;
            }
            else { maerrorProvider1.Dispose(); }

            for (maX = maXd; maX <= maXg; maX = maX + mah)
            {
                float maSumaSzeregu;
                maObliczSumęSzeregu(maX, maEps, out maSumaSzeregu);
                string mastringX = maX.ToString();
                string mastringSumaSzeregu = maSumaSzeregu.ToString();
                string[] maXb = new string[] { mastringX, mastringSumaSzeregu };
                madataGridView1.Rows.Add(maXb);
                //wycentrowanie zapisów w kolumnach kontrolki DataGridView
                madataGridView1.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //odsłonięcie kontrolki dgvrozlicznie
                madataGridView1.Visible = true;
                //ustawienie stanu braku aktywności dla przychisku poleceń :
                mabutTabela.Enabled = false;
                machartWykres.Visible = false;
                matxtEps.Enabled = false;
                matxth.Enabled = false;
                matxtZmiennaX.Enabled = false;
                matxtXd.Enabled = false;
                matxtXg.Enabled = false;
                mapictureBox1.Visible = false;
            }
                
        }
            

        private void txth_TextChanged(object sender, EventArgs e)
        {

        }

        private void chartWykres_Click(object sender, EventArgs e)
        {
           
        }

        private void btnWykres_Click(object sender, EventArgs e)
        {
            machartWykres.Series[0].Points.Clear();
            float maXd, maXg, maX, maEps, mah;
            if (!maPorbanieZmiennychXd(out maXd, out maXg, out maX, out maEps, out mah))
            {
                maerrorProvider1.SetError(mabutTabela, "Wystąpił błąd podczas wczytania danych");
                return;
            }else { maerrorProvider1.Clear(); }
            machartWykres.Visible = true;
            machartWykres.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            foreach (RadioButton Kontrolka in magroupBox1.Controls)
            {
                if (marbBezOpisu.Checked == true)
                {
                    machartWykres.ChartAreas[0].AxisX.LabelStyle.Format = " ";
                    machartWykres.ChartAreas[0].AxisY.LabelStyle.Format = " ";
                }
                if (marbOpis.Checked == true)
                {
                    machartWykres.ChartAreas[0].AxisX.LabelStyle.Format = "0.00";
                    machartWykres.ChartAreas[0].AxisY.LabelStyle.Format = "0.00";
                }
            }
            machartWykres.Titles.Add("Wykres funkcji");
            machartWykres.ChartAreas[0].AxisX.Title = "Wartość F(X)";
            machartWykres.ChartAreas[0].AxisY.Title = "Wartość X";
            machartWykres.Legends.FindByName("Legend1").Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            float maSumaSzeregu;
            for (maX = maXd; maX <= maXg; maX = maX + mah)
            {
                maObliczSumęSzeregu(maX, maEps, out maSumaSzeregu);
                this.machartWykres.Series[0].Points.AddXY(maX, maSumaSzeregu);
            }
            matxtEps.Enabled = false;
            matxth.Enabled = false;
            matxtZmiennaX.Enabled = false;
            matxtXd.Enabled = false;
            matxtXg.Enabled = false;
            mapictureBox1.Visible = false;
            mabtnWykres.Enabled = false;
            //magroupBox1.Enabled = false;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // bezwzględne wyjście zakończenie programu
            Application.Exit();
        }

        private void kolorTłaWykresuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // deklaracja i utworzenie egzemplarza Palety kolorów
            ColorDialog PaletaKolorów = new ColorDialog();
            //ustawienie aktualnego koloru tła wykresu
            PaletaKolorów.Color = machartWykres.BackColor;
            // wyświelenie palety kolorów i "odczyt" nowego koloru
            if (PaletaKolorów.ShowDialog() == DialogResult.OK)
                machartWykres.BackColor = PaletaKolorów.Color;
            matxtKolorTła.BackColor = PaletaKolorów.Color;
        }

        private void kolorLiniiWykresuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //deklaracja palety kolorów
            ColorDialog maPaletaKolorów = new ColorDialog();
            //ustawienie aktualnego koloru wykresów 
            maPaletaKolorów.Color = machartWykres.Series[0].Color;
            //wyświetlenie palety kolorów i "odczyt" nowego koloru
            if (maPaletaKolorów.ShowDialog() == DialogResult.OK)
            //zmiana koloru w kontrolce chart
            { machartWykres.Series[0].Color = maPaletaKolorów.Color; }
            matxtKolorLinii.BackColor = maPaletaKolorów.Color;
        }

        private void kolorCzcionkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //deklaracja palety kolorów
            ColorDialog maPaletaKolorów = new ColorDialog();
            //ustawienie aktualnego koloru wykresów 
            maPaletaKolorów.Color = machartWykres.Series[0].Color;
            //wyświetlenie palety kolorów i "odczyt" nowego koloru
            if (maPaletaKolorów.ShowDialog() == DialogResult.OK)
            //zmiana koloru w kontrolce chart
            {
                malabel1.ForeColor = maPaletaKolorów.Color;
                malblZmiennaX.ForeColor = maPaletaKolorów.Color;
                malblXg.ForeColor = maPaletaKolorów.Color;
                malblXd.ForeColor = maPaletaKolorów.Color;
                malblWartośćCałki.ForeColor = maPaletaKolorów.Color;
                malblOpisOsi.ForeColor = maPaletaKolorów.Color;
                malblKrokh.ForeColor = maPaletaKolorów.Color;
                malblGórnaGranica.ForeColor = maPaletaKolorów.Color;
                malblEps.ForeColor = maPaletaKolorów.Color;
                malblDolnaGranica.ForeColor = maPaletaKolorów.Color;
                malblDokładnoścObliczeń.ForeColor = maPaletaKolorów.Color;
                malabel1.ForeColor = maPaletaKolorów.Color;
                malabel2.ForeColor = maPaletaKolorów.Color;
                malabel3.ForeColor = maPaletaKolorów.Color;
                mabtnWykres.ForeColor = maPaletaKolorów.Color;
                mabutFunkcjaX.ForeColor = maPaletaKolorów.Color;
                mabutKolorLinii.ForeColor = maPaletaKolorów.Color;
                mabutKolorTła.ForeColor = maPaletaKolorów.Color;
                mabutObliczCałkę.ForeColor = maPaletaKolorów.Color;
                mabutReset.ForeColor = maPaletaKolorów.Color;
                mabutTabela.ForeColor = maPaletaKolorów.Color;
                macbStylLini.ForeColor = maPaletaKolorów.Color;
                machartWykres.ForeColor = maPaletaKolorów.Color;
                matxtZmiennaX.ForeColor = maPaletaKolorów.Color;
                matxtXg.ForeColor = maPaletaKolorów.Color;
                matxtXd.ForeColor = maPaletaKolorów.Color;
                matxtCD.ForeColor = maPaletaKolorów.Color;
                matxtCG.ForeColor = maPaletaKolorów.Color;
                matxtEps.ForeColor = maPaletaKolorów.Color;
                matxtEps2.ForeColor = maPaletaKolorów.Color;
                matxth.ForeColor = maPaletaKolorów.Color;
                matxtKolorLinii.ForeColor = maPaletaKolorów.Color;
                matxtKolorTła.ForeColor = maPaletaKolorów.Color;
                matxtObliczanieFX.ForeColor = maPaletaKolorów.Color;
                matxtWartośćCałki.ForeColor = maPaletaKolorów.Color;
                maciagłaToolStripMenuItem.ForeColor = maPaletaKolorów.Color;
                maexitToolStripMenuItem.ForeColor = maPaletaKolorów.Color;
                magrubośćLiniiToolStripMenuItem.ForeColor = maPaletaKolorów.Color;
                makolorCzcionkiToolStripMenuItem.ForeColor = maPaletaKolorów.Color;
                makolorLiniiWykresuToolStripMenuItem.ForeColor = maPaletaKolorów.Color;
                makolorTłaWykresuToolStripMenuItem.ForeColor = maPaletaKolorów.Color;
                makoloryToolStripMenuItem.ForeColor = maPaletaKolorów.Color;
                makreskowaToolStripMenuItem.ForeColor = maPaletaKolorów.Color;
                makreskowokropkowaToolStripMenuItem.ForeColor = maPaletaKolorów.Color;
                makropkowaToolStripMenuItem.ForeColor = maPaletaKolorów.Color;
                makrójPismaToolStripMenuItem.ForeColor = maPaletaKolorów.Color;
                makursywaToolStripMenuItem.ForeColor = maPaletaKolorów.Color;
                maodczytajTablicęZPlikuToolStripMenuItem.ForeColor = maPaletaKolorów.Color;
                maplikToolStripMenuItem.ForeColor = maPaletaKolorów.Color;
                mapogrubionaIKursywaToolStripMenuItem.ForeColor = maPaletaKolorów.Color;
                mapogrubionaToolStripMenuItem.ForeColor = maPaletaKolorów.Color;
                marbBezOpisu.ForeColor = maPaletaKolorów.Color;
                marbOpis.ForeColor = maPaletaKolorów.Color;
                marozmiarCzcionkiToolStripMenuItem.ForeColor = maPaletaKolorów.Color;
                mastylCzcionkiToolStripMenuItem.ForeColor = maPaletaKolorów.Color;
                malabel1.ForeColor = maPaletaKolorów.Color;
                mazapiszTablicęWPlikuToolStripMenuItem.ForeColor = maPaletaKolorów.Color;
                mastylLiniiToolStripMenuItem.ForeColor = maPaletaKolorów.Color;
            }
            matxtKolorLinii.BackColor = maPaletaKolorów.Color;
        }

        private void kreskowaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            machartWykres.Series[0].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
        }

        private void kropkowaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            machartWykres.Series[0].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
        }

        private void kreskowokropkowaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            machartWykres.Series[0].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
        }

        private void ciagłaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            machartWykres.Series[0].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
        }

        private void cbStylLini_SelectedIndexChanged(object sender, EventArgs e)
        {
            string WybórStylu;
            WybórStylu = macbStylLini.SelectedItem.ToString();
            if(WybórStylu == "Kropkowa")
            {
                machartWykres.Series[0].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            }
            if (WybórStylu == "Kreskowa")
            {
                machartWykres.Series[0].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            }
            if (WybórStylu == "Kreskowo-kropkowa")
            {
                machartWykres.Series[0].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            }
            if (WybórStylu == "Ciągła")
            {
                machartWykres.Series[0].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void butReset_Click(object sender, EventArgs e)
        {
            matxtZmiennaX.Text = "";
            matxtZmiennaX.Visible = true;
            matxtZmiennaX.Enabled = true;
            matxtObliczanieFX.Text = "";
            matxtObliczanieFX.Visible = true;
            matxtObliczanieFX.Enabled = true;
            matxtEps.Text = "";
            matxtEps.Visible = true;
            matxtEps.Enabled = true;
            matxtXd.Text = "";
            matxtXd.Visible = true;
            matxtXd.Enabled = true;
            matxtXg.Text = "";
            matxtXg.Visible = true;
            matxtXg.Enabled = true;
            matxtCD.Text = "";
            matxtCD.Visible = true;
            matxtCD.Enabled = true;
            matxtCG.Text = "";
            matxtCG.Visible = true;
            matxtCG.Enabled = true;
            matxth.Text = "";
            matxth.Visible = true;
            matxth.Enabled = true;
            matxtGrubość.Text = "";
            matxtGrubość.Visible = true;
            matxtGrubość.Enabled = true;
            matxtWartośćCałki.Text = "";
            matxtWartośćCałki.Visible = true;
            matxtWartośćCałki.Enabled = true;
            matxtEps2.Text = "";
            matxtEps2.Visible = true;
            matxtEps2.Enabled = true;
            mabutFunkcjaX.Enabled = true;
            mabutKolorLinii.Enabled = true;
            mabutKolorTła.Enabled = true;
            mabutObliczCałkę.Enabled = true;
            mabutObliczCałkę.Visible = true;
            mabutTabela.Enabled = true;
            machartWykres.Visible = false;
            mabtnWykres.Enabled = true;
            madataGridView1.Visible = false;
            madataGridView1.Rows.Clear();
            maerrorProvider1.Clear();
            machartWykres.ChartAreas["ChartArea1"].BackColor = Color.White;
            mapictureBox1.Visible = true;
            marbOpis.Visible = true;
            marbOpis.Enabled = true;
            marbBezOpisu.Visible = true;
            marbBezOpisu.Enabled = true;
            malblZmiennaX.Font = new Font(malabel1.Font.FontFamily, 9);
            malblXg.Font = new Font(malabel1.Font.FontFamily, 9);
            malblXd.Font = new Font(malabel1.Font.FontFamily, 9);
            malblWartośćCałki.Font = new Font(malabel1.Font.FontFamily, 9);
            malblOpisOsi.Font = new Font(malabel1.Font.FontFamily, 9);
            malblKrokh.Font = new Font(malabel1.Font.FontFamily, 9);
            malblGórnaGranica.Font = new Font(malabel1.Font.FontFamily, 9);
            malblEps.Font = new Font(malabel1.Font.FontFamily, 9);
            malblDolnaGranica.Font = new Font(malabel1.Font.FontFamily, 9);
            malblDokładnoścObliczeń.Font = new Font(malabel1.Font.FontFamily, 9);
            malabel1.Font = new Font(malabel1.Font.FontFamily, 9);
            malabel2.Font = new Font(malabel1.Font.FontFamily, 9);
            malabel3.Font = new Font(malabel1.Font.FontFamily, 9);
            mabtnWykres.Font = new Font(malabel1.Font.FontFamily, 9);
            mabutFunkcjaX.Font = new Font(malabel1.Font.FontFamily, 9);
            mabutKolorLinii.Font = new Font(malabel1.Font.FontFamily, 9);
            mabutKolorTła.Font = new Font(malabel1.Font.FontFamily, 9);
            mabutObliczCałkę.Font = new Font(malabel1.Font.FontFamily, 9);
            mabutReset.Font = new Font(malabel1.Font.FontFamily, 9);
            mabutTabela.Font = new Font(malabel1.Font.FontFamily, 9);
            macbStylLini.Font = new Font(malabel1.Font.FontFamily, 9);
            machartWykres.Font = new Font(malabel1.Font.FontFamily, 9);
            matxtZmiennaX.Font = new Font(malabel1.Font.FontFamily, 9);
            matxtXg.Font = new Font(malabel1.Font.FontFamily, 9);
            matxtXd.Font = new Font(malabel1.Font.FontFamily, 9);
            matxtCD.Font = new Font(malabel1.Font.FontFamily, 9);
            matxtCG.Font = new Font(malabel1.Font.FontFamily, 9);
            matxtEps.Font = new Font(malabel1.Font.FontFamily, 9);
            matxtEps2.Font = new Font(malabel1.Font.FontFamily, 9);
            matxth.Font = new Font(malabel1.Font.FontFamily, 9);
            matxtKolorLinii.Font = new Font(malabel1.Font.FontFamily, 9);
            matxtKolorTła.Font = new Font(malabel1.Font.FontFamily, 9);
            matxtObliczanieFX.Font = new Font(malabel1.Font.FontFamily, 9);
            matxtWartośćCałki.Font = new Font(malabel1.Font.FontFamily, 9);
            maciagłaToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 9);
            maexitToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 9);
            magrubośćLiniiToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 9);
            makolorCzcionkiToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 9);
            makolorLiniiWykresuToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 9);
            makolorTłaWykresuToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 9);
            makoloryToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 9);
            makreskowaToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 9);
            makreskowokropkowaToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 9);
            makropkowaToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 9);
            makrójPismaToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 9);
            makursywaToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 9);
            maodczytajTablicęZPlikuToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 9);
            maplikToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 9);
            mapogrubionaIKursywaToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 9);
            mapogrubionaToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 9);
            marbBezOpisu.Font = new Font(malabel1.Font.FontFamily, 9);
            marbOpis.Font = new Font(malabel1.Font.FontFamily, 9);
            marozmiarCzcionkiToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 9);
            mastylCzcionkiToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 9);
            malabel1.Font = new Font(malabel1.Font.FontFamily, 9);


        }

        private void butObliczCałkę_Click(object sender, EventArgs e)
        {
            float mad, mag, maEps, maCałka = 0.0f;
            string maWyborMetody;
            if (!maPobranieZmiennychCałkowania(out mad, out mag, out maEps, out maWyborMetody))
            {
                maerrorProvider1.SetError(mabutObliczCałkę, "Wystąpił błąd podczas wczytania danych");
                return;
            }
            else maerrorProvider1.Clear();
            if (maWyborMetody == "Metoda prostokątów")
            {
                maCałka = CałkametodąProstokątów(mad, mag, maEps, out int maLicznikIteracyjny);
            }
            if (maWyborMetody == "Metoda trapezów")
            {
                maCałka = CałkaMetodąTrapezów(mad, mag, maEps, out int maLicznikIteracyjny);
            }
            mabutObliczCałkę.Visible = false;
            matxtCD.Enabled = false;
            matxtCG.Enabled = false;
            matxtEps2.Enabled = false;
            matxtWartośćCałki.Text = string.Format("{0}", maCałka);
        }

        private void txtWartośćCałki_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void zapiszTablicęWPlikuToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        private void odczytajTablicęZPlikuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            madataGridView1.Rows.Clear();
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Otwórz plik tabeli";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string tak = dialog.FileName;
                string manie;
                manie = tak.Substring(0, tak.LastIndexOf('\\'));
                string[] maTekst = File.ReadAllLines(tak);
                foreach(string maLine in maTekst)
                {
                  
                    madataGridView1.Rows.Add(maLine.Split('\t'));
                    
                }
            }
        }

        private void cmbWybórMetody_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void zapiszTablicęWPlikuToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //sprawdzenie włączenia tablicy
            if (madataGridView1.Visible)
            {

            }
            //jeśli tablica nie została włączona wychodzi błąd 
            else
            {
                maerrorProvider1.SetError(mabtnWykres, "Musisz wcześniej wykonać wizualizację tabelę");
                return;
            }
            maerrorProvider1.Dispose();
            SaveFileDialog OknoZapisuPliku = new SaveFileDialog();
            OknoZapisuPliku.Filter = "txt files (*.txt)|*.txt|All Files(*.*)|*.*";
            OknoZapisuPliku.FilterIndex = 1;
            OknoZapisuPliku.RestoreDirectory = true;
            OknoZapisuPliku.InitialDirectory = "C:\\";
            OknoZapisuPliku.Title = "Zapisanie wierszy danych tabeli";
            if (OknoZapisuPliku.ShowDialog() == DialogResult.OK)
            {
                StreamWriter maPlikZnakowy = new StreamWriter(OknoZapisuPliku.OpenFile());
                maPlikZnakowy.WriteLine("\n\n\t\t\t\tWiersze danych kontrolki");
                maPlikZnakowy.WriteLine("\n\t");
                for (int i = 0; i < madataGridView1.Rows.Count; i++)
                {
                    maPlikZnakowy.Write(string.Format("\t {0,8} ", madataGridView1.Rows[i].Cells[0].Value));
                    maPlikZnakowy.Write(string.Format("\t\t\t {0,8} ", madataGridView1.Rows[i].Cells[0].Value));

                }
                madataGridView1.Rows.Clear();
                maPlikZnakowy.Dispose();
                maPlikZnakowy.Close();
            }
            else
            {
                maerrorProvider1.SetError(mabutTabela, "Musisz wcześniej dokonać wizualizacji tabeli");
                return;
            }
        }

        private void butKolorLinii_Click(object sender, EventArgs e)
        {
            //deklaracja palety kolorów
            ColorDialog maPaletaKolorów = new ColorDialog();
            //ustawienie aktualnego koloru wykresów 
            maPaletaKolorów.Color = machartWykres.Series[0].Color;
            //wyświetlenie palety kolorów i "odczyt" nowego koloru
            if (maPaletaKolorów.ShowDialog() == DialogResult.OK)
            //zmiana koloru w kontrolce chart
            { machartWykres.Series[0].Color = maPaletaKolorów.Color; }
            matxtKolorLinii.BackColor = maPaletaKolorów.Color;
            
            
        }

        private void butKolorTła_Click(object sender, EventArgs e)
        {
            // deklaracja i utworzenie egzemplarza Palety kolorów
            ColorDialog PaletaKolorów = new ColorDialog();
            //ustawienie aktualnego koloru tła wykresu
            PaletaKolorów.Color = machartWykres.BackColor;
            // wyświelenie palety kolorów i "odczyt" nowego koloru
            if (PaletaKolorów.ShowDialog() == DialogResult.OK)
            machartWykres.BackColor = PaletaKolorów.Color;
            matxtKolorTła.BackColor = PaletaKolorów.Color;
        }
        //nadanie wartości grubości wszystkim przyciskom 
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            machartWykres.Series[0].BorderWidth = 1;
            matbGrubość.Value = 1;
            matxtGrubość.Text = "1";
            machartWykres.Series[0].BorderWidth = matbGrubość.Value;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            machartWykres.Series[0].BorderWidth = 2;
            matbGrubość.Value = 2;
            matxtGrubość.Text = "2";
            machartWykres.Series[0].BorderWidth = matbGrubość.Value;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            machartWykres.Series[0].BorderWidth = 3;
            matbGrubość.Value = 3;
            matxtGrubość.Text = "3";
            machartWykres.Series[0].BorderWidth = matbGrubość.Value;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            machartWykres.Series[0].BorderWidth = 4;
            matbGrubość.Value = 4;
            matxtGrubość.Text = "4";
            machartWykres.Series[0].BorderWidth = matbGrubość.Value;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            machartWykres.Series[0].BorderWidth = 5;
            matbGrubość.Value = 5;
            matxtGrubość.Text = "5";
            machartWykres.Series[0].BorderWidth = matbGrubość.Value;
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            machartWykres.Series[0].BorderWidth = 6;
            matbGrubość.Value = 6;
            matxtGrubość.Text = "6";
            machartWykres.Series[0].BorderWidth = matbGrubość.Value;
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            machartWykres.Series[0].BorderWidth = 7;
            matbGrubość.Value = 7;
            matxtGrubość.Text = "7";
            machartWykres.Series[0].BorderWidth = matbGrubość.Value;
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            machartWykres.Series[0].BorderWidth = 8;
            matbGrubość.Value = 8;
            matxtGrubość.Text = "8";
            machartWykres.Series[0].BorderWidth = matbGrubość.Value;
        }

        private void tbGrubość_Scroll(object sender, EventArgs e)
        {
            machartWykres.Series[0].BorderWidth = matbGrubość.Value;
            machartWykres.Series[0].BorderWidth = matbGrubość.Value;
            matbGrubość.Value = matbGrubość.Value;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbOpis_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblWartośćCałki_Click(object sender, EventArgs e)
        {

        }

        private void makrójPismaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog maOknoWyboruCzcionki = new FontDialog(); //deklaruje zmienną czcionki 
            if (maOknoWyboruCzcionki.ShowDialog() == DialogResult.OK) //otwiera okno z formatowaniem czcionek
            { //nadaje danym tekstom czcionki wybrane przez użytkownika
                machartWykres.ChartAreas[0].AxisY.TitleFont = maOknoWyboruCzcionki.Font;
                machartWykres.ChartAreas[0].AxisX.TitleFont = maOknoWyboruCzcionki.Font;
                machartWykres.ChartAreas[0].AxisX.LabelStyle.Font = maOknoWyboruCzcionki.Font;
                machartWykres.ChartAreas[0].AxisY.LabelStyle.Font = maOknoWyboruCzcionki.Font;
                malabel1.Font = maOknoWyboruCzcionki.Font;
                malblZmiennaX.Font = maOknoWyboruCzcionki.Font;
                malblXg.Font = maOknoWyboruCzcionki.Font;
                malblXd.Font = maOknoWyboruCzcionki.Font;
                malblWartośćCałki.Font = maOknoWyboruCzcionki.Font;
                malblOpisOsi.Font = maOknoWyboruCzcionki.Font;
                malblKrokh.Font = maOknoWyboruCzcionki.Font;
                malblGórnaGranica.Font = maOknoWyboruCzcionki.Font;
                malblEps.Font = maOknoWyboruCzcionki.Font;
                malblDolnaGranica.Font = maOknoWyboruCzcionki.Font;
                malblDokładnoścObliczeń.Font = maOknoWyboruCzcionki.Font;
                malabel1.Font = maOknoWyboruCzcionki.Font;
                malabel2.Font = maOknoWyboruCzcionki.Font;
                malabel3.Font = maOknoWyboruCzcionki.Font;
                mabtnWykres.Font = maOknoWyboruCzcionki.Font;
                mabutFunkcjaX.Font = maOknoWyboruCzcionki.Font;
                mabutKolorLinii.Font = maOknoWyboruCzcionki.Font;
                mabutKolorTła.Font = maOknoWyboruCzcionki.Font;
                mabutObliczCałkę.Font = maOknoWyboruCzcionki.Font;
                mabutReset.Font = maOknoWyboruCzcionki.Font;
                mabutTabela.Font = maOknoWyboruCzcionki.Font;
                macbStylLini.Font = maOknoWyboruCzcionki.Font;
                machartWykres.Font = maOknoWyboruCzcionki.Font;
                matxtZmiennaX.Font = maOknoWyboruCzcionki.Font;
                matxtXg.Font = maOknoWyboruCzcionki.Font;
                matxtXd.Font = maOknoWyboruCzcionki.Font;
                matxtCD.Font = maOknoWyboruCzcionki.Font;
                matxtCG.Font = maOknoWyboruCzcionki.Font;
                matxtEps.Font = maOknoWyboruCzcionki.Font;
                matxtEps2.Font = maOknoWyboruCzcionki.Font;
                matxth.Font = maOknoWyboruCzcionki.Font;
                matxtKolorLinii.Font = maOknoWyboruCzcionki.Font;
                matxtKolorTła.Font = maOknoWyboruCzcionki.Font;
                matxtObliczanieFX.Font = maOknoWyboruCzcionki.Font;
                matxtWartośćCałki.Font = maOknoWyboruCzcionki.Font;
                maciagłaToolStripMenuItem.Font = maOknoWyboruCzcionki.Font;
                maexitToolStripMenuItem.Font = maOknoWyboruCzcionki.Font;
                magrubośćLiniiToolStripMenuItem.Font = maOknoWyboruCzcionki.Font;
                makolorCzcionkiToolStripMenuItem.Font = maOknoWyboruCzcionki.Font;
                makolorLiniiWykresuToolStripMenuItem.Font = maOknoWyboruCzcionki.Font;
                makolorTłaWykresuToolStripMenuItem.Font = maOknoWyboruCzcionki.Font;
                makoloryToolStripMenuItem.Font = maOknoWyboruCzcionki.Font;
                makreskowaToolStripMenuItem.Font = maOknoWyboruCzcionki.Font;
                makreskowokropkowaToolStripMenuItem.Font = maOknoWyboruCzcionki.Font;
                makropkowaToolStripMenuItem.Font = maOknoWyboruCzcionki.Font;
                makrójPismaToolStripMenuItem.Font = maOknoWyboruCzcionki.Font;
                makursywaToolStripMenuItem.Font = maOknoWyboruCzcionki.Font;
                maodczytajTablicęZPlikuToolStripMenuItem.Font = maOknoWyboruCzcionki.Font;
                maplikToolStripMenuItem.Font = maOknoWyboruCzcionki.Font;
                mapogrubionaIKursywaToolStripMenuItem.Font = maOknoWyboruCzcionki.Font;
                mapogrubionaToolStripMenuItem.Font = maOknoWyboruCzcionki.Font;
                marbBezOpisu.Font = maOknoWyboruCzcionki.Font;
                marbOpis.Font = maOknoWyboruCzcionki.Font;
                marozmiarCzcionkiToolStripMenuItem.Font = maOknoWyboruCzcionki.Font;
                mastylCzcionkiToolStripMenuItem.Font = maOknoWyboruCzcionki.Font;
                malabel1.Font = maOknoWyboruCzcionki.Font;
            }
        }

        private void mapogrubionaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            malblZmiennaX.Font = new Font(this.Font, FontStyle.Bold);
            malblXg.Font = new Font(this.Font, FontStyle.Bold);
            malblXd.Font = new Font(this.Font, FontStyle.Bold);
            malblWartośćCałki.Font = new Font(this.Font, FontStyle.Bold);
            malblOpisOsi.Font = new Font(this.Font, FontStyle.Bold);
            malblKrokh.Font = new Font(this.Font, FontStyle.Bold);
            malblGórnaGranica.Font = new Font(this.Font, FontStyle.Bold);
            malblEps.Font = new Font(this.Font, FontStyle.Bold);
            malblDolnaGranica.Font = new Font(this.Font, FontStyle.Bold);
            malblDokładnoścObliczeń.Font = new Font(this.Font, FontStyle.Bold);
            malabel1.Font = new Font(this.Font, FontStyle.Bold);
            malabel2.Font = new Font(this.Font, FontStyle.Bold);
            malabel3.Font = new Font(this.Font, FontStyle.Bold);
            mabtnWykres.Font = new Font(this.Font, FontStyle.Bold);
            mabutFunkcjaX.Font = new Font(this.Font, FontStyle.Bold);
            mabutKolorLinii.Font = new Font(this.Font, FontStyle.Bold);
            mabutKolorTła.Font = new Font(this.Font, FontStyle.Bold);
            mabutObliczCałkę.Font = new Font(this.Font, FontStyle.Bold);
            mabutReset.Font = new Font(this.Font, FontStyle.Bold);
            mabutTabela.Font = new Font(this.Font, FontStyle.Bold);
            macbStylLini.Font = new Font(this.Font, FontStyle.Bold);
            machartWykres.Font = new Font(this.Font, FontStyle.Bold);
            matxtZmiennaX.Font = new Font(this.Font, FontStyle.Bold);
            matxtXg.Font = new Font(this.Font, FontStyle.Bold);
            matxtXd.Font = new Font(this.Font, FontStyle.Bold);
            matxtCD.Font = new Font(this.Font, FontStyle.Bold);
            matxtCG.Font = new Font(this.Font, FontStyle.Bold);
            matxtEps.Font = new Font(this.Font, FontStyle.Bold);
            matxtEps2.Font = new Font(this.Font, FontStyle.Bold);
            matxth.Font = new Font(this.Font, FontStyle.Bold);
            matxtKolorLinii.Font = new Font(this.Font, FontStyle.Bold);
            matxtKolorTła.Font = new Font(this.Font, FontStyle.Bold);
            matxtObliczanieFX.Font = new Font(this.Font, FontStyle.Bold);
            matxtWartośćCałki.Font = new Font(this.Font, FontStyle.Bold);
            maciagłaToolStripMenuItem.Font = new Font(this.Font, FontStyle.Bold);
            maexitToolStripMenuItem.Font = new Font(this.Font, FontStyle.Bold);
            magrubośćLiniiToolStripMenuItem.Font = new Font(this.Font, FontStyle.Bold);
            makolorCzcionkiToolStripMenuItem.Font = new Font(this.Font, FontStyle.Bold);
            makolorLiniiWykresuToolStripMenuItem.Font = new Font(this.Font, FontStyle.Bold);
            makolorTłaWykresuToolStripMenuItem.Font = new Font(this.Font, FontStyle.Bold);
            makoloryToolStripMenuItem.Font = new Font(this.Font, FontStyle.Bold);
            makreskowaToolStripMenuItem.Font = new Font(this.Font, FontStyle.Bold);
            makreskowokropkowaToolStripMenuItem.Font = new Font(this.Font, FontStyle.Bold);
            makropkowaToolStripMenuItem.Font = new Font(this.Font, FontStyle.Bold);
            makrójPismaToolStripMenuItem.Font = new Font(this.Font, FontStyle.Bold);
            makursywaToolStripMenuItem.Font = new Font(this.Font, FontStyle.Bold);
            maodczytajTablicęZPlikuToolStripMenuItem.Font = new Font(this.Font, FontStyle.Bold);
            maplikToolStripMenuItem.Font = new Font(this.Font, FontStyle.Bold);
            mapogrubionaIKursywaToolStripMenuItem.Font = new Font(this.Font, FontStyle.Bold);
            mapogrubionaToolStripMenuItem.Font = new Font(this.Font, FontStyle.Bold);
            marbBezOpisu.Font = new Font(this.Font, FontStyle.Bold);
            marbOpis.Font = new Font(this.Font, FontStyle.Bold);
            marozmiarCzcionkiToolStripMenuItem.Font = new Font(this.Font, FontStyle.Bold);
            mastylCzcionkiToolStripMenuItem.Font = new Font(this.Font, FontStyle.Bold);
        }

        private void makursywaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            malblZmiennaX.Font = new Font(this.Font, FontStyle.Italic);
            malblXg.Font = new Font(this.Font, FontStyle.Italic);
            malblXd.Font = new Font(this.Font, FontStyle.Italic);
            malblWartośćCałki.Font = new Font(this.Font, FontStyle.Italic);
            malblOpisOsi.Font = new Font(this.Font, FontStyle.Italic);
            malblKrokh.Font = new Font(this.Font, FontStyle.Italic);
            malblGórnaGranica.Font = new Font(this.Font, FontStyle.Italic);
            malblEps.Font = new Font(this.Font, FontStyle.Italic);
            malblDolnaGranica.Font = new Font(this.Font, FontStyle.Italic);
            malblDokładnoścObliczeń.Font = new Font(this.Font, FontStyle.Italic);
            malabel1.Font = new Font(this.Font, FontStyle.Italic);
            malabel2.Font = new Font(this.Font, FontStyle.Italic);
            malabel3.Font = new Font(this.Font, FontStyle.Italic);
            mabtnWykres.Font = new Font(this.Font, FontStyle.Italic);
            mabutFunkcjaX.Font = new Font(this.Font, FontStyle.Italic);
            mabutKolorLinii.Font = new Font(this.Font, FontStyle.Italic);
            mabutKolorTła.Font = new Font(this.Font, FontStyle.Italic);
            mabutObliczCałkę.Font = new Font(this.Font, FontStyle.Italic);
            mabutReset.Font = new Font(this.Font, FontStyle.Italic);
            mabutTabela.Font = new Font(this.Font, FontStyle.Italic);
            macbStylLini.Font = new Font(this.Font, FontStyle.Italic);
            machartWykres.Font = new Font(this.Font, FontStyle.Italic);
            matxtZmiennaX.Font = new Font(this.Font, FontStyle.Italic);
            matxtXg.Font = new Font(this.Font, FontStyle.Italic);
            matxtXd.Font = new Font(this.Font, FontStyle.Italic);
            matxtCD.Font = new Font(this.Font, FontStyle.Italic);
            matxtCG.Font = new Font(this.Font, FontStyle.Italic);
            matxtEps.Font = new Font(this.Font, FontStyle.Italic);
            matxtEps2.Font = new Font(this.Font, FontStyle.Italic);
            matxth.Font = new Font(this.Font, FontStyle.Italic);
            matxtKolorLinii.Font = new Font(this.Font, FontStyle.Italic);
            matxtKolorTła.Font = new Font(this.Font, FontStyle.Italic);
            matxtObliczanieFX.Font = new Font(this.Font, FontStyle.Italic);
            matxtWartośćCałki.Font = new Font(this.Font, FontStyle.Italic);
            maciagłaToolStripMenuItem.Font = new Font(this.Font, FontStyle.Italic);
            maexitToolStripMenuItem.Font = new Font(this.Font, FontStyle.Italic);
            magrubośćLiniiToolStripMenuItem.Font = new Font(this.Font, FontStyle.Italic);
            makolorCzcionkiToolStripMenuItem.Font = new Font(this.Font, FontStyle.Italic);
            makolorLiniiWykresuToolStripMenuItem.Font = new Font(this.Font, FontStyle.Italic);
            makolorTłaWykresuToolStripMenuItem.Font = new Font(this.Font, FontStyle.Italic);
            makoloryToolStripMenuItem.Font = new Font(this.Font, FontStyle.Italic);
            makreskowaToolStripMenuItem.Font = new Font(this.Font, FontStyle.Italic);
            makreskowokropkowaToolStripMenuItem.Font = new Font(this.Font, FontStyle.Italic);
            makropkowaToolStripMenuItem.Font = new Font(this.Font, FontStyle.Italic);
            makrójPismaToolStripMenuItem.Font = new Font(this.Font, FontStyle.Italic);
            makursywaToolStripMenuItem.Font = new Font(this.Font, FontStyle.Italic);
            maodczytajTablicęZPlikuToolStripMenuItem.Font = new Font(this.Font, FontStyle.Italic);
            maplikToolStripMenuItem.Font = new Font(this.Font, FontStyle.Italic);
            mapogrubionaIKursywaToolStripMenuItem.Font = new Font(this.Font, FontStyle.Italic);
            mapogrubionaToolStripMenuItem.Font = new Font(this.Font, FontStyle.Italic);
            marbBezOpisu.Font = new Font(this.Font, FontStyle.Italic);
            marbOpis.Font = new Font(this.Font, FontStyle.Italic);
            marozmiarCzcionkiToolStripMenuItem.Font = new Font(this.Font, FontStyle.Italic);
            mastylCzcionkiToolStripMenuItem.Font = new Font(this.Font, FontStyle.Italic);
        }

        private void mapogrubionaIKursywaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            malblZmiennaX.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
            malblXg.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
            malblXd.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
            malblWartośćCałki.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
            malblOpisOsi.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
            malblKrokh.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
            malblGórnaGranica.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
            malblEps.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
            malblDolnaGranica.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
            malblDokładnoścObliczeń.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
            malabel1.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
            malabel2.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
            malabel3.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
            mabtnWykres.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
            mabutFunkcjaX.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
            mabutKolorLinii.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
            mabutKolorTła.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
            mabutObliczCałkę.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
            mabutReset.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
            mabutTabela.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
            macbStylLini.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
            machartWykres.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
            matxtZmiennaX.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
            matxtXg.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
            matxtXd.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
            matxtCD.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
            matxtCG.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
            matxtEps.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
            matxtEps2.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
            matxth.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
            matxtKolorLinii.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
            matxtKolorTła.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
            matxtObliczanieFX.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
            matxtWartośćCałki.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
            maciagłaToolStripMenuItem.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
            maexitToolStripMenuItem.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
            magrubośćLiniiToolStripMenuItem.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
            makolorCzcionkiToolStripMenuItem.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
            makolorLiniiWykresuToolStripMenuItem.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
            makolorTłaWykresuToolStripMenuItem.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
            makoloryToolStripMenuItem.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
            makreskowaToolStripMenuItem.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
            makreskowokropkowaToolStripMenuItem.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
            makropkowaToolStripMenuItem.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
            makrójPismaToolStripMenuItem.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
            makursywaToolStripMenuItem.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
            maodczytajTablicęZPlikuToolStripMenuItem.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
            maplikToolStripMenuItem.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
            mapogrubionaIKursywaToolStripMenuItem.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
            mapogrubionaToolStripMenuItem.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
            marbBezOpisu.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
            marbOpis.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
            marozmiarCzcionkiToolStripMenuItem.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
            mastylCzcionkiToolStripMenuItem.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
        }

            private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            malblZmiennaX.Font = new Font(malabel1.Font.FontFamily, 6);
            malblXg.Font = new Font(malabel1.Font.FontFamily, 6);
            malblXd.Font = new Font(malabel1.Font.FontFamily, 6);
            malblWartośćCałki.Font = new Font(malabel1.Font.FontFamily, 6);
            malblOpisOsi.Font = new Font(malabel1.Font.FontFamily, 6);
            malblKrokh.Font = new Font(malabel1.Font.FontFamily, 6);
            malblGórnaGranica.Font = new Font(malabel1.Font.FontFamily, 6);
            malblEps.Font = new Font(malabel1.Font.FontFamily, 6);
            malblDolnaGranica.Font = new Font(malabel1.Font.FontFamily, 6);
            malblDokładnoścObliczeń.Font = new Font(malabel1.Font.FontFamily, 6);
            malabel1.Font = new Font(malabel1.Font.FontFamily, 6);
            malabel2.Font = new Font(malabel1.Font.FontFamily, 6);
            malabel3.Font = new Font(malabel1.Font.FontFamily, 6);
            mabtnWykres.Font = new Font(malabel1.Font.FontFamily, 6);
            mabutFunkcjaX.Font = new Font(malabel1.Font.FontFamily, 6);
            mabutKolorLinii.Font = new Font(malabel1.Font.FontFamily, 6);
            mabutKolorTła.Font = new Font(malabel1.Font.FontFamily, 6);
            mabutObliczCałkę.Font = new Font(malabel1.Font.FontFamily, 6);
            mabutReset.Font = new Font(malabel1.Font.FontFamily, 6);
            mabutTabela.Font = new Font(malabel1.Font.FontFamily, 6);
            macbStylLini.Font = new Font(malabel1.Font.FontFamily, 6);
            machartWykres.Font = new Font(malabel1.Font.FontFamily, 6);
            matxtZmiennaX.Font = new Font(malabel1.Font.FontFamily, 6);
            matxtXg.Font = new Font(malabel1.Font.FontFamily, 6);
            matxtXd.Font = new Font(malabel1.Font.FontFamily, 6);
            matxtCD.Font = new Font(malabel1.Font.FontFamily, 6);
            matxtCG.Font = new Font(malabel1.Font.FontFamily, 6);
            matxtEps.Font = new Font(malabel1.Font.FontFamily, 6);
            matxtEps2.Font = new Font(malabel1.Font.FontFamily, 6);
            matxth.Font = new Font(malabel1.Font.FontFamily, 6);
            matxtKolorLinii.Font = new Font(malabel1.Font.FontFamily, 6);
            matxtKolorTła.Font = new Font(malabel1.Font.FontFamily, 6);
            matxtObliczanieFX.Font = new Font(malabel1.Font.FontFamily, 6);
            matxtWartośćCałki.Font = new Font(malabel1.Font.FontFamily, 6);
            maciagłaToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 6);
            maexitToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 6);
            magrubośćLiniiToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 6);
            makolorCzcionkiToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 6);
            makolorLiniiWykresuToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 6);
            makolorTłaWykresuToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 6);
            makoloryToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 6);
            makreskowaToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 6);
            makreskowokropkowaToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 6);
            makropkowaToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 6);
            makrójPismaToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 6);
            makursywaToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 6);
            maodczytajTablicęZPlikuToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 6);
            maplikToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 6);
            mapogrubionaIKursywaToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 6);
            mapogrubionaToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 6);
            marbBezOpisu.Font = new Font(malabel1.Font.FontFamily, 6);
            marbOpis.Font = new Font(malabel1.Font.FontFamily, 6);
            marozmiarCzcionkiToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 6);
            mastylCzcionkiToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 6);
            malabel1.Font = new Font(malabel1.Font.FontFamily, 6);
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            malblZmiennaX.Font = new Font(malabel1.Font.FontFamily, 7);
            malblXg.Font = new Font(malabel1.Font.FontFamily, 7);
            malblXd.Font = new Font(malabel1.Font.FontFamily, 7);
            malblWartośćCałki.Font = new Font(malabel1.Font.FontFamily, 7);
            malblOpisOsi.Font = new Font(malabel1.Font.FontFamily, 7);
            malblKrokh.Font = new Font(malabel1.Font.FontFamily, 7);
            malblGórnaGranica.Font = new Font(malabel1.Font.FontFamily, 7);
            malblEps.Font = new Font(malabel1.Font.FontFamily, 7);
            malblDolnaGranica.Font = new Font(malabel1.Font.FontFamily, 7);
            malblDokładnoścObliczeń.Font = new Font(malabel1.Font.FontFamily, 7);
            malabel1.Font = new Font(malabel1.Font.FontFamily, 7);
            malabel2.Font = new Font(malabel1.Font.FontFamily, 7);
            malabel3.Font = new Font(malabel1.Font.FontFamily, 7);
            mabtnWykres.Font = new Font(malabel1.Font.FontFamily, 7);
            mabutFunkcjaX.Font = new Font(malabel1.Font.FontFamily, 7);
            mabutKolorLinii.Font = new Font(malabel1.Font.FontFamily, 7);
            mabutKolorTła.Font = new Font(malabel1.Font.FontFamily, 7);
            mabutObliczCałkę.Font = new Font(malabel1.Font.FontFamily, 7);
            mabutReset.Font = new Font(malabel1.Font.FontFamily, 7);
            mabutTabela.Font = new Font(malabel1.Font.FontFamily, 7);
            macbStylLini.Font = new Font(malabel1.Font.FontFamily, 7);
            machartWykres.Font = new Font(malabel1.Font.FontFamily, 7);
            matxtZmiennaX.Font = new Font(malabel1.Font.FontFamily, 7);
            matxtXg.Font = new Font(malabel1.Font.FontFamily, 7);
            matxtXd.Font = new Font(malabel1.Font.FontFamily, 7);
            matxtCD.Font = new Font(malabel1.Font.FontFamily, 7);
            matxtCG.Font = new Font(malabel1.Font.FontFamily, 7);
            matxtEps.Font = new Font(malabel1.Font.FontFamily, 7);
            matxtEps2.Font = new Font(malabel1.Font.FontFamily, 7);
            matxth.Font = new Font(malabel1.Font.FontFamily, 7);
            matxtKolorLinii.Font = new Font(malabel1.Font.FontFamily, 7);
            matxtKolorTła.Font = new Font(malabel1.Font.FontFamily, 7);
            matxtObliczanieFX.Font = new Font(malabel1.Font.FontFamily, 7);
            matxtWartośćCałki.Font = new Font(malabel1.Font.FontFamily, 7);
            maciagłaToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 7);
            maexitToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 7);
            magrubośćLiniiToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 7);
            makolorCzcionkiToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 7);
            makolorLiniiWykresuToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 7);
            makolorTłaWykresuToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 7);
            makoloryToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 7);
            makreskowaToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 7);
            makreskowokropkowaToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 7);
            makropkowaToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 7);
            makrójPismaToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 7);
            makursywaToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 7);
            maodczytajTablicęZPlikuToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 7);
            maplikToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 7);
            mapogrubionaIKursywaToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 7);
            mapogrubionaToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 7);
            marbBezOpisu.Font = new Font(malabel1.Font.FontFamily, 7);
            marbOpis.Font = new Font(malabel1.Font.FontFamily, 7);
            marozmiarCzcionkiToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 7);
            mastylCzcionkiToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 7);
            malabel1.Font = new Font(malabel1.Font.FontFamily, 7);
        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            malblZmiennaX.Font = new Font(malabel1.Font.FontFamily, 8);
            malblXg.Font = new Font(malabel1.Font.FontFamily, 8);
            malblXd.Font = new Font(malabel1.Font.FontFamily, 8);
            malblWartośćCałki.Font = new Font(malabel1.Font.FontFamily, 8);
            malblOpisOsi.Font = new Font(malabel1.Font.FontFamily, 8);
            malblKrokh.Font = new Font(malabel1.Font.FontFamily, 8);
            malblGórnaGranica.Font = new Font(malabel1.Font.FontFamily, 8);
            malblEps.Font = new Font(malabel1.Font.FontFamily, 8);
            malblDolnaGranica.Font = new Font(malabel1.Font.FontFamily, 8);
            malblDokładnoścObliczeń.Font = new Font(malabel1.Font.FontFamily, 8);
            malabel1.Font = new Font(malabel1.Font.FontFamily, 8);
            malabel2.Font = new Font(malabel1.Font.FontFamily, 8);
            malabel3.Font = new Font(malabel1.Font.FontFamily, 8);
            mabtnWykres.Font = new Font(malabel1.Font.FontFamily, 8);
            mabutFunkcjaX.Font = new Font(malabel1.Font.FontFamily, 8);
            mabutKolorLinii.Font = new Font(malabel1.Font.FontFamily, 8);
            mabutKolorTła.Font = new Font(malabel1.Font.FontFamily, 8);
            mabutObliczCałkę.Font = new Font(malabel1.Font.FontFamily, 8);
            mabutReset.Font = new Font(malabel1.Font.FontFamily, 8);
            mabutTabela.Font = new Font(malabel1.Font.FontFamily, 8);
            macbStylLini.Font = new Font(malabel1.Font.FontFamily, 8);
            machartWykres.Font = new Font(malabel1.Font.FontFamily, 8);
            matxtZmiennaX.Font = new Font(malabel1.Font.FontFamily, 8);
            matxtXg.Font = new Font(malabel1.Font.FontFamily, 8);
            matxtXd.Font = new Font(malabel1.Font.FontFamily, 8);
            matxtCD.Font = new Font(malabel1.Font.FontFamily, 8);
            matxtCG.Font = new Font(malabel1.Font.FontFamily, 8);
            matxtEps.Font = new Font(malabel1.Font.FontFamily, 8);
            matxtEps2.Font = new Font(malabel1.Font.FontFamily, 8);
            matxth.Font = new Font(malabel1.Font.FontFamily, 8);
            matxtKolorLinii.Font = new Font(malabel1.Font.FontFamily, 8);
            matxtKolorTła.Font = new Font(malabel1.Font.FontFamily, 8);
            matxtObliczanieFX.Font = new Font(malabel1.Font.FontFamily, 8);
            matxtWartośćCałki.Font = new Font(malabel1.Font.FontFamily, 8);
            maciagłaToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 8);
            maexitToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 8);
            magrubośćLiniiToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 8);
            makolorCzcionkiToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 8);
            makolorLiniiWykresuToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 8);
            makolorTłaWykresuToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 8);
            makoloryToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 8);
            makreskowaToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 8);
            makreskowokropkowaToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 8);
            makropkowaToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 8);
            makrójPismaToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 8);
            makursywaToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 8);
            maodczytajTablicęZPlikuToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 8);
            maplikToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 8);
            mapogrubionaIKursywaToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 8);
            mapogrubionaToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 8);
            marbBezOpisu.Font = new Font(malabel1.Font.FontFamily, 8);
            marbOpis.Font = new Font(malabel1.Font.FontFamily, 8);
            marozmiarCzcionkiToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 8);
            mastylCzcionkiToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 8);
            malabel1.Font = new Font(malabel1.Font.FontFamily, 8);
        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            malblZmiennaX.Font = new Font(malabel1.Font.FontFamily, 9);
            malblXg.Font = new Font(malabel1.Font.FontFamily, 9);
            malblXd.Font = new Font(malabel1.Font.FontFamily, 9);
            malblWartośćCałki.Font = new Font(malabel1.Font.FontFamily, 9);
            malblOpisOsi.Font = new Font(malabel1.Font.FontFamily, 9);
            malblKrokh.Font = new Font(malabel1.Font.FontFamily, 9);
            malblGórnaGranica.Font = new Font(malabel1.Font.FontFamily, 9);
            malblEps.Font = new Font(malabel1.Font.FontFamily, 9);
            malblDolnaGranica.Font = new Font(malabel1.Font.FontFamily, 9);
            malblDokładnoścObliczeń.Font = new Font(malabel1.Font.FontFamily, 9);
            malabel1.Font = new Font(malabel1.Font.FontFamily, 9);
            malabel2.Font = new Font(malabel1.Font.FontFamily, 9);
            malabel3.Font = new Font(malabel1.Font.FontFamily, 9);
            mabtnWykres.Font = new Font(malabel1.Font.FontFamily, 9);
            mabutFunkcjaX.Font = new Font(malabel1.Font.FontFamily, 9);
            mabutKolorLinii.Font = new Font(malabel1.Font.FontFamily, 9);
            mabutKolorTła.Font = new Font(malabel1.Font.FontFamily, 9);
            mabutObliczCałkę.Font = new Font(malabel1.Font.FontFamily, 9);
            mabutReset.Font = new Font(malabel1.Font.FontFamily, 9);
            mabutTabela.Font = new Font(malabel1.Font.FontFamily, 9);
            macbStylLini.Font = new Font(malabel1.Font.FontFamily, 9);
            machartWykres.Font = new Font(malabel1.Font.FontFamily, 9);
            matxtZmiennaX.Font = new Font(malabel1.Font.FontFamily, 9);
            matxtXg.Font = new Font(malabel1.Font.FontFamily, 9);
            matxtXd.Font = new Font(malabel1.Font.FontFamily, 9);
            matxtCD.Font = new Font(malabel1.Font.FontFamily, 9);
            matxtCG.Font = new Font(malabel1.Font.FontFamily, 9);
            matxtEps.Font = new Font(malabel1.Font.FontFamily, 9);
            matxtEps2.Font = new Font(malabel1.Font.FontFamily, 9);
            matxth.Font = new Font(malabel1.Font.FontFamily, 9);
            matxtKolorLinii.Font = new Font(malabel1.Font.FontFamily, 9);
            matxtKolorTła.Font = new Font(malabel1.Font.FontFamily, 9);
            matxtObliczanieFX.Font = new Font(malabel1.Font.FontFamily, 9);
            matxtWartośćCałki.Font = new Font(malabel1.Font.FontFamily, 9);
            maciagłaToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 9);
            maexitToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 9);
            magrubośćLiniiToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 9);
            makolorCzcionkiToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 9);
            makolorLiniiWykresuToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 9);
            makolorTłaWykresuToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 9);
            makoloryToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 9);
            makreskowaToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 9);
            makreskowokropkowaToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 9);
            makropkowaToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 9);
            makrójPismaToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 9);
            makursywaToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 9);
            maodczytajTablicęZPlikuToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 9);
            maplikToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 9);
            mapogrubionaIKursywaToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 9);
            mapogrubionaToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 9);
            marbBezOpisu.Font = new Font(malabel1.Font.FontFamily, 9);
            marbOpis.Font = new Font(malabel1.Font.FontFamily, 9);
            marozmiarCzcionkiToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 9);
            mastylCzcionkiToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 9);
            malabel1.Font = new Font(malabel1.Font.FontFamily, 9);
        }

        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {
            malblZmiennaX.Font = new Font(malabel1.Font.FontFamily, 10);
            malblXg.Font = new Font(malabel1.Font.FontFamily, 10);
            malblXd.Font = new Font(malabel1.Font.FontFamily, 10);
            malblWartośćCałki.Font = new Font(malabel1.Font.FontFamily, 10);
            malblOpisOsi.Font = new Font(malabel1.Font.FontFamily, 10);
            malblKrokh.Font = new Font(malabel1.Font.FontFamily, 10);
            malblGórnaGranica.Font = new Font(malabel1.Font.FontFamily, 10);
            malblEps.Font = new Font(malabel1.Font.FontFamily, 10);
            malblDolnaGranica.Font = new Font(malabel1.Font.FontFamily, 10);
            malblDokładnoścObliczeń.Font = new Font(malabel1.Font.FontFamily, 10);
            malabel1.Font = new Font(malabel1.Font.FontFamily, 10);
            malabel2.Font = new Font(malabel1.Font.FontFamily, 10);
            malabel3.Font = new Font(malabel1.Font.FontFamily, 10);
            mabtnWykres.Font = new Font(malabel1.Font.FontFamily, 10);
            mabutFunkcjaX.Font = new Font(malabel1.Font.FontFamily, 10);
            mabutKolorLinii.Font = new Font(malabel1.Font.FontFamily, 10);
            mabutKolorTła.Font = new Font(malabel1.Font.FontFamily, 10);
            mabutObliczCałkę.Font = new Font(malabel1.Font.FontFamily, 10);
            mabutReset.Font = new Font(malabel1.Font.FontFamily, 10);
            mabutTabela.Font = new Font(malabel1.Font.FontFamily, 10);
            macbStylLini.Font = new Font(malabel1.Font.FontFamily, 10);
            machartWykres.Font = new Font(malabel1.Font.FontFamily, 10);
            matxtZmiennaX.Font = new Font(malabel1.Font.FontFamily, 10);
            matxtXg.Font = new Font(malabel1.Font.FontFamily, 10);
            matxtXd.Font = new Font(malabel1.Font.FontFamily, 10);
            matxtCD.Font = new Font(malabel1.Font.FontFamily, 10);
            matxtCG.Font = new Font(malabel1.Font.FontFamily, 10);
            matxtEps.Font = new Font(malabel1.Font.FontFamily, 10);
            matxtEps2.Font = new Font(malabel1.Font.FontFamily, 10);
            matxth.Font = new Font(malabel1.Font.FontFamily, 10);
            matxtKolorLinii.Font = new Font(malabel1.Font.FontFamily, 10);
            matxtKolorTła.Font = new Font(malabel1.Font.FontFamily, 10);
            matxtObliczanieFX.Font = new Font(malabel1.Font.FontFamily, 10);
            matxtWartośćCałki.Font = new Font(malabel1.Font.FontFamily, 10);
            maciagłaToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 10);
            maexitToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 10);
            magrubośćLiniiToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 10);
            makolorCzcionkiToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 10);
            makolorLiniiWykresuToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 10);
            makolorTłaWykresuToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 10);
            makoloryToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 10);
            makreskowaToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 10);
            makreskowokropkowaToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 10);
            makropkowaToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 10);
            makrójPismaToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 10);
            makursywaToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 10);
            maodczytajTablicęZPlikuToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 10);
            maplikToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 10);
            mapogrubionaIKursywaToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 10);
            mapogrubionaToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 10);
            marbBezOpisu.Font = new Font(malabel1.Font.FontFamily, 10);
            marbOpis.Font = new Font(malabel1.Font.FontFamily, 10);
            marozmiarCzcionkiToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 10);
            mastylCzcionkiToolStripMenuItem.Font = new Font(malabel1.Font.FontFamily, 10);
            malabel1.Font = new Font(malabel1.Font.FontFamily, 10);
        }

        private void stylLiniiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void verdanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void matxtEps2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
