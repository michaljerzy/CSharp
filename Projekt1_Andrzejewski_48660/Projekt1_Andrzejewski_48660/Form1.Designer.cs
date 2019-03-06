namespace Projekt1_Andrzejewski_48660
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
            this.picBoxRysownica = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRysownica)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxRysownica
            // 
            this.picBoxRysownica.Location = new System.Drawing.Point(30, 33);
            this.picBoxRysownica.Name = "picBoxRysownica";
            this.picBoxRysownica.Size = new System.Drawing.Size(579, 378);
            this.picBoxRysownica.TabIndex = 0;
            this.picBoxRysownica.TabStop = false;
            this.picBoxRysownica.Click += new System.EventHandler(this.picBoxRysownica_Click);
            this.picBoxRysownica.Paint += new System.Windows.Forms.PaintEventHandler(this.picBoxRysownica_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picBoxRysownica);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRysownica)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxRysownica;
    }
}

