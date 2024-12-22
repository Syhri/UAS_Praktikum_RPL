
namespace Sistem_Pemesanan_Tiket_Kereta
{
    partial class DataBookings
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
            dgvBookings = new DataGridView();
            btnBayar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).BeginInit();
            SuspendLayout();
            // 
            // dgvBookings
            // 
            dgvBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookings.Location = new Point(15, 15);
            dgvBookings.Name = "dgvBookings";
            dgvBookings.Size = new Size(760, 350);
            dgvBookings.TabIndex = 0;
            dgvBookings.CellContentClick += this.dgvBookings_CellContentClick;
            // 
            // btnBayar
            // 
            btnBayar.Location = new Point(700, 380);
            btnBayar.Name = "btnBayar";
            btnBayar.Size = new Size(75, 23);
            btnBayar.TabIndex = 1;
            btnBayar.Text = "Bayar";
            btnBayar.UseVisualStyleBackColor = true;
            btnBayar.Click += btnBayar_Click;
            // 
            // DataBookings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnBayar);
            Controls.Add(dgvBookings);
            Name = "DataBookings";
            Size = new Size(800, 450);
            Load += DataBookings_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBookings).EndInit();
            ResumeLayout(false);
        }

        private void dgvBookings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBookings;
        private System.Windows.Forms.Button btnBayar;
    }
}