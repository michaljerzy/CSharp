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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Andrzejewski));
            this.maPicBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.maRysujBut = new System.Windows.Forms.Button();
            this.matbSzybkoscKulki = new System.Windows.Forms.TrackBar();
            this.malblPredkosc = new System.Windows.Forms.Label();
            this.mabutStop = new System.Windows.Forms.Button();
            this.maTBPredkosc = new System.Windows.Forms.TextBox();
            this.macolorDialog1 = new System.Windows.Forms.ColorDialog();
            this.mabutKolorLinii = new System.Windows.Forms.Button();
            this.butkolory = new System.Windows.Forms.Button();
            this.matbZaciemnienie = new System.Windows.Forms.TrackBar();
            this.malblJasnosc = new System.Windows.Forms.Label();
            this.mapictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblGruboscKulki = new System.Windows.Forms.Label();
            this.maTBWielkoscKulki = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.maPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matbSzybkoscKulki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matbZaciemnienie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maTBWielkoscKulki)).BeginInit();
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
            this.maRysujBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
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
            this.matbSzybkoscKulki.Minimum = 1;
            this.matbSzybkoscKulki.Name = "matbSzybkoscKulki";
            this.matbSzybkoscKulki.Size = new System.Drawing.Size(143, 45);
            this.matbSzybkoscKulki.TabIndex = 2;
            this.matbSzybkoscKulki.Value = 1;
            this.matbSzybkoscKulki.Scroll += new System.EventHandler(this.matbSzybkoscKulki_Scroll);
            // 
            // malblPredkosc
            // 
            this.malblPredkosc.AutoSize = true;
            this.malblPredkosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.malblPredkosc.Location = new System.Drawing.Point(711, 125);
            this.malblPredkosc.Name = "malblPredkosc";
            this.malblPredkosc.Size = new System.Drawing.Size(120, 18);
            this.malblPredkosc.TabIndex = 3;
            this.malblPredkosc.Text = "Prędkość kulki";
            // 
            // mabutStop
            // 
            this.mabutStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
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
            // mabutKolorLinii
            // 
            this.mabutKolorLinii.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mabutKolorLinii.Location = new System.Drawing.Point(645, 386);
            this.mabutKolorLinii.Name = "mabutKolorLinii";
            this.mabutKolorLinii.Size = new System.Drawing.Size(143, 66);
            this.mabutKolorLinii.TabIndex = 9;
            this.mabutKolorLinii.Text = "Kolor wykresu";
            this.mabutKolorLinii.UseVisualStyleBackColor = true;
            this.mabutKolorLinii.Click += new System.EventHandler(this.mabutKolorLinii_Click);
            // 
            // butkolory
            // 
            this.butkolory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.butkolory.Location = new System.Drawing.Point(794, 37);
            this.butkolory.Name = "butkolory";
            this.butkolory.Size = new System.Drawing.Size(143, 67);
            this.butkolory.TabIndex = 10;
            this.butkolory.Text = "Kolory kulki";
            this.butkolory.UseVisualStyleBackColor = true;
            this.butkolory.Click += new System.EventHandler(this.butkolory_Click);
            // 
            // matbZaciemnienie
            // 
            this.matbZaciemnienie.Location = new System.Drawing.Point(12, 59);
            this.matbZaciemnienie.Maximum = 8;
            this.matbZaciemnienie.Name = "matbZaciemnienie";
            this.matbZaciemnienie.Size = new System.Drawing.Size(392, 45);
            this.matbZaciemnienie.TabIndex = 11;
            this.matbZaciemnienie.Scroll += new System.EventHandler(this.matbZaciemnienie_Scroll);
            // 
            // malblJasnosc
            // 
            this.malblJasnosc.AutoSize = true;
            this.malblJasnosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.malblJasnosc.Location = new System.Drawing.Point(30, 12);
            this.malblJasnosc.Name = "malblJasnosc";
            this.malblJasnosc.Size = new System.Drawing.Size(278, 24);
            this.malblJasnosc.TabIndex = 12;
            this.malblJasnosc.Text = "Poziom zaciemnienia ekranu";
            // 
            // mapictureBox1
            // 
            this.mapictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("mapictureBox1.Image")));
            this.mapictureBox1.Location = new System.Drawing.Point(100, 200);
            this.mapictureBox1.Name = "mapictureBox1";
            this.mapictureBox1.Size = new System.Drawing.Size(296, 111);
            this.mapictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.mapictureBox1.TabIndex = 45;
            this.mapictureBox1.TabStop = false;
            // 
            // lblGruboscKulki
            // 
            this.lblGruboscKulki.AutoSize = true;
            this.lblGruboscKulki.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGruboscKulki.Location = new System.Drawing.Point(847, 125);
            this.lblGruboscKulki.Name = "lblGruboscKulki";
            this.lblGruboscKulki.Size = new System.Drawing.Size(113, 18);
            this.lblGruboscKulki.TabIndex = 47;
            this.lblGruboscKulki.Text = "Grubość kulki";
            // 
            // maTBWielkoscKulki
            // 
            this.maTBWielkoscKulki.Location = new System.Drawing.Point(928, 514);
            this.maTBWielkoscKulki.Maximum = 15;
            this.maTBWielkoscKulki.Minimum = 5;
            this.maTBWielkoscKulki.Name = "maTBWielkoscKulki";
            this.maTBWielkoscKulki.Size = new System.Drawing.Size(104, 45);
            this.maTBWielkoscKulki.TabIndex = 48;
            this.maTBWielkoscKulki.Value = 5;
            this.maTBWielkoscKulki.Scroll += new System.EventHandler(this.maTBWielkoscKulki_Scroll);
            // 
            // Andrzejewski
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 561);
            this.Controls.Add(this.maTBWielkoscKulki);
            this.Controls.Add(this.lblGruboscKulki);
            this.Controls.Add(this.mapictureBox1);
            this.Controls.Add(this.malblJasnosc);
            this.Controls.Add(this.matbZaciemnienie);
            this.Controls.Add(this.butkolory);
            this.Controls.Add(this.mabutKolorLinii);
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
            ((System.ComponentModel.ISupportInitialize)(this.matbZaciemnienie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maTBWielkoscKulki)).EndInit();
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
        private System.Windows.Forms.ColorDialog macolorDialog1;
        private System.Windows.Forms.Button mabutKolorLinii;
        private System.Windows.Forms.Button butkolory;
        private System.Windows.Forms.TrackBar matbZaciemnienie;
        private System.Windows.Forms.Label malblJasnosc;
        private System.Windows.Forms.PictureBox mapictureBox1;
        private System.Windows.Forms.Label lblGruboscKulki;
        private System.Windows.Forms.TrackBar maTBWielkoscKulki;
    }
}

