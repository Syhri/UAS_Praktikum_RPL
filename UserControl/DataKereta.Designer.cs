namespace Sistem_Pemesanan_Tiket_Kereta
{
    partial class DataKereta
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
            txtNamaKereta = new TextBox();
            txtJenisKereta = new TextBox();
            txtRute = new TextBox();
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
            label1.Size = new Size(229, 25);
            label1.TabIndex = 0;
            label1.Text = "Pengelolaan Data Kereta";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(20, 160);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(760, 250);
            dataGridView1.TabIndex = 1;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(20, 120);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Tambah";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(110, 120);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(200, 120);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Hapus";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtNamaKereta
            // 
            txtNamaKereta.BorderStyle = BorderStyle.FixedSingle;
            txtNamaKereta.Location = new Point(120, 60);
            txtNamaKereta.Name = "txtNamaKereta";
            txtNamaKereta.Size = new Size(200, 23);
            txtNamaKereta.TabIndex = 5;
            txtNamaKereta.TextChanged += txtNamaKereta_TextChanged;
            // 
            // txtJenisKereta
            // 
            txtJenisKereta.BorderStyle = BorderStyle.FixedSingle;
            txtJenisKereta.Location = new Point(120, 90);
            txtJenisKereta.Name = "txtJenisKereta";
            txtJenisKereta.Size = new Size(200, 23);
            txtJenisKereta.TabIndex = 6;
            // 
            // txtRute
            // 
            txtRute.BorderStyle = BorderStyle.FixedSingle;
            txtRute.Location = new Point(500, 60);
            txtRute.Name = "txtRute";
            txtRute.Size = new Size(200, 23);
            txtRute.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 60);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 8;
            label2.Text = "Nama Kereta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 90);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 9;
            label3.Text = "Jenis Kereta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(400, 60);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 10;
            label4.Text = "Rute";
            // 
            // DataKereta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtRute);
            Controls.Add(txtJenisKereta);
            Controls.Add(txtNamaKereta);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "DataKereta";
            Size = new Size(800, 450);
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
        private System.Windows.Forms.TextBox txtNamaKereta;
        private System.Windows.Forms.TextBox txtJenisKereta;
        private System.Windows.Forms.TextBox txtRute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}