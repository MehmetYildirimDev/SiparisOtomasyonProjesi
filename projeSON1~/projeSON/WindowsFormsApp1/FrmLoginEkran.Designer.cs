
namespace WindowsFormsApp1
{
    partial class FrmLoginEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoginEkran));
            this.lblHG = new System.Windows.Forms.Label();
            this.rbtnMusteri = new System.Windows.Forms.RadioButton();
            this.rdbtnAdminGiris = new System.Windows.Forms.RadioButton();
            this.grMusteriGiris = new System.Windows.Forms.GroupBox();
            this.LnkLblUyeOl = new System.Windows.Forms.LinkLabel();
            this.BtnMGiriş = new System.Windows.Forms.Button();
            this.txtMSifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMKullaniciadi = new System.Windows.Forms.TextBox();
            this.grAdminGiris = new System.Windows.Forms.GroupBox();
            this.BtnAGiris = new System.Windows.Forms.Button();
            this.txtASifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAKullaniciadi = new System.Windows.Forms.TextBox();
            this.grMusteriGiris.SuspendLayout();
            this.grAdminGiris.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHG
            // 
            this.lblHG.AutoSize = true;
            this.lblHG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHG.Font = new System.Drawing.Font("Sitka Text", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHG.ForeColor = System.Drawing.Color.Firebrick;
            this.lblHG.Location = new System.Drawing.Point(191, 5);
            this.lblHG.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHG.Name = "lblHG";
            this.lblHG.Size = new System.Drawing.Size(297, 62);
            this.lblHG.TabIndex = 0;
            this.lblHG.Text = "Hoş Geldiniz";
            this.lblHG.UseWaitCursor = true;
            // 
            // rbtnMusteri
            // 
            this.rbtnMusteri.AutoSize = true;
            this.rbtnMusteri.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rbtnMusteri.Checked = true;
            this.rbtnMusteri.ForeColor = System.Drawing.Color.Black;
            this.rbtnMusteri.Location = new System.Drawing.Point(26, 83);
            this.rbtnMusteri.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnMusteri.Name = "rbtnMusteri";
            this.rbtnMusteri.Size = new System.Drawing.Size(257, 48);
            this.rbtnMusteri.TabIndex = 1;
            this.rbtnMusteri.TabStop = true;
            this.rbtnMusteri.Text = "Müşteri Giriş";
            this.rbtnMusteri.UseVisualStyleBackColor = false;
            this.rbtnMusteri.UseWaitCursor = true;
            this.rbtnMusteri.CheckedChanged += new System.EventHandler(this.rbtnMusteri_CheckedChanged);
            // 
            // rdbtnAdminGiris
            // 
            this.rdbtnAdminGiris.AutoSize = true;
            this.rdbtnAdminGiris.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rdbtnAdminGiris.ForeColor = System.Drawing.Color.Black;
            this.rdbtnAdminGiris.Location = new System.Drawing.Point(395, 83);
            this.rdbtnAdminGiris.Margin = new System.Windows.Forms.Padding(2);
            this.rdbtnAdminGiris.Name = "rdbtnAdminGiris";
            this.rdbtnAdminGiris.Size = new System.Drawing.Size(240, 48);
            this.rdbtnAdminGiris.TabIndex = 2;
            this.rdbtnAdminGiris.Text = "Admin Giriş";
            this.rdbtnAdminGiris.UseVisualStyleBackColor = false;
            this.rdbtnAdminGiris.UseWaitCursor = true;
            this.rdbtnAdminGiris.CheckedChanged += new System.EventHandler(this.rdbtnAdminGiris_CheckedChanged_1);
            // 
            // grMusteriGiris
            // 
            this.grMusteriGiris.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grMusteriGiris.Controls.Add(this.LnkLblUyeOl);
            this.grMusteriGiris.Controls.Add(this.BtnMGiriş);
            this.grMusteriGiris.Controls.Add(this.txtMSifre);
            this.grMusteriGiris.Controls.Add(this.label4);
            this.grMusteriGiris.Controls.Add(this.label5);
            this.grMusteriGiris.Controls.Add(this.txtMKullaniciadi);
            this.grMusteriGiris.Location = new System.Drawing.Point(185, 156);
            this.grMusteriGiris.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grMusteriGiris.Name = "grMusteriGiris";
            this.grMusteriGiris.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grMusteriGiris.Size = new System.Drawing.Size(354, 367);
            this.grMusteriGiris.TabIndex = 3;
            this.grMusteriGiris.TabStop = false;
            this.grMusteriGiris.Text = "MÜŞTERİ";
            this.grMusteriGiris.UseWaitCursor = true;
            // 
            // LnkLblUyeOl
            // 
            this.LnkLblUyeOl.AutoSize = true;
            this.LnkLblUyeOl.LinkColor = System.Drawing.Color.Firebrick;
            this.LnkLblUyeOl.Location = new System.Drawing.Point(6, 264);
            this.LnkLblUyeOl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LnkLblUyeOl.Name = "LnkLblUyeOl";
            this.LnkLblUyeOl.Size = new System.Drawing.Size(136, 44);
            this.LnkLblUyeOl.TabIndex = 5;
            this.LnkLblUyeOl.TabStop = true;
            this.LnkLblUyeOl.Text = "Üye Ol";
            this.LnkLblUyeOl.UseWaitCursor = true;
            this.LnkLblUyeOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkLblUyeOl_LinkClicked);
            // 
            // BtnMGiriş
            // 
            this.BtnMGiriş.BackColor = System.Drawing.Color.Black;
            this.BtnMGiriş.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMGiriş.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMGiriş.ForeColor = System.Drawing.Color.Firebrick;
            this.BtnMGiriş.Location = new System.Drawing.Point(110, 187);
            this.BtnMGiriş.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnMGiriş.Name = "BtnMGiriş";
            this.BtnMGiriş.Size = new System.Drawing.Size(232, 59);
            this.BtnMGiriş.TabIndex = 5;
            this.BtnMGiriş.Text = "Giriş";
            this.BtnMGiriş.UseVisualStyleBackColor = false;
            this.BtnMGiriş.UseWaitCursor = true;
            this.BtnMGiriş.Click += new System.EventHandler(this.BtnMGiriş_Click);
            // 
            // txtMSifre
            // 
            this.txtMSifre.Location = new System.Drawing.Point(210, 121);
            this.txtMSifre.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMSifre.Name = "txtMSifre";
            this.txtMSifre.Size = new System.Drawing.Size(130, 49);
            this.txtMSifre.TabIndex = 24;
            this.txtMSifre.UseSystemPasswordChar = true;
            this.txtMSifre.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 36);
            this.label4.TabIndex = 21;
            this.label4.Text = "Kullanıcı Ad : ";
            this.label4.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(104, 130);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 36);
            this.label5.TabIndex = 23;
            this.label5.Text = "Şifre : ";
            this.label5.UseWaitCursor = true;
            // 
            // txtMKullaniciadi
            // 
            this.txtMKullaniciadi.Location = new System.Drawing.Point(210, 60);
            this.txtMKullaniciadi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMKullaniciadi.Name = "txtMKullaniciadi";
            this.txtMKullaniciadi.Size = new System.Drawing.Size(130, 49);
            this.txtMKullaniciadi.TabIndex = 22;
            this.txtMKullaniciadi.UseWaitCursor = true;
            // 
            // grAdminGiris
            // 
            this.grAdminGiris.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grAdminGiris.Controls.Add(this.BtnAGiris);
            this.grAdminGiris.Controls.Add(this.txtASifre);
            this.grAdminGiris.Controls.Add(this.label2);
            this.grAdminGiris.Controls.Add(this.label6);
            this.grAdminGiris.Controls.Add(this.txtAKullaniciadi);
            this.grAdminGiris.ForeColor = System.Drawing.Color.Black;
            this.grAdminGiris.Location = new System.Drawing.Point(181, 156);
            this.grAdminGiris.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grAdminGiris.Name = "grAdminGiris";
            this.grAdminGiris.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grAdminGiris.Size = new System.Drawing.Size(354, 367);
            this.grAdminGiris.TabIndex = 4;
            this.grAdminGiris.TabStop = false;
            this.grAdminGiris.Text = "ADMİN";
            this.grAdminGiris.UseWaitCursor = true;
            // 
            // BtnAGiris
            // 
            this.BtnAGiris.BackColor = System.Drawing.Color.Black;
            this.BtnAGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAGiris.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAGiris.ForeColor = System.Drawing.Color.Firebrick;
            this.BtnAGiris.Location = new System.Drawing.Point(108, 187);
            this.BtnAGiris.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnAGiris.Name = "BtnAGiris";
            this.BtnAGiris.Size = new System.Drawing.Size(232, 59);
            this.BtnAGiris.TabIndex = 25;
            this.BtnAGiris.Text = "Giriş";
            this.BtnAGiris.UseVisualStyleBackColor = false;
            this.BtnAGiris.UseWaitCursor = true;
            this.BtnAGiris.Click += new System.EventHandler(this.BtnAGiris_Click);
            // 
            // txtASifre
            // 
            this.txtASifre.Location = new System.Drawing.Point(210, 117);
            this.txtASifre.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtASifre.Name = "txtASifre";
            this.txtASifre.Size = new System.Drawing.Size(130, 49);
            this.txtASifre.TabIndex = 28;
            this.txtASifre.UseSystemPasswordChar = true;
            this.txtASifre.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 36);
            this.label2.TabIndex = 25;
            this.label2.Text = "Kullanıcı Ad : ";
            this.label2.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(104, 126);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 36);
            this.label6.TabIndex = 27;
            this.label6.Text = "Şifre : ";
            this.label6.UseWaitCursor = true;
            // 
            // txtAKullaniciadi
            // 
            this.txtAKullaniciadi.Location = new System.Drawing.Point(210, 56);
            this.txtAKullaniciadi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtAKullaniciadi.Name = "txtAKullaniciadi";
            this.txtAKullaniciadi.Size = new System.Drawing.Size(130, 49);
            this.txtAKullaniciadi.TabIndex = 26;
            this.txtAKullaniciadi.UseWaitCursor = true;
            // 
            // FrmLoginEkran
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(715, 553);
            this.Controls.Add(this.grAdminGiris);
            this.Controls.Add(this.grMusteriGiris);
            this.Controls.Add(this.rdbtnAdminGiris);
            this.Controls.Add(this.rbtnMusteri);
            this.Controls.Add(this.lblHG);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Name = "FrmLoginEkran";
            this.Text = "FrmLoginEkran";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.FrmLoginEkran_Load);
            this.grMusteriGiris.ResumeLayout(false);
            this.grMusteriGiris.PerformLayout();
            this.grAdminGiris.ResumeLayout(false);
            this.grAdminGiris.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHG;
        private System.Windows.Forms.RadioButton rbtnMusteri;
        private System.Windows.Forms.RadioButton rdbtnAdminGiris;
        private System.Windows.Forms.GroupBox grMusteriGiris;
        private System.Windows.Forms.GroupBox grAdminGiris;
        private System.Windows.Forms.TextBox txtMSifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMKullaniciadi;
        private System.Windows.Forms.TextBox txtASifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAKullaniciadi;
        private System.Windows.Forms.Button BtnMGiriş;
        private System.Windows.Forms.Button BtnAGiris;
        private System.Windows.Forms.LinkLabel LnkLblUyeOl;
    }
}