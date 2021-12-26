
namespace WindowsFormsApp1
{
    partial class FrmSiparisOlustur
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
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.LstUrun = new System.Windows.Forms.ListBox();
            this.BtnSiparisEkle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.mskMiktar = new System.Windows.Forms.MaskedTextBox();
            this.LstSepet = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSiparisDurum = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblSepetAgırlık = new System.Windows.Forms.Label();
            this.lblkg = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblAraToplam = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblToplamVergi = new System.Windows.Forms.Label();
            this.btnOdeme = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.lblOdenecekTutar = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblKargoTutari = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(12, 33);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(55, 34);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Ad";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.Location = new System.Drawing.Point(113, 33);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(105, 34);
            this.lblSoyad.TabIndex = 1;
            this.lblSoyad.Text = "Soyad";
            // 
            // LstUrun
            // 
            this.LstUrun.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LstUrun.ForeColor = System.Drawing.Color.Firebrick;
            this.LstUrun.FormattingEnabled = true;
            this.LstUrun.ItemHeight = 36;
            this.LstUrun.Location = new System.Drawing.Point(12, 132);
            this.LstUrun.Name = "LstUrun";
            this.LstUrun.Size = new System.Drawing.Size(211, 364);
            this.LstUrun.TabIndex = 2;
            // 
            // BtnSiparisEkle
            // 
            this.BtnSiparisEkle.BackColor = System.Drawing.Color.Black;
            this.BtnSiparisEkle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSiparisEkle.ForeColor = System.Drawing.Color.Firebrick;
            this.BtnSiparisEkle.Location = new System.Drawing.Point(276, 305);
            this.BtnSiparisEkle.Name = "BtnSiparisEkle";
            this.BtnSiparisEkle.Size = new System.Drawing.Size(153, 36);
            this.BtnSiparisEkle.TabIndex = 3;
            this.BtnSiparisEkle.Text = "Sepete Ekle >";
            this.BtnSiparisEkle.UseVisualStyleBackColor = false;
            this.BtnSiparisEkle.Click += new System.EventHandler(this.BtnSiparisEkle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(304, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 35);
            this.label3.TabIndex = 5;
            this.label3.Text = "Miktar";
            // 
            // mskMiktar
            // 
            this.mskMiktar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mskMiktar.ForeColor = System.Drawing.Color.Firebrick;
            this.mskMiktar.Location = new System.Drawing.Point(261, 165);
            this.mskMiktar.Mask = "000";
            this.mskMiktar.Name = "mskMiktar";
            this.mskMiktar.Size = new System.Drawing.Size(179, 41);
            this.mskMiktar.TabIndex = 6;
            this.mskMiktar.ValidatingType = typeof(int);
            // 
            // LstSepet
            // 
            this.LstSepet.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LstSepet.ForeColor = System.Drawing.Color.Firebrick;
            this.LstSepet.FormattingEnabled = true;
            this.LstSepet.ItemHeight = 36;
            this.LstSepet.Location = new System.Drawing.Point(482, 132);
            this.LstSepet.Name = "LstSepet";
            this.LstSepet.Size = new System.Drawing.Size(237, 364);
            this.LstSepet.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(473, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 35);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ürün";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(601, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 35);
            this.label2.TabIndex = 10;
            this.label2.Text = "Adet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(731, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 35);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tarih  :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Black;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dateTimePicker1.Location = new System.Drawing.Point(844, 61);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(403, 41);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(748, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(255, 35);
            this.label5.TabIndex = 13;
            this.label5.Text = "Sipariş Durumu :";
            // 
            // lblSiparisDurum
            // 
            this.lblSiparisDurum.AutoSize = true;
            this.lblSiparisDurum.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSiparisDurum.Location = new System.Drawing.Point(1002, 151);
            this.lblSiparisDurum.Name = "lblSiparisDurum";
            this.lblSiparisDurum.Size = new System.Drawing.Size(39, 35);
            this.lblSiparisDurum.TabIndex = 14;
            this.lblSiparisDurum.Text = "...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(776, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(217, 35);
            this.label7.TabIndex = 15;
            this.label7.Text = "Toplam Vergi :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(775, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(223, 35);
            this.label9.TabIndex = 16;
            this.label9.Text = "Sepet Ağırlığı :";
            // 
            // lblSepetAgırlık
            // 
            this.lblSepetAgırlık.AutoSize = true;
            this.lblSepetAgırlık.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSepetAgırlık.Location = new System.Drawing.Point(1002, 206);
            this.lblSepetAgırlık.Name = "lblSepetAgırlık";
            this.lblSepetAgırlık.Size = new System.Drawing.Size(32, 35);
            this.lblSepetAgırlık.TabIndex = 17;
            this.lblSepetAgırlık.Text = "0";
            // 
            // lblkg
            // 
            this.lblkg.AutoSize = true;
            this.lblkg.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkg.Location = new System.Drawing.Point(1085, 206);
            this.lblkg.Name = "lblkg";
            this.lblkg.Size = new System.Drawing.Size(60, 35);
            this.lblkg.TabIndex = 18;
            this.lblkg.Text = "KG";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(800, 259);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(194, 35);
            this.label10.TabIndex = 22;
            this.label10.Text = "Ara Toplam :";
            // 
            // lblAraToplam
            // 
            this.lblAraToplam.AutoSize = true;
            this.lblAraToplam.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAraToplam.Location = new System.Drawing.Point(1002, 259);
            this.lblAraToplam.Name = "lblAraToplam";
            this.lblAraToplam.Size = new System.Drawing.Size(32, 35);
            this.lblAraToplam.TabIndex = 23;
            this.lblAraToplam.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(1093, 259);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 35);
            this.label11.TabIndex = 24;
            this.label11.Text = "TL";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(1093, 316);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 35);
            this.label12.TabIndex = 26;
            this.label12.Text = "TL";
            // 
            // lblToplamVergi
            // 
            this.lblToplamVergi.AutoSize = true;
            this.lblToplamVergi.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamVergi.Location = new System.Drawing.Point(1002, 316);
            this.lblToplamVergi.Name = "lblToplamVergi";
            this.lblToplamVergi.Size = new System.Drawing.Size(32, 35);
            this.lblToplamVergi.TabIndex = 25;
            this.lblToplamVergi.Text = "0";
            // 
            // btnOdeme
            // 
            this.btnOdeme.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOdeme.Font = new System.Drawing.Font("Arial", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdeme.ForeColor = System.Drawing.Color.Firebrick;
            this.btnOdeme.Location = new System.Drawing.Point(1029, 475);
            this.btnOdeme.Name = "btnOdeme";
            this.btnOdeme.Size = new System.Drawing.Size(203, 65);
            this.btnOdeme.TabIndex = 27;
            this.btnOdeme.Text = "Ödemeye Git";
            this.btnOdeme.UseVisualStyleBackColor = false;
            this.btnOdeme.Click += new System.EventHandler(this.btnOdeme_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(1093, 428);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 35);
            this.label14.TabIndex = 30;
            this.label14.Text = "TL";
            // 
            // lblOdenecekTutar
            // 
            this.lblOdenecekTutar.AutoSize = true;
            this.lblOdenecekTutar.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdenecekTutar.Location = new System.Drawing.Point(1002, 428);
            this.lblOdenecekTutar.Name = "lblOdenecekTutar";
            this.lblOdenecekTutar.Size = new System.Drawing.Size(32, 35);
            this.lblOdenecekTutar.TabIndex = 29;
            this.lblOdenecekTutar.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(742, 428);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(258, 35);
            this.label16.TabIndex = 28;
            this.label16.Text = "Ödenecek Tutar :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(1093, 373);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 35);
            this.label17.TabIndex = 33;
            this.label17.Text = "TL";
            // 
            // lblKargoTutari
            // 
            this.lblKargoTutari.AutoSize = true;
            this.lblKargoTutari.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKargoTutari.Location = new System.Drawing.Point(1002, 373);
            this.lblKargoTutari.Name = "lblKargoTutari";
            this.lblKargoTutari.Size = new System.Drawing.Size(32, 35);
            this.lblKargoTutari.TabIndex = 32;
            this.lblKargoTutari.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(797, 373);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(201, 35);
            this.label19.TabIndex = 31;
            this.label19.Text = "KargoTutari :";
            // 
            // FrmSiparisOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(1264, 566);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lblKargoTutari);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.btnOdeme);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LstSepet);
            this.Controls.Add(this.mskMiktar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnSiparisEkle);
            this.Controls.Add(this.LstUrun);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblOdenecekTutar);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblToplamVergi);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblAraToplam);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblkg);
            this.Controls.Add(this.lblSepetAgırlık);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblSiparisDurum);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "FrmSiparisOlustur";
            this.Text = "FrmSiparisOlustur";
            this.Load += new System.EventHandler(this.FrmSiparisOlustur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.ListBox LstUrun;
        private System.Windows.Forms.Button BtnSiparisEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskMiktar;
        private System.Windows.Forms.ListBox LstSepet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSiparisDurum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblSepetAgırlık;
        private System.Windows.Forms.Label lblkg;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblAraToplam;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblToplamVergi;
        private System.Windows.Forms.Button btnOdeme;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblOdenecekTutar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblKargoTutari;
        private System.Windows.Forms.Label label19;
    }
}