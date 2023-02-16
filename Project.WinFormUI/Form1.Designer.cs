namespace Project.WinFormUI
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
            this.lstKategoriler = new System.Windows.Forms.ListBox();
            this.btnPasif = new System.Windows.Forms.Button();
            this.btnGüncel = new System.Windows.Forms.Button();
            this.btnAktif = new System.Windows.Forms.Button();
            this.btnHepsi = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnYokEt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstKategoriler
            // 
            this.lstKategoriler.BackColor = System.Drawing.Color.DarkRed;
            this.lstKategoriler.FormattingEnabled = true;
            this.lstKategoriler.Location = new System.Drawing.Point(45, 33);
            this.lstKategoriler.Name = "lstKategoriler";
            this.lstKategoriler.Size = new System.Drawing.Size(225, 303);
            this.lstKategoriler.TabIndex = 0;
            this.lstKategoriler.SelectedValueChanged += new System.EventHandler(this.lstKategoriler_SelectedValueChanged);
            // 
            // btnPasif
            // 
            this.btnPasif.Location = new System.Drawing.Point(518, 239);
            this.btnPasif.Name = "btnPasif";
            this.btnPasif.Size = new System.Drawing.Size(93, 38);
            this.btnPasif.TabIndex = 1;
            this.btnPasif.Text = "Pasifleri Getir";
            this.btnPasif.UseVisualStyleBackColor = true;
            this.btnPasif.Click += new System.EventHandler(this.btnPasif_Click);
            // 
            // btnGüncel
            // 
            this.btnGüncel.Location = new System.Drawing.Point(419, 239);
            this.btnGüncel.Name = "btnGüncel";
            this.btnGüncel.Size = new System.Drawing.Size(93, 38);
            this.btnGüncel.TabIndex = 2;
            this.btnGüncel.Text = "Güncellenenleri Getir";
            this.btnGüncel.UseVisualStyleBackColor = true;
            this.btnGüncel.Click += new System.EventHandler(this.btnGüncel_Click);
            // 
            // btnAktif
            // 
            this.btnAktif.Location = new System.Drawing.Point(320, 239);
            this.btnAktif.Name = "btnAktif";
            this.btnAktif.Size = new System.Drawing.Size(93, 38);
            this.btnAktif.TabIndex = 3;
            this.btnAktif.Text = "Aktifleri Getir";
            this.btnAktif.UseVisualStyleBackColor = true;
            this.btnAktif.Click += new System.EventHandler(this.btnAktif_Click);
            // 
            // btnHepsi
            // 
            this.btnHepsi.Location = new System.Drawing.Point(629, 239);
            this.btnHepsi.Name = "btnHepsi";
            this.btnHepsi.Size = new System.Drawing.Size(93, 38);
            this.btnHepsi.TabIndex = 4;
            this.btnHepsi.Text = "Hepsini Getir";
            this.btnHepsi.UseVisualStyleBackColor = true;
            this.btnHepsi.Click += new System.EventHandler(this.btnHepsi_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(394, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 5;
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(394, 172);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(100, 41);
            this.btnGüncelle.TabIndex = 6;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(394, 125);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(100, 41);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(394, 75);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(100, 41);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnYokEt
            // 
            this.btnYokEt.Location = new System.Drawing.Point(518, 75);
            this.btnYokEt.Name = "btnYokEt";
            this.btnYokEt.Size = new System.Drawing.Size(100, 41);
            this.btnYokEt.TabIndex = 9;
            this.btnYokEt.Text = "Yok Et";
            this.btnYokEt.UseVisualStyleBackColor = true;
            this.btnYokEt.Click += new System.EventHandler(this.btnYokEt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnYokEt);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnHepsi);
            this.Controls.Add(this.btnAktif);
            this.Controls.Add(this.btnGüncel);
            this.Controls.Add(this.btnPasif);
            this.Controls.Add(this.lstKategoriler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstKategoriler;
        private System.Windows.Forms.Button btnPasif;
        private System.Windows.Forms.Button btnGüncel;
        private System.Windows.Forms.Button btnAktif;
        private System.Windows.Forms.Button btnHepsi;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnYokEt;
    }
}

