using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sistem_Pemesanan_Tiket_Kereta
{
    public partial class FormPembayaran : Form
    {
        private string connectionString = "server=localhost;port=3306;username=root;password=;database=uas_rpl";
        private int pemesananId;

        public FormPembayaran(int pemesananId)
        {
            InitializeComponent();
            this.pemesananId = pemesananId;
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            if (IsValidInput())
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand("UPDATE bookings SET metode_pembayaran = @MetodePembayaran, jumlah_bayar = @JumlahBayar, status = 'Dibayar' WHERE id = @PemesananId", conn);
                        cmd.Parameters.AddWithValue("@PemesananId", pemesananId);
                        cmd.Parameters.AddWithValue("@MetodePembayaran", cmbMetodePembayaran.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@JumlahBayar", txtJumlahBayar.Text);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Pembayaran berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error processing payment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool IsValidInput()
        {
            if (string.IsNullOrWhiteSpace(txtJumlahBayar.Text) ||
                cmbMetodePembayaran.SelectedIndex == -1)
            {
                MessageBox.Show("Mohon isi semua kolom.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}