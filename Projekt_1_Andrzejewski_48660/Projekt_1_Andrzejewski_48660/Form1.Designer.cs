namespace Projekt_1_Andrzejewski_48660
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
            this.maPicBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.maRysujBut = new System.Windows.Forms.Button();
            this.matbSzybkoscKulki = new System.Windows.Forms.TrackBar();
            this.malblPredkosc = new System.Windows.Forms.Label();
            this.mabutStop = new System.Windows.Forms.Button();
            this.maTBPredkosc = new System.Windows.Forms.TextBox();
            this.maCMBKoloryKulki = new System.Windows.Forms.ComboBox();
            this.mabutKolorTła = new System.Windows.Forms.Button();
            this.macolorDialog1 = new System.Windows.Forms.ColorDialog();
            this.mabutKolorLinii = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.maPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matbSzybkoscKulki)).BeginInit();
            this.SuspendLayout();
            // 
            // maPicBox
            // 
            this.maPicBox.Location = new System.Drawing.Point(12, 12);
            this.maPicBox.Name = "maPicBox";
            this.maPicBox.Size = new System.Drawing.Size(100, 50);
            this.maPicBox.TabIndex = 0;
            this.maPicBox.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // maRysujBut
            // 
            this.maRysujBut.Location = new System.Drawing.Point(645, 37);
            this.maRysujBut.Name = "maRysujBut";
            this.maRysujBut.Size = new System.Drawing.Size(143, 67);
            this.maRysujBut.TabIndex = 1;
            this.maRysujBut.Text = "Rysuj!";
            this.maRysujBut.UseVisualStyleBackColor = true;
            this.maRysujBut.Click += new System.EventHandler(this.maRysujBut_Click);
            // 
            // matbSzybkoscKulki
            // 
            this.matbSzybkoscKulki.Location = new System.Drawing.Point(645, 141);
            this.matbSzybkoscKulki.Name = "matbSzybkoscKulki";
            this.matbSzybkoscKulki.Size = new System.Drawing.Size(143, 45);
            this.matbSzybkoscKulki.TabIndex = 2;
            this.matbSzybkoscKulki.Scroll += new System.EventHandler(this.matbSzybkoscKulki_Scroll);
            // 
            // malblPredkosc
            // 
            this.malblPredkosc.AutoSize = true;
            this.malblPredkosc.Location = new System.Drawing.Point(711, 125);
            this.malblPredkosc.Name = "malblPredkosc";
            this.malblPredkosc.Size = new System.Drawing.Size(77, 13);
            this.malblPredkosc.TabIndex = 3;
            this.malblPredkosc.Text = "Prędkość kulki";
            // 
            // mabutStop
            // 
            this.mabutStop.Location = new System.Drawing.Point(645, 218);
            this.mabutStop.Name = "mabutStop";
            this.mabutStop.Size = new System.Drawing.Size(143, 67);
            this.mabutStop.TabIndex = 5;
            this.mabutStop.Text = "Stop!";
            this.mabutStop.UseVisualStyleBackColor = true;
            this.mabutStop.Click += new System.EventHandler(this.mabutStop_Click);
            // 
            // maTBPredkosc
            // 
            this.maTBPredkosc.Location = new System.Drawing.Point(645, 192);
            this.maTBPredkosc.Name = "maTBPredkosc";
            this.maTBPredkosc.Size = new System.Drawing.Size(143, 20);
            this.maTBPredkosc.TabIndex = 6;
            this.maTBPredkosc.TextChanged += new System.EventHandler(this.maTBPredkosc_TextChanged);
            // 
            // maCMBKoloryKulki
            // 
            this.maCMBKoloryKulki.FormattingEnabled = true;
            this.maCMBKoloryKulki.Items.AddRange(new object[] {
            "Czerwony",
            "Biały",
            "Niebieski",
            "Zielony",
            "Pomarańczowy",
            "Różowy",
            "Fioletowy"});
            this.maCMBKoloryKulki.Location = new System.Drawing.Point(645, 291);
            this.maCMBKoloryKulki.Name = "maCMBKoloryKulki";
            this.maCMBKoloryKulki.Size = new System.Drawing.Size(143, 21);
            this.maCMBKoloryKulki.TabIndex = 7;
            this.maCMBKoloryKulki.Text = "Wybierz kolor kulki";
            // 
            // mabutKolorTła
            // 
            this.mabutKolorTła.Location = new System.Drawing.Point(645, 318);
            this.mabutKolorTła.Name = "mabutKolorTła";
            this.mabutKolorTła.Size = new System.Drawing.Size(143, 62);
            this.mabutKolorTła.TabIndex = 8;
            this.mabutKolorTła.Text = "Kolor Tła";
            this.mabutKolorTła.UseVisualStyleBackColor = true;
            this.mabutKolorTła.Click += new System.EventHandler(this.mabutKolorTła_Click);
            // 
            // mabutKolorLinii
            // 
            this.mabutKolorLinii.Location = new System.Drawing.Point(645, 386);
            this.mabutKolorLinii.Name = "mabutKolorLinii";
            this.mabutKolorLinii.Size = new System.Drawing.Size(143, 66);
            this.mabutKolorLinii.TabIndex = 9;
            this.mabutKolorLinii.Text = "Kolor wykresu";
            this.mabutKolorLinii.UseVisualStyleBackColor = true;
            this.mabutKolorLinii.Click += new System.EventHandler(this.mabutKolorLinii_Click);
            // 
            // Andrzejewski
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mabutKolorLinii);
            this.Controls.Add(this.mabutKolorTła);
            this.Controls.Add(this.maCMBKoloryKulki);
            this.Controls.Add(this.maTBPredkosc);
            this.Controls.Add(this.mabutStop);
            this.Controls.Add(this.malblPredkosc);
            this.Controls.Add(this.matbSzybkoscKulki);
            this.Controls.Add(this.maRysujBut);
            this.Controls.Add(this.maPicBox);
            this.Name = "Andrzejewski";
            this.Text = "Wykres szeregu";
            this.Load += new System.EventHandler(this.Andrzejewski_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Andrzejewski_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.maPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matbSzybkoscKulki)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox maPicBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button maRysujBut;
        private System.Windows.Forms.TrackBar matbSzybkoscKulki;
        private System.Windows.Forms.Label malblPredkosc;
        private System.Windows.Forms.Button mabutStop;
        private System.Windows.Forms.TextBox maTBPredkosc;
        private System.Windows.Forms.ComboBox maCMBKoloryKulki;
        private System.Windows.Forms.Button mabutKolorTła;
        private System.Windows.Forms.ColorDialog macolorDialog1;
        private System.Windows.Forms.Button mabutKolorLinii;
    }
}

