namespace Sistem_Pemesanan_Tiket_Kereta
{
    partial class FormPesanTiket
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
            this.txtNamaPenumpang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtJumlahTiket = new System.Windows.Forms.TextBox();
            this.btnPesan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Penumpang";
            // 
            // txtNamaPenumpang
            // 
            this.txtNamaPenumpang.Location = new System.Drawing.Point(116, 12);
            this.txtNamaPenumpang.Name = "txtNamaPenumpang";
            this.txtNamaPenumpang.Size = new System.Drawing.Size(156, 23);
            this.txtNamaPenumpang.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Jumlah Tiket";
            // 
            // txtJumlahTiket
            // 
            this.txtJumlahTiket.Location = new System.Drawing.Point(116, 50);
            this.txtJumlahTiket.Name = "txtJumlahTiket";
            this.txtJumlahTiket.Size = new System.Drawing.Size(156, 23);
            this.txtJumlahTiket.TabIndex = 3;
            // 
            // btnPesan
            // 
            this.btnPesan.Location = new System.Drawing.Point(116, 90);
            this.btnPesan.Name = "btnPesan";
            this.btnPesan.Size = new System.Drawing.Size(156, 23);
            this.btnPesan.TabIndex = 4;
            this.btnPesan.Text = "Pesan";
            this.btnPesan.UseVisualStyleBackColor = true;
            this.btnPesan.Click += new System.EventHandler(this.btnPesan_Click);
            // 
            // FormPesanTiket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 131);
            this.Controls.Add(this.btnPesan);
            this.Controls.Add(this.txtJumlahTiket);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNamaPenumpang);
            this.Controls.Add(this.label1);
            this.Name = "FormPesanTiket";
            this.Text = "Pesan Tiket";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNamaPenumpang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtJumlahTiket;
        private System.Windows.Forms.Button btnPesan;
    }
}