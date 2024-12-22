using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sistem_Pemesanan_Tiket_Kereta
{
    public partial class FormPesanTiket : Form
    {
        private string connectionString = "server=localhost;port=3306;username=root;password=;database=uas_rpl";
        private int tiketId;

        public FormPesanTiket(int tiketId)
        {
            InitializeComponent();
            this.tiketId = tiketId;
        }

        private void btnPesan_Click(object sender, EventArgs e)
        {
            if (IsValidInput())
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand("INSERT INTO bookings (tiket_id, nama_penumpang, jumlah_tiket) VALUES (@TiketId, @NamaPenumpang, @JumlahTiket)", conn);
                        cmd.Parameters.AddWithValue("@TiketId", tiketId);
                        cmd.Parameters.AddWithValue("@NamaPenumpang", txtNamaPenumpang.Text);
                        cmd.Parameters.AddWithValue("@JumlahTiket", txtJumlahTiket.Text);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Tiket berhasil dipesan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error processing booking: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool IsValidInput()
        {
            if (string.IsNullOrWhiteSpace(txtNamaPenumpang.Text) ||
                string.IsNullOrWhiteSpace(txtJumlahTiket.Text))
            {
                MessageBox.Show("Mohon isi semua kolom.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}