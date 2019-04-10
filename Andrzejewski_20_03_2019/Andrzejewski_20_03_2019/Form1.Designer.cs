namespace Andrzejewski_20_03_2019
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
            this.lblTxtn = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.lblwybierzfigurę = new System.Windows.Forms.Label();
            this.panelRysownica = new System.Windows.Forms.Panel();
            this.butStart = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnWlaczenieSlaidera = new System.Windows.Forms.Button();
            this.btnNastepny = new System.Windows.Forms.Button();
            this.btnPoprzedni = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbNrFigury = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWyłącz = new System.Windows.Forms.Button();
            this.rdButAutomatyczny = new System.Windows.Forms.RadioButton();
            this.rdButPrzyciskowy = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTxtn
            // 
            this.lblTxtn.AutoSize = true;
            this.lblTxtn.Location = new System.Drawing.Point(0, 0);
            this.lblTxtn.Name = "lblTxtn";
            this.lblTxtn.Size = new System.Drawing.Size(167, 13);
            this.lblTxtn.TabIndex = 0;
            this.lblTxtn.Text = "Podaj liczbę figur geometrycznych";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(30, 16);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 20);
            this.txtN.TabIndex = 2;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Punkt",
            "Linia",
            "Elipsa",
            "Okrąg",
            "Prostokąt",
            "Kwadrat",
            "Wielokąt foremny",
            "Koło"});
            this.checkedListBox1.Location = new System.Drawing.Point(655, 62);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 124);
            this.checkedListBox1.TabIndex = 3;
            // 
            // lblwybierzfigurę
            // 
            this.lblwybierzfigurę.AutoSize = true;
            this.lblwybierzfigurę.Location = new System.Drawing.Point(645, 37);
            this.lblwybierzfigurę.Name = "lblwybierzfigurę";
            this.lblwybierzfigurę.Size = new System.Drawing.Size(143, 13);
            this.lblwybierzfigurę.TabIndex = 5;
            this.lblwybierzfigurę.Text = "Wybierz figurę do prezentacji";
            // 
            // panelRysownica
            // 
            this.panelRysownica.Location = new System.Drawing.Point(97, 69);
            this.panelRysownica.Name = "panelRysownica";
            this.panelRysownica.Size = new System.Drawing.Size(487, 283);
            this.panelRysownica.TabIndex = 6;
            // 
            // butStart
            // 
            this.butStart.Location = new System.Drawing.Point(655, 192);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(120, 51);
            this.butStart.TabIndex = 7;
            this.butStart.Text = "START";
            this.butStart.UseVisualStyleBackColor = true;
            this.butStart.Click += new System.EventHandler(this.butStart_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnWlaczenieSlaidera
            // 
            this.btnWlaczenieSlaidera.Location = new System.Drawing.Point(12, 229);
            this.btnWlaczenieSlaidera.Name = "btnWlaczenieSlaidera";
            this.btnWlaczenieSlaidera.Size = new System.Drawing.Size(75, 58);
            this.btnWlaczenieSlaidera.TabIndex = 8;
            this.btnWlaczenieSlaidera.Text = "Włączenie slajdera figur geometrycznych";
            this.btnWlaczenieSlaidera.UseVisualStyleBackColor = true;
            this.btnWlaczenieSlaidera.Click += new System.EventHandler(this.btnWlaczenieSlaidera_Click);
            // 
            // btnNastepny
            // 
            this.btnNastepny.Location = new System.Drawing.Point(275, 397);
            this.btnNastepny.Name = "btnNastepny";
            this.btnNastepny.Size = new System.Drawing.Size(75, 23);
            this.btnNastepny.TabIndex = 9;
            this.btnNastepny.Text = "Nastepny";
            this.btnNastepny.UseVisualStyleBackColor = true;
            this.btnNastepny.Click += new System.EventHandler(this.btnNastepny_Click);
            // 
            // btnPoprzedni
            // 
            this.btnPoprzedni.Location = new System.Drawing.Point(572, 406);
            this.btnPoprzedni.Name = "btnPoprzedni";
            this.btnPoprzedni.Size = new System.Drawing.Size(75, 23);
            this.btnPoprzedni.TabIndex = 10;
            this.btnPoprzedni.Text = "Poprzedni";
            this.btnPoprzedni.UseVisualStyleBackColor = true;
            this.btnPoprzedni.Click += new System.EventHandler(this.btnPoprzedni_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdButPrzyciskowy);
            this.panel1.Controls.Add(this.rdButAutomatyczny);
            this.panel1.Location = new System.Drawing.Point(12, 364);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 74);
            this.panel1.TabIndex = 11;
            // 
            // txbNrFigury
            // 
            this.txbNrFigury.Location = new System.Drawing.Point(453, 409);
            this.txbNrFigury.Name = "txbNrFigury";
            this.txbNrFigury.Size = new System.Drawing.Size(100, 20);
            this.txbNrFigury.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(450, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nr figury (slajdu)";
            // 
            // btnWyłącz
            // 
            this.btnWyłącz.Location = new System.Drawing.Point(675, 364);
            this.btnWyłącz.Name = "btnWyłącz";
            this.btnWyłącz.Size = new System.Drawing.Size(100, 65);
            this.btnWyłącz.TabIndex = 14;
            this.btnWyłącz.Text = "Wyłącz slajdera figu geometrycznych";
            this.btnWyłącz.UseVisualStyleBackColor = true;
            this.btnWyłącz.Click += new System.EventHandler(this.btnWyłącz_Click);
            // 
            // rdButAutomatyczny
            // 
            this.rdButAutomatyczny.AutoSize = true;
            this.rdButAutomatyczny.Location = new System.Drawing.Point(18, 16);
            this.rdButAutomatyczny.Name = "rdButAutomatyczny";
            this.rdButAutomatyczny.Size = new System.Drawing.Size(91, 17);
            this.rdButAutomatyczny.TabIndex = 0;
            this.rdButAutomatyczny.TabStop = true;
            this.rdButAutomatyczny.Text = "Automatyczny";
            this.rdButAutomatyczny.UseVisualStyleBackColor = true;
            // 
            // rdButPrzyciskowy
            // 
            this.rdButPrzyciskowy.AutoSize = true;
            this.rdButPrzyciskowy.Location = new System.Drawing.Point(18, 39);
            this.rdButPrzyciskowy.Name = "rdButPrzyciskowy";
            this.rdButPrzyciskowy.Size = new System.Drawing.Size(83, 17);
            this.rdButPrzyciskowy.TabIndex = 1;
            this.rdButPrzyciskowy.TabStop = true;
            this.rdButPrzyciskowy.Text = "Przyciskowy";
            this.rdButPrzyciskowy.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Andrzejewski
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnWyłącz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbNrFigury);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPoprzedni);
            this.Controls.Add(this.btnNastepny);
            this.Controls.Add(this.btnWlaczenieSlaidera);
            this.Controls.Add(this.butStart);
            this.Controls.Add(this.panelRysownica);
            this.Controls.Add(this.lblwybierzfigurę);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.lblTxtn);
            this.Name = "Andrzejewski";
            this.Text = "Prezentacja wybranych figur geometrycznych";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTxtn;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label lblwybierzfigurę;
        private System.Windows.Forms.Panel panelRysownica;
        private System.Windows.Forms.Button butStart;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnWyłącz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNrFigury;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdButPrzyciskowy;
        private System.Windows.Forms.RadioButton rdButAutomatyczny;
        private System.Windows.Forms.Button btnPoprzedni;
        private System.Windows.Forms.Button btnNastepny;
        private System.Windows.Forms.Button btnWlaczenieSlaidera;
        private System.Windows.Forms.Timer timer1;
    }
}

