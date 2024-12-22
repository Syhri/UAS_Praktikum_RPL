namespace Sistem_Pemesanan_Tiket_Kereta
{
    partial class FormPembayaran
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomorPesanan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMetodePembayaran = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtJumlahBayar = new System.Windows.Forms.TextBox();
            this.btnBayar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nomor Pesanan";
            // 
            // txtNomorPesanan
            // 
            this.txtNomorPesanan.Location = new System.Drawing.Point(106, 12);
            this.txtNomorPesanan.Name = "txtNomorPesanan";
            this.txtNomorPesanan.Size = new System.Drawing.Size(166, 23);
            this.txtNomorPesanan.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Metode Pembayaran";
            // 
            // cmbMetodePembayaran
            // 
            this.cmbMetodePembayaran.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMetodePembayaran.FormattingEnabled = true;
            this.cmbMetodePembayaran.Items.AddRange(new object[] {
            "Kartu Kredit",
            "Transfer Bank",
            "E-Wallet"});
            this.cmbMetodePembayaran.Location = new System.Drawing.Point(125, 47);
            this.cmbMetodePembayaran.Name = "cmbMetodePembayaran";
            this.cmbMetodePembayaran.Size = new System.Drawing.Size(147, 23);
            this.cmbMetodePembayaran.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Jumlah Bayar";
            // 
            // txtJumlahBayar
            // 
            this.txtJumlahBayar.Location = new System.Drawing.Point(88, 82);
            this.txtJumlahBayar.Name = "txtJumlahBayar";
            this.txtJumlahBayar.Size = new System.Drawing.Size(184, 23);
            this.txtJumlahBayar.TabIndex = 5;
            // 
            // btnBayar
            // 
            this.btnBayar.Location = new System.Drawing.Point(197, 121);
            this.btnBayar.Name = "btnBayar";
            this.btnBayar.Size = new System.Drawing.Size(75, 23);
            this.btnBayar.TabIndex = 6;
            this.btnBayar.Text = "Bayar";
            this.btnBayar.UseVisualStyleBackColor = true;
            this.btnBayar.Click += new System.EventHandler(this.btnBayar_Click);
            // 
            // FormPembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.btnBayar);
            this.Controls.Add(this.txtJumlahBayar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbMetodePembayaran);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomorPesanan);
            this.Controls.Add(this.label1);
            this.Name = "FormPembayaran";
            this.Text = "Pembayaran";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomorPesanan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMetodePembayaran;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtJumlahBayar;
        private System.Windows.Forms.Button btnBayar;
    }
}