using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace Sistem_Pemesanan_Tiket_Kereta
{
    public partial class DataPencarianTiket : UserControl
    {
        private string connectionString = "server=localhost;port=3306;username=root;password=;database=uas_rpl";

        public DataPencarianTiket()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData(txtSearch.Text);
        }

        private void LoadData(string searchTerm)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM tiket WHERE asal LIKE @SearchTerm OR tujuan LIKE @SearchTerm";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
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