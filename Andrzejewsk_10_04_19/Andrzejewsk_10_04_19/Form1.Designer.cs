namespace Andrzejewsk_10_04_19
{
    partial class Form1
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
            this.trbPromieńBryły = new System.Windows.Forms.TrackBar();
            this.trbWysokośćBryły = new System.Windows.Forms.TrackBar();
            this.cmbListaBrył = new System.Windows.Forms.ComboBox();
            this.nudStopieńWielokąta = new System.Windows.Forms.NumericUpDown();
            this.nudKątNachyleniaBryły = new System.Windows.Forms.NumericUpDown();
            this.btnDodajNoweBryły = new System.Windows.Forms.Button();
            this.pbRysownica = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trbPromieńBryły)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbWysokośćBryły)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStopieńWielokąta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKątNachyleniaBryły)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRysownica)).BeginInit();
            this.SuspendLayout();
            // 
            // trbPromieńBryły
            // 
            this.trbPromieńBryły.Location = new System.Drawing.Point(12, 52);
            this.trbPromieńBryły.Maximum = 200;
            this.trbPromieńBryły.Minimum = 10;
            this.trbPromieńBryły.Name = "trbPromieńBryły";
            this.trbPromieńBryły.Size = new System.Drawing.Size(104, 45);
            this.trbPromieńBryły.TabIndex = 0;
            this.trbPromieńBryły.Value = 10;
            // 
            // trbWysokośćBryły
            // 
            this.trbWysokośćBryły.Location = new System.Drawing.Point(12, 114);
            this.trbWysokośćBryły.Maximum = 200;
            this.trbWysokośćBryły.Minimum = 20;
            this.trbWysokośćBryły.Name = "trbWysokośćBryły";
            this.trbWysokośćBryły.Size = new System.Drawing.Size(104, 45);
            this.trbWysokośćBryły.TabIndex = 1;
            this.trbWysokośćBryły.Value = 20;
            // 
            // cmbListaBrył
            // 
            this.cmbListaBrył.FormattingEnabled = true;
            this.cmbListaBrył.Items.AddRange(new object[] {
            "Walec",
            "Walec(pochylony)",
            "Stożek",
            "Stożek(pochylony)",
            "Ostrosłup",
            "Ostrosłup(pochylony)",
            "Graniastosłup",
            "Graniastosłup(pochylony)"});
            this.cmbListaBrył.Location = new System.Drawing.Point(12, 12);
            this.cmbListaBrył.Name = "cmbListaBrył";
            this.cmbListaBrył.Size = new System.Drawing.Size(121, 21);
            this.cmbListaBrył.TabIndex = 2;
            // 
            // nudStopieńWielokąta
            // 
            this.nudStopieńWielokąta.Location = new System.Drawing.Point(100, 181);
            this.nudStopieńWielokąta.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudStopieńWielokąta.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudStopieńWielokąta.Name = "nudStopieńWielokąta";
            this.nudStopieńWielokąta.Size = new System.Drawing.Size(32, 20);
            this.nudStopieńWielokąta.TabIndex = 3;
            this.nudStopieńWielokąta.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // nudKątNachyleniaBryły
            // 
            this.nudKątNachyleniaBryły.Location = new System.Drawing.Point(100, 232);
            this.nudKątNachyleniaBryły.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.nudKątNachyleniaBryły.Name = "nudKątNachyleniaBryły";
            this.nudKątNachyleniaBryły.Size = new System.Drawing.Size(33, 20);
            this.nudKątNachyleniaBryły.TabIndex = 4;
            // 
            // btnDodajNoweBryły
            // 
            this.btnDodajNoweBryły.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajNoweBryły.Location = new System.Drawing.Point(13, 272);
            this.btnDodajNoweBryły.Name = "btnDodajNoweBryły";
            this.btnDodajNoweBryły.Size = new System.Drawing.Size(119, 44);
            this.btnDodajNoweBryły.TabIndex = 5;
            this.btnDodajNoweBryły.Text = "Dodaj nowe bryły";
            this.btnDodajNoweBryły.UseVisualStyleBackColor = true;
            // 
            // pbRysownica
            // 
            this.pbRysownica.Location = new System.Drawing.Point(198, 12);
            this.pbRysownica.Name = "pbRysownica";
            this.pbRysownica.Size = new System.Drawing.Size(558, 326);
            this.pbRysownica.TabIndex = 6;
            this.pbRysownica.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Stopień wielokąta podstawy bryły";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kąt nachylenia bryły geometrycznej";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 366);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbRysownica);
            this.Controls.Add(this.btnDodajNoweBryły);
            this.Controls.Add(this.nudKątNachyleniaBryły);
            this.Controls.Add(this.nudStopieńWielokąta);
            this.Controls.Add(this.cmbListaBrył);
            this.Controls.Add(this.trbWysokośćBryły);
            this.Controls.Add(this.trbPromieńBryły);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trbPromieńBryły)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbWysokośćBryły)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStopieńWielokąta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKątNachyleniaBryły)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRysownica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trbPromieńBryły;
        private System.Windows.Forms.TrackBar trbWysokośćBryły;
        private System.Windows.Forms.ComboBox cmbListaBrył;
        private System.Windows.Forms.NumericUpDown nudStopieńWielokąta;
        private System.Windows.Forms.NumericUpDown nudKątNachyleniaBryły;
        private System.Windows.Forms.Button btnDodajNoweBryły;
        private System.Windows.Forms.PictureBox pbRysownica;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

