
namespace WindowsFormsApp1
{
    partial class FrmMusteriKayit
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
            this.BtnKayitOl = new System.Windows.Forms.Button();
            this.rchAdres = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKullaniciadi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnKayitOl
            // 
            this.BtnKayitOl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnKayitOl.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKayitOl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnKayitOl.Location = new System.Drawing.Point(142, 559);
            this.BtnKayitOl.Name = "BtnKayitOl";
            this.BtnKayitOl.Size = new System.Drawing.Size(260, 58);
            this.BtnKayitOl.TabIndex = 23;
            this.BtnKayitOl.Text = "Kayıt Ol";
            this.BtnKayitOl.UseVisualStyleBackColor = false;
            this.BtnKayitOl.Click += new System.EventHandler(this.BtnKayitOl_Click);
            // 
            // rchAdres
            // 
            this.rchAdres.Location = new System.Drawing.Point(243, 410);
            this.rchAdres.Name = "rchAdres";
            this.rchAdres.Size = new System.Drawing.Size(260, 130);
            this.rchAdres.TabIndex = 22;
            this.rchAdres.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(113, 405);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 38);
            this.label6.TabIndex = 21;
            this.label6.Text = "Adres :";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(243, 347);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(151, 45);
            this.txtSifre.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(123, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 38);
            this.label5.TabIndex = 19;
            this.label5.Text = "Şifre : ";
            // 
            // txtKullaniciadi
            // 
            this.txtKullaniciadi.Location = new System.Drawing.Point(243, 286);
            this.txtKullaniciadi.Name = "txtKullaniciadi";
            this.txtKullaniciadi.Size = new System.Drawing.Size(151, 45);
            this.txtKullaniciadi.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(13, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 38);
            this.label4.TabIndex = 17;
            this.label4.Text = "Kullanıcı Ad : ";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(243, 222);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(151, 45);
            this.txtSoyad.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(96, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 38);
            this.label3.TabIndex = 15;
            this.label3.Text = "Soyad : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(67, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(393, 46);
            this.label2.TabIndex = 14;
            this.label2.Text = "Müşteri Kayit Paneli";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(243, 156);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(151, 45);
            this.txtAd.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(151, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 38);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ad : ";
            // 
            // FrmMusteriKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(585, 723);
            this.Controls.Add(this.BtnKayitOl);
            this.Controls.Add(this.rchAdres);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtKullaniciadi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "FrmMusteriKayit";
            this.Text = "FrmMusteriKayit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnKayitOl;
        private System.Windows.Forms.RichTextBox rchAdres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKullaniciadi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label1;
    }
}