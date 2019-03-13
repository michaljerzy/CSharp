namespace _13._03._2019_Andrzejewski
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
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblx = new System.Windows.Forms.Label();
            this.lblxp = new System.Windows.Forms.Label();
            this.tbxl = new System.Windows.Forms.TextBox();
            this.tbxp = new System.Windows.Forms.TextBox();
            this.btnWykreślenieWykresu = new System.Windows.Forms.Button();
            this.pbRysownica = new System.Windows.Forms.PictureBox();
            this.txtH = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbRysownica)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(64, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Przedział wartości zmian zmiennej niezależnej";
            // 
            // lblx
            // 
            this.lblx.AutoSize = true;
            this.lblx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblx.Location = new System.Drawing.Point(447, 45);
            this.lblx.Name = "lblx";
            this.lblx.Size = new System.Drawing.Size(18, 18);
            this.lblx.TabIndex = 1;
            this.lblx.Text = "xl";
            // 
            // lblxp
            // 
            this.lblxp.AutoSize = true;
            this.lblxp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblxp.Location = new System.Drawing.Point(563, 44);
            this.lblxp.Name = "lblxp";
            this.lblxp.Size = new System.Drawing.Size(23, 18);
            this.lblxp.TabIndex = 2;
            this.lblxp.Text = "xp";
            // 
            // tbxl
            // 
            this.tbxl.Location = new System.Drawing.Point(473, 44);
            this.tbxl.Name = "tbxl";
            this.tbxl.Size = new System.Drawing.Size(84, 20);
            this.tbxl.TabIndex = 3;
            // 
            // tbxp
            // 
            this.tbxp.Location = new System.Drawing.Point(592, 44);
            this.tbxp.Name = "tbxp";
            this.tbxp.Size = new System.Drawing.Size(95, 20);
            this.tbxp.TabIndex = 4;
            // 
            // btnWykreślenieWykresu
            // 
            this.btnWykreślenieWykresu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWykreślenieWykresu.Location = new System.Drawing.Point(693, 22);
            this.btnWykreślenieWykresu.Name = "btnWykreślenieWykresu";
            this.btnWykreślenieWykresu.Size = new System.Drawing.Size(95, 66);
            this.btnWykreślenieWykresu.TabIndex = 5;
            this.btnWykreślenieWykresu.Text = "Wykreślenie wykresu";
            this.btnWykreślenieWykresu.UseVisualStyleBackColor = true;
            this.btnWykreślenieWykresu.Click += new System.EventHandler(this.btnWykreślenieWykresu_Click);
            // 
            // pbRysownica
            // 
            this.pbRysownica.Location = new System.Drawing.Point(49, 85);
            this.pbRysownica.Name = "pbRysownica";
            this.pbRysownica.Size = new System.Drawing.Size(600, 325);
            this.pbRysownica.TabIndex = 6;
            this.pbRysownica.TabStop = false;
            this.pbRysownica.Paint += new System.Windows.Forms.PaintEventHandler(this.pbRysownica_Paint);
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(697, 150);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(69, 20);
            this.txtH.TabIndex = 7;
            // 
            // Andrzejewski
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.pbRysownica);
            this.Controls.Add(this.btnWykreślenieWykresu);
            this.Controls.Add(this.tbxp);
            this.Controls.Add(this.tbxl);
            this.Controls.Add(this.lblxp);
            this.Controls.Add(this.lblx);
            this.Controls.Add(this.label1);
            this.Name = "Andrzejewski";
            this.Text = "Wykres funkcji zastosowanie klas statycznych.";
            this.Load += new System.EventHandler(this.Andrzejewski_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbRysownica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblx;
        private System.Windows.Forms.Label lblxp;
        private System.Windows.Forms.TextBox tbxl;
        private System.Windows.Forms.TextBox tbxp;
        private System.Windows.Forms.Button btnWykreślenieWykresu;
        private System.Windows.Forms.PictureBox pbRysownica;
        private System.Windows.Forms.TextBox txtH;
    }
}

