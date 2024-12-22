using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace Sistem_Pemesanan_Tiket_Kereta
{
    public partial class DataPemesananTiket : UserControl
    {
        private string connectionString = "server=localhost;port=3306;username=root;password=;database=uas_rpl";

        public DataPemesananTiket()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM pemesanan_terbayar", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}