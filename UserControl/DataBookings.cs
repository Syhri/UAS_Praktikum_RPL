using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sistem_Pemesanan_Tiket_Kereta
{
    public partial class DataBookings : UserControl
    {
        private string connectionString = "server=localhost;port=3306;username=root;password=;database=uas_rpl";

        public DataBookings()
        {
            InitializeComponent();
        }

        private void DataBookings_Load(object sender, EventArgs e)
        {
            LoadDataBookings();
        }

        private void LoadDataBookings()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM bookings WHERE user_id = @UserId";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserId", GetCurrentUserId());

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvBookings.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            if (dgvBookings.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvBookings.SelectedRows[0];
                int pemesananId = Convert.ToInt32(selectedRow.Cells["id"].Value);

                // Open FormPembayaran
                FormPembayaran formPembayaran = new FormPembayaran(pemesananId);
                formPembayaran.ShowDialog();

                // Refresh bookings after payment
                LoadDataBookings();
            }
            else
            {
                MessageBox.Show("Pilih booking yang ingin dibayar.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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