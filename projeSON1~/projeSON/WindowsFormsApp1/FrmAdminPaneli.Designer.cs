
namespace WindowsFormsApp1
{
    partial class FrmAdminPaneli
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ürünİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbMusteriBilgi = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblMusteriBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.siparisProjesiDataSet = new WindowsFormsApp1.SiparisProjesiDataSet();
            this.tblMusteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siparisProjesiDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_MusteriTableAdapter = new WindowsFormsApp1.SiparisProjesiDataSetTableAdapters.Tbl_MusteriTableAdapter();
            this.tblMusteriBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.grbMusteriBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMusteriBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisProjesiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMusteriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisProjesiDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMusteriBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(865, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ürünİşlemleriToolStripMenuItem
            // 
            this.ürünİşlemleriToolStripMenuItem.BackColor = System.Drawing.Color.Firebrick;
            this.ürünİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünEkleToolStripMenuItem,
            this.ürünGüncelleToolStripMenuItem});
            this.ürünİşlemleriToolStripMenuItem.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ürünİşlemleriToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ürünİşlemleriToolStripMenuItem.Name = "ürünİşlemleriToolStripMenuItem";
            this.ürünİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.ürünİşlemleriToolStripMenuItem.Text = "Ürün İşlemleri";
            // 
            // ürünEkleToolStripMenuItem
            // 
            this.ürünEkleToolStripMenuItem.Name = "ürünEkleToolStripMenuItem";
            this.ürünEkleToolStripMenuItem.Size = new System.Drawing.Size(303, 26);
            this.ürünEkleToolStripMenuItem.Text = "Ürün Ekle ";
            this.ürünEkleToolStripMenuItem.Click += new System.EventHandler(this.ürünEkleToolStripMenuItem_Click);
            // 
            // ürünGüncelleToolStripMenuItem
            // 
            this.ürünGüncelleToolStripMenuItem.Name = "ürünGüncelleToolStripMenuItem";
            this.ürünGüncelleToolStripMenuItem.Size = new System.Drawing.Size(303, 26);
            this.ürünGüncelleToolStripMenuItem.Text = "Ürün Güncelle veya Sil";
            this.ürünGüncelleToolStripMenuItem.Click += new System.EventHandler(this.ürünGüncelleToolStripMenuItem_Click);
            // 
            // grbMusteriBilgi
            // 
            this.grbMusteriBilgi.BackColor = System.Drawing.Color.Firebrick;
            this.grbMusteriBilgi.Controls.Add(this.dataGridView1);
            this.grbMusteriBilgi.ForeColor = System.Drawing.Color.Black;
            this.grbMusteriBilgi.Location = new System.Drawing.Point(28, 51);
            this.grbMusteriBilgi.Name = "grbMusteriBilgi";
            this.grbMusteriBilgi.Size = new System.Drawing.Size(814, 426);
            this.grbMusteriBilgi.TabIndex = 1;
            this.grbMusteriBilgi.TabStop = false;
            this.grbMusteriBilgi.Text = "Müşteri Bilgileri";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView1.DataSource = this.tblMusteriBindingSource2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlText;
            this.dataGridView1.Location = new System.Drawing.Point(3, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(808, 386);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Adi";
            this.dataGridViewTextBoxColumn2.HeaderText = "Adi";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Soyadi";
            this.dataGridViewTextBoxColumn3.HeaderText = "Soyadi";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "KullaniciAdi";
            this.dataGridViewTextBoxColumn4.HeaderText = "KullaniciAdi";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Sifre";
            this.dataGridViewTextBoxColumn5.HeaderText = "Sifre";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Adresi";
            this.dataGridViewTextBoxColumn6.HeaderText = "Adresi";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // tblMusteriBindingSource1
            // 
            this.tblMusteriBindingSource1.DataMember = "Tbl_Musteri";
            this.tblMusteriBindingSource1.DataSource = this.siparisProjesiDataSet;
            // 
            // siparisProjesiDataSet
            // 
            this.siparisProjesiDataSet.DataSetName = "SiparisProjesiDataSet";
            this.siparisProjesiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblMusteriBindingSource
            // 
            this.tblMusteriBindingSource.DataMember = "Tbl_Musteri";
            // 
            // tbl_MusteriTableAdapter
            // 
            this.tbl_MusteriTableAdapter.ClearBeforeFill = true;
            // 
            // tblMusteriBindingSource2
            // 
            this.tblMusteriBindingSource2.DataMember = "Tbl_Musteri";
            this.tblMusteriBindingSource2.DataSource = this.siparisProjesiDataSet;
            // 
            // FrmAdminPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(865, 492);
            this.Controls.Add(this.grbMusteriBilgi);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "FrmAdminPaneli";
            this.Text = "FrmAdminPaneli";
            this.Load += new System.EventHandler(this.FrmAdminPaneli_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grbMusteriBilgi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMusteriBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisProjesiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMusteriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisProjesiDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMusteriBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ürünİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünGüncelleToolStripMenuItem;
        private System.Windows.Forms.GroupBox grbMusteriBilgi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource siparisProjesiDataSet1BindingSource;
        
        private System.Windows.Forms.BindingSource tblMusteriBindingSource;
        
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresiDataGridViewTextBoxColumn;
        private SiparisProjesiDataSet siparisProjesiDataSet;
        private System.Windows.Forms.BindingSource tblMusteriBindingSource1;
        private SiparisProjesiDataSetTableAdapters.Tbl_MusteriTableAdapter tbl_MusteriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource tblMusteriBindingSource2;
    }
}

