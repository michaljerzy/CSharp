namespace Sprawdzian2_Andrzejewski_48660
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maTBLiczby = new System.Windows.Forms.TextBox();
            this.maTBGórnaGranica = new System.Windows.Forms.TextBox();
            this.maTBDolnaGranica = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.maLBWygenerowaneLiczby = new System.Windows.Forms.ListBox();
            this.maLBPierwsze = new System.Windows.Forms.ListBox();
            this.maLBLiczbyPierwszeMersebbe = new System.Windows.Forms.ListBox();
            this.maLBPozostałe = new System.Windows.Forms.ListBox();
            this.maerrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.maerrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaj ile liczb losowych należy wygenerować";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dolna Granica przedziału liczb losowych";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Górna granica przedziału liczb losowych";
            // 
            // maTBLiczby
            // 
            this.maTBLiczby.Location = new System.Drawing.Point(76, 34);
            this.maTBLiczby.Name = "maTBLiczby";
            this.maTBLiczby.Size = new System.Drawing.Size(82, 20);
            this.maTBLiczby.TabIndex = 3;
            // 
            // maTBGórnaGranica
            // 
            this.maTBGórnaGranica.Location = new System.Drawing.Point(76, 98);
            this.maTBGórnaGranica.Name = "maTBGórnaGranica";
            this.maTBGórnaGranica.Size = new System.Drawing.Size(77, 20);
            this.maTBGórnaGranica.TabIndex = 4;
            // 
            // maTBDolnaGranica
            // 
            this.maTBDolnaGranica.Location = new System.Drawing.Point(71, 163);
            this.maTBDolnaGranica.Name = "maTBDolnaGranica";
            this.maTBDolnaGranica.Size = new System.Drawing.Size(82, 20);
            this.maTBDolnaGranica.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 74);
            this.button1.TabIndex = 6;
            this.button1.Text = "Wygeneruj liczby losowe z podanego przedziału";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // maLBWygenerowaneLiczby
            // 
            this.maLBWygenerowaneLiczby.FormattingEnabled = true;
            this.maLBWygenerowaneLiczby.Location = new System.Drawing.Point(251, 106);
            this.maLBWygenerowaneLiczby.Name = "maLBWygenerowaneLiczby";
            this.maLBWygenerowaneLiczby.Size = new System.Drawing.Size(137, 199);
            this.maLBWygenerowaneLiczby.TabIndex = 7;
            // 
            // maLBPierwsze
            // 
            this.maLBPierwsze.FormattingEnabled = true;
            this.maLBPierwsze.Location = new System.Drawing.Point(394, 106);
            this.maLBPierwsze.Name = "maLBPierwsze";
            this.maLBPierwsze.Size = new System.Drawing.Size(137, 199);
            this.maLBPierwsze.TabIndex = 10;
            // 
            // maLBLiczbyPierwszeMersebbe
            // 
            this.maLBLiczbyPierwszeMersebbe.FormattingEnabled = true;
            this.maLBLiczbyPierwszeMersebbe.Location = new System.Drawing.Point(537, 106);
            this.maLBLiczbyPierwszeMersebbe.Name = "maLBLiczbyPierwszeMersebbe";
            this.maLBLiczbyPierwszeMersebbe.Size = new System.Drawing.Size(137, 199);
            this.maLBLiczbyPierwszeMersebbe.TabIndex = 11;
            // 
            // maLBPozostałe
            // 
            this.maLBPozostałe.FormattingEnabled = true;
            this.maLBPozostałe.Location = new System.Drawing.Point(680, 106);
            this.maLBPozostałe.Name = "maLBPozostałe";
            this.maLBPozostałe.Size = new System.Drawing.Size(137, 199);
            this.maLBPozostałe.TabIndex = 12;
            // 
            // maerrorProvider1
            // 
            this.maerrorProvider1.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Wygenerowane liczby";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(414, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Liczby Pierwsze ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(534, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Liczby Pierwsze Mersenne\'a";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(702, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Pozostale Liczby";
            // 
            // Andrzejewski
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maLBPozostałe);
            this.Controls.Add(this.maLBLiczbyPierwszeMersebbe);
            this.Controls.Add(this.maLBPierwsze);
            this.Controls.Add(this.maLBWygenerowaneLiczby);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maTBDolnaGranica);
            this.Controls.Add(this.maTBGórnaGranica);
            this.Controls.Add(this.maTBLiczby);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Andrzejewski";
            this.Text = "Andrzejewski";
            ((System.ComponentModel.ISupportInitialize)(this.maerrorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox maTBLiczby;
        private System.Windows.Forms.TextBox maTBGórnaGranica;
        private System.Windows.Forms.TextBox maTBDolnaGranica;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox maLBWygenerowaneLiczby;
        private System.Windows.Forms.ListBox maLBPierwsze;
        private System.Windows.Forms.ListBox maLBLiczbyPierwszeMersebbe;
        private System.Windows.Forms.ListBox maLBPozostałe;
        private System.Windows.Forms.ErrorProvider maerrorProvider1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

