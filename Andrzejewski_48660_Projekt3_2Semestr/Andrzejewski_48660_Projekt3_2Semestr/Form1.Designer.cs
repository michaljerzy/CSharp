namespace Andrzejewski_48660_Projekt3_2Semestr
{
    partial class Andrzejewski
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.maPanelEdycji = new System.Windows.Forms.Panel();
            this.maBUTWyłączSlajder = new System.Windows.Forms.Button();
            this.maBUTFiguraNastępna = new System.Windows.Forms.Button();
            this.maBUTFiguraPoprzednia = new System.Windows.Forms.Button();
            this.maTXTBOXIndexFigury = new System.Windows.Forms.TextBox();
            this.maLBLIndexFigury = new System.Windows.Forms.Label();
            this.maBUTWłączenieSlajdera = new System.Windows.Forms.Button();
            this.pwRadioButtonRęcznie = new System.Windows.Forms.RadioButton();
            this.pwRadioButtonAuto = new System.Windows.Forms.RadioButton();
            this.maBUTKierunekWLewo = new System.Windows.Forms.Button();
            this.maBUTKierunekWPrawo = new System.Windows.Forms.Button();
            this.maBUTNowaBryła = new System.Windows.Forms.Button();
            this.maLBLStopieńWielokąta = new System.Windows.Forms.Label();
            this.maLBLWysokość = new System.Windows.Forms.Label();
            this.maLBLPromień = new System.Windows.Forms.Label();
            this.maCMBWybórBryły = new System.Windows.Forms.ComboBox();
            this.maLBLWybórFigury = new System.Windows.Forms.Label();
            this.maNUDKątNachylenia = new System.Windows.Forms.NumericUpDown();
            this.maNUDStopieńWielokąta = new System.Windows.Forms.NumericUpDown();
            this.maLBLKątNachylenia = new System.Windows.Forms.Label();
            this.maLStopieńWielokąta = new System.Windows.Forms.Label();
            this.maNUDNumerBryłyDoSkasowania = new System.Windows.Forms.NumericUpDown();
            this.maBTNUsuńWybranąBryłę = new System.Windows.Forms.Button();
            this.maBTNUsuńOstatniąBryłę = new System.Windows.Forms.Button();
            this.maBTNUsuńPierwsząBryłę = new System.Windows.Forms.Button();
            this.maGBoxKryteriaPokazu = new System.Windows.Forms.GroupBox();
            this.maRBTNPolePowierzchni = new System.Windows.Forms.RadioButton();
            this.maRBTNObjętośćBryły = new System.Windows.Forms.RadioButton();
            this.maRBTNPromieńBryły = new System.Windows.Forms.RadioButton();
            this.maRBTNWysokość = new System.Windows.Forms.RadioButton();
            this.maTBPromien = new System.Windows.Forms.TrackBar();
            this.maTBWysokosc = new System.Windows.Forms.TrackBar();
            this.maTimerDodawanie = new System.Windows.Forms.Timer(this.components);
            this.maTimerPokazSlajdów = new System.Windows.Forms.Timer(this.components);
            this.maPicBoxRysownica = new System.Windows.Forms.PictureBox();
            this.maGBoxUsuwanieBrył = new System.Windows.Forms.GroupBox();
            this.maGBoxSlajder = new System.Windows.Forms.GroupBox();
            this.maBTNLosujPołożenie = new System.Windows.Forms.Button();
            this.maBTNLosoweAtrybutyGraficzne = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.maNUDKątNachylenia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maNUDStopieńWielokąta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maNUDNumerBryłyDoSkasowania)).BeginInit();
            this.maGBoxKryteriaPokazu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maTBPromien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maTBWysokosc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maPicBoxRysownica)).BeginInit();
            this.maGBoxUsuwanieBrył.SuspendLayout();
            this.maGBoxSlajder.SuspendLayout();
            this.SuspendLayout();
            // 
            // maPanelEdycji
            // 
            this.maPanelEdycji.Location = new System.Drawing.Point(871, 377);
            this.maPanelEdycji.Name = "maPanelEdycji";
            this.maPanelEdycji.Size = new System.Drawing.Size(278, 218);
            this.maPanelEdycji.TabIndex = 56;
            this.maPanelEdycji.Paint += new System.Windows.Forms.PaintEventHandler(this.maPanelEdycji_Paint);
            // 
            // maBUTWyłączSlajder
            // 
            this.maBUTWyłączSlajder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maBUTWyłączSlajder.Location = new System.Drawing.Point(27, 274);
            this.maBUTWyłączSlajder.Name = "maBUTWyłączSlajder";
            this.maBUTWyłączSlajder.Size = new System.Drawing.Size(173, 79);
            this.maBUTWyłączSlajder.TabIndex = 55;
            this.maBUTWyłączSlajder.Text = "Wyłącz Slajder";
            this.maBUTWyłączSlajder.UseVisualStyleBackColor = true;
            this.maBUTWyłączSlajder.Click += new System.EventHandler(this.maBUTNoweAtrybuty_Click);
            // 
            // maBUTFiguraNastępna
            // 
            this.maBUTFiguraNastępna.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maBUTFiguraNastępna.Location = new System.Drawing.Point(143, 195);
            this.maBUTFiguraNastępna.Name = "maBUTFiguraNastępna";
            this.maBUTFiguraNastępna.Size = new System.Drawing.Size(115, 61);
            this.maBUTFiguraNastępna.TabIndex = 54;
            this.maBUTFiguraNastępna.Text = "Następna";
            this.maBUTFiguraNastępna.UseVisualStyleBackColor = true;
            this.maBUTFiguraNastępna.Click += new System.EventHandler(this.maBUTFiguraNastępna_Click);
            // 
            // maBUTFiguraPoprzednia
            // 
            this.maBUTFiguraPoprzednia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maBUTFiguraPoprzednia.Location = new System.Drawing.Point(7, 195);
            this.maBUTFiguraPoprzednia.Name = "maBUTFiguraPoprzednia";
            this.maBUTFiguraPoprzednia.Size = new System.Drawing.Size(115, 61);
            this.maBUTFiguraPoprzednia.TabIndex = 53;
            this.maBUTFiguraPoprzednia.Text = "Poprzednia";
            this.maBUTFiguraPoprzednia.UseVisualStyleBackColor = true;
            this.maBUTFiguraPoprzednia.Click += new System.EventHandler(this.maBUTFiguraPoprzednia_Click);
            // 
            // maTXTBOXIndexFigury
            // 
            this.maTXTBOXIndexFigury.Location = new System.Drawing.Point(100, 165);
            this.maTXTBOXIndexFigury.Name = "maTXTBOXIndexFigury";
            this.maTXTBOXIndexFigury.Size = new System.Drawing.Size(60, 20);
            this.maTXTBOXIndexFigury.TabIndex = 52;
            this.maTXTBOXIndexFigury.TextChanged += new System.EventHandler(this.maTXTBOXIndexFigury_TextChanged);
            // 
            // maLBLIndexFigury
            // 
            this.maLBLIndexFigury.AutoSize = true;
            this.maLBLIndexFigury.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maLBLIndexFigury.Location = new System.Drawing.Point(4, 165);
            this.maLBLIndexFigury.Name = "maLBLIndexFigury";
            this.maLBLIndexFigury.Size = new System.Drawing.Size(95, 16);
            this.maLBLIndexFigury.TabIndex = 51;
            this.maLBLIndexFigury.Text = "Index figury: ";
            // 
            // maBUTWłączenieSlajdera
            // 
            this.maBUTWłączenieSlajdera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maBUTWłączenieSlajdera.Location = new System.Drawing.Point(27, 70);
            this.maBUTWłączenieSlajdera.Name = "maBUTWłączenieSlajdera";
            this.maBUTWłączenieSlajdera.Size = new System.Drawing.Size(173, 79);
            this.maBUTWłączenieSlajdera.TabIndex = 50;
            this.maBUTWłączenieSlajdera.Text = "Włącz slajder";
            this.maBUTWłączenieSlajdera.UseVisualStyleBackColor = true;
            this.maBUTWłączenieSlajdera.Click += new System.EventHandler(this.maBUTWłączenieSlajdera_Click);
            // 
            // pwRadioButtonRęcznie
            // 
            this.pwRadioButtonRęcznie.AutoSize = true;
            this.pwRadioButtonRęcznie.Location = new System.Drawing.Point(16, 37);
            this.pwRadioButtonRęcznie.Name = "pwRadioButtonRęcznie";
            this.pwRadioButtonRęcznie.Size = new System.Drawing.Size(131, 17);
            this.pwRadioButtonRęcznie.TabIndex = 49;
            this.pwRadioButtonRęcznie.Text = "Ręczny pokaz slajdów";
            this.pwRadioButtonRęcznie.UseVisualStyleBackColor = true;
            this.pwRadioButtonRęcznie.CheckedChanged += new System.EventHandler(this.pwRadioButtonRęcznie_CheckedChanged);
            // 
            // pwRadioButtonAuto
            // 
            this.pwRadioButtonAuto.AutoSize = true;
            this.pwRadioButtonAuto.Checked = true;
            this.pwRadioButtonAuto.Location = new System.Drawing.Point(16, 14);
            this.pwRadioButtonAuto.Name = "pwRadioButtonAuto";
            this.pwRadioButtonAuto.Size = new System.Drawing.Size(161, 17);
            this.pwRadioButtonAuto.TabIndex = 48;
            this.pwRadioButtonAuto.TabStop = true;
            this.pwRadioButtonAuto.Text = "Automatyczny pokaz slajdów";
            this.pwRadioButtonAuto.UseVisualStyleBackColor = true;
            this.pwRadioButtonAuto.CheckedChanged += new System.EventHandler(this.pwRadioButtonAuto_CheckedChanged);
            // 
            // maBUTKierunekWLewo
            // 
            this.maBUTKierunekWLewo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maBUTKierunekWLewo.Location = new System.Drawing.Point(19, 385);
            this.maBUTKierunekWLewo.Name = "maBUTKierunekWLewo";
            this.maBUTKierunekWLewo.Size = new System.Drawing.Size(82, 58);
            this.maBUTKierunekWLewo.TabIndex = 69;
            this.maBUTKierunekWLewo.Text = "Kierunek obrotu w lewo";
            this.maBUTKierunekWLewo.UseVisualStyleBackColor = true;
            this.maBUTKierunekWLewo.Click += new System.EventHandler(this.maBUTKierunekWLewo_Click);
            // 
            // maBUTKierunekWPrawo
            // 
            this.maBUTKierunekWPrawo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maBUTKierunekWPrawo.Location = new System.Drawing.Point(107, 385);
            this.maBUTKierunekWPrawo.Name = "maBUTKierunekWPrawo";
            this.maBUTKierunekWPrawo.Size = new System.Drawing.Size(83, 58);
            this.maBUTKierunekWPrawo.TabIndex = 68;
            this.maBUTKierunekWPrawo.Text = "Kierunek obrotu w prawo";
            this.maBUTKierunekWPrawo.UseVisualStyleBackColor = true;
            this.maBUTKierunekWPrawo.Click += new System.EventHandler(this.maBUTKierunekWPrawo_Click);
            // 
            // maBUTNowaBryła
            // 
            this.maBUTNowaBryła.Location = new System.Drawing.Point(18, 336);
            this.maBUTNowaBryła.Name = "maBUTNowaBryła";
            this.maBUTNowaBryła.Size = new System.Drawing.Size(171, 43);
            this.maBUTNowaBryła.TabIndex = 67;
            this.maBUTNowaBryła.Text = "Dodaj nową figurę";
            this.maBUTNowaBryła.UseVisualStyleBackColor = true;
            this.maBUTNowaBryła.Click += new System.EventHandler(this.maBUTNowaBryła_Click);
            // 
            // maLBLStopieńWielokąta
            // 
            this.maLBLStopieńWielokąta.AutoSize = true;
            this.maLBLStopieńWielokąta.Location = new System.Drawing.Point(16, 192);
            this.maLBLStopieńWielokąta.Name = "maLBLStopieńWielokąta";
            this.maLBLStopieńWielokąta.Size = new System.Drawing.Size(0, 13);
            this.maLBLStopieńWielokąta.TabIndex = 64;
            // 
            // maLBLWysokość
            // 
            this.maLBLWysokość.AutoSize = true;
            this.maLBLWysokość.Location = new System.Drawing.Point(35, 144);
            this.maLBLWysokość.Name = "maLBLWysokość";
            this.maLBLWysokość.Size = new System.Drawing.Size(113, 13);
            this.maLBLWysokość.TabIndex = 62;
            this.maLBLWysokość.Text = "Ustaw wysokość bryły";
            // 
            // maLBLPromień
            // 
            this.maLBLPromień.AutoSize = true;
            this.maLBLPromień.Location = new System.Drawing.Point(35, 80);
            this.maLBLPromień.Name = "maLBLPromień";
            this.maLBLPromień.Size = new System.Drawing.Size(103, 13);
            this.maLBLPromień.TabIndex = 60;
            this.maLBLPromień.Text = "Ustaw promień bryły";
            // 
            // maCMBWybórBryły
            // 
            this.maCMBWybórBryły.FormattingEnabled = true;
            this.maCMBWybórBryły.Items.AddRange(new object[] {
            "Walec",
            "Ostrosłup",
            "Graniastosłup",
            "Kula",
            "Stożek",
            "Ostrosłup pochylony",
            "Graniastosłup pochylony",
            "Stożek pochylony",
            "Sześcian",
            "Diament"});
            this.maCMBWybórBryły.Location = new System.Drawing.Point(15, 40);
            this.maCMBWybórBryły.Name = "maCMBWybórBryły";
            this.maCMBWybórBryły.Size = new System.Drawing.Size(165, 21);
            this.maCMBWybórBryły.TabIndex = 59;
            this.maCMBWybórBryły.Text = "Wybierz bryłę";
            // 
            // maLBLWybórFigury
            // 
            this.maLBLWybórFigury.AutoSize = true;
            this.maLBLWybórFigury.Location = new System.Drawing.Point(11, 11);
            this.maLBLWybórFigury.Name = "maLBLWybórFigury";
            this.maLBLWybórFigury.Size = new System.Drawing.Size(170, 13);
            this.maLBLWybórFigury.TabIndex = 58;
            this.maLBLWybórFigury.Text = "Wybierz nową bryłę geometryczną";
            // 
            // maNUDKątNachylenia
            // 
            this.maNUDKątNachylenia.Location = new System.Drawing.Point(62, 288);
            this.maNUDKątNachylenia.Margin = new System.Windows.Forms.Padding(2);
            this.maNUDKątNachylenia.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.maNUDKątNachylenia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maNUDKątNachylenia.Name = "maNUDKątNachylenia";
            this.maNUDKątNachylenia.Size = new System.Drawing.Size(49, 20);
            this.maNUDKątNachylenia.TabIndex = 86;
            this.maNUDKątNachylenia.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // maNUDStopieńWielokąta
            // 
            this.maNUDStopieńWielokąta.Location = new System.Drawing.Point(62, 243);
            this.maNUDStopieńWielokąta.Margin = new System.Windows.Forms.Padding(2);
            this.maNUDStopieńWielokąta.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.maNUDStopieńWielokąta.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.maNUDStopieńWielokąta.Name = "maNUDStopieńWielokąta";
            this.maNUDStopieńWielokąta.Size = new System.Drawing.Size(51, 20);
            this.maNUDStopieńWielokąta.TabIndex = 85;
            this.maNUDStopieńWielokąta.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // maLBLKątNachylenia
            // 
            this.maLBLKątNachylenia.AutoSize = true;
            this.maLBLKątNachylenia.Location = new System.Drawing.Point(50, 271);
            this.maLBLKątNachylenia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maLBLKątNachylenia.Name = "maLBLKątNachylenia";
            this.maLBLKątNachylenia.Size = new System.Drawing.Size(79, 13);
            this.maLBLKątNachylenia.TabIndex = 84;
            this.maLBLKątNachylenia.Text = "Kąt Nachylenia";
            // 
            // maLStopieńWielokąta
            // 
            this.maLStopieńWielokąta.AutoSize = true;
            this.maLStopieńWielokąta.Location = new System.Drawing.Point(44, 227);
            this.maLStopieńWielokąta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maLStopieńWielokąta.Name = "maLStopieńWielokąta";
            this.maLStopieńWielokąta.Size = new System.Drawing.Size(94, 13);
            this.maLStopieńWielokąta.TabIndex = 83;
            this.maLStopieńWielokąta.Text = "Stopień Wielokąta";
            // 
            // maNUDNumerBryłyDoSkasowania
            // 
            this.maNUDNumerBryłyDoSkasowania.Location = new System.Drawing.Point(490, 15);
            this.maNUDNumerBryłyDoSkasowania.Margin = new System.Windows.Forms.Padding(2);
            this.maNUDNumerBryłyDoSkasowania.Name = "maNUDNumerBryłyDoSkasowania";
            this.maNUDNumerBryłyDoSkasowania.Size = new System.Drawing.Size(49, 20);
            this.maNUDNumerBryłyDoSkasowania.TabIndex = 90;
            // 
            // maBTNUsuńWybranąBryłę
            // 
            this.maBTNUsuńWybranąBryłę.Location = new System.Drawing.Point(354, 11);
            this.maBTNUsuńWybranąBryłę.Margin = new System.Windows.Forms.Padding(2);
            this.maBTNUsuńWybranąBryłę.Name = "maBTNUsuńWybranąBryłę";
            this.maBTNUsuńWybranąBryłę.Size = new System.Drawing.Size(125, 25);
            this.maBTNUsuńWybranąBryłę.TabIndex = 89;
            this.maBTNUsuńWybranąBryłę.Text = "Usuń Wybraną Bryłę :";
            this.maBTNUsuńWybranąBryłę.UseVisualStyleBackColor = true;
            this.maBTNUsuńWybranąBryłę.Click += new System.EventHandler(this.maBTNUsuńWybranąBryłę_Click);
            // 
            // maBTNUsuńOstatniąBryłę
            // 
            this.maBTNUsuńOstatniąBryłę.Location = new System.Drawing.Point(204, 11);
            this.maBTNUsuńOstatniąBryłę.Margin = new System.Windows.Forms.Padding(2);
            this.maBTNUsuńOstatniąBryłę.Name = "maBTNUsuńOstatniąBryłę";
            this.maBTNUsuńOstatniąBryłę.Size = new System.Drawing.Size(125, 25);
            this.maBTNUsuńOstatniąBryłę.TabIndex = 88;
            this.maBTNUsuńOstatniąBryłę.Text = "Usuń Ostatnią Bryłę";
            this.maBTNUsuńOstatniąBryłę.UseVisualStyleBackColor = true;
            this.maBTNUsuńOstatniąBryłę.Click += new System.EventHandler(this.maBTNUsuńOstatniąBryłę_Click);
            // 
            // maBTNUsuńPierwsząBryłę
            // 
            this.maBTNUsuńPierwsząBryłę.Location = new System.Drawing.Point(54, 11);
            this.maBTNUsuńPierwsząBryłę.Margin = new System.Windows.Forms.Padding(2);
            this.maBTNUsuńPierwsząBryłę.Name = "maBTNUsuńPierwsząBryłę";
            this.maBTNUsuńPierwsząBryłę.Size = new System.Drawing.Size(125, 25);
            this.maBTNUsuńPierwsząBryłę.TabIndex = 87;
            this.maBTNUsuńPierwsząBryłę.Text = "Usuń Pierwszą Bryłę";
            this.maBTNUsuńPierwsząBryłę.UseVisualStyleBackColor = true;
            this.maBTNUsuńPierwsząBryłę.Click += new System.EventHandler(this.maBTNUsuńPierwsząBryłę_Click);
            // 
            // maGBoxKryteriaPokazu
            // 
            this.maGBoxKryteriaPokazu.Controls.Add(this.maRBTNPolePowierzchni);
            this.maGBoxKryteriaPokazu.Controls.Add(this.maRBTNObjętośćBryły);
            this.maGBoxKryteriaPokazu.Controls.Add(this.maRBTNPromieńBryły);
            this.maGBoxKryteriaPokazu.Controls.Add(this.maRBTNWysokość);
            this.maGBoxKryteriaPokazu.Location = new System.Drawing.Point(311, 488);
            this.maGBoxKryteriaPokazu.Margin = new System.Windows.Forms.Padding(2);
            this.maGBoxKryteriaPokazu.Name = "maGBoxKryteriaPokazu";
            this.maGBoxKryteriaPokazu.Padding = new System.Windows.Forms.Padding(2);
            this.maGBoxKryteriaPokazu.Size = new System.Drawing.Size(554, 43);
            this.maGBoxKryteriaPokazu.TabIndex = 91;
            this.maGBoxKryteriaPokazu.TabStop = false;
            this.maGBoxKryteriaPokazu.Text = "Kryteria pokazu brył";
            // 
            // maRBTNPolePowierzchni
            // 
            this.maRBTNPolePowierzchni.AutoSize = true;
            this.maRBTNPolePowierzchni.Location = new System.Drawing.Point(426, 18);
            this.maRBTNPolePowierzchni.Margin = new System.Windows.Forms.Padding(2);
            this.maRBTNPolePowierzchni.Name = "maRBTNPolePowierzchni";
            this.maRBTNPolePowierzchni.Size = new System.Drawing.Size(106, 17);
            this.maRBTNPolePowierzchni.TabIndex = 3;
            this.maRBTNPolePowierzchni.TabStop = true;
            this.maRBTNPolePowierzchni.Text = "Pole Powierzchni";
            this.maRBTNPolePowierzchni.UseVisualStyleBackColor = true;
            // 
            // maRBTNObjętośćBryły
            // 
            this.maRBTNObjętośćBryły.AutoSize = true;
            this.maRBTNObjętośćBryły.Location = new System.Drawing.Point(291, 18);
            this.maRBTNObjętośćBryły.Margin = new System.Windows.Forms.Padding(2);
            this.maRBTNObjętośćBryły.Name = "maRBTNObjętośćBryły";
            this.maRBTNObjętośćBryły.Size = new System.Drawing.Size(67, 17);
            this.maRBTNObjętośćBryły.TabIndex = 2;
            this.maRBTNObjętośćBryły.TabStop = true;
            this.maRBTNObjętośćBryły.Text = "Objętość";
            this.maRBTNObjętośćBryły.UseVisualStyleBackColor = true;
            // 
            // maRBTNPromieńBryły
            // 
            this.maRBTNPromieńBryły.AutoSize = true;
            this.maRBTNPromieńBryły.Location = new System.Drawing.Point(149, 18);
            this.maRBTNPromieńBryły.Margin = new System.Windows.Forms.Padding(2);
            this.maRBTNPromieńBryły.Name = "maRBTNPromieńBryły";
            this.maRBTNPromieńBryły.Size = new System.Drawing.Size(63, 17);
            this.maRBTNPromieńBryły.TabIndex = 1;
            this.maRBTNPromieńBryły.TabStop = true;
            this.maRBTNPromieńBryły.Text = "Promień";
            this.maRBTNPromieńBryły.UseVisualStyleBackColor = true;
            // 
            // maRBTNWysokość
            // 
            this.maRBTNWysokość.AutoSize = true;
            this.maRBTNWysokość.Location = new System.Drawing.Point(15, 18);
            this.maRBTNWysokość.Margin = new System.Windows.Forms.Padding(2);
            this.maRBTNWysokość.Name = "maRBTNWysokość";
            this.maRBTNWysokość.Size = new System.Drawing.Size(75, 17);
            this.maRBTNWysokość.TabIndex = 0;
            this.maRBTNWysokość.TabStop = true;
            this.maRBTNWysokość.Text = "Wysokość";
            this.maRBTNWysokość.UseVisualStyleBackColor = true;
            // 
            // maTBPromien
            // 
            this.maTBPromien.Location = new System.Drawing.Point(11, 95);
            this.maTBPromien.Margin = new System.Windows.Forms.Padding(2);
            this.maTBPromien.Maximum = 300;
            this.maTBPromien.Minimum = 20;
            this.maTBPromien.Name = "maTBPromien";
            this.maTBPromien.Size = new System.Drawing.Size(149, 45);
            this.maTBPromien.TabIndex = 92;
            this.maTBPromien.TickFrequency = 15;
            this.maTBPromien.Value = 160;
            // 
            // maTBWysokosc
            // 
            this.maTBWysokosc.Location = new System.Drawing.Point(11, 172);
            this.maTBWysokosc.Margin = new System.Windows.Forms.Padding(2);
            this.maTBWysokosc.Maximum = 300;
            this.maTBWysokosc.Minimum = 20;
            this.maTBWysokosc.Name = "maTBWysokosc";
            this.maTBWysokosc.Size = new System.Drawing.Size(149, 45);
            this.maTBWysokosc.TabIndex = 93;
            this.maTBWysokosc.TickFrequency = 15;
            this.maTBWysokosc.Value = 160;
            // 
            // maTimerDodawanie
            // 
            this.maTimerDodawanie.Tick += new System.EventHandler(this.maTimerDodawanie_Tick);
            // 
            // maTimerPokazSlajdów
            // 
            this.maTimerPokazSlajdów.Tick += new System.EventHandler(this.maTimerPokazSlajdów_Tick);
            // 
            // maPicBoxRysownica
            // 
            this.maPicBoxRysownica.Location = new System.Drawing.Point(196, 5);
            this.maPicBoxRysownica.Name = "maPicBoxRysownica";
            this.maPicBoxRysownica.Size = new System.Drawing.Size(669, 422);
            this.maPicBoxRysownica.TabIndex = 57;
            this.maPicBoxRysownica.TabStop = false;
            this.maPicBoxRysownica.Click += new System.EventHandler(this.maPicBoxRysownica_Click);
            this.maPicBoxRysownica.Paint += new System.Windows.Forms.PaintEventHandler(this.maPicBoxRysownica_Paint);
            this.maPicBoxRysownica.MouseUp += new System.Windows.Forms.MouseEventHandler(this.maPicBoxRysownica_MouseUp);
            // 
            // maGBoxUsuwanieBrył
            // 
            this.maGBoxUsuwanieBrył.Controls.Add(this.maNUDNumerBryłyDoSkasowania);
            this.maGBoxUsuwanieBrył.Controls.Add(this.maBTNUsuńWybranąBryłę);
            this.maGBoxUsuwanieBrył.Controls.Add(this.maBTNUsuńOstatniąBryłę);
            this.maGBoxUsuwanieBrył.Controls.Add(this.maBTNUsuńPierwsząBryłę);
            this.maGBoxUsuwanieBrył.Location = new System.Drawing.Point(311, 435);
            this.maGBoxUsuwanieBrył.Name = "maGBoxUsuwanieBrył";
            this.maGBoxUsuwanieBrył.Size = new System.Drawing.Size(553, 53);
            this.maGBoxUsuwanieBrył.TabIndex = 94;
            this.maGBoxUsuwanieBrył.TabStop = false;
            this.maGBoxUsuwanieBrył.Text = "Usuwanie Brył";
            // 
            // maGBoxSlajder
            // 
            this.maGBoxSlajder.Controls.Add(this.maBUTWyłączSlajder);
            this.maGBoxSlajder.Controls.Add(this.maBUTFiguraNastępna);
            this.maGBoxSlajder.Controls.Add(this.maBUTFiguraPoprzednia);
            this.maGBoxSlajder.Controls.Add(this.maTXTBOXIndexFigury);
            this.maGBoxSlajder.Controls.Add(this.maLBLIndexFigury);
            this.maGBoxSlajder.Controls.Add(this.maBUTWłączenieSlajdera);
            this.maGBoxSlajder.Controls.Add(this.pwRadioButtonRęcznie);
            this.maGBoxSlajder.Controls.Add(this.pwRadioButtonAuto);
            this.maGBoxSlajder.Location = new System.Drawing.Point(871, 7);
            this.maGBoxSlajder.Name = "maGBoxSlajder";
            this.maGBoxSlajder.Size = new System.Drawing.Size(277, 370);
            this.maGBoxSlajder.TabIndex = 95;
            this.maGBoxSlajder.TabStop = false;
            this.maGBoxSlajder.Text = "Slajder";
            // 
            // maBTNLosujPołożenie
            // 
            this.maBTNLosujPołożenie.Location = new System.Drawing.Point(19, 493);
            this.maBTNLosujPołożenie.Margin = new System.Windows.Forms.Padding(2);
            this.maBTNLosujPołożenie.Name = "maBTNLosujPołożenie";
            this.maBTNLosujPołożenie.Size = new System.Drawing.Size(170, 37);
            this.maBTNLosujPołożenie.TabIndex = 97;
            this.maBTNLosujPołożenie.Text = "Losuj Położenie Bryły";
            this.maBTNLosujPołożenie.UseVisualStyleBackColor = true;
            this.maBTNLosujPołożenie.Click += new System.EventHandler(this.maBTNLosujPołożenie_Click);
            // 
            // maBTNLosoweAtrybutyGraficzne
            // 
            this.maBTNLosoweAtrybutyGraficzne.Location = new System.Drawing.Point(19, 451);
            this.maBTNLosoweAtrybutyGraficzne.Margin = new System.Windows.Forms.Padding(2);
            this.maBTNLosoweAtrybutyGraficzne.Name = "maBTNLosoweAtrybutyGraficzne";
            this.maBTNLosoweAtrybutyGraficzne.Size = new System.Drawing.Size(170, 37);
            this.maBTNLosoweAtrybutyGraficzne.TabIndex = 96;
            this.maBTNLosoweAtrybutyGraficzne.Text = "Losuj Atrybuty Graficzne Bryły";
            this.maBTNLosoweAtrybutyGraficzne.UseVisualStyleBackColor = true;
            this.maBTNLosoweAtrybutyGraficzne.Click += new System.EventHandler(this.maBTNLosoweAtrybutyGraficzne_Click);
            // 
            // Andrzejewski
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 706);
            this.Controls.Add(this.maBTNLosujPołożenie);
            this.Controls.Add(this.maBTNLosoweAtrybutyGraficzne);
            this.Controls.Add(this.maGBoxSlajder);
            this.Controls.Add(this.maGBoxUsuwanieBrył);
            this.Controls.Add(this.maTBWysokosc);
            this.Controls.Add(this.maTBPromien);
            this.Controls.Add(this.maGBoxKryteriaPokazu);
            this.Controls.Add(this.maNUDKątNachylenia);
            this.Controls.Add(this.maNUDStopieńWielokąta);
            this.Controls.Add(this.maLBLKątNachylenia);
            this.Controls.Add(this.maLStopieńWielokąta);
            this.Controls.Add(this.maBUTKierunekWLewo);
            this.Controls.Add(this.maBUTKierunekWPrawo);
            this.Controls.Add(this.maBUTNowaBryła);
            this.Controls.Add(this.maLBLStopieńWielokąta);
            this.Controls.Add(this.maLBLWysokość);
            this.Controls.Add(this.maLBLPromień);
            this.Controls.Add(this.maCMBWybórBryły);
            this.Controls.Add(this.maLBLWybórFigury);
            this.Controls.Add(this.maPicBoxRysownica);
            this.Controls.Add(this.maPanelEdycji);
            this.Name = "Andrzejewski";
            this.Text = "Projekt 3, Andrzejewski 48660";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.maNUDKątNachylenia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maNUDStopieńWielokąta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maNUDNumerBryłyDoSkasowania)).EndInit();
            this.maGBoxKryteriaPokazu.ResumeLayout(false);
            this.maGBoxKryteriaPokazu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maTBPromien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maTBWysokosc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maPicBoxRysownica)).EndInit();
            this.maGBoxUsuwanieBrył.ResumeLayout(false);
            this.maGBoxSlajder.ResumeLayout(false);
            this.maGBoxSlajder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel maPanelEdycji;
        private System.Windows.Forms.Button maBUTWyłączSlajder;
        private System.Windows.Forms.Button maBUTFiguraNastępna;
        private System.Windows.Forms.Button maBUTFiguraPoprzednia;
        private System.Windows.Forms.TextBox maTXTBOXIndexFigury;
        private System.Windows.Forms.Label maLBLIndexFigury;
        private System.Windows.Forms.Button maBUTWłączenieSlajdera;
        private System.Windows.Forms.RadioButton pwRadioButtonRęcznie;
        private System.Windows.Forms.RadioButton pwRadioButtonAuto;
        private System.Windows.Forms.Button maBUTKierunekWLewo;
        private System.Windows.Forms.Button maBUTKierunekWPrawo;
        private System.Windows.Forms.Button maBUTNowaBryła;
        private System.Windows.Forms.Label maLBLStopieńWielokąta;
        private System.Windows.Forms.Label maLBLWysokość;
        private System.Windows.Forms.Label maLBLPromień;
        private System.Windows.Forms.ComboBox maCMBWybórBryły;
        private System.Windows.Forms.Label maLBLWybórFigury;
        private System.Windows.Forms.NumericUpDown maNUDKątNachylenia;
        private System.Windows.Forms.NumericUpDown maNUDStopieńWielokąta;
        private System.Windows.Forms.Label maLBLKątNachylenia;
        private System.Windows.Forms.Label maLStopieńWielokąta;
        private System.Windows.Forms.NumericUpDown maNUDNumerBryłyDoSkasowania;
        private System.Windows.Forms.Button maBTNUsuńWybranąBryłę;
        private System.Windows.Forms.Button maBTNUsuńOstatniąBryłę;
        private System.Windows.Forms.Button maBTNUsuńPierwsząBryłę;
        private System.Windows.Forms.GroupBox maGBoxKryteriaPokazu;
        public System.Windows.Forms.RadioButton maRBTNPolePowierzchni;
        public System.Windows.Forms.RadioButton maRBTNObjętośćBryły;
        public System.Windows.Forms.RadioButton maRBTNPromieńBryły;
        public System.Windows.Forms.RadioButton maRBTNWysokość;
        private System.Windows.Forms.TrackBar maTBPromien;
        private System.Windows.Forms.TrackBar maTBWysokosc;
        private System.Windows.Forms.Timer maTimerDodawanie;
        private System.Windows.Forms.Timer maTimerPokazSlajdów;
        private System.Windows.Forms.PictureBox maPicBoxRysownica;
        private System.Windows.Forms.GroupBox maGBoxUsuwanieBrył;
        private System.Windows.Forms.GroupBox maGBoxSlajder;
        private System.Windows.Forms.Button maBTNLosujPołożenie;
        private System.Windows.Forms.Button maBTNLosoweAtrybutyGraficzne;
    }
}

