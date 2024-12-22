using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sistem_Pemesanan_Tiket_Kereta
{
    public partial class DataPemesananTiket : UserControl
    {
        private string connectionString = "server=localhost;port=3306;username=root;password=;database=uas_rpl";

        public DataPemesananTiket()
        {
            InitializeComponent();
        }

        private void DataPemesananTiket_Load(object sender, EventArgs e)
        {
            LoadDataTiket();
        }

        private void LoadDataTiket(string searchQuery = "")
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM tiket";
                    if (!string.IsNullOrEmpty(searchQuery))
                    {
                        query += " WHERE nama_kereta LIKE @searchQuery OR rute LIKE @searchQuery";
                    }

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        if (!string.IsNullOrEmpty(searchQuery))
                        {
                            cmd.Parameters.AddWithValue("@searchQuery", "%" + searchQuery + "%");
                        }

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvTiket.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadDataTiket(txtSearch.Text);
        }

        private void btnPesan_Click(object sender, EventArgs e)
        {
            if (dgvTiket.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvTiket.SelectedRows[0];
                int tiketId = Convert.ToInt32(selectedRow.Cells["id"].Value);

                // Example: Assuming you get the passenger name and ticket quantity from TextBoxes or other inputs
                string namaPenumpang = "Nama Penumpang"; // Replace with actual input
                int jumlahTiket = 1; // Replace with actual input

                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand("INSERT INTO bookings (user_id, tiket_id, status, nama_penumpang, jumlah_tiket) VALUES (@UserId, @TiketId, 'Belum Dibayar', @NamaPenumpang, @JumlahTiket)", conn);
                        cmd.Parameters.AddWithValue("@UserId", GetCurrentUserId());
                        cmd.Parameters.AddWithValue("@TiketId", tiketId);
                        cmd.Parameters.AddWithValue("@NamaPenumpang", namaPenumpang);
                        cmd.Parameters.AddWithValue("@JumlahTiket", jumlahTiket);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Pemesanan berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error processing order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Pilih tiket yang ingin dipesan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private int GetCurrentUserId()
        {
            // Implementasikan logika untuk mendapatkan user ID saat ini
            // Misalnya, bisa dari sesi login pengguna
            return 1; // Contoh: mengembalikan user ID 1
        }
    }
}