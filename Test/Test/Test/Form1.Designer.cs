namespace Test
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ListBoxWykaz = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ListBoxParzyste = new System.Windows.Forms.ListBox();
            this.ListBoxNieparzyste = new System.Windows.Forms.ListBox();
            this.ListBoxPierwsze = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ListBoxNiePierwsze = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Min";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Max";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(25, 156);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListBoxWykaz
            // 
            this.ListBoxWykaz.FormattingEnabled = true;
            this.ListBoxWykaz.ItemHeight = 16;
            this.ListBoxWykaz.Location = new System.Drawing.Point(141, 85);
            this.ListBoxWykaz.Name = "ListBoxWykaz";
            this.ListBoxWykaz.Size = new System.Drawing.Size(169, 212);
            this.ListBoxWykaz.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ile";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(25, 221);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Wykaz Liczb";
            // 
            // ListBoxParzyste
            // 
            this.ListBoxParzyste.FormattingEnabled = true;
            this.ListBoxParzyste.ItemHeight = 16;
            this.ListBoxParzyste.Location = new System.Drawing.Point(383, 271);
            this.ListBoxParzyste.Name = "ListBoxParzyste";
            this.ListBoxParzyste.Size = new System.Drawing.Size(169, 212);
            this.ListBoxParzyste.TabIndex = 9;
            // 
            // ListBoxNieparzyste
            // 
            this.ListBoxNieparzyste.FormattingEnabled = true;
            this.ListBoxNieparzyste.ItemHeight = 16;
            this.ListBoxNieparzyste.Location = new System.Drawing.Point(582, 271);
            this.ListBoxNieparzyste.Name = "ListBoxNieparzyste";
            this.ListBoxNieparzyste.Size = new System.Drawing.Size(169, 212);
            this.ListBoxNieparzyste.TabIndex = 10;
            // 
            // ListBoxPierwsze
            // 
            this.ListBoxPierwsze.FormattingEnabled = true;
            this.ListBoxPierwsze.ItemHeight = 16;
            this.ListBoxPierwsze.Location = new System.Drawing.Point(783, 271);
            this.ListBoxPierwsze.Name = "ListBoxPierwsze";
            this.ListBoxPierwsze.Size = new System.Drawing.Size(169, 212);
            this.ListBoxPierwsze.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(419, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Liczby Parzyste";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(605, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Liczby Nieparzyste";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(819, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Liczby Pierwsze";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1015, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Liczby Nie Pierwsze";
            // 
            // ListBoxNiePierwsze
            // 
            this.ListBoxNiePierwsze.FormattingEnabled = true;
            this.ListBoxNiePierwsze.ItemHeight = 16;
            this.ListBoxNiePierwsze.Location = new System.Drawing.Point(979, 271);
            this.ListBoxNiePierwsze.Name = "ListBoxNiePierwsze";
            this.ListBoxNiePierwsze.Size = new System.Drawing.Size(169, 212);
            this.ListBoxNiePierwsze.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 608);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ListBoxNiePierwsze);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ListBoxPierwsze);
            this.Controls.Add(this.ListBoxNieparzyste);
            this.Controls.Add(this.ListBoxParzyste);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ListBoxWykaz);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox ListBoxWykaz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox ListBoxParzyste;
        private System.Windows.Forms.ListBox ListBoxNieparzyste;
        private System.Windows.Forms.ListBox ListBoxPierwsze;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox ListBoxNiePierwsze;
    }
}

