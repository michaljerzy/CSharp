namespace Sprawdzian_Andrzejewski1
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
            this.txtH = new System.Windows.Forms.TextBox();
            this.lblh = new System.Windows.Forms.Label();
            this.pbRysownica = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtXg = new System.Windows.Forms.TextBox();
            this.txtXd = new System.Windows.Forms.TextBox();
            this.lblXg = new System.Windows.Forms.Label();
            this.lblXd = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTytuł = new System.Windows.Forms.Label();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbRysownica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(750, 188);
            this.txtH.Margin = new System.Windows.Forms.Padding(2);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(68, 20);
            this.txtH.TabIndex = 26;
            this.txtH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblh
            // 
            this.lblh.AutoSize = true;
            this.lblh.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblh.Location = new System.Drawing.Point(705, 183);
            this.lblh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblh.Name = "lblh";
            this.lblh.Size = new System.Drawing.Size(27, 22);
            this.lblh.TabIndex = 25;
            this.lblh.Text = "h:";
            // 
            // pbRysownica
            // 
            this.pbRysownica.Location = new System.Drawing.Point(-17, 88);
            this.pbRysownica.Margin = new System.Windows.Forms.Padding(2);
            this.pbRysownica.Name = "pbRysownica";
            this.pbRysownica.Size = new System.Drawing.Size(695, 319);
            this.pbRysownica.TabIndex = 24;
            this.pbRysownica.TabStop = false;
            this.pbRysownica.Paint += new System.Windows.Forms.PaintEventHandler(this.pbRysownica_Paint);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStart.ForeColor = System.Drawing.Color.Navy;
            this.btnStart.Location = new System.Drawing.Point(696, 235);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(121, 52);
            this.btnStart.TabIndex = 23;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtXg
            // 
            this.txtXg.Location = new System.Drawing.Point(750, 135);
            this.txtXg.Margin = new System.Windows.Forms.Padding(2);
            this.txtXg.Name = "txtXg";
            this.txtXg.Size = new System.Drawing.Size(68, 20);
            this.txtXg.TabIndex = 22;
            this.txtXg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtXd
            // 
            this.txtXd.Location = new System.Drawing.Point(750, 88);
            this.txtXd.Margin = new System.Windows.Forms.Padding(2);
            this.txtXd.Name = "txtXd";
            this.txtXd.Size = new System.Drawing.Size(68, 20);
            this.txtXd.TabIndex = 21;
            this.txtXd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblXg
            // 
            this.lblXg.AutoSize = true;
            this.lblXg.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblXg.Location = new System.Drawing.Point(692, 130);
            this.lblXg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblXg.Name = "lblXg";
            this.lblXg.Size = new System.Drawing.Size(40, 22);
            this.lblXg.TabIndex = 20;
            this.lblXg.Text = "Xg:";
            // 
            // lblXd
            // 
            this.lblXd.AutoSize = true;
            this.lblXd.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblXd.Location = new System.Drawing.Point(692, 84);
            this.lblXd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblXd.Name = "lblXd";
            this.lblXd.Size = new System.Drawing.Size(40, 22);
            this.lblXd.TabIndex = 19;
            this.lblXd.Text = "Xd:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(767, 144);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(68, 20);
            this.textBox1.TabIndex = 35;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(722, 139);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 22);
            this.label1.TabIndex = 34;
            this.label1.Text = "h:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 44);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(695, 319);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.Teal;
            this.button1.Location = new System.Drawing.Point(713, 191);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 52);
            this.button1.TabIndex = 32;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(767, 91);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(68, 20);
            this.textBox2.TabIndex = 31;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(767, 44);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(68, 20);
            this.textBox3.TabIndex = 30;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(709, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 22);
            this.label2.TabIndex = 29;
            this.label2.Text = "Xg:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(709, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 22);
            this.label3.TabIndex = 28;
            this.label3.Text = "Xd:";
            // 
            // lblTytuł
            // 
            this.lblTytuł.AutoSize = true;
            this.lblTytuł.Font = new System.Drawing.Font("Century Gothic", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTytuł.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTytuł.Location = new System.Drawing.Point(30, 0);
            this.lblTytuł.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTytuł.Name = "lblTytuł";
            this.lblTytuł.Size = new System.Drawing.Size(654, 23);
            this.lblTytuł.TabIndex = 27;
            this.lblTytuł.Text = "Wykreślenie wykresu podanej funkcji w przedziale [Xd,Xg] z krokiem h";
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Andrzejewski
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTytuł);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.lblh);
            this.Controls.Add(this.pbRysownica);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtXg);
            this.Controls.Add(this.txtXd);
            this.Controls.Add(this.lblXg);
            this.Controls.Add(this.lblXd);
            this.Name = "Andrzejewski";
            this.Text = "Andrzejewski";
            ((System.ComponentModel.ISupportInitialize)(this.pbRysownica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.Label lblh;
        private System.Windows.Forms.PictureBox pbRysownica;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtXg;
        private System.Windows.Forms.TextBox txtXd;
        private System.Windows.Forms.Label lblXg;
        private System.Windows.Forms.Label lblXd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTytuł;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}

