using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace Sistem_Pemesanan_Tiket_Kereta
{
    public partial class DataTiketTerbit : UserControl
    {
        private string connectionString = "server=localhost;port=3306;username=root;password=;database=uas_rpl";

        public DataTiketTerbit()
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
                    MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM tiket_terbit", conn);
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
                        MySqlCommand cmd = new MySqlCommand("INSERT INTO tiket_terbit (user_id, tiket_id, tanggal_terbit) VALUES (@UserId, @TiketId, @TanggalTerbit)", conn);
                        cmd.Parameters.AddWithValue("@UserId", txtUserId.Text);
                        cmd.Parameters.AddWithValue("@TiketId", txtTiketId.Text);
                        cmd.Parameters.AddWithValue("@TanggalTerbit", dtpTanggalTerbit.Value.ToString("yyyy-MM-dd HH:mm:ss"));
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
                        MySqlCommand cmd = new MySqlCommand("UPDATE tiket_terbit SET user_id = @UserId, tiket_id = @TiketId, tanggal_terbit = @TanggalTerbit WHERE id = @Id", conn);
                        cmd.Parameters.AddWithValue("@Id", dataGridView1.SelectedRows[0].Cells["id"].Value);
                        cmd.Parameters.AddWithValue("@UserId", txtUserId.Text);
                        cmd.Parameters.AddWithValue("@TiketId", txtTiketId.Text);
                        cmd.Parameters.AddWithValue("@TanggalTerbit", dtpTanggalTerbit.Value.ToString("yyyy-MM-dd HH:mm:ss"));
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
                        MySqlCommand cmd = new MySqlCommand("DELETE FROM tiket_terbit WHERE id = @Id", conn);
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
                txtUserId.Text = selectedRow.Cells["user_id"].Value?.ToString() ?? string.Empty;
                txtTiketId.Text = selectedRow.Cells["tiket_id"].Value?.ToString() ?? string.Empty;
                dtpTanggalTerbit.Value = DateTime.Parse(selectedRow.Cells["tanggal_terbit"].Value?.ToString() ?? DateTime.Now.ToString());
            }
        }

        private void ClearFields()
        {
            txtUserId.Clear();
            txtTiketId.Clear();
            dtpTanggalTerbit.Value = DateTime.Now;
        }

        private bool IsValidInput()
        {
            if (string.IsNullOrWhiteSpace(txtUserId.Text) ||
                string.IsNullOrWhiteSpace(txtTiketId.Text) ||
                dtpTanggalTerbit.Value == null)
            {
                MessageBox.Show("Mohon isi semua kolom.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}