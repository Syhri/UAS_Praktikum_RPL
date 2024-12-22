using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Sistem_Pemesanan_Tiket_Kereta
{
    public partial class DataTiket : UserControl
    {
        private string connectionString = "server=localhost;port=3306;username=root;password=;database=uas_rpl";

        public DataTiket()
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
                    MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM tiket", conn);
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
                        MySqlCommand cmd = new MySqlCommand("INSERT INTO tiket (kereta_id, asal, tujuan, waktu_berangkat, waktu_tiba) VALUES (@KeretaId, @Asal, @Tujuan, @WaktuBerangkat, @WaktuTiba)", conn);
                        cmd.Parameters.AddWithValue("@KeretaId", txtKeretaId.Text);
                        cmd.Parameters.AddWithValue("@Asal", txtAsal.Text);
                        cmd.Parameters.AddWithValue("@Tujuan", txtTujuan.Text);
                        cmd.Parameters.AddWithValue("@WaktuBerangkat", dtpWaktuBerangkat.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                        cmd.Parameters.AddWithValue("@WaktuTiba", dtpWaktuTiba.Value.ToString("yyyy-MM-dd HH:mm:ss"));
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
                        MySqlCommand cmd = new MySqlCommand("UPDATE tiket SET kereta_id = @KeretaId, asal = @Asal, tujuan = @Tujuan, waktu_berangkat = @WaktuBerangkat, waktu_tiba = @WaktuTiba WHERE id = @Id", conn);
                        cmd.Parameters.AddWithValue("@Id", dataGridView1.SelectedRows[0].Cells["id"].Value);
                        cmd.Parameters.AddWithValue("@KeretaId", txtKeretaId.Text);
                        cmd.Parameters.AddWithValue("@Asal", txtAsal.Text);
                        cmd.Parameters.AddWithValue("@Tujuan", txtTujuan.Text);
                        cmd.Parameters.AddWithValue("@WaktuBerangkat", dtpWaktuBerangkat.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                        cmd.Parameters.AddWithValue("@WaktuTiba", dtpWaktuTiba.Value.ToString("yyyy-MM-dd HH:mm:ss"));
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
                        MySqlCommand cmd = new MySqlCommand("DELETE FROM tiket WHERE id = @Id", conn);
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
                txtKeretaId.Text = selectedRow.Cells["kereta_id"].Value?.ToString() ?? string.Empty;
                txtAsal.Text = selectedRow.Cells["asal"].Value?.ToString() ?? string.Empty;
                txtTujuan.Text = selectedRow.Cells["tujuan"].Value?.ToString() ?? string.Empty;
                dtpWaktuBerangkat.Value = DateTime.Parse(selectedRow.Cells["waktu_berangkat"].Value?.ToString() ?? DateTime.Now.ToString());
                dtpWaktuTiba.Value = DateTime.Parse(selectedRow.Cells["waktu_tiba"].Value?.ToString() ?? DateTime.Now.ToString());
            }
        }

        private void ClearFields()
        {
            txtKeretaId.Clear();
            txtAsal.Clear();
            txtTujuan.Clear();
            dtpWaktuBerangkat.Value = DateTime.Now;
            dtpWaktuTiba.Value = DateTime.Now;
        }

        private bool IsValidInput()
        {
            if (string.IsNullOrWhiteSpace(txtKeretaId.Text) ||
                string.IsNullOrWhiteSpace(txtAsal.Text) ||
                string.IsNullOrWhiteSpace(txtTujuan.Text) ||
                dtpWaktuBerangkat.Value == null ||
                dtpWaktuTiba.Value == null)
            {
                MessageBox.Show("Mohon isi semua kolom.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}