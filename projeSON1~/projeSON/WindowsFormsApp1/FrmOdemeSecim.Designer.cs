
namespace WindowsFormsApp1
{
    partial class FrmOdemeSecim
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
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.btnCek = new System.Windows.Forms.Button();
            this.btnKredi = new System.Windows.Forms.Button();
            this.btnNakit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(55, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tutar:";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(131, 54);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.ReadOnly = true;
            this.txtTutar.Size = new System.Drawing.Size(110, 34);
            this.txtTutar.TabIndex = 8;
            // 
            // btnCek
            // 
            this.btnCek.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCek.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCek.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCek.Location = new System.Drawing.Point(77, 285);
            this.btnCek.Name = "btnCek";
            this.btnCek.Size = new System.Drawing.Size(200, 52);
            this.btnCek.TabIndex = 7;
            this.btnCek.Text = "Çek ile Öde";
            this.btnCek.UseVisualStyleBackColor = false;
            this.btnCek.Click += new System.EventHandler(this.btnCek_Click_1);
            // 
            // btnKredi
            // 
            this.btnKredi.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnKredi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKredi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKredi.Location = new System.Drawing.Point(77, 202);
            this.btnKredi.Name = "btnKredi";
            this.btnKredi.Size = new System.Drawing.Size(200, 57);
            this.btnKredi.TabIndex = 6;
            this.btnKredi.Text = "Kredi Kartı İle Öde";
            this.btnKredi.UseVisualStyleBackColor = false;
            this.btnKredi.Click += new System.EventHandler(this.btnKredi_Click_1);
            // 
            // btnNakit
            // 
            this.btnNakit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNakit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNakit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNakit.Location = new System.Drawing.Point(77, 127);
            this.btnNakit.Name = "btnNakit";
            this.btnNakit.Size = new System.Drawing.Size(200, 53);
            this.btnNakit.TabIndex = 5;
            this.btnNakit.Text = "Nakit Öde";
            this.btnNakit.UseVisualStyleBackColor = false;
            this.btnNakit.Click += new System.EventHandler(this.btnNakit_Click);
            // 
            // FrmOdemeSecim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(340, 415);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.btnCek);
            this.Controls.Add(this.btnKredi);
            this.Controls.Add(this.btnNakit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmOdemeSecim";
            this.Text = "FrmOdemeSecim";
            this.Load += new System.EventHandler(this.FrmOdemeSecim_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Button btnCek;
        private System.Windows.Forms.Button btnKredi;
        private System.Windows.Forms.Button btnNakit;
    }
}