using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Sistem_Pemesanan_Tiket_Kereta
{
    public partial class DataKereta : UserControl
    {
        private string connectionString = "server=localhost;port=3306;username=root;password=;database=uas_rpl";

        public DataKereta()
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
                    MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM kereta", conn);
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsValidInput())
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand("INSERT INTO kereta (nama_kereta, jenis_kereta, rute) VALUES (@NamaKereta, @JenisKereta, @Rute)", conn);
                        cmd.Parameters.AddWithValue("@NamaKereta", txtNamaKereta.Text);
                        cmd.Parameters.AddWithValue("@JenisKereta", txtJenisKereta.Text);
                        cmd.Parameters.AddWithValue("@Rute", txtRute.Text);
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && IsValidInput())
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand("UPDATE kereta SET nama_kereta = @NamaKereta, jenis_kereta = @JenisKereta, rute = @Rute WHERE id = @Id", conn);
                        cmd.Parameters.AddWithValue("@Id", dataGridView1.SelectedRows[0].Cells["id"].Value);
                        cmd.Parameters.AddWithValue("@NamaKereta", txtNamaKereta.Text);
                        cmd.Parameters.AddWithValue("@JenisKereta", txtJenisKereta.Text);
                        cmd.Parameters.AddWithValue("@Rute", txtRute.Text);
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
                        MySqlCommand cmd = new MySqlCommand("DELETE FROM kereta WHERE id = @Id", conn);
                        cmd.Parameters.AddWithValue("@Id", dataGridView1.SelectedRows[0].Cells["id"].Value);
                        cmd.ExecuteNonQuery();
                    }
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                txtNamaKereta.Text = selectedRow.Cells["nama_kereta"].Value?.ToString() ?? string.Empty;
                txtJenisKereta.Text = selectedRow.Cells["jenis_kereta"].Value?.ToString() ?? string.Empty;
                txtRute.Text = selectedRow.Cells["rute"].Value?.ToString() ?? string.Empty;
            }
        }

        private void ClearFields()
        {
            txtNamaKereta.Clear();
            txtJenisKereta.Clear();
            txtRute.Clear();
        }

        private bool IsValidInput()
        {
            if (string.IsNullOrWhiteSpace(txtNamaKereta.Text) ||
                string.IsNullOrWhiteSpace(txtJenisKereta.Text) ||
                string.IsNullOrWhiteSpace(txtRute.Text))
            {
                MessageBox.Show("Mohon isi semua kolom.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void txtNamaKereta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}