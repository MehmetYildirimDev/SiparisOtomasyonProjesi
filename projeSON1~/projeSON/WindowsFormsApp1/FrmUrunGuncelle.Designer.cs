
namespace WindowsFormsApp1
{
    partial class FrmUrunGuncelle
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.urunIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunMiktariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunBirimFiyatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vergiTutariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAgirligiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAciklamasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblUrunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siparisProjesiDataSet = new WindowsFormsApp1.SiparisProjesiDataSet();
            this.tbl_UrunTableAdapter = new WindowsFormsApp1.SiparisProjesiDataSetTableAdapters.Tbl_UrunTableAdapter();
            this.mskMiktar = new System.Windows.Forms.MaskedTextBox();
            this.txtAgirlik = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.rchAcıklama = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVergiTutar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUrunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisProjesiDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(1246, 277);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürünler";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunIDDataGridViewTextBoxColumn,
            this.urunAdiDataGridViewTextBoxColumn,
            this.urunMiktariDataGridViewTextBoxColumn,
            this.urunBirimFiyatiDataGridViewTextBoxColumn,
            this.vergiTutariDataGridViewTextBoxColumn,
            this.urunAgirligiDataGridViewTextBoxColumn,
            this.urunAciklamasiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblUrunBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(2, 38);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1242, 236);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // urunIDDataGridViewTextBoxColumn
            // 
            this.urunIDDataGridViewTextBoxColumn.DataPropertyName = "UrunID";
            this.urunIDDataGridViewTextBoxColumn.HeaderText = "UrunID";
            this.urunIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunIDDataGridViewTextBoxColumn.Name = "urunIDDataGridViewTextBoxColumn";
            this.urunIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.urunIDDataGridViewTextBoxColumn.Width = 144;
            // 
            // urunAdiDataGridViewTextBoxColumn
            // 
            this.urunAdiDataGridViewTextBoxColumn.DataPropertyName = "UrunAdi";
            this.urunAdiDataGridViewTextBoxColumn.HeaderText = "UrunAdi";
            this.urunAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunAdiDataGridViewTextBoxColumn.Name = "urunAdiDataGridViewTextBoxColumn";
            this.urunAdiDataGridViewTextBoxColumn.ReadOnly = true;
            this.urunAdiDataGridViewTextBoxColumn.Width = 161;
            // 
            // urunMiktariDataGridViewTextBoxColumn
            // 
            this.urunMiktariDataGridViewTextBoxColumn.DataPropertyName = "UrunMiktari";
            this.urunMiktariDataGridViewTextBoxColumn.HeaderText = "UrunMiktari";
            this.urunMiktariDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunMiktariDataGridViewTextBoxColumn.Name = "urunMiktariDataGridViewTextBoxColumn";
            this.urunMiktariDataGridViewTextBoxColumn.ReadOnly = true;
            this.urunMiktariDataGridViewTextBoxColumn.Width = 211;
            // 
            // urunBirimFiyatiDataGridViewTextBoxColumn
            // 
            this.urunBirimFiyatiDataGridViewTextBoxColumn.DataPropertyName = "UrunBirimFiyati";
            this.urunBirimFiyatiDataGridViewTextBoxColumn.HeaderText = "UrunBirimFiyati";
            this.urunBirimFiyatiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunBirimFiyatiDataGridViewTextBoxColumn.Name = "urunBirimFiyatiDataGridViewTextBoxColumn";
            this.urunBirimFiyatiDataGridViewTextBoxColumn.ReadOnly = true;
            this.urunBirimFiyatiDataGridViewTextBoxColumn.Width = 266;
            // 
            // vergiTutariDataGridViewTextBoxColumn
            // 
            this.vergiTutariDataGridViewTextBoxColumn.DataPropertyName = "VergiTutari";
            this.vergiTutariDataGridViewTextBoxColumn.HeaderText = "VergiTutari";
            this.vergiTutariDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vergiTutariDataGridViewTextBoxColumn.Name = "vergiTutariDataGridViewTextBoxColumn";
            this.vergiTutariDataGridViewTextBoxColumn.ReadOnly = true;
            this.vergiTutariDataGridViewTextBoxColumn.Width = 198;
            // 
            // urunAgirligiDataGridViewTextBoxColumn
            // 
            this.urunAgirligiDataGridViewTextBoxColumn.DataPropertyName = "UrunAgirligi";
            this.urunAgirligiDataGridViewTextBoxColumn.HeaderText = "UrunAgirligi";
            this.urunAgirligiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunAgirligiDataGridViewTextBoxColumn.Name = "urunAgirligiDataGridViewTextBoxColumn";
            this.urunAgirligiDataGridViewTextBoxColumn.ReadOnly = true;
            this.urunAgirligiDataGridViewTextBoxColumn.Width = 215;
            // 
            // urunAciklamasiDataGridViewTextBoxColumn
            // 
            this.urunAciklamasiDataGridViewTextBoxColumn.DataPropertyName = "UrunAciklamasi";
            this.urunAciklamasiDataGridViewTextBoxColumn.HeaderText = "UrunAciklamasi";
            this.urunAciklamasiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunAciklamasiDataGridViewTextBoxColumn.Name = "urunAciklamasiDataGridViewTextBoxColumn";
            this.urunAciklamasiDataGridViewTextBoxColumn.ReadOnly = true;
            this.urunAciklamasiDataGridViewTextBoxColumn.Width = 270;
            // 
            // tblUrunBindingSource
            // 
            this.tblUrunBindingSource.DataMember = "Tbl_Urun";
            this.tblUrunBindingSource.DataSource = this.siparisProjesiDataSet;
            // 
            // siparisProjesiDataSet
            // 
            this.siparisProjesiDataSet.DataSetName = "SiparisProjesiDataSet";
            this.siparisProjesiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_UrunTableAdapter
            // 
            this.tbl_UrunTableAdapter.ClearBeforeFill = true;
            // 
            // mskMiktar
            // 
            this.mskMiktar.Location = new System.Drawing.Point(218, 407);
            this.mskMiktar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.mskMiktar.Mask = "0000";
            this.mskMiktar.Name = "mskMiktar";
            this.mskMiktar.Size = new System.Drawing.Size(125, 42);
            this.mskMiktar.TabIndex = 54;
            this.mskMiktar.ValidatingType = typeof(int);
            // 
            // txtAgirlik
            // 
            this.txtAgirlik.Location = new System.Drawing.Point(605, 405);
            this.txtAgirlik.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtAgirlik.Name = "txtAgirlik";
            this.txtAgirlik.Size = new System.Drawing.Size(125, 42);
            this.txtAgirlik.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(373, 407);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 35);
            this.label1.TabIndex = 52;
            this.label1.Text = "Ürün Ağırlığı : ";
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnGuncelle.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnGuncelle.Location = new System.Drawing.Point(360, 493);
            this.BtnGuncelle.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(218, 79);
            this.BtnGuncelle.TabIndex = 51;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = false;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // rchAcıklama
            // 
            this.rchAcıklama.Location = new System.Drawing.Point(973, 313);
            this.rchAcıklama.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rchAcıklama.Name = "rchAcıklama";
            this.rchAcıklama.Size = new System.Drawing.Size(216, 147);
            this.rchAcıklama.TabIndex = 53;
            this.rchAcıklama.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(793, 364);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 35);
            this.label6.TabIndex = 49;
            this.label6.Text = "Açılması :";
            // 
            // txtVergiTutar
            // 
            this.txtVergiTutar.Location = new System.Drawing.Point(605, 357);
            this.txtVergiTutar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtVergiTutar.Name = "txtVergiTutar";
            this.txtVergiTutar.Size = new System.Drawing.Size(125, 42);
            this.txtVergiTutar.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(389, 359);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 35);
            this.label5.TabIndex = 47;
            this.label5.Text = "Vergi Tutarı : ";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(218, 357);
            this.txtFiyat.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(125, 42);
            this.txtFiyat.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(98, 359);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 35);
            this.label4.TabIndex = 45;
            this.label4.Text = "Fiyat : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(78, 407);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 35);
            this.label3.TabIndex = 44;
            this.label3.Text = "Miktar : ";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(218, 307);
            this.txtAd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(125, 42);
            this.txtAd.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(128, 315);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 35);
            this.label7.TabIndex = 42;
            this.label7.Text = "Ad : ";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(605, 307);
            this.txtID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(125, 42);
            this.txtID.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(521, 315);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 35);
            this.label2.TabIndex = 55;
            this.label2.Text = "ID : ";
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSil.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSil.Location = new System.Drawing.Point(654, 493);
            this.btnSil.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(218, 79);
            this.btnSil.TabIndex = 57;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // FrmUrunGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(1260, 631);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mskMiktar);
            this.Controls.Add(this.txtAgirlik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.rchAcıklama);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtVergiTutar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "FrmUrunGuncelle";
            this.Text = "FrmUrunGuncelle";
            this.Load += new System.EventHandler(this.FrmUrunGuncelle_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUrunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisProjesiDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SiparisProjesiDataSet siparisProjesiDataSet;
        private System.Windows.Forms.BindingSource tblUrunBindingSource;
        private SiparisProjesiDataSetTableAdapters.Tbl_UrunTableAdapter tbl_UrunTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunMiktariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunBirimFiyatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vergiTutariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAgirligiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAciklamasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.MaskedTextBox mskMiktar;
        private System.Windows.Forms.TextBox txtAgirlik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.RichTextBox rchAcıklama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVergiTutar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSil;
    }
}