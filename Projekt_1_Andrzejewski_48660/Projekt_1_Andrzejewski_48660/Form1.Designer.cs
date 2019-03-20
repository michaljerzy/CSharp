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
            this.lblGruboscKulki = new System.Windows.Forms.Label();
            this.maTBWielkoscKulki = new System.Windows.Forms.TrackBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kolorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolorKulkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolorWykresuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stylLiniiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kropkowaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreskowaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreskowokropkowaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ciagłaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stylLiniiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kropkowaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kreskowaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kropkowokreskowaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ciagłaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.roToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.krójPismaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rozmiarCzcionkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.maPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matbSzybkoscKulki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matbZaciemnienie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maTBWielkoscKulki)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // maPicBox
            // 
            this.maPicBox.Location = new System.Drawing.Point(12, 83);
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
            this.matbSzybkoscKulki.Maximum = 200;
            this.matbSzybkoscKulki.Minimum = 1;
            this.matbSzybkoscKulki.Name = "matbSzybkoscKulki";
            this.matbSzybkoscKulki.Size = new System.Drawing.Size(143, 45);
            this.matbSzybkoscKulki.TabIndex = 2;
            this.matbSzybkoscKulki.Value = 5;
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
            this.matbZaciemnienie.Location = new System.Drawing.Point(4, 113);
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
            this.malblJasnosc.Location = new System.Drawing.Point(28, 65);
            this.malblJasnosc.Name = "malblJasnosc";
            this.malblJasnosc.Size = new System.Drawing.Size(278, 24);
            this.malblJasnosc.TabIndex = 12;
            this.malblJasnosc.Text = "Poziom zaciemnienia ekranu";
            // 
            // lblGruboscKulki
            // 
            this.lblGruboscKulki.AutoSize = true;
            this.lblGruboscKulki.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGruboscKulki.Location = new System.Drawing.Point(847, 125);
            this.lblGruboscKulki.Name = "lblGruboscKulki";
            this.lblGruboscKulki.Size = new System.Drawing.Size(111, 18);
            this.lblGruboscKulki.TabIndex = 47;
            this.lblGruboscKulki.Text = "Promień kulki";
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kolorToolStripMenuItem,
            this.stylLiniiToolStripMenuItem,
            this.stylLiniiToolStripMenuItem1,
            this.roToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1034, 24);
            this.menuStrip1.TabIndex = 49;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kolorToolStripMenuItem
            // 
            this.kolorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kolorKulkiToolStripMenuItem,
            this.kolorWykresuToolStripMenuItem});
            this.kolorToolStripMenuItem.Name = "kolorToolStripMenuItem";
            this.kolorToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.kolorToolStripMenuItem.Text = "Kolor";
            // 
            // kolorKulkiToolStripMenuItem
            // 
            this.kolorKulkiToolStripMenuItem.Name = "kolorKulkiToolStripMenuItem";
            this.kolorKulkiToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.kolorKulkiToolStripMenuItem.Text = "Kolor kulki";
            this.kolorKulkiToolStripMenuItem.Click += new System.EventHandler(this.kolorKulkiToolStripMenuItem_Click);
            // 
            // kolorWykresuToolStripMenuItem
            // 
            this.kolorWykresuToolStripMenuItem.Name = "kolorWykresuToolStripMenuItem";
            this.kolorWykresuToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.kolorWykresuToolStripMenuItem.Text = "Kolor wykresu";
            this.kolorWykresuToolStripMenuItem.Click += new System.EventHandler(this.kolorWykresuToolStripMenuItem_Click);
            // 
            // stylLiniiToolStripMenuItem
            // 
            this.stylLiniiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kropkowaToolStripMenuItem,
            this.kreskowaToolStripMenuItem,
            this.kreskowokropkowaToolStripMenuItem,
            this.ciagłaToolStripMenuItem});
            this.stylLiniiToolStripMenuItem.Name = "stylLiniiToolStripMenuItem";
            this.stylLiniiToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.stylLiniiToolStripMenuItem.Text = "Styl linii osi";
            // 
            // kropkowaToolStripMenuItem
            // 
            this.kropkowaToolStripMenuItem.Name = "kropkowaToolStripMenuItem";
            this.kropkowaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.kropkowaToolStripMenuItem.Text = "Kropkowa";
            this.kropkowaToolStripMenuItem.Click += new System.EventHandler(this.kropkowaToolStripMenuItem_Click);
            // 
            // kreskowaToolStripMenuItem
            // 
            this.kreskowaToolStripMenuItem.Name = "kreskowaToolStripMenuItem";
            this.kreskowaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.kreskowaToolStripMenuItem.Text = "Kreskowa";
            this.kreskowaToolStripMenuItem.Click += new System.EventHandler(this.kreskowaToolStripMenuItem_Click);
            // 
            // kreskowokropkowaToolStripMenuItem
            // 
            this.kreskowokropkowaToolStripMenuItem.Name = "kreskowokropkowaToolStripMenuItem";
            this.kreskowokropkowaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.kreskowokropkowaToolStripMenuItem.Text = "Kreskowo-kropkowa";
            this.kreskowokropkowaToolStripMenuItem.Click += new System.EventHandler(this.kreskowokropkowaToolStripMenuItem_Click);
            // 
            // ciagłaToolStripMenuItem
            // 
            this.ciagłaToolStripMenuItem.Name = "ciagłaToolStripMenuItem";
            this.ciagłaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.ciagłaToolStripMenuItem.Text = "Ciagła";
            this.ciagłaToolStripMenuItem.Click += new System.EventHandler(this.ciagłaToolStripMenuItem_Click);
            // 
            // stylLiniiToolStripMenuItem1
            // 
            this.stylLiniiToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kropkowaToolStripMenuItem1,
            this.kreskowaToolStripMenuItem1,
            this.kropkowokreskowaToolStripMenuItem,
            this.ciagłaToolStripMenuItem1});
            this.stylLiniiToolStripMenuItem1.Name = "stylLiniiToolStripMenuItem1";
            this.stylLiniiToolStripMenuItem1.Size = new System.Drawing.Size(106, 20);
            this.stylLiniiToolStripMenuItem1.Text = "Styl linii wykresu";
            // 
            // kropkowaToolStripMenuItem1
            // 
            this.kropkowaToolStripMenuItem1.Name = "kropkowaToolStripMenuItem1";
            this.kropkowaToolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
            this.kropkowaToolStripMenuItem1.Text = "Kropkowa";
            this.kropkowaToolStripMenuItem1.Click += new System.EventHandler(this.kropkowaToolStripMenuItem1_Click);
            // 
            // kreskowaToolStripMenuItem1
            // 
            this.kreskowaToolStripMenuItem1.Name = "kreskowaToolStripMenuItem1";
            this.kreskowaToolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
            this.kreskowaToolStripMenuItem1.Text = "Kreskowa";
            this.kreskowaToolStripMenuItem1.Click += new System.EventHandler(this.kreskowaToolStripMenuItem1_Click);
            // 
            // kropkowokreskowaToolStripMenuItem
            // 
            this.kropkowokreskowaToolStripMenuItem.Name = "kropkowokreskowaToolStripMenuItem";
            this.kropkowokreskowaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.kropkowokreskowaToolStripMenuItem.Text = "Kropkowo-kreskowa";
            this.kropkowokreskowaToolStripMenuItem.Click += new System.EventHandler(this.kropkowokreskowaToolStripMenuItem_Click);
            // 
            // ciagłaToolStripMenuItem1
            // 
            this.ciagłaToolStripMenuItem1.Name = "ciagłaToolStripMenuItem1";
            this.ciagłaToolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
            this.ciagłaToolStripMenuItem1.Text = "Ciagła";
            this.ciagłaToolStripMenuItem1.Click += new System.EventHandler(this.ciagłaToolStripMenuItem1_Click);
            // 
            // roToolStripMenuItem
            // 
            this.roToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.krójPismaToolStripMenuItem,
            this.rozmiarCzcionkiToolStripMenuItem});
            this.roToolStripMenuItem.Name = "roToolStripMenuItem";
            this.roToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.roToolStripMenuItem.Text = "Czcionka X i Y";
            this.roToolStripMenuItem.Click += new System.EventHandler(this.roToolStripMenuItem_Click);
            // 
            // krójPismaToolStripMenuItem
            // 
            this.krójPismaToolStripMenuItem.Name = "krójPismaToolStripMenuItem";
            this.krójPismaToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.krójPismaToolStripMenuItem.Text = "Krój pisma";
            this.krójPismaToolStripMenuItem.Click += new System.EventHandler(this.krójPismaToolStripMenuItem_Click);
            // 
            // rozmiarCzcionkiToolStripMenuItem
            // 
            this.rozmiarCzcionkiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.rozmiarCzcionkiToolStripMenuItem.Name = "rozmiarCzcionkiToolStripMenuItem";
            this.rozmiarCzcionkiToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.rozmiarCzcionkiToolStripMenuItem.Text = "Rozmiar czcionki";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem2.Text = "6";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem3.Text = "7";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem4.Text = "8";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem5.Text = "9";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem6.Text = "10";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(190, 249);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(627, 212);
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            // 
            // Andrzejewski
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 561);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.maTBWielkoscKulki);
            this.Controls.Add(this.lblGruboscKulki);
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
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Andrzejewski";
            this.Text = "Wykres szeregu";
            this.Load += new System.EventHandler(this.Andrzejewski_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Andrzejewski_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.maPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matbSzybkoscKulki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matbZaciemnienie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maTBWielkoscKulki)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Label lblGruboscKulki;
        private System.Windows.Forms.TrackBar maTBWielkoscKulki;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kolorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kolorKulkiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kolorWykresuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stylLiniiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kropkowaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreskowaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreskowokropkowaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ciagłaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stylLiniiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kropkowaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kreskowaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kropkowokreskowaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ciagłaToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem roToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem krójPismaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rozmiarCzcionkiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
    }
}

