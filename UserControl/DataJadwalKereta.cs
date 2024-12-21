using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Sistem_Pemesanan_Tiket_Kereta
{
    public partial class DataJadwalKereta : UserControl
    {
        private string connectionString;
        private DataTable dataTable;

        public DataJadwalKereta()
        {
            InitializeComponent();
            connectionString = "server=localhost;port=3306;username=root;password=;database=uas_rpl;";
            dataTable = new DataTable();
        }

        private void DataJadwalKereta_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM jadwal_kereta", conn);
                    dataTable.Clear();
                    da.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsValidInput())
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand("INSERT INTO jadwal_kereta (nama_kereta, asal, tujuan, waktu_berangkat, waktu_tiba) VALUES (@NamaKereta, @Asal, @Tujuan, @WaktuBerangkat, @WaktuTiba)", conn);
                        cmd.Parameters.AddWithValue("@NamaKereta", txtKereta.Text);
                        cmd.Parameters.AddWithValue("@Asal", txtAsal.Text);
                        cmd.Parameters.AddWithValue("@Tujuan", txtTujuan.Text);
                        cmd.Parameters.AddWithValue("@WaktuBerangkat", txtWaktuBerangkat.Text);
                        cmd.Parameters.AddWithValue("@WaktuTiba", txtWaktuTiba.Text);
                        cmd.ExecuteNonQuery();
                    }
                    LoadData();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error adding data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && IsValidInput())
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand("UPDATE jadwal_kereta SET nama_kereta = @NamaKereta, asal = @Asal, tujuan = @Tujuan, waktu_berangkat = @WaktuBerangkat, waktu_tiba = @WaktuTiba WHERE id = @Id", conn);
                        cmd.Parameters.AddWithValue("@Id", dataGridView1.SelectedRows[0].Cells["id"].Value);
                        cmd.Parameters.AddWithValue("@NamaKereta", txtKereta.Text);
                        cmd.Parameters.AddWithValue("@Asal", txtAsal.Text);
                        cmd.Parameters.AddWithValue("@Tujuan", txtTujuan.Text);
                        cmd.Parameters.AddWithValue("@WaktuBerangkat", txtWaktuBerangkat.Text);
                        cmd.Parameters.AddWithValue("@WaktuTiba", txtWaktuTiba.Text);
                        cmd.ExecuteNonQuery();
                    }
                    LoadData();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand("DELETE FROM jadwal_kereta WHERE id = @Id", conn);
                        cmd.Parameters.AddWithValue("@Id", dataGridView1.SelectedRows[0].Cells["id"].Value);
                        cmd.ExecuteNonQuery();
                    }
                    LoadData();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataTable.Clear();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                txtKereta.Text = selectedRow.Cells["Nama Kereta"].Value?.ToString() ?? string.Empty;
                txtAsal.Text = selectedRow.Cells["Asal"].Value?.ToString() ?? string.Empty;
                txtTujuan.Text = selectedRow.Cells["Tujuan"].Value?.ToString() ?? string.Empty;
                txtWaktuBerangkat.Text = selectedRow.Cells["Waktu Berangkat"].Value?.ToString() ?? string.Empty;
                txtWaktuTiba.Text = selectedRow.Cells["Waktu Tiba"].Value?.ToString() ?? string.Empty;
            }
        }

        private void ClearFields()
        {
            txtKereta.Clear();
            txtAsal.Clear();
            txtTujuan.Clear();
            txtWaktuBerangkat.Clear();
            txtWaktuTiba.Clear();
        }

        private bool IsValidInput()
        {
            if (string.IsNullOrWhiteSpace(txtKereta.Text) ||
                string.IsNullOrWhiteSpace(txtAsal.Text) ||
                string.IsNullOrWhiteSpace(txtTujuan.Text) ||
                string.IsNullOrWhiteSpace(txtWaktuBerangkat.Text) ||
                string.IsNullOrWhiteSpace(txtWaktuTiba.Text))
            {
                MessageBox.Show("Please ensure all fields are filled correctly.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void txtKereta_TextChanged(object sender, EventArgs e)
        {
            // Implementasi logika yang diperlukan saat teks pada txtKereta berubah
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}