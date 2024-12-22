using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sistem_Pemesanan_Tiket_Kereta
{
    public partial class MainFormUser : Form
    {
        private string connectionString = "server=localhost;port=3306;username=root;password=;database=uas_rpl";

        public MainFormUser()
        {
            InitializeComponent();
        }

        private void MainFormUser_Load(object sender, EventArgs e)
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

        private void btnSearchTickets_Click(object sender, EventArgs e)
        {
            ShowControl(new DataPencarianTiket());
        }

        private void btnViewBookings_Click(object sender, EventArgs e)
        {
            ShowControl(new DataPemesananTiket());
        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            ShowControl(new UserProfile());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Log out and return to LoginSelectionForm
            this.Hide();
            LoginSelectionForm loginForm = new LoginSelectionForm();
            loginForm.Show();
        }

        private void btnPesan_Click(object sender, EventArgs e)
        {
            if (dgvTiket.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvTiket.SelectedRows[0];
                int tiketId = Convert.ToInt32(selectedRow.Cells["id"].Value);
                FormPesanTiket formPesan = new FormPesanTiket(tiketId);
                formPesan.ShowDialog();
            }
            else
            {
                MessageBox.Show("Pilih tiket yang ingin dipesan terlebih dahulu.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ShowControl(UserControl control)
        {
            pnlContent.Controls.Clear();
            control.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(control);
        }

        private void pnlContent_Paint(object sender, PaintEventArgs e) { }

        private void pnlNavbar_Paint(object sender, PaintEventArgs e) { }
    }
}