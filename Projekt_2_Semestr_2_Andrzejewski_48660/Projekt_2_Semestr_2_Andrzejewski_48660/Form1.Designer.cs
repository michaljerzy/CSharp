namespace Projekt_2_Semestr_2_Andrzejewski_48660
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
            this.maPBRysownica = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.maPBRysownica)).BeginInit();
            this.SuspendLayout();
            // 
            // maPBRysownica
            // 
            this.maPBRysownica.Location = new System.Drawing.Point(0, 0);
            this.maPBRysownica.Name = "maPBRysownica";
            this.maPBRysownica.Size = new System.Drawing.Size(406, 315);
            this.maPBRysownica.TabIndex = 0;
            this.maPBRysownica.TabStop = false;
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(12, 418);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 20);
            this.txtX.TabIndex = 1;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(151, 418);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 20);
            this.txtY.TabIndex = 2;
            // 
            // Andrzejewski
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.maPBRysownica);
            this.Name = "Andrzejewski";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Andrzejewski_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Andrzejewski_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.maPBRysownica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox maPBRysownica;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
    }
}

