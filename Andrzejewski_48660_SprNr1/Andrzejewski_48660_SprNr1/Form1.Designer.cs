namespace Andrzejewski_48660_SprNr1
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
            this.maRysownica = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mabutStart = new System.Windows.Forms.Button();
            this.maTBXd = new System.Windows.Forms.TextBox();
            this.maTBXg = new System.Windows.Forms.TextBox();
            this.maTBH = new System.Windows.Forms.TextBox();
            this.malblXd = new System.Windows.Forms.Label();
            this.malblXg = new System.Windows.Forms.Label();
            this.malblH = new System.Windows.Forms.Label();
            this.maerrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.maRysownica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maerrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // maRysownica
            // 
            this.maRysownica.Location = new System.Drawing.Point(12, 12);
            this.maRysownica.Name = "maRysownica";
            this.maRysownica.Size = new System.Drawing.Size(100, 50);
            this.maRysownica.TabIndex = 0;
            this.maRysownica.TabStop = false;
            this.maRysownica.Paint += new System.Windows.Forms.PaintEventHandler(this.maRysownica_Paint);
            // 
            // mabutStart
            // 
            this.mabutStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mabutStart.Location = new System.Drawing.Point(692, 12);
            this.mabutStart.Name = "mabutStart";
            this.mabutStart.Size = new System.Drawing.Size(96, 60);
            this.mabutStart.TabIndex = 1;
            this.mabutStart.Text = "Start";
            this.mabutStart.UseVisualStyleBackColor = true;
            this.mabutStart.Click += new System.EventHandler(this.mabutStart_Click);
            // 
            // maTBXd
            // 
            this.maTBXd.Location = new System.Drawing.Point(789, 103);
            this.maTBXd.Name = "maTBXd";
            this.maTBXd.Size = new System.Drawing.Size(100, 20);
            this.maTBXd.TabIndex = 2;
            // 
            // maTBXg
            // 
            this.maTBXg.Location = new System.Drawing.Point(789, 142);
            this.maTBXg.Name = "maTBXg";
            this.maTBXg.Size = new System.Drawing.Size(100, 20);
            this.maTBXg.TabIndex = 3;
            // 
            // maTBH
            // 
            this.maTBH.Location = new System.Drawing.Point(789, 181);
            this.maTBH.Name = "maTBH";
            this.maTBH.Size = new System.Drawing.Size(100, 20);
            this.maTBH.TabIndex = 4;
            // 
            // malblXd
            // 
            this.malblXd.AutoSize = true;
            this.malblXd.Location = new System.Drawing.Point(756, 87);
            this.malblXd.Name = "malblXd";
            this.malblXd.Size = new System.Drawing.Size(159, 13);
            this.malblXd.TabIndex = 5;
            this.malblXd.Text = "Dolna granica przedziału funkcji";
            // 
            // malblXg
            // 
            this.malblXg.AutoSize = true;
            this.malblXg.Location = new System.Drawing.Point(756, 126);
            this.malblXg.Name = "malblXg";
            this.malblXg.Size = new System.Drawing.Size(160, 13);
            this.malblXg.TabIndex = 6;
            this.malblXg.Text = "Górna granica przedziału funkcji";
            // 
            // malblH
            // 
            this.malblH.AutoSize = true;
            this.malblH.Location = new System.Drawing.Point(821, 165);
            this.malblH.Name = "malblH";
            this.malblH.Size = new System.Drawing.Size(40, 13);
            this.malblH.TabIndex = 7;
            this.malblH.Text = "Krok H";
            // 
            // maerrorProvider1
            // 
            this.maerrorProvider1.ContainerControl = this;
            // 
            // Andrzejewski
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 450);
            this.Controls.Add(this.malblH);
            this.Controls.Add(this.malblXg);
            this.Controls.Add(this.malblXd);
            this.Controls.Add(this.maTBH);
            this.Controls.Add(this.maTBXg);
            this.Controls.Add(this.maTBXd);
            this.Controls.Add(this.mabutStart);
            this.Controls.Add(this.maRysownica);
            this.Name = "Andrzejewski";
            this.Text = "Sprawdzian1";
            this.Load += new System.EventHandler(this.Andrzejewski_Load);
            ((System.ComponentModel.ISupportInitialize)(this.maRysownica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maerrorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox maRysownica;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button mabutStart;
        private System.Windows.Forms.TextBox maTBXd;
        private System.Windows.Forms.TextBox maTBXg;
        private System.Windows.Forms.TextBox maTBH;
        private System.Windows.Forms.Label malblXd;
        private System.Windows.Forms.Label malblXg;
        private System.Windows.Forms.Label malblH;
        private System.Windows.Forms.ErrorProvider maerrorProvider1;
    }
}

