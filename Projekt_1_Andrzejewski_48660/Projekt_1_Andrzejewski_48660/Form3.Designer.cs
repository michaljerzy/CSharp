namespace Projekt_1_Andrzejewski_48660
{
    partial class maMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(maMenuForm));
            this.mapictureBox1 = new System.Windows.Forms.PictureBox();
            this.butmenu = new System.Windows.Forms.Button();
            this.butwyjscie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mapictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mapictureBox1
            // 
            this.mapictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("mapictureBox1.Image")));
            this.mapictureBox1.Location = new System.Drawing.Point(250, 12);
            this.mapictureBox1.Name = "mapictureBox1";
            this.mapictureBox1.Size = new System.Drawing.Size(296, 111);
            this.mapictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.mapictureBox1.TabIndex = 45;
            this.mapictureBox1.TabStop = false;
            // 
            // butmenu
            // 
            this.butmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.butmenu.Location = new System.Drawing.Point(147, 183);
            this.butmenu.Name = "butmenu";
            this.butmenu.Size = new System.Drawing.Size(160, 83);
            this.butmenu.TabIndex = 46;
            this.butmenu.Text = "Otwórz program";
            this.butmenu.UseVisualStyleBackColor = true;
            this.butmenu.Click += new System.EventHandler(this.butmenu_Click);
            // 
            // butwyjscie
            // 
            this.butwyjscie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.butwyjscie.Location = new System.Drawing.Point(472, 183);
            this.butwyjscie.Name = "butwyjscie";
            this.butwyjscie.Size = new System.Drawing.Size(160, 83);
            this.butwyjscie.TabIndex = 47;
            this.butwyjscie.Text = "Wyjście ";
            this.butwyjscie.UseVisualStyleBackColor = true;
            // 
            // maMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butwyjscie);
            this.Controls.Add(this.butmenu);
            this.Controls.Add(this.mapictureBox1);
            this.Name = "maMenuForm";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.mapictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mapictureBox1;
        private System.Windows.Forms.Button butmenu;
        private System.Windows.Forms.Button butwyjscie;
    }
}