
namespace Sistem_Pemesanan_Tiket_Kereta
{
    partial class DataPemesananTiket
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            dgvTiket = new DataGridView();
            btnPesan = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTiket).BeginInit();
            SuspendLayout();
            // 
            // dgvTiket
            // 
            dgvTiket.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTiket.Location = new Point(15, 45);
            dgvTiket.Name = "dgvTiket";
            dgvTiket.Size = new Size(760, 350);
            dgvTiket.TabIndex = 0;
            dgvTiket.CellContentClick += dgvTiket_CellContentClick;
            // 
            // btnPesan
            // 
            btnPesan.Location = new Point(700, 415);
            btnPesan.Name = "btnPesan";
            btnPesan.Size = new Size(75, 23);
            btnPesan.TabIndex = 1;
            btnPesan.Text = "Pesan";
            btnPesan.UseVisualStyleBackColor = true;
            btnPesan.Click += btnPesan_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(15, 15);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(660, 23);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(690, 15);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Cari";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // DataPemesananTiket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnPesan);
            Controls.Add(dgvTiket);
            Name = "DataPemesananTiket";
            Size = new Size(800, 450);
            Load += DataPemesananTiket_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTiket).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void dgvTiket_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTiket;
        private System.Windows.Forms.Button btnPesan;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
    }
}