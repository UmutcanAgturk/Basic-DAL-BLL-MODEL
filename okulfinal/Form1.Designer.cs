namespace okulfinal
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtNumara = new System.Windows.Forms.TextBox();
            this.txtTcKimlik = new System.Windows.Forms.TextBox();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.cBSinif = new System.Windows.Forms.ComboBox();
            this.btnKayit = new System.Windows.Forms.Button();
            this.btnBul = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtOgrenciID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numara:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "TC Kimlik:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sınıf Seçiniz:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Numara Giriniz:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(86, 12);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 6;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(86, 38);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 7;
            // 
            // txtNumara
            // 
            this.txtNumara.Location = new System.Drawing.Point(86, 64);
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(100, 20);
            this.txtNumara.TabIndex = 8;
            // 
            // txtTcKimlik
            // 
            this.txtTcKimlik.Location = new System.Drawing.Point(86, 90);
            this.txtTcKimlik.Name = "txtTcKimlik";
            this.txtTcKimlik.Size = new System.Drawing.Size(100, 20);
            this.txtTcKimlik.TabIndex = 9;
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(86, 230);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(100, 20);
            this.txtArama.TabIndex = 10;
            // 
            // cBSinif
            // 
            this.cBSinif.FormattingEnabled = true;
            this.cBSinif.Location = new System.Drawing.Point(86, 116);
            this.cBSinif.Name = "cBSinif";
            this.cBSinif.Size = new System.Drawing.Size(100, 21);
            this.cBSinif.TabIndex = 11;
            // 
            // btnKayit
            // 
            this.btnKayit.Location = new System.Drawing.Point(86, 143);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(100, 23);
            this.btnKayit.TabIndex = 12;
            this.btnKayit.Text = "Kaydet";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(86, 256);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(100, 23);
            this.btnBul.TabIndex = 13;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(86, 201);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(99, 23);
            this.btnGuncelle.TabIndex = 14;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(86, 172);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(99, 23);
            this.btnSil.TabIndex = 15;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtOgrenciID
            // 
            this.txtOgrenciID.Location = new System.Drawing.Point(60, 203);
            this.txtOgrenciID.Name = "txtOgrenciID";
            this.txtOgrenciID.Size = new System.Drawing.Size(20, 20);
            this.txtOgrenciID.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 298);
            this.Controls.Add(this.txtOgrenciID);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.cBSinif);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.txtTcKimlik);
            this.Controls.Add(this.txtNumara);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtNumara;
        private System.Windows.Forms.TextBox txtTcKimlik;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.ComboBox cBSinif;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtOgrenciID;
    }
}

