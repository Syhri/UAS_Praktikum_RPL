namespace Sistem_Pemesanan_Tiket_Kereta
{
    partial class DataPemesananTerbayar
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            txtUserId = new TextBox();
            txtTiketId = new TextBox();
            dtpTanggalPembayaran = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(240, 25);
            label1.TabIndex = 0;
            label1.Text = "Data Pemesanan Terbayar";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(20, 220);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(760, 250);
            dataGridView1.TabIndex = 1;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(20, 180);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Tambah";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(110, 180);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(200, 180);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Hapus";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtUserId
            // 
            txtUserId.Location = new Point(144, 60);
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new Size(200, 23);
            txtUserId.TabIndex = 5;
            // 
            // txtTiketId
            // 
            txtTiketId.Location = new Point(144, 91);
            txtTiketId.Name = "txtTiketId";
            txtTiketId.Size = new Size(200, 23);
            txtTiketId.TabIndex = 6;
            // 
            // dtpTanggalPembayaran
            // 
            dtpTanggalPembayaran.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dtpTanggalPembayaran.Format = DateTimePickerFormat.Custom;
            dtpTanggalPembayaran.Location = new Point(143, 120);
            dtpTanggalPembayaran.Name = "dtpTanggalPembayaran";
            dtpTanggalPembayaran.Size = new Size(200, 23);
            dtpTanggalPembayaran.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 63);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 8;
            label2.Text = "User ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 94);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 9;
            label3.Text = "Tiket ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 126);
            label4.Name = "label4";
            label4.Size = new Size(117, 15);
            label4.TabIndex = 10;
            label4.Text = "Tanggal Pembayaran";
            // 
            // DataPemesananTerbayar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtpTanggalPembayaran);
            Controls.Add(txtTiketId);
            Controls.Add(txtUserId);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "DataPemesananTerbayar";
            Size = new Size(800, 500);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TextBox txtTiketId;
        private System.Windows.Forms.DateTimePicker dtpTanggalPembayaran;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}