namespace Projekt_2_Andrzejewski_48660
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picBoxTrojkat = new System.Windows.Forms.PictureBox();
            this.picBoxOkrag = new System.Windows.Forms.PictureBox();
            this.picBoxKwadrat = new System.Windows.Forms.PictureBox();
            this.picBoxPunkt = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.picBoxWielokat = new System.Windows.Forms.PictureBox();
            this.butClear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTrojkat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxOkrag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxKwadrat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPunkt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxWielokat)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxTrojkat
            // 
            this.picBoxTrojkat.Image = ((System.Drawing.Image)(resources.GetObject("picBoxTrojkat.Image")));
            this.picBoxTrojkat.Location = new System.Drawing.Point(760, 184);
            this.picBoxTrojkat.Name = "picBoxTrojkat";
            this.picBoxTrojkat.Size = new System.Drawing.Size(28, 31);
            this.picBoxTrojkat.TabIndex = 3;
            this.picBoxTrojkat.TabStop = false;
            this.picBoxTrojkat.Click += new System.EventHandler(this.picBoxTrojkat_Click);
            // 
            // picBoxOkrag
            // 
            this.picBoxOkrag.Image = ((System.Drawing.Image)(resources.GetObject("picBoxOkrag.Image")));
            this.picBoxOkrag.Location = new System.Drawing.Point(760, 221);
            this.picBoxOkrag.Name = "picBoxOkrag";
            this.picBoxOkrag.Size = new System.Drawing.Size(28, 31);
            this.picBoxOkrag.TabIndex = 4;
            this.picBoxOkrag.TabStop = false;
            // 
            // picBoxKwadrat
            // 
            this.picBoxKwadrat.Image = ((System.Drawing.Image)(resources.GetObject("picBoxKwadrat.Image")));
            this.picBoxKwadrat.Location = new System.Drawing.Point(760, 258);
            this.picBoxKwadrat.Name = "picBoxKwadrat";
            this.picBoxKwadrat.Size = new System.Drawing.Size(28, 31);
            this.picBoxKwadrat.TabIndex = 5;
            this.picBoxKwadrat.TabStop = false;
            // 
            // picBoxPunkt
            // 
            this.picBoxPunkt.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPunkt.Image")));
            this.picBoxPunkt.Location = new System.Drawing.Point(760, 295);
            this.picBoxPunkt.Name = "picBoxPunkt";
            this.picBoxPunkt.Size = new System.Drawing.Size(28, 32);
            this.picBoxPunkt.TabIndex = 6;
            this.picBoxPunkt.TabStop = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // picBoxWielokat
            // 
            this.picBoxWielokat.Image = ((System.Drawing.Image)(resources.GetObject("picBoxWielokat.Image")));
            this.picBoxWielokat.Location = new System.Drawing.Point(760, 333);
            this.picBoxWielokat.Name = "picBoxWielokat";
            this.picBoxWielokat.Size = new System.Drawing.Size(28, 30);
            this.picBoxWielokat.TabIndex = 7;
            this.picBoxWielokat.TabStop = false;
            // 
            // butClear
            // 
            this.butClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.butClear.Location = new System.Drawing.Point(697, 12);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(91, 48);
            this.butClear.TabIndex = 8;
            this.butClear.Text = "Clear";
            this.butClear.UseVisualStyleBackColor = true;
            this.butClear.Click += new System.EventHandler(this.butClear_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(691, 438);
            this.panel1.TabIndex = 9;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.butClear);
            this.Controls.Add(this.picBoxWielokat);
            this.Controls.Add(this.picBoxPunkt);
            this.Controls.Add(this.picBoxKwadrat);
            this.Controls.Add(this.picBoxOkrag);
            this.Controls.Add(this.picBoxTrojkat);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTrojkat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxOkrag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxKwadrat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPunkt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxWielokat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picBoxTrojkat;
        private System.Windows.Forms.PictureBox picBoxOkrag;
        private System.Windows.Forms.PictureBox picBoxKwadrat;
        private System.Windows.Forms.PictureBox picBoxPunkt;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.PictureBox picBoxWielokat;
        private System.Windows.Forms.Button butClear;
        private System.Windows.Forms.Panel panel1;
    }
}

