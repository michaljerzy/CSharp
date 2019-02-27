namespace SinusCosinusy
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
            this.tbGrubość_Scroll = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.tbGrubość_Scroll)).BeginInit();
            this.SuspendLayout();
            // 
            // tbGrubość_Scroll
            // 
            this.tbGrubość_Scroll.Location = new System.Drawing.Point(12, 53);
            this.tbGrubość_Scroll.Minimum = 1;
            this.tbGrubość_Scroll.Name = "tbGrubość_Scroll";
            this.tbGrubość_Scroll.Size = new System.Drawing.Size(158, 45);
            this.tbGrubość_Scroll.TabIndex = 0;
            this.tbGrubość_Scroll.Value = 1;
            this.tbGrubość_Scroll.Scroll += new System.EventHandler(this.tbGrubość_Scroll_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbGrubość_Scroll);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.tbGrubość_Scroll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tbGrubość_Scroll;
    }
}

