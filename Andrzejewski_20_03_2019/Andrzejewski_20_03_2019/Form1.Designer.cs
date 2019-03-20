namespace Andrzejewski_20_03_2019
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
            this.lblTxtn = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.lblwybierzfigurę = new System.Windows.Forms.Label();
            this.panelRysownica = new System.Windows.Forms.Panel();
            this.butStart = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTxtn
            // 
            this.lblTxtn.AutoSize = true;
            this.lblTxtn.Location = new System.Drawing.Point(0, 0);
            this.lblTxtn.Name = "lblTxtn";
            this.lblTxtn.Size = new System.Drawing.Size(167, 13);
            this.lblTxtn.TabIndex = 0;
            this.lblTxtn.Text = "Podaj liczbę figur geometrycznych";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(30, 16);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 20);
            this.txtN.TabIndex = 2;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Punkt",
            "Linia",
            "Elipsa",
            "Okrąg",
            "Prostokąt",
            "Kwadrat",
            "Wielokąt foremny",
            "Koło"});
            this.checkedListBox1.Location = new System.Drawing.Point(655, 62);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 124);
            this.checkedListBox1.TabIndex = 3;
            // 
            // lblwybierzfigurę
            // 
            this.lblwybierzfigurę.AutoSize = true;
            this.lblwybierzfigurę.Location = new System.Drawing.Point(645, 37);
            this.lblwybierzfigurę.Name = "lblwybierzfigurę";
            this.lblwybierzfigurę.Size = new System.Drawing.Size(143, 13);
            this.lblwybierzfigurę.TabIndex = 5;
            this.lblwybierzfigurę.Text = "Wybierz figurę do prezentacji";
            // 
            // panelRysownica
            // 
            this.panelRysownica.Location = new System.Drawing.Point(97, 69);
            this.panelRysownica.Name = "panelRysownica";
            this.panelRysownica.Size = new System.Drawing.Size(487, 283);
            this.panelRysownica.TabIndex = 6;
            // 
            // butStart
            // 
            this.butStart.Location = new System.Drawing.Point(655, 192);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(120, 51);
            this.butStart.TabIndex = 7;
            this.butStart.Text = "START";
            this.butStart.UseVisualStyleBackColor = true;
            this.butStart.Click += new System.EventHandler(this.butStart_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Andrzejewski
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butStart);
            this.Controls.Add(this.panelRysownica);
            this.Controls.Add(this.lblwybierzfigurę);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.lblTxtn);
            this.Name = "Andrzejewski";
            this.Text = "Prezentacja wybranych figur geometrycznych";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTxtn;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label lblwybierzfigurę;
        private System.Windows.Forms.Panel panelRysownica;
        private System.Windows.Forms.Button butStart;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

