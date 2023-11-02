namespace _2_RadioButton_CheckBox
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
            this.rdbFenerbahce = new System.Windows.Forms.RadioButton();
            this.rdbGalatasaray = new System.Windows.Forms.RadioButton();
            this.rdbBesiktas = new System.Windows.Forms.RadioButton();
            this.btnSonucuGoster = new System.Windows.Forms.Button();
            this.lblTutulanTakim = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rdbFenerbahce
            // 
            this.rdbFenerbahce.AutoSize = true;
            this.rdbFenerbahce.Location = new System.Drawing.Point(239, 88);
            this.rdbFenerbahce.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbFenerbahce.Name = "rdbFenerbahce";
            this.rdbFenerbahce.Size = new System.Drawing.Size(101, 20);
            this.rdbFenerbahce.TabIndex = 0;
            this.rdbFenerbahce.TabStop = true;
            this.rdbFenerbahce.Text = "Fenerbahçe";
            this.rdbFenerbahce.UseVisualStyleBackColor = true;
            this.rdbFenerbahce.CheckedChanged += new System.EventHandler(this.rdbFenerbahce_CheckedChanged);
            // 
            // rdbGalatasaray
            // 
            this.rdbGalatasaray.AutoSize = true;
            this.rdbGalatasaray.Location = new System.Drawing.Point(239, 167);
            this.rdbGalatasaray.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbGalatasaray.Name = "rdbGalatasaray";
            this.rdbGalatasaray.Size = new System.Drawing.Size(102, 20);
            this.rdbGalatasaray.TabIndex = 1;
            this.rdbGalatasaray.TabStop = true;
            this.rdbGalatasaray.Text = "Galatasaray";
            this.rdbGalatasaray.UseVisualStyleBackColor = true;
            // 
            // rdbBesiktas
            // 
            this.rdbBesiktas.AutoSize = true;
            this.rdbBesiktas.Location = new System.Drawing.Point(239, 246);
            this.rdbBesiktas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbBesiktas.Name = "rdbBesiktas";
            this.rdbBesiktas.Size = new System.Drawing.Size(80, 20);
            this.rdbBesiktas.TabIndex = 2;
            this.rdbBesiktas.TabStop = true;
            this.rdbBesiktas.Text = "Beşiktaş";
            this.rdbBesiktas.UseVisualStyleBackColor = true;
            // 
            // btnSonucuGoster
            // 
            this.btnSonucuGoster.Location = new System.Drawing.Point(231, 300);
            this.btnSonucuGoster.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSonucuGoster.Name = "btnSonucuGoster";
            this.btnSonucuGoster.Size = new System.Drawing.Size(109, 52);
            this.btnSonucuGoster.TabIndex = 6;
            this.btnSonucuGoster.Text = "SONUCU GÖSTER";
            this.btnSonucuGoster.UseVisualStyleBackColor = true;
            this.btnSonucuGoster.Click += new System.EventHandler(this.btnSonucuGoster_Click);
            // 
            // lblTutulanTakim
            // 
            this.lblTutulanTakim.AutoSize = true;
            this.lblTutulanTakim.Location = new System.Drawing.Point(259, 384);
            this.lblTutulanTakim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTutulanTakim.Name = "lblTutulanTakim";
            this.lblTutulanTakim.Size = new System.Drawing.Size(44, 16);
            this.lblTutulanTakim.TabIndex = 7;
            this.lblTutulanTakim.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(236, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tuttuğunuz Takım";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(588, 499);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTutulanTakim);
            this.Controls.Add(this.btnSonucuGoster);
            this.Controls.Add(this.rdbBesiktas);
            this.Controls.Add(this.rdbGalatasaray);
            this.Controls.Add(this.rdbFenerbahce);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbFenerbahce;
        private System.Windows.Forms.RadioButton rdbGalatasaray;
        private System.Windows.Forms.RadioButton rdbBesiktas;
        private System.Windows.Forms.Button btnSonucuGoster;
        private System.Windows.Forms.Label lblTutulanTakim;
        private System.Windows.Forms.Label label2;
    }
}

