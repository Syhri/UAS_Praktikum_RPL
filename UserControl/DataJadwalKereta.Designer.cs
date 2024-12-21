namespace Sistem_Pemesanan_Tiket_Kereta
{
    partial class DataJadwalKereta
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
            btnClear = new Button();
            txtKereta = new TextBox();
            txtAsal = new TextBox();
            txtTujuan = new TextBox();
            txtWaktuBerangkat = new TextBox();
            txtWaktuTiba = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(242, 26);
            label1.Name = "label1";
            label1.Size = new Size(181, 25);
            label1.TabIndex = 0;
            label1.Text = "Atur Jadwal Kereta";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(230, 84);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(451, 375);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(10, 28);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(77, 23);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(104, 28);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(77, 23);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(10, 65);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(77, 23);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(104, 65);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(77, 23);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtKereta
            // 
            txtKereta.BorderStyle = BorderStyle.FixedSingle;
            txtKereta.Location = new Point(9, 37);
            txtKereta.Name = "txtKereta";
            txtKereta.PlaceholderText = "Nama Kereta";
            txtKereta.Size = new Size(176, 23);
            txtKereta.TabIndex = 2;
            txtKereta.TextChanged += txtKereta_TextChanged;
            // 
            // txtAsal
            // 
            txtAsal.BorderStyle = BorderStyle.FixedSingle;
            txtAsal.Location = new Point(10, 77);
            txtAsal.Name = "txtAsal";
            txtAsal.PlaceholderText = "Asal";
            txtAsal.Size = new Size(176, 23);
            txtAsal.TabIndex = 3;
            // 
            // txtTujuan
            // 
            txtTujuan.BorderStyle = BorderStyle.FixedSingle;
            txtTujuan.Location = new Point(10, 152);
            txtTujuan.Name = "txtTujuan";
            txtTujuan.PlaceholderText = "Tujuan";
            txtTujuan.Size = new Size(176, 23);
            txtTujuan.TabIndex = 4;
            // 
            // txtWaktuBerangkat
            // 
            txtWaktuBerangkat.BorderStyle = BorderStyle.FixedSingle;
            txtWaktuBerangkat.Location = new Point(10, 113);
            txtWaktuBerangkat.Name = "txtWaktuBerangkat";
            txtWaktuBerangkat.PlaceholderText = "Waktu Berangkat";
            txtWaktuBerangkat.Size = new Size(176, 23);
            txtWaktuBerangkat.TabIndex = 5;
            // 
            // txtWaktuTiba
            // 
            txtWaktuTiba.BorderStyle = BorderStyle.FixedSingle;
            txtWaktuTiba.Location = new Point(10, 188);
            txtWaktuTiba.Name = "txtWaktuTiba";
            txtWaktuTiba.PlaceholderText = "Waktu Tiba";
            txtWaktuTiba.Size = new Size(176, 23);
            txtWaktuTiba.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtKereta);
            groupBox1.Controls.Add(txtAsal);
            groupBox1.Controls.Add(txtWaktuTiba);
            groupBox1.Controls.Add(txtTujuan);
            groupBox1.Controls.Add(txtWaktuBerangkat);
            groupBox1.Location = new Point(19, 84);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(197, 236);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tambah Data Kereta";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(btnClear);
            groupBox2.Location = new Point(19, 351);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(197, 108);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pilih Opsi";
            // 
            // DataJadwalKereta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "DataJadwalKereta";
            Size = new Size(700, 500);
            Load += DataJadwalKereta_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Implementasi logika yang diperlukan saat sebuah cell diklik
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private TextBox txtKereta;
        private TextBox txtAsal;
        private TextBox txtTujuan;
        private TextBox txtWaktuBerangkat;
        private TextBox txtWaktuTiba;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear; // Deklarasikan tombol Clear
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}