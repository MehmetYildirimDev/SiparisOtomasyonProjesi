
namespace WindowsFormsApp1
{
    partial class FrmUrunEkle
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
            this.txtAgirlik = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnUrunEkle = new System.Windows.Forms.Button();
            this.rchAcıklama = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVergiTutar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mskMiktar = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // txtAgirlik
            // 
            this.txtAgirlik.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtAgirlik.ForeColor = System.Drawing.Color.Black;
            this.txtAgirlik.Location = new System.Drawing.Point(336, 362);
            this.txtAgirlik.Name = "txtAgirlik";
            this.txtAgirlik.Size = new System.Drawing.Size(151, 39);
            this.txtAgirlik.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(121, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 33);
            this.label1.TabIndex = 39;
            this.label1.Text = "Ürün Ağırlığı : ";
            // 
            // BtnUrunEkle
            // 
            this.BtnUrunEkle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnUrunEkle.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUrunEkle.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnUrunEkle.Location = new System.Drawing.Point(246, 585);
            this.BtnUrunEkle.Name = "BtnUrunEkle";
            this.BtnUrunEkle.Size = new System.Drawing.Size(260, 60);
            this.BtnUrunEkle.TabIndex = 38;
            this.BtnUrunEkle.Text = "Ürün Ekle";
            this.BtnUrunEkle.UseVisualStyleBackColor = false;
            this.BtnUrunEkle.Click += new System.EventHandler(this.BtnUrunEkle_Click);
            // 
            // rchAcıklama
            // 
            this.rchAcıklama.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.rchAcıklama.ForeColor = System.Drawing.Color.Black;
            this.rchAcıklama.Location = new System.Drawing.Point(336, 431);
            this.rchAcıklama.Name = "rchAcıklama";
            this.rchAcıklama.Size = new System.Drawing.Size(260, 134);
            this.rchAcıklama.TabIndex = 40;
            this.rchAcıklama.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(181, 432);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 33);
            this.label6.TabIndex = 36;
            this.label6.Text = "Açılması :";
            // 
            // txtVergiTutar
            // 
            this.txtVergiTutar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtVergiTutar.ForeColor = System.Drawing.Color.Black;
            this.txtVergiTutar.Location = new System.Drawing.Point(336, 306);
            this.txtVergiTutar.Name = "txtVergiTutar";
            this.txtVergiTutar.Size = new System.Drawing.Size(151, 39);
            this.txtVergiTutar.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(139, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 33);
            this.label5.TabIndex = 34;
            this.label5.Text = "Vergi Orani : ";
            // 
            // txtFiyat
            // 
            this.txtFiyat.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtFiyat.ForeColor = System.Drawing.Color.Black;
            this.txtFiyat.Location = new System.Drawing.Point(336, 243);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(151, 39);
            this.txtFiyat.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(223, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 33);
            this.label4.TabIndex = 32;
            this.label4.Text = "Fiyat : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(204, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 33);
            this.label3.TabIndex = 30;
            this.label3.Text = "Miktar : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(179, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(389, 46);
            this.label2.TabIndex = 29;
            this.label2.Text = "Ürün Ekleme Paneli";
            // 
            // txtAd
            // 
            this.txtAd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtAd.ForeColor = System.Drawing.Color.Black;
            this.txtAd.Location = new System.Drawing.Point(336, 108);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(151, 39);
            this.txtAd.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(253, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 33);
            this.label7.TabIndex = 27;
            this.label7.Text = "Ad : ";
            // 
            // mskMiktar
            // 
            this.mskMiktar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mskMiktar.ForeColor = System.Drawing.Color.Black;
            this.mskMiktar.Location = new System.Drawing.Point(336, 177);
            this.mskMiktar.Mask = "0000";
            this.mskMiktar.Name = "mskMiktar";
            this.mskMiktar.Size = new System.Drawing.Size(151, 39);
            this.mskMiktar.TabIndex = 41;
            this.mskMiktar.ValidatingType = typeof(int);
            // 
            // FrmUrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(768, 703);
            this.Controls.Add(this.mskMiktar);
            this.Controls.Add(this.txtAgirlik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnUrunEkle);
            this.Controls.Add(this.rchAcıklama);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtVergiTutar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label7);
            this.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmUrunEkle";
            this.Text = "FrmUrunEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAgirlik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnUrunEkle;
        private System.Windows.Forms.RichTextBox rchAcıklama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVergiTutar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mskMiktar;
    }
}