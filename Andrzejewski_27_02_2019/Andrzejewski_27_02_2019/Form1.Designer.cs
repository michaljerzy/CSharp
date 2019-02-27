namespace Andrzejewski_27_02_2019
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
            this.picBoxRysownica = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblSuwak = new System.Windows.Forms.Label();
            this.trbSuwakPrędkości = new System.Windows.Forms.TrackBar();
            this.btnWycieraczki = new System.Windows.Forms.Button();
            this.btnZatrzymaj = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRysownica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbSuwakPrędkości)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxRysownica
            // 
            this.picBoxRysownica.Location = new System.Drawing.Point(12, 53);
            this.picBoxRysownica.Name = "picBoxRysownica";
            this.picBoxRysownica.Size = new System.Drawing.Size(594, 337);
            this.picBoxRysownica.TabIndex = 0;
            this.picBoxRysownica.TabStop = false;
            this.picBoxRysownica.Paint += new System.Windows.Forms.PaintEventHandler(this.picBoxRysownica_Paint);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(82, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(17, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // lblSuwak
            // 
            this.lblSuwak.AutoSize = true;
            this.lblSuwak.Location = new System.Drawing.Point(612, 53);
            this.lblSuwak.Name = "lblSuwak";
            this.lblSuwak.Size = new System.Drawing.Size(176, 13);
            this.lblSuwak.TabIndex = 2;
            this.lblSuwak.Text = "Ustaw prędkość ruchu wycieraczek";
            // 
            // trbSuwakPrędkości
            // 
            this.trbSuwakPrędkości.Location = new System.Drawing.Point(647, 69);
            this.trbSuwakPrędkości.Maximum = 50;
            this.trbSuwakPrędkości.Minimum = 10;
            this.trbSuwakPrędkości.Name = "trbSuwakPrędkości";
            this.trbSuwakPrędkości.Size = new System.Drawing.Size(104, 45);
            this.trbSuwakPrędkości.TabIndex = 3;
            this.trbSuwakPrędkości.Value = 10;
            // 
            // btnWycieraczki
            // 
            this.btnWycieraczki.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWycieraczki.Location = new System.Drawing.Point(652, 120);
            this.btnWycieraczki.Name = "btnWycieraczki";
            this.btnWycieraczki.Size = new System.Drawing.Size(99, 59);
            this.btnWycieraczki.TabIndex = 4;
            this.btnWycieraczki.Text = "Włącz wycieraczki";
            this.btnWycieraczki.UseVisualStyleBackColor = true;
            this.btnWycieraczki.Click += new System.EventHandler(this.btnWycieraczki_Click);
            // 
            // btnZatrzymaj
            // 
            this.btnZatrzymaj.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZatrzymaj.Location = new System.Drawing.Point(652, 196);
            this.btnZatrzymaj.Name = "btnZatrzymaj";
            this.btnZatrzymaj.Size = new System.Drawing.Size(99, 59);
            this.btnZatrzymaj.TabIndex = 5;
            this.btnZatrzymaj.Text = "Zatrzymaj wycieraczki";
            this.btnZatrzymaj.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(652, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 59);
            this.button1.TabIndex = 6;
            this.button1.Text = "Wyłącz wycieraczki";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Andrzejewski
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnZatrzymaj);
            this.Controls.Add(this.btnWycieraczki);
            this.Controls.Add(this.trbSuwakPrędkości);
            this.Controls.Add(this.lblSuwak);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.picBoxRysownica);
            this.Name = "Andrzejewski";
            this.Text = "Wycieraczki samochodowe";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRysownica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbSuwakPrędkości)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxRysownica;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblSuwak;
        private System.Windows.Forms.TrackBar trbSuwakPrędkości;
        private System.Windows.Forms.Button btnWycieraczki;
        private System.Windows.Forms.Button btnZatrzymaj;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}

