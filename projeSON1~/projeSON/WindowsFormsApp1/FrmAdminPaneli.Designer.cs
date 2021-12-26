
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
            this.tblMusteriBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.siparisProjesiDataSet = new WindowsFormsApp1.SiparisProjesiDataSet();
            this.tblMusteriBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblMusteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siparisProjesiDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_MusteriTableAdapter = new WindowsFormsApp1.SiparisProjesiDataSetTableAdapters.Tbl_MusteriTableAdapter();
            this.menuStrip1.SuspendLayout();
            this.grbMusteriBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMusteriBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisProjesiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMusteriBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMusteriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisProjesiDataSet1BindingSource)).BeginInit();
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
            this.grbMusteriBilgi.Location = new System.Drawing.Point(75, 54);
            this.grbMusteriBilgi.Name = "grbMusteriBilgi";
            this.grbMusteriBilgi.Size = new System.Drawing.Size(743, 426);
            this.grbMusteriBilgi.TabIndex = 1;
            this.grbMusteriBilgi.TabStop = false;
            this.grbMusteriBilgi.Text = "Müşteri Bilgileri";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlText;
            this.dataGridView1.Location = new System.Drawing.Point(3, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(737, 386);
            this.dataGridView1.TabIndex = 0;
            // 
            // tblMusteriBindingSource2
            // 
            this.tblMusteriBindingSource2.DataMember = "Tbl_Musteri";
            this.tblMusteriBindingSource2.DataSource = this.siparisProjesiDataSet;
            // 
            // siparisProjesiDataSet
            // 
            this.siparisProjesiDataSet.DataSetName = "SiparisProjesiDataSet";
            this.siparisProjesiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblMusteriBindingSource1
            // 
            this.tblMusteriBindingSource1.DataMember = "Tbl_Musteri";
            this.tblMusteriBindingSource1.DataSource = this.siparisProjesiDataSet;
            // 
            // tblMusteriBindingSource
            // 
            this.tblMusteriBindingSource.DataMember = "Tbl_Musteri";
            // 
            // tbl_MusteriTableAdapter
            // 
            this.tbl_MusteriTableAdapter.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.tblMusteriBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisProjesiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMusteriBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMusteriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisProjesiDataSet1BindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource tblMusteriBindingSource2;
    }
}

